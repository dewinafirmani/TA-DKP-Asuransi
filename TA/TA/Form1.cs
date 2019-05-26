using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e) { }
               
        class asuransi //kelas objek atau setter getter
        {
            private string Nama; //deklarasi atribut


            public void setNama(string val) //method set atribut
            {
                this.Nama = val; //menentukan nilai atribut
            }
            public string getNama() //method get atribut
            {
                return Nama; //mendapatkan nilai atribut dan mengembalikan ke fungsi yang memanggilnya
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int pilihan;
            int jenis = 0;
            int total = 0;
            int tingkat = 0;
           
            pilihan = comboBox1.SelectedIndex;
            if (comboBox1.SelectedIndex == 0)
            {
                jenis = 150000;
                tingkat = comboBox2.SelectedIndex + 1;
                total = jenis * tingkat;

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                jenis = 100000;
                tingkat = comboBox2.SelectedIndex + 1;
                total = jenis * tingkat;

            }
            else if (comboBox1.SelectedIndex == 2)
            {
                jenis = 125000;
                tingkat = comboBox2.SelectedIndex + 1;
                total = jenis * tingkat;
            }
    
                textBox4.Text = "Member :" + textBox2.Text + Environment.NewLine + "No Asuransi : " + textBox3.Text + Environment.NewLine + ("Total pembayaran yang harus dibayar Rp " + total); 
        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
            
        private void button1_Click(object sender, EventArgs e)
        {
             {
                textBox2.Text=String.Empty;
                textBox3.Text = String.Empty;
                comboBox1.Items.Clear();
                comboBox2.Items.Clear();
                textBox4.Text = String.Empty;
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda ingin keluar aplikasi ?","Konfirmasi",MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}

