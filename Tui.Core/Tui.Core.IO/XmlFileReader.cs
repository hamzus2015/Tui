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
            doc.Load(_fileName);

            using (StringWriter strWriter = new StringWriter())
            using (XmlTextWriter xmlTextWriter = new XmlTextWriter(strWriter))
            {  
                doc.WriteTo(xmlTextWriter);
                return strWriter.ToString();
            }
         
        }
    }
}
