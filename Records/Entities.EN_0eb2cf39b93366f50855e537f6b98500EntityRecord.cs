using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENOrderItemEntriesEntity {
private static readonly ActivitySource activitySource = new(typeof(ENOrderItemEntriesEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@Id, "id") ?? "id"},
{"ordermainitemid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@OrderMainItemid, "ordermainitemid") ?? "ordermainitemid"},
{"quantity_", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@Quantity_, "quantity_") ?? "quantity_"},
{"isfromfirstimport", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@IsFromFirstImport, "isfromfirstimport") ?? "isfromfirstimport"},
{"entrydocument", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@EntryDocument, "entrydocument") ?? "entrydocument"},
{"createdon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@CreatedOn, "createdon") ?? "createdon"},
{"createdby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@CreatedBy, "createdby") ?? "createdby"},
{"rejectfolio", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@RejectFolio, "rejectfolio") ?? "rejectfolio"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, "folio_u8aqr95gpfe_cej73o9f6rs0"));
}
} // ENOrderItemEntriesEntity

}

