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

        public Inventory inventory { get; set; }

        public Player()
        {
            level = 1;
            damage = 10;
            defense = 5;
            hp = 100;
            gold = 1000;

            inventory = new Inventory();
        }

        public int GetArmorStat()
        {
            if (inventory.equipedArmor == null)
                return 0;
            else
                return inventory.equipedArmor.defense;
        }
        public int GetWeaponStat()
        {
            if (inventory.equipedWeapon == null)
                return 0;
            else
                return inventory.equipedWeapon.damage;
        }
    }
}
