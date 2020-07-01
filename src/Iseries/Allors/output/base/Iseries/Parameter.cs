using Allors;
using Allors.Meta;

namespace Iseries.AllorsGenerated
{
	
 
	public interface AllorsInterfaceParameter :   AllorsObject 
	{


		System.String Direction 
		{
			get;
			set;
		}
		bool ExistDirection{get;}
		void RemoveDirection();

		Iseries.Parameter NextParameter
		{ 
			get;
			set;
		}
		bool ExistNextParameter
		{
			get;
		}
		void RemoveNextParameter();

		System.String Name 
		{
			get;
			set;
		}
		bool ExistName{get;}
		void RemoveName();


		Iseries.Parameter ParameterWhereNextParameter
		{ 
			get;
		} 
		bool ExistParameterWhereNextParameter
		{
			get;
		}

		Iseries.Program ProgramWhereFirstParameter
		{ 
			get;
		} 
		bool ExistProgramWhereFirstParameter
		{
			get;
		}
	}
	
}