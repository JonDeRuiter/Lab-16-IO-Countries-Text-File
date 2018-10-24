using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IO_Countries
{
    class Countries_Text_IO
    {

        

        public static string FileReader(string filePath)
        {
            try
            {
                StreamReader reader = new StreamReader(filePath);
                string text = reader.ReadToEnd();
                Console.WriteLine(text);
                reader.Close();
                return text;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return "";
        }
        public static string FileWriter(string filePath)
        {
            try
            {
                string oldStuff = FileReader(filePath);
                StreamWriter writer = new StreamWriter(filePath);
                Console.WriteLine($"What Country would you like to add: ");
                string newLines = Validator.IsName(Console.ReadLine());
                newLines = oldStuff + newLines;
                writer.WriteLine(newLines);
                writer.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);                
            }
            return "";
        }

    }
}
