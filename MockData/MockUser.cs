using LolTrack.Models;
using Microsoft.AspNetCore.Identity;

namespace LolTrack.MockData
{
    public class MockUser
    {
        private static PasswordHasher<string> _passwordHasher = new PasswordHasher<string>();

        private static List<User> users = new List<User>()
        {
            new User("Thomas", _passwordHasher.HashPassword(null, "123")),
            new User("Martin", _passwordHasher.HashPassword(null, "123")),
            new User("Henrik", _passwordHasher.HashPassword(null, "123")),
            new User("Mikkel", _passwordHasher.HashPassword(null, "123")),
            new User("Censor", _passwordHasher.HashPassword(null, "123"))
        }; 


        public static List<User> GetMockUser()
        {
            return users; 
        }
    }
}
