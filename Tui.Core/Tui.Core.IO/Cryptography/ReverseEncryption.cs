using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tui.Core.IO.Cryptography
{
    public class ReverseEncryption : ICryptographyStrategy
    {
        public string Decode(string encodedText)
        {
            return new String(encodedText.Reverse().ToArray());
        }

        public string Encode(string plainText)
        {
            return new String(plainText.Reverse().ToArray());
        }
    }
}
