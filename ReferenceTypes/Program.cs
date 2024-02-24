﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            References();
            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Engin";
            person2 = person1;//değer eşitlemesi değil adres eşitlemesi yapılır
            person1.FirstName = "Derin";
            Console.WriteLine(person2.FirstName);

            Customer customer = new Customer();
            customer.FirstName = "Salih";
            customer.CreditCardNumber = "123456789";
            Employee employee = new Employee();
            employee.FirstName = "Veli";

            Person person3 = customer;

            customer.FirstName = "Ahmet";
            Console.WriteLine(person3.FirstName);
            Console.WriteLine(((Customer)person3).CreditCardNumber);

            PersonManager personManager = new PersonManager();
            personManager.Add(employee);

            Console.ReadLine();
        }

        private static void References()
        {
            //int, decimal,float,enum, boolean:value types
            int sayi1 = 10;
            int sayi2 = 20;
            sayi1 = sayi2;
            sayi2 = 100;
            Console.WriteLine("Sayı1: " + sayi1);
            Console.WriteLine("-----------------");
            //array,class,interface....:reference types 
            int[] sayilar1 = new int[] { 1, 2, 3 };
            int[] sayilar2 = new int[] { 10, 20, 30 };
            sayilar1 = sayilar2;
            sayilar2[0] = 1000;
            Console.WriteLine("Sayılar1 0. elaman: " + sayilar1[0]);
            Console.WriteLine("-----------------");
        }

        //Base class:Person
        class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        class Customer:Person
        {
            public string CreditCardNumber { get; set; }
        }

        class Employee:Person
        {
            public string EmployeeNumber { get; set; }
        }
        class PersonManager
        {
            public void Add(Person person)
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }
}