using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Allors;
using IBM.Data.DB2.iSeries;

namespace Iseries
{
    public partial class Table
    {
        private iDB2Command command;

        public static Table Create(AllorsSession session, Library lib, string name)
        {
            var obj = session.Create<Table>();
            obj.Name = name;

            lib.AddTable(obj);
            return obj;
        }

        public void ExecuteReader(Session session)
        {
            string table = this.LibraryWhereTable.Name + "." + this.Name;
            command = new iDB2Command(table, session.Connection, session.Transaction);
            command.CommandTimeout = 0;
            command.CommandType = CommandType.TableDirect;

            try
            {
                iDB2DataReader reader = command.ExecuteReader();
               
                    for(int i=0;i<reader.FieldCount;i++)
                    {
                        string column  = reader.GetName(i);
                        Type type = reader.GetFieldType(i);
                        Column.Create(this.AllorsSession, this, column, type);
                    }

                    while (reader.Read())
                    {
                        Row row = Row.Create(this.AllorsSession, this);
                        // Create cells for each column
                        foreach (Column col in this.Columns)
                        {
                            object value = reader.GetValue(reader.GetOrdinal(col.Name));
                            if (value != null)
                            {
                                CellFactory.Create(this.AllorsSession, row, col, value);
                            }
                        }
                    }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
