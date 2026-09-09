using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENApplicationRoleEntity {
private static readonly ActivitySource activitySource = new(typeof(ENApplicationRoleEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@ApplicationRole, _EntityKeyConstants._SecurityAuthEntityKeys._ApplicationRoleAttributeKeys.@Id, "id") ?? "id"},
{"code", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@ApplicationRole, _EntityKeyConstants._SecurityAuthEntityKeys._ApplicationRoleAttributeKeys.@Code, "code") ?? "code"},
{"name", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@ApplicationRole, _EntityKeyConstants._SecurityAuthEntityKeys._ApplicationRoleAttributeKeys.@Name, "name") ?? "name"},
{"isactive", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@ApplicationRole, _EntityKeyConstants._SecurityAuthEntityKeys._ApplicationRoleAttributeKeys.@IsActive, "isactive") ?? "isactive"},
{"isareausuaria", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@ApplicationRole, _EntityKeyConstants._SecurityAuthEntityKeys._ApplicationRoleAttributeKeys.@IsAreaUsuaria, "isareausuaria") ?? "isareausuaria"},
{"isareacxp", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@ApplicationRole, _EntityKeyConstants._SecurityAuthEntityKeys._ApplicationRoleAttributeKeys.@IsAreaCxP, "isareacxp") ?? "isareacxp"},
{"canbulkapprovefolios", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@ApplicationRole, _EntityKeyConstants._SecurityAuthEntityKeys._ApplicationRoleAttributeKeys.@CanBulkApproveFolios, "canbulkapprovefolios") ?? "canbulkapprovefolios"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@ApplicationRole, "appli_e_ge42by2w4lfrzu7izq3q41"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("97b32a7a-5154-4364-bb42-14d1f0d1f962");
} // ENApplicationRoleEntity

}

