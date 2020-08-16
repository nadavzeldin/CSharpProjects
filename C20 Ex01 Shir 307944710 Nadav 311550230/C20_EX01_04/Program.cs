using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C20_EX01_04
{
    class Program
    {
        public static void Main()
        {
            bool isPalindromeIsEnglish = false;
            bool isPalindromeANumber = false;
            bool lengthIsnt12Digits = true;
            bool isPalindrom = false;
            Console.WriteLine("Please insert 12 digit palindrome");
            string palindrome = Console.ReadLine();
            int numberOfSmallLetter = 0;
            long result;

            while (lengthIsnt12Digits)
            {
                if(palindrome.Length == 12 && (long.TryParse(palindrome, out result) || onlyEnglish(palindrome, ref numberOfSmallLetter)))
                {
                    lengthIsnt12Digits = false;

                }
                else
                {
                    Console.WriteLine("Please insert 12 digit palindrome");
                    palindrome = Console.ReadLine();
                }
            }

            isPalindrom = Program.isPalindrom(palindrome);
            if(isPalindrom)
            {
                Console.WriteLine(palindrome + ", is a palindrome");

            }

            else
            {
                Console.WriteLine(palindrome + ", isn't a valid palindrome");
            }

            //check if palindrome is a number and if so does he divided by 3 without reminder
            isPalindromeANumber = long.TryParse(palindrome, out result);
            if(isPalindromeANumber)
            {
                Console.WriteLine("Palindrome is a number");

                bool isDivedByThree;
                long paldindromReminder = long.Parse(palindrome) % 3;
                if (paldindromReminder == 0)
                {
                    Console.WriteLine("Palindrome is divided by 3 without reminder");
                }
                else
                {
                    Console.WriteLine("Palindrome doesn't divided by 3 without reminder");
                }
            }

            //test if palindrome contains only english letters
            numberOfSmallLetter = 0;
            isPalindromeIsEnglish = onlyEnglish(palindrome, ref numberOfSmallLetter);
            if(isPalindromeIsEnglish && isPalindrom)
            {
                Console.WriteLine("Palindrome is english letter");
                Console.WriteLine("Contains " + numberOfSmallLetter + " of small letters");
            }

        

            
        }

        public static bool isPalindrom(string i_Palindrom )
        {
            if(i_Palindrom.Length <= 1)
            {
                return true;
            }

            if(i_Palindrom[0] != i_Palindrom[i_Palindrom.Length-1])
            {
                return false;
            }

            else
            {
                return isPalindrom(i_Palindrom.Substring(1, i_Palindrom.Length - 2));
            }
        }

        public static bool onlyEnglish(string i_Palindrom, ref int  i_NumberOfSmallLetters)
        {
            for(int i = 0; i < i_Palindrom.Length; i++)
            {
                char currentIndex = i_Palindrom[i];
                if(currentIndex<'A' || currentIndex > 'z')
                {
                    return false;
                }

                if(currentIndex >= 'a' && currentIndex <= 'z')
                {
                    i_NumberOfSmallLetters++;
                }
            }
            return true;
        }
    }

}
