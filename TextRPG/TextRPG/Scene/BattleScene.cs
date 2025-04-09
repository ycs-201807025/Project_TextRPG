using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextRPG.Monsters;

namespace TextRPG.Scene
{
    class BattleScene : BaseScene
    {
        private Monster currentMonster;
        private ConsoleKey input;
        // 몬스터 정보를 설정하는 메서드
        public void SetMonster(Monster monster)
        {
            currentMonster = monster;
        }
        public override void Render()
        {
            
            Console.WriteLine("===== 전투 시작 =====");
            Console.WriteLine($"몬스터: {currentMonster.name}");
            Console.WriteLine($"레벨: {currentMonster.level}");
            Console.WriteLine($"체력: {currentMonster.hp}");
            Console.WriteLine($"공격력: {currentMonster.attack}");
            Console.WriteLine($"방어력: {currentMonster.defense}");
            Console.WriteLine("=====================");
            Console.WriteLine("1. 공격");
            Console.WriteLine("2. 방어");
            Console.WriteLine("3. 도망");
            Console.WriteLine("선택지를 입력하세요: ");
            Game.PrintInfo();

        }
        public override void Input()
        {
            ConsoleKey input = Console.ReadKey(true).Key;
            if (input == ConsoleKey.I)
            {
                Game.Player.Inventory.Open(); // 인벤토리 열기
                input = ConsoleKey.NoName; // 입력 초기화 (다른 동작 방지)
            }
        }
        public override void Update()
        {
            if (input == ConsoleKey.NoName) return; // 입력이 초기화된 경우 아무 동작도 하지 않음
            Game.Player.Action(input);
        }
        public override void Result()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("공격 합니다.");
                    currentMonster.hp -= Game.Player.Attack;
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("도망칩니다.");
                    Game.ChangeScene("Dungeon01");
                    break;
            }
        }
        
    }
}
