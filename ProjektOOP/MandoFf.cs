using projektOOP.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace projektOOP
{
    public partial class MandoFf : Form
    {
        public MandoFf()
        {
            InitializeComponent();
            home_Controls1.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            userName_logged.Text = StaticDb.CurrentUser.UserName;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }



        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            home_Controls home_Control = new home_Controls();
            home_Controls1.BringToFront();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            pizza_Controls pizza_Control = new pizza_Controls();
            pizza_Controls1.BringToFront();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void sallata_Button_Click(object sender, EventArgs e)
        {
            salad_Controls sallataControl = new salad_Controls();
            sallata_Controll1.BringToFront();
        }

        private void hamburger_Button_Click(object sender, EventArgs e)
        {
            burgers_Controls burgerControl = new burgers_Controls();
            burger_Controll1.BringToFront();
        }

        private void pije_Button_Click(object sender, EventArgs e)
        {

        }

        private void sallata_Controll1_Load(object sender, EventArgs e)
        {

        }

        private void friesMenu_Button_Click(object sender, EventArgs e)
        {
            snacks_Controls snacks_Control = new snacks_Controls();
            snacks_Controls1.BringToFront();
        }

        private void drinks_Controls1_Load(object sender, EventArgs e)
        {

        }

        private void drinkMenu_Button_Click(object sender, EventArgs e)
        {
            drinks_Controls drink_Control = new drinks_Controls();
            drinks_Controls1.BringToFront();
        }

        private void home_Controls1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            login_form login_Form = new login_form();
            Hide();
            login_Form.ShowDialog();
            Close();
        }
    }
}
