using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENUserApplicationRoleTempEntity {
private static readonly ActivitySource activitySource = new(typeof(ENUserApplicationRoleTempEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@UserApplicationRoleTemp, _EntityKeyConstants._SecurityAuthEntityKeys._UserApplicationRoleTempAttributeKeys.@Id, "id") ?? "id"},
{"userid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@UserApplicationRoleTemp, _EntityKeyConstants._SecurityAuthEntityKeys._UserApplicationRoleTempAttributeKeys.@UserId, "userid") ?? "userid"},
{"applicationroleid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@UserApplicationRoleTemp, _EntityKeyConstants._SecurityAuthEntityKeys._UserApplicationRoleTempAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid"},
{"entraroleid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@UserApplicationRoleTemp, _EntityKeyConstants._SecurityAuthEntityKeys._UserApplicationRoleTempAttributeKeys.@EntraRoleId, "entraroleid") ?? "entraroleid"},
{"assignedby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@UserApplicationRoleTemp, _EntityKeyConstants._SecurityAuthEntityKeys._UserApplicationRoleTempAttributeKeys.@AssignedBy, "assignedby") ?? "assignedby"},
{"assigneddate", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@UserApplicationRoleTemp, _EntityKeyConstants._SecurityAuthEntityKeys._UserApplicationRoleTempAttributeKeys.@AssignedDate, "assigneddate") ?? "assigneddate"},
{"rolestatusid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@UserApplicationRoleTemp, _EntityKeyConstants._SecurityAuthEntityKeys._UserApplicationRoleTempAttributeKeys.@RoleStatusId, "rolestatusid") ?? "rolestatusid"},
{"revokedby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@UserApplicationRoleTemp, _EntityKeyConstants._SecurityAuthEntityKeys._UserApplicationRoleTempAttributeKeys.@RevokedBy, "revokedby") ?? "revokedby"},
{"revokeddate", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@UserApplicationRoleTemp, _EntityKeyConstants._SecurityAuthEntityKeys._UserApplicationRoleTempAttributeKeys.@RevokedDate, "revokeddate") ?? "revokeddate"},
{"datefrom", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@UserApplicationRoleTemp, _EntityKeyConstants._SecurityAuthEntityKeys._UserApplicationRoleTempAttributeKeys.@DateFrom, "datefrom") ?? "datefrom"},
{"dateto", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@UserApplicationRoleTemp, _EntityKeyConstants._SecurityAuthEntityKeys._UserApplicationRoleTempAttributeKeys.@DateTo, "dateto") ?? "dateto"},
{"lastupdatedon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@UserApplicationRoleTemp, _EntityKeyConstants._SecurityAuthEntityKeys._UserApplicationRoleTempAttributeKeys.@LastUpdatedOn, "lastupdatedon") ?? "lastupdatedon"},
{"conceptid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@UserApplicationRoleTemp, _EntityKeyConstants._SecurityAuthEntityKeys._UserApplicationRoleTempAttributeKeys.@ConceptId, "conceptid") ?? "conceptid"},
{"regiontobeassign", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@UserApplicationRoleTemp, _EntityKeyConstants._SecurityAuthEntityKeys._UserApplicationRoleTempAttributeKeys.@RegionToBeAssign, "regiontobeassign") ?? "regiontobeassign"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@UserApplicationRoleTemp, "usera_e_ge42by2w4dlamvmgvh87u6"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("97b32a7a-5154-4364-bb42-14d1f0d1f962");
} // ENUserApplicationRoleTempEntity

}

