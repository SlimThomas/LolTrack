using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LolTrack.Models
{
    public class User
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserID { get; set; }

        [Required(ErrorMessage = "Username må maks være på 20 tegn"), StringLength(20)]
        public string UserName { get; set; }
        [Required]
        public string Passwrod { get; set; }

        public User(string userName, string passwrod)
        {
            
            UserName = userName;
            Passwrod = passwrod;
        }

        public User() 
        {
            
        }

    }
}
