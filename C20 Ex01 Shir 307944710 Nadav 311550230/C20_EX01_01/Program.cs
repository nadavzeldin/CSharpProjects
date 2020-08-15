using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C20_EX01_01
{
    class Program
    {
        //convert binary to decimal
        //statistics - average 0,1 | how many of bins are power of 2 | how many in dec form are increasing series | dec average 
        public static void Main()
        {
            Console.WriteLine("Please insert first binary number");
            String bin1 = Console.ReadLine();
            //int valueOfbin1 = int.Parse(bin1, 2);
            while (!BinaryInputValidation(bin1))
            {
                Console.WriteLine("Please insert binary number");
                bin1 = Console.ReadLine();
            }

            Console.WriteLine("Please insert second binary number");
            String bin2 = Console.ReadLine();
            while (!BinaryInputValidation(bin2))
            {
                Console.WriteLine("Please insert binary number");
                bin2 = Console.ReadLine();
            }

            Console.WriteLine("Please insert third binary number");
            String bin3 = Console.ReadLine();
            while (!BinaryInputValidation(bin3))
            {
                Console.WriteLine("Please insert binary number");
                bin3 = Console.ReadLine();
            }

            Console.WriteLine("Please insert fourth binary number");
            String bin4 = Console.ReadLine();
            while (!BinaryInputValidation(bin4))
            {
                Console.WriteLine("Please insert binary number");
                bin4 = Console.ReadLine();
            }


        }

        public static bool BinaryInputValidation(String i_BinaryInput)
        {
            //length validation
            if (i_BinaryInput.Length != 8)
            {
                Console.WriteLine("binary need to be 8 digits");
                return false;
            }
            //char validation
            for (int i = 0; i < i_BinaryInput.Length; i++)
            {
                char binaryInputAtIndex = i_BinaryInput[i];
                if (binaryInputAtIndex != '0' && i_BinaryInput[i] != '1')
                {
                    Console.WriteLine("binary can have only '0' and '1' ");
                    return false;
                }
            }
            return true;
        }


    }


}
