using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Allors;

namespace Iseries
{
    public partial class DateTimeCell : Cell
    {
        public static DateTimeCell Create(AllorsSession session, Row row, DateTime value)
        {
            var obj = session.Create<DateTimeCell>();
            obj.Value = value;

            row.AddCell(obj);
            return obj;
        }
    }
}
