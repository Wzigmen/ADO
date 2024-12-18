using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO
{
	internal class Library
	{

		public static void InsertAuthor(int id, string last_name, string first_name)
		{
			string cmd = "INSERT Authors(author_id, last_name, first_name) VALUES(@id, @last_name, @first_name)";
			SqlCommand command = new SqlCommand(cmd, connection);

			SqlParameter p_id = new SqlParameter("id", System.Data.SqlDbType.Int); p_id.Value = id;
			SqlParameter p_last_name = new SqlParameter("last_name", System.Data.SqlDbType.NVarChar, 150); p_last_name.Value = last_name;
			SqlParameter p_first_name = new SqlParameter("first_name", System.Data.SqlDbType.NVarChar, 150); p_last_name.Value = first_name;

			command.Parameters.Add(p_id);
			command.Parameters.Add(p_last_name);
			command.Parameters.Add(p_first_name);

			connection.Open();
			command.ExecuteNonQuery();
			connection.Close();
		}
		public static void InsertBook(int id, string title, int size, string date, string author)
		{
			string cmd =
				"INSERT Books(book_id,book_title,book_size,publish_date,author)" +
				"VALUES (@id,@title,@size,@date,@author)";
			SqlCommand command = new SqlCommand(cmd, connection);
			command.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
			command.Parameters.Add("@title", System.Data.SqlDbType.NVarChar).Value = title;
			command.Parameters.Add("@size", System.Data.SqlDbType.Int).Value = size;
			command.Parameters.Add("@date", System.Data.SqlDbType.Date).Value = date;
			command.Parameters.Add("@author", System.Data.SqlDbType.Int).Value = GetAuthorID(author);

			connection.Open();
			command.ExecuteNonQuery();
			connection.Close();
		}
		public static int GetAuthorID(string full_name)
		{
			string cmd = "SELECT author_id FROM Authors WHERE last_name AND first_name=@first_name";
			SqlCommand command = new SqlCommand(cmd, connection);
			command.Parameters.Add("@first_name", System.Data.SqlDbType.NVarChar, 150).Value = full_name.Split(' ').First();
			command.Parameters.Add("@last_nmae", System.Data.SqlDbType.NVarChar, 150).Value = full_name.Split(' ').Last();

			connection.Open();
			int id = Convert.ToInt32(command.ExecuteScalar());
			connection.Close();
			return id;
		}
	}

}
