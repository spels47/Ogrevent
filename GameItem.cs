using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgreVent
{
    public static class GameItem
    {
        public static Item[] GameItems = new Item[]
            {
                new Item("horseshoes",70,2,1),
                new Item("nails",30,1,1),
                new Item("carpenter tools",150,10,5),
                new Item("dagger",30,2,2,0,2),
                new Item("spear",50,4,0,0,5),
                new Item("shield",100,6),
                new Item("helmet",200,5),
                new Item("ration",3,1,1),
                new Item("vegetables",2,1,1),
                new Item("fruit",2,1,1),
                new Item("meat",5,1,1),
                new Item("waterskin",5,2,2),
                new Item("wooden holy symbol",3,2,2),
                new Item("silver ring",100,2,1),
                new Item("gold ring",500,3,1),
                new Item("silver necklace",200,2,1),
                new Item("gold necklace",700,3,1),
                new Item("signet ring",200,2,1),
                new Item("bottle of endless water",30000,2,2),
                new Item("ring of mighty strength",30000,2,1),
                new Item("talking chair",30000,4,6),
                new Item("talking donkey",30000,0),
                new Item("bag of holding",30000,5,2),
                new Item("ring of invisibility",30000,2,1),
                new Item("chainmail",500,7,0,10),
                new Item("leather armor",200,5,0,5),
                new Item("half plate",1000,17,0,15),
                new Item("full plate",2500,25,0,20),
                new Item("heavy shield",200,10),
                new Item("wanted poster",0,0,1),
                new Item("church key",0,1,1),
                new Item("church lantern",0,2,3),
                new Item("knights gear",0,20,0,15,7),
                new Item("backpack",50,2,1),
                new Item("mayors ring",0,0),
                new Item("wand of fireball", 300000, 0, 1),
                new Item("bottle of red wine", 300, 1, 1),
                new Item("bottle of white wine", 300, 1, 1),
                new Item("bottle of whiskey", 700, 1, 1),
                new Item("bottle of rum", 1000, 1, 1),
                new Item("bottle of fruit liqueur", 500, 1, 1),
                new Item("alchemical components", 200, 1, 1),
                new Item("alchemists tools", 1800, 5, 5)
            };
        public static bool RemoveItemFromInventory(string Name)
        {
            if (Program.CheckInventory(Name))
            {
                var item = GetItem(Name);
                Program.Inventory.Remove(item);
                Program.CurrentWeight -= item.MyWeight;
                Program.CurrentSpace -= item.MySpace;
                return true;
            }
            return false;
        }
        public static bool AddItemToInventory(string Name, bool CheckPrice = false)
        {
            var item = GetItem(Name);
            if (CheckPrice && Program.Money < item.MyValue) return false;
            if (Program.CheckCarryCapacity(item.MyWeight, item.MySpace))
            {
                Program.Inventory.Add(item);
                if (CheckPrice) Program.Money -= item.MyValue;
                return true;
            }
            return false;
        }
        public static Item GetItem(string Name)
        {
            return GameItems.Select(item => item).Where(item => item.MyName == Name).First();
        }
    }
}
