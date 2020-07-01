using Allors;
using Allors.Meta;

namespace Iseries.AllorsGenerated
{
public interface AllorsInterfaceProgram :   AllorsObject
	{
	}
	
 
	public abstract class AllorsClassProgram :  AllorsObject
	{
		protected AllorsStrategy allors;

		public virtual AllorsSession AllorsSession{get{return this.allors.Session;}}
		public virtual AllorsObjectId AllorsId{get{return this.allors.Id;}}
		public virtual MetaType AllorsMetaType{get{return this.allors.MetaType;}}
		public virtual AllorsStrategy AllorsStrategy{get{return this.allors;}}
		public virtual bool AllorsIsDisconnectedNew{get{return this.allors.IsDisconnectedNew;}}

		public virtual void Delete(){this.allors.Delete();}
		public virtual bool IsDeleted{get{return this.allors.IsDeleted;}}

		public override System.Boolean Equals( System.Object obj ) {
			AllorsObject typedObj = obj as AllorsObject;
			return	typedObj != null && 
					typedObj.AllorsId.Equals(this.AllorsId) && 
					typedObj.AllorsSession.Population.Equals(AllorsSession.Population);
		}

		public override System.Int32 GetHashCode() {
			return this.AllorsId.GetHashCode();
		}

		public override System.String ToString() {
            return "Object[type=" + this.GetType().Name + ", id=" + AllorsId + "] " + AllorsSession.ToString();
		}

		protected AllorsClassProgram(AllorsStrategy allors){this.allors=allors;}

		
 
		virtual public System.String Name 
		{
			get
			{
				return (System.String) allors.GetUnitRole(AllorsDomains.IseriesDomain.ProgramName);
			}
			set
			{
				allors.SetUnitRole(AllorsDomains.IseriesDomain.ProgramName,value);
			}
		}
		virtual public bool ExistName{
			get
			{
				return allors.ExistUnitRole(AllorsDomains.IseriesDomain.ProgramName);
			}
		}
		virtual public void RemoveName()
		{
			allors.RemoveUnitRole(AllorsDomains.IseriesDomain.ProgramName);
		}

 
		virtual public Iseries.Parameter FirstParameter
		{ 
			get
			{
				return (Iseries.Parameter) allors.GetCompositeRole(AllorsDomains.IseriesDomain.ProgramFirstParameter);
			}
			set
			{
				allors.SetCompositeRole(AllorsDomains.IseriesDomain.ProgramFirstParameter,value);
			}
		}
		virtual public bool ExistFirstParameter
		{
			get
			{
				return allors.ExistCompositeRole(AllorsDomains.IseriesDomain.ProgramFirstParameter);
			}
		}
		virtual public void RemoveFirstParameter()
		{
			allors.RemoveCompositeRole(AllorsDomains.IseriesDomain.ProgramFirstParameter);
		}


 
		virtual public Iseries.Library LibraryWhereProgram
		{ 
			get
			{
				return (Iseries.Library) allors.GetCompositeAssociation(AllorsDomains.IseriesDomain.LibraryProgram);
			}
		} 
		virtual public bool ExistLibraryWhereProgram
		{
			get
			{
				return allors.ExistCompositeAssociation(AllorsDomains.IseriesDomain.LibraryProgram);
			}
		}
	}
}