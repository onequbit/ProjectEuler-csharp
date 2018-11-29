using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public static partial class ExtensionMethods
    {
        public static string With(this string str, params object[] values)
        {
            return string.Format(str, values);
        }

        public static void Print(this string str) => Console.Write(str);

        public static void ToConsole(this string str) => Console.WriteLine(str);

        public static void KeyPrompt(this string prompt)
        {
            prompt.Print();
            Console.ReadKey();
        }

        public static void EnterPrompt(this string prompt)
        {
            prompt.Print();
            Console.ReadLine();
        }

        public static int Sum(this HashSet<int> set)
        {
            int accumulator = 0;
            foreach (int i in set)
            {
                accumulator += i;
            }
            return accumulator;
        }

        public static int Sqrt(this int number)
        {
            return (int)Math.Sqrt(number);
        }

        public static long Sqrt(this long number)
        {
            return (long)Math.Sqrt(number);
        }

        public static List<string> ToStringList<T>(this IEnumerable<T> list)
        {
            List<string> output = new List<string> { };
            foreach (var item in list)
            {
                output.Add(item.ToString());
            }
            return output;
        }

        public static T[] ToArray<T>(this IEnumerable<T> source)
        {
            return new List<T>(source).ToArray();
        }

        public static string Join<T>(this T[] array, string str)
        {
            StringBuilder sb = new StringBuilder();
            for (int i=0; i<array.Length; i++)
            {
                sb.Append(array[i]);
                if (i != array.Length - 1)
                    sb.Append(str);
            }
            return sb.ToString();
        }

        public static void ToConsole<T>(this IEnumerable<T> list)
        {
            list.ToArray().Join(",").ToConsole();            
        }

        public static bool IsEmpty<T>(this HashSet<T> collection)
        {
            return collection.Count == 0;
        }

        public static void ToConsole<T>(
            this IEnumerable<T> list, string formatStr = "")
        {
            foreach(var item in list)
            {
                string.Format(formatStr,item).ToConsole();                
            }
        }

        public static bool IsMultipleOf(this int A, int B)
        {
            return A % B == 0;
        }

        public static bool IsMultipleOf(this long A, long B)
        {
            return A % B == 0;
        }
    }
}
