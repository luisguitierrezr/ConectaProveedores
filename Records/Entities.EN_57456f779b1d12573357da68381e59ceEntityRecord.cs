using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENFileImportLogEntity {
private static readonly ActivitySource activitySource = new(typeof(ENFileImportLogEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileImportLog, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileImportLogAttributeKeys.@Id, "id") ?? "id"},
{"fileid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileImportLog, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileImportLogAttributeKeys.@FileId, "fileid") ?? "fileid"},
{"timestamp", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileImportLog, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileImportLogAttributeKeys.@Timestamp, "timestamp") ?? "timestamp"},
{"importtype", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileImportLog, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileImportLogAttributeKeys.@ImportType, "importtype") ?? "importtype"},
{"importedby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileImportLog, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileImportLogAttributeKeys.@ImportedBy, "importedby") ?? "importedby"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileImportLog, "file__u8aqr95gpfeuwtqw84ujowr0"));
}
} // ENFileImportLogEntity

}

