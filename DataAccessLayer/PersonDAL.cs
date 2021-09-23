using NetCoreApiPractice.Repository;
using NetCoreApiPractice.Repository.Entities;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessLayer
{
    public class PersonDAL
    {
        public List<Person> GetAllPersons()
        {
            var db = new PersonDbContext();
            return db.People.ToList();
        }
        public Person GetPersonById(int id)
        {
            var db = new PersonDbContext();
            Person p = new Person();
            p = db.People.FirstOrDefault(p => p.Id == id);
            return p;
        }
    }
}
