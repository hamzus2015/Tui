using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tui.Core.IO.Security
{
    public class InMemoryPermissionProvider : IPermissionProvider
    {
        private ICollection<FilePermission> _permissions;

        public InMemoryPermissionProvider()
        {
            this._permissions = new List<FilePermission>();
             var fp = new FilePermission("test1.txt")
             {
                 Rights = new Dictionary<string, Right[]>()
                 {
                     {"Admin",new Right[] {Right.Read} }
                 }
             };
            Permissions.Add(fp);
        }

        public ICollection<FilePermission> Permissions
        {
            get
            {
               return _permissions;
            }

            set
            {
                _permissions = value;
            }
        }

        public bool HasRight(string role, Right right, string fileName)
        {
            throw new NotImplementedException();
        }
    }
}
