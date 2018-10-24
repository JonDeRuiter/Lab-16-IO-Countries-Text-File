using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IO_Countries
{
    class Program
    {
        static void Main(string[] args)
        {
            CountriesApp c = new CountriesApp();
            Console.WriteLine("Here at Grand Circus we edit Country names in files!");
            c.CountriesMenu();

            

        }
        
    }
}
