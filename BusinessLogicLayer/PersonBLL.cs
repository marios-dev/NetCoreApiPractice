using NetCoreApiPractice.Repository;
using NetCoreApiPractice.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogicLayer
{
    public class PersonBLL
    {
        private DataAccessLayer.PersonDAL _DAL;
        public PersonBLL()
        {
            _DAL = new DataAccessLayer.PersonDAL();
        }
        public List<Person> GetAllPersons()
        {
            var data = _DAL.GetAllPersons();
            return data;
        }
        public Person GetPersonById(int id)
        {
            var data = _DAL.GetPersonById(id);
            if (data == null)
            {
                throw new Exception("Invalid ID");
            }
            return data;
        }
    }
}
