using FinalProject.Models;
using System.Collections;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace FinalProject
{
    internal class DBHandler
    {
        private static string connectionQuery = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\themohsen\Documents\C-Sharp\FinalProject\FinalProject\Database1.mdf;Integrated Security=True";

        public static bool ExecuteNonQuery(string query)
        {
            int i = 0;
            try
            {
                SqlConnection conn = new SqlConnection(connectionQuery);
                conn.Open();

                SqlCommand command = new SqlCommand(query, conn);

                i = command.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception ex) {}

            return (i > 0);
        }

        
        public static ArrayList GetAdmins()
        {
            ArrayList data = new ArrayList();
            try
            {
                SqlConnection conn = new SqlConnection(connectionQuery);
                conn.Open();

                string query = "SELECT username FROM Admin WHERE is_superuser=1";

                SqlCommand command = new SqlCommand(query, conn);
                var reader = command.ExecuteReader();


                while (reader.Read())
                {
                    data.Add(new AppUser(reader["username"].ToString()));
                }

                conn.Close();
            }
            catch (Exception ex) {}

            return data;
        }

        public static AppUser CheckAdmin(string password)
        {
            AppUser admin = null;
            try
            {
                string hashedPassword = HashPassword(password);

                SqlConnection conn = new SqlConnection(connectionQuery);
                conn.Open();

                string query = $"SELECT username FROM Admin WHERE password='{hashedPassword}' AND is_superuser=1";

                SqlCommand command = new SqlCommand(query, conn);
                var reader = command.ExecuteReader();


                while (reader.Read())
                {
                    admin = new AppUser(reader["username"].ToString());
                }

                conn.Close();
            }
            catch (Exception ex) {}

            return admin;
        }
        public static string HashPassword(string password)
        {

            SHA256 sha256 = SHA256.Create();
            var byteValue = Encoding.UTF8.GetBytes(password);
            var byteHash = sha256.ComputeHash(byteValue);

            return Convert.ToBase64String(byteHash);
        }

        public static ArrayList GetMembers()
        {
            ArrayList members = new ArrayList();

            try
            {
                SqlConnection conn = new SqlConnection(connectionQuery);
                conn.Open();

                string query = "SELECT * FROM Member";

                SqlCommand command = new SqlCommand(query, conn);
                var reader = command.ExecuteReader();


                while (reader.Read())
                {
                    members.Add(new MemberModel(
                        reader["id"].ToString(),
                        reader["fullname"].ToString(),
                        reader["registered_at"].ToString(),
                        reader["phone"].ToString(),
                        reader["paid"].ToString(),
                        reader["age"].ToString()
                    ));
                }

                conn.Close();
            }
            catch (Exception ex) { }

            return members;
        }

    }
}
