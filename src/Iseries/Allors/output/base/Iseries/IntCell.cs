using Allors;
using Allors.Meta;

namespace Iseries.AllorsGenerated
{
public interface AllorsInterfaceIntCell : Iseries.Cell,  AllorsObject
	{
	}
	
 
	public abstract class AllorsClassIntCell :  AllorsObject
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

		protected AllorsClassIntCell(AllorsStrategy allors){this.allors=allors;}

		
 
		virtual public System.Int32 Value 
		{
			get
			{
				return (System.Int32) allors.GetUnitRole(AllorsDomains.IseriesDomain.IntCellValue);
			}
			set
			{
				allors.SetUnitRole(AllorsDomains.IseriesDomain.IntCellValue,value);
			}
		}
		virtual public bool ExistValue{
			get
			{
				return allors.ExistUnitRole(AllorsDomains.IseriesDomain.IntCellValue);
			}
		}
		virtual public void RemoveValue()
		{
			allors.RemoveUnitRole(AllorsDomains.IseriesDomain.IntCellValue);
		}

 
		virtual public Iseries.Column Column
		{ 
			get
			{
				return (Iseries.Column) allors.GetCompositeRole(AllorsDomains.IseriesDomain.CellColumn);
			}
			set
			{
				allors.SetCompositeRole(AllorsDomains.IseriesDomain.CellColumn,value);
			}
		}
		virtual public bool ExistColumn
		{
			get
			{
				return allors.ExistCompositeRole(AllorsDomains.IseriesDomain.CellColumn);
			}
		}
		virtual public void RemoveColumn()
		{
			allors.RemoveCompositeRole(AllorsDomains.IseriesDomain.CellColumn);
		}


 
		virtual public Iseries.Row RowWhereCell
		{ 
			get
			{
				return (Iseries.Row) allors.GetCompositeAssociation(AllorsDomains.IseriesDomain.RowCell);
			}
		} 
		virtual public bool ExistRowWhereCell
		{
			get
			{
				return allors.ExistCompositeAssociation(AllorsDomains.IseriesDomain.RowCell);
			}
		}
	}
}