using InterfaceAbstrackDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstrackDemo.Abstract
{
    public interface ICustomerService
    {

        void Save(Customer customer);   
    }
}
