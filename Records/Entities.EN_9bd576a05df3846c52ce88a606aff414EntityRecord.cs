using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENInvoiceExtendedCartaPorteEntity {
private static readonly ActivitySource activitySource = new(typeof(ENInvoiceExtendedCartaPorteEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedCartaPorte, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedCartaPorteAttributeKeys.@Id, "id") ?? "id"},
{"descripcion", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedCartaPorte, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedCartaPorteAttributeKeys.@Descripcion, "descripcion") ?? "descripcion"},
{"valormercancia", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedCartaPorte, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedCartaPorteAttributeKeys.@ValorMercancia, "valormercancia") ?? "valormercancia"},
{"centroatencion", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedCartaPorte, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedCartaPorteAttributeKeys.@CentroAtencion, "centroatencion") ?? "centroatencion"},
{"calle", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedCartaPorte, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedCartaPorteAttributeKeys.@Calle, "calle") ?? "calle"},
{"numeroexterior", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedCartaPorte, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedCartaPorteAttributeKeys.@NumeroExterior, "numeroexterior") ?? "numeroexterior"},
{"codigopostal", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedCartaPorte, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedCartaPorteAttributeKeys.@CodigoPostal, "codigopostal") ?? "codigopostal"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedCartaPorte, "invoi_u8aqr95gpfet10c8zkbtum94"));
}
} // ENInvoiceExtendedCartaPorteEntity

}

