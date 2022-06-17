using System;
using System.Collections.Generic;
using System.Text;

namespace kulso_osztalyok
{
    internal class beallitasok
    {
        public static int Width { get; set; }
        public static int Height { get; set; }

        public string direction;

        public beallitasok()
        {
            Width = 16;
            Height = 16;
            direction = "left";
        }
    }
}
