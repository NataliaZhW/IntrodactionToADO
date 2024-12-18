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
        public static void Select(string tables, string fields, string condition = "", int padding = 20)
        {
            Console.WriteLine("\n===========================2");
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
                Console.WriteLine("\n-------------------------1");
                while (reader.Read())
                {
                    for (int j = 0; j < reader.FieldCount; j++)
                    {
                        Console.Write(reader[j].ToString().PadRight(padding).Remove(padding - 1)); //   // + "\t\t"                   
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("===========================2\n");

            }
            reader.Close();
            connection.Close();
        }

        public static void Insert(string table, string fields, string values)
        {
            Console.WriteLine("\n===========================2");
            string cmd = $"INSERT {table}({fields}) VALUES ({values});";
            SqlCommand command = new SqlCommand(cmd, connection);
            connection.Open();
            command.ExecuteNonQuery();
            Console.WriteLine("===========================2\n");

            connection.Close();
        }


        public static void InsertParam(string table, string fields, string values)//, string passvord
        {
            Console.WriteLine("\n===========================2");
            string cmd = $"INSERT @table(@fields) VALUES (@values);";
            //SqlCommand command = new SqlCommand(cmd, connection);
            //connection.Open();
            //command.ExecuteNonQuery();
            Console.WriteLine("===========================2\n");

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
        }
    }
}
