using LolTrack.Models;

namespace LolTrack.MockData
{
    public class MockAbility
    {
        private static List<Ability> _abilities = new List<Ability>()
        {
            new Ability(1, 1, "The Darkin Blade", "Aatrox slams his greatsword down, dealing 10/25/40/55/70 (+60/67.5/75/82.5/90% Attack Damage) physical damage (minions take 55/60/65/70% damage). The Darkin Blade may be re-cast 2 additional times, each one increasing the damage by 25%.\r\n\r\nEach strike can hit with the Edge, briefly knocking enemies up for 0.25 seconds and dealing 60% more damage.", "AatroxQ.png"),
            new Ability(2, 1, "Infernal Chains","Aatrox smashes the ground, dealing 30/40/50/60/70 (+40 total attack damage) magic damage to the first enemy hit and slowing by 25/27.5/30/32.5/35% for 1.5 seconds.\r\n\r\nChampions or Large Monsters have 1.5s to leave the impact area or be dragged back and damaged again.","AatroxW.png"),
            new Ability(3, 1, "Umbral Dash","Passive: Aatrox gains 18/19.5/21/22.5/24% Omnivamp against champions, increased to 20/24/28/32/36% Omnivamp during World Ender.\r\n\r\nActive: Aatrox dashes. He can use this Ability while winding up his other Abilities.","AatroxE.png"),
            new Ability(4, 1, "World Ender","After 0.25 Aatrox reveals his true demonic form for 10 seconds. On activation, he fears nearby enemy minions for 3 seconds and gains 60/80/100 Movement Speed, decaying over the duration. While World Ender persists, he gains 20/32.5/45% Attack Damage and increases self healing by 25/35/45%.\r\n\r\nOn enemy champion takedown, World Ender is extended by 5 seconds.","AatroxR.png"),
        };
        public static List<Ability> GetMockAbilities() { return _abilities; }
    }
}
