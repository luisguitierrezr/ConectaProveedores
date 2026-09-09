using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENInvoiceApprovalEntity {
private static readonly ActivitySource activitySource = new(typeof(ENInvoiceApprovalEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@Id, "id") ?? "id"},
{"invoiceid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid"},
{"aprovalprocessid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@AprovalProcessId, "aprovalprocessid") ?? "aprovalprocessid"},
{"processtypecode", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@ProcessTypeCode, "processtypecode") ?? "processtypecode"},
{"approvalprocessversion", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@ApprovalProcessVersion, "approvalprocessversion") ?? "approvalprocessversion"},
{"currentlevel", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@CurrentLevel, "currentlevel") ?? "currentlevel"},
{"maxlevel", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@MaxLevel, "maxlevel") ?? "maxlevel"},
{"startedon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@StartedOn, "startedon") ?? "startedon"},
{"finishedon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@FinishedOn, "finishedon") ?? "finishedon"},
{"hasstartedaccounting", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@HasStartedAccounting, "hasstartedaccounting") ?? "hasstartedaccounting"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, "invoi_u8aqr95gpfeqnsdbw0iglgz7"));
}
} // ENInvoiceApprovalEntity

}

