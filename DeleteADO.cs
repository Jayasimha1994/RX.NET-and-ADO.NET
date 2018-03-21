using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RXproject
{
    class DeleteADO
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("enter the id of the record to be deleted:");
                int id = Convert.ToInt32(Console.ReadLine());
                string query = "delete from Person where p_id =   " + id + " ";
                Console.WriteLine(query);
                string cs = @"Data Source=.\JAYASIMHASQL;Initial Catalog=con1;User ID=sa;Password=123";
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                Console.WriteLine("established connection ");
                SqlCommand cmd = new SqlCommand(query, con);
                int result = cmd.ExecuteNonQuery();
                Console.WriteLine(result + " records deleted from emp table");

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
