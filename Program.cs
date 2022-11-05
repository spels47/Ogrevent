using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;

namespace OgreVent
{
    class Program
    {
        public static string Location = "Markedplace";
        public static List<Item> Inventory = new List<Item>();
        public static int Health = 3;
        public static int CurrentWeight = 0;
        public static int CurrentSpace = 0;
        public static float Money = 0;
        public static int time = 20;

        public static int Time(int TimePassed = 0)
        {
            time -= TimePassed;
            if (time < 1 && EatAndDrink())
            {
                time = 20;
            }
            else if(time < 1)
            {
                time = 5;
            }
            return time;
        }

        public static bool EatAndDrink()
        {
            if(Inventory.Count == 0)
            {
                Poster.Post("Your tummy rumbles, and you realise you have no food, you will starve like the peasant you are, for now all you can do is swallow the pain and soldier on");
                Health--;
                return false;
            }
            foreach (Item item in Inventory)
            {
                if (item.MyName == "ration" || item.MyName == "vegetables" || item.MyName == "fruit" || item.MyName == "meat" || item.MyName == "waterskin")
                {
                    Poster.Post($"You are hungry or thirsty, maybe even both. You stop and take a break and you enjoy your {item.MyName} before you continue your adventure.");
                    Inventory.Remove(item);
                    return true;
                }
                else if(item.MyName == "bottle of endless water")
                {
                    Poster.Post($"You are thirsty, you drink your fill from your {item.MyName} before you tuck it away. You are unsure wether you drank from the bottle or the bottle drank from you, it is the strangest most indescribable drinking experience you have had");
                    return true;
                }
                else if(Inventory.Last() == item)
                {
                    Poster.Post("Your tummy rumbles, and you realise you have no food, you will starve like the peasant you are, for now all you can do is swallow the pain and soldier on");
                    Health--;
                    return false;
                }
            }
            return false;
        }

        public static string Input()
        {
            Poster.Post();
            Console.Write("Action: ");
            return Console.ReadLine();
        }

        static public bool CheckInventory(string ItemName)
        {
            for (int i = 0; i < Inventory.ToArray().Length; i++)
            {
                if (Inventory[i].MyName == ItemName)
                {
                    return true;
                }
                else if (Inventory.ToArray().Length == 0)
                {
                    return false;
                }
                else if (i == Inventory.ToArray().Length - 1)
                {
                    return false;
                }
            }
            return false;
        }

        static public bool CheckCarryCapacity(int ItemWeight, int ItemSpace)
        {
            if (CurrentWeight + ItemWeight <= CarryingCapacity())
            {
                if (CurrentSpace + ItemSpace <= CarrySpace())
                {
                    CurrentWeight += ItemWeight;
                    CurrentSpace += ItemSpace;
                    return true;
                }
                else
                {
                    Poster.Post("you do not have the space for this, did you think you were gonna keister it?");
                    return false;
                }

            }
            else
            {
                Poster.Post("Your feeble peasant body cannot handle the encumbering weight of this item and the weight of your inventory combined");
                return false;
            }
        }

        static public int CarryingCapacity()
        {
            int carryingCapacity = 30;
            foreach (Item item in Inventory)
            {
                if (item.MyName == "backpack")
                {
                    carryingCapacity += 15;
                    break;
                }
            }
            foreach (Item item in Inventory)
            {
                if (item.MyName == "ring of mighty strength")
                {
                    carryingCapacity += 20;
                    break;
                }
            }
            return carryingCapacity;
        }
        static public int CarrySpace()
        {
            int carrySpace = 10;
            foreach (Item item in Inventory)
            {
                if (item.MyName == "backpack")
                {
                    carrySpace += 20;
                    break;
                }
            }
            return carrySpace;
        }

        public static string PrintValue(int Value)
        {
            string Bucks = Value.ToString();
            if (Bucks.Length == 1)
            {
                return $"{Value} Copper";
            }
            if (Bucks.Length == 2)
            {
                return $"{Bucks[0]} Silver\n{Bucks[1]} Copper";
            }
            if (Bucks.Length == 3)
            {
                return $"{Bucks[0]} Gold\n{Bucks[1]} Silver\n{Bucks[2]} Copper";
            }
            if (Bucks.Length == 4)
            {
                return $"{Bucks[0]}{Bucks[1]} Gold\n{Bucks[2]} Silver\n{Bucks[3]} Copper";
            }
            if (Bucks.Length == 5)
            {
                return $"{Bucks[0]}{Bucks[1]}{Bucks[2]} Gold\n{Bucks[3]} Silver\n{Bucks[4]} Copper";
            }
            if (Bucks.Length == 6)
            {
                return $"{Bucks[0]}{Bucks[1]}{Bucks[2]}{Bucks[3]} Gold\n{Bucks[4]} Silver\n{Bucks[5]} Copper";
            }
            return string.Empty;
        }

        public static void BeltPouch()
        {
            string Bucks = Money.ToString();
            Poster.Post("Belt Pouch:");
            if (Bucks.Length == 1)
            {
                Poster.Post($"{Money} Copper");
            }
            if (Bucks.Length == 2)
            {
                Poster.Post($"{Bucks[0]} Silver");
                Poster.Post($"{Bucks[1]} Copper", 0, false);
            }
            if (Bucks.Length == 3)
            {
                Poster.Post($"{Bucks[0]} Gold");
                Poster.Post($"{Bucks[1]} Silver", 0, false);
                Poster.Post($"{Bucks[2]} Copper", 0, false);
            }
            if (Bucks.Length == 4)
            {
                Poster.Post($"{Bucks[0]}{Bucks[1]} Gold");
                Poster.Post($"{Bucks[2]} Silver", 0, false);
                Poster.Post($"{Bucks[3]} Copper", 0, false);
            }
            if (Bucks.Length == 5)
            {
                Poster.Post($"{Bucks[0]}{Bucks[1]}{Bucks[2]} Gold");
                Poster.Post($"{Bucks[3]} Silver", 0, false);
                Poster.Post($"{Bucks[4]} Copper", 0, false);
            }
            if (Bucks.Length == 6)
            {
                Poster.Post($"{Bucks[0]}{Bucks[1]}{Bucks[2]}{Bucks[3]} Gold");
                Poster.Post($"{Bucks[4]} Silver", 0, false);
                Poster.Post($"{Bucks[5]} Copper", 0, false);
            }
        }

        public static bool IsAlive = true;

        static void Main()
        {
            Poster.PrintTitle();
            Poster.Post();
            Poster.Post();
            Poster.Post();
            Poster.Post();
            Poster.PrintIntro();
            Poster.Post();
            Poster.Post("To check your inventory use 'inventory' to check how much money you have use 'money' to drop an item use 'drop item' otherwise actions are simple they\ncome in the form of 2 to 3 phrase long commands for example 'look left', have fun");
            
            Random random = new Random();
            string MyAction;
            while (IsAlive)
            {
                if (Health <= 0)
                {
                    IsAlive = false;
                    break;
                }


                MyAction = Input();

                if (MyAction.ToUpper() == "INVENTORY")
                {
                    Poster.Post("Inventory:");
                    foreach (Item Item in Inventory.ToArray())
                    {
                        Poster.Post(Item.MyName, 0, false);
                    }
                    Poster.Post($"you are currently carrying {CurrentWeight} Kg, and it takes up {CurrentSpace} amount of space in your inventory out of {CarrySpace()}. You can also carry a total weight of {CarryingCapacity()} Kg.");
                    continue;
                }

                if (MyAction.ToUpper() == "DROP ITEM")
                {
                    Poster.Post("what item would you like to drop?");
                    Console.Write("Item: ");
                    string DropItem = Console.ReadLine();
                    for (int i = 0; i < Inventory.ToArray().Length; i++)
                    {
                        if (Inventory[i].MyName == DropItem.ToLower())
                        {
                            Poster.Post($"you dropped {Inventory[i].MyName}");
                            CurrentWeight -= Inventory[i].MyWeight;
                            CurrentSpace -= Inventory[i].MySpace;
                            Inventory.Remove(Inventory[i]);
                            break;
                        }
                        if (i == Inventory.ToArray().Length - 1 && Inventory[i].MyName != DropItem)
                        {
                            Poster.Post("sorry no item by that name");
                            break;
                        }
                    }
                    continue;
                }

                if (MyAction.ToUpper() == "MONEY")
                {
                    BeltPouch();
                    continue;
                }

                if (MyAction.ToUpper() == "ADD MONEY")
                {
                    Money += 1000;
                    Poster.Post("Added 10 Gold");
                    continue;
                }

                if (Location == "Markedplace")
                {
                    MarkedPlace.Actions(MyAction.ToUpper());
                    continue;
                }
                else if (Location == "Church")
                {
                    Church.Actions(MyAction.ToUpper());
                    continue;
                }
                else if (Location == "Tavern")
                {
                    Tavern.Actions(MyAction.ToUpper());
                    continue;
                }
                else if (Location == "Town Hall")
                {
                    TownHall.Actions(MyAction.ToUpper());
                    continue;
                }
                else if (Location == "Chestlock Guild Hall")
                {
                    ChestlockGuildHall.Actions(MyAction.ToUpper());
                    continue;
                }
                else if (Location == "Hunters Lodge")
                {
                    HuntersLodge.Actions(MyAction.ToUpper());
                    continue;
                }
                else if (Location == "Brinewood Forest")
                {
                    BrinewoodForest.Actions(MyAction.ToUpper());
                    continue;
                }
                else if (Location == "Scholars Market")
                {
                    ScholarsMarket.Actions(MyAction.ToUpper());
                    continue;
                }
                else if (Location == "Magic Shop")
                {
                    MagicShop.Actions(MyAction.ToUpper());
                    continue;
                }
                else if (Location == "Imported Spirits Shop")
                {
                    ImportedSpiritsShop.Actions(MyAction.ToUpper());
                    continue;
                }
                else if (Location == "Alchemist Shop")
                {
                    AlchemistShop.Actions(MyAction.ToUpper());
                    continue;
                }
                else if (Location == "Tobacconist Shop")
                {
                    TobacconistShop.Actions(MyAction.ToUpper());
                    continue;
                }
                else if (Location == "Demon Pit")
                {
                    DemonPit.Actions(MyAction.ToUpper());
                    continue;
                }
                else if (Location == "Inside Pit")
                {
                    InsidePit.Actions(MyAction.ToUpper());
                    continue;
                }
                else if (Location == "Inside Pit Level 2")
                {
                    InsidePitLevel2.Actions(MyAction.ToUpper());
                    continue;
                }
                else if (Location == "Inside Pit Level 3")
                {
                    InsidePitLevel3.Actions(MyAction.ToUpper());
                    continue;
                }
                else if (Location == "Inside Pit Level 4")
                {
                    InsidePitLevel4.Actions(MyAction.ToUpper());
                    continue;
                }
                else if (Location == "Inside Pit Level 5")
                {
                    InsidePitLevel5.Actions(MyAction.ToUpper());
                    continue;
                }
                else if (Location == "Mayors Office")
                {
                    MayorsOffice.Actions(MyAction.ToUpper());
                    continue;
                }
            }
            Poster.Post("You are Dead, you will not be remembered, you will not pass into legend. You shall fade into the nothingness of wich you came.");
            Poster.Post();
            Thread.Sleep(20000);
        }
    }
}
