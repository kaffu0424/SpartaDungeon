using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpartaDungeon
{
    public class ItemManager : Singleton<ItemManager> 
    {
        private Item[] items;

        public ItemManager()
        {
            int length = Enum.GetValues(typeof(ItemName)).Length;
            items = new Item[length];

            items[(int)ItemName.NoviceArmor]    
                = new Armor("수련자 갑옷", "수련에 도움을 주는 갑옷입니다.", 5);
            items[(int)ItemName.IronArmor]      
                = new Armor("무쇠 갑옷", "무쇠로 만들어져 튼튼한 갑옷입니다.", 9);
            items[(int)ItemName.SpartaArmor]    
                = new Armor("스파르타 갑옷", "스파르타의 전사들이 사용했다는 전설의 갑옷입니다.", 15);
            items[(int)ItemName.OldSword]       
                = new Weapon("낡은 검", "쉽게 볼 수 있는 낡은 검 입니다.", 2);
            items[(int)ItemName.BronzeAxe]      
                = new Weapon("청동 도끼", "어디선가 사용됐던거 같은 도끼입니다.", 5);
            items[(int)ItemName.SpartaSpear]    
                = new Weapon("스파르타의 창", "스파르타의 전사들이 사용했다는 전설의 창입니다.", 7);
        }

        public Item GetItemReference(ItemName _name)
        {
            return items[(int)_name];
        }
    }
}
