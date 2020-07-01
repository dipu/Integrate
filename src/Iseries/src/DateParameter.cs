using System;
using Allors;
using IBM.Data.DB2.iSeries;

namespace Iseries
{
    public partial class DateParameter : Parameter
    {
        public static DateParameter Create(AllorsSession session, string name, DateTime value)
        {
            var param = session.Create<DateParameter>();
            param.Name = name;
            param.Value = value;

            return param;
        }

        public void Fill(iDB2Parameter db2Parameter)
        {
            db2Parameter.iDB2DbType = iDB2DbType.iDB2Date;
            db2Parameter.ParameterName = this.Name;
            db2Parameter.Value = this.Value.Date;
            db2Parameter.Direction = System.Data.ParameterDirection.InputOutput;
        }

        public void UpdateValue(iDB2Parameter db2Parameter)
        {
            this.Value = Convert.ToDateTime(db2Parameter.Value);
        }
    }
}
