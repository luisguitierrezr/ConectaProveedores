using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENInvoiceExtendedMoreChargesEntity {
private static readonly ActivitySource activitySource = new(typeof(ENInvoiceExtendedMoreChargesEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedMoreCharges, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedMoreChargesAttributeKeys.@Id, "id") ?? "id"},
{"invoiceid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedMoreCharges, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedMoreChargesAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid"},
{"nombreconcepto", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedMoreCharges, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedMoreChargesAttributeKeys.@NombreConcepto, "nombreconcepto") ?? "nombreconcepto"},
{"value", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedMoreCharges, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedMoreChargesAttributeKeys.@Value, "value") ?? "value"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedMoreCharges, "invoi_u8aqr95gpfezcphhmkwcp_k6"));
}
} // ENInvoiceExtendedMoreChargesEntity

}

