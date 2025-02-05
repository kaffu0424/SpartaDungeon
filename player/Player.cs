using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpartaDungeon
{
    public class Player : Singleton<Player>
    {
        public string name      { get; set; }
        public JobType job      { get; set; }

        public int level        { get; private set; }
        public int exp          { get; private set; }
        public float damage     { get; private set; }
        public float defense    { get; private set; }
        public int hp           { get; set; }
        public int gold         { get; set; }

        public Inventory inventory { get; private set; }

        public Player()
        {
            level = 1;
            exp = 0;
            damage = 10;
            defense = 5;
            hp = 100;
            gold = 1000;

            inventory = new Inventory();
        }

        public void AddExp()
        {
            exp++;
            if (exp == level)
            {
                level++;
                exp = 0;

                damage += 0.5f;
                defense += 1;
            }
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
