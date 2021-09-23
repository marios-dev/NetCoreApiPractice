using NetCoreApiPractice.Repository;
using NetCoreApiPractice.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using BusinessLogicLayer.Models;

namespace BusinessLogicLayer
{
    public class PersonBLL
    {
        private DataAccessLayer.PersonDAL _DAL;
        private Mapper _Personmapper;
        public PersonBLL()
        {
            _DAL = new DataAccessLayer.PersonDAL();
            var _configPerson = new MapperConfiguration(cfg => cfg.CreateMap<Person, PersonModel>().ReverseMap());
            _Personmapper = new Mapper(_configPerson);
        }
        public List<PersonModel> GetAllPersons()
        {
            List<Person> personsFromDB = _DAL.GetAllPersons();
            List<PersonModel> personsModel = _Personmapper.Map<List<Person>, List<PersonModel>>(personsFromDB);
            return personsModel;
        }
        public PersonModel GetPersonById(int id)
        {
            var personEntity = _DAL.GetPersonById(id);
            PersonModel personModel = _Personmapper.Map<Person, PersonModel>(personEntity);
            return personModel;
        }
        public void postPerson(PersonModel personModel)
        {
            Person personEntity = _Personmapper.Map<PersonModel, Person>(personModel);
            _DAL.postPerson(personEntity);
        }
    }
}
