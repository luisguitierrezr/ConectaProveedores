using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENDeletedStorageEntity {
private static readonly ActivitySource activitySource = new(typeof(ENDeletedStorageEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@TelcelStorage, _EntityKeyConstants._TelcelStorageEntityKeys.@DeletedStorage, _EntityKeyConstants._TelcelStorageEntityKeys._DeletedStorageAttributeKeys.@Id, "id") ?? "id"},
{"internalconceptid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@TelcelStorage, _EntityKeyConstants._TelcelStorageEntityKeys.@DeletedStorage, _EntityKeyConstants._TelcelStorageEntityKeys._DeletedStorageAttributeKeys.@InternalConceptId, "internalconceptid") ?? "internalconceptid"},
{"concept", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@TelcelStorage, _EntityKeyConstants._TelcelStorageEntityKeys.@DeletedStorage, _EntityKeyConstants._TelcelStorageEntityKeys._DeletedStorageAttributeKeys.@Concept, "concept") ?? "concept"},
{"filename", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@TelcelStorage, _EntityKeyConstants._TelcelStorageEntityKeys.@DeletedStorage, _EntityKeyConstants._TelcelStorageEntityKeys._DeletedStorageAttributeKeys.@Filename, "filename") ?? "filename"},
{"vendor", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@TelcelStorage, _EntityKeyConstants._TelcelStorageEntityKeys.@DeletedStorage, _EntityKeyConstants._TelcelStorageEntityKeys._DeletedStorageAttributeKeys.@Vendor, "vendor") ?? "vendor"},
{"doc_type", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@TelcelStorage, _EntityKeyConstants._TelcelStorageEntityKeys.@DeletedStorage, _EntityKeyConstants._TelcelStorageEntityKeys._DeletedStorageAttributeKeys.@Doc_Type, "doc_type") ?? "doc_type"},
{"object_type", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@TelcelStorage, _EntityKeyConstants._TelcelStorageEntityKeys.@DeletedStorage, _EntityKeyConstants._TelcelStorageEntityKeys._DeletedStorageAttributeKeys.@Object_type, "object_type") ?? "object_type"},
{"archive_id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@TelcelStorage, _EntityKeyConstants._TelcelStorageEntityKeys.@DeletedStorage, _EntityKeyConstants._TelcelStorageEntityKeys._DeletedStorageAttributeKeys.@Archive_ID, "archive_id") ?? "archive_id"},
{"arc_doc_id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@TelcelStorage, _EntityKeyConstants._TelcelStorageEntityKeys.@DeletedStorage, _EntityKeyConstants._TelcelStorageEntityKeys._DeletedStorageAttributeKeys.@Arc_Doc_ID, "arc_doc_id") ?? "arc_doc_id"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@TelcelStorage, _EntityKeyConstants._TelcelStorageEntityKeys.@DeletedStorage, "delet_pqz6uvkp8y5e11p7jp7_u2x6"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("bb3c573f-1de4-4979-b17a-0a3584b8c7b3");
} // ENDeletedStorageEntity

}

