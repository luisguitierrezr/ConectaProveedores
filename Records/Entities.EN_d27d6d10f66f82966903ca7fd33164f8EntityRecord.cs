using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENEntraRoleEntity {
private static readonly ActivitySource activitySource = new(typeof(ENEntraRoleEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@EntraRole, _EntityKeyConstants._SecurityAuthEntityKeys._EntraRoleAttributeKeys.@Id, "id") ?? "id"},
{"rolename", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@EntraRole, _EntityKeyConstants._SecurityAuthEntityKeys._EntraRoleAttributeKeys.@RoleName, "rolename") ?? "rolename"},
{"isareausuaria", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@EntraRole, _EntityKeyConstants._SecurityAuthEntityKeys._EntraRoleAttributeKeys.@IsAreaUsuaria, "isareausuaria") ?? "isareausuaria"},
{"isareacxp", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@EntraRole, _EntityKeyConstants._SecurityAuthEntityKeys._EntraRoleAttributeKeys.@IsAreaCxP, "isareacxp") ?? "isareacxp"},
{"issolicitante", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@EntraRole, _EntityKeyConstants._SecurityAuthEntityKeys._EntraRoleAttributeKeys.@IsSolicitante, "issolicitante") ?? "issolicitante"},
{"isassistant", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@EntraRole, _EntityKeyConstants._SecurityAuthEntityKeys._EntraRoleAttributeKeys.@IsAssistant, "isassistant") ?? "isassistant"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@EntraRole, "entra_e_ge42by2w4e8ha9xvwdiqa3"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("97b32a7a-5154-4364-bb42-14d1f0d1f962");
} // ENEntraRoleEntity

}

