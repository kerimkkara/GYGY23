using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppHomework
{

    public abstract class Manager
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public void Add(Manager manager)
        {
            if (manager is EmployeeManager)
            {
                Console.WriteLine($"{Name} adlı çalışan eklendi");
            }
            else
            {
                Console.WriteLine($"{Name} adlı müşteri eklendi");
            }
            
     
        }

        public abstract void Delete();

    }

    public class CustomerManager : Manager, IPayment
    {
  
        public override void Delete()
        {
            Console.WriteLine("Müşteri Silindi");
        }

        public void Payment()
        { 
            Console.WriteLine($"Id değeri {Id} olan müşteriden ödeme alındı.");
        }
    }

    public class EmployeeManager : Manager , ISalary
    {

        public override void Delete()
        {
            Console.WriteLine("Çalışan Silindi");
        }
       public void Pay()
        {
            Console.WriteLine($"Id değeri {Id} olan çalışanın maaşı ödendi");
        }
    }

}
