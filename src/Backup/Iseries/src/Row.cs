using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Allors;

namespace Iseries
{
    public partial class Row
    {
        public static Row Create(AllorsSession session, Table table)
        {
            var obj = session.Create<Row>();

            table.AddRow(obj);
            return obj;
        }
    }
}
