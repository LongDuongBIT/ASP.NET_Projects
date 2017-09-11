using SampleArch.Model;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace SampleArch.Repository
{
    public class PersonRepository : GenericRepository<Person>, IPersonRepository
    {
        public PersonRepository(DbContext context)
            : base(context)
        {
        }

        public override IEnumerable<Person> GetAll() => _entities.Set<Person>().Include(x => x.Country).AsEnumerable();

        public Person GetById(long id) => _dbset.Include(x => x.Country).FirstOrDefault(x => x.Id == id);
    }
}