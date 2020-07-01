using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Allors;
using IBM.Data.DB2.iSeries;

namespace Iseries
{
    public partial class Program : IDisposable
    {
        private iDB2Command command;

        public static Program Create(AllorsSession session, string name, Library library)
        {
            var pgm = session.Create<Program>();
            pgm.Name = name;

            library.AddProgram(pgm);
            return pgm;
        }

        public void Call(Session session)
        {
            string program = this.LibraryWhereProgram.Name + "." + this.Name;
            command = new iDB2Command(program, session.Connection, session.Transaction);
            command.CommandTimeout = 0;
            command.CommandType = CommandType.StoredProcedure;

            foreach(Parameter parameter in this.Parameters)
            {
                iDB2Parameter param = new iDB2Parameter();
                parameter.Fill(param);
                this.command.Parameters.Add(param);
            }

            try
            {
                command.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw ex;
            }

            foreach(Parameter parameter in this.Parameters)
            {
                iDB2Parameter db2Parameter = command.Parameters[parameter.Name];
                if (db2Parameter != null)
                {
                    parameter.UpdateValue(db2Parameter);
                }
            }
        }

        public AllorsList Parameters
        {
            get {
                return new AllorsList(this, AllorsDomains.IseriesDomain.ProgramFirstParameter,
                                      AllorsDomains.IseriesDomain.ParameterNextParameter); }
        }

        #region IDisposable Members

        public void Dispose()
        {
            command.Dispose();
        }

        #endregion
    }
}
