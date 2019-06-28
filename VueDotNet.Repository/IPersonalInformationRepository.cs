using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VueDotNet.DAL.Entities;

namespace VueDotNet.Repository
{
    public interface IPersonalInformationRepository
    {
        Task Save(PersonalInformation personInfo);
    }
}
