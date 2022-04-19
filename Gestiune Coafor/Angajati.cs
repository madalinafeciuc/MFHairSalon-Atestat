using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Gestiune_Coafor
{
    public partial class Angajati : Form
    {
        public Angajati()
        {
            InitializeComponent();
        }


        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\MFdb.mdf;Integrated Security=True;Connect Timeout=30");









        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Angajati_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mFdbDataSet.Angajati' table. You can move, or remove it, as needed.
            ///this.angajatiTableAdapter.Fill(this.mFdbDataSet.Angajati);
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

        private void add_btn_Click(object sender, EventArgs e)
        {
            con.Open();
            ///SqlCommand cmd1 = new SqlCommand("Insert into Angajati(Nume,Prenume,An_nastere,Data_inceperii_contractului,Data_expirarii_contractului,Program)Values(@Nume,@Prenume,@An_nastere,@Data_inceperii_contractului,@Data_expirarii_contractului,@Program)", con);
            SqlCommand cmd1 = new SqlCommand("Insert into Angajati(Nume,Prenume,An_nastere,Data_inceperii_contractului,Data_expirarii_contractului,Program)Values('"+nume_txtBox.Text+"','"+prenume_txtBox.Text+"', '"+an_nastere_txtBox.Text+"', '"+startContract_txtBox.Text+"', '"+finalContract_txtBox.Text+"', '"+program_txtBox.Text+"')", con);
            /*cmd1.Parameters.AddWithValue("@Nume", nume_txtBox.Text);                  
            cmd1.Parameters.AddWithValue("@Prenume", prenume_txtBox.Text);
            cmd1.Parameters.AddWithValue("@An_nastere", an_nastere_txtBox.Text);                  
            cmd1.Parameters.AddWithValue("@Data_inceperii_contractului", startContract_txtBox.Text);                  
            cmd1.Parameters.AddWithValue("@Data_expirarii_contractului", finalContract_txtBox.Text);                  
            cmd1.Parameters.AddWithValue("@Program", program_txtBox.Text);*/
           
            cmd1.ExecuteNonQuery();
            con.Close();
            angajatiTableAdapter.Fill(this.mFdbDataSet.Angajati);
            bind_data();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            index = e.RowIndex;
            if (index >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[index];
                Id_txtbox.Text = selectedRow.Cells[0].Value.ToString();
                nume_txtBox.Text = selectedRow.Cells[1].Value.ToString();
                prenume_txtBox.Text = selectedRow.Cells[2].Value.ToString();
                an_nastere_txtBox.Text = selectedRow.Cells[3].Value.ToString();
                startContract_txtBox.Text = selectedRow.Cells[4].Value.ToString();
                finalContract_txtBox.Text = selectedRow.Cells[5].Value.ToString();
                program_txtBox.Text = selectedRow.Cells[6].Value.ToString();
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd2 = new SqlCommand("Update Angajati Set Nume=@Nume,Prenume=@Prenume,An_nastere=@An_nastere,Data_inceperii_contractului=@Data_inceperii_contractului,Data_expirarii_contractului=@Data_expirarii_contractului,Program=@Program where Id=@Id", con);
            cmd2.Parameters.AddWithValue("@Nume", nume_txtBox.Text);
            cmd2.Parameters.AddWithValue("@Prenume", prenume_txtBox.Text);
            cmd2.Parameters.AddWithValue("@An_nastere", an_nastere_txtBox.Text);
            cmd2.Parameters.AddWithValue("@Data_inceperii_contractului", startContract_txtBox.Text);
            cmd2.Parameters.AddWithValue("@Data_expirarii_contractului", finalContract_txtBox.Text);
            cmd2.Parameters.AddWithValue("@Program", program_txtBox.Text);
            cmd2.Parameters.AddWithValue("@Id", Id_txtbox.Text);

            con.Open();
            cmd2.ExecuteNonQuery();
            con.Close();
            bind_data();

        }

        public void bind_data()
        {
            SqlCommand cmd = new SqlCommand("Select Id,Nume as Nume, Prenume as Prenume, An_nastere as An_Nastere, Data_inceperii_contractului as Data_inceperii_contractului, Data_expirarii_contractului as Data_expirarii_contractului, Program as Program From Angajati", con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd3 = new SqlCommand("Delete from Angajati where Id=@Id", con);
            cmd3.Parameters.AddWithValue("@Id", Id_txtbox.Text);

            con.Open();
            cmd3.ExecuteNonQuery();
            con.Close();
            bind_data();
        }
    }

}
