using System;
using System.Text;

namespace C20_Ex01_06
{
    class Program
    {
        public static int s_maxDigit = 0;
        public static int s_minDigit = 9;
        public static int s_numOfDigsThatCanBeDividedByFour = 0;
        public static int s_numOfDigsThatAreLargerThanTheUnitsDigit = 0;
        public static int s_numOfIterations = 8;
        public static int s_unitDig;

        public static void Main()
        {
            int o_inputNumber;

            o_inputNumber = GetInputNumber();
            s_unitDig = GetUnitsDigit(o_inputNumber);
            GetStatistics(o_inputNumber);
            PrintStatisticsOnInputNumber();
        }

        public static int GetInputNumber()
        {
            int o_inputNumber;
            String inputAsString;
            Boolean isEightDigits;

            Console.WriteLine("Please enter an 8 digit number:");
            inputAsString = Console.ReadLine();
            isEightDigits = inputAsString.Length == s_numOfIterations;

            while (int.TryParse(inputAsString, out o_inputNumber) == false || isEightDigits == false)
            {
                Console.WriteLine("Invalid input, please enter eight digits only:");
                inputAsString = Console.ReadLine();
                isEightDigits = inputAsString.Length == s_numOfIterations;
            }

            return o_inputNumber;
        }

        public static void GetStatistics(int i_inputNumber)
        {
            int i;

            for (i = 0; i < s_numOfIterations; i++)
            {
                int currDigit = i_inputNumber % 10;
                s_maxDigit = Math.Max(s_maxDigit, currDigit);
                s_minDigit = Math.Min(s_minDigit, currDigit);
                CheckDivisionByFour(currDigit);
                CheckDigitLargerThanUnitDigit(currDigit);
                i_inputNumber /= 10;
            }
        }

        public static void CheckDivisionByFour(int i_digitToCheck)
        {
            Boolean isDividedByFour = false;

            isDividedByFour = i_digitToCheck % 4 == 0;
            if (isDividedByFour == true)
            {
                s_numOfDigsThatCanBeDividedByFour++;
            }
        }

        public static void CheckDigitLargerThanUnitDigit(int i_digitToCheck)
        {
            Boolean isLargerThanUnitDigit = false;

            isLargerThanUnitDigit = i_digitToCheck > s_unitDig;
            if (isLargerThanUnitDigit == true)
            {
                s_numOfDigsThatAreLargerThanTheUnitsDigit++;
                isLargerThanUnitDigit = false;
            }
        }

        public static int GetUnitsDigit(int i_inputNumber)
        {
            int o_unitsDigit = i_inputNumber % 10;

            return o_unitsDigit;
        }

        public static void PrintStatisticsOnInputNumber()
        {
            //Print max digit
            StringBuilder stringToPrint = new StringBuilder("The maximum digit is: ");
            stringToPrint.Append(s_maxDigit);
            Console.WriteLine(stringToPrint);
            //Print min digit
            stringToPrint.Clear();
            stringToPrint.Append("The minimum digit is: ");
            stringToPrint.Append(s_minDigit);
            Console.WriteLine(stringToPrint);
            //Print the amount of digits of the original input that can be divided by four
            stringToPrint.Clear();
            stringToPrint.Append("The amount of digits that can be divided by four is: ");
            stringToPrint.Append(s_numOfDigsThatCanBeDividedByFour);
            Console.WriteLine(stringToPrint);
            //Print the amount of digits that are larger than the units digit of the original input
            stringToPrint.Clear();
            stringToPrint.Append("The amount of ditits that are larger than the units digit is: ");
            stringToPrint.Append(s_numOfDigsThatAreLargerThanTheUnitsDigit);
            Console.WriteLine(stringToPrint);
        }
    }
}
