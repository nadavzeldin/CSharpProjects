using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C20_Ex01_02
{
    public class Program
    {
        public static Boolean isTheEnd = false;
        public static int numberOfAstricks = 5;
        public static int numberOfSpaces = 0;

        public static void Main()
        {
            printSandGlass(numberOfAstricks);
        }

        public static void printSandGlass(int i_numberOfAstricks)
        {
            numberOfAstricks = i_numberOfAstricks;
            printALineOfAstricksRec(numberOfAstricks, numberOfSpaces);
        }

        public static void printALineOfAstricksRec(int i_numberOfAstricks, int i_numberOfSpaces)
        {
            StringBuilder stringToPrint = new StringBuilder("");

            if (i_numberOfAstricks <=1)
            {
                if(i_numberOfAstricks == 1)
                {
                    stringToPrint.Append(new String(' ', i_numberOfSpaces));
                    stringToPrint.Append("*");
                    Console.WriteLine(stringToPrint);
                }
                isTheEnd = true;
            }

            if(isTheEnd == true)
            {
                return;
            }

            stringToPrint.Append(new String(' ', i_numberOfSpaces));
            stringToPrint.Append(new String('*', i_numberOfAstricks));
            Console.WriteLine(stringToPrint);
            printALineOfAstricksRec(i_numberOfAstricks - 2, i_numberOfSpaces + 1);
            Console.WriteLine(stringToPrint);
        }
    }
}
