﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpartaDungeon
{
    public class LobbyScene : Scene
    {
        public override void Print()
        {
            Console.Clear();

            Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
            Console.WriteLine("이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.\n");
            Console.WriteLine("─────────────────────────");
            Console.WriteLine("1. 상태보기");
            Console.WriteLine("2. 인벤토리");
            Console.WriteLine("3. 상점");
            Console.WriteLine("4. 던전입장");
            Console.WriteLine("5. 휴식하기");
            Console.WriteLine("─────────────────────────");
            if (!SceneManager.Instance.SceneInputCommand(out int intCommand))
                return;

            switch(intCommand)
            {
                case 1:
                    SceneManager.Instance.ChangeScene(SceneName.StatScene);
                    break;
                case 2:
                    SceneManager.Instance.ChangeScene(SceneName.InventoryScene);
                    break;
                case 3:
                    SceneManager.Instance.ChangeScene(SceneName.ShopScene);
                    break;
                case 4:
                    SceneManager.Instance.ChangeScene(SceneName.DungeonScene);
                    break;
                case 5:
                    SceneManager.Instance.ChangeScene(SceneName.SleepScene);
                    break;
            }
        }
    }
}
