using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int num = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] % 2 == 0)
                {
                    num += numbers[i];
                }
                else
                {
                    num -= numbers[i];
                }
            }
            return num;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int[] array = {str1.Length,  };
            return array.Min();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int[] nums = { number1, number2, number3, number4 };

            return nums.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            throw new NotImplementedException();

            //google how to figure out three lengths = triangle
        }

        public bool IsStringANumber(string input)
        {
            
            double i = 0;
            bool result = double.TryParse(input, out i);
            return result;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int nullCount = 0;
            int notNullCount = 0;
            bool fact = true;
            for (int i = 0; i < objs.Length; i++)
            {
                if (nullCount > notNullCount) 
                {
                    if (objs[i] == null)
                    {
                        nullCount++;
                    }
                    else 
                    {
                        notNullCount++;
                    }
                    fact = true;
                }
                else
                {
                    fact = false;
                }

            }
            return fact;

            //foreach loop
            //counter
            //if counter > length/2....
        }

        public double AverageEvens(int[] numbers)
        {
            throw new NotImplementedException();
            //for (int i = 0; i < numbers.Length; i++)
            //{

            //    if ()
            //    {

            //    }
            //}
        }

        public int Factorial(int number)
        {
            int num = 1;
            for (int i = number; i >= 0; i--)
            {
                if (i == 0)
                {
                    num = 1;
                }
                else
                {
                    num *= i;
                }
            }
            return num;

            //factorial C# recursion (google)
        }
    }
}
