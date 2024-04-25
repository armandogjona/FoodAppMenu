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
    public partial class burgers_Controls : UserControl
    {
        public burgers_Controls()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cheeseBurger_Button_Click(object sender, EventArgs e)
        {
            StaticDb.AddToCart("Cheese Burger", 150);
        }

        private void chickenBurger_Button_Click(object sender, EventArgs e)
        {
            StaticDb.AddToCart("Chicken Burger", 175);

        }

        private void veggieBurger_Button_Click(object sender, EventArgs e)
        {
            StaticDb.AddToCart("Veggie Burger", 230);

        }

        private void souvlaki_Button_Click(object sender, EventArgs e)
        {
            StaticDb.AddToCart("Souvlaki", 250);
        }

        private void sandwich_Button_Click(object sender, EventArgs e)
        {
            StaticDb.AddToCart("Sandwich", 175);
        }

        private void toast_Button_Click(object sender, EventArgs e)
        {
            StaticDb.AddToCart("Toast", 175);
        }
    }
}
