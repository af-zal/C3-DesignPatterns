using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational
{
    public interface IUser
    {
        string Name { get; }
        int Age { get; }
        string Address { get; }
    }
    public class User : IUser
    {
        private string name;
        private int age;
        private string address;

        public string Name { get { return name; } }
        public int Age { get { return age; } }
        public string Address { get { return address; } }

        private User() { }

        public class UserBuilder
        {
            //child class - has access to private properties
            //responsibility - build objects
            private User user;

            public UserBuilder()
            {
                user = new User();
            }

            //user object can be build with only name or age or address
            public UserBuilder WithName(string name) { 
                user.name = name;
                return this;
            }
            public UserBuilder WithAge(int age)
            {
                user.age = age;
                return this;
            }
            public UserBuilder WithAddress(string address)
            {
                user.address = address;
                return this;
            }

            //return user object
            public User Build()
            {
                return user;
            }
        }
    }
}



//the Factory pattern is used to create objects with a common interface, while the Builder pattern is used to create complex objects with
//multiple parts, allowing you to construct them step by step with different representations.
//provides a way to build the object by providing a series of methods that allow you to set its properties or attributes

