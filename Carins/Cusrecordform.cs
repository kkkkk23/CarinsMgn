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
    public partial class Cusrecordform : Form
    {
        public string keeptime;
        public string keepusname;
        public string keepustype;

        public Cusrecordform()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public void cleantxtbox()
        {
            this.txtcarp.Text = "";
            this.txtcarpn.Text = "";
            this.txtcusname.Text = "";
            this.txtphonen.Text = "";
        }
        private void Cusrecordform_Load(object sender, EventArgs e)
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


        private void btnsubmit_Click(object sender, EventArgs e)
        {

            string tcusname, tcarnum, tcusph, tcarpr, countnum;
            int tcarpr2;
            tcusname = this.txtcusname.Text;
            tcarnum = this.txtcarpn.Text;
            tcusph = this.txtphonen.Text;
            tcarpr = this.txtcarp.Text;

            countnum = "0";
            if ((tcusname == "") || (tcarnum == "") || (tcusph == "") || (tcarpr == ""))
            {
                MessageBox.Show("Please Fillup information !");
            }
            else
            {
                try
                {
                    tcarpr2 = int.Parse(tcarpr);
                    Customerinfos cusinfosobj = new Customerinfos(tcusname, tcarnum, tcusph, tcarpr2);
                    Operatedbclass operatedb = new Operatedbclass();
                    if (operatedb.Matchphone(cusinfosobj.Cusphone) != countnum)
                    {
                        MessageBox.Show("Phone number alreay registered !");
                    }
                    else
                    {
                        operatedb.Insertcusinfo(cusinfosobj.Cusname, cusinfosobj.Carnum, cusinfosobj.Cusphone, cusinfosobj.Carprice);
                        MessageBox.Show("Register successful !");
                        cleantxtbox();
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
            this.txtcarp.Text = "";
            this.txtcarpn.Text = "";
            this.txtcusname.Text = "";
            this.txtphonen.Text = "";
        }

        private void txtcarp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8))//cannot enter other character except for number0-9
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
                return;
            }
        }

        private void txtphonen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8))//cannot enter other character except for number0-9
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
                return;
            }




        }
    }
}
