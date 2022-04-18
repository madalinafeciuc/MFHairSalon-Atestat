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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void db_btn_Click(object sender, EventArgs e)
        {
           LoginForm loginPage = new LoginForm();
            this.Hide();
            loginPage.Closed += (s, args) => this.Close();
            loginPage.Show();
        }

        private void credits_btn_Click(object sender, EventArgs e)
        {
            Credits credite = new Credits();
            this.Hide();
            credite.Closed += (s, args) => this.Close();
            credite.Show();
        }
    }
}
