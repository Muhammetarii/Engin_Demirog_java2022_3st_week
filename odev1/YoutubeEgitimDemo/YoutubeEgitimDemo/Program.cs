using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeEgitimDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ioc Container
            CustomerManager customerManager = new CustomerManager(new Customer(), new TeacherCreditManager());
            customerManager.GiveCredit();

            Console.ReadLine();

        }
    }
    
    class CreditManager
    {
        public void Calculate( int CreditType)

        {
            if (CreditType==1)//Esnaf
            {

            }
            if (CreditType == 2)//Ogretmen
            {

            }
;            Console.WriteLine("Hesaplandı");
        }

        public void Save()
        {
            Console.WriteLine("Kredi verildi");
        } // Class ların temel mantığı içerisinde operasyonları(method-fonksiyon) tutan bir ortamdır diyebiliriz.
    }

    interface ICreditManager
    {
        void Calculate();
        void Save();
    }

    abstract class BaseCreditManager : ICreditManager
    {
        public abstract void Calculate();
        

        public virtual void Save()
        {
            Console.WriteLine("Kaydedildi");
        }
    }

    class TeacherCreditManager : BaseCreditManager, ICreditManager // Java da implement olarak yazılır.
    {
        public  override void Calculate()
        {
            Console.WriteLine("Öğretmen kredisi hesaplandı");
        }
        public override void Save()
        {
            base.Save();
        }


    }
    class MilitaryCreditManager : BaseCreditManager, ICreditManager
    {
        public override void Calculate()
        {
            Console.WriteLine("Asker kredisi hesaplandı");
        }

        
    }

    class CarCreditManager : BaseCreditManager, ICreditManager
    {
        public override void Calculate()
        {
            Console.WriteLine("Araba kredisi hesaplandı");
        }

    }

    //SOLID
    class Customer
    {
        public Customer()
        {
            Console.WriteLine("Müşteri nesnesi başlatıldı"); //Constructor yapıcı method olarak bilinir.
        }
        public int Id { get; set; }
        // Property yapısı C# da.Hem yazılabilir hem okunabilir.
        public string City { get; set; }
    }
    
    class Person : Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalIdentity { get; set; }
        
    }
    class Company : Customer
    {
        public string CompanyName { get; set; }
        public string TaxNumber { get; set; }
    }

    // Katmanlı mimariler için temel altyapı mantığıdır.
    class CustomerManager
    {
        private Customer _customer;
        private ICreditManager _creditManager; 
        public CustomerManager(Customer customer,ICreditManager creditManager)
        {
            _customer = customer;
            _creditManager = creditManager;
           
        }
       
        public void Save()
        {
            Console.WriteLine("Müşteri kaydedildi : ");
        }
        public void Delete()
        {
            Console.WriteLine("Müşteri silindi : ");
        }

        public void GiveCredit()
        {
            _creditManager.Calculate();
            Console.WriteLine("Kredi verildi");

        }
        
    }

}
