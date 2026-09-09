using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENCustomSettingValueEntity {
private static readonly ActivitySource activitySource = new(typeof(ENCustomSettingValueEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@CustomSettingValue, _EntityKeyConstants._OrganizationEntityKeys._CustomSettingValueAttributeKeys.@Id, "id") ?? "id"},
{"customsettingid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@CustomSettingValue, _EntityKeyConstants._OrganizationEntityKeys._CustomSettingValueAttributeKeys.@CustomSettingId, "customsettingid") ?? "customsettingid"},
{"value", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@CustomSettingValue, _EntityKeyConstants._OrganizationEntityKeys._CustomSettingValueAttributeKeys.@Value, "value") ?? "value"},
{"updatedon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@CustomSettingValue, _EntityKeyConstants._OrganizationEntityKeys._CustomSettingValueAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon"},
{"updatedby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@CustomSettingValue, _EntityKeyConstants._OrganizationEntityKeys._CustomSettingValueAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@CustomSettingValue, "custo_ok7ot05vqrovql84b0bputv2"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENCustomSettingValueEntity

}

