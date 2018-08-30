using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2
{
    [TestFixture]
    public class Class1
    {
        [TestCase]
        public void login()
        {
            MiddleWare  mw = new MiddleWare();
            Assert.AreEqual(1, mw.login("megha@gmail.com", "megha"));
          
        }


    }

 
}