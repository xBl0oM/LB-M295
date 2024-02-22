using System.ComponentModel.DataAnnotations;

namespace Floorballer
{
    public class User
    {
        [Key]
        public string Username { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
    }
}
