
namespace Parking
{
    partial class Facture_d4achat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facture_d4achat));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelmontants = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labeletemps = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labeldtemps = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labeltp = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelvno = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelnomdc = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxvtr = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(890, 106);
            this.dataGridView1.TabIndex = 1;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labeldtemps);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.labelmontants);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.labeletemps);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 162);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 246);
            this.panel1.TabIndex = 0;
            // 
            // labelmontants
            // 
            this.labelmontants.AutoSize = true;
            this.labelmontants.BackColor = System.Drawing.Color.Transparent;
            this.labelmontants.Cursor = System.Windows.Forms.Cursors.No;
            this.labelmontants.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmontants.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelmontants.Location = new System.Drawing.Point(677, 147);
            this.labelmontants.Name = "labelmontants";
            this.labelmontants.Size = new System.Drawing.Size(44, 20);
            this.labelmontants.TabIndex = 24;
            this.labelmontants.Text = "00:0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Cursor = System.Windows.Forms.Cursors.No;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(660, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Montant";
            // 
            // labeletemps
            // 
            this.labeletemps.AutoSize = true;
            this.labeletemps.BackColor = System.Drawing.Color.Transparent;
            this.labeletemps.Cursor = System.Windows.Forms.Cursors.No;
            this.labeletemps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeletemps.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labeletemps.Location = new System.Drawing.Point(151, 127);
            this.labeletemps.Name = "labeletemps";
            this.labeletemps.Size = new System.Drawing.Size(58, 20);
            this.labeletemps.TabIndex = 22;
            this.labeletemps.Text = "temps";
            this.labeletemps.Click += new System.EventHandler(this.labelcp_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.No;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(16, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Temps D\'arrêt";
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
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.92944F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.07056F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(902, 411);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // labeldtemps
            // 
            this.labeldtemps.AutoSize = true;
            this.labeldtemps.BackColor = System.Drawing.Color.Transparent;
            this.labeldtemps.Cursor = System.Windows.Forms.Cursors.No;
            this.labeldtemps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldtemps.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labeldtemps.Location = new System.Drawing.Point(478, 127);
            this.labeldtemps.Name = "labeldtemps";
            this.labeldtemps.Size = new System.Drawing.Size(58, 20);
            this.labeldtemps.TabIndex = 26;
            this.labeldtemps.Text = "temps";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Cursor = System.Windows.Forms.Cursors.No;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(325, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Temps de Départ";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Parking.Properties.Resources.IMAG4758_5f97e1d8d4948_1920x1080;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.labeltp);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.labelvno);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.labelnomdc);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.comboBoxvtr);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(896, 153);
            this.panel2.TabIndex = 1;
            // 
            // labeltp
            // 
            this.labeltp.AutoSize = true;
            this.labeltp.BackColor = System.Drawing.Color.Transparent;
            this.labeltp.Cursor = System.Windows.Forms.Cursors.No;
            this.labeltp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labeltp.Location = new System.Drawing.Point(607, 93);
            this.labeltp.Name = "labeltp";
            this.labeltp.Size = new System.Drawing.Size(19, 20);
            this.labeltp.TabIndex = 30;
            this.labeltp.Text = "a";
            this.labeltp.Click += new System.EventHandler(this.label3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Cursor = System.Windows.Forms.Cursors.No;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(544, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 20);
            this.label8.TabIndex = 29;
            this.label8.Text = "Type";
            // 
            // labelvno
            // 
            this.labelvno.AutoSize = true;
            this.labelvno.BackColor = System.Drawing.Color.Transparent;
            this.labelvno.Cursor = System.Windows.Forms.Cursors.No;
            this.labelvno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelvno.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelvno.Location = new System.Drawing.Point(438, 93);
            this.labelvno.Name = "labelvno";
            this.labelvno.Size = new System.Drawing.Size(19, 20);
            this.labelvno.TabIndex = 28;
            this.labelvno.Text = "a";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Cursor = System.Windows.Forms.Cursors.No;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(316, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Voiture No";
            // 
            // labelnomdc
            // 
            this.labelnomdc.AutoSize = true;
            this.labelnomdc.BackColor = System.Drawing.Color.Transparent;
            this.labelnomdc.Cursor = System.Windows.Forms.Cursors.No;
            this.labelnomdc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnomdc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelnomdc.Location = new System.Drawing.Point(197, 93);
            this.labelnomdc.Name = "labelnomdc";
            this.labelnomdc.Size = new System.Drawing.Size(19, 20);
            this.labelnomdc.TabIndex = 26;
            this.labelnomdc.Text = "a";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(499, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 38);
            this.button1.TabIndex = 24;
            this.button1.Text = "Imprimer";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.No;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(26, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Nom du conducteur";
            // 
            // comboBoxvtr
            // 
            this.comboBoxvtr.FormattingEnabled = true;
            this.comboBoxvtr.Location = new System.Drawing.Point(355, 6);
            this.comboBoxvtr.Name = "comboBoxvtr";
            this.comboBoxvtr.Size = new System.Drawing.Size(121, 21);
            this.comboBoxvtr.TabIndex = 18;
            this.comboBoxvtr.SelectedIndexChanged += new System.EventHandler(this.comboBoxvtr_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(264, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(429, 37);
            this.label2.TabIndex = 10;
            this.label2.Text = "Réçu du Parking DeVoiture";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.No;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(244, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Recherche";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(653, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 38);
            this.button2.TabIndex = 31;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Facture_d4achat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(902, 411);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "Facture_d4achat";
            this.Text = "Facture_d4achat";
            this.Load += new System.EventHandler(this.Facture_d4achat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labeletemps;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelmontants;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxvtr;
        private System.Windows.Forms.Label labeltp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelvno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelnomdc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labeldtemps;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button button2;
    }
}