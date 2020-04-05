using System;

namespace part2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        class Employee{
            public string name {get; set;}
            public string surname {get; set;}
            public Employee (string Name, string Surname){
                name = Name;
                surname = Surname;
            }
            public Employee(){

            }
            

        }
    }
}
