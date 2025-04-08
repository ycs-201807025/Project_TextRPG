﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    public abstract class Item
    {
        public string name;
        public string description;

        public abstract void Use();
        
    }
}
