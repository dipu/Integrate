#region using
using System;
using System.Data;
using IBM.Data.DB2.iSeries;
#endregion

namespace ISeries
{
	/// <summary>
	/// <para>ISeriesCall creates a command object to as400, does the actual calls and encapsulates all parameter get and set methods</para>
	/// <para>Use for calling storedProcedures on as400</para>
	/// </summary>
	public class ISeriesCall : IDisposable
	{
		private const String CALAMITEIT = "CALAMITEIT";
		private iDB2Command command;

		public iDB2Command Command
		{
			get
			{
				return this.command;
			}
		}

		/// <summary>
		/// Constructor for a ISeriesCall object
		/// </summary>
		/// <param name="program"></param>
		/// <param name="connection"></param>
		/// <param name="transaction"></param>
		public ISeriesCall(string program, iDB2Connection connection, iDB2Transaction transaction)
		{
			command = new iDB2Command(program, connection, transaction);
			command.CommandTimeout = 0;
			command.CommandType = CommandType.StoredProcedure;
		}

		public void Dispose()
		{
			command.Dispose();
		}

		/// <summary>
		/// <para>Set method for string type parameter</para>
		/// <para>Equivalent RPG type: xxA (char)</para>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="length"></param>
		/// <param name="aString"></param>
		public void setString(string name, int length, string aString)
		{
			iDB2Parameter parameter = new iDB2Parameter("@" + name, iDB2DbType.iDB2VarChar, length);
			parameter.Value = aString;
			parameter.Direction = ParameterDirection.InputOutput;
			command.Parameters.Add(parameter);
		}

		/// <summary>
		/// <para>Set method for int type parameter</para>
		/// <para>Equivalent RPG type: 10i0</para>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="anInteger"></param>
		public void setInteger(string name, int anInteger)
		{
			iDB2Parameter parameter = new iDB2Parameter("@" + name, iDB2DbType.iDB2Integer);
			parameter.Value = anInteger;
			parameter.Direction = ParameterDirection.InputOutput;
			command.Parameters.Add(parameter);
		}

		/// <summary>
		/// <para>Set method for decimal type parameter</para>
		/// <para>Equivalent RPG type: 15p2 (by Convention)</para>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="precision"></param>
		/// <param name="scale"></param>
		/// <param name="aDecimal"></param>
		public void setDecimal(string name, byte precision, byte scale, Decimal aDecimal)
		{
			iDB2Parameter parameter = new iDB2Parameter("@" + name, iDB2DbType.iDB2Decimal);
			parameter.Value = aDecimal;
			parameter.Precision = precision;
			parameter.Scale = scale;
			parameter.Direction = ParameterDirection.InputOutput;
			command.Parameters.Add(parameter);
		}

		/// <summary>
		/// <para>Set method for Date type parameter</para>
		/// <para>Equivalent RPG type: timestamp (z)</para>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="aDate"></param>
		public void setDate(string name, DateTime aDate)
		{
			iDB2Parameter parameter = new iDB2Parameter("@" + name, iDB2DbType.iDB2TimeStamp);
			parameter.Value = aDate;
			parameter.Direction = ParameterDirection.InputOutput;
			command.Parameters.Add(parameter);
		}

		/// <summary>
		/// <para>Actual call to Iseries StoredProcedure</para>
		/// <para>By convention, it adds an extra parameter for error handling</para>
		/// <para>which should be present in all rpg program interfaces</para>
		/// </summary>
		public void execute()
		{
			setString(CALAMITEIT, 128, "");
			command.ExecuteNonQuery();
		}

		/// <summary>
		/// Get method for string type parameter
		/// </summary>
		/// <param name="name"></param>
		/// <returns>string value</returns>
		public string getString(string name)
		{
			return command.Parameters["@" + name].Value.ToString().TrimEnd();
		}

		/// <summary>
		/// Get method for int type parameter
		/// </summary>
		/// <param name="name"></param>
		/// <returns>int value</returns>
		public int getInteger(string name)
		{
			return (int) command.Parameters["@" + name].Value;
		}

		/// <summary>
		/// Get method for decimal type parameter
		/// </summary>
		/// <param name="name"></param>
		/// <returns>decimal value</returns>
		public decimal getDecimal(string name)
		{
			return (decimal) command.Parameters["@" + name].Value;
		}

		/// <summary>
		/// Get method for date type parameter
		/// </summary>
		/// <param name="name"></param>
		/// <returns>DateTime value</returns>
		public DateTime getDate(string name)
		{
			return (DateTime) command.Parameters["@" + name].Value;
		}
	}
}