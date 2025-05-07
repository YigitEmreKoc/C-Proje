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
using System.Data.OleDb;

namespace Proje_deneme
{
    public partial class StokKontrol: Form
    {

  
        public StokKontrol()
        {
            InitializeComponent();
            foreach (var yiyecek in Yiyecek)
            {
                comboBox1.Items.Add(yiyecek);
            }
            label2.Text = ("Sufle Stoğu: " + sufle.ToString());
            label3.Text = ("Sosis Stoğu: " + sosis.ToString());
            label4.Text = ("Makarna Stoğu: " + makarna.ToString());
            label7.Text = ("Tavuk Stoğu: " + tavuk.ToString());
            label8.Text = ("Su Stoğu: " + su.ToString());
            label9.Text = ("Kola Stoğu: " + kola.ToString());
            label10.Text = ("Ayran Stoğu: " + ayran.ToString());
            label11.Text = ("Gazoz Stoğu: " + gazoz.ToString());


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string secilenyiyecek = comboBox1.SelectedItem.ToString();



           

        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Kafe kafe = new Kafe();
            kafe.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
