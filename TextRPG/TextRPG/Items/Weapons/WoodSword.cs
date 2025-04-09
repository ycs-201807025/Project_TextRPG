using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG.Items.Weapons
{
    class WoodSword : Weapon
    {
        public WoodSword()
        {
            attack = 5;
            name = "나무검";
            description = "나무로 만든 검 보기보다 튼튼하다";
            type = "Weapon";
        }
        public override void Use()
        {
            
        }
    }
   
}
