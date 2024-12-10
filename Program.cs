using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkPictures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int allUserPicts = 52;
            int pictsInRow = 3;
            int numberFullRows;
            int residuePicts;

            numberFullRows = allUserPicts / pictsInRow;
            residuePicts = numberFullRows % pictsInRow;

            Console.WriteLine($"Number full rows it's {numberFullRows}, pictures residue {residuePicts}");
        }
    }
}
