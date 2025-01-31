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


        }

        public void ScenePrint()
        {
            currentScene.Print();
        }

        public void ChangeScene()
        {

        }
    }
}
