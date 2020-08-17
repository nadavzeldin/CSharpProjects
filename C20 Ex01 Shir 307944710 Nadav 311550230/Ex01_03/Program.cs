using System;
using static C20_Ex01_02.Program;

namespace Ex01_03
{
    class Program
    {
        public static void Main()
        {
            int o_numberOfAstricks;

            o_numberOfAstricks = GetNumberOfAstricks();
            PrintSandGlass(o_numberOfAstricks);
        }

        public static int GetNumberOfAstricks()
        {
            int o_numberOfAstricks;
            String inputFromTheUser;
            Boolean isEvenNumber;

            Console.WriteLine("Please enter the number of lines for the Sand Glass: ");
            inputFromTheUser = Console.ReadLine();
            while(int.TryParse(inputFromTheUser, out o_numberOfAstricks) == false)
            {
                Console.WriteLine("Invalid input, please enter an integer");
                inputFromTheUser = Console.ReadLine();
            }

            isEvenNumber = o_numberOfAstricks % 2 == 0;
            if (isEvenNumber == true)
            {
                o_numberOfAstricks += 1;
            }
            return o_numberOfAstricks;
        }
    }
}
