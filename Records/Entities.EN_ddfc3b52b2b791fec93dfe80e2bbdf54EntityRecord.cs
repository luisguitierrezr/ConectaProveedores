using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENEntryBlockDatesEntity {
private static readonly ActivitySource activitySource = new(typeof(ENEntryBlockDatesEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@EntryBlockDates, _EntityKeyConstants._OrganizationEntityKeys._EntryBlockDatesAttributeKeys.@Id, "id") ?? "id"},
{"initialdate", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@EntryBlockDates, _EntityKeyConstants._OrganizationEntityKeys._EntryBlockDatesAttributeKeys.@InitialDate, "initialdate") ?? "initialdate"},
{"endingdate", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@EntryBlockDates, _EntityKeyConstants._OrganizationEntityKeys._EntryBlockDatesAttributeKeys.@EndingDate, "endingdate") ?? "endingdate"},
{"imputationcode", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@EntryBlockDates, _EntityKeyConstants._OrganizationEntityKeys._EntryBlockDatesAttributeKeys.@ImputationCode, "imputationcode") ?? "imputationcode"},
{"glaccountsid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@EntryBlockDates, _EntityKeyConstants._OrganizationEntityKeys._EntryBlockDatesAttributeKeys.@GLAccountsId, "glaccountsid") ?? "glaccountsid"},
{"isactive", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@EntryBlockDates, _EntityKeyConstants._OrganizationEntityKeys._EntryBlockDatesAttributeKeys.@IsActive, "isactive") ?? "isactive"},
{"createdon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@EntryBlockDates, _EntityKeyConstants._OrganizationEntityKeys._EntryBlockDatesAttributeKeys.@CreatedOn, "createdon") ?? "createdon"},
{"createdby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@EntryBlockDates, _EntityKeyConstants._OrganizationEntityKeys._EntryBlockDatesAttributeKeys.@CreatedBy, "createdby") ?? "createdby"},
{"updatedon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@EntryBlockDates, _EntityKeyConstants._OrganizationEntityKeys._EntryBlockDatesAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon"},
{"updatedby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@EntryBlockDates, _EntityKeyConstants._OrganizationEntityKeys._EntryBlockDatesAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@EntryBlockDates, "entry_ok7ot05vqrothxf6rdxb7mr3"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENEntryBlockDatesEntity

}

