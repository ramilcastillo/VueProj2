using AutoMapper;
using System.Threading.Tasks;
using VueDotNet.DAL.Entities;
using VueDotNet.DTO;
using VueDotNet.Repository;

namespace VueDotNet.Services.BusinessLogic
{
    public class PersonalInformationBusinessLogic: IPersonalInformationBusinessLogic
    {
        private readonly IPersonalInformationRepository _repository;
        private readonly IMapper _mapper;

        public PersonalInformationBusinessLogic(IPersonalInformationRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Save(PersonalInformationViewModel viewModel)
        {
            //var personInfo = _mapper.Map<PersonalInformationViewModel, PersonalInformation>(viewModel);
            var personInfo = new PersonalInformation
            {
                Age = viewModel.PersonalInfo.Age,
                Email =  viewModel.PersonalInfo.Email,
                FullName = viewModel.PersonalInfo.FullName,
                Gender = viewModel.PersonalInfo.Gender
            };
            await _repository.Save(personInfo);
        }
    }
}
