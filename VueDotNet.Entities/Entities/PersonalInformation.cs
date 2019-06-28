using System.ComponentModel.DataAnnotations;

namespace VueDotNet.DAL.Entities
{
    public class PersonalInformation
    {
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
    }
}
