using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Allors;

namespace Iseries
{
    public partial class DecimalCell : Cell
    {
        public static DecimalCell Create(AllorsSession session, Row row, decimal value)
        {
            var obj = session.Create<DecimalCell>();
            obj.Value = value;

            row.AddCell(obj);
            return obj;
        }
    }
}
