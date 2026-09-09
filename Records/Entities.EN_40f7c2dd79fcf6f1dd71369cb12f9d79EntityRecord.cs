using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENInvoicePolizaEntity {
private static readonly ActivitySource activitySource = new(typeof(ENInvoicePolizaEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@Id, "id") ?? "id"},
{"polizaid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@PolizaId, "polizaid") ?? "polizaid"},
{"polizasap", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@PolizaSAP, "polizasap") ?? "polizasap"},
{"sapobject", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@SAPObject, "sapobject") ?? "sapobject"},
{"sent", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@Sent, "sent") ?? "sent"},
{"sentwhen", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@SentWhen, "sentwhen") ?? "sentwhen"},
{"witherror", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@WithError, "witherror") ?? "witherror"},
{"error_message", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@Error_Message, "error_message") ?? "error_message"},
{"createdon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@CreatedOn, "createdon") ?? "createdon"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, "invoi_u8aqr95gpfeuyt1w8kibwj33"));
}
} // ENInvoicePolizaEntity

}

