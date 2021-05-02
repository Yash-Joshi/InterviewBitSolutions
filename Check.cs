using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scaler
{
    public class Solution
    {

       

       

        public static List<List<int>> solveR(List<int> A, List<int> B)
        {

            int[] mainArray = A.ToArray();
            int[] rotationArray = B.ToArray(); 
            
            List<List<int>> ret = new List<List<int>>();

            for (int b = 0; b < rotationArray.Length; b++)
            {
                int[] dumparray = new int[mainArray.Length];
                for (int i = 0; i < mainArray.Length; i++)
                {
                    dumparray[i] = mainArray[(i + rotationArray[b]) % mainArray.Length];

                }

                var li = dumparray.ToList();
                ret.Add(li);
            }

            return ret;
        }
        public static List<List<int>> solveRotateted(List<int> A, List<int> B)
        {


            // Created main array
            int[] mainArray = A.ToArray();
            int[] copy = mainArray;

            //Created array that have values to be roated around
            int[] rotationArray = B.ToArray();

            // this is the returned array list
            List<List<int>> ret = new List<List<int>>();

            // this acts as primary array to be added
            List<int> toAdd = new List<int>();

            for (int i = 0; i < rotationArray.Length; i++)
            {
                //mainArray = copy;
                int rotate = B[i];
                //int[] temp = new int[rotate];
                for(int j = 0; j < rotate; j++)
                leftRotate(mainArray, mainArray.Length);
                
                List<int> pp = mainArray.ToList();
                ret.Add(pp);
                CopyArray(copy, mainArray);

            }
            //ret.Add(toAdd);
            return ret;
        }

        public static void leftRotate(int[] arr, int len)
        {
            int i, temp = arr[0];
            for (i = 0; i < len - 1; i++)
                arr[i] = arr[i + 1];
            arr[len - 1] = temp;
        
        }

        public static void CopyArray(int[] source, int[] target)
        {

            for (int i = 0; i < source.Length; i++)
            {
                target[i] = source[i];
            }
        }
        public static int maxArr(List<int> A)
        {
            int[] a = A.ToArray();

            int maxArrayPlus = a[0];
            int minArrayPlus = a[0];

            int maxArrayMinus = a[0];
            int minArrayMinus = a[0];

            for (int i = 0; i < a.Length; i++)
            {
                int n = a[i] + i;
                if (n > maxArrayPlus)
                {
                    maxArrayPlus = n;
                }
                if (n < minArrayPlus)
                {
                    minArrayPlus = n;
                }
            }

            for (int i = 0; i < a.Length; i++)
            {
                int n = a[i] - i;
                if (n > maxArrayMinus)
                {
                    maxArrayMinus = n;
                }
                if (n < minArrayMinus)
                {
                    minArrayMinus = n;
                }
            }

            int finalPlus = maxArrayPlus - minArrayPlus;
            int finalMinus = maxArrayMinus + minArrayMinus;

            if (finalPlus > finalMinus)
            {
                return finalPlus;
            }
            else
            {
                return finalMinus;
            }
        }

        public List<int> solveAtLeast2Grater(List<int> A)
        {
            int firstMax = 0;
            int secondMax = 0;

            List<int> newList = new List<int>();

            for (int i = 0; i < A.Count; i++)
            {
                if (A[i] > firstMax)
                {
                    secondMax = firstMax;
                    firstMax = A[i];
                }

            }

            for (int i = 0; i < A.Count; i++)
            {
                if (A[i] == firstMax || A[i] == secondMax)
                {
                    continue;
                }
                else
                {
                    newList.Add(A[i]);
                }
            }

            return newList;
        }

        public static string simplifyPath(string A)
        {
            var list = A.Split('/').ToList();

            Stack<string> myStackPath = new Stack<string>();

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == "." || list[i] == string.Empty)
                {
                    continue;
                }
                else if (list[i] == "..")
                {
                    if (myStackPath.Count != 0)
                    {
                        myStackPath.Pop();
                    }

                }
                else
                {
                    myStackPath.Push(list[i]);
                }
            }

            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            if (myStackPath.Count == 1)
            {
                sb = sb.Append("/");
                sb = sb.Append(myStackPath.Pop());
                return sb.ToString();
            }

            Stack<string> srev = new Stack<string>();
            while (myStackPath.Count != 0)
            {
               // srev.Push("/");
                srev.Push(myStackPath.Pop());

                //sb = sb.Append("/");
                //sb = sb.Append(myStackPath.Pop());
            }

            System.Text.StringBuilder st = new System.Text.StringBuilder();
            while (srev.Count != 0)
            {
                st.Append("/");
                st = st.Append(srev.Pop());
              
            }

            string pp = st.ToString();
            if (pp != string.Empty)
            {
                return pp;
            }

            string p = sb.ToString();

            if (p == String.Empty)
            {
                return "/";
            }

            return null;
            //System.Text.StringBuilder s = new System.Text.StringBuilder();
            //for (int i = p.Length - 1; i >= 0; i--)
            //{
            //    s.Append(p[i]);
            //}

            //return s.ToString();


        
    }

        public static  string largestNumber(List<int> A)
        {

            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            List<string> newList = A.ConvertAll<string>(delegate (int i) { return i.ToString(); });
            newList.Sort(myCompare);

            // [1,3,2,40,50,99,100] 995040123100

            for (int i = 0; i < A.Count; i++)
            {
                sb = sb.Append(newList[i]);
            }
            if (sb[0] == '0' && sb.Length > 1)
            {
                return "0";
            }
            else
                return sb.ToString();

        }

        public static int myCompare(string k1, string k2)
        {

            string XY = k1 + k2;
            string YX = k2 + k1;


            return YX.CompareTo(XY);//0 ? -1 : 1;
        }

        public static List<int> solveCommonElements(int[] A,int[] B)
        {

            int[] a = A.ToArray();
            int[] b = B.ToArray();

            Array.Sort(a);
            Array.Sort(b);

            Dictionary<int, int> Aa = new Dictionary<int, int>();
            List<int> ret = new List<int>();

            foreach (int i in a)
            {
                if (Aa.ContainsKey(i))
                {
                    Aa[i] += 1;
                }
                else
                {
                    Aa.Add(i, 1);
                }
            }

            for (int i = 0; i < b.Length; i++)
            {

                if (Aa.ContainsKey(b[i]) && Aa[b[i]] > 0)
                {
                    ret.Add(b[i]);
                    Aa[b[i]] -= 1;
                }
            }

            return ret;
        }
        // 2 ,-7 , -11, 15  B= 8
        public static List<int> twoSum(int[] A, int B)
        {

            int[] a = A.ToArray();

            Dictionary<int, int> index = new Dictionary<int, int>();
            Dictionary<int, int> sum = new Dictionary<int, int>();
            List<int> v = new List<int>();
            int one = 0;
            int second = 0;

            int index1 = 0;
            int index2 = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (!index.ContainsKey(a[i]))
                {
                    index.Add(a[i], i + 1);

                }
            }

            for (int j = 0; j < a.Length; j++)
            {
                int bp = B - a[j];
                if (index.ContainsKey(bp))
                {
                    one = bp;
                    index1 = index[bp];
                    index.Remove(bp);
                    break;
                }
            }

            int y = B - one;

            if (index.ContainsKey(y))
            {
                index2 = index[y];
            }


            v.Add(index1);
            v.Add(index2);

            return v;



        }

        public static List<List<int>> solveRot(int[] A, int[] B)
        {

            int[] mainArray = A.ToArray();
            int[] rotationArray = B.ToArray();

            List<List<int>> ret = new List<List<int>>();
            List<int> toAdd = new List<int>();
            for (int i = 0; i < rotationArray.Length; i++)
            {
                int rotate = B[i];
                int[] temp = new int[rotate];
                for (int j = 0; j < rotate; j++)
                {
                    temp[j] = mainArray[j];

                }

                for (int p = 0; p < rotate; p++)
                {
                    mainArray[p] = mainArray[p + rotate];
                }

                for (int k = rotate; k < mainArray.Length; k++)
                {
                    if( (k - rotate) < temp.Length)
                    {
                        mainArray[k] = temp[k - rotate];
                    }
                   
                }

                ret.Add(mainArray.ToList());

            }
           // ret.Add(toAdd);
            return ret;
        }
        public static int solveHash(int[] A, int B)
        {

            int[] a = A.ToArray();
            int count = 0;

            Dictionary<int, int> istic = new Dictionary<int, int>();
            foreach (int i in a)
            {
                istic.Add(i, 1);
            
            }

            for (int i = 0; i < a.Length; i++)
            {
                int ap = a[i] ^ B;
                if (istic.ContainsKey(ap))
                {
                    count++;
                }
            }

            

            return count/2;
        }

        public static List<int> solveLP(List<int> A, List<int> B)
        {

            // B:[20, 4, 10, 2]

            // A: [3, 4, 4, 6]

            int[] a = A.ToArray();
            int[] b = B.ToArray();

            List<int> ab = new List<int>();
            int sum = 0;
            int count = 0;
            for (int i = 0; i < b.Length; i++)
            {
                sum = 0;
                for(int j = 0; j < a.Length; j++)
                {
                    sum = sum + a[j];
                    if (sum > b[i])
                    {
                        ab.Add(j);
                        break;
                    }
                    else if (j == a.Length - 1 && sum < b[i])
                    {
                        ab.Add(a.Length);
                    }
                    
                }

                
            }
            return ab;
        }
        public static int solve(string A)
        {
            
            
            char[] a = A.ToArray();
            int start = 0;
            int end = a.Length - 1;

            int isPallindrom = isPalin(a, start, end);

            if (isPallindrom == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public static int isPalin(char[] a, int start, int end)
        {
            if (start >= end)
            {
                return 1;
            }
            if (a[start] != a[end])
            {
                return 0;

            }

            return isPalin(a, start+1, end-1);
        }

        public static void solvePT(int A)
        {
            List<List<int>> bt = new List<List<int>>();
            int val = 1;
            for (int i = 0; i < A; i++)
            {
              
                List<int> it = new List<int>();
                for (int j = 0; j <= i; j++)
                {
                   
                    if (j == 0 || i == 0)
                        val = 1;
                    else
                        val = val * (i - j + 1) / j;
                    it.Add(val);
                }
                bt.Add(it);

               
            }
        }
        public static  int titleToNumber(string A)
        {
            char[] a = A.ToArray();
            int basePower = A.Length;
            double returnExcelRowNumber = 0;

            if (a.Length == 1)
            {
                return a[0] - 64;
                
            }

            for(int i = 0; i < a.Length; i++)
            {
                //while (basePower >= 0)
                //{

                    returnExcelRowNumber += (a[i] - 64) * Math.Pow(26, i);
                  //  basePower--;
                //}

            }
            return Convert.ToInt32(returnExcelRowNumber);

        }

        public static  int solveMaxMin(List<int> A)
        {

            int[] arr = A.ToArray();

            int maxEven = 0;
            int minOdd = Int32.MaxValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    if (arr[i] > maxEven)
                    {
                        maxEven = arr[i];
                    }
                }
                else
                {
                    if (arr[i] < minOdd)
                    {
                        minOdd = arr[i];
                    }
                }
            }

            return maxEven - minOdd;
        }

        public static int reverse(int A)
        {
            int finalNumber = 0;
            int number = 0;

            if (A < 0)
            {
                number = A * -1;
            }

            while (number != 0)
            {
                int remainder = number % 10;

                finalNumber = finalNumber * 10 + remainder;
                number = number / 10;
            }


            if (A <= 0)
            {
                return finalNumber * -1;
            }
            else
            {
                return finalNumber;
            }
        }

        public static int solveMultiAr(List<List<int>> A)
        {

            int[][] arrays = A.Select(a => a.ToArray()).ToArray();
            int rowOneCount = 0;
            int bestMaxCount = 0;
            int rowReturn = 0;

            for (int i = 0; i < arrays.Length; i++)
            {
                for (int j = 0; j < arrays.Length; j++)
                {
                    if (arrays[i][j] == 1)
                    {
                        rowOneCount++;
                       
                    }

                    
                }
                if (rowOneCount > bestMaxCount)
                {
                    bestMaxCount = rowOneCount;
                    rowReturn = i;
                  
                }
                rowOneCount = 0;
            }

            
            return rowReturn;
        }


        public static int majorityElement(List<int> A)
        {

            int[] a = A.ToArray();

            Array.Sort(a);

            if (a.Length == 1)
            {
                return a[0];
            }
            int majority = a.Length / 2 + 1;
            Dictionary<int, int> arrayItemsCount = new Dictionary<int, int>();

            for (int i = 0; i < a.Length; i++)
            {
                if (arrayItemsCount.ContainsKey(a[i]))
                {
                    //update the value by one of the key 
                    arrayItemsCount[a[i]] += 1;
                }
                else
                {
                    //adding that element to the dictionary
                    arrayItemsCount.Add(a[i], 1);
                }

            }

            //Now we have to find the maximum in the dictionary
            var maxCount = arrayItemsCount.Values.Max();

            //Then compare it with the arr.legth / 2 + 1 if yes return that number key
            int v = 0;
            if (maxCount <= majority)
            {
                // find that number and find the key
                v = arrayItemsCount.FirstOrDefault(x => x.Value == maxCount).Key;

            }
            return v;


        }

        public static int solveRowColumnNumberFind(List<List<int>> A, int B)
        {

            int[][] arr = A.Select(a => a.ToArray()).ToArray();
            int seenAll = 0;
            int countBreak = 0;
            for (int i = 0; i < arr.GetLength(0) ; i++)
            {
                for (int j = 0; j < arr.GetLength(1) ; j++)
                {
                    if (arr[i][j] == B)
                    {
                        seenAll++;
                        countBreak = 1;
                        return ((i * 1009) + 2);

                    }
                    else
                    {
                        countBreak = 0;
                        continue;
                    }

                }

            }

            return -1;
        }
    }
}
