using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateRequisitionApprovalLevel
/// </summary>

public static async Task<long> CreateRequisitionApprovalLevel(IRequestContext requestContext,RC_5404698ef74632f0bc59763509d95177 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateRequisitionApprovalLevel", "875ae9ed-3877-4b95-9236-49ac94000633.#CreateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateRequisitionApprovalLevel", "875ae9ed-3877-4b95-9236-49ac94000633.#CreateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_27b1469f497d364a764a1359956ef9adEntityRecord ssENRequisitionApprovalLevel = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENRequisitionApprovalLevelEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@RequisitionApprovalId, "requisitionapprovalid") ?? "requisitionapprovalid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@LevelNumber, "levelnumber") ?? "levelnumber") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@EntraJobTitle, "entrajobtitle") ?? "entrajobtitle") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@DepartmentId, "departmentid") ?? "departmentid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@ManagementId, "managementid") ?? "managementid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@SubdirectionId, "subdirectionid") ?? "subdirectionid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@EntraRoleId, "entraroleid") ?? "entraroleid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@EntraUserName, "entrausername") ?? "entrausername") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@AssignedTo, "assignedto") ?? "assignedto") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@NeedsContract, "needscontract") ?? "needscontract") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@ApprovalStatusId, "approvalstatusid") ?? "approvalstatusid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@ApprovedBy, "approvedby") ?? "approvedby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@ApprovedOn, "approvedon") ?? "approvedon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@RequestToModifyBy, "requesttomodifyby") ?? "requesttomodifyby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@RequestToModifyOn, "requesttomodifyon") ?? "requesttomodifyon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@CanceledBy, "canceledby") ?? "canceledby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@CanceledOn_DEPREC, "canceledon_deprec") ?? "canceledon_deprec") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@IsAccounting, "isaccounting") ?? "isaccounting") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@IsStartAccounting, "isstartaccounting") ?? "isstartaccounting") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@CanceledOn_, "canceledon_") ?? "canceledon_") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@ApproveAsAreaUsuaria, "approveasareausuaria") ?? "approveasareausuaria") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@IsMandatory, "ismandatory") ?? "ismandatory") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@IsReassigned, "isreassigned") ?? "isreassigned") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@IsSubstituteFor, "issubstitutefor") ?? "issubstitutefor") + "" +
" ) VALUES (" +
" @ssRequisitionApprovalId" +
", @ssLevelNumber" +
", @ssApplicationRoleId" +
", @ssEntraJobTitle" +
", @ssDepartmentId" +
", @ssManagementId" +
", @ssSubdirectionId" +
", @ssEntraRoleId" +
", @ssEntraUserName" +
", @ssAssignedTo" +
", @ssNeedsContract" +
", @ssApprovalStatusId" +
", @ssApprovedBy" +
", @ssApprovedOn" +
", @ssRequestToModifyBy" +
", @ssRequestToModifyOn" +
", @ssCanceledBy" +
", @ssCanceledOn_DEPREC" +
", @ssIsAccounting" +
", @ssIsStartAccounting" +
", @ssCanceledOn_" +
", @ssApproveAsAreaUsuaria" +
", @ssIsMandatory" +
", @ssIsReassigned" +
", @ssIsSubstituteFor" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENRequisitionApprovalLevel.ssRequisitionApprovalId==0L)) {
insertSqlCmd.CreateParameter("@ssRequisitionApprovalId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssRequisitionApprovalId", DbType.Int64, ssENRequisitionApprovalLevel.ssRequisitionApprovalId);

}
insertSqlCmd.CreateParameter("@ssLevelNumber", DbType.Int32, ssENRequisitionApprovalLevel.ssLevelNumber);
if ((ssENRequisitionApprovalLevel.ssApplicationRoleId==0L)) {
insertSqlCmd.CreateParameter("@ssApplicationRoleId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssApplicationRoleId", DbType.Int64, ssENRequisitionApprovalLevel.ssApplicationRoleId);

}
insertSqlCmd.CreateParameter("@ssEntraJobTitle", DbType.String, ssENRequisitionApprovalLevel.ssEntraJobTitle);
if ((ssENRequisitionApprovalLevel.ssDepartmentId==0L)) {
insertSqlCmd.CreateParameter("@ssDepartmentId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssDepartmentId", DbType.Int64, ssENRequisitionApprovalLevel.ssDepartmentId);

}
if ((ssENRequisitionApprovalLevel.ssManagementId==0L)) {
insertSqlCmd.CreateParameter("@ssManagementId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssManagementId", DbType.Int64, ssENRequisitionApprovalLevel.ssManagementId);

}
if ((ssENRequisitionApprovalLevel.ssSubdirectionId==0L)) {
insertSqlCmd.CreateParameter("@ssSubdirectionId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssSubdirectionId", DbType.Int64, ssENRequisitionApprovalLevel.ssSubdirectionId);

}
if ((ssENRequisitionApprovalLevel.ssEntraRoleId==0L)) {
insertSqlCmd.CreateParameter("@ssEntraRoleId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssEntraRoleId", DbType.Int64, ssENRequisitionApprovalLevel.ssEntraRoleId);

}
insertSqlCmd.CreateParameter("@ssEntraUserName", DbType.String, ssENRequisitionApprovalLevel.ssEntraUserName);
if ((ssENRequisitionApprovalLevel.ssAssignedTo=="")) {
insertSqlCmd.CreateParameter("@ssAssignedTo", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssAssignedTo", DbType.String, ssENRequisitionApprovalLevel.ssAssignedTo);

}
insertSqlCmd.CreateParameter("@ssNeedsContract", DbType.Boolean, ssENRequisitionApprovalLevel.ssNeedsContract);
if ((ssENRequisitionApprovalLevel.ssApprovalStatusId==0)) {
insertSqlCmd.CreateParameter("@ssApprovalStatusId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssApprovalStatusId", DbType.Int32, ssENRequisitionApprovalLevel.ssApprovalStatusId);

}
if ((ssENRequisitionApprovalLevel.ssApprovedBy=="")) {
insertSqlCmd.CreateParameter("@ssApprovedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssApprovedBy", DbType.String, ssENRequisitionApprovalLevel.ssApprovedBy);

}
insertSqlCmd.CreateParameter("@ssApprovedOn", DbType.DateTime, ssENRequisitionApprovalLevel.ssApprovedOn);
if ((ssENRequisitionApprovalLevel.ssRequestToModifyBy=="")) {
insertSqlCmd.CreateParameter("@ssRequestToModifyBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssRequestToModifyBy", DbType.String, ssENRequisitionApprovalLevel.ssRequestToModifyBy);

}
insertSqlCmd.CreateParameter("@ssRequestToModifyOn", DbType.DateTime, ssENRequisitionApprovalLevel.ssRequestToModifyOn);
if ((ssENRequisitionApprovalLevel.ssCanceledBy=="")) {
insertSqlCmd.CreateParameter("@ssCanceledBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCanceledBy", DbType.String, ssENRequisitionApprovalLevel.ssCanceledBy);

}
insertSqlCmd.CreateParameter("@ssCanceledOn_DEPREC", DbType.Boolean, ssENRequisitionApprovalLevel.ssCanceledOn_DEPREC);
insertSqlCmd.CreateParameter("@ssIsAccounting", DbType.Boolean, ssENRequisitionApprovalLevel.ssIsAccounting);
insertSqlCmd.CreateParameter("@ssIsStartAccounting", DbType.Boolean, ssENRequisitionApprovalLevel.ssIsStartAccounting);
insertSqlCmd.CreateParameter("@ssCanceledOn_", DbType.DateTime, ssENRequisitionApprovalLevel.ssCanceledOn_);
insertSqlCmd.CreateParameter("@ssApproveAsAreaUsuaria", DbType.Boolean, ssENRequisitionApprovalLevel.ssApproveAsAreaUsuaria);
insertSqlCmd.CreateParameter("@ssIsMandatory", DbType.Boolean, ssENRequisitionApprovalLevel.ssIsMandatory);
insertSqlCmd.CreateParameter("@ssIsReassigned", DbType.Boolean, ssENRequisitionApprovalLevel.ssIsReassigned);
if ((ssENRequisitionApprovalLevel.ssIsSubstituteFor=="")) {
insertSqlCmd.CreateParameter("@ssIsSubstituteFor", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssIsSubstituteFor", DbType.String, ssENRequisitionApprovalLevel.ssIsSubstituteFor);

}
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateRequisitionApprovalLevel", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateRequisitionApprovalLevel
/// </summary>

public static async Task<long> CreateOrUpdateRequisitionApprovalLevel(IRequestContext requestContext,BitArray usedFields,RC_5404698ef74632f0bc59763509d95177 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateRequisitionApprovalLevel", "875ae9ed-3877-4b95-9236-49ac94000633.#CreateOrUpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateRequisitionApprovalLevel", "875ae9ed-3877-4b95-9236-49ac94000633.#CreateOrUpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_27b1469f497d364a764a1359956ef9adEntityRecord ssENRequisitionApprovalLevel = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(26,true);
}
string updateSet = "UPDATE " + ENRequisitionApprovalLevelEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@RequisitionApprovalId, "requisitionapprovalid") ?? "requisitionapprovalid") + " = @ssRequisitionApprovalId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@LevelNumber, "levelnumber") ?? "levelnumber") + " = @ssLevelNumber"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid") + " = @ssApplicationRoleId"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@EntraJobTitle, "entrajobtitle") ?? "entrajobtitle") + " = @ssEntraJobTitle"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@DepartmentId, "departmentid") ?? "departmentid") + " = @ssDepartmentId"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@ManagementId, "managementid") ?? "managementid") + " = @ssManagementId"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@SubdirectionId, "subdirectionid") ?? "subdirectionid") + " = @ssSubdirectionId"): parameters);
parameters = (usedFields[8] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@EntraRoleId, "entraroleid") ?? "entraroleid") + " = @ssEntraRoleId"): parameters);
parameters = (usedFields[9] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@EntraUserName, "entrausername") ?? "entrausername") + " = @ssEntraUserName"): parameters);
parameters = (usedFields[10] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@AssignedTo, "assignedto") ?? "assignedto") + " = @ssAssignedTo"): parameters);
parameters = (usedFields[11] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@NeedsContract, "needscontract") ?? "needscontract") + " = @ssNeedsContract"): parameters);
parameters = (usedFields[12] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@ApprovalStatusId, "approvalstatusid") ?? "approvalstatusid") + " = @ssApprovalStatusId"): parameters);
parameters = (usedFields[13] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@ApprovedBy, "approvedby") ?? "approvedby") + " = @ssApprovedBy"): parameters);
parameters = (usedFields[14] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@ApprovedOn, "approvedon") ?? "approvedon") + " = @ssApprovedOn"): parameters);
parameters = (usedFields[15] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@RequestToModifyBy, "requesttomodifyby") ?? "requesttomodifyby") + " = @ssRequestToModifyBy"): parameters);
parameters = (usedFields[16] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@RequestToModifyOn, "requesttomodifyon") ?? "requesttomodifyon") + " = @ssRequestToModifyOn"): parameters);
parameters = (usedFields[17] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@CanceledBy, "canceledby") ?? "canceledby") + " = @ssCanceledBy"): parameters);
parameters = (usedFields[18] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@CanceledOn_DEPREC, "canceledon_deprec") ?? "canceledon_deprec") + " = @ssCanceledOn_DEPREC"): parameters);
parameters = (usedFields[19] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@IsAccounting, "isaccounting") ?? "isaccounting") + " = @ssIsAccounting"): parameters);
parameters = (usedFields[20] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@IsStartAccounting, "isstartaccounting") ?? "isstartaccounting") + " = @ssIsStartAccounting"): parameters);
parameters = (usedFields[21] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@CanceledOn_, "canceledon_") ?? "canceledon_") + " = @ssCanceledOn_"): parameters);
parameters = (usedFields[22] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@ApproveAsAreaUsuaria, "approveasareausuaria") ?? "approveasareausuaria") + " = @ssApproveAsAreaUsuaria"): parameters);
parameters = (usedFields[23] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@IsMandatory, "ismandatory") ?? "ismandatory") + " = @ssIsMandatory"): parameters);
parameters = (usedFields[24] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@IsReassigned, "isreassigned") ?? "isreassigned") + " = @ssIsReassigned"): parameters);
parameters = (usedFields[25] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@IsSubstituteFor, "issubstitutefor") ?? "issubstitutefor") + " = @ssIsSubstituteFor"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENRequisitioApprovalLevel_ssd_RequisitionAprovalLevel";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@NeedsContract, "needscontract") ?? "needscontract") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@NeedsContract, "needscontract") ?? "needscontract") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENRequisitionApprovalLevel.ssRequisitionApprovalId==0L)) {
sqlCmd.CreateParameter("@ssRequisitionApprovalId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssRequisitionApprovalId", DbType.Int64, ssENRequisitionApprovalLevel.ssRequisitionApprovalId);

}
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssLevelNumber", DbType.Int32, ssENRequisitionApprovalLevel.ssLevelNumber);
}
if(usedFields[3]) {
if ((ssENRequisitionApprovalLevel.ssApplicationRoleId==0L)) {
sqlCmd.CreateParameter("@ssApplicationRoleId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssApplicationRoleId", DbType.Int64, ssENRequisitionApprovalLevel.ssApplicationRoleId);

}
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssEntraJobTitle", DbType.String, ssENRequisitionApprovalLevel.ssEntraJobTitle);
}
if(usedFields[5]) {
if ((ssENRequisitionApprovalLevel.ssDepartmentId==0L)) {
sqlCmd.CreateParameter("@ssDepartmentId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssDepartmentId", DbType.Int64, ssENRequisitionApprovalLevel.ssDepartmentId);

}
}
if(usedFields[6]) {
if ((ssENRequisitionApprovalLevel.ssManagementId==0L)) {
sqlCmd.CreateParameter("@ssManagementId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssManagementId", DbType.Int64, ssENRequisitionApprovalLevel.ssManagementId);

}
}
if(usedFields[7]) {
if ((ssENRequisitionApprovalLevel.ssSubdirectionId==0L)) {
sqlCmd.CreateParameter("@ssSubdirectionId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssSubdirectionId", DbType.Int64, ssENRequisitionApprovalLevel.ssSubdirectionId);

}
}
if(usedFields[8]) {
if ((ssENRequisitionApprovalLevel.ssEntraRoleId==0L)) {
sqlCmd.CreateParameter("@ssEntraRoleId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssEntraRoleId", DbType.Int64, ssENRequisitionApprovalLevel.ssEntraRoleId);

}
}
if(usedFields[9]) {
sqlCmd.CreateParameter("@ssEntraUserName", DbType.String, ssENRequisitionApprovalLevel.ssEntraUserName);
}
if(usedFields[10]) {
if ((ssENRequisitionApprovalLevel.ssAssignedTo=="")) {
sqlCmd.CreateParameter("@ssAssignedTo", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssAssignedTo", DbType.String, ssENRequisitionApprovalLevel.ssAssignedTo);

}
}
if(usedFields[11]) {
sqlCmd.CreateParameter("@ssNeedsContract", DbType.Boolean, ssENRequisitionApprovalLevel.ssNeedsContract);
}
if(usedFields[12]) {
if ((ssENRequisitionApprovalLevel.ssApprovalStatusId==0)) {
sqlCmd.CreateParameter("@ssApprovalStatusId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssApprovalStatusId", DbType.Int32, ssENRequisitionApprovalLevel.ssApprovalStatusId);

}
}
if(usedFields[13]) {
if ((ssENRequisitionApprovalLevel.ssApprovedBy=="")) {
sqlCmd.CreateParameter("@ssApprovedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssApprovedBy", DbType.String, ssENRequisitionApprovalLevel.ssApprovedBy);

}
}
if(usedFields[14]) {
sqlCmd.CreateParameter("@ssApprovedOn", DbType.DateTime, ssENRequisitionApprovalLevel.ssApprovedOn);
}
if(usedFields[15]) {
if ((ssENRequisitionApprovalLevel.ssRequestToModifyBy=="")) {
sqlCmd.CreateParameter("@ssRequestToModifyBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssRequestToModifyBy", DbType.String, ssENRequisitionApprovalLevel.ssRequestToModifyBy);

}
}
if(usedFields[16]) {
sqlCmd.CreateParameter("@ssRequestToModifyOn", DbType.DateTime, ssENRequisitionApprovalLevel.ssRequestToModifyOn);
}
if(usedFields[17]) {
if ((ssENRequisitionApprovalLevel.ssCanceledBy=="")) {
sqlCmd.CreateParameter("@ssCanceledBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCanceledBy", DbType.String, ssENRequisitionApprovalLevel.ssCanceledBy);

}
}
if(usedFields[18]) {
sqlCmd.CreateParameter("@ssCanceledOn_DEPREC", DbType.Boolean, ssENRequisitionApprovalLevel.ssCanceledOn_DEPREC);
}
if(usedFields[19]) {
sqlCmd.CreateParameter("@ssIsAccounting", DbType.Boolean, ssENRequisitionApprovalLevel.ssIsAccounting);
}
if(usedFields[20]) {
sqlCmd.CreateParameter("@ssIsStartAccounting", DbType.Boolean, ssENRequisitionApprovalLevel.ssIsStartAccounting);
}
if(usedFields[21]) {
sqlCmd.CreateParameter("@ssCanceledOn_", DbType.DateTime, ssENRequisitionApprovalLevel.ssCanceledOn_);
}
if(usedFields[22]) {
sqlCmd.CreateParameter("@ssApproveAsAreaUsuaria", DbType.Boolean, ssENRequisitionApprovalLevel.ssApproveAsAreaUsuaria);
}
if(usedFields[23]) {
sqlCmd.CreateParameter("@ssIsMandatory", DbType.Boolean, ssENRequisitionApprovalLevel.ssIsMandatory);
}
if(usedFields[24]) {
sqlCmd.CreateParameter("@ssIsReassigned", DbType.Boolean, ssENRequisitionApprovalLevel.ssIsReassigned);
}
if(usedFields[25]) {
if ((ssENRequisitionApprovalLevel.ssIsSubstituteFor=="")) {
sqlCmd.CreateParameter("@ssIsSubstituteFor", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssIsSubstituteFor", DbType.String, ssENRequisitionApprovalLevel.ssIsSubstituteFor);

}
}
sqlCmd.CreateParameter("@idparam_ssENRequisitioApprovalLevel_ssd_RequisitionAprovalLevel", DbType.Int64, ssENRequisitionApprovalLevel.ssId);
int counter = 0;
if(ssENRequisitionApprovalLevel.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateRequisitionApprovalLevel (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENRequisitionApprovalLevelEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@RequisitionApprovalId, "requisitionapprovalid") ?? "requisitionapprovalid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@LevelNumber, "levelnumber") ?? "levelnumber") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@EntraJobTitle, "entrajobtitle") ?? "entrajobtitle") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@DepartmentId, "departmentid") ?? "departmentid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@ManagementId, "managementid") ?? "managementid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@SubdirectionId, "subdirectionid") ?? "subdirectionid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@EntraRoleId, "entraroleid") ?? "entraroleid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@EntraUserName, "entrausername") ?? "entrausername") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@AssignedTo, "assignedto") ?? "assignedto") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@NeedsContract, "needscontract") ?? "needscontract") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@ApprovalStatusId, "approvalstatusid") ?? "approvalstatusid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@ApprovedBy, "approvedby") ?? "approvedby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@ApprovedOn, "approvedon") ?? "approvedon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@RequestToModifyBy, "requesttomodifyby") ?? "requesttomodifyby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@RequestToModifyOn, "requesttomodifyon") ?? "requesttomodifyon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@CanceledBy, "canceledby") ?? "canceledby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@CanceledOn_DEPREC, "canceledon_deprec") ?? "canceledon_deprec") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@IsAccounting, "isaccounting") ?? "isaccounting") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@IsStartAccounting, "isstartaccounting") ?? "isstartaccounting") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@CanceledOn_, "canceledon_") ?? "canceledon_") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@ApproveAsAreaUsuaria, "approveasareausuaria") ?? "approveasareausuaria") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@IsMandatory, "ismandatory") ?? "ismandatory") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@IsReassigned, "isreassigned") ?? "isreassigned") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@IsSubstituteFor, "issubstitutefor") ?? "issubstitutefor") + "" +
" ) VALUES (" +
" @ssRequisitionApprovalId" +
", @ssLevelNumber" +
", @ssApplicationRoleId" +
", @ssEntraJobTitle" +
", @ssDepartmentId" +
", @ssManagementId" +
", @ssSubdirectionId" +
", @ssEntraRoleId" +
", @ssEntraUserName" +
", @ssAssignedTo" +
", @ssNeedsContract" +
", @ssApprovalStatusId" +
", @ssApprovedBy" +
", @ssApprovedOn" +
", @ssRequestToModifyBy" +
", @ssRequestToModifyOn" +
", @ssCanceledBy" +
", @ssCanceledOn_DEPREC" +
", @ssIsAccounting" +
", @ssIsStartAccounting" +
", @ssCanceledOn_" +
", @ssApproveAsAreaUsuaria" +
", @ssIsMandatory" +
", @ssIsReassigned" +
", @ssIsSubstituteFor" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENRequisitionApprovalLevel.ssRequisitionApprovalId==0L)) {
insertSqlCmd.CreateParameter("@ssRequisitionApprovalId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssRequisitionApprovalId", DbType.Int64, ssENRequisitionApprovalLevel.ssRequisitionApprovalId);

}
insertSqlCmd.CreateParameter("@ssLevelNumber", DbType.Int32, ssENRequisitionApprovalLevel.ssLevelNumber);
if ((ssENRequisitionApprovalLevel.ssApplicationRoleId==0L)) {
insertSqlCmd.CreateParameter("@ssApplicationRoleId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssApplicationRoleId", DbType.Int64, ssENRequisitionApprovalLevel.ssApplicationRoleId);

}
insertSqlCmd.CreateParameter("@ssEntraJobTitle", DbType.String, ssENRequisitionApprovalLevel.ssEntraJobTitle);
if ((ssENRequisitionApprovalLevel.ssDepartmentId==0L)) {
insertSqlCmd.CreateParameter("@ssDepartmentId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssDepartmentId", DbType.Int64, ssENRequisitionApprovalLevel.ssDepartmentId);

}
if ((ssENRequisitionApprovalLevel.ssManagementId==0L)) {
insertSqlCmd.CreateParameter("@ssManagementId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssManagementId", DbType.Int64, ssENRequisitionApprovalLevel.ssManagementId);

}
if ((ssENRequisitionApprovalLevel.ssSubdirectionId==0L)) {
insertSqlCmd.CreateParameter("@ssSubdirectionId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssSubdirectionId", DbType.Int64, ssENRequisitionApprovalLevel.ssSubdirectionId);

}
if ((ssENRequisitionApprovalLevel.ssEntraRoleId==0L)) {
insertSqlCmd.CreateParameter("@ssEntraRoleId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssEntraRoleId", DbType.Int64, ssENRequisitionApprovalLevel.ssEntraRoleId);

}
insertSqlCmd.CreateParameter("@ssEntraUserName", DbType.String, ssENRequisitionApprovalLevel.ssEntraUserName);
if ((ssENRequisitionApprovalLevel.ssAssignedTo=="")) {
insertSqlCmd.CreateParameter("@ssAssignedTo", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssAssignedTo", DbType.String, ssENRequisitionApprovalLevel.ssAssignedTo);

}
insertSqlCmd.CreateParameter("@ssNeedsContract", DbType.Boolean, ssENRequisitionApprovalLevel.ssNeedsContract);
if ((ssENRequisitionApprovalLevel.ssApprovalStatusId==0)) {
insertSqlCmd.CreateParameter("@ssApprovalStatusId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssApprovalStatusId", DbType.Int32, ssENRequisitionApprovalLevel.ssApprovalStatusId);

}
if ((ssENRequisitionApprovalLevel.ssApprovedBy=="")) {
insertSqlCmd.CreateParameter("@ssApprovedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssApprovedBy", DbType.String, ssENRequisitionApprovalLevel.ssApprovedBy);

}
insertSqlCmd.CreateParameter("@ssApprovedOn", DbType.DateTime, ssENRequisitionApprovalLevel.ssApprovedOn);
if ((ssENRequisitionApprovalLevel.ssRequestToModifyBy=="")) {
insertSqlCmd.CreateParameter("@ssRequestToModifyBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssRequestToModifyBy", DbType.String, ssENRequisitionApprovalLevel.ssRequestToModifyBy);

}
insertSqlCmd.CreateParameter("@ssRequestToModifyOn", DbType.DateTime, ssENRequisitionApprovalLevel.ssRequestToModifyOn);
if ((ssENRequisitionApprovalLevel.ssCanceledBy=="")) {
insertSqlCmd.CreateParameter("@ssCanceledBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCanceledBy", DbType.String, ssENRequisitionApprovalLevel.ssCanceledBy);

}
insertSqlCmd.CreateParameter("@ssCanceledOn_DEPREC", DbType.Boolean, ssENRequisitionApprovalLevel.ssCanceledOn_DEPREC);
insertSqlCmd.CreateParameter("@ssIsAccounting", DbType.Boolean, ssENRequisitionApprovalLevel.ssIsAccounting);
insertSqlCmd.CreateParameter("@ssIsStartAccounting", DbType.Boolean, ssENRequisitionApprovalLevel.ssIsStartAccounting);
insertSqlCmd.CreateParameter("@ssCanceledOn_", DbType.DateTime, ssENRequisitionApprovalLevel.ssCanceledOn_);
insertSqlCmd.CreateParameter("@ssApproveAsAreaUsuaria", DbType.Boolean, ssENRequisitionApprovalLevel.ssApproveAsAreaUsuaria);
insertSqlCmd.CreateParameter("@ssIsMandatory", DbType.Boolean, ssENRequisitionApprovalLevel.ssIsMandatory);
insertSqlCmd.CreateParameter("@ssIsReassigned", DbType.Boolean, ssENRequisitionApprovalLevel.ssIsReassigned);
if ((ssENRequisitionApprovalLevel.ssIsSubstituteFor=="")) {
insertSqlCmd.CreateParameter("@ssIsSubstituteFor", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssIsSubstituteFor", DbType.String, ssENRequisitionApprovalLevel.ssIsSubstituteFor);

}
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateRequisitionApprovalLevel", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENRequisitionApprovalLevel.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeRequisitionApprovalLevel
/// </summary>

public static async Task CreateOrUpdateSomeRequisitionApprovalLevel(IRequestContext requestContext,RL_d8bc800f4e3c344ab91bf54150e31a34 inParamSourceList,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateSomeRequisitionApprovalLevel", "875ae9ed-3877-4b95-9236-49ac94000633.#CreateOrUpdateAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeRequisitionApprovalLevel", "875ae9ed-3877-4b95-9236-49ac94000633.#CreateOrUpdateAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
string entityTableName = ENRequisitionApprovalLevelEntity.LocalViewName(null);
string insertSql = "INSERT INTO " + entityTableName + " (" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@RequisitionApprovalId, "requisitionapprovalid") ?? "requisitionapprovalid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@LevelNumber, "levelnumber") ?? "levelnumber") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@EntraJobTitle, "entrajobtitle") ?? "entrajobtitle") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@DepartmentId, "departmentid") ?? "departmentid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@ManagementId, "managementid") ?? "managementid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@SubdirectionId, "subdirectionid") ?? "subdirectionid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@EntraRoleId, "entraroleid") ?? "entraroleid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@EntraUserName, "entrausername") ?? "entrausername") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@AssignedTo, "assignedto") ?? "assignedto") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@NeedsContract, "needscontract") ?? "needscontract") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@ApprovalStatusId, "approvalstatusid") ?? "approvalstatusid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@ApprovedBy, "approvedby") ?? "approvedby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@ApprovedOn, "approvedon") ?? "approvedon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@RequestToModifyBy, "requesttomodifyby") ?? "requesttomodifyby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@RequestToModifyOn, "requesttomodifyon") ?? "requesttomodifyon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@CanceledBy, "canceledby") ?? "canceledby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@CanceledOn_DEPREC, "canceledon_deprec") ?? "canceledon_deprec") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@IsAccounting, "isaccounting") ?? "isaccounting") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@IsStartAccounting, "isstartaccounting") ?? "isstartaccounting") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@CanceledOn_, "canceledon_") ?? "canceledon_") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@ApproveAsAreaUsuaria, "approveasareausuaria") ?? "approveasareausuaria") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@IsMandatory, "ismandatory") ?? "ismandatory") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@IsReassigned, "isreassigned") ?? "isreassigned") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@IsSubstituteFor, "issubstitutefor") ?? "issubstitutefor") + ") VALUES ( unnest(@ssRequisitionApprovalId),  unnest(@ssLevelNumber),  unnest(@ssApplicationRoleId),  unnest(@ssEntraJobTitle),  unnest(@ssDepartmentId),  unnest(@ssManagementId),  unnest(@ssSubdirectionId),  unnest(@ssEntraRoleId),  unnest(@ssEntraUserName),  unnest(@ssAssignedTo),  unnest(@ssNeedsContract),  unnest(@ssApprovalStatusId),  unnest(@ssApprovedBy),  unnest(@ssApprovedOn),  unnest(@ssRequestToModifyBy),  unnest(@ssRequestToModifyOn),  unnest(@ssCanceledBy),  unnest(@ssCanceledOn_DEPREC),  unnest(@ssIsAccounting),  unnest(@ssIsStartAccounting),  unnest(@ssCanceledOn_),  unnest(@ssApproveAsAreaUsuaria),  unnest(@ssIsMandatory),  unnest(@ssIsReassigned),  unnest(@ssIsSubstituteFor)) ";
insertSql += "";

string updateSql = "UPDATE " + entityTableName + " SET " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@RequisitionApprovalId, "requisitionapprovalid") ?? "requisitionapprovalid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@RequisitionApprovalId, "requisitionapprovalid") ?? "requisitionapprovalid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@LevelNumber, "levelnumber") ?? "levelnumber") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@LevelNumber, "levelnumber") ?? "levelnumber") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@EntraJobTitle, "entrajobtitle") ?? "entrajobtitle") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@EntraJobTitle, "entrajobtitle") ?? "entrajobtitle") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@DepartmentId, "departmentid") ?? "departmentid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@DepartmentId, "departmentid") ?? "departmentid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@ManagementId, "managementid") ?? "managementid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@ManagementId, "managementid") ?? "managementid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@SubdirectionId, "subdirectionid") ?? "subdirectionid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@SubdirectionId, "subdirectionid") ?? "subdirectionid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@EntraRoleId, "entraroleid") ?? "entraroleid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@EntraRoleId, "entraroleid") ?? "entraroleid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@EntraUserName, "entrausername") ?? "entrausername") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@EntraUserName, "entrausername") ?? "entrausername") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@AssignedTo, "assignedto") ?? "assignedto") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@AssignedTo, "assignedto") ?? "assignedto") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@NeedsContract, "needscontract") ?? "needscontract") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@NeedsContract, "needscontract") ?? "needscontract") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@ApprovalStatusId, "approvalstatusid") ?? "approvalstatusid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@ApprovalStatusId, "approvalstatusid") ?? "approvalstatusid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@ApprovedBy, "approvedby") ?? "approvedby") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@ApprovedBy, "approvedby") ?? "approvedby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@ApprovedOn, "approvedon") ?? "approvedon") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@ApprovedOn, "approvedon") ?? "approvedon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@RequestToModifyBy, "requesttomodifyby") ?? "requesttomodifyby") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@RequestToModifyBy, "requesttomodifyby") ?? "requesttomodifyby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@RequestToModifyOn, "requesttomodifyon") ?? "requesttomodifyon") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@RequestToModifyOn, "requesttomodifyon") ?? "requesttomodifyon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@CanceledBy, "canceledby") ?? "canceledby") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@CanceledBy, "canceledby") ?? "canceledby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@CanceledOn_DEPREC, "canceledon_deprec") ?? "canceledon_deprec") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@CanceledOn_DEPREC, "canceledon_deprec") ?? "canceledon_deprec") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@IsAccounting, "isaccounting") ?? "isaccounting") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@IsAccounting, "isaccounting") ?? "isaccounting") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@IsStartAccounting, "isstartaccounting") ?? "isstartaccounting") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@IsStartAccounting, "isstartaccounting") ?? "isstartaccounting") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@CanceledOn_, "canceledon_") ?? "canceledon_") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@CanceledOn_, "canceledon_") ?? "canceledon_") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@ApproveAsAreaUsuaria, "approveasareausuaria") ?? "approveasareausuaria") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@ApproveAsAreaUsuaria, "approveasareausuaria") ?? "approveasareausuaria") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@IsMandatory, "ismandatory") ?? "ismandatory") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@IsMandatory, "ismandatory") ?? "ismandatory") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@IsReassigned, "isreassigned") ?? "isreassigned") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@IsReassigned, "isreassigned") ?? "isreassigned") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@IsSubstituteFor, "issubstitutefor") ?? "issubstitutefor") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@IsSubstituteFor, "issubstitutefor") ?? "issubstitutefor") + " from ( select  unnest(@ssId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@Id, "id") ?? "id") + ",  unnest(@ssRequisitionApprovalId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@RequisitionApprovalId, "requisitionapprovalid") ?? "requisitionapprovalid") + ",  unnest(@ssLevelNumber) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@LevelNumber, "levelnumber") ?? "levelnumber") + ",  unnest(@ssApplicationRoleId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid") + ",  unnest(@ssEntraJobTitle) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@EntraJobTitle, "entrajobtitle") ?? "entrajobtitle") + ",  unnest(@ssDepartmentId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@DepartmentId, "departmentid") ?? "departmentid") + ",  unnest(@ssManagementId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@ManagementId, "managementid") ?? "managementid") + ",  unnest(@ssSubdirectionId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@SubdirectionId, "subdirectionid") ?? "subdirectionid") + ",  unnest(@ssEntraRoleId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@EntraRoleId, "entraroleid") ?? "entraroleid") + ",  unnest(@ssEntraUserName) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@EntraUserName, "entrausername") ?? "entrausername") + ",  unnest(@ssAssignedTo) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@AssignedTo, "assignedto") ?? "assignedto") + ",  unnest(@ssNeedsContract) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@NeedsContract, "needscontract") ?? "needscontract") + ",  unnest(@ssApprovalStatusId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@ApprovalStatusId, "approvalstatusid") ?? "approvalstatusid") + ",  unnest(@ssApprovedBy) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@ApprovedBy, "approvedby") ?? "approvedby") + ",  unnest(@ssApprovedOn) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@ApprovedOn, "approvedon") ?? "approvedon") + ",  unnest(@ssRequestToModifyBy) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@RequestToModifyBy, "requesttomodifyby") ?? "requesttomodifyby") + ",  unnest(@ssRequestToModifyOn) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@RequestToModifyOn, "requesttomodifyon") ?? "requesttomodifyon") + ",  unnest(@ssCanceledBy) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@CanceledBy, "canceledby") ?? "canceledby") + ",  unnest(@ssCanceledOn_DEPREC) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@CanceledOn_DEPREC, "canceledon_deprec") ?? "canceledon_deprec") + ",  unnest(@ssIsAccounting) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@IsAccounting, "isaccounting") ?? "isaccounting") + ",  unnest(@ssIsStartAccounting) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@IsStartAccounting, "isstartaccounting") ?? "isstartaccounting") + ",  unnest(@ssCanceledOn_) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@CanceledOn_, "canceledon_") ?? "canceledon_") + ",  unnest(@ssApproveAsAreaUsuaria) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@ApproveAsAreaUsuaria, "approveasareausuaria") ?? "approveasareausuaria") + ",  unnest(@ssIsMandatory) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@IsMandatory, "ismandatory") ?? "ismandatory") + ",  unnest(@ssIsReassigned) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@IsReassigned, "isreassigned") ?? "isreassigned") + ",  unnest(@ssIsSubstituteFor) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@IsSubstituteFor, "issubstitutefor") ?? "issubstitutefor") + " ) as updateTable where " + entityTableName + "." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@Id, "id") ?? "id") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@Id, "id") ?? "id") + " ";
updateSql += "";

List<object> insertRequisitionApprovalIdList = new List<object>();
List<int> insertLevelNumberList = new List<int>();
List<object> insertApplicationRoleIdList = new List<object>();
List<string> insertEntraJobTitleList = new List<string>();
List<object> insertDepartmentIdList = new List<object>();
List<object> insertManagementIdList = new List<object>();
List<object> insertSubdirectionIdList = new List<object>();
List<object> insertEntraRoleIdList = new List<object>();
List<string> insertEntraUserNameList = new List<string>();
List<object> insertAssignedToList = new List<object>();
List<bool> insertNeedsContractList = new List<bool>();
List<object> insertApprovalStatusIdList = new List<object>();
List<object> insertApprovedByList = new List<object>();
List<DateTime> insertApprovedOnList = new List<DateTime>();
List<object> insertRequestToModifyByList = new List<object>();
List<DateTime> insertRequestToModifyOnList = new List<DateTime>();
List<object> insertCanceledByList = new List<object>();
List<bool> insertCanceledOn_DEPRECList = new List<bool>();
List<bool> insertIsAccountingList = new List<bool>();
List<bool> insertIsStartAccountingList = new List<bool>();
List<DateTime> insertCanceledOn_List = new List<DateTime>();
List<bool> insertApproveAsAreaUsuariaList = new List<bool>();
List<bool> insertIsMandatoryList = new List<bool>();
List<bool> insertIsReassignedList = new List<bool>();
List<object> insertIsSubstituteForList = new List<object>();

List<long> updateIdList = new List<long>();
List<object> updateRequisitionApprovalIdList = new List<object>();
List<int> updateLevelNumberList = new List<int>();
List<object> updateApplicationRoleIdList = new List<object>();
List<string> updateEntraJobTitleList = new List<string>();
List<object> updateDepartmentIdList = new List<object>();
List<object> updateManagementIdList = new List<object>();
List<object> updateSubdirectionIdList = new List<object>();
List<object> updateEntraRoleIdList = new List<object>();
List<string> updateEntraUserNameList = new List<string>();
List<object> updateAssignedToList = new List<object>();
List<bool> updateNeedsContractList = new List<bool>();
List<object> updateApprovalStatusIdList = new List<object>();
List<object> updateApprovedByList = new List<object>();
List<DateTime> updateApprovedOnList = new List<DateTime>();
List<object> updateRequestToModifyByList = new List<object>();
List<DateTime> updateRequestToModifyOnList = new List<DateTime>();
List<object> updateCanceledByList = new List<object>();
List<bool> updateCanceledOn_DEPRECList = new List<bool>();
List<bool> updateIsAccountingList = new List<bool>();
List<bool> updateIsStartAccountingList = new List<bool>();
List<DateTime> updateCanceledOn_List = new List<DateTime>();
List<bool> updateApproveAsAreaUsuariaList = new List<bool>();
List<bool> updateIsMandatoryList = new List<bool>();
List<bool> updateIsReassignedList = new List<bool>();
List<object> updateIsSubstituteForList = new List<object>();

var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_5404698ef74632f0bc59763509d95177)inParamSourceList.Current).ssENRequisitionApprovalLevel;
if (record.ssId != 0L) {
updateIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
if ((record.ssRequisitionApprovalId==0L)) {
updateRequisitionApprovalIdList.Add(null);
} else {
updateRequisitionApprovalIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssRequisitionApprovalId));
}
updateLevelNumberList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssLevelNumber));
if ((record.ssApplicationRoleId==0L)) {
updateApplicationRoleIdList.Add(null);
} else {
updateApplicationRoleIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssApplicationRoleId));
}
updateEntraJobTitleList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssEntraJobTitle));
if ((record.ssDepartmentId==0L)) {
updateDepartmentIdList.Add(null);
} else {
updateDepartmentIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssDepartmentId));
}
if ((record.ssManagementId==0L)) {
updateManagementIdList.Add(null);
} else {
updateManagementIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssManagementId));
}
if ((record.ssSubdirectionId==0L)) {
updateSubdirectionIdList.Add(null);
} else {
updateSubdirectionIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssSubdirectionId));
}
if ((record.ssEntraRoleId==0L)) {
updateEntraRoleIdList.Add(null);
} else {
updateEntraRoleIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssEntraRoleId));
}
updateEntraUserNameList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssEntraUserName));
if ((record.ssAssignedTo=="")) {
updateAssignedToList.Add(null);
} else {
updateAssignedToList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssAssignedTo));
}
updateNeedsContractList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssNeedsContract));
if ((record.ssApprovalStatusId==0)) {
updateApprovalStatusIdList.Add(null);
} else {
updateApprovalStatusIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssApprovalStatusId));
}
if ((record.ssApprovedBy=="")) {
updateApprovedByList.Add(null);
} else {
updateApprovedByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssApprovedBy));
}
updateApprovedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssApprovedOn));
if ((record.ssRequestToModifyBy=="")) {
updateRequestToModifyByList.Add(null);
} else {
updateRequestToModifyByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssRequestToModifyBy));
}
updateRequestToModifyOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssRequestToModifyOn));
if ((record.ssCanceledBy=="")) {
updateCanceledByList.Add(null);
} else {
updateCanceledByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssCanceledBy));
}
updateCanceledOn_DEPRECList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssCanceledOn_DEPREC));
updateIsAccountingList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsAccounting));
updateIsStartAccountingList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsStartAccounting));
updateCanceledOn_List.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssCanceledOn_));
updateApproveAsAreaUsuariaList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssApproveAsAreaUsuaria));
updateIsMandatoryList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsMandatory));
updateIsReassignedList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsReassigned));
if ((record.ssIsSubstituteFor=="")) {
updateIsSubstituteForList.Add(null);
} else {
updateIsSubstituteForList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssIsSubstituteFor));
}
} else {
if ((record.ssRequisitionApprovalId==0L)) {
insertRequisitionApprovalIdList.Add(null);
} else {
insertRequisitionApprovalIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssRequisitionApprovalId));
}
insertLevelNumberList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssLevelNumber));
if ((record.ssApplicationRoleId==0L)) {
insertApplicationRoleIdList.Add(null);
} else {
insertApplicationRoleIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssApplicationRoleId));
}
insertEntraJobTitleList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssEntraJobTitle));
if ((record.ssDepartmentId==0L)) {
insertDepartmentIdList.Add(null);
} else {
insertDepartmentIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssDepartmentId));
}
if ((record.ssManagementId==0L)) {
insertManagementIdList.Add(null);
} else {
insertManagementIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssManagementId));
}
if ((record.ssSubdirectionId==0L)) {
insertSubdirectionIdList.Add(null);
} else {
insertSubdirectionIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssSubdirectionId));
}
if ((record.ssEntraRoleId==0L)) {
insertEntraRoleIdList.Add(null);
} else {
insertEntraRoleIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssEntraRoleId));
}
insertEntraUserNameList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssEntraUserName));
if ((record.ssAssignedTo=="")) {
insertAssignedToList.Add(null);
} else {
insertAssignedToList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssAssignedTo));
}
insertNeedsContractList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssNeedsContract));
if ((record.ssApprovalStatusId==0)) {
insertApprovalStatusIdList.Add(null);
} else {
insertApprovalStatusIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssApprovalStatusId));
}
if ((record.ssApprovedBy=="")) {
insertApprovedByList.Add(null);
} else {
insertApprovedByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssApprovedBy));
}
insertApprovedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssApprovedOn));
if ((record.ssRequestToModifyBy=="")) {
insertRequestToModifyByList.Add(null);
} else {
insertRequestToModifyByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssRequestToModifyBy));
}
insertRequestToModifyOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssRequestToModifyOn));
if ((record.ssCanceledBy=="")) {
insertCanceledByList.Add(null);
} else {
insertCanceledByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssCanceledBy));
}
insertCanceledOn_DEPRECList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssCanceledOn_DEPREC));
insertIsAccountingList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsAccounting));
insertIsStartAccountingList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsStartAccounting));
insertCanceledOn_List.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssCanceledOn_));
insertApproveAsAreaUsuariaList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssApproveAsAreaUsuaria));
insertIsMandatoryList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsMandatory));
insertIsReassignedList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsReassigned));
if ((record.ssIsSubstituteFor=="")) {
insertIsSubstituteForList.Add(null);
} else {
insertIsSubstituteForList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssIsSubstituteFor));
}
}
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertRequisitionApprovalIdList.IsEmpty() || !insertLevelNumberList.IsEmpty() || !insertApplicationRoleIdList.IsEmpty() || !insertEntraJobTitleList.IsEmpty() || !insertDepartmentIdList.IsEmpty() || !insertManagementIdList.IsEmpty() || !insertSubdirectionIdList.IsEmpty() || !insertEntraRoleIdList.IsEmpty() || !insertEntraUserNameList.IsEmpty() || !insertAssignedToList.IsEmpty() || !insertNeedsContractList.IsEmpty() || !insertApprovalStatusIdList.IsEmpty() || !insertApprovedByList.IsEmpty() || !insertApprovedOnList.IsEmpty() || !insertRequestToModifyByList.IsEmpty() || !insertRequestToModifyOnList.IsEmpty() || !insertCanceledByList.IsEmpty() || !insertCanceledOn_DEPRECList.IsEmpty() || !insertIsAccountingList.IsEmpty() || !insertIsStartAccountingList.IsEmpty() || !insertCanceledOn_List.IsEmpty() || !insertApproveAsAreaUsuariaList.IsEmpty() || !insertIsMandatoryList.IsEmpty() || !insertIsReassignedList.IsEmpty() || !insertIsSubstituteForList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssRequisitionApprovalId",DbType.Int64,insertRequisitionApprovalIdList);
executionService.CreateParameter(insertSqlCmd,"@ssLevelNumber",DbType.Int32,insertLevelNumberList);
executionService.CreateParameter(insertSqlCmd,"@ssApplicationRoleId",DbType.Int64,insertApplicationRoleIdList);
executionService.CreateParameter(insertSqlCmd,"@ssEntraJobTitle",DbType.String,insertEntraJobTitleList);
executionService.CreateParameter(insertSqlCmd,"@ssDepartmentId",DbType.Int64,insertDepartmentIdList);
executionService.CreateParameter(insertSqlCmd,"@ssManagementId",DbType.Int64,insertManagementIdList);
executionService.CreateParameter(insertSqlCmd,"@ssSubdirectionId",DbType.Int64,insertSubdirectionIdList);
executionService.CreateParameter(insertSqlCmd,"@ssEntraRoleId",DbType.Int64,insertEntraRoleIdList);
executionService.CreateParameter(insertSqlCmd,"@ssEntraUserName",DbType.String,insertEntraUserNameList);
executionService.CreateParameter(insertSqlCmd,"@ssAssignedTo",DbType.String,insertAssignedToList);
executionService.CreateParameter(insertSqlCmd,"@ssNeedsContract",DbType.Boolean,insertNeedsContractList);
executionService.CreateParameter(insertSqlCmd,"@ssApprovalStatusId",DbType.Int32,insertApprovalStatusIdList);
executionService.CreateParameter(insertSqlCmd,"@ssApprovedBy",DbType.String,insertApprovedByList);
executionService.CreateParameter(insertSqlCmd,"@ssApprovedOn",DbType.DateTime,insertApprovedOnList);
executionService.CreateParameter(insertSqlCmd,"@ssRequestToModifyBy",DbType.String,insertRequestToModifyByList);
executionService.CreateParameter(insertSqlCmd,"@ssRequestToModifyOn",DbType.DateTime,insertRequestToModifyOnList);
executionService.CreateParameter(insertSqlCmd,"@ssCanceledBy",DbType.String,insertCanceledByList);
executionService.CreateParameter(insertSqlCmd,"@ssCanceledOn_DEPREC",DbType.Boolean,insertCanceledOn_DEPRECList);
executionService.CreateParameter(insertSqlCmd,"@ssIsAccounting",DbType.Boolean,insertIsAccountingList);
executionService.CreateParameter(insertSqlCmd,"@ssIsStartAccounting",DbType.Boolean,insertIsStartAccountingList);
executionService.CreateParameter(insertSqlCmd,"@ssCanceledOn_",DbType.DateTime,insertCanceledOn_List);
executionService.CreateParameter(insertSqlCmd,"@ssApproveAsAreaUsuaria",DbType.Boolean,insertApproveAsAreaUsuariaList);
executionService.CreateParameter(insertSqlCmd,"@ssIsMandatory",DbType.Boolean,insertIsMandatoryList);
executionService.CreateParameter(insertSqlCmd,"@ssIsReassigned",DbType.Boolean,insertIsReassignedList);
executionService.CreateParameter(insertSqlCmd,"@ssIsSubstituteFor",DbType.String,insertIsSubstituteForList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeRequisitionApprovalLevel (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
if(!updateRequisitionApprovalIdList.IsEmpty() || !updateLevelNumberList.IsEmpty() || !updateApplicationRoleIdList.IsEmpty() || !updateEntraJobTitleList.IsEmpty() || !updateDepartmentIdList.IsEmpty() || !updateManagementIdList.IsEmpty() || !updateSubdirectionIdList.IsEmpty() || !updateEntraRoleIdList.IsEmpty() || !updateEntraUserNameList.IsEmpty() || !updateAssignedToList.IsEmpty() || !updateNeedsContractList.IsEmpty() || !updateApprovalStatusIdList.IsEmpty() || !updateApprovedByList.IsEmpty() || !updateApprovedOnList.IsEmpty() || !updateRequestToModifyByList.IsEmpty() || !updateRequestToModifyOnList.IsEmpty() || !updateCanceledByList.IsEmpty() || !updateCanceledOn_DEPRECList.IsEmpty() || !updateIsAccountingList.IsEmpty() || !updateIsStartAccountingList.IsEmpty() || !updateCanceledOn_List.IsEmpty() || !updateApproveAsAreaUsuariaList.IsEmpty() || !updateIsMandatoryList.IsEmpty() || !updateIsReassignedList.IsEmpty() || !updateIsSubstituteForList.IsEmpty()){
await using(var updateSqlCmd = trans.CreateCommand(updateSql)){
executionService.CreateParameter(updateSqlCmd,"@ssId",DbType.Int64,updateIdList);
executionService.CreateParameter(updateSqlCmd,"@ssRequisitionApprovalId",DbType.Int64,updateRequisitionApprovalIdList);
executionService.CreateParameter(updateSqlCmd,"@ssLevelNumber",DbType.Int32,updateLevelNumberList);
executionService.CreateParameter(updateSqlCmd,"@ssApplicationRoleId",DbType.Int64,updateApplicationRoleIdList);
executionService.CreateParameter(updateSqlCmd,"@ssEntraJobTitle",DbType.String,updateEntraJobTitleList);
executionService.CreateParameter(updateSqlCmd,"@ssDepartmentId",DbType.Int64,updateDepartmentIdList);
executionService.CreateParameter(updateSqlCmd,"@ssManagementId",DbType.Int64,updateManagementIdList);
executionService.CreateParameter(updateSqlCmd,"@ssSubdirectionId",DbType.Int64,updateSubdirectionIdList);
executionService.CreateParameter(updateSqlCmd,"@ssEntraRoleId",DbType.Int64,updateEntraRoleIdList);
executionService.CreateParameter(updateSqlCmd,"@ssEntraUserName",DbType.String,updateEntraUserNameList);
executionService.CreateParameter(updateSqlCmd,"@ssAssignedTo",DbType.String,updateAssignedToList);
executionService.CreateParameter(updateSqlCmd,"@ssNeedsContract",DbType.Boolean,updateNeedsContractList);
executionService.CreateParameter(updateSqlCmd,"@ssApprovalStatusId",DbType.Int32,updateApprovalStatusIdList);
executionService.CreateParameter(updateSqlCmd,"@ssApprovedBy",DbType.String,updateApprovedByList);
executionService.CreateParameter(updateSqlCmd,"@ssApprovedOn",DbType.DateTime,updateApprovedOnList);
executionService.CreateParameter(updateSqlCmd,"@ssRequestToModifyBy",DbType.String,updateRequestToModifyByList);
executionService.CreateParameter(updateSqlCmd,"@ssRequestToModifyOn",DbType.DateTime,updateRequestToModifyOnList);
executionService.CreateParameter(updateSqlCmd,"@ssCanceledBy",DbType.String,updateCanceledByList);
executionService.CreateParameter(updateSqlCmd,"@ssCanceledOn_DEPREC",DbType.Boolean,updateCanceledOn_DEPRECList);
executionService.CreateParameter(updateSqlCmd,"@ssIsAccounting",DbType.Boolean,updateIsAccountingList);
executionService.CreateParameter(updateSqlCmd,"@ssIsStartAccounting",DbType.Boolean,updateIsStartAccountingList);
executionService.CreateParameter(updateSqlCmd,"@ssCanceledOn_",DbType.DateTime,updateCanceledOn_List);
executionService.CreateParameter(updateSqlCmd,"@ssApproveAsAreaUsuaria",DbType.Boolean,updateApproveAsAreaUsuariaList);
executionService.CreateParameter(updateSqlCmd,"@ssIsMandatory",DbType.Boolean,updateIsMandatoryList);
executionService.CreateParameter(updateSqlCmd,"@ssIsReassigned",DbType.Boolean,updateIsReassignedList);
executionService.CreateParameter(updateSqlCmd,"@ssIsSubstituteFor",DbType.String,updateIsSubstituteForList);
await updateSqlCmd.PrepareAsync(cancellationToken);
await updateSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeRequisitionApprovalLevel (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(updateSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteRequisitionApprovalLevel
/// </summary>

public static async Task DeleteRequisitionApprovalLevel(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteRequisitionApprovalLevel", "875ae9ed-3877-4b95-9236-49ac94000633.#DeleteEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteRequisitionApprovalLevel", "875ae9ed-3877-4b95-9236-49ac94000633.#DeleteEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENRequisitionApprovalLevelEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteRequisitionApprovalLevel", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllRequisitionApprovalLevel
/// </summary>

public static async Task DeleteAllRequisitionApprovalLevel(IRequestContext requestContext,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteAllRequisitionApprovalLevel", "875ae9ed-3877-4b95-9236-49ac94000633.#DeleteAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllRequisitionApprovalLevel", "875ae9ed-3877-4b95-9236-49ac94000633.#DeleteAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENRequisitionApprovalLevelEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteRequisitionApprovalLevel", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetRequisitionApprovalLevel
/// </summary>

public static async Task<RC_5404698ef74632f0bc59763509d95177> GetRequisitionApprovalLevel(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_5404698ef74632f0bc59763509d95177 outParamRecord = default;
outParamRecord = new RC_5404698ef74632f0bc59763509d95177();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetRequisitionApprovalLevel", "875ae9ed-3877-4b95-9236-49ac94000633.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetRequisitionApprovalLevel", "875ae9ed-3877-4b95-9236-49ac94000633.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@RequisitionApprovalId, "requisitionapprovalid") ?? "requisitionapprovalid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@LevelNumber, "levelnumber") ?? "levelnumber", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@EntraJobTitle, "entrajobtitle") ?? "entrajobtitle", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@DepartmentId, "departmentid") ?? "departmentid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@ManagementId, "managementid") ?? "managementid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@SubdirectionId, "subdirectionid") ?? "subdirectionid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@EntraRoleId, "entraroleid") ?? "entraroleid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@EntraUserName, "entrausername") ?? "entrausername", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@AssignedTo, "assignedto") ?? "assignedto", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@NeedsContract, "needscontract") ?? "needscontract", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@ApprovalStatusId, "approvalstatusid") ?? "approvalstatusid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@ApprovedBy, "approvedby") ?? "approvedby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@ApprovedOn, "approvedon") ?? "approvedon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@RequestToModifyBy, "requesttomodifyby") ?? "requesttomodifyby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@RequestToModifyOn, "requesttomodifyon") ?? "requesttomodifyon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@CanceledBy, "canceledby") ?? "canceledby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@CanceledOn_DEPREC, "canceledon_deprec") ?? "canceledon_deprec", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@IsAccounting, "isaccounting") ?? "isaccounting", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@IsStartAccounting, "isstartaccounting") ?? "isstartaccounting", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@CanceledOn_, "canceledon_") ?? "canceledon_", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@ApproveAsAreaUsuaria, "approveasareausuaria") ?? "approveasareausuaria", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@IsMandatory, "ismandatory") ?? "ismandatory", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@IsReassigned, "isreassigned") ?? "isreassigned", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@IsSubstituteFor, "issubstitutefor") ?? "issubstitutefor", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
" FROM " + ENRequisitionApprovalLevelEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetRequisitionApprovalLevel", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(26,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENRequisitionApprovalLevelEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetRequisitionApprovalLevelForUpdate
/// </summary>

public static async Task<RC_5404698ef74632f0bc59763509d95177> GetRequisitionApprovalLevelForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_5404698ef74632f0bc59763509d95177 outParamRecord = default;
outParamRecord = new RC_5404698ef74632f0bc59763509d95177();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetRequisitionApprovalLevelForUpdate", "875ae9ed-3877-4b95-9236-49ac94000633.#GetEntityForUpdate");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetRequisitionApprovalLevelForUpdate", "875ae9ed-3877-4b95-9236-49ac94000633.#GetEntityForUpdate", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@RequisitionApprovalId, "requisitionapprovalid") ?? "requisitionapprovalid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@LevelNumber, "levelnumber") ?? "levelnumber", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@EntraJobTitle, "entrajobtitle") ?? "entrajobtitle", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@DepartmentId, "departmentid") ?? "departmentid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@ManagementId, "managementid") ?? "managementid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@SubdirectionId, "subdirectionid") ?? "subdirectionid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@EntraRoleId, "entraroleid") ?? "entraroleid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@EntraUserName, "entrausername") ?? "entrausername", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@AssignedTo, "assignedto") ?? "assignedto", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@NeedsContract, "needscontract") ?? "needscontract", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@ApprovalStatusId, "approvalstatusid") ?? "approvalstatusid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@ApprovedBy, "approvedby") ?? "approvedby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@ApprovedOn, "approvedon") ?? "approvedon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@RequestToModifyBy, "requesttomodifyby") ?? "requesttomodifyby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@RequestToModifyOn, "requesttomodifyon") ?? "requesttomodifyon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@CanceledBy, "canceledby") ?? "canceledby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@CanceledOn_DEPREC, "canceledon_deprec") ?? "canceledon_deprec", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@IsAccounting, "isaccounting") ?? "isaccounting", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@IsStartAccounting, "isstartaccounting") ?? "isstartaccounting", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@CanceledOn_, "canceledon_") ?? "canceledon_", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@ApproveAsAreaUsuaria, "approveasareausuaria") ?? "approveasareausuaria", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@IsMandatory, "ismandatory") ?? "ismandatory", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@IsReassigned, "isreassigned") ?? "isreassigned", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@IsSubstituteFor, "issubstitutefor") ?? "issubstitutefor", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
" FROM " + ENRequisitionApprovalLevelEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@Id, "id") ?? "id") + " = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetRequisitionApprovalLevelForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(26,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENRequisitionApprovalLevelEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateRequisitionApprovalLevel
/// </summary>

public static async Task UpdateRequisitionApprovalLevel(IRequestContext requestContext,BitArray usedFields,RC_5404698ef74632f0bc59763509d95177 inParamSource,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("UpdateRequisitionApprovalLevel", "875ae9ed-3877-4b95-9236-49ac94000633.#UpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateRequisitionApprovalLevel", "875ae9ed-3877-4b95-9236-49ac94000633.#UpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_27b1469f497d364a764a1359956ef9adEntityRecord ssENRequisitionApprovalLevel = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(26,true);
}
string updateSet = "UPDATE " + ENRequisitionApprovalLevelEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@RequisitionApprovalId, "requisitionapprovalid") ?? "requisitionapprovalid") + " = @ssRequisitionApprovalId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@LevelNumber, "levelnumber") ?? "levelnumber") + " = @ssLevelNumber"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid") + " = @ssApplicationRoleId"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@EntraJobTitle, "entrajobtitle") ?? "entrajobtitle") + " = @ssEntraJobTitle"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@DepartmentId, "departmentid") ?? "departmentid") + " = @ssDepartmentId"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@ManagementId, "managementid") ?? "managementid") + " = @ssManagementId"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@SubdirectionId, "subdirectionid") ?? "subdirectionid") + " = @ssSubdirectionId"): parameters);
parameters = (usedFields[8] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@EntraRoleId, "entraroleid") ?? "entraroleid") + " = @ssEntraRoleId"): parameters);
parameters = (usedFields[9] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@EntraUserName, "entrausername") ?? "entrausername") + " = @ssEntraUserName"): parameters);
parameters = (usedFields[10] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@AssignedTo, "assignedto") ?? "assignedto") + " = @ssAssignedTo"): parameters);
parameters = (usedFields[11] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@NeedsContract, "needscontract") ?? "needscontract") + " = @ssNeedsContract"): parameters);
parameters = (usedFields[12] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@ApprovalStatusId, "approvalstatusid") ?? "approvalstatusid") + " = @ssApprovalStatusId"): parameters);
parameters = (usedFields[13] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@ApprovedBy, "approvedby") ?? "approvedby") + " = @ssApprovedBy"): parameters);
parameters = (usedFields[14] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@ApprovedOn, "approvedon") ?? "approvedon") + " = @ssApprovedOn"): parameters);
parameters = (usedFields[15] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@RequestToModifyBy, "requesttomodifyby") ?? "requesttomodifyby") + " = @ssRequestToModifyBy"): parameters);
parameters = (usedFields[16] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@RequestToModifyOn, "requesttomodifyon") ?? "requesttomodifyon") + " = @ssRequestToModifyOn"): parameters);
parameters = (usedFields[17] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@CanceledBy, "canceledby") ?? "canceledby") + " = @ssCanceledBy"): parameters);
parameters = (usedFields[18] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@CanceledOn_DEPREC, "canceledon_deprec") ?? "canceledon_deprec") + " = @ssCanceledOn_DEPREC"): parameters);
parameters = (usedFields[19] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@IsAccounting, "isaccounting") ?? "isaccounting") + " = @ssIsAccounting"): parameters);
parameters = (usedFields[20] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@IsStartAccounting, "isstartaccounting") ?? "isstartaccounting") + " = @ssIsStartAccounting"): parameters);
parameters = (usedFields[21] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@CanceledOn_, "canceledon_") ?? "canceledon_") + " = @ssCanceledOn_"): parameters);
parameters = (usedFields[22] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@ApproveAsAreaUsuaria, "approveasareausuaria") ?? "approveasareausuaria") + " = @ssApproveAsAreaUsuaria"): parameters);
parameters = (usedFields[23] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@IsMandatory, "ismandatory") ?? "ismandatory") + " = @ssIsMandatory"): parameters);
parameters = (usedFields[24] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@IsReassigned, "isreassigned") ?? "isreassigned") + " = @ssIsReassigned"): parameters);
parameters = (usedFields[25] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@IsSubstituteFor, "issubstitutefor") ?? "issubstitutefor") + " = @ssIsSubstituteFor"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENRequisitioApprovalLevel_ssd_RequisitionAprovalLevel";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@NeedsContract, "needscontract") ?? "needscontract") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalLevelAttributeKeys.@NeedsContract, "needscontract") ?? "needscontract") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENRequisitionApprovalLevel.ssRequisitionApprovalId==0L)) {
sqlCmd.CreateParameter("@ssRequisitionApprovalId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssRequisitionApprovalId", DbType.Int64, ssENRequisitionApprovalLevel.ssRequisitionApprovalId);

}
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssLevelNumber", DbType.Int32, ssENRequisitionApprovalLevel.ssLevelNumber);
}
if(usedFields[3]) {
if ((ssENRequisitionApprovalLevel.ssApplicationRoleId==0L)) {
sqlCmd.CreateParameter("@ssApplicationRoleId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssApplicationRoleId", DbType.Int64, ssENRequisitionApprovalLevel.ssApplicationRoleId);

}
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssEntraJobTitle", DbType.String, ssENRequisitionApprovalLevel.ssEntraJobTitle);
}
if(usedFields[5]) {
if ((ssENRequisitionApprovalLevel.ssDepartmentId==0L)) {
sqlCmd.CreateParameter("@ssDepartmentId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssDepartmentId", DbType.Int64, ssENRequisitionApprovalLevel.ssDepartmentId);

}
}
if(usedFields[6]) {
if ((ssENRequisitionApprovalLevel.ssManagementId==0L)) {
sqlCmd.CreateParameter("@ssManagementId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssManagementId", DbType.Int64, ssENRequisitionApprovalLevel.ssManagementId);

}
}
if(usedFields[7]) {
if ((ssENRequisitionApprovalLevel.ssSubdirectionId==0L)) {
sqlCmd.CreateParameter("@ssSubdirectionId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssSubdirectionId", DbType.Int64, ssENRequisitionApprovalLevel.ssSubdirectionId);

}
}
if(usedFields[8]) {
if ((ssENRequisitionApprovalLevel.ssEntraRoleId==0L)) {
sqlCmd.CreateParameter("@ssEntraRoleId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssEntraRoleId", DbType.Int64, ssENRequisitionApprovalLevel.ssEntraRoleId);

}
}
if(usedFields[9]) {
sqlCmd.CreateParameter("@ssEntraUserName", DbType.String, ssENRequisitionApprovalLevel.ssEntraUserName);
}
if(usedFields[10]) {
if ((ssENRequisitionApprovalLevel.ssAssignedTo=="")) {
sqlCmd.CreateParameter("@ssAssignedTo", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssAssignedTo", DbType.String, ssENRequisitionApprovalLevel.ssAssignedTo);

}
}
if(usedFields[11]) {
sqlCmd.CreateParameter("@ssNeedsContract", DbType.Boolean, ssENRequisitionApprovalLevel.ssNeedsContract);
}
if(usedFields[12]) {
if ((ssENRequisitionApprovalLevel.ssApprovalStatusId==0)) {
sqlCmd.CreateParameter("@ssApprovalStatusId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssApprovalStatusId", DbType.Int32, ssENRequisitionApprovalLevel.ssApprovalStatusId);

}
}
if(usedFields[13]) {
if ((ssENRequisitionApprovalLevel.ssApprovedBy=="")) {
sqlCmd.CreateParameter("@ssApprovedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssApprovedBy", DbType.String, ssENRequisitionApprovalLevel.ssApprovedBy);

}
}
if(usedFields[14]) {
sqlCmd.CreateParameter("@ssApprovedOn", DbType.DateTime, ssENRequisitionApprovalLevel.ssApprovedOn);
}
if(usedFields[15]) {
if ((ssENRequisitionApprovalLevel.ssRequestToModifyBy=="")) {
sqlCmd.CreateParameter("@ssRequestToModifyBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssRequestToModifyBy", DbType.String, ssENRequisitionApprovalLevel.ssRequestToModifyBy);

}
}
if(usedFields[16]) {
sqlCmd.CreateParameter("@ssRequestToModifyOn", DbType.DateTime, ssENRequisitionApprovalLevel.ssRequestToModifyOn);
}
if(usedFields[17]) {
if ((ssENRequisitionApprovalLevel.ssCanceledBy=="")) {
sqlCmd.CreateParameter("@ssCanceledBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCanceledBy", DbType.String, ssENRequisitionApprovalLevel.ssCanceledBy);

}
}
if(usedFields[18]) {
sqlCmd.CreateParameter("@ssCanceledOn_DEPREC", DbType.Boolean, ssENRequisitionApprovalLevel.ssCanceledOn_DEPREC);
}
if(usedFields[19]) {
sqlCmd.CreateParameter("@ssIsAccounting", DbType.Boolean, ssENRequisitionApprovalLevel.ssIsAccounting);
}
if(usedFields[20]) {
sqlCmd.CreateParameter("@ssIsStartAccounting", DbType.Boolean, ssENRequisitionApprovalLevel.ssIsStartAccounting);
}
if(usedFields[21]) {
sqlCmd.CreateParameter("@ssCanceledOn_", DbType.DateTime, ssENRequisitionApprovalLevel.ssCanceledOn_);
}
if(usedFields[22]) {
sqlCmd.CreateParameter("@ssApproveAsAreaUsuaria", DbType.Boolean, ssENRequisitionApprovalLevel.ssApproveAsAreaUsuaria);
}
if(usedFields[23]) {
sqlCmd.CreateParameter("@ssIsMandatory", DbType.Boolean, ssENRequisitionApprovalLevel.ssIsMandatory);
}
if(usedFields[24]) {
sqlCmd.CreateParameter("@ssIsReassigned", DbType.Boolean, ssENRequisitionApprovalLevel.ssIsReassigned);
}
if(usedFields[25]) {
if ((ssENRequisitionApprovalLevel.ssIsSubstituteFor=="")) {
sqlCmd.CreateParameter("@ssIsSubstituteFor", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssIsSubstituteFor", DbType.String, ssENRequisitionApprovalLevel.ssIsSubstituteFor);

}
}
sqlCmd.CreateParameter("@idparam_ssENRequisitioApprovalLevel_ssd_RequisitionAprovalLevel", DbType.Int64, ssENRequisitionApprovalLevel.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateRequisitionApprovalLevel", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("RequisitionApprovalLevel", ssENRequisitionApprovalLevel.ssId.ToString()); }}
}
return;
}

}
}
