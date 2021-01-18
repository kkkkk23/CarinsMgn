namespace Carins
{
    partial class Cusrecordform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cusrecordform));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcusname = new System.Windows.Forms.TextBox();
            this.txtcarpn = new System.Windows.Forms.TextBox();
            this.txtphonen = new System.Windows.Forms.TextBox();
            this.txtcarp = new System.Windows.Forms.TextBox();
            this.btnback = new System.Windows.Forms.Button();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.55172F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.55172F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(33, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Car plate number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.55172F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(33, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.55172F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(33, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Car value(RM)";
            // 
            // txtcusname
            // 
            this.txtcusname.Font = new System.Drawing.Font("Times New Roman", 10.55172F, System.Drawing.FontStyle.Bold);
            this.txtcusname.Location = new System.Drawing.Point(184, 47);
            this.txtcusname.Name = "txtcusname";
            this.txtcusname.Size = new System.Drawing.Size(225, 27);
            this.txtcusname.TabIndex = 5;
            // 
            // txtcarpn
            // 
            this.txtcarpn.Font = new System.Drawing.Font("Times New Roman", 10.55172F, System.Drawing.FontStyle.Bold);
            this.txtcarpn.Location = new System.Drawing.Point(184, 133);
            this.txtcarpn.Name = "txtcarpn";
            this.txtcarpn.Size = new System.Drawing.Size(225, 27);
            this.txtcarpn.TabIndex = 6;
            // 
            // txtphonen
            // 
            this.txtphonen.Font = new System.Drawing.Font("Times New Roman", 10.55172F, System.Drawing.FontStyle.Bold);
            this.txtphonen.Location = new System.Drawing.Point(184, 219);
            this.txtphonen.Name = "txtphonen";
            this.txtphonen.Size = new System.Drawing.Size(225, 27);
            this.txtphonen.TabIndex = 7;
            this.txtphonen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtphonen_KeyPress);
            // 
            // txtcarp
            // 
            this.txtcarp.Font = new System.Drawing.Font("Times New Roman", 10.55172F, System.Drawing.FontStyle.Bold);
            this.txtcarp.Location = new System.Drawing.Point(184, 305);
            this.txtcarp.Name = "txtcarp";
            this.txtcarp.Size = new System.Drawing.Size(225, 27);
            this.txtcarp.TabIndex = 8;
            this.txtcarp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcarp_KeyPress);
            // 
            // btnback
            // 
            this.btnback.Font = new System.Drawing.Font("Times New Roman", 10.55172F, System.Drawing.FontStyle.Bold);
            this.btnback.Location = new System.Drawing.Point(47, 377);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(97, 46);
            this.btnback.TabIndex = 10;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnsubmit
            // 
            this.btnsubmit.Font = new System.Drawing.Font("Times New Roman", 10.55172F, System.Drawing.FontStyle.Bold);
            this.btnsubmit.Location = new System.Drawing.Point(299, 377);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(97, 46);
            this.btnsubmit.TabIndex = 11;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // btnreset
            // 
            this.btnreset.Font = new System.Drawing.Font("Times New Roman", 10.55172F, System.Drawing.FontStyle.Bold);
            this.btnreset.Location = new System.Drawing.Point(173, 377);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(97, 46);
            this.btnreset.TabIndex = 12;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // Cusrecordform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 470);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.txtcarp);
            this.Controls.Add(this.txtphonen);
            this.Controls.Add(this.txtcarpn);
            this.Controls.Add(this.txtcusname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Cusrecordform";
            this.Text = "Customer Information Recording";
            this.Load += new System.EventHandler(this.Cusrecordform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcusname;
        private System.Windows.Forms.TextBox txtcarpn;
        private System.Windows.Forms.TextBox txtphonen;
        private System.Windows.Forms.TextBox txtcarp;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.Button btnreset;
    }
}