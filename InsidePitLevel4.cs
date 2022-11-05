using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgreVent
{
    public class InsidePitLevel4
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

            if (Program.Location == "Inside Pit Level 4")
            {
                if (Console.ForegroundColor == ConsoleColor.DarkGray) Console.ForegroundColor = ConsoleColor.Red;
                switch (MyAction.ToUpper())
                {
                    case "LOOK FORWARD":
                        Poster.Post("Ahead, you see the staircase continuing down into the darkness");
                        break;
                    case "LOOK LEFT":
                        Poster.Post("To your left is the edge of the staircase towards the center of the pit");
                        break;
                    case "LOOK RIGHT":
                        Poster.Post("To your right, there are still shelves filled with coffins and papers and such," +
                            " but as you look at one of the coffins located in the shelf in the wall right next to you," +
                            " you start hearing sounds begin to emanate from within the coffin," +
                            " sounds of something moving around," +
                            " what exactly it is or what is even going on is a bit harder to tell just by looking at the thing.");
                        break;
                    case "LOOK BEHIND":
                        Poster.Post("You look back up the staircase, you want to leave");
                        break;
                    case "JUMP DOWN":
                        Poster.Post("You throw yourself over the side into the center of the pit," +
                            " you fall far," +
                            " you fall fast," +
                            " you fall for a long time," +
                            " before you are finally awarded with the discovery of the bottom.");
                        Program.IsAlive = false;
                        break;
                    case "DESCEND":
                        Poster.Post("You continue further down into the pit," +
                            " as you progress you experience that serenity and the ability to recall singular memories gives way to confusions and horror." +
                            " Memories of your childhood begins to fade," +
                            " same with the memories of your first week in the service to sir Yellegor," +
                            " you notice that you have to work harder in order to remember anything that brings joy and stillness to your mind as you continue your descent," +
                            " after a while you can see the bottom");
                        if(Program.CheckInventory("wooden holy symbol"))
                        {
                            Poster.Post("your holy symbol begins to vibrate as you near the bottom",0,false);
                        }
                        Poster.Post("you finally reach the bottom of the staircase and you now stand on flat solid bedrock," +
                            " covered in infernal runes in a circular pattern that seems to gather at the center of the room," +
                            " the runes glow in a dim red light," +
                            " and you are unable to read the runes," +
                            " this time analphabetism turned out in your favor perhaps." +
                            " In the silhouette of the glowing runes is the shape of a man sitting leaned over in an uncomfortable," +
                            " nearly inanimate sort of way in what can only be described as a simple," +
                            " broken, chair... much like the one you have in your home", 1);
                        Program.Location = "Inside Pit Level 5";
                        break;
                    case "ASCEND":
                        Poster.Post("You walk back up the staircase", 1);
                        Program.Location = "Inside Pit Level 3";
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
