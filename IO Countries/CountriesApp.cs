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
            bool menuAgain = true;
                        
            do
            {
                Console.WriteLine("Would you like to:\n 1. Display Country List\n 2. Enter a New Country\n 3. Delete a New Country \n 4. Exit Program");
                numSelect = Validator.DigitInRange(Console.ReadLine(), 4);
                menuAgain = MenuNav(numSelect);

            } while (menuAgain);

        }
        public bool MenuNav(int x)
        {
            string filePath = @"C:\Users\GC Student\Source\Repos\IO Countries\IO Countries\Countries List.txt";

            if (x == 1)
            {
                List<string> textFile = new List<string>();
                textFile = Countries_Text_IO.FileReader(filePath);
                foreach (string s in textFile)
                {
                    Console.WriteLine(s);
                }
                
                Console.WriteLine();
                return true;
            }
            else if (x == 2)
            {
                Countries_Text_IO.FileWriter(filePath);
                return true;
            }
            else if (x == 3)
            {
                Countries_Text_IO.DeleteAName(filePath);
                return true;
            }
            else
            {
                Console.WriteLine("Goodbye!");
                Console.ReadLine();
                return false;
            }
        }

    }
}
