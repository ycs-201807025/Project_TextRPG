using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG.Monsters
{
    class MonsterFactory
    {
        public Monster CreateMonster(string name)
        {
            Monster monster;
            switch (name)
            {
                case "슬라임":  monster = new Monster("슬라임",1,10,3,1,1,10); break;

                default: return null;
            }
            return monster;
        }
    }
}
