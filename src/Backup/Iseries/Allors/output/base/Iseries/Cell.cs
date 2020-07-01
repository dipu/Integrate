using Allors;
using Allors.Meta;

namespace Iseries.AllorsGenerated
{
	
 
	public interface AllorsInterfaceCell :   AllorsObject 
	{


		Iseries.Column Column
		{ 
			get;
			set;
		}
		bool ExistColumn
		{
			get;
		}
		void RemoveColumn();


		Iseries.Row RowWhereCell
		{ 
			get;
		} 
		bool ExistRowWhereCell
		{
			get;
		}
	}
	
}