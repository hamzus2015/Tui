using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Tui.Core.IO.Security
{
    public interface IPermissionProvider
    {
        ICollection<FilePermission> Permissions { get; set; }


        bool HasRight(string role, Right right, string fileName);
    }
}
