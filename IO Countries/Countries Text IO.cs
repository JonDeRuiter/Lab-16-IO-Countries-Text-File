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
        //Methods
        public static List<string> FileReader(string filePath)
        {
            List<string> text = new List<string>();
            try
            {
                string line;
                StreamReader reader = new StreamReader(filePath);
                //text = reader.ReadLine();
                while ((line = reader.ReadLine()) != null)
                {
                    text.Add(line);
                    if (line == null)
                    {
                        break;
                    }
                }
                
                reader.Close();
                return text;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return text;
        }
        public static void FileWriter(string filePath)
        {
            List<string> textFile = new List<string>();
            try
            {
                textFile = FileReader(filePath);
                StreamWriter writer = new StreamWriter(filePath);
                Console.WriteLine($"What Country would you like to add: ");
                string newLines = Validator.IsName(Console.ReadLine());
                textFile.Add(newLines);
                foreach (string s in textFile)
                {
                    writer.WriteLine(s);
                }
                writer.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);                
            }            
        }
        public static void DeleteAName(string filePath)
        {
            List<string> textFile = new List<string>();
            textFile = FileReader(filePath);
            StreamWriter rewriter = new StreamWriter(filePath);
            
            Console.WriteLine("Which entry would you like to delete?");
            for (int i = 0; i < textFile.Count; i++)
            {
                Console.WriteLine($"{i+1}. {textFile[i]}");
            }
            int deletable = Validator.DigitInRange(Console.ReadLine(),textFile.Count);
            deletable--;
            textFile.RemoveAt(deletable);

            foreach (string s in textFile)
            {
                rewriter.WriteLine(s);
            }
            rewriter.Close();                       
        }

    }
}
