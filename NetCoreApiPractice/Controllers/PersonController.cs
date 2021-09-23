using Microsoft.AspNetCore.Mvc;
using NetCoreApiPractice.Repository;
using NetCoreApiPractice.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NetCoreApiPractice.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private BusinessLogicLayer.PersonBLL _BLL;
        public PersonController()
        {
            _BLL = new BusinessLogicLayer.PersonBLL();
        }
        [HttpGet]
        [Route("getPersons")]
        public List<Person> GetAllPersons()
        {
            return _BLL.GetAllPersons();
        }

        [HttpGet]
        [Route("getPerson")]
        public ActionResult <Person> GetPersonById(int id)
        {
            var person= _BLL.GetPersonById(id);
            if (person==null)
            {
                return NotFound("Invalid ID");
            }
            return Ok(person);
        }

        [Route("postPerson")]
        [HttpDelete]
        public void postPerson([FromBody] Person p)
        {
            var db = new PersonDbContext();
            db.Add(p);
            db.SaveChanges();
        }

        [Route("deletePerson")]
        [HttpDelete]
        public void DeletePerson(int id)
        {
            var db = new PersonDbContext();
            var person=db.People.FirstOrDefault(p => p.Id == id);
            if (person==null)
            {
                throw new Exception("Not found");
            }
            db.People.Remove(person);
            db.SaveChanges();
        }
    }
}
