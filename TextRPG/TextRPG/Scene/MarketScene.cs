using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextRPG.Items;

namespace TextRPG.Scene
{
    public class MarketScene : BaseScene
    {
        private ConsoleKey input;
        private Encyclopedia encyclopedia = new Encyclopedia(); // 도감

        public override void Render()
        {
            Console.WriteLine("현재 있는 장소 : 상점");
            Console.WriteLine();
            Console.WriteLine("1. 마을로 돌아가기");
            Console.WriteLine("2. 상점 둘러보기");
            Console.WriteLine("I. 인벤토리 열기");
            Console.WriteLine("U. 도감열기");
            Console.WriteLine("선택지를 입력하세요 : ");
            Game.PrintInfo();
        }
        public override void Input()
        {
            input = Console.ReadKey(true).Key;
            // U 키를 눌렀을 때 도감 표시
            if (input == ConsoleKey.U)
            {
                Console.Clear();
                encyclopedia.DisplayAllItems(); // 도감 출력
                Util.PressAnyKey("도감을 닫으려면 아무 키나 누르세요.");
            }
        }

        public override void Update()
        {
            Game.Player.Action(input);
        }

        public override void Result()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    Util.PressAnyKey("마을로 돌아갑니다");
                    Game.ChangeScene("Newbie");
                    break;
                case ConsoleKey.D2:
                    Util.PressAnyKey("상점을 둘러봅니다");
                    Game.ChangeScene("Sell");
                    break;
            }
        }
    }
}
