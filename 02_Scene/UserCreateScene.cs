﻿using SpartaDungeon.Module;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace SpartaDungeon
{
    public class UserCreateScene : Scene
    {
        private bool isNameCheck;
        private bool isJobCheck;

        public UserCreateScene()
        {
            isNameCheck = false;
            isJobCheck = false;
        }

        public override void Update()
        {
            CreateName();
            SelectJob();

            if (isNameCheck && isJobCheck)
                SceneManager.Instance.ChangeScene(SceneName.LobbyScene);
        }

        private void CreateName()
        {
            while(!isNameCheck)
            {
                Console.Clear();

                Console.WriteLine("스파르타 던전에 오신 여러분 환영합니다.");
                Console.WriteLine("원하시는 이름을 설정해주세요.");
                Console.Write("\n> ");
                string name = Console.ReadLine();
                if (name.Length < 1)
                    continue;

                Console.WriteLine($"\n입력하신 이름은 {name} 입니다.\n");
                Console.WriteLine("1. 저장");
                Console.WriteLine("2. 취소");
                Console.Write("\n> ");
                string command = Console.ReadLine();

                // 입력 확인
                if (!int.TryParse(command, out int intCommand))
                    continue;

                if(intCommand == 1)
                {
                    isNameCheck = true;
                    Player.Instance.name = name;
                }
            }
        }

        private void SelectJob()
        {
            while(!isJobCheck)
            {
                Console.Clear();

                Console.WriteLine("스파르타 던전에 오신 여러분 환영합니다.");
                Console.WriteLine("원하시는 직업을 선택해주세요.\n");
                Console.WriteLine("1. 전사");
                Console.WriteLine("2. 도적");

                Console.Write("\n> ");
                string command = Console.ReadLine();

                // 입력 확인
                if (!int.TryParse(command, out int intCommand))
                    continue;

                switch(intCommand) 
                {
                    case 1:
                        isJobCheck = true;
                        Player.Instance.job = JobType.Warrior;
                        break;
                    case 2:
                        Player.Instance.job = JobType.Rogue;
                        isJobCheck = true;
                        break;
                }
            }
        }
    }
}
