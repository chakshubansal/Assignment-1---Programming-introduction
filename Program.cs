using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace DIS_Assignmnet1_SPRING_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            Console.WriteLine("Q1: Enter the string:");
            string s = Console.ReadLine();
            string final_string = RemoveVowels(s);
            Console.WriteLine("Final string after removing the Vowels: {0}", final_string);
            Console.WriteLine();

            //Question 2:
            string[] bulls_string1 = new string[] { "Marshall", "Student", "Center" };
            string[] bulls_string2 = new string[] { "MarshallStudent", "Center" };
            bool flag = ArrayStringsAreEqual(bulls_string1, bulls_string2);
            Console.WriteLine("Q2");
            if (flag)
            {
                Console.WriteLine("Yes, Both the array’s represent the same string");
            }
            else
            {
                Console.WriteLine("No, Both the array’s don’t represent the same string ");
            }
            Console.WriteLine();

            //Question 3:
            int[] bull_bucks = new int[] { 1, 2, 3, 2 };
            int unique_sum = SumOfUnique(bull_bucks);
            Console.WriteLine("Q3:");
            Console.WriteLine("Sum of Unique Elements in the array are :{0}", unique_sum);
            Console.WriteLine();


            //Question 4:
            int[,] bulls_grid = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Console.WriteLine("Q4:");
            int diagSum = DiagonalSum(bulls_grid);
            Console.WriteLine("The sum of diagonal elements in the bulls grid is {0}:", diagSum);
            Console.WriteLine();

            //Question 5:
            Console.WriteLine("Q5:");
            String bulls_string = "aiohn";
            int[] indices = { 3, 1, 4, 2, 0 };
            String rotated_string = RestoreString(bulls_string, indices);
            Console.WriteLine("The  Final string after rotation is {0} ", rotated_string);
            Console.WriteLine();

            //Quesiton 6:
            string bulls_string6 = "mumacollegeofbusiness";
            char ch = 'c';
            string reversed_string = ReversePrefix(bulls_string6, ch);
            Console.WriteLine("Q6:");
            Console.WriteLine("Resultant string are reversing the prefix:{0}", reversed_string);
            Console.WriteLine();

        }

        /* 
        <summary>
        Given a string s, remove the vowels 'a', 'e', 'i', 'o', and 'u' from it, and return the new string.
        Example 1:
        Input: s = "MumaCollegeofBusiness"
        Output: "MmCllgfBsnss"
        Example 2:
        Input: s = "aeiou"
        Output: ""
        Constraints:
        •	0 <= s.length <= 10000
        s consists of uppercase and lowercase letters
        </summary>
        */

        private static string RemoveVowels(string s)                                    //This is the method to remove vowels from a string
        {
            try
            {
                String final_string = "";
                char[] vowels = new char[10] { 'a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U' };          //Saving all the vowels to an array 

                StringBuilder ns = new StringBuilder(s);
                for (int i = 0; i < ns.Length; i++)                                           //iteration to compare the alphabets of given string one by one
                {
                    char c = ns[i];
                    for (int j = 0; j < vowels.Length; j++)                                 //iterations to compare alphabet to each vowel one by one
                    {
                        if (c == vowels[j])                                                 // Comparing the alphabet of string to vowels
                        {
                            ns.Replace(vowels[j].ToString(), "");                           //Replacing the vowel to print the output without vowel            
                        }

                    }
                }
                final_string = ns.ToString();
                return final_string;
            }
            catch (Exception)
            {
                throw;
            }

        }

        /* 
        <summary>
       Given two string arrays word1 and word2, return true if the two arrays represent the same string, and false otherwise.
       A string is represented by an array if the array elements concatenated in order forms the string.
       Example 1:
       Input: : bulls_string1 = ["Marshall", "Student",”Center”], : bulls_string2 = ["MarshallStudent ", "Center"]
       Output: true
       Explanation:
       word1 represents string "marshall" + "student" + “center” -> "MarshallStudentCenter "
       word2 represents string "MarshallStudent" + "Center" -> "MarshallStudentCenter"
       The strings are the same, so return true.
       Example 2:
       Input: word1 = ["Zimmerman", "School", ”of Advertising”, ”and Mass Communications”], word2 = ["Muma", “College”,"of”, “Business"]
       Output: false
       Example 3:
       Input: word1  = ["University", "of", "SouthFlorida"], word2 = ["UniversityofSouthFlorida"]
       Output: true
       </summary>
       */

        private static bool ArrayStringsAreEqual(string[] bulls_string1, string[] bulls_string2)        //This is the method to compare the arrays of two strings
        {
            try
            {
                string FullString1 = "", FullString2 = "";                                // Initializing the empty string for bulls_string 1 and bulls_string2
                 for (int i = 0; i < bulls_string1.Length; i++)             // For loop till the length of the first string
                 {
                    FullString1 = FullString1 + bulls_string1[i];       //  adding the words of the string       
                 }

                for (int i = 0; i < bulls_string2.Length; i++)           // For loop to till the length of the second string
                {
                    FullString2 = FullString2 + bulls_string2[i];       //  adding the words of the string    
                }

                return FullString1.Equals(FullString2);                 //Checking if the words of the two added complete strings match or not

            }
            catch (Exception)
            {

                throw;
            }

        }
        /*
        <summary> 
       You are given an integer array bull_bucks. The unique elements of an array are the elements that appear exactly once in the array.
       Return the sum of all the unique elements of nums.
       Example 1:
       Input: bull_bucks = [1,2,3,2]
       Output: 4
       Explanation: The unique elements are [1,3], and the sum is 4.
       Example 2:
       Input: bull_bucks = [1,1,1,1,1]
       Output: 0
       Explanation: There are no unique elements, and the sum is 0.
       Example 3:
       Input: bull_bucks = [1,2,3,4,5]
       Output: 15
       Explanation: The unique elements are [1,2,3,4,5], and the sum is 15.
       </summary>
        */

        private static int SumOfUnique(int[] bull_bucks)
        {
            try
            {
                Array.Sort(bull_bucks);                     //Sorting the list and storing in array
               int sum = 0;                                 //Initializing the sum as 0
               if (bull_bucks[0] != bull_bucks[1])          //Checking the first two values of array are same or not
               {
                    sum = bull_bucks[0];
                    for (int i = 0; i < bull_bucks.Length - 1; i++)             //Looping till one less than length of the array 
                    {
                        if (bull_bucks[i] != bull_bucks[i + 1])                 //checking if two digits are not same then the loop will execute
                        {
                            sum = sum + bull_bucks[i];                          //Calcuating the sum of the digits which are not same
                        }
                    }
               }
               return sum;
            }

            catch (Exception)
            {
                throw;
            }
        }
        /*
        <summary>
       Given a square matrix bulls_grid, return the sum of the matrix diagonals.
       Only include the sum of all the elements on the primary diagonal and all the elements on the secondary diagonal that are not part of the primary diagonal.
       Example 1:
       Input: bulls_grid = [[1,2,3],[4,5,6], [7,8,9]]
       Output: 25
       Explanation: Diagonals sum: 1 + 5 + 9 + 3 + 7 = 25
       Notice that element mat[1][1] = 5 is counted only once.
       Example 2:
       Input: bulls_grid = [[1,1,1,1], [1,1,1,1],[1,1,1,1], [1,1,1,1]]
       Output: 8
       Example 3:
       Input: bulls_grid = [[5]]
       Output: 5
       </summary>
        */

        private static int DiagonalSum(int[,] bulls_grid)                                   //This is the method to find the sum of diagonals and removing repeating value
        {
            try
            {
                int Totalsum = 0, samevalue;
                int length = Convert.ToInt32(Math.Sqrt(bulls_grid.Length));                         // To find the size of the matrix
                for (int i = 0; i < length; i++)                                          // Iterating till the length of the matrix to get all first diagonal values
                {
                    Totalsum += bulls_grid[i, i];                                                   // Calculating the sum of the first diagonal
                }

                for (int i = length - 1; i >= 0; i--)
                {
                    Totalsum = Totalsum + bulls_grid[Convert.ToInt64(length - (i + 1)), i];            // Calculating the sum of the second diagonal    
                }

                if (((length) % 2 != 0) && (length > 1))                                            // finding the repeating value from the matrix
                {
                    samevalue = (length - 1) / 2;
                    Totalsum = Totalsum - bulls_grid[samevalue, samevalue];                         //Removing the repeating value from the sum
                }


                return Totalsum;
            }
            catch (Exception e)
            {

                Console.WriteLine("An error occured: " + e.Message);
                throw;
            }

        }



        /*
         
        <summary>
        Given a string bulls_string  and an integer array indices of the same length.
        The string bulls_string  will be shuffled such that the character at the ith position moves to indices[i] in the shuffled string.
        Return the shuffled string.
        Example 3:
        Input: bulls_string  = "aiohn", indices = [3,1,4,2,0]
        Output: "nihao"
        */

        private static string RestoreString(string bulls_string, int[] indices)         //Method to return the shuffled string
        {
            try
            {
                int i, a;
                string Finalresult = "";                                            // Initializing the empty string for the result
                for (i = 0; i < indices.Length; i++)                                // Iterating till the length of the indices
                {
                    a = Array.IndexOf(indices, i);                                  // Stroing the alphabets of the string in the index of the array
                    Finalresult += bulls_string[i];                                 //saving the alphabets to the finalresult string
                }
                return Finalresult;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

        }

        /*
         <summary>
        Given a 0-indexed string bulls_string   and a character ch, reverse the segment of word that starts at index 0 and ends at the index of the first occurrence of ch (inclusive). If the character ch does not exist in word, do nothing.
        For example, if word = "abcdefd" and ch = "d", then you should reverse the segment that starts at 0 and ends at 3 (inclusive). The resulting string will be "dcbaefd".
        Return the resulting string.
        Example 1:
        Input: bulls_string   = "mumacollegeofbusiness", ch = "c"
        Output: "camumollegeofbusiness"
        Explanation: The first occurrence of "c" is at index 4. 
        Reverse the part of word from 0 to 4 (inclusive), the resulting string is "camumollegeofbusiness".
        Example 2:
        Input: bulls_string   = "xyxzxe", ch = "z"
        Output: "zxyxxe"
        Explanation: The first and only occurrence of "z" is at index 3.
        Reverse the part of word from 0 to 3 (inclusive), the resulting string is "zxyxxe".
        Example 3:
        Input: bulls_string   = "zimmermanschoolofadvertising", ch = "x"
        Output: "zimmermanschoolofadvertising"
        Explanation: "x" does not exist in word.
        You should not do any reverse operation, the resulting string is "zimmermanschoolofadvertising".
        */

        private static string ReversePrefix(string bulls_string6, char ch)
        {
            try
            {

                String prefix_string = "";                                                 // Initializing the empty string for saving the result
                int n = bulls_string6.IndexOf(ch, 0, bulls_string6.Length);               //saving the index of the first occurance character mentioned in bulls_string

                for (int a = n; a >= 0; a--)
                {
                    prefix_string += bulls_string6[a];                                      //saving the value of the reversed string in prefix_string
                }
                for (int a = n + 1; a < bulls_string6.Length; a++)
                {
                    prefix_string += bulls_string6[a];                                     //adding the remaining string to the reversed string
                }
                return prefix_string;
            }

            catch (Exception)
            {

                throw;
            }

        }
    }
}





/*Self-reflection:
Time- taken: 24 hours

Learning: This Assignment was useful for learning and applying basic concepts such as looping, conditional statements, data type usage, passing parameters, methods.
I also learned to use debugger and compiler while doing this assigment which helped me understand where I am going wrong.
I also learned how to use Github and how to push the files.
This assignment has helped me clear my basic knowledge of coding. Looking forward to learn more from such assignemnts.

Recommendation: It would be really benefitial for the students if the hints are provided for all the questions as this will help us keep our thought process more on the track.
*/
