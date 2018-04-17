using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tui.Core.IO;
using Tui.Core.IO.Cryptography;

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

        [TestMethod()]
        public void ReadEncodedTest()
        {
            ReverseEncryption encryptionStrategy = new ReverseEncryption();
            TextFileReader reader = new TextFileReader("encryptedText.txt", encryptionStrategy);
            string decodedText = reader.ReadEncoded();
            Assert.AreEqual(decodedText,"hello");
        }
    }
}
