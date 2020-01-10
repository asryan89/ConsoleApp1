using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Input_Output
    {
        public static List<string[]> file_lines = new List<string[]>();

        public static void Read_File()
        {
            var lines = File.ReadAllLines("in.txt");
            foreach (var item in lines)
            {
                file_lines.Add(item.Split(new char[] { ' ', ',', '.', ':', '\t' }, StringSplitOptions.RemoveEmptyEntries));
            }
          
        }

        public static void Write_File(List<string> res) {
           
            using (StreamWriter streamWriter = new StreamWriter("result.txt", false))
            {
                foreach (var item in res)
                {
                    streamWriter.WriteLine(item);
                }
                
            }
        }
    }
}
