using System.Collections.Generic;
using System.Linq;
using Swag.Api.Models;

namespace Swag.Api.Repositories
{
    public class PeopleRepository : Repository<Person>
    {
        public PeopleRepository(){

        }
        public ICollection<Person> GetAll()
        {

            return new List<Person>{
                 new Person(){
                    FirstName = "Julius"
                 },
                 new Person(){
                     FirstName = "Elvie"
                 }
            };
        }
    }
}