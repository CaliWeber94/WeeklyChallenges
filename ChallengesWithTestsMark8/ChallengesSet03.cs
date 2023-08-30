using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach(bool val in vals)
            {
                if(!val)
                {
                    return true;
                }
            }

            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            int sum = 0;
            if(numbers == null || !numbers.Any())
            {
                return false;
            }

            foreach(int num in numbers)
            {
                if(num % 2 != 0)
                {
                    sum += num;
                }
            }

            return sum % 2 != 0;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool containsUpper = false;
            bool containsLower = false;
            bool containsNumber = false;

            foreach(char c in password)
            {
                if(char.IsUpper(c))
                {
                    containsUpper = true;
                }
                else if(char.IsLower(c))
                {
                    containsLower = true;
                }
                else if(char.IsDigit(c))
                {
                    containsNumber = true;
                }

                if(containsUpper && containsLower && containsNumber)
                {
                    return true;
                }
            }

            return false;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return (val[val.Length - 1]);
        } 

        public decimal Divide(decimal dividend, decimal divisor)
        {
           if(dividend == 0 || divisor == 0)
            {
                return 0;
            }
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            List<int> odds = new List<int>();

            for(int i = 1; i < 100; i += 2)
            {
                odds.Add(i);
            }

            return odds.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for(int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
