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
    public partial class Départ : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        private object textvoiture;

        public Départ()
        {
            InitializeComponent();
        }

        private void texttemps_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Page_d_acceuil p = new Page_d_acceuil();
            p.Show();
            this.Hide();
        }

        private void Départ_Load(object sender, EventArgs e)
        {

            try
            {
                var dblod = db.tblDepart.ToList();
                dataGridView1.DataSource = dblod;
                comboBoxvtr.DataSource = db.tblArrivé.ToList();
                comboBoxvtr.ValueMember = "ID";
                comboBoxvtr.DisplayMember = "ID";
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
                if (comboBoxvtr.Text != null & labelndc.Text != null & lbltemps.Text != null & lbltemps.Text != null)
                {


                    tblDepart s = new tblDepart();
                    s.Voiture_No = comboBoxvtr.Text;
                    s.Conducteur = labelndc.Text;
                    s.Type = labelpType.Text;
                    s.Temps_P= labelptemps.Text;

                    decimal str = Convert.ToDecimal(labelptemps.Text);
                    decimal amt = Convert.ToDecimal(textpmontant.Text);
                    decimal amttotale = str * amt;
                    s.Montant = amttotale;
                    s.Heure_de_départ= DateTime.Now;
                    db.tblDepart.InsertOnSubmit(s);
                    db.SubmitChanges();
                    MessageBox.Show("Départ avec succès.... ");

                    load();
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

        private void load()
        {
            var dblod = db.tblDepart.ToList();
            dataGridView1.DataSource = dblod;
            comboBoxvtr.DataSource = db.tblArrivé.ToList();
            comboBoxvtr.ValueMember = "Voiture No";
            comboBoxvtr.DisplayMember = "Voiture No";
        }

        private void comboBoxvtr_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                tblArrivé obj = comboBoxvtr.SelectedItem as tblArrivé;
                if (obj != null)
                {
                    labelndc.Text = obj.Nom_du_conducteur.ToString();
                    labelpType.Text = obj.Category.ToString();
                    labelptemps.Text = obj.Temps_d_arrêt.ToString();


                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur");
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indexrow = e.RowIndex;
            lblid.Text = dataGridView1.Rows[indexrow].Cells[0].Value.ToString();
            lbltemps.Text = dataGridView1.Rows[indexrow].Cells[6].Value.ToString();
            lblpayé.Text = dataGridView1.Rows[indexrow].Cells[5].Value.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblid.Text != null & labelndc.Text != null & lbltemps.Text != null & lbltemps.Text != null)
                {

                    if (MessageBox.Show("Voulez-vous Modifier...", "Modifier", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                    {




                        int st = Convert.ToInt32(lblid.Text);
                        var s = db.tblDepart.Where(o => o.ID == st).FirstOrDefault();
                        s.Voiture_No = comboBoxvtr.Text;
                        s.Conducteur = labelndc.Text;
                        s.Type = labelpType.Text;
                        s.Temps_P = labelptemps.Text;

                        decimal str = Convert.ToDecimal(labelptemps.Text);
                        decimal amt = Convert.ToDecimal(textpmontant.Text);
                        decimal amttotale = str * amt;
                        s.Montant = amttotale;
                        s.Heure_de_départ = DateTime.Now;
                        db.SubmitChanges();
                        MessageBox.Show("Donnée Modifier");

                        load();
                    }
                }
               
                    
                
                else
                {
                    MessageBox.Show("Emplacement NO ou Position vide.... Réessayer....!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "veuillez entrer un Montant....! et Reessayez");
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

                        int st = Convert.ToInt32(lblid.Text);
                        var s = db.tblDepart.Where(o => o.ID == st).FirstOrDefault();
                        db.tblDepart.DeleteOnSubmit(s);
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
            p.Title = "Rapport de départ";
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
                    var chk = db.tblDepart.Where(o => o.Voiture_No == sk || o.Conducteur== sk || o.Type== sk).ToList();
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
    }
    }

