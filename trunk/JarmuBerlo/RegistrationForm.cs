using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using JarmuBerloDAL;
using System.Text.RegularExpressions;

namespace JarmuBerlo
{
    public partial class RegistrationForm : Form
    {
        LoginForm login;
        Users users = new Users();

        public RegistrationForm(LoginForm login)
        {
            InitializeComponent();
            this.login = login;
            login.Hide();
            Location = new Point(50, 5);
        }

        //regisztralast hajt vegre, azaz berlot probal beszurni az adatbazisba
        //ha valamilyen hiba tortenik, uzenetet ir ki a felhasznalonak
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text.Equals("") || tbPassword.Text.Equals("") || tbFullName.Text.Equals("") || tbPhoneNumber.Text.Equals("") || tbLicenseNumber.Text.Equals(""))
            {
                MessageBox.Show("Kérem töltsön ki minden mezőt!");
            }
            else
            {
                if (users.AddLoaner(3, tbUsername.Text, Encrypter.Encrypt(tbPassword.Text), tbFullName.Text, tbPhoneNumber.Text, tbLicenseNumber.Text) == 0)
                {
                    MessageBox.Show("Sikeres regisztráció.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("A felhasználónév már foglalt.");
                }
            }
        }

        private void RegistrationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            login.Show();
        }

        private void tbPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            tbPhoneNumber.Text = Regex.Replace(tbPhoneNumber.Text, "[^0-9]", "", RegexOptions.Compiled);
        }

        private void tbLicenseNumber_TextChanged(object sender, EventArgs e)
        {
            tbLicenseNumber.Text = Regex.Replace(tbLicenseNumber.Text, "[^0-9]", "", RegexOptions.Compiled);
        }
    }
}
