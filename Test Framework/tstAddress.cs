﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Framework
{
    [TestClass]
    public class tstAddress
    {
        [TestMethod]
        public void TestMethod1()
        {
            //create an instance of our class address
            clsAddress AnAddress = new clsAddress();
            //check to see if the class is not null
            Assert.IsNotNull(AnAddress);

        }
    }
}
