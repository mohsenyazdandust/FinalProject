using FinalProject.Models;
using Microsoft.VisualBasic.Logging;
using System.Collections;
using System.Data.SqlClient;
using System.Text;

namespace FinalProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitialUser();
        }


        Home home = new Home();

        private void InitialUser()
        {
            ArrayList admins = DBHandler.GetAdmins();

            if (admins.Count <= 0)
            {
                string hashedPassword = DBHandler.HashPassword("admin");

                string query = $"INSERT INTO Admin (password) VALUES ('{hashedPassword}')";
             
                DBHandler.ExecuteNonQuery(query);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string password = textBox1.Text.ToString();

            AppUser admin = DBHandler.CheckAdmin(password);


            if (admin != null)
            {
                home.Show();
                home.TopMost = true;
                home.TopMost = false;
                // this.Hide();
            } else
            {
                MessageBox.Show("Wrong Password!");
            }
        }
    }
}