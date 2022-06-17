using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using kulso_osztalyok;

namespace snake_hhu75j
{
    public partial class Form1 : Form
    {

        //private List<circle> kigyo = new List<circle>();
        
        KIGYO kelgyo = new KIGYO(704, 704);

        int pontszam;
        int maxPontszam;
        Random random = new Random();



        public Form1()
        {
            InitializeComponent();
            new beallitasok();

        }

        private void legomb(object sender, KeyEventArgs e)
        {
            kelgyo.Iranyit(e);
            if (e.KeyCode == Keys.Escape) JatekVege();
        }

        private void felgomb(object sender, KeyEventArgs e)
        {
            
        }

        private void start_game(object sender, EventArgs e)
        {
            Restart();
        }

        private void jatek_orajel(object sender, EventArgs e)
        {
            kelgyo.Mozgat(JatekVege, Megesz);
            palya.Invalidate();
        }

        private void palya_frissit(object sender, PaintEventArgs e)
        {
            kelgyo.UjraRajzoltat(e);
           /* Graphics jatek = e.graphics;

            brush kigyoszine;
            for (int i = 0; i < kelgyo.test.count; i++)
            {
                if (i == 0)
                {
                    kigyoszine = brushes.black;
                }
                else
                {
                    kigyoszine = brushes.green;
                }
                jatek.fillellipse(kigyoszine, new rectangle(kelgyo.test[i].x * beallitasok.width, kigyo[i].y * beallitasok.height, beallitasok.width, beallitasok.height));
            }
            jatek.FillEllipse(Brushes.DarkRed, new Rectangle(kaja.x * beallitasok.Width, kaja.y * beallitasok.Height, beallitasok.Width, beallitasok.Height));*/
        }

        private void palya_Click(object sender, EventArgs e)
        {

        }

        private void pontszamLabel_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void stopGomb_Click(object sender, EventArgs e)
        {
            JatekVege();
        }

        private void helpGomb_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Irányíáts: A kígyót a kurzor gombokkal irányíthatod.\nA kígyó a pálya szélére érve visszajön.\nAz elindított játékot az escape billentyűvel állíthatod meg.");
        }

        private void Restart()
        {
            kelgyo.Clear();
            kelgyo.InitializeBody(10);
            start_gomb.Enabled = false;

            helpGomb.Enabled = false;
            maxPontszamLabel.ForeColor = Color.Black;

            
            pontszam = 0;
            pontszamLabel.Text = $"Elért pontszám: {pontszam}";
            

            //kaja = new circle { x = random.Next(2, maxWidth), y = random.Next(2, maxHeight) };
           

            idozito.Start();

        }

        private void Megesz()
        {
            pontszam++;
            pontszamLabel.Text = $"Elért pontszám: {pontszam}";
            kelgyo.MegEtte();
        }

        private void JatekVege()
        {

            idozito.Stop();
            helpGomb.Enabled = true;
            start_gomb.Enabled = true;
            MessageBox.Show("Játék vége!");
            if (pontszam > maxPontszam)
            {
                maxPontszam = pontszam;
                maxPontszamLabel.Text = $"Legnagyobb pontszám: {pontszam}";
                maxPontszamLabel.ForeColor = Color.OrangeRed;
            }
            
        }
        
    }
}
