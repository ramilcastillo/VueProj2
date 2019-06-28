using System.Threading.Tasks;
using VueDotNet.DTO;

namespace VueDotNet.Services
{
    public interface IPersonalInformationBusinessLogic
    {
        Task Save(PersonalInformationViewModel viewModel);
    }
}
