
namespace Parking
{
    partial class Réservation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelcp = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelarrive = new System.Windows.Forms.Label();
            this.labelentrer = new System.Windows.Forms.Label();
            this.lbltotales = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.lbltemps = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblmontant = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textrecherche = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.35343F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.64657F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(939, 481);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 330);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.Location = new System.Drawing.Point(3, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(930, 330);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Parking.Properties.Resources._5e9e6dc1_7759_45af_8972_072d661e4030;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.labelcp);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.labelarrive);
            this.panel2.Controls.Add(this.labelentrer);
            this.panel2.Controls.Add(this.lbltotales);
            this.panel2.Controls.Add(this.lblid);
            this.panel2.Controls.Add(this.lbltemps);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lblmontant);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textrecherche);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(933, 139);
            this.panel2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(274, 60);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 40);
            this.button2.TabIndex = 24;
            this.button2.Text = "Imprimer la liste";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(141, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 40);
            this.button1.TabIndex = 23;
            this.button1.Text = "Facture d\'achat";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelcp
            // 
            this.labelcp.AutoSize = true;
            this.labelcp.BackColor = System.Drawing.Color.Transparent;
            this.labelcp.Cursor = System.Windows.Forms.Cursors.No;
            this.labelcp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelcp.Location = new System.Drawing.Point(445, 90);
            this.labelcp.Name = "labelcp";
            this.labelcp.Size = new System.Drawing.Size(80, 20);
            this.labelcp.TabIndex = 22;
            this.labelcp.Text = "Capacité";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.No;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(423, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Capacité";
            // 
            // labelarrive
            // 
            this.labelarrive.AutoSize = true;
            this.labelarrive.BackColor = System.Drawing.Color.Transparent;
            this.labelarrive.Cursor = System.Windows.Forms.Cursors.No;
            this.labelarrive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelarrive.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelarrive.Location = new System.Drawing.Point(585, 88);
            this.labelarrive.Name = "labelarrive";
            this.labelarrive.Size = new System.Drawing.Size(59, 20);
            this.labelarrive.TabIndex = 20;
            this.labelarrive.Text = "Entrer";
            // 
            // labelentrer
            // 
            this.labelentrer.AutoSize = true;
            this.labelentrer.BackColor = System.Drawing.Color.Transparent;
            this.labelentrer.Cursor = System.Windows.Forms.Cursors.No;
            this.labelentrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelentrer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelentrer.Location = new System.Drawing.Point(563, 60);
            this.labelentrer.Name = "labelentrer";
            this.labelentrer.Size = new System.Drawing.Size(114, 20);
            this.labelentrer.TabIndex = 19;
            this.labelentrer.Text = "Totale Entrer";
            // 
            // lbltotales
            // 
            this.lbltotales.AutoSize = true;
            this.lbltotales.BackColor = System.Drawing.Color.Transparent;
            this.lbltotales.Cursor = System.Windows.Forms.Cursors.No;
            this.lbltotales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotales.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbltotales.Location = new System.Drawing.Point(699, 88);
            this.lbltotales.Name = "lbltotales";
            this.lbltotales.Size = new System.Drawing.Size(58, 20);
            this.lbltotales.TabIndex = 18;
            this.lbltotales.Text = "temps";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.BackColor = System.Drawing.Color.Transparent;
            this.lblid.Cursor = System.Windows.Forms.Cursors.No;
            this.lblid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblid.Location = new System.Drawing.Point(20, 16);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(28, 20);
            this.lblid.TabIndex = 17;
            this.lblid.Text = "ID";
            // 
            // lbltemps
            // 
            this.lbltemps.AutoSize = true;
            this.lbltemps.BackColor = System.Drawing.Color.Transparent;
            this.lbltemps.Cursor = System.Windows.Forms.Cursors.No;
            this.lbltemps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltemps.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbltemps.Location = new System.Drawing.Point(806, 88);
            this.lbltemps.Name = "lbltemps";
            this.lbltemps.Size = new System.Drawing.Size(31, 20);
            this.lbltemps.TabIndex = 16;
            this.lbltemps.Text = "Rs";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.No;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(704, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Totale";
            // 
            // lblmontant
            // 
            this.lblmontant.AutoSize = true;
            this.lblmontant.BackColor = System.Drawing.Color.Transparent;
            this.lblmontant.Cursor = System.Windows.Forms.Cursors.No;
            this.lblmontant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmontant.ForeColor = System.Drawing.Color.White;
            this.lblmontant.Location = new System.Drawing.Point(843, 88);
            this.lblmontant.Name = "lblmontant";
            this.lblmontant.Size = new System.Drawing.Size(19, 20);
            this.lblmontant.TabIndex = 14;
            this.lblmontant.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Cursor = System.Windows.Forms.Cursors.No;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(806, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Montant ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(299, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(362, 37);
            this.label2.TabIndex = 10;
            this.label2.Text = "Réservation de Voiture";
            // 
            // textrecherche
            // 
            this.textrecherche.Location = new System.Drawing.Point(23, 67);
            this.textrecherche.Name = "textrecherche";
            this.textrecherche.Size = new System.Drawing.Size(112, 20);
            this.textrecherche.TabIndex = 9;
            this.textrecherche.TextChanged += new System.EventHandler(this.textrecherche_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.No;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(22, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Recherche";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(35, 105);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(68, 31);
            this.button3.TabIndex = 25;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Réservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(939, 481);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "Réservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Réservation";
            this.Load += new System.EventHandler(this.Réservation_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lbltemps;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblmontant;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textrecherche;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbltotales;
        private System.Windows.Forms.Label labelarrive;
        private System.Windows.Forms.Label labelentrer;
        private System.Windows.Forms.Label labelcp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button button3;
    }
}