using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENInvoiceExtendedRelationsEntity {
private static readonly ActivitySource activitySource = new(typeof(ENInvoiceExtendedRelationsEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedRelations, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedRelationsAttributeKeys.@Id, "id") ?? "id"},
{"invoiceid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedRelations, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedRelationsAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid"},
{"tiporelacion", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedRelations, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedRelationsAttributeKeys.@TipoRelacion, "tiporelacion") ?? "tiporelacion"},
{"uuidrelacionado", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedRelations, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedRelationsAttributeKeys.@UUIDRelacionado, "uuidrelacionado") ?? "uuidrelacionado"},
{"foliorelacionado", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedRelations, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedRelationsAttributeKeys.@FolioRelacionado, "foliorelacionado") ?? "foliorelacionado"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedRelations, "invoi_u8aqr95gpfey05cja5m5nya2"));
}
} // ENInvoiceExtendedRelationsEntity

}

