using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG.Scene
{
    /// <summary>
    /// 초보자마을 씬 
    /// </summary>
    public class NewbieTownScene : BaseScene
    {
        private ConsoleKey input;
        public override void Render()
        {
            Console.WriteLine("현재 있는 장소 : 초보자 마을");
            Console.WriteLine();
            Console.WriteLine("무엇을 할까?");
            Console.WriteLine("1. 던전으로 간다");
            Console.WriteLine("2. 상점으로 간다");
            Console.WriteLine("3. 휴식을 취한다");
            Console.WriteLine("선택지를 입력하세요 : ");
            
            Game.Player.Inventory.PrintAll();
        }
        public override void Input()
        {
            input = Console.ReadKey(true).Key;
        }

        public override void Update()
        {

        }

        public override void Result()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    Util.PressAnyKey("던전으로 갑니다");
                    Game.ChangeScene("Dungeon01");
                    break;
                case ConsoleKey.D2:
                    Util.PressAnyKey("상점으로 갑니다");
                    Game.ChangeScene("Market");
                    break;
                case ConsoleKey.D3:
                    Util.PressAnyKey("여관으로 갑니다(미구현)");
                    Game.ChangeScene("");
                    break;
            }
        }


    }
}
