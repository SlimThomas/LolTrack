using LolTrack.MockData;
using LolTrack.Models;

namespace LolTrack.Services
{
    public class AbilityService
    {
        private List<Ability> _abilities;

        public AbilityService()
        {
            _abilities = MockAbility.GetMockAbilities();
        }
        public void AddAbility(Ability abi)
        {
            _abilities.Add(abi);
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
