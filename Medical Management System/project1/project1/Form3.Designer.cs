
namespace project1
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.btnf3_addpatient = new System.Windows.Forms.Button();
            this.btnf3_viewpatient = new System.Windows.Forms.Button();
            this.btnf3_testdir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtf3_cash = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtf3_due = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtf3_patient = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtf3_host = new System.Windows.Forms.TextBox();
            this.btnf3_signout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnf3_addpatient
            // 
            this.btnf3_addpatient.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnf3_addpatient.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnf3_addpatient.FlatAppearance.BorderSize = 3;
            this.btnf3_addpatient.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnf3_addpatient.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnf3_addpatient.Location = new System.Drawing.Point(76, 107);
            this.btnf3_addpatient.Name = "btnf3_addpatient";
            this.btnf3_addpatient.Size = new System.Drawing.Size(124, 64);
            this.btnf3_addpatient.TabIndex = 16;
            this.btnf3_addpatient.Text = "Add New Patient";
            this.btnf3_addpatient.UseVisualStyleBackColor = false;
            this.btnf3_addpatient.Click += new System.EventHandler(this.btnf3_addpatient_Click);
            // 
            // btnf3_viewpatient
            // 
            this.btnf3_viewpatient.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnf3_viewpatient.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnf3_viewpatient.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnf3_viewpatient.Location = new System.Drawing.Point(247, 107);
            this.btnf3_viewpatient.Name = "btnf3_viewpatient";
            this.btnf3_viewpatient.Size = new System.Drawing.Size(124, 64);
            this.btnf3_viewpatient.TabIndex = 17;
            this.btnf3_viewpatient.Text = "View All Patients";
            this.btnf3_viewpatient.UseVisualStyleBackColor = false;
            this.btnf3_viewpatient.Click += new System.EventHandler(this.btnf3_viewpatient_Click);
            // 
            // btnf3_testdir
            // 
            this.btnf3_testdir.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnf3_testdir.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnf3_testdir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnf3_testdir.Location = new System.Drawing.Point(150, 212);
            this.btnf3_testdir.Name = "btnf3_testdir";
            this.btnf3_testdir.Size = new System.Drawing.Size(124, 64);
            this.btnf3_testdir.TabIndex = 18;
            this.btnf3_testdir.Text = "Test Directory";
            this.btnf3_testdir.UseVisualStyleBackColor = false;
            this.btnf3_testdir.Click += new System.EventHandler(this.btnf3_testdir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(487, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "Total Patient :";
            // 
            // txtf3_cash
            // 
            this.txtf3_cash.Location = new System.Drawing.Point(620, 202);
            this.txtf3_cash.Multiline = true;
            this.txtf3_cash.Name = "txtf3_cash";
            this.txtf3_cash.Size = new System.Drawing.Size(104, 24);
            this.txtf3_cash.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(514, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 24);
            this.label4.TabIndex = 24;
            this.label4.Text = "Total Due :";
            // 
            // txtf3_due
            // 
            this.txtf3_due.Location = new System.Drawing.Point(620, 257);
            this.txtf3_due.Multiline = true;
            this.txtf3_due.Name = "txtf3_due";
            this.txtf3_due.Size = new System.Drawing.Size(104, 24);
            this.txtf3_due.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(503, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 24);
            this.label2.TabIndex = 30;
            this.label2.Text = "Total Cash :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(325, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 38);
            this.label3.TabIndex = 29;
            this.label3.Text = "MENU";
            // 
            // txtf3_patient
            // 
            this.txtf3_patient.Location = new System.Drawing.Point(620, 147);
            this.txtf3_patient.Multiline = true;
            this.txtf3_patient.Name = "txtf3_patient";
            this.txtf3_patient.Size = new System.Drawing.Size(104, 24);
            this.txtf3_patient.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(607, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "Host :";
            // 
            // txtf3_host
            // 
            this.txtf3_host.Location = new System.Drawing.Point(657, 22);
            this.txtf3_host.Multiline = true;
            this.txtf3_host.Name = "txtf3_host";
            this.txtf3_host.ReadOnly = true;
            this.txtf3_host.Size = new System.Drawing.Size(76, 18);
            this.txtf3_host.TabIndex = 33;
            // 
            // btnf3_signout
            // 
            this.btnf3_signout.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnf3_signout.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnf3_signout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnf3_signout.Location = new System.Drawing.Point(660, 46);
            this.btnf3_signout.Name = "btnf3_signout";
            this.btnf3_signout.Size = new System.Drawing.Size(64, 27);
            this.btnf3_signout.TabIndex = 34;
            this.btnf3_signout.Text = "Sign Out";
            this.btnf3_signout.UseVisualStyleBackColor = false;
            this.btnf3_signout.Click += new System.EventHandler(this.btnf3_signout_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(766, 360);
            this.Controls.Add(this.btnf3_signout);
            this.Controls.Add(this.txtf3_host);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtf3_patient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtf3_due);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtf3_cash);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnf3_testdir);
            this.Controls.Add(this.btnf3_viewpatient);
            this.Controls.Add(this.btnf3_addpatient);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnf3_addpatient;
        private System.Windows.Forms.Button btnf3_viewpatient;
        private System.Windows.Forms.Button btnf3_testdir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtf3_cash;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtf3_due;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtf3_patient;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtf3_host;
        private System.Windows.Forms.Button btnf3_signout;
    }
}