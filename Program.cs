using System;

namespace PalindromeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(Palindrome());
        }

        public static string Palindrome()
        {
            int result = 0;
            int palindrome = 0;

            for (int i = 9999; i > 0; i--)
            {
                for (int y = 9999; y > 0; y--)
                {
                    result = i * y;

                    if (result == Reverse(result))
                    {
                        if (result > palindrome)
                            palindrome = result;
                    }
                }
            }
            return palindrome.ToString();
        }

        public static int Reverse(int num)
        {
            int reverseNum = 0;
            while (num > 0)
            {
                reverseNum = reverseNum * 10 + num % 10;
                num = num / 10;
            }
            return reverseNum;
        }
    }
}