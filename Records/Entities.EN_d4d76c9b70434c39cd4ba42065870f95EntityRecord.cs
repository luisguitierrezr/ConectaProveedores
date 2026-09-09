using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENFiscalYearExceptionsEntity {
private static readonly ActivitySource activitySource = new(typeof(ENFiscalYearExceptionsEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@FiscalYearExceptions, _EntityKeyConstants._OrganizationEntityKeys._FiscalYearExceptionsAttributeKeys.@Id, "id") ?? "id"},
{"year", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@FiscalYearExceptions, _EntityKeyConstants._OrganizationEntityKeys._FiscalYearExceptionsAttributeKeys.@Year, "year") ?? "year"},
{"invoicefolio", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@FiscalYearExceptions, _EntityKeyConstants._OrganizationEntityKeys._FiscalYearExceptionsAttributeKeys.@InvoiceFolio, "invoicefolio") ?? "invoicefolio"},
{"invoiceuuid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@FiscalYearExceptions, _EntityKeyConstants._OrganizationEntityKeys._FiscalYearExceptionsAttributeKeys.@InvoiceUUID, "invoiceuuid") ?? "invoiceuuid"},
{"isactive", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@FiscalYearExceptions, _EntityKeyConstants._OrganizationEntityKeys._FiscalYearExceptionsAttributeKeys.@IsActive, "isactive") ?? "isactive"},
{"createdon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@FiscalYearExceptions, _EntityKeyConstants._OrganizationEntityKeys._FiscalYearExceptionsAttributeKeys.@CreatedOn, "createdon") ?? "createdon"},
{"createdby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@FiscalYearExceptions, _EntityKeyConstants._OrganizationEntityKeys._FiscalYearExceptionsAttributeKeys.@CreatedBy, "createdby") ?? "createdby"},
{"updatedon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@FiscalYearExceptions, _EntityKeyConstants._OrganizationEntityKeys._FiscalYearExceptionsAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon"},
{"updatedby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@FiscalYearExceptions, _EntityKeyConstants._OrganizationEntityKeys._FiscalYearExceptionsAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@FiscalYearExceptions, "fisca_ok7ot05vqroys7uc_ouozdn4"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENFiscalYearExceptionsEntity

}

