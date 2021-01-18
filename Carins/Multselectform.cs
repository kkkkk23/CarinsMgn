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
    public partial class Multselectform : Form
    {
        public string lgtime;
        public string lgusname;
        public string lgustype;
        public Multselectform()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Multselectform_Load(object sender, EventArgs e)
        {
            this.txtusname.Text = "Current user: " + lgusname;
            this.txtlgtime.Text = "Login time: " + lgtime;
            this.txtustype.Text = "User type: " + lgustype;
        }

        private void btnl_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void btnrci_Click(object sender, EventArgs e)
        {
            Cusrecordform cusf = new Cusrecordform();
            cusf.keeptime = lgtime;
            cusf.keepusname = lgusname;
            cusf.keepustype = lgustype;
            this.Hide();
            cusf.ShowDialog();
            this.Close();
        }

        private void btnsr_Click(object sender, EventArgs e)
        {
            Staffregform stff = new Staffregform();
            stff.keeptime = lgtime;
            stff.keepusname = lgusname;
            stff.keepustype = lgustype;
            if (lgustype.Equals("Admin")){
                this.Hide();
                stff.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("You are not admin user. Cannot enter.");
            }
           
        }

        private void btnis_Click(object sender, EventArgs e)
        {
            Insuranceservicesform insvs = new Insuranceservicesform();
            insvs.keeptime = lgtime;
            insvs.keepusname = lgusname;
            insvs.keepustype = lgustype;
            this.Hide();
            insvs.ShowDialog();
            this.Close();
        }

        private void btncim_Click(object sender, EventArgs e)
        {
            Customerfixform cusfix = new Customerfixform();
            cusfix.keeptime = lgtime;
            cusfix.keepusname = lgusname;
            cusfix.keepustype = lgustype;
            this.Hide();
            cusfix.ShowDialog();
            this.Close();
        }
    }
}
