using A_Website_Dependency_Injection.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace A_Website_Dependency_Injection.Requsters
{
    public abstract class RequestManager : IGetData
    {

        public abstract string GetData(string path);

    }
}
