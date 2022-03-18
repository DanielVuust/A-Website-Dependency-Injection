using A_Website_Dependency_Injection.Handlers;
using A_Website_Dependency_Injection.Interfaces;
using A_Website_Dependency_Injection.Requsters;
using System;

namespace A_Website_Dependency_Injection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write the url of the website you want to read");
            string url = Console.ReadLine();
            DataHandler webDataHandler = new WebDataHandler();
            Console.WriteLine(webDataHandler.GetData(url));
            Console.WriteLine("Write the path of the file you want to read");
            string path = Console.ReadLine();
            DataHandler fileDataHandler = new FileDataHandler();
            Console.WriteLine(fileDataHandler.GetData(path));

            Console.Read();
        }
    }
}
