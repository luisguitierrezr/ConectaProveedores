using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {

public sealed partial class ENManualsEntity {
private static readonly ActivitySource activitySource = new(typeof(ENManualsEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Manuals, _EntityKeyConstants._OrganizationEntityKeys._ManualsAttributeKeys.@Id, "id") ?? "id"},
{"title", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Manuals, _EntityKeyConstants._OrganizationEntityKeys._ManualsAttributeKeys.@Title, "title") ?? "title"},
{"appconceptid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Manuals, _EntityKeyConstants._OrganizationEntityKeys._ManualsAttributeKeys.@AppConceptId, "appconceptid") ?? "appconceptid"},
{"conceptid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Manuals, _EntityKeyConstants._OrganizationEntityKeys._ManualsAttributeKeys.@ConceptId, "conceptid") ?? "conceptid"},
{"shortdescription", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Manuals, _EntityKeyConstants._OrganizationEntityKeys._ManualsAttributeKeys.@ShortDescription, "shortdescription") ?? "shortdescription"},
{"description", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Manuals, _EntityKeyConstants._OrganizationEntityKeys._ManualsAttributeKeys.@Description, "description") ?? "description"},
{"star", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Manuals, _EntityKeyConstants._OrganizationEntityKeys._ManualsAttributeKeys.@Star, "star") ?? "star"},
{"forproveedor", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Manuals, _EntityKeyConstants._OrganizationEntityKeys._ManualsAttributeKeys.@ForProveedor, "forproveedor") ?? "forproveedor"},
{"isvideo", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Manuals, _EntityKeyConstants._OrganizationEntityKeys._ManualsAttributeKeys.@IsVideo, "isvideo") ?? "isvideo"},
{"isactive", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Manuals, _EntityKeyConstants._OrganizationEntityKeys._ManualsAttributeKeys.@IsActive, "isactive") ?? "isactive"},
{"createdon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Manuals, _EntityKeyConstants._OrganizationEntityKeys._ManualsAttributeKeys.@CreatedOn, "createdon") ?? "createdon"},
{"createdby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Manuals, _EntityKeyConstants._OrganizationEntityKeys._ManualsAttributeKeys.@CreatedBy, "createdby") ?? "createdby"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Manuals, "manua_ok7ot05vqrokvkybece8dud3"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENManualsEntity

}

