using SampleArch.Model;
using SampleArch.Repository;

namespace SampleArch.Service
{
    public class PersonService : EntityService<Person>, IPersonService
    {
        private IPersonRepository _personRepository;
        private IUnitOfWork _unitOfWork;

        public PersonService(IUnitOfWork unitOfWork, IPersonRepository personRepository)
            : base(unitOfWork, personRepository)
        {
            _unitOfWork = unitOfWork;
            _personRepository = personRepository;
        }

        public Person GetById(long Id) => _personRepository.GetById(Id);
    }
}