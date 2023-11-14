using InterfaceAbstrackDemo.Abstract;
using InterfaceAbstrackDemo.Entities;
using InterfaceAbstrackDemo.MernisServiceReference;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InterfaceAbstrackDemo.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(); 
            return client.TCKimlikNoDogrula(Convert.ToInt64(customer.NationalityId), customer.FirstName.ToUpper(),
                customer.LastName.ToUpper(), customer.DateOfBirth.Year);
        }
    }
}
