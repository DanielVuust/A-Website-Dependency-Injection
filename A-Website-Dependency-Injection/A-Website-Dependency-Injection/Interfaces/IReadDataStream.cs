using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace A_Website_Dependency_Injection.Interfaces
{
    interface IReadDataStream
    {
        string ReadDataStream(Stream dataStream);
    }
}
