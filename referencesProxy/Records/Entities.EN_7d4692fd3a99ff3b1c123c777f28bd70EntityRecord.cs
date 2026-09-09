using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {

public sealed partial class ENAccountingAccounts_ServiceTypeEntity {
private static readonly ActivitySource activitySource = new(typeof(ENAccountingAccounts_ServiceTypeEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@AccountingAccounts_ServiceType, _EntityKeyConstants._OrganizationEntityKeys._AccountingAccounts_ServiceTypeAttributeKeys.@Id, "id") ?? "id"},
{"cc", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@AccountingAccounts_ServiceType, _EntityKeyConstants._OrganizationEntityKeys._AccountingAccounts_ServiceTypeAttributeKeys.@CC, "cc") ?? "cc"},
{"description", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@AccountingAccounts_ServiceType, _EntityKeyConstants._OrganizationEntityKeys._AccountingAccounts_ServiceTypeAttributeKeys.@Description, "description") ?? "description"},
{"isactive", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@AccountingAccounts_ServiceType, _EntityKeyConstants._OrganizationEntityKeys._AccountingAccounts_ServiceTypeAttributeKeys.@IsActive, "isactive") ?? "isactive"},
{"createdby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@AccountingAccounts_ServiceType, _EntityKeyConstants._OrganizationEntityKeys._AccountingAccounts_ServiceTypeAttributeKeys.@CreatedBy, "createdby") ?? "createdby"},
{"createdon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@AccountingAccounts_ServiceType, _EntityKeyConstants._OrganizationEntityKeys._AccountingAccounts_ServiceTypeAttributeKeys.@CreatedOn, "createdon") ?? "createdon"},
{"updatedby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@AccountingAccounts_ServiceType, _EntityKeyConstants._OrganizationEntityKeys._AccountingAccounts_ServiceTypeAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby"},
{"updatedon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@AccountingAccounts_ServiceType, _EntityKeyConstants._OrganizationEntityKeys._AccountingAccounts_ServiceTypeAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@AccountingAccounts_ServiceType, "accou_ok7ot05vqroxotoyq_0vh7y6"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENAccountingAccounts_ServiceTypeEntity

}

