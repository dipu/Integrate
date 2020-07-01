using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Allors;

namespace Iseries
{
    public class CellFactory
    {
       public static Cell Create(AllorsSession session, Row row, Column col, object value)
       {
           switch (col.DbType)
           {
               case "System.String":
                return StringCell.Create(session, row, (string)value);
               case "System.Integer":
               case "System.Int32":
                   return IntCell.Create(session, row, (int) value);
               case "System.Decimal":
                   return DecimalCell.Create(session, row, (decimal) value);
               case "System.DateTime":
                   return DateTimeCell.Create(session, row, (DateTime)value);
               default:
                   throw new Exception("Type not supported exception");
           }
       }
    }
}
