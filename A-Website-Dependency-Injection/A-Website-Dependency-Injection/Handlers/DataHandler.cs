using A_Website_Dependency_Injection.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace A_Website_Dependency_Injection.Handlers
{
    public abstract class DataHandler
    {
        public abstract string GetData(string path);
        protected abstract bool ValidateInput(string path);
    }
}
