using A_Website_Dependency_Injection.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace A_Website_Dependency_Injection
{
    public abstract class BaseRequest : IReadDataStream
    {
        public BaseRequest()
        {
            
        }
        public abstract bool ValidateInput();
        public string ReadDataStream(Stream dataStream)
        {
            
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();
            // Display the content.
            Console.WriteLine(responseFromServer);

            return responseFromServer;
        }
    }
}
