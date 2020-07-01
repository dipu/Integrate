using AllorsDomains;
using Allors;
using Allors.Meta;
using Iseries.AllorsGenerated;

namespace Iseries
{
	// Generated file. 
	// Do not edit this file, changes will be overwritten.
	public partial class DateTimeParameter : AllorsClassDateTimeParameter, AllorsInterfaceDateTimeParameter
	{		
		public DateTimeParameter(AllorsStrategy allors) : base(allors) {}

		public static DateTimeParameter Instantiate (AllorsSession session, string id)
		{
			return (DateTimeParameter) session.Instantiate(id);		
		}
	}
}