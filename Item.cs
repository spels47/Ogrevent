using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgreVent
{
    public class Item
    {
        public string MyName;
        public int MyValue;
        public int MyWeight;
        public int MyArmor;
        public int MyDamage;
        public int MySpace;
        public Item(string Name, int Value, int Weight, int Space = 0, int Armor = 0, int Damage = 0)
        {
            MyName = Name;
            MyValue = Value;
            MyWeight = Weight;
            MyArmor = Armor;
            MyDamage = Damage;
            MySpace = Space;
        }
    }
}
