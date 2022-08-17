using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SuperMarket
{
    internal class SuperMarketDal
    {
        internal static List<Customer> getCustomers()
        {
            string cmdstring = "SELECT * FROM Customer";
            List<Customer> list = new List<Customer>();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = cmdstring;
            cmd.Connection = DbHelper.getConnection();
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Customer x = new Customer();
                x.CustomerId = (int)dr["CustomerId"];
                x.CName = dr["CName"].ToString();
                x.CSurname = dr["CSurname"].ToString();
                x.Gsm = dr["Gsm"].ToString();
                list.Add(x);
            }
            dr.Close();
            return list;
        }
        internal static List<Order> getOrders()
        {
            List<Order> list = new List<Order>();
            string cmdstring = "select * from Orders";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = DbHelper.getConnection();
            cmd.CommandText = cmdstring;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Order x = new Order();
                x.OrderId = (int)dr["OrderId"];
                x.CustomerId = (int)dr["CustomerId"];
                x.OrderNote = dr["OrderNote"].ToString();
                x.OrderDate = (DateTime)dr["OrderDate"];
                list.Add(x);
            }
            dr.Close();
            return list;
        }
        private static void createCustomerParams(Customer x,SqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@CName", x.CName);
            cmd.Parameters.AddWithValue("@CSurname", x.CSurname);
            cmd.Parameters.AddWithValue("@Gsm",x.Gsm);
        }
        private static void createOrderParams(Order x,SqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@CustomerId", x.CustomerId);
            cmd.Parameters.AddWithValue("@OrderDate", x.OrderDate);
            cmd.Parameters.AddWithValue("@OrderNote", x.OrderNote);
        }
        internal static void add(Customer x)
        {
            string cmdstring = "INSERT INTO Customer(CName,CSurname,Gsm) values(@CName,@CSurname,@Gsm)";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = cmdstring;
            cmd.Connection = DbHelper.getConnection();
            createCustomerParams(x, cmd);
            cmd.ExecuteNonQuery();
        }
        internal static void add(Order x)
        {
            string cmdstring = "INSERT INTO Orders(CustomerId,OrderNote,OrderDate) values(@CustomerId,@OrderNote,@OrderDate)";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = cmdstring;
            cmd.Connection = DbHelper.getConnection();
            createOrderParams(x, cmd);
            cmd.ExecuteNonQuery();
        }
        internal static List<Order> getOrdersTimeFrame(DateTime x,DateTime y)
        {
            List<Order> list = new List<Order>();
            string cmdstring = $"SELECT * FROM Orders where OrderDate between @FirstDate and @SecondDate";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = DbHelper.getConnection();
            cmd.CommandText = cmdstring;
            cmd.Parameters.AddWithValue("@FirstDate",x);
            cmd.Parameters.AddWithValue("SecondDate",y);
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Order order = new Order();
                order.OrderId = (int)dr["OrderId"];
                order.CustomerId = (int)dr["CustomerId"];
                order.OrderDate = (DateTime)dr["OrderDate"];
                order.OrderNote = dr["OrderNote"].ToString();
                list.Add(order);
            }
            dr.Close();
            return list;
        }
        internal static List<Order> getOrdersByCustomer(Customer x)
        {
            List<Order> list = new List<Order>();
            string cmdstring = $"SELECT * FROM Orders where CustomerId={x.CustomerId}";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = DbHelper.getConnection();
            cmd.CommandText = cmdstring;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Order order = new Order();
                order.OrderId = (int)dr["OrderId"];
                order.CustomerId = (int)dr["CustomerId"];
                order.OrderDate = (DateTime)dr["OrderDate"];
                order.OrderNote = dr["OrderNote"].ToString();
                list.Add(order);
            }
            dr.Close();
            return list;
        }
    }
}
