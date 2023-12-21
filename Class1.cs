using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNAKEGAME
{
    public static class GameSettings
    {
        public static int ShakeDuration { get; set; } = 2000;

        public static int BoostSpeed { get; set; } = 40;

        public static bool EnableBGMusic { get; set; } = false;

        public static double WallDensity { get; set; } = .10;

        public static bool WallFatality { get; set; } = true;
    }
}
