using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENUserEntity {
private static readonly ActivitySource activitySource = new(typeof(ENUserEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@System_, _EntityKeyConstants._System_EntityKeys.@User, _EntityKeyConstants._System_EntityKeys._UserAttributeKeys.@Id, "id") ?? "id"},
{"name", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@System_, _EntityKeyConstants._System_EntityKeys.@User, _EntityKeyConstants._System_EntityKeys._UserAttributeKeys.@Name, "name") ?? "name"},
{"email", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@System_, _EntityKeyConstants._System_EntityKeys.@User, _EntityKeyConstants._System_EntityKeys._UserAttributeKeys.@Email, "email") ?? "email"},
{"photourl", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@System_, _EntityKeyConstants._System_EntityKeys.@User, _EntityKeyConstants._System_EntityKeys._UserAttributeKeys.@PhotoUrl, "photourl") ?? "photourl"},
{"username", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@System_, _EntityKeyConstants._System_EntityKeys.@User, _EntityKeyConstants._System_EntityKeys._UserAttributeKeys.@Username, "username") ?? "username"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@System_, _EntityKeyConstants._System_EntityKeys.@User, "osvue_user"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("478870b9-2d60-4f73-9eb3-7cd8b994a737");
} // ENUserEntity

}

