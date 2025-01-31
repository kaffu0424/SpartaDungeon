using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpartaDungeon
{
    public class SceneManager : Singleton<SceneManager>
    {
        private Scene currentScene;
        private Scene[] scenes;

        public SceneManager() 
        {
            int sceneCount = Enum.GetValues(typeof(SceneName)).Length;
            scenes = new Scene[sceneCount];

            scenes[0] = new UserCreateScene();
            scenes[1] = new LobbyScene();
            scenes[2] = new StatScene();
            scenes[3] = new InventoryScene();
            scenes[4] = new ShopScene();
            scenes[5] = new DungeonScene();
            scenes[6] = new SleepScene();

            ChangeScene(SceneName.UserCreateScene);
        }

        public void ScenePrint()
        {
            currentScene.Print();
        }

        public void ChangeScene(SceneName _name)
        {
            currentScene = scenes[(int)_name];
        }
    }
}
