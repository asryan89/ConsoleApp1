using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {           
            Input_Output.Read_File();
            Input_Output.Write_File(Calculate.Calc(Input_Output.file_lines));
            Search.Search_In_Result();
        }
    }
}
