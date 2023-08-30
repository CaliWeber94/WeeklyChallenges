using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null)
            {
                return false;
            }

            StringComparison comparisonType = ignoreCase ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal;

            foreach (string item in words)
            {
                if (string.Equals(item, word, comparisonType))
                {
                    return true;
                }
            }

            return false;
        }
    
    

        public bool IsPrimeNumber(int num)
        {
            if(num <= 1)
            {
                return false;
            }

            if(num <= 3)
            {
                return true;
            }

            if(num % 2 == 0 || num % 3 == 0)
            {
                return false;
            }

            for(int i = 5; i * i <= num; i += 6)
            {
                if(num % i == 0 || num % (i + 2) == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            int index = -1;
            bool uindex;

            for(int i = 0; i < str.Length; i++)
            {
                uindex = true;

                for(int j = 0; j < str.Length; j++)
                {
                    if(str[i] == str[j] && i != j)
                    {
                        uindex = false;
                    }
                }

                if(uindex == true)
                {
                    index = i;
                }
            }
            return index;

        }

          
        

        public int MaxConsecutiveCount(int[] numbers)
        {
            if(numbers.Length == 0)
            {
                return 0;
            }

            int maxCount = 1;
            int count = 1;

            for(int i = 1; i < numbers.Length; i++)
            {
                if(numbers[i] == numbers[i - 1])
                {
                    count++;
                    maxCount = Math.Max(maxCount, count);
                }
                else
                {
                    count = 1;
                }
            }

            return maxCount;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if (elements == null || n <= 0)
            {
                return new double[0];
            }
            List<double> element = new List<double>();

            for(int i = n - 1; i < elements.Count; i += n)
            {
                element.Add(elements[i]);
            }

            return element.ToArray();
        }
    }
}
