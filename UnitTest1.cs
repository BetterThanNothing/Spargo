using System;
using System.Collections.Generic;
using DestinationPoints;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var source = new List<Tuple<string, string>>
            {
                new Tuple<string, string>("Мельбурн", "Кельн"),
                new Tuple<string, string>("Берлин", "Токио"),
                new Tuple<string, string>("Москва", "Париж"),
                new Tuple<string, string>("Кельн", "Москва"),
                new Tuple<string, string>("Париж", "Берлин")
            };

            var target = new List<Tuple<string, string>>
            {
                new Tuple<string, string>("Мельбурн", "Кельн"),
                new Tuple<string, string>("Кельн", "Москва"),
                new Tuple<string, string>("Москва", "Париж"),
                new Tuple<string, string>("Париж", "Берлин"),
                new Tuple<string, string>("Берлин", "Токио")
            };

            var result = Program.GetRoute(source);
            CollectionAssert.AreEqual(target, result);
        }
    }
}
