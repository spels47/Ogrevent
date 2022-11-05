using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgreVent
{
    public class Poster
    {
        public static void Post(string post = null, int delay = 0, bool AddSpace = true)
        {
            if (AddSpace) Console.WriteLine();
            if (post != null) Console.WriteLine(post);
            if (delay > 0) Program.Time(delay);
        }

        public static void PrintTitle()
        {
            Post("###################################################################################################################", 0, false);
            Post("###################################################################################################################", 0, false);
            Post("###################################################################################################################", 0, false);
            Post("###################################################################################################################", 0, false);
            Post("###################################################################################################################", 0, false);
            Post("#####     ■■■■■■     ■■■■■■■■     ■■■■       ■■■■■■     ■■          ■■     ■■■■■■     ■■■■■■■■    ■■■■■■■■     ####", 0, false);
            Post("#####     ■■■■■■     ■■■■■■■■     ■■■■       ■■          ■■        ■■      ■■         ■■■■■■■■    ■■■■■■■■     ####", 0, false);
            Post("#####     ■■  ■■     ■■           ■  ■       ■■           ■■      ■■       ■■         ■■    ■■       ■■        ####", 0, false);
            Post("#####     ■■  ■■     ■■  ■■■■     ■  ■       ■■■■■■        ■■    ■■        ■■■■■■     ■■    ■■       ■■        ####", 0, false);
            Post("#####     ■■  ■■     ■■    ■■     ■■■■       ■■             ■■  ■■         ■■         ■■    ■■       ■■        ####", 0, false);
            Post("#####     ■■■■■■     ■■■■■■■■     ■  ■■      ■■              ■■■■          ■■         ■■    ■■       ■■        ####", 0, false);
            Post("#####     ■■■■■■     ■■■■■■■■     ■   ■■     ■■■■■■           ■■           ■■■■■■     ■■    ■■       ■■        ####", 0, false);
            Post("###################################################################################################################", 0, false);
            Post("###################################################################################################################", 0, false);
            Post("###################################################################################################################", 0, false);
            Post("###################################################################################################################", 0, false);
            Post("###################################################################################################################", 0, false);
        }

        public static void PrintIntro()
        {
            Post("You were the squire of the late sir Yellegor Yellowflag, a monster slayer of great renown!");
            Post("Last night your master was killed in combat against a fierce ogre and you find yourself at the marketplace spending your last coppers on half a bread and some apples.", 0, false);
            Post("With your tummy temporarily satisfied with nourishment and with no money or valuables to your name, and far from your home, you catch a glimpse of a poster in the corner of your eye", 0, false);
            Post("You focus your attention on the poster, it is a wanted poster for the great ogre that killed your master, the bounty for the beast has tripled and now offers a gold price from the lord of 300 Gold Pieces", 0, false);
            Post("And so your Quest to Slay The Ogre Begins!", 0, false);
        }
    }
}
