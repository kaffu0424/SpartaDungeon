using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpartaDungeon
{
    public class ShopScene : Scene
    {
        private bool onBuy;
        private bool onSell;

        private bool onMessage;
        private string message;
        private ConsoleColor messageColor;

        public ShopScene()
        {
            onBuy = false;
            onSell = false;
        }

        public override void Print()
        {
            if (onBuy)
                ShopBuy();

            else if (onSell)
                ShopSell();

            else
                ShopMain();
        }

        private void ShopMain()
        {
            Console.Clear();
            Console.WriteLine("상점");
            Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.");
            Console.WriteLine("─────────────────────────");
            Console.WriteLine("[보유 골드]");
            Console.WriteLine($"{Player.Instance.gold} G");
            Console.WriteLine("─────────────────────────");
            Console.WriteLine("[아이템 목록]");
            PrintItemList();
            Console.WriteLine("─────────────────────────");

            Console.WriteLine("1. 아이템 구매");
            Console.WriteLine("2. 아이템 판매");
            Console.WriteLine("0. 나가기");

            if (!SceneManager.Instance.SceneInputCommand(out int intCommand))
                return;

            switch (intCommand)
            {
                case 0:
                    SceneManager.Instance.ChangeScene(SceneName.LobbyScene);
                    break;
                case 1:
                    onBuy = true;
                    break;
                case 2:
                    onSell = true;
                    break;
            }
        }

        private void ShopBuy()
        {
            Console.Clear();
            Console.WriteLine("상점 - 아이템 구매");
            Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.");
            Console.WriteLine("─────────────────────────");
            Console.WriteLine("[보유 골드]");
            Console.WriteLine($"{Player.Instance.gold} G");
            Console.WriteLine("─────────────────────────");
            Console.WriteLine("[아이템 목록]");
            PrintItemList(true);
            Console.WriteLine("─────────────────────────");

            Console.WriteLine("0. 나가기");

            if (onMessage)
            {
                SceneManager.Instance.PlayerMessage(message, messageColor);
                onMessage = false;
            }

            if (!SceneManager.Instance.SceneInputCommand(out int intCommand))
                return;

            switch (intCommand)
            {
                case 0:
                    onBuy = false;
                    break;

                default:
                    onMessage = true;
                    message = "잘못된 입력입니다.";
                    messageColor = ConsoleColor.Red;
                    break;
            }
        }

        private void ShopSell()
        {
            Console.Clear();
            Console.WriteLine("상점 - 아이템 판매");
            Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.");
            Console.WriteLine("─────────────────────────");
            Console.WriteLine("[보유 골드]");
            Console.WriteLine($"{Player.Instance.gold} G");
            Console.WriteLine("─────────────────────────");
            Console.WriteLine("[아이템 목록]");
            PrintItemList(true);
            Console.WriteLine("─────────────────────────");

            Console.WriteLine("0. 나가기");



            if (!SceneManager.Instance.SceneInputCommand(out int intCommand))
                return;

            switch(intCommand)
            {
                case 0:
                    onSell = false;
                    break;
            }
        }

        private void PrintItemList(bool _isNumber = false)
        {
            int? number;
            for(int i = 0; i < ItemManager.Instance.itemLength; i++)
            {
                number = _isNumber ? i + 1 : null;
                
                Console.Write($"- {number} {ItemManager.Instance.items[i].ItemInfo()}");

                if (Player.Instance.inventory[i] == null)
                    Console.WriteLine($"  | {ItemManager.Instance.itemPrice[i]}G");

                else
                    Console.WriteLine("  | 구매완료");
            }
        }
    }
}
