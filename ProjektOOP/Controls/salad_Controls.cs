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
    public partial class salad_Controls : UserControl
    {
        public salad_Controls()
        {
            InitializeComponent();
        }
        private void sallateCheff_Button_Click(object sender, EventArgs e)
        {
            StaticDb.AddToCart("Cheff Salad", 350);
        }

        private void sallateCeasar_Button_Click(object sender, EventArgs e)
        {
            StaticDb.AddToCart("Ceasar Salad", 270);
        }

        private void sallatPatate_Button_Click(object sender, EventArgs e)
        {
            StaticDb.AddToCart("Potato Salad", 250);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            StaticDb.AddToCart("Fruit Salad", 250);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            StaticDb.AddToCart("Greek Salad", 150);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            StaticDb.AddToCart("Tuna Salad", 300);
        }
    }
}
