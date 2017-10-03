using System;
using System.ServiceModel;
using ServiceReference;

namespace ClassLibrary
{
    public class Class1
    {
        ServiceReference.ServiceClient client = new ServiceReference.ServiceClient();
        
        public int GetLength(string path)
        {
            return (int)client.GetStreamAsync(path).Result.Length;
        }

    }
}
