using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class LivingThing
    {
        public int CurrentHP { get; set; }
        public int MaxHP { get; set; }

        public LivingThing (int currentHP, int maxHP)
        {
            CurrentHP = currentHP;
            MaxHP = maxHP;
        }

    }
}
