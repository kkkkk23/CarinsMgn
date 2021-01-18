namespace Carins
{
    partial class Staffregform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staffregform));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtacc = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.combacty = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcpass = new System.Windows.Forms.TextBox();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.55172F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(29, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.55172F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(29, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtacc
            // 
            this.txtacc.Font = new System.Drawing.Font("Times New Roman", 10.55172F, System.Drawing.FontStyle.Bold);
            this.txtacc.Location = new System.Drawing.Point(181, 48);
            this.txtacc.Name = "txtacc";
            this.txtacc.Size = new System.Drawing.Size(211, 27);
            this.txtacc.TabIndex = 2;
            // 
            // txtpass
            // 
            this.txtpass.Font = new System.Drawing.Font("Times New Roman", 10.55172F, System.Drawing.FontStyle.Bold);
            this.txtpass.Location = new System.Drawing.Point(181, 119);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(211, 27);
            this.txtpass.TabIndex = 3;
            this.txtpass.UseSystemPasswordChar = true;
            // 
            // combacty
            // 
            this.combacty.Font = new System.Drawing.Font("Times New Roman", 10.55172F, System.Drawing.FontStyle.Bold);
            this.combacty.FormattingEnabled = true;
            this.combacty.Items.AddRange(new object[] {
            "Admin",
            "Staff"});
            this.combacty.Location = new System.Drawing.Point(181, 261);
            this.combacty.Name = "combacty";
            this.combacty.Size = new System.Drawing.Size(211, 27);
            this.combacty.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.55172F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(29, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Confirm password";
            // 
            // txtcpass
            // 
            this.txtcpass.Font = new System.Drawing.Font("Times New Roman", 10.55172F, System.Drawing.FontStyle.Bold);
            this.txtcpass.Location = new System.Drawing.Point(181, 190);
            this.txtcpass.Name = "txtcpass";
            this.txtcpass.Size = new System.Drawing.Size(211, 27);
            this.txtcpass.TabIndex = 6;
            this.txtcpass.UseSystemPasswordChar = true;
            // 
            // btnsubmit
            // 
            this.btnsubmit.Font = new System.Drawing.Font("Times New Roman", 10.55172F, System.Drawing.FontStyle.Bold);
            this.btnsubmit.Location = new System.Drawing.Point(295, 334);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(120, 46);
            this.btnsubmit.TabIndex = 7;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // btnreset
            // 
            this.btnreset.Font = new System.Drawing.Font("Times New Roman", 10.55172F, System.Drawing.FontStyle.Bold);
            this.btnreset.Location = new System.Drawing.Point(155, 334);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(120, 46);
            this.btnreset.TabIndex = 8;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.55172F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(29, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Account type";
            // 
            // btnback
            // 
            this.btnback.Font = new System.Drawing.Font("Times New Roman", 10.55172F, System.Drawing.FontStyle.Bold);
            this.btnback.Location = new System.Drawing.Point(15, 334);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(120, 46);
            this.btnback.TabIndex = 10;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // Staffregform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 416);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.txtcpass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.combacty);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtacc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Staffregform";
            this.Text = "Staff registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtacc;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.ComboBox combacty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcpass;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnback;
    }
}