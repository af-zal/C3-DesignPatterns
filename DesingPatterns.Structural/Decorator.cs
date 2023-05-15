using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.Structural
{
    // Component
    public abstract class Car
    {
        protected string description = "Unknown car";

        public virtual string GetDescription()
        {
            return description;
        }

        public abstract int GetCost();
    }

    // Concrete Component
    public class BasicCar : Car
    {
        public BasicCar()
        {
            description = "Basic car";
        }

        public override int GetCost()
        {
            return 10000;
        }
    }

    // Decorator
    public abstract class CarDecorator : Car
    //It adds new functionalities to the Car object by modifying its behavior.
    //The concrete decorators, Sunroof, LeatherSeats
    {
        protected Car car;

        public CarDecorator(Car car)
        {
            this.car = car;
        }

        public override string GetDescription()
        {
            return car.GetDescription();
        }

        public override int GetCost()
        {
            return car.GetCost();
        }
    }

    // Concrete Decorator
    public class Sunroof : CarDecorator
    {
        public Sunroof(Car car) : base(car)
        {
        }

        public override string GetDescription()
        {
            return car.GetDescription() + ", with sunroof";
        }

        public override int GetCost()
        {
            return car.GetCost() + 1000;
        }
    }

    public class LeatherSeats : CarDecorator
    {
        public LeatherSeats(Car car) : base(car)
        {
        }

        public override string GetDescription()
        {
            return car.GetDescription() + ", with leather seats";
        }

        public override int GetCost()
        {
            return car.GetCost() + 2000;
        }
    }

    public class GPS : CarDecorator
    {
        public GPS(Car car) : base(car)
        {
        }

        public override string GetDescription()
        {
            return car.GetDescription() + ", with GPS";
        }

        public override int GetCost()
        {
            return car.GetCost() + 500;
        }
    }

    // Client
    public class CarDealership
    {
        public void Main()
        {
            // Create a basic car
            Car myCar = new BasicCar();

            // Add features to the car
            myCar = new Sunroof(myCar);
            myCar = new LeatherSeats(myCar);
            myCar = new GPS(myCar);

            // Display the car's features and cost
            Console.WriteLine("My car: " + myCar.GetDescription());
            Console.WriteLine("Cost: $" + myCar.GetCost());
        }
    }

}


//The Decorator design pattern is used to dynamically add new behaviors or responsibilities to an object,
//without modifying its original class. This pattern involves creating a decorator class that wraps around
//the original class and provides additional functionalities while maintaining the original class's interface.