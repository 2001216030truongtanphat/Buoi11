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

namespace QLSinhVien
{
    public partial class QLSinhVien : Form
    {
        SqlConnection con;
        string conStr = "Data Source = A209PC47; Initial Catalog= QLSinhVien; Integrated Security = True";
        public QLSinhVien()
        {
            InitializeComponent();
            con = new SqlConnection(conStr);
        }
        private void Form1_Load(object sender, EventArgs e)
        { 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string insertStr;
                insertStr = "INSERT INTO Khoa VALUES ('" + textBox1.Text + "', N'" + textBox2.Text + "')";
                SqlCommand cmd = new SqlCommand(insertStr, con);
                cmd.ExecuteNonQuery();
                if (con.State == ConnectionState.Open)
                    con.Close();
                MessageBox.Show("Thanh cong");
            }
            catch(Exception ex)
            {
                MessageBox.Show("That bai");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string delStr;
                delStr = "delete Khoa where MaKhoa = '" + textBox1.Text + "'";
                SqlCommand cmd = new SqlCommand(delStr, con);
                cmd.ExecuteNonQuery();
                if (con.State == ConnectionState.Open)
                    con.Close();
                MessageBox.Show("Thanh cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show("That bai");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string updateStr;
                updateStr = "update Khoa set TenKhoa = N'" + textBox2.Text + "'Where MaKhoa = '" + textBox1.Text + "'";
                SqlCommand cmd = new SqlCommand(updateStr, con);
                cmd.ExecuteNonQuery();
                if (con.State == ConnectionState.Open)
                    con.Close();
                MessageBox.Show("Thanh cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show("That bai");
            }
        }

        
    }
}
