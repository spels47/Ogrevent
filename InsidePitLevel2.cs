using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgreVent
{
    public class InsidePitLevel2
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

            if (Program.Location == "Inside Pit Level 2")
            {
                switch (MyAction.ToUpper())
                {
                    case "LOOK FORWARD":
                        Poster.Post("Ahead, you see the staircase continuing down into the darkness");
                        break;
                    case "LOOK LEFT":
                        Poster.Post("To your left is the edge of the staircase towards the center of the pit");
                        break;
                    case "LOOK RIGHT":
                        Poster.Post("To your right you see makeshift shelves carved into the stone wall," +
                            " they seem to cover the walls along the outer edge from this point and all the way down that you can see," +
                            " the carved out shelves does not seem organised," +
                            " each shelf is of a non uniform size and shape," +
                            " and is allocated in a non uniform way to the others," +
                            " no discernable patterns can be observed in these shelves," +
                            " likewise the content of the shelves is equally disorganised," +
                            " filled with papers, books, scrolls, letters and other little trinkets but mostly papers and such.");
                        break;
                    case "LOOK BEHIND":
                        Poster.Post("Behind you," +
                            " is the staircase back up and out of this place," +
                            " as you look back up you feel an urge to leave as this place is uncomfortable and a brief sensation of a presence somewhere behind you," +
                            " this sensation makes your stomach twist for a moment," +
                            " giving you another impulse," +
                            " an impulse to turn back around and look down the staircase and raise your voice to see if anyone is there," +
                            " even if the idea in a sense seems silly you have heard and seen noone here and cant imagine why anyone would be down here." +
                            " You turn and face back down," +
                            " and you spend a few moments calming down and the sensation subsides..." +
                            " you are left with only the general uneasiness that has been with you since you entered this place.");
                        break;
                    case "JUMP DOWN":
                        Poster.Post("You throw yourself over the side into the center of the pit," +
                            " you fall far," +
                            " you fall fast," +
                            " you fall for a long time," +
                            " before you are finally awarded with the discovery of the bottom.");
                        Program.IsAlive = false;
                        break;
                    case "INSPECT SHELVES":
                        Poster.Post("You walk over to the shelves and take a pile of papers and such out and hold it in one arm," +
                            " as you set your lantern down in the shelf you begin to go through the contents resting on your forearm." +
                            " Most of the papers are written in different shades of red," +
                            " sadly peasants like yourself cant read, however the papers that are written in shades of read all seem to have a demonic symbol on them," +
                            " and they all seem to have one or more signatures on them");
                        break;
                    case "DESCEND":
                        Poster.Post("You continue further down into the pit," +
                            " a state of fear elevates and hangs over you," +
                            " and you experience a self realisation and awareness that something is wrong with a refusal to accept that.", 1);
                        Program.Location = "Inside Pit Level 3";
                        break;
                    case "ASCEND":
                        Poster.Post("You walk back up the staircase, somewhat relieved", 1);
                        Program.Location = "Inside Pit";
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
