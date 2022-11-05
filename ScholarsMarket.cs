using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgreVent
{
    public class ScholarsMarket
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
            if (Program.Location == "Scholars Market")
            {
                switch (MyAction.ToUpper())
                {
                    case "LOOK FORWARD":
                        Poster.Post("Ahead," +
                            " is the mouth to a tunnel like structure," +
                            " decorated in colored bricks in exotic patterns the tunnel stretches on for a short while," +
                            " you can see the exit on the other side," +
                            " streams of people traffic through the tunnel in both directions in a slow tempo.");
                        break;
                    case "LOOK LEFT":
                        Poster.Post("To the left hand side of the tunnel you can see the entrances to the alchemist shop," +
                            " and the tobacconist," +
                            " the entrances are wide and the shops themselves seem to be quite spacious");
                        break;
                    case "LOOK RIGHT":
                        Poster.Post("To the right hand side of the tunnel," +
                            " you can see the entrances to the magic shop," +
                            " and the imported spirits shop." +
                            " The entrances are wide and the shops themselves seem to be quite spacious");
                        break;
                    case "LOOK BEHIND":
                        Poster.Post("Behind you," +
                            " is a group of mercenary looking men wielding crossbows and shortswords," +
                            " some of them also have guard dogs," +
                            " presumably here to make sure noone tries to steal anything from the market");
                        break;
                    case "ENTER MAGIC SHOP":
                        Poster.Post("You move through the crowd and the thick incense smoke coming down from chandelier incense burners," +
                            " you get into the shop which is less crowded than the tunnel.");
                        Program.Location = "Magic Shop";
                        break;
                    case "ENTER TOBACCONIST":
                        Poster.Post("You move through the crowd and the thick incense smoke coming down from chandelier incense burners," +
                            " you get into the shop which is less crowded than the tunnel.");
                        Program.Location = "Tobacconist";
                        break;
                    case "ENTER ALCHEMY SHOP":
                        Poster.Post("You move through the crowd and the thick incense smoke coming down from chandelier incense burners," +
                            " you get into the shop which is less crowded than the tunnel.");
                        Program.Location = "Alchemy Shop";
                        break;
                    case "ENTER SPIRITS SHOP":
                        Poster.Post("You move through the crowd and the thick incense smoke coming down from chandelier incense burners," +
                            " you get into the shop which is less crowded than the tunnel.");
                        Program.Location = "Spirits Shop";
                        break;
                    case "GO TO MARKEDPLACE":
                        Poster.Post("You go to the markedplace");
                        Program.Location = "Markedplace";
                        break;
                    case "GO TO TOWN HALL":
                        Poster.Post("You walk to the Town Hall located in the northern part of town," +
                            "\n as you stand outside the Town Hall you notice that there are more guards here," +
                            " the people look," +
                            " walk and talk in a way that would suggest they come from wealth." +
                            "\n The Town Hall itself has a bell tower with a spire." +
                            " The Hall is made out of stone for the most part but the stone is painted white," +
                            " however the spire is made out of wood and is seemingly the only major part of the Hall that is made of wood.", 2);
                        Program.Location = "Town Hall";
                        break;
                    case "GO TO CHESTLOCK GUILD HALL":
                        Poster.Post("You walk to the Chestlock Guild Hall," +
                            " as you arrive you find that the Guild Hall is actually a Fort with crenellations and everything with a Guild Hall instead of barracks and" +
                            " storage houses instead of stables and other normal structures to be found in a more tradiotional fort." +
                            "\n And all this inside the city, there is a steady flow of people entering and leaving the Forts gate," +
                            " and the guards standing by the gate and above on the wall seem ever so vigilant.", 2);
                        Program.Location = "Chestlock Guild Hall";
                        break;
                    case "GO TO HUNTERS LODGE":
                        Poster.Post("You walk to the Hunters Lodge," +
                            " there you find a man chopping firewood." +
                            "\n The Lodge itself takes form in a large cabin it looks rather cozy and homely.", 4);
                        Program.Location = "Hunters Lodge";
                        break;
                    case "GO TO BRINEWOOD FOREST":
                        Poster.Post("You walk to Brinewood Forest," +
                            " you now stand in the forest there are sounds of birds in the trees," +
                            " there are moss covered rocks and everything seems calm.", 3);
                        Program.Location = "Brinewood Forest";
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
                        Poster.Post("Enter Magic Shop", 0, false);
                        Poster.Post("Enter Tobacconist", 0, false);
                        Poster.Post("Enter Alchemy Shop", 0, false);
                        Poster.Post("Enter Spirits Shop", 0, false);
                        Poster.Post("Go To Markedplace", 0, false);
                        Poster.Post("Go To Town Hall", 0, false);
                        Poster.Post("Go To Chestlock Guild Hall", 0, false);
                        Poster.Post("Go To Hunters Lodge", 0, false);
                        Poster.Post("Go To Brinewood Forest", 0, false);
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
