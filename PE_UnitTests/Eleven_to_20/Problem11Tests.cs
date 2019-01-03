using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeLibrary;
using ProjectEuler;
using System;

namespace PE_UnitTests.Eleven_to_20
{
    [TestClass]
    public class Problem11Tests
    {
                
        [TestMethod]
        public void Constructor_Test()
        {
            // Arrange
            var p11 = new Problem11();

            // Act

            // Assert
            Assert.IsNotNull(p11, "Problem11() Constructor is null");            
        }

        [TestMethod]
        public void Grid_Tests()
        {
            var p11 = new Problem11();

            Assert.AreEqual(p11.GetCell(0, 0), 08, "cells are not equal");
            Assert.AreEqual(p11.GetCell(1, 1), 49, "cells are not equal");
            Assert.AreEqual(p11.GetCell(2, 3), 73, "cells are not equal");
            Assert.AreEqual(p11.GetCell(4, 5), 67, "cells are not equal");
            Assert.AreEqual(p11.GetCell(19, 19), 48, "cells are not equal");
        }

        [TestMethod]
        public void Horizontal_Tests()
        {
            var p11 = new Problem11();

            int[] h1 = new int[4];
            int[] h2 = new int[4] { 8, 2, 22, 97 };
            h1 = p11.GetHorizontal(0, 0);
            Assert.IsTrue(h1.IsEqualTo(h2), "arrays are not equal");

            h1 = p11.GetHorizontal(0, 16);
            h2 = new int[4] { 50, 77, 91, 08 };
            Assert.IsTrue(h1.IsEqualTo(h2), "arrays are not equal");

            h1 = p11.GetHorizontal(19, 16);
            h2 = new int[4] { 89, 19, 67, 48 };
            Assert.IsTrue(h1.IsEqualTo(h2), "arrays are not equal");

        }

        [TestMethod]
        public void Vertical_Tests()
        {
            var p11 = new Problem11();

            int[] h1 = new int[4];
            int[] h2 = new int[4] { 8, 49, 81, 52 };
            h1 = p11.GetVertical(0, 0);
            Assert.IsTrue(h1.IsEqualTo(h2), "arrays are not equal");

            h1 = p11.GetVertical(16, 0);
            h2 = new int[4] { 4, 20, 20, 1 };
            Assert.IsTrue(h1.IsEqualTo(h2), "arrays are not equal");

            h1 = p11.GetVertical(16, 16);
            h2 = new int[4] { 40, 74, 23, 89 };
            Assert.IsTrue(h1.IsEqualTo(h2), "arrays are not equal");

        }

        [TestMethod]
        public void DiagonalDown_Tests()
        {
            var p11 = new Problem11();

            int[] h1 = new int[4];
            int[] h2 = new int[4] { 8, 49, 31, 23 };
            h1 = p11.GetDiagonalDown(0, 0);
            Assert.IsTrue(h1.IsEqualTo(h2), "arrays are not equal");

            h1 = p11.GetDiagonalDown(16, 16);
            h2 = new int[4] { 40, 4, 5, 48 };
            Assert.IsTrue(h1.IsEqualTo(h2), "arrays are not equal");

            h1 = p11.GetDiagonalDown(5, 5);
            h2 = new int[4] { 3, 67, 20, 97 };
            Assert.IsTrue(h1.IsEqualTo(h2), "arrays are not equal");

        }

        [TestMethod]
        public void DiagonalUp_Tests()
        {
            var p11 = new Problem11();

            int[] h1 = new int[4];
            int[] h2 = new int[4] { 1, 73, 36, 73 };
            h1 = p11.GetDiagonalUp(19, 0);
            Assert.IsTrue(h1.IsEqualTo(h2), "arrays are not equal");

            h1 = p11.GetDiagonalUp(19, 16);
            h2 = new int[4] { 89, 57, 36, 36 };
            Assert.IsTrue(h1.IsEqualTo(h2), "arrays are not equal");

            h1 = p11.GetDiagonalUp(3, 16);
            h2 = new int[4] { 37, 13, 62, 8 };
            Assert.IsTrue(h1.IsEqualTo(h2), "arrays are not equal");

        }

    }

    public static partial class ExtensionMethods
    {
        public static bool IsEqualTo<T>(this T[] source, T[] target)
        {
            if (source.Length != target.Length) return false;
            int length = source.Length;
            for (int i = 0; i < length; i++)
            { 
                var a = source.GetValue(i).ToString();
                var b = target.GetValue(i).ToString();
                if (!a.Equals(b)) return false;
            }
            return true;

        }

    }
}
