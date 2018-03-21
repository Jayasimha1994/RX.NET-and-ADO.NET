using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RXproject
{
    class CreateADO
    {
        static void Main(string[] args)
        {
            try
            {
                string query = "create table person(p_id int, p_name nchar(10))";
                Console.WriteLine(query);
                string cs = @"Data Source=.\JAYASIMHASQL;Initial Catalog=con1;User ID=sa;Password=123";
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                Console.WriteLine("established connection ");
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                Console.WriteLine("table created");
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.ReadLine();
        }
    }
}
