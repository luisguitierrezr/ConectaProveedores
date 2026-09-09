using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENSupplierUserEntity {
private static readonly ActivitySource activitySource = new(typeof(ENSupplierUserEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@SupplierUser, _EntityKeyConstants._OrganizationEntityKeys._SupplierUserAttributeKeys.@Id, "id") ?? "id"},
{"supplierid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@SupplierUser, _EntityKeyConstants._OrganizationEntityKeys._SupplierUserAttributeKeys.@SupplierId, "supplierid") ?? "supplierid"},
{"userid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@SupplierUser, _EntityKeyConstants._OrganizationEntityKeys._SupplierUserAttributeKeys.@UserId, "userid") ?? "userid"},
{"name", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@SupplierUser, _EntityKeyConstants._OrganizationEntityKeys._SupplierUserAttributeKeys.@Name, "name") ?? "name"},
{"email", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@SupplierUser, _EntityKeyConstants._OrganizationEntityKeys._SupplierUserAttributeKeys.@Email, "email") ?? "email"},
{"activationemailsentdate", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@SupplierUser, _EntityKeyConstants._OrganizationEntityKeys._SupplierUserAttributeKeys.@ActivationEmailSentDate, "activationemailsentdate") ?? "activationemailsentdate"},
{"isactive", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@SupplierUser, _EntityKeyConstants._OrganizationEntityKeys._SupplierUserAttributeKeys.@IsActive, "isactive") ?? "isactive"},
{"isdeleted", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@SupplierUser, _EntityKeyConstants._OrganizationEntityKeys._SupplierUserAttributeKeys.@IsDeleted, "isdeleted") ?? "isdeleted"},
{"isblocked", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@SupplierUser, _EntityKeyConstants._OrganizationEntityKeys._SupplierUserAttributeKeys.@IsBlocked, "isblocked") ?? "isblocked"},
{"blockeduntil", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@SupplierUser, _EntityKeyConstants._OrganizationEntityKeys._SupplierUserAttributeKeys.@BlockedUntil, "blockeduntil") ?? "blockeduntil"},
{"lastlogindate", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@SupplierUser, _EntityKeyConstants._OrganizationEntityKeys._SupplierUserAttributeKeys.@LastLoginDate, "lastlogindate") ?? "lastlogindate"},
{"createdby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@SupplierUser, _EntityKeyConstants._OrganizationEntityKeys._SupplierUserAttributeKeys.@CreatedBy, "createdby") ?? "createdby"},
{"createdon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@SupplierUser, _EntityKeyConstants._OrganizationEntityKeys._SupplierUserAttributeKeys.@CreatedOn, "createdon") ?? "createdon"},
{"updatedby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@SupplierUser, _EntityKeyConstants._OrganizationEntityKeys._SupplierUserAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby"},
{"updatedon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@SupplierUser, _EntityKeyConstants._OrganizationEntityKeys._SupplierUserAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@SupplierUser, "suppl_ok7ot05vqropo2c8wsb8pk14"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENSupplierUserEntity

}

