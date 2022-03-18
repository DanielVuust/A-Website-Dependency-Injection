using A_Website_Dependency_Injection.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace A_Website_Dependency_Injection.Requsters
{
    public class RequestWebData : RequestManager, IWebResponseReader
    {
        public override string GetData(string path)
        {
            WebRequest request = WebRequest.Create("https://docs.microsoft.com");
            // If required by the server, set the credentials.
            request.Credentials = CredentialCache.DefaultCredentials;

            // Get the response.
            WebResponse response = request.GetResponse();
            return this.ReadWebResponse(response);
        }

        public string ReadWebResponse(WebResponse webResponse)
        {
            string responseFromServer = null;
            using (Stream dataStream = webResponse.GetResponseStream())
            {
                // Open the stream using a StreamReader for easy access.
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.
                responseFromServer = reader.ReadToEnd();
                // Display the content.
                Console.WriteLine(responseFromServer);
            }
            webResponse.Close();
            return responseFromServer;
        }
    }
}
