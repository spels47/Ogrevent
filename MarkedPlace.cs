using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgreVent
{
    public class MarkedPlace
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
            if (Program.Location == "Markedplace")
            {
                switch (MyAction.ToUpper())
                {
                    case "LOOK LEFT":
                        Poster.Post("To your left you can see a thriving markedplace it is currently early in the morning and most of the merchants have set up their stand and started their day while some tardy merchants are still arriving or in the middle of setting up their stand, in the center of the markedplace there is a rather spacious well with a steady stream of locals regularly retrieving water from it. on the marketplace there is a merchant who sells fresh meat and vegetables from local hunters and farmers, another who sells jewelry and other trinkets, one who seems to sell metalworks mostly tools some weapons, mostly horseshoes and carpentry nails, and one merchant who you cant really say what he is selling, seems like a little bit of this a little bit of that probably just a load of junk, and a merchant who hasnt completely set up his stand just yet who sells armor and good shoes and backpacks fit for the most travel hungry adventurer.");
                        break;
                    case "LOOK RIGHT":
                        Poster.Post("To your right you can see the chapel where youre late master Yellegor Yellowflag was taken for burial preperations as he was a lesser nobleman, not just some mere peasant like yourself. Outside the chapel the flaggelant militia of the holy order of the Phoenix stands guard in rough tattered clothing seemingly non uniform with the exception of the holy symbol representing their god and their order hanging around their necks, the symbols are made of wood. they carry spears and several of them is munching on a loaf of bread in the current moment. the chapels reinforced front entrance is open and the puplic is seemingly free to enter and leave at their own behest.");
                        break;
                    case "LOOK FORWARD":
                        if(Program.CheckInventory("wanted poster")) Poster.Post("You are currently facing the Rusty Shovel, a local tavern renowned for their cheap grog");
                        else Poster.Post("You are currently facing the wanted poster of the ogre, the poster is hanging on the wall to the left hand side of the entrance to the Rusty Shovel, a local tavern renowned for their cheap grog");
                        break;
                    case "LOOK BEHIND":
                        Poster.Post("You see the main road in and out of this markedplace, it is rather spacious compared to the standards of the inner city you would think it is about 7 meters wide. Down the road you can see the silhouette of a guard tower basking in the morning sun.");
                        break;
                    case "JUMP DOWN THE WELL":
                        Poster.Post("You throw your body over the side of the well and you fall and bruise youself along the slippery sides until you hit the water with a splash your leg is caught in the bucket and your entire body is flipped upside down as your head hits the hard bottom of the well you gasp for air and take in water, after much struggling you manage to get out of the well with the help of the locals. Some people in the marketplace is giving you weird looks. Why you would ever do this is beyond you", 1);
                        Program.Health--;
                        break;
                    case "TALK TO METALWORKS MERCHANT":
                        Poster.Post("what do you talk about?", 1);
                        Poster.Post("Prices");
                        Poster.Post("Local Places", 0, false);
                        string tempA = string.Empty;
                        tempA = Input().ToUpper();
                        if (tempA == "PRICES")
                        {
                            Poster.Post("Horseshoes: 7 Silver");
                            Poster.Post("Nails: 3 Silver", 0, false);
                            Poster.Post("Carpenter Tools: 1 Gold 5 Silver", 0, false);
                            Poster.Post("Dagger: 3 Silver", 0, false);
                            Poster.Post("Spear: 5 Silver", 0, false);
                            Poster.Post("Shield: 1 Gold", 0, false);
                            Poster.Post("Helmet: 2 Gold", 0, false);
                        }
                        else if (tempA == "LOCAL PLACES")
                        {
                            Poster.Post("In the city there is The Town Hall, where the ruling class sits and discuss and decide various matters.\n And then there is The ChestLock Guild, which is originally a merchants guild but also own multiple Banks both here and elsewhere. They have a Guild Hall in town that doubles as a Bank.\n There is also a sort of indoor bazaar where you can find this citys most renowned \n alchemist shop,\n magic shop,\n tobacconist\n and\n imported spirits seller");
                        }
                        else
                        {
                            Poster.Post("The Merchant has nothing to add on this topic");
                        }
                        break;
                    case "TALK TO FOOD MERCHANT":
                        Poster.Post("what do you talk about?",1);
                        Poster.Post("Prices");
                        Poster.Post("Local Places", 0, false);
                        string tempB = string.Empty;
                        tempB = Input().ToUpper();
                        if (tempB == "PRICES")
                        {
                            Poster.Post("Ration: 3 coppers");
                            Poster.Post("Vegetables: 2 coppers", 0, false);
                            Poster.Post("Fruit: 2 coppers", 0, false);
                            Poster.Post("Meat: 5 coppers", 0, false);
                            Poster.Post("Waterskin: 5 coppers", 0, false);
                        }
                        else if (tempB == "LOCAL PLACES")
                        {
                            Poster.Post("Well there is The Town Hall, where the council decides various matters.\n And then there is The ChestLock Guild, which is a great merchants guild. They have a Guild Hall in town.\n There is also a group of shops that share a pretty large building the \n alchemist shop,\n magic shop,\n tobacconist\n and\n imported spirits seller\n i believe it was, if you are into that sort of stuff.\n Last but not least there is the Hunters Lodge located in Brinewood forest its a 2 hour walk there");
                        }
                        else
                        {
                            Poster.Post("The Merchant has nothing to add on this topic");
                        }
                        break;
                    case "TALK TO JEWELRY MERCHANT":
                        Poster.Post("what do you talk about?", 1);
                        Poster.Post("Prices");
                        Poster.Post("Local Places", 0, false);
                        string tempC = string.Empty;
                        tempC = Input().ToUpper();
                        if (tempC == "PRICES")
                        {
                            Poster.Post("Wooden Holy Symbol: 3 coppers");
                            Poster.Post("Silver Ring: 1 Gold", 0, false);
                            Poster.Post("Gold Ring: 5 Gold", 0, false);
                            Poster.Post("Silver Necklace: 2 Gold", 0, false);
                            Poster.Post("Gold Necklace: 7 Gold", 0, false);
                            Poster.Post("Signet Ring: 2 Gold", 0, false);
                        }
                        else if (tempC == "LOCAL PLACES")
                        {
                            Poster.Post("Well there is The Town Hall, where matters are decided.\n And then there is ChestLock Bank, a safe place for your valuables, guaranteed.\n There is also the Scholars Market they have pretty good tobacco, i will tell you where in town you can find them.");
                        }
                        else
                        {
                            Poster.Post("The Merchant has nothing to add on this topic");
                        }
                        break;
                    case "TALK TO JUNK MERCHANT":
                        Poster.Post("what do you talk about?", 1);
                        Poster.Post("Prices");
                        Poster.Post("What do you sell?", 0, false);
                        string tempD = string.Empty;
                        tempD = Input().ToUpper();
                        if (tempD == "PRICES")
                        {
                            Poster.Post("Bottle of Endless Water: 300 Gold");
                            Poster.Post("Ring of Mighty Strength: 300 Gold", 0, false);
                            Poster.Post("Talking Chair: 300 Gold", 0, false);
                            Poster.Post("Talking Donkey: 300 Gold", 0, false);
                            Poster.Post("Bag of Holding: 300 Gold", 0, false);
                            Poster.Post("Ring of Invisibility: 300 Gold", 0, false);
                        }
                        else if (tempD == "WHAT DO YOU SELL?")
                        {
                            Poster.Post("I sell artifacts many of them ancient, they might look simple or mundane but they hold great and unique powers, but one can not make a living of just aquiring and studying them, so i sell them if you have the coin.");
                        }
                        else
                        {
                            Poster.Post("The Merchant has nothing to add on this topic");
                        }
                        break;
                    case "TALK TO ARMOR MERCHANT":
                        Poster.Post("what do you talk about?", 1);
                        Poster.Post("Prices");
                        Poster.Post("Who Makes It?", 0, false);
                        string tempE = string.Empty;
                        tempE = Input().ToUpper();
                        if (tempE == "PRICES")
                        {
                            Poster.Post("Chainmail: 5 Gold");
                            Poster.Post("Leather Armor: 2 Gold", 0, false);
                            Poster.Post("Half Plate: 10 Gold", 0, false);
                            Poster.Post("Full Plate: 25 Gold", 0, false);
                            Poster.Post("Shield: 2 Gold", 0, false);
                            Poster.Post("Backpack: 5 Silver", 0, false);
                        }
                        else if (tempE == "WHO MAKES IT?")
                        {
                            Poster.Post("That good sir is a trade secret but my wares are of supreme craftmanship, that i can assure you");
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
                        if(random.Next(1, 3) == 2 || Program.CheckInventory("ring of invisibility"))
                        {
                            if (GameItem.AddItemToInventory(stealA)) Poster.Post($"You have successfully stolen {stealA}");
                            else Poster.Post("You successfully steal the item but you have no way of carrying it, so you ditch it in some nearby bushes");
                        }
                        else
                        {
                            Poster.Post("You have been caught stealing and is beaten by the merchants and a kid");
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
                    case "TAKE WANTED POSTER":
                        if (Program.CheckInventory("wanted poster"))
                        {
                            Poster.Post("You already have it");
                        }
                        else if (GlobalBools.TookWantedPoster)
                        {
                            Poster.Post("You remember that you had already ripped the wanted poster off the wall, and then you got rid of it, it is now lost to you forever");
                        }
                        else
                        {
                            if (GameItem.AddItemToInventory("wanted poster")) 
                            {
                                Poster.Post("You rip the poster off the wall and stuff it into your filthy peasant pockets");
                                GlobalBools.TookWantedPoster = true;
                            }
                            else Poster.Post("Your pockets seem to be filled with other useless crap and you dont seem to find the space for the note");
                        }
                        break;
                    case "GO INTO CHURCH":
                        Poster.Post("You walk past the church militia and enter the armory, you are now inside the church");
                        Program.Location = "Church";
                        break;
                    case "ENTER TAVERN":
                        Poster.Post("You open the door and the scent of tobacco hits your face as you enter the dimlit establishment and walk up to the counter");
                        Program.Location = "Tavern";
                        break;
                    case "GO TO TOWN HALL":
                        Poster.Post("You walk to the Town Hall located in the northern part of town,\n as you stand outside the Town Hall you notice that there are more guards here, the people look, walk and talk in a way that would suggest they come from wealth.\n The Town Hall itself has a bell tower with a spire. The Hall is made out of stone for the most part but the stone is painted white, however the spire is made out of wood and is seemingly the only major part of the Hall that is made of wood.", 2);
                        Program.Location = "Town Hall";
                        break;
                    case "GO TO CHESTLOCK GUILD HALL":
                        Poster.Post("You walk to the Chestlock Guild Hall, as you arrive you find that the Guild Hall is actually a Fort with crenellations and everything with a Guild Hall instead of barracks and storage houses instead of stables and other normal structures to be found in a more tradiotional fort.\n And all this inside the city, there is a steady flow of people entering and leaving the Forts gate, and the guards standing by the gate and above on the wall seem ever so vigilant.", 2);
                        Program.Location = "Chestlock Guild Hall";
                        break;
                    case "GO TO HUNTERS LODGE":
                        Poster.Post("You walk to the Hunters Lodge, there you find a man chopping firewood.\n The Lodge itself takes form in a large cabin it looks rather cozy and homely.", 4);
                        Program.Location = "Hunters Lodge";
                        break;
                    case "GO TO BRINEWOOD FOREST":
                        Poster.Post("You walk to Brinewood Forest, you now stand in the forest there are sounds of birds in the trees, there are moss covered rocks and everything seems calm.", 3);
                        Program.Location = "Brinewood Forest";
                        break;
                    case "GO TO SCHOLARS MARKET":
                        Poster.Post("You walk to the Scholars Market, the outside area would make you think of this as a street of townhouses but you notice a sign hanging above one of the doors saying 'The Scholars Market'\n. As you enter you understand that this might have at some point been a street of townhouses but has been later turned into a set of shops located on the same floor under one roof, and not just this street the houses that would have been on the next street aswell making this a rather sizable place.\n The smells in the air are varied and exotic", 2);
                        Program.Location = "Scholars Market";
                        break;
                    case "HELP":
                        Poster.Post("The commands below might also include actions that you havent discovered in the story yet \n or choices your character havent discovered yet \n so use them with caution as using actions you havent discovered in the story might come at the expense of your experience.");
                        Poster.Post("Current Input Opportunities:");
                        Poster.Post("Look Left");
                        Poster.Post("Look Right", 0, false);
                        Poster.Post("Look Forward", 0, false);
                        Poster.Post("Look Behind", 0, false);
                        Poster.Post("Jump Down The Well", 0, false);
                        Poster.Post("Talk to Metalworks Merchant", 0, false);
                        Poster.Post("Talk to Food Merchant", 0, false);
                        Poster.Post("Talk to Jewelry merchant", 0, false);
                        Poster.Post("Talk to Junk Merchant", 0, false);
                        Poster.Post("Talk to Armor Merchant", 0, false);
                        Poster.Post("Steal", 0, false);
                        Poster.Post("Buy", 0, false);
                        Poster.Post("Go Into Church", 0, false);
                        Poster.Post("Take Wanted Poster", 0, false);
                        Poster.Post("Sell", 0, false);
                        Poster.Post("Enter Tavern", 0, false);
                        Poster.Post("Go To Town Hall", 0, false);
                        Poster.Post("Go To Chestlock Guild Hall", 0, false);
                        Poster.Post("Go To Hunters Lodge", 0, false);
                        Poster.Post("Go To Brinewood Forest", 0, false);
                        Poster.Post("Go To Scholars Market", 0, false);
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
