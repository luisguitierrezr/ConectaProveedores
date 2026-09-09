using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {

public sealed partial class ENUserApplicationRoleEntity {
private static readonly ActivitySource activitySource = new(typeof(ENUserApplicationRoleEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@UserApplicationRole, _EntityKeyConstants._SecurityAuthEntityKeys._UserApplicationRoleAttributeKeys.@Id, "id") ?? "id"},
{"userid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@UserApplicationRole, _EntityKeyConstants._SecurityAuthEntityKeys._UserApplicationRoleAttributeKeys.@UserId, "userid") ?? "userid"},
{"applicationroleid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@UserApplicationRole, _EntityKeyConstants._SecurityAuthEntityKeys._UserApplicationRoleAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid"},
{"regiontobeassign", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@UserApplicationRole, _EntityKeyConstants._SecurityAuthEntityKeys._UserApplicationRoleAttributeKeys.@RegionToBeAssign, "regiontobeassign") ?? "regiontobeassign"},
{"assignedby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@UserApplicationRole, _EntityKeyConstants._SecurityAuthEntityKeys._UserApplicationRoleAttributeKeys.@AssignedBy, "assignedby") ?? "assignedby"},
{"assigneddate", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@UserApplicationRole, _EntityKeyConstants._SecurityAuthEntityKeys._UserApplicationRoleAttributeKeys.@AssignedDate, "assigneddate") ?? "assigneddate"},
{"rolestatusid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@UserApplicationRole, _EntityKeyConstants._SecurityAuthEntityKeys._UserApplicationRoleAttributeKeys.@RoleStatusId, "rolestatusid") ?? "rolestatusid"},
{"revokedby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@UserApplicationRole, _EntityKeyConstants._SecurityAuthEntityKeys._UserApplicationRoleAttributeKeys.@RevokedBy, "revokedby") ?? "revokedby"},
{"revokeddate", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@UserApplicationRole, _EntityKeyConstants._SecurityAuthEntityKeys._UserApplicationRoleAttributeKeys.@RevokedDate, "revokeddate") ?? "revokeddate"},
{"conceptid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@UserApplicationRole, _EntityKeyConstants._SecurityAuthEntityKeys._UserApplicationRoleAttributeKeys.@ConceptId, "conceptid") ?? "conceptid"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@UserApplicationRole, "usera_e_ge42by2w4fyxanldizlvd2"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("97b32a7a-5154-4364-bb42-14d1f0d1f962");
} // ENUserApplicationRoleEntity

}

