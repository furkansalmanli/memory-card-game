using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace CardGame
{
    public partial class Form1 : Form
    {
        Random Rastgele = new Random();
        public Form1()
        {
            InitializeComponent();
            AssingnIconsToSquares();
        }
        Label ilkEslestirme, ikinciEslestirme;
        WindowsMediaPlayer wmp = new WindowsMediaPlayer();
        WindowsMediaPlayer wmpa = new WindowsMediaPlayer();

        private void label2_Click(object sender, EventArgs e)
        {
            wmp.URL = "C:\\Proje Sesleri\\ButonSesi.mp3";
            wmp.controls.play();
            if (ilkEslestirme != null && ikinciEslestirme != null)
            {
                return;
            }
            Label clickedLabel = sender as Label;

            if (clickedLabel == null)
                return;

            if (clickedLabel.ForeColor == Color.Black)
                return;
            if (ilkEslestirme == null)
            {
                ilkEslestirme = clickedLabel;
                ilkEslestirme.ForeColor = Color.Black;
                return;
            }
            ikinciEslestirme = clickedLabel;
            ikinciEslestirme.ForeColor = Color.Black;
            if(ilkEslestirme.Text == ikinciEslestirme.Text)
            {
                if(ilkEslestirme.Text =="b")
                {
                    timer2.Stop();
                    wmp.URL = "C:\\Proje Sesleri\\Bicycle.mp3";
                    wmp.controls.play();
                    MessageBox.Show("Bisiklet = Bicycle");
                    timer2.Start();

                }
                if (ilkEslestirme.Text == "j")
                {
                    timer2.Stop();
                    wmp.URL = "C:\\Proje Sesleri\\Plane.mp3";
                    wmp.controls.play();
                    MessageBox.Show("Uçak = Plane");
                    timer2.Start();
                } if (ilkEslestirme.Text == "h")
                {
                    timer2.Stop();
                    wmp.URL = "C:\\Proje Sesleri\\Ambulance.mp3";
                    wmp.controls.play();
                    MessageBox.Show("Ambulans = Ambulance");
                    timer2.Start();
                } if (ilkEslestirme.Text == "z")
                {
                    timer2.Stop();
                    wmp.URL = "C:\\Proje Sesleri\\Error.mp3";
                    wmp.controls.play();
                    MessageBox.Show("Sigara içmek yasak = No Smoking");
                    timer2.Start();
                } if (ilkEslestirme.Text == "ö")
                {
                    timer2.Stop();
                    wmp.URL = "C:\\Proje Sesleri\\Cat.mp3";
                    wmp.controls.play();
                    MessageBox.Show("Kedi = Cat");
                    timer2.Start();
                } if (ilkEslestirme.Text == "t")
                {
                    timer2.Stop();
                    wmp.URL = "C:\\Proje Sesleri\\Train.mp3";
                    wmp.controls.play();
                    MessageBox.Show("Tren = Train");
                    timer2.Start();
                } if (ilkEslestirme.Text == "p")
                {
                    timer2.Stop();
                    wmp.URL = "C:\\Proje Sesleri\\Police.mp3";
                    wmp.controls.play();
                    MessageBox.Show("Polis Arabası = Police Car");
                    timer2.Start();
                } if (ilkEslestirme.Text == "v")
                {
                    timer2.Stop();
                    wmp.URL = "C:\\Proje Sesleri\\Bus.mp3";
                    wmp.controls.play();
                    MessageBox.Show("Otobüs = Bus");
                    timer2.Start();
                }
                ilkEslestirme = null;
                ikinciEslestirme = null;
            }else

            timer1.Start();
            wmp.controls.stop();
        }
        List<String> İcons = new List<String>(){
                 "b","b","j","j","h","h","ö","ö","z","z","t","t","p","p","v","v"
            };

        private void Form1_Load(object sender, EventArgs e)
        {
            timer2.Start();
            wmpa.URL = "";
            wmp.controls.stop();
        }

        public void AssingnIconsToSquares()
        {

            Label label;
            int rastgeleSecim;

            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                if (tableLayoutPanel1.Controls[i] is Label)

                    label = (Label)tableLayoutPanel1.Controls[i];

                else
                    continue;
                rastgeleSecim = Rastgele.Next(0, İcons.Count);
                label.Text = İcons[rastgeleSecim];
                İcons.RemoveAt(rastgeleSecim);
                


            }


        }
       

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            ilkEslestirme.ForeColor = ilkEslestirme.BackColor;
            ikinciEslestirme.ForeColor = ikinciEslestirme.BackColor;
            ilkEslestirme = null;
            ikinciEslestirme = null;
            

        }
        int sure = 90;
        private void timer2_Tick(object sender, EventArgs e)
        {
            sure = sure-1;
            label17.Text = Convert.ToString(sure);
            
        }
        
    }
}


