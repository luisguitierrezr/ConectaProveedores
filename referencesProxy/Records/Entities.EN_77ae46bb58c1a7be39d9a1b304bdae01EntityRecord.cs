using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {

public sealed partial class ENRoleConceptEntity {
private static readonly ActivitySource activitySource = new(typeof(ENRoleConceptEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@RoleConcept, _EntityKeyConstants._SecurityAuthEntityKeys._RoleConceptAttributeKeys.@Id, "id") ?? "id"},
{"applicationroleid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@RoleConcept, _EntityKeyConstants._SecurityAuthEntityKeys._RoleConceptAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid"},
{"conceptid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@RoleConcept, _EntityKeyConstants._SecurityAuthEntityKeys._RoleConceptAttributeKeys.@ConceptId, "conceptid") ?? "conceptid"},
{"entraroleid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@RoleConcept, _EntityKeyConstants._SecurityAuthEntityKeys._RoleConceptAttributeKeys.@EntraRoleId, "entraroleid") ?? "entraroleid"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@RoleConcept, "rolec_e_ge42by2w4b5wnxcw0jt1k3"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("97b32a7a-5154-4364-bb42-14d1f0d1f962");
} // ENRoleConceptEntity

}

