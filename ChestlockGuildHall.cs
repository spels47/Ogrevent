using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgreVent
{
    public class ChestlockGuildHall
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
            if (Program.Location == "Chestlock Guild Hall")
            {
                switch (MyAction.ToUpper())
                {
                    case "LOOK LEFT":
                        Poster.Post("To your left inside the guild hall you see merchants waiting in line in order to talk to a clerk, it seems many have brought chests or bags of gold");
                        break;
                    case "LOOK RIGHT":
                        Poster.Post("To your right inside the guild hall you see offices, some that seem intended to recieve people who needs to talk to a guild representative and others that seem to be purely for use by those that work here.");
                        break;
                    case "LOOK FORWARD":
                        Poster.Post("Ahead of you inside the guild hall is a grand staircase that lead up to a floor that by the look of the guards stationed by it is off limits.");
                        break;
                    case "LOOK BACK":
                        Poster.Post("Behind you is the way out of the guild hall");
                        break;
                    case "TALK TO CLERK":
                        Poster.Post("waiting in line seems to take forever and you eventually you reach the clerk who informs you that you must live in the city in order to use the banks services, 'regulations' she says in a snarky tone", 2);
                        break;
                    case "ENTER OFFICE":
                        //TODO: if you have armor or equipment that make you look knightly add more to this than getting thrown out.
                        Poster.Post("You enter one of the offices in order to talk to a representative of the guild and as you enter the office, the representative screams 'WAH, peasant! GUARDS!' you are tossed out of the representatives office, you think they can smell the poor person on you, quite a distinct smell");
                        break;
                    case "GO UP STAIRCASE":
                        Poster.Post("You head for the grand staircase, your heart flutters as you imagine what it would be like to walk upon such bejeweled engraved gold lined mirror clear marble stairs, perfectly crafted with mathematical precision, though you end up being stopped by the guards who tell you 'this place is off limits sir, please go and ... count sheep or something somewhere else, guild heads only'");
                        break;
                    case "GO TO MARKEDPLACE":
                        Poster.Post("You go to the markedplace", 1);
                        Program.Location = "Markedplace";
                        break;
                    case "GO TO TOWN HALL":
                        Poster.Post("You walk to the Town Hall located in the northern part of town,\n as you stand outside the Town Hall you notice that there are more guards here, the people look, walk and talk in a way that would suggest they come from wealth.\n The Town Hall itself has a bell tower with a spire. The Hall is made out of stone for the most part but the stone is painted white, however the spire is made out of wood and is seemingly the only major part of the Hall that is made of wood.", 1);
                        Program.Location = "Town Hall";
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
                        Poster.Post("You walk to the Scholars Market, the outside area would make you think of this as a street of townhouses but you notice a sign hanging above one of the doors saying 'The Scholars Market'\n. As you enter you understand that this might have at some point been a street of townhouses but has been later turned into a set of shops located on the same floor under one roof, and not just this street the houses that would have been on the next street aswell making this a rather sizable place.\n The smells in the air are varied and exotic", 1);
                        Program.Location = "Scholars Market";
                        break;
                    case "HELP":
                        Poster.Post("The commands below might also include actions that you havent discovered in the story yet \n or choices your character havent discovered yet \n so use them with caution as using actions you havent discovered in the story might come at the expense of your experience.");
                        Poster.Post("Current Input Opportunities:");
                        Poster.Post("Look Left");
                        Poster.Post("Look Right", 0, false);
                        Poster.Post("Look Forward", 0, false);
                        Poster.Post("Look Back", 0, false);
                        Poster.Post("Talk To Clerk", 0, false);
                        Poster.Post("Enter Office", 0, false);
                        Poster.Post("Go Up Staircase", 0, false);
                        Poster.Post("Go To Markedplace", 0, false);
                        Poster.Post("Go To Town Hall", 0, false);
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
