using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using AnimalShelter.Models;
using AnimalShelter.Helpers;

namespace AnimalShelter.Services
{
  public interface IUserService
  {
    User Auth(string username, string password);
    IEnumerable<User> GetAll();
  }

  public class UserService : IUserService
  {
    private readonly AppSettings _appSettings;
    private AnimalShelterContext _db;

    public UserService(IOptions<AppSettings> appSettings, AnimalShelterContext db)
    {
      _appSettings = appSettings.Value;
      _db = db;
    }

    public User Auth(string username, string password)
    {
      var user = _db.Users.SingleOrDefault(x => x.UserName == username && x.Password == password);
      
      if (user == null)
        return null;

      // Auth success, generate JWT token
      var tokenHandler = new JwtSecurityTokenHandler();
      var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
      var tokenDescriptor = new SecurityTokenDescriptor
      {
        Subject = new ClaimsIdentity(new Claim[]
          {
            new Claim(ClaimTypes.Name, user.Id.ToString())
          }),
        Expires = DateTime.UtcNow.AddDays(7),
        SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
      };
      var token = tokenHandler.CreateToken(tokenDescriptor);
      user.Token = tokenHandler.WriteToken(token);

      user.Password = null;
      return user;
    }
    public IEnumerable<User> GetAll()
    {
      List<User> u = new List<User> { };
      u = _db.Users.ToList();
      return u.Select(x =>
      {
        x.Password = null;
        return x;
      });
    }
  }
}