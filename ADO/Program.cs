using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ADO
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//ADO - ActiveX Data Objects
			//MS SQL Server, Oracle, SQLite....
			//SQL Server Object Explorer
			string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Library;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
			Console.WriteLine(connectionString);
			Console.WriteLine("\n-----------------------------------\n");
			//////////////////////////////////////////////////////////////////////////////
			SqlConnection connection = new SqlConnection(connectionString);
			string cmd = "SELECT * FROM Authors";
			const int padding = 32;
			SqlCommand command = new SqlCommand(cmd, connection);
			connection.Open();

			SqlDataReader reader = command.ExecuteReader();

			for (int i = 0; i < reader.FieldCount; i++)
			{
				Console.Write(reader.GetName(i).PadRight(padding));
			}
			Console.WriteLine();

			if (reader.HasRows)
			{
				while (reader.Read())
				{
					for (int i = 0; i < reader.FieldCount; i++)
					{
						Console.Write(reader[i].ToString().PadRight(padding));
					}
					Console.WriteLine();
				}
			}

			reader.Close();
			connection.Close();
			Console.WriteLine("\n-----------------------------------\n");

			command.CommandText =
				"SELECT book_title,first_name+' '+last_name AS 'Author' " +
				"FROM Books JOIN Authors ON (author=author_id)";
			connection.Open();
			reader = command.ExecuteReader();
			if (reader.HasRows)
			{
				for (int i = 0; i < reader.FieldCount; i++)
					Console.Write(reader.GetName(i).PadRight(padding));
				Console.WriteLine();
				while (reader.Read())
				{
					for (int i = 0; i < reader.FieldCount; i++)
					{
						Console.Write(reader[i].ToString().PadRight(padding));
					}
					Console.WriteLine();
				}
			}
			reader.Close();
			connection.Close();
			Console.WriteLine("\n-----------------------------------\n");
			////////////////////////////////////////////////////////////////////////////

			command.CommandText =
				"SELECT first_name+' '+last_name AS 'Author', COUNT(book_id), 'Books count' " +
				"FROM Books JOIN Authors ON (author=author_id)" +
				"GROUP BY first_name,last_name";
			connection.Open();
			reader = command.ExecuteReader();
			if (reader.HasRows)
			{
				for (int i = 0; i < reader.FieldCount; i++)
					Console.Write(reader.GetName(i).PadRight(padding));
				Console.WriteLine();
				while (reader.Read())
				{
					for (int i = 0; i < reader.FieldCount; i++)
					{
						Console.Write(reader[i].ToString().PadRight(padding));
					}
					Console.WriteLine();
				}
			}
			connection.Close();
			///////////////////////////////////////////////////////////////////////////////

			//Library.InsertAuthor(7,"Gadge", "Randy")
			//Library.InsertAuthor(5,"Stroustrup", "Bjarne")
			Console.WriteLine(Library.GetAuthorID("Bjarne Stroustrup"));
			Library.InsertBook(7, "C++ Programming Language", 331, "1986-01-29", "Bjarne Stroustrup");
			Library.Select("author_id, first_name, last_name", "Authors");
			Library.Select
				(
					"book_id,book_title,publish_date,[Author] = first_name+' '+last_name",
					"Books,Authors",
					"author=author_id;DROP TABLE Genres",
					32
				);
		}
	}
}
