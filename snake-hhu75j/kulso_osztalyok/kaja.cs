using System;
using System.Collections.Generic;
using System.Text;

namespace kulso_osztalyok
{
    
    internal class kaja
    {
        public circle currentalma { get; set; }
        
        Random rand = new Random();
        public int x { get; set; }
        public int y { get; set; }
        int maxWidth;
        int maxHeight;
        public kaja(int maxWidth, int maxHeight)
        {
            x = 0;
            y = 0;
            this.maxWidth = maxWidth/beallitasok.Width;
            this.maxHeight = maxHeight/beallitasok.Height;
            currentalma = ujkaja();
        }
        public circle ujkaja()
        {
            x = rand.Next(2, maxWidth);
            y = rand.Next(2, maxHeight);
            currentalma = new circle(x,y);
            return currentalma;
            
        }
    }

}
