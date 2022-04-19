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
    public partial class Marfa : Form
    {
        public Marfa()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\MFdb.mdf;Integrated Security=True;Connect Timeout=30");


        private void Marfa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mFdbDataSet3.Marfa' table. You can move, or remove it, as needed.
            this.marfaTableAdapter2.Fill(this.mFdbDataSet3.Marfa);
            // TODO: This line of code loads data into the 'mFdbDataSet2.Marfa' table. You can move, or remove it, as needed.
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

        private void delete_btn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd3 = new SqlCommand("Delete from Marfa where Id=@Id", con);
            cmd3.Parameters.AddWithValue("@Id", Id_txtBox.Text);

            con.Open();
            cmd3.ExecuteNonQuery();
            con.Close();
            bind_data();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void finalContract_txtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pretBuc_txtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void furnizor_txtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cantitate_txtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void numeProdus_txtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void d_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd2 = new SqlCommand("Update Marfa Set Tip_Produs=@Tip_Produs,Nume_produs=@Nume_produs,Cantitate=@Cantitate, Pret_Buc_RON=@Pret_Buc_RON, Data_expirare=@Data_expirare,Furnizor=@Furnizor where Id=@Id", con);
            cmd2.Parameters.AddWithValue("@Id", Id_txtBox.Text);
            cmd2.Parameters.AddWithValue("@Tip_Produs", tipProdus_txtBox.Text);
            cmd2.Parameters.AddWithValue("@Nume_produs", numeProdus_txtBox.Text);
            cmd2.Parameters.AddWithValue("@Cantitate", cantitate_txtBox.Text);
            cmd2.Parameters.AddWithValue("@Pret_Buc_RON", pretBuc_txtBox.Text);
            cmd2.Parameters.AddWithValue("@Data_expirare", dataExp_txtBox.Text);
            cmd2.Parameters.AddWithValue("@Furnizor", furnizor_txtBox.Text);
            con.Open();
            cmd2.ExecuteNonQuery();
            con.Close();

            bind_data();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            
            SqlCommand cmd1 = new SqlCommand("Insert into Marfa(Tip_Produs,Nume_produs,Cantitate,Pret_Buc_Ron, Data_expirare, Furnizor)Values(@Tip_Produs,@Nume_produs,@Cantitate,@Pret_Buc_RON,@Data_expirare,@Furnizor)", con);
            ///SqlCommand cmd1 = new SqlCommand("Insert into Furnizori(Nume_furnizor,Produse_furnizor,Locatie_Sediu)Values('" + nume_furnizor.Text + "','" + numeProdus_txtBox.Text + "', '" + locatie_txtBox.Text + "'", con);
            cmd1.Parameters.AddWithValue("@Tip_Produs", tipProdus_txtBox.Text);
            cmd1.Parameters.AddWithValue("@Nume_produs", numeProdus_txtBox.Text);
            cmd1.Parameters.AddWithValue("@Cantitate", cantitate_txtBox.Text);
            cmd1.Parameters.AddWithValue("@Pret_Buc_RON", pretBuc_txtBox.Text);
            if (dataExp_txtBox.Text == "")
            {
                cmd1.Parameters.AddWithValue("@Data_expirare", " ");
            }
            else
            {
                cmd1.Parameters.AddWithValue("@Data_expirare", dataExp_txtBox.Text);
            }
            
            cmd1.Parameters.AddWithValue("@Furnizor", furnizor_txtBox.Text);

            con.Open();
            cmd1.ExecuteNonQuery();
            
            con.Close();


            bind_data();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void bind_data()
        {
            SqlCommand cmd = new SqlCommand("Select Id,Tip_Produs as Tip_Produs, Nume_produs as Nume_produs, Cantitate as Cantitate, Pret_Buc_RON as Pret_Buc_RON, Data_expirare as Data_expirare, Furnizor as Furnizor  From Marfa", con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            index = e.RowIndex;
            if (index >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[index];
                Id_txtBox.Text = selectedRow.Cells[0].Value.ToString();
                tipProdus_txtBox.Text = selectedRow.Cells[1].Value.ToString();
                numeProdus_txtBox.Text = selectedRow.Cells[2].Value.ToString();
                cantitate_txtBox.Text = selectedRow.Cells[3].Value.ToString();
                pretBuc_txtBox.Text = selectedRow.Cells[4].Value.ToString();
                dataExp_txtBox.Text = selectedRow.Cells[5].Value.ToString();
                furnizor_txtBox.Text = selectedRow.Cells[6].Value.ToString();



            }
        }
    }
}
