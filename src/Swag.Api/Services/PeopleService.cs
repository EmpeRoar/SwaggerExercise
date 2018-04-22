using System.Collections.Generic;
using Swag.Api.Models;
using Swag.Api.Repositories;

namespace Swag.Api.Services
{
    public class PeopleService : IPeopleService
    {
        private readonly IRepository<Person> _peopleRepository;
        public PeopleService(IRepository<Person> peopleRepository){
            _peopleRepository = peopleRepository;
        }
        public ICollection<Person> GetPeople()
        {
            return _peopleRepository.GetAll();
        }
    }
}