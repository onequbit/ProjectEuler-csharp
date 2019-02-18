using System;
using System.Collections.Generic;
using System.Text;
using ProjectEuler;
using CodeLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PE_UnitTests.Eleven_to_20
{
    [TestClass]
    public class Problem17Tests
    {
        [TestMethod]
        public void Constructor_Test()
        {
            for (int i = 0; i < 20; i++)
            {
                new Number(i).ToString().Print(); ", ".Print();
            }
            "".ToConsole();
            for (int i = 20; i < 200; i++)
            {
                new Number(i).ToString().Print(); ", ".Print();
            }
        }

        [TestMethod]
        public void RandomNumber_Test()
        {
            for (int i=0; i < 10; i++)
            {
                int value = RndLib.RandomInt(1, 2000);
                string word = new Number(value).ToString();
                $"{value} :=> {word}".ToConsole();
            }
            for (int i = 0; i < 10; i++)
            {
                int value = RndLib.RandomInt(900, 90000);
                string word = new Number(value).ToString();
                $"{value} :=> {word}".ToConsole();
            }

        }

        [TestMethod]
        public void BuildNumberWordList_Test()
        {
            string wordList = Problem17.BuildNumberWordList(1, 5);
            string wordListStripped = Problem17.StripWhiteSpace(wordList);
            int letterCount = Problem17.StripWhiteSpace(wordList).Length;
            $"{wordListStripped} => {letterCount} characters".ToConsole();
            
        }

        [TestMethod]
        public void CountLetters_Tests()
        {
            int number1 = 342;
            string number1Str = new Number(number1).ToString();
            int number1Count = Problem17.CountLetters(number1Str);
            $"{number1} : {number1Str} => {number1Count}".ToConsole();
            int number2 = 115;
            string number2Str = new Number(number2).ToString();
            int number2Count = Problem17.CountLetters(number2Str);
            $"{number2} : {number2Str} => {number2Count}".ToConsole();
        }
    }
}
