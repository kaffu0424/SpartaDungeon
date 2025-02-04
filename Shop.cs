using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpartaDungeon
{
    public class Shop
    {
        public bool onMessage;
        public string message;
        public ConsoleColor messageColor;
        public ConsoleColor defaultColor;

        public Shop() 
        {
            defaultColor = Console.ForegroundColor;
        }

        public void BuyItem(int _index)
        {

        }

        public void PrintItemList(bool _isNumber = false)
        {
            int? number;
            for (int i = 0; i < ItemManager.Instance.itemLength; i++)
            {
                number = _isNumber ? i + 1 : null;

                Console.Write($"- {number} {ItemManager.Instance.items[i].ItemInfo()}");

                if (Player.Instance.inventory[i] == null)
                    Console.WriteLine($"  | {ItemManager.Instance.itemPrice[i]}G");

                else
                    Console.WriteLine("  | 구매완료");
            }
        }

        public void ShopMessage()
        {
            if (!onMessage)
                return;

            Console.ForegroundColor = messageColor;
            Console.WriteLine($"\n{message}");
            Console.ForegroundColor = defaultColor;
        }
    }
}
