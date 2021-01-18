namespace Carins
{
    partial class Insuranceservicesform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Insuranceservicesform));
            this.dtgvis = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnviewallreceipt = new System.Windows.Forms.Button();
            this.btnviewall = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnsearchphone = new System.Windows.Forms.Button();
            this.txtrcid = new System.Windows.Forms.TextBox();
            this.txtsearchphone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labphonenum = new System.Windows.Forms.Label();
            this.labcarplate = new System.Windows.Forms.Label();
            this.labname = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labcarval = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.labsumm = new System.Windows.Forms.Label();
            this.labncd = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.comclaimfp = new System.Windows.Forms.ComboBox();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.labsum = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.labend = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtdd = new System.Windows.Forms.TextBox();
            this.txtmm = new System.Windows.Forms.TextBox();
            this.txtyy = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cominstype = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btndel = new System.Windows.Forms.Button();
            this.txtrciddel = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvis)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvis
            // 
            this.dtgvis.AllowUserToAddRows = false;
            this.dtgvis.AllowUserToDeleteRows = false;
            this.dtgvis.AllowUserToResizeColumns = false;
            this.dtgvis.AllowUserToResizeRows = false;
            this.dtgvis.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgvis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvis.Location = new System.Drawing.Point(12, 12);
            this.dtgvis.Name = "dtgvis";
            this.dtgvis.ReadOnly = true;
            this.dtgvis.RowTemplate.Height = 27;
            this.dtgvis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvis.Size = new System.Drawing.Size(1152, 280);
            this.dtgvis.TabIndex = 0;
            this.dtgvis.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvis_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnviewallreceipt);
            this.panel1.Controls.Add(this.btnviewall);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnsearchphone);
            this.panel1.Controls.Add(this.txtrcid);
            this.panel1.Controls.Add(this.txtsearchphone);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 311);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 256);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(359, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "--------------------------------------------";
            // 
            // btnviewallreceipt
            // 
            this.btnviewallreceipt.Font = new System.Drawing.Font("Times New Roman", 10.55172F, System.Drawing.FontStyle.Bold);
            this.btnviewallreceipt.Location = new System.Drawing.Point(18, 206);
            this.btnviewallreceipt.Name = "btnviewallreceipt";
            this.btnviewallreceipt.Size = new System.Drawing.Size(329, 35);
            this.btnviewallreceipt.TabIndex = 9;
            this.btnviewallreceipt.Text = "View receipt detail";
            this.btnviewallreceipt.UseVisualStyleBackColor = true;
            this.btnviewallreceipt.Click += new System.EventHandler(this.btnviewallreceipt_Click);
            // 
            // btnviewall
            // 
            this.btnviewall.Font = new System.Drawing.Font("Times New Roman", 10.55172F, System.Drawing.FontStyle.Bold);
            this.btnviewall.Location = new System.Drawing.Point(196, 97);
            this.btnviewall.Name = "btnviewall";
            this.btnviewall.Size = new System.Drawing.Size(151, 35);
            this.btnviewall.TabIndex = 8;
            this.btnviewall.Text = "View all record";
            this.btnviewall.UseVisualStyleBackColor = true;
            this.btnviewall.Click += new System.EventHandler(this.btnviewall_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.55172F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Search";
            // 
            // btnsearchphone
            // 
            this.btnsearchphone.Font = new System.Drawing.Font("Times New Roman", 10.55172F, System.Drawing.FontStyle.Bold);
            this.btnsearchphone.Location = new System.Drawing.Point(18, 97);
            this.btnsearchphone.Name = "btnsearchphone";
            this.btnsearchphone.Size = new System.Drawing.Size(151, 35);
            this.btnsearchphone.TabIndex = 5;
            this.btnsearchphone.Text = "Search by phone";
            this.btnsearchphone.UseVisualStyleBackColor = true;
            this.btnsearchphone.Click += new System.EventHandler(this.btnsearchphone_Click);
            // 
            // txtrcid
            // 
            this.txtrcid.Font = new System.Drawing.Font("Times New Roman", 10.55172F, System.Drawing.FontStyle.Bold);
            this.txtrcid.Location = new System.Drawing.Point(145, 161);
            this.txtrcid.Name = "txtrcid";
            this.txtrcid.Size = new System.Drawing.Size(202, 27);
            this.txtrcid.TabIndex = 4;
            this.txtrcid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtrcid_KeyPress);
            // 
            // txtsearchphone
            // 
            this.txtsearchphone.Font = new System.Drawing.Font("Times New Roman", 10.55172F, System.Drawing.FontStyle.Bold);
            this.txtsearchphone.Location = new System.Drawing.Point(145, 47);
            this.txtsearchphone.Name = "txtsearchphone";
            this.txtsearchphone.Size = new System.Drawing.Size(202, 27);
            this.txtsearchphone.TabIndex = 3;
            this.txtsearchphone.TextChanged += new System.EventHandler(this.txtsearchphone_TextChanged);
            this.txtsearchphone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsearchphone_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.55172F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(14, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Receipt id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.55172F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(14, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phone number";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.labphonenum);
            this.panel2.Controls.Add(this.labcarplate);
            this.panel2.Controls.Add(this.labname);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.labcarval);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(400, 311);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(272, 256);
            this.panel2.TabIndex = 2;
            // 
            // labphonenum
            // 
            this.labphonenum.AutoSize = true;
            this.labphonenum.Font = new System.Drawing.Font("Times New Roman", 10.55172F, System.Drawing.FontStyle.Bold);
            this.labphonenum.Location = new System.Drawing.Point(122, 153);
            this.labphonenum.Name = "labphonenum";
            this.labphonenum.Size = new System.Drawing.Size(13, 19);
            this.labphonenum.TabIndex = 8;
            this.labphonenum.Text = ".";
            // 
            // labcarplate
            // 
            this.labcarplate.AutoSize = true;
            this.labcarplate.Font = new System.Drawing.Font("Times New Roman", 10.55172F, System.Drawing.FontStyle.Bold);
            this.labcarplate.Location = new System.Drawing.Point(145, 105);
            this.labcarplate.Name = "labcarplate";
            this.labcarplate.Size = new System.Drawing.Size(13, 19);
            this.labcarplate.TabIndex = 7;
            this.labcarplate.Text = ".";
            // 
            // labname
            // 
            this.labname.AutoSize = true;
            this.labname.Font = new System.Drawing.Font("Times New Roman", 10.55172F, System.Drawing.FontStyle.Bold);
            this.labname.Location = new System.Drawing.Point(62, 57);
            this.labname.Name = "labname";
            this.labname.Size = new System.Drawing.Size(13, 19);
            this.labname.TabIndex = 6;
            this.labname.Text = ".";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10.55172F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(3, 153);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 19);
            this.label10.TabIndex = 5;
            this.label10.Text = "Phone number:";
            // 
            // labcarval
            // 
            this.labcarval.AutoSize = true;
            this.labcarval.Font = new System.Drawing.Font("Times New Roman", 10.55172F, System.Drawing.FontStyle.Bold);
            this.labcarval.Location = new System.Drawing.Point(123, 201);
            this.labcarval.Name = "labcarval";
            this.labcarval.Size = new System.Drawing.Size(13, 19);
            this.labcarval.TabIndex = 4;
            this.labcarval.Text = ".";
            this.labcarval.Click += new System.EventHandler(this.labcarval_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.55172F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(2, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 19);
            this.label8.TabIndex = 3;
            this.label8.Text = "Car value(RM):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.55172F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label7.Location = new System.Drawing.Point(3, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 19);
            this.label7.TabIndex = 2;
            this.label7.Text = "Customer information";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.55172F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(3, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Car plate number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.55172F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(3, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Name: ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.labsumm);
            this.panel3.Controls.Add(this.labncd);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.comclaimfp);
            this.panel3.Controls.Add(this.btnsubmit);
            this.panel3.Controls.Add(this.labsum);
            this.panel3.Controls.Add(this.label21);
            this.panel3.Controls.Add(this.labend);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.txtdd);
            this.panel3.Controls.Add(this.txtmm);
            this.panel3.Controls.Add(this.txtyy);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.cominstype);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Location = new System.Drawing.Point(691, 311);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(311, 256);
            this.panel3.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(111, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "YY      MM      DD";
            // 
            // labsumm
            // 
            this.labsumm.AutoSize = true;
            this.labsumm.Font = new System.Drawing.Font("Times New Roman", 10.55172F, System.Drawing.FontStyle.Bold);
            this.labsumm.Location = new System.Drawing.Point(93, 219);
            this.labsumm.Name = "labsumm";
            this.labsumm.Size = new System.Drawing.Size(13, 19);
            this.labsumm.TabIndex = 17;
            this.labsumm.Text = ".";
            this.labsumm.Click += new System.EventHandler(this.label9_Click);
            // 
            // labncd
            // 
            this.labncd.AutoSize = true;
            this.labncd.Font = new System.Drawing.Font("Times New Roman", 10.55172F, System.Drawing.FontStyle.Bold);
            this.labncd.Location = new System.Drawing.Point(59, 114);
            this.labncd.Name = "labncd";
            this.labncd.Size = new System.Drawing.Size(13, 19);
            this.labncd.TabIndex = 16;
            this.labncd.Text = ".";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 10.55172F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(7, 114);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(51, 19);
            this.label17.TabIndex = 15;
            this.label17.Text = "NCD:";
            // 
            // comclaimfp
            // 
            this.comclaimfp.Font = new System.Drawing.Font("Times New Roman", 10.55172F, System.Drawing.FontStyle.Bold);
            this.comclaimfp.FormattingEnabled = true;
            this.comclaimfp.Items.AddRange(new object[] {
            "After 1st Year",
            "After 2nd Year",
            "After 3rd Year",
            "After 4th Year",
            "After 5th Year",
            "6th Years Onwards",
            "None"});
            this.comclaimfp.Location = new System.Drawing.Point(147, 76);
            this.comclaimfp.Name = "comclaimfp";
            this.comclaimfp.Size = new System.Drawing.Size(147, 27);
            this.comclaimfp.TabIndex = 14;
            this.comclaimfp.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // btnsubmit
            // 
            this.btnsubmit.Font = new System.Drawing.Font("Times New Roman", 10.55172F, System.Drawing.FontStyle.Bold);
            this.btnsubmit.Location = new System.Drawing.Point(205, 206);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(89, 35);
            this.btnsubmit.TabIndex = 13;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // labsum
            // 
            this.labsum.AutoSize = true;
            this.labsum.Font = new System.Drawing.Font("Times New Roman", 10.55172F, System.Drawing.FontStyle.Bold);
            this.labsum.Location = new System.Drawing.Point(90, 219);
            this.labsum.Name = "labsum";
            this.labsum.Size = new System.Drawing.Size(0, 19);
            this.labsum.TabIndex = 12;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Times New Roman", 10.55172F, System.Drawing.FontStyle.Bold);
            this.label21.Location = new System.Drawing.Point(7, 219);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(91, 19);
            this.label21.TabIndex = 11;
            this.label21.Text = "Sum(RM): ";
            // 
            // labend
            // 
            this.labend.AutoSize = true;
            this.labend.Font = new System.Drawing.Font("Times New Roman", 10.55172F, System.Drawing.FontStyle.Bold);
            this.labend.Location = new System.Drawing.Point(84, 184);
            this.labend.Name = "labend";
            this.labend.Size = new System.Drawing.Size(79, 19);
            this.labend.TabIndex = 10;
            this.labend.Text = "Next Year";
            this.labend.Click += new System.EventHandler(this.labend_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 10.55172F, System.Drawing.FontStyle.Bold);
            this.label19.Location = new System.Drawing.Point(7, 184);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(79, 19);
            this.label19.TabIndex = 9;
            this.label19.Text = "End date:";
            // 
            // txtdd
            // 
            this.txtdd.Font = new System.Drawing.Font("Times New Roman", 10.55172F, System.Drawing.FontStyle.Bold);
            this.txtdd.Location = new System.Drawing.Point(226, 146);
            this.txtdd.Name = "txtdd";
            this.txtdd.Size = new System.Drawing.Size(68, 27);
            this.txtdd.TabIndex = 8;
            this.txtdd.TextChanged += new System.EventHandler(this.txtdd_TextChanged);
            this.txtdd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdd_KeyPress);
            // 
            // txtmm
            // 
            this.txtmm.Font = new System.Drawing.Font("Times New Roman", 10.55172F, System.Drawing.FontStyle.Bold);
            this.txtmm.Location = new System.Drawing.Point(157, 146);
            this.txtmm.Name = "txtmm";
            this.txtmm.Size = new System.Drawing.Size(63, 27);
            this.txtmm.TabIndex = 7;
            this.txtmm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmm_KeyPress);
            // 
            // txtyy
            // 
            this.txtyy.Font = new System.Drawing.Font("Times New Roman", 10.55172F, System.Drawing.FontStyle.Bold);
            this.txtyy.Location = new System.Drawing.Point(94, 146);
            this.txtyy.Name = "txtyy";
            this.txtyy.Size = new System.Drawing.Size(57, 27);
            this.txtyy.TabIndex = 6;
            this.txtyy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtyy_KeyPress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 10.55172F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(7, 149);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(87, 19);
            this.label18.TabIndex = 5;
            this.label18.Text = "Start date:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 10.55172F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(7, 79);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(141, 19);
            this.label16.TabIndex = 3;
            this.label16.Text = "Claim free period";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // cominstype
            // 
            this.cominstype.Font = new System.Drawing.Font("Times New Roman", 10.55172F, System.Drawing.FontStyle.Bold);
            this.cominstype.FormattingEnabled = true;
            this.cominstype.Items.AddRange(new object[] {
            "Third party",
            "Third party-fire and theft",
            "Comprehensive cover"});
            this.cominstype.Location = new System.Drawing.Point(147, 41);
            this.cominstype.Name = "cominstype";
            this.cominstype.Size = new System.Drawing.Size(147, 27);
            this.cominstype.TabIndex = 2;
            this.cominstype.SelectedIndexChanged += new System.EventHandler(this.cominstype_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 10.55172F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(7, 44);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(116, 19);
            this.label15.TabIndex = 1;
            this.label15.Text = "Insurance type";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 10.55172F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label14.Location = new System.Drawing.Point(3, 10);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(135, 19);
            this.label14.TabIndex = 0;
            this.label14.Text = "Insurance record";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel4.Controls.Add(this.btndel);
            this.panel4.Controls.Add(this.txtrciddel);
            this.panel4.Controls.Add(this.label25);
            this.panel4.Controls.Add(this.label24);
            this.panel4.Location = new System.Drawing.Point(1018, 311);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(146, 172);
            this.panel4.TabIndex = 4;
            // 
            // btndel
            // 
            this.btndel.Font = new System.Drawing.Font("Times New Roman", 10.55172F, System.Drawing.FontStyle.Bold);
            this.btndel.Location = new System.Drawing.Point(16, 118);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(117, 37);
            this.btndel.TabIndex = 3;
            this.btndel.Text = "Delete";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // txtrciddel
            // 
            this.txtrciddel.Location = new System.Drawing.Point(3, 79);
            this.txtrciddel.Name = "txtrciddel";
            this.txtrciddel.Size = new System.Drawing.Size(140, 25);
            this.txtrciddel.TabIndex = 2;
            this.txtrciddel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtrciddel_KeyPress);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Times New Roman", 10.55172F, System.Drawing.FontStyle.Bold);
            this.label25.Location = new System.Drawing.Point(29, 48);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(85, 19);
            this.label25.TabIndex = 1;
            this.label25.Text = "Receipt id";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Times New Roman", 10.55172F, System.Drawing.FontStyle.Bold);
            this.label24.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label24.Location = new System.Drawing.Point(3, 12);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(111, 19);
            this.label24.TabIndex = 0;
            this.label24.Text = "Delete record";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.55172F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(1018, 532);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 10.55172F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(1018, 489);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 37);
            this.button2.TabIndex = 6;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Insuranceservicesform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1176, 579);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtgvis);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Insuranceservicesform";
            this.Text = "Insurance services";
            this.Load += new System.EventHandler(this.Insuranceservicesform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvis)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvis;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnsearchphone;
        private System.Windows.Forms.TextBox txtrcid;
        private System.Windows.Forms.TextBox txtsearchphone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labphonenum;
        private System.Windows.Forms.Label labcarplate;
        private System.Windows.Forms.Label labname;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labcarval;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnviewallreceipt;
        private System.Windows.Forms.Button btnviewall;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comclaimfp;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.Label labsum;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label labend;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cominstype;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labncd;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.TextBox txtrciddel;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labsumm;
        private System.Windows.Forms.TextBox txtdd;
        private System.Windows.Forms.TextBox txtmm;
        private System.Windows.Forms.TextBox txtyy;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
    }
}