using System;
using System.IO;
using System.Xml;

namespace Tui.Core.IO
{
    public class XmlFileReader:FileReader
    {
        private string _fileName;

        public XmlFileReader(string fileName)
        {
            this._fileName = fileName;
        }

        public override string FileName
        {
            get
            {
                return _fileName;
            }
        }      

        public override string Read()
        {
            XmlDocument doc = new XmlDocument();
            StringWriter strWriter = new StringWriter();
            XmlTextWriter xmlTextWriter = new XmlTextWriter(strWriter);

            doc.Load(_fileName);

            doc.WriteTo(xmlTextWriter);

            return strWriter.ToString();
        }
    }
}
