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

        private Armor? equipedArmor;
        private Weapon? equipedWeapon;
        public Inventory()
        {
            int length = Enum.GetValues(typeof(ItemName)).Length;
            inventory = new Item[length];

            //// 아이템 구매 ( 인벤토리 추가 ) 테스트 코드
            //inventory[(int)ItemName.NoviceArmor] =
            //    ItemManager.Instance.GetItemReference(ItemName.NoviceArmor);
            //inventory[(int)ItemName.IronArmor] =
            //    ItemManager.Instance.GetItemReference(ItemName.IronArmor);
            //inventory[(int)ItemName.BronzeAxe] =
            //    ItemManager.Instance.GetItemReference(ItemName.BronzeAxe);
            //// 아이템 장착 테스트코드
            //equipedArmor = (Armor)inventory[(int)ItemName.NoviceArmor];
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

                // item이 장착중인 방어구일때
                if(equipedArmor == item)
                    Console.WriteLine($"{itemCount}. [E]{item.ItemInfo()}");

                // item이 장착중인 무기일때
                else if(equipedWeapon == item)
                    Console.WriteLine($"{itemCount} . [E]{item.ItemInfo()}");

                // item이 장착중이 아닐때
                else
                    Console.WriteLine($"{itemCount} . {item.ItemInfo()}");

                itemCount++;
            }
        }

        public void ArmorStat()
        {
            string stat = "";
            if (equipedArmor != null)
                stat = $" ( +{equipedArmor.defense} )";

            Console.WriteLine($"{stat}");
        }

        public void WeaponStat()
        {
            string stat = "";
            if (equipedWeapon != null)
                stat = $" ( +{equipedWeapon.damage} )";

            Console.WriteLine($"{stat}");
        }
    }
}
