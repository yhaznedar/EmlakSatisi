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

namespace Emlak
{
    public partial class Form1 : Form
    {
        SqlConnection conFriends = new SqlConnection("Data Source=YUNUSH\\SQLEXPRESS;Initial Catalog=Emlak;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();



        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 ff = new Form2();
            ff.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            dataGridView1.Refresh();
            dataGridView2.Refresh();
            conFriends.Open();
            SqlCommand cmd = new SqlCommand("SatilikEvlerListesi", conFriends);
            SqlCommand cmd1 = new SqlCommand("KiralıkEvlerListesi", conFriends);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd1.CommandType = CommandType.StoredProcedure;
            using (SqlDataAdapter adap = new SqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                adap.Fill(dt);
                dataGridView1.DataSource = dt;
               
            }
            using (SqlDataAdapter adap1 = new SqlDataAdapter(cmd1))
            {
                DataTable dt1 = new DataTable();
                adap1.Fill(dt1);
                dataGridView2.DataSource = dt1;
              

            }

            cmd.ExecuteNonQuery();
            cmd.ExecuteNonQuery();
            conFriends.Close();
        }


    



        public void EvSil()
        {
            conFriends.Open();
            SqlCommand cmdInsert = new SqlCommand("EvSil1", conFriends);
            cmdInsert.CommandType = CommandType.StoredProcedure;
            SqlParameter paramEvID = cmdInsert.Parameters.AddWithValue("@evid", textBox1.Text);
            cmdInsert.ExecuteNonQuery();
            conFriends.Close();
        }


        public void KiraEkle()
        {
            conFriends.Open();
            SqlCommand cmdInsert = new SqlCommand("EvEkle", conFriends);
            cmdInsert.CommandType = CommandType.StoredProcedure;
            SqlParameter paramEvTur = cmdInsert.Parameters.AddWithValue("@evtur", checkedListBox1.Items[0].ToString());
            SqlParameter paramEvID = cmdInsert.Parameters.AddWithValue("@evid", textBox1.Text);
            SqlParameter paramEvAdres = cmdInsert.Parameters.AddWithValue("@evadres", textBox2.Text);
            SqlParameter paramEvSahip = cmdInsert.Parameters.AddWithValue("@sahipadsoyad", textBox4.Text);
            SqlParameter paramEvSTel = cmdInsert.Parameters.AddWithValue("@sahiptel", textBox6.Text);
            SqlParameter paramAciklama = cmdInsert.Parameters.AddWithValue("@aciklama", textBox5.Text);
            SqlParameter paramKiram = cmdInsert.Parameters.AddWithValue("@kirafiyati", textBox3.Text);
            cmdInsert.ExecuteNonQuery();
            conFriends.Close();
        }

        public void KiraİlanGuncelle()
        {
            conFriends.Open();
            SqlCommand cmdInsert = new SqlCommand("KiraİlanGuncelle", conFriends);
            cmdInsert.CommandType = CommandType.StoredProcedure;
            SqlParameter paramEvID = cmdInsert.Parameters.AddWithValue("@evid", textBox1.Text);
            SqlParameter paramEvAdres = cmdInsert.Parameters.AddWithValue("@evadres", textBox2.Text);
            SqlParameter paramEvSahip = cmdInsert.Parameters.AddWithValue("@sahipadsoyad", textBox4.Text);
            SqlParameter paramEvSTel = cmdInsert.Parameters.AddWithValue("@sahiptel", textBox6.Text);
            SqlParameter paramAciklama = cmdInsert.Parameters.AddWithValue("@aciklama", textBox5.Text);
            SqlParameter paramKiram = cmdInsert.Parameters.AddWithValue("@kirafiyat", textBox3.Text);
            cmdInsert.ExecuteNonQuery();
            conFriends.Close();
        }


        public void SatilikİlanGuncelle()
        {
            conFriends.Open();
            SqlCommand cmdInsert = new SqlCommand("SatilikİlanGuncelle", conFriends);
            cmdInsert.CommandType = CommandType.StoredProcedure;
            SqlParameter paramEvID = cmdInsert.Parameters.AddWithValue("@evid", textBox1.Text);
            SqlParameter paramEvAdres = cmdInsert.Parameters.AddWithValue("@evadres", textBox2.Text);
            SqlParameter paramEvSahip = cmdInsert.Parameters.AddWithValue("@sahipadsoyad", textBox4.Text);
            SqlParameter paramEvSTel = cmdInsert.Parameters.AddWithValue("@sahiptel", textBox6.Text);
            SqlParameter paramAciklama = cmdInsert.Parameters.AddWithValue("@aciklama", textBox5.Text);
            SqlParameter paramSatis= cmdInsert.Parameters.AddWithValue("@satisfiyati", textBox3.Text);
            cmdInsert.ExecuteNonQuery();
            conFriends.Close();
        }



        public void SatilikEkle()
        {
            conFriends.Open();
            SqlCommand cmdInsert = new SqlCommand("EvEkle2", conFriends);
            cmdInsert.CommandType = CommandType.StoredProcedure;
            cmdInsert.CommandType = CommandType.StoredProcedure;
            SqlParameter paramEvTur = cmdInsert.Parameters.AddWithValue("@evtur", checkedListBox1.Items[0].ToString());
            SqlParameter paramEvID = cmdInsert.Parameters.AddWithValue("@evid", textBox1.Text);
            SqlParameter paramEvAdres = cmdInsert.Parameters.AddWithValue("@evadres", textBox2.Text);
            SqlParameter paramEvSahip = cmdInsert.Parameters.AddWithValue("@sahipadsoyad", textBox4.Text);
            SqlParameter paramEvSTel = cmdInsert.Parameters.AddWithValue("@sahiptel", textBox6.Text);
            SqlParameter paramAciklama = cmdInsert.Parameters.AddWithValue("@aciklama", textBox5.Text);
            SqlParameter paramSatis = cmdInsert.Parameters.AddWithValue("@satisfiyati", textBox3.Text);

            cmdInsert.ExecuteNonQuery();
            conFriends.Close();
        }

    

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (checkedListBox1.SelectedIndex == 0)
            {

                KiraEkle();
                MessageBox.Show("İlan Eklendi!", "Bilgilendirme", MessageBoxButtons.OK);
                dataGridView1.Refresh();
                Form1_Load(sender, e);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
            }

            else if (checkedListBox1.SelectedIndex == 1)
            {

                SatilikEkle();
                MessageBox.Show("İlan Eklendi!", "Bilgilendirme", MessageBoxButtons.OK);
                dataGridView1.Refresh();
                Form1_Load(sender, e);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();

            }

            else 
                MessageBox.Show("İlanın türünü seçmediniz!", "Hata", MessageBoxButtons.OK);



          


            foreach (int i in checkedListBox1.CheckedIndices)
            {
                checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);
            }

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                EvSil();
                MessageBox.Show("İlan Silindi!", "Bilgilendirme", MessageBoxButtons.OK);
                dataGridView1.Refresh();
                Form1_Load(sender, e);
                textBox1.Clear();
            }

            else
                MessageBox.Show("Silenecek ilana ait Ev ID'si girmediniz!", "Hata",MessageBoxButtons.OK);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (checkedListBox1.SelectedIndex == 0)
            {

                KiraİlanGuncelle();
                MessageBox.Show("İlan Güncellendi.", "Bilgilendirme", MessageBoxButtons.OK);
                dataGridView1.Refresh();
                dataGridView2.Refresh();
                Form1_Load(sender, e);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
            }

            else if (checkedListBox1.SelectedIndex == 1)
            {

                SatilikİlanGuncelle();
                MessageBox.Show("İlan Güncellendi.", "Bilgilendirme", MessageBoxButtons.OK);
                dataGridView1.Refresh();
                dataGridView2.Refresh();
                Form1_Load(sender, e);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();

            }
            else
                MessageBox.Show("Eksik bilgi girildi. Lütfen bilgileri kontrol ediniz.", "Hata", MessageBoxButtons.OK);

            foreach (int i in checkedListBox1.CheckedIndices)
            {
                checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);
            }


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
