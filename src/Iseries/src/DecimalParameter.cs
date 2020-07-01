using System;
using Allors;
using IBM.Data.DB2.iSeries;

namespace Iseries
{
    public partial class DecimalParameter : Parameter
    {
        public static DecimalParameter Create(AllorsSession session, string name, int precision, int scale, Decimal value)
        {
            var param = session.Create<DecimalParameter>();
            param.Name = name;
            param.Precision = precision;
            param.Scale = scale;
            param.Value = value;

            return param;
        }

        public void Fill(iDB2Parameter db2Parameter)
        {
            db2Parameter.iDB2DbType = iDB2DbType.iDB2Decimal;
            db2Parameter.ParameterName = this.Name;
            db2Parameter.Precision = Convert.ToByte(this.Precision);
            db2Parameter.Scale = Convert.ToByte(this.Scale);
            db2Parameter.Value = this.Value;
            db2Parameter.Direction = System.Data.ParameterDirection.InputOutput;
        }

        public void UpdateValue(iDB2Parameter db2Parameter)
        {
            this.Value = Convert.ToDecimal(db2Parameter.Value);
        }
    }
}
