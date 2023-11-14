using InterfaceAbstrackDemo.Abstract;
using InterfaceAbstrackDemo.Adapters;
using InterfaceAbstrackDemo.Concrate;
using InterfaceAbstrackDemo.Entities;

namespace InterfaceAbstrackDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
           BaseCustomerManager customerManager = new StarbucksCustomerManager(new CustomerCheckManager());
            customerManager.Save(new Customer { DateOfBirth = new DateTime(1985, 1, 6), FirstName = "Engin", LastName = "Demiroğ", NationalityId = ""});
            Console.ReadLine();
        }
    }
   
}