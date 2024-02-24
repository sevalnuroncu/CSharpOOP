using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Id = 3;
            Customer customer2 = new Customer() { Id=1,FirstName="Engin",LastName="Demiroğ",City="Ankara"};

            Customer customer3 = new Customer(2, "Derin", "Demiroğ", "Ankara");
            Console.WriteLine(customer3.FirstName);
            Console.ReadLine();

        }
    }

    class Customer
    {   //default constructor
        private int v1;
        private string v2;
        private string v3;
        private string v4;

        public Customer()
        {
            Console.WriteLine("Yapıcı blok çalıştı");
        }

        public Customer(int id, string firstname, string lastname, string city)
        {
            this.Id = id;
            this.FirstName = firstname;
            this.LastName = lastname;
            this.City = city;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
