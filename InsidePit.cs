using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgreVent
{
    public class InsidePit
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

            if (Program.Location == "Inside Pit")
            {
                if (!AmbiencePlayer.SoundOn) AmbiencePlayer.PlaySong("TownCave");
                else if (AmbiencePlayer.CurrentlyPlaying != "TownCave")
                {
                    AmbiencePlayer.SoundOn = false;
                    AmbiencePlayer.PlaySong("TownCave");
                }
                if (Console.ForegroundColor == ConsoleColor.White) Console.ForegroundColor = ConsoleColor.Gray;
                switch (MyAction.ToUpper())
                {
                    case "LOOK FORWARD":
                        Poster.Post("Ahead," +
                            " over the edge you can look down into the deep dark unending pit," +
                            " you might be able to make out something etched into the walls of the cave further down the staircase");
                        break;
                    case "LOOK LEFT":
                        Poster.Post("To you left is the top end of the staircase");
                        break;
                    case "LOOK RIGHT":
                        Poster.Post("To your right," +
                            " is the way down the staircase," +
                            " the wooden steps look unsafe to walk on and you do not excpet to survive if you were to fall");
                        break;
                    case "LOOK BEHIND":
                        Poster.Post("Behind you, is the way out");
                        break;
                    case "JUMP DOWN":
                        Poster.Post("You throw yourself over the side," +
                            " and you fall far," +
                            " you fall fast," +
                            " and you fall for a very long time," +
                            " for your patience you are awarded with finding the bottom");
                        Program.IsAlive = false;
                        break;
                    case "DESCEND":
                        Poster.Post("You walk down the staircase");
                        if(Program.CheckInventory("church lantern"))
                        {
                            Poster.Post("You light the lantern you found in the church earlier which makes it possible to traverse this staircase", 1);
                            Program.Location = "Inside Pit Level 2";
                        }
                        else
                        {
                            Poster.Post("You slip and fall as you walk down in the dark");
                            Program.IsAlive = false;
                        }
                        break;
                    case "LEAVE":
                        Poster.Post("You walk back out past the mahagony doors");
                        AmbiencePlayer.SoundOn = false;
                        Console.ForegroundColor = ConsoleColor.White;
                        Program.Location = "Demon Pit";
                        break;
                    case "HELP":
                        Poster.Post("The commands below might also include actions that you havent discovered in the story yet \n or choices your character havent discovered yet \n so use them with caution as using actions you havent discovered in the story might come at the expense of your experience.");
                        Poster.Post("Current Input Opportunities:");
                        Poster.Post("Look Forward");
                        Poster.Post("Look Left", 0, false);
                        Poster.Post("Look Right", 0, false);
                        Poster.Post("Look Behind", 0, false);
                        Poster.Post("Descend", 0, false);
                        Poster.Post("Jump Down", 0, false);
                        Poster.Post("Leave", 0, false);
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
