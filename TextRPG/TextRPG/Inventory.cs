using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    /// <summary>
    /// 인벤토리 클래스 
    /// </summary>
    public class Inventory
    {
        private List<Item> items;
        private Stack<string> stack;
        private int selectIndex;

        public Inventory()
        {
            items = new List<Item>();
            stack = new Stack<string>();
        }
        /// <summary>
        /// 아이템을 추가
        /// </summary>
        public void Add(Item item)
        {
            items.Add(item);
        }
        /// <summary>
        /// 아이템 제거
        /// </summary>
        public void Remove(Item item)
        {
            items.Remove(item);
        }
        /// <summary>
        /// 아이템 모두 제거
        /// </summary>
        public void RemoveAt(int index)
        {
            items.RemoveAt(index);
        }
        /// <summary>
        /// 아이템 모두 사용
        /// </summary>
        public void UseAt(int index)
        {
            items[index].Use();
        }
        /// <summary>
        /// 인벤토리 오픈
        /// </summary>
        public void Open()
        {
            stack.Push("Menu");

            while (stack.Count > 0)
            {

                Console.Clear();
                switch (stack.Peek())
                {
                    case "Menu": Menu();
                        break;
                    case "UseMenu":
                        UseMenu();
                        break;
                    case "DropMenu":
                        DropMenu();
                        break;
                    case "UseConfirm":
                        UseConfirm();
                        break;
                    case "DropConfirm":
                        DropConfirm();
                        break;
                }
            }
        }
        /// <summary>
        /// 인벤토리 상호작용
        /// </summary>
        private void Menu()
        {
            PrintAll();

            Console.WriteLine("1. 사용하기");
            Console.WriteLine("2. 버리기");
            Console.WriteLine("3. 뒤로가기");

            ConsoleKey input = Console.ReadKey(true).Key;
            switch (input)
            {
                case ConsoleKey.D1:
                    stack.Push("UseMenu");
                    break;
                case ConsoleKey.D2:
                    stack.Push("DropMenu");
                    break;
                case ConsoleKey.D3:
                    stack.Pop();
                    break;
            }
        }
        /// <summary>
        /// 사용할 아이템 선택
        /// </summary>
        private void UseMenu()
        {
            PrintAll();

            Console.WriteLine("사용할 아이템을 선택해주세요.");
            Console.WriteLine("뒤로가기 : 0");

            ConsoleKey input = Console.ReadKey(true).Key;
            if (input == ConsoleKey.D0)
            {
                stack.Pop();
            }
            else
            {
                int select = (int)input - (int)ConsoleKey.D1;
                if (select < 0 || items.Count <= select)
                {
                    Util.PressAnyKey("범위 내의 아이템을 선택하세요");
                }
                else
                {
                    selectIndex = select;
                    stack.Push("UseConfirm");
                }
            }
        }
        /// <summary>
        /// 버릴 아이템 선택
        /// </summary>
        private void DropMenu()
        {
            PrintAll();

            Console.WriteLine("버릴 아이템을 선택해주세요");
            Console.WriteLine("뒤로가기 : 0");

            ConsoleKey input = Console.ReadKey(true).Key;
            if (input == ConsoleKey.D0)
            {
                stack.Pop();
            }
            else
            {
                int select = (int)input - (int)ConsoleKey.D1;
                if (select < 0 || items.Count <= select)
                {
                    Util.PressAnyKey("범위 내의 아이템을 선택하세요.");
                }
                else
                {
                    selectIndex = select;
                    stack.Push("DropConfirm");
                }
            }
        }
        /// <summary>
        /// 사용할 아이템 최종 확인
        /// </summary>
        private void UseConfirm()
        {
            Item selectItem = items[selectIndex];
            Console.WriteLine("{0} 을/를 사용하시겠습니까? (y/n)", selectItem.name);

            ConsoleKey input = Console.ReadKey(true).Key;
            switch (input)
            {
                case ConsoleKey.Y:
                    selectItem.Use();
                    Util.PressAnyKey($"{selectItem.name} 을/를 사용했습니다.");
                    Remove(selectItem);
                    stack.Pop();
                    break;
                case ConsoleKey.N:
                    stack.Pop();
                    break;
            }
        }
        /// <summary>
        /// 버릴 아이템 최종 확인
        /// </summary>
        private void DropConfirm()
        {
            Item selectItem = items[selectIndex];
            Console.WriteLine("{0} 을/를 버리시겠습니까? (y/n)", selectItem.name);

            ConsoleKey input = Console.ReadKey(true).Key;
            switch (input)
            {
                case ConsoleKey.Y:
                    Util.PressAnyKey($"{selectItem.name} 을/를 버렸습니다.");
                    Remove(selectItem);
                    stack.Pop();
                    break;
                case ConsoleKey.N:
                    stack.Pop();
                    break;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public void PrintAll()
        {
            Console.WriteLine("=====================가지고있는 아이템======================");
            if (items.Count == 0)
            {
                Console.WriteLine("현재 가지고 있는 아이템없음");
            }
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine("{0}. {1}",i+1, items[i].name);
            }
            Console.WriteLine("===========================================================");
        }
    }
}
