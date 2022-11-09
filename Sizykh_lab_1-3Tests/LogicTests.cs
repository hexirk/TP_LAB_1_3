using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sizykh_lab_1_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sizykh_lab_1_3.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void Reverse()
        {
            var str = "Проверка предложения";
            var result = Logic.Reverse(str);
            Assert.AreEqual("Перевернутое предложение: \nпредложения Проверка ",result);
        }

        [TestMethod()]
        public void Reverse1word()
        {
            var str = "Проверка";
            var result = Logic.Reverse(str);
            Assert.AreEqual("Перевернутое предложение: \nПроверка ", result);
        }
    }
}