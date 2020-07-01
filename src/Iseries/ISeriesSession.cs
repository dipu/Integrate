#region using

using System;
using IBM.Data.DB2.iSeries;

#endregion

namespace ISeries
{
	/// <summary>
	/// ISeriesSession creates a connection to as400 for executing call and  sql statements
	/// </summary>
	public class ISeriesSession : IDisposable
	{
		private iDB2Connection connection;
		private iDB2Transaction transaction;
		private const string DEFAULT_COLLECTION = "DefaultCollection=";
		private static string dataLibrary = null;
		private static string programLibrary = null;
		private static string dsn = null;

		/// <summary>
		/// <para>Default constructor for creating a connection (transactional)</para>
		/// <para>Also opens the connection and begins the transaction</para>
		/// </summary>
		public ISeriesSession()
		{
			this.connection = new iDB2Connection(Dsn);
			this.connection.Open();
			this.transaction = this.connection.BeginTransaction();
		}

		/// <summary>
		/// Creates and ISeriesCall object
		/// </summary>
		/// <param name="program"></param>
		/// <returns></returns>
		public ISeriesCall createCall(String program)
		{
			program = ProgramLibrary + "." + program;
			return new ISeriesCall(program, connection, transaction);
		}

		public void Commit()
		{
			transaction.Commit();
			connection.Dispose();
			connection.Close();
			transaction = null;
			connection = null;
		}

		public void Rollback()
		{
			transaction.Rollback();
			connection.Dispose();
			connection.Close();
			transaction = null;
			connection = null;
		}

		public void Dispose()
		{
			if (connection != null)
			{
				this.Rollback();
				throw new ISeriesException("ISeriesSession rollbacked");
			}
		}

		/// <summary>
		/// Gets the programLibrary from the configuration file
		/// </summary>
		public static string ProgramLibrary
		{
			get
			{
				return programLibrary;
			}
		}

		/// <summary>
		/// Gets the dataLibrary from the configuration file
		/// </summary>
		public static string DataLibrary
		{
			get
			{
				return dataLibrary;
			}
		}

		/// <summary>
		/// Gets the dsn (connection string) from the configuration file
		/// </summary>
		public static string Dsn
		{
			get
			{
				return dsn;
			}
		}

		public iDB2Connection Connection
		{
			get { return this.connection; }
		}

		public iDB2Transaction Transaction
		{
			get { return this.transaction; }
		}
	}
}