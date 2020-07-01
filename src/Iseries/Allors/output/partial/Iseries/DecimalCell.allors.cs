using AllorsDomains;
using Allors;
using Allors.Meta;
using Iseries.AllorsGenerated;

namespace Iseries
{
	// Generated file. 
	// Do not edit this file, changes will be overwritten.
	public partial class DecimalCell : AllorsClassDecimalCell, AllorsInterfaceDecimalCell
	{		
		public DecimalCell(AllorsStrategy allors) : base(allors) {}

		public static DecimalCell Instantiate (AllorsSession session, string id)
		{
			return (DecimalCell) session.Instantiate(id);		
		}
	}
}