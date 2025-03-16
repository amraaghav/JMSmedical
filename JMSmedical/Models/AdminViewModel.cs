using System.ComponentModel.DataAnnotations;

namespace JMSmedical.Models
{
    public class AdminViewModel
    {
        [Required, EmailAddress]
        public required string Email { get; set; }

        [Required, DataType(DataType.Password)]
        public required string Password { get; set; }
    }
}
