using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Allors;

namespace Iseries
{
    public partial class IntCell : Cell
    {
        public static IntCell Create(AllorsSession session, Row row, int value)
        {
            var obj = session.Create<IntCell>();
            obj.Value = value;

            row.AddCell(obj);
            return obj;
        }
    }
}
