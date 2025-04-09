using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextRPG.Items;
using TextRPG.Items.Armors;
using TextRPG.Items.Weapons;

namespace TextRPG.Scene
{
    public class SellScene : BaseScene
    {
        private ConsoleKey input;
        HpPotion potion = new HpPotion();
        Weapon sword = new WoodSword();
        LeatherArmor armor = new LeatherArmor();
        public override void Render()
        {
            Console.WriteLine("현재 있는 장소 : 상점");
            Console.WriteLine();
            Console.WriteLine("=========================================================");
            Console.WriteLine("=1. {0}                                                  ",potion.name);
            Console.WriteLine("=2. {0}                                                  ",sword.name);
            Console.WriteLine("=3. {0}                                                  ",armor.name);
            Console.WriteLine("=4. 돌아간다                                              ");
            Console.WriteLine("=========================================================");
            Console.WriteLine("사고싶은 아이템을 선택하세요 : ");
            Game.Player.Inventory.PrintAll();
        }
        public override void Input()
        {
            input = Console.ReadKey(true).Key;
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
                    Game.Player.Inventory.Add(potion);
                    break;
                case ConsoleKey.D2:
                    Game.Player.Inventory.Add(sword);
                    break;
                case ConsoleKey.D3:
                    Game.Player.Inventory.Add(armor);
                    break;
                case ConsoleKey.D4:
                    Game.ChangeScene("Market");
                    break;
            }
        }
    }
}
