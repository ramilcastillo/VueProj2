using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VueDotNet.DAL;
using VueDotNet.DAL.Entities;

namespace VueDotNet.Repository.Repositories
{
    public class PersonalInformationRepository : IPersonalInformationRepository
    {
        private readonly VueDotNetContext _context;
        public PersonalInformationRepository(VueDotNetContext context)
        {
            _context = context;
        }

        public async  Task Save(PersonalInformation personInfo)
        {
            await _context.PersonalInformation.AddAsync(personInfo);
            await _context.SaveChangesAsync();
        }
    }
}
