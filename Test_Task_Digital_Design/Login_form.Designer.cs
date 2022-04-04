namespace Test_Task_Digital_Design
{
    partial class Login_form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_form));
            this.Username_txtbox = new System.Windows.Forms.TextBox();
            this.Password_txtbox = new System.Windows.Forms.TextBox();
            this.Log_in_btn = new System.Windows.Forms.Button();
            this.Username_lbl = new System.Windows.Forms.Label();
            this.Password_lbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Sign_up_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Username_txtbox
            // 
            this.Username_txtbox.Location = new System.Drawing.Point(12, 80);
            this.Username_txtbox.Name = "Username_txtbox";
            this.Username_txtbox.Size = new System.Drawing.Size(167, 20);
            this.Username_txtbox.TabIndex = 0;
            // 
            // Password_txtbox
            // 
            this.Password_txtbox.Location = new System.Drawing.Point(12, 119);
            this.Password_txtbox.Name = "Password_txtbox";
            this.Password_txtbox.Size = new System.Drawing.Size(167, 20);
            this.Password_txtbox.TabIndex = 1;
            // 
            // Log_in_btn
            // 
            this.Log_in_btn.Location = new System.Drawing.Point(12, 145);
            this.Log_in_btn.Name = "Log_in_btn";
            this.Log_in_btn.Size = new System.Drawing.Size(75, 23);
            this.Log_in_btn.TabIndex = 2;
            this.Log_in_btn.Text = "Log in";
            this.Log_in_btn.UseVisualStyleBackColor = true;
            this.Log_in_btn.Click += new System.EventHandler(this.Log_in_btn_Click);
            // 
            // Username_lbl
            // 
            this.Username_lbl.AutoSize = true;
            this.Username_lbl.Location = new System.Drawing.Point(12, 64);
            this.Username_lbl.Name = "Username_lbl";
            this.Username_lbl.Size = new System.Drawing.Size(55, 13);
            this.Username_lbl.TabIndex = 3;
            this.Username_lbl.Text = "Username";
            // 
            // Password_lbl
            // 
            this.Password_lbl.AutoSize = true;
            this.Password_lbl.Location = new System.Drawing.Point(12, 103);
            this.Password_lbl.Name = "Password_lbl";
            this.Password_lbl.Size = new System.Drawing.Size(53, 13);
            this.Password_lbl.TabIndex = 4;
            this.Password_lbl.Text = "Password";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 61);
            this.panel1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "Authorization";
            // 
            // Sign_up_btn
            // 
            this.Sign_up_btn.Location = new System.Drawing.Point(104, 145);
            this.Sign_up_btn.Name = "Sign_up_btn";
            this.Sign_up_btn.Size = new System.Drawing.Size(75, 23);
            this.Sign_up_btn.TabIndex = 6;
            this.Sign_up_btn.Text = "Sign up";
            this.Sign_up_btn.UseVisualStyleBackColor = true;
            this.Sign_up_btn.Click += new System.EventHandler(this.Sign_up_btn_Click);
            // 
            // Login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(384, 186);
            this.Controls.Add(this.Sign_up_btn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Password_lbl);
            this.Controls.Add(this.Username_lbl);
            this.Controls.Add(this.Log_in_btn);
            this.Controls.Add(this.Password_txtbox);
            this.Controls.Add(this.Username_txtbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Test_Task_Digital_Design";
            this.Load += new System.EventHandler(this.Login_form_load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Username_txtbox;
        private System.Windows.Forms.TextBox Password_txtbox;
        private System.Windows.Forms.Button Log_in_btn;
        private System.Windows.Forms.Label Username_lbl;
        private System.Windows.Forms.Label Password_lbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Sign_up_btn;
    }
}

