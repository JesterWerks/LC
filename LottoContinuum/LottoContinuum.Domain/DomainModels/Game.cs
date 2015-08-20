using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LottoContinuum.Domain.DomainModels
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Game_Balls { get; set; }
        public int Bottom_Game_Ball { get; set; }
        public int Top_Game_Ball { get; set; }
        public int Bonus_Balls { get; set; }
        public int Bottom_Bonus_Ball { get; set; }
        public int Top_Bonus_Ball { get; set; }
        public string Site_Url { get; set; }
        public int Permutations { get; set; }
        public string Drawing_Time { get; set; }
    }
}
