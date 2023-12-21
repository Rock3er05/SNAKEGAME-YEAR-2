

using System;
using System.Media;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace AMSnake
{
    public static class Audio
    {
        public readonly static MediaPlayer GameLoop = LoadAudio("Bella Ciao.mp3");
        
        public readonly static List<MediaPlayer> BGMusic = new()
        {
            GameLoop,
        };

        private static MediaPlayer LoadAudio(string filename, double volume = 1, bool autoReset = true, bool repeat = false)
        {
            MediaPlayer player = new();
            player.Open(new Uri($"Assets/{filename}", UriKind.Relative));
            player.Volume = volume;

            if (autoReset)
            {
                player.MediaEnded += Player_MediaEnded;
            }

            if (repeat)
            {
                player.MediaEnded += Player_MediaEnded;
            }
            return player;
        }

        private static void Player_MediaEnded(object sender, EventArgs e)
        {
            MediaPlayer m = sender as MediaPlayer;
            m.Stop();
            m.Position = new TimeSpan(0);
        }

        private static void PlayerRepeat_MediaEnded(object sender, EventArgs e)
        {
            MediaPlayer m = sender as MediaPlayer;
            m.Stop();
            m.Position = new TimeSpan(0);
            m.Play();
        }
    }
}
