using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Parking
{
    public partial class Form1 : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public Form1()
        {
            
            InitializeComponent();
        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (textpassword.Text!=null & textemail.Text!=null)
                {
                    var item = db.tblAccount.Where(s => s.Password == textpassword.Text & s.Email == textemail.Text).FirstOrDefault();
                    if(item!=null)
                    {
                        Page_d_acceuil wc = new Page_d_acceuil();
                        wc.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Your enter Account information not exist.... first create your account");
                    }
                }
                 else
                {
                    MessageBox.Show("Email or password not valid....! try again");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            
        }
    }
}
