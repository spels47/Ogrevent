using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgreVent
{
    public class TobacconistShop
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
            if (Program.Location == "Tobacconist Shop")
            {
                switch (MyAction.ToUpper())
                {
                    case "LOOK FORWARD":
                        Poster.Post("In front of you," +
                            " are wooden boxes on display containing cigars of different widths and colors and scents");
                        break;
                    case "LOOK LEFT":
                        Poster.Post("To your left," +
                            " you can see platters attached to chains in the ceiling with various cigarretes and chewing tobacco propped up on them for display");
                        break;
                    case "LOOK RIGHT":
                        Poster.Post("To the right," +
                            " is a shelf filled with small jars labeled" +
                            " 'Herbal Pleasures Of Supernatural Relaxation And Inner Peace'" +
                            " you also find the shopkeeper next to this shelf," +
                            " he is currently amidst rolling a form of long cigarette" +
                            " using tobacco from this shelf before he seals them individually in empty wine bottles");
                        break;
                    case "LOOK BEHIND":
                        Poster.Post("Behind you, is the way out");
                        break;
                    case "TALK TO SHOPKEEP":
                        Poster.Post("you walk up to the shopkeep");
                        Poster.Post("the shopkeep turns towards you by rotating" +
                            " around his own axis on his heel in a relaxed and suave manner," +
                            " then he says 'so what are you huffing for, for i have got what you could be puffing on'");
                        Poster.Post("what do you talk to the seller about?");
                        Poster.Post("Prices");
                        string tempA = string.Empty;
                        tempA = Input().ToUpper();
                        if (tempA == "PRICES")
                        {
                            Poster.Post("Tobacco: 5 Gold");
                        }
                        else
                        {
                            Poster.Post("The Merchant has nothing to add on this topic");
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
