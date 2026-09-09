using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENInvoiceExtendedItemEntity {
private static readonly ActivitySource activitySource = new(typeof(ENInvoiceExtendedItemEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@Id, "id") ?? "id"},
{"invoiceid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid"},
{"productnumber", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@ProductNumber, "productnumber") ?? "productnumber"},
{"description", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@Description, "description") ?? "description"},
{"materialcode", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@MaterialCode, "materialcode") ?? "materialcode"},
{"quantity", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@Quantity, "quantity") ?? "quantity"},
{"unityprice", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@UnityPrice, "unityprice") ?? "unityprice"},
{"currency", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@Currency, "currency") ?? "currency"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, "invoi_u8aqr95gpfeuq0w8o23sdcq7"));
}
} // ENInvoiceExtendedItemEntity

}

