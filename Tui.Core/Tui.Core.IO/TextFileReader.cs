using System;
using System.IO;
using Tui.Core.IO.Cryptography;

namespace Tui.Core.IO
{
    public class TextFileReader:FileReader
    {
        public TextFileReader(string fileName)
        {
            this.FileName = fileName;
        }

        public TextFileReader(string fileName,ICryptographyStrategy decodingStrategy)
        {
            this.FileName = fileName;
            this.DecodingStrategy = decodingStrategy;
        }       


        public override string Read()
        {
            FileInfo fileInfo = new FileInfo(this.FileName);

            using (var fs = fileInfo.OpenText())
            {
                return fs.ReadToEnd();
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
