using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using QuizApplikation.ViewModels;

namespace QuizApplikation.Models
{
    public class Database
    {
        // Initialiserer en instans af ProcedureNames fra CategoryViewModel, Det gør jeg så jeg ikke kaster værdien på Procedure navnet væk
        readonly ProcedureNames ProcedureNames = CategoryViewModel.procedures;
        public static Database Instance = new();
        readonly private string connectionString = "Data Source=DESKTOP-REG0P5N;Initial Catalog=QuizDB;Integrated Security=True;TrustServerCertificate=True";

        #region AllQuestionDATA
        internal List<Answers> ExtractData()
        {
            // Henter stored procedure navnet til kategorien
            string categoryProcedure = ProcedureNames.CategoryProcedure;
 
            List<Answers> Answers = new List<Answers>();

            // Laver en forbindelse til databasen ved hjælp af connectionString
            using (SqlConnection connection = new(connectionString))
            {
                // Laver en SqlCommand til at udføre den specificerede stored procedure
                using (SqlCommand command = new SqlCommand(categoryProcedure, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Åbner forbindelsen til databasen
                    connection.Open();

                    // Udfører kommandoen og læser resultaterne ved hjælp af en SqlDataReader
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Læser gennem resultaterne
                        while (reader.Read())
                        {
                            Answers ans = new
                            (
                                Question: reader["Question"].ToString(),
                                RealAnswer: reader["RealAnswer"].ToString(),
                                FalseAnswer1: reader["FalseAnswer1"].ToString(),
                                FalseAnswer2: reader["FalseAnswer2"].ToString(),
                                FalseAnswer3: reader["FalseAnswer3"].ToString(),
                                FalseAnswer4: reader["FalseAnswer4"].ToString()
                            );
                            // Tilføjer den nye Answers instans til listen
                            Answers.Add(ans);
                        }
                    }
                }
            }
            // Returnerer listen af Answers
            return Answers;
        }
        #endregion



        #region UsernameExists
        internal bool IsUsernameExists(string username)
        {
            string storedProcedureName = "GetUsernameCount";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(storedProcedureName, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;


                        command.Parameters.AddWithValue("@Username", username);

                        int count = (int)command.ExecuteScalar();

                        return count > 0;
                    }
                }
                catch (SqlException sqlEx)
                {
                    string errorDetails = $"SQL Error: {sqlEx.Message}";
                    Console.WriteLine(errorDetails);
                    return false;
                }
                catch (Exception ex)
                {
                    string errorDetails = $"Error: {ex.Message}";
                    Console.WriteLine(errorDetails);
                    return false;
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        #endregion


        #region UserDATA
        internal void InsertData(string username, string password, string firstname, string lastname)
        {
            string storedProcedureName = "InsertUser";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(storedProcedureName, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@FirstName", firstname);
                        command.Parameters.AddWithValue("@LastName", lastname);

                        int rowsAffected = command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    string errorDetails = $"Error: {ex.Message}";
                    Console.WriteLine(errorDetails);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        #endregion


        #region LoggedInFailedOrWorked
        internal bool LoginOrNot(string username, string password)
        {
            string procedureName = "CheckLogin";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(procedureName, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@inputUsername", username);
                        command.Parameters.AddWithValue("@inputPassword", password);

                        int count = (int)command.ExecuteScalar();

                        return count > 0;
                    }
                }
                catch (SqlException sqlEx)
                {
                    string errorDetails = $"SQL Error: {sqlEx.Message}";
                    Console.WriteLine(errorDetails);
                    return false;
                }
                catch (Exception ex)
                {
                    string errorDetails = $"Error: {ex.Message}";
                    Console.WriteLine(errorDetails);
                    return false;
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        #endregion
    }
}