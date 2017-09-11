using SampleArch.Model;

namespace SampleArch.Service
{
    public interface ICountryService : IEntityService<Country>
    {
        Country GetById(int Id);
    }
}