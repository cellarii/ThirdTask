using Microsoft.VisualStudio.TestTools.UnitTesting;
using ThirdTask;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdTask.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void OnlyLetters()
        {
            var str = "Тест";
            
            var result=Logic.Calculation(str);

            Assert.AreEqual(100, result);
        }

        [TestMethod()]
        public void SpaceSeparator()
        {
            var str = "Тест тест";

            var result = Logic.Calculation(str);

            Assert.AreEqual(88.89, result);
        }

        [TestMethod()]
        public void MultipleSpaces()
        {
            var str = "Тест   тест";

            var result = Logic.Calculation(str);

            Assert.AreEqual(72.73, result);
        }

        [TestMethod()]
        public void SeparatorPunctuationMark()
        {
            var str = "Тест,тест";

            var result = Logic.Calculation(str);

            Assert.AreEqual(88.89, result);
        }

        [TestMethod()]
        public void MultiplePunctuationMark()
        {
            var str = "Тест,!^тест";

            var result = Logic.Calculation(str);

            Assert.AreEqual(72.73, result);
        }

        [TestMethod()]
        public void BasicCase()
        {
            var str = "Тест, который выполнится!";

            var result = Logic.Calculation(str);

            Assert.AreEqual(84, result);
        }

    }
}