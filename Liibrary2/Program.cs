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
            //Library.InsertAuthor(7, "Gadge","Randy");//
            //Library.InsertAuthor(5, "Stroustrup", "Bjarn");//
            //Library.InsertAuthor(12, "Smit1","Alex");//
            //Library.InsertParam("Authors", "author_id,last_name,first_name" ,"12, 'Smit1','Alex'");//
            //Library.Insert("Books", "book_id,book_title,book_size,publish_year,author", "6,'Vicings',950,'10.10.2010',10");
            Library.InsertBook(7, "C++ Programming Language", 331, "29.01.1986", "Bjarn Stroustrup");
            //Library.Select("author_id,first_name,last_name", "Authors");
            //Library.Select("book_title,publish_date,[Author] = first_name+' '+last_name",
            //"Books,Authors", "author=author_id",32);
            //Console.WriteLine(Library.GetAuthorID("Bjarn Stroustrup")); 
            //Console.WriteLine(Library.GetAuthorID("Alexsandr Mazin"));



            Library.Select("Authors", "author_id,last_name,first_name" );//,"10, 'Mazin','Alexsandr'"
            Library.Select("Books", "book_id,book_title,book_size,publish_year,author");            
        }
    }
}
