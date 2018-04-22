using System.Collections.Generic;
using Swag.Api.Models;

namespace Swag.Api.Services
{
    public interface IPeopleService
    {
         ICollection<Person> GetPeople();
    }
}