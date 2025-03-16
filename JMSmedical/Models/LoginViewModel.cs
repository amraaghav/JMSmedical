using System.ComponentModel.DataAnnotations;

namespace JMSmedical.Models
{
    public class LoginViewModel
    {
        public LoginViewModel(string username)
        {
            Username = username;
        }

        public required string Username { get; set; }

        [Required, DataType(DataType.Password)]
        public required string Password { get; set; }
    }
}
