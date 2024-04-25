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
    public partial class drinks_Controls : UserControl
    {
        public drinks_Controls()
        {
            InitializeComponent();
        }

        private void waterDrinks_Button_Click(object sender, EventArgs e)
        {
            StaticDb.AddToCart("Water", 50);
        }

        private void cocacolaDrinks_Button_Click(object sender, EventArgs e)
        {
            StaticDb.AddToCart("Coca Cola", 150);
        }

        private void fantaDrinks_Button_Click(object sender, EventArgs e)
        {
            StaticDb.AddToCart("Fanta Exotic", 150);
        }

        private void bravoDrinks_Button_Click(object sender, EventArgs e)
        {
            StaticDb.AddToCart("Bravo", 150);
        }

        private void beerDrinks_Button_Click(object sender, EventArgs e)
        {
            StaticDb.AddToCart("Beer", 150);
        }

        private void b52Drinks_Button_Click(object sender, EventArgs e)
        {
            StaticDb.AddToCart("B52", 150);
        }
    }
}
