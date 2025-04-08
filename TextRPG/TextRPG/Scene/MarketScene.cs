using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG.Scene
{
    public class MarketScene : BaseScene
    {
        private ConsoleKey input;

        public override void Render()
        {
            Console.WriteLine("현재 있는 장소 : 상점");
            Console.WriteLine();
            Console.WriteLine("1. 타이틀로 돌아가기");
            Console.WriteLine("선택지를 입력하세요 : ");
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
                    Util.PressAnyKey("타이틀로 돌아갑니다");
                    Game.ChangeScene("Title");
                    break;
            }
        }
    }
}
