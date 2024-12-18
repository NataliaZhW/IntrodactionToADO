using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;


namespace Liibrary2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Library.connectionString);
            //Library.Insert("Authors", "author_id,last_name,first_name" ,"10, 'Mazin','Alexsandr'");//
            Library.Select("Authors", "author_id,last_name,first_name" );//,"10, 'Mazin','Alexsandr'"
            //Library.Insert("Books", "book_id,book_title,book_size,publish_year,author", "6,'Vicings',950,'10.10.2010',10");
            Library.Select("Books", "book_id,book_title,book_size,publish_year,author");
            //Library.Select("author_id,first_name,last_name", "Authors");
            //Library.Select("book_title,publish_date,[Author] = first_name+' '+last_name",
                 //"Books,Authors", "author=author_id",32);
        }
    }
}
