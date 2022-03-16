using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace A_Website_Dependency_Injection.Interfaces
{
    interface IWebRequest
    {
        void CreateWebRequest(string url);
        void AddWebCredentials();
        Stream GetWebRequestResponse();


    }
}
