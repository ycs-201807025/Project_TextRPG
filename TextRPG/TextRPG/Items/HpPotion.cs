using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG.Items
{
    public class HpPotion : Item
    {
        public HpPotion()
        {
            name = "체력 회복 포션";
            description = "체력을 회복시켜주는 포션 아이템";
        }
        public override void Use()
        {
            Game.Player.Heal(30);
        }
    }
}
