using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENRequisitionFile2Entity {
private static readonly ActivitySource activitySource = new(typeof(ENRequisitionFile2Entity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@Id, "id") ?? "id"},
{"filename", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@Filename, "filename") ?? "filename"},
{"vendor", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@VENDOR, "vendor") ?? "vendor"},
{"doc_type", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@DOC_TYPE, "doc_type") ?? "doc_type"},
{"sap_object", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@SAP_OBJECT, "sap_object") ?? "sap_object"},
{"createdby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@CreatedBy, "createdby") ?? "createdby"},
{"createdon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@CreatedOn, "createdon") ?? "createdon"},
{"storageid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@StorageId, "storageid") ?? "storageid"}
};
}
public static System.Collections.Generic.Dictionary<string,string> AttributesToDatabaseNamesMap() {
return EntityAttributes;
}
public static string AttributeDatabaseName(string attributeName) {
string databaseName;
EntityAttributes.TryGetValue(attributeName, out databaseName);
return databaseName;
}
public static string LocalViewName(string locale) {
return ViewName(locale);
}
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, "requi_u8aqr95gpfe_pszdgkx_8s73"));
}
} // ENRequisitionFile2Entity

}

