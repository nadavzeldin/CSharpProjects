using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C20_Ex01_02
{
    class Program
    {
        public static Boolean isReverseHalf = false;
        public static Boolean isTheEnd = false;
        public static int numberOfAstricks;
        public static int numberOfSpaces = 0;


        public static void Main()
        {
            printSandGlass(5);
        }

        public static void printSandGlass(int i_numberOfAstricks)
        {
            numberOfAstricks = i_numberOfAstricks;
            printALineOfAstricksRec(numberOfAstricks, numberOfSpaces);

        }

        public static void printALineOfAstricksRec(int i_numberOfAstricks, int i_numberOfSpaces)
        {
            if((isReverseHalf == true && i_numberOfAstricks > numberOfAstricks) || i_numberOfAstricks <=1)
            {
                if(i_numberOfAstricks <= 1)
                {
                    if(i_numberOfAstricks == 1)
                    {
                        Console.Write(new string(' ', i_numberOfSpaces));
                        Console.WriteLine('*');
                    }
                    isReverseHalf = true;
                }
                isTheEnd = true;
            }

            if(isTheEnd == true)
            {
                return;
            }

            Console.Write(new String(' ', i_numberOfSpaces));
            Console.Write(new String('*', i_numberOfAstricks));
            Console.WriteLine();
            printALineOfAstricksRec(i_numberOfAstricks - 2, i_numberOfSpaces + 1);
            Console.Write(new String(' ', i_numberOfSpaces));
            Console.Write(new String('*', i_numberOfAstricks));
            Console.WriteLine();
        }
    }
}
