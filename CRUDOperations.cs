using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RXproject
{
    class CRUDOperations
    {
        static string cs;
        static SqlConnection con;
        static void connection()
        {
            cs = @"Data Source=.\JAYASIMHASQL;Initial Catalog=con1;User ID=sa;Password=123";
            con = new SqlConnection(cs);
            con.Open();
        }
        static void Create()
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
        }
        static void Insert()
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
        static void Update()
        {
            try
            {
                Console.WriteLine("enter the id :");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter the name :");
                string name = Console.ReadLine();
                string query = "update Person set p_name= '" + name + "'where p_id =   " + id + " ";
                Console.WriteLine(query);
                string cs = @"Data Source=.\JAYASIMHASQL;Initial Catalog=con1;User ID=sa;Password=123";
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                Console.WriteLine("established connection ");
                SqlCommand cmd = new SqlCommand(query, con);
                int result = cmd.ExecuteNonQuery();
                Console.WriteLine(result + " records updated in emp table");

                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        static void Delete()
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
        }
        static void Main(string[] args)
        {
            connection();
            Console.WriteLine("enter your query");
            string Query = Console.ReadLine();
            switch (Query)
            {
                case "create": Create();
                    break;
                case "insert": Insert();
                    break;
                case "update": Update();
                    break;
                case "delete": Delete();
                    break;
            }
            Console.WriteLine("Operation completed");
            Console.WriteLine("would like to continue ? Please enter yes or no");
            string str = Console.ReadLine();
            if (str == "yes")
            {
                Main(args);
            }
        }    
    }
}
