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
    }
}
