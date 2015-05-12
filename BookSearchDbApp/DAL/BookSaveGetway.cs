using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookSearchDbApp.Model;

namespace BookSearchDbApp.DAL
{
    class BookSaveGetway
    {
        string connectionString = ConfigurationManager.ConnectionStrings["UniversityConString"].ConnectionString;
        public int insert(BookSave bookSave)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "INSERT INTO Salary_Table VALUES ('" + BookSave.name + "','" + BookSave.isbn + "','" + BookSave.author + "')";

            SqlCommand aCommand = new SqlCommand(query, connection);
            connection.Open();

            int rowAffect = aCommand.ExecuteNonQuery();
            connection.Close();

            return rowAffect;
    }
}
