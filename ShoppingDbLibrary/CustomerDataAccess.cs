using System.Data;
using System.Runtime.InteropServices;
using Microsoft.Data.SqlClient;
using ShoppingBusinessLogicLibrary;

namespace ShoppingDbLibrary
{
    public class CustomerDataAccess
    {
        string cnString = "Data Source=CDACLAB-127;Initial Catalog=Shopping;User ID=sa;Password=123456;Trust Server Certificate=true";
        public void InsertCustomer(CustomerBusinessLogic c)
        {
            SqlConnection cn = new SqlConnection(cnString);
            SqlCommand cmd = new SqlCommand("[dbo].sp_NewCustomer1", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cn.Open();
            cmd.Parameters.AddWithValue("@p_custid", c.CustomerId);
            cmd.Parameters.AddWithValue("@p_custName", c.CustomerName);
            cmd.ExecuteNonQuery();
            cn.Close();
            cn.Dispose();


        }
        public void UpdateCustomer(int id,CustomerBusinessLogic c)
        {
            SqlConnection cn = new SqlConnection(cnString);

        }
        public void DeleteCustomer(int id)
        {
        
        }

        public List<CustomerBusinessLogic> ShowCustomerList()
        {
            SqlConnection cn = new SqlConnection(cnString);
            SqlCommand cmd = new SqlCommand("select * from Tbl_Customer", cn);
            cn.Open();
            SqlDataReader dr= cmd.ExecuteReader();
            List<CustomerBusinessLogic>custList = new List<CustomerBusinessLogic>();
            while (dr.Read())
            {
                CustomerBusinessLogic customer = new CustomerBusinessLogic();
                for (int i = 0; i < 2; i++)
                {
                    customer.CustomerId = Convert.ToInt32(dr[0]);
                    customer.CustomerName = dr[1].ToString();
                }
                custList.Add(customer);
            }
            cmd.Dispose();
            cn.Close();
            cn.Dispose();
            return custList;
        }
        //, [Optional]string name-->either id or name
        //public CustomerBusinessLogic FindCustomer(int id)
        //{

        //}
    }
}