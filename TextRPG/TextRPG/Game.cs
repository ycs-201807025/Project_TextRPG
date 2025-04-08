using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TextRPG.Scene;

namespace TextRPG
{
    public static class Game
    {
        private static Dictionary<string, BaseScene> sceneDic;
        private static BaseScene curScene;

        private static bool gameOver;

        /// <summary>
        /// 게임 동작 시 작업
        /// </summary>
        public static void Run()
        {
            Start();

            while (gameOver == false)
            {
                Console.Clear();
                curScene.Render();
                curScene.Input();
                curScene.Update();
                curScene.Result();
            }
        }
        /// <summary>
        /// 게임 시작 작업 
        /// </summary>
        private static void Start()
        {
            gameOver = false;

            sceneDic = new Dictionary<string, BaseScene>();
            sceneDic.Add("Title", new TitleScene());

            curScene = sceneDic["Title"];
            

        }
        /// <summary>
        /// 게임 마무리 작업
        /// </summary>
        private static void End()
        {

        }
    }
}
