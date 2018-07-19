using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArchitectureDemo.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureDemo.Logic.Tests
{
    [TestClass()]
    public class GreetingTests
    {
        [TestMethod()]
        public void 결과가_Hello로_시작하여야_함()
        {
            Greeting greeting = new Greeting();
            string text = greeting.SayHello("Tomas");

            Assert.AreEqual(true, text.StartsWith("Hello"));
        }

        [TestMethod()]
        public void 글자수가_매개변수보다_7이_커야_함()
        {
            Greeting greeting = new Greeting();
            string name = "Tomas";
            string text = greeting.SayHello(name);

            Assert.AreEqual(name.Length+7, text.Length);
        }
    }
}