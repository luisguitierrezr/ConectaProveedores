using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateInvoiceApprovalLevel
/// </summary>

public static async Task<long> CreateInvoiceApprovalLevel(IRequestContext requestContext,RC_a542803a75b19356be8279fb269e55fb inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateInvoiceApprovalLevel", "8f31a9ea-a8ae-4a4e-bf59-767b69b75d76.#CreateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateInvoiceApprovalLevel", "8f31a9ea-a8ae-4a4e-bf59-767b69b75d76.#CreateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord ssENInvoiceApprovalLevel = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENInvoiceApprovalLevelEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@InvoiceApprovalId, "invoiceapprovalid") ?? "invoiceapprovalid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@LevelNumber, "levelnumber") ?? "levelnumber") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@AssignedTo, "assignedto") ?? "assignedto") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@EntraJobTitle, "entrajobtitle") ?? "entrajobtitle") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@DepartmentId, "departmentid") ?? "departmentid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@ManagementId, "managementid") ?? "managementid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@SubdirectionId, "subdirectionid") ?? "subdirectionid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@EntraRoleId, "entraroleid") ?? "entraroleid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@ApprovalStatusId, "approvalstatusid") ?? "approvalstatusid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@CanBeFirstApprover, "canbefirstapprover") ?? "canbefirstapprover") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@SelectsNextApprover, "selectsnextapprover") ?? "selectsnextapprover") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@SelectsFirstApprover, "selectsfirstapprover") ?? "selectsfirstapprover") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@IsAccounting, "isaccounting") ?? "isaccounting") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@IsStartAccounting, "isstartaccounting") ?? "isstartaccounting") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@ApprovedBy, "approvedby") ?? "approvedby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@ApprovedOn, "approvedon") ?? "approvedon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@RequestToModifyBy, "requesttomodifyby") ?? "requesttomodifyby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@RequestToModifyOn, "requesttomodifyon") ?? "requesttomodifyon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@CanceledBy, "canceledby") ?? "canceledby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@CanceledOn, "canceledon") ?? "canceledon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@NeedsContract_DEPREC, "needscontract_deprec") ?? "needscontract_deprec") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@IsReassigned, "isreassigned") ?? "isreassigned") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@IsSubstituteFor, "issubstitutefor") ?? "issubstitutefor") + "" +
" ) VALUES (" +
" @ssInvoiceApprovalId" +
", @ssLevelNumber" +
", @ssAssignedTo" +
", @ssApplicationRoleId" +
", @ssEntraJobTitle" +
", @ssDepartmentId" +
", @ssManagementId" +
", @ssSubdirectionId" +
", @ssEntraRoleId" +
", @ssApprovalStatusId" +
", @ssCanBeFirstApprover" +
", @ssSelectsNextApprover" +
", @ssSelectsFirstApprover" +
", @ssIsAccounting" +
", @ssIsStartAccounting" +
", @ssApprovedBy" +
", @ssApprovedOn" +
", @ssRequestToModifyBy" +
", @ssRequestToModifyOn" +
", @ssCanceledBy" +
", @ssCanceledOn" +
", @ssNeedsContract_DEPREC" +
", @ssIsReassigned" +
", @ssIsSubstituteFor" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENInvoiceApprovalLevel.ssInvoiceApprovalId==0L)) {
insertSqlCmd.CreateParameter("@ssInvoiceApprovalId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssInvoiceApprovalId", DbType.Int64, ssENInvoiceApprovalLevel.ssInvoiceApprovalId);

}
insertSqlCmd.CreateParameter("@ssLevelNumber", DbType.Int32, ssENInvoiceApprovalLevel.ssLevelNumber);
if ((ssENInvoiceApprovalLevel.ssAssignedTo=="")) {
insertSqlCmd.CreateParameter("@ssAssignedTo", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssAssignedTo", DbType.String, ssENInvoiceApprovalLevel.ssAssignedTo);

}
if ((ssENInvoiceApprovalLevel.ssApplicationRoleId==0L)) {
insertSqlCmd.CreateParameter("@ssApplicationRoleId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssApplicationRoleId", DbType.Int64, ssENInvoiceApprovalLevel.ssApplicationRoleId);

}
insertSqlCmd.CreateParameter("@ssEntraJobTitle", DbType.String, ssENInvoiceApprovalLevel.ssEntraJobTitle);
if ((ssENInvoiceApprovalLevel.ssDepartmentId==0L)) {
insertSqlCmd.CreateParameter("@ssDepartmentId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssDepartmentId", DbType.Int64, ssENInvoiceApprovalLevel.ssDepartmentId);

}
if ((ssENInvoiceApprovalLevel.ssManagementId==0L)) {
insertSqlCmd.CreateParameter("@ssManagementId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssManagementId", DbType.Int64, ssENInvoiceApprovalLevel.ssManagementId);

}
if ((ssENInvoiceApprovalLevel.ssSubdirectionId==0L)) {
insertSqlCmd.CreateParameter("@ssSubdirectionId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssSubdirectionId", DbType.Int64, ssENInvoiceApprovalLevel.ssSubdirectionId);

}
if ((ssENInvoiceApprovalLevel.ssEntraRoleId==0L)) {
insertSqlCmd.CreateParameter("@ssEntraRoleId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssEntraRoleId", DbType.Int64, ssENInvoiceApprovalLevel.ssEntraRoleId);

}
if ((ssENInvoiceApprovalLevel.ssApprovalStatusId==0)) {
insertSqlCmd.CreateParameter("@ssApprovalStatusId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssApprovalStatusId", DbType.Int32, ssENInvoiceApprovalLevel.ssApprovalStatusId);

}
insertSqlCmd.CreateParameter("@ssCanBeFirstApprover", DbType.Boolean, ssENInvoiceApprovalLevel.ssCanBeFirstApprover);
insertSqlCmd.CreateParameter("@ssSelectsNextApprover", DbType.Boolean, ssENInvoiceApprovalLevel.ssSelectsNextApprover);
insertSqlCmd.CreateParameter("@ssSelectsFirstApprover", DbType.Boolean, ssENInvoiceApprovalLevel.ssSelectsFirstApprover);
insertSqlCmd.CreateParameter("@ssIsAccounting", DbType.Boolean, ssENInvoiceApprovalLevel.ssIsAccounting);
insertSqlCmd.CreateParameter("@ssIsStartAccounting", DbType.Boolean, ssENInvoiceApprovalLevel.ssIsStartAccounting);
if ((ssENInvoiceApprovalLevel.ssApprovedBy=="")) {
insertSqlCmd.CreateParameter("@ssApprovedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssApprovedBy", DbType.String, ssENInvoiceApprovalLevel.ssApprovedBy);

}
insertSqlCmd.CreateParameter("@ssApprovedOn", DbType.DateTime, ssENInvoiceApprovalLevel.ssApprovedOn);
if ((ssENInvoiceApprovalLevel.ssRequestToModifyBy=="")) {
insertSqlCmd.CreateParameter("@ssRequestToModifyBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssRequestToModifyBy", DbType.String, ssENInvoiceApprovalLevel.ssRequestToModifyBy);

}
insertSqlCmd.CreateParameter("@ssRequestToModifyOn", DbType.DateTime, ssENInvoiceApprovalLevel.ssRequestToModifyOn);
if ((ssENInvoiceApprovalLevel.ssCanceledBy=="")) {
insertSqlCmd.CreateParameter("@ssCanceledBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCanceledBy", DbType.String, ssENInvoiceApprovalLevel.ssCanceledBy);

}
insertSqlCmd.CreateParameter("@ssCanceledOn", DbType.DateTime, ssENInvoiceApprovalLevel.ssCanceledOn);
insertSqlCmd.CreateParameter("@ssNeedsContract_DEPREC", DbType.Boolean, ssENInvoiceApprovalLevel.ssNeedsContract_DEPREC);
insertSqlCmd.CreateParameter("@ssIsReassigned", DbType.Boolean, ssENInvoiceApprovalLevel.ssIsReassigned);
if ((ssENInvoiceApprovalLevel.ssIsSubstituteFor=="")) {
insertSqlCmd.CreateParameter("@ssIsSubstituteFor", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssIsSubstituteFor", DbType.String, ssENInvoiceApprovalLevel.ssIsSubstituteFor);

}
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateInvoiceApprovalLevel", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateInvoiceApprovalLevel
/// </summary>

public static async Task<long> CreateOrUpdateInvoiceApprovalLevel(IRequestContext requestContext,BitArray usedFields,RC_a542803a75b19356be8279fb269e55fb inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateInvoiceApprovalLevel", "8f31a9ea-a8ae-4a4e-bf59-767b69b75d76.#CreateOrUpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateInvoiceApprovalLevel", "8f31a9ea-a8ae-4a4e-bf59-767b69b75d76.#CreateOrUpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord ssENInvoiceApprovalLevel = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(25,true);
}
string updateSet = "UPDATE " + ENInvoiceApprovalLevelEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@InvoiceApprovalId, "invoiceapprovalid") ?? "invoiceapprovalid") + " = @ssInvoiceApprovalId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@LevelNumber, "levelnumber") ?? "levelnumber") + " = @ssLevelNumber"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@AssignedTo, "assignedto") ?? "assignedto") + " = @ssAssignedTo"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid") + " = @ssApplicationRoleId"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@EntraJobTitle, "entrajobtitle") ?? "entrajobtitle") + " = @ssEntraJobTitle"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@DepartmentId, "departmentid") ?? "departmentid") + " = @ssDepartmentId"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@ManagementId, "managementid") ?? "managementid") + " = @ssManagementId"): parameters);
parameters = (usedFields[8] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@SubdirectionId, "subdirectionid") ?? "subdirectionid") + " = @ssSubdirectionId"): parameters);
parameters = (usedFields[9] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@EntraRoleId, "entraroleid") ?? "entraroleid") + " = @ssEntraRoleId"): parameters);
parameters = (usedFields[10] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@ApprovalStatusId, "approvalstatusid") ?? "approvalstatusid") + " = @ssApprovalStatusId"): parameters);
parameters = (usedFields[11] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@CanBeFirstApprover, "canbefirstapprover") ?? "canbefirstapprover") + " = @ssCanBeFirstApprover"): parameters);
parameters = (usedFields[12] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@SelectsNextApprover, "selectsnextapprover") ?? "selectsnextapprover") + " = @ssSelectsNextApprover"): parameters);
parameters = (usedFields[13] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@SelectsFirstApprover, "selectsfirstapprover") ?? "selectsfirstapprover") + " = @ssSelectsFirstApprover"): parameters);
parameters = (usedFields[14] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@IsAccounting, "isaccounting") ?? "isaccounting") + " = @ssIsAccounting"): parameters);
parameters = (usedFields[15] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@IsStartAccounting, "isstartaccounting") ?? "isstartaccounting") + " = @ssIsStartAccounting"): parameters);
parameters = (usedFields[16] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@ApprovedBy, "approvedby") ?? "approvedby") + " = @ssApprovedBy"): parameters);
parameters = (usedFields[17] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@ApprovedOn, "approvedon") ?? "approvedon") + " = @ssApprovedOn"): parameters);
parameters = (usedFields[18] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@RequestToModifyBy, "requesttomodifyby") ?? "requesttomodifyby") + " = @ssRequestToModifyBy"): parameters);
parameters = (usedFields[19] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@RequestToModifyOn, "requesttomodifyon") ?? "requesttomodifyon") + " = @ssRequestToModifyOn"): parameters);
parameters = (usedFields[20] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@CanceledBy, "canceledby") ?? "canceledby") + " = @ssCanceledBy"): parameters);
parameters = (usedFields[21] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@CanceledOn, "canceledon") ?? "canceledon") + " = @ssCanceledOn"): parameters);
parameters = (usedFields[22] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@NeedsContract_DEPREC, "needscontract_deprec") ?? "needscontract_deprec") + " = @ssNeedsContract_DEPREC"): parameters);
parameters = (usedFields[23] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@IsReassigned, "isreassigned") ?? "isreassigned") + " = @ssIsReassigned"): parameters);
parameters = (usedFields[24] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@IsSubstituteFor, "issubstitutefor") ?? "issubstitutefor") + " = @ssIsSubstituteFor"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENInvoiceApprovalLevel_ssId_InvoiceApprovalLevel";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@CanBeFirstApprover, "canbefirstapprover") ?? "canbefirstapprover") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@CanBeFirstApprover, "canbefirstapprover") ?? "canbefirstapprover") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENInvoiceApprovalLevel.ssInvoiceApprovalId==0L)) {
sqlCmd.CreateParameter("@ssInvoiceApprovalId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssInvoiceApprovalId", DbType.Int64, ssENInvoiceApprovalLevel.ssInvoiceApprovalId);

}
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssLevelNumber", DbType.Int32, ssENInvoiceApprovalLevel.ssLevelNumber);
}
if(usedFields[3]) {
if ((ssENInvoiceApprovalLevel.ssAssignedTo=="")) {
sqlCmd.CreateParameter("@ssAssignedTo", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssAssignedTo", DbType.String, ssENInvoiceApprovalLevel.ssAssignedTo);

}
}
if(usedFields[4]) {
if ((ssENInvoiceApprovalLevel.ssApplicationRoleId==0L)) {
sqlCmd.CreateParameter("@ssApplicationRoleId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssApplicationRoleId", DbType.Int64, ssENInvoiceApprovalLevel.ssApplicationRoleId);

}
}
if(usedFields[5]) {
sqlCmd.CreateParameter("@ssEntraJobTitle", DbType.String, ssENInvoiceApprovalLevel.ssEntraJobTitle);
}
if(usedFields[6]) {
if ((ssENInvoiceApprovalLevel.ssDepartmentId==0L)) {
sqlCmd.CreateParameter("@ssDepartmentId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssDepartmentId", DbType.Int64, ssENInvoiceApprovalLevel.ssDepartmentId);

}
}
if(usedFields[7]) {
if ((ssENInvoiceApprovalLevel.ssManagementId==0L)) {
sqlCmd.CreateParameter("@ssManagementId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssManagementId", DbType.Int64, ssENInvoiceApprovalLevel.ssManagementId);

}
}
if(usedFields[8]) {
if ((ssENInvoiceApprovalLevel.ssSubdirectionId==0L)) {
sqlCmd.CreateParameter("@ssSubdirectionId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssSubdirectionId", DbType.Int64, ssENInvoiceApprovalLevel.ssSubdirectionId);

}
}
if(usedFields[9]) {
if ((ssENInvoiceApprovalLevel.ssEntraRoleId==0L)) {
sqlCmd.CreateParameter("@ssEntraRoleId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssEntraRoleId", DbType.Int64, ssENInvoiceApprovalLevel.ssEntraRoleId);

}
}
if(usedFields[10]) {
if ((ssENInvoiceApprovalLevel.ssApprovalStatusId==0)) {
sqlCmd.CreateParameter("@ssApprovalStatusId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssApprovalStatusId", DbType.Int32, ssENInvoiceApprovalLevel.ssApprovalStatusId);

}
}
if(usedFields[11]) {
sqlCmd.CreateParameter("@ssCanBeFirstApprover", DbType.Boolean, ssENInvoiceApprovalLevel.ssCanBeFirstApprover);
}
if(usedFields[12]) {
sqlCmd.CreateParameter("@ssSelectsNextApprover", DbType.Boolean, ssENInvoiceApprovalLevel.ssSelectsNextApprover);
}
if(usedFields[13]) {
sqlCmd.CreateParameter("@ssSelectsFirstApprover", DbType.Boolean, ssENInvoiceApprovalLevel.ssSelectsFirstApprover);
}
if(usedFields[14]) {
sqlCmd.CreateParameter("@ssIsAccounting", DbType.Boolean, ssENInvoiceApprovalLevel.ssIsAccounting);
}
if(usedFields[15]) {
sqlCmd.CreateParameter("@ssIsStartAccounting", DbType.Boolean, ssENInvoiceApprovalLevel.ssIsStartAccounting);
}
if(usedFields[16]) {
if ((ssENInvoiceApprovalLevel.ssApprovedBy=="")) {
sqlCmd.CreateParameter("@ssApprovedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssApprovedBy", DbType.String, ssENInvoiceApprovalLevel.ssApprovedBy);

}
}
if(usedFields[17]) {
sqlCmd.CreateParameter("@ssApprovedOn", DbType.DateTime, ssENInvoiceApprovalLevel.ssApprovedOn);
}
if(usedFields[18]) {
if ((ssENInvoiceApprovalLevel.ssRequestToModifyBy=="")) {
sqlCmd.CreateParameter("@ssRequestToModifyBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssRequestToModifyBy", DbType.String, ssENInvoiceApprovalLevel.ssRequestToModifyBy);

}
}
if(usedFields[19]) {
sqlCmd.CreateParameter("@ssRequestToModifyOn", DbType.DateTime, ssENInvoiceApprovalLevel.ssRequestToModifyOn);
}
if(usedFields[20]) {
if ((ssENInvoiceApprovalLevel.ssCanceledBy=="")) {
sqlCmd.CreateParameter("@ssCanceledBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCanceledBy", DbType.String, ssENInvoiceApprovalLevel.ssCanceledBy);

}
}
if(usedFields[21]) {
sqlCmd.CreateParameter("@ssCanceledOn", DbType.DateTime, ssENInvoiceApprovalLevel.ssCanceledOn);
}
if(usedFields[22]) {
sqlCmd.CreateParameter("@ssNeedsContract_DEPREC", DbType.Boolean, ssENInvoiceApprovalLevel.ssNeedsContract_DEPREC);
}
if(usedFields[23]) {
sqlCmd.CreateParameter("@ssIsReassigned", DbType.Boolean, ssENInvoiceApprovalLevel.ssIsReassigned);
}
if(usedFields[24]) {
if ((ssENInvoiceApprovalLevel.ssIsSubstituteFor=="")) {
sqlCmd.CreateParameter("@ssIsSubstituteFor", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssIsSubstituteFor", DbType.String, ssENInvoiceApprovalLevel.ssIsSubstituteFor);

}
}
sqlCmd.CreateParameter("@idparam_ssENInvoiceApprovalLevel_ssId_InvoiceApprovalLevel", DbType.Int64, ssENInvoiceApprovalLevel.ssId);
int counter = 0;
if(ssENInvoiceApprovalLevel.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateInvoiceApprovalLevel (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENInvoiceApprovalLevelEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@InvoiceApprovalId, "invoiceapprovalid") ?? "invoiceapprovalid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@LevelNumber, "levelnumber") ?? "levelnumber") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@AssignedTo, "assignedto") ?? "assignedto") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@EntraJobTitle, "entrajobtitle") ?? "entrajobtitle") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@DepartmentId, "departmentid") ?? "departmentid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@ManagementId, "managementid") ?? "managementid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@SubdirectionId, "subdirectionid") ?? "subdirectionid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@EntraRoleId, "entraroleid") ?? "entraroleid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@ApprovalStatusId, "approvalstatusid") ?? "approvalstatusid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@CanBeFirstApprover, "canbefirstapprover") ?? "canbefirstapprover") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@SelectsNextApprover, "selectsnextapprover") ?? "selectsnextapprover") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@SelectsFirstApprover, "selectsfirstapprover") ?? "selectsfirstapprover") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@IsAccounting, "isaccounting") ?? "isaccounting") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@IsStartAccounting, "isstartaccounting") ?? "isstartaccounting") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@ApprovedBy, "approvedby") ?? "approvedby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@ApprovedOn, "approvedon") ?? "approvedon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@RequestToModifyBy, "requesttomodifyby") ?? "requesttomodifyby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@RequestToModifyOn, "requesttomodifyon") ?? "requesttomodifyon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@CanceledBy, "canceledby") ?? "canceledby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@CanceledOn, "canceledon") ?? "canceledon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@NeedsContract_DEPREC, "needscontract_deprec") ?? "needscontract_deprec") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@IsReassigned, "isreassigned") ?? "isreassigned") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@IsSubstituteFor, "issubstitutefor") ?? "issubstitutefor") + "" +
" ) VALUES (" +
" @ssInvoiceApprovalId" +
", @ssLevelNumber" +
", @ssAssignedTo" +
", @ssApplicationRoleId" +
", @ssEntraJobTitle" +
", @ssDepartmentId" +
", @ssManagementId" +
", @ssSubdirectionId" +
", @ssEntraRoleId" +
", @ssApprovalStatusId" +
", @ssCanBeFirstApprover" +
", @ssSelectsNextApprover" +
", @ssSelectsFirstApprover" +
", @ssIsAccounting" +
", @ssIsStartAccounting" +
", @ssApprovedBy" +
", @ssApprovedOn" +
", @ssRequestToModifyBy" +
", @ssRequestToModifyOn" +
", @ssCanceledBy" +
", @ssCanceledOn" +
", @ssNeedsContract_DEPREC" +
", @ssIsReassigned" +
", @ssIsSubstituteFor" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENInvoiceApprovalLevel.ssInvoiceApprovalId==0L)) {
insertSqlCmd.CreateParameter("@ssInvoiceApprovalId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssInvoiceApprovalId", DbType.Int64, ssENInvoiceApprovalLevel.ssInvoiceApprovalId);

}
insertSqlCmd.CreateParameter("@ssLevelNumber", DbType.Int32, ssENInvoiceApprovalLevel.ssLevelNumber);
if ((ssENInvoiceApprovalLevel.ssAssignedTo=="")) {
insertSqlCmd.CreateParameter("@ssAssignedTo", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssAssignedTo", DbType.String, ssENInvoiceApprovalLevel.ssAssignedTo);

}
if ((ssENInvoiceApprovalLevel.ssApplicationRoleId==0L)) {
insertSqlCmd.CreateParameter("@ssApplicationRoleId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssApplicationRoleId", DbType.Int64, ssENInvoiceApprovalLevel.ssApplicationRoleId);

}
insertSqlCmd.CreateParameter("@ssEntraJobTitle", DbType.String, ssENInvoiceApprovalLevel.ssEntraJobTitle);
if ((ssENInvoiceApprovalLevel.ssDepartmentId==0L)) {
insertSqlCmd.CreateParameter("@ssDepartmentId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssDepartmentId", DbType.Int64, ssENInvoiceApprovalLevel.ssDepartmentId);

}
if ((ssENInvoiceApprovalLevel.ssManagementId==0L)) {
insertSqlCmd.CreateParameter("@ssManagementId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssManagementId", DbType.Int64, ssENInvoiceApprovalLevel.ssManagementId);

}
if ((ssENInvoiceApprovalLevel.ssSubdirectionId==0L)) {
insertSqlCmd.CreateParameter("@ssSubdirectionId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssSubdirectionId", DbType.Int64, ssENInvoiceApprovalLevel.ssSubdirectionId);

}
if ((ssENInvoiceApprovalLevel.ssEntraRoleId==0L)) {
insertSqlCmd.CreateParameter("@ssEntraRoleId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssEntraRoleId", DbType.Int64, ssENInvoiceApprovalLevel.ssEntraRoleId);

}
if ((ssENInvoiceApprovalLevel.ssApprovalStatusId==0)) {
insertSqlCmd.CreateParameter("@ssApprovalStatusId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssApprovalStatusId", DbType.Int32, ssENInvoiceApprovalLevel.ssApprovalStatusId);

}
insertSqlCmd.CreateParameter("@ssCanBeFirstApprover", DbType.Boolean, ssENInvoiceApprovalLevel.ssCanBeFirstApprover);
insertSqlCmd.CreateParameter("@ssSelectsNextApprover", DbType.Boolean, ssENInvoiceApprovalLevel.ssSelectsNextApprover);
insertSqlCmd.CreateParameter("@ssSelectsFirstApprover", DbType.Boolean, ssENInvoiceApprovalLevel.ssSelectsFirstApprover);
insertSqlCmd.CreateParameter("@ssIsAccounting", DbType.Boolean, ssENInvoiceApprovalLevel.ssIsAccounting);
insertSqlCmd.CreateParameter("@ssIsStartAccounting", DbType.Boolean, ssENInvoiceApprovalLevel.ssIsStartAccounting);
if ((ssENInvoiceApprovalLevel.ssApprovedBy=="")) {
insertSqlCmd.CreateParameter("@ssApprovedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssApprovedBy", DbType.String, ssENInvoiceApprovalLevel.ssApprovedBy);

}
insertSqlCmd.CreateParameter("@ssApprovedOn", DbType.DateTime, ssENInvoiceApprovalLevel.ssApprovedOn);
if ((ssENInvoiceApprovalLevel.ssRequestToModifyBy=="")) {
insertSqlCmd.CreateParameter("@ssRequestToModifyBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssRequestToModifyBy", DbType.String, ssENInvoiceApprovalLevel.ssRequestToModifyBy);

}
insertSqlCmd.CreateParameter("@ssRequestToModifyOn", DbType.DateTime, ssENInvoiceApprovalLevel.ssRequestToModifyOn);
if ((ssENInvoiceApprovalLevel.ssCanceledBy=="")) {
insertSqlCmd.CreateParameter("@ssCanceledBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCanceledBy", DbType.String, ssENInvoiceApprovalLevel.ssCanceledBy);

}
insertSqlCmd.CreateParameter("@ssCanceledOn", DbType.DateTime, ssENInvoiceApprovalLevel.ssCanceledOn);
insertSqlCmd.CreateParameter("@ssNeedsContract_DEPREC", DbType.Boolean, ssENInvoiceApprovalLevel.ssNeedsContract_DEPREC);
insertSqlCmd.CreateParameter("@ssIsReassigned", DbType.Boolean, ssENInvoiceApprovalLevel.ssIsReassigned);
if ((ssENInvoiceApprovalLevel.ssIsSubstituteFor=="")) {
insertSqlCmd.CreateParameter("@ssIsSubstituteFor", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssIsSubstituteFor", DbType.String, ssENInvoiceApprovalLevel.ssIsSubstituteFor);

}
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateInvoiceApprovalLevel", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENInvoiceApprovalLevel.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeInvoiceApprovalLevel
/// </summary>

public static async Task CreateOrUpdateSomeInvoiceApprovalLevel(IRequestContext requestContext,RL_b2132c93db5fd1f839353b7412eed8f5 inParamSourceList,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateSomeInvoiceApprovalLevel", "8f31a9ea-a8ae-4a4e-bf59-767b69b75d76.#CreateOrUpdateAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeInvoiceApprovalLevel", "8f31a9ea-a8ae-4a4e-bf59-767b69b75d76.#CreateOrUpdateAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
string entityTableName = ENInvoiceApprovalLevelEntity.LocalViewName(null);
string insertSql = "INSERT INTO " + entityTableName + " (" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@InvoiceApprovalId, "invoiceapprovalid") ?? "invoiceapprovalid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@LevelNumber, "levelnumber") ?? "levelnumber") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@AssignedTo, "assignedto") ?? "assignedto") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@EntraJobTitle, "entrajobtitle") ?? "entrajobtitle") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@DepartmentId, "departmentid") ?? "departmentid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@ManagementId, "managementid") ?? "managementid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@SubdirectionId, "subdirectionid") ?? "subdirectionid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@EntraRoleId, "entraroleid") ?? "entraroleid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@ApprovalStatusId, "approvalstatusid") ?? "approvalstatusid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@CanBeFirstApprover, "canbefirstapprover") ?? "canbefirstapprover") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@SelectsNextApprover, "selectsnextapprover") ?? "selectsnextapprover") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@SelectsFirstApprover, "selectsfirstapprover") ?? "selectsfirstapprover") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@IsAccounting, "isaccounting") ?? "isaccounting") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@IsStartAccounting, "isstartaccounting") ?? "isstartaccounting") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@ApprovedBy, "approvedby") ?? "approvedby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@ApprovedOn, "approvedon") ?? "approvedon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@RequestToModifyBy, "requesttomodifyby") ?? "requesttomodifyby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@RequestToModifyOn, "requesttomodifyon") ?? "requesttomodifyon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@CanceledBy, "canceledby") ?? "canceledby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@CanceledOn, "canceledon") ?? "canceledon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@NeedsContract_DEPREC, "needscontract_deprec") ?? "needscontract_deprec") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@IsReassigned, "isreassigned") ?? "isreassigned") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@IsSubstituteFor, "issubstitutefor") ?? "issubstitutefor") + ") VALUES ( unnest(@ssInvoiceApprovalId),  unnest(@ssLevelNumber),  unnest(@ssAssignedTo),  unnest(@ssApplicationRoleId),  unnest(@ssEntraJobTitle),  unnest(@ssDepartmentId),  unnest(@ssManagementId),  unnest(@ssSubdirectionId),  unnest(@ssEntraRoleId),  unnest(@ssApprovalStatusId),  unnest(@ssCanBeFirstApprover),  unnest(@ssSelectsNextApprover),  unnest(@ssSelectsFirstApprover),  unnest(@ssIsAccounting),  unnest(@ssIsStartAccounting),  unnest(@ssApprovedBy),  unnest(@ssApprovedOn),  unnest(@ssRequestToModifyBy),  unnest(@ssRequestToModifyOn),  unnest(@ssCanceledBy),  unnest(@ssCanceledOn),  unnest(@ssNeedsContract_DEPREC),  unnest(@ssIsReassigned),  unnest(@ssIsSubstituteFor)) ";
insertSql += "";

string updateSql = "UPDATE " + entityTableName + " SET " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@InvoiceApprovalId, "invoiceapprovalid") ?? "invoiceapprovalid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@InvoiceApprovalId, "invoiceapprovalid") ?? "invoiceapprovalid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@LevelNumber, "levelnumber") ?? "levelnumber") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@LevelNumber, "levelnumber") ?? "levelnumber") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@AssignedTo, "assignedto") ?? "assignedto") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@AssignedTo, "assignedto") ?? "assignedto") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@EntraJobTitle, "entrajobtitle") ?? "entrajobtitle") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@EntraJobTitle, "entrajobtitle") ?? "entrajobtitle") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@DepartmentId, "departmentid") ?? "departmentid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@DepartmentId, "departmentid") ?? "departmentid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@ManagementId, "managementid") ?? "managementid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@ManagementId, "managementid") ?? "managementid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@SubdirectionId, "subdirectionid") ?? "subdirectionid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@SubdirectionId, "subdirectionid") ?? "subdirectionid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@EntraRoleId, "entraroleid") ?? "entraroleid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@EntraRoleId, "entraroleid") ?? "entraroleid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@ApprovalStatusId, "approvalstatusid") ?? "approvalstatusid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@ApprovalStatusId, "approvalstatusid") ?? "approvalstatusid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@CanBeFirstApprover, "canbefirstapprover") ?? "canbefirstapprover") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@CanBeFirstApprover, "canbefirstapprover") ?? "canbefirstapprover") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@SelectsNextApprover, "selectsnextapprover") ?? "selectsnextapprover") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@SelectsNextApprover, "selectsnextapprover") ?? "selectsnextapprover") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@SelectsFirstApprover, "selectsfirstapprover") ?? "selectsfirstapprover") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@SelectsFirstApprover, "selectsfirstapprover") ?? "selectsfirstapprover") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@IsAccounting, "isaccounting") ?? "isaccounting") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@IsAccounting, "isaccounting") ?? "isaccounting") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@IsStartAccounting, "isstartaccounting") ?? "isstartaccounting") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@IsStartAccounting, "isstartaccounting") ?? "isstartaccounting") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@ApprovedBy, "approvedby") ?? "approvedby") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@ApprovedBy, "approvedby") ?? "approvedby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@ApprovedOn, "approvedon") ?? "approvedon") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@ApprovedOn, "approvedon") ?? "approvedon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@RequestToModifyBy, "requesttomodifyby") ?? "requesttomodifyby") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@RequestToModifyBy, "requesttomodifyby") ?? "requesttomodifyby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@RequestToModifyOn, "requesttomodifyon") ?? "requesttomodifyon") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@RequestToModifyOn, "requesttomodifyon") ?? "requesttomodifyon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@CanceledBy, "canceledby") ?? "canceledby") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@CanceledBy, "canceledby") ?? "canceledby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@CanceledOn, "canceledon") ?? "canceledon") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@CanceledOn, "canceledon") ?? "canceledon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@NeedsContract_DEPREC, "needscontract_deprec") ?? "needscontract_deprec") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@NeedsContract_DEPREC, "needscontract_deprec") ?? "needscontract_deprec") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@IsReassigned, "isreassigned") ?? "isreassigned") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@IsReassigned, "isreassigned") ?? "isreassigned") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@IsSubstituteFor, "issubstitutefor") ?? "issubstitutefor") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@IsSubstituteFor, "issubstitutefor") ?? "issubstitutefor") + " from ( select  unnest(@ssId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@Id, "id") ?? "id") + ",  unnest(@ssInvoiceApprovalId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@InvoiceApprovalId, "invoiceapprovalid") ?? "invoiceapprovalid") + ",  unnest(@ssLevelNumber) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@LevelNumber, "levelnumber") ?? "levelnumber") + ",  unnest(@ssAssignedTo) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@AssignedTo, "assignedto") ?? "assignedto") + ",  unnest(@ssApplicationRoleId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid") + ",  unnest(@ssEntraJobTitle) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@EntraJobTitle, "entrajobtitle") ?? "entrajobtitle") + ",  unnest(@ssDepartmentId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@DepartmentId, "departmentid") ?? "departmentid") + ",  unnest(@ssManagementId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@ManagementId, "managementid") ?? "managementid") + ",  unnest(@ssSubdirectionId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@SubdirectionId, "subdirectionid") ?? "subdirectionid") + ",  unnest(@ssEntraRoleId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@EntraRoleId, "entraroleid") ?? "entraroleid") + ",  unnest(@ssApprovalStatusId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@ApprovalStatusId, "approvalstatusid") ?? "approvalstatusid") + ",  unnest(@ssCanBeFirstApprover) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@CanBeFirstApprover, "canbefirstapprover") ?? "canbefirstapprover") + ",  unnest(@ssSelectsNextApprover) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@SelectsNextApprover, "selectsnextapprover") ?? "selectsnextapprover") + ",  unnest(@ssSelectsFirstApprover) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@SelectsFirstApprover, "selectsfirstapprover") ?? "selectsfirstapprover") + ",  unnest(@ssIsAccounting) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@IsAccounting, "isaccounting") ?? "isaccounting") + ",  unnest(@ssIsStartAccounting) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@IsStartAccounting, "isstartaccounting") ?? "isstartaccounting") + ",  unnest(@ssApprovedBy) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@ApprovedBy, "approvedby") ?? "approvedby") + ",  unnest(@ssApprovedOn) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@ApprovedOn, "approvedon") ?? "approvedon") + ",  unnest(@ssRequestToModifyBy) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@RequestToModifyBy, "requesttomodifyby") ?? "requesttomodifyby") + ",  unnest(@ssRequestToModifyOn) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@RequestToModifyOn, "requesttomodifyon") ?? "requesttomodifyon") + ",  unnest(@ssCanceledBy) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@CanceledBy, "canceledby") ?? "canceledby") + ",  unnest(@ssCanceledOn) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@CanceledOn, "canceledon") ?? "canceledon") + ",  unnest(@ssNeedsContract_DEPREC) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@NeedsContract_DEPREC, "needscontract_deprec") ?? "needscontract_deprec") + ",  unnest(@ssIsReassigned) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@IsReassigned, "isreassigned") ?? "isreassigned") + ",  unnest(@ssIsSubstituteFor) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@IsSubstituteFor, "issubstitutefor") ?? "issubstitutefor") + " ) as updateTable where " + entityTableName + "." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@Id, "id") ?? "id") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@Id, "id") ?? "id") + " ";
updateSql += "";

List<object> insertInvoiceApprovalIdList = new List<object>();
List<int> insertLevelNumberList = new List<int>();
List<object> insertAssignedToList = new List<object>();
List<object> insertApplicationRoleIdList = new List<object>();
List<string> insertEntraJobTitleList = new List<string>();
List<object> insertDepartmentIdList = new List<object>();
List<object> insertManagementIdList = new List<object>();
List<object> insertSubdirectionIdList = new List<object>();
List<object> insertEntraRoleIdList = new List<object>();
List<object> insertApprovalStatusIdList = new List<object>();
List<bool> insertCanBeFirstApproverList = new List<bool>();
List<bool> insertSelectsNextApproverList = new List<bool>();
List<bool> insertSelectsFirstApproverList = new List<bool>();
List<bool> insertIsAccountingList = new List<bool>();
List<bool> insertIsStartAccountingList = new List<bool>();
List<object> insertApprovedByList = new List<object>();
List<DateTime> insertApprovedOnList = new List<DateTime>();
List<object> insertRequestToModifyByList = new List<object>();
List<DateTime> insertRequestToModifyOnList = new List<DateTime>();
List<object> insertCanceledByList = new List<object>();
List<DateTime> insertCanceledOnList = new List<DateTime>();
List<bool> insertNeedsContract_DEPRECList = new List<bool>();
List<bool> insertIsReassignedList = new List<bool>();
List<object> insertIsSubstituteForList = new List<object>();

List<long> updateIdList = new List<long>();
List<object> updateInvoiceApprovalIdList = new List<object>();
List<int> updateLevelNumberList = new List<int>();
List<object> updateAssignedToList = new List<object>();
List<object> updateApplicationRoleIdList = new List<object>();
List<string> updateEntraJobTitleList = new List<string>();
List<object> updateDepartmentIdList = new List<object>();
List<object> updateManagementIdList = new List<object>();
List<object> updateSubdirectionIdList = new List<object>();
List<object> updateEntraRoleIdList = new List<object>();
List<object> updateApprovalStatusIdList = new List<object>();
List<bool> updateCanBeFirstApproverList = new List<bool>();
List<bool> updateSelectsNextApproverList = new List<bool>();
List<bool> updateSelectsFirstApproverList = new List<bool>();
List<bool> updateIsAccountingList = new List<bool>();
List<bool> updateIsStartAccountingList = new List<bool>();
List<object> updateApprovedByList = new List<object>();
List<DateTime> updateApprovedOnList = new List<DateTime>();
List<object> updateRequestToModifyByList = new List<object>();
List<DateTime> updateRequestToModifyOnList = new List<DateTime>();
List<object> updateCanceledByList = new List<object>();
List<DateTime> updateCanceledOnList = new List<DateTime>();
List<bool> updateNeedsContract_DEPRECList = new List<bool>();
List<bool> updateIsReassignedList = new List<bool>();
List<object> updateIsSubstituteForList = new List<object>();

var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_a542803a75b19356be8279fb269e55fb)inParamSourceList.Current).ssENInvoiceApprovalLevel;
if (record.ssId != 0L) {
updateIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
if ((record.ssInvoiceApprovalId==0L)) {
updateInvoiceApprovalIdList.Add(null);
} else {
updateInvoiceApprovalIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssInvoiceApprovalId));
}
updateLevelNumberList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssLevelNumber));
if ((record.ssAssignedTo=="")) {
updateAssignedToList.Add(null);
} else {
updateAssignedToList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssAssignedTo));
}
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
if ((record.ssApprovalStatusId==0)) {
updateApprovalStatusIdList.Add(null);
} else {
updateApprovalStatusIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssApprovalStatusId));
}
updateCanBeFirstApproverList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssCanBeFirstApprover));
updateSelectsNextApproverList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssSelectsNextApprover));
updateSelectsFirstApproverList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssSelectsFirstApprover));
updateIsAccountingList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsAccounting));
updateIsStartAccountingList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsStartAccounting));
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
updateCanceledOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssCanceledOn));
updateNeedsContract_DEPRECList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssNeedsContract_DEPREC));
updateIsReassignedList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsReassigned));
if ((record.ssIsSubstituteFor=="")) {
updateIsSubstituteForList.Add(null);
} else {
updateIsSubstituteForList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssIsSubstituteFor));
}
} else {
if ((record.ssInvoiceApprovalId==0L)) {
insertInvoiceApprovalIdList.Add(null);
} else {
insertInvoiceApprovalIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssInvoiceApprovalId));
}
insertLevelNumberList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssLevelNumber));
if ((record.ssAssignedTo=="")) {
insertAssignedToList.Add(null);
} else {
insertAssignedToList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssAssignedTo));
}
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
if ((record.ssApprovalStatusId==0)) {
insertApprovalStatusIdList.Add(null);
} else {
insertApprovalStatusIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssApprovalStatusId));
}
insertCanBeFirstApproverList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssCanBeFirstApprover));
insertSelectsNextApproverList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssSelectsNextApprover));
insertSelectsFirstApproverList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssSelectsFirstApprover));
insertIsAccountingList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsAccounting));
insertIsStartAccountingList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsStartAccounting));
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
insertCanceledOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssCanceledOn));
insertNeedsContract_DEPRECList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssNeedsContract_DEPREC));
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
if (!insertInvoiceApprovalIdList.IsEmpty() || !insertLevelNumberList.IsEmpty() || !insertAssignedToList.IsEmpty() || !insertApplicationRoleIdList.IsEmpty() || !insertEntraJobTitleList.IsEmpty() || !insertDepartmentIdList.IsEmpty() || !insertManagementIdList.IsEmpty() || !insertSubdirectionIdList.IsEmpty() || !insertEntraRoleIdList.IsEmpty() || !insertApprovalStatusIdList.IsEmpty() || !insertCanBeFirstApproverList.IsEmpty() || !insertSelectsNextApproverList.IsEmpty() || !insertSelectsFirstApproverList.IsEmpty() || !insertIsAccountingList.IsEmpty() || !insertIsStartAccountingList.IsEmpty() || !insertApprovedByList.IsEmpty() || !insertApprovedOnList.IsEmpty() || !insertRequestToModifyByList.IsEmpty() || !insertRequestToModifyOnList.IsEmpty() || !insertCanceledByList.IsEmpty() || !insertCanceledOnList.IsEmpty() || !insertNeedsContract_DEPRECList.IsEmpty() || !insertIsReassignedList.IsEmpty() || !insertIsSubstituteForList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssInvoiceApprovalId",DbType.Int64,insertInvoiceApprovalIdList);
executionService.CreateParameter(insertSqlCmd,"@ssLevelNumber",DbType.Int32,insertLevelNumberList);
executionService.CreateParameter(insertSqlCmd,"@ssAssignedTo",DbType.String,insertAssignedToList);
executionService.CreateParameter(insertSqlCmd,"@ssApplicationRoleId",DbType.Int64,insertApplicationRoleIdList);
executionService.CreateParameter(insertSqlCmd,"@ssEntraJobTitle",DbType.String,insertEntraJobTitleList);
executionService.CreateParameter(insertSqlCmd,"@ssDepartmentId",DbType.Int64,insertDepartmentIdList);
executionService.CreateParameter(insertSqlCmd,"@ssManagementId",DbType.Int64,insertManagementIdList);
executionService.CreateParameter(insertSqlCmd,"@ssSubdirectionId",DbType.Int64,insertSubdirectionIdList);
executionService.CreateParameter(insertSqlCmd,"@ssEntraRoleId",DbType.Int64,insertEntraRoleIdList);
executionService.CreateParameter(insertSqlCmd,"@ssApprovalStatusId",DbType.Int32,insertApprovalStatusIdList);
executionService.CreateParameter(insertSqlCmd,"@ssCanBeFirstApprover",DbType.Boolean,insertCanBeFirstApproverList);
executionService.CreateParameter(insertSqlCmd,"@ssSelectsNextApprover",DbType.Boolean,insertSelectsNextApproverList);
executionService.CreateParameter(insertSqlCmd,"@ssSelectsFirstApprover",DbType.Boolean,insertSelectsFirstApproverList);
executionService.CreateParameter(insertSqlCmd,"@ssIsAccounting",DbType.Boolean,insertIsAccountingList);
executionService.CreateParameter(insertSqlCmd,"@ssIsStartAccounting",DbType.Boolean,insertIsStartAccountingList);
executionService.CreateParameter(insertSqlCmd,"@ssApprovedBy",DbType.String,insertApprovedByList);
executionService.CreateParameter(insertSqlCmd,"@ssApprovedOn",DbType.DateTime,insertApprovedOnList);
executionService.CreateParameter(insertSqlCmd,"@ssRequestToModifyBy",DbType.String,insertRequestToModifyByList);
executionService.CreateParameter(insertSqlCmd,"@ssRequestToModifyOn",DbType.DateTime,insertRequestToModifyOnList);
executionService.CreateParameter(insertSqlCmd,"@ssCanceledBy",DbType.String,insertCanceledByList);
executionService.CreateParameter(insertSqlCmd,"@ssCanceledOn",DbType.DateTime,insertCanceledOnList);
executionService.CreateParameter(insertSqlCmd,"@ssNeedsContract_DEPREC",DbType.Boolean,insertNeedsContract_DEPRECList);
executionService.CreateParameter(insertSqlCmd,"@ssIsReassigned",DbType.Boolean,insertIsReassignedList);
executionService.CreateParameter(insertSqlCmd,"@ssIsSubstituteFor",DbType.String,insertIsSubstituteForList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeInvoiceApprovalLevel (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
if(!updateInvoiceApprovalIdList.IsEmpty() || !updateLevelNumberList.IsEmpty() || !updateAssignedToList.IsEmpty() || !updateApplicationRoleIdList.IsEmpty() || !updateEntraJobTitleList.IsEmpty() || !updateDepartmentIdList.IsEmpty() || !updateManagementIdList.IsEmpty() || !updateSubdirectionIdList.IsEmpty() || !updateEntraRoleIdList.IsEmpty() || !updateApprovalStatusIdList.IsEmpty() || !updateCanBeFirstApproverList.IsEmpty() || !updateSelectsNextApproverList.IsEmpty() || !updateSelectsFirstApproverList.IsEmpty() || !updateIsAccountingList.IsEmpty() || !updateIsStartAccountingList.IsEmpty() || !updateApprovedByList.IsEmpty() || !updateApprovedOnList.IsEmpty() || !updateRequestToModifyByList.IsEmpty() || !updateRequestToModifyOnList.IsEmpty() || !updateCanceledByList.IsEmpty() || !updateCanceledOnList.IsEmpty() || !updateNeedsContract_DEPRECList.IsEmpty() || !updateIsReassignedList.IsEmpty() || !updateIsSubstituteForList.IsEmpty()){
await using(var updateSqlCmd = trans.CreateCommand(updateSql)){
executionService.CreateParameter(updateSqlCmd,"@ssId",DbType.Int64,updateIdList);
executionService.CreateParameter(updateSqlCmd,"@ssInvoiceApprovalId",DbType.Int64,updateInvoiceApprovalIdList);
executionService.CreateParameter(updateSqlCmd,"@ssLevelNumber",DbType.Int32,updateLevelNumberList);
executionService.CreateParameter(updateSqlCmd,"@ssAssignedTo",DbType.String,updateAssignedToList);
executionService.CreateParameter(updateSqlCmd,"@ssApplicationRoleId",DbType.Int64,updateApplicationRoleIdList);
executionService.CreateParameter(updateSqlCmd,"@ssEntraJobTitle",DbType.String,updateEntraJobTitleList);
executionService.CreateParameter(updateSqlCmd,"@ssDepartmentId",DbType.Int64,updateDepartmentIdList);
executionService.CreateParameter(updateSqlCmd,"@ssManagementId",DbType.Int64,updateManagementIdList);
executionService.CreateParameter(updateSqlCmd,"@ssSubdirectionId",DbType.Int64,updateSubdirectionIdList);
executionService.CreateParameter(updateSqlCmd,"@ssEntraRoleId",DbType.Int64,updateEntraRoleIdList);
executionService.CreateParameter(updateSqlCmd,"@ssApprovalStatusId",DbType.Int32,updateApprovalStatusIdList);
executionService.CreateParameter(updateSqlCmd,"@ssCanBeFirstApprover",DbType.Boolean,updateCanBeFirstApproverList);
executionService.CreateParameter(updateSqlCmd,"@ssSelectsNextApprover",DbType.Boolean,updateSelectsNextApproverList);
executionService.CreateParameter(updateSqlCmd,"@ssSelectsFirstApprover",DbType.Boolean,updateSelectsFirstApproverList);
executionService.CreateParameter(updateSqlCmd,"@ssIsAccounting",DbType.Boolean,updateIsAccountingList);
executionService.CreateParameter(updateSqlCmd,"@ssIsStartAccounting",DbType.Boolean,updateIsStartAccountingList);
executionService.CreateParameter(updateSqlCmd,"@ssApprovedBy",DbType.String,updateApprovedByList);
executionService.CreateParameter(updateSqlCmd,"@ssApprovedOn",DbType.DateTime,updateApprovedOnList);
executionService.CreateParameter(updateSqlCmd,"@ssRequestToModifyBy",DbType.String,updateRequestToModifyByList);
executionService.CreateParameter(updateSqlCmd,"@ssRequestToModifyOn",DbType.DateTime,updateRequestToModifyOnList);
executionService.CreateParameter(updateSqlCmd,"@ssCanceledBy",DbType.String,updateCanceledByList);
executionService.CreateParameter(updateSqlCmd,"@ssCanceledOn",DbType.DateTime,updateCanceledOnList);
executionService.CreateParameter(updateSqlCmd,"@ssNeedsContract_DEPREC",DbType.Boolean,updateNeedsContract_DEPRECList);
executionService.CreateParameter(updateSqlCmd,"@ssIsReassigned",DbType.Boolean,updateIsReassignedList);
executionService.CreateParameter(updateSqlCmd,"@ssIsSubstituteFor",DbType.String,updateIsSubstituteForList);
await updateSqlCmd.PrepareAsync(cancellationToken);
await updateSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeInvoiceApprovalLevel (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(updateSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteInvoiceApprovalLevel
/// </summary>

public static async Task DeleteInvoiceApprovalLevel(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteInvoiceApprovalLevel", "8f31a9ea-a8ae-4a4e-bf59-767b69b75d76.#DeleteEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteInvoiceApprovalLevel", "8f31a9ea-a8ae-4a4e-bf59-767b69b75d76.#DeleteEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENInvoiceApprovalLevelEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteInvoiceApprovalLevel", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllInvoiceApprovalLevel
/// </summary>

public static async Task DeleteAllInvoiceApprovalLevel(IRequestContext requestContext,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteAllInvoiceApprovalLevel", "8f31a9ea-a8ae-4a4e-bf59-767b69b75d76.#DeleteAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllInvoiceApprovalLevel", "8f31a9ea-a8ae-4a4e-bf59-767b69b75d76.#DeleteAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENInvoiceApprovalLevelEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteInvoiceApprovalLevel", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetInvoiceApprovalLevel
/// </summary>

public static async Task<RC_a542803a75b19356be8279fb269e55fb> GetInvoiceApprovalLevel(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_a542803a75b19356be8279fb269e55fb outParamRecord = default;
outParamRecord = new RC_a542803a75b19356be8279fb269e55fb();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetInvoiceApprovalLevel", "8f31a9ea-a8ae-4a4e-bf59-767b69b75d76.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetInvoiceApprovalLevel", "8f31a9ea-a8ae-4a4e-bf59-767b69b75d76.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@InvoiceApprovalId, "invoiceapprovalid") ?? "invoiceapprovalid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@LevelNumber, "levelnumber") ?? "levelnumber", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@AssignedTo, "assignedto") ?? "assignedto", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@EntraJobTitle, "entrajobtitle") ?? "entrajobtitle", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@DepartmentId, "departmentid") ?? "departmentid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@ManagementId, "managementid") ?? "managementid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@SubdirectionId, "subdirectionid") ?? "subdirectionid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@EntraRoleId, "entraroleid") ?? "entraroleid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@ApprovalStatusId, "approvalstatusid") ?? "approvalstatusid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@CanBeFirstApprover, "canbefirstapprover") ?? "canbefirstapprover", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@SelectsNextApprover, "selectsnextapprover") ?? "selectsnextapprover", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@SelectsFirstApprover, "selectsfirstapprover") ?? "selectsfirstapprover", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@IsAccounting, "isaccounting") ?? "isaccounting", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@IsStartAccounting, "isstartaccounting") ?? "isstartaccounting", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@ApprovedBy, "approvedby") ?? "approvedby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@ApprovedOn, "approvedon") ?? "approvedon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@RequestToModifyBy, "requesttomodifyby") ?? "requesttomodifyby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@RequestToModifyOn, "requesttomodifyon") ?? "requesttomodifyon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@CanceledBy, "canceledby") ?? "canceledby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@CanceledOn, "canceledon") ?? "canceledon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@NeedsContract_DEPREC, "needscontract_deprec") ?? "needscontract_deprec", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@IsReassigned, "isreassigned") ?? "isreassigned", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@IsSubstituteFor, "issubstitutefor") ?? "issubstitutefor", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
" FROM " + ENInvoiceApprovalLevelEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetInvoiceApprovalLevel", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(25,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENInvoiceApprovalLevelEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetInvoiceApprovalLevelForUpdate
/// </summary>

public static async Task<RC_a542803a75b19356be8279fb269e55fb> GetInvoiceApprovalLevelForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_a542803a75b19356be8279fb269e55fb outParamRecord = default;
outParamRecord = new RC_a542803a75b19356be8279fb269e55fb();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetInvoiceApprovalLevelForUpdate", "8f31a9ea-a8ae-4a4e-bf59-767b69b75d76.#GetEntityForUpdate");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetInvoiceApprovalLevelForUpdate", "8f31a9ea-a8ae-4a4e-bf59-767b69b75d76.#GetEntityForUpdate", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@InvoiceApprovalId, "invoiceapprovalid") ?? "invoiceapprovalid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@LevelNumber, "levelnumber") ?? "levelnumber", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@AssignedTo, "assignedto") ?? "assignedto", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@EntraJobTitle, "entrajobtitle") ?? "entrajobtitle", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@DepartmentId, "departmentid") ?? "departmentid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@ManagementId, "managementid") ?? "managementid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@SubdirectionId, "subdirectionid") ?? "subdirectionid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@EntraRoleId, "entraroleid") ?? "entraroleid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@ApprovalStatusId, "approvalstatusid") ?? "approvalstatusid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@CanBeFirstApprover, "canbefirstapprover") ?? "canbefirstapprover", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@SelectsNextApprover, "selectsnextapprover") ?? "selectsnextapprover", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@SelectsFirstApprover, "selectsfirstapprover") ?? "selectsfirstapprover", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@IsAccounting, "isaccounting") ?? "isaccounting", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@IsStartAccounting, "isstartaccounting") ?? "isstartaccounting", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@ApprovedBy, "approvedby") ?? "approvedby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@ApprovedOn, "approvedon") ?? "approvedon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@RequestToModifyBy, "requesttomodifyby") ?? "requesttomodifyby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@RequestToModifyOn, "requesttomodifyon") ?? "requesttomodifyon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@CanceledBy, "canceledby") ?? "canceledby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@CanceledOn, "canceledon") ?? "canceledon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@NeedsContract_DEPREC, "needscontract_deprec") ?? "needscontract_deprec", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@IsReassigned, "isreassigned") ?? "isreassigned", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@IsSubstituteFor, "issubstitutefor") ?? "issubstitutefor", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
" FROM " + ENInvoiceApprovalLevelEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@Id, "id") ?? "id") + " = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetInvoiceApprovalLevelForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(25,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENInvoiceApprovalLevelEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateInvoiceApprovalLevel
/// </summary>

public static async Task UpdateInvoiceApprovalLevel(IRequestContext requestContext,BitArray usedFields,RC_a542803a75b19356be8279fb269e55fb inParamSource,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("UpdateInvoiceApprovalLevel", "8f31a9ea-a8ae-4a4e-bf59-767b69b75d76.#UpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateInvoiceApprovalLevel", "8f31a9ea-a8ae-4a4e-bf59-767b69b75d76.#UpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord ssENInvoiceApprovalLevel = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(25,true);
}
string updateSet = "UPDATE " + ENInvoiceApprovalLevelEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@InvoiceApprovalId, "invoiceapprovalid") ?? "invoiceapprovalid") + " = @ssInvoiceApprovalId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@LevelNumber, "levelnumber") ?? "levelnumber") + " = @ssLevelNumber"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@AssignedTo, "assignedto") ?? "assignedto") + " = @ssAssignedTo"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid") + " = @ssApplicationRoleId"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@EntraJobTitle, "entrajobtitle") ?? "entrajobtitle") + " = @ssEntraJobTitle"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@DepartmentId, "departmentid") ?? "departmentid") + " = @ssDepartmentId"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@ManagementId, "managementid") ?? "managementid") + " = @ssManagementId"): parameters);
parameters = (usedFields[8] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@SubdirectionId, "subdirectionid") ?? "subdirectionid") + " = @ssSubdirectionId"): parameters);
parameters = (usedFields[9] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@EntraRoleId, "entraroleid") ?? "entraroleid") + " = @ssEntraRoleId"): parameters);
parameters = (usedFields[10] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@ApprovalStatusId, "approvalstatusid") ?? "approvalstatusid") + " = @ssApprovalStatusId"): parameters);
parameters = (usedFields[11] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@CanBeFirstApprover, "canbefirstapprover") ?? "canbefirstapprover") + " = @ssCanBeFirstApprover"): parameters);
parameters = (usedFields[12] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@SelectsNextApprover, "selectsnextapprover") ?? "selectsnextapprover") + " = @ssSelectsNextApprover"): parameters);
parameters = (usedFields[13] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@SelectsFirstApprover, "selectsfirstapprover") ?? "selectsfirstapprover") + " = @ssSelectsFirstApprover"): parameters);
parameters = (usedFields[14] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@IsAccounting, "isaccounting") ?? "isaccounting") + " = @ssIsAccounting"): parameters);
parameters = (usedFields[15] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@IsStartAccounting, "isstartaccounting") ?? "isstartaccounting") + " = @ssIsStartAccounting"): parameters);
parameters = (usedFields[16] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@ApprovedBy, "approvedby") ?? "approvedby") + " = @ssApprovedBy"): parameters);
parameters = (usedFields[17] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@ApprovedOn, "approvedon") ?? "approvedon") + " = @ssApprovedOn"): parameters);
parameters = (usedFields[18] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@RequestToModifyBy, "requesttomodifyby") ?? "requesttomodifyby") + " = @ssRequestToModifyBy"): parameters);
parameters = (usedFields[19] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@RequestToModifyOn, "requesttomodifyon") ?? "requesttomodifyon") + " = @ssRequestToModifyOn"): parameters);
parameters = (usedFields[20] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@CanceledBy, "canceledby") ?? "canceledby") + " = @ssCanceledBy"): parameters);
parameters = (usedFields[21] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@CanceledOn, "canceledon") ?? "canceledon") + " = @ssCanceledOn"): parameters);
parameters = (usedFields[22] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@NeedsContract_DEPREC, "needscontract_deprec") ?? "needscontract_deprec") + " = @ssNeedsContract_DEPREC"): parameters);
parameters = (usedFields[23] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@IsReassigned, "isreassigned") ?? "isreassigned") + " = @ssIsReassigned"): parameters);
parameters = (usedFields[24] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@IsSubstituteFor, "issubstitutefor") ?? "issubstitutefor") + " = @ssIsSubstituteFor"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENInvoiceApprovalLevel_ssId_InvoiceApprovalLevel";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@CanBeFirstApprover, "canbefirstapprover") ?? "canbefirstapprover") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@CanBeFirstApprover, "canbefirstapprover") ?? "canbefirstapprover") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENInvoiceApprovalLevel.ssInvoiceApprovalId==0L)) {
sqlCmd.CreateParameter("@ssInvoiceApprovalId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssInvoiceApprovalId", DbType.Int64, ssENInvoiceApprovalLevel.ssInvoiceApprovalId);

}
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssLevelNumber", DbType.Int32, ssENInvoiceApprovalLevel.ssLevelNumber);
}
if(usedFields[3]) {
if ((ssENInvoiceApprovalLevel.ssAssignedTo=="")) {
sqlCmd.CreateParameter("@ssAssignedTo", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssAssignedTo", DbType.String, ssENInvoiceApprovalLevel.ssAssignedTo);

}
}
if(usedFields[4]) {
if ((ssENInvoiceApprovalLevel.ssApplicationRoleId==0L)) {
sqlCmd.CreateParameter("@ssApplicationRoleId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssApplicationRoleId", DbType.Int64, ssENInvoiceApprovalLevel.ssApplicationRoleId);

}
}
if(usedFields[5]) {
sqlCmd.CreateParameter("@ssEntraJobTitle", DbType.String, ssENInvoiceApprovalLevel.ssEntraJobTitle);
}
if(usedFields[6]) {
if ((ssENInvoiceApprovalLevel.ssDepartmentId==0L)) {
sqlCmd.CreateParameter("@ssDepartmentId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssDepartmentId", DbType.Int64, ssENInvoiceApprovalLevel.ssDepartmentId);

}
}
if(usedFields[7]) {
if ((ssENInvoiceApprovalLevel.ssManagementId==0L)) {
sqlCmd.CreateParameter("@ssManagementId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssManagementId", DbType.Int64, ssENInvoiceApprovalLevel.ssManagementId);

}
}
if(usedFields[8]) {
if ((ssENInvoiceApprovalLevel.ssSubdirectionId==0L)) {
sqlCmd.CreateParameter("@ssSubdirectionId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssSubdirectionId", DbType.Int64, ssENInvoiceApprovalLevel.ssSubdirectionId);

}
}
if(usedFields[9]) {
if ((ssENInvoiceApprovalLevel.ssEntraRoleId==0L)) {
sqlCmd.CreateParameter("@ssEntraRoleId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssEntraRoleId", DbType.Int64, ssENInvoiceApprovalLevel.ssEntraRoleId);

}
}
if(usedFields[10]) {
if ((ssENInvoiceApprovalLevel.ssApprovalStatusId==0)) {
sqlCmd.CreateParameter("@ssApprovalStatusId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssApprovalStatusId", DbType.Int32, ssENInvoiceApprovalLevel.ssApprovalStatusId);

}
}
if(usedFields[11]) {
sqlCmd.CreateParameter("@ssCanBeFirstApprover", DbType.Boolean, ssENInvoiceApprovalLevel.ssCanBeFirstApprover);
}
if(usedFields[12]) {
sqlCmd.CreateParameter("@ssSelectsNextApprover", DbType.Boolean, ssENInvoiceApprovalLevel.ssSelectsNextApprover);
}
if(usedFields[13]) {
sqlCmd.CreateParameter("@ssSelectsFirstApprover", DbType.Boolean, ssENInvoiceApprovalLevel.ssSelectsFirstApprover);
}
if(usedFields[14]) {
sqlCmd.CreateParameter("@ssIsAccounting", DbType.Boolean, ssENInvoiceApprovalLevel.ssIsAccounting);
}
if(usedFields[15]) {
sqlCmd.CreateParameter("@ssIsStartAccounting", DbType.Boolean, ssENInvoiceApprovalLevel.ssIsStartAccounting);
}
if(usedFields[16]) {
if ((ssENInvoiceApprovalLevel.ssApprovedBy=="")) {
sqlCmd.CreateParameter("@ssApprovedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssApprovedBy", DbType.String, ssENInvoiceApprovalLevel.ssApprovedBy);

}
}
if(usedFields[17]) {
sqlCmd.CreateParameter("@ssApprovedOn", DbType.DateTime, ssENInvoiceApprovalLevel.ssApprovedOn);
}
if(usedFields[18]) {
if ((ssENInvoiceApprovalLevel.ssRequestToModifyBy=="")) {
sqlCmd.CreateParameter("@ssRequestToModifyBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssRequestToModifyBy", DbType.String, ssENInvoiceApprovalLevel.ssRequestToModifyBy);

}
}
if(usedFields[19]) {
sqlCmd.CreateParameter("@ssRequestToModifyOn", DbType.DateTime, ssENInvoiceApprovalLevel.ssRequestToModifyOn);
}
if(usedFields[20]) {
if ((ssENInvoiceApprovalLevel.ssCanceledBy=="")) {
sqlCmd.CreateParameter("@ssCanceledBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCanceledBy", DbType.String, ssENInvoiceApprovalLevel.ssCanceledBy);

}
}
if(usedFields[21]) {
sqlCmd.CreateParameter("@ssCanceledOn", DbType.DateTime, ssENInvoiceApprovalLevel.ssCanceledOn);
}
if(usedFields[22]) {
sqlCmd.CreateParameter("@ssNeedsContract_DEPREC", DbType.Boolean, ssENInvoiceApprovalLevel.ssNeedsContract_DEPREC);
}
if(usedFields[23]) {
sqlCmd.CreateParameter("@ssIsReassigned", DbType.Boolean, ssENInvoiceApprovalLevel.ssIsReassigned);
}
if(usedFields[24]) {
if ((ssENInvoiceApprovalLevel.ssIsSubstituteFor=="")) {
sqlCmd.CreateParameter("@ssIsSubstituteFor", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssIsSubstituteFor", DbType.String, ssENInvoiceApprovalLevel.ssIsSubstituteFor);

}
}
sqlCmd.CreateParameter("@idparam_ssENInvoiceApprovalLevel_ssId_InvoiceApprovalLevel", DbType.Int64, ssENInvoiceApprovalLevel.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateInvoiceApprovalLevel", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("InvoiceApprovalLevel", ssENInvoiceApprovalLevel.ssId.ToString()); }}
}
return;
}

}
}
