namespace WindowsFormsApplication1
{
    partial class sign
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.user_name = new System.Windows.Forms.TextBox();
            this.user_password = new System.Windows.Forms.TextBox();
            this.user_password2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.user_nick = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名(登录用)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "密　码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "确认密码";
            // 
            // user_name
            // 
            this.user_name.Location = new System.Drawing.Point(149, 34);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(122, 21);
            this.user_name.TabIndex = 3;
            // 
            // user_password
            // 
            this.user_password.Location = new System.Drawing.Point(149, 77);
            this.user_password.Name = "user_password";
            this.user_password.PasswordChar = '*';
            this.user_password.Size = new System.Drawing.Size(122, 21);
            this.user_password.TabIndex = 4;
            // 
            // user_password2
            // 
            this.user_password2.Location = new System.Drawing.Point(149, 120);
            this.user_password2.Name = "user_password2";
            this.user_password2.PasswordChar = '*';
            this.user_password2.Size = new System.Drawing.Size(122, 21);
            this.user_password2.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(192, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "注册";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "昵　称";
            // 
            // user_nick
            // 
            this.user_nick.Location = new System.Drawing.Point(149, 163);
            this.user_nick.Name = "user_nick";
            this.user_nick.Size = new System.Drawing.Size(122, 21);
            this.user_nick.TabIndex = 8;
            // 
            // sign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 265);
            this.Controls.Add(this.user_nick);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.user_password2);
            this.Controls.Add(this.user_password);
            this.Controls.Add(this.user_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "sign";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "注册";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox user_name;
        private System.Windows.Forms.TextBox user_password;
        private System.Windows.Forms.TextBox user_password2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox user_nick;
    }
}