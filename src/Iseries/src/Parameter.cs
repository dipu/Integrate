using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IBM.Data.DB2.iSeries;

namespace Iseries
{
    public partial interface Parameter
    {
        void Fill(iDB2Parameter db2Parameter);
        void UpdateValue(iDB2Parameter db2Parameter);
    }
}
