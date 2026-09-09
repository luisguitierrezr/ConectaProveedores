using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENProcessTypeDatesAllowedEntity {
private static readonly ActivitySource activitySource = new(typeof(ENProcessTypeDatesAllowedEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@ProcessTypeDatesAllowed, _EntityKeyConstants._OrganizationEntityKeys._ProcessTypeDatesAllowedAttributeKeys.@Id, "id") ?? "id"},
{"processtypecode", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@ProcessTypeDatesAllowed, _EntityKeyConstants._OrganizationEntityKeys._ProcessTypeDatesAllowedAttributeKeys.@ProcessTypeCode, "processtypecode") ?? "processtypecode"},
{"dayofweekid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@ProcessTypeDatesAllowed, _EntityKeyConstants._OrganizationEntityKeys._ProcessTypeDatesAllowedAttributeKeys.@DayOfWeekId, "dayofweekid") ?? "dayofweekid"},
{"updatedon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@ProcessTypeDatesAllowed, _EntityKeyConstants._OrganizationEntityKeys._ProcessTypeDatesAllowedAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon"},
{"updatedby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@ProcessTypeDatesAllowed, _EntityKeyConstants._OrganizationEntityKeys._ProcessTypeDatesAllowedAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@ProcessTypeDatesAllowed, "proce_ok7ot05vqroli49onpjdisl4"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENProcessTypeDatesAllowedEntity

}

