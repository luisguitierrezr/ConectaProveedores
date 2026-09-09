using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateFolioApprovalLevel
/// </summary>

public static async Task<long> CreateFolioApprovalLevel(IRequestContext requestContext,RC_0be8bae4cc285c0288822b663818cb6c inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateFolioApprovalLevel", "5344fba0-3ba8-4da2-91bc-253eec573814.#CreateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateFolioApprovalLevel", "5344fba0-3ba8-4da2-91bc-253eec573814.#CreateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord ssENFolioApprovalLevel = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENFolioApprovalLevelEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@FolioApprovalId, "folioapprovalid") ?? "folioapprovalid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@LevelNumber, "levelnumber") ?? "levelnumber") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@EntraJobTitle, "entrajobtitle") ?? "entrajobtitle") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@EntraRoleId, "entraroleid") ?? "entraroleid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@DepartmentId, "departmentid") ?? "departmentid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@AssignedTo, "assignedto") ?? "assignedto") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@ApprovalStatusId, "approvalstatusid") ?? "approvalstatusid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@IsMandatory, "ismandatory") ?? "ismandatory") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@IsReassigned, "isreassigned") ?? "isreassigned") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@ApprovedBy, "approvedby") ?? "approvedby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@ApprovedOn, "approvedon") ?? "approvedon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@CanceledBy, "canceledby") ?? "canceledby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@CanceledOn, "canceledon") ?? "canceledon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@RejectedBy, "rejectedby") ?? "rejectedby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@RejectedOn, "rejectedon") ?? "rejectedon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@IsSubstituteFor, "issubstitutefor") ?? "issubstitutefor") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@RejectReason, "rejectreason") ?? "rejectreason") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@IsInvoiceApproval, "isinvoiceapproval") ?? "isinvoiceapproval") + "" +
" ) VALUES (" +
" @ssFolioApprovalId" +
", @ssLevelNumber" +
", @ssApplicationRoleId" +
", @ssEntraJobTitle" +
", @ssEntraRoleId" +
", @ssDepartmentId" +
", @ssAssignedTo" +
", @ssApprovalStatusId" +
", @ssIsMandatory" +
", @ssIsReassigned" +
", @ssApprovedBy" +
", @ssApprovedOn" +
", @ssCanceledBy" +
", @ssCanceledOn" +
", @ssRejectedBy" +
", @ssRejectedOn" +
", @ssIsSubstituteFor" +
", @ssRejectReason" +
", @ssIsInvoiceApproval" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENFolioApprovalLevel.ssFolioApprovalId==0L)) {
insertSqlCmd.CreateParameter("@ssFolioApprovalId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssFolioApprovalId", DbType.Int64, ssENFolioApprovalLevel.ssFolioApprovalId);

}
insertSqlCmd.CreateParameter("@ssLevelNumber", DbType.Int32, ssENFolioApprovalLevel.ssLevelNumber);
if ((ssENFolioApprovalLevel.ssApplicationRoleId==0L)) {
insertSqlCmd.CreateParameter("@ssApplicationRoleId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssApplicationRoleId", DbType.Int64, ssENFolioApprovalLevel.ssApplicationRoleId);

}
insertSqlCmd.CreateParameter("@ssEntraJobTitle", DbType.String, ssENFolioApprovalLevel.ssEntraJobTitle);
if ((ssENFolioApprovalLevel.ssEntraRoleId==0L)) {
insertSqlCmd.CreateParameter("@ssEntraRoleId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssEntraRoleId", DbType.Int64, ssENFolioApprovalLevel.ssEntraRoleId);

}
if ((ssENFolioApprovalLevel.ssDepartmentId==0L)) {
insertSqlCmd.CreateParameter("@ssDepartmentId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssDepartmentId", DbType.Int64, ssENFolioApprovalLevel.ssDepartmentId);

}
if ((ssENFolioApprovalLevel.ssAssignedTo=="")) {
insertSqlCmd.CreateParameter("@ssAssignedTo", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssAssignedTo", DbType.String, ssENFolioApprovalLevel.ssAssignedTo);

}
if ((ssENFolioApprovalLevel.ssApprovalStatusId==0)) {
insertSqlCmd.CreateParameter("@ssApprovalStatusId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssApprovalStatusId", DbType.Int32, ssENFolioApprovalLevel.ssApprovalStatusId);

}
insertSqlCmd.CreateParameter("@ssIsMandatory", DbType.Boolean, ssENFolioApprovalLevel.ssIsMandatory);
insertSqlCmd.CreateParameter("@ssIsReassigned", DbType.Boolean, ssENFolioApprovalLevel.ssIsReassigned);
if ((ssENFolioApprovalLevel.ssApprovedBy=="")) {
insertSqlCmd.CreateParameter("@ssApprovedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssApprovedBy", DbType.String, ssENFolioApprovalLevel.ssApprovedBy);

}
insertSqlCmd.CreateParameter("@ssApprovedOn", DbType.DateTime, ssENFolioApprovalLevel.ssApprovedOn);
if ((ssENFolioApprovalLevel.ssCanceledBy=="")) {
insertSqlCmd.CreateParameter("@ssCanceledBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCanceledBy", DbType.String, ssENFolioApprovalLevel.ssCanceledBy);

}
insertSqlCmd.CreateParameter("@ssCanceledOn", DbType.DateTime, ssENFolioApprovalLevel.ssCanceledOn);
if ((ssENFolioApprovalLevel.ssRejectedBy=="")) {
insertSqlCmd.CreateParameter("@ssRejectedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssRejectedBy", DbType.String, ssENFolioApprovalLevel.ssRejectedBy);

}
insertSqlCmd.CreateParameter("@ssRejectedOn", DbType.DateTime, ssENFolioApprovalLevel.ssRejectedOn);
if ((ssENFolioApprovalLevel.ssIsSubstituteFor=="")) {
insertSqlCmd.CreateParameter("@ssIsSubstituteFor", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssIsSubstituteFor", DbType.String, ssENFolioApprovalLevel.ssIsSubstituteFor);

}
insertSqlCmd.CreateParameter("@ssRejectReason", DbType.String, ssENFolioApprovalLevel.ssRejectReason);
insertSqlCmd.CreateParameter("@ssIsInvoiceApproval", DbType.Boolean, ssENFolioApprovalLevel.ssIsInvoiceApproval);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateFolioApprovalLevel", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateFolioApprovalLevel
/// </summary>

public static async Task<long> CreateOrUpdateFolioApprovalLevel(IRequestContext requestContext,BitArray usedFields,RC_0be8bae4cc285c0288822b663818cb6c inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateFolioApprovalLevel", "5344fba0-3ba8-4da2-91bc-253eec573814.#CreateOrUpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateFolioApprovalLevel", "5344fba0-3ba8-4da2-91bc-253eec573814.#CreateOrUpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord ssENFolioApprovalLevel = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(20,true);
}
string updateSet = "UPDATE " + ENFolioApprovalLevelEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@FolioApprovalId, "folioapprovalid") ?? "folioapprovalid") + " = @ssFolioApprovalId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@LevelNumber, "levelnumber") ?? "levelnumber") + " = @ssLevelNumber"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid") + " = @ssApplicationRoleId"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@EntraJobTitle, "entrajobtitle") ?? "entrajobtitle") + " = @ssEntraJobTitle"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@EntraRoleId, "entraroleid") ?? "entraroleid") + " = @ssEntraRoleId"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@DepartmentId, "departmentid") ?? "departmentid") + " = @ssDepartmentId"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@AssignedTo, "assignedto") ?? "assignedto") + " = @ssAssignedTo"): parameters);
parameters = (usedFields[8] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@ApprovalStatusId, "approvalstatusid") ?? "approvalstatusid") + " = @ssApprovalStatusId"): parameters);
parameters = (usedFields[9] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@IsMandatory, "ismandatory") ?? "ismandatory") + " = @ssIsMandatory"): parameters);
parameters = (usedFields[10] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@IsReassigned, "isreassigned") ?? "isreassigned") + " = @ssIsReassigned"): parameters);
parameters = (usedFields[11] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@ApprovedBy, "approvedby") ?? "approvedby") + " = @ssApprovedBy"): parameters);
parameters = (usedFields[12] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@ApprovedOn, "approvedon") ?? "approvedon") + " = @ssApprovedOn"): parameters);
parameters = (usedFields[13] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@CanceledBy, "canceledby") ?? "canceledby") + " = @ssCanceledBy"): parameters);
parameters = (usedFields[14] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@CanceledOn, "canceledon") ?? "canceledon") + " = @ssCanceledOn"): parameters);
parameters = (usedFields[15] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@RejectedBy, "rejectedby") ?? "rejectedby") + " = @ssRejectedBy"): parameters);
parameters = (usedFields[16] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@RejectedOn, "rejectedon") ?? "rejectedon") + " = @ssRejectedOn"): parameters);
parameters = (usedFields[17] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@IsSubstituteFor, "issubstitutefor") ?? "issubstitutefor") + " = @ssIsSubstituteFor"): parameters);
parameters = (usedFields[18] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@RejectReason, "rejectreason") ?? "rejectreason") + " = @ssRejectReason"): parameters);
parameters = (usedFields[19] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@IsInvoiceApproval, "isinvoiceapproval") ?? "isinvoiceapproval") + " = @ssIsInvoiceApproval"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENFolioApprovalLevel_ssId_FolioApprovalLevel";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@IsMandatory, "ismandatory") ?? "ismandatory") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@IsMandatory, "ismandatory") ?? "ismandatory") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENFolioApprovalLevel.ssFolioApprovalId==0L)) {
sqlCmd.CreateParameter("@ssFolioApprovalId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssFolioApprovalId", DbType.Int64, ssENFolioApprovalLevel.ssFolioApprovalId);

}
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssLevelNumber", DbType.Int32, ssENFolioApprovalLevel.ssLevelNumber);
}
if(usedFields[3]) {
if ((ssENFolioApprovalLevel.ssApplicationRoleId==0L)) {
sqlCmd.CreateParameter("@ssApplicationRoleId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssApplicationRoleId", DbType.Int64, ssENFolioApprovalLevel.ssApplicationRoleId);

}
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssEntraJobTitle", DbType.String, ssENFolioApprovalLevel.ssEntraJobTitle);
}
if(usedFields[5]) {
if ((ssENFolioApprovalLevel.ssEntraRoleId==0L)) {
sqlCmd.CreateParameter("@ssEntraRoleId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssEntraRoleId", DbType.Int64, ssENFolioApprovalLevel.ssEntraRoleId);

}
}
if(usedFields[6]) {
if ((ssENFolioApprovalLevel.ssDepartmentId==0L)) {
sqlCmd.CreateParameter("@ssDepartmentId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssDepartmentId", DbType.Int64, ssENFolioApprovalLevel.ssDepartmentId);

}
}
if(usedFields[7]) {
if ((ssENFolioApprovalLevel.ssAssignedTo=="")) {
sqlCmd.CreateParameter("@ssAssignedTo", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssAssignedTo", DbType.String, ssENFolioApprovalLevel.ssAssignedTo);

}
}
if(usedFields[8]) {
if ((ssENFolioApprovalLevel.ssApprovalStatusId==0)) {
sqlCmd.CreateParameter("@ssApprovalStatusId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssApprovalStatusId", DbType.Int32, ssENFolioApprovalLevel.ssApprovalStatusId);

}
}
if(usedFields[9]) {
sqlCmd.CreateParameter("@ssIsMandatory", DbType.Boolean, ssENFolioApprovalLevel.ssIsMandatory);
}
if(usedFields[10]) {
sqlCmd.CreateParameter("@ssIsReassigned", DbType.Boolean, ssENFolioApprovalLevel.ssIsReassigned);
}
if(usedFields[11]) {
if ((ssENFolioApprovalLevel.ssApprovedBy=="")) {
sqlCmd.CreateParameter("@ssApprovedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssApprovedBy", DbType.String, ssENFolioApprovalLevel.ssApprovedBy);

}
}
if(usedFields[12]) {
sqlCmd.CreateParameter("@ssApprovedOn", DbType.DateTime, ssENFolioApprovalLevel.ssApprovedOn);
}
if(usedFields[13]) {
if ((ssENFolioApprovalLevel.ssCanceledBy=="")) {
sqlCmd.CreateParameter("@ssCanceledBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCanceledBy", DbType.String, ssENFolioApprovalLevel.ssCanceledBy);

}
}
if(usedFields[14]) {
sqlCmd.CreateParameter("@ssCanceledOn", DbType.DateTime, ssENFolioApprovalLevel.ssCanceledOn);
}
if(usedFields[15]) {
if ((ssENFolioApprovalLevel.ssRejectedBy=="")) {
sqlCmd.CreateParameter("@ssRejectedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssRejectedBy", DbType.String, ssENFolioApprovalLevel.ssRejectedBy);

}
}
if(usedFields[16]) {
sqlCmd.CreateParameter("@ssRejectedOn", DbType.DateTime, ssENFolioApprovalLevel.ssRejectedOn);
}
if(usedFields[17]) {
if ((ssENFolioApprovalLevel.ssIsSubstituteFor=="")) {
sqlCmd.CreateParameter("@ssIsSubstituteFor", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssIsSubstituteFor", DbType.String, ssENFolioApprovalLevel.ssIsSubstituteFor);

}
}
if(usedFields[18]) {
sqlCmd.CreateParameter("@ssRejectReason", DbType.String, ssENFolioApprovalLevel.ssRejectReason);
}
if(usedFields[19]) {
sqlCmd.CreateParameter("@ssIsInvoiceApproval", DbType.Boolean, ssENFolioApprovalLevel.ssIsInvoiceApproval);
}
sqlCmd.CreateParameter("@idparam_ssENFolioApprovalLevel_ssId_FolioApprovalLevel", DbType.Int64, ssENFolioApprovalLevel.ssId);
int counter = 0;
if(ssENFolioApprovalLevel.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateFolioApprovalLevel (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENFolioApprovalLevelEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@FolioApprovalId, "folioapprovalid") ?? "folioapprovalid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@LevelNumber, "levelnumber") ?? "levelnumber") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@EntraJobTitle, "entrajobtitle") ?? "entrajobtitle") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@EntraRoleId, "entraroleid") ?? "entraroleid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@DepartmentId, "departmentid") ?? "departmentid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@AssignedTo, "assignedto") ?? "assignedto") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@ApprovalStatusId, "approvalstatusid") ?? "approvalstatusid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@IsMandatory, "ismandatory") ?? "ismandatory") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@IsReassigned, "isreassigned") ?? "isreassigned") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@ApprovedBy, "approvedby") ?? "approvedby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@ApprovedOn, "approvedon") ?? "approvedon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@CanceledBy, "canceledby") ?? "canceledby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@CanceledOn, "canceledon") ?? "canceledon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@RejectedBy, "rejectedby") ?? "rejectedby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@RejectedOn, "rejectedon") ?? "rejectedon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@IsSubstituteFor, "issubstitutefor") ?? "issubstitutefor") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@RejectReason, "rejectreason") ?? "rejectreason") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@IsInvoiceApproval, "isinvoiceapproval") ?? "isinvoiceapproval") + "" +
" ) VALUES (" +
" @ssFolioApprovalId" +
", @ssLevelNumber" +
", @ssApplicationRoleId" +
", @ssEntraJobTitle" +
", @ssEntraRoleId" +
", @ssDepartmentId" +
", @ssAssignedTo" +
", @ssApprovalStatusId" +
", @ssIsMandatory" +
", @ssIsReassigned" +
", @ssApprovedBy" +
", @ssApprovedOn" +
", @ssCanceledBy" +
", @ssCanceledOn" +
", @ssRejectedBy" +
", @ssRejectedOn" +
", @ssIsSubstituteFor" +
", @ssRejectReason" +
", @ssIsInvoiceApproval" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENFolioApprovalLevel.ssFolioApprovalId==0L)) {
insertSqlCmd.CreateParameter("@ssFolioApprovalId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssFolioApprovalId", DbType.Int64, ssENFolioApprovalLevel.ssFolioApprovalId);

}
insertSqlCmd.CreateParameter("@ssLevelNumber", DbType.Int32, ssENFolioApprovalLevel.ssLevelNumber);
if ((ssENFolioApprovalLevel.ssApplicationRoleId==0L)) {
insertSqlCmd.CreateParameter("@ssApplicationRoleId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssApplicationRoleId", DbType.Int64, ssENFolioApprovalLevel.ssApplicationRoleId);

}
insertSqlCmd.CreateParameter("@ssEntraJobTitle", DbType.String, ssENFolioApprovalLevel.ssEntraJobTitle);
if ((ssENFolioApprovalLevel.ssEntraRoleId==0L)) {
insertSqlCmd.CreateParameter("@ssEntraRoleId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssEntraRoleId", DbType.Int64, ssENFolioApprovalLevel.ssEntraRoleId);

}
if ((ssENFolioApprovalLevel.ssDepartmentId==0L)) {
insertSqlCmd.CreateParameter("@ssDepartmentId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssDepartmentId", DbType.Int64, ssENFolioApprovalLevel.ssDepartmentId);

}
if ((ssENFolioApprovalLevel.ssAssignedTo=="")) {
insertSqlCmd.CreateParameter("@ssAssignedTo", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssAssignedTo", DbType.String, ssENFolioApprovalLevel.ssAssignedTo);

}
if ((ssENFolioApprovalLevel.ssApprovalStatusId==0)) {
insertSqlCmd.CreateParameter("@ssApprovalStatusId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssApprovalStatusId", DbType.Int32, ssENFolioApprovalLevel.ssApprovalStatusId);

}
insertSqlCmd.CreateParameter("@ssIsMandatory", DbType.Boolean, ssENFolioApprovalLevel.ssIsMandatory);
insertSqlCmd.CreateParameter("@ssIsReassigned", DbType.Boolean, ssENFolioApprovalLevel.ssIsReassigned);
if ((ssENFolioApprovalLevel.ssApprovedBy=="")) {
insertSqlCmd.CreateParameter("@ssApprovedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssApprovedBy", DbType.String, ssENFolioApprovalLevel.ssApprovedBy);

}
insertSqlCmd.CreateParameter("@ssApprovedOn", DbType.DateTime, ssENFolioApprovalLevel.ssApprovedOn);
if ((ssENFolioApprovalLevel.ssCanceledBy=="")) {
insertSqlCmd.CreateParameter("@ssCanceledBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCanceledBy", DbType.String, ssENFolioApprovalLevel.ssCanceledBy);

}
insertSqlCmd.CreateParameter("@ssCanceledOn", DbType.DateTime, ssENFolioApprovalLevel.ssCanceledOn);
if ((ssENFolioApprovalLevel.ssRejectedBy=="")) {
insertSqlCmd.CreateParameter("@ssRejectedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssRejectedBy", DbType.String, ssENFolioApprovalLevel.ssRejectedBy);

}
insertSqlCmd.CreateParameter("@ssRejectedOn", DbType.DateTime, ssENFolioApprovalLevel.ssRejectedOn);
if ((ssENFolioApprovalLevel.ssIsSubstituteFor=="")) {
insertSqlCmd.CreateParameter("@ssIsSubstituteFor", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssIsSubstituteFor", DbType.String, ssENFolioApprovalLevel.ssIsSubstituteFor);

}
insertSqlCmd.CreateParameter("@ssRejectReason", DbType.String, ssENFolioApprovalLevel.ssRejectReason);
insertSqlCmd.CreateParameter("@ssIsInvoiceApproval", DbType.Boolean, ssENFolioApprovalLevel.ssIsInvoiceApproval);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateFolioApprovalLevel", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENFolioApprovalLevel.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeFolioApprovalLevel
/// </summary>

public static async Task CreateOrUpdateSomeFolioApprovalLevel(IRequestContext requestContext,RL_ecaf6a267327a661b83be973ba99d46b inParamSourceList,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateSomeFolioApprovalLevel", "5344fba0-3ba8-4da2-91bc-253eec573814.#CreateOrUpdateAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeFolioApprovalLevel", "5344fba0-3ba8-4da2-91bc-253eec573814.#CreateOrUpdateAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
string entityTableName = ENFolioApprovalLevelEntity.LocalViewName(null);
string insertSql = "INSERT INTO " + entityTableName + " (" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@FolioApprovalId, "folioapprovalid") ?? "folioapprovalid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@LevelNumber, "levelnumber") ?? "levelnumber") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@EntraJobTitle, "entrajobtitle") ?? "entrajobtitle") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@EntraRoleId, "entraroleid") ?? "entraroleid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@DepartmentId, "departmentid") ?? "departmentid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@AssignedTo, "assignedto") ?? "assignedto") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@ApprovalStatusId, "approvalstatusid") ?? "approvalstatusid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@IsMandatory, "ismandatory") ?? "ismandatory") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@IsReassigned, "isreassigned") ?? "isreassigned") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@ApprovedBy, "approvedby") ?? "approvedby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@ApprovedOn, "approvedon") ?? "approvedon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@CanceledBy, "canceledby") ?? "canceledby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@CanceledOn, "canceledon") ?? "canceledon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@RejectedBy, "rejectedby") ?? "rejectedby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@RejectedOn, "rejectedon") ?? "rejectedon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@IsSubstituteFor, "issubstitutefor") ?? "issubstitutefor") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@RejectReason, "rejectreason") ?? "rejectreason") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@IsInvoiceApproval, "isinvoiceapproval") ?? "isinvoiceapproval") + ") VALUES ( unnest(@ssFolioApprovalId),  unnest(@ssLevelNumber),  unnest(@ssApplicationRoleId),  unnest(@ssEntraJobTitle),  unnest(@ssEntraRoleId),  unnest(@ssDepartmentId),  unnest(@ssAssignedTo),  unnest(@ssApprovalStatusId),  unnest(@ssIsMandatory),  unnest(@ssIsReassigned),  unnest(@ssApprovedBy),  unnest(@ssApprovedOn),  unnest(@ssCanceledBy),  unnest(@ssCanceledOn),  unnest(@ssRejectedBy),  unnest(@ssRejectedOn),  unnest(@ssIsSubstituteFor),  unnest(@ssRejectReason),  unnest(@ssIsInvoiceApproval)) ";
insertSql += "";

string updateSql = "UPDATE " + entityTableName + " SET " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@FolioApprovalId, "folioapprovalid") ?? "folioapprovalid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@FolioApprovalId, "folioapprovalid") ?? "folioapprovalid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@LevelNumber, "levelnumber") ?? "levelnumber") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@LevelNumber, "levelnumber") ?? "levelnumber") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@EntraJobTitle, "entrajobtitle") ?? "entrajobtitle") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@EntraJobTitle, "entrajobtitle") ?? "entrajobtitle") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@EntraRoleId, "entraroleid") ?? "entraroleid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@EntraRoleId, "entraroleid") ?? "entraroleid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@DepartmentId, "departmentid") ?? "departmentid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@DepartmentId, "departmentid") ?? "departmentid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@AssignedTo, "assignedto") ?? "assignedto") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@AssignedTo, "assignedto") ?? "assignedto") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@ApprovalStatusId, "approvalstatusid") ?? "approvalstatusid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@ApprovalStatusId, "approvalstatusid") ?? "approvalstatusid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@IsMandatory, "ismandatory") ?? "ismandatory") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@IsMandatory, "ismandatory") ?? "ismandatory") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@IsReassigned, "isreassigned") ?? "isreassigned") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@IsReassigned, "isreassigned") ?? "isreassigned") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@ApprovedBy, "approvedby") ?? "approvedby") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@ApprovedBy, "approvedby") ?? "approvedby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@ApprovedOn, "approvedon") ?? "approvedon") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@ApprovedOn, "approvedon") ?? "approvedon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@CanceledBy, "canceledby") ?? "canceledby") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@CanceledBy, "canceledby") ?? "canceledby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@CanceledOn, "canceledon") ?? "canceledon") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@CanceledOn, "canceledon") ?? "canceledon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@RejectedBy, "rejectedby") ?? "rejectedby") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@RejectedBy, "rejectedby") ?? "rejectedby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@RejectedOn, "rejectedon") ?? "rejectedon") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@RejectedOn, "rejectedon") ?? "rejectedon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@IsSubstituteFor, "issubstitutefor") ?? "issubstitutefor") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@IsSubstituteFor, "issubstitutefor") ?? "issubstitutefor") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@RejectReason, "rejectreason") ?? "rejectreason") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@RejectReason, "rejectreason") ?? "rejectreason") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@IsInvoiceApproval, "isinvoiceapproval") ?? "isinvoiceapproval") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@IsInvoiceApproval, "isinvoiceapproval") ?? "isinvoiceapproval") + " from ( select  unnest(@ssId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@Id, "id") ?? "id") + ",  unnest(@ssFolioApprovalId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@FolioApprovalId, "folioapprovalid") ?? "folioapprovalid") + ",  unnest(@ssLevelNumber) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@LevelNumber, "levelnumber") ?? "levelnumber") + ",  unnest(@ssApplicationRoleId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid") + ",  unnest(@ssEntraJobTitle) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@EntraJobTitle, "entrajobtitle") ?? "entrajobtitle") + ",  unnest(@ssEntraRoleId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@EntraRoleId, "entraroleid") ?? "entraroleid") + ",  unnest(@ssDepartmentId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@DepartmentId, "departmentid") ?? "departmentid") + ",  unnest(@ssAssignedTo) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@AssignedTo, "assignedto") ?? "assignedto") + ",  unnest(@ssApprovalStatusId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@ApprovalStatusId, "approvalstatusid") ?? "approvalstatusid") + ",  unnest(@ssIsMandatory) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@IsMandatory, "ismandatory") ?? "ismandatory") + ",  unnest(@ssIsReassigned) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@IsReassigned, "isreassigned") ?? "isreassigned") + ",  unnest(@ssApprovedBy) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@ApprovedBy, "approvedby") ?? "approvedby") + ",  unnest(@ssApprovedOn) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@ApprovedOn, "approvedon") ?? "approvedon") + ",  unnest(@ssCanceledBy) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@CanceledBy, "canceledby") ?? "canceledby") + ",  unnest(@ssCanceledOn) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@CanceledOn, "canceledon") ?? "canceledon") + ",  unnest(@ssRejectedBy) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@RejectedBy, "rejectedby") ?? "rejectedby") + ",  unnest(@ssRejectedOn) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@RejectedOn, "rejectedon") ?? "rejectedon") + ",  unnest(@ssIsSubstituteFor) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@IsSubstituteFor, "issubstitutefor") ?? "issubstitutefor") + ",  unnest(@ssRejectReason) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@RejectReason, "rejectreason") ?? "rejectreason") + ",  unnest(@ssIsInvoiceApproval) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@IsInvoiceApproval, "isinvoiceapproval") ?? "isinvoiceapproval") + " ) as updateTable where " + entityTableName + "." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@Id, "id") ?? "id") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@Id, "id") ?? "id") + " ";
updateSql += "";

List<object> insertFolioApprovalIdList = new List<object>();
List<int> insertLevelNumberList = new List<int>();
List<object> insertApplicationRoleIdList = new List<object>();
List<string> insertEntraJobTitleList = new List<string>();
List<object> insertEntraRoleIdList = new List<object>();
List<object> insertDepartmentIdList = new List<object>();
List<object> insertAssignedToList = new List<object>();
List<object> insertApprovalStatusIdList = new List<object>();
List<bool> insertIsMandatoryList = new List<bool>();
List<bool> insertIsReassignedList = new List<bool>();
List<object> insertApprovedByList = new List<object>();
List<DateTime> insertApprovedOnList = new List<DateTime>();
List<object> insertCanceledByList = new List<object>();
List<DateTime> insertCanceledOnList = new List<DateTime>();
List<object> insertRejectedByList = new List<object>();
List<DateTime> insertRejectedOnList = new List<DateTime>();
List<object> insertIsSubstituteForList = new List<object>();
List<string> insertRejectReasonList = new List<string>();
List<bool> insertIsInvoiceApprovalList = new List<bool>();

List<long> updateIdList = new List<long>();
List<object> updateFolioApprovalIdList = new List<object>();
List<int> updateLevelNumberList = new List<int>();
List<object> updateApplicationRoleIdList = new List<object>();
List<string> updateEntraJobTitleList = new List<string>();
List<object> updateEntraRoleIdList = new List<object>();
List<object> updateDepartmentIdList = new List<object>();
List<object> updateAssignedToList = new List<object>();
List<object> updateApprovalStatusIdList = new List<object>();
List<bool> updateIsMandatoryList = new List<bool>();
List<bool> updateIsReassignedList = new List<bool>();
List<object> updateApprovedByList = new List<object>();
List<DateTime> updateApprovedOnList = new List<DateTime>();
List<object> updateCanceledByList = new List<object>();
List<DateTime> updateCanceledOnList = new List<DateTime>();
List<object> updateRejectedByList = new List<object>();
List<DateTime> updateRejectedOnList = new List<DateTime>();
List<object> updateIsSubstituteForList = new List<object>();
List<string> updateRejectReasonList = new List<string>();
List<bool> updateIsInvoiceApprovalList = new List<bool>();

var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_0be8bae4cc285c0288822b663818cb6c)inParamSourceList.Current).ssENFolioApprovalLevel;
if (record.ssId != 0L) {
updateIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
if ((record.ssFolioApprovalId==0L)) {
updateFolioApprovalIdList.Add(null);
} else {
updateFolioApprovalIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssFolioApprovalId));
}
updateLevelNumberList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssLevelNumber));
if ((record.ssApplicationRoleId==0L)) {
updateApplicationRoleIdList.Add(null);
} else {
updateApplicationRoleIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssApplicationRoleId));
}
updateEntraJobTitleList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssEntraJobTitle));
if ((record.ssEntraRoleId==0L)) {
updateEntraRoleIdList.Add(null);
} else {
updateEntraRoleIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssEntraRoleId));
}
if ((record.ssDepartmentId==0L)) {
updateDepartmentIdList.Add(null);
} else {
updateDepartmentIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssDepartmentId));
}
if ((record.ssAssignedTo=="")) {
updateAssignedToList.Add(null);
} else {
updateAssignedToList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssAssignedTo));
}
if ((record.ssApprovalStatusId==0)) {
updateApprovalStatusIdList.Add(null);
} else {
updateApprovalStatusIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssApprovalStatusId));
}
updateIsMandatoryList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsMandatory));
updateIsReassignedList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsReassigned));
if ((record.ssApprovedBy=="")) {
updateApprovedByList.Add(null);
} else {
updateApprovedByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssApprovedBy));
}
updateApprovedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssApprovedOn));
if ((record.ssCanceledBy=="")) {
updateCanceledByList.Add(null);
} else {
updateCanceledByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssCanceledBy));
}
updateCanceledOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssCanceledOn));
if ((record.ssRejectedBy=="")) {
updateRejectedByList.Add(null);
} else {
updateRejectedByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssRejectedBy));
}
updateRejectedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssRejectedOn));
if ((record.ssIsSubstituteFor=="")) {
updateIsSubstituteForList.Add(null);
} else {
updateIsSubstituteForList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssIsSubstituteFor));
}
updateRejectReasonList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssRejectReason));
updateIsInvoiceApprovalList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsInvoiceApproval));
} else {
if ((record.ssFolioApprovalId==0L)) {
insertFolioApprovalIdList.Add(null);
} else {
insertFolioApprovalIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssFolioApprovalId));
}
insertLevelNumberList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssLevelNumber));
if ((record.ssApplicationRoleId==0L)) {
insertApplicationRoleIdList.Add(null);
} else {
insertApplicationRoleIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssApplicationRoleId));
}
insertEntraJobTitleList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssEntraJobTitle));
if ((record.ssEntraRoleId==0L)) {
insertEntraRoleIdList.Add(null);
} else {
insertEntraRoleIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssEntraRoleId));
}
if ((record.ssDepartmentId==0L)) {
insertDepartmentIdList.Add(null);
} else {
insertDepartmentIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssDepartmentId));
}
if ((record.ssAssignedTo=="")) {
insertAssignedToList.Add(null);
} else {
insertAssignedToList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssAssignedTo));
}
if ((record.ssApprovalStatusId==0)) {
insertApprovalStatusIdList.Add(null);
} else {
insertApprovalStatusIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssApprovalStatusId));
}
insertIsMandatoryList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsMandatory));
insertIsReassignedList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsReassigned));
if ((record.ssApprovedBy=="")) {
insertApprovedByList.Add(null);
} else {
insertApprovedByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssApprovedBy));
}
insertApprovedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssApprovedOn));
if ((record.ssCanceledBy=="")) {
insertCanceledByList.Add(null);
} else {
insertCanceledByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssCanceledBy));
}
insertCanceledOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssCanceledOn));
if ((record.ssRejectedBy=="")) {
insertRejectedByList.Add(null);
} else {
insertRejectedByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssRejectedBy));
}
insertRejectedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssRejectedOn));
if ((record.ssIsSubstituteFor=="")) {
insertIsSubstituteForList.Add(null);
} else {
insertIsSubstituteForList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssIsSubstituteFor));
}
insertRejectReasonList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssRejectReason));
insertIsInvoiceApprovalList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsInvoiceApproval));
}
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertFolioApprovalIdList.IsEmpty() || !insertLevelNumberList.IsEmpty() || !insertApplicationRoleIdList.IsEmpty() || !insertEntraJobTitleList.IsEmpty() || !insertEntraRoleIdList.IsEmpty() || !insertDepartmentIdList.IsEmpty() || !insertAssignedToList.IsEmpty() || !insertApprovalStatusIdList.IsEmpty() || !insertIsMandatoryList.IsEmpty() || !insertIsReassignedList.IsEmpty() || !insertApprovedByList.IsEmpty() || !insertApprovedOnList.IsEmpty() || !insertCanceledByList.IsEmpty() || !insertCanceledOnList.IsEmpty() || !insertRejectedByList.IsEmpty() || !insertRejectedOnList.IsEmpty() || !insertIsSubstituteForList.IsEmpty() || !insertRejectReasonList.IsEmpty() || !insertIsInvoiceApprovalList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssFolioApprovalId",DbType.Int64,insertFolioApprovalIdList);
executionService.CreateParameter(insertSqlCmd,"@ssLevelNumber",DbType.Int32,insertLevelNumberList);
executionService.CreateParameter(insertSqlCmd,"@ssApplicationRoleId",DbType.Int64,insertApplicationRoleIdList);
executionService.CreateParameter(insertSqlCmd,"@ssEntraJobTitle",DbType.String,insertEntraJobTitleList);
executionService.CreateParameter(insertSqlCmd,"@ssEntraRoleId",DbType.Int64,insertEntraRoleIdList);
executionService.CreateParameter(insertSqlCmd,"@ssDepartmentId",DbType.Int64,insertDepartmentIdList);
executionService.CreateParameter(insertSqlCmd,"@ssAssignedTo",DbType.String,insertAssignedToList);
executionService.CreateParameter(insertSqlCmd,"@ssApprovalStatusId",DbType.Int32,insertApprovalStatusIdList);
executionService.CreateParameter(insertSqlCmd,"@ssIsMandatory",DbType.Boolean,insertIsMandatoryList);
executionService.CreateParameter(insertSqlCmd,"@ssIsReassigned",DbType.Boolean,insertIsReassignedList);
executionService.CreateParameter(insertSqlCmd,"@ssApprovedBy",DbType.String,insertApprovedByList);
executionService.CreateParameter(insertSqlCmd,"@ssApprovedOn",DbType.DateTime,insertApprovedOnList);
executionService.CreateParameter(insertSqlCmd,"@ssCanceledBy",DbType.String,insertCanceledByList);
executionService.CreateParameter(insertSqlCmd,"@ssCanceledOn",DbType.DateTime,insertCanceledOnList);
executionService.CreateParameter(insertSqlCmd,"@ssRejectedBy",DbType.String,insertRejectedByList);
executionService.CreateParameter(insertSqlCmd,"@ssRejectedOn",DbType.DateTime,insertRejectedOnList);
executionService.CreateParameter(insertSqlCmd,"@ssIsSubstituteFor",DbType.String,insertIsSubstituteForList);
executionService.CreateParameter(insertSqlCmd,"@ssRejectReason",DbType.String,insertRejectReasonList);
executionService.CreateParameter(insertSqlCmd,"@ssIsInvoiceApproval",DbType.Boolean,insertIsInvoiceApprovalList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeFolioApprovalLevel (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
if(!updateFolioApprovalIdList.IsEmpty() || !updateLevelNumberList.IsEmpty() || !updateApplicationRoleIdList.IsEmpty() || !updateEntraJobTitleList.IsEmpty() || !updateEntraRoleIdList.IsEmpty() || !updateDepartmentIdList.IsEmpty() || !updateAssignedToList.IsEmpty() || !updateApprovalStatusIdList.IsEmpty() || !updateIsMandatoryList.IsEmpty() || !updateIsReassignedList.IsEmpty() || !updateApprovedByList.IsEmpty() || !updateApprovedOnList.IsEmpty() || !updateCanceledByList.IsEmpty() || !updateCanceledOnList.IsEmpty() || !updateRejectedByList.IsEmpty() || !updateRejectedOnList.IsEmpty() || !updateIsSubstituteForList.IsEmpty() || !updateRejectReasonList.IsEmpty() || !updateIsInvoiceApprovalList.IsEmpty()){
await using(var updateSqlCmd = trans.CreateCommand(updateSql)){
executionService.CreateParameter(updateSqlCmd,"@ssId",DbType.Int64,updateIdList);
executionService.CreateParameter(updateSqlCmd,"@ssFolioApprovalId",DbType.Int64,updateFolioApprovalIdList);
executionService.CreateParameter(updateSqlCmd,"@ssLevelNumber",DbType.Int32,updateLevelNumberList);
executionService.CreateParameter(updateSqlCmd,"@ssApplicationRoleId",DbType.Int64,updateApplicationRoleIdList);
executionService.CreateParameter(updateSqlCmd,"@ssEntraJobTitle",DbType.String,updateEntraJobTitleList);
executionService.CreateParameter(updateSqlCmd,"@ssEntraRoleId",DbType.Int64,updateEntraRoleIdList);
executionService.CreateParameter(updateSqlCmd,"@ssDepartmentId",DbType.Int64,updateDepartmentIdList);
executionService.CreateParameter(updateSqlCmd,"@ssAssignedTo",DbType.String,updateAssignedToList);
executionService.CreateParameter(updateSqlCmd,"@ssApprovalStatusId",DbType.Int32,updateApprovalStatusIdList);
executionService.CreateParameter(updateSqlCmd,"@ssIsMandatory",DbType.Boolean,updateIsMandatoryList);
executionService.CreateParameter(updateSqlCmd,"@ssIsReassigned",DbType.Boolean,updateIsReassignedList);
executionService.CreateParameter(updateSqlCmd,"@ssApprovedBy",DbType.String,updateApprovedByList);
executionService.CreateParameter(updateSqlCmd,"@ssApprovedOn",DbType.DateTime,updateApprovedOnList);
executionService.CreateParameter(updateSqlCmd,"@ssCanceledBy",DbType.String,updateCanceledByList);
executionService.CreateParameter(updateSqlCmd,"@ssCanceledOn",DbType.DateTime,updateCanceledOnList);
executionService.CreateParameter(updateSqlCmd,"@ssRejectedBy",DbType.String,updateRejectedByList);
executionService.CreateParameter(updateSqlCmd,"@ssRejectedOn",DbType.DateTime,updateRejectedOnList);
executionService.CreateParameter(updateSqlCmd,"@ssIsSubstituteFor",DbType.String,updateIsSubstituteForList);
executionService.CreateParameter(updateSqlCmd,"@ssRejectReason",DbType.String,updateRejectReasonList);
executionService.CreateParameter(updateSqlCmd,"@ssIsInvoiceApproval",DbType.Boolean,updateIsInvoiceApprovalList);
await updateSqlCmd.PrepareAsync(cancellationToken);
await updateSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeFolioApprovalLevel (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(updateSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteFolioApprovalLevel
/// </summary>

public static async Task DeleteFolioApprovalLevel(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteFolioApprovalLevel", "5344fba0-3ba8-4da2-91bc-253eec573814.#DeleteEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteFolioApprovalLevel", "5344fba0-3ba8-4da2-91bc-253eec573814.#DeleteEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENFolioApprovalLevelEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteFolioApprovalLevel", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllFolioApprovalLevel
/// </summary>

public static async Task DeleteAllFolioApprovalLevel(IRequestContext requestContext,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteAllFolioApprovalLevel", "5344fba0-3ba8-4da2-91bc-253eec573814.#DeleteAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllFolioApprovalLevel", "5344fba0-3ba8-4da2-91bc-253eec573814.#DeleteAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENFolioApprovalLevelEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteFolioApprovalLevel", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetFolioApprovalLevel
/// </summary>

public static async Task<RC_0be8bae4cc285c0288822b663818cb6c> GetFolioApprovalLevel(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_0be8bae4cc285c0288822b663818cb6c outParamRecord = default;
outParamRecord = new RC_0be8bae4cc285c0288822b663818cb6c();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetFolioApprovalLevel", "5344fba0-3ba8-4da2-91bc-253eec573814.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetFolioApprovalLevel", "5344fba0-3ba8-4da2-91bc-253eec573814.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@FolioApprovalId, "folioapprovalid") ?? "folioapprovalid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@LevelNumber, "levelnumber") ?? "levelnumber", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@EntraJobTitle, "entrajobtitle") ?? "entrajobtitle", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@EntraRoleId, "entraroleid") ?? "entraroleid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@DepartmentId, "departmentid") ?? "departmentid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@AssignedTo, "assignedto") ?? "assignedto", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@ApprovalStatusId, "approvalstatusid") ?? "approvalstatusid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@IsMandatory, "ismandatory") ?? "ismandatory", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@IsReassigned, "isreassigned") ?? "isreassigned", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@ApprovedBy, "approvedby") ?? "approvedby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@ApprovedOn, "approvedon") ?? "approvedon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@CanceledBy, "canceledby") ?? "canceledby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@CanceledOn, "canceledon") ?? "canceledon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@RejectedBy, "rejectedby") ?? "rejectedby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@RejectedOn, "rejectedon") ?? "rejectedon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@IsSubstituteFor, "issubstitutefor") ?? "issubstitutefor", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@RejectReason, "rejectreason") ?? "rejectreason", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@IsInvoiceApproval, "isinvoiceapproval") ?? "isinvoiceapproval", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
" FROM " + ENFolioApprovalLevelEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetFolioApprovalLevel", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(20,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENFolioApprovalLevelEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetFolioApprovalLevelForUpdate
/// </summary>

public static async Task<RC_0be8bae4cc285c0288822b663818cb6c> GetFolioApprovalLevelForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_0be8bae4cc285c0288822b663818cb6c outParamRecord = default;
outParamRecord = new RC_0be8bae4cc285c0288822b663818cb6c();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetFolioApprovalLevelForUpdate", "5344fba0-3ba8-4da2-91bc-253eec573814.#GetEntityForUpdate");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetFolioApprovalLevelForUpdate", "5344fba0-3ba8-4da2-91bc-253eec573814.#GetEntityForUpdate", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@FolioApprovalId, "folioapprovalid") ?? "folioapprovalid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@LevelNumber, "levelnumber") ?? "levelnumber", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@EntraJobTitle, "entrajobtitle") ?? "entrajobtitle", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@EntraRoleId, "entraroleid") ?? "entraroleid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@DepartmentId, "departmentid") ?? "departmentid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@AssignedTo, "assignedto") ?? "assignedto", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@ApprovalStatusId, "approvalstatusid") ?? "approvalstatusid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@IsMandatory, "ismandatory") ?? "ismandatory", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@IsReassigned, "isreassigned") ?? "isreassigned", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@ApprovedBy, "approvedby") ?? "approvedby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@ApprovedOn, "approvedon") ?? "approvedon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@CanceledBy, "canceledby") ?? "canceledby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@CanceledOn, "canceledon") ?? "canceledon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@RejectedBy, "rejectedby") ?? "rejectedby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@RejectedOn, "rejectedon") ?? "rejectedon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@IsSubstituteFor, "issubstitutefor") ?? "issubstitutefor", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@RejectReason, "rejectreason") ?? "rejectreason", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@IsInvoiceApproval, "isinvoiceapproval") ?? "isinvoiceapproval", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
" FROM " + ENFolioApprovalLevelEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@Id, "id") ?? "id") + " = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetFolioApprovalLevelForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(20,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENFolioApprovalLevelEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateFolioApprovalLevel
/// </summary>

public static async Task UpdateFolioApprovalLevel(IRequestContext requestContext,BitArray usedFields,RC_0be8bae4cc285c0288822b663818cb6c inParamSource,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("UpdateFolioApprovalLevel", "5344fba0-3ba8-4da2-91bc-253eec573814.#UpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateFolioApprovalLevel", "5344fba0-3ba8-4da2-91bc-253eec573814.#UpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord ssENFolioApprovalLevel = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(20,true);
}
string updateSet = "UPDATE " + ENFolioApprovalLevelEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@FolioApprovalId, "folioapprovalid") ?? "folioapprovalid") + " = @ssFolioApprovalId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@LevelNumber, "levelnumber") ?? "levelnumber") + " = @ssLevelNumber"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid") + " = @ssApplicationRoleId"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@EntraJobTitle, "entrajobtitle") ?? "entrajobtitle") + " = @ssEntraJobTitle"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@EntraRoleId, "entraroleid") ?? "entraroleid") + " = @ssEntraRoleId"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@DepartmentId, "departmentid") ?? "departmentid") + " = @ssDepartmentId"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@AssignedTo, "assignedto") ?? "assignedto") + " = @ssAssignedTo"): parameters);
parameters = (usedFields[8] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@ApprovalStatusId, "approvalstatusid") ?? "approvalstatusid") + " = @ssApprovalStatusId"): parameters);
parameters = (usedFields[9] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@IsMandatory, "ismandatory") ?? "ismandatory") + " = @ssIsMandatory"): parameters);
parameters = (usedFields[10] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@IsReassigned, "isreassigned") ?? "isreassigned") + " = @ssIsReassigned"): parameters);
parameters = (usedFields[11] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@ApprovedBy, "approvedby") ?? "approvedby") + " = @ssApprovedBy"): parameters);
parameters = (usedFields[12] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@ApprovedOn, "approvedon") ?? "approvedon") + " = @ssApprovedOn"): parameters);
parameters = (usedFields[13] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@CanceledBy, "canceledby") ?? "canceledby") + " = @ssCanceledBy"): parameters);
parameters = (usedFields[14] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@CanceledOn, "canceledon") ?? "canceledon") + " = @ssCanceledOn"): parameters);
parameters = (usedFields[15] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@RejectedBy, "rejectedby") ?? "rejectedby") + " = @ssRejectedBy"): parameters);
parameters = (usedFields[16] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@RejectedOn, "rejectedon") ?? "rejectedon") + " = @ssRejectedOn"): parameters);
parameters = (usedFields[17] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@IsSubstituteFor, "issubstitutefor") ?? "issubstitutefor") + " = @ssIsSubstituteFor"): parameters);
parameters = (usedFields[18] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@RejectReason, "rejectreason") ?? "rejectreason") + " = @ssRejectReason"): parameters);
parameters = (usedFields[19] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@IsInvoiceApproval, "isinvoiceapproval") ?? "isinvoiceapproval") + " = @ssIsInvoiceApproval"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENFolioApprovalLevel_ssId_FolioApprovalLevel";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@IsMandatory, "ismandatory") ?? "ismandatory") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@IsMandatory, "ismandatory") ?? "ismandatory") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENFolioApprovalLevel.ssFolioApprovalId==0L)) {
sqlCmd.CreateParameter("@ssFolioApprovalId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssFolioApprovalId", DbType.Int64, ssENFolioApprovalLevel.ssFolioApprovalId);

}
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssLevelNumber", DbType.Int32, ssENFolioApprovalLevel.ssLevelNumber);
}
if(usedFields[3]) {
if ((ssENFolioApprovalLevel.ssApplicationRoleId==0L)) {
sqlCmd.CreateParameter("@ssApplicationRoleId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssApplicationRoleId", DbType.Int64, ssENFolioApprovalLevel.ssApplicationRoleId);

}
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssEntraJobTitle", DbType.String, ssENFolioApprovalLevel.ssEntraJobTitle);
}
if(usedFields[5]) {
if ((ssENFolioApprovalLevel.ssEntraRoleId==0L)) {
sqlCmd.CreateParameter("@ssEntraRoleId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssEntraRoleId", DbType.Int64, ssENFolioApprovalLevel.ssEntraRoleId);

}
}
if(usedFields[6]) {
if ((ssENFolioApprovalLevel.ssDepartmentId==0L)) {
sqlCmd.CreateParameter("@ssDepartmentId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssDepartmentId", DbType.Int64, ssENFolioApprovalLevel.ssDepartmentId);

}
}
if(usedFields[7]) {
if ((ssENFolioApprovalLevel.ssAssignedTo=="")) {
sqlCmd.CreateParameter("@ssAssignedTo", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssAssignedTo", DbType.String, ssENFolioApprovalLevel.ssAssignedTo);

}
}
if(usedFields[8]) {
if ((ssENFolioApprovalLevel.ssApprovalStatusId==0)) {
sqlCmd.CreateParameter("@ssApprovalStatusId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssApprovalStatusId", DbType.Int32, ssENFolioApprovalLevel.ssApprovalStatusId);

}
}
if(usedFields[9]) {
sqlCmd.CreateParameter("@ssIsMandatory", DbType.Boolean, ssENFolioApprovalLevel.ssIsMandatory);
}
if(usedFields[10]) {
sqlCmd.CreateParameter("@ssIsReassigned", DbType.Boolean, ssENFolioApprovalLevel.ssIsReassigned);
}
if(usedFields[11]) {
if ((ssENFolioApprovalLevel.ssApprovedBy=="")) {
sqlCmd.CreateParameter("@ssApprovedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssApprovedBy", DbType.String, ssENFolioApprovalLevel.ssApprovedBy);

}
}
if(usedFields[12]) {
sqlCmd.CreateParameter("@ssApprovedOn", DbType.DateTime, ssENFolioApprovalLevel.ssApprovedOn);
}
if(usedFields[13]) {
if ((ssENFolioApprovalLevel.ssCanceledBy=="")) {
sqlCmd.CreateParameter("@ssCanceledBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCanceledBy", DbType.String, ssENFolioApprovalLevel.ssCanceledBy);

}
}
if(usedFields[14]) {
sqlCmd.CreateParameter("@ssCanceledOn", DbType.DateTime, ssENFolioApprovalLevel.ssCanceledOn);
}
if(usedFields[15]) {
if ((ssENFolioApprovalLevel.ssRejectedBy=="")) {
sqlCmd.CreateParameter("@ssRejectedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssRejectedBy", DbType.String, ssENFolioApprovalLevel.ssRejectedBy);

}
}
if(usedFields[16]) {
sqlCmd.CreateParameter("@ssRejectedOn", DbType.DateTime, ssENFolioApprovalLevel.ssRejectedOn);
}
if(usedFields[17]) {
if ((ssENFolioApprovalLevel.ssIsSubstituteFor=="")) {
sqlCmd.CreateParameter("@ssIsSubstituteFor", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssIsSubstituteFor", DbType.String, ssENFolioApprovalLevel.ssIsSubstituteFor);

}
}
if(usedFields[18]) {
sqlCmd.CreateParameter("@ssRejectReason", DbType.String, ssENFolioApprovalLevel.ssRejectReason);
}
if(usedFields[19]) {
sqlCmd.CreateParameter("@ssIsInvoiceApproval", DbType.Boolean, ssENFolioApprovalLevel.ssIsInvoiceApproval);
}
sqlCmd.CreateParameter("@idparam_ssENFolioApprovalLevel_ssId_FolioApprovalLevel", DbType.Int64, ssENFolioApprovalLevel.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateFolioApprovalLevel", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("FolioApprovalLevel", ssENFolioApprovalLevel.ssId.ToString()); }}
}
return;
}

}
}
