using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENInvoiceAccountingProcessRetentionsEntity {
private static readonly ActivitySource activitySource = new(typeof(ENInvoiceAccountingProcessRetentionsEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessRetentions, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessRetentionsAttributeKeys.@Id, "id") ?? "id"},
{"invoiceaccountingprocessid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessRetentions, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessRetentionsAttributeKeys.@InvoiceAccountingProcessId, "invoiceaccountingprocessid") ?? "invoiceaccountingprocessid"},
{"witht", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessRetentions, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessRetentionsAttributeKeys.@WITHT, "witht") ?? "witht"},
{"wt_withcd", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessRetentions, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessRetentionsAttributeKeys.@WT_WITHCD, "wt_withcd") ?? "wt_withcd"},
{"wt_subjct", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessRetentions, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessRetentionsAttributeKeys.@WT_SUBJCT, "wt_subjct") ?? "wt_subjct"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessRetentions, "invoi_u8aqr95gpfezi8wn6zkelwc5"));
}
} // ENInvoiceAccountingProcessRetentionsEntity

}

