using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENInvoicesUsageAccountsEntity {
private static readonly ActivitySource activitySource = new(typeof(ENInvoicesUsageAccountsEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@InvoicesUsageAccounts, _EntityKeyConstants._OrganizationEntityKeys._InvoicesUsageAccountsAttributeKeys.@Id, "id") ?? "id"},
{"invoiceusageid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@InvoicesUsageAccounts, _EntityKeyConstants._OrganizationEntityKeys._InvoicesUsageAccountsAttributeKeys.@InvoiceUsageId, "invoiceusageid") ?? "invoiceusageid"},
{"accountingaccount", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@InvoicesUsageAccounts, _EntityKeyConstants._OrganizationEntityKeys._InvoicesUsageAccountsAttributeKeys.@AccountingAccount, "accountingaccount") ?? "accountingaccount"},
{"createdon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@InvoicesUsageAccounts, _EntityKeyConstants._OrganizationEntityKeys._InvoicesUsageAccountsAttributeKeys.@CreatedOn, "createdon") ?? "createdon"},
{"createdby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@InvoicesUsageAccounts, _EntityKeyConstants._OrganizationEntityKeys._InvoicesUsageAccountsAttributeKeys.@CreatedBy, "createdby") ?? "createdby"},
{"updatedon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@InvoicesUsageAccounts, _EntityKeyConstants._OrganizationEntityKeys._InvoicesUsageAccountsAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon"},
{"updatedby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@InvoicesUsageAccounts, _EntityKeyConstants._OrganizationEntityKeys._InvoicesUsageAccountsAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@InvoicesUsageAccounts, "invoi_ok7ot05vqropalnwj_whax81"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENInvoicesUsageAccountsEntity

}

