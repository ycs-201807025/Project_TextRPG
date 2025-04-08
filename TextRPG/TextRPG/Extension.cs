using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    
    public static class Extension
    {

    }
    public static class Util
    {   
        /// <summary>
        /// 장면이 넘어갈때마다 나오는 아무키나 누르세요를 클래스를 만들어 사용할 수 있도록 만듬
        /// </summary>
        public static void PressAnyKey(string text)
        {
            Console.WriteLine(text);
            Console.WriteLine("계속 하려면 아무키나 누르세요...");
            Console.ReadKey(true);
        }
    }
}
