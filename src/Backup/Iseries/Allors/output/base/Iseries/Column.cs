using Allors;
using Allors.Meta;

namespace Iseries.AllorsGenerated
{
public interface AllorsInterfaceColumn :   AllorsObject
	{
	}
	
 
	public abstract class AllorsClassColumn :  AllorsObject
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

		protected AllorsClassColumn(AllorsStrategy allors){this.allors=allors;}

		
 
		virtual public System.String Name 
		{
			get
			{
				return (System.String) allors.GetUnitRole(AllorsDomains.IseriesDomain.ColumnName);
			}
			set
			{
				allors.SetUnitRole(AllorsDomains.IseriesDomain.ColumnName,value);
			}
		}
		virtual public bool ExistName{
			get
			{
				return allors.ExistUnitRole(AllorsDomains.IseriesDomain.ColumnName);
			}
		}
		virtual public void RemoveName()
		{
			allors.RemoveUnitRole(AllorsDomains.IseriesDomain.ColumnName);
		}

		
 
		virtual public System.String DbType 
		{
			get
			{
				return (System.String) allors.GetUnitRole(AllorsDomains.IseriesDomain.ColumnDbType);
			}
			set
			{
				allors.SetUnitRole(AllorsDomains.IseriesDomain.ColumnDbType,value);
			}
		}
		virtual public bool ExistDbType{
			get
			{
				return allors.ExistUnitRole(AllorsDomains.IseriesDomain.ColumnDbType);
			}
		}
		virtual public void RemoveDbType()
		{
			allors.RemoveUnitRole(AllorsDomains.IseriesDomain.ColumnDbType);
		}


 
		virtual public Iseries.Table TableWhereColumn
		{ 
			get
			{
				return (Iseries.Table) allors.GetCompositeAssociation(AllorsDomains.IseriesDomain.TableColumn);
			}
		} 
		virtual public bool ExistTableWhereColumn
		{
			get
			{
				return allors.ExistCompositeAssociation(AllorsDomains.IseriesDomain.TableColumn);
			}
		}

 
		virtual public AllorsExtent<Iseries.Cell> CellsWhereColumn
		{ 
			get
			{
				return allors.GetCompositeAssociations(AllorsDomains.IseriesDomain.CellColumn);
			}
		}
		virtual public bool ExistCellsWhereColumn
		{
			get
			{
				return allors.ExistCompositeAssociations(AllorsDomains.IseriesDomain.CellColumn);
			}
		}
	}
}