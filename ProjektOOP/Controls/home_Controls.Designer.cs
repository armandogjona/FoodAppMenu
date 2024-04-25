namespace projektOOP
{
    partial class home_Controls
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home_Controls));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(142, 247);
            label1.Name = "label1";
            label1.Size = new Size(276, 44);
            label1.TabIndex = 0;
            label1.Text = "Cheeseburger";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Elephant", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkOrange;
            label2.Location = new Point(59, 75);
            label2.Name = "label2";
            label2.Size = new Size(479, 155);
            label2.TabIndex = 1;
            label2.Text = "150lek";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkOrange;
            label3.Location = new Point(72, 60);
            label3.Name = "label3";
            label3.Size = new Size(64, 27);
            label3.TabIndex = 2;
            label3.Text = "Only";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(84, 311);
            label4.Name = "label4";
            label4.Size = new Size(413, 29);
            label4.TabIndex = 3;
            label4.Text = "With melted cheese and a big patty";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(59, 386);
            label5.Name = "label5";
            label5.Size = new Size(631, 189);
            label5.TabIndex = 4;
            label5.Text = resources.GetString("label5.Text");
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(512, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(463, 498);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkOrange;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(696, 542);
            button1.Name = "button1";
            button1.Size = new Size(254, 53);
            button1.TabIndex = 6;
            button1.Text = "Order Now!";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // home_Controls
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "home_Controls";
            Size = new Size(978, 628);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox1;
        private Button button1;
    }
}
