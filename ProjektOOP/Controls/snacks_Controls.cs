using projektOOP.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projektOOP
{
    public partial class snacks_Controls : UserControl
    {
        public snacks_Controls()
        {
            InitializeComponent();
        }

        private void friesSnacks_Button_Click(object sender, EventArgs e)
        {
            StaticDb.AddToCart("French Fries", 70);
        }

        private void applepieSnacks_Button_Click(object sender, EventArgs e)
        {
            StaticDb.AddToCart("Baked Apple Pie", 50);
        }

        private void cookieSnacks_Button_Click(object sender, EventArgs e)
        {
            StaticDb.AddToCart("Chocolate Cookie", 50);
        }

        private void hashbrownsSnacks_Button_Click(object sender, EventArgs e)
        {
            StaticDb.AddToCart("Hashbrowns", 90);
        }

        private void sausagebiscuitSnacks_Button_Click(object sender, EventArgs e)
        {
            StaticDb.AddToCart("Sausage Biscuit", 100);
        }

        private void chickenSnacks_Button_Click(object sender, EventArgs e)
        {
            StaticDb.AddToCart("Fried Chicken", 175);
        }
    }
}
