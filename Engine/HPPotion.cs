using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class HPPotion : Item
    {
        public int AmountToHeal { get; set; }

        public HPPotion(int id, string name, string namePlural, int amountToHeal) : base(id, name, namePlural)
        {
            AmountToHeal = amountToHeal;
            ID = id;
            Name = name;
            NamePlural = namePlural;
        }
    }
}
