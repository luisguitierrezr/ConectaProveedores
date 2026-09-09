using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {

public sealed partial class ENManualFileEntity {
private static readonly ActivitySource activitySource = new(typeof(ENManualFileEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@ManualFile, _EntityKeyConstants._OrganizationEntityKeys._ManualFileAttributeKeys.@Id, "id") ?? "id"},
{"filename", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@ManualFile, _EntityKeyConstants._OrganizationEntityKeys._ManualFileAttributeKeys.@Filename, "filename") ?? "filename"},
{"file", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@ManualFile, _EntityKeyConstants._OrganizationEntityKeys._ManualFileAttributeKeys.@File, "file") ?? "file"},
{"videolink", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@ManualFile, _EntityKeyConstants._OrganizationEntityKeys._ManualFileAttributeKeys.@VideoLink, "videolink") ?? "videolink"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@ManualFile, "manua_ok7ot05vqrotq1d12muzip05"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENManualFileEntity

}

