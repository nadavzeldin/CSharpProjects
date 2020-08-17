using System;
using System.Text;

namespace C20_Ex01_02
{
    public class Program
    {
        public static Boolean s_isTheEnd = false;
        public static int s_numberOfAstricks = 5;
        public static int s_numberOfSpaces = 0;

        public static void Main()
        {
            PrintSandGlass(s_numberOfAstricks);
        }

        public static void PrintSandGlass(int i_numberOfAstricks)
        {
            s_numberOfAstricks = i_numberOfAstricks;
            PrintALineOfAstricksRec(s_numberOfAstricks, s_numberOfSpaces);
        }

        public static void PrintALineOfAstricksRec(int i_numberOfAstricks, int i_numberOfSpaces)
        {
            StringBuilder stringToPrint = new StringBuilder("");
            Boolean isNumberOfAstricksIsOne = false;

            isNumberOfAstricksIsOne = i_numberOfAstricks == 1;
            if (isNumberOfAstricksIsOne == true)
            {
                stringToPrint.Append(new String(' ', i_numberOfSpaces));
                stringToPrint.Append("*");
                Console.WriteLine(stringToPrint);
                s_isTheEnd = true;
            }

            if(s_isTheEnd == true)
            {
                return;
            }

            stringToPrint.Append(new String(' ', i_numberOfSpaces));
            stringToPrint.Append(new String('*', i_numberOfAstricks));
            Console.WriteLine(stringToPrint);
            PrintALineOfAstricksRec(i_numberOfAstricks - 2, i_numberOfSpaces + 1);
            Console.WriteLine(stringToPrint);
        }
    }
}
