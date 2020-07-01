using System;
using IBM.Data.DB2.iSeries;

namespace Iseries
{
    public class Session : IDisposable
    {
        public iDB2Connection Connection { get; set; }
        public iDB2Transaction Transaction { get; set; }

        public Session(string connectionString)
        {
            this.Connection = new iDB2Connection(connectionString);
            this.Connection.Open();
            this.Transaction = this.Connection.BeginTransaction();
        }

        public void Commit()
        {
            Transaction.Commit();
            Connection.Dispose();
            Connection.Close();
            Transaction = null;
            Connection = null;
        }

        public void Rollback()
        {
            this.Transaction.Rollback();
            this.Connection.Dispose();
            this.Connection.Close();
            this.Transaction = null;
            this.Connection = null;
        }

        #region IDisposable Members

        public void Dispose()
        {
            if (Connection != null)
            {
                this.Rollback();
            }
        }

        #endregion
    }
}
