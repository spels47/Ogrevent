using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OgreVent
{
    public class InsidePitLevel3
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

            if (Program.Location == "Inside Pit Level 3")
            {
                if (Console.ForegroundColor == ConsoleColor.Gray) Console.ForegroundColor = ConsoleColor.DarkGray;
                switch (MyAction.ToUpper())
                {
                    case "LOOK FORWARD":
                        Poster.Post("Ahead, you see the staircase continuing down into the darkness");
                        break;
                    case "LOOK LEFT":
                        Poster.Post("To your left is the edge of the staircase towards the center of the pit");
                        break;
                    case "LOOK RIGHT":
                        Poster.Post("To your right," +
                            " you notice that the content in the shelves has changed," +
                            " while still being filled with an extraordinary quantity of papers in various forms," +
                            " the majority of the space is taken up by large wooden boxes that resembles coffins," +
                            " at a closer inspection you confirm that these wooden boxes are indeed coffins," +
                            " why they would be here and not in the cemetary as is customary is beyond your feeble comprehension");
                        break;
                    case "LOOK BEHIND":
                        Poster.Post("You look back up the staircase," +
                            " with a wanting to leave and be done with the horror and fear you have for this place and all of its absurdity," +
                            " but you know what they say about curiosity," +
                            " curiosity is lying in wait for every secret");
                        break;
                    case "JUMP DOWN":
                        Poster.Post("You throw yourself over the side into the center of the pit," +
                            " you fall far," +
                            " you fall fast," +
                            " you fall for a long time," +
                            " before you are finally awarded with the discovery of the bottom.");
                        Program.IsAlive = false;
                        break;
                    case "OPEN COFFIN":
                        if (!GlobalBools.CoffinInspected)
                        {
                            Poster.Post("You pull the coffin out of the shelf," +
                            " papers and books come flying out with it and with an echoing thunk the coffin lands on the staircase in front of your feet.");
                            if (Program.CheckInventory("carpenter tools"))
                            {
                                Poster.Post("You get out your carpenter tools and begin pulling the nails out of the coffin," +
                                    " after a while you have pulled all the nails out and you remove the lid from the coffin", 0, false);
                            }
                            else if (Program.CheckInventory("dagger"))
                            {
                                Poster.Post("You get out your dagger and begin to jimmy the lid open," +
                                    " it takes you a while since there was used an extraordinary amount of nails to seal this coffin shut", 0, false);
                            }
                            else
                            {
                                Poster.Post("The coffin is nailed shut and you have no ordinary means of gaining entrance to its contents," +
                                    " if you only had some tools appropriate", 0, false);
                                break;
                            }
                            Poster.Post("within the the coffin you find a half rotten corpse," +
                                " you take particular notice of the unholy symbol around the neck of the corpse," +
                                " and the signet ring on one of its hands," +
                                " you decide to take the ring", 0, false);
                            Thread.Sleep(3000);
                            if (!GameItem.AddItemToInventory("signet ring"))
                            {
                                Poster.Post("You however seem to have filled your pockets to the brim," +
                                    " instead you spend a few moments simply admiring it", 0, false);
                            }
                            Poster.Post("YOU COULD SWEAR TO GOD THAT BODY JUST MOVED ON ITS OWN");
                            Poster.Post("you quickly close the lid shut and and trample the nails good and deep back into the moldy coffin," +
                                " the coffin is ..." +
                                " just sitting there," +
                                " silent as the grave," +
                                " frightened you shove the coffin back where it came from");
                            GlobalBools.CoffinInspected = true;
                        }
                        else
                        {
                            Poster.Post("NO," +
                                " we are not doing that again," +
                                " not after what happened last time," +
                                " in fact dont bring it up again!");
                        }
                        break;
                    case "DESCEND":
                        Poster.Post("You continue further down into the pit," +
                            " as you progress some singular memories become more disturbed, isolated, broken and distant.");
                        Program.Location = "Inside Pit Level 4";
                        break;
                    case "ASCEND":
                        Poster.Post("You walk back up the staircase, with a bit of a hasted jump in your step.", 1);
                        Program.Location = "Inside Pit Level 2";
                        break;
                    case "HELP":
                        Poster.Post("The commands below might also include actions that you havent discovered in the story yet \n or choices your character havent discovered yet \n so use them with caution as using actions you havent discovered in the story might come at the expense of your experience.");
                        Poster.Post("Current Input Opportunities:");
                        Poster.Post("Look Forward");
                        Poster.Post("Look Left", 0, false);
                        Poster.Post("Look Right", 0, false);
                        Poster.Post("Look Behind", 0, false);
                        Poster.Post("Descend", 0, false);
                        Poster.Post("Ascend", 0, false);
                        Poster.Post("Jump Down", 0, false);
                        Poster.Post("Open Coffin", 0, false);
                        break;
                    default:
                        Poster.Post("In this pit you may not take such an action, however i can always offer you the option to cower in fear!");
                        Poster.Post("If you are stuck you can use the 'Help' Command to view all possible inputs at the current moment", 0, false);
                        break;
                }
            }
        }
    }
}
