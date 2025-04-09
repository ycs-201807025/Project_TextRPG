using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextRPG.Items.Consums;

namespace TextRPG.Items
{
    public class HpPotion : Consume
    {
        public HpPotion()
        {
            name = "체력 회복 포션";
            description = "체력을 회복시켜주는 포션 아이템";
            type = "Consume";
        }
        public override void Use()
        {
            Game.Player.Heal(30);
        }
    }
}
