using System;

namespace part2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee firstEmployee = new Employee();
            System.Console.Write("Enter employee name: ");
            firstEmployee.name = Console.ReadLine();
            System.Console.Write("Enter employee surname: ");
            firstEmployee.surname = Console.ReadLine();
            System.Console.WriteLine("choose his/her position:");
            System.Console.WriteLine("1. intern\t 2. junior\n3. middle\t 4. senior");
            int choicePost = int.Parse(Console.ReadLine());
            System.Console.WriteLine("choose his/her experience:");
            System.Console.WriteLine("1. 1 year\t 2. 2 year\n3. 3 year\t 4. 4 year");
            int choiceExperience = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Information about employee:");
            System.Console.WriteLine($"Name: {firstEmployee.name}");
            System.Console.WriteLine($"Surname: {firstEmployee.surname}");
            System.Console.WriteLine($"Position: {firstEmployee.post[choicePost-1]}");
            System.Console.WriteLine($"Salary: {firstEmployee.salary(choicePost, choiceExperience)}");
            System.Console.WriteLine($"Tax: {firstEmployee.tax(firstEmployee.salary(choicePost, choiceExperience))}");
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
            public int[] postSalary = {1500, 2500, 3500, 5000};
            public string[] post = {"intern", "junior", "middle", "senior"};
            public int[] service = {200, 400, 600, 800};   
            public int salary(int cP, int cE){
                return postSalary[cP-1] + service[cE-1];
            }
            public double tax(int salary){
                return 0.14*salary;
            }
        }
    }
}
