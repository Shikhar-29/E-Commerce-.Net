using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;

namespace WebApplication2
{
    [Parallelizable(ParallelScope.All)]
    public class Testing
    {
        MiddleWare mw = new MiddleWare();
        [SetUp]
        public void SetUp()
        { 
            Thread.Sleep(TimeSpan.FromSeconds(4));
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual(1, mw.login("megha@gmail.com", "megha"));

        }
        [Test]
        public void Test2()
        {
            Assert.AreEqual(1, mw.login("meg123ha@gmail.com", "megha"));

        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual(0, mw.click_1("t-shirt"));

        }


    }
}