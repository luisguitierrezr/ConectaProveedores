using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENAccountableGuideEntity {
private static readonly ActivitySource activitySource = new(typeof(ENAccountableGuideEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@AccountableGuide, _EntityKeyConstants._OrganizationEntityKeys._AccountableGuideAttributeKeys.@Id, "id") ?? "id"},
{"supplierid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@AccountableGuide, _EntityKeyConstants._OrganizationEntityKeys._AccountableGuideAttributeKeys.@SupplierId, "supplierid") ?? "supplierid"},
{"project_asset_serviceid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@AccountableGuide, _EntityKeyConstants._OrganizationEntityKeys._AccountableGuideAttributeKeys.@Project_Asset_ServiceId, "project_asset_serviceid") ?? "project_asset_serviceid"},
{"regionid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@AccountableGuide, _EntityKeyConstants._OrganizationEntityKeys._AccountableGuideAttributeKeys.@RegionId, "regionid") ?? "regionid"},
{"accountname", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@AccountableGuide, _EntityKeyConstants._OrganizationEntityKeys._AccountableGuideAttributeKeys.@AccountName, "accountname") ?? "accountname"},
{"account", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@AccountableGuide, _EntityKeyConstants._OrganizationEntityKeys._AccountableGuideAttributeKeys.@Account, "account") ?? "account"},
{"costcentersapid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@AccountableGuide, _EntityKeyConstants._OrganizationEntityKeys._AccountableGuideAttributeKeys.@CostCenterSAPId, "costcentersapid") ?? "costcentersapid"},
{"createdon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@AccountableGuide, _EntityKeyConstants._OrganizationEntityKeys._AccountableGuideAttributeKeys.@CreatedOn, "createdon") ?? "createdon"},
{"createdby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@AccountableGuide, _EntityKeyConstants._OrganizationEntityKeys._AccountableGuideAttributeKeys.@CreatedBy, "createdby") ?? "createdby"},
{"updatedon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@AccountableGuide, _EntityKeyConstants._OrganizationEntityKeys._AccountableGuideAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon"},
{"updatedby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@AccountableGuide, _EntityKeyConstants._OrganizationEntityKeys._AccountableGuideAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@AccountableGuide, "accou_ok7ot05vqropcp3e02z0hg94"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENAccountableGuideEntity

}

