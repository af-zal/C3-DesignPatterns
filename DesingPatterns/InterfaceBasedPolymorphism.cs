using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns
{
    internal class InterfaceBasedPolymorphism
    {
    }

    // Define an interface for a shape
    public interface IShape
    {
        void Draw();
    }

    // Define a concrete implementation of the interface for a rectangle
    public class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a rectangle...");
        }
    }

    // Define a concrete implementation of the interface for a circle
    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a circle...");
        }
    }

    // Define a method that takes an IShape parameter and calls its Draw method
    //public void DrawShape(IShape shape)
    //{
    //    shape.Draw();
    //}

    //// Client code
    //IShape rectangle = new Rectangle();
    //IShape circle = new Circle();

    //DrawShape(rectangle); // Output: "Drawing a rectangle..."
    //DrawShape(circle); // Output: "Drawing a circle..."

}


//objects are treated based on their interface type rather than their concrete type