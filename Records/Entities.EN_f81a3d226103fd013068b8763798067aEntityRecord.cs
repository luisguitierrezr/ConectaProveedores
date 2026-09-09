using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENInvoiceExtendedEntity {
private static readonly ActivitySource activitySource = new(typeof(ENInvoiceExtendedEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Id, "id") ?? "id"},
{"version", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Version, "version") ?? "version"},
{"folio", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Folio, "folio") ?? "folio"},
{"serie", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Serie, "serie") ?? "serie"},
{"fechaemision", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@FechaEmision, "fechaemision") ?? "fechaemision"},
{"formapago", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@FormaPago, "formapago") ?? "formapago"},
{"metodopago", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@MetodoPago, "metodopago") ?? "metodopago"},
{"lugarexpedicion", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@LugarExpedicion, "lugarexpedicion") ?? "lugarexpedicion"},
{"subtotal", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Subtotal, "subtotal") ?? "subtotal"},
{"descuento", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Descuento, "descuento") ?? "descuento"},
{"totaliva", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@TotalIVA, "totaliva") ?? "totaliva"},
{"retenciones", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Retenciones, "retenciones") ?? "retenciones"},
{"total", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Total, "total") ?? "total"},
{"tipocomprobante", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@TipoComprobante, "tipocomprobante") ?? "tipocomprobante"},
{"moneda", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Moneda, "moneda") ?? "moneda"},
{"tipocambio", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@TipoCambio, "tipocambio") ?? "tipocambio"},
{"usocfdi", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@UsoCFDI, "usocfdi") ?? "usocfdi"},
{"exportacion", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Exportacion, "exportacion") ?? "exportacion"},
{"uuid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@UUID, "uuid") ?? "uuid"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, "invoi_u8aqr95gpfetz5oaq5b1w1w6"));
}
} // ENInvoiceExtendedEntity

}

