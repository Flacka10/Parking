using DGVPrinterHelper;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Parking
{
    public partial class Réservation : Form
    {
        readonly DataClasses1DataContext db = new DataClasses1DataContext();
        public Réservation()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Réservation_Load(object sender, EventArgs e)
        {
            var ld = db.tblDepart.ToList();
            dataGridView1.DataSource = ld;
            Display();
        }
        public void Display()
        {
            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
            }
            lblmontant.Text = sum.ToString();
            var insérer = db.tblEmplacement.Count();
            labelcp.Text = insérer.ToString();
            var pca = db.tblArrivé.Count();
            labelarrive.Text = pca.ToString();

            var pca1 = db.tblDepart.Count();
            lbltotales.Text = pca1.ToString();
        }

        private void textrecherche_TextChanged(object sender, EventArgs e)
        {
            if (textrecherche.Text == "")
            {
                load();
                Display();
            }
            else
            {
                searchdata();
            }
        }

        private void load()
        {
            throw new NotImplementedException();
        }

        public void searchdata()
        {

            try
            {
                if (textrecherche.Text != null)
                {
                    string sk = textrecherche.Text;
                    var chk = db.tblDepart.Where(o => o.Voiture_No == sk || o.Conducteur == sk || o.Type == sk).ToList();
                    if (chk != null)
                    {

                        dataGridView1.DataSource = chk;
                        Display();

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DGVPrinter p = new DGVPrinter();
            p.printDocument = printDocument1;
            p.Title = "Rapport d'ensemble";
            p.SubTitle = string.Format("Date:0", DateTime.Now);
            p.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            p.printDocument = printDocument1;
            p.PageNumbers = true;
            p.PageNumberInHeader = true;
            p.PorportionalColumns = true;
            p.HeaderCellAlignment = StringAlignment.Near;
            p.Footer = "Parking de voiture";
            p.FooterSpacing = 15;
            p.PrintDataGridView(dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Facture_d4achat i = new Facture_d4achat();
            i.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}