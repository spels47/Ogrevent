using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgreVent
{
    public class MagicShop
    {
        public static string Input()
        {
            return Console.ReadLine();
        }
        public static string MyAction;
        public static void Actions(string Action)
        {
            Random random = new Random();
            MyAction = Action;
            if (Program.Location == "Magic Shop")
            {
                switch (MyAction.ToUpper())
                {
                    case "LOOK FORWARD":
                        Poster.Post("In front of you," +
                            " is an assortment of unrecognizable objects of all categories neatly sorted and labeled in long shelves along the back wall," +
                            " with a sign hanging above the top shelf that says 'Tim`s enchanted power components'");
                        break;
                    case "LOOK LEFT":
                        Poster.Post("To your left," +
                            " are several display cabinets with wands and staffs laid on satin pillows barred behind glass." +
                            " Among the cabinets you see the shopkeep talking with some potential customers");
                        break;
                    case "LOOK RIGHT":
                        Poster.Post("To the right, you see a bookshelf filled with books and scrolls," +
                            " probably magic related books and scrolls." +
                            " Behind the bookshelf there is a stone altar with a flat plain top that is used as some sort of checkout counter");
                        break;
                    case "LOOK BEHIND":
                        Poster.Post("Behind you, is the way out");
                        break;
                    case "TALK TO SHOPKEEP":
                        Poster.Post("you walk up to the shopkeep");
                        if (Program.CheckInventory("bottle of endless water") ||
                           Program.CheckInventory("ring of mighty strength") ||
                           Program.CheckInventory("talking chair") ||
                           Program.CheckInventory("bag of holding") ||
                           Program.CheckInventory("ring of invisibility") ||
                           Program.CheckInventory("mayors ring"))
                        {
                            Poster.Post("the shopkeep looks at you with a somewhat withdrawn reaction, he asks if he can help you with anything");
                            Poster.Post("what do you talk to the seller about?");
                            Poster.Post("Prices");
                            string tempA = string.Empty;
                            tempA = Input().ToUpper();
                            if (tempA == "PRICES")
                            {
                                Poster.Post("Wand of Fireball: 3000 Gold");
                            }
                            else
                            {
                                Poster.Post("The Merchant has nothing to add on this topic");
                            }
                        }
                        else if(Program.CheckInventory("spear") && Program.CheckInventory("shield") ||
                            Program.CheckInventory("helmet") ||
                            Program.CheckInventory("silver ring") ||
                            Program.CheckInventory("gold ring") ||
                            Program.CheckInventory("silver necklace") ||
                            Program.CheckInventory("gold necklace") ||
                            Program.CheckInventory("signet ring") ||
                            Program.CheckInventory("chainmail") ||
                            Program.CheckInventory("leather armor") ||
                            Program.CheckInventory("half plate") ||
                            Program.CheckInventory("full plate") ||
                            Program.CheckInventory("heavy shield") ||
                            Program.CheckInventory("knights gear"))
                        {
                            Poster.Post("as you approach the merchant turns to you and says" +
                                " 'im sorry but i dont believe this establishment has the suitable wares to scintillate neither your desires nor your needs," +
                                " but please do tell of my shop to any magical friends," +
                                " family or colleagues you migiht have'");
                        }
                        else
                        {
                            Poster.Post("as you are about to greet the man," +
                                " his face turns and writhes between what could be interpreted as happiness," +
                                " then surprise," +
                                " then disgust," +
                                " and finally finds its resting pose in what you could only understand as either anger or frustration.");
                            Poster.Post("before you are able to utter a word the man says 'this is no place for vagabonds or whatever decrepit thing you elsewise might be, begone!'");
                            Poster.Post("the shopkeeper casts a spell on you compelling you to leave");
                            Poster.Post("you walk out of the store and back to the marketplace, where you sit down in some wet mud in a fetal position where you remain catatonic until the spell wears off", 2);
                            Program.Location = "Markedplace";
                        }
                        break;
                    case "STEAL":
                        Poster.Post("what do you attempt to steal?", 1);
                        Poster.Post();
                        string stealA = string.Empty;
                        stealA = Input().ToLower();
                        if (random.Next(1, 3) == 2 || Program.CheckInventory("ring of invisibility"))
                        {
                            if (GameItem.AddItemToInventory(stealA)) Poster.Post($"You have successfully stolen {stealA}");
                            else Poster.Post("You successfully steal the item but you have no way of carrying it, so you ditch it");
                        }
                        else
                        {
                            Poster.Post("You have been caught stealing and is beaten sensless by a bunch of mercenaries");
                            Program.Health--;
                        }
                        break;
                    case "BUY":
                        Poster.Post("What do you Purchase?");
                        string purchitem = string.Empty;
                        purchitem = Input();
                        if (GameItem.AddItemToInventory(purchitem, true))
                        {
                            var item = GameItem.GetItem(purchitem);
                            Poster.Post($"You Purchased {item.MyName}");
                        }
                        else Poster.Post("This item can not be purchased or you can not afford it, either way you walk away emptyhanded");
                        break;
                    case "SELL":
                        Poster.Post("What do you sell?", 1);
                        Poster.Post();
                        string sellitem = string.Empty;
                        sellitem = Input();
                        var result = GameItem.RemoveItemFromInventory(sellitem.ToLower());
                        if (result)
                        {
                            var item = GameItem.GetItem(sellitem);
                            Program.Money += (float)Math.Round(item.MyValue / 2f);
                            Poster.Post($"You Sold {item.MyName} for {Program.PrintValue((int)Math.Round(item.MyValue / 2f))}");
                        }
                        else
                        {
                            Poster.Post("This item can not be sold or you do not have it, either way you walk away no richer than before");
                        }
                        break;
                    case "EXIT STORE":
                        Poster.Post("You go back outside");
                        Program.Location = "Scholars Market";
                        break;
                    case "HELP":
                        Poster.Post("The commands below might also include actions that you havent discovered in the story yet " +
                            "\n or choices your character havent discovered yet " +
                            "\n so use them with caution as using actions you havent discovered in the story might come at the expense of your experience.");
                        Poster.Post("Current Input Opportunities:");
                        Poster.Post("Look Forward");
                        Poster.Post("Look Left", 0, false);
                        Poster.Post("Look Right", 0, false);
                        Poster.Post("Look Behind", 0, false);
                        Poster.Post("Talk To Shopkeep", 0, false);
                        Poster.Post("Steal", 0, false);
                        Poster.Post("Buy", 0, false);
                        Poster.Post("Sell", 0, false);
                        Poster.Post("Exit Store", 0, false);
                        break;
                    default:
                        Poster.Post("Sorry you cant do that right now, or possibly even ever!");
                        Poster.Post("If you are stuck you can use the 'Help' Command to view all possible inputs at the current moment", 0, false);
                        break;
                }
            }
        }
    }
}
