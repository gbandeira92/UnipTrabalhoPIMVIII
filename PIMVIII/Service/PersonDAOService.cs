using Microsoft.EntityFrameworkCore;
using PIMVIII.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PIMVIII.Service
{
    public class PersonDAOService
    {
        private readonly MainContext _mainContext;

        public PersonDAOService(MainContext mainContext)
        {
            _mainContext = mainContext;
        }

        public List<Person> GetAll()
        {
            return _mainContext.Person.Include(x => x.Nome).ToList();
        }

        public void Insert(Person person)
        {
            _mainContext.Add(person);
            _mainContext.SaveChanges();
        }

        public Person Update(Person person)
        {
            var result = _mainContext.Person.Where(c => c.Id == person.Id).FirstOrDefault();
            if (result != null)
            {
                result.Nome = person.Nome;
                _mainContext.Update(result);
                _mainContext.SaveChanges();
                return result;
            }
            return person;
        }

        public void Delete(Person cliente)
        {
            _mainContext.Remove(cliente);
            _mainContext.SaveChanges();
        }

        public Person GetByID(int id)
        {
            var result = _mainContext.Person.Find(id);
            return result;
        }

    }
}
