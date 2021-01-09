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
            var handler = new StringHandler();

            var actual = handler.InsertSpaces(source);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsertSpacesTEsWithExistingSpace()
        {
            var source = "Bob Ross";
            var expected = "Bob Ross";
            var handler = new StringHandler();

            var actual = handler.InsertSpaces(source);

            Assert.AreEqual(expected, actual);
        }
    }
}
