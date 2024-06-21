using ShoppingBusinessLogicLibrary;
using ShoppingDbLibrary;

namespace HelperLibrary
{
    public class CustomerDbHelper
    {
        CustomerDataAccess custdal = new CustomerDataAccess();
        public List<CustomerBusinessLogic> GetCustList()
        {
            
            List<CustomerBusinessLogic> custs= new List<CustomerBusinessLogic>();
            custs = custdal.ShowCustomerList();
            return custs;

        }
        public void InsertCustomer(CustomerBusinessLogic c)
        {
            custdal.InsertCustomer(c);
        }
    }
}