using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ignition.Framework.Core.DatabaseTypes
{
    public class CoreDatabaseType : IDatabaseType
    {
        public string GetDatabaseName() => "core";
    }
}
