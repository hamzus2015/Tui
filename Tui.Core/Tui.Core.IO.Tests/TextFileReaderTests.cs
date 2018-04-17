using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tui.Core.IO;

namespace Tui.Core.IO.Tests
{
    [TestClass]
    public class TextFileReaderTests
    {
        [TestMethod]
        public void ReadSimpleTextTest()
        {
            TextFileReader reader = new TextFileReader("test1.txt");
            var content = reader.Read();

            Assert.AreEqual(content, "hello");
        }
    }
}
