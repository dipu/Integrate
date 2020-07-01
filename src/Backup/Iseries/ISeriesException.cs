using System;

namespace ISeries
{
	/// <summary>
	/// Exception class for ISeries Exceptions
	/// </summary>
	public class ISeriesException : Exception
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		/// <param name="boodschap"></param>
		public ISeriesException(string boodschap) : base(boodschap)
		{
		}

		/// <summary>
		/// Alternative constructor
		/// </summary>
		/// <param name="boodschap"></param>
		/// <param name="call"></param>
		public ISeriesException(string boodschap, ISeriesCall call) : base(boodschap)
		{
            
		}

		/// <summary>
		/// Alternative constructor
		/// </summary>
		/// <param name="boodschap"></param>
		/// <param name="wortelCalamiteit"></param>
		public ISeriesException(string boodschap, Exception wortelCalamiteit) : base(boodschap, wortelCalamiteit)
		{
		}
	}
}