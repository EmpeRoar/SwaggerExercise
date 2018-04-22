using System.Collections.Generic;
using System.Linq;

namespace Swag.Api.Repositories
{
    public interface IRepository<T>
    {
         ICollection<T> GetAll();
    }
}