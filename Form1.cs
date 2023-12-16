using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace AuctionSystem
{
    public partial class Form1 : Form
    {
        SqlConnection con;

        public Form1()
        {
            InitializeComponent();
            con  = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Muhammad Masood\\Downloads\\AuctionSystem\\AuctionSystem\\Database.mdf\";Integrated Security=True");

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (signupValidation())
            {
                MessageBox.Show("SignUp Successfull");
            }
        }

        private bool signupValidation()
        {
            errorProvider1.Clear();
            errorProvider2.Clear();
            errorProvider3.Clear();
            bool isValid = true;
            var textboxes = new[] { nameV, emailV, passV };
            var errorProviders = new[] { errorProvider1, errorProvider2, errorProvider3 };
            var patternMatches = new[] {
                Regex.IsMatch(nameV.Text, @"^[a-zA-Z ]+$"),
                Regex.IsMatch(emailV.Text, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"),
                Regex.IsMatch(passV.Text, @"^[a-zA-Z0-9 ._$@]+$"),
            };
            try
            {
                for (int i = 0; i < textboxes.Length; i++)
                {
                    if (string.IsNullOrEmpty(textboxes[i].Text))
                    {
                        errorProviders[i].SetError(textboxes[i], "Field cannot be empty");
                        isValid = false;
                    }
                    else if (!patternMatches[i])
                    {
                        errorProviders[i].SetError(textboxes[i], "Invalid format");
                        isValid = false;
                    }
                    else
                    {
                        errorProviders[i].Clear();
                        try
                        {
                            con.Open();
                            string query = "insert into Users values ('""')";
                            SqlCommand cmd = new SqlCommand(query, con);
                        }
                        catch 
                        {
                            MessageBox.Show("error");
                        }
                        finally
                        {
                            con.Close();
                        }
                    }
                }
            }
            catch (Exception) {

            }

            return isValid;
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog img = new OpenFileDialog();
            if(img.ShowDialog()  == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(img.FileName);
            }
           
        }
    }
}
