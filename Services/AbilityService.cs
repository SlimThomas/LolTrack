using LolTrack.MockData;
using LolTrack.Models;
using System.Data.Common;

namespace LolTrack.Services
{
    public class AbilityService
    {
        private List<Ability> _abilities;
        private JsonFileService<Ability> _fileService;
        private DbService _dbService;

        public AbilityService(DbService dbService, JsonFileService<Ability> fileService)
        {
            //_abilities = MockAbility.GetMockAbilities();
            _dbService = dbService;
            //_dbService.SaveAbilities(_abilities);
            _fileService = fileService;
            _abilities = _fileService.GetJsonObjects().ToList();
            _fileService.SaveJsonObjects(_abilities);
            //_abilities = _dbService.GetAbilities().Result;

        }
        public void AddAbility(Ability abi)
        {
            _abilities.Add(abi);
            _fileService.SaveJsonObjects(_abilities);
            _dbService.AddAbility(abi);
        }
        public Ability GetAbility(int id)
        {
            foreach (Ability abi in _abilities)
            {
                if (abi.AbiID == id) return abi;
            }
            return null;
        }
        public List<Ability> GetAbilities()
        {
            return _abilities;
        }
    }
}
