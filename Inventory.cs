using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SpartaDungeon
{
    public class Inventory
    {
        private Item[] inventory;

        private Armor equipedArmor;
        private Weapon equipedWeapon;
        public Inventory()
        {
            int length = Enum.GetValues(typeof(ItemName)).Length;
            inventory = new Item[length];

            inventory[(int)ItemName.NoviceArmor] =
                ItemManager.Instance.GetItemReference(ItemName.NoviceArmor);

        }

        public void ShowInventory()
        {
            foreach (Item item in inventory)
            {
                if(item != null)
                    Console.WriteLine(item.ItemInfo());
            }
        }
        public void ShowEquip()
        {
            int itemCount = 1;

            foreach (Item item in inventory)
            {
                if (item == null)
                    continue;

                if(equipedArmor == item)
                    Console.WriteLine($"{itemCount}. [E]{item.ItemInfo()}");

                else if(equipedWeapon == item)
                    Console.WriteLine($"{itemCount} . [E]{item.ItemInfo()}");

                else
                    Console.WriteLine($"{itemCount} . {item.ItemInfo()}");

                itemCount++;
            }
        }
    }
}
