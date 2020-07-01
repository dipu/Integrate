using System;
using Allors;
using IBM.Data.DB2.iSeries;

namespace Iseries
{
    public partial class StringParameter : Parameter
    {
        public static StringParameter Create(AllorsSession session, string name, int length, string value)
        {
            var param = session.Create<StringParameter>();
            param.Length = length;
            param.Name = name;
            param.Value = value;

            return param;
        }

        public void Fill(iDB2Parameter db2Parameter)
        {
            db2Parameter.iDB2DbType = iDB2DbType.iDB2VarChar;
            db2Parameter.ParameterName = this.Name;
            db2Parameter.Size = this.Length;
            db2Parameter.Value = this.Value;
            db2Parameter.Direction = System.Data.ParameterDirection.InputOutput;
        }

        public void UpdateValue(iDB2Parameter db2Parameter)
        {
            this.Value = Convert.ToString(db2Parameter.Value).Trim();
        }
    }
}
