using SampleArch.Model;
using System.Data.Entity;
using System.Linq;

namespace SampleArch.Repository
{
    public class CountryRepository : GenericRepository<Country>, ICountryRepository
    {
        public CountryRepository(DbContext context)
              : base(context)
        {
        }

        public Country GetById(int id) => FindBy(x => x.Id == id).FirstOrDefault();
    }
}