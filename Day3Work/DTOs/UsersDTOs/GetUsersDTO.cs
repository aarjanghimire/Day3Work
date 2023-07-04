using System.ComponentModel.DataAnnotations;

namespace Day3Work.DTOs.UsersDTOs
{
    public class GetUsersDTO {


        public string Username { get; set; }
        public string Email { get; set; }
        [Key]
        public int UserID { get; set; }

    }
}
