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
    public partial class Facture_d4achat : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public Facture_d4achat()
        {
            InitializeComponent();
        }

        private void labelcp_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Facture_d4achat_Load(object sender, EventArgs e)
        {
            comboBoxvtr.DataSource = db.tblDepart.ToList();
            comboBoxvtr.ValueMember = "ID";
            comboBoxvtr.DisplayMember = "ID";
        }

        private void comboBoxvtr_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                tblDepart obj = comboBoxvtr.SelectedItem as tblDepart;
                if (obj != null)
                {
                    labelnomdc.Text = obj.Conducteur.ToString();
                    labeltp.Text = obj.Type.ToString();
                    labeletemps.Text = obj.Temps_P.ToString();
                    labelmontants.Text = obj.Montant.ToString();
                    labelvno.Text = obj.Voiture_No.ToString();
                    labeldtemps.Text = obj.Heure_de_départ.ToString();



                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Graphics myg = this.CreateGraphics();
                //size s= this.Size;
                bitmap = new Bitmap(this.Size.Width, this.Size.Height, myg);
                Graphics mg = Graphics.FromImage(bitmap);
                mg.CopyFromScreen(this.Location.X, Location.Y, 0, 0, this.Size);
                printPreviewDialog1.Show();
                    
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur");
            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }
        Bitmap bitmap;

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
