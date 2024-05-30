using LolTrack.MockData;
using LolTrack.Models;
using System.Runtime.CompilerServices;

namespace LolTrack.Services
{
    public class UserService
    {
        public List<User> _users { get; }
        private JsonFileService<User> _fileService;
        private DbService _dbService; 

        public UserService(DbService dbService, JsonFileService<User> fileService)
        {
            //_users = MockUser.GetMockUser();

            _fileService = fileService;
            _users = _fileService.GetJsonObjects().ToList();
            _dbService = dbService;
            //_fileService.SaveJsonObjects(_users);
            //_users = _dbService.GetUsers().Result;
            _dbService.SaveUsers(_users);

        }

        public async Task AddUserAsync (User user)
        {
            _users.Add(user);
            _fileService.SaveJsonObjects(_users);
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
