using projektOOP.Data;

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
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                StaticDb.Save();
                StaticDb.UpdateCart();
            }
        }
    }
}
