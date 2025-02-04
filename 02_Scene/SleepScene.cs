using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpartaDungeon
{
    internal class SleepScene : Scene
    {
        public override void Print()
        {
            Console.Clear();
            Console.WriteLine("휴식하기");
            Console.WriteLine($"500 G 를 내면 체력을 회복할 수 있습니다. (보유 골드 : {Player.Instance.gold} G)\n");
            Console.WriteLine("1. 휴식하기");
            Console.WriteLine("0. 나가기");


            if (!SceneManager.Instance.SceneInputCommand(out int intCommand))
                return;

            switch(intCommand)
            {

            }
        }
    }
}
