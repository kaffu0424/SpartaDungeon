﻿using System;
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

        private Shop shop;

        public ShopScene()
        {
            onBuy = false;
            onSell = false;

            shop = new Shop();
        }

        public override void Update()
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
            shop.PrintItemList();
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
            shop.PrintItemList(true);
            Console.WriteLine("─────────────────────────");

            Console.WriteLine("0. 나가기");

            shop.ShopMessage();
            if (!SceneManager.Instance.SceneInputCommand(out int intCommand))
                return;
            
            switch (intCommand)
            {
                case 0:
                    onBuy = false;
                    break;

                default:
                    shop.BuyItem(intCommand);
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
            shop.SellItemList();
            Console.WriteLine("─────────────────────────");

            Console.WriteLine("0. 나가기");

            shop.ShopMessage();
            if (!SceneManager.Instance.SceneInputCommand(out int intCommand))
                return;

            switch(intCommand)
            {
                case 0:
                    onSell = false;
                    break;
                default:
                    shop.SellItem(intCommand);
                    break;
            }
        }
    }
}
