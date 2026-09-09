using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {

public sealed partial class ENIVAExceptionM9SuppliersEntity {
private static readonly ActivitySource activitySource = new(typeof(ENIVAExceptionM9SuppliersEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@IVAExceptionM9Suppliers, _EntityKeyConstants._OrganizationEntityKeys._IVAExceptionM9SuppliersAttributeKeys.@Id, "id") ?? "id"},
{"suppliernumber", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@IVAExceptionM9Suppliers, _EntityKeyConstants._OrganizationEntityKeys._IVAExceptionM9SuppliersAttributeKeys.@SupplierNumber, "suppliernumber") ?? "suppliernumber"},
{"createdon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@IVAExceptionM9Suppliers, _EntityKeyConstants._OrganizationEntityKeys._IVAExceptionM9SuppliersAttributeKeys.@CreatedOn, "createdon") ?? "createdon"},
{"createdby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@IVAExceptionM9Suppliers, _EntityKeyConstants._OrganizationEntityKeys._IVAExceptionM9SuppliersAttributeKeys.@CreatedBy, "createdby") ?? "createdby"},
{"updatedon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@IVAExceptionM9Suppliers, _EntityKeyConstants._OrganizationEntityKeys._IVAExceptionM9SuppliersAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon"},
{"updatedby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@IVAExceptionM9Suppliers, _EntityKeyConstants._OrganizationEntityKeys._IVAExceptionM9SuppliersAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@IVAExceptionM9Suppliers, "ivaex_ok7ot05vqrom4wox8wwlezx1"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENIVAExceptionM9SuppliersEntity

}

