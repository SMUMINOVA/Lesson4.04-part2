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
            public int[] post = {1500, 2500, 3500, 5000};
            public int[] service = {100, 200, 300, 400, 500};            
        }
    }
}
