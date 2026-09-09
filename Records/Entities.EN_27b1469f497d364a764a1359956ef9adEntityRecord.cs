using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENRequisitionApprovalLevelEntity {
private static readonly ActivitySource activitySource = new(typeof(ENRequisitionApprovalLevelEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@Id, "id") ?? "id"},
{"requisitionapprovalid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@RequisitionApprovalId, "requisitionapprovalid") ?? "requisitionapprovalid"},
{"levelnumber", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@LevelNumber, "levelnumber") ?? "levelnumber"},
{"applicationroleid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid"},
{"entrajobtitle", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@EntraJobTitle, "entrajobtitle") ?? "entrajobtitle"},
{"departmentid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@DepartmentId, "departmentid") ?? "departmentid"},
{"managementid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@ManagementId, "managementid") ?? "managementid"},
{"subdirectionid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@SubdirectionId, "subdirectionid") ?? "subdirectionid"},
{"entraroleid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@EntraRoleId, "entraroleid") ?? "entraroleid"},
{"entrausername", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@EntraUserName, "entrausername") ?? "entrausername"},
{"assignedto", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@AssignedTo, "assignedto") ?? "assignedto"},
{"needscontract", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@NeedsContract, "needscontract") ?? "needscontract"},
{"approvalstatusid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@ApprovalStatusId, "approvalstatusid") ?? "approvalstatusid"},
{"approvedby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@ApprovedBy, "approvedby") ?? "approvedby"},
{"approvedon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@ApprovedOn, "approvedon") ?? "approvedon"},
{"requesttomodifyby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@RequestToModifyBy, "requesttomodifyby") ?? "requesttomodifyby"},
{"requesttomodifyon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@RequestToModifyOn, "requesttomodifyon") ?? "requesttomodifyon"},
{"canceledby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@CanceledBy, "canceledby") ?? "canceledby"},
{"canceledon_deprec", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@CanceledOn_DEPREC, "canceledon_deprec") ?? "canceledon_deprec"},
{"isaccounting", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@IsAccounting, "isaccounting") ?? "isaccounting"},
{"isstartaccounting", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@IsStartAccounting, "isstartaccounting") ?? "isstartaccounting"},
{"canceledon_", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@CanceledOn_, "canceledon_") ?? "canceledon_"},
{"approveasareausuaria", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@ApproveAsAreaUsuaria, "approveasareausuaria") ?? "approveasareausuaria"},
{"ismandatory", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@IsMandatory, "ismandatory") ?? "ismandatory"},
{"isreassigned", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@IsReassigned, "isreassigned") ?? "isreassigned"},
{"issubstitutefor", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@IsSubstituteFor, "issubstitutefor") ?? "issubstitutefor"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, "requi_u8aqr95gpfez9icaqnqwvqd4"));
}
} // ENRequisitionApprovalLevelEntity

}

