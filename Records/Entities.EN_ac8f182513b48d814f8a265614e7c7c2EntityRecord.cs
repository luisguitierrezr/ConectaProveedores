using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENInvoiceExtendedItemTaxEntity {
private static readonly ActivitySource activitySource = new(typeof(ENInvoiceExtendedItemTaxEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@Id, "id") ?? "id"},
{"invoiceextendeditemid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@InvoiceExtendedItemId, "invoiceextendeditemid") ?? "invoiceextendeditemid"},
{"invoicetaxtypeid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@InvoiceTaxTypeId, "invoicetaxtypeid") ?? "invoicetaxtypeid"},
{"impuesto", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@Impuesto, "impuesto") ?? "impuesto"},
{"base", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@Base, "base") ?? "base"},
{"tasaocuota", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@TasaOCuota, "tasaocuota") ?? "tasaocuota"},
{"importe", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@Importe, "importe") ?? "importe"},
{"tipofactor", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@TipoFactor, "tipofactor") ?? "tipofactor"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, "invoi_u8aqr95gpfetngtkq9t6rpf5"));
}
} // ENInvoiceExtendedItemTaxEntity

}

