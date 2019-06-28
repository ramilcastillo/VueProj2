namespace VueDotNet.DTO
{
    public class PersonalInformationViewModel
    {
        public PersonalInformationDetail PersonalInfo { get; set; }
    }

    public class PersonalInformationDetail
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
    }
}
