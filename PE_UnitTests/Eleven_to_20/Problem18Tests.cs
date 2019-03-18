using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CodeLibrary;
using ProjectEuler;

namespace PE_UnitTests.Eleven_to_20
{
    [TestClass]
    public class Problem18Tests
    {
        public static readonly int[] exampleTriangle = 
            new int[] {
                3,
                7, 4,
                2, 4, 6,
                8, 5, 9, 3
        };

        [TestMethod]
        public void SimplePath_Test()
        {
            NumberTriangle t = new NumberTriangle(exampleTriangle);
            int size = t.MaxRows;

            for (int row=1; row<t.MaxRows; row++)
            {
                for (int item=1; item<=row; item++)
                {
                    int node = t.GetElement(row,item);
                    int left = t.GetLeftChild(row, item);
                    int right = t.GetRightChild(row, item);
                    $"[{row},{item}]:{node} => Left:{left}, Right:{right}".ToConsole();
                }                
            }
        }


        [TestMethod]
        public void GetSize_Test()
        {
            int[] set1 = exampleTriangle;
            set1.ToConsole();
            $"size: {NumberTriangle.GetSize(set1.Length)}".ToConsole();

            int[] set2 = new int[] {
                0,
                1, 2,
                3, 4, 5,
                6, 7, 8, 9,
                10, 11, 12, 13, 14
            };

            set2.ToConsole();
            $"size: {NumberTriangle.GetSize(set2.Length)}".ToConsole();
        }

        [TestMethod]
        public void GetElement_Test()
        {
            var t = new NumberTriangle(exampleTriangle);
            int x = t.GetElement(3, 1);
            int y = t.GetElement(3, 2);
            int z = t.GetElement(3, 3);            
            $"GetElement expecting 2, got {x}".ToConsole();
            $"GetElement expecting 4, got {y}".ToConsole();
            $"GetElement expecting 6, got {z}".ToConsole();
            Assert.AreEqual(2, x);
            Assert.AreEqual(4, y);
            Assert.AreEqual(6, z);

            int check = t.GetElement(4, 4);
            $"GetElement expecting 3, got {check}".ToConsole();
            Assert.AreEqual(3, check);
        }

        [TestMethod]
        public void GetLeftRightPath_Tests()
        {
            var t = new NumberTriangle(exampleTriangle);
            int xL = t.GetLeftChild(3, 1);
            int xR = t.GetRightChild(3, 1);
            int yL = t.GetLeftChild(3, 2);
            int yR = t.GetRightChild(3, 2);
            int zL = t.GetLeftChild(3, 3);
            int zR = t.GetRightChild(3, 3);
            // 8, 5, 9, 3
            $"GetLeftChild expecting 8, got {xL}".ToConsole();
            $"GetRightChild expecting 5, got {xR}".ToConsole();
            $"GetLeftChild expecting 5, got {yL}".ToConsole();
            $"GetRightChild expecting 9, got {yR}".ToConsole();
            $"GetLeftChild expecting 9, got {zL}".ToConsole();
            $"GetRightChild expecting 3, got {zR}".ToConsole();            
            Assert.AreEqual(8, xL);
            Assert.AreEqual(5, xR);
            Assert.AreEqual(5, yL);
            Assert.AreEqual(9, yR);
            Assert.AreEqual(9, zL);
            Assert.AreEqual(3, zR);            
        }
    }
}
