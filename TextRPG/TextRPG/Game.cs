﻿using System;
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
        public static string prevSceneName;

        private static Player player;
        public static Player Player { get { return player; } }


        private static bool gameOver;

        /// <summary>
        /// 게임 동작 시 작업
        /// </summary>
        public static void Run()
        {
            Start();

            while (gameOver == false)
            {
                //씬이 넘어갈때마다 화면 클리어
                Console.Clear();
                //렌더 작업
                curScene.Render();
                Console.WriteLine();
                //인풋 작업
                curScene.Input();
                Console.WriteLine();
                //업데이트 작업
                curScene.Update();
                Console.WriteLine();
                //결과 작업
                curScene.Result();
            }
        }
        /// <summary>
        /// 장면 전환을 위해 만듬
        /// </summary>
        public static void ChangeScene(string sceneName)
        {
            prevSceneName = curScene.name;
            curScene.Exit();
            curScene = sceneDic[sceneName];
            curScene.Enter();
        }
        /// <summary>
        /// 게임 시작 작업 
        /// </summary>
        private static void Start()
        {
            //게임 설정
            gameOver = false;

            //플레이어 설정
            player = new Player();

            //씬을 만들때마다 추가
            sceneDic = new Dictionary<string, BaseScene>();
            sceneDic.Add("Title", new TitleScene());
            sceneDic.Add("Newbie", new NewbieTownScene());
            sceneDic.Add("Dungeon01", new Dungeon01Scene());
            sceneDic.Add("Market", new MarketScene());
            sceneDic.Add("Sell", new SellScene());


            //시작시 맨 처음 나타날 씬
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
