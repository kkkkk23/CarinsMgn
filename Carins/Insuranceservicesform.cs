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
    public partial class Insuranceservicesform : Form
    {
        public string keeptime;
        public string keepusname;
        public string keepustype;
        public int glbsum;
        public Insuranceservicesform()
        {
            InitializeComponent();
            this.dtgvis.SelectionMode = DataGridViewSelectionMode.FullRowSelect;//selecting
            this.dtgvis.ReadOnly = true;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Initdgvh()
        {
            this.dtgvis.Columns[0].HeaderText = "Receipt ID";
            this.dtgvis.Columns[1].HeaderText = "Name";
            this.dtgvis.Columns[2].HeaderText = "Car plate number";
            this.dtgvis.Columns[3].HeaderText = "Phone number";
            this.dtgvis.Columns[4].HeaderText = "Car value";
            this.dtgvis.Columns[5].HeaderText = "Insurance type";
            this.dtgvis.Columns[6].HeaderText = "Claim free period";
            this.dtgvis.Columns[7].HeaderText = "NCD";
            this.dtgvis.Columns[8].HeaderText = "Sum(RM)";
            this.dtgvis.Columns[9].HeaderText = "Insurance start date";
            this.dtgvis.Columns[10].HeaderText = "Insurance end date";


        }
        public void cleanup()
        {
            //this.dtgvis.Rows.Clear();
            this.txtsearchphone.Text = "";
            this.txtrciddel.Text = "";
            this.labname.Text = ".";
            this.labphonenum.Text = ".";
            this.labcarval.Text = ".";
            this.labcarplate.Text = ".";
            this.labncd.Text = ".";
            this.txtrcid.Text = "";
            this.txtyy.Text = "";
            this.labend.Text = "";
            this.labsumm.Text = ".";
            this.comclaimfp.Text = "";
            this.cominstype.Text = "";
            this.txtmm.Text = "";
            this.txtdd.Text = "";
            cominstype.Enabled = false;
            comclaimfp.Enabled = false;
        }
        private void Setdgvso(DataGridView dgv)
        {
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                dgv.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                //dgv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;//auto size column
            }
        }
        private void Insuranceservicesform_Load(object sender, EventArgs e)
        {
            Operatedbclass opdt = new Operatedbclass();
            opdt.initdtbind(this.dtgvis, "Insinfos");
            this.Initdgvh();
            Setdgvso(this.dtgvis);
            cominstype.Enabled = false;
            comclaimfp.Enabled = false;


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tfayear = this.comclaimfp.Text;
            if (tfayear == "After 1st Year")
            {
                labncd.Text = "25%";
            }
            if (tfayear == "After 2nd Year")
            {
                labncd.Text = "30%";

            }
            if (tfayear == "After 3rd Year")
            {
                labncd.Text = "38.33%";

            }
            if (tfayear == "After 4th Year")
            {
                labncd.Text = "45%";

            }
            if (tfayear == "After 5th Year")
            {
                labncd.Text = "55%";

            }
            if (tfayear == "6th Years Onwards")
            {
                labncd.Text = "55%";

            }
            if (tfayear == "None")
            {
                labncd.Text = "None";

            }
            ////////////cal
            int tcarv = int.Parse(this.labcarval.Text);
            string tinstype = this.cominstype.Text;
            //string tfayear = this.comclaimfp.Text;
            string tncd = this.labncd.Text;
            double tsum = new double();
            double dbcarval = Convert.ToDouble(tcarv);
            ////////////////////////////////cal
            if (tinstype == "Third party")
            {
                if (tncd == "25%")
                {
                    tsum = (dbcarval * 0.75 * 0.0266) + (dbcarval * 0.75 * 0.0266) * 0.06 + 10;
                }
                if (tncd == "30%")
                {
                    tsum = (dbcarval * 0.70 * 0.0266) + (dbcarval * 0.70 * 0.0266) * 0.06 + 10;
                }
                if (tncd == "38.33%")
                {
                    tsum = (dbcarval * 0.6167 * 0.0266) + (dbcarval * 0.6167 * 0.0266) * 0.06 + 10;
                }
                if (tncd == "45%")
                {
                    tsum = (dbcarval * 0.55 * 0.0266) + (dbcarval * 0.55 * 0.0266) * 0.06 + 10;
                }
                if (tncd == "55%")
                {
                    tsum = (dbcarval * 0.45 * 0.0266) + (dbcarval * 0.45 * 0.0266) * 0.06 + 10;
                }
                if (tncd == "None")
                {
                    tsum = (dbcarval * 0.0266) + (dbcarval * 0.0266) * 0.06 + 10;
                }
            }///////////////////////////////////
            if (tinstype == "Third party-fire and theft")
            {
                if (tncd == "25%")
                {
                    tsum = (dbcarval * 0.75 * 0.0275) + (dbcarval * 0.75 * 0.0275) * 0.06 + 10;
                }
                if (tncd == "30%")
                {
                    tsum = (dbcarval * 0.70 * 0.0275) + (dbcarval * 0.70 * 0.0275) * 0.06 + 10;
                }
                if (tncd == "38.33%")
                {
                    tsum = (dbcarval * 0.6167 * 0.0275) + (dbcarval * 0.6167 * 0.0275) * 0.06 + 10;
                }
                if (tncd == "45%")
                {
                    tsum = (dbcarval * 0.55 * 0.0275) + (dbcarval * 0.55 * 0.0275) * 0.06 + 10;
                }
                if (tncd == "55%")
                {
                    tsum = (dbcarval * 0.45 * 0.0275) + (dbcarval * 0.45 * 0.0275) * 0.06 + 10;
                }
                if (tncd == "None")
                {
                    tsum = (dbcarval * 0.0275) + (dbcarval * 0.0275) * 0.06 + 10;
                }
            }/////////////////////////////////////////////
            if (tinstype == "Comprehensive cover")
            {
                if (tncd == "25%")
                {
                    tsum = (dbcarval * 0.75 * 0.0284) + (dbcarval * 0.75 * 0.0284) * 0.06 + 10;
                }
                if (tncd == "30%")
                {
                    tsum = (dbcarval * 0.70 * 0.0284) + (dbcarval * 0.70 * 0.0284) * 0.06 + 10;
                }
                if (tncd == "38.33%")
                {
                    tsum = (dbcarval * 0.6167 * 0.0284) + (dbcarval * 0.6167 * 0.0284) * 0.06 + 10;
                }
                if (tncd == "45%")
                {
                    tsum = (dbcarval * 0.55 * 0.0284) + (dbcarval * 0.55 * 0.0284) * 0.06 + 10;
                }
                if (tncd == "55%")
                {
                    tsum = (dbcarval * 0.45 * 0.0284) + (dbcarval * 0.45 * 0.0284) * 0.06 + 10;
                }
                if (tncd == "None")
                {
                    tsum = (dbcarval * 0.0284) + (dbcarval * 0.0284) * 0.06 + 10;
                }
            }
            ////////////////////
            int finalsum = Convert.ToInt32(tsum);
            glbsum = finalsum;
            this.labsumm.Text = finalsum.ToString();

        }

        private void dtgvis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                this.labname.Text = dtgvis.Rows[e.RowIndex].Cells[1].Value.ToString();
                this.labcarplate.Text = dtgvis.Rows[e.RowIndex].Cells[2].Value.ToString();
                this.labphonenum.Text = dtgvis.Rows[e.RowIndex].Cells[3].Value.ToString();
                this.labcarval.Text = dtgvis.Rows[e.RowIndex].Cells[4].Value.ToString();
            }


            string tcusname = this.labname.Text;
            string tcarnum = this.labcarplate.Text;
            string tcusphone = this.labphonenum.Text;
            if (tcarnum == "." || tcusname == "." || tcusphone == ".")
            {
                cominstype.Enabled = false;
                comclaimfp.Enabled = false;
            }
            else
            {
                cominstype.Enabled = true;
                comclaimfp.Enabled = true;
            }
            if (e.RowIndex == -1) { return; }
        }

        private void btnsearchphone_Click(object sender, EventArgs e)
        {
            string phonenum = this.txtsearchphone.Text;
            Operatedbclass opdt = new Operatedbclass();
            if (phonenum == "")
            {
                MessageBox.Show("Phone number empty !");
            }
            else
            {
                if (opdt.dtbind(this.dtgvis, "Cusinsinfo", phonenum) == "")
                {
                    MessageBox.Show("Phone number not exist !");
                }
                else
                {
                    opdt.dtbind(this.dtgvis, "Cusinsinfo", phonenum);
                }
            }
        }

        private void btnviewall_Click(object sender, EventArgs e)
        {
            string phonenum = this.txtsearchphone.Text;
            Operatedbclass opdt = new Operatedbclass();
            if (phonenum == "")
            {
                MessageBox.Show("Phone number empty !");
            }
            else
            {
                if (opdt.dtallbind(this.dtgvis, "Insinfos", phonenum) == "")
                {
                    MessageBox.Show("No record!");
                }
                else
                {
                    opdt.dtallbind(this.dtgvis, "Insinfos", phonenum);
                }

            }
        }

        private void btnviewallreceipt_Click(object sender, EventArgs e)
        {
            string rcid = this.txtrcid.Text;

            Operatedbclass opdt = new Operatedbclass();
            if (rcid == "")
            {
                MessageBox.Show("Receipt id empty !");
            }
            else
            {
                int rcidnum = int.Parse(this.txtrcid.Text);
                if (opdt.dtrcbind(this.dtgvis, "Insinfos", rcidnum) == "")
                {
                    MessageBox.Show("Receipt id not exist !");
                }
                else
                {
                    opdt.dtrcbind(this.dtgvis, "Insinfos", rcidnum);
                }
            }

        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            Randomidclass rand = new Randomidclass();
            int trcid = rand.genrandid();
            string tcusname = this.labname.Text;
            string tcarnum = this.labcarplate.Text;
            string tcusphone = this.labphonenum.Text;
            string tinstype = this.cominstype.Text;
            string tfayear = this.comclaimfp.Text;
            string tncd = this.labncd.Text;
            string tyy = this.txtyy.Text;
            string tmm = this.txtmm.Text;
            string tdd = this.txtdd.Text;
            string tstdate = tyy + "-" + tmm + "-" + tdd;
            


            if ((tinstype == "") || (tfayear == "") || (tyy == "") || (tmm == "") || (tdd == "")||(tncd=="."))
            {
                MessageBox.Show("Please Fillup information !");
            }
            else
            {
                try
                {
                    string tendyy = (int.Parse(tyy) + 1).ToString();
                    string tenddate = tendyy + "-" + tmm + "-" + tdd;
                    int tcarv = int.Parse(this.labcarval.Text);
                    Operatedbclass opdb = new Operatedbclass();
                    Insurancedetails insd = new Insurancedetails(trcid, tcusname, tcarnum, tcusphone, tcarv, tinstype,
                        tfayear, tncd, glbsum, tstdate, tenddate);
                    opdb.Insertinsrecord(insd.Rcid, insd.Cusname, insd.Carnum, insd.Cusphone, insd.Carprice, insd.Instype, insd.Fayear,
                        insd.Ncd, insd.Sum, insd.Stdate, insd.Enddate);
                    MessageBox.Show("Submit successful! Please research to view record.");
                    cleanup();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Some error happened " + ex.Message + "");
                }
            }
        }

        private void txtdd_TextChanged(object sender, EventArgs e)
        {
            string tyy = this.txtyy.Text;
            string tmm = this.txtmm.Text;
            string tdd = this.txtdd.Text;
            if (tyy == "" || tmm == ""||tdd=="")
            {
                //this.txtyy.Text = "0";
                return;
                //MessageBox.Show("Fill up the year and month first !");
            }
            else
            {
                string tstdate = tyy + "-" + tmm + "-" + tdd;
                string tendyy = (int.Parse(tyy) + 1).ToString();
                string tenddate = tendyy + "-" + tmm + "-" + tdd;
                labend.Text = tenddate;
            }
           /* if (tdd == " ")
            {
                labend.Text = "";
            }*/

        }

        private void cominstype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Multselectform multf = new Multselectform();
            multf.lgtime = keeptime;
            multf.lgusname = keepusname;
            multf.lgustype = keepustype;
            multf.ShowDialog();
            this.Close();
        }



        private void label9_Click(object sender, EventArgs e)
        {
            this.labsumm.Text = glbsum.ToString();
        }

        private void btndel_Click(object sender, EventArgs e)
        {

            string sdelrcid = this.txtrciddel.Text;
            if (sdelrcid == "")
            {
                MessageBox.Show("Pleae fill up receipt id !");
            }
            else
            {
                try
                {
                    int delrcid = int.Parse(this.txtrciddel.Text);
                    Operatedbclass opdb = new Operatedbclass();
                    if (opdb.Detecrcid(delrcid) == "")
                    {
                        MessageBox.Show("Receipt id not exist.");
                    }
                    else
                    {
                        opdb.Deletercid(delrcid);
                        MessageBox.Show("Receipt " + sdelrcid + " delete successful !");
                        this.txtrciddel.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Some error happened " + ex.Message + "");
                }

            }
        }

        private void labend_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cleanup();

        }

        private void labcarval_Click(object sender, EventArgs e)
        {

        }

        private void txtsearchphone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsearchphone_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtrcid_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtyy_KeyPress(object sender, KeyPressEventArgs e)
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


        private void txtmm_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtdd_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtrciddel_KeyPress(object sender, KeyPressEventArgs e)
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