using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENFolioItemsEntity {
private static readonly ActivitySource activitySource = new(typeof(ENFolioItemsEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@Id, "id") ?? "id"},
{"folioid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@FolioId, "folioid") ?? "folioid"},
{"ordermainitemid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@OrderMainItemId, "ordermainitemid") ?? "ordermainitemid"},
{"ordernumber", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@OrderNumber, "ordernumber") ?? "ordernumber"},
{"articlenumber", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@ArticleNumber, "articlenumber") ?? "articlenumber"},
{"description", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@Description, "description") ?? "description"},
{"inputationcode", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@InputationCode, "inputationcode") ?? "inputationcode"},
{"deliverydate", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@DeliveryDate, "deliverydate") ?? "deliverydate"},
{"invoiceqtt", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@InvoiceQtt, "invoiceqtt") ?? "invoiceqtt"},
{"remainingqtt", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@RemainingQtt, "remainingqtt") ?? "remainingqtt"},
{"unitprice", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@UnitPrice, "unitprice") ?? "unitprice"},
{"totalprice", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@TotalPrice, "totalprice") ?? "totalprice"},
{"quantity", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@Quantity, "quantity") ?? "quantity"},
{"deliveryqtt", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@DeliveryQtt, "deliveryqtt") ?? "deliveryqtt"},
{"importdelivery", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@Importdelivery, "importdelivery") ?? "importdelivery"},
{"pep", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@PEP, "pep") ?? "pep"},
{"placeid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@PlaceId, "placeid") ?? "placeid"},
{"placename", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@PlaceName, "placename") ?? "placename"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, "folio_u8aqr95gpfex358e6fzyxup1"));
}
} // ENFolioItemsEntity

}

