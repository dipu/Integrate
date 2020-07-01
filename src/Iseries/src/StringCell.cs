using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Allors;

namespace Iseries
{
    public partial class StringCell : Cell
    {
        public static StringCell Create(AllorsSession session, Row row, string value)
        {
            var obj = session.Create<StringCell>();
            obj.Value = value;

            row.AddCell(obj);
            return obj;
        }
    }
}
