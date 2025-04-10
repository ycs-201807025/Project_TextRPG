using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextRPG.Monsters;

namespace TextRPG.Scene
{
    public class BattleScene : BaseScene
    {
        
        MonsterFactory monsterFactory = new MonsterFactory();
        private Monster monster01;
        private ConsoleKey input;
        public override void Render()
        {
            if (monster01 == null)
            {
                monster01 = monsterFactory.CreateMonster("슬라임");
            }
            Console.WriteLine("===== 전투 시작 =====");
            Console.WriteLine($"몬스터: {monster01.name}");
            Console.WriteLine($"레벨: {monster01.level}");
            Console.WriteLine($"체력: {monster01.hp}");
            Console.WriteLine($"공격력: {monster01.attack}");
            Console.WriteLine($"방어력: {monster01.defense}");
            Console.WriteLine("=====================");
            Console.WriteLine("1. 공격");
            Console.WriteLine("2. 도망");
            Console.WriteLine("선택지를 입력하세요: ");
            Game.PrintInfo();

        }
        public override void Input()
        {
            input = Console.ReadKey(true).Key;
            if (input == ConsoleKey.I)
            {
                Game.Player.Inventory.Open(); // 인벤토리 열기
            }
        }
        public override void Update()
        {
            
        }
        public override void Result()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    Util.PressAnyKey("공격합니다");
                    monster01.hit(Game.Player.Attack);
                    if (monster01.hp <= 0)
                    {
                        Console.WriteLine($"몬스터 {monster01.name}을(를) 처치했습니다!");
                        Util.PressAnyKey("전투가 종료되었습니다.");
                        Game.ChangeScene("Dungeon01"); // 전투 종료 후 던전으로 이동
                    }
                    else
                    {
                        Render();
                    }
                        break;
                case ConsoleKey.D2:
                    Util.PressAnyKey("도망 칩니다");
                    Game.ChangeScene("Dungeon01");
                    break;
            }
        }
        
    }
}
