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
    public partial class JarmuBerloForm : Form
    {
        LoginForm login;
        Categories categories = new Categories();
        Makers makers = new Makers();
        Owners owners = new Owners();
        Vehicles vehicles = new Vehicles();
        Loans loans = new Loans();
        Users users = new Users();
        UserGroups userGroups = new UserGroups();
        List<Loan> loanList;
        List<Vehicle> vehicleList;
        int user;
        
        
        public JarmuBerloForm(LoginForm login, int user)
        {
            //inicializalasok a formon
            InitializeComponent();
            InitializeComponentLists();
            this.login = login;
            this.user = user;
            FillDgvVehicles("", "");
            vehicleList = vehicles.GetVehicleList("", "");
            FillMakerFilterCb();
            FillCategoryFilterCb();

            //ha berlo jelentkezett be, akkor az ennek fenntartott fieldeket aktivva teszi
            if (user > 0)
            {
                dtpLoanStart.Format = DateTimePickerFormat.Custom;
                dtpLoanStart.CustomFormat = "yyyy-MM-dd";
                dtpLoanStart.Value = DateTime.Today;
                dtpLoanStart.MinDate = DateTime.Today;
                dtpLoanEnd.Value = DateTime.Today;
                dtpLoanEnd.MinDate = DateTime.Today;
                dtpLoanEnd.Format = DateTimePickerFormat.Custom;
                dtpLoanEnd.CustomFormat = "yyyy-MM-dd";
                loanList = new List<Loan>();
                foreach (Control item in loanerItems)
                {
                    item.Enabled = true;
                }
            }
            //ha bejegyzo vagy admin lepett be, akkor a kozos fieldek lesznek aktivak
            else
            {
                foreach (Control item in registrantItems)
                {
                    item.Enabled = true;
                }
                FillMakersCb();
                FillCategoriesCb();
                FillOwnerCb();
                FillExportCb();
                if (user == 0) //ha admin, akkor az ennek specifikus fieldek is aktviak lesznek
                {
                    FillUsersCb();
                    FillUserGroupsCb();
                    cbExport.Items.Add("Felhasználók");
                    foreach (Control item in adminItems)
                    {
                        item.Enabled = true;
                    }
                }
            }
            Location = new Point(50, 5);
        }

        //feltolti a tablat ami a jarmuvek informacioit tartalmazza
        private void FillDgvVehicles(string makerFilter, string categoryFilter)
        {
            dgvVehicles.Rows.Clear();
            List<Vehicle> vehiclesList = vehicles.GetVehicleList(makerFilter, categoryFilter);

            foreach (var v in vehiclesList)
            {
                dgvVehicles.Rows.Add(v.VehicleID, v.MakerName, v.VehicleModel, v.VehicleYear, v.CategoryName, v.VehiclePrice, v.VehicleConsumption);
            }
        }

        //feltolti a gyartokat tartalmazo comboboxot, amit keresesnel lehet hasznalni
        private void FillMakerFilterCb()
        {
            List<Maker> makerList = makers.GetMakerList();
            cbMakerFilter.DataSource = makerList;
            cbMakerFilter.DisplayMember = "MakerName";
        }

        //feltolti a kategoriakat tartalmazo comboboxot, amit keresesnel lehet hasznalni
        private void FillCategoryFilterCb()
        {
            List<Category> categoryList = categories.GetCategoryList();
            cbCategoryFilter.DataSource = categoryList;
            cbCategoryFilter.DisplayMember = "CategoryName";
        }

        private void btnCategoryFilter_Click(object sender, EventArgs e)
        {
            FillDgvVehicles(cbMakerFilter.Text, cbCategoryFilter.Text);
        }

        //feltolti a gyartokat tartalmazo comboboxot, amit hozzaadasnal lehet hasznalni
        private void FillMakersCb()
        {
            List<Maker> makerList = makers.GetMakerList();
            cbMakers.DataSource = makerList;
            cbMakers.DisplayMember = "MakerName";
            cbMakers.ValueMember = "MakerID";
        }

        //feltolti a kategoriakat tartalmazo comboboxot, amit hozzaadasnal lehet hasznalni
        private void FillCategoriesCb()
        {
            List<Category> categoryList = categories.GetCategoryList();
            cbCategories.DataSource = categoryList;
            cbCategories.DisplayMember = "CategoryName";
            cbCategories.ValueMember = "CategoryID";
        }

        //feltolti a tualjdonosokat tartalmazo comboboxot, amit hozzaadasnal lehet hasznalni
        private void FillOwnerCb()
        {
            List<Owner> ownerList = owners.GetOwnerList();
            cbOwners.DataSource = ownerList;
            cbOwners.DisplayMember = "OwnerName";
            cbOwners.ValueMember = "OwnerID";
        }

        //feltolti a csoportokat tartalmazo comboboxot, amit felhasznalo hozzaadasnal lehet hasznalni
        private void FillUserGroupsCb()
        {
            List<UserGroup> userGroupList = userGroups.GetUserGroupList();
            cbUserGroups.DataSource = userGroupList;
            cbUserGroups.DisplayMember = "GroupName";
            cbUserGroups.ValueMember = "GroupName";
        }

        //feltolti a felhasznalokat tartalmazo comboboxot, amit felhasznalo torlesenel lehet hasznalni
        private void FillUsersCb()
        {
            List<User> userList = users.GetUserList();
            cbUsers.DataSource = userList;
            cbUsers.DisplayMember = "Username";
            cbUsers.ValueMember = "UserID";
        }

        //az XMLkent exportalhato comboboxot tolti fel
        private void FillExportCb()
        {
            cbExport.Items.Add("Járművek");
            cbExport.Items.Add("Bérlések");
            cbExport.SelectedIndex = 0;
        }

        //berles vegrehajtasa
        private void btnLoan_Click(object sender, EventArgs e)
        {
            if (loanList.Count == 0)
            {
                MessageBox.Show("A bérlési lista üres. \n Tegye be a listába a járműveket\n amiket meg akar rendelni.");
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                int sum = 0;
                //vegigjarja a listaban talalhato autokat, es megprobalja kiberelni a megadott datumok kozott
                foreach (Loan l in loanList)
                {
                    int ret = loans.Loan(l.VehicleID, user, l.LoanStart, l.LoanEnd);
                    Vehicle v = vehicleList.ElementAt(l.VehicleID - 1);
                    if (ret > 0)
                    {
                        sb.Append(v.MakerName);
                        sb.Append(" ");
                        sb.Append(v.VehicleModel);
                        sb.Append(" ");
                        sb.Append(l.LoanStart);
                        sb.Append("-");
                        sb.Append(l.LoanEnd);
                        sb.Append(" ... " + ret.ToString() + "\n");
                        sum += ret;
                    }
                    else
                    {
                        sb.Append(v.MakerName);
                        sb.Append(" ");
                        sb.Append(v.VehicleModel);
                        sb.Append(" ");
                        sb.Append(l.LoanStart);
                        sb.Append("-");
                        sb.Append(l.LoanEnd);
                        sb.Append(" ... foglalt\n");
                    }
                }
                sb.Append("Összesen: " + sum.ToString());
                MessageBox.Show(sb.ToString());
                loanList = new List<Loan>();
                dgvLoanList.Rows.Clear();
            }
        }

        //megadja a kivalasztott jarmure a datumokat amiken foglalt
        private void btnOccupied_Click(object sender, EventArgs e)
        {
            int vehicleID = Convert.ToInt32(dgvVehicles.SelectedRows[0].Cells[0].Value);
            MessageBox.Show(loans.GetOccupiedDates(vehicleID));
        }

        private void dtpLoanStart_ValueChanged(object sender, EventArgs e)
        {
            dtpLoanEnd.MinDate = dtpLoanStart.Value;
            if (dtpLoanStart.Value > dtpLoanEnd.Value)
            {
                dtpLoanEnd.Value = dtpLoanStart.Value;
            }
        }

        //jarmu beszurasa
        private void btInsert_Click(object sender, EventArgs e)
        {
            string makerID = cbMakers.SelectedValue.ToString();
            string ownerID = cbOwners.SelectedValue.ToString();
            string categoryID = cbCategories.SelectedValue.ToString();
            string price = tbPrice.Text;
            string consumption = tbConsumption.Text;
            string year = tbYear.Text;
            string model = tbModel.Text;
            
            int ret = vehicles.AddVehicle(makerID, ownerID, categoryID, price, consumption, year, model);
            if (ret == 0)
            {
                MessageBox.Show("Jármű beszúrva");
                FillDgvVehicles("", "");
            }
        }
        
        //jarmu torlese
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int vehicleID = Convert.ToInt32(dgvVehicles.SelectedRows[0].Cells[0].Value);
            loans.RemoveLoans(vehicleID);
            vehicles.RemoveVehicle(vehicleID);
            MessageBox.Show("Jármű törölve");
            FillDgvVehicles("", "");
        }

        private void cbUserGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbUserGroups.SelectedValue.ToString().StartsWith("Bérl"))
            {
                ShowLoanerFields(true);
                btnAddUser.Location = new Point(87, 563);
            }
            else
            {
                ShowLoanerFields(false);
                btnAddUser.Location = new Point(87, 491);
            }
        }

        private void ShowLoanerFields(Boolean b)
        {
            lbFullName.Visible = b;
            lbPhoneNumber.Visible = b;
            lbLicenseNumber.Visible = b;
            tbFullName.Visible = b;
            tbPhoneNumber.Visible = b;
            tbLicenseNumber.Visible = b;
        }

        //felhasznalo hozzaadasa, ami lehet berlo, bejegyzo vagy admin
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            int ret;
            if (cbUserGroups.SelectedValue.ToString().StartsWith("Bérl"))
            {
                ret = users.AddLoaner(cbUserGroups.SelectedIndex + 1, tbUsername.Text, Encrypter.Encrypt(tbPassword.Text), tbFullName.Text, tbPhoneNumber.Text, tbLicenseNumber.Text);
            }
            else
            {
                ret = users.AddUser(cbUserGroups.SelectedIndex + 1, tbUsername.Text, Encrypter.Encrypt(tbPassword.Text));
            }
            if (ret == 0)
            {
                MessageBox.Show("Felhasználó létrehozva");
                FillUsersCb();
            }
            else 
            {
                MessageBox.Show("A felhasználónév már foglalt");
            }
        }

        //felhasznalo torlese
        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            users.RemoveUser(Convert.ToInt32(cbUsers.SelectedValue));
            MessageBox.Show("Felhasználó törölve");
            FillUsersCb();
        }

        //bezarasnal megjeleniti a bejelentkezesi formot
        private void JarmuBerloForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            login.Show();
        }

        //field validalasok; csak szamokat enged beirni
        private void tbPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            tbPhoneNumber.Text = Regex.Replace(tbPhoneNumber.Text, "[^0-9]", "", RegexOptions.Compiled);
        }

        private void tbLicenseNumber_TextChanged(object sender, EventArgs e)
        {
            tbLicenseNumber.Text = Regex.Replace(tbLicenseNumber.Text, "[^0-9]", "", RegexOptions.Compiled);
        }

        private void tbYear_TextChanged(object sender, EventArgs e)
        {
            tbYear.Text = Regex.Replace(tbYear.Text, "[^0-9]", "", RegexOptions.Compiled);
        }

        private void tbPrice_TextChanged(object sender, EventArgs e)
        {
            tbPrice.Text = Regex.Replace(tbPrice.Text, "[^0-9]", "", RegexOptions.Compiled);
        }

        private void tbConsumption_TextChanged(object sender, EventArgs e)
        {
            tbConsumption.Text = Regex.Replace(tbConsumption.Text, "[^0-9]", "", RegexOptions.Compiled);
        }

        //hozzaadja az adott autot a kivalasztott datumok kozott a berlesi listahoz
        //ha az mar foglalt valamely napokon a kivalasztott datumok kozott, akkor figyelmezteti a felhasznalot
        private void btnLoanListAdd_Click(object sender, EventArgs e)
        {
            Loan l = new Loan();
            l.LoanStart = dtpLoanStart.Value.ToString("yyyy-MM-dd");
            l.LoanEnd = dtpLoanEnd.Value.ToString("yyyy-MM-dd");
            l.VehicleID = Convert.ToInt32(dgvVehicles.SelectedRows[0].Cells[0].Value);
            if (loans.IsFree(l.VehicleID, l.LoanStart, l.LoanEnd) == 0)
            {
                loanList.Add(l);
                dgvLoanList.Rows.Add(dgvVehicles.SelectedRows[0].Cells[1].Value.ToString() + " " + dgvVehicles.SelectedRows[0].Cells[2].Value.ToString(), dtpLoanStart.Value.ToString("yyyy-MM-dd"), dtpLoanEnd.Value.ToString("yyyy-MM-dd"));
            }
            else
            {
                MessageBox.Show("A jármű foglalt.");
            }
        }

        //megjelenit egy folder kereso ablakot XML exportalashoz
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                tbFileLocationExport.Text = folderBrowser.SelectedPath + "\\";
            }
        }

        //XML exportolasa a kivalasztott szoveg alapjan a kivalasztott fileba
        //automatikusan general melle egy ugyanolyan nevu HTML file-t is, XSLT hasznalataval
        private void btnExport_Click(object sender, EventArgs e)
        {
            string file = tbFileLocationExport.Text;
            if (file.Equals("") || file.EndsWith("\\"))
                file += "<fname>";
            if (!file.Contains(":"))
                file = "C:\\Users\\" + Environment.UserName + "\\Desktop\\" + file;
            if (!file.EndsWith(".xml"))
                file += ".xml";
            if (cbExport.SelectedIndex == 0)
            {
                vehicles.ExportVehiclesXML(file.Replace("<fname>", "VehiclesExport"));
            }
            if (cbExport.SelectedIndex == 1)
            {
                loans.ExportLoansXML(file.Replace("<fname>", "LoansExport"));
            }
            if (cbExport.SelectedIndex == 2)
            {
                users.ExportUsersXML(file.Replace("<fname>", "UsersExport"));
            }
            MessageBox.Show("Az exportálás befejeződött.");
        }
    }
}