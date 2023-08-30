using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text.RegularExpressions;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            int remainder = startNumber % n;
            int difference = n - remainder;

            return startNumber + difference;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {

            foreach (Business business in businesses)
            {
                if (business.TotalRevenue == 0)
                {
                    business.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || !numbers.Any())
            {
                return false;
            }
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[i - 1])
                {
                    return false;
                }
            }

            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            int sum = 0;
            if (numbers == null || !numbers.Any())
            {
                return 0;
            }

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] % 2 == 0)
                {
                    sum += numbers[i];
                }
            }

            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {

            if (words == null || words.Length == 0)
            {
                return string.Empty;
            }

            var sentence = "";

            foreach (var word in words)
            {
                if(word.Trim().Length > 0)
                {
                    sentence += word.Trim() + " ";
                }
            }

            if(sentence.Length == 0)
            {
                return string.Empty;
            }

            sentence = sentence.Substring(0, sentence.Length - 1);
            sentence += ".";

            return sentence;

            
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            List<double> fourthElement = new List<double>();

            if (elements == null)
            {
                return new double[] { };
            }

            for (int i = 3; i < elements.Count; i += 4)
            {
                fourthElement.Add(elements[i]);
            }

            return fourthElement.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            if (nums == null || nums.Length < 2)
            {
                return false;
            }

            Array.Sort(nums);
            int left = 0;
            int right = nums.Length - 1;

            while(left < right)
            {
                int sum = nums[left] + nums[right];

                if(sum == targetNumber)
                {
                    return true;
                }
                else if(sum < targetNumber)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
             return false;
        }





    }
}

