using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {

public sealed partial class ENServiceFormatEntity {
private static readonly ActivitySource activitySource = new(typeof(ENServiceFormatEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@ServiceFormat, _EntityKeyConstants._OrganizationEntityKeys._ServiceFormatAttributeKeys.@Id, "id") ?? "id"},
{"description", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@ServiceFormat, _EntityKeyConstants._OrganizationEntityKeys._ServiceFormatAttributeKeys.@Description, "description") ?? "description"},
{"createdon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@ServiceFormat, _EntityKeyConstants._OrganizationEntityKeys._ServiceFormatAttributeKeys.@CreatedOn, "createdon") ?? "createdon"},
{"createdby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@ServiceFormat, _EntityKeyConstants._OrganizationEntityKeys._ServiceFormatAttributeKeys.@CreatedBy, "createdby") ?? "createdby"},
{"updatedon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@ServiceFormat, _EntityKeyConstants._OrganizationEntityKeys._ServiceFormatAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon"},
{"updatedby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@ServiceFormat, _EntityKeyConstants._OrganizationEntityKeys._ServiceFormatAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@ServiceFormat, "servi_ok7ot05vqrovxh9ytayefl24"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENServiceFormatEntity

}

