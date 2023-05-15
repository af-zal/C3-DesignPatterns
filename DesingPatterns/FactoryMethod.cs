using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryMethod
{
    internal class FactoryMethod
    {
    }

    // Define a product interface
    public interface IProduct
    {
        void Use();
    }

    // Define concrete product classes
    public class ProductA : IProduct
    {
        public void Use()
        {
            Console.WriteLine("Using product A...");
        }
    }

    public class ProductB : IProduct
    {
        public void Use()
        {
            Console.WriteLine("Using product B...");
        }
    }

    // Define a factory interface
    public interface IProductFactory
    {
        IProduct CreateProduct();
    }

    // Define concrete factory classes
    public class ProductAFactory : IProductFactory
    {
        public IProduct CreateProduct()
        {
            //here we can have different models in a product if any
            return new ProductA();
        }
    }

    public class ProductBFactory : IProductFactory
    {
        public IProduct CreateProduct()
        {
            return new ProductB();
        }
    }

   
}

//In Simple Factory, difficult to maintain as new object types are added to the system.

//the Factory Method pattern provides an interface for creating objects, but allows subclasses to 
//decide which class to instantiate. Each product type has its own corresponding factory class that implements the factory interface, and the client code interacts only with the factory interface

