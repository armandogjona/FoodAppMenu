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
    public partial class home_Controls : UserControl
    {
        public home_Controls()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            StaticDb.AddToCart("Cheese Burger", 150);
        }
    }
}
