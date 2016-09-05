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

namespace Emlak
{
    public partial class Form3 : Form
    {
        SqlConnection conFriends = new SqlConnection("Data Source=YUNUSH\\SQLEXPRESS;Initial Catalog=Emlak;Integrated Security=True");
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'emlakDataSet1.Alicilar' table. You can move, or remove it, as needed.
            this.alicilarTableAdapter.Fill(this.emlakDataSet1.Alicilar);
            // TODO: This line of code loads data into the 'emlakDataSet.Evler' table. You can move, or remove it, as needed.
            this.evlerTableAdapter.Fill(this.emlakDataSet.Evler);
      
           
            
            comboBox1.SelectedItem = null;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            dataGridView1.Refresh();
            dataGridView2.Refresh();
            conFriends.Open();
            SqlCommand cmd = new SqlCommand("AliciF", conFriends);
            cmd.CommandType = CommandType.StoredProcedure;
            using (SqlDataAdapter adap = new SqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                adap.Fill(dt);
                dataGridView1.DataSource = dt;
               
            }

            cmd.ExecuteNonQuery();
            conFriends.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fff = new Form1();
            fff.Show();
            this.Hide();
           

           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conFriends.Open();
            SqlCommand cmdInsert = new SqlCommand("AliciEkle", conFriends);
            cmdInsert.CommandType = CommandType.StoredProcedure;
            SqlParameter paramAliciTC = cmdInsert.Parameters.AddWithValue("@alicitc", textBox1.Text.ToString());
            SqlParameter paramAlici = cmdInsert.Parameters.AddWithValue("@aliciadsoyad", textBox2.Text);
            SqlParameter paramEvAdres = cmdInsert.Parameters.AddWithValue("@alicitel", textBox3.Text.ToString());
            SqlParameter paramEvSahip = cmdInsert.Parameters.AddWithValue("@ilgevid", comboBox1.Text);
            cmdInsert.ExecuteNonQuery();
            conFriends.Close();
            dataGridView1.Refresh();
            dataGridView2.Refresh();
            Form3_Load(sender, e);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.SelectedItem = null;
            MessageBox.Show("Alıcı listeye eklendi.", "Bilgilendirme", MessageBoxButtons.OK);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                conFriends.Open();
                SqlCommand cmdInsert = new SqlCommand("AliciSil", conFriends);
                cmdInsert.CommandType = CommandType.StoredProcedure;
                SqlParameter paramAliciTC = cmdInsert.Parameters.AddWithValue("@alicitc", textBox1.Text);
                cmdInsert.ExecuteNonQuery();
                conFriends.Close();
                textBox1.Clear();
                MessageBox.Show("Alıcı silindi.", "Bilgilendirme", MessageBoxButtons.OK);
                dataGridView1.Refresh();
                dataGridView2.Refresh();
                Form3_Load(sender, e);
            }

            else
                MessageBox.Show("Silinecek alıcının TC'sini girmediniz!", "Hata", MessageBoxButtons.OK);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            conFriends.Open();
            SqlCommand cmdInsert = new SqlCommand("AliciGuncelle", conFriends);
            cmdInsert.CommandType = CommandType.StoredProcedure;
            SqlParameter paramAliciTC = cmdInsert.Parameters.AddWithValue("@alicitc", textBox1.Text.ToString());
            SqlParameter paramAlici = cmdInsert.Parameters.AddWithValue("@aliciadsoyad", textBox2.Text);
            SqlParameter paramEvAdres = cmdInsert.Parameters.AddWithValue("@alicitel", textBox3.Text.ToString());
            SqlParameter paramEvSahip = cmdInsert.Parameters.AddWithValue("@ilgevid", comboBox1.Text);
            cmdInsert.ExecuteNonQuery();
            conFriends.Close();
            dataGridView1.Refresh();
            dataGridView2.Refresh();
            Form3_Load(sender, e);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.SelectedItem = null;
            MessageBox.Show("Alıcı bilgileri güncellendi!.", "Bilgilendirme", MessageBoxButtons.OK);
        }
    }
}
