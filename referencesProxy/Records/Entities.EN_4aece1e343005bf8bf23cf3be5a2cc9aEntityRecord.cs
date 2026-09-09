using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {

public sealed partial class ENPaymentMethodsEntity {
private static readonly ActivitySource activitySource = new(typeof(ENPaymentMethodsEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@PaymentMethods, _EntityKeyConstants._OrganizationEntityKeys._PaymentMethodsAttributeKeys.@Id, "id") ?? "id"},
{"description", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@PaymentMethods, _EntityKeyConstants._OrganizationEntityKeys._PaymentMethodsAttributeKeys.@Description, "description") ?? "description"},
{"externalid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@PaymentMethods, _EntityKeyConstants._OrganizationEntityKeys._PaymentMethodsAttributeKeys.@ExternalId, "externalid") ?? "externalid"},
{"isfcp", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@PaymentMethods, _EntityKeyConstants._OrganizationEntityKeys._PaymentMethodsAttributeKeys.@IsFCP, "isfcp") ?? "isfcp"},
{"createdon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@PaymentMethods, _EntityKeyConstants._OrganizationEntityKeys._PaymentMethodsAttributeKeys.@CreatedOn, "createdon") ?? "createdon"},
{"createdby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@PaymentMethods, _EntityKeyConstants._OrganizationEntityKeys._PaymentMethodsAttributeKeys.@CreatedBy, "createdby") ?? "createdby"},
{"updatedon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@PaymentMethods, _EntityKeyConstants._OrganizationEntityKeys._PaymentMethodsAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon"},
{"updatedby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@PaymentMethods, _EntityKeyConstants._OrganizationEntityKeys._PaymentMethodsAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby"},
{"isactive", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@PaymentMethods, _EntityKeyConstants._OrganizationEntityKeys._PaymentMethodsAttributeKeys.@IsActive, "isactive") ?? "isactive"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@PaymentMethods, "payme_ok7ot05vqrothiz6ffuaevt3"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENPaymentMethodsEntity

}

