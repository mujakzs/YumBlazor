using System.ComponentModel.DataAnnotations;

namespace YumBlazor.Data
{
    public class UserInfo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter your First name...")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Please enter your Last name...")]

        public string? LastName { get; set; }

        [Required(ErrorMessage = "Please enter your Email...")]

        public string? Email { get; set; }


        [Required(ErrorMessage = "Please enter your Number...")]

        public string? Phone { get; set; }
    }
}
