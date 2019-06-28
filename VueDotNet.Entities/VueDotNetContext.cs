using Microsoft.EntityFrameworkCore;
using VueDotNet.DAL.Entities;

namespace VueDotNet.DAL
{
    public class VueDotNetContext: DbContext
    {
        public VueDotNetContext(DbContextOptions<VueDotNetContext> options)
            : base(options)
        {
                
        }
        public virtual DbSet<PersonalInformation> PersonalInformation { get; set; }
    }
}
