using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENInvoiceExtendedIssuerEntity {
private static readonly ActivitySource activitySource = new(typeof(ENInvoiceExtendedIssuerEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedIssuer, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedIssuerAttributeKeys.@Id, "id") ?? "id"},
{"rfc", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedIssuer, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedIssuerAttributeKeys.@RFC, "rfc") ?? "rfc"},
{"nombre", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedIssuer, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedIssuerAttributeKeys.@Nombre, "nombre") ?? "nombre"},
{"regimenfiscal", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedIssuer, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedIssuerAttributeKeys.@RegimenFiscal, "regimenfiscal") ?? "regimenfiscal"},
{"codigopostal", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedIssuer, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedIssuerAttributeKeys.@CodigoPostal, "codigopostal") ?? "codigopostal"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedIssuer, "invoi_u8aqr95gpfeolpb8pndtukk5"));
}
} // ENInvoiceExtendedIssuerEntity

}

