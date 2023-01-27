using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyMathImplementation
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static List<int> GenericSort(List<int> toSort, Func<int, int, int> isInOrder)
        {
            throw new NotImplementedException();
        }

        public static List<int> GetAllPrimary(int a)
        {
            List<int> list = new List<int>();

            for (int i = 2; i <= a; i++)
            {
               if (IsPrimary(i) == true) list.Add(i);
            }
            return list;
        }

        public static bool IsDivisible(int a, int b)
        {
            if (a % b == 0) return true;
            else return false;
        }

        public static bool IsEven(int a)
        {
            if (a % 2 == 0) return true;
            else return false;
        }

        public static int IsInOrder(int a, int b)
        {
            if ( a < b ) return 1;
            else if ( a > b ) return -1;
            else return 0;
        }

        public static int IsInOrderDesc(int arg1, int arg2)
        {
            throw new NotImplementedException();
        }

        public static bool IsListInOrder(List<int> list)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i] > list[i + 1])
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsMajeur(int age)
        {

            if (age < 0 || age >= 150) { throw new ArgumentException(); }
            else if (age >= 18) { return true; }
            else { return false; }
        }

        public static bool IsPrimary(int a)
        {
            for (int i = 2; i < a; i++)
            {
                if (a%i == 0) { return false; }
            }
            return true;
        }

        public static int Power(int a, int b)
        {
            int result = a;

            for (int i = 0; i < b-1; i++)
            {
                result = result * a;
            }
            return result;
        }

        public static int Power2(int a)
        {
            a = a * a;
            return a;
        }

        public static List<int> Sort(List<int> toSort)
        {
            int temp;
            for (int i = 0; i < toSort.Count - 1; i++)
            {
                for (int j = 0; j < toSort.Count - 1 - i; j++)
                {
                    if (toSort[j] > toSort[j + 1])
                    {
                        temp = toSort[j + 1];
                        toSort[j + 1] = toSort[j];
                        toSort[j] = temp;
                    }
                }
            }
            return toSort;
        }
    }
}