using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();

            

            customerManager.Id = 1;
            customerManager.Name = "Müşteri 1";
            customerManager.Add(customerManager);
            customerManager.Payment();
           
           

            EmployeeManager employeeManager = new EmployeeManager();

            employeeManager.Id = 1;

            employeeManager.Pay();

            Console.ReadLine();
        }

    }
}
