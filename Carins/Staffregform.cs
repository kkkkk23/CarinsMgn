using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carins
{
    public partial class Staffregform : Form
    {
        public string keeptime;
        public string keepusname;
        public string keepustype;
        public Staffregform()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Multselectform multf = new Multselectform();
            multf.lgtime = keeptime;
            multf.lgusname = keepusname;
            multf.lgustype = keepustype;
            multf.ShowDialog();
            this.Close();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            this.txtacc.Text = "";
            this.txtcpass.Text = "";
            this.txtpass.Text = "";
            this.combacty.Text = "";
        }
        public void cleanup() {
            this.txtacc.Text = "";
            this.txtcpass.Text = "";
            this.txtpass.Text = "";
            this.combacty.Text = "";
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            string acc, pass, actype,repass,countnum;
            acc = this.txtacc.Text;
            pass = this.txtpass.Text;
            repass = this.txtcpass.Text;
            actype = this.combacty.Text.Trim();
            countnum="0";
            if ((acc == "") || (pass == "") || (repass == "") || (actype == ""))
            {
                MessageBox.Show("Please Fillup information !");
            }
            else {
                try
                {
                    Staffinfos stinfo = new Staffinfos(actype, acc, repass);
                    Operatedbclass opdb = new Operatedbclass();

                    if (pass.Equals(repass))
                    {
                        if (opdb.Matchaccount(stinfo.Staccount) != countnum)
                        {
                            MessageBox.Show("Account already exist. Please use another one.");
                        }
                        else
                        {
                            opdb.Insertloinfo(stinfo.Actype, stinfo.Staccount, stinfo.Stpass);
                            MessageBox.Show("Register successful !");
                            cleanup();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password doesn't match with the confirm password !");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Some error happened " + ex.Message + "");
                }
            }
            
        }
    }
}
