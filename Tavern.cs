using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgreVent
{
    public class Tavern
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
            if (Program.Location == "Tavern")
            {
                switch (MyAction.ToUpper())
                {
                    case "LOOK FORWARD":
                        Poster.Post("In front of you theres the counter, behind the counter stands a tall handsome man wearing a nice but simple shirt with rolled up sleeves and dark pants, he has tattoos on his arms.\nThis would be the Barkeep.\nOn top of the counter there are all kinds of miscellaneous items such as glassware, spilt liquids, bugs both of the dead kind and the soon to be kind, the occational blunt dagger forcibly stuck into the counter top and one carving of a heart into the counter top with the text 'i love mom' inside");
                        break;
                    case "LOOK LEFT":
                        Poster.Post("To your left, you can see a staircase leading up to what is most likely bedrooms or private rooms the tavern holds off for richer regulars.\nThere is also a lot of tables many of the with 2 to 5 patrons drinking and talking and playing games of chance.\nNext to the staircase there are 2 barrels forming a narrow walkway that leads underneath the staircase where there is a small table and 3 kegs to sit on, the candle on the middle of the table is unused and rather dusty but there is recently used mugs on the table, the lighting in the tavern is considered dim lit but this corner is even darker than that.");
                        break;
                    case "LOOK RIGHT":
                        Poster.Post("To your right you can see a barmaid wandering through the thick smokelaiden room and patrons smoking and playing a game of cards, in the corner a bard sits on a high chair and plays his lute, the tune is not exactly upbeat.");
                        break;
                    case "LOOK BEHIND":
                        Poster.Post("Behind you, you can see private guards sitting around the exit, looking around for troublemakers, and a man sleeping at the table. His glass was half full until the barmaid came over and poured the remaining grog into a keg you are sure they also use when serving a fresh mug, some things can not be unseen.");
                        break;
                    case "TALK TO BARKEEP":
                        Poster.Post("What do you talk about?", 1);
                        Poster.Post("Local News", 0, false);
                        Poster.Post("Price for grog", 0, false);
                        Poster.Post("Price for stew", 0, false);
                        string LocalInput = Input();
                        Poster.Post();
                        if (LocalInput.ToUpper() == "LOCAL NEWS")
                        {
                            Poster.Post("Have you heard the farmers living along the edge of Brinewood demands that the lord raise a militia to deal with goblin raids on their farms, tshh they should see the rats in the slums here, theyre about the same size and about twice as ferocious as any goblin i ever served, erh i mean encountered. That reminds me, have you tried the stew? Its pretty descent.");
                        }
                        else if (LocalInput.ToUpper() == "PRICE FOR GROG")
                        {
                            Poster.Post("The grog costs 1 copper per mug, did i mention we also have stew?");
                        }
                        else if (LocalInput.ToUpper() == "PRICE FOR STEW")
                        {
                            Poster.Post("The stew costs 1 copper, eat your fill");
                        }
                        else
                        {
                            Poster.Post("The Barkeep has nothing to add on this subject");
                        }
                        break;
                    case "BUY GROG":
                        if (Program.Money > 1)
                        {
                            Poster.Post("You buy a mug of grog, you then take your time to drink it, for the price for a mug its not bad, but it is also very far from tasty", 1);
                            Program.Money--;
                        }
                        else
                        {
                            Poster.Post("You cannot afford this right now");
                        }
                        break;
                    case "BUY STEW":
                        if (Program.Money > 0)
                        {
                            Poster.Post("You buy stew it smells weird and its content is not even visually identifiable certain chunks come with a texture of overboiled fabric, whatever food is food right yet your stomach has never complained this much in its entire life before");
                            Program.Money--;
                            Program.time = 20;
                            if (Program.Money > 0)
                            {
                                Poster.Post("you buy a mug of grog to settle your stomach, it works ... kind of.", 1);
                                Program.Money--;
                            }
                            else
                            {
                                Poster.Post("You may have eaten something you shouldnt", 1);
                                if(random.Next(1,11) > 7) Program.Health--;
                            }
                        }
                        else
                        {
                            Poster.Post("You cannot afford this right now");
                        }
                        break;
                    case "SIT UNDER STAIRS":
                        Poster.Post("You sit down under the staircase and a man... or what you think is a man, sits down with you shortly after. with a rough as gravel voice the creature utters 'do you want to buy Fleggersh?'\nwhat do you say?", 1);
                        string TempInput = Input();
                        if (TempInput.ToUpper() == "YES")
                        {
                            if (Program.Money >= 2)
                            {
                                Poster.Post("you recieve a weird mushroom rolled up in a leaf you dont recognize, you eat it. You go on wild adventures and lose track of time, though you remain seated.", 3);
                                Program.Health--;
                                Program.Money -= 2;
                            }
                            else
                            {
                                Poster.Post("You cant afford what the creature is selling, the creature hisses at you as he walks away back to whatever place he came from");
                            }
                        }
                        else if (TempInput.ToUpper() == "NO")
                        {
                            Poster.Post("The man gets up and leaves, for all you know he has blended in with the room or gone to wherever he came from for he is not to be seen anywhere once he leaves your sight");
                        }
                        else
                        {
                            Poster.Post("What? he gets up and leaves");
                        }
                        break;
                    case "PLAY CARDS":
                        Poster.Post("You sit down at the table with the other fellas playing and having a good time");
                        int BetAmount;
                        string AnotherHandAnswer = null;
                        while(AnotherHandAnswer == null || AnotherHandAnswer.ToUpper() == "YES")
                        {
                            Poster.Post("How many coppers do you bet?");
                            Int32.TryParse(Input(), out BetAmount);
                            if (Program.Money < BetAmount)
                            {
                                Poster.Post("Sorry you dont have that much money, you are asked to leave the table");
                            }
                            else
                            {
                                if (random.Next(1, 7) == 6)
                                {
                                    Poster.Post("You Win this hand", 1);
                                    Program.Money += (float)Math.Round(BetAmount * 1.5);
                                    Program.BeltPouch();
                                }
                                else
                                {
                                    Poster.Post("You lose this hand", 1);
                                    Program.Money -= BetAmount;
                                    Program.BeltPouch();
                                }
                            }
                            Poster.Post("Another Hand?");
                            AnotherHandAnswer = Input();
                        }
                        break;
                    case "LEAVE":
                        Poster.Post("You leave the tavern and return to the Markedplace");
                        Program.Location = "Markedplace";
                        break;
                    case "HELP":
                        Poster.Post("The commands below might also include actions that you havent discovered in the story yet \n or choices your character havent discovered yet \n so use them with caution as using actions you havent discovered in the story might come at the expense of your experience.");
                        Poster.Post("Current Input Opportunities:");
                        Poster.Post("Look Forward");
                        Poster.Post("Look Left", 0, false);
                        Poster.Post("Look Right", 0, false);
                        Poster.Post("Look Behind", 0, false);
                        Poster.Post("Talk to Barkeep", 0, false);
                        Poster.Post("Buy Grog", 0, false);
                        Poster.Post("Buy Stew", 0, false);
                        Poster.Post("Sit Under Stairs", 0, false);
                        Poster.Post("Play Cards", 0, false);
                        Poster.Post("Leave", 0, false);
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
