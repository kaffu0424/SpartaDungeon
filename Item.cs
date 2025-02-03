using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpartaDungeon
{
    public abstract class Item
    {
        public string itemName { get; set; }
        public string itemDescription { get; set; }
        public Item(string _name, string _description) 
        {
            itemName = _name;
            itemDescription = _description;
        }

        public abstract string ItemInfo();
    }

    public class Armor : Item
    {
        public int defense { get; set; }

        public Armor(string _name, string _description, int _defense)
            : base(_name, _description)
        {
            defense = _defense;
        }

        public override string ItemInfo()
        {
            return $"{itemName} | 방어력 +{defense} | {itemDescription}";
        }
    }

    public class Weapon : Item
    {
        public int damage { get; set; }
        public Weapon(string _name, string _description, int _damage) 
            : base(_name, _description)
        {
            damage = _damage;
        }

        public override string ItemInfo()
        {
            return $"{itemName} | 공격력 +{damage} | {itemDescription}";
        }
    }
}
