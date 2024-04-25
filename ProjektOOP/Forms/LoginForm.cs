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
    public partial class login_form : Form
    {
        public login_form()
        {
            InitializeComponent();
        }
        private void login_Button_Click(object sender, EventArgs e)
        {
            // Check user
            foreach(var user in StaticDb.Users)
            {
                if (user.UserName == username_textBox.Text)
                {
                    if (user.Password == password_textBox.Text)
                    {
                        StaticDb.CurrentUser = user;

                        MandoFf mandoFf = new MandoFf();
                        Hide();
                        mandoFf.ShowDialog();
                        Close();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Incorrect password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            MessageBox.Show("User does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Transparent;
        }
        private void signup_Button_Click(object sender, EventArgs e)
        {
            // Check user
            foreach (var usr in StaticDb.Users)
            {
                if (usr.UserName == username_textBox.Text)
                {
                    MessageBox.Show("Username taken!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Save user
            var user = new User
            {
                UserName = username_textBox.Text,
                Password = password_textBox.Text,
                Cart = new List<Order>()
            };
            StaticDb.Users.Add(user);
            StaticDb.Save();
            StaticDb.CurrentUser = user;


            // Open form
            MandoFf mandoFf = new MandoFf();
            Hide();
            mandoFf.ShowDialog();
            Close();
        }
    }
}
