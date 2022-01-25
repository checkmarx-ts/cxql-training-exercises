using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigFilesManyLanguages
{
    class SqlInjectionWithSwitch
    {
        static void EntryPoint()
        {
            String a = Console.ReadLine();
            doSomethingAwesome(true, 0, 1, a);
            doSomethingAwesome(false, 2, 3, Console.ReadLine());
            fakeYouOut("Haha!", 1);
            doSomethingAwesome(true, 1, 1, a);
            doSomethingAwesome(false, 0, 10, Console.ReadLine());
        }

        static String doSomethingAwesome(Boolean flag, int x, int y, String s)
        {
            switch (x)
            {
                case 0:
                    return safeMethod(s);
                case 1:
                    return unsafeMethod(s);
                case 2:
                    return safeMethod(s + " awesome");
            }
            return "oops";
        }

        static void fakeYouOut(String s, int x)
        {
            Console.WriteLine("Just kidding.");
        }

        static String safeMethod(String something)
        {
            return "It's OK.";
        }

        static String unsafeMethod(String something)
        {
            string connectionString = @"Data Source=.\SQLEXPRESS; Initial Catalog=MyTestDb;Integrated Security=True";
            System.Data.SqlClient.SqlConnection sqlConnection1 = new System.Data.SqlClient.SqlConnection(connectionString);
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "INSERT INTO Mytable (CustomerID) VALUES (" + something + ")";
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();
            cmd.ExecuteScalar();
            sqlConnection1.Close();

            return "done.";
        }
    }
}
