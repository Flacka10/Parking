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
    public partial class Insérer : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public Insérer()
        {
            InitializeComponent();
        }

        private void Insérer_Load(object sender, EventArgs e)
        {
            load();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Page_d_acceuil s = new Page_d_acceuil();
            s.Show();
            this.Hide();

        }

        private void textpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void reset()
        {
            textempl.Text = "";
            textposition.Text = "";
            labelid.Text = "";
        }
        public void load()
        {
            var lod = db.tblEmplacement.ToList();
            dataGridView1.DataSource = lod;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
             if(textempl.Text!=null & textposition.Text != null)
                {
                   string empl = textempl.Text;
                    var chk = db.tblEmplacement.Where(o => o.Emplacement_No == empl).FirstOrDefault();
                    if(chk==null)
                    { 

                    tblEmplacement s = new tblEmplacement();
                    s.Emplacement_No = textempl.Text;
                    s.Position = textposition.Text;
                    db.tblEmplacement.InsertOnSubmit(s);
                    db.SubmitChanges();
                    MessageBox.Show("Donnée Insérer");
                    reset();
                    load();
                    }
                    else
                    {
                        MessageBox.Show("Déjà ajouter...");
                    }
                }
                else
                {
                    MessageBox.Show("Emplacement NO ou Position vide.... Réessayer....!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur");
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int ir = e.RowIndex;
            labelid.Text = dataGridView1.Rows[ir].Cells[0].Value.ToString();
            textempl.Text = dataGridView1.Rows[ir].Cells[1].Value.ToString();
            textposition.Text = dataGridView1.Rows[ir].Cells[2].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (labelid.Text!=null & textempl.Text != null & textposition.Text != null)
                {

                    if (MessageBox.Show("Voulez-vous Modifier...", "Modifier", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                    {

                        string empl = textempl.Text;
                        var chk = db.tblEmplacement.Where(o => o.Emplacement_No == empl).FirstOrDefault();
                        if (chk == null)
                        {
                            int st = Convert.ToInt32(labelid.Text);
                            var s = db.tblEmplacement.Where(o => o.ID == st).FirstOrDefault();
                            s.Emplacement_No = textempl.Text;
                            s.Position = textposition.Text;
                           
                            db.SubmitChanges();
                            MessageBox.Show("Donnée Modifier");
                            reset();
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

                            int st = Convert.ToInt32(labelid.Text);
                            var s = db.tblEmplacement.Where(o => o.ID == st).FirstOrDefault();
                        db.tblEmplacement.DeleteOnSubmit(s);
                            db.SubmitChanges();
                            MessageBox.Show("Donnée Supprimer");
                            reset();
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
                if(textrecherche.Text!=null)
                {
                    string sk = textrecherche.Text;
                    var chk = db.tblEmplacement.Where(o => o.Emplacement_No == sk || o.Position == sk).ToList();
                    if (chk!=null)
                    {
                        
                        dataGridView1.DataSource = chk;
                    }
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur");
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            DGVPrinter p = new DGVPrinter();
            p.printDocument = printDocument1;
            p.Title = "Rapport de capacité totale des voitures";
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textposition_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_Click(object sender, EventArgs e)
        {

        }

        private void password_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
