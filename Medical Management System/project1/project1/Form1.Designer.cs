
namespace project1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label3 = new System.Windows.Forms.Label();
            this.btnf1notreg = new System.Windows.Forms.Button();
            this.btnf1login = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtf1password = new System.Windows.Forms.TextBox();
            this.txtf1username = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(169, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 38);
            this.label3.TabIndex = 13;
            this.label3.Text = "LOGIN";
            // 
            // btnf1notreg
            // 
            this.btnf1notreg.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnf1notreg.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnf1notreg.ForeColor = System.Drawing.Color.White;
            this.btnf1notreg.Location = new System.Drawing.Point(154, 253);
            this.btnf1notreg.Name = "btnf1notreg";
            this.btnf1notreg.Size = new System.Drawing.Size(147, 29);
            this.btnf1notreg.TabIndex = 12;
            this.btnf1notreg.Text = "Not Registered";
            this.btnf1notreg.UseVisualStyleBackColor = false;
            this.btnf1notreg.Click += new System.EventHandler(this.btnf1notreg_Click);
            // 
            // btnf1login
            // 
            this.btnf1login.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnf1login.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnf1login.ForeColor = System.Drawing.Color.White;
            this.btnf1login.Location = new System.Drawing.Point(174, 196);
            this.btnf1login.Name = "btnf1login";
            this.btnf1login.Size = new System.Drawing.Size(101, 33);
            this.btnf1login.TabIndex = 11;
            this.btnf1login.Text = "LOGIN";
            this.btnf1login.UseVisualStyleBackColor = false;
            this.btnf1login.Click += new System.EventHandler(this.btnf1login_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(58, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(54, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Username : ";
            // 
            // txtf1password
            // 
            this.txtf1password.Location = new System.Drawing.Point(169, 145);
            this.txtf1password.Name = "txtf1password";
            this.txtf1password.Size = new System.Drawing.Size(209, 20);
            this.txtf1password.TabIndex = 15;
            this.txtf1password.UseSystemPasswordChar = true;
            // 
            // txtf1username
            // 
            this.txtf1username.Location = new System.Drawing.Point(169, 103);
            this.txtf1username.Name = "txtf1username";
            this.txtf1username.Size = new System.Drawing.Size(209, 20);
            this.txtf1username.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(433, 310);
            this.Controls.Add(this.txtf1password);
            this.Controls.Add(this.txtf1username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnf1notreg);
            this.Controls.Add(this.btnf1login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnf1notreg;
        private System.Windows.Forms.Button btnf1login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtf1password;
        private System.Windows.Forms.TextBox txtf1username;
    }
}

