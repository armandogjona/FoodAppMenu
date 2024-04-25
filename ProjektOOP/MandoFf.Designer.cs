namespace projektOOP
{
    partial class MandoFf
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MandoFf));
            Second_form = new Panel();
            button1 = new Button();
            label2 = new Label();
            ig_logo = new PictureBox();
            fb_logo = new PictureBox();
            userName_logged = new Label();
            pictureBox3 = new PictureBox();
            mando_fastfood_Logo = new PictureBox();
            panel2 = new Panel();
            food_Cart_Button = new Button();
            drinkMenu_Button = new Button();
            friesMenu_Button = new Button();
            pizzaMenu_Button = new Button();
            saladsMenu_Button = new Button();
            burgersMenu_Button = new Button();
            home_Button = new Button();
            sallata_Controll1 = new salad_Controls();
            burger_Controll1 = new burgers_Controls();
            pizza_Controls1 = new pizza_Controls();
            snacks_Controls1 = new snacks_Controls();
            drinks_Controls1 = new drinks_Controls();
            home_Controls1 = new home_Controls();
            Second_form.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ig_logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fb_logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mando_fastfood_Logo).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // Second_form
            // 
            Second_form.BackColor = Color.FromArgb(227, 119, 18);
            Second_form.BorderStyle = BorderStyle.FixedSingle;
            Second_form.Controls.Add(button1);
            Second_form.Controls.Add(label2);
            Second_form.Controls.Add(ig_logo);
            Second_form.Controls.Add(fb_logo);
            Second_form.Controls.Add(userName_logged);
            Second_form.Controls.Add(pictureBox3);
            Second_form.Controls.Add(mando_fastfood_Logo);
            Second_form.Dock = DockStyle.Top;
            Second_form.Location = new Point(0, 0);
            Second_form.Name = "Second_form";
            Second_form.Size = new Size(1215, 67);
            Second_form.TabIndex = 0;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(1125, 13);
            button1.Name = "button1";
            button1.Size = new Size(41, 41);
            button1.TabIndex = 9;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(391, 24);
            label2.Name = "label2";
            label2.Size = new Size(138, 18);
            label2.TabIndex = 8;
            label2.Text = "@MandoFastFood";
            // 
            // ig_logo
            // 
            ig_logo.Image = (Image)resources.GetObject("ig_logo.Image");
            ig_logo.Location = new Point(329, 12);
            ig_logo.Name = "ig_logo";
            ig_logo.Size = new Size(56, 40);
            ig_logo.SizeMode = PictureBoxSizeMode.Zoom;
            ig_logo.TabIndex = 7;
            ig_logo.TabStop = false;
            // 
            // fb_logo
            // 
            fb_logo.Image = (Image)resources.GetObject("fb_logo.Image");
            fb_logo.Location = new Point(267, 12);
            fb_logo.Name = "fb_logo";
            fb_logo.Size = new Size(56, 40);
            fb_logo.SizeMode = PictureBoxSizeMode.Zoom;
            fb_logo.TabIndex = 6;
            fb_logo.TabStop = false;
            // 
            // userName_logged
            // 
            userName_logged.AutoSize = true;
            userName_logged.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userName_logged.ForeColor = SystemColors.ControlLightLight;
            userName_logged.Location = new Point(978, 24);
            userName_logged.Name = "userName_logged";
            userName_logged.Size = new Size(111, 18);
            userName_logged.TabIndex = 5;
            userName_logged.Text = "Unknown User";
            userName_logged.Click += label1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(916, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(56, 40);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // mando_fastfood_Logo
            // 
            mando_fastfood_Logo.Image = (Image)resources.GetObject("mando_fastfood_Logo.Image");
            mando_fastfood_Logo.Location = new Point(-21, 0);
            mando_fastfood_Logo.Name = "mando_fastfood_Logo";
            mando_fastfood_Logo.Size = new Size(175, 109);
            mando_fastfood_Logo.SizeMode = PictureBoxSizeMode.Zoom;
            mando_fastfood_Logo.TabIndex = 3;
            mando_fastfood_Logo.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.Controls.Add(food_Cart_Button);
            panel2.Controls.Add(drinkMenu_Button);
            panel2.Controls.Add(friesMenu_Button);
            panel2.Controls.Add(pizzaMenu_Button);
            panel2.Controls.Add(saladsMenu_Button);
            panel2.Controls.Add(burgersMenu_Button);
            panel2.Controls.Add(home_Button);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 67);
            panel2.Name = "panel2";
            panel2.Size = new Size(233, 628);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint_1;
            // 
            // food_Cart_Button
            // 
            food_Cart_Button.BackColor = Color.DarkOrange;
            food_Cart_Button.Cursor = Cursors.Hand;
            food_Cart_Button.FlatAppearance.BorderSize = 0;
            food_Cart_Button.FlatAppearance.MouseOverBackColor = Color.Red;
            food_Cart_Button.FlatStyle = FlatStyle.Flat;
            food_Cart_Button.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            food_Cart_Button.ForeColor = SystemColors.ControlLightLight;
            food_Cart_Button.Image = (Image)resources.GetObject("food_Cart_Button.Image");
            food_Cart_Button.Location = new Point(-86, 565);
            food_Cart_Button.Name = "food_Cart_Button";
            food_Cart_Button.Size = new Size(317, 63);
            food_Cart_Button.TabIndex = 7;
            food_Cart_Button.Text = "                               Food Cart";
            food_Cart_Button.UseVisualStyleBackColor = false;
            // 
            // drinkMenu_Button
            // 
            drinkMenu_Button.Cursor = Cursors.Hand;
            drinkMenu_Button.FlatAppearance.BorderSize = 0;
            drinkMenu_Button.FlatStyle = FlatStyle.Flat;
            drinkMenu_Button.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            drinkMenu_Button.ForeColor = SystemColors.GrayText;
            drinkMenu_Button.Image = (Image)resources.GetObject("drinkMenu_Button.Image");
            drinkMenu_Button.Location = new Point(-84, 336);
            drinkMenu_Button.Name = "drinkMenu_Button";
            drinkMenu_Button.Size = new Size(317, 63);
            drinkMenu_Button.TabIndex = 3;
            drinkMenu_Button.Text = "                      Drinks";
            drinkMenu_Button.UseVisualStyleBackColor = true;
            drinkMenu_Button.Click += drinkMenu_Button_Click;
            // 
            // friesMenu_Button
            // 
            friesMenu_Button.Cursor = Cursors.Hand;
            friesMenu_Button.FlatAppearance.BorderSize = 0;
            friesMenu_Button.FlatStyle = FlatStyle.Flat;
            friesMenu_Button.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            friesMenu_Button.ForeColor = SystemColors.GrayText;
            friesMenu_Button.Image = (Image)resources.GetObject("friesMenu_Button.Image");
            friesMenu_Button.Location = new Point(-86, 265);
            friesMenu_Button.Name = "friesMenu_Button";
            friesMenu_Button.Size = new Size(317, 63);
            friesMenu_Button.TabIndex = 6;
            friesMenu_Button.Text = "                        Snacks";
            friesMenu_Button.UseVisualStyleBackColor = true;
            friesMenu_Button.Click += friesMenu_Button_Click;
            // 
            // pizzaMenu_Button
            // 
            pizzaMenu_Button.Cursor = Cursors.Hand;
            pizzaMenu_Button.FlatAppearance.BorderSize = 0;
            pizzaMenu_Button.FlatStyle = FlatStyle.Flat;
            pizzaMenu_Button.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pizzaMenu_Button.ForeColor = SystemColors.GrayText;
            pizzaMenu_Button.Image = (Image)resources.GetObject("pizzaMenu_Button.Image");
            pizzaMenu_Button.Location = new Point(-86, 198);
            pizzaMenu_Button.Name = "pizzaMenu_Button";
            pizzaMenu_Button.Size = new Size(317, 63);
            pizzaMenu_Button.TabIndex = 5;
            pizzaMenu_Button.Text = "                      Pizza";
            pizzaMenu_Button.UseVisualStyleBackColor = true;
            pizzaMenu_Button.Click += button4_Click;
            // 
            // saladsMenu_Button
            // 
            saladsMenu_Button.BackColor = SystemColors.ControlLightLight;
            saladsMenu_Button.Cursor = Cursors.Hand;
            saladsMenu_Button.FlatAppearance.BorderSize = 0;
            saladsMenu_Button.FlatStyle = FlatStyle.Flat;
            saladsMenu_Button.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saladsMenu_Button.ForeColor = SystemColors.GrayText;
            saladsMenu_Button.Image = (Image)resources.GetObject("saladsMenu_Button.Image");
            saladsMenu_Button.Location = new Point(-86, 138);
            saladsMenu_Button.Name = "saladsMenu_Button";
            saladsMenu_Button.Size = new Size(317, 63);
            saladsMenu_Button.TabIndex = 4;
            saladsMenu_Button.Text = "                        Salads";
            saladsMenu_Button.UseVisualStyleBackColor = false;
            saladsMenu_Button.Click += sallata_Button_Click;
            // 
            // burgersMenu_Button
            // 
            burgersMenu_Button.Cursor = Cursors.Hand;
            burgersMenu_Button.FlatAppearance.BorderSize = 0;
            burgersMenu_Button.FlatAppearance.MouseOverBackColor = Color.Transparent;
            burgersMenu_Button.FlatStyle = FlatStyle.Flat;
            burgersMenu_Button.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            burgersMenu_Button.ForeColor = SystemColors.GrayText;
            burgersMenu_Button.Image = (Image)resources.GetObject("burgersMenu_Button.Image");
            burgersMenu_Button.Location = new Point(-86, 69);
            burgersMenu_Button.Name = "burgersMenu_Button";
            burgersMenu_Button.Size = new Size(317, 63);
            burgersMenu_Button.TabIndex = 3;
            burgersMenu_Button.Text = "                          Burgers";
            burgersMenu_Button.UseVisualStyleBackColor = true;
            burgersMenu_Button.Click += hamburger_Button_Click;
            // 
            // home_Button
            // 
            home_Button.Cursor = Cursors.Hand;
            home_Button.FlatAppearance.BorderSize = 0;
            home_Button.FlatStyle = FlatStyle.Flat;
            home_Button.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            home_Button.ForeColor = SystemColors.GrayText;
            home_Button.Image = Properties.Resources.icons8_home_24;
            home_Button.Location = new Point(-86, 0);
            home_Button.Name = "home_Button";
            home_Button.Size = new Size(317, 63);
            home_Button.TabIndex = 2;
            home_Button.Text = "                      Home";
            home_Button.UseVisualStyleBackColor = true;
            home_Button.Click += button1_Click;
            // 
            // sallata_Controll1
            // 
            sallata_Controll1.BackColor = SystemColors.Control;
            sallata_Controll1.Location = new Point(237, 67);
            sallata_Controll1.Name = "sallata_Controll1";
            sallata_Controll1.Size = new Size(978, 628);
            sallata_Controll1.TabIndex = 2;
            sallata_Controll1.Load += sallata_Controll1_Load;
            // 
            // burger_Controll1
            // 
            burger_Controll1.Location = new Point(237, 67);
            burger_Controll1.Name = "burger_Controll1";
            burger_Controll1.Size = new Size(978, 628);
            burger_Controll1.TabIndex = 3;
            // 
            // pizza_Controls1
            // 
            pizza_Controls1.Location = new Point(237, 67);
            pizza_Controls1.Name = "pizza_Controls1";
            pizza_Controls1.Size = new Size(978, 628);
            pizza_Controls1.TabIndex = 4;
            // 
            // snacks_Controls1
            // 
            snacks_Controls1.Location = new Point(237, 67);
            snacks_Controls1.Name = "snacks_Controls1";
            snacks_Controls1.Size = new Size(978, 628);
            snacks_Controls1.TabIndex = 5;
            // 
            // drinks_Controls1
            // 
            drinks_Controls1.Location = new Point(237, 67);
            drinks_Controls1.Name = "drinks_Controls1";
            drinks_Controls1.Size = new Size(978, 628);
            drinks_Controls1.TabIndex = 6;
            // 
            // home_Controls1
            // 
            home_Controls1.Location = new Point(239, 67);
            home_Controls1.Name = "home_Controls1";
            home_Controls1.Size = new Size(978, 628);
            home_Controls1.TabIndex = 7;
            home_Controls1.Load += home_Controls1_Load;
            // 
            // MandoFf
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1215, 695);
            Controls.Add(home_Controls1);
            Controls.Add(drinks_Controls1);
            Controls.Add(snacks_Controls1);
            Controls.Add(pizza_Controls1);
            Controls.Add(sallata_Controll1);
            Controls.Add(panel2);
            Controls.Add(Second_form);
            Controls.Add(burger_Controll1);
            Name = "MandoFf";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mando Fast Food";
            Load += Form1_Load;
            Second_form.ResumeLayout(false);
            Second_form.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ig_logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)fb_logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)mando_fastfood_Logo).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel Second_form;
        private Panel panel2;
        private PictureBox mando_fastfood_Logo;
        private PictureBox pictureBox3;
        private Label userName_logged;
        private Button home_Button;
        private Button saladsMenu_Button;
        private Button burgersMenu_Button;
        private Button drinkMenu_Button;
        private Button pizzaMenu_Button;
        private Button food_Cart_Button;
        private PictureBox fb_logo;
        private Label label2;
        private PictureBox ig_logo;
        private Button button15;
        private salad_Controls sallata_Control1;
        private salad_Controls sallata_Control2;
        private salad_Controls sallata_Controll1;
        private burgers_Controls burger_Controll1;
        private Button friesMenu_Button;
        private pizza_Controls pizza_Controls1;
        private snacks_Controls snacks_Controls1;
        private drinks_Controls drinks_Controls1;
        private home_Controls home_Controls1;
        private Button button1;
    }
}
