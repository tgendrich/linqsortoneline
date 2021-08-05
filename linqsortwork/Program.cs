using System;
using System.Linq;
using System.Collections.Generic;
namespace linqsortwork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var videoGameNames = new List<string>() { "Duke Nukem forever", "Super Mario 64", "Crash Bandicoot", "Resident Evil" }.Where(x => x.Length > 0).OrderBy(x => x.Length).ToList();
           
            foreach(string c in videoGameNames)
                Console.WriteLine(c);
        }
    }
}
