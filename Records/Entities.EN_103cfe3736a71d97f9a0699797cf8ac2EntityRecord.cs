using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENInvoiceAccountingServicesEntity {
private static readonly ActivitySource activitySource = new(typeof(ENInvoiceAccountingServicesEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@Id, "id") ?? "id"},
{"invoiceaccountingid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@InvoiceAccountingId, "invoiceaccountingid") ?? "invoiceaccountingid"},
{"servicetypeid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@ServiceTypeId, "servicetypeid") ?? "servicetypeid"},
{"account", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@Account, "account") ?? "account"},
{"costcenterid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@CostCenterId, "costcenterid") ?? "costcenterid"},
{"cebecostcenterid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@CeBeCostCenterId, "cebecostcenterid") ?? "cebecostcenterid"},
{"amount", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@Amount, "amount") ?? "amount"},
{"iva_old", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@IVA_Old, "iva_old") ?? "iva_old"},
{"ivaindicatorid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@IVAIndicatorId, "ivaindicatorid") ?? "ivaindicatorid"},
{"buydocnumber", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@BuyDocNumber, "buydocnumber") ?? "buydocnumber"},
{"buydocposition", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@BuyDocPosition, "buydocposition") ?? "buydocposition"},
{"freetext", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@FreeText, "freetext") ?? "freetext"},
{"division", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@Division, "division") ?? "division"},
{"icme", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@ICME, "icme") ?? "icme"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, "invoi_u8aqr95gpfer3aeaiehvy740"));
}
} // ENInvoiceAccountingServicesEntity

}

