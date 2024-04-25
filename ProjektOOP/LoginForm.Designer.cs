namespace projektOOP
{
    partial class login_form
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
            appLogo = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            username_textBox = new TextBox();
            password_textBox = new TextBox();
            login_Button = new Button();
            signup_Button = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)appLogo).BeginInit();
            SuspendLayout();
            // 
            // appLogo
            // 
            appLogo.Image = Properties.Resources.Screenshot_2024_04_16_221250_fotor_bg_remover_20240416221338;
            appLogo.Location = new Point(96, 36);
            appLogo.Name = "appLogo";
            appLogo.Size = new Size(266, 217);
            appLogo.SizeMode = PictureBoxSizeMode.Zoom;
            appLogo.TabIndex = 0;
            appLogo.TabStop = false;
            appLogo.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 303);
            label1.Name = "label1";
            label1.Size = new Size(100, 22);
            label1.TabIndex = 2;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 366);
            label2.Name = "label2";
            label2.Size = new Size(92, 22);
            label2.TabIndex = 3;
            label2.Text = "Password";
            label2.Click += label2_Click;
            // 
            // username_textBox
            // 
            username_textBox.BackColor = Color.AntiqueWhite;
            username_textBox.BorderStyle = BorderStyle.FixedSingle;
            username_textBox.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            username_textBox.Location = new Point(126, 303);
            username_textBox.Name = "username_textBox";
            username_textBox.Size = new Size(211, 26);
            username_textBox.TabIndex = 4;
            // 
            // password_textBox
            // 
            password_textBox.BackColor = Color.AntiqueWhite;
            password_textBox.BorderStyle = BorderStyle.FixedSingle;
            password_textBox.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            password_textBox.Location = new Point(126, 366);
            password_textBox.Name = "password_textBox";
            password_textBox.PasswordChar = '*';
            password_textBox.Size = new Size(211, 26);
            password_textBox.TabIndex = 5;
            // 
            // login_Button
            // 
            login_Button.BackColor = Color.AntiqueWhite;
            login_Button.CausesValidation = false;
            login_Button.FlatAppearance.BorderSize = 0;
            login_Button.FlatStyle = FlatStyle.Popup;
            login_Button.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login_Button.Location = new Point(243, 423);
            login_Button.Name = "login_Button";
            login_Button.Size = new Size(94, 32);
            login_Button.TabIndex = 6;
            login_Button.Text = "Login";
            login_Button.UseVisualStyleBackColor = false;
            login_Button.Click += login_Button_Click;
            // 
            // signup_Button
            // 
            signup_Button.BackColor = Color.AntiqueWhite;
            signup_Button.CausesValidation = false;
            signup_Button.FlatAppearance.BorderSize = 0;
            signup_Button.FlatStyle = FlatStyle.Popup;
            signup_Button.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signup_Button.Location = new Point(126, 423);
            signup_Button.Name = "signup_Button";
            signup_Button.Size = new Size(94, 32);
            signup_Button.TabIndex = 7;
            signup_Button.Text = "Signup";
            signup_Button.UseVisualStyleBackColor = false;
            signup_Button.Click += signup_Button_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.CausesValidation = false;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Image = Properties.Resources.icons8_close_32__1_;
            button1.Location = new Point(410, 12);
            button1.Name = "button1";
            button1.Size = new Size(50, 37);
            button1.TabIndex = 8;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            button1.MouseLeave += button1_MouseLeave;
            button1.MouseHover += button1_MouseHover;
            // 
            // login_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOrange;
            ClientSize = new Size(472, 514);
            Controls.Add(button1);
            Controls.Add(signup_Button);
            Controls.Add(login_Button);
            Controls.Add(password_textBox);
            Controls.Add(username_textBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(appLogo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "login_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            Load += login_form_Load;
            ((System.ComponentModel.ISupportInitialize)appLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox appLogo;
        private Label label1;
        private Label label2;
        private TextBox username_textBox;
        private TextBox password_textBox;
        private Button login_Button;
        private Button signup_Button;
        private Button button1;
    }
}