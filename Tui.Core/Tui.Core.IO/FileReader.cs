using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tui.Core.IO
{
    public abstract class FileReader
    {
        public abstract string FileName { get; }

        public abstract string Read();
    }
}
