using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENInvoiceAccountingProcessLines_F43Entity {
private static readonly ActivitySource activitySource = new(typeof(ENInvoiceAccountingProcessLines_F43Entity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessLines_F43, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessLines_F43AttributeKeys.@Id, "id") ?? "id"},
{"invoiceaccounting_processid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessLines_F43, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessLines_F43AttributeKeys.@InvoiceAccounting_ProcessId, "invoiceaccounting_processid") ?? "invoiceaccounting_processid"},
{"parameter", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessLines_F43, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessLines_F43AttributeKeys.@Parameter, "parameter") ?? "parameter"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessLines_F43, "invoi_u8aqr95gpfepcgsi89gyb4z6"));
}
} // ENInvoiceAccountingProcessLines_F43Entity

}

