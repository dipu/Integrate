using Allors.Meta;

namespace AllorsDomains
{
	public class IseriesDomain
	{
		#region Attributes
		public static readonly MetaDomain MetaDomain;
	
		public static readonly MetaNamespace Allors;	
		public static readonly MetaNamespace Iseries;
	
		public static readonly MetaType AllorsString;	
		public static readonly MetaType AllorsInteger;	
		public static readonly MetaType AllorsLong;	
		public static readonly MetaType AllorsDecimal;	
		public static readonly MetaType AllorsDouble;	
		public static readonly MetaType AllorsBoolean;	
		public static readonly MetaType AllorsDate;	
		public static readonly MetaType AllorsDateTime;	
		public static readonly MetaType AllorsUnique;	
		public static readonly MetaType AllorsBinary;	
		public static readonly MetaType StringParameter;	
		public static readonly MetaType Parameter;	
		public static readonly MetaType IntParameter;	
		public static readonly MetaType Program;	
		public static readonly MetaType Library;	
		public static readonly MetaType DateParameter;	
		public static readonly MetaType DateTimeParameter;	
		public static readonly MetaType DecimalParameter;	
		public static readonly MetaType Table;	
		public static readonly MetaType Row;	
		public static readonly MetaType Column;	
		public static readonly MetaType Cell;	
		public static readonly MetaType IntCell;	
		public static readonly MetaType DecimalCell;	
		public static readonly MetaType StringCell;	
		public static readonly MetaType DateTimeCell;
	
		public static readonly MetaRelation StringParameterLength;	
		public static readonly MetaRelation ParameterDirection;	
		public static readonly MetaRelation ParameterNextParameter;	
		public static readonly MetaRelation ParameterName;	
		public static readonly MetaRelation StringParameterValue;	
		public static readonly MetaRelation ProgramName;	
		public static readonly MetaRelation LibraryName;	
		public static readonly MetaRelation DateTimeParameterValue;	
		public static readonly MetaRelation DecimalParameterValue;	
		public static readonly MetaRelation DecimalParameterScale;	
		public static readonly MetaRelation IntParameterValue;	
		public static readonly MetaRelation LibraryProgram;	
		public static readonly MetaRelation ProgramFirstParameter;	
		public static readonly MetaRelation DateParameterValue;	
		public static readonly MetaRelation DecimalParameterPrecision;	
		public static readonly MetaRelation TableName;	
		public static readonly MetaRelation TableRow;	
		public static readonly MetaRelation LibraryTable;	
		public static readonly MetaRelation TableColumn;	
		public static readonly MetaRelation ColumnName;	
		public static readonly MetaRelation ColumnDbType;	
		public static readonly MetaRelation CellColumn;	
		public static readonly MetaRelation RowCell;	
		public static readonly MetaRelation IntCellValue;	
		public static readonly MetaRelation DecimalCellValue;	
		public static readonly MetaRelation StringCellValue;	
		public static readonly MetaRelation DateTimeCellValue;
		#endregion		

		static IseriesDomain()
		{
			MetaDomain = MetaDomain.Create(new System.Guid("ef394f08-049d-4352-96c9-c8d649e178c2"));
			MetaDomain.Name = "Iseries";

			#region Namespaces
			Allors = MetaDomain.AddNamespace(new System.Guid("34fb9dde-3afd-49d1-9106-7701b5aefb50"));
			Allors.ShortName = "Allors";
			Allors.LongName = "Allors";Iseries = MetaDomain.AddNamespace(new System.Guid("09d8acde-bc56-4fa3-bf36-2729688843bb"));
			Iseries.ShortName = "Iseries";
			Iseries.LongName = "Iseries";
			#endregion
			
			#region Types

			AllorsString = MetaDomain.FindType(new System.Guid("ad7f5ddc-bedb-4aaa-97ac-d6693a009ba9"));
			AllorsInteger = MetaDomain.FindType(new System.Guid("ccd6f134-26de-4103-bff9-a37ec3e997a3"));
			AllorsLong = MetaDomain.FindType(new System.Guid("e8989069-024b-4389-ac77-a98c4dfff25a"));
			AllorsDecimal = MetaDomain.FindType(new System.Guid("da866d8e-2c40-41a8-ae5b-5f6dae0b89c8"));
			AllorsDouble = MetaDomain.FindType(new System.Guid("ffcabd07-f35f-4083-bef6-f6c47970ca5d"));
			AllorsBoolean = MetaDomain.FindType(new System.Guid("b5ee6cea-4e2b-498e-a5dd-24671d896477"));
			AllorsDate = MetaDomain.FindType(new System.Guid("c402fbda-133a-4b59-858a-832fbd2ec565"));
			AllorsDateTime = MetaDomain.FindType(new System.Guid("c4c09343-61d3-418c-ade2-fe6fd588f128"));
			AllorsUnique = MetaDomain.FindType(new System.Guid("6dc0a1a8-88a4-4614-adb4-92dd3d017c0e"));
			AllorsBinary = MetaDomain.FindType(new System.Guid("c28e515b-cae8-4d6b-95bf-062aec8042fc"));
			StringParameter = MetaDomain.AddType(new System.Guid("3c1e925f-7ea6-4f1e-9daf-4490a76c6bd0"));
			StringParameter.SingularName = "StringParameter";
			StringParameter.PluralName = "StringParameters";
			StringParameter.Namespace = Iseries;

			Parameter = MetaDomain.AddType(new System.Guid("637001bf-27d1-4456-9ab7-086c54b0d530"));
			Parameter.SingularName = "Parameter";
			Parameter.PluralName = "Parameters";
			Parameter.Namespace = Iseries;
			Parameter.IsInterface = true;

			IntParameter = MetaDomain.AddType(new System.Guid("6e32f1fc-0f7f-4cb4-9fc3-353b79c87da9"));
			IntParameter.SingularName = "IntParameter";
			IntParameter.PluralName = "IntParameters";
			IntParameter.Namespace = Iseries;

			Program = MetaDomain.AddType(new System.Guid("706df194-b7d6-49b9-8429-85fc05caf80c"));
			Program.SingularName = "Program";
			Program.PluralName = "Programs";
			Program.Namespace = Iseries;

			Library = MetaDomain.AddType(new System.Guid("bcaa5b32-31e6-462b-991b-ff676dcdee89"));
			Library.SingularName = "Library";
			Library.PluralName = "Libraries";
			Library.Namespace = Iseries;

			DateParameter = MetaDomain.AddType(new System.Guid("bef4c9e8-bf04-45ee-8df5-b84e0fd08b82"));
			DateParameter.SingularName = "DateParameter";
			DateParameter.PluralName = "DateParameters";
			DateParameter.Namespace = Iseries;

			DateTimeParameter = MetaDomain.AddType(new System.Guid("de4f31bc-8489-4cbe-acad-d1edf34243a6"));
			DateTimeParameter.SingularName = "DateTimeParameter";
			DateTimeParameter.PluralName = "DateTimeParameters";
			DateTimeParameter.Namespace = Iseries;

			DecimalParameter = MetaDomain.AddType(new System.Guid("f18ef4d7-4476-4b74-ba70-6c7b550c411c"));
			DecimalParameter.SingularName = "DecimalParameter";
			DecimalParameter.PluralName = "DecimalParameters";
			DecimalParameter.Namespace = Iseries;

			Table = MetaDomain.AddType(new System.Guid("cec9f5f8-c036-481c-9e87-f104bbcafb32"));
			Table.SingularName = "Table";
			Table.PluralName = "Tables";
			Table.Namespace = Iseries;

			Row = MetaDomain.AddType(new System.Guid("2f42bd84-0cdc-43a9-9f05-b8edd1ca74d0"));
			Row.SingularName = "Row";
			Row.PluralName = "Rows";
			Row.Namespace = Iseries;

			Column = MetaDomain.AddType(new System.Guid("6d0ecca5-f47c-4ba3-a515-e4533697ae68"));
			Column.SingularName = "Column";
			Column.PluralName = "Columns";
			Column.Namespace = Iseries;

			Cell = MetaDomain.AddType(new System.Guid("6cf3f3e8-6a11-47b6-8d41-c8454fa42308"));
			Cell.SingularName = "Cell";
			Cell.PluralName = "Cells";
			Cell.Namespace = Iseries;
			Cell.IsInterface = true;

			IntCell = MetaDomain.AddType(new System.Guid("0788605b-9ac4-4442-a104-0e7533b8e23a"));
			IntCell.SingularName = "IntCell";
			IntCell.PluralName = "IntCells";
			IntCell.Namespace = Iseries;

			DecimalCell = MetaDomain.AddType(new System.Guid("e828d29a-28a3-4ef5-a745-c881cf0afeb5"));
			DecimalCell.SingularName = "DecimalCell";
			DecimalCell.PluralName = "DecimalCells";
			DecimalCell.Namespace = Iseries;

			StringCell = MetaDomain.AddType(new System.Guid("3d494a57-0944-465b-a29a-bab7dd7790b1"));
			StringCell.SingularName = "StringCell";
			StringCell.PluralName = "StringCells";
			StringCell.Namespace = Iseries;

			DateTimeCell = MetaDomain.AddType(new System.Guid("f74f1c3c-edcb-4b70-9e70-70603bb4d12d"));
			DateTimeCell.SingularName = "DateTimeCell";
			DateTimeCell.PluralName = "DateTimeCells";
			DateTimeCell.Namespace = Iseries;

			#endregion
			
			#region Inheritances
			MetaInheritance inheritance;


			inheritance = MetaDomain.AddInheritance(new System.Guid("193366f5-2fd8-4707-866e-d56610bd4645"));
			inheritance.Subtype = DecimalParameter;
			inheritance.Supertype = Parameter;

			inheritance = MetaDomain.AddInheritance(new System.Guid("3586b0a3-b3d6-4eed-aae8-3076e4161dd3"));
			inheritance.Subtype = StringParameter;
			inheritance.Supertype = Parameter;

			inheritance = MetaDomain.AddInheritance(new System.Guid("512a449e-aaa7-4c39-8fee-ce4896cc90b0"));
			inheritance.Subtype = IntParameter;
			inheritance.Supertype = Parameter;

			inheritance = MetaDomain.AddInheritance(new System.Guid("51ab5c5d-3434-47ea-8cfb-969004040d68"));
			inheritance.Subtype = DateParameter;
			inheritance.Supertype = Parameter;

			inheritance = MetaDomain.AddInheritance(new System.Guid("90dbc604-b7ee-4909-b363-f74df992a6c1"));
			inheritance.Subtype = DateTimeParameter;
			inheritance.Supertype = Parameter;

			inheritance = MetaDomain.AddInheritance(new System.Guid("21520088-64c3-4b05-aad3-f03a91a3fce3"));
			inheritance.Subtype = IntCell;
			inheritance.Supertype = Cell;

			inheritance = MetaDomain.AddInheritance(new System.Guid("adb7ceb4-550d-438a-8c18-1a62ddcacfba"));
			inheritance.Subtype = DecimalCell;
			inheritance.Supertype = Cell;

			inheritance = MetaDomain.AddInheritance(new System.Guid("6e8dd66b-a799-42f7-a713-8f7b09601362"));
			inheritance.Subtype = StringCell;
			inheritance.Supertype = Cell;

			inheritance = MetaDomain.AddInheritance(new System.Guid("e7f5411b-cc87-4612-9fac-7dc1a75575b6"));
			inheritance.Subtype = DateTimeCell;
			inheritance.Supertype = Cell;
			#endregion

			#region Relations

			StringParameterLength = MetaDomain.AddRelation(new System.Guid("035d6f81-63da-4946-9f73-761165473cfb"));
			MetaAssociation A_StringParameterLength = StringParameterLength.Association;
			A_StringParameterLength.Type = StringParameter;
			MetaRole R_StringParameterLength = StringParameterLength.Role;
			R_StringParameterLength.Type = AllorsInteger;
			R_StringParameterLength.AssignedSingularName = "Length";
			R_StringParameterLength.AssignedPluralName = "Lengths";

			ParameterDirection = MetaDomain.AddRelation(new System.Guid("04359812-ac29-4c58-814e-edcc84fbf8c6"));
			MetaAssociation A_ParameterDirection = ParameterDirection.Association;
			A_ParameterDirection.Type = Parameter;
			MetaRole R_ParameterDirection = ParameterDirection.Role;
			R_ParameterDirection.Type = AllorsString;
			R_ParameterDirection.AssignedSingularName = "Direction";
			R_ParameterDirection.AssignedPluralName = "Directions";
			R_ParameterDirection.Size = 256;

			ParameterNextParameter = MetaDomain.AddRelation(new System.Guid("154ccfbb-bb38-4df4-a0f8-cc035079d316"));
			ParameterNextParameter.IsIndexed = true;
			MetaAssociation A_ParameterNextParameter = ParameterNextParameter.Association;
			A_ParameterNextParameter.Type = Parameter;
			MetaRole R_ParameterNextParameter = ParameterNextParameter.Role;
			R_ParameterNextParameter.Type = Parameter;
			R_ParameterNextParameter.AssignedSingularName = "NextParameter";
			R_ParameterNextParameter.AssignedPluralName = "NextParameters";

			ParameterName = MetaDomain.AddRelation(new System.Guid("18c574b3-e672-4cac-9705-392c5d3f4cc4"));
			MetaAssociation A_ParameterName = ParameterName.Association;
			A_ParameterName.Type = Parameter;
			MetaRole R_ParameterName = ParameterName.Role;
			R_ParameterName.Type = AllorsString;
			R_ParameterName.AssignedSingularName = "Name";
			R_ParameterName.AssignedPluralName = "Names";
			R_ParameterName.Size = 256;

			StringParameterValue = MetaDomain.AddRelation(new System.Guid("3919e39c-0e08-42dd-aea7-89c3d5ef5aad"));
			MetaAssociation A_StringParameterValue = StringParameterValue.Association;
			A_StringParameterValue.Type = StringParameter;
			MetaRole R_StringParameterValue = StringParameterValue.Role;
			R_StringParameterValue.Type = AllorsString;
			R_StringParameterValue.AssignedSingularName = "Value";
			R_StringParameterValue.AssignedPluralName = "Values";
			R_StringParameterValue.Size = 256;

			ProgramName = MetaDomain.AddRelation(new System.Guid("4c9a017d-d6d4-4bbc-ad10-3a0eebe9426b"));
			MetaAssociation A_ProgramName = ProgramName.Association;
			A_ProgramName.Type = Program;
			MetaRole R_ProgramName = ProgramName.Role;
			R_ProgramName.Type = AllorsString;
			R_ProgramName.AssignedSingularName = "Name";
			R_ProgramName.AssignedPluralName = "Names";
			R_ProgramName.Size = 256;

			LibraryName = MetaDomain.AddRelation(new System.Guid("569acf7f-5a5c-4c08-96dd-71b99b2292d2"));
			MetaAssociation A_LibraryName = LibraryName.Association;
			A_LibraryName.Type = Library;
			MetaRole R_LibraryName = LibraryName.Role;
			R_LibraryName.Type = AllorsString;
			R_LibraryName.AssignedSingularName = "Name";
			R_LibraryName.AssignedPluralName = "Names";
			R_LibraryName.Size = 256;

			DateTimeParameterValue = MetaDomain.AddRelation(new System.Guid("62406c42-d240-4879-b8e7-96d04f22c74b"));
			MetaAssociation A_DateTimeParameterValue = DateTimeParameterValue.Association;
			A_DateTimeParameterValue.Type = DateTimeParameter;
			MetaRole R_DateTimeParameterValue = DateTimeParameterValue.Role;
			R_DateTimeParameterValue.Type = AllorsDateTime;
			R_DateTimeParameterValue.AssignedSingularName = "Value";
			R_DateTimeParameterValue.AssignedPluralName = "Values";

			DecimalParameterValue = MetaDomain.AddRelation(new System.Guid("71c61601-6759-4368-9f6d-6a03e8f29ea1"));
			MetaAssociation A_DecimalParameterValue = DecimalParameterValue.Association;
			A_DecimalParameterValue.Type = DecimalParameter;
			MetaRole R_DecimalParameterValue = DecimalParameterValue.Role;
			R_DecimalParameterValue.Type = AllorsDecimal;
			R_DecimalParameterValue.AssignedSingularName = "Value";
			R_DecimalParameterValue.AssignedPluralName = "Values";
			R_DecimalParameterValue.Precision = 19;
			R_DecimalParameterValue.Scale = 2;
			DecimalParameterScale = MetaDomain.AddRelation(new System.Guid("8f75bd11-7486-43d7-aa84-df2e46bcc457"));
			MetaAssociation A_DecimalParameterScale = DecimalParameterScale.Association;
			A_DecimalParameterScale.Type = DecimalParameter;
			MetaRole R_DecimalParameterScale = DecimalParameterScale.Role;
			R_DecimalParameterScale.Type = AllorsInteger;
			R_DecimalParameterScale.AssignedSingularName = "Scale";
			R_DecimalParameterScale.AssignedPluralName = "Scales";

			IntParameterValue = MetaDomain.AddRelation(new System.Guid("9412c853-372d-4a57-ab4d-6695c33ff9d1"));
			MetaAssociation A_IntParameterValue = IntParameterValue.Association;
			A_IntParameterValue.Type = IntParameter;
			MetaRole R_IntParameterValue = IntParameterValue.Role;
			R_IntParameterValue.Type = AllorsInteger;
			R_IntParameterValue.AssignedSingularName = "Value";
			R_IntParameterValue.AssignedPluralName = "Values";

			LibraryProgram = MetaDomain.AddRelation(new System.Guid("d7fa542b-ac0e-430d-a65d-e397c6a618bb"));
			LibraryProgram.IsIndexed = true;
			MetaAssociation A_LibraryProgram = LibraryProgram.Association;
			A_LibraryProgram.Type = Library;
			MetaRole R_LibraryProgram = LibraryProgram.Role;
			R_LibraryProgram.Type = Program;
			R_LibraryProgram.IsMany = true;

			ProgramFirstParameter = MetaDomain.AddRelation(new System.Guid("ef12dd85-00ac-4c2e-a7e8-61fc745db0ec"));
			ProgramFirstParameter.IsIndexed = true;
			MetaAssociation A_ProgramFirstParameter = ProgramFirstParameter.Association;
			A_ProgramFirstParameter.Type = Program;
			MetaRole R_ProgramFirstParameter = ProgramFirstParameter.Role;
			R_ProgramFirstParameter.Type = Parameter;
			R_ProgramFirstParameter.AssignedSingularName = "FirstParameter";
			R_ProgramFirstParameter.AssignedPluralName = "FirstParameters";

			DateParameterValue = MetaDomain.AddRelation(new System.Guid("f3b9d5e1-a39e-4544-969e-d37ccde89d33"));
			MetaAssociation A_DateParameterValue = DateParameterValue.Association;
			A_DateParameterValue.Type = DateParameter;
			MetaRole R_DateParameterValue = DateParameterValue.Role;
			R_DateParameterValue.Type = AllorsDate;
			R_DateParameterValue.AssignedSingularName = "Value";
			R_DateParameterValue.AssignedPluralName = "Values";

			DecimalParameterPrecision = MetaDomain.AddRelation(new System.Guid("fe8cf49d-377c-48f7-a89e-d506d48b1bdf"));
			MetaAssociation A_DecimalParameterPrecision = DecimalParameterPrecision.Association;
			A_DecimalParameterPrecision.Type = DecimalParameter;
			MetaRole R_DecimalParameterPrecision = DecimalParameterPrecision.Role;
			R_DecimalParameterPrecision.Type = AllorsInteger;
			R_DecimalParameterPrecision.AssignedSingularName = "Precision";
			R_DecimalParameterPrecision.AssignedPluralName = "Precisions";

			TableName = MetaDomain.AddRelation(new System.Guid("2495cd02-72e0-40f2-995b-727af0a0240d"));
			MetaAssociation A_TableName = TableName.Association;
			A_TableName.Type = Table;
			MetaRole R_TableName = TableName.Role;
			R_TableName.Type = AllorsString;
			R_TableName.AssignedSingularName = "Name";
			R_TableName.AssignedPluralName = "Names";
			R_TableName.Size = 256;

			TableRow = MetaDomain.AddRelation(new System.Guid("645a3afc-e5c1-45fe-aac8-878ae93eb227"));
			TableRow.IsIndexed = true;
			MetaAssociation A_TableRow = TableRow.Association;
			A_TableRow.Type = Table;
			MetaRole R_TableRow = TableRow.Role;
			R_TableRow.Type = Row;
			R_TableRow.IsMany = true;

			LibraryTable = MetaDomain.AddRelation(new System.Guid("20bbb4b0-59f5-44f2-8d8e-f71e3ef233d8"));
			LibraryTable.IsIndexed = true;
			MetaAssociation A_LibraryTable = LibraryTable.Association;
			A_LibraryTable.Type = Library;
			MetaRole R_LibraryTable = LibraryTable.Role;
			R_LibraryTable.Type = Table;
			R_LibraryTable.IsMany = true;

			TableColumn = MetaDomain.AddRelation(new System.Guid("2d03137f-b975-4683-b4e9-84b1ddbb1de7"));
			TableColumn.IsIndexed = true;
			MetaAssociation A_TableColumn = TableColumn.Association;
			A_TableColumn.Type = Table;
			MetaRole R_TableColumn = TableColumn.Role;
			R_TableColumn.Type = Column;
			R_TableColumn.IsMany = true;

			ColumnName = MetaDomain.AddRelation(new System.Guid("bdbcb9ba-c071-4655-9ab7-3990603a34ff"));
			MetaAssociation A_ColumnName = ColumnName.Association;
			A_ColumnName.Type = Column;
			MetaRole R_ColumnName = ColumnName.Role;
			R_ColumnName.Type = AllorsString;
			R_ColumnName.AssignedSingularName = "Name";
			R_ColumnName.AssignedPluralName = "Names";
			R_ColumnName.Size = 256;

			ColumnDbType = MetaDomain.AddRelation(new System.Guid("6c1e9dfb-33bb-414f-bdf2-78629cd0ce36"));
			MetaAssociation A_ColumnDbType = ColumnDbType.Association;
			A_ColumnDbType.Type = Column;
			MetaRole R_ColumnDbType = ColumnDbType.Role;
			R_ColumnDbType.Type = AllorsString;
			R_ColumnDbType.AssignedSingularName = "DbType";
			R_ColumnDbType.AssignedPluralName = "DbTypes";
			R_ColumnDbType.Size = 256;

			CellColumn = MetaDomain.AddRelation(new System.Guid("9eb74345-a8e6-4c6e-b855-d0f029117f04"));
			CellColumn.IsIndexed = true;
			MetaAssociation A_CellColumn = CellColumn.Association;
			A_CellColumn.Type = Cell;
			A_CellColumn.IsMany = true;
			MetaRole R_CellColumn = CellColumn.Role;
			R_CellColumn.Type = Column;

			RowCell = MetaDomain.AddRelation(new System.Guid("ff62b386-f5ef-409e-82f7-d5efa16e2198"));
			RowCell.IsIndexed = true;
			MetaAssociation A_RowCell = RowCell.Association;
			A_RowCell.Type = Row;
			MetaRole R_RowCell = RowCell.Role;
			R_RowCell.Type = Cell;
			R_RowCell.IsMany = true;

			IntCellValue = MetaDomain.AddRelation(new System.Guid("d20bed08-4892-4c13-869d-b003c07f19e8"));
			MetaAssociation A_IntCellValue = IntCellValue.Association;
			A_IntCellValue.Type = IntCell;
			MetaRole R_IntCellValue = IntCellValue.Role;
			R_IntCellValue.Type = AllorsInteger;
			R_IntCellValue.AssignedSingularName = "Value";
			R_IntCellValue.AssignedPluralName = "Values";

			DecimalCellValue = MetaDomain.AddRelation(new System.Guid("ee1dd84c-8ba2-436d-8268-4f5c153e778c"));
			MetaAssociation A_DecimalCellValue = DecimalCellValue.Association;
			A_DecimalCellValue.Type = DecimalCell;
			MetaRole R_DecimalCellValue = DecimalCellValue.Role;
			R_DecimalCellValue.Type = AllorsDecimal;
			R_DecimalCellValue.AssignedSingularName = "Value";
			R_DecimalCellValue.AssignedPluralName = "Values";
			R_DecimalCellValue.Precision = 19;
			R_DecimalCellValue.Scale = 2;
			StringCellValue = MetaDomain.AddRelation(new System.Guid("4d25794c-22c3-4887-88b9-63b69fda07be"));
			MetaAssociation A_StringCellValue = StringCellValue.Association;
			A_StringCellValue.Type = StringCell;
			MetaRole R_StringCellValue = StringCellValue.Role;
			R_StringCellValue.Type = AllorsString;
			R_StringCellValue.AssignedSingularName = "Value";
			R_StringCellValue.AssignedPluralName = "Values";
			R_StringCellValue.Size = 256;

			DateTimeCellValue = MetaDomain.AddRelation(new System.Guid("019fe282-2ba7-4d90-ab5a-9a6ea9f0a80d"));
			MetaAssociation A_DateTimeCellValue = DateTimeCellValue.Association;
			A_DateTimeCellValue.Type = DateTimeCell;
			MetaRole R_DateTimeCellValue = DateTimeCellValue.Role;
			R_DateTimeCellValue.Type = AllorsDateTime;
			R_DateTimeCellValue.AssignedSingularName = "Value";
			R_DateTimeCellValue.AssignedPluralName = "Values";

			#endregion
		}
	
		public IseriesDomain(){}
	}
}