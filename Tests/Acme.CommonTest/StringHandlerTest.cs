using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Acme.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpacesTestValid()
        {
            var source = "BobRoss";
            var expected = "Bob Ross";   

            var actual = StringHandler.InsertSpaces(source);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsertSpacesTEsWithExistingSpace()
        {
            var source = "Bob Ross";
            var expected = "Bob Ross";

            var actual = StringHandler.InsertSpaces(source);

            Assert.AreEqual(expected, actual);
        }
    }
}
