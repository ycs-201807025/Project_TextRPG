using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG.Scene
{
    /// <summary>
    /// 게임 시작시 나오는 타이틀의 씬 
    /// </summary>
    public class TitleScene : BaseScene
    {
        public TitleScene()
        {
            name = "Title";
        }
        public override void Render()
        {
            Console.WriteLine("☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★");
            Console.WriteLine("★                          일단                              ☆");
            Console.WriteLine("☆                         써보는                             ★");
            Console.WriteLine("★                         타이틀                             ☆");
            Console.WriteLine("☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★");
            Console.WriteLine();
            Console.WriteLine("계속하려면 아무키나 누르세요...");
        }
        public override void Input()
        {
            Console.ReadKey(true);
        }

        public override void Update()
        {
            
        }

        public override void Result()
        {
            Game.ChangeScene("Newbie");
        }

      
    }
}
