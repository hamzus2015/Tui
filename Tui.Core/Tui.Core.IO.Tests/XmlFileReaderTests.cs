using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tui.Core.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tui.Core.IO.Tests
{
    [TestClass()]
    public class XmlFileReaderTests
    {
        [TestMethod()]
        public void ReadTest()
        {
            XmlFileReader xmlReader = new XmlFileReader("XMLFile1.xml");
            string content = xmlReader.Read();

            Assert.Equals(content, @"<tui><core><io>FileReader library</io></core></tui>");
        }
    }
}