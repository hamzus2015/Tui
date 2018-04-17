using System;
using System.IO;
using System.Xml;
using Tui.Core.IO.Cryptography;

namespace Tui.Core.IO
{
    public class XmlFileReader:FileReader
    {      
        

        public XmlFileReader(string fileName)
        {
            this.FileName = fileName;
        }

        public XmlFileReader(string fileName,ICryptographyStrategy decodingStrategy)
        {
            this.FileName = fileName;
            this.DecodingStrategy = decodingStrategy;

        }
       

        public override string Read()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(FileName);

            using (StringWriter strWriter = new StringWriter())
            using (XmlTextWriter xmlTextWriter = new XmlTextWriter(strWriter))
            {  
                doc.WriteTo(xmlTextWriter);
                return strWriter.ToString();
            }
         
        }

        public override string ReadEncoded(Func<string, string> encryptingMethod)
        {
            string content = this.Read();
            return encryptingMethod(content);
        }

        public override string ReadEncoded()
        {
            string content = this.Read();
            return DecodingStrategy.Decode(content);
        }
    }
}
