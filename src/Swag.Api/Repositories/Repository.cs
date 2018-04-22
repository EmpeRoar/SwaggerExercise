using System.Collections.Generic;

namespace Swag.Api.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public Repository(){

        }
        public ICollection<T> GetAll()
        {
            return new List<T>();
        }
    }
}