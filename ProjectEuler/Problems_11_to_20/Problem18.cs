using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjectEuler;
using CodeLibrary;

namespace ProjectEuler
{
    /// <summary>
    /// Maximum path sum I
    /// </summary>
    /// <remarks>
    /// By starting at the top of the triangle below and moving to adjacent numbers on the row below, the maximum total from top to bottom is 23.        
    ///    3    
    ///   7 4
    ///  2 4 6
    /// 8 5 9 3
    /// That is, 3 + 7 + 4 + 9 = 23.
    /// Find the maximum total from top to bottom of the triangle below:
    ///                             75
    ///                           95  64
    ///                         17  47  82
    ///                       18  35  87  10
    ///                     20  04  82  47  65
    ///                   19  01  23  75  03  34
    ///                 88  02  77  73  07  63  67
    ///               99  65  04  28  06  16  70  92
    ///             41  41  26  56  83  40  80  70  33
    ///           41  48  72  33  47  32  37  16  94  29
    ///         53  71  44  65  25  43  91  52  97  51  14
    ///       70  11  33  28  77  73  17  78  39  68  17  57
    ///     91  71  52  38  17  14  91  43  58  50  27  29  48
    ///   63  66  04  68  89  53  67  30  73  16  69  87  40  31
    /// 04  62  98  27  23  09  70  98  73  93  38  53  60  04  23
    /// 
    /// NOTE: As there are only 16384 routes, it is possible to solve this problem by trying every route.However, Problem 67, is the same challenge with a triangle containing one-hundred rows; it cannot be solved by brute force, and requires a clever method! ;o)
    /// </remarks>
    

    public class Problem18 : IPEProblem
    {
        public Problem18()
        {

        }

        public string Answer => _getOutput();

        public void ShowAnswer(object problemSize)
        {
            "*Problem 18*".ToConsole();
            Answer.ToConsole();
        }

        private string _getOutput()
        {
            return "";
        }
    }

    public class NumberTriangle
    {
        public int CurrentRow { get; set; }
        public int CurrentItem { get; set; }

        public NumberTriangle()
        {
            CurrentRow = 0;
            CurrentItem = 0;
        }

        public NumberTriangle(int size) : this()
        {
            _size = size;
            _cells = new int[1 + _size.RangeSum()];
        }

        public NumberTriangle(int[] numbers) : this()
        {
            _size = GetSize(numbers.Length);
            _cells = new int[numbers.Length];
            Array.Copy(numbers, _cells, numbers.Length);            
        }

        public int MaxRows => _size;
        private int _size;
        private int[] _cells { get; set; }

        public static int GetSize(int collectionsize)
        {
            int size = 0;
            int rowsize = 0;
            while (size < collectionsize)
            {
                rowsize += 1;
                size += rowsize;                
            }
            return rowsize;
        }

        public static int GetSize(int[] triangleArray)
        {
            return GetSize(triangleArray.Length);            
        }

        public int[] GetRow(int rowNumber)
        {
            List<int> row = new List<int> { };
            int start = rowNumber.RangeSum();
            int end = rowNumber.RangeSum() + rowNumber;
            for (int i=start; i<=end; i++)
            {
                row.Append(this._cells[i]);
            }
            CurrentRow = rowNumber;
            return row.ToArray();
        }

        public int GetElement(int row, int item)
        {
            return _cells[GetIndex(row, item)];
        }

        public int GetIndex(int row, int item)
        {            
            return row.RangeSum() + item - 1;            
        }

        public int GetLeftChild()
        {
            return GetLeftChild(CurrentRow, CurrentItem);
        }

        public int GetRightChild()
        {
            return GetRightChild(CurrentRow, CurrentItem);
        }

        public int GetLeftChild(int row, int item)
        {
            if (row == MaxRows) return 0;
            // return _cells[GetIndexLeftPath(row, item)];
            return GetElement(row + 1, item);
        }

        public int GetRightChild(int row, int item)
        {
            if (row == MaxRows) return 0;
            // return _cells[GetIndexRightPath(row, item)];
            return GetElement(row + 1, item + 1);
        }

        public int GetIndexLeftPath(int row, int item)
        {
            return GetIndex(row + 1, item);
        }

        public int GetIndexRightPath(int row, int item)
        {
            return GetIndex(row + 1, item + 1);
        }

        public void FromIndex(out int row, out int item)
        {
            
            row = 0;
            item = 0;
        }

        public IEnumerable<int> MaxPath()
        {
            CurrentRow = 1;
            CurrentItem = 1;
            yield return GetElement(CurrentRow, CurrentItem);
            for (int row = 1; row <= MaxRows; row++)
            {

            }
        }

    }

    public static partial class ExtensionMethods
    {
        public static int[] ToRange(this int number)
        {
            List<int> result = new List<int> { };
            for (int i=0; i<number; i++)
            {
                result.Add(i);
            }
            return result.ToArray();
        }

        public static int RangeSum(this int number)
        {
            return number.ToRange().Sum();
        }
    }
    
}
