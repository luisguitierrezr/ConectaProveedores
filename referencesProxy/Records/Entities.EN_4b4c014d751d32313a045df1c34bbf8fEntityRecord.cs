using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {

public sealed partial class ENInvoiceUsageEntity {
private static readonly ActivitySource activitySource = new(typeof(ENInvoiceUsageEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@InvoiceUsage, _EntityKeyConstants._OrganizationEntityKeys._InvoiceUsageAttributeKeys.@Id, "id") ?? "id"},
{"key", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@InvoiceUsage, _EntityKeyConstants._OrganizationEntityKeys._InvoiceUsageAttributeKeys.@Key, "key") ?? "key"},
{"description", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@InvoiceUsage, _EntityKeyConstants._OrganizationEntityKeys._InvoiceUsageAttributeKeys.@Description, "description") ?? "description"},
{"isappliedtoobjectiveperson", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@InvoiceUsage, _EntityKeyConstants._OrganizationEntityKeys._InvoiceUsageAttributeKeys.@IsAppliedToObjectivePerson, "isappliedtoobjectiveperson") ?? "isappliedtoobjectiveperson"},
{"isappliedtomoralperson", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@InvoiceUsage, _EntityKeyConstants._OrganizationEntityKeys._InvoiceUsageAttributeKeys.@IsAppliedToMoralPerson, "isappliedtomoralperson") ?? "isappliedtomoralperson"},
{"isactive", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@InvoiceUsage, _EntityKeyConstants._OrganizationEntityKeys._InvoiceUsageAttributeKeys.@IsActive, "isactive") ?? "isactive"},
{"createdon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@InvoiceUsage, _EntityKeyConstants._OrganizationEntityKeys._InvoiceUsageAttributeKeys.@CreatedOn, "createdon") ?? "createdon"},
{"createdby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@InvoiceUsage, _EntityKeyConstants._OrganizationEntityKeys._InvoiceUsageAttributeKeys.@CreatedBy, "createdby") ?? "createdby"},
{"updatedon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@InvoiceUsage, _EntityKeyConstants._OrganizationEntityKeys._InvoiceUsageAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon"},
{"updatedby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@InvoiceUsage, _EntityKeyConstants._OrganizationEntityKeys._InvoiceUsageAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@InvoiceUsage, "invoi_ok7ot05vqromhvlvqj0m7w62"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENInvoiceUsageEntity

}

