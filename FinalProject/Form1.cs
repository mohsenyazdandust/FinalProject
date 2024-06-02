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


        public static Home home = new Home();
        public static Members membersPage = new Members();
        public static AddMember addMemberPage = new AddMember();
        public static AddMember editMemberPage = new AddMember();

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
                try
                {
                    home.Show();
                } catch (Exception ex)
                {
                    home = new Home();
                    home.Show();
                }
                home.TopMost = true;
                home.TopMost = false;
            } else
            {
                MessageBox.Show("Wrong Password!");
            }
        }
    }
}