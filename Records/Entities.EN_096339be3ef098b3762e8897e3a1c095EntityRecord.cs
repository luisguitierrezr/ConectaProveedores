using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENOrderFileEntity {
private static readonly ActivitySource activitySource = new(typeof(ENOrderFileEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@Id, "id") ?? "id"},
{"filename", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@Filename, "filename") ?? "filename"},
{"vendor", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@VENDOR, "vendor") ?? "vendor"},
{"doc_type", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@DOC_TYPE, "doc_type") ?? "doc_type"},
{"sap_object", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@SAP_OBJECT, "sap_object") ?? "sap_object"},
{"createdby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@CreatedBy, "createdby") ?? "createdby"},
{"createdon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@CreatedOn, "createdon") ?? "createdon"},
{"storageid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@StorageId, "storageid") ?? "storageid"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, "order_u8aqr95gpfeyebt8go7lf2a1"));
}
} // ENOrderFileEntity

}

