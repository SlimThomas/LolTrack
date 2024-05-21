using LolTrack.Models;
using Microsoft.AspNetCore.Identity;

namespace LolTrack.MockData
{
    public class MockUser
    {
        private static PasswordHasher<string> _passwordHasher = new PasswordHasher<string>();

        private static List<User> users = new List<User>()
        {
            new User("Thomas", _passwordHasher.HashPassword(null, "123"), "ThomasProfileSplash.png", 2),
            new User("Martin", _passwordHasher.HashPassword(null, "123"), "MartinProfileSplash.png", 1),
            new User("Henrik", _passwordHasher.HashPassword(null, "123"), "HenrikProfileSplash.png", 3),
            new User("Mikkel", _passwordHasher.HashPassword(null, "123"), "MikkelProfileSplash.jpg", 4),
            new User("Censor", _passwordHasher.HashPassword(null, "123"), "CensorProfileSplash.png", 5)
        }; 


        public static List<User> GetMockUser()
        {
            return users; 
        }
    }
}
