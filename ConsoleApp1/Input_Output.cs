using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    //if all functions are static make class also static 
    // Why private class? make public
    class Input_Output
    {
        public static List<string[]> file_lines = new List<string[]>();

        public static void Read_File()
        {
            //add folder and in.txt in sources, currently unable run programm
            //"Input/in.txt" into appsettings.json and read path from configuration 
            var lines = File.ReadAllLines("Input/in.txt");
            foreach (var item in lines)
            {
                // make new char[] { ' ', ',', '.', ':', '\t' } static list and use everyware you need, seems you use it several times
                file_lines.Add(item.Split(new char[] { ' ', ',', '.', ':', '\t' }, StringSplitOptions.RemoveEmptyEntries));
            }
          
        }

        public static void Write_File(List<string> res) {

            // Same here
            //"Output/result.txt" into appsettings.json and read path from configuration 
            // What about if file has already beeb created ? catch exception
            using (StreamWriter streamWriter = new StreamWriter("Output/result.txt", false))
            {
                foreach (var item in res)
                {
                    streamWriter.WriteLine(item);
                }
                
            }
        }
    }
}
