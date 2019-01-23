using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetFrameworkChecker.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var versionChecker = new VersionChecker();
            Console.WriteLine(versionChecker.GetVersionDetails());
            Console.ReadKey();
        }
    }
}
