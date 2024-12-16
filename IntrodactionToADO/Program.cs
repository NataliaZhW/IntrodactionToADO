using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.Remoting.Contexts;

namespace IntrodactionToADO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = Library; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            Console.WriteLine(connectionString);
            Console.WriteLine("\n---------------------------");

            SqlConnection connection = new SqlConnection(connectionString);
            string cmd = "SELECT * FROM Authors";
            Console.WriteLine(cmd);
            SqlCommand command = new SqlCommand(cmd, connection);
            connection.Open();
            const int padding = 28;

            SqlDataReader reader = command.ExecuteReader();

            for (int i = 0; i < reader.FieldCount; i++)
            {
                Console.Write(reader.GetName(i).ToString().PadRight(padding - 1));
            }
            Console.WriteLine();

            if (!reader.IsClosed)
            {
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.Write(reader[i].ToString().PadRight(padding).Remove(padding - 1));  //   // + "\t\t"                   
                        //Console.Write(reader[i] + "\t\t");     // .ToString().PadRight(padding)                  
                    }
                    Console.WriteLine();
                }
            }

            reader.Close();
            connection.Close();
            Console.WriteLine("\n===========================\n");
            Console.WriteLine("\n===========================\n");
            command.CommandText = "SELECT book_title, first_name+' '+ last_name AS 'Author' FROM Books JOIN Authors ON (author = author_id)";

            connection.Open();
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Console.Write(reader.GetName(i).ToString().PadRight(padding - 1));
                    //Console.WriteLine("\n===========================2\n");
                }
                Console.WriteLine();
                while (reader.Read())
                {
                    for (int j = 0; j < reader.FieldCount; j++)
                    {
                        Console.Write(reader[j].ToString().PadRight(padding).Remove(padding - 1));  //   // + "\t\t"                   

                    }
                    Console.WriteLine();
                }
            }
            reader.Close();
            connection.Close();

            //string connectionString = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = Library; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            //Console.WriteLine(connectionString);
            Console.WriteLine("\n---------------------------");

            //SqlConnection connection = new SqlConnection(connectionString);



            cmd = "SELECT * FROM Books";
            Console.WriteLine(cmd);
            command = new SqlCommand(cmd, connection);

            connection.Open();
            //const int padding = 25;

            reader = command.ExecuteReader();

            for (int i = 0; i < reader.FieldCount; i++)
            {
                Console.Write(reader.GetName(i).ToString().PadRight(padding - 1));
            }
            Console.WriteLine();

            if (!reader.IsClosed)
            {
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.Write(reader[i].ToString().PadRight(padding).Remove(padding - 1));  //   // + "\t\t"                   
                    }
                    Console.WriteLine();
                }
            }
            reader.Close();
            connection.Close();


            //string connectionString = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = Library; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            //Console.WriteLine(connectionString);
            Console.WriteLine("\n---------------------------");

            //SqlConnection connection = new SqlConnection(connectionString);

            //string aut = "Scott";

            cmd = "SELECT COUNT(*) FROM Books,Authors WHERE author = author_id AND first_name = 'Jeffrey'";//(NCHAR (150)
            //cmd = "SELECT COUNT(*) FROM Books,Authors WHERE author = author_id AND first_name = 'Scott'";//(NCHAR (150)

            //cmd = "SELECT COUNT(*) FROM Authors";
            Console.WriteLine(cmd);
            command = new SqlCommand(cmd, connection);

            connection.Open();
            Int32 count = (Int32)command.ExecuteScalar();
            Console.WriteLine("Count: " + count);

            reader.Close();
            connection.Close();






            command.CommandText =
                "SELECT " +
                "first_name+' '+ last_name AS 'Author'," +
                "COUNT(book_id) AS 'Books count'" +
                " FROM Books JOIN Authors ON (author = author_id)"
                + "GROUP BY first_name,last_name"
                ;
            Console.WriteLine("\n===========================3\n");

            //"WHERE author = author_id AND first_name = 'Jeffrey'";//(NCHAR (150)  //"SELECT book_title, first_name+' '+ last_name AS 'Author' FROM Books JOIN Authors ON (author = author_id)";
            connection.Open();
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Console.Write(reader.GetName(i).ToString().PadRight(padding - 1));
                    //Console.WriteLine("\n===========================\n");
                    Console.WriteLine();
                    while (reader.Read())
                    {
                        for (int j = 0; j < reader.FieldCount; j++)
                        {
                            Console.Write(reader[j].ToString().PadRight(padding).Remove(padding - 1));  //   // + "\t\t"                   

                        }
                        Console.WriteLine();
                    }
                }
            }
            reader.Close();
            connection.Close();

        }
    }
}
