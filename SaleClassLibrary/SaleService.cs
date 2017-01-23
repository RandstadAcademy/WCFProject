using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleClassLibrary
{
    class SaleService : ISaleService
    {
        public bool DeleteCustomer(int Cid)
        {
            var item = customerList.First(x => x.CustomerID == Cid);

            customerList.Remove(item);
            return true;
        }

        public List<Customer> GetAllCustomer()
        {
            return customerList;
        }

        public bool InsertCustomer(Customer obj)
        {
            customerList.Add(obj);
            return true;
        }

        public bool UpdateCustomer(Customer obj)
        {
            customerList.Where(p=> p.CustomerID == obj.CustomerID).Update(p => p.CustomerName = obj.CustomerName);
            return true;
        }


        public static List<Customer> customerList = new List<Customer>()
        {
            new Customer { CustomerID = 1, CustomerName = "Sujeet",
            Address = "Pune", EmailId = "test@yahoo.com" },
            new Customer { CustomerID = 2, CustomerName = "Rahul",
            Address = "Pune", EmailId = "test@yahoo.com" }

        };
    }

    public static class LinqUpdate
    {
        public static void Update<T>(this IEnumerable<T> source, Action<T> action)
        {
            foreach (var item in source)
                action(item);

        }

    }

}
    

    
