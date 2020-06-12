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
    
  }
}