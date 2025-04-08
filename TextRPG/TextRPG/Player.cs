using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    public class Player
    {

        private Inventory inventory;
        public Inventory Inventory { get { return Inventory; } }

        private int curHP;
        public int CurHP { get { return curHP; } }
        private int maxHP;
        public int MaxHP { get { return maxHP; } }

        public Player()
        {
            inventory = new Inventory();
            maxHP = 50;
            curHP = maxHP;
        }
        public void Heal(int amount)
        {
            curHP += amount;
            if (curHP > maxHP)
            {
                curHP = maxHP;
            }
        }
    }
}
