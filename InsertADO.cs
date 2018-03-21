using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RXproject
{
    class InsertADO
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("enter empid: ");
                int empid = Convert.ToInt32(Console.ReadLine());

                Console.Write("enter the name :");
                string name = Console.ReadLine();

                string query = "insert into person values(" +
                    empid + ", '" + name + "' )";
                Console.WriteLine(query);
                string cs = @"Data Source=.\JAYASIMHASQL;Initial Catalog=con1;User ID=sa;Password=123";
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                Console.WriteLine("established connection ");
                SqlCommand cmd = new SqlCommand(query, con);
                int result = cmd.ExecuteNonQuery();
                Console.WriteLine(result + " records inserted in emp table");

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
