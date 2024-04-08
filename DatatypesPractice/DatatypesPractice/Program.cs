using DatatypesPractice;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Immutable;
using System.Globalization;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml.Linq;


class Program
{
    static void Main()
    {




        string[] firstNames = { "Alice", "Bob", "Charlie", "David", "Eva", "Frank", "Grace", "Henry", "Ivy", "Jack" };
        string[] lastNames = { "Smith", "Johnson", "Williams", "Jones", "Brown", "Davis", "Miller", "Wilson", "Moore", "Taylor" };

        List<Employee> employees = new List<Employee>();
        Random random = new Random();

        //for (int i = 0; i < 50; i++)
        //{
        //    StringBuilder sb = new StringBuilder();
        //    sb.Append(firstNames[random.Next(firstNames.Length)]);
        //    sb.Append(" ");
        //    sb.Append(lastNames[random.Next(lastNames.Length)]);

        //    int id = random.Next(1, 10);
        //    int depId = random.Next(1, 10000);
        //    string name = sb.ToString();
        //    string pNo = "12345" + random.Next(100000, 200000);
        //    DateTime dob = new DateTime(random.Next(1970, 2010), random.Next(1, 12), random.Next(1, 28));
        //    Currency salary = new Currency(random.Next(100000, 200000), "USD");
        //    double salary = random.Next(100000, 200000);
        //    Employee employee = new Employee(id, depId, name, pNo, dob, salary);
        //    employees.Add(employee);


        //}



        EmployeeManager employeeManager = new EmployeeManager();

        employeeManager.DeleteEmployee(50);
        // employeeManager.UpdateEmployee(12, "poojitha gowda");
        // Console.WriteLine(employeeManager.ReadEmployeeDataAt(12)); 
        var listofEmployees= employeeManager.NewGetAllEmployees();

        //foreach (var employee in employees)
        //{
        //    employeeManager.InsertEmployee(employee);
        //}

        //List<Vehicle> vehicles = new List<Vehicle>();
        //MotorCycles motorCycle1 = new MotorCycles (200,13);
        //RaceMotorCycles raceMotorCycles1 = new RaceMotorCycles(600, 60);
        //CrossMotorCycles crossMotorCycles1 = new CrossMotorCycles(400, 13);
        //Cars car1 = new Cars(450, 13);
        //MotorCycles motorCycle2 = new MotorCycles(350, 13);
        //vehicles.Add(motorCycle1);
        //vehicles.Add(motorCycle2);
        //vehicles.Add(raceMotorCycles1);
        //vehicles.Add(crossMotorCycles1);
        //vehicles.Add(car1);

        //foreach (var vehicle in vehicles)
        //{
        //    Console.WriteLine((vehicle.GetType().Name,vehicle.HorsePower,vehicle.FuelConsumption));
        //}
        //var vehicle = new Cars(380, 20);
        //vehicle.Drive(100);

        //Console.WriteLine(vehicle.Fuel);

        //Lizard lizard  = new Lizard();
        //lizard.AnimalsSound();

        //Dogs dog1 = new Dogs { Name = "Buddy", Age = 3 };
        //Dogs dog2 = new Dogs { Name = "Max", Age = 5 };
        //Cats cat1 = new Cats { Name = "Whiskers", Age = 2 };
        //Cats cat2 = new Cats { Name = "Whiskers", Age = 2 };
        //Dogs dog3 = new Dogs { Name = "Shiro", Age = 3 };
        //Dogs dog4 = new Dogs { Name = "Rio", Age = 5 };
        //Animal animal = new Animal();
        //animal.AddAnimal(dog1);
        //animal.AddAnimal(dog2);
        //animal.AddAnimal(dog3);
        //animal.AddAnimal(dog4);
        //animal.AddAnimal(cat1);
        //animal.AddAnimal(cat2);

        //animal.ToPrintAllTheAnimals();
    }
}
