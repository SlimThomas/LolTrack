using LolTrack.EFDBContext;
using LolTrack.Models;
using Microsoft.EntityFrameworkCore;

//namespace LolTrack.Services
//{
    //public class DBService
    //{
//        public async Task<Player> GetPlayers()
//        {
//            using (var context = new LolDbContext())
//            {
//                return await context.Players.ToListAsync();
//            }
//        } 
//        public async Task<Ability> GetAbilities()
//        {
//            using (var context = new LolDbContext())
//            {
//                return await context.Abilities.ToListAsync();
//            }
//        }
//        public async Task<Champion> GetChampions()
//        {
//            using (var context = new LolDbContext())
//            {
//                return await context.Champions.ToListAsync();
//            }
//        }
//        public async Task<Match> GetMatches()
//        {
//            using (var context = new LolDbContext())
//            {
//                return await context.Matches.ToListAsync();
//            }
//        }
//        public async Task<Rune> GetRunes()
//        {
//            using (var context = new LolDbContext())
//            {
//                return await context.Runes.ToListAsync();
//            }
//        }
//        public async Task<SSpell> GetSspells()
//        {
//            using (var context = new LolDbContext())
//            {
//                return await context.SSpells.ToListAsync();
//            }
//        }
//        public async Task<List<Item>> GetItems()
//        {
//            using (var context = new LolDbContext())
//            {
//                return await context.Items.ToListAsync();
//            }
//        }
//        public async Task<List<User>> GetUsers()
//        {
//            using (var context = new LolDbContext())
//            {
//                return await context.Users.ToListAsync();
//            }
//        }
//        public async Task AddAbility(Ability ability)
//        {
//            using (var context = new LolDbContext())
//            {
//                context.Abilities.Add(ability);
//                context.SaveChanges();
//            }
//        }
//        public async Task AddChampion(Champion champ)
//        {
//            using (var context = new LolDbContext())
//            {
//                context.Champions.Add(champ);
//                context.SaveChanges();
//            }
//        }
//        public async Task AddMatch(Match match)
//        {
//            using (var context = new LolDbContext())
//            {
//                context.Matches.Add(match);
//                context.SaveChanges();
//            }
//        }
//        public async Task AddPlayer(Player player)
//        {
//            using (var context = new LolDbContext())
//            {
//                context.Players.Add(player);
//                context.SaveChanges();
//            }
//        }
//        public async Task AddRune(Rune rune)
//        {
//            using (var context = new LolDbContext())
//            {
//                context.Runes.Add(rune);
//                context.SaveChanges();
//            }
//        }
//        public async Task AddSSpell(SSpell sSpell)
//        {
//            using (var context = new LolDbContext())
//            {
//                context.SSpells.Add(sSpell);
//                context.SaveChanges();
//            }
//        }
//        public async Task AddItem(Item item)
//        {
//            using (var context = new LolDbContext())
//            {
//                context.Items.Add(item);
//                context.SaveChanges();
//            }
//        }
//        public async Task AddUser(User user)
//        {
//            using (var context = new LolDbContext())
//            {
//                context.Users.Add(user);
//                context.SaveChanges();
//            }
//        }
//        public async Task SaveAbilities(List<Ability> abilities)
//        {
//            using (var context = new LolDbContext())
//            {
//                foreach (Ability abi in abilities)
//                {
//                    context.Items.Add(abi);
//                    context.SaveChanges();
//                }
//                context.SaveChanges();
//            }
//        }
//        public async Task SaveChampions(List<Champion> champs)
//        {
//            using (var context = new LolDbContext())
//            {
//                foreach (Champion champ in champs)
//                {
//                    context.Items.Add(champ);
//                    context.SaveChanges();
//                }
//                context.SaveChanges();
//            }
//        }
//        public async Task SaveMatches(List<Match> matches)
//        {
//            using (var context = new LolDbContext())
//            {
//                foreach (Match m in matches)
//                {
//                    context.Items.Add(m);
//                    context.SaveChanges();
//                }
//                context.SaveChanges();
//            }
//        }
//        public async Task SavePlayers(List<Player> players)
//        {
//            using (var context = new LolDbContext())
//            {
//                foreach (Player p in players)
//                {
//                    context.Items.Add(p);
//                    context.SaveChanges();
//                }
//                context.SaveChanges();
//            }
//        }
//        public async Task SaveRunes(List<Rune> runes)
//        {
//            using (var context = new LolDbContext())
//            {
//                foreach (Rune r in runes)
//                {
//                    context.Items.Add(r);
//                    context.SaveChanges();
//                }
//                context.SaveChanges();
//            }
//        }
//        public async Task SaveSSpels(List<SSpell> sSpells)
//        {
//            using (var context = new LolDbContext())
//            {
//                foreach (SSpell sS in sSpells)
//                {
//                    context.Items.Add(sS);
//                    context.SaveChanges();
//                }
//                context.SaveChanges();
//            }
//        }
//        public async Task SaveItems(List<Item> items)
//        {
//            using (var context = new LolDbContext())
//            {
//                foreach (Item item in items)
//                {
//                    context.Items.Add(item);
//                    context.SaveChanges();
//                }
//                context.SaveChanges();
//            }
//        }
//        public async Task SaveUsers(List<User> users)
//        {
//            using (var context = new LolDbContext())
//            {
//                foreach (User user in users)
//                {
//                    context.Users.Add(user);
//                    context.SaveChanges();
//                }
//                context.SaveChanges();
//            }
//        }
//    }
//}

