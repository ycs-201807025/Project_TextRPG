using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG.Items
{
    public class Encyclopedia
    {
        // 아이템 정보를 저장하는 딕셔너리
        private Dictionary<string, ItemInfo> itemDictionary;

        public Encyclopedia()
        {
            itemDictionary = new Dictionary<string, ItemInfo>();
            InitializeItems(); // 초기 아이템 정보 추가
        }

        // 아이템 정보를 추가하는 메서드
        public void AddItem(string name, string description, string type)
        {
            if (!itemDictionary.ContainsKey(name))
            {
                itemDictionary[name] = new ItemInfo(name, description, type);
            }
        }

        // 아이템 정보를 조회하는 메서드
        public void DisplayAllItems()
        {
            
            Console.WriteLine("===== 아이템 도감 =====");
            foreach (var item in itemDictionary.Values)
            {
                Console.WriteLine($"이름: {item.Name}");
                Console.WriteLine($"설명: {item.Description}");
                Console.WriteLine($"타입: {item.Type}");
                Console.WriteLine("-----------------------");
            }
            Console.WriteLine("1. 아이템검색");
            Console.WriteLine("2. 도감 닫기");
            ConsoleKey input = Console.ReadKey(true).Key;
            switch (input)
            {
                case ConsoleKey.D1:
                    Console.Write("검색할 아이템 : ");
                    string search = Console.ReadLine();
                    DisplayItem(search);
                    break;
                case ConsoleKey.D2:
                    
                    break;  
            }
            
            
        }

        // 특정 아이템 정보를 조회하는 메서드
        public void DisplayItem(string name)
        {
            if (itemDictionary.ContainsKey(name))
            {
                var item = itemDictionary[name];
                Console.WriteLine($"이름: {item.Name}");
                Console.WriteLine($"설명: {item.Description}");
                Console.WriteLine($"타입: {item.Type}");
            }
            else
            {
                Console.WriteLine("해당 아이템이 도감에 없습니다.");
            }
        }

        // 초기 아이템 정보를 추가하는 메서드
        private void InitializeItems()
        {
            AddItem("체력포션", "체력을 회복하는 포션입니다.", "소모품");
            AddItem("나무검", "초보자가 사용하는 나무 검입니다.", "무기");
        }
    }

    // 아이템 정보를 저장하는 클래스
    class ItemInfo
    {
        public string Name { get; }
        public string Description { get; }
        public string Type { get; }

        public ItemInfo(string name, string description, string type)
        {
            Name = name;
            Description = description;
            Type = type;
        }
    }
}

