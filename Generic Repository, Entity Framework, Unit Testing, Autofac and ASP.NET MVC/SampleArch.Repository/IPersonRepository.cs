using SampleArch.Model;

namespace SampleArch.Repository
{
    public interface IPersonRepository : IGenericRepository<Person>
    {
        Person GetById(long id);
    }
}