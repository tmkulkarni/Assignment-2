using System;
using System.Collections.Generic;
using System.Linq;

namespace Programming_Assignment_2_Summer_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question1:
            Console.WriteLine("Question 1");
            int[] nums1 = { 2, 5, 1, 3, 4, 7 };
            int[] nums2 = { 2, 1, 4, 7 };
            Intersection(nums1, nums2);
            Console.WriteLine("");

            //Question 2 
            Console.WriteLine("Question 2");
            int[] nums = { 0, 1, 0, 3, 12 };
            Console.WriteLine("Enter the target number:");
            int target = Int32.Parse(Console.ReadLine());
            int pos = SearchInsert(nums, target);
            Console.WriteLine("Insert Position of the target is : {0}", pos);
            Console.WriteLine("");

            //Question3
            Console.WriteLine("Question 3");
            int[] ar3 = { 1, 2, 3, 1, 1, 3 };
            int Lnum = LuckyNumber(ar3);
            if (Lnum == -1)
                Console.WriteLine("Given Array doesn't have any lucky Integer");
            else
                Console.WriteLine("Lucky Integer for given array {0}", Lnum);

            Console.WriteLine();

            //Question 4
            Console.WriteLine("Question 4");
            Console.WriteLine("Enter the value for n:");
            int n = Int32.Parse(Console.ReadLine());
            int Ma = GenerateNums(n);
            Console.WriteLine("Maximun Element in the Generated Array is {0}", Ma);
            Console.WriteLine();

            //Question 5

            Console.WriteLine("Question 5");
            List<List<string>> cities = new List<List<string>>();
            cities.Add(new List<string>() { "London", "New York" });
            cities.Add(new List<string>() { "New York", "Tampa" });
            cities.Add(new List<string>() { "Delhi", "London" });
            string Dcity = DestCity(cities);
            Console.WriteLine("Destination City for Given Route is : {0}", Dcity);

            Console.WriteLine();

            //Question 6
            Console.WriteLine("Question 6");
            int[] Nums = { 2, 7, 11, 15 };
            int target_sum = 9;
            targetSum(Nums, target_sum);
            Console.WriteLine();

            //Question 7
            Console.WriteLine("Question 7");
            int[,] scores = { { 1, 91 }, { 1, 92 }, { 2, 93 }, { 2, 97 }, { 1, 60 }, { 2, 77 }, { 1, 65 }, { 1, 87 }, { 1, 100 }, { 2, 100 }, { 2, 76 } };
            HighFive(scores);
            Console.WriteLine();

            //Question 8
            Console.WriteLine("Question 8");
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            int K = 3;
            RotateArray(arr, K);

            Console.WriteLine();

            //Question 9
            Console.WriteLine("Question 9");
            int[] arr9 = { 7, 1, 5, 3, 6, 4 };
            int Ms = MaximumSum(arr9);
            Console.WriteLine("Maximun Sum contiguous subarray {0}", Ms);
            Console.WriteLine();

            //Question 10
            Console.WriteLine("Question 10");
            int[] costs = { 10, 15, 20 };
            int minCost = MinCostToClimb(costs);
            Console.WriteLine("Minium cost to climb the top stair {0}", minCost);
            Console.WriteLine();
        }

        //Question 1
        /// <summary>
        //Given two integer arrays nums1 and nums2, return an array of their intersection.
        //Each element in the result must be unique and you may return the result in any order.
        //Example 1:
        //Input: nums1 = [1,2,2,1], nums2 = [2,2]
        //Output: [2]
        //Example 2:
        //Input: nums1 = [4,9,5], nums2 = [9,4,9,8,4]
        //Output: [9,4]
        //
        /// </summary>

        public static void Intersection(int[] nums1, int[] nums2)       //We are using all static methods because method is not dependent of object or instance variable
        {
            try
            {
                
                int[] arrayOutput = new int[4];                 //Declaring array
                int val = 0;

                for (int i = 0; i < nums1.Length; i++)
                {
                    for (int j = 0; j < nums2.Length; j++)      //Using nested loops for traversing 
                    {
                        if (nums1[i] == nums2[j])      
                        {
                            arrayOutput[val] = nums2[j];

                            val += 1;                
                        }
                        continue;                               //Using continue to pass control to next iteration
                    }
                }

                Console.Write("[");

                for (int i = 0; i < arrayOutput.Length; i++)       //logic for printing output
                {
                    arrayOutput.Distinct();
                    Console.Write(arrayOutput[i]);

                    if (i < arrayOutput.Length - 1)
                    {
                        Console.Write(",");
                    }
                }
                Console.Write("]");

            }
            catch (Exception)
            {

                throw;
            }
        }
        /*  <SelfReflectionProblem1> 
     *  From above code,I understood the use of iterative and conditional logic. 
     *  Effectively used continue keyword. 
     *  </SelfReflectionProblem1> */

        //Question 2:
        /// <summary>
        //Given a sorted array of distinct integers and a target value, return the index if the target is found.If not, return the index where it would be if it were inserted in order.
        //Note: You must write an algorithm with O(log n) runtime complexity.
        //Example 1:
        //Input: nums = [1, 3, 5, 6], target = 5
        //Output: 2
        //Example 2:
        //Input: nums = [1, 3, 5, 6], target = 2
        //Output: 1
        //Example 3:
        //Input: nums = [1, 3, 5, 6], target = 7
        //Output: 4
        //Example 4:
        //Input: nums = [1, 3, 5, 6], target = 0
        //Output: 0
        /// </summary>

        public static int SearchInsert(int[] nums, int target)
        {
            try
            {
                for (int i = 0; i < nums.Length; i++)                   
                {
                    if (target == nums[i])
                    {                                                               //conditional logic is for finding position of target 
                        return i;
                    }
                    else if (nums[i] < target && target < nums[i + 1])
                    {                                                               //logic if target is not present then, identifying position of target
                        return i + 1;
                    }
                }
                return -1;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /*  <SelfReflectionProblem2> 
     *  This logic was comparitively easy to implement
     *  Use of && in conditional logic is done for adding multiple conditions in 'else-if'. 
     *  </SelfReflectionProblem2> */


        //Question 3
        /// <summary>
        //Given an array of integers arr, a lucky integer is an integer which has a frequency in the array equal to its value.
        //Return a lucky integer in the array. If there are multiple lucky integers return the largest of them. If there is no lucky integer return -1.
        //Example 1:
        //Input: arr = [2, 2, 3, 4]
        //Output: 2
        //Explanation: The only lucky number in the array is 2 because frequency[2] == 2.
        /// </summary>

        private static int LuckyNumber(int[] nums)
        {
            try
            {
                Dictionary<int, int> dictionaryForLN = new Dictionary<int, int>();  //Dictionary is imported from system.collections
                foreach (int val in nums)
                {
                    if (dictionaryForLN.ContainsKey(val))
                    {
                        dictionaryForLN[val]++;
                    }
                    else
                        dictionaryForLN.Add(val, 1);                                //Add is an inbuilt function in dictionary
                }
                int num = -1;
                foreach (var val in dictionaryForLN.Keys)
                {
                    if (val == dictionaryForLN[val] && val > num)
                        num = val;
                }
                return num;             
            }
            catch (Exception)
            {

                throw;
            }
        }
        /*  <SelfReflectionProblem3> 
    *  Use of dictionary is implemented 
    *  </SelfReflectionProblem3> */

        //Question 4:
        /// <summary>
        //You are given an integer n.An array nums of length n + 1 is generated in the following way:
        //•	nums[0] = 0
        //•	nums[1] = 1
        //•	nums[2 * i] = nums[i]  when 2 <= 2 * i <= n
        //•	nums[2 * i + 1] = nums[i] + nums[i + 1] when 2 <= 2 * i + 1 <= n
        // Return the maximum integer in the array nums.

        //Example 1:
        //Input: n = 7
        //Output: 3
        //Explanation: According to the given rules:
        //nums[0] = 0
        //nums[1] = 1
        //nums[(1 * 2) = 2] = nums[1] = 1
        //nums[(1 * 2) + 1 = 3] = nums[1] + nums[2] = 1 + 1 = 2
        //nums[(2 * 2) = 4] = nums[2] = 1
        //nums[(2 * 2) + 1 = 5] = nums[2] + nums[3] = 1 + 2 = 3
        //nums[(3 * 2) = 6] = nums[3] = 2
        //nums[(3 * 2) + 1 = 7] = nums[3] + nums[4] = 2 + 1 = 3
        //Hence, nums = [0, 1, 1, 2, 1, 3, 2, 3], and the maximum is 3.

        /// </summary>
        private static int GenerateNums(int n)
        {
            try
            {
                int[] array = new int[n + 1];           //Array is instantiated
                if (n <= 0) return 0;
                if (n <= 2) return 1;
                array[0] = 0;
                array[1] = 1;

                for (int i = 2; i <= n; i++)
                {
                    if (i % 2 == 0) 
                    {
                        array[i] = array[i / 2];
                    }
                    else
                    {
                        int num = (i - 1) / 2;
                        array[i] = array[num] + array[num + 1];
                    }
                }

                return array.Max();                 //Max is an enumerable function which returns maximum value of array
            }
            catch (Exception)
            {
                throw;
            }

        }
        /*  <SelfReflectionProblem4> 
   *  Used iterative and conditional logic to implement the solution 
   *  </SelfReflectionProblem4> */

        //Question 5
        /// <summary>
        //You are given the array paths, where paths[i] = [cityAi, cityBi] means there exists a direct path going from cityAi to cityBi.Return the destination city, that is, the city without any path outgoing to another city.
        //It is guaranteed that the graph of paths forms a line without any loop, therefore, there will be exactly one destination city.
        //Example 1:
        //Input: paths = [["London", "New York"], ["New York","Lima"], ["Lima","Sao Paulo"]]
        //Output: "Sao Paulo" 
        //Explanation: Starting at "London" city you will reach "Sao Paulo" city which is the destination city.Your trip consist of: "London" -> "New York" -> "Lima" -> "Sao Paulo".
        /// </summary>
        public static string DestCity(List<List<string>> paths)     //Passing list in argument
        {
            try
            {
                HashSet<string> set = new HashSet<string>();        //Hashset initialized

                foreach (var item in paths)
                    set.Add(item[1]);                   //Add and remove are inbuilt methods in hashset collection

                foreach (var item in paths)
                    set.Remove(item[0]);

                return set.First();                     //First is an inbuilt method in Enumerable which returns first value in sequence
            }
            catch (Exception)
            {
                throw;
            }
        }
        /*  <SelfReflectionProblem5> 
   *  Use of hashset is implemented 
   *  Because of hashset, it was quite easy to implement
   *  </SelfReflectionProblem5> */

        //Question 6:
        /// <summary>
        //Given an array of integers numbers that is already sorted in non-decreasing order, find two numbers such that they add up to a specific target number.
        //Print the indices of the two numbers (1-indexed) as an integer array answer of size 2, where 1 <= answer[0] < answer[1] <= numbers.Length.
        //You may not use the same element twice, there will be only one solution for a given array
        //Example 1:
        //Input: numbers = [2,7,11,15], target = 9
        //Output: [1,2]
        //Explanation: The sum of 2 and 7 is 9. Therefore index1 = 1, index2 = 2.

        /// </summary>
        private static void targetSum(int[] nums, int target)
        {
            try
            {
                int num1, num2;
                num1 = 0;
                num2 = nums.Length - 1;
                while (num1 < num2)                                         //Using while loop for iteration
                {
                    if (nums[num1] + nums[num2] == target)
                    {
                        num1 += 1;
                        num2 += 1;
                        Console.Write("[" + num1 + "," + num2 + "]");
                    }
                    else if (nums[num1] + nums[num2] > target)              //logic for finding indexes
                    {
                        num2--;
                    }
                    else if (nums[num1] + nums[num2] < target)
                    {
                        num1++;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        /*  <SelfReflectionProblem6> 
   *  Use of while loop is implemented 
   *  Because of hashset, it was quite easy to implement
   *  </SelfReflectionProblem6> */

        //Question 7
        /// <summary>
        /// Given a list of the scores of different students, items, where items[i] = [IDi, scorei] represents one score from a student with IDi, calculate each student's top five average.
        /// Print the answer as an array of pairs result, where result[j] = [IDj, topFiveAveragej] represents the student with IDj and their top five average.Sort result by IDj in increasing order.
        /// A student's top five average is calculated by taking the sum of their top five scores and dividing it by 5 using integer division.
        /// Example 1:
        /// Input: items = [[1, 91], [1,92], [2,93], [2,97], [1,60], [2,77], [1,65], [1,87], [1,100], [2,100], [2,76]]
        /// Output: [[1,87],[2,88]]
        /// Explanation: 
        /// The student with ID = 1 got scores 91, 92, 60, 65, 87, and 100. Their top five average is (100 + 92 + 91 + 87 + 65) / 5 = 87.
        /// The student with ID = 2 got scores 93, 97, 77, 100, and 76. Their top five average is (100 + 97 + 93 + 77 + 76) / 5 = 88.6, but with integer division their average converts to 88.
        /// Example 2:
        /// Input: items = [[1,100],[7,100],[1,100],[7,100],[1,100],[7,100],[1,100],[7,100],[1,100],[7,100]]
        /// Output: [[1,100],[7,100]]
        /// Constraints:
        /// 1 <= items.length <= 1000
        /// items[i].length == 2
        /// 1 <= IDi <= 1000
        /// 0 <= scorei <= 100
        /// For each IDi, there will be at least five scores.
        /// </summary>
        private static void HighFive(int[,] items)
        {
            try
            {
                List<List<int>> listing = new List<List<int>>();
                Dictionary<int, List<int>> dictionary = new Dictionary<int, List<int>>();
                for (int i = 0; i < items.GetLength(0); i++)
                {
                    if (!dictionary.ContainsKey(items[i, 0]))
                    {
                        dictionary.Add(items[i, 0], new List<int>());
                        dictionary[items[i, 0]].Add(items[i, 1]);
                    }
                    else
                        dictionary[items[i, 0]].Add(items[i, 1]);
                }

                foreach (var val in dictionary)
                {
                    dictionary[val.Key].Sort();
                    dictionary[val.Key].Reverse();
                }

                foreach (var val in dictionary)
                {
                    List<int> flag = new List<int>();
                    flag.Add(val.Key);
                    flag.Add((int)dictionary[val.Key].GetRange(0, 5).AsQueryable().Sum() / 5);
                    listing.Add(flag);

                }

                Console.Write("[");
                foreach (var val in listing)
                {
                    Console.Write("[");
                    foreach (var j in val)
                    {
                       
                        Console.Write(j + " ");
                    }
                    Console.Write("]");
                }
                Console.Write("]");
                Console.WriteLine();

            }
            catch (Exception)
            {

                throw;
            }
        }

        //Question 8
        /// <summary>
        //Given an array, rotate the array to the right by k steps, where k is non-negative.
        //Print the Final array after rotation.
        //Example 1:
        //Input: nums = [1, 2, 3, 4, 5, 6, 7], k = 3
        //Output: [5,6,7,1,2,3,4]
        //Explanation:
        //rotate 1 steps to the right: [7,1,2,3,4,5,6]
        //rotate 2 steps to the right: [6,7,1,2,3,4,5]
        //rotate 3 steps to the right: [5,6,7,1,2,3,4]
        //Example 2:
        //Input: nums = [-1,-100,3,99], k = 2
        //Output: [3,99,-1,-100]
        //Explanation: 
        //rotate 1 steps to the right: [99,-1,-100,3]
        //rotate 2 steps to the right: [3,99,-1,-100]
        /// </summary>

        private static void RotateArray(int[] arr, int n)
        {
            try
            {
                int[] array = new int[arr.Length];
                for (int i = 0; i < arr.Length; i++)
                {
                    array[(i + n) % arr.Length] = arr[i];
                }
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = array[i];
                }

                Console.Write("[");
                for(int i = 0; i<arr.Length;i++)
                {
                    Console.Write(arr[i]);

                    if(i==arr.Length-1)
                    {
                        break;
                    }
                    else
                    {
                        Console.Write(",");
                    }
                }
                Console.Write("]");
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Question 9
        /// <summary>
        //Given an integer array nums, find the contiguous subarray(containing at least one number) which has the largest sum and return its sum
        //Example 1:
        //Input: nums = [-2,1,-3,4,-1,2,1,-5,4]
        //Output: 6
        //Explanation: [4,-1,2,1] has the largest sum = 6.
        //Example 2:
        //Input: nums = [1]
        //Output: 1
        // Example 3:
        // Input: nums = [5,4,-1,7,8]
        //Output: 23
        /// </summary>

        private static int MaximumSum(int[] arr)
        {
            try
            {                
                int currentSubarray = arr[0];
                int maxSubarray = arr[0];
                
                for (int i = 1; i < arr.Length; i++)
                {
                    int num = arr[i];
                    
                    currentSubarray = Math.Max(num, currentSubarray + num);
                    maxSubarray = Math.Max(maxSubarray, currentSubarray);
                }

                return maxSubarray;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Question 10
        /// <summary>
        //You are given an integer array cost where cost[i] is the cost of ith step on a staircase.Once you pay the cost, you can either climb one or two steps.
        //You can either start from the step with index 0, or the step with index 1.
        //Return the minimum cost to reach the top of the floor.
        //Example 1:
        //Input: cost = [10, 15, 20]
        //Output: 15
        //Explanation: Cheapest is: start on cost[1], pay that cost, and go to the top.

        /// </summary>

        private static int MinCostToClimb(int[] costs)
        {
            try
            {
               
                int[] minCost = new int[costs.Length + 1];
              
                for (int i = 2; i < minCost.Length; i++)
                {
                    int takeOneStep = minCost[i - 1] + costs[i - 1];
                    int takeTwoSteps = minCost[i - 2] + costs[i - 2];
                    minCost[i] = Math.Min(takeOneStep, takeTwoSteps);
                }                
                return minCost[minCost.Length - 1];
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}