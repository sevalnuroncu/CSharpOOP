using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        //interface newlenemez
        static void Main(string[] args)
        {
            //IPersonManager customerManager=new CustomerManager();
            //customerManager.Add();

            //IPersonManager employeeManager = new EmployeePersonManager();
            //employeeManager.Add();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new InternManager());
            Console.ReadLine();
        }
    }

    //inherits - class...................implements - interface

    interface IPersonManager
    {
        //unimplemented operation
        void Add();//imza
        void Update();
    }

    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            //müşteri ekleme kodları
            Console.WriteLine("Customer was added");
        }

        public void Update()
        {
            Console.WriteLine("Customer was updated");
        }
    }

    class EmployeePersonManager : IPersonManager
    {
        public void Add()
        {
            //personel ekleme kodları
            Console.WriteLine("Employee was added");
        }

        public void Update()
        {
            Console.WriteLine("Employee was updated");
        }
    }

    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Intern was added");
        }

        public void Update()
        {
            Console.WriteLine("Intern was updated");
        }
    }

    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {    
            personManager.Add();
        }

    }
}
