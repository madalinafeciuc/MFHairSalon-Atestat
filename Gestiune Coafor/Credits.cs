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
    public partial class Credits : Form
    {
        public Credits()
        {
            InitializeComponent();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            MainMenu meniu = new MainMenu();
            this.Hide();
            meniu.Closed += (s, args) => this.Close();
            meniu.Show();
        }
    }
}
