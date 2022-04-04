namespace Test_Task_Digital_Design
{
    partial class Signup_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup_form));
            this.Sign_up_btn = new System.Windows.Forms.Button();
            this.Password_lbl = new System.Windows.Forms.Label();
            this.Username_lbl = new System.Windows.Forms.Label();
            this.Password_txtbox = new System.Windows.Forms.TextBox();
            this.Username_txtbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Sign_up_btn
            // 
            this.Sign_up_btn.Location = new System.Drawing.Point(12, 145);
            this.Sign_up_btn.Name = "Sign_up_btn";
            this.Sign_up_btn.Size = new System.Drawing.Size(75, 23);
            this.Sign_up_btn.TabIndex = 13;
            this.Sign_up_btn.Text = "Sign up";
            this.Sign_up_btn.UseVisualStyleBackColor = true;
            this.Sign_up_btn.Click += new System.EventHandler(this.Sign_up_btn_Click);
            // 
            // Password_lbl
            // 
            this.Password_lbl.AutoSize = true;
            this.Password_lbl.Location = new System.Drawing.Point(12, 103);
            this.Password_lbl.Name = "Password_lbl";
            this.Password_lbl.Size = new System.Drawing.Size(53, 13);
            this.Password_lbl.TabIndex = 11;
            this.Password_lbl.Text = "Password";
            // 
            // Username_lbl
            // 
            this.Username_lbl.AutoSize = true;
            this.Username_lbl.Location = new System.Drawing.Point(12, 64);
            this.Username_lbl.Name = "Username_lbl";
            this.Username_lbl.Size = new System.Drawing.Size(55, 13);
            this.Username_lbl.TabIndex = 10;
            this.Username_lbl.Text = "Username";
            // 
            // Password_txtbox
            // 
            this.Password_txtbox.Location = new System.Drawing.Point(12, 119);
            this.Password_txtbox.Name = "Password_txtbox";
            this.Password_txtbox.Size = new System.Drawing.Size(167, 20);
            this.Password_txtbox.TabIndex = 8;
            // 
            // Username_txtbox
            // 
            this.Username_txtbox.Location = new System.Drawing.Point(12, 80);
            this.Username_txtbox.Name = "Username_txtbox";
            this.Username_txtbox.Size = new System.Drawing.Size(167, 20);
            this.Username_txtbox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "Registration";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 61);
            this.panel1.TabIndex = 12;
            // 
            // Signup_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 186);
            this.Controls.Add(this.Sign_up_btn);
            this.Controls.Add(this.Password_lbl);
            this.Controls.Add(this.Username_lbl);
            this.Controls.Add(this.Password_txtbox);
            this.Controls.Add(this.Username_txtbox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Signup_form";
            this.Text = "Test_Task_Digital_Design";
            this.Load += new System.EventHandler(this.Signup_form_load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Sign_up_btn;
        private System.Windows.Forms.Label Password_lbl;
        private System.Windows.Forms.Label Username_lbl;
        private System.Windows.Forms.TextBox Password_txtbox;
        private System.Windows.Forms.TextBox Username_txtbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
    }
}