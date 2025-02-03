using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpartaDungeon
{
    public class StatScene : Scene
    {
        public override void Print()
        {
            Console.Clear();
            Console.WriteLine("상태보기");
            Console.WriteLine("캐릭터의 정보가 표시됩니다.");
            Console.WriteLine("─────────────────────────");
            Console.WriteLine($"Lv. {Player.Instance.level}");
            Console.WriteLine($"{Player.Instance.name} ( {Player.Instance.job} )");
            Console.WriteLine($"공격력 : {Player.Instance.damage}");
            Console.WriteLine($"방어력 : {Player.Instance.defense}");
            Console.WriteLine($"체 력 : {Player.Instance.hp}");
            Console.WriteLine($"Gold : {Player.Instance.gold}");
            Console.WriteLine("─────────────────────────");
            Console.WriteLine("0. 나가기");

            Console.WriteLine("\n원하시는 행동을 입력해주세요.");

            Console.Write("> ");
            string command = Console.ReadLine();

            // 입력 확인
            if (!int.TryParse(command, out int intCommand))
                return;

            if (intCommand == 0)
                SceneManager.Instance.ChangeScene(SceneName.LobbyScene);
        }
    }
}
