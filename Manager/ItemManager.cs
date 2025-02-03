using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpartaDungeon
{
    internal class ItemManager : Singleton<ItemManager> 
    {
        public Item[] items { get; private set; }
        public string[] itemDescription { get; private set; }
        public ItemManager()
        {
            int length = Enum.GetValues(typeof(ItemName)).Length;
            items = new Item[length];
            itemDescription = new string[length];

            items[(int)ItemName.NoviceArmor]    = new Armor("수련자 갑옷", 5);
            items[(int)ItemName.IronArmor]      = new Armor("무쇠 갑옷", 9);
            items[(int)ItemName.SpartaArmor]    = new Armor("스파르타 갑옷", 15);
            items[(int)ItemName.OldSword]       = new Weapon("낡은 검", 2);
            items[(int)ItemName.BronzeAxe]      = new Weapon("청동 도끼", 5);
            items[(int)ItemName.SpartaSpear]    = new Weapon("스파르타의 창", 7);

            itemDescription[(int)ItemName.NoviceArmor]  = "수련에 도움을 주는 갑옷입니다.";
            itemDescription[(int)ItemName.IronArmor]    = "무쇠로 만들어져 튼튼한 갑옷입니다.";
            itemDescription[(int)ItemName.SpartaArmor]  = "스파르타의 전사들이 사용했다는 전설의 갑옷입니다.";
            itemDescription[(int)ItemName.OldSword]     = "쉽게 볼 수 있는 낡은 검 입니다.";
            itemDescription[(int)ItemName.BronzeAxe]    = "어디선가 사용됐던거 같은 도끼입니다.";
            itemDescription[(int)ItemName.SpartaSpear]  = "스파르타의 전사들이 사용했다는 전설의 창입니다.";
        }
    }
}
