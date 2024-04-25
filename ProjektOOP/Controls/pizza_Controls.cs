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
    public partial class pizza_Controls : UserControl
    {
        public pizza_Controls()
        {
            InitializeComponent();
        }
        private void sandwich_Button_Click(object sender, EventArgs e)
        {
            StaticDb.AddToCart("4 Stinet", 600);
        }

        private void hotPizza_Button_Click(object sender, EventArgs e)
        {
            StaticDb.AddToCart("Hot Pizza", 500);
        }

        private void mushroomsPizza_Button_Click(object sender, EventArgs e)
        {
            StaticDb.AddToCart("Mushrooms Pizza", 450);
        }

        private void margaritaPizza_Button_Click(object sender, EventArgs e)
        {
            StaticDb.AddToCart("Margarita Pizza", 300);
        }

        private void vegetarianPizza_Button_Click(object sender, EventArgs e)
        {
            StaticDb.AddToCart("Vegetarian Pizza", 400);
        }

        private void tonPizza_Button_Click(object sender, EventArgs e)
        {
            StaticDb.AddToCart("Ton Pizza", 500);
        }
    }
}
