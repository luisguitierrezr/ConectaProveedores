using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {

public sealed partial class ENProject_Asset_ServiceEntity {
private static readonly ActivitySource activitySource = new(typeof(ENProject_Asset_ServiceEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Project_Asset_Service, _EntityKeyConstants._OrganizationEntityKeys._Project_Asset_ServiceAttributeKeys.@Id, "id") ?? "id"},
{"description", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Project_Asset_Service, _EntityKeyConstants._OrganizationEntityKeys._Project_Asset_ServiceAttributeKeys.@Description, "description") ?? "description"},
{"isothers", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Project_Asset_Service, _EntityKeyConstants._OrganizationEntityKeys._Project_Asset_ServiceAttributeKeys.@IsOthers, "isothers") ?? "isothers"},
{"createdon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Project_Asset_Service, _EntityKeyConstants._OrganizationEntityKeys._Project_Asset_ServiceAttributeKeys.@CreatedOn, "createdon") ?? "createdon"},
{"createdby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Project_Asset_Service, _EntityKeyConstants._OrganizationEntityKeys._Project_Asset_ServiceAttributeKeys.@CreatedBy, "createdby") ?? "createdby"},
{"updatedon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Project_Asset_Service, _EntityKeyConstants._OrganizationEntityKeys._Project_Asset_ServiceAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon"},
{"updatedby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Project_Asset_Service, _EntityKeyConstants._OrganizationEntityKeys._Project_Asset_ServiceAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Project_Asset_Service, "proje_ok7ot05vqrox82hxrqwia8s7"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENProject_Asset_ServiceEntity

}

