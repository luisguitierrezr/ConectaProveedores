using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENInvoiceAccountingEntity {
private static readonly ActivitySource activitySource = new(typeof(ENInvoiceAccountingEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@Id, "id") ?? "id"},
{"invoiceid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid"},
{"suppliernumber", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@SupplierNumber, "suppliernumber") ?? "suppliernumber"},
{"servicetypeid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@ServiceTypeId, "servicetypeid") ?? "servicetypeid"},
{"freetext", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@FreeText, "freetext") ?? "freetext"},
{"division", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@Division, "division") ?? "division"},
{"ivaamount", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@IvaAmount, "ivaamount") ?? "ivaamount"},
{"iva_old", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@Iva_Old, "iva_old") ?? "iva_old"},
{"ivaindicatorid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@IvaIndicatorId, "ivaindicatorid") ?? "ivaindicatorid"},
{"totalamount", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@TotalAmount, "totalamount") ?? "totalamount"},
{"paymentmethodid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@PaymentMethodId, "paymentmethodid") ?? "paymentmethodid"},
{"paymenttermsid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@PaymentTermsId, "paymenttermsid") ?? "paymenttermsid"},
{"icmeindicator", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@ICMEIndicator, "icmeindicator") ?? "icmeindicator"},
{"createdby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@CreatedBy, "createdby") ?? "createdby"},
{"createdon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@CreatedOn, "createdon") ?? "createdon"},
{"submissionby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@SubmissionBy, "submissionby") ?? "submissionby"},
{"submissionon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@SubmissionOn, "submissionon") ?? "submissionon"},
{"servicecalledby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@ServiceCalledBy, "servicecalledby") ?? "servicecalledby"},
{"servicecalledon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@ServiceCalledOn, "servicecalledon") ?? "servicecalledon"},
{"buydocnumber", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@BuyDocNumber, "buydocnumber") ?? "buydocnumber"},
{"buydocposition", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@BuyDocPosition, "buydocposition") ?? "buydocposition"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, "invoi_u8aqr95gpfeo_9wd9sw_4nu0"));
}
} // ENInvoiceAccountingEntity

}

