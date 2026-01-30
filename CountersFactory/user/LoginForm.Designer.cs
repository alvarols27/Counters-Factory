namespace CountersFactory.user
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            textBoxUser = new TextBox();
            textBoxPassword = new TextBox();
            labelPassword = new Label();
            buttonLogin = new Button();
            labelUser = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBoxUser
            // 
            textBoxUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            textBoxUser.Location = new Point(569, 129);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.Size = new Size(175, 35);
            textBoxUser.TabIndex = 7;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            textBoxPassword.Location = new Point(569, 207);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(175, 35);
            textBoxPassword.TabIndex = 8;
            // 
            // labelPassword
            // 
            labelPassword.BackColor = Color.Transparent;
            labelPassword.BorderStyle = BorderStyle.Fixed3D;
            labelPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelPassword.Location = new Point(396, 198);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(151, 48);
            labelPassword.TabIndex = 6;
            labelPassword.Text = "Password:";
            labelPassword.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.Transparent;
            buttonLogin.Location = new Point(489, 306);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(129, 60);
            buttonLogin.TabIndex = 9;
            buttonLogin.Text = "LOGIN";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // labelUser
            // 
            labelUser.BackColor = Color.Transparent;
            labelUser.BorderStyle = BorderStyle.Fixed3D;
            labelUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelUser.Location = new Point(396, 107);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(146, 57);
            labelUser.TabIndex = 5;
            labelUser.Text = "User:";
            labelUser.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(294, 85);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(78, 79);
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(294, 181);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(78, 74);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(791, 485);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(labelUser);
            Controls.Add(buttonLogin);
            Controls.Add(labelPassword);
            Controls.Add(textBoxUser);
            Controls.Add(textBoxPassword);
            Name = "LoginForm";
            Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxUser;
        private TextBox textBoxPassword;
        private Label labelPassword;
        private Button buttonLogin;
        private Label labelUser;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}