using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parking
{
    public partial class Page_d_acceuil : Form
    {
        public Page_d_acceuil()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Arrivé a = new Arrivé();
            a.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Insérer i = new Insérer();
            i.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Départ d = new Départ();
            d.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Réservation r = new Réservation();
            r.Show();
            this.Hide();

        }
    }
}
