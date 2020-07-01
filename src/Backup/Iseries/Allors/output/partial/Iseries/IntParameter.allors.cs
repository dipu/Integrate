using AllorsDomains;
using Allors;
using Allors.Meta;
using Iseries.AllorsGenerated;

namespace Iseries
{
	// Generated file. 
	// Do not edit this file, changes will be overwritten.
	public partial class IntParameter : AllorsClassIntParameter, AllorsInterfaceIntParameter
	{		
		public IntParameter(AllorsStrategy allors) : base(allors) {}

		public static IntParameter Instantiate (AllorsSession session, string id)
		{
			return (IntParameter) session.Instantiate(id);		
		}
	}
}