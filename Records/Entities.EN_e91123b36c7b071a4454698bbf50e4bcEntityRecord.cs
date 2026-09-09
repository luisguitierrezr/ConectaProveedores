using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENInvoiceAccountingProcessResponseEntity {
private static readonly ActivitySource activitySource = new(typeof(ENInvoiceAccountingProcessResponseEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"invoiceaccountingprocessid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessResponse, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessResponseAttributeKeys.@InvoiceAccountingProcessId, "invoiceaccountingprocessid") ?? "invoiceaccountingprocessid"},
{"issuccess", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessResponse, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessResponseAttributeKeys.@IsSuccess, "issuccess") ?? "issuccess"},
{"id_poliza", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessResponse, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessResponseAttributeKeys.@ID_POLIZA, "id_poliza") ?? "id_poliza"},
{"texto", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessResponse, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessResponseAttributeKeys.@TEXTO, "texto") ?? "texto"},
{"po_resultado", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessResponse, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessResponseAttributeKeys.@PO_RESULTADO, "po_resultado") ?? "po_resultado"},
{"codigo", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessResponse, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessResponseAttributeKeys.@CODIGO, "codigo") ?? "codigo"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessResponse, "invoi_u8aqr95gpfetjbt4ono3fm43"));
}
} // ENInvoiceAccountingProcessResponseEntity

}

