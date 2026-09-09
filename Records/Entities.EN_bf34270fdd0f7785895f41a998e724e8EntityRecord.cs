using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENInvoiceLogEntity {
private static readonly ActivitySource activitySource = new(typeof(ENInvoiceLogEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceLog, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceLogAttributeKeys.@Id, "id") ?? "id"},
{"invoiceid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceLog, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceLogAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid"},
{"message", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceLog, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceLogAttributeKeys.@Message, "message") ?? "message"},
{"createdon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceLog, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceLogAttributeKeys.@CreatedOn, "createdon") ?? "createdon"},
{"createdby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceLog, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceLogAttributeKeys.@CreatedBy, "createdby") ?? "createdby"},
{"iserror", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceLog, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceLogAttributeKeys.@IsError, "iserror") ?? "iserror"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceLog, "invoi_u8aqr95gpfe0a56rumj6aty6"));
}
} // ENInvoiceLogEntity

}

