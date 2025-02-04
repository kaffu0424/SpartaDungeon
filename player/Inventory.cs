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
        public Item this[int index]
        {
            get { return inventory[index]; }
        }

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
            // 인벤토리 내 보유한 아이템 전부 출력
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
                    Console.WriteLine($"{itemCount}. [E]{item.ItemInfo()}");

                // item이 장착중이 아닐때
                else
                    Console.WriteLine($"{itemCount}. {item.ItemInfo()}");

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

        public void Equipment(int _inputCount)
        {
            int itemCount = 1;

            for(int i = 0; i < inventory.Length; i++)
            {
                if (inventory[i] == null)
                    continue;

                // 입력한 순서의 아이템일때
                if(_inputCount == itemCount)
                {
                    switch (inventory[i].itemType)
                    {
                        case ItemType.Armor:
                            // 선택된 방어구가 착용중인 방어구와 같을때 착용해제
                            if (equipedArmor == (Armor)inventory[i])
                                equipedArmor = null;
                            // 착용
                            else
                                equipedArmor = (Armor)inventory[i];
                            break;

                        case ItemType.Weapon:
                            // 선택된 무기가 착용중인 무기와 같을때 착용해제
                            if (equipedWeapon == (Weapon)inventory[i])
                                equipedWeapon = null;
                            //착용
                            else
                                equipedWeapon = (Weapon)inventory[i];
                            break;
                    }
                    break;
                }

                itemCount++;
            }
        }

        public void AddItem(int _index)
        {
            inventory[_index] = ItemManager.Instance.items[_index];
        }
    }
}
