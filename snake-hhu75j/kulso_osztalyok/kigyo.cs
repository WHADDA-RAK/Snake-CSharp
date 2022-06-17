using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using kulso_osztalyok;


namespace kulso_osztalyok
{
    internal class KIGYO
    {
        public kaja alma { get; set; }
       
        public List<circle> test { get; set; }
       
        
      
        beallitasok settings = new beallitasok();
        int xinit = 10, yinit = 10;
        int maxWidth { get; }

        int maxHeight { get; }
        public KIGYO(int width, int height)
        {
            maxWidth = width / beallitasok.Width - 1;
            maxHeight = height / beallitasok.Height - 1;
            test = new List<circle>();
            test.Add(new circle(xinit, yinit));
            alma = new kaja(704,704);
            alma.ujkaja();
        }
        public void Mozgat(Action JatekVege, Action Megesz)
        {
           
            for (int i = test.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    switch (settings.direction)
                    {
                        case "left":
                            test[i].x--;
                            break;
                        case "right":
                            test[i].x++;
                            break;
                        case "up":
                            test[i].y--;
                            break;
                        case "down":
                            test[i].y++;
                            break;
                    }
                    if (test[i].x < 0)
                    {
                        test[i].x = maxWidth;
                    }
                    if (test[i].x > maxWidth)
                    {
                        test[i].x = 0;
                    }
                    if (test[i].y > maxHeight)
                    {
                        test[i].y = 0;
                    }
                    if (test[i].y < 0)
                    {
                        test[i].y = maxHeight;
                    }
                    if (test[i].x == alma.x && test[i].y == alma.y)
                    {
                        Megesz();
                    }
                    for (int j = 1; j < test.Count; j++)
                    {
                        if (test[j].x == test[i].x && test[j].y == test[i].y)
                        {
                            JatekVege();
                        }
                    }
                }
                else
                {
                    test[i].x = test[i - 1].x;
                    test[i].y = test[i - 1].y;
                }
            }
        }
        public void Iranyit(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && settings.direction != "right") settings.direction = "left";
            if (e.KeyCode == Keys.Right && settings.direction != "left") settings.direction = "right";
            if (e.KeyCode == Keys.Up && settings.direction != "down") settings.direction = "up";
            if (e.KeyCode == Keys.Down && settings.direction != "up") settings.direction = "down"; 
        }
        public void Clear()
        {
            test.Clear();
        }
        public void InitializeBody(int size)
        {
            
            for (int i = 1; i < size; i++)
            {
                test.Add(new circle(xinit+i, yinit));

            }
        }
        public void MegEtte()
        {
            test.Add(new circle { x = test[test.Count - 1].x, y = test[test.Count - 1].y });
            alma.ujkaja();
        }
        public void UjraRajzoltat(PaintEventArgs e)
        {
            Graphics jatek = e.Graphics;

            Brush kigyoszine;
            for (int i = 0; i < test.Count; i++)
            {
                if (i == 0)
                {
                    kigyoszine = Brushes.Black;
                }
                else
                {
                    kigyoszine = Brushes.Green;
                }
                jatek.FillEllipse(kigyoszine, new Rectangle(test[i].x * beallitasok.Width, test[i].y * beallitasok.Height, beallitasok.Width, beallitasok.Height));
            }
            jatek.FillEllipse(Brushes.DarkRed, new Rectangle(alma.x * beallitasok.Width, alma.y * beallitasok.Height, beallitasok.Width, beallitasok.Height));
        }
    }
}
