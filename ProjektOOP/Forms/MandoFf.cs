using projektOOP.Data;

namespace projektOOP;

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
    private void button1_Click(object sender, EventArgs e)
    {
        home_Controls1.BringToFront();
    }
    private void button4_Click(object sender, EventArgs e)
    {
        pizza_Controls1.BringToFront();
    }
    private void sallata_Button_Click(object sender, EventArgs e)
    {
        sallata_Controll1.BringToFront();
    }

    private void hamburger_Button_Click(object sender, EventArgs e)
    {
        burger_Controll1.BringToFront();
    }
    private void friesMenu_Button_Click(object sender, EventArgs e)
    {
        snacks_Controls1.BringToFront();
    }
    private void drinkMenu_Button_Click(object sender, EventArgs e)
    {
        drinks_Controls1.BringToFront();
    }
    private void button1_Click_1(object sender, EventArgs e)
    {
        login_form login_Form = new login_form();
        Hide();
        login_Form.ShowDialog();
        Close();
    }

    private void food_Cart_Button_Click(object sender, EventArgs e)
    {
        foodCart1.BringToFront();
        foodCart1.LoadData();
    }
}
