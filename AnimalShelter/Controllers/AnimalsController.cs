﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimalShelter.Models;

namespace AnimalShelter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        private AnimalShelterContext _db;

        public AnimalsController(AnimalShelterContext db)
        {
            _db = db;
        }

        // GET api/animals
        [HttpGet]
        public ActionResult<IEnumerable<Animal>> Get(string name, string species, string family, string gender, string mass, string diet, string period, string preferredfood)
        {
            var query = _db.Animals.AsQueryable();
            if (name != null)
            {
                query = query.Where(entry => entry.Name == name);
            }
            if (species != null)
            {
                query = query.Where(entry => entry.Species == species);
            }
            if (family != null)
            {
                query = query.Where(entry => entry.Family == family);
            }
            if (gender != null)
            {
                query = query.Where(entry => entry.Gender == gender);
            }
            if (mass != null)
            {
                query = query.Where(entry => entry.Mass == mass);
            }
            if (diet != null)
            {
                query = query.Where(entry => entry.Diet == diet);
            }
            if (period != null)
            {
                query = query.Where(entry => entry.Period == period);
            }
            if (preferredfood != null)
            {
                query = query.Where(entry => entry.PreferredFood == preferredfood);
            }
            return query.ToList();
        }

        // GET api/animals/5
        [HttpGet("{id}")]
        public ActionResult<Animal> Get(int id)
        {
            return _db.Animals.FirstOrDefault(entry => entry.AnimalId == id);
        }

        // POST api/animals
        [HttpPost]
        public void Post([FromBody] Animal animal)
        {
            _db.Animals.Add(animal);
            _db.SaveChanges();
        }

        // PUT api/animals/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Animal animal)
        {
            animal.AnimalId = id;
            _db.Entry(animal).State = EntityState.Modified;
            _db.SaveChanges();
        }

        // DELETE api/animals/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var animalToDelete = _db.Animals.FirstOrDefault(entry => entry.AnimalId == id);
            _db.Animals.Remove(animalToDelete);
            _db.SaveChanges();
        }
    }
}
