using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENInvoiceAccountingProcessEntity {
private static readonly ActivitySource activitySource = new(typeof(ENInvoiceAccountingProcessEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@Id, "id") ?? "id"},
{"invoiceid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid"},
{"requisitionid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid"},
{"offsetutc", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@OffsetUtc, "offsetutc") ?? "offsetutc"},
{"comment", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@Comment, "comment") ?? "comment"},
{"processnumber", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@ProcessNumber, "processnumber") ?? "processnumber"},
{"createdon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@CreatedOn, "createdon") ?? "createdon"},
{"nexttry", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@NextTry, "nexttry") ?? "nexttry"},
{"invoiceprocessstatusid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@InvoiceProcessStatusId, "invoiceprocessstatusid") ?? "invoiceprocessstatusid"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, "invoi_u8aqr95gpfepqsaxsj08prn7"));
}
} // ENInvoiceAccountingProcessEntity

}

