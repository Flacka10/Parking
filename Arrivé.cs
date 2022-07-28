using DGVPrinterHelper;
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
    public partial class Arrivé : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public Arrivé()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void email_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Page_d_acceuil p = new Page_d_acceuil();
            p.Show();
            this.Hide();
        }
        public void load()
        {
            var ld = db.tblArrivé.ToList();
            dataGridView1.DataSource = ld;
            labelid.Text = "";
            textconducteur.Text = "";
            textvoiture.Text = "";
            texttemps.Text = "";
            checkedListBox1.Text = "";

            var total = db.tblArrivé.Count();
            lbltotale.Text = total.ToString();



        }

        private void Arrivé_Load(object sender, EventArgs e)
        {
            load();
            comboBox1.DataSource = db.tblEmplacement.ToList();
            comboBox1.ValueMember = "ID";
            comboBox1.DisplayMember = "Voiture NO";

        }

        private void textconducteur_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textconducteur.Text != null & textvoiture.Text != null & texttemps.Text != null & checkedListBox1.Text != null & comboBox1.Text != null )
                {
                    string empl = textvoiture.Text;
                    var chk = db.tblArrivé.Where(o => o.Voiture_No == empl).FirstOrDefault();
                    if (chk == null)
                    {

                        tblArrivé s = new tblArrivé();
                        s.Nom_du_conducteur = textconducteur.Text;
                        s.Voiture_No = textvoiture.Text;
                        s.Category = checkedListBox1.Text;
                        s.Temps_d_arrêt = texttemps.Text;
                        s.Emplacement_sélectionné = comboBox1.Text;
                        s.Temps = DateTime.Now;                      
                        db.tblArrivé.InsertOnSubmit(s);
                        db.SubmitChanges();
                        MessageBox.Show("Donnée Parquées avec succès.... ");
                         
                        load();
                    }
                    else
                    {
                        MessageBox.Show("Déjà ajouter...");
                    }
                }
                else
                {
                    MessageBox.Show("Case vide Réessayer....!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int ir = e.RowIndex;
            labelid.Text = dataGridView1.Rows[ir].Cells[0].Value.ToString();
            textconducteur.Text = dataGridView1.Rows[ir].Cells[1].Value.ToString();
            textvoiture.Text = dataGridView1.Rows[ir].Cells[2].Value.ToString();
            lblvoitureno.Text = dataGridView1.Rows[ir].Cells[2].Value.ToString();
            texttemps.Text = dataGridView1.Rows[ir].Cells[3].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[ir].Cells[4].Value.ToString();
            checkedListBox1.Text = dataGridView1.Rows[ir].Cells[5].Value.ToString();
            lblarrivé.Text = dataGridView1.Rows[ir].Cells[56].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (labelid.Text!=null & textconducteur.Text != null & textvoiture.Text != null & texttemps.Text != null & checkedListBox1.Text != null & comboBox1.Text != null)
                {

                    if (MessageBox.Show("Voulez-vous Modifier...", "Modifier", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                    {

                        string empl = textvoiture.Text;
                        var chk = db.tblArrivé.Where(o => o.Voiture_No == empl).FirstOrDefault();
                        if (chk == null)
                        {
                            int st = Convert.ToInt32(labelid.Text);
                            var s = db.tblArrivé.Where(o => o.ID == st).FirstOrDefault();
                            s.Nom_du_conducteur = textconducteur.Text;
                            s.Voiture_No = textvoiture.Text;
                            s.Category = checkedListBox1.Text;
                            s.Temps_d_arrêt = texttemps.Text;
                            s.Emplacement_sélectionné = comboBox1.Text;
                            s.Temps = DateTime.Now;
                            db.SubmitChanges();
                            MessageBox.Show("Donnée Modifier");
                           
                            load();
                        }

                        else
                        {
                            MessageBox.Show("Déjà ajouter...");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Emplacement NO ou Position vide.... Réessayer....!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (labelid.Text != null)
                {

                    if (MessageBox.Show("Voulez-vous Supprimer...", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                    {

                        int st = Convert.ToInt32(lblarrivé.Text);
                        var s = db.tblArrivé.Where(o => o.ID == st).FirstOrDefault();
                        db.tblArrivé.DeleteOnSubmit(s);
                        db.SubmitChanges();
                        MessageBox.Show("Donnée Supprimer");

                        load();

                    }
                }
                else
                {
                    MessageBox.Show("Veuillez Selectionné une donnée et  Réessayer....!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DGVPrinter p = new DGVPrinter();
            p.printDocument = printDocument1;
            p.Title = "Rapport d'arrivé";
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

        private void textrecherche_TextChanged(object sender, EventArgs e)
        {
            if (textrecherche.Text == "")
            {
                load();
            }
            else
            {
                searchdata();
            }
        }
        public void searchdata()
        {

            try
            {
                if (textrecherche.Text != null)
                {
                    string sk = textrecherche.Text;
                    var chk = db.tblArrivé.Where(o => o.Nom_du_conducteur == sk || o.Voiture_No == sk ||o.Category==sk).ToList();
                    if (chk != null)
                    {

                        dataGridView1.DataSource = chk;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur");
            }


        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labelid_Click(object sender, EventArgs e)
        {

        }

        private void textvoiture_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblvoitureno_Click(object sender, EventArgs e)
        {

        }

        private void lbltotale_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lblarrivé_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void texttemps_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
