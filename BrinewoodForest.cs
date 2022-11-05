using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OgreVent
{
    public class BrinewoodForest
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
            if (Program.Location == "Brinewood Forest")
            {
                switch (MyAction.ToUpper())
                {
                    case "LOOK LEFT":
                        Poster.Post("To your left you see birds in the trees and the occasional blue berries, yummy");
                        break;
                    case "LOOK RIGHT":
                        Poster.Post("To your right you see a beehive in a tree, its surprisingly large.");
                        break;
                    case "LOOK FORWARD":
                        Poster.Post("Ahead of you is a great large OGRE, probably the one and the same that killed your master, it doesnt seem like it has noticed you yet");
                        break;
                    case "LOOK BACK":
                        Poster.Post("Behind you, you can see rough and hard to travel terrain, thorned bushes and the like");
                        break;
                    case "KILL OGRE":
                        int TotalDamage = 0;
                        int TotalDefence = 0;
                        foreach (Item item in Program.Inventory)
                        {
                            TotalDamage += item.MyDamage;
                            TotalDefence += item.MyArmor;
                        }
                        if (TotalDamage >= 7 && TotalDefence >= 15)
                        {
                            Poster.Post("You kill the mighty ogre and return triumphant, you claim your reward and live a merry life as a monster hunter until your last day and pass into legend");
                            Thread.Sleep(10000);
                            Environment.Exit(0);
                        }
                        else
                        {
                            Program.IsAlive = false;
                        }
                        break;
                    case "GO TO MARKEDPLACE":
                        Poster.Post("You walk back to the Town and head over to the markedplace, you have a mosquito bite on your ancle", 3);
                        Program.Location = "Markedplace";
                        break;
                    case "GO TO TOWN HALL":
                        Poster.Post("You walk to the Town Hall located in the northern part of town,\n as you stand outside the Town Hall you notice that there are more guards here, the people look, walk and talk in a way that would suggest they come from wealth.\n The Town Hall itself has a bell tower with a spire. The Hall is made out of stone for the most part but the stone is painted white, however the spire is made out of wood and is seemingly the only major part of the Hall that is made of wood.", 3);
                        Program.Location = "Town Hall";
                        break;
                    case "GO TO CHESTLOCK GUILD HALL":
                        Poster.Post("You walk to the Chestlock Guild Hall, as you arrive you find that the Guild Hall is actually a Fort with crenellations and everything with a Guild Hall instead of barracks and storage houses instead of stables and other normal structures to be found in a more tradiotional fort.\n And all this inside the city, there is a steady flow of people entering and leaving the Forts gate, and the guards standing by the gate and above on the wall seem ever so vigilant.", 3);
                        Program.Location = "Chestlock Guild Hall";
                        break;
                    case "GO TO HUNTERS LODGE":
                        Poster.Post("You walk to the Hunters Lodge, there you find a man chopping firewood.\n The Lodge itself takes form in a large cabin it looks rather cozy and homely.", 1);
                        Program.Location = "Hunters Lodge";
                        break;
                    case "GO TO SCHOLARS MARKET":
                        Poster.Post("You walk to the Scholars Market, the outside area would make you think of this as a street of townhouses but you notice a sign hanging above one of the doors saying 'The Scholars Market'\n. As you enter you understand that this might have at some point been a street of townhouses but has been later turned into a set of shops located on the same floor under one roof, and not just this street the houses that would have been on the next street aswell making this a rather sizable place.\n The smells in the air are varied and exotic", 3);
                        Program.Location = "Scholars Market";
                        break;
                    case "HELP":
                        Poster.Post("The commands below might also include actions that you havent discovered in the story yet \n or choices your character havent discovered yet \n so use them with caution as using actions you havent discovered in the story might come at the expense of your experience.");
                        Poster.Post("Current Input Opportunities:");
                        Poster.Post("Look Left");
                        Poster.Post("Look Right", 0, false);
                        Poster.Post("Look Forward", 0, false);
                        Poster.Post("Look Back", 0, false);
                        Poster.Post("Go To Markedplace", 0, false);
                        Poster.Post("Go To Town Hall", 0, false);
                        Poster.Post("Go To Chestlock Guild Hall", 0, false);
                        Poster.Post("Go To Hunters Lodge", 0, false);
                        Poster.Post("Go To Scholars Market", 0, false);
                        Poster.Post("Kill Ogre", 0, false);
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
