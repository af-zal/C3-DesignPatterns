using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational
{
    internal class AbstractFactory
    {
    }

    // Define abstract product interfaces
    public interface IProductA
    {
        void Use();
    }

    public interface IProductB
    {
        void Use();
    }

    // Define concrete product classes
    public class ProductA1 : IProductA
    {
        public void Use()
        {
            Console.WriteLine("Using ProductA1...");
        }
    }

    public class ProductA2 : IProductA
    {
        public void Use()
        {
            Console.WriteLine("Using ProductA2...");
        }
    }

    public class ProductB1 : IProductB
    {
        public void Use()
        {
            Console.WriteLine("Using ProductB1...");
        }
    }

    public class ProductB2 : IProductB
    {
        public void Use()
        {
            Console.WriteLine("Using ProductB2...");
        }
    }

    // Define abstract factory interface
    public interface IFactory
    {
        IProductA CreateProductA();
        IProductB CreateProductB();
    }

    // Define concrete factory classes
    public class Factory1 : IFactory
    {
        public IProductA CreateProductA()
        {
            return new ProductA1();
        }

        public IProductB CreateProductB()
        {
            return new ProductB1();
        }
    }

    public class Factory2 : IFactory
    {
        public IProductA CreateProductA()
        {
            return new ProductA2();
        }

        public IProductB CreateProductB()
        {
            return new ProductB2();
        }
    }


}


//provides an interface for creating families of related or dependent objects without specifying their concrete classes. It allows clients to create objects of 
//one or more families of related objects without coupling them to the concrete classes that implement those objects.
//It helps to create objects of different types that belong to the same family or group.