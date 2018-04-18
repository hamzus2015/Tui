using System.Collections.Generic;
using System.Linq;

namespace Tui.Core.IO.Security
{
    public class FilePermission
    {
        
        public Dictionary<string,Right[]> Rights { get; set; }

        public string FileName { get; set; }

        public FilePermission(string fileName)
        {
            this.FileName = fileName;
        }
        public bool HasRight(string role,Right right)
        {
            //var rightsOfRole = Rights[role];
            //rightsOfRole.Where(r => r == right).SingleOrDefault();

            return Rights[role].Where(r => r == right).SingleOrDefault() != null;
        }
    }
}