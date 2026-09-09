using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENFolioFilesEntity {
private static readonly ActivitySource activitySource = new(typeof(ENFolioFilesEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioFiles, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioFilesAttributeKeys.@Id, "id") ?? "id"},
{"filename", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioFiles, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioFilesAttributeKeys.@Filename, "filename") ?? "filename"},
{"folioid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioFiles, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioFilesAttributeKeys.@FolioId, "folioid") ?? "folioid"},
{"isextra", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioFiles, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioFilesAttributeKeys.@IsExtra, "isextra") ?? "isextra"},
{"storageid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioFiles, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioFilesAttributeKeys.@StorageId, "storageid") ?? "storageid"},
{"createdby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioFiles, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioFilesAttributeKeys.@CreatedBy, "createdby") ?? "createdby"},
{"createdon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioFiles, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioFilesAttributeKeys.@CreatedOn, "createdon") ?? "createdon"},
{"isnewfile", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioFiles, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioFilesAttributeKeys.@IsNewFile, "isnewfile") ?? "isnewfile"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioFiles, "folio_u8aqr95gpfepid0cdzk893q5"));
}
} // ENFolioFilesEntity

}

