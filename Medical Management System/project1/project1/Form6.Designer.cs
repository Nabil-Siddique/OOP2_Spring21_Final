
namespace project1
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.label2 = new System.Windows.Forms.Label();
            this.txtf6_totpat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gridf6_patient = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnf6_check = new System.Windows.Forms.Button();
            this.btnf6_remove = new System.Windows.Forms.Button();
            this.txtf6_patientid = new System.Windows.Forms.TextBox();
            this.txtf6_host = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnf8_menu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridf6_patient)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(63, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 19);
            this.label2.TabIndex = 36;
            this.label2.Text = "Total Patient : ";
            // 
            // txtf6_totpat
            // 
            this.txtf6_totpat.Location = new System.Drawing.Point(177, 155);
            this.txtf6_totpat.Name = "txtf6_totpat";
            this.txtf6_totpat.ReadOnly = true;
            this.txtf6_totpat.Size = new System.Drawing.Size(72, 20);
            this.txtf6_totpat.TabIndex = 35;
            this.txtf6_totpat.TextChanged += new System.EventHandler(this.txtf6_totpat_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 23);
            this.label1.TabIndex = 34;
            this.label1.Text = "All Patient Detail";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(563, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // gridf6_patient
            // 
            this.gridf6_patient.BackgroundColor = System.Drawing.Color.Azure;
            this.gridf6_patient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridf6_patient.Location = new System.Drawing.Point(17, 192);
            this.gridf6_patient.Name = "gridf6_patient";
            this.gridf6_patient.Size = new System.Drawing.Size(558, 228);
            this.gridf6_patient.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(31, 449);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 19);
            this.label3.TabIndex = 39;
            this.label3.Text = "PatientID: ";
            // 
            // btnf6_check
            // 
            this.btnf6_check.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnf6_check.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnf6_check.ForeColor = System.Drawing.Color.White;
            this.btnf6_check.Location = new System.Drawing.Point(35, 484);
            this.btnf6_check.Name = "btnf6_check";
            this.btnf6_check.Size = new System.Drawing.Size(108, 46);
            this.btnf6_check.TabIndex = 55;
            this.btnf6_check.Text = "Check Detail";
            this.btnf6_check.UseVisualStyleBackColor = false;
            this.btnf6_check.Click += new System.EventHandler(this.btnf6_check_Click);
            // 
            // btnf6_remove
            // 
            this.btnf6_remove.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnf6_remove.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnf6_remove.ForeColor = System.Drawing.Color.White;
            this.btnf6_remove.Location = new System.Drawing.Point(160, 484);
            this.btnf6_remove.Name = "btnf6_remove";
            this.btnf6_remove.Size = new System.Drawing.Size(108, 46);
            this.btnf6_remove.TabIndex = 56;
            this.btnf6_remove.Text = "Remove Patient";
            this.btnf6_remove.UseVisualStyleBackColor = false;
            this.btnf6_remove.Click += new System.EventHandler(this.btnf6_remove_Click);
            // 
            // txtf6_patientid
            // 
            this.txtf6_patientid.Location = new System.Drawing.Point(117, 448);
            this.txtf6_patientid.Name = "txtf6_patientid";
            this.txtf6_patientid.Size = new System.Drawing.Size(72, 20);
            this.txtf6_patientid.TabIndex = 38;
            // 
            // txtf6_host
            // 
            this.txtf6_host.Location = new System.Drawing.Point(499, 24);
            this.txtf6_host.Multiline = true;
            this.txtf6_host.Name = "txtf6_host";
            this.txtf6_host.ReadOnly = true;
            this.txtf6_host.Size = new System.Drawing.Size(66, 18);
            this.txtf6_host.TabIndex = 60;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(449, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 17);
            this.label13.TabIndex = 59;
            this.label13.Text = "Host :";
            // 
            // btnf8_menu
            // 
            this.btnf8_menu.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnf8_menu.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnf8_menu.ForeColor = System.Drawing.Color.White;
            this.btnf8_menu.Location = new System.Drawing.Point(459, 492);
            this.btnf8_menu.Name = "btnf8_menu";
            this.btnf8_menu.Size = new System.Drawing.Size(106, 30);
            this.btnf8_menu.TabIndex = 89;
            this.btnf8_menu.Text = "Back To Menu";
            this.btnf8_menu.UseVisualStyleBackColor = false;
            this.btnf8_menu.Click += new System.EventHandler(this.btnf8_menu_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(587, 542);
            this.Controls.Add(this.btnf8_menu);
            this.Controls.Add(this.txtf6_host);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnf6_remove);
            this.Controls.Add(this.btnf6_check);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtf6_patientid);
            this.Controls.Add(this.gridf6_patient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtf6_totpat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridf6_patient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtf6_totpat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView gridf6_patient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnf6_check;
        private System.Windows.Forms.Button btnf6_remove;
        private System.Windows.Forms.TextBox txtf6_patientid;
        private System.Windows.Forms.TextBox txtf6_host;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnf8_menu;
    }
}