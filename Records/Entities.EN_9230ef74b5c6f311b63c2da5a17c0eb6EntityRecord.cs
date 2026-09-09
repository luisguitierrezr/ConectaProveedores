using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENApplicantEntity {
private static readonly ActivitySource activitySource = new(typeof(ENApplicantEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Applicant, _EntityKeyConstants._OrganizationEntityKeys._ApplicantAttributeKeys.@Id, "id") ?? "id"},
{"applicant", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Applicant, _EntityKeyConstants._OrganizationEntityKeys._ApplicantAttributeKeys.@Applicant, "applicant") ?? "applicant"},
{"description", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Applicant, _EntityKeyConstants._OrganizationEntityKeys._ApplicantAttributeKeys.@Description, "description") ?? "description"},
{"approvalprocesstypeid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Applicant, _EntityKeyConstants._OrganizationEntityKeys._ApplicantAttributeKeys.@ApprovalProcessTypeId, "approvalprocesstypeid") ?? "approvalprocesstypeid"},
{"createdby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Applicant, _EntityKeyConstants._OrganizationEntityKeys._ApplicantAttributeKeys.@CreatedBy, "createdby") ?? "createdby"},
{"createdon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Applicant, _EntityKeyConstants._OrganizationEntityKeys._ApplicantAttributeKeys.@CreatedOn, "createdon") ?? "createdon"},
{"updatedon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Applicant, _EntityKeyConstants._OrganizationEntityKeys._ApplicantAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon"},
{"updatedby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Applicant, _EntityKeyConstants._OrganizationEntityKeys._ApplicantAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Applicant, "appli_ok7ot05vqromep4kmlwcc2a2"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENApplicantEntity

}

