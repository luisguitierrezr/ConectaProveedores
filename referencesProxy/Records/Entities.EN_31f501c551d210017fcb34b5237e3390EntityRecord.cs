using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {

public sealed partial class ENRegionEntity {
private static readonly ActivitySource activitySource = new(typeof(ENRegionEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Region, _EntityKeyConstants._OrganizationEntityKeys._RegionAttributeKeys.@Id, "id") ?? "id"},
{"code", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Region, _EntityKeyConstants._OrganizationEntityKeys._RegionAttributeKeys.@Code, "code") ?? "code"},
{"name", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Region, _EntityKeyConstants._OrganizationEntityKeys._RegionAttributeKeys.@Name, "name") ?? "name"},
{"divisionfi", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Region, _EntityKeyConstants._OrganizationEntityKeys._RegionAttributeKeys.@DivisionFI, "divisionfi") ?? "divisionfi"},
{"centrortp", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Region, _EntityKeyConstants._OrganizationEntityKeys._RegionAttributeKeys.@CentroRTP, "centrortp") ?? "centrortp"},
{"commissionregion", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Region, _EntityKeyConstants._OrganizationEntityKeys._RegionAttributeKeys.@CommissionRegion, "commissionregion") ?? "commissionregion"},
{"isactive", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Region, _EntityKeyConstants._OrganizationEntityKeys._RegionAttributeKeys.@IsActive, "isactive") ?? "isactive"},
{"createdon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Region, _EntityKeyConstants._OrganizationEntityKeys._RegionAttributeKeys.@CreatedOn, "createdon") ?? "createdon"},
{"createdby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Region, _EntityKeyConstants._OrganizationEntityKeys._RegionAttributeKeys.@CreatedBy, "createdby") ?? "createdby"},
{"updatedon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Region, _EntityKeyConstants._OrganizationEntityKeys._RegionAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon"},
{"updatedby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Region, _EntityKeyConstants._OrganizationEntityKeys._RegionAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby"},
{"isfsp", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Region, _EntityKeyConstants._OrganizationEntityKeys._RegionAttributeKeys.@IsFsP, "isfsp") ?? "isfsp"},
{"isfcp", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Region, _EntityKeyConstants._OrganizationEntityKeys._RegionAttributeKeys.@IsFcP, "isfcp") ?? "isfcp"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Region, "regio_ok7ot05vqroorg1hcklnjep3"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENRegionEntity

}

