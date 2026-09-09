using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENSubdirectionEntity {
private static readonly ActivitySource activitySource = new(typeof(ENSubdirectionEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Subdirection, _EntityKeyConstants._OrganizationEntityKeys._SubdirectionAttributeKeys.@Id, "id") ?? "id"},
{"name", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Subdirection, _EntityKeyConstants._OrganizationEntityKeys._SubdirectionAttributeKeys.@Name, "name") ?? "name"},
{"isactive", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Subdirection, _EntityKeyConstants._OrganizationEntityKeys._SubdirectionAttributeKeys.@IsActive, "isactive") ?? "isactive"},
{"createdon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Subdirection, _EntityKeyConstants._OrganizationEntityKeys._SubdirectionAttributeKeys.@CreatedOn, "createdon") ?? "createdon"},
{"createdby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Subdirection, _EntityKeyConstants._OrganizationEntityKeys._SubdirectionAttributeKeys.@CreatedBy, "createdby") ?? "createdby"},
{"updatedon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Subdirection, _EntityKeyConstants._OrganizationEntityKeys._SubdirectionAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon"},
{"updatedby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Subdirection, _EntityKeyConstants._OrganizationEntityKeys._SubdirectionAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Subdirection, "subdi_ok7ot05vqrouuprvhsxi5qr4"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENSubdirectionEntity

}

