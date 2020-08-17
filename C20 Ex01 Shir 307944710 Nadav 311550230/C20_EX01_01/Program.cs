using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C20_EX01_01
{
    class Program
    {
        public static void Main()
        {
            BinaryQueries();
        }

        public static void BinaryQueries()
        {
            int averageDecimalValue = 0;
            int increasingSeries = 0;
            int numberOfPowerOfTwo = 0;
            int currentDecimal = 0;
            String binary = null;
            StringBuilder userInput = new StringBuilder();
            Console.WriteLine("Please insert four binary number");
            binary = UserInput(binary, userInput);

            for(int i = 0; i < binary.Length; i += 8)
            {
                int binaryNumber = int.Parse(binary.Substring(i, 8));
                currentDecimal = BinaryToDecimal(binaryNumber);
                averageDecimalValue += currentDecimal;
                if(PowerOfTwo(binaryNumber))
                {
                    numberOfPowerOfTwo++;
                }

                if(IncreasingSerie(currentDecimal))
                {
                    increasingSeries++;
                }
            }

            AverageOfZeroVsOnes(binary);
            String powerOfTwoText = String.Format("There are {0} in the power of two", numberOfPowerOfTwo);
            Console.WriteLine(powerOfTwoText);
            String increasingSeriesText = String.Format("There are {0} increasing series", increasingSeries);
            Console.WriteLine(increasingSeriesText);
            Console.WriteLine("Average decimal value is: " + averageDecimalValue / 4);
        }

        private static string UserInput(string i_Binary, StringBuilder i_UserInput)
        {
            for(int i = 0; i < 4; i++)
            {
                i_Binary = Console.ReadLine();
                while(!BinaryInputValidation(i_Binary))
                {
                    Console.WriteLine("Please insert binary number");
                    i_Binary = Console.ReadLine();
                }

                i_UserInput.Append(i_Binary);
            }

            return i_UserInput.ToString();
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

        public static int BinaryToDecimal(int i_BinaryInput)
        {
          
                int decimalValue = 0;
                // initializing base1 value to 1, i.e 2^0 
                int base1 = 1;

                while (i_BinaryInput > 0)
                {
                    int reminder = i_BinaryInput % 10;
                    i_BinaryInput = i_BinaryInput / 10;
                    decimalValue += reminder * base1;
                    base1 = base1 * 2;
                }
                Console.WriteLine(decimalValue);
                return decimalValue;

        }

        public static void AverageOfZeroVsOnes(String i_BinaryInput)
        {
            int zeroAverage = 0;
            int oneAverage = 0;

            for(int i = 0; i < i_BinaryInput.Length; i++)
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

            Console.WriteLine("Average Zeros: " + zeroAverage / 4);
            Console.WriteLine("Average Ones: "  + oneAverage  / 4);
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
