using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z');
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            int count = 0;
            for (int i = 1; i <= vals.Length; i++)
            {
                count++;
            }
            if (count % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

            
        }

        public bool IsNumberEven(int number) 
        {

            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool IsNumberOdd(int num) 
        {
            if (num % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {

        
                if (numbers == null)
                {
                    return 0;
                }
                if (numbers.Count() <= 0)
                {
                    return 0;
                }

                double min = numbers.Min();
                double max = numbers.Max();
                return min + max;


        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            int one = Convert.ToInt32(str1.Length);
            int two = Convert.ToInt32(str2.Length);
            if (one > two)
            {
                return two;
            }
            else
            {
                return one;
            }
        }

        public int Sum(int[] numbers)
        {
            int even = 0;
            try
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    even += numbers[i];
                }
                return even;
            }
            catch(NullReferenceException ex) 
            {
                return 0;
            }

        }

        public int SumEvens(int[] numbers)
        {
            int even = 0;
            if (numbers == null)
            {
                return 0;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                
          
                if (numbers[i] % 2 == 0)
                {
                    even += numbers[i];
                }
                
            }
            return even;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }

            int sum = numbers.Sum();
            
            if (sum % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {

            if(number > 0)
            {
                return number / 2;
            }
            else
            {
                return 0;
            }


        }
    }
}
