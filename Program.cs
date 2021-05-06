using System;
using System.Collections.Generic;
using System.Linq;


namespace Scaler
{
    class Program
    {
        static void Main(string[] args)
        {

            //List<int> commonPrefix = new List<int>();
            //commonPrefix.Add(43);
            //commonPrefix.Add(35);
            //commonPrefix.Add(25);
            //commonPrefix.Add(5);
            //commonPrefix.Add(34);

            //commonPrefix.Add(5);
            //commonPrefix.Add(8);
            //commonPrefix.Add(7);

            //int[] fgd = { 2, 5, -1, 7, -3, -1, -2 };

            //int[] arrr = { 1,2,3,4,5 };

            List<int> vals = new List<int>();
            vals.Add(5);
            vals.Add(10);
            vals.Add(20);
            vals.Add(100);
            vals.Add(105);

            var showUp = TwoPointers.SubArrayWithGivenSum.solve(vals, 110);

            List<string> ab = new List<string>();

            ab.Add("cat");
            ab.Add("dog");
            ab.Add("god");
            ab.Add("tac");

            var anagrams = Hashing.Anagrams.anagrams(ab);


          //  var ansSum = Queues.SlidingWindowMax.MaxInList(arrr, 3);


           // var aip = StringManipulation.ReverseString.solve("the sky is blue");

          //  var items = Stacks.SortItemsUsing2Stacks.solve(commonPrefix);

            string A = "dadbc";
            #region
            int temp = 0, sol = 0, i = 0, j = 0;

            Dictionary<char, int> myMap = new Dictionary<char, int>();

            while (j < A.Length)
            {
                if (!myMap.ContainsKey(A[j]))
                {
                    myMap.Add(A[j], 1);
                    j++;
                    temp++;
                }
                else
                {
                    while (A[i] != A[j])
                    {
                        myMap.Remove(A[i]);
                        i++;
                        temp--;

                    }

                    if (i != j)
                    {
                        i++;
                    }
                    temp--;
                    myMap.Remove(A[j]);
                }
                if (temp > sol)
                {
                    sol = temp;
                }

            }

           

            #endregion
            Console.WriteLine(sol);
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }

        private static void CallingExcelColumnToNumberConversion(string s)
        {
            int result =0;

            for (int i = 0; i < s.Length; i++)
            {
                result *= 26;
                result += s[i] - 'A' + 1;
            }

            Console.WriteLine("This is your output");
            Console.WriteLine(result);
        }

        public static  List<string> FizzBuzz(int A)
            {

                string[] a = new string[A];
                int p = 0;

                for (int i = 0; i < a.Length; i++)
                {
                    p = i + 1;
                    if (p % 3 == 0 && p % 5 != 0)
                    {

                        a[i] = "Fizz";
                    }

                    else if (p % 3 != 0 && p % 5 == 0)
                    {
                        a[i] = "Buzz";
                    }
                    else if (p % 3 == 0 && p % 5 == 0)
                    {
                        a[i] = "FizzBuzz";
                    }

                    else
                    {
                        a[i] = p.ToString();
                    }
                }
                return a.ToList();
            }


        public static string solve(string A)
        {

            char[] a = new char[A.Length * 2];

            string B = A + A;

            a = B.ToCharArray();
            string newString = string.Empty;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] >= 65 && a[i] <= 90)
                {
                    continue;
                }
                else
                {
                    newString += a[i].ToString();
                }
            }

            int len = newString.Length;
            char[] b = new char[len];
            string finalString = string.Empty;
            for (int j = 0; j < b.Length; j++)
            {
                if (b[j].ToString() == "a" || b[j].ToString() == "e" || b[j].ToString() == "i" || b[j].ToString() == "o" || b[j].ToString() == "u")
                {
                    finalString += "#";
                }
                else
                {
                    finalString += b[j].ToString();
                }
            }

            return finalString;
        }

        public static int solve(List<char> A)
        {
            byte[] newCharArray = System.Text.Encoding.ASCII.GetBytes(A.ToArray());
            int checkValueFlag = 0;

            for (int i = 0; i < newCharArray.Length; i++)
            {
                if ((newCharArray[i] >= 65 && newCharArray[i] <= 90) || (newCharArray[i] >= 97 && newCharArray[i] <= 122))
                {
                    checkValueFlag += 1;

                }
                else
                {
                    checkValueFlag += 0;
                    break;

                }

            }

            if ((checkValueFlag) == newCharArray.Length + 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public int solveAV(string A)
        {
            //int B = 2;
            //char[] a = new char[A.Length + B];
            char[] a = A.ToArray();
            string ap = string.Empty;
            int count = 0;
            for (int i = 0; i < a.Length - 2; i++)
            {
                if (a[i].ToString() == "b")
                {
                    if (a[i + 1].ToString() == "o")
                    {
                        if (a[i + 2].ToString() == "b")
                        {
                            count += 1;
                        }
                    }
                }

            }
            return count;
        }

        public int solvep(List<char> A)
        {

            char[] arryChar = A.ToArray();
            int count = 0;
            bool foundNonAlphaNumeric = false;
            for (int i = 0; i < arryChar.Length; i++)
            {
                if ((arryChar[i] >= 48 && arryChar[i] > 57) || (arryChar[i] >= 65 && arryChar[i] > 90)
                || (arryChar[i] >= 97 && arryChar[i] > 122))

                {
                    count++;
                }

                else
                {
                    foundNonAlphaNumeric = true;
                    break;
                }
            }

            if (foundNonAlphaNumeric == true)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }


}
