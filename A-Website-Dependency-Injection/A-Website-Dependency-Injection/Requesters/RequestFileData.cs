using A_Website_Dependency_Injection.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace A_Website_Dependency_Injection.Requsters
{
    public class RequestFileData : RequestManager
    {
        public override string GetData(string path)
        {
            return System.IO.File.ReadAllText(path);
        }
    }

}
