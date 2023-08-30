using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if(vals.Length % 2 == 0)
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
            return number % 2 == 0;
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if(numbers == null || !numbers.Any())
            {
                return 0;
            }
            double minValue = numbers.Min();
            double maxValue = numbers.Max();

            return minValue + maxValue;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            int length1 = str1.Length;
            int length2 = str2.Length;

            return Math.Min(length1, length2);
        }

        public int Sum(int[] numbers)
        {
            if(numbers == null || !numbers.Any())
            {
                return 0;
            }
            return numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            int sum = 0;
            if(numbers == null || !numbers.Any())
            {
                return 0;
            }

            foreach(int num in numbers)
            {
                if (num % 2 == 0)
                {
                    sum += num;
                }
            }

            return sum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            int sum = 0;
            if(numbers == null || !numbers.Any())
            {
                return false;
            }
            foreach(int num in numbers)
            {
                sum += num;
            }

            return sum % 2 != 0;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if(number <= 1)
            {
                return 0;
            }

            long positiveNumber = Math.Abs(number);
            long positiveCount = (positiveNumber)/2;

            if(number > 0 && number % 2 == 0)
            {
                return positiveCount--;
            }

            return positiveCount;

        }
    }
}


