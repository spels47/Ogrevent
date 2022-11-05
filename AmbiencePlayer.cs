using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OgreVent
{
    public class AmbiencePlayer
    {
        public static bool SoundOn = false;
        public static string CurrentlyPlaying = null;
        public static void PlaySong(string song)
        {
            Task.Factory.StartNew(() =>
            {
                SoundPlayer MyPlayer = new SoundPlayer($@"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\{song}.wav");
                SoundOn = true;
                CurrentlyPlaying = song;
                MyPlayer.Play();
                while (SoundOn)
                {
                    Thread.Sleep(1000);
                }
                MyPlayer.Stop();
                CurrentlyPlaying = null;
            });
        }
    }
}
