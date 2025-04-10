using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using TextRPG.Items;

namespace TextRPG
{
    public class Player
    {

        private Inventory inventory;
        public Inventory Inventory { get { return inventory; } }

        private int curHP;
        public int CurHP { get { return curHP; } set { curHP = value; } }
        private int maxHP;
        public int MaxHP { get { return maxHP; } set { maxHP = value; } }

        private int attack;
        public int Attack { get { return attack; } set { attack = value; } }

        private int defence;
        public int Defence { get { return defence; } set { defence = value; } }

        private int gold;
        public int Gold { get { return gold; } set { gold = value; } }

        private int intel;
        public int Intel { get { return intel; } set { intel = value; } }

        public Player()
        {
            inventory = new Inventory();
            
            maxHP = 50;
            curHP = maxHP;
        }
        public void Action(ConsoleKey input)
        {
            switch (input)
            {
                case ConsoleKey.I:
                    Inventory.Open();
                    break;
            }
        }
        public void Heal(int amount)
        {
            curHP += amount;
            if (curHP > maxHP)
            {
                curHP = maxHP;
            }
        }

        public void GetGold()
        {
            Util.PressAnyKey("골드를 획득했습니다");
            Gold += 10;
        }
    }
}
