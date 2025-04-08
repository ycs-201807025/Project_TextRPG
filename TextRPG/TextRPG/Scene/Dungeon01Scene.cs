using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG.Scene
{
    public class Dungeon01Scene : BaseScene
    {
        private ConsoleKey input;

        public override void Render()
        {
            Console.WriteLine("현재 있는 장소 : 던전초입");
            Console.WriteLine("나오는 몬스터 : 슬라임");
            Console.WriteLine();
            Console.WriteLine("1. 앞으로 간다");
            Console.WriteLine("2. 주변을 둘러본다");
            Console.WriteLine("3. 마을로 돌아간다");
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
                    Util.PressAnyKey("앞으로 나아갑니다(미구현)");
                    Game.ChangeScene("");
                    break;
                case ConsoleKey.D2:
                    Util.PressAnyKey("주변을 둘러봅니다(미구현)");
                    Game.ChangeScene("");
                    break;
                case ConsoleKey.D3:
                    Util.PressAnyKey("마을로 돌아갑니다");
                    Game.ChangeScene("Newbie");
                    break;
            }
        }
    }
}
