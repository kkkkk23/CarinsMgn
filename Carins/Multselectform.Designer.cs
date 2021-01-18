namespace Carins
{
    partial class Multselectform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Multselectform));
            this.btnsr = new System.Windows.Forms.Button();
            this.btnrci = new System.Windows.Forms.Button();
            this.btnis = new System.Windows.Forms.Button();
            this.btnl = new System.Windows.Forms.Button();
            this.txtusname = new System.Windows.Forms.Label();
            this.txtlgtime = new System.Windows.Forms.Label();
            this.txtustype = new System.Windows.Forms.Label();
            this.btncim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnsr
            // 
            this.btnsr.Font = new System.Drawing.Font("Times New Roman", 10.55172F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsr.Location = new System.Drawing.Point(111, 43);
            this.btnsr.Name = "btnsr";
            this.btnsr.Size = new System.Drawing.Size(188, 63);
            this.btnsr.TabIndex = 0;
            this.btnsr.Text = "Staff registration";
            this.btnsr.UseVisualStyleBackColor = true;
            this.btnsr.Click += new System.EventHandler(this.btnsr_Click);
            // 
            // btnrci
            // 
            this.btnrci.Font = new System.Drawing.Font("Times New Roman", 10.55172F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrci.Location = new System.Drawing.Point(111, 119);
            this.btnrci.Name = "btnrci";
            this.btnrci.Size = new System.Drawing.Size(188, 63);
            this.btnrci.TabIndex = 1;
            this.btnrci.Text = "Record customer information";
            this.btnrci.UseVisualStyleBackColor = true;
            this.btnrci.Click += new System.EventHandler(this.btnrci_Click);
            // 
            // btnis
            // 
            this.btnis.Font = new System.Drawing.Font("Times New Roman", 10.55172F, System.Drawing.FontStyle.Bold);
            this.btnis.Location = new System.Drawing.Point(111, 271);
            this.btnis.Name = "btnis";
            this.btnis.Size = new System.Drawing.Size(188, 63);
            this.btnis.TabIndex = 2;
            this.btnis.Text = "Insurance services";
            this.btnis.UseVisualStyleBackColor = true;
            this.btnis.Click += new System.EventHandler(this.btnis_Click);
            // 
            // btnl
            // 
            this.btnl.Font = new System.Drawing.Font("Times New Roman", 10.55172F, System.Drawing.FontStyle.Bold);
            this.btnl.Location = new System.Drawing.Point(111, 347);
            this.btnl.Name = "btnl";
            this.btnl.Size = new System.Drawing.Size(188, 63);
            this.btnl.TabIndex = 3;
            this.btnl.Text = "Logout";
            this.btnl.UseVisualStyleBackColor = true;
            this.btnl.Click += new System.EventHandler(this.btnl_Click);
            // 
            // txtusname
            // 
            this.txtusname.AutoSize = true;
            this.txtusname.Font = new System.Drawing.Font("Times New Roman", 9.310345F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusname.Location = new System.Drawing.Point(12, 9);
            this.txtusname.Name = "txtusname";
            this.txtusname.Size = new System.Drawing.Size(47, 17);
            this.txtusname.TabIndex = 4;
            this.txtusname.Text = "label1";
            // 
            // txtlgtime
            // 
            this.txtlgtime.AutoSize = true;
            this.txtlgtime.Font = new System.Drawing.Font("Times New Roman", 9.310345F, System.Drawing.FontStyle.Bold);
            this.txtlgtime.Location = new System.Drawing.Point(12, 446);
            this.txtlgtime.Name = "txtlgtime";
            this.txtlgtime.Size = new System.Drawing.Size(47, 17);
            this.txtlgtime.TabIndex = 5;
            this.txtlgtime.Text = "label2";
            // 
            // txtustype
            // 
            this.txtustype.AutoSize = true;
            this.txtustype.Font = new System.Drawing.Font("Times New Roman", 9.310345F, System.Drawing.FontStyle.Bold);
            this.txtustype.Location = new System.Drawing.Point(275, 446);
            this.txtustype.Name = "txtustype";
            this.txtustype.Size = new System.Drawing.Size(47, 17);
            this.txtustype.TabIndex = 6;
            this.txtustype.Text = "label3";
            // 
            // btncim
            // 
            this.btncim.Font = new System.Drawing.Font("Times New Roman", 10.55172F, System.Drawing.FontStyle.Bold);
            this.btncim.Location = new System.Drawing.Point(111, 195);
            this.btncim.Name = "btncim";
            this.btncim.Size = new System.Drawing.Size(183, 63);
            this.btncim.TabIndex = 7;
            this.btncim.Text = "Customer information modify";
            this.btncim.UseVisualStyleBackColor = true;
            this.btncim.Click += new System.EventHandler(this.btncim_Click);
            // 
            // Multselectform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 470);
            this.Controls.Add(this.btncim);
            this.Controls.Add(this.txtustype);
            this.Controls.Add(this.txtlgtime);
            this.Controls.Add(this.txtusname);
            this.Controls.Add(this.btnl);
            this.Controls.Add(this.btnis);
            this.Controls.Add(this.btnrci);
            this.Controls.Add(this.btnsr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Multselectform";
            this.Text = "Services";
            this.Load += new System.EventHandler(this.Multselectform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsr;
        private System.Windows.Forms.Button btnrci;
        private System.Windows.Forms.Button btnis;
        private System.Windows.Forms.Button btnl;
        private System.Windows.Forms.Label txtusname;
        private System.Windows.Forms.Label txtlgtime;
        private System.Windows.Forms.Label txtustype;
        private System.Windows.Forms.Button btncim;
    }
}