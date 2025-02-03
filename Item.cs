using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpartaDungeon
{
    public class Item
    {
        public ItemType itemType { get; set; }
        public string itemName { get; set; }
    }

    public class Armor : Item
    {
        public int defense { get; set; }

        public Armor(string _name, int _defense)
        {
            itemType = ItemType.Armor;
            itemName = _name;
            defense = _defense;
        }
    }

    public class Weapon : Item
    {
        public int damage { get; set; }
        public Weapon(string _name, int _damage)
        {
            itemType = ItemType.Weapon;
            itemName = _name;
            damage = _damage;
        }
    }
}
