using LolTrack.MockData;
using LolTrack.Models;
using System.Runtime.CompilerServices;

namespace LolTrack.Services
{
    public class UserService
    {
        public List<User> _users { get; }
        private DbService _dbService; 

        public UserService(DbService dbService)
        {
            _users = MockUser.GetMockUser();
            _dbService = dbService;
            //_dbService.SaveUsers(_users);
            //_users = _dbService.GetUsers().Result;

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
