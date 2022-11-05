using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgreVent
{
    public class DemonPit
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

            if (Program.Location == "Demon Pit")
            {
                Poster.Post("For some reason your ring doesnt work here, you become visible");
                switch (MyAction.ToUpper())
                {
                    case "LOOK FORWARD":
                        Poster.Post("Ahead of you," +
                                    " you can see the lumber stuck into the sides of this circular cave stretching down into the dark," +
                                    " with no other light source than the one from the open door behind you," +
                                    " beyond that lumber is the edge");
                        break;
                    case "LOOK LEFT":
                        Poster.Post("To your left," +
                            " you see the people busy with their paperwork," +
                            " their bland atmosphere that they exude from the interactions they have with their work and with each other seems almost cheerfull," +
                            " compared to the feeling of dread and emptiness that washes over you," +
                            " in a sense you recognise that this feeling is eminating from the pit," +
                            " but you excuse it as just the shock of discovering this highly unexpected... place");
                        break;
                    case "LOOK RIGHT":
                        Poster.Post("To your right, still standing outside the mahagony doors," +
                            " Is a hallway leading down a corridor with many doors on both sides," +
                            " presumably leading to boring offices with people coming and going frequently," +
                            " some passing you by," +
                            " not even recognising the now open mahagony doors or the contents within");
                        break;
                    case "LOOK BEHIND":
                        Poster.Post("Behind you," +
                            " is the carpeted path leading back to the double doors out of this building," +
                            " and the desks on each side of this path, each side has 3 desks on 3 rows," +
                            " the desks are all facing away from you," +
                            " a certain want for leaving comes to mind as you see the rays of sunlight slip between the cracks of the doors out");
                        break;
                    case "ENTER PIT":
                        Poster.Post("You walk past the mahagony doors and step onto the first steps of the old wooden staircase");
                        Program.Location = "Inside Pit";
                        break;
                    case "LEAVE":
                        Poster.Post("You manage to claw your way out passing the mahagony doors and leave the building and return to the outside of the town hall.");
                        Program.Location = "Town Hall";
                        break;
                    case "HELP":
                        Poster.Post("The commands below might also include actions that you havent discovered in the story yet \n or choices your character havent discovered yet \n so use them with caution as using actions you havent discovered in the story might come at the expense of your experience.");
                        Poster.Post("Current Input Opportunities:");
                        Poster.Post("Look Forward");
                        Poster.Post("Look Left", 0, false);
                        Poster.Post("Look Right", 0, false);
                        Poster.Post("Look Behind", 0, false);
                        Poster.Post("Enter Pit", 0, false);
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
