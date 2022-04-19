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
    public partial class Programari : Form
    {
        public Programari()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\MFdb.mdf;Integrated Security=True;Connect Timeout=30");

        private void Programari_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mFdbDataSet1.Progrmari' table. You can move, or remove it, as needed.
            bind_data();

        }


        public void bind_data()
        {
            SqlCommand cmd = new SqlCommand("Select Id,Nume_client as Nume_client, Prenume_client as Prenume_client, Data as Data, Ora as Ora, Serviciu as Serviciu, Nume_Specialist as Nume_Specialist, Pret as Pret From Progrmari", con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            bind_data();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            BazaDeDateMF dbmenu = new BazaDeDateMF();
            this.Hide();
            dbmenu.Closed += (s, args) => this.Close();
            dbmenu.Show();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd1 = new SqlCommand("Insert into Progrmari(Nume_client,Prenume_Client,Data,Ora,Serviciu,Nume_specialist,Pret)Values(@Nume_client,@Prenume_Client,@Data,@Ora,@Serviciu,@Nume_specialist,@Pret)", con);
            
            cmd1.Parameters.AddWithValue("@Nume_client", nume_client_txtBox.Text);
            cmd1.Parameters.AddWithValue("@Prenume_Client", prenume_Client_txtBox.Text);
            cmd1.Parameters.AddWithValue("@Data", data_txtBox.Text);
            cmd1.Parameters.AddWithValue("@Ora", ora_txtBox.Text);
            cmd1.Parameters.AddWithValue("@Serviciu", serviciu_txtBox.Text);
            cmd1.Parameters.AddWithValue("@Nume_specialist", nume_specialist_txtBox.Text);
            cmd1.Parameters.AddWithValue("@Pret", pret_txtBox.Text);
            
            con.Open();
            cmd1.ExecuteNonQuery();
            con.Close();

            bind_data();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd2 = new SqlCommand("Update Progrmari Set Nume_client=@Nume_client,Prenume_Client=@Prenume_Client,Data=@Data,Ora=@Ora,Serviciu=@Serviciu,Nume_specialist=@Nume_specialist,Pret=@Pret where Id=@Id", con);
            cmd2.Parameters.AddWithValue("@Nume_client", nume_client_txtBox.Text);
            cmd2.Parameters.AddWithValue("@Prenume_Client", prenume_Client_txtBox.Text);
            cmd2.Parameters.AddWithValue("@Data", data_txtBox.Text);
            cmd2.Parameters.AddWithValue("@Ora", ora_txtBox.Text);
            cmd2.Parameters.AddWithValue("@Serviciu", serviciu_txtBox.Text);
            cmd2.Parameters.AddWithValue("@Nume_specialist", nume_specialist_txtBox.Text);
            cmd2.Parameters.AddWithValue("@Pret", pret_txtBox.Text);



            cmd2.Parameters.AddWithValue("@Id", Id_txtBox.Text);

            con.Open();
            cmd2.ExecuteNonQuery();
            con.Close();
            bind_data();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd3 = new SqlCommand("Delete from Progrmari where Id=@Id", con);
            cmd3.Parameters.AddWithValue("@Id", Id_txtBox.Text);

            con.Open();
            cmd3.ExecuteNonQuery();
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
                nume_client_txtBox.Text = selectedRow.Cells[1].Value.ToString();
                prenume_Client_txtBox.Text = selectedRow.Cells[2].Value.ToString();
                data_txtBox.Text = selectedRow.Cells[3].Value.ToString();
                ora_txtBox.Text = selectedRow.Cells[4].Value.ToString();
                serviciu_txtBox.Text = selectedRow.Cells[5].Value.ToString();
                nume_specialist_txtBox.Text = selectedRow.Cells[6].Value.ToString();
                pret_txtBox.Text = selectedRow.Cells[7].Value.ToString();



            }
        }
    }
}
