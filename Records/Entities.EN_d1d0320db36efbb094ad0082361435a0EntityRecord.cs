using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENInvoiceEntity {
private static readonly ActivitySource activitySource = new(typeof(ENInvoiceEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@Id, "id") ?? "id"},
{"name", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@Name, "name") ?? "name"},
{"requisitionid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid"},
{"folioid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@FolioId, "folioid") ?? "folioid"},
{"ordermainid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@OrderMainId, "ordermainid") ?? "ordermainid"},
{"cfditypeid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@CFDITypeId, "cfditypeid") ?? "cfditypeid"},
{"totalamount", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@TotalAmount, "totalamount") ?? "totalamount"},
{"currency", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@Currency, "currency") ?? "currency"},
{"invoicestatusid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@InvoiceStatusId, "invoicestatusid") ?? "invoicestatusid"},
{"accountingdatetime", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@AccountingDateTime, "accountingdatetime") ?? "accountingdatetime"},
{"paymentdatetime", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@PaymentDateTime, "paymentdatetime") ?? "paymentdatetime"},
{"createdon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@CreatedOn, "createdon") ?? "createdon"},
{"createdby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@CreatedBy, "createdby") ?? "createdby"},
{"updatedon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon"},
{"updatedby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby"},
{"submittedon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@SubmittedOn, "submittedon") ?? "submittedon"},
{"isnewversion", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@IsNewVersion, "isnewversion") ?? "isnewversion"},
{"id_poliza", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@ID_POLIZA, "id_poliza") ?? "id_poliza"},
{"id_poliza_sap", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@ID_POLIZA_SAP, "id_poliza_sap") ?? "id_poliza_sap"},
{"doc51", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@Doc51, "doc51") ?? "doc51"},
{"accountingerror", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@AccountingError, "accountingerror") ?? "accountingerror"},
{"orderaccconceptsid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@OrderAccConceptsID, "orderaccconceptsid") ?? "orderaccconceptsid"},
{"amortization", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@Amortization, "amortization") ?? "amortization"},
{"creditnoteinvoiceid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@CreditNoteInvoiceId, "creditnoteinvoiceid") ?? "creditnoteinvoiceid"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, "invoi_u8aqr95gpfeyj77gagfoy467"));
}
} // ENInvoiceEntity

}

