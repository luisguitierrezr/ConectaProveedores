using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {

public sealed partial class ENApprovalProcessLevelEntity {
private static readonly ActivitySource activitySource = new(typeof(ENApprovalProcessLevelEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@ApprovalProcessLevel, _EntityKeyConstants._WorkflowEngineEntityKeys._ApprovalProcessLevelAttributeKeys.@Id, "id") ?? "id"},
{"approvalprocessid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@ApprovalProcessLevel, _EntityKeyConstants._WorkflowEngineEntityKeys._ApprovalProcessLevelAttributeKeys.@ApprovalProcessId, "approvalprocessid") ?? "approvalprocessid"},
{"levelnumber", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@ApprovalProcessLevel, _EntityKeyConstants._WorkflowEngineEntityKeys._ApprovalProcessLevelAttributeKeys.@LevelNumber, "levelnumber") ?? "levelnumber"},
{"applicationroleid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@ApprovalProcessLevel, _EntityKeyConstants._WorkflowEngineEntityKeys._ApprovalProcessLevelAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid"},
{"isapplicant", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@ApprovalProcessLevel, _EntityKeyConstants._WorkflowEngineEntityKeys._ApprovalProcessLevelAttributeKeys.@IsApplicant, "isapplicant") ?? "isapplicant"},
{"isfirstapprover", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@ApprovalProcessLevel, _EntityKeyConstants._WorkflowEngineEntityKeys._ApprovalProcessLevelAttributeKeys.@IsFirstApprover, "isfirstapprover") ?? "isfirstapprover"},
{"jobtitle", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@ApprovalProcessLevel, _EntityKeyConstants._WorkflowEngineEntityKeys._ApprovalProcessLevelAttributeKeys.@JobTitle, "jobtitle") ?? "jobtitle"},
{"entraroleid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@ApprovalProcessLevel, _EntityKeyConstants._WorkflowEngineEntityKeys._ApprovalProcessLevelAttributeKeys.@EntraRoleId, "entraroleid") ?? "entraroleid"},
{"departmentid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@ApprovalProcessLevel, _EntityKeyConstants._WorkflowEngineEntityKeys._ApprovalProcessLevelAttributeKeys.@DepartmentId, "departmentid") ?? "departmentid"},
{"managementid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@ApprovalProcessLevel, _EntityKeyConstants._WorkflowEngineEntityKeys._ApprovalProcessLevelAttributeKeys.@ManagementId, "managementid") ?? "managementid"},
{"subdirectionid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@ApprovalProcessLevel, _EntityKeyConstants._WorkflowEngineEntityKeys._ApprovalProcessLevelAttributeKeys.@SubdirectionId, "subdirectionid") ?? "subdirectionid"},
{"minamount", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@ApprovalProcessLevel, _EntityKeyConstants._WorkflowEngineEntityKeys._ApprovalProcessLevelAttributeKeys.@MinAmount, "minamount") ?? "minamount"},
{"maxamount", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@ApprovalProcessLevel, _EntityKeyConstants._WorkflowEngineEntityKeys._ApprovalProcessLevelAttributeKeys.@MaxAmount, "maxamount") ?? "maxamount"},
{"isactive", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@ApprovalProcessLevel, _EntityKeyConstants._WorkflowEngineEntityKeys._ApprovalProcessLevelAttributeKeys.@IsActive, "isactive") ?? "isactive"},
{"excluderegion_deprec", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@ApprovalProcessLevel, _EntityKeyConstants._WorkflowEngineEntityKeys._ApprovalProcessLevelAttributeKeys.@ExcludeRegion_DEPREC, "excluderegion_deprec") ?? "excluderegion_deprec"},
{"onlyregion", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@ApprovalProcessLevel, _EntityKeyConstants._WorkflowEngineEntityKeys._ApprovalProcessLevelAttributeKeys.@OnlyRegion, "onlyregion") ?? "onlyregion"},
{"withoutcontract", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@ApprovalProcessLevel, _EntityKeyConstants._WorkflowEngineEntityKeys._ApprovalProcessLevelAttributeKeys.@WithoutContract, "withoutcontract") ?? "withoutcontract"},
{"needsproofofforeignresidence", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@ApprovalProcessLevel, _EntityKeyConstants._WorkflowEngineEntityKeys._ApprovalProcessLevelAttributeKeys.@NeedsProofOfForeignResidence, "needsproofofforeignresidence") ?? "needsproofofforeignresidence"},
{"needscontract", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@ApprovalProcessLevel, _EntityKeyConstants._WorkflowEngineEntityKeys._ApprovalProcessLevelAttributeKeys.@NeedsContract, "needscontract") ?? "needscontract"},
{"isaccounting_deprec", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@ApprovalProcessLevel, _EntityKeyConstants._WorkflowEngineEntityKeys._ApprovalProcessLevelAttributeKeys.@IsAccounting_DEPREC, "isaccounting_deprec") ?? "isaccounting_deprec"},
{"isstartaccounting", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@ApprovalProcessLevel, _EntityKeyConstants._WorkflowEngineEntityKeys._ApprovalProcessLevelAttributeKeys.@IsStartAccounting, "isstartaccounting") ?? "isstartaccounting"},
{"canbefirstapprover", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@ApprovalProcessLevel, _EntityKeyConstants._WorkflowEngineEntityKeys._ApprovalProcessLevelAttributeKeys.@CanBeFirstApprover, "canbefirstapprover") ?? "canbefirstapprover"},
{"selectsnextapprover", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@ApprovalProcessLevel, _EntityKeyConstants._WorkflowEngineEntityKeys._ApprovalProcessLevelAttributeKeys.@SelectsNextApprover, "selectsnextapprover") ?? "selectsnextapprover"},
{"selectsfirstapprover", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@ApprovalProcessLevel, _EntityKeyConstants._WorkflowEngineEntityKeys._ApprovalProcessLevelAttributeKeys.@SelectsFirstApprover, "selectsfirstapprover") ?? "selectsfirstapprover"},
{"isexclude", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@ApprovalProcessLevel, _EntityKeyConstants._WorkflowEngineEntityKeys._ApprovalProcessLevelAttributeKeys.@IsExclude, "isexclude") ?? "isexclude"},
{"ismandatory", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@ApprovalProcessLevel, _EntityKeyConstants._WorkflowEngineEntityKeys._ApprovalProcessLevelAttributeKeys.@IsMandatory, "ismandatory") ?? "ismandatory"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@ApprovalProcessLevel, "appro_62995wmjvxo_p3hxvv3nqin4"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("1760d0f4-0a67-4950-83db-6692da4d3a3e");
} // ENApprovalProcessLevelEntity

}

