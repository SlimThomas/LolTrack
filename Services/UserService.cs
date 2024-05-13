using LolTrack.MockData;
using LolTrack.Models;
using System.Runtime.CompilerServices;

namespace LolTrack.Services
{
    public class UserService
    {
        public List<User> _users { get; } 

        public UserService()
        {
            _users = MockUser.GetMockUser(); 

        }

        public async Task AddUserAsync (User user)
        {
            _users.Add(user); 
        }

        public User GetUserByUsername (string username)
        {
            foreach (var user in _users)
            {
                if (user.UserName == username) return user;
            }
            return null; 
        }

    }
}
