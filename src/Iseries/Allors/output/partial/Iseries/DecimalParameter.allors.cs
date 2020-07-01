using AllorsDomains;
using Allors;
using Allors.Meta;
using Iseries.AllorsGenerated;

namespace Iseries
{
	// Generated file. 
	// Do not edit this file, changes will be overwritten.
	public partial class DecimalParameter : AllorsClassDecimalParameter, AllorsInterfaceDecimalParameter
	{		
		public DecimalParameter(AllorsStrategy allors) : base(allors) {}

		public static DecimalParameter Instantiate (AllorsSession session, string id)
		{
			return (DecimalParameter) session.Instantiate(id);		
		}
	}
}