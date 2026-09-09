using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENCompanyEntity {
private static readonly ActivitySource activitySource = new(typeof(ENCompanyEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Company, _EntityKeyConstants._OrganizationEntityKeys._CompanyAttributeKeys.@Id, "id") ?? "id"},
{"externalid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Company, _EntityKeyConstants._OrganizationEntityKeys._CompanyAttributeKeys.@ExternalId, "externalid") ?? "externalid"},
{"description", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Company, _EntityKeyConstants._OrganizationEntityKeys._CompanyAttributeKeys.@Description, "description") ?? "description"},
{"rfc", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Company, _EntityKeyConstants._OrganizationEntityKeys._CompanyAttributeKeys.@RFC, "rfc") ?? "rfc"},
{"postalcode", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Company, _EntityKeyConstants._OrganizationEntityKeys._CompanyAttributeKeys.@PostalCode, "postalcode") ?? "postalcode"},
{"cyaimport", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Company, _EntityKeyConstants._OrganizationEntityKeys._CompanyAttributeKeys.@CyAImport, "cyaimport") ?? "cyaimport"},
{"fspuse", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Company, _EntityKeyConstants._OrganizationEntityKeys._CompanyAttributeKeys.@FsPUse, "fspuse") ?? "fspuse"},
{"createdon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Company, _EntityKeyConstants._OrganizationEntityKeys._CompanyAttributeKeys.@CreatedOn, "createdon") ?? "createdon"},
{"createdby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Company, _EntityKeyConstants._OrganizationEntityKeys._CompanyAttributeKeys.@CreatedBy, "createdby") ?? "createdby"},
{"updatedon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Company, _EntityKeyConstants._OrganizationEntityKeys._CompanyAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon"},
{"updatedby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Company, _EntityKeyConstants._OrganizationEntityKeys._CompanyAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Company, "compa_ok7ot05vqromd0dqd58fg5v3"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENCompanyEntity

}

