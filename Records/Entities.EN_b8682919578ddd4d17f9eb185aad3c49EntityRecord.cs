using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENColumnSettingsEntity {
private static readonly ActivitySource activitySource = new(typeof(ENColumnSettingsEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ColumnSettings, _EntityKeyConstants._ConectaProveedoresEntityKeys._ColumnSettingsAttributeKeys.@Id, "id") ?? "id"},
{"tablename", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ColumnSettings, _EntityKeyConstants._ConectaProveedoresEntityKeys._ColumnSettingsAttributeKeys.@TableName, "tablename") ?? "tablename"},
{"jsondata", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ColumnSettings, _EntityKeyConstants._ConectaProveedoresEntityKeys._ColumnSettingsAttributeKeys.@JSONData, "jsondata") ?? "jsondata"},
{"userid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ColumnSettings, _EntityKeyConstants._ConectaProveedoresEntityKeys._ColumnSettingsAttributeKeys.@UserId, "userid") ?? "userid"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ColumnSettings, "colum_u8aqr95gpfetmnj0zugbe1u0"));
}
} // ENColumnSettingsEntity

}

