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
        public Player player { get; set; }
        public int UserPlayerID { get; set; }
        [Required]
        public string Password { get; set; }
        public string ProfileSplash { get; set; }



        public ICollection<Match> Matches { get; set; } = new List<Match>();
        public User(string userName, string password, string profileSplash, int userplayerid)
        {
            
            UserName = userName;
            Password = password;
            ProfileSplash = profileSplash;
            UserPlayerID = userplayerid;
        }

        public User() 
        {
            
        }

    }
}
