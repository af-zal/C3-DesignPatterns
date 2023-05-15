using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.Structural
{
    // Component
    public abstract class CompanyEntity
    //defines the basic operations that both Employee and Department classes will implement
    {
        protected string name;

        public CompanyEntity(string name)
        {
            this.name = name;
        }

        public abstract void Display();
    }

    // Leaf - represents the end nodes of the tree structure
    public class Employee : CompanyEntity
    {
        public Employee(string name) : base(name)
        {
        }

        public override void Display()
        {
            Console.WriteLine(name);
        }
    }

    // Composite - represents the nodes that can have child nodes.
    public class Department : CompanyEntity
    {
        private List<CompanyEntity> entities = new List<CompanyEntity>();

        public Department(string name) : base(name)
        {
        }

        public override void Display()
        {
            Console.WriteLine(name);

            foreach (CompanyEntity entity in entities)
            {
                entity.Display();
            }
        }

        public void Add(CompanyEntity entity)
        {
            entities.Add(entity);
        }

        public void Remove(CompanyEntity entity)
        {
            entities.Remove(entity);
        }
    }
}


//The Composite design pattern is a structural pattern that allows you to treat individual objects and
//groups of objects uniformly. It enables you to create a hierarchical structure of objects,
//where each object can have one or more child objects. The pattern is useful when you want
//to work with objects in a tree-like structure.


