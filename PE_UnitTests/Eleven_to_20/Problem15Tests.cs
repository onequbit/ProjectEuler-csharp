﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeLibrary;
using ProjectEuler;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;

namespace PE_UnitTests.Eleven_to_20
{
    [TestClass]
    public class Problem15Tests
    {
        /*
            1
            1,1
            1,2,1
            1,3,3,1
            1,4,6,4,1
            1,5,10,10,5,1
            1,6,15,20,15,6,1
            1,7,21,35,35,21,7,1
            1,8,28,56,70,56,28,8,1
            1,9,36,84,126,126,84,36,9,1
            1,10,45,120,210,252,210,120,45,10,1
            1,11,55,165,330,462,462,330,165,55,11,1
            1,12,66,220,495,792,924,792,495,220,66,12,1
            1,13,78,286,715,1287,1716,1716,1287,715,286,78,13,1
            1,14,91,364,1001,2002,3003,3432,3003,2002,1001,364,91,14,1
        */
        [TestMethod]
        public void PascalsTriangle_Tests()
        {            
            for (int i = 1; i <= 40; i++)
            {
                var result = Problem15.PascalsTriangle(i, i / 2);
                $"{i} :=> {result}".ToConsole();
            }                        
        }

        [TestMethod]
        public void Factorial_Tests()
        {
            for (BigInteger i = 1; i <= 21; i++)
            {
                var result = i.Factorial();
                $"{i} :=> {result}".ToConsole();
            }
        }

    }
}
