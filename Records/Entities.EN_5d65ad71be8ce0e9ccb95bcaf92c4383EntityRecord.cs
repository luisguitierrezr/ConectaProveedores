using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENInvoiceExtendedSelloDigitalEntity {
private static readonly ActivitySource activitySource = new(typeof(ENInvoiceExtendedSelloDigitalEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"invoiceid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedSelloDigital, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedSelloDigitalAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid"},
{"sellodigital", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedSelloDigital, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedSelloDigitalAttributeKeys.@SelloDigital, "sellodigital") ?? "sellodigital"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedSelloDigital, "invoi_u8aqr95gpfew4nbtwroz1440"));
}
} // ENInvoiceExtendedSelloDigitalEntity

}

