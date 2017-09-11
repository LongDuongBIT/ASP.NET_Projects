using SampleArch.Model;
using SampleArch.Repository;

namespace SampleArch.Service
{
    public class CountryService : EntityService<Country>, ICountryService
    {
        private ICountryRepository _countryRepository;
        private IUnitOfWork _unitOfWork;

        public CountryService(IUnitOfWork unitOfWork, ICountryRepository countryRepository)
            : base(unitOfWork, countryRepository)
        {
            _unitOfWork = unitOfWork;
            _countryRepository = countryRepository;
        }

        public Country GetById(int Id) => _countryRepository.GetById(Id);
    }
}