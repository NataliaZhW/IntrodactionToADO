using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Xml.Linq;

namespace Liibrary2
{

    internal class Library
    {
        public static string connectionString = "";
        static SqlConnection connection = null;
        static Library()//public
        {
            connectionString = ConfigurationManager.ConnectionStrings["Library"].ConnectionString;
            connection = new SqlConnection(connectionString);
            Console.WriteLine(connectionString);
        }
        public static void Select(string tables, string fields, string condition = "", int padding = 26)
        {
            Console.WriteLine("\n===========================");
            string cmd = $"SELECT {fields} FROM {tables} ";
            if (condition.Length > 0) cmd += $" WHERE condition";
            cmd += ";";
            Console.WriteLine(cmd);
            SqlCommand command = new SqlCommand(cmd, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Console.Write(reader.GetName(i).ToString().PadRight(padding - 1));
                }
                //Console.WriteLine();
                Console.WriteLine("\n-------------------------");
                while (reader.Read())
                {
                    for (int j = 0; j < reader.FieldCount; j++)
                    {
                        Console.Write(reader[j].ToString().PadRight(padding).Remove(padding - 1)); //   // + "\t\t"                   
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("===========================\n");

            }
            reader.Close();
            connection.Close();
        }

        public static void Insert(string table, string fields, string values)
        {
            Console.WriteLine("\n===========================Insert");
            string cmd = $"INSERT {table}({fields}) VALUES ({values});";
            SqlCommand command = new SqlCommand(cmd, connection);
            connection.Open();
            command.ExecuteNonQuery();
            Console.WriteLine("===========================Insert\n");

            connection.Close();
        }


        public static void InsertParam(string table, string fields, string values)//, string passvord
        {
            Console.WriteLine("\n===========================InsertParam");
            string cmd = "INSERT @table(@fields) VALUES (@values);";
            //SqlCommand command = new SqlCommand(cmd, connection);
            //connection.Open();
            //command.ExecuteNonQuery();
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //await connection.OpenAsync();

                SqlCommand command = new SqlCommand();
                // определяем выполняемую команду
                command.CommandText = cmd;
                // определяем используемое подключение
                command.Connection = connection;
                // создаем параметр 
                SqlParameter nameParam = new SqlParameter("@table", table);
                // добавляем параметр к команде
                command.Parameters.Add(nameParam);
                // создаем параметр 
                SqlParameter ageParam = new SqlParameter("@fields", fields);
                // добавляем параметр к команде
                command.Parameters.Add(ageParam);
                // создаем параметр 
                SqlParameter valuesParam = new SqlParameter("@values", values);
                // добавляем параметр к команде
                command.Parameters.Add(valuesParam);

                //int number = 
                command.ExecuteNonQueryAsync();
                //Console.WriteLine($"Добавлено объектов: {number}");
            }
            connection.Close();
            Console.WriteLine("===========================InsertParam\n");
        }

        public static void InsertAuthor(int id, string last_name, string first_name)//
        {
            Console.WriteLine("\n===========================InsertAuthor");
            string cmd = "INSERT Authors(author_id, last_name, first_name) VALUES (@id, @last_name, @first_name);";
            SqlCommand command = new SqlCommand(cmd, connection);

            SqlParameter p_id = new SqlParameter("@id", SqlDbType.Int); p_id.Value = id;
            SqlParameter p_last_name = new SqlParameter("@last_name", SqlDbType.NVarChar, 150); p_last_name.Value = last_name;
            SqlParameter p_first_name = new SqlParameter("@first_name", SqlDbType.NVarChar, 150); p_first_name.Value = first_name;

            command.Parameters.Add(p_id);
            command.Parameters.Add(p_last_name);
            command.Parameters.Add(p_first_name);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            Console.WriteLine("===========================InsertAuthor\n");
        }
        public static void InsertBook(int book_id, string book_title, int book_size, string publish_year, string author)//DateTime
        {
            Console.WriteLine("===========================InsertBook\n");
            string cmd = "INSERT Books(book_id,book_title,book_size,publish_year,author) " +
                "VALUES (@book_id,@book_title,@book_size,@publish_year,@author);";
            SqlCommand command = new SqlCommand(cmd, connection);
            command.Parameters.Add("@book_id", SqlDbType.Int).Value = book_id;
            command.Parameters.Add("@book_title", SqlDbType.NVarChar, 150).Value = book_title;
            command.Parameters.Add("@book_size", SqlDbType.Int).Value = book_size;
            command.Parameters.Add("@publish_year", SqlDbType.Date).Value = publish_year;
            command.Parameters.Add("@author", SqlDbType.Int).Value = GetAuthorID(author);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            Console.WriteLine("===========================InsertBook\n");

        }
        public static int GetAuthorID(string full_name)//
        {
            string cmd = "SELECT author_id FROM Authors WHERE last_name=@last_name AND first_name=@first_name;";
            SqlCommand command = new SqlCommand(cmd, connection);
            command.Parameters.Add("@first_name", SqlDbType.NVarChar, 150).Value = full_name.Split(' ').First();
            command.Parameters.Add("@last_name", SqlDbType.NVarChar, 150).Value = full_name.Split(' ').Last();

            connection.Open();
            int id = Convert.ToInt32(command.ExecuteScalar());
            connection.Close();
            return id;
        }
    }
}
