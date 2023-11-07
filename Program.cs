//Carl Fransson .Net23
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace Labb8___OOP_Generic_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Skapar fem olika objekt av klassen Employee
            Employee E1 = new Employee()
            {
                Id = 1,
                Name = "Calle",
                Gender = "Male",
                Salary = 45000
            };
            Employee E2 = new Employee()
            {
                Id = 2,
                Name = "Alice",
                Gender = "Female",
                Salary = 70000
            };
            Employee E3 = new Employee()
            {
                Id = 3,
                Name = "David",
                Gender = "Male",
                Salary = 25000
            };
            Employee E4 = new Employee()
            {
                Id = 4,
                Name = "Sara",
                Gender = "Female",
                Salary = 50000
            };
            Employee E5 = new Employee()
            {
                Id = 5,
                Name = "Erik",
                Gender = "Male",
                Salary = 65000
            };

            //Skapar en stack och lägger till de objekten i stacken
            Stack<Employee> myStack = new Stack<Employee>();
            myStack.Push(E1);
            myStack.Push(E2);
            myStack.Push(E3);
            myStack.Push(E4);
            myStack.Push(E5);

            Console.WriteLine("Skriver ut alla objekt i stacken");
            Console.WriteLine("===============================================");

            foreach (Employee items in myStack) // Skriver ut alla objekt i stacken
            {
                Console.WriteLine("ID: {0} Name: {1} Gender: {2} Salary: {3}", items.Id, items.Name, items.Gender, items.Salary);
                Console.WriteLine("Antal objekt i stacken: {0}", myStack.Count()); //Räknar antalet i stacken för varje objekt som skrivs ut
            }
            Console.WriteLine("===============================================");

            Console.WriteLine("Raderar de senaste inlagda objektet i stacken");
           
            while(myStack.Count() > 0) // Loopen körs så länge stacken är högre än 0 och minskar för varje gång metoden pop körs
            {
                Employee stackRemove = myStack.Pop();
                Console.WriteLine("ID: {0} Name: {1} Gender: {2} Salary: {3}", stackRemove.Id, stackRemove.Name, stackRemove.Gender, stackRemove.Salary);
                Console.WriteLine("Antal objekt i stacken: {0}", myStack.Count());
            }
            myStack.Push(E1);
            myStack.Push(E2);
            myStack.Push(E3);
            myStack.Push(E4);
            myStack.Push(E5);

            Console.WriteLine("==============================================="); 
            Console.WriteLine("Hämtar objektet som är högst upp i stacken");
            Employee firstEmployee = myStack.Peek(); // använder Peek metoden för att hämta objektet som ligger överst i stacken
            Console.WriteLine("ID:{0} Name: {1} Gender: {2} Salary: {3}",firstEmployee.Id,firstEmployee.Name,firstEmployee.Gender,firstEmployee.Salary);
            Console.WriteLine("===============================================");
            if (myStack.Contains(E3)) // Kollar med metoden Contains om objektet finns i stacken
            {
                Console.WriteLine("Ja {0} finns i stacken",E3.Name);
            }
            else // om inte objektet skulle finnas i stacken
            {
                Console.WriteLine("Nej {0} finns inte i stacken",E3.Name);
            }
            Console.WriteLine("===============================================");
            List<Employee> employees = new List<Employee> //skapar en lista och lägger till objekten ovan i listan
            {
                E1,E2,E3,E4,E5
            };

            if (employees.Contains(E2)) //kollar med metoden contains om objektet finns i listan
            {
                Console.WriteLine("Ja {0} finns i listan",E2.Name);
            }
            else // om objektet inte finns i listan
            {
                Console.WriteLine("Nej {0} finns inte med i listan",E2.Name);
            }
            Console.WriteLine("===============================================");
           
            Employee? maleEmployee = employees.Find(employee => employee.Gender == "Male"); // använder metoden Find för att söka igenom listan och hitta det första objektet som matchar villkoret "Male"

            if (maleEmployee != null) // om det finns en manlig anställd
            {
                Console.WriteLine("Första manliga anställda:");
                Console.WriteLine("ID: {0}, Name: {1}, Gender: {2}, Salary: {3}", maleEmployee.Id, maleEmployee.Name, maleEmployee.Gender, maleEmployee.Salary);
            }
            else // om ingen manlig anställd hittades
            {
                Console.WriteLine("Ingen manlig anställd hittades i listan.");
            }
            Console.WriteLine("===============================================");
            List<Employee> allMaleEmployees = employees.FindAll(employee => employee.Gender == "Male"); // använder metoden FindAll för att hitta alla objekt som matchar med villkoret "Male"
            Console.WriteLine("Alla manliga anställda:");
            if(allMaleEmployees != null) // om det finns manliga anställda
            {
                foreach (Employee employee in allMaleEmployees) // skriver ut alla manliga anställda i listan
                {
                    Console.WriteLine("ID: {0}, Name: {1}, Gender: {2}, Salary: {3}", employee.Id, employee.Name, employee.Gender, employee.Salary);
                }
            }
            else // Om inte finns några mannliga anställda
            {
                Console.WriteLine("Inga manliga anställda hittades i listan.");
            }
        }
    }
}