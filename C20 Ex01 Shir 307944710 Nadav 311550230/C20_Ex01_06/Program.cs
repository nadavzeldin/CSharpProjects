using System;
using System.Text;

namespace C20_Ex01_06
{
    class Program
    {
        public static int inputNumber;
        public static int maxDigit = 0;
        public static int minDigit = 9;
        public static int numOfDigsThatCanBeDividedByFour = 0;
        public static int numOfDigsThatAreLargerThanTheUnitsDigit = 0;
        public static int numOfIterations = 8;
        public static int unitDig;

        public static void Main()
        {
            inputNumber = getInputNumber();
            unitDig = getUnitsDigit(inputNumber);
            getStatistics(inputNumber);
            printStatisticsOnInputNumber();
        }

        public static int getInputNumber()
        {
            int o_inputNumber;
            String inputAsString;
            Boolean isEightDigits;

            Console.WriteLine("Please enter an 8 digit number:");
            inputAsString = Console.ReadLine();
            isEightDigits = inputAsString.Length == numOfIterations;

            while (int.TryParse(inputAsString, out o_inputNumber) == false || isEightDigits == false)
            {
                Console.WriteLine("Invalid input, please enter eight digits only:");
                inputAsString = Console.ReadLine();
                isEightDigits = inputAsString.Length == numOfIterations;
            }
            return o_inputNumber;
        }

        public static void getStatistics(int i_inputNumber)
        {
            int i;

            for (i = 0; i < numOfIterations; i++)
            {
                int currDigit = i_inputNumber % 10;
                maxDigit = Math.Max(maxDigit, currDigit);
                minDigit = Math.Min(minDigit, currDigit);
                checkDivisionByFour(currDigit);
                checkDigitLargerThanUnitDigit(currDigit);
                i_inputNumber /= 10;
            }
        }

        public static void checkDivisionByFour(int i_digitToCheck)
        {
            Boolean isDividedByFour = false;

            isDividedByFour = i_digitToCheck % 4 == 0;
            if (isDividedByFour == true)
            {
                numOfDigsThatCanBeDividedByFour++;
            }
        }

        public static void checkDigitLargerThanUnitDigit(int i_digitToCheck)
        {
            Boolean isLargerThanUnitDigit = false;
            isLargerThanUnitDigit = i_digitToCheck > unitDig;
            if (isLargerThanUnitDigit == true)
            {
                numOfDigsThatAreLargerThanTheUnitsDigit++;
                isLargerThanUnitDigit = false;
            }
        }

        public static int getUnitsDigit(int i_inputNumber)
        {
            int o_unitsDigit = i_inputNumber % 10;
            return o_unitsDigit;
        }

        public static void printStatisticsOnInputNumber()
        {
            //Print max digit
            StringBuilder stringToPrint = new StringBuilder("The maximum digit is: ");
            stringToPrint.Append(maxDigit);
            Console.WriteLine(stringToPrint);

            //Print min digit
            stringToPrint.Clear();
            stringToPrint.Append("The minimum digit is: ");
            stringToPrint.Append(minDigit);
            Console.WriteLine(stringToPrint);

            //Print the amount of digits of the original input that can be divided by four
            stringToPrint.Clear();
            stringToPrint.Append("The amount of digits that can be divided by four is: ");
            stringToPrint.Append(numOfDigsThatCanBeDividedByFour);
            Console.WriteLine(stringToPrint);

            //Print the amount of digits that are larger than the units digit of the original input
            stringToPrint.Clear();
            stringToPrint.Append("The amount of ditits that are larger than the units digit is: ");
            stringToPrint.Append(numOfDigsThatAreLargerThanTheUnitsDigit);
            Console.WriteLine(stringToPrint);
        }
    }
}
