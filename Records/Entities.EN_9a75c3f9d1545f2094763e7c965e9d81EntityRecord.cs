using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENSustainabilityEntity {
private static readonly ActivitySource activitySource = new(typeof(ENSustainabilityEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Sustainability, _EntityKeyConstants._OrganizationEntityKeys._SustainabilityAttributeKeys.@Id, "id") ?? "id"},
{"description", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Sustainability, _EntityKeyConstants._OrganizationEntityKeys._SustainabilityAttributeKeys.@Description, "description") ?? "description"},
{"createdon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Sustainability, _EntityKeyConstants._OrganizationEntityKeys._SustainabilityAttributeKeys.@CreatedOn, "createdon") ?? "createdon"},
{"createdby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Sustainability, _EntityKeyConstants._OrganizationEntityKeys._SustainabilityAttributeKeys.@CreatedBy, "createdby") ?? "createdby"},
{"updatedon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Sustainability, _EntityKeyConstants._OrganizationEntityKeys._SustainabilityAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon"},
{"updatedby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Sustainability, _EntityKeyConstants._OrganizationEntityKeys._SustainabilityAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby"},
{"isactive", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Sustainability, _EntityKeyConstants._OrganizationEntityKeys._SustainabilityAttributeKeys.@IsActive, "isactive") ?? "isactive"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Sustainability, "susta_ok7ot05vqroyvqqwznlheem6"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENSustainabilityEntity

}

