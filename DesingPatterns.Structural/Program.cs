using DesignPatterns.Creational.Adapter;
using DesingPatterns.Structural;
using System.Collections.Generic;
using System.IO;

public class Demo
{
    static void Main(string[] args)
    {
        //Adapter
        IClientAdapter iClientAdapter = new ClientAdapter();
        ClientA obj = new ClientA(iClientAdapter);
        List<string> list = obj.GetListOfClientItem();
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

        //Bridge





        //Composite
        // Create a hierarchy
        Department salesDepartment = new Department("Sales Department");
        salesDepartment.Add(new Employee("John"));
        salesDepartment.Add(new Employee("Mike"));

        Department marketingDepartment = new Department("Marketing Department");
        marketingDepartment.Add(new Employee("Sarah"));
        marketingDepartment.Add(new Employee("Jane"));

        Department engineeringDepartment = new Department("Engineering Department");
        engineeringDepartment.Add(new Employee("Tom"));
        engineeringDepartment.Add(new Employee("Peter"));

        Department headDepartment = new Department("Head Department");
        headDepartment.Add(salesDepartment);
        headDepartment.Add(marketingDepartment);
        headDepartment.Add(engineeringDepartment);

        // Display hierarchy
        headDepartment.Display();


        //Decorator
        CarDealership carDealership = new CarDealership();
        carDealership.Main();

        Console.ReadLine();
    }
}
