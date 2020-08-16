using System;
using static C20_Ex01_02.Program;

namespace Ex01_03
{
    class Program
    {
        public static int o_numberOfAstricks;
        public static void Main()
        {
            getNumberOfAstricks();
            printSandGlass(o_numberOfAstricks);
        }

        public static void getNumberOfAstricks()
        {
            String i_inputFromTheUser;
            Boolean isEvenNumber;

            Console.WriteLine("Please enter the number of lines for the Sand Glass: ");
            i_inputFromTheUser = Console.ReadLine();
            while(int.TryParse(i_inputFromTheUser, out o_numberOfAstricks) == false)
            {
                Console.WriteLine("Invalid input, please enter an integer");
                i_inputFromTheUser = Console.ReadLine();
            }

            isEvenNumber = o_numberOfAstricks % 2 == 0;
            if (isEvenNumber == true)
            {
                o_numberOfAstricks += 1;
            }
        }
    }
}
