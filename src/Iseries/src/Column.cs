using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Allors;

namespace Iseries
{
    public partial class Column
    {
        public static Column Create(AllorsSession session, Table table, string name, Type dbType)
        {
            var obj = session.Create<Column>();
            obj.Name = name;
            obj.DbType = dbType.ToString();

            table.AddColumn(obj);
            return obj;
        }
    }
}
