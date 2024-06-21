
using HelperLibrary;
using ShoppingBusinessLogicLibrary;

namespace ShoppingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("1.Show Customer List \n2. Insert Customer \n3.Delete");
            CustomerDbHelper helper = new CustomerDbHelper();
            int userchoice = Convert.ToInt32(Console.ReadLine());
            switch(userchoice)
            {
                case 1:
                    
                    List<CustomerBusinessLogic> custList = helper.GetCustList();
                    foreach (var cust in custList)
                    {
                        Console.WriteLine(cust.CustomerId);
                        Console.WriteLine(cust.CustomerName);
                    }
                    break;
                case 2:
                    CustomerBusinessLogic c = new CustomerBusinessLogic();
                    Console.WriteLine("Enter Customer Id :");
                    c.CustomerId = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Name");
                    c.CustomerName=Console.ReadLine();

                    helper.InsertCustomer(c);
                    break;


            }
        }
    }
}