using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENInvoicePolizaStorageEntity {
private static readonly ActivitySource activitySource = new(typeof(ENInvoicePolizaStorageEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePolizaStorage, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaStorageAttributeKeys.@Id, "id") ?? "id"},
{"polizaflowid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePolizaStorage, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaStorageAttributeKeys.@PolizaFlowId, "polizaflowid") ?? "polizaflowid"},
{"storageid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePolizaStorage, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaStorageAttributeKeys.@StorageId, "storageid") ?? "storageid"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePolizaStorage, "invoi_u8aqr95gpfetxigfldq25024"));
}
} // ENInvoicePolizaStorageEntity

}

