using Allors;
using Allors.Meta;

namespace Iseries.AllorsGenerated
{
public interface AllorsInterfaceTable :   AllorsObject
	{
	}
	
 
	public abstract class AllorsClassTable :  AllorsObject
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

		protected AllorsClassTable(AllorsStrategy allors){this.allors=allors;}

		
 
		virtual public System.String Name 
		{
			get
			{
				return (System.String) allors.GetUnitRole(AllorsDomains.IseriesDomain.TableName);
			}
			set
			{
				allors.SetUnitRole(AllorsDomains.IseriesDomain.TableName,value);
			}
		}
		virtual public bool ExistName{
			get
			{
				return allors.ExistUnitRole(AllorsDomains.IseriesDomain.TableName);
			}
		}
		virtual public void RemoveName()
		{
			allors.RemoveUnitRole(AllorsDomains.IseriesDomain.TableName);
		}

 
		virtual public AllorsExtent<Iseries.Row> Rows
		{ 
			get
			{
				return allors.GetCompositeRoles(AllorsDomains.IseriesDomain.TableRow);
			}
			set
			{
				allors.SetCompositeRoles(AllorsDomains.IseriesDomain.TableRow,value);
			}
		}
		virtual public void AddRow (Iseries.Row value)
		{
			allors.AddCompositeRole(AllorsDomains.IseriesDomain.TableRow,value);
		}
		virtual public void RemoveRow (Iseries.Row value)
		{
			allors.RemoveCompositeRole(AllorsDomains.IseriesDomain.TableRow,value);
		}
		virtual public bool ExistRows
		{
			get
			{
				return allors.ExistCompositeRoles(AllorsDomains.IseriesDomain.TableRow);
			}
		}
		virtual public void RemoveRows()
		{
			allors.RemoveCompositeRoles(AllorsDomains.IseriesDomain.TableRow);
		}

 
		virtual public AllorsExtent<Iseries.Column> Columns
		{ 
			get
			{
				return allors.GetCompositeRoles(AllorsDomains.IseriesDomain.TableColumn);
			}
			set
			{
				allors.SetCompositeRoles(AllorsDomains.IseriesDomain.TableColumn,value);
			}
		}
		virtual public void AddColumn (Iseries.Column value)
		{
			allors.AddCompositeRole(AllorsDomains.IseriesDomain.TableColumn,value);
		}
		virtual public void RemoveColumn (Iseries.Column value)
		{
			allors.RemoveCompositeRole(AllorsDomains.IseriesDomain.TableColumn,value);
		}
		virtual public bool ExistColumns
		{
			get
			{
				return allors.ExistCompositeRoles(AllorsDomains.IseriesDomain.TableColumn);
			}
		}
		virtual public void RemoveColumns()
		{
			allors.RemoveCompositeRoles(AllorsDomains.IseriesDomain.TableColumn);
		}


 
		virtual public Iseries.Library LibraryWhereTable
		{ 
			get
			{
				return (Iseries.Library) allors.GetCompositeAssociation(AllorsDomains.IseriesDomain.LibraryTable);
			}
		} 
		virtual public bool ExistLibraryWhereTable
		{
			get
			{
				return allors.ExistCompositeAssociation(AllorsDomains.IseriesDomain.LibraryTable);
			}
		}
	}
}