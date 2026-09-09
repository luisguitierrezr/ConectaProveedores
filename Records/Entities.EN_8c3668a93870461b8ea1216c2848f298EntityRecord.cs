using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENOrdersImportRequestEntity {
private static readonly ActivitySource activitySource = new(typeof(ENOrdersImportRequestEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@Id, "id") ?? "id"},
{"origin", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@Origin, "origin") ?? "origin"},
{"importeddata", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@ImportedData, "importeddata") ?? "importeddata"},
{"ordermainid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@OrderMainId, "ordermainid") ?? "ordermainid"},
{"status", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@Status, "status") ?? "status"},
{"lastrownumberread", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@LastRowNumberRead, "lastrownumberread") ?? "lastrownumberread"},
{"rowswitherror", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@RowsWithError, "rowswitherror") ?? "rowswitherror"},
{"createdby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@CreatedBy, "createdby") ?? "createdby"},
{"createdon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@CreatedOn, "createdon") ?? "createdon"},
{"updatedon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, "order_u8aqr95gpfe_kxvivb8kenw5"));
}
} // ENOrdersImportRequestEntity

}

