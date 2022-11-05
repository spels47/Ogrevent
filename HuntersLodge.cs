using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgreVent
{
    public class HuntersLodge
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
            if (Program.Location == "Hunters Lodge")
            {
                switch (MyAction.ToUpper())
                {
                    case "GO TO MARKEDPLACE":
                        Poster.Post("You go to the markedplace", 4);
                        Program.Location = "Markedplace";
                        break;
                    case "GO TO TOWN HALL":
                        Poster.Post("You walk to the Town Hall located in the northern part of town,\n as you stand outside the Town Hall you notice that there are more guards here, the people look, walk and talk in a way that would suggest they come from wealth.\n The Town Hall itself has a bell tower with a spire. The Hall is made out of stone for the most part but the stone is painted white, however the spire is made out of wood and is seemingly the only major part of the Hall that is made of wood.", 4);
                        Program.Location = "Town Hall";
                        break;
                    case "GO TO CHESTLOCK GUILD HALL":
                        Poster.Post("You walk to the Chestlock Guild Hall, as you arrive you find that the Guild Hall is actually a Fort with crenellations and everything with a Guild Hall instead of barracks and storage houses instead of stables and other normal structures to be found in a more tradiotional fort.\n And all this inside the city, there is a steady flow of people entering and leaving the Forts gate, and the guards standing by the gate and above on the wall seem ever so vigilant.", 4);
                        Program.Location = "Chestlock Guild Hall";
                        break;
                    case "GO TO BRINEWOOD FOREST":
                        Poster.Post("You walk to Brinewood Forest, you now stand in the forest there are sounds of birds in the trees, there are moss covered rocks and everything seems calm.", 1);
                        Program.Location = "Brinewood Forest";
                        break;
                    case "GO TO SCHOLARS MARKET":
                        Poster.Post("You walk to the Scholars Market, the outside area would make you think of this as a street of townhouses but you notice a sign hanging above one of the doors saying 'The Scholars Market'\n. As you enter you understand that this might have at some point been a street of townhouses but has been later turned into a set of shops located on the same floor under one roof, and not just this street the houses that would have been on the next street aswell making this a rather sizable place.\n The smells in the air are varied and exotic", 4);
                        Program.Location = "Scholars Market";
                        break;
                    case "LOOK LEFT":
                        Poster.Post("You look to your left and gaze upon a man chopping wood");
                        break;
                    case "LOOK RIGHT":
                        Poster.Post("You look to your right and see some men practising with a bow");
                        break;
                    case "LOOK FORWARD":
                        Poster.Post("Ahead you see a cozy looking cabin, its quite large");
                        break;
                    case "LOOK BACK":
                        Poster.Post("Behind you lies Brinewood Forest it reminds you of wet dogs for some reason");
                        break;
                    case "HELP":
                        Poster.Post("The commands below might also include actions that you havent discovered in the story yet \n or choices your character havent discovered yet \n so use them with caution as using actions you havent discovered in the story might come at the expense of your experience.");
                        Poster.Post("Current Input Opportunities:");
                        Poster.Post("Look Left");
                        Poster.Post("Look Right", 0, false);
                        Poster.Post("Look Forward", 0, false);
                        Poster.Post("Look back", 0, false);
                        Poster.Post("Go To Markedplace", 0, false);
                        Poster.Post("Go To Town Hall");
                        Poster.Post("Go To Chestlock Guild Hall", 0, false);
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
