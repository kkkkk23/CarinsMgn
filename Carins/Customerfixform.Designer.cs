namespace Carins
{
    partial class Customerfixform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customerfixform));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labname = new System.Windows.Forms.Label();
            this.labphone = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcarplate = new System.Windows.Forms.TextBox();
            this.txtcarv = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtsp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.55172F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(26, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.55172F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(26, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phone";
            // 
            // labname
            // 
            this.labname.AutoSize = true;
            this.labname.Font = new System.Drawing.Font("Times New Roman", 10.55172F, System.Drawing.FontStyle.Bold);
            this.labname.Location = new System.Drawing.Point(146, 40);
            this.labname.Name = "labname";
            this.labname.Size = new System.Drawing.Size(13, 19);
            this.labname.TabIndex = 2;
            this.labname.Text = ".";
            // 
            // labphone
            // 
            this.labphone.AutoSize = true;
            this.labphone.Font = new System.Drawing.Font("Times New Roman", 10.55172F, System.Drawing.FontStyle.Bold);
            this.labphone.Location = new System.Drawing.Point(146, 95);
            this.labphone.Name = "labphone";
            this.labphone.Size = new System.Drawing.Size(13, 19);
            this.labphone.TabIndex = 3;
            this.labphone.Text = ".";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.55172F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(26, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Car plate No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.55172F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(26, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Car value(RM)";
            // 
            // txtcarplate
            // 
            this.txtcarplate.Font = new System.Drawing.Font("Times New Roman", 10.55172F, System.Drawing.FontStyle.Bold);
            this.txtcarplate.Location = new System.Drawing.Point(150, 146);
            this.txtcarplate.Name = "txtcarplate";
            this.txtcarplate.Size = new System.Drawing.Size(173, 27);
            this.txtcarplate.TabIndex = 6;
            // 
            // txtcarv
            // 
            this.txtcarv.Font = new System.Drawing.Font("Times New Roman", 10.55172F, System.Drawing.FontStyle.Bold);
            this.txtcarv.Location = new System.Drawing.Point(150, 211);
            this.txtcarv.Name = "txtcarv";
            this.txtcarv.Size = new System.Drawing.Size(173, 27);
            this.txtcarv.TabIndex = 7;
            this.txtcarv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcarv_KeyPress);
            // 
            // btnsearch
            // 
            this.btnsearch.Font = new System.Drawing.Font("Times New Roman", 10.55172F, System.Drawing.FontStyle.Bold);
            this.btnsearch.Location = new System.Drawing.Point(329, 275);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(76, 28);
            this.btnsearch.TabIndex = 8;
            this.btnsearch.Text = "search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btnreset
            // 
            this.btnreset.Font = new System.Drawing.Font("Times New Roman", 10.55172F, System.Drawing.FontStyle.Bold);
            this.btnreset.Location = new System.Drawing.Point(150, 336);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(102, 43);
            this.btnreset.TabIndex = 9;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Times New Roman", 10.55172F, System.Drawing.FontStyle.Bold);
            this.btnupdate.Location = new System.Drawing.Point(290, 336);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(102, 43);
            this.btnupdate.TabIndex = 10;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnback
            // 
            this.btnback.Font = new System.Drawing.Font("Times New Roman", 10.55172F, System.Drawing.FontStyle.Bold);
            this.btnback.Location = new System.Drawing.Point(17, 336);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(102, 43);
            this.btnback.TabIndex = 11;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.button4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.55172F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(26, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Search phone";
            // 
            // txtsp
            // 
            this.txtsp.Font = new System.Drawing.Font("Times New Roman", 10.55172F, System.Drawing.FontStyle.Bold);
            this.txtsp.Location = new System.Drawing.Point(150, 276);
            this.txtsp.Name = "txtsp";
            this.txtsp.Size = new System.Drawing.Size(173, 27);
            this.txtsp.TabIndex = 13;
            this.txtsp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsp_KeyPress);
            // 
            // Customerfixform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 418);
            this.Controls.Add(this.txtsp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.txtcarv);
            this.Controls.Add(this.txtcarplate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labphone);
            this.Controls.Add(this.labname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Customerfixform";
            this.Text = "Information modify";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labname;
        private System.Windows.Forms.Label labphone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtcarplate;
        private System.Windows.Forms.TextBox txtcarv;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtsp;
    }
}