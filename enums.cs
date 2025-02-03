using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpartaDungeon
{
    public enum JobType
    {
        Warrior,
        Rogue
    }

    public enum SceneName
    {
        UserCreateScene,
        LobbyScene,
        StatScene,
        InventoryScene,
        ShopScene,
        DungeonScene,
        SleepScene
    }

    public enum ItemType
    {
        Weapon,
        Armor
    }

    public enum ItemName
    {
        NoviceArmor,
        IronArmor,
        SpartaArmor,
        OldSword,
        BronzeAxe,
        SpartaSpear
    }
}
