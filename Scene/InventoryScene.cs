using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpartaDungeon
{
    internal class InventoryScene : Scene
    {
        private bool onEquip;
        public InventoryScene()
        {
            onEquip = false;
        }

        public override void Print()
        {
            if (onEquip)
                equipManagement();
            else
                InventoryPrint();
        }
        private void InventoryPrint()
        {
            Console.Clear();
            Console.WriteLine("인벤토리");
            Console.WriteLine("보유중인 아이템을 관리할 수 있습니다.");
            Console.WriteLine("─────────────────────────");
            Console.WriteLine("[아이템 목록]");
            Player.Instance.inventory.ShowInventory();
            Console.WriteLine("─────────────────────────");
            Console.WriteLine("1. 장착 관리");
            Console.WriteLine("0. 나가기");

            Console.WriteLine("\n원하시는 행동을 입력해주세요.");

            Console.Write("> ");
            string command = Console.ReadLine();

            // 입력 확인
            if (!int.TryParse(command, out int intCommand))
                return;

            switch (intCommand)
            {
                case 0:
                    SceneManager.Instance.ChangeScene(SceneName.LobbyScene);
                    break;
                case 1:
                    onEquip = true;
                    break;

            }
        }
        private void equipManagement()
        {
            Console.Clear();
            Console.WriteLine("인벤토리 - 장착 관리");
            Console.WriteLine("보유중인 아이템을 관리할 수 있습니다.");
            Console.WriteLine("─────────────────────────");
            Console.WriteLine("[아이템 목록]");
            Player.Instance.inventory.ShowEquip();
            Console.WriteLine("─────────────────────────");
            Console.WriteLine("0. 나가기");

            Console.WriteLine("\n원하시는 행동을 입력해주세요.");

            Console.Write("> ");
            string command = Console.ReadLine();
            // 입력 확인
            if (!int.TryParse(command, out int intCommand))
                return;

            switch(intCommand)
            {
                case 0:
                    onEquip = false;
                    break;
            }
        }
    }
}
