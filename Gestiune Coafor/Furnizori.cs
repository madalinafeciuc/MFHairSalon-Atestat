using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestiune_Coafor
{
    public partial class Furnizori : Form
    {
        public Furnizori()
        {
            InitializeComponent();
        }


        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\MFdb.mdf;Integrated Security=True;Connect Timeout=30");

        private void Furnizori_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mFdbDataSet1.Furnizori' table. You can move, or remove it, as needed.
            bind_data();

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            BazaDeDateMF dbmenu = new BazaDeDateMF();
            this.Hide();
            dbmenu.Closed += (s, args) => this.Close();
            dbmenu.Show();
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            bind_data();
        }


        public void bind_data()
        {
            SqlCommand cmd = new SqlCommand("Select Id,Nume_furnizor as Nume_furnizor, Produse_furnizor as Produse_furnizor, Locatie_sediu as Locatie_sediu From Furnizori", con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd1 = new SqlCommand("Insert into Furnizori(Nume_furnizor,Produse_furnizor,Locatie_Sediu)Values(@Nume_furnizor,@Produse_furnizor,@Locatie_Sediu)", con);
            cmd1.Parameters.AddWithValue("@Nume_furnizor", nume_furnizor.Text);                  
            cmd1.Parameters.AddWithValue("@Produse_furnizor", numeProdus_txtBox.Text);
            cmd1.Parameters.AddWithValue("@Locatie_Sediu", locatie_txtBox.Text);
            con.Open();
            cmd1.ExecuteNonQuery();
            con.Close();
            
            bind_data();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            index = e.RowIndex;
            if (index >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[index];
                Id_txtBox.Text = selectedRow.Cells[0].Value.ToString();
                nume_furnizor.Text = selectedRow.Cells[1].Value.ToString();
                numeProdus_txtBox.Text = selectedRow.Cells[2].Value.ToString();
                locatie_txtBox.Text = selectedRow.Cells[3].Value.ToString();
                
                
                
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd2 = new SqlCommand("Update Furnizori Set Nume_furnizor=@Nume_furnizor,Produse_furnizor=@Produse_furnizor,Locatie_Sediu=@Locatie_Sediu where Id=@Id", con);
            cmd2.Parameters.AddWithValue("@Nume_furnizor", nume_furnizor.Text);
            cmd2.Parameters.AddWithValue("@Produse_furnizor", numeProdus_txtBox.Text);
            cmd2.Parameters.AddWithValue("@Locatie_Sediu", locatie_txtBox.Text);
            
           
            
            cmd2.Parameters.AddWithValue("@Id", Id_txtBox.Text);

            con.Open();
            cmd2.ExecuteNonQuery();
            con.Close();
            bind_data();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd3 = new SqlCommand("Delete from Furnizori where Id=@Id", con);
            cmd3.Parameters.AddWithValue("@Id", Id_txtBox.Text);

            con.Open();
            cmd3.ExecuteNonQuery();
            con.Close();
            bind_data();
        }
    }
}
