using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENInvoiceStatusHistoryEntity {
private static readonly ActivitySource activitySource = new(typeof(ENInvoiceStatusHistoryEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceStatusHistoryAttributeKeys.@Id, "id") ?? "id"},
{"invoiceid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceStatusHistoryAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid"},
{"invoicestatusid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceStatusHistoryAttributeKeys.@InvoiceStatusId, "invoicestatusid") ?? "invoicestatusid"},
{"timestamp", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceStatusHistoryAttributeKeys.@TimeStamp, "timestamp") ?? "timestamp"},
{"createdby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceStatusHistoryAttributeKeys.@CreatedBy, "createdby") ?? "createdby"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceStatusHistory, "invoi_u8aqr95gpfe1bpf25215t3h6"));
}
} // ENInvoiceStatusHistoryEntity

}

