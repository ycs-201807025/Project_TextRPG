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

        // 몬스터 정보를 설정하는 메서드
        public void SetMonster(Monster monster)
        {
            currentMonster = monster;
        }
        public override void Render()
        {
            Console.WriteLine("현재 있는 장소 : 던전초입");
            Console.WriteLine("나오는 몬스터 : 슬라임");
            Console.WriteLine();
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
            Game.Player.Inventory.PrintAll();

        }
        public override void Input()
        {
            ConsoleKey input = Console.ReadKey(true).Key;
        }
        public override void Update()
        {
        }
        public override void Result()
        {
        }
        
    }
}
