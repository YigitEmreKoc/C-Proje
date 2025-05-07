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


namespace Proje_deneme
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.AcceptButton = button1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.; Initial Catalog=Kafe; Integrated Security=True";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            bool boolUsername = StringComparer.Ordinal.Equals(username, "admin");

            string password = textBox2.Text;
            bool boolPassword = StringComparer.Ordinal.Equals(password, "admin");
            if (boolUsername && boolPassword)
            {
                this.Hide();
                Kafe kafe = new Kafe();
                kafe.Show();
                
            }
            else
            {
                MessageBox.Show("Başarısız Giriş, Lütfen Tekrar Deneyin !");
            }
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}