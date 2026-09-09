using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {

public sealed partial class ENPaymentOptionsEntity {
private static readonly ActivitySource activitySource = new(typeof(ENPaymentOptionsEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@PaymentOptions, _EntityKeyConstants._OrganizationEntityKeys._PaymentOptionsAttributeKeys.@Id, "id") ?? "id"},
{"code", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@PaymentOptions, _EntityKeyConstants._OrganizationEntityKeys._PaymentOptionsAttributeKeys.@Code, "code") ?? "code"},
{"description", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@PaymentOptions, _EntityKeyConstants._OrganizationEntityKeys._PaymentOptionsAttributeKeys.@Description, "description") ?? "description"},
{"isactive", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@PaymentOptions, _EntityKeyConstants._OrganizationEntityKeys._PaymentOptionsAttributeKeys.@IsActive, "isactive") ?? "isactive"},
{"createdon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@PaymentOptions, _EntityKeyConstants._OrganizationEntityKeys._PaymentOptionsAttributeKeys.@CreatedOn, "createdon") ?? "createdon"},
{"createdby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@PaymentOptions, _EntityKeyConstants._OrganizationEntityKeys._PaymentOptionsAttributeKeys.@CreatedBy, "createdby") ?? "createdby"},
{"updatedon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@PaymentOptions, _EntityKeyConstants._OrganizationEntityKeys._PaymentOptionsAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon"},
{"updatedby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@PaymentOptions, _EntityKeyConstants._OrganizationEntityKeys._PaymentOptionsAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@PaymentOptions, "payme_ok7ot05vqroy32rocyelm4l5"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENPaymentOptionsEntity

}

