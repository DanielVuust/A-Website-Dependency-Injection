using A_Website_Dependency_Injection.Interfaces;
using A_Website_Dependency_Injection.Requsters;
using System;
using System.Collections.Generic;
using System.Text;

namespace A_Website_Dependency_Injection.Handlers
{
    public class FileDataHandler : DataHandler
    {
        public override string GetData(string path)
        {
            if (!this.ValidateInput(path))
                return null;

            IGetData getData = new RequestFileData();
            return getData.GetData(path);
        }
        //Validations can be added here, for now we will asume the input is valid, thus always returning true.
        protected override bool ValidateInput(string path)
        {
            return true;
        }
    }
}
