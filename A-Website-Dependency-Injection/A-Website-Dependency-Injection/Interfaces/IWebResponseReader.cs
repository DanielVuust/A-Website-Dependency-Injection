using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace A_Website_Dependency_Injection.Interfaces
{
    public interface IWebResponseReader
    {
        string ReadWebResponse(WebResponse webResponse);
    }
}
