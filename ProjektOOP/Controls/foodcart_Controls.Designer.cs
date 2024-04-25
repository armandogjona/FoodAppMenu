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
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.DarkOrange;
            listBox1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 23;
            listBox1.Items.AddRange(new object[] { "test qwrersr", "srserserser" });
            listBox1.Location = new Point(132, 70);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(466, 395);
            listBox1.TabIndex = 0;
            // 
            // foodcart_Controls
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listBox1);
            Name = "foodcart_Controls";
            Size = new Size(978, 628);
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
    }
}
