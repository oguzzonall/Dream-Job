namespace CareerPortal.Core.Dtos.Concrete.User
{
    public class UserForRegisterDto : Dto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
