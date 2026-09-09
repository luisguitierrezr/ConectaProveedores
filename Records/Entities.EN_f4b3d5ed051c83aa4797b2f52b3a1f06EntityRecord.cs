using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENInvoiceFileEntity {
private static readonly ActivitySource activitySource = new(typeof(ENInvoiceFileEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@Id, "id") ?? "id"},
{"invoiceid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid"},
{"filename", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@Filename, "filename") ?? "filename"},
{"isextra", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@IsExtra, "isextra") ?? "isextra"},
{"isreport", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@IsReport, "isreport") ?? "isreport"},
{"storageid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@StorageId, "storageid") ?? "storageid"},
{"createdby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@CreatedBy, "createdby") ?? "createdby"},
{"createdon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@CreatedOn, "createdon") ?? "createdon"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, "invoi_u8aqr95gpfeybqpj52piqo26"));
}
} // ENInvoiceFileEntity

}

