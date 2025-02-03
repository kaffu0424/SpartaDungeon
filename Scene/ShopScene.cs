using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpartaDungeon
{
    public class ShopScene : Scene
    {
        public override void Print()
        {
            Console.Clear();
            Console.WriteLine("인벤토리");
            Console.WriteLine("보유중인 아이템을 관리할 수 있습니다.");
            Console.WriteLine("─────────────────────────");
            Console.WriteLine("[보유 골드]");
            Console.WriteLine($"{Player.Instance.gold} G");
            Console.WriteLine("─────────────────────────");
            
            Console.WriteLine("─────────────────────────");
        }
    }
}
