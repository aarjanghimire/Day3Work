using System.ComponentModel.DataAnnotations;

namespace Day3Work.Models
{
    public class Users
    {
        [Key]
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
