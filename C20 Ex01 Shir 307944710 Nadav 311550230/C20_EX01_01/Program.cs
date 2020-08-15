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
            while (!BinaryInputValidation(bin1))
            {
                Console.WriteLine("Please insert binary number");
                bin1 = Console.ReadLine();
            }
            int bin1Decimal = BinaryToDecimal(bin1);


            Console.WriteLine("Please insert second binary number");
            String bin2 = Console.ReadLine();
            while (!BinaryInputValidation(bin2))
            {
                Console.WriteLine("Please insert binary number");
                bin2 = Console.ReadLine();
            }
            int bin2Decimal = BinaryToDecimal(bin2);


            Console.WriteLine("Please insert third binary number");
            String bin3 = Console.ReadLine();
            while (!BinaryInputValidation(bin3))
            {
                Console.WriteLine("Please insert binary number");
                bin3 = Console.ReadLine();
            }
            int bin3Decimal = BinaryToDecimal(bin3);


            Console.WriteLine("Please insert fourth binary number");
            String bin4 = Console.ReadLine();
            while (!BinaryInputValidation(bin4))
            {
                Console.WriteLine("Please insert binary number");
                bin4 = Console.ReadLine();
            }
            int bin4Decimal = BinaryToDecimal(bin4);

            //Printing results
            Console.WriteLine("The numbers are : " +bin1Decimal + " " + bin2Decimal + " " + bin3Decimal + " " + bin4Decimal + " ");

                int numberOfPowerOfTwo =0;
                if(PowerOfTwo(bin1Decimal))
                    numberOfPowerOfTwo++;
                if (PowerOfTwo(bin2Decimal))
                    numberOfPowerOfTwo++;
                if (PowerOfTwo(bin3Decimal))
                    numberOfPowerOfTwo++;
                if (PowerOfTwo(bin4Decimal))
                    numberOfPowerOfTwo++;
            
            Console.WriteLine("There are " + numberOfPowerOfTwo + " in the power of two");


            int IncreasingSeries = 0;
            if (IncreasingSerie(bin1Decimal))
                IncreasingSeries++;
            if (IncreasingSerie(bin2Decimal))
                IncreasingSeries++;
            if (IncreasingSerie(bin3Decimal))
                IncreasingSeries++;
            if (IncreasingSerie(bin4Decimal))
                IncreasingSeries++;
            Console.WriteLine("There are " + IncreasingSeries + " increasing series");

            Console.WriteLine("Average (decimal) " + (bin1Decimal + bin2Decimal  + bin3Decimal + bin4Decimal)/4 );
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

        public static int BinaryToDecimal(String i_BinaryInput)
        {
            int binaryNumber = int.Parse(i_BinaryInput);
            int decimalValue = 0;
            // initializing base1 value to 1, i.e 2^0 
            int base1 = 1;

            while (binaryNumber > 0)
            {
                int reminder = binaryNumber % 10;
                binaryNumber = binaryNumber / 10;
                decimalValue += reminder * base1;
                base1 = base1 * 2;
            }
            return decimalValue;
        }

        public static void AverageOfZeroVsOnes(String i_BinaryInput)
        {
            int zeroAverage = 0;
            int oneAverage = 0;

            for(int i = 0; i < 8; i++)
            {
                if(i_BinaryInput[i] == '0')
                {
                    zeroAverage++;
                }
                else
                {
                    oneAverage++;
                }
            }
            Console.WriteLine("Average Zeros: " + zeroAverage + "Average Ones: " + oneAverage);
        }

        public static bool PowerOfTwo(int i_Decimal)
        {
            int reminder =0;
            while(i_Decimal > 1)
            {
                reminder = i_Decimal % 2;
                if(reminder != 0)
                {
                    return false;
                }

                i_Decimal /= 2;
            }
            return true;
        }

        public static bool IncreasingSerie(int i_Decimal)
        {
            int currentIndexValue;
            int previousIndexValue;

            while(i_Decimal > 0)
            {
                currentIndexValue = i_Decimal % 10;
                i_Decimal /= 10;
                previousIndexValue = i_Decimal % 10;
                if(currentIndexValue <= previousIndexValue)
                {
                    return false;
                }
            }
            return true;
        }
    }


}
