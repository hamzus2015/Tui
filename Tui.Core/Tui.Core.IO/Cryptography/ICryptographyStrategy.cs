using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tui.Core.IO.Cryptography
{
    public interface ICryptographyStrategy
    {
        string Encode(string plainText);

        string Decode(string encodedText);
    }
}
