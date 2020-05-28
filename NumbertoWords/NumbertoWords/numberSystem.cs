using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace NumbertoWords
{
    /// <summary>
    /// This class is used to convert the Convert given number to Words in Indian System 
    /// I have made this class as public in order to make this accessible for Unit Testing if there is more 
    /// time we can  avoid this is made solely for demo purpose only
    /// </summary>
    public class numberSystem
    {

        // place holder to hold named constants from 1 to 19 Units Place
        static string[] unit = {"", "one ", "two ", "three ", "four ",
                       "five ", "six ", "seven ", "eight ",
                       "nine ", "ten ", "eleven ", "twelve ",
                       "thirteen ", "fourteen ", "fifteen ",
                       "sixteen ", "seventeen ", "eighteen ",
                       "nineteen "};

        // place holder to hold named constants from 20 to 90 Tens Place
        static string[] tens = {"", "", "twenty ", "thirty ", "forty ",
                       "fifty ", "sixty ", "seventy ", "eighty ",
                       "ninety "};


        static string numToWords(int n, string s)
        {
            string result = "";

            // if n is more than 19, divide it  
            if (n > 19)
            {
                result += tens[n / 10] + unit[n % 10];
            }
            else
            {
                result += unit[n];
            }

            // if n is non-zero  
            if (n != 0)
            {
                result += s;
            }

            return result;
        }

        // Function to print a given number in words  
        public static string convertToWords(long n)
        {
            if (n == 0)
                return "Zero";

            // stores word representation of  
            // given number n  
            string result = "";

            // handes Crores  places (if any)  
            result += numToWords((int)(n / 10000000),
                                          "crore ");

            // handles lakhs place  
            result += numToWords((int)((n / 100000) % 100),
                                      "lakh ");

            // handles thousands places
            result += numToWords((int)((n / 1000) % 100),
                                           "thousand ");

            // handles digit at hundreds places 
            result += numToWords((int)((n / 100) % 10),
                                          "hundred ");

            if (n > 100 && n % 100 > 0)
            {
                result += "and ";
            }

            // handles digits at ones and tens  
            // places (if any)  
            result += numToWords((int)(n % 100), "");
            return result;
        }
    }
}
