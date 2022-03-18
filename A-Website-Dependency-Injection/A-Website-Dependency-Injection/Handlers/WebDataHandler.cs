using A_Website_Dependency_Injection.Interfaces;
using A_Website_Dependency_Injection.Requsters;
using System;
using System.Collections.Generic;
using System.Text;

namespace A_Website_Dependency_Injection.Handlers
{
    public class WebDataHandler : DataHandler
    {
        public override string GetData(string url)
        {
            if (!this.ValidateInput(url))
                return null;

            IGetData getData = new RequestWebData();
            return getData.GetData(url);
        }
        //Validations can be added here, for now we will asume the input is valid, thus always returning true.
        protected override bool ValidateInput(string url)
        {
            return true;
        }
    }
}
