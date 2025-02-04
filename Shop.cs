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

        public void BuyItem(int _num)
        {
            int itemIndex = _num - 1;
            onMessage = true;

            // 잘못된 입력
            // 범위 초과 ( 0 미만 , 게임 내 아이템 개수 초과 )
            if (_num < 0 || ItemManager.Instance.itemLength < _num)
            {
                message = "잘못된 입력입니다";
                messageColor = ConsoleColor.Red;
                return;
            }

            // 이미 보유한 아이템
            if (Player.Instance.inventory[itemIndex] != null)
            {
                message = "이미 구매한 아이템입니다.";
                messageColor = ConsoleColor.Blue;
                return;
            }

            // 구매 시도
            // 돈이 충분하지않을때
            if (Player.Instance.gold < ItemManager.Instance.itemPrice[itemIndex])
            {
                message = "Gold 가 부족합니다.";
                messageColor = ConsoleColor.Red;
                return;
            }

            // 범위를 초과하지않음 / 보유중이 아님 / 돈이 충분함
            message = "구매를 완료했습니다.";
            messageColor = ConsoleColor.Blue;

            // 돈 차감 및 아이템 추가
            Player.Instance.gold -= ItemManager.Instance.itemPrice[itemIndex];
            Player.Instance.inventory.AddItem(itemIndex);
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

            onMessage = false;
        }
    }
}
