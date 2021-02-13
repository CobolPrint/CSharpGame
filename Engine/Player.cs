using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class Player : LivingThing
    {
        public int CurrentGold { get; set; }
        public int XP { get; set; }
        public int Lvl { get; set; }
    }

}
