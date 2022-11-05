using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgreVent
{
    public class TownHall
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

            if (Program.Location == "Town Hall")
            {
                switch (MyAction.ToUpper())
                {
                    case "GO TO MARKEDPLACE":
                        Poster.Post("You walk away from the town hall, away from the rich inner city and back to the markedplace", 1);
                        Program.Location = "Markedplace";
                        break;
                    case "LOOK LEFT":
                        Poster.Post("To your left you can see a crowd gathered around a man speaking atop a box, he is surrounded by a minor crowd that seems to be listening to what the man has to say, the crowd has a varied response on their faces to what the man is saying.");
                        break;
                    case "LOOK RIGHT":
                        Poster.Post("To your right you can see a statue of a man riding a horse wielding a lance and shiny armor.");
                        break;
                    case "LOOK FORWARD":
                        Poster.Post("Ahead of you, you can see the great town hall, guards are stationed around every door and every window it seems like a really secure building and entrance seems limited and privileged to the few.");
                        break;
                    case "LOOK BACK":
                        Poster.Post("Behind you lies the rest of the city, crowded streets and narrow roads between sets of structures of various designs and purposes, atleast the streets are stone and not mud.");
                        break;
                    case "ENTER TOWN HALL":
                        Poster.Post();
                        foreach (Item item in Program.Inventory)
                        {
                            if (item.MyName == "ring of invicibility")
                            {
                                Poster.Post($"You put on your {item.MyName} and sneak past the guards and enter the town hall");
                                Poster.Post("Once on the inside you see people doing paperwork at their desks," +
                                    " while others walk around with piles of paper in their hands and the occasional people talking in the hallways mostly about taxation and other political topics." +
                                    " straight ahead is a set of fine mahogony double doors that has been polished to really bring out its deep red color," +
                                    " the door handles are made out what looks like silver or some similar material and at the center of the handle it is crested with a green gemstone.", 0, false);
                                Poster.Post("Do you 'Open the Door'? or do you 'Leave'?", 0, false);
                                string TempString = Input();
                                switch (TempString)
                                {
                                    case "OPEN THE DOOR":
                                        if (GlobalBools.DoneWithTheDevil)
                                        {
                                            Poster.Post("Your attempts at entering is futile, fear is nurtured within you");
                                        }
                                        else if (!GlobalBools.SurvivedTheMayor)
                                        {
                                            Poster.Post("just before you open the doors you can hear voices from the other side of the intimidatingly valuable doors when you open them you are faced with an empty room," +
                                                " or less of a room and just a deep swallowing pit," +
                                                " dirty dark and empty an old wooden staircase made out of timber lodged into the sides of the pit creating a circling pathway down into the deep darkness");
                                            Program.Location = "Demon Pit";
                                        }
                                        else
                                        {
                                            Poster.Post("You knock gently on the mahagony doors before entering the mayors office");
                                            Program.Location = "Mayors Office";
                                        }
                                        break;
                                    case "LEAVE":
                                        break;
                                }
                            }
                        }
                        Poster.Post("You bravely attempt to enter the town hall but find yourself stopped by the guards and turned away.");
                        break;
                    case "LISTEN TO MAN":
                        Poster.Post("You walk over to the man standing atop the box, he wears ragged clothes that clearly does not fit in with the finery of this district, he speaks of fanatic beliefs and that all should seek forgiveness before the inevitable end, he does so with a crack in his voice not unlike that of a teenager going through puberty.");
                        break;
                    case "GO TO STATUE":
                        Poster.Post("You walk over to the statue and read the plaque and it says 'In Honour of Sir Pilferd Pernkelbottom must his heroics never be forgotten' it is a marvelous statue of a knight in his shining armor.");
                        break;
                    case "GO TO CHESTLOCK GUILD HALL":
                        Poster.Post("You walk to the Chestlock Guild Hall, as you arrive you find that the Guild Hall is actually a Fort with crenellations and everything with a Guild Hall instead of barracks and storage houses instead of stables and other normal structures to be found in a more tradiotional fort.\n And all this inside the city, there is a steady flow of people entering and leaving the Forts gate, and the guards standing by the gate and above on the wall seem ever so vigilant.");
                        Program.Location = "Chestlock Guild Hall";
                        break;
                    case "GO TO HUNTERS LODGE":
                        Poster.Post("You walk to the Hunters Lodge, there you find a man chopping firewood.\n The Lodge itself takes form in a large cabin it looks rather cozy and homely.");
                        Program.Location = "Hunters Lodge";
                        break;
                    case "GO TO BRINEWOOD FOREST":
                        Poster.Post("You walk to Brinewood Forest, you now stand in the forest there are sounds of birds in the trees, there are moss covered rocks and everything seems calm.");
                        Program.Location = "Brinewood Forest";
                        break;
                    case "GO TO SCHOLARS MARKET":
                        Poster.Post("You walk to the Scholars Market, the outside area would make you think of this as a street of townhouses but you notice a sign hanging above one of the doors saying 'The Scholars Market'\n. As you enter you understand that this might have at some point been a street of townhouses but has been later turned into a set of shops located on the same floor under one roof, and not just this street the houses that would have been on the next street aswell making this a rather sizable place.\n The smells in the air are varied and exotic");
                        Program.Location = "Scholars Market";
                        break;
                    case "HELP":
                        Poster.Post("The commands below might also include actions that you havent discovered in the story yet \n or choices your character havent discovered yet \n so use them with caution as using actions you havent discovered in the story might come at the expense of your experience.");
                        Poster.Post("Current Input Opportunities:");
                        Poster.Post("Look Left");
                        Poster.Post("Look Right", 0, false);
                        Poster.Post("Look Forward", 0, false);
                        Poster.Post("Look Back", 0, false);
                        Poster.Post("Enter Town Hall", 0, false);
                        Poster.Post("Listen To Man", 0, false);
                        Poster.Post("Go To Statue", 0, false);
                        Poster.Post("Go To Markedplace", 0, false);
                        Poster.Post("Go To Chestlock Guild Hall", 0, false);
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
