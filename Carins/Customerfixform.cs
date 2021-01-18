using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carins
{
    public partial class Customerfixform : Form
    {
        public string keeptime;
        public string keepusname;
        public string keepustype;
        public string cusname, carnum, cusphone, carprice;

        public void cleanup()
        {

            this.labname.Text = ".";
            this.labphone.Text = ".";
            this.txtcarplate.Text = "";
            this.txtcarv.Text = "";
            this.txtsp.Text = ";";
            this.txtsp.Text = "";
        }
        public Customerfixform()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button4_Click(object sender, EventArgs e)
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
            cleanup();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string usphone = this.txtsp.Text;
            if (usphone == "")
            {
                MessageBox.Show("Phone number empty !");
            }
            else
            {
                Operatedbclass opdb = new Operatedbclass();
                //opdb.Detecphone(usphone);
                string detectph = "";
                SqlConnection sqlconn = opdb.Opendbcn();
                sqlconn.Open();
                string sql2 = "select* from Cusinsinfo where Cusphone='" + usphone + "'";
                SqlCommand cmd2 = new SqlCommand(sql2, sqlconn);
                SqlDataReader dr = cmd2.ExecuteReader();
                if(dr.Read())
                    {
                        detectph = dr["Cusphone"].ToString();
                       // if (detectph == usphone)
                       // {

                            cusphone = dr["Cusphone"].ToString();
                            cusname = dr["Cusname"].ToString();
                            carnum = dr["Carnum"].ToString();
                            carprice = dr["Carprice"].ToString();

                       // }

                    }
                else
                {
                    MessageBox.Show("Phone number not exist !");
                }
                sqlconn.Close();
                this.labname.Text = cusname;
                this.labphone.Text = cusphone;
                this.txtcarplate.Text = carnum;
                this.txtcarv.Text = carprice;

            }

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if ((this.txtcarplate.Text == "") || (this.txtcarv.Text == "") || (this.labname.Text == ".") || (this.labphone.Text == "."))
            {
                MessageBox.Show("Please Fillup information !");

            }
            else
            {
                Operatedbclass opdb = new Operatedbclass();
                opdb.Updatecusinfo(this.labname.Text, this.txtcarplate.Text, this.labphone.Text, int.Parse(this.txtcarv.Text));
                MessageBox.Show("Update successful !");
                cleanup();
            }
        }

        private void txtcarv_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtsp_KeyPress(object sender, KeyPressEventArgs e)
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

