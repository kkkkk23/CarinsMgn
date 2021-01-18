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

namespace Carins
{
    public partial class Loginform : Form
    {
        
        public Loginform()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        

       

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string account = this.txtacc.Text;
            string passd = this.txtpass.Text;
            if ((account == "") || (passd == ""))
            {
                MessageBox.Show("Please enter account or password !");
                return;
            }
            else {
                try
                {
                    Operatedbclass operatedb = new Operatedbclass();
                    if (operatedb.Finduserpass(account) == passd)
                    {
                        Multselectform multslf = new Multselectform();
                        multslf.lgusname = account;
                        multslf.lgustype = operatedb.Findusertype(account);
                        multslf.lgtime = DateTime.Now.ToString();
                        this.Hide();
                        multslf.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Password error !");
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Some error happened " + ex.Message + "");
                }
            } 
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            this.txtacc.Text = "";
            this.txtpass.Text = "";
        }

        private void Loginform_Load(object sender, EventArgs e)
        {

        }
    }
}
