using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENOrderDistributionConfigEntity {
private static readonly ActivitySource activitySource = new(typeof(ENOrderDistributionConfigEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@Id, "id") ?? "id"},
{"regionid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@RegionId, "regionid") ?? "regionid"},
{"applicant", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@Applicant, "applicant") ?? "applicant"},
{"applicantdescription", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@ApplicantDescription, "applicantdescription") ?? "applicantdescription"},
{"directionid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@DirectionId, "directionid") ?? "directionid"},
{"firstcontact_entraroleid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@FirstContact_EntraRoleId, "firstcontact_entraroleid") ?? "firstcontact_entraroleid"},
{"secondcontact_entraroleid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@SecondContact_EntraRoleId, "secondcontact_entraroleid") ?? "secondcontact_entraroleid"},
{"firstapprover_entraroleid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@FirstApprover_EntraRoleId, "firstapprover_entraroleid") ?? "firstapprover_entraroleid"},
{"secondapprover_entraroleid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@SecondApprover_EntraRoleId, "secondapprover_entraroleid") ?? "secondapprover_entraroleid"},
{"createdby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@CreatedBy, "createdby") ?? "createdby"},
{"createdon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@CreatedOn, "createdon") ?? "createdon"},
{"updatedby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby"},
{"updatedon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, "order_u8aqr95gpfe0tk5_n9me69p6"));
}
} // ENOrderDistributionConfigEntity

}

