using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardGame
{
    public partial class girisEkrani : Form
    {
        public girisEkrani()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            Visible = false;
            frm.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = true;
            label1.Text = "Furkan SALMANLI \n 201613172021 \n Bilgisayar Mühendisliği ";

        }

        private void girisEkrani_Load(object sender, EventArgs e)
        {
            button4.Visible = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = false;
            label1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
