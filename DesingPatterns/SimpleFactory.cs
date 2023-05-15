using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational
{
    internal class SimpleFactory
    {
    }

    // Define a simple product class hierarchy
    public abstract class Product
    {
        public abstract void Use();
    }

    public class ProductA : Product
    {
        public override void Use()
        {
            Console.WriteLine("Using product A...");
        }
    }

    public class ProductB : Product
    {
        public override void Use()
        {
            Console.WriteLine("Using product B...");
        }
    }

    // Define a simple factory class
    public class ProductFactory
    {
        public Product CreateProduct(string productType)
        {
            //if we have separate models for products
            switch (productType)
            {
                case "A":
                    return new ProductA();
                case "B":
                    return new ProductB();
                default:
                    throw new ArgumentException("Invalid product type.");
            }
        }
    }
}


//It defines a factory class that has a method for creating objects based on a given type or set of parameters.


