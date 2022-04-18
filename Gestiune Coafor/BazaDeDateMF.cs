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
    public partial class BazaDeDateMF : Form
    {
        public BazaDeDateMF()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu meniu = new MainMenu();
            this.Hide();
            meniu.Closed += (s, args) => this.Close();
            meniu.Show();
            ////butonul de intoarcere in pagina principala
        }

        private void empl_btn_Click(object sender, EventArgs e)
        {
            Angajati angajati = new Angajati();
            this.Hide();
            angajati.Closed += (s, args) => this.Close();
            angajati.Show();
        }

        private void supp_btn_Click(object sender, EventArgs e)
        {
            Furnizori furnizori = new Furnizori();
            this.Hide();
            furnizori.Closed += (s, args) => this.Close();
            furnizori.Show();
        }

        private void goods_btn_Click(object sender, EventArgs e)
        {
            Marfa marfa = new Marfa();
            this.Hide();
            marfa.Closed += (s, args) => this.Close();
            marfa.Show();
        }

        private void book_btn_Click(object sender, EventArgs e)
        {
            Programari programari = new Programari();
            this.Hide();
            programari.Closed += (s, args) => this.Close();
            programari.Show();
        }
    }
}
