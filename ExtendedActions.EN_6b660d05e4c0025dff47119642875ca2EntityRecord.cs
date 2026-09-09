using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateOrderApprovalLevel
/// </summary>

public static async Task<long> CreateOrderApprovalLevel(IRequestContext requestContext,RC_ff8382bb6fb6cc7d57ecda7bb499922f inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrderApprovalLevel", "c6ad5773-2f47-4166-b537-1bc6f31bbf81.#CreateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrderApprovalLevel", "c6ad5773-2f47-4166-b537-1bc6f31bbf81.#CreateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_6b660d05e4c0025dff47119642875ca2EntityRecord ssENOrderApprovalLevel = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENOrderApprovalLevelEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@OrderApprovalId, "orderapprovalid") ?? "orderapprovalid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@LevelNumber, "levelnumber") ?? "levelnumber") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@EntraRoleId, "entraroleid") ?? "entraroleid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@AssignedTo, "assignedto") ?? "assignedto") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@AssignedOn, "assignedon") ?? "assignedon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@ApprovalStatusId, "approvalstatusid") ?? "approvalstatusid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@ApprovedBy, "approvedby") ?? "approvedby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@ApprovedOn, "approvedon") ?? "approvedon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@RejectedBy, "rejectedby") ?? "rejectedby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@RejectedOn, "rejectedon") ?? "rejectedon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@IsComplement, "iscomplement") ?? "iscomplement") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@IsReassigned, "isreassigned") ?? "isreassigned") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@IsSubstituteFor, "issubstitutefor") ?? "issubstitutefor") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@ToModifyBy, "tomodifyby") ?? "tomodifyby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@ToModifyOn, "tomodifyon") ?? "tomodifyon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@WasCanceledBy, "wascanceledby") ?? "wascanceledby") + "" +
" ) VALUES (" +
" @ssOrderApprovalId" +
", @ssLevelNumber" +
", @ssEntraRoleId" +
", @ssAssignedTo" +
", @ssAssignedOn" +
", @ssApprovalStatusId" +
", @ssApprovedBy" +
", @ssApprovedOn" +
", @ssRejectedBy" +
", @ssRejectedOn" +
", @ssIsComplement" +
", @ssIsReassigned" +
", @ssIsSubstituteFor" +
", @ssToModifyBy" +
", @ssToModifyOn" +
", @ssWasCanceledBy" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENOrderApprovalLevel.ssOrderApprovalId==0L)) {
insertSqlCmd.CreateParameter("@ssOrderApprovalId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssOrderApprovalId", DbType.Int64, ssENOrderApprovalLevel.ssOrderApprovalId);

}
insertSqlCmd.CreateParameter("@ssLevelNumber", DbType.Int32, ssENOrderApprovalLevel.ssLevelNumber);
if ((ssENOrderApprovalLevel.ssEntraRoleId==0L)) {
insertSqlCmd.CreateParameter("@ssEntraRoleId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssEntraRoleId", DbType.Int64, ssENOrderApprovalLevel.ssEntraRoleId);

}
if ((ssENOrderApprovalLevel.ssAssignedTo=="")) {
insertSqlCmd.CreateParameter("@ssAssignedTo", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssAssignedTo", DbType.String, ssENOrderApprovalLevel.ssAssignedTo);

}
insertSqlCmd.CreateParameter("@ssAssignedOn", DbType.DateTime, ssENOrderApprovalLevel.ssAssignedOn);
if ((ssENOrderApprovalLevel.ssApprovalStatusId==0)) {
insertSqlCmd.CreateParameter("@ssApprovalStatusId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssApprovalStatusId", DbType.Int32, ssENOrderApprovalLevel.ssApprovalStatusId);

}
if ((ssENOrderApprovalLevel.ssApprovedBy=="")) {
insertSqlCmd.CreateParameter("@ssApprovedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssApprovedBy", DbType.String, ssENOrderApprovalLevel.ssApprovedBy);

}
insertSqlCmd.CreateParameter("@ssApprovedOn", DbType.DateTime, ssENOrderApprovalLevel.ssApprovedOn);
if ((ssENOrderApprovalLevel.ssRejectedBy=="")) {
insertSqlCmd.CreateParameter("@ssRejectedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssRejectedBy", DbType.String, ssENOrderApprovalLevel.ssRejectedBy);

}
insertSqlCmd.CreateParameter("@ssRejectedOn", DbType.DateTime, ssENOrderApprovalLevel.ssRejectedOn);
insertSqlCmd.CreateParameter("@ssIsComplement", DbType.Boolean, ssENOrderApprovalLevel.ssIsComplement);
insertSqlCmd.CreateParameter("@ssIsReassigned", DbType.Boolean, ssENOrderApprovalLevel.ssIsReassigned);
if ((ssENOrderApprovalLevel.ssIsSubstituteFor=="")) {
insertSqlCmd.CreateParameter("@ssIsSubstituteFor", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssIsSubstituteFor", DbType.String, ssENOrderApprovalLevel.ssIsSubstituteFor);

}
if ((ssENOrderApprovalLevel.ssToModifyBy=="")) {
insertSqlCmd.CreateParameter("@ssToModifyBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssToModifyBy", DbType.String, ssENOrderApprovalLevel.ssToModifyBy);

}
insertSqlCmd.CreateParameter("@ssToModifyOn", DbType.DateTime, ssENOrderApprovalLevel.ssToModifyOn);
if ((ssENOrderApprovalLevel.ssWasCanceledBy=="")) {
insertSqlCmd.CreateParameter("@ssWasCanceledBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssWasCanceledBy", DbType.String, ssENOrderApprovalLevel.ssWasCanceledBy);

}
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrderApprovalLevel", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateOrderApprovalLevel
/// </summary>

public static async Task<long> CreateOrUpdateOrderApprovalLevel(IRequestContext requestContext,BitArray usedFields,RC_ff8382bb6fb6cc7d57ecda7bb499922f inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateOrderApprovalLevel", "c6ad5773-2f47-4166-b537-1bc6f31bbf81.#CreateOrUpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateOrderApprovalLevel", "c6ad5773-2f47-4166-b537-1bc6f31bbf81.#CreateOrUpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_6b660d05e4c0025dff47119642875ca2EntityRecord ssENOrderApprovalLevel = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(17,true);
}
string updateSet = "UPDATE " + ENOrderApprovalLevelEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@OrderApprovalId, "orderapprovalid") ?? "orderapprovalid") + " = @ssOrderApprovalId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@LevelNumber, "levelnumber") ?? "levelnumber") + " = @ssLevelNumber"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@EntraRoleId, "entraroleid") ?? "entraroleid") + " = @ssEntraRoleId"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@AssignedTo, "assignedto") ?? "assignedto") + " = @ssAssignedTo"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@AssignedOn, "assignedon") ?? "assignedon") + " = @ssAssignedOn"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@ApprovalStatusId, "approvalstatusid") ?? "approvalstatusid") + " = @ssApprovalStatusId"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@ApprovedBy, "approvedby") ?? "approvedby") + " = @ssApprovedBy"): parameters);
parameters = (usedFields[8] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@ApprovedOn, "approvedon") ?? "approvedon") + " = @ssApprovedOn"): parameters);
parameters = (usedFields[9] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@RejectedBy, "rejectedby") ?? "rejectedby") + " = @ssRejectedBy"): parameters);
parameters = (usedFields[10] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@RejectedOn, "rejectedon") ?? "rejectedon") + " = @ssRejectedOn"): parameters);
parameters = (usedFields[11] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@IsComplement, "iscomplement") ?? "iscomplement") + " = @ssIsComplement"): parameters);
parameters = (usedFields[12] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@IsReassigned, "isreassigned") ?? "isreassigned") + " = @ssIsReassigned"): parameters);
parameters = (usedFields[13] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@IsSubstituteFor, "issubstitutefor") ?? "issubstitutefor") + " = @ssIsSubstituteFor"): parameters);
parameters = (usedFields[14] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@ToModifyBy, "tomodifyby") ?? "tomodifyby") + " = @ssToModifyBy"): parameters);
parameters = (usedFields[15] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@ToModifyOn, "tomodifyon") ?? "tomodifyon") + " = @ssToModifyOn"): parameters);
parameters = (usedFields[16] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@WasCanceledBy, "wascanceledby") ?? "wascanceledby") + " = @ssWasCanceledBy"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENOrderApprovalLevel_ssId_OrderApprovalLevel";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@IsComplement, "iscomplement") ?? "iscomplement") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@IsComplement, "iscomplement") ?? "iscomplement") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENOrderApprovalLevel.ssOrderApprovalId==0L)) {
sqlCmd.CreateParameter("@ssOrderApprovalId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssOrderApprovalId", DbType.Int64, ssENOrderApprovalLevel.ssOrderApprovalId);

}
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssLevelNumber", DbType.Int32, ssENOrderApprovalLevel.ssLevelNumber);
}
if(usedFields[3]) {
if ((ssENOrderApprovalLevel.ssEntraRoleId==0L)) {
sqlCmd.CreateParameter("@ssEntraRoleId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssEntraRoleId", DbType.Int64, ssENOrderApprovalLevel.ssEntraRoleId);

}
}
if(usedFields[4]) {
if ((ssENOrderApprovalLevel.ssAssignedTo=="")) {
sqlCmd.CreateParameter("@ssAssignedTo", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssAssignedTo", DbType.String, ssENOrderApprovalLevel.ssAssignedTo);

}
}
if(usedFields[5]) {
sqlCmd.CreateParameter("@ssAssignedOn", DbType.DateTime, ssENOrderApprovalLevel.ssAssignedOn);
}
if(usedFields[6]) {
if ((ssENOrderApprovalLevel.ssApprovalStatusId==0)) {
sqlCmd.CreateParameter("@ssApprovalStatusId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssApprovalStatusId", DbType.Int32, ssENOrderApprovalLevel.ssApprovalStatusId);

}
}
if(usedFields[7]) {
if ((ssENOrderApprovalLevel.ssApprovedBy=="")) {
sqlCmd.CreateParameter("@ssApprovedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssApprovedBy", DbType.String, ssENOrderApprovalLevel.ssApprovedBy);

}
}
if(usedFields[8]) {
sqlCmd.CreateParameter("@ssApprovedOn", DbType.DateTime, ssENOrderApprovalLevel.ssApprovedOn);
}
if(usedFields[9]) {
if ((ssENOrderApprovalLevel.ssRejectedBy=="")) {
sqlCmd.CreateParameter("@ssRejectedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssRejectedBy", DbType.String, ssENOrderApprovalLevel.ssRejectedBy);

}
}
if(usedFields[10]) {
sqlCmd.CreateParameter("@ssRejectedOn", DbType.DateTime, ssENOrderApprovalLevel.ssRejectedOn);
}
if(usedFields[11]) {
sqlCmd.CreateParameter("@ssIsComplement", DbType.Boolean, ssENOrderApprovalLevel.ssIsComplement);
}
if(usedFields[12]) {
sqlCmd.CreateParameter("@ssIsReassigned", DbType.Boolean, ssENOrderApprovalLevel.ssIsReassigned);
}
if(usedFields[13]) {
if ((ssENOrderApprovalLevel.ssIsSubstituteFor=="")) {
sqlCmd.CreateParameter("@ssIsSubstituteFor", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssIsSubstituteFor", DbType.String, ssENOrderApprovalLevel.ssIsSubstituteFor);

}
}
if(usedFields[14]) {
if ((ssENOrderApprovalLevel.ssToModifyBy=="")) {
sqlCmd.CreateParameter("@ssToModifyBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssToModifyBy", DbType.String, ssENOrderApprovalLevel.ssToModifyBy);

}
}
if(usedFields[15]) {
sqlCmd.CreateParameter("@ssToModifyOn", DbType.DateTime, ssENOrderApprovalLevel.ssToModifyOn);
}
if(usedFields[16]) {
if ((ssENOrderApprovalLevel.ssWasCanceledBy=="")) {
sqlCmd.CreateParameter("@ssWasCanceledBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssWasCanceledBy", DbType.String, ssENOrderApprovalLevel.ssWasCanceledBy);

}
}
sqlCmd.CreateParameter("@idparam_ssENOrderApprovalLevel_ssId_OrderApprovalLevel", DbType.Int64, ssENOrderApprovalLevel.ssId);
int counter = 0;
if(ssENOrderApprovalLevel.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateOrderApprovalLevel (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENOrderApprovalLevelEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@OrderApprovalId, "orderapprovalid") ?? "orderapprovalid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@LevelNumber, "levelnumber") ?? "levelnumber") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@EntraRoleId, "entraroleid") ?? "entraroleid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@AssignedTo, "assignedto") ?? "assignedto") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@AssignedOn, "assignedon") ?? "assignedon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@ApprovalStatusId, "approvalstatusid") ?? "approvalstatusid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@ApprovedBy, "approvedby") ?? "approvedby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@ApprovedOn, "approvedon") ?? "approvedon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@RejectedBy, "rejectedby") ?? "rejectedby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@RejectedOn, "rejectedon") ?? "rejectedon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@IsComplement, "iscomplement") ?? "iscomplement") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@IsReassigned, "isreassigned") ?? "isreassigned") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@IsSubstituteFor, "issubstitutefor") ?? "issubstitutefor") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@ToModifyBy, "tomodifyby") ?? "tomodifyby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@ToModifyOn, "tomodifyon") ?? "tomodifyon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@WasCanceledBy, "wascanceledby") ?? "wascanceledby") + "" +
" ) VALUES (" +
" @ssOrderApprovalId" +
", @ssLevelNumber" +
", @ssEntraRoleId" +
", @ssAssignedTo" +
", @ssAssignedOn" +
", @ssApprovalStatusId" +
", @ssApprovedBy" +
", @ssApprovedOn" +
", @ssRejectedBy" +
", @ssRejectedOn" +
", @ssIsComplement" +
", @ssIsReassigned" +
", @ssIsSubstituteFor" +
", @ssToModifyBy" +
", @ssToModifyOn" +
", @ssWasCanceledBy" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENOrderApprovalLevel.ssOrderApprovalId==0L)) {
insertSqlCmd.CreateParameter("@ssOrderApprovalId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssOrderApprovalId", DbType.Int64, ssENOrderApprovalLevel.ssOrderApprovalId);

}
insertSqlCmd.CreateParameter("@ssLevelNumber", DbType.Int32, ssENOrderApprovalLevel.ssLevelNumber);
if ((ssENOrderApprovalLevel.ssEntraRoleId==0L)) {
insertSqlCmd.CreateParameter("@ssEntraRoleId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssEntraRoleId", DbType.Int64, ssENOrderApprovalLevel.ssEntraRoleId);

}
if ((ssENOrderApprovalLevel.ssAssignedTo=="")) {
insertSqlCmd.CreateParameter("@ssAssignedTo", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssAssignedTo", DbType.String, ssENOrderApprovalLevel.ssAssignedTo);

}
insertSqlCmd.CreateParameter("@ssAssignedOn", DbType.DateTime, ssENOrderApprovalLevel.ssAssignedOn);
if ((ssENOrderApprovalLevel.ssApprovalStatusId==0)) {
insertSqlCmd.CreateParameter("@ssApprovalStatusId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssApprovalStatusId", DbType.Int32, ssENOrderApprovalLevel.ssApprovalStatusId);

}
if ((ssENOrderApprovalLevel.ssApprovedBy=="")) {
insertSqlCmd.CreateParameter("@ssApprovedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssApprovedBy", DbType.String, ssENOrderApprovalLevel.ssApprovedBy);

}
insertSqlCmd.CreateParameter("@ssApprovedOn", DbType.DateTime, ssENOrderApprovalLevel.ssApprovedOn);
if ((ssENOrderApprovalLevel.ssRejectedBy=="")) {
insertSqlCmd.CreateParameter("@ssRejectedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssRejectedBy", DbType.String, ssENOrderApprovalLevel.ssRejectedBy);

}
insertSqlCmd.CreateParameter("@ssRejectedOn", DbType.DateTime, ssENOrderApprovalLevel.ssRejectedOn);
insertSqlCmd.CreateParameter("@ssIsComplement", DbType.Boolean, ssENOrderApprovalLevel.ssIsComplement);
insertSqlCmd.CreateParameter("@ssIsReassigned", DbType.Boolean, ssENOrderApprovalLevel.ssIsReassigned);
if ((ssENOrderApprovalLevel.ssIsSubstituteFor=="")) {
insertSqlCmd.CreateParameter("@ssIsSubstituteFor", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssIsSubstituteFor", DbType.String, ssENOrderApprovalLevel.ssIsSubstituteFor);

}
if ((ssENOrderApprovalLevel.ssToModifyBy=="")) {
insertSqlCmd.CreateParameter("@ssToModifyBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssToModifyBy", DbType.String, ssENOrderApprovalLevel.ssToModifyBy);

}
insertSqlCmd.CreateParameter("@ssToModifyOn", DbType.DateTime, ssENOrderApprovalLevel.ssToModifyOn);
if ((ssENOrderApprovalLevel.ssWasCanceledBy=="")) {
insertSqlCmd.CreateParameter("@ssWasCanceledBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssWasCanceledBy", DbType.String, ssENOrderApprovalLevel.ssWasCanceledBy);

}
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateOrderApprovalLevel", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENOrderApprovalLevel.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeOrderApprovalLevel
/// </summary>

public static async Task CreateOrUpdateSomeOrderApprovalLevel(IRequestContext requestContext,RL_ee0c9b1586585bb225d3aea45637d365 inParamSourceList,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateSomeOrderApprovalLevel", "c6ad5773-2f47-4166-b537-1bc6f31bbf81.#CreateOrUpdateAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeOrderApprovalLevel", "c6ad5773-2f47-4166-b537-1bc6f31bbf81.#CreateOrUpdateAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
string entityTableName = ENOrderApprovalLevelEntity.LocalViewName(null);
string insertSql = "INSERT INTO " + entityTableName + " (" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@OrderApprovalId, "orderapprovalid") ?? "orderapprovalid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@LevelNumber, "levelnumber") ?? "levelnumber") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@EntraRoleId, "entraroleid") ?? "entraroleid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@AssignedTo, "assignedto") ?? "assignedto") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@AssignedOn, "assignedon") ?? "assignedon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@ApprovalStatusId, "approvalstatusid") ?? "approvalstatusid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@ApprovedBy, "approvedby") ?? "approvedby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@ApprovedOn, "approvedon") ?? "approvedon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@RejectedBy, "rejectedby") ?? "rejectedby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@RejectedOn, "rejectedon") ?? "rejectedon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@IsComplement, "iscomplement") ?? "iscomplement") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@IsReassigned, "isreassigned") ?? "isreassigned") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@IsSubstituteFor, "issubstitutefor") ?? "issubstitutefor") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@ToModifyBy, "tomodifyby") ?? "tomodifyby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@ToModifyOn, "tomodifyon") ?? "tomodifyon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@WasCanceledBy, "wascanceledby") ?? "wascanceledby") + ") VALUES ( unnest(@ssOrderApprovalId),  unnest(@ssLevelNumber),  unnest(@ssEntraRoleId),  unnest(@ssAssignedTo),  unnest(@ssAssignedOn),  unnest(@ssApprovalStatusId),  unnest(@ssApprovedBy),  unnest(@ssApprovedOn),  unnest(@ssRejectedBy),  unnest(@ssRejectedOn),  unnest(@ssIsComplement),  unnest(@ssIsReassigned),  unnest(@ssIsSubstituteFor),  unnest(@ssToModifyBy),  unnest(@ssToModifyOn),  unnest(@ssWasCanceledBy)) ";
insertSql += "";

string updateSql = "UPDATE " + entityTableName + " SET " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@OrderApprovalId, "orderapprovalid") ?? "orderapprovalid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@OrderApprovalId, "orderapprovalid") ?? "orderapprovalid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@LevelNumber, "levelnumber") ?? "levelnumber") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@LevelNumber, "levelnumber") ?? "levelnumber") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@EntraRoleId, "entraroleid") ?? "entraroleid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@EntraRoleId, "entraroleid") ?? "entraroleid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@AssignedTo, "assignedto") ?? "assignedto") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@AssignedTo, "assignedto") ?? "assignedto") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@AssignedOn, "assignedon") ?? "assignedon") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@AssignedOn, "assignedon") ?? "assignedon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@ApprovalStatusId, "approvalstatusid") ?? "approvalstatusid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@ApprovalStatusId, "approvalstatusid") ?? "approvalstatusid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@ApprovedBy, "approvedby") ?? "approvedby") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@ApprovedBy, "approvedby") ?? "approvedby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@ApprovedOn, "approvedon") ?? "approvedon") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@ApprovedOn, "approvedon") ?? "approvedon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@RejectedBy, "rejectedby") ?? "rejectedby") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@RejectedBy, "rejectedby") ?? "rejectedby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@RejectedOn, "rejectedon") ?? "rejectedon") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@RejectedOn, "rejectedon") ?? "rejectedon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@IsComplement, "iscomplement") ?? "iscomplement") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@IsComplement, "iscomplement") ?? "iscomplement") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@IsReassigned, "isreassigned") ?? "isreassigned") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@IsReassigned, "isreassigned") ?? "isreassigned") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@IsSubstituteFor, "issubstitutefor") ?? "issubstitutefor") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@IsSubstituteFor, "issubstitutefor") ?? "issubstitutefor") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@ToModifyBy, "tomodifyby") ?? "tomodifyby") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@ToModifyBy, "tomodifyby") ?? "tomodifyby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@ToModifyOn, "tomodifyon") ?? "tomodifyon") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@ToModifyOn, "tomodifyon") ?? "tomodifyon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@WasCanceledBy, "wascanceledby") ?? "wascanceledby") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@WasCanceledBy, "wascanceledby") ?? "wascanceledby") + " from ( select  unnest(@ssId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@Id, "id") ?? "id") + ",  unnest(@ssOrderApprovalId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@OrderApprovalId, "orderapprovalid") ?? "orderapprovalid") + ",  unnest(@ssLevelNumber) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@LevelNumber, "levelnumber") ?? "levelnumber") + ",  unnest(@ssEntraRoleId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@EntraRoleId, "entraroleid") ?? "entraroleid") + ",  unnest(@ssAssignedTo) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@AssignedTo, "assignedto") ?? "assignedto") + ",  unnest(@ssAssignedOn) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@AssignedOn, "assignedon") ?? "assignedon") + ",  unnest(@ssApprovalStatusId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@ApprovalStatusId, "approvalstatusid") ?? "approvalstatusid") + ",  unnest(@ssApprovedBy) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@ApprovedBy, "approvedby") ?? "approvedby") + ",  unnest(@ssApprovedOn) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@ApprovedOn, "approvedon") ?? "approvedon") + ",  unnest(@ssRejectedBy) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@RejectedBy, "rejectedby") ?? "rejectedby") + ",  unnest(@ssRejectedOn) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@RejectedOn, "rejectedon") ?? "rejectedon") + ",  unnest(@ssIsComplement) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@IsComplement, "iscomplement") ?? "iscomplement") + ",  unnest(@ssIsReassigned) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@IsReassigned, "isreassigned") ?? "isreassigned") + ",  unnest(@ssIsSubstituteFor) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@IsSubstituteFor, "issubstitutefor") ?? "issubstitutefor") + ",  unnest(@ssToModifyBy) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@ToModifyBy, "tomodifyby") ?? "tomodifyby") + ",  unnest(@ssToModifyOn) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@ToModifyOn, "tomodifyon") ?? "tomodifyon") + ",  unnest(@ssWasCanceledBy) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@WasCanceledBy, "wascanceledby") ?? "wascanceledby") + " ) as updateTable where " + entityTableName + "." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@Id, "id") ?? "id") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@Id, "id") ?? "id") + " ";
updateSql += "";

List<object> insertOrderApprovalIdList = new List<object>();
List<int> insertLevelNumberList = new List<int>();
List<object> insertEntraRoleIdList = new List<object>();
List<object> insertAssignedToList = new List<object>();
List<DateTime> insertAssignedOnList = new List<DateTime>();
List<object> insertApprovalStatusIdList = new List<object>();
List<object> insertApprovedByList = new List<object>();
List<DateTime> insertApprovedOnList = new List<DateTime>();
List<object> insertRejectedByList = new List<object>();
List<DateTime> insertRejectedOnList = new List<DateTime>();
List<bool> insertIsComplementList = new List<bool>();
List<bool> insertIsReassignedList = new List<bool>();
List<object> insertIsSubstituteForList = new List<object>();
List<object> insertToModifyByList = new List<object>();
List<DateTime> insertToModifyOnList = new List<DateTime>();
List<object> insertWasCanceledByList = new List<object>();

List<long> updateIdList = new List<long>();
List<object> updateOrderApprovalIdList = new List<object>();
List<int> updateLevelNumberList = new List<int>();
List<object> updateEntraRoleIdList = new List<object>();
List<object> updateAssignedToList = new List<object>();
List<DateTime> updateAssignedOnList = new List<DateTime>();
List<object> updateApprovalStatusIdList = new List<object>();
List<object> updateApprovedByList = new List<object>();
List<DateTime> updateApprovedOnList = new List<DateTime>();
List<object> updateRejectedByList = new List<object>();
List<DateTime> updateRejectedOnList = new List<DateTime>();
List<bool> updateIsComplementList = new List<bool>();
List<bool> updateIsReassignedList = new List<bool>();
List<object> updateIsSubstituteForList = new List<object>();
List<object> updateToModifyByList = new List<object>();
List<DateTime> updateToModifyOnList = new List<DateTime>();
List<object> updateWasCanceledByList = new List<object>();

var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_ff8382bb6fb6cc7d57ecda7bb499922f)inParamSourceList.Current).ssENOrderApprovalLevel;
if (record.ssId != 0L) {
updateIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
if ((record.ssOrderApprovalId==0L)) {
updateOrderApprovalIdList.Add(null);
} else {
updateOrderApprovalIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssOrderApprovalId));
}
updateLevelNumberList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssLevelNumber));
if ((record.ssEntraRoleId==0L)) {
updateEntraRoleIdList.Add(null);
} else {
updateEntraRoleIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssEntraRoleId));
}
if ((record.ssAssignedTo=="")) {
updateAssignedToList.Add(null);
} else {
updateAssignedToList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssAssignedTo));
}
updateAssignedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssAssignedOn));
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
if ((record.ssRejectedBy=="")) {
updateRejectedByList.Add(null);
} else {
updateRejectedByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssRejectedBy));
}
updateRejectedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssRejectedOn));
updateIsComplementList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsComplement));
updateIsReassignedList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsReassigned));
if ((record.ssIsSubstituteFor=="")) {
updateIsSubstituteForList.Add(null);
} else {
updateIsSubstituteForList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssIsSubstituteFor));
}
if ((record.ssToModifyBy=="")) {
updateToModifyByList.Add(null);
} else {
updateToModifyByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssToModifyBy));
}
updateToModifyOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssToModifyOn));
if ((record.ssWasCanceledBy=="")) {
updateWasCanceledByList.Add(null);
} else {
updateWasCanceledByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssWasCanceledBy));
}
} else {
if ((record.ssOrderApprovalId==0L)) {
insertOrderApprovalIdList.Add(null);
} else {
insertOrderApprovalIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssOrderApprovalId));
}
insertLevelNumberList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssLevelNumber));
if ((record.ssEntraRoleId==0L)) {
insertEntraRoleIdList.Add(null);
} else {
insertEntraRoleIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssEntraRoleId));
}
if ((record.ssAssignedTo=="")) {
insertAssignedToList.Add(null);
} else {
insertAssignedToList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssAssignedTo));
}
insertAssignedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssAssignedOn));
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
if ((record.ssRejectedBy=="")) {
insertRejectedByList.Add(null);
} else {
insertRejectedByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssRejectedBy));
}
insertRejectedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssRejectedOn));
insertIsComplementList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsComplement));
insertIsReassignedList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsReassigned));
if ((record.ssIsSubstituteFor=="")) {
insertIsSubstituteForList.Add(null);
} else {
insertIsSubstituteForList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssIsSubstituteFor));
}
if ((record.ssToModifyBy=="")) {
insertToModifyByList.Add(null);
} else {
insertToModifyByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssToModifyBy));
}
insertToModifyOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssToModifyOn));
if ((record.ssWasCanceledBy=="")) {
insertWasCanceledByList.Add(null);
} else {
insertWasCanceledByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssWasCanceledBy));
}
}
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertOrderApprovalIdList.IsEmpty() || !insertLevelNumberList.IsEmpty() || !insertEntraRoleIdList.IsEmpty() || !insertAssignedToList.IsEmpty() || !insertAssignedOnList.IsEmpty() || !insertApprovalStatusIdList.IsEmpty() || !insertApprovedByList.IsEmpty() || !insertApprovedOnList.IsEmpty() || !insertRejectedByList.IsEmpty() || !insertRejectedOnList.IsEmpty() || !insertIsComplementList.IsEmpty() || !insertIsReassignedList.IsEmpty() || !insertIsSubstituteForList.IsEmpty() || !insertToModifyByList.IsEmpty() || !insertToModifyOnList.IsEmpty() || !insertWasCanceledByList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssOrderApprovalId",DbType.Int64,insertOrderApprovalIdList);
executionService.CreateParameter(insertSqlCmd,"@ssLevelNumber",DbType.Int32,insertLevelNumberList);
executionService.CreateParameter(insertSqlCmd,"@ssEntraRoleId",DbType.Int64,insertEntraRoleIdList);
executionService.CreateParameter(insertSqlCmd,"@ssAssignedTo",DbType.String,insertAssignedToList);
executionService.CreateParameter(insertSqlCmd,"@ssAssignedOn",DbType.DateTime,insertAssignedOnList);
executionService.CreateParameter(insertSqlCmd,"@ssApprovalStatusId",DbType.Int32,insertApprovalStatusIdList);
executionService.CreateParameter(insertSqlCmd,"@ssApprovedBy",DbType.String,insertApprovedByList);
executionService.CreateParameter(insertSqlCmd,"@ssApprovedOn",DbType.DateTime,insertApprovedOnList);
executionService.CreateParameter(insertSqlCmd,"@ssRejectedBy",DbType.String,insertRejectedByList);
executionService.CreateParameter(insertSqlCmd,"@ssRejectedOn",DbType.DateTime,insertRejectedOnList);
executionService.CreateParameter(insertSqlCmd,"@ssIsComplement",DbType.Boolean,insertIsComplementList);
executionService.CreateParameter(insertSqlCmd,"@ssIsReassigned",DbType.Boolean,insertIsReassignedList);
executionService.CreateParameter(insertSqlCmd,"@ssIsSubstituteFor",DbType.String,insertIsSubstituteForList);
executionService.CreateParameter(insertSqlCmd,"@ssToModifyBy",DbType.String,insertToModifyByList);
executionService.CreateParameter(insertSqlCmd,"@ssToModifyOn",DbType.DateTime,insertToModifyOnList);
executionService.CreateParameter(insertSqlCmd,"@ssWasCanceledBy",DbType.String,insertWasCanceledByList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeOrderApprovalLevel (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
if(!updateOrderApprovalIdList.IsEmpty() || !updateLevelNumberList.IsEmpty() || !updateEntraRoleIdList.IsEmpty() || !updateAssignedToList.IsEmpty() || !updateAssignedOnList.IsEmpty() || !updateApprovalStatusIdList.IsEmpty() || !updateApprovedByList.IsEmpty() || !updateApprovedOnList.IsEmpty() || !updateRejectedByList.IsEmpty() || !updateRejectedOnList.IsEmpty() || !updateIsComplementList.IsEmpty() || !updateIsReassignedList.IsEmpty() || !updateIsSubstituteForList.IsEmpty() || !updateToModifyByList.IsEmpty() || !updateToModifyOnList.IsEmpty() || !updateWasCanceledByList.IsEmpty()){
await using(var updateSqlCmd = trans.CreateCommand(updateSql)){
executionService.CreateParameter(updateSqlCmd,"@ssId",DbType.Int64,updateIdList);
executionService.CreateParameter(updateSqlCmd,"@ssOrderApprovalId",DbType.Int64,updateOrderApprovalIdList);
executionService.CreateParameter(updateSqlCmd,"@ssLevelNumber",DbType.Int32,updateLevelNumberList);
executionService.CreateParameter(updateSqlCmd,"@ssEntraRoleId",DbType.Int64,updateEntraRoleIdList);
executionService.CreateParameter(updateSqlCmd,"@ssAssignedTo",DbType.String,updateAssignedToList);
executionService.CreateParameter(updateSqlCmd,"@ssAssignedOn",DbType.DateTime,updateAssignedOnList);
executionService.CreateParameter(updateSqlCmd,"@ssApprovalStatusId",DbType.Int32,updateApprovalStatusIdList);
executionService.CreateParameter(updateSqlCmd,"@ssApprovedBy",DbType.String,updateApprovedByList);
executionService.CreateParameter(updateSqlCmd,"@ssApprovedOn",DbType.DateTime,updateApprovedOnList);
executionService.CreateParameter(updateSqlCmd,"@ssRejectedBy",DbType.String,updateRejectedByList);
executionService.CreateParameter(updateSqlCmd,"@ssRejectedOn",DbType.DateTime,updateRejectedOnList);
executionService.CreateParameter(updateSqlCmd,"@ssIsComplement",DbType.Boolean,updateIsComplementList);
executionService.CreateParameter(updateSqlCmd,"@ssIsReassigned",DbType.Boolean,updateIsReassignedList);
executionService.CreateParameter(updateSqlCmd,"@ssIsSubstituteFor",DbType.String,updateIsSubstituteForList);
executionService.CreateParameter(updateSqlCmd,"@ssToModifyBy",DbType.String,updateToModifyByList);
executionService.CreateParameter(updateSqlCmd,"@ssToModifyOn",DbType.DateTime,updateToModifyOnList);
executionService.CreateParameter(updateSqlCmd,"@ssWasCanceledBy",DbType.String,updateWasCanceledByList);
await updateSqlCmd.PrepareAsync(cancellationToken);
await updateSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeOrderApprovalLevel (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(updateSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteOrderApprovalLevel
/// </summary>

public static async Task DeleteOrderApprovalLevel(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteOrderApprovalLevel", "c6ad5773-2f47-4166-b537-1bc6f31bbf81.#DeleteEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteOrderApprovalLevel", "c6ad5773-2f47-4166-b537-1bc6f31bbf81.#DeleteEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENOrderApprovalLevelEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteOrderApprovalLevel", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllOrderApprovalLevel
/// </summary>

public static async Task DeleteAllOrderApprovalLevel(IRequestContext requestContext,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteAllOrderApprovalLevel", "c6ad5773-2f47-4166-b537-1bc6f31bbf81.#DeleteAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllOrderApprovalLevel", "c6ad5773-2f47-4166-b537-1bc6f31bbf81.#DeleteAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENOrderApprovalLevelEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteOrderApprovalLevel", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetOrderApprovalLevel
/// </summary>

public static async Task<RC_ff8382bb6fb6cc7d57ecda7bb499922f> GetOrderApprovalLevel(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_ff8382bb6fb6cc7d57ecda7bb499922f outParamRecord = default;
outParamRecord = new RC_ff8382bb6fb6cc7d57ecda7bb499922f();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetOrderApprovalLevel", "c6ad5773-2f47-4166-b537-1bc6f31bbf81.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetOrderApprovalLevel", "c6ad5773-2f47-4166-b537-1bc6f31bbf81.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@OrderApprovalId, "orderapprovalid") ?? "orderapprovalid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@LevelNumber, "levelnumber") ?? "levelnumber", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@EntraRoleId, "entraroleid") ?? "entraroleid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@AssignedTo, "assignedto") ?? "assignedto", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@AssignedOn, "assignedon") ?? "assignedon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@ApprovalStatusId, "approvalstatusid") ?? "approvalstatusid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@ApprovedBy, "approvedby") ?? "approvedby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@ApprovedOn, "approvedon") ?? "approvedon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@RejectedBy, "rejectedby") ?? "rejectedby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@RejectedOn, "rejectedon") ?? "rejectedon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@IsComplement, "iscomplement") ?? "iscomplement", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@IsReassigned, "isreassigned") ?? "isreassigned", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@IsSubstituteFor, "issubstitutefor") ?? "issubstitutefor", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@ToModifyBy, "tomodifyby") ?? "tomodifyby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@ToModifyOn, "tomodifyon") ?? "tomodifyon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@WasCanceledBy, "wascanceledby") ?? "wascanceledby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
" FROM " + ENOrderApprovalLevelEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetOrderApprovalLevel", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(17,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENOrderApprovalLevelEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetOrderApprovalLevelForUpdate
/// </summary>

public static async Task<RC_ff8382bb6fb6cc7d57ecda7bb499922f> GetOrderApprovalLevelForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_ff8382bb6fb6cc7d57ecda7bb499922f outParamRecord = default;
outParamRecord = new RC_ff8382bb6fb6cc7d57ecda7bb499922f();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetOrderApprovalLevelForUpdate", "c6ad5773-2f47-4166-b537-1bc6f31bbf81.#GetEntityForUpdate");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetOrderApprovalLevelForUpdate", "c6ad5773-2f47-4166-b537-1bc6f31bbf81.#GetEntityForUpdate", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@OrderApprovalId, "orderapprovalid") ?? "orderapprovalid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@LevelNumber, "levelnumber") ?? "levelnumber", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@EntraRoleId, "entraroleid") ?? "entraroleid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@AssignedTo, "assignedto") ?? "assignedto", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@AssignedOn, "assignedon") ?? "assignedon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@ApprovalStatusId, "approvalstatusid") ?? "approvalstatusid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@ApprovedBy, "approvedby") ?? "approvedby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@ApprovedOn, "approvedon") ?? "approvedon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@RejectedBy, "rejectedby") ?? "rejectedby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@RejectedOn, "rejectedon") ?? "rejectedon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@IsComplement, "iscomplement") ?? "iscomplement", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@IsReassigned, "isreassigned") ?? "isreassigned", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@IsSubstituteFor, "issubstitutefor") ?? "issubstitutefor", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@ToModifyBy, "tomodifyby") ?? "tomodifyby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@ToModifyOn, "tomodifyon") ?? "tomodifyon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@WasCanceledBy, "wascanceledby") ?? "wascanceledby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
" FROM " + ENOrderApprovalLevelEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@Id, "id") ?? "id") + " = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetOrderApprovalLevelForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(17,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENOrderApprovalLevelEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateOrderApprovalLevel
/// </summary>

public static async Task UpdateOrderApprovalLevel(IRequestContext requestContext,BitArray usedFields,RC_ff8382bb6fb6cc7d57ecda7bb499922f inParamSource,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("UpdateOrderApprovalLevel", "c6ad5773-2f47-4166-b537-1bc6f31bbf81.#UpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateOrderApprovalLevel", "c6ad5773-2f47-4166-b537-1bc6f31bbf81.#UpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_6b660d05e4c0025dff47119642875ca2EntityRecord ssENOrderApprovalLevel = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(17,true);
}
string updateSet = "UPDATE " + ENOrderApprovalLevelEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@OrderApprovalId, "orderapprovalid") ?? "orderapprovalid") + " = @ssOrderApprovalId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@LevelNumber, "levelnumber") ?? "levelnumber") + " = @ssLevelNumber"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@EntraRoleId, "entraroleid") ?? "entraroleid") + " = @ssEntraRoleId"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@AssignedTo, "assignedto") ?? "assignedto") + " = @ssAssignedTo"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@AssignedOn, "assignedon") ?? "assignedon") + " = @ssAssignedOn"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@ApprovalStatusId, "approvalstatusid") ?? "approvalstatusid") + " = @ssApprovalStatusId"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@ApprovedBy, "approvedby") ?? "approvedby") + " = @ssApprovedBy"): parameters);
parameters = (usedFields[8] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@ApprovedOn, "approvedon") ?? "approvedon") + " = @ssApprovedOn"): parameters);
parameters = (usedFields[9] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@RejectedBy, "rejectedby") ?? "rejectedby") + " = @ssRejectedBy"): parameters);
parameters = (usedFields[10] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@RejectedOn, "rejectedon") ?? "rejectedon") + " = @ssRejectedOn"): parameters);
parameters = (usedFields[11] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@IsComplement, "iscomplement") ?? "iscomplement") + " = @ssIsComplement"): parameters);
parameters = (usedFields[12] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@IsReassigned, "isreassigned") ?? "isreassigned") + " = @ssIsReassigned"): parameters);
parameters = (usedFields[13] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@IsSubstituteFor, "issubstitutefor") ?? "issubstitutefor") + " = @ssIsSubstituteFor"): parameters);
parameters = (usedFields[14] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@ToModifyBy, "tomodifyby") ?? "tomodifyby") + " = @ssToModifyBy"): parameters);
parameters = (usedFields[15] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@ToModifyOn, "tomodifyon") ?? "tomodifyon") + " = @ssToModifyOn"): parameters);
parameters = (usedFields[16] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@WasCanceledBy, "wascanceledby") ?? "wascanceledby") + " = @ssWasCanceledBy"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENOrderApprovalLevel_ssId_OrderApprovalLevel";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@IsComplement, "iscomplement") ?? "iscomplement") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@IsComplement, "iscomplement") ?? "iscomplement") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENOrderApprovalLevel.ssOrderApprovalId==0L)) {
sqlCmd.CreateParameter("@ssOrderApprovalId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssOrderApprovalId", DbType.Int64, ssENOrderApprovalLevel.ssOrderApprovalId);

}
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssLevelNumber", DbType.Int32, ssENOrderApprovalLevel.ssLevelNumber);
}
if(usedFields[3]) {
if ((ssENOrderApprovalLevel.ssEntraRoleId==0L)) {
sqlCmd.CreateParameter("@ssEntraRoleId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssEntraRoleId", DbType.Int64, ssENOrderApprovalLevel.ssEntraRoleId);

}
}
if(usedFields[4]) {
if ((ssENOrderApprovalLevel.ssAssignedTo=="")) {
sqlCmd.CreateParameter("@ssAssignedTo", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssAssignedTo", DbType.String, ssENOrderApprovalLevel.ssAssignedTo);

}
}
if(usedFields[5]) {
sqlCmd.CreateParameter("@ssAssignedOn", DbType.DateTime, ssENOrderApprovalLevel.ssAssignedOn);
}
if(usedFields[6]) {
if ((ssENOrderApprovalLevel.ssApprovalStatusId==0)) {
sqlCmd.CreateParameter("@ssApprovalStatusId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssApprovalStatusId", DbType.Int32, ssENOrderApprovalLevel.ssApprovalStatusId);

}
}
if(usedFields[7]) {
if ((ssENOrderApprovalLevel.ssApprovedBy=="")) {
sqlCmd.CreateParameter("@ssApprovedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssApprovedBy", DbType.String, ssENOrderApprovalLevel.ssApprovedBy);

}
}
if(usedFields[8]) {
sqlCmd.CreateParameter("@ssApprovedOn", DbType.DateTime, ssENOrderApprovalLevel.ssApprovedOn);
}
if(usedFields[9]) {
if ((ssENOrderApprovalLevel.ssRejectedBy=="")) {
sqlCmd.CreateParameter("@ssRejectedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssRejectedBy", DbType.String, ssENOrderApprovalLevel.ssRejectedBy);

}
}
if(usedFields[10]) {
sqlCmd.CreateParameter("@ssRejectedOn", DbType.DateTime, ssENOrderApprovalLevel.ssRejectedOn);
}
if(usedFields[11]) {
sqlCmd.CreateParameter("@ssIsComplement", DbType.Boolean, ssENOrderApprovalLevel.ssIsComplement);
}
if(usedFields[12]) {
sqlCmd.CreateParameter("@ssIsReassigned", DbType.Boolean, ssENOrderApprovalLevel.ssIsReassigned);
}
if(usedFields[13]) {
if ((ssENOrderApprovalLevel.ssIsSubstituteFor=="")) {
sqlCmd.CreateParameter("@ssIsSubstituteFor", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssIsSubstituteFor", DbType.String, ssENOrderApprovalLevel.ssIsSubstituteFor);

}
}
if(usedFields[14]) {
if ((ssENOrderApprovalLevel.ssToModifyBy=="")) {
sqlCmd.CreateParameter("@ssToModifyBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssToModifyBy", DbType.String, ssENOrderApprovalLevel.ssToModifyBy);

}
}
if(usedFields[15]) {
sqlCmd.CreateParameter("@ssToModifyOn", DbType.DateTime, ssENOrderApprovalLevel.ssToModifyOn);
}
if(usedFields[16]) {
if ((ssENOrderApprovalLevel.ssWasCanceledBy=="")) {
sqlCmd.CreateParameter("@ssWasCanceledBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssWasCanceledBy", DbType.String, ssENOrderApprovalLevel.ssWasCanceledBy);

}
}
sqlCmd.CreateParameter("@idparam_ssENOrderApprovalLevel_ssId_OrderApprovalLevel", DbType.Int64, ssENOrderApprovalLevel.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateOrderApprovalLevel", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("OrderApprovalLevel", ssENOrderApprovalLevel.ssId.ToString()); }}
}
return;
}

}
}
