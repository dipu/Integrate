using Allors;
using Allors.Meta;

namespace Iseries.AllorsGenerated
{
public interface AllorsInterfaceRow :   AllorsObject
	{
	}
	
 
	public abstract class AllorsClassRow :  AllorsObject
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

		protected AllorsClassRow(AllorsStrategy allors){this.allors=allors;}

 
		virtual public AllorsExtent<Iseries.Cell> Cells
		{ 
			get
			{
				return allors.GetCompositeRoles(AllorsDomains.IseriesDomain.RowCell);
			}
			set
			{
				allors.SetCompositeRoles(AllorsDomains.IseriesDomain.RowCell,value);
			}
		}
		virtual public void AddCell (Iseries.Cell value)
		{
			allors.AddCompositeRole(AllorsDomains.IseriesDomain.RowCell,value);
		}
		virtual public void RemoveCell (Iseries.Cell value)
		{
			allors.RemoveCompositeRole(AllorsDomains.IseriesDomain.RowCell,value);
		}
		virtual public bool ExistCells
		{
			get
			{
				return allors.ExistCompositeRoles(AllorsDomains.IseriesDomain.RowCell);
			}
		}
		virtual public void RemoveCells()
		{
			allors.RemoveCompositeRoles(AllorsDomains.IseriesDomain.RowCell);
		}


 
		virtual public Iseries.Table TableWhereRow
		{ 
			get
			{
				return (Iseries.Table) allors.GetCompositeAssociation(AllorsDomains.IseriesDomain.TableRow);
			}
		} 
		virtual public bool ExistTableWhereRow
		{
			get
			{
				return allors.ExistCompositeAssociation(AllorsDomains.IseriesDomain.TableRow);
			}
		}
	}
}