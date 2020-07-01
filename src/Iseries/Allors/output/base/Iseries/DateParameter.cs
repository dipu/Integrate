using Allors;
using Allors.Meta;

namespace Iseries.AllorsGenerated
{
public interface AllorsInterfaceDateParameter : Iseries.Parameter,  AllorsObject
	{
	}
	
 
	public abstract class AllorsClassDateParameter :  AllorsObject
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

		protected AllorsClassDateParameter(AllorsStrategy allors){this.allors=allors;}

		
 
		virtual public System.DateTime Value 
		{
			get
			{
				return (System.DateTime) allors.GetUnitRole(AllorsDomains.IseriesDomain.DateParameterValue);
			}
			set
			{
				allors.SetUnitRole(AllorsDomains.IseriesDomain.DateParameterValue,value);
			}
		}
		virtual public bool ExistValue{
			get
			{
				return allors.ExistUnitRole(AllorsDomains.IseriesDomain.DateParameterValue);
			}
		}
		virtual public void RemoveValue()
		{
			allors.RemoveUnitRole(AllorsDomains.IseriesDomain.DateParameterValue);
		}

		
 
		virtual public System.String Direction 
		{
			get
			{
				return (System.String) allors.GetUnitRole(AllorsDomains.IseriesDomain.ParameterDirection);
			}
			set
			{
				allors.SetUnitRole(AllorsDomains.IseriesDomain.ParameterDirection,value);
			}
		}
		virtual public bool ExistDirection{
			get
			{
				return allors.ExistUnitRole(AllorsDomains.IseriesDomain.ParameterDirection);
			}
		}
		virtual public void RemoveDirection()
		{
			allors.RemoveUnitRole(AllorsDomains.IseriesDomain.ParameterDirection);
		}

 
		virtual public Iseries.Parameter NextParameter
		{ 
			get
			{
				return (Iseries.Parameter) allors.GetCompositeRole(AllorsDomains.IseriesDomain.ParameterNextParameter);
			}
			set
			{
				allors.SetCompositeRole(AllorsDomains.IseriesDomain.ParameterNextParameter,value);
			}
		}
		virtual public bool ExistNextParameter
		{
			get
			{
				return allors.ExistCompositeRole(AllorsDomains.IseriesDomain.ParameterNextParameter);
			}
		}
		virtual public void RemoveNextParameter()
		{
			allors.RemoveCompositeRole(AllorsDomains.IseriesDomain.ParameterNextParameter);
		}

		
 
		virtual public System.String Name 
		{
			get
			{
				return (System.String) allors.GetUnitRole(AllorsDomains.IseriesDomain.ParameterName);
			}
			set
			{
				allors.SetUnitRole(AllorsDomains.IseriesDomain.ParameterName,value);
			}
		}
		virtual public bool ExistName{
			get
			{
				return allors.ExistUnitRole(AllorsDomains.IseriesDomain.ParameterName);
			}
		}
		virtual public void RemoveName()
		{
			allors.RemoveUnitRole(AllorsDomains.IseriesDomain.ParameterName);
		}


 
		virtual public Iseries.Parameter ParameterWhereNextParameter
		{ 
			get
			{
				return (Iseries.Parameter) allors.GetCompositeAssociation(AllorsDomains.IseriesDomain.ParameterNextParameter);
			}
		} 
		virtual public bool ExistParameterWhereNextParameter
		{
			get
			{
				return allors.ExistCompositeAssociation(AllorsDomains.IseriesDomain.ParameterNextParameter);
			}
		}

 
		virtual public Iseries.Program ProgramWhereFirstParameter
		{ 
			get
			{
				return (Iseries.Program) allors.GetCompositeAssociation(AllorsDomains.IseriesDomain.ProgramFirstParameter);
			}
		} 
		virtual public bool ExistProgramWhereFirstParameter
		{
			get
			{
				return allors.ExistCompositeAssociation(AllorsDomains.IseriesDomain.ProgramFirstParameter);
			}
		}
	}
}