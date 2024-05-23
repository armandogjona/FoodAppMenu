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
            //label.text = total
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count < 0)
                return;

            StaticDb.CurrentUser.Cart.RemoveAt(listBox1.SelectedIndex);

            StaticDb.Save();
            StaticDb.UpdateCart();
            LoadData();
        }
    }
}
