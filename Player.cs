using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpartaDungeon
{
    public class Player : Singleton<Player>
    {
        public string name  { get; set; }
        public JobType job  { get; set; }

        public int level    { get; set; }
        public int damage   { get; set; }
        public int defense  { get; set; }
        public int hp       { get; set; }
        public int gold     { get; set; }

        public Player()
        {
            
        }
    }
}
