using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
        
            for (int i = 0; i < vals.Length; i ++)
            {
                
                int counter = 0;
                if (vals[i] == false)
                {
                    counter++;
                }
                if (counter > 0)
                {
                    return true;
                }
            }
            return false;

            //try the .Contains
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        { 
            try
            {
                return numbers.Where(x => x % 2 != 0).Sum() % 2 != 0;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            if (password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsDigit))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor > 0)
            {
                return dividend / divisor;
            }
            else
            {
                return 0;
            }
            
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            var name = Enumerable.Range(1, 100).Where(X => X % 2 != 0).ToArray();
            return name;
            
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
           
            
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
                
            }
            
        }
    }
}
