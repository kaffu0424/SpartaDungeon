using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpartaDungeon
{
    public class Player : Singleton<Player>
    {
        private string name;
        private JobType job;

        public string Name {  get { return name; } set { name = value; } }
        public JobType Job {  get { return job; } set { job = value; } }

        public Player()
        {

        }
    }
}
