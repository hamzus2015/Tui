﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tui.Core.IO
{
    public class TextFileReader
    {
        private string _fileName;

        public TextFileReader(string fileName)
        {
            this._fileName = fileName;
        }

        public string Read()
        {
            FileInfo fileInfo = new FileInfo(this._fileName);  

            var fs = fileInfo.OpenText();

            return fs.ReadToEnd();
        }
    }
}