using DesignPatterns.Creational;
using DesignPatterns.Creational.Adapter;
using DesignPatterns.Creational.FactoryMethod;
using static DesignPatterns.Creational.User;

public class Demo
{
    static void Main(string[] args)
    {
        //Simple Factory
        ProductFactory factory = new ProductFactory();
        Product productA = factory.CreateProduct("A");
        productA.Use();
        Product productB = factory.CreateProduct("B");
        productB.Use();

        //Factory Method
        IProductFactory fact = new ProductAFactory();
        IProduct product = fact.CreateProduct();
        product.Use();

        //Abstract Factory
        IFactory factory1 = new Factory1();
        IProductA productA1 = factory1.CreateProductA();
        IProductB productB1 = factory1.CreateProductB();
        productA1.Use();
        productB1.Use();
        IFactory factory2 = new Factory2();
        IProductA productA2 = factory2.CreateProductA();
        IProductB productB2 = factory2.CreateProductB();
        productA2.Use();
        productB2.Use();

        //Builder
        IUser user= new UserBuilder().WithName("Afzal").WithAge(23).Build();
        Console.WriteLine(user.Name);
        //services.AddSingleton<IUser>(new User.UserBuilder().WithName("Afzal").Build());

        var houseBuilder = new HouseBuilder();
        var director = new Director(houseBuilder);

        director.BuildHouse();
        House house = houseBuilder.GetHouse();

        Console.WriteLine("My new house has a {0} foundation, {1} walls, {2} roof, {3} windows, and {4} doors.",
        house.Foundation, house.Walls, house.Roof, house.Windows, house.Doors);

        //Prototype
        Developer dev = new Developer();
        dev.Name = "Af";
        dev.Role = "Team Leader";
        dev.PreferredLanguage = "C#";

        Developer devCopy = (Developer)dev.Clone();
        devCopy.Name = "Hsn"; //Not mention Role and PreferredLanguage, it will copy above

        Console.WriteLine(dev.GetDetails());
        Console.WriteLine(devCopy.GetDetails());

        Typist typist = new Typist();
        typist.Name = "Vj";
        typist.Role = "Typist";
        typist.WordsPerMinute = 120;

        Typist typistCopy = (Typist)typist.Clone();
        typistCopy.Name = "Dj";
        typistCopy.WordsPerMinute = 115;//Not mention Role, it will copy above

        Console.WriteLine(typist.GetDetails());
        Console.WriteLine(typistCopy.GetDetails());

        //Singleton
        Client client = new Client();
        client.Run();

        

        Console.ReadLine();
    }
}



//Simple Factory - Factory creates the object for us without exposing the instantiation

//Factory Method - provides an interface for creating objects, but allows subclasses to determine which class to instantiate
//it defines an abstract method for creating objects and lets subclasses implement that method to create different types of objects.