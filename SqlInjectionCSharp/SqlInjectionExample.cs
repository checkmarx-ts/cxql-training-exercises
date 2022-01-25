// Two SQLi flows; one is a false positive, because validate() is a sanitizer
using System;
using System.Linq;

class SqlInjectionExample
{
	public static void Main(String [] args)
	{
		String id = Console.ReadLine();
		saveValue(id);
		
		String id2 = Console.ReadLine();
		id2 = validate(id2);
		saveValue(id2);
	} //end main	
	
	private static string validate(String s)
	{
		if(!s.All(char.IsDigit))
			return s;

		return (-1).ToString();
	} //end fix
	
	private static void saveValue(String s)
	{
		string connectionString = @"Data Source=.\SQLEXPRESS; Initial Catalog=MyTestDb;Integrated Security=True";
		System.Data.SqlClient.SqlConnection sqlConnection1 = new System.Data.SqlClient.SqlConnection(connectionString);
		System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
		cmd.CommandText = "INSERT INTO Mytable (CustomerID) VALUES (" + s + ")";
		cmd.Connection = sqlConnection1;

		sqlConnection1.Open();
		cmd.ExecuteScalar();
		sqlConnection1.Close();
	} //end saveValue	
} //end class E1