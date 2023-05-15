using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Adapter
{
    public class ClientA //client class needs to use the class ThirdPartyAdaptee
    {
        IClientAdapter iClientAdapter;
        public ClientA(IClientAdapter adapter)
        {
            this.iClientAdapter = adapter;
        }
        public List<string> GetListOfClientItem()
        {
            return this.iClientAdapter.GetClientAdapterItem();
        }
    }
    public class ThirdPartyAdaptee //this class is not compatible with the client class(ClientA)
    {
        List<string> list;
        public ThirdPartyAdaptee() {
            list = new List<string>();
        }

        public List<string> GetThirdPartyItem()
        {
            list.Add("Laptop");
            list.Add("Mouse");
            list.Add("Keyboard"); 
            list.Add("Monitor");
            return list;
        }
        
    }

    //To bridge the gap between the client and the third-party class, we create an adapter class
    public interface IClientAdapter
    {
        List<string> GetClientAdapterItem();
    }

    public class ClientAdapter : ThirdPartyAdaptee, IClientAdapter    {
        //This method internally calls the GetThirdPartyItem method of the ThirdPartyAdaptee class and returns the list of third-party items.
        public List<string> GetClientAdapterItem()
        {
            return GetThirdPartyItem();
        }
    }

    
}

//Adapter design pattern is a structural design pattern that allows objects with incompatible interfaces to collaborate with each other.
//It converts the interface of one class into another interface that clients expect, making classes work together that otherwise would not be able to.
//the Adapter pattern allows us to use an incompatible class by creating an adapter class that acts as a bridge between the client and the incompatible class.