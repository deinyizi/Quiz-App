using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Quiz.Model;

namespace Quiz
{
    class DBHelper
    {
        private static String connStr = "Server=(local);Database=Quiz;Trusted_Connection=Yes;";
        
        public static bool userExists(String username)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@connStr);
                conn.Open();

                const String QUERY = "SELECT * FROM [User] where [Username] = @Username";

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = QUERY;

                cmd.Parameters.AddWithValue("@Username", username);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return true;
                }

                conn.Close();
            } 
            catch (SqlException ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return false;
        }

        public static bool insertUser(String username, String password, String email)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@connStr);
                conn.Open();

                const String QUERY = "INSERT INTO [User] ([Username], [Password], [email])" +
                    "VALUES (@Username, HASHBYTES('SHA2_512', @Password), @Email)";

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = QUERY;

                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@Email", email);

                int affectedRows = cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
            return true;
        }

        public static bool verifyUser(String username, String password)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@connStr);
                conn.Open();

                const String QUERY = "SELECT * FROM [User] where [Username] = @Username" +
                    " AND [Password] = HASHBYTES('SHA2_512', @Password)";
                 
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = QUERY;

                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return true;
                }

                conn.Close();
            }
            catch (SqlException ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return false;
        }

        public static User getUser(string username, string password)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@connStr);
                conn.Open();

                const String QUERY = "SELECT * FROM [User] where [Username] = @Username" +
                    " AND [Password] = HASHBYTES('SHA2_512', @Password)";

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = QUERY;

                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    return new User(reader.GetInt32(0), reader.GetString(1), reader.GetString(2),
                        reader.GetString(3));
                }

                conn.Close();
            }
            catch (SqlException ex)
            {
                Debug.WriteLine(ex.Message);
            }

            return new User();
        }

        public static List<Question> getQuestions(string subject)
        {
            List<Question> questions = new List<Question>();
            try
            {
                SqlConnection conn = new SqlConnection(@connStr);
                conn.Open();

                const String QUERY = "SELECT * FROM [QuestionTable] WHERE subject=@Subject";

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = QUERY;

                cmd.Parameters.AddWithValue("@Subject", subject);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    questions.Add(new Question(reader.GetInt32(0), reader.GetString(1),
                        reader.GetString(2), reader.GetString(3), reader.GetString(4),
                        reader.GetString(5), reader.GetString(6), reader.GetString(7)));
                }

                conn.Close();
            }
            catch (SqlException ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return questions;
        }
    }
}
