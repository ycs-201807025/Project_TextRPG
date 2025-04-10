using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG.Monsters
{
    /// <summary>
    /// 몬스터 클래스
    /// </summary>
    public class Monster
    {
        public string name;
        public int level;
        public int hp;
        public int attack;
        public int defense;
        public int exp;
        public int gold;

        public Monster(string name, int level,int hp, int attack, int defense, int exp, int gold)
        {
            this.name = name;
            this.level = level;
            this.hp = hp;
            this.attack = attack;
            this.defense = defense;
            this.exp = exp;
            this.gold = gold;
        }
        public void hit(int damage)
        {
            hp -= damage;
    
        }
    }
}
