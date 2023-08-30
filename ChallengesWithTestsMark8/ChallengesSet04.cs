using System;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int result = 0;

            foreach(int num in numbers)
            {
                if(num % 2 == 0)
                {
                    result += num;
                }
                else
                {
                    result -= num;
                }
            }

            return result;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int minLength = int.MaxValue;

            if(str1.Length < minLength)
                minLength = str1.Length;
            if(str2.Length < minLength)
                minLength = str2.Length;
            if(str3.Length < minLength)
                minLength = str3.Length;
            if(str4.Length < minLength)
                minLength = str4.Length;

            return minLength;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int smallestnum = number1;

            if(number2 < smallestnum)
                smallestnum = number2;
            if(number3 < smallestnum)
                smallestnum = number3;
            if(number4 < smallestnum)
                smallestnum = number4;

            return smallestnum;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
          return 
          sideLength1 + sideLength2 > sideLength3 
          && sideLength1 + sideLength3 > sideLength2 
          && sideLength2 + sideLength3 > sideLength1;
        }

        public bool IsStringANumber(string input)
        {
            if(input == null)
            {
                return false;
            }
            return double.TryParse(input, out _);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int countNull = 0;
            int countNotNull = 0;

            foreach(object obj in objs)
            {
                if(obj == null)
                {
                    countNull++;
                }
                else
                {
                    countNotNull++;
                }
            }

            return countNull > countNotNull;
        }

        public double AverageEvens(int[] numbers)
        {
            int sumEvens = 0;
            int countEvens = 0;
            if(numbers == null || !numbers.Any())
            {
                return 0;
            }

            foreach (int num in numbers)
            {
                if(num % 2 == 0)
                {
                    sumEvens += num;
                    countEvens++;
                }
            }

            if(countEvens == 0)
            {
                return 0;
            }

            return(double)sumEvens / countEvens;

        }

        public int Factorial(int number)
        {
            if(number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if(number == null)
            {
                return 0;
            }
            if(number == 0 || number == 1)
            {
                return 1;
            }

            int result = 1;

            for(int i = 2; i <= number; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
