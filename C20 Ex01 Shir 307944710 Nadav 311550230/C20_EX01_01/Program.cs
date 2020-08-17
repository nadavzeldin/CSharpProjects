using System;
using System.Text;


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
            String binaryUserInput = null;
            StringBuilder userInput = new StringBuilder();

            //receive user binary inputs
            Console.WriteLine("Please insert four binary number");
            binaryUserInput = UserInput(userInput);

            //for each binary value analyze and print required information
            for(int i = 0; i < binaryUserInput.Length; i+= 8)
            {
                int binaryNumber = int.Parse(binaryUserInput.Substring(i, 8));
                currentDecimal = BinaryToDecimal(binaryNumber);
                averageDecimalValue += currentDecimal;
                
                if(PowerOfTwo(currentDecimal))
                {
                    numberOfPowerOfTwo++;
                }

                if(IncreasingSerie(currentDecimal))
                {
                    increasingSeries++;
                }
            }

            AverageOfZeroVsOnes(binaryUserInput);

            String powerOfTwoText = String.Format("There are {0} in the power of two", numberOfPowerOfTwo);
            Console.WriteLine(powerOfTwoText);

            String increasingSeriesText = String.Format("There are {0} increasing series", increasingSeries);
            Console.WriteLine(increasingSeriesText);

            Console.WriteLine("Average decimal value is: " + averageDecimalValue / 4);
        }

        public static string UserInput(StringBuilder i_UserInput)
        {
            string binaryInput;
            for (int i = 0; i < 4; i++)
            {
                binaryInput = Console.ReadLine();
                while(!BinaryInputValidation(binaryInput))
                {
                    Console.WriteLine("Please insert binary number");
                    binaryInput = Console.ReadLine();
                }

                i_UserInput.Append(binaryInput);
            }

            return i_UserInput.ToString();
        }

        public static bool BinaryInputValidation(String i_BinaryInput)
        {
            bool binaryContainValidDigits = true;
            bool binaryInputValidationResult = true;

            //length validation
            if (i_BinaryInput.Length != 8)
            {
                Console.WriteLine("binary need to be 8 digits");
                binaryInputValidationResult= false;
            }

            //char validation
            for(int i = 0; i < i_BinaryInput.Length; i++)
            {
                char binaryInputAtIndex = i_BinaryInput[i];
                if (binaryInputAtIndex != '0' && i_BinaryInput[i] != '1')
                {
                    binaryInputValidationResult= false;
                    binaryContainValidDigits = false;
                }
            }

            if(binaryContainValidDigits == false)
            {
                Console.WriteLine("binary can have only '0' and '1' ");
            }
            return binaryInputValidationResult;
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
            bool powerOfTwoResult = true;
            int reminder =0;
            while(i_Decimal > 1)
            {
                reminder = i_Decimal % 2;
                if(reminder != 0)
                {
                    powerOfTwoResult= false;
                }

                i_Decimal /= 2;
            }

            return powerOfTwoResult;
        }

        public static bool IncreasingSerie(int i_Decimal)
        {
            bool increasingSerieResult = true;
            int currentIndexValue;
            int previousIndexValue;

            while(i_Decimal > 0)
            {
                currentIndexValue = i_Decimal % 10;
                i_Decimal /= 10;
                previousIndexValue = i_Decimal % 10;
                if(currentIndexValue <= previousIndexValue)
                {
                    increasingSerieResult = false;
                }
            }
            return increasingSerieResult;
        }
    }


}
