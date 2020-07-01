using Allors;
using Allors.Meta;

namespace Iseries.AllorsGenerated
{
public interface AllorsInterfaceLibrary :   AllorsObject
	{
	}
	
 
	public abstract class AllorsClassLibrary :  AllorsObject
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

		protected AllorsClassLibrary(AllorsStrategy allors){this.allors=allors;}

		
 
		virtual public System.String Name 
		{
			get
			{
				return (System.String) allors.GetUnitRole(AllorsDomains.IseriesDomain.LibraryName);
			}
			set
			{
				allors.SetUnitRole(AllorsDomains.IseriesDomain.LibraryName,value);
			}
		}
		virtual public bool ExistName{
			get
			{
				return allors.ExistUnitRole(AllorsDomains.IseriesDomain.LibraryName);
			}
		}
		virtual public void RemoveName()
		{
			allors.RemoveUnitRole(AllorsDomains.IseriesDomain.LibraryName);
		}

 
		virtual public AllorsExtent<Iseries.Program> Programs
		{ 
			get
			{
				return allors.GetCompositeRoles(AllorsDomains.IseriesDomain.LibraryProgram);
			}
			set
			{
				allors.SetCompositeRoles(AllorsDomains.IseriesDomain.LibraryProgram,value);
			}
		}
		virtual public void AddProgram (Iseries.Program value)
		{
			allors.AddCompositeRole(AllorsDomains.IseriesDomain.LibraryProgram,value);
		}
		virtual public void RemoveProgram (Iseries.Program value)
		{
			allors.RemoveCompositeRole(AllorsDomains.IseriesDomain.LibraryProgram,value);
		}
		virtual public bool ExistPrograms
		{
			get
			{
				return allors.ExistCompositeRoles(AllorsDomains.IseriesDomain.LibraryProgram);
			}
		}
		virtual public void RemovePrograms()
		{
			allors.RemoveCompositeRoles(AllorsDomains.IseriesDomain.LibraryProgram);
		}

 
		virtual public AllorsExtent<Iseries.Table> Tables
		{ 
			get
			{
				return allors.GetCompositeRoles(AllorsDomains.IseriesDomain.LibraryTable);
			}
			set
			{
				allors.SetCompositeRoles(AllorsDomains.IseriesDomain.LibraryTable,value);
			}
		}
		virtual public void AddTable (Iseries.Table value)
		{
			allors.AddCompositeRole(AllorsDomains.IseriesDomain.LibraryTable,value);
		}
		virtual public void RemoveTable (Iseries.Table value)
		{
			allors.RemoveCompositeRole(AllorsDomains.IseriesDomain.LibraryTable,value);
		}
		virtual public bool ExistTables
		{
			get
			{
				return allors.ExistCompositeRoles(AllorsDomains.IseriesDomain.LibraryTable);
			}
		}
		virtual public void RemoveTables()
		{
			allors.RemoveCompositeRoles(AllorsDomains.IseriesDomain.LibraryTable);
		}
	}
}