using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {

public sealed partial class ENPaymentTermsEntity {
private static readonly ActivitySource activitySource = new(typeof(ENPaymentTermsEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@PaymentTerms, _EntityKeyConstants._OrganizationEntityKeys._PaymentTermsAttributeKeys.@Id, "id") ?? "id"},
{"description", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@PaymentTerms, _EntityKeyConstants._OrganizationEntityKeys._PaymentTermsAttributeKeys.@Description, "description") ?? "description"},
{"clcta", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@PaymentTerms, _EntityKeyConstants._OrganizationEntityKeys._PaymentTermsAttributeKeys.@ClCta, "clcta") ?? "clcta"},
{"classfecha", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@PaymentTerms, _EntityKeyConstants._OrganizationEntityKeys._PaymentTermsAttributeKeys.@ClassFecha, "classfecha") ?? "classfecha"},
{"ctd_dias", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@PaymentTerms, _EntityKeyConstants._OrganizationEntityKeys._PaymentTermsAttributeKeys.@Ctd_dias, "ctd_dias") ?? "ctd_dias"},
{"estructuradescripcionprop", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@PaymentTerms, _EntityKeyConstants._OrganizationEntityKeys._PaymentTermsAttributeKeys.@EstructuraDescripcionPROP, "estructuradescripcionprop") ?? "estructuradescripcionprop"},
{"isspecial", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@PaymentTerms, _EntityKeyConstants._OrganizationEntityKeys._PaymentTermsAttributeKeys.@IsSpecial, "isspecial") ?? "isspecial"},
{"createdon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@PaymentTerms, _EntityKeyConstants._OrganizationEntityKeys._PaymentTermsAttributeKeys.@CreatedOn, "createdon") ?? "createdon"},
{"createdby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@PaymentTerms, _EntityKeyConstants._OrganizationEntityKeys._PaymentTermsAttributeKeys.@CreatedBy, "createdby") ?? "createdby"},
{"updatedon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@PaymentTerms, _EntityKeyConstants._OrganizationEntityKeys._PaymentTermsAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon"},
{"updatedby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@PaymentTerms, _EntityKeyConstants._OrganizationEntityKeys._PaymentTermsAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@PaymentTerms, "payme_ok7ot05vqroy8ekgimbvgzw4"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENPaymentTermsEntity

}

