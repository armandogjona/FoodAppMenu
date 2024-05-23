namespace projektOOP
{
    partial class foodcart_Controls
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
            listBox1 = new ListBox();
            panel1 = new Panel();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.DarkOrange;
            listBox1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 23;
            listBox1.Items.AddRange(new object[] { "test qwrersr", "srserserser" });
            listBox1.Location = new Point(0, 0);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(981, 556);
            listBox1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(button1);
            panel1.Location = new Point(3, 555);
            panel1.Name = "panel1";
            panel1.Size = new Size(981, 72);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkOrange;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(351, 17);
            button1.Name = "button1";
            button1.Size = new Size(274, 41);
            button1.TabIndex = 0;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // foodcart_Controls
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(listBox1);
            Name = "foodcart_Controls";
            Size = new Size(978, 628);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Panel panel1;
        private Button button1;
    }
}
