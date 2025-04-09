using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG.Items.Armors
{
    public class LeatherArmor : Armor
    {
        public LeatherArmor()
        {
            defense = 5;
            hp = 10;
            name = "가죽 갑옷";
            description = "가죽으로 만든 갑옷";
            type = "Armor";
        }
    }
}
