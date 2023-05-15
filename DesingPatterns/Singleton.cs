using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational
{
    //The singleton class, which has a private constructor and a static instance variable

    public sealed class Logger
    {
        private static Logger instance = null;
        private Logger() { }

        public static Logger Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Logger();
                }
                return instance;
            }
        }

        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }

    //The client code that uses the singleton logger
    class Client
    {
        public void Run()
        {
            // Get the singleton logger instance
            Logger logger = Logger.Instance;

            // Log some messages
            logger.Log("Message 1");
            logger.Log("Message 2");
            logger.Log("Message 3");
        }
    }
}


//ensures that a class has only one instance, and provides a global point of access to that instance.

//declare a constructor that should be private and parameterless - restrict the class to be instantiated from outside the class
//class should be declared as sealed - cannot be inherited
//create a private static variable that is going to hold a reference to the singleton instance of the class.
//create a public static property/method which will return the singleton instance of the class


