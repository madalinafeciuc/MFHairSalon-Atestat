using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestiune_Coafor
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        

        private void username_txtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (username_txtBox.Text == "admin" && pass_txtBox.Text == "parolaAdmin")
            {
                MessageBox.Show("Autentificare reusita!");
                BazaDeDateMF dbmenu = new BazaDeDateMF();
                this.Hide();
                dbmenu.Closed += (s, args) => this.Close();
                dbmenu.Show();
                ////butonul de verificare a datelor introduse, respectiv de accesare a meniului cu tabele
            }
            else MessageBox.Show("Autentificare nereusita! Numele de utilizator sau parola sunt incorecte!");
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            MainMenu meniu = new MainMenu();
            this.Hide();
            meniu.Closed += (s, args) => this.Close();
            meniu.Show();
            ////butonul de intoarcere in pagina principala
        }
    }
}
