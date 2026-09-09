using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENInvoiceExtendedForeignerEntity {
private static readonly ActivitySource activitySource = new(typeof(ENInvoiceExtendedForeignerEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@Id, "id") ?? "id"},
{"invoicenumber", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@InvoiceNumber, "invoicenumber") ?? "invoicenumber"},
{"direction", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@Direction, "direction") ?? "direction"},
{"receiversocialreason", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@ReceiverSocialReason, "receiversocialreason") ?? "receiversocialreason"},
{"receiverrfc", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@ReceiverRFC, "receiverrfc") ?? "receiverrfc"},
{"issuersocialreason", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@IssuerSocialReason, "issuersocialreason") ?? "issuersocialreason"},
{"issuertaxid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@IssuerTaxId, "issuertaxid") ?? "issuertaxid"},
{"invoicedate", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@InvoiceDate, "invoicedate") ?? "invoicedate"},
{"totalamount", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@TotalAmount, "totalamount") ?? "totalamount"},
{"currency", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@Currency, "currency") ?? "currency"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, "invoi_u8aqr95gpfe1p8u7i4_lr4v2"));
}
} // ENInvoiceExtendedForeignerEntity

}

