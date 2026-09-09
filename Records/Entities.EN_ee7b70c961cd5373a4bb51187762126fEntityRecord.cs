using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENPurchasingGroupEntity {
private static readonly ActivitySource activitySource = new(typeof(ENPurchasingGroupEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@PurchasingGroup, _EntityKeyConstants._OrganizationEntityKeys._PurchasingGroupAttributeKeys.@Id, "id") ?? "id"},
{"md", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@PurchasingGroup, _EntityKeyConstants._OrganizationEntityKeys._PurchasingGroupAttributeKeys.@Md, "md") ?? "md"},
{"code", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@PurchasingGroup, _EntityKeyConstants._OrganizationEntityKeys._PurchasingGroupAttributeKeys.@Code, "code") ?? "code"},
{"denomination", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@PurchasingGroup, _EntityKeyConstants._OrganizationEntityKeys._PurchasingGroupAttributeKeys.@Denomination, "denomination") ?? "denomination"},
{"usedon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@PurchasingGroup, _EntityKeyConstants._OrganizationEntityKeys._PurchasingGroupAttributeKeys.@UsedOn, "usedon") ?? "usedon"},
{"regionid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@PurchasingGroup, _EntityKeyConstants._OrganizationEntityKeys._PurchasingGroupAttributeKeys.@RegionId, "regionid") ?? "regionid"},
{"notes", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@PurchasingGroup, _EntityKeyConstants._OrganizationEntityKeys._PurchasingGroupAttributeKeys.@Notes, "notes") ?? "notes"},
{"createdon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@PurchasingGroup, _EntityKeyConstants._OrganizationEntityKeys._PurchasingGroupAttributeKeys.@CreatedOn, "createdon") ?? "createdon"},
{"createdby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@PurchasingGroup, _EntityKeyConstants._OrganizationEntityKeys._PurchasingGroupAttributeKeys.@CreatedBy, "createdby") ?? "createdby"},
{"updatedon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@PurchasingGroup, _EntityKeyConstants._OrganizationEntityKeys._PurchasingGroupAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon"},
{"updatedby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@PurchasingGroup, _EntityKeyConstants._OrganizationEntityKeys._PurchasingGroupAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@PurchasingGroup, "purch_ok7ot05vqrom9et5kg5qcs95"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENPurchasingGroupEntity

}

