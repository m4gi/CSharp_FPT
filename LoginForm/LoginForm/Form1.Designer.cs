
namespace LoginForm
{
    partial class FormMain
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
            System.Windows.Forms.Button btn_Login;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.lb_head = new System.Windows.Forms.Label();
            this.lb_Username = new System.Windows.Forms.Label();
            this.lb_Password = new System.Windows.Forms.Label();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.pic_Logo = new System.Windows.Forms.PictureBox();
            btn_Login = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Login
            // 
            btn_Login.Anchor = System.Windows.Forms.AnchorStyles.None;
            btn_Login.Location = new System.Drawing.Point(209, 134);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new System.Drawing.Size(75, 23);
            btn_Login.TabIndex = 2;
            btn_Login.Text = "Login";
            btn_Login.UseVisualStyleBackColor = true;
            btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Cancel.Location = new System.Drawing.Point(320, 134);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 3;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // lb_head
            // 
            this.lb_head.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_head.AutoSize = true;
            this.lb_head.Location = new System.Drawing.Point(194, 15);
            this.lb_head.Name = "lb_head";
            this.lb_head.Size = new System.Drawing.Size(210, 13);
            this.lb_head.TabIndex = 2;
            this.lb_head.Text = "Please enter your username and password:";
            this.lb_head.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lb_Username
            // 
            this.lb_Username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_Username.AutoSize = true;
            this.lb_Username.Location = new System.Drawing.Point(191, 53);
            this.lb_Username.Name = "lb_Username";
            this.lb_Username.Size = new System.Drawing.Size(58, 13);
            this.lb_Username.TabIndex = 3;
            this.lb_Username.Text = "Username:";
            // 
            // lb_Password
            // 
            this.lb_Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_Password.AutoSize = true;
            this.lb_Password.Location = new System.Drawing.Point(191, 91);
            this.lb_Password.Name = "lb_Password";
            this.lb_Password.Size = new System.Drawing.Size(53, 13);
            this.lb_Password.TabIndex = 4;
            this.lb_Password.Text = "Password";
            // 
            // txt_Username
            // 
            this.txt_Username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Username.Location = new System.Drawing.Point(255, 53);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(140, 20);
            this.txt_Username.TabIndex = 0;
            // 
            // txt_Password
            // 
            this.txt_Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Password.Location = new System.Drawing.Point(255, 88);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '•';
            this.txt_Password.Size = new System.Drawing.Size(140, 20);
            this.txt_Password.TabIndex = 1;
            // 
            // pic_Logo
            // 
            this.pic_Logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pic_Logo.Image = ((System.Drawing.Image)(resources.GetObject("pic_Logo.Image")));
            this.pic_Logo.Location = new System.Drawing.Point(38, 31);
            this.pic_Logo.Name = "pic_Logo";
            this.pic_Logo.Size = new System.Drawing.Size(96, 115);
            this.pic_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Logo.TabIndex = 7;
            this.pic_Logo.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 180);
            this.Controls.Add(this.pic_Logo);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.lb_Password);
            this.Controls.Add(this.lb_Username);
            this.Controls.Add(this.lb_head);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(btn_Login);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label lb_head;
        private System.Windows.Forms.Label lb_Username;
        private System.Windows.Forms.Label lb_Password;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.PictureBox pic_Logo;
    }
}

