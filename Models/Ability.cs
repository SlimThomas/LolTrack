namespace LolTrack.Models
{
    public class Ability
    {
        public int AbiID { get; set; }
        public int AbiChampID { get; set; }
        public string AbilityName { get; set; }
        public string AbilityDesc { get; set; }
        public string AbilitySplash { get; set; }

        public Ability(int abiID, int abiChampID, string abilityName, string abilityDesc, string abilitySplash)
        {
            AbiChampID = abiChampID;
            AbiID = abiID;
            AbilityName = abilityName;
            AbilityDesc = abilityDesc;
            AbilitySplash = abilitySplash;
        }

        public Ability()
        {
        }
    }
}
