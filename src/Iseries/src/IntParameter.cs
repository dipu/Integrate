using System;
using Allors;
using IBM.Data.DB2.iSeries;

namespace Iseries
{
    public partial class IntParameter : Parameter
    {
        public static IntParameter Create(AllorsSession session, string name, int value)
        {
            var param = session.Create<IntParameter>();
            param.Name = name;
            param.Value = value;

            return param;
        }

        public void Fill(iDB2Parameter db2Parameter)
        {
            db2Parameter.iDB2DbType = iDB2DbType.iDB2Integer;
            db2Parameter.ParameterName = this.Name;
            db2Parameter.Value = this.Value;
            db2Parameter.Direction = System.Data.ParameterDirection.InputOutput;
        }

        public void UpdateValue(iDB2Parameter db2Parameter)
        {
            this.Value = Convert.ToInt32(db2Parameter.Value);
        }
    }
}
