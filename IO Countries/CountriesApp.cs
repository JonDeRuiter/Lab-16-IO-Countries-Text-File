using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IO_Countries
{
    class CountriesApp
    {
        //Constructor
        public CountriesApp()
        {

        }

        //Methods
        public void CountriesMenu()
        {
            int numSelect;
            Console.WriteLine("Would you like to:\n 1. Display Country List\n 2. Enter a New Country\n 3. Delete a New Country \n 4. Exit Program");
            numSelect = Validator.DigitInRange(Console.ReadLine(), 4);
            MenuNav(numSelect);

        }
        public void MenuNav(int x)
        {
            string filePath = @"C:\Users\GC Student\Source\Repos\IO Countries\IO Countries\Countries List.txt";

            if (x == 1)
            {
                string list = Countries_Text_IO.FileReader(filePath);
            }
            else if (x == 2)
            {
                string Stringy = Countries_Text_IO.FileWriter(filePath);
            }
            else if (x == 3)
            {
                //Deletes an entry
            }
            else
            {
                Console.WriteLine("Goodbye!");
            }
        }
    }
}
