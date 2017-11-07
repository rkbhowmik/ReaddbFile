using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeDatabase
{
	class Program
	{
		static void Main(string[] args)
		{
			SQLiteConnection cn = new SQLiteConnection(@"Data Source=C:\Users\Studerande\Downloads\sqlitestudio-3.1.1\SQLiteStudio\Recept.db");
			cn.Open();
			var cmd = cn.CreateCommand();
			cmd.CommandText = "SELECT recipe_name FROM Maträtter";
			var reader = cmd.ExecuteReader();
			while (reader.Read())
			{
				Console.WriteLine(reader.GetString(0));
			}
			cn.Close();
			Console.ReadKey();
		}
	}
}
