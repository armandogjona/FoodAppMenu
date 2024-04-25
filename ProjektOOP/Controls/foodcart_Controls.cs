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
    public partial class foodcart_Controls : UserControl
    {
        public foodcart_Controls()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            listBox1.Items.Clear();
            var total = 0;
            foreach (var order in StaticDb.CurrentUser.Cart)
            {
                listBox1.Items.Add($"{order.Description} - {order.Price}LEK");
                total += order.Price;
            }
            //label.text = total
        }
    }
}
