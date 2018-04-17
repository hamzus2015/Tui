using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tui.Core.IO.Cryptography;

namespace Tui.Core.IO
{
    public abstract class FileReader
    {
        public string FileName { get; set; }

        protected ICryptographyStrategy DecodingStrategy { get; set; }

        public abstract string Read();

        public abstract string ReadEncoded();

        public abstract string ReadEncoded(Func<string, string> encryptingMethod);
    }
}
