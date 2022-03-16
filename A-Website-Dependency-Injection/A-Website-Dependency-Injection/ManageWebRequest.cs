using A_Website_Dependency_Injection.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace A_Website_Dependency_Injection
{
    public abstract class ManageWebRequest : BaseRequest, IWebRequest
    {
        private WebRequest request;
        public virtual void CreateWebRequest(string url)
        {
            request = WebRequest.Create(url);
        }
        public virtual void AddWebCredentials()
        {
            request.Credentials = CredentialCache.DefaultCredentials;
        }

        public virtual Stream GetWebRequestResponse()
        {
            return request.GetResponse().GetResponseStream();
        }

    }
}
