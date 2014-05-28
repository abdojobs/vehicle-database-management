using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using JarmuBerloDAL;

namespace JarmuBerlo
{
    public partial class LoginForm : Form
    {
        Users users = new Users();

        public LoginForm()
        {
            InitializeComponent();
            Location = new Point(50, 5);
        }

        //a gomb lenyomasara megprobal belepni es tovabbkuldi a felhasznalo tipusat a jarmuberlo formnak
        //ha hiba tortenik, szoveget ir ki a felhasznalonak
        private void btnLogin_Click(object sender, EventArgs e)
        {
            int ret = users.Login(tbUsername.Text, Encrypter.Encrypt(tbPassword.Text));
            if (ret == -1)
            {
                MessageBox.Show("SQL error");
            }
            else if (ret == -3)
            {
                MessageBox.Show("A felhasználónév nem létezik");
            }
            else if (ret == -4)
            {
                MessageBox.Show("A megadott jelszó nem helyes");
            }
            else
            {
                new JarmuBerloForm(this, ret).Show();
                this.Hide();
                tbUsername.Text = "";
                tbPassword.Text = "";
            }
        }

        //regisztracios formot jelenit meg gombnyomasra
        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            new RegistrationForm(this).Show();
        }
    }
}
