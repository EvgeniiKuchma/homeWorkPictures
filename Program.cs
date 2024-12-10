using System;


namespace homeWorkPictures
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            int allUserPictures = 52;
            int picturesInRow = 3;
            int numberFullRows;
            int residuePictures;

            numberFullRows = allUserPictures / picturesInRow;
            residuePictures = numberFullRows % picturesInRow;

            Console.WriteLine($"Number full rows it's {numberFullRows}, pictures residue {residuePictures}");
        }
    }
}
