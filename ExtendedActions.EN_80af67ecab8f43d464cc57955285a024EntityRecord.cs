using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateOrderRequestFileApprovalLevel
/// </summary>

public static async Task<long> CreateOrderRequestFileApprovalLevel(IRequestContext requestContext,RC_daa6040aa65b55c2574e6a4e976766ce inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrderRequestFileApprovalLevel", "2226eab2-3395-4540-8bb3-30c80928b458.#CreateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrderRequestFileApprovalLevel", "2226eab2-3395-4540-8bb3-30c80928b458.#CreateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_80af67ecab8f43d464cc57955285a024EntityRecord ssENOrderRequestFileApprovalLevel = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENOrderRequestFileApprovalLevelEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@OrderRequestFileApprovalId, "orderrequestfileapprovalid") ?? "orderrequestfileapprovalid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@LevelNumber, "levelnumber") ?? "levelnumber") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@EntraRoleId, "entraroleid") ?? "entraroleid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@AssignedTo, "assignedto") ?? "assignedto") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@ApprovalStatusId, "approvalstatusid") ?? "approvalstatusid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@ApprovedBy, "approvedby") ?? "approvedby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@ApprovedOn, "approvedon") ?? "approvedon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@RejectedBy, "rejectedby") ?? "rejectedby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@RejectedOn, "rejectedon") ?? "rejectedon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@IsReassigned, "isreassigned") ?? "isreassigned") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@IsSubstituteFor, "issubstitutefor") ?? "issubstitutefor") + "" +
" ) VALUES (" +
" @ssOrderRequestFileApprovalId" +
", @ssLevelNumber" +
", @ssEntraRoleId" +
", @ssAssignedTo" +
", @ssApprovalStatusId" +
", @ssApprovedBy" +
", @ssApprovedOn" +
", @ssRejectedBy" +
", @ssRejectedOn" +
", @ssIsReassigned" +
", @ssIsSubstituteFor" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENOrderRequestFileApprovalLevel.ssOrderRequestFileApprovalId==0L)) {
insertSqlCmd.CreateParameter("@ssOrderRequestFileApprovalId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssOrderRequestFileApprovalId", DbType.Int64, ssENOrderRequestFileApprovalLevel.ssOrderRequestFileApprovalId);

}
insertSqlCmd.CreateParameter("@ssLevelNumber", DbType.Int32, ssENOrderRequestFileApprovalLevel.ssLevelNumber);
if ((ssENOrderRequestFileApprovalLevel.ssEntraRoleId==0L)) {
insertSqlCmd.CreateParameter("@ssEntraRoleId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssEntraRoleId", DbType.Int64, ssENOrderRequestFileApprovalLevel.ssEntraRoleId);

}
if ((ssENOrderRequestFileApprovalLevel.ssAssignedTo=="")) {
insertSqlCmd.CreateParameter("@ssAssignedTo", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssAssignedTo", DbType.String, ssENOrderRequestFileApprovalLevel.ssAssignedTo);

}
if ((ssENOrderRequestFileApprovalLevel.ssApprovalStatusId==0)) {
insertSqlCmd.CreateParameter("@ssApprovalStatusId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssApprovalStatusId", DbType.Int32, ssENOrderRequestFileApprovalLevel.ssApprovalStatusId);

}
if ((ssENOrderRequestFileApprovalLevel.ssApprovedBy=="")) {
insertSqlCmd.CreateParameter("@ssApprovedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssApprovedBy", DbType.String, ssENOrderRequestFileApprovalLevel.ssApprovedBy);

}
insertSqlCmd.CreateParameter("@ssApprovedOn", DbType.DateTime, ssENOrderRequestFileApprovalLevel.ssApprovedOn);
if ((ssENOrderRequestFileApprovalLevel.ssRejectedBy=="")) {
insertSqlCmd.CreateParameter("@ssRejectedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssRejectedBy", DbType.String, ssENOrderRequestFileApprovalLevel.ssRejectedBy);

}
insertSqlCmd.CreateParameter("@ssRejectedOn", DbType.DateTime, ssENOrderRequestFileApprovalLevel.ssRejectedOn);
insertSqlCmd.CreateParameter("@ssIsReassigned", DbType.Boolean, ssENOrderRequestFileApprovalLevel.ssIsReassigned);
if ((ssENOrderRequestFileApprovalLevel.ssIsSubstituteFor=="")) {
insertSqlCmd.CreateParameter("@ssIsSubstituteFor", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssIsSubstituteFor", DbType.String, ssENOrderRequestFileApprovalLevel.ssIsSubstituteFor);

}
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrderRequestFileApprovalLevel", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateOrderRequestFileApprovalLevel
/// </summary>

public static async Task<long> CreateOrUpdateOrderRequestFileApprovalLevel(IRequestContext requestContext,BitArray usedFields,RC_daa6040aa65b55c2574e6a4e976766ce inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateOrderRequestFileApprovalLevel", "2226eab2-3395-4540-8bb3-30c80928b458.#CreateOrUpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateOrderRequestFileApprovalLevel", "2226eab2-3395-4540-8bb3-30c80928b458.#CreateOrUpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_80af67ecab8f43d464cc57955285a024EntityRecord ssENOrderRequestFileApprovalLevel = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(12,true);
}
string updateSet = "UPDATE " + ENOrderRequestFileApprovalLevelEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@OrderRequestFileApprovalId, "orderrequestfileapprovalid") ?? "orderrequestfileapprovalid") + " = @ssOrderRequestFileApprovalId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@LevelNumber, "levelnumber") ?? "levelnumber") + " = @ssLevelNumber"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@EntraRoleId, "entraroleid") ?? "entraroleid") + " = @ssEntraRoleId"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@AssignedTo, "assignedto") ?? "assignedto") + " = @ssAssignedTo"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@ApprovalStatusId, "approvalstatusid") ?? "approvalstatusid") + " = @ssApprovalStatusId"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@ApprovedBy, "approvedby") ?? "approvedby") + " = @ssApprovedBy"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@ApprovedOn, "approvedon") ?? "approvedon") + " = @ssApprovedOn"): parameters);
parameters = (usedFields[8] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@RejectedBy, "rejectedby") ?? "rejectedby") + " = @ssRejectedBy"): parameters);
parameters = (usedFields[9] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@RejectedOn, "rejectedon") ?? "rejectedon") + " = @ssRejectedOn"): parameters);
parameters = (usedFields[10] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@IsReassigned, "isreassigned") ?? "isreassigned") + " = @ssIsReassigned"): parameters);
parameters = (usedFields[11] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@IsSubstituteFor, "issubstitutefor") ?? "issubstitutefor") + " = @ssIsSubstituteFor"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENOrderRequeeApprovalLevel_OrderRequestFApprovalLevel";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@IsReassigned, "isreassigned") ?? "isreassigned") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@IsReassigned, "isreassigned") ?? "isreassigned") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENOrderRequestFileApprovalLevel.ssOrderRequestFileApprovalId==0L)) {
sqlCmd.CreateParameter("@ssOrderRequestFileApprovalId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssOrderRequestFileApprovalId", DbType.Int64, ssENOrderRequestFileApprovalLevel.ssOrderRequestFileApprovalId);

}
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssLevelNumber", DbType.Int32, ssENOrderRequestFileApprovalLevel.ssLevelNumber);
}
if(usedFields[3]) {
if ((ssENOrderRequestFileApprovalLevel.ssEntraRoleId==0L)) {
sqlCmd.CreateParameter("@ssEntraRoleId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssEntraRoleId", DbType.Int64, ssENOrderRequestFileApprovalLevel.ssEntraRoleId);

}
}
if(usedFields[4]) {
if ((ssENOrderRequestFileApprovalLevel.ssAssignedTo=="")) {
sqlCmd.CreateParameter("@ssAssignedTo", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssAssignedTo", DbType.String, ssENOrderRequestFileApprovalLevel.ssAssignedTo);

}
}
if(usedFields[5]) {
if ((ssENOrderRequestFileApprovalLevel.ssApprovalStatusId==0)) {
sqlCmd.CreateParameter("@ssApprovalStatusId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssApprovalStatusId", DbType.Int32, ssENOrderRequestFileApprovalLevel.ssApprovalStatusId);

}
}
if(usedFields[6]) {
if ((ssENOrderRequestFileApprovalLevel.ssApprovedBy=="")) {
sqlCmd.CreateParameter("@ssApprovedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssApprovedBy", DbType.String, ssENOrderRequestFileApprovalLevel.ssApprovedBy);

}
}
if(usedFields[7]) {
sqlCmd.CreateParameter("@ssApprovedOn", DbType.DateTime, ssENOrderRequestFileApprovalLevel.ssApprovedOn);
}
if(usedFields[8]) {
if ((ssENOrderRequestFileApprovalLevel.ssRejectedBy=="")) {
sqlCmd.CreateParameter("@ssRejectedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssRejectedBy", DbType.String, ssENOrderRequestFileApprovalLevel.ssRejectedBy);

}
}
if(usedFields[9]) {
sqlCmd.CreateParameter("@ssRejectedOn", DbType.DateTime, ssENOrderRequestFileApprovalLevel.ssRejectedOn);
}
if(usedFields[10]) {
sqlCmd.CreateParameter("@ssIsReassigned", DbType.Boolean, ssENOrderRequestFileApprovalLevel.ssIsReassigned);
}
if(usedFields[11]) {
if ((ssENOrderRequestFileApprovalLevel.ssIsSubstituteFor=="")) {
sqlCmd.CreateParameter("@ssIsSubstituteFor", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssIsSubstituteFor", DbType.String, ssENOrderRequestFileApprovalLevel.ssIsSubstituteFor);

}
}
sqlCmd.CreateParameter("@idparam_ssENOrderRequeeApprovalLevel_OrderRequestFApprovalLevel", DbType.Int64, ssENOrderRequestFileApprovalLevel.ssId);
int counter = 0;
if(ssENOrderRequestFileApprovalLevel.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateOrderRequestFileApprovalLevel (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENOrderRequestFileApprovalLevelEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@OrderRequestFileApprovalId, "orderrequestfileapprovalid") ?? "orderrequestfileapprovalid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@LevelNumber, "levelnumber") ?? "levelnumber") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@EntraRoleId, "entraroleid") ?? "entraroleid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@AssignedTo, "assignedto") ?? "assignedto") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@ApprovalStatusId, "approvalstatusid") ?? "approvalstatusid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@ApprovedBy, "approvedby") ?? "approvedby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@ApprovedOn, "approvedon") ?? "approvedon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@RejectedBy, "rejectedby") ?? "rejectedby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@RejectedOn, "rejectedon") ?? "rejectedon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@IsReassigned, "isreassigned") ?? "isreassigned") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@IsSubstituteFor, "issubstitutefor") ?? "issubstitutefor") + "" +
" ) VALUES (" +
" @ssOrderRequestFileApprovalId" +
", @ssLevelNumber" +
", @ssEntraRoleId" +
", @ssAssignedTo" +
", @ssApprovalStatusId" +
", @ssApprovedBy" +
", @ssApprovedOn" +
", @ssRejectedBy" +
", @ssRejectedOn" +
", @ssIsReassigned" +
", @ssIsSubstituteFor" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENOrderRequestFileApprovalLevel.ssOrderRequestFileApprovalId==0L)) {
insertSqlCmd.CreateParameter("@ssOrderRequestFileApprovalId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssOrderRequestFileApprovalId", DbType.Int64, ssENOrderRequestFileApprovalLevel.ssOrderRequestFileApprovalId);

}
insertSqlCmd.CreateParameter("@ssLevelNumber", DbType.Int32, ssENOrderRequestFileApprovalLevel.ssLevelNumber);
if ((ssENOrderRequestFileApprovalLevel.ssEntraRoleId==0L)) {
insertSqlCmd.CreateParameter("@ssEntraRoleId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssEntraRoleId", DbType.Int64, ssENOrderRequestFileApprovalLevel.ssEntraRoleId);

}
if ((ssENOrderRequestFileApprovalLevel.ssAssignedTo=="")) {
insertSqlCmd.CreateParameter("@ssAssignedTo", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssAssignedTo", DbType.String, ssENOrderRequestFileApprovalLevel.ssAssignedTo);

}
if ((ssENOrderRequestFileApprovalLevel.ssApprovalStatusId==0)) {
insertSqlCmd.CreateParameter("@ssApprovalStatusId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssApprovalStatusId", DbType.Int32, ssENOrderRequestFileApprovalLevel.ssApprovalStatusId);

}
if ((ssENOrderRequestFileApprovalLevel.ssApprovedBy=="")) {
insertSqlCmd.CreateParameter("@ssApprovedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssApprovedBy", DbType.String, ssENOrderRequestFileApprovalLevel.ssApprovedBy);

}
insertSqlCmd.CreateParameter("@ssApprovedOn", DbType.DateTime, ssENOrderRequestFileApprovalLevel.ssApprovedOn);
if ((ssENOrderRequestFileApprovalLevel.ssRejectedBy=="")) {
insertSqlCmd.CreateParameter("@ssRejectedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssRejectedBy", DbType.String, ssENOrderRequestFileApprovalLevel.ssRejectedBy);

}
insertSqlCmd.CreateParameter("@ssRejectedOn", DbType.DateTime, ssENOrderRequestFileApprovalLevel.ssRejectedOn);
insertSqlCmd.CreateParameter("@ssIsReassigned", DbType.Boolean, ssENOrderRequestFileApprovalLevel.ssIsReassigned);
if ((ssENOrderRequestFileApprovalLevel.ssIsSubstituteFor=="")) {
insertSqlCmd.CreateParameter("@ssIsSubstituteFor", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssIsSubstituteFor", DbType.String, ssENOrderRequestFileApprovalLevel.ssIsSubstituteFor);

}
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateOrderRequestFileApprovalLevel", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENOrderRequestFileApprovalLevel.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeOrderRequestFileApprovalLevel
/// </summary>

public static async Task CreateOrUpdateSomeOrderRequestFileApprovalLevel(IRequestContext requestContext,RL_1812a591b87097467375f4f1d26f72aa inParamSourceList,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateSomeOrderRequestFileApprovalLevel", "2226eab2-3395-4540-8bb3-30c80928b458.#CreateOrUpdateAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeOrderRequestFileApprovalLevel", "2226eab2-3395-4540-8bb3-30c80928b458.#CreateOrUpdateAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
string entityTableName = ENOrderRequestFileApprovalLevelEntity.LocalViewName(null);
string insertSql = "INSERT INTO " + entityTableName + " (" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@OrderRequestFileApprovalId, "orderrequestfileapprovalid") ?? "orderrequestfileapprovalid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@LevelNumber, "levelnumber") ?? "levelnumber") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@EntraRoleId, "entraroleid") ?? "entraroleid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@AssignedTo, "assignedto") ?? "assignedto") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@ApprovalStatusId, "approvalstatusid") ?? "approvalstatusid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@ApprovedBy, "approvedby") ?? "approvedby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@ApprovedOn, "approvedon") ?? "approvedon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@RejectedBy, "rejectedby") ?? "rejectedby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@RejectedOn, "rejectedon") ?? "rejectedon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@IsReassigned, "isreassigned") ?? "isreassigned") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@IsSubstituteFor, "issubstitutefor") ?? "issubstitutefor") + ") VALUES ( unnest(@ssOrderRequestFileApprovalId),  unnest(@ssLevelNumber),  unnest(@ssEntraRoleId),  unnest(@ssAssignedTo),  unnest(@ssApprovalStatusId),  unnest(@ssApprovedBy),  unnest(@ssApprovedOn),  unnest(@ssRejectedBy),  unnest(@ssRejectedOn),  unnest(@ssIsReassigned),  unnest(@ssIsSubstituteFor)) ";
insertSql += "";

string updateSql = "UPDATE " + entityTableName + " SET " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@OrderRequestFileApprovalId, "orderrequestfileapprovalid") ?? "orderrequestfileapprovalid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@OrderRequestFileApprovalId, "orderrequestfileapprovalid") ?? "orderrequestfileapprovalid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@LevelNumber, "levelnumber") ?? "levelnumber") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@LevelNumber, "levelnumber") ?? "levelnumber") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@EntraRoleId, "entraroleid") ?? "entraroleid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@EntraRoleId, "entraroleid") ?? "entraroleid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@AssignedTo, "assignedto") ?? "assignedto") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@AssignedTo, "assignedto") ?? "assignedto") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@ApprovalStatusId, "approvalstatusid") ?? "approvalstatusid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@ApprovalStatusId, "approvalstatusid") ?? "approvalstatusid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@ApprovedBy, "approvedby") ?? "approvedby") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@ApprovedBy, "approvedby") ?? "approvedby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@ApprovedOn, "approvedon") ?? "approvedon") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@ApprovedOn, "approvedon") ?? "approvedon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@RejectedBy, "rejectedby") ?? "rejectedby") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@RejectedBy, "rejectedby") ?? "rejectedby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@RejectedOn, "rejectedon") ?? "rejectedon") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@RejectedOn, "rejectedon") ?? "rejectedon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@IsReassigned, "isreassigned") ?? "isreassigned") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@IsReassigned, "isreassigned") ?? "isreassigned") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@IsSubstituteFor, "issubstitutefor") ?? "issubstitutefor") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@IsSubstituteFor, "issubstitutefor") ?? "issubstitutefor") + " from ( select  unnest(@ssId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@Id, "id") ?? "id") + ",  unnest(@ssOrderRequestFileApprovalId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@OrderRequestFileApprovalId, "orderrequestfileapprovalid") ?? "orderrequestfileapprovalid") + ",  unnest(@ssLevelNumber) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@LevelNumber, "levelnumber") ?? "levelnumber") + ",  unnest(@ssEntraRoleId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@EntraRoleId, "entraroleid") ?? "entraroleid") + ",  unnest(@ssAssignedTo) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@AssignedTo, "assignedto") ?? "assignedto") + ",  unnest(@ssApprovalStatusId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@ApprovalStatusId, "approvalstatusid") ?? "approvalstatusid") + ",  unnest(@ssApprovedBy) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@ApprovedBy, "approvedby") ?? "approvedby") + ",  unnest(@ssApprovedOn) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@ApprovedOn, "approvedon") ?? "approvedon") + ",  unnest(@ssRejectedBy) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@RejectedBy, "rejectedby") ?? "rejectedby") + ",  unnest(@ssRejectedOn) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@RejectedOn, "rejectedon") ?? "rejectedon") + ",  unnest(@ssIsReassigned) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@IsReassigned, "isreassigned") ?? "isreassigned") + ",  unnest(@ssIsSubstituteFor) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@IsSubstituteFor, "issubstitutefor") ?? "issubstitutefor") + " ) as updateTable where " + entityTableName + "." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@Id, "id") ?? "id") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@Id, "id") ?? "id") + " ";
updateSql += "";

List<object> insertOrderRequestFileApprovalIdList = new List<object>();
List<int> insertLevelNumberList = new List<int>();
List<object> insertEntraRoleIdList = new List<object>();
List<object> insertAssignedToList = new List<object>();
List<object> insertApprovalStatusIdList = new List<object>();
List<object> insertApprovedByList = new List<object>();
List<DateTime> insertApprovedOnList = new List<DateTime>();
List<object> insertRejectedByList = new List<object>();
List<DateTime> insertRejectedOnList = new List<DateTime>();
List<bool> insertIsReassignedList = new List<bool>();
List<object> insertIsSubstituteForList = new List<object>();

List<long> updateIdList = new List<long>();
List<object> updateOrderRequestFileApprovalIdList = new List<object>();
List<int> updateLevelNumberList = new List<int>();
List<object> updateEntraRoleIdList = new List<object>();
List<object> updateAssignedToList = new List<object>();
List<object> updateApprovalStatusIdList = new List<object>();
List<object> updateApprovedByList = new List<object>();
List<DateTime> updateApprovedOnList = new List<DateTime>();
List<object> updateRejectedByList = new List<object>();
List<DateTime> updateRejectedOnList = new List<DateTime>();
List<bool> updateIsReassignedList = new List<bool>();
List<object> updateIsSubstituteForList = new List<object>();

var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_daa6040aa65b55c2574e6a4e976766ce)inParamSourceList.Current).ssENOrderRequestFileApprovalLevel;
if (record.ssId != 0L) {
updateIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
if ((record.ssOrderRequestFileApprovalId==0L)) {
updateOrderRequestFileApprovalIdList.Add(null);
} else {
updateOrderRequestFileApprovalIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssOrderRequestFileApprovalId));
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
updateIsReassignedList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsReassigned));
if ((record.ssIsSubstituteFor=="")) {
updateIsSubstituteForList.Add(null);
} else {
updateIsSubstituteForList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssIsSubstituteFor));
}
} else {
if ((record.ssOrderRequestFileApprovalId==0L)) {
insertOrderRequestFileApprovalIdList.Add(null);
} else {
insertOrderRequestFileApprovalIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssOrderRequestFileApprovalId));
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
if (!insertOrderRequestFileApprovalIdList.IsEmpty() || !insertLevelNumberList.IsEmpty() || !insertEntraRoleIdList.IsEmpty() || !insertAssignedToList.IsEmpty() || !insertApprovalStatusIdList.IsEmpty() || !insertApprovedByList.IsEmpty() || !insertApprovedOnList.IsEmpty() || !insertRejectedByList.IsEmpty() || !insertRejectedOnList.IsEmpty() || !insertIsReassignedList.IsEmpty() || !insertIsSubstituteForList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssOrderRequestFileApprovalId",DbType.Int64,insertOrderRequestFileApprovalIdList);
executionService.CreateParameter(insertSqlCmd,"@ssLevelNumber",DbType.Int32,insertLevelNumberList);
executionService.CreateParameter(insertSqlCmd,"@ssEntraRoleId",DbType.Int64,insertEntraRoleIdList);
executionService.CreateParameter(insertSqlCmd,"@ssAssignedTo",DbType.String,insertAssignedToList);
executionService.CreateParameter(insertSqlCmd,"@ssApprovalStatusId",DbType.Int32,insertApprovalStatusIdList);
executionService.CreateParameter(insertSqlCmd,"@ssApprovedBy",DbType.String,insertApprovedByList);
executionService.CreateParameter(insertSqlCmd,"@ssApprovedOn",DbType.DateTime,insertApprovedOnList);
executionService.CreateParameter(insertSqlCmd,"@ssRejectedBy",DbType.String,insertRejectedByList);
executionService.CreateParameter(insertSqlCmd,"@ssRejectedOn",DbType.DateTime,insertRejectedOnList);
executionService.CreateParameter(insertSqlCmd,"@ssIsReassigned",DbType.Boolean,insertIsReassignedList);
executionService.CreateParameter(insertSqlCmd,"@ssIsSubstituteFor",DbType.String,insertIsSubstituteForList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeOrderRequestFileApprovalLevel (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
if(!updateOrderRequestFileApprovalIdList.IsEmpty() || !updateLevelNumberList.IsEmpty() || !updateEntraRoleIdList.IsEmpty() || !updateAssignedToList.IsEmpty() || !updateApprovalStatusIdList.IsEmpty() || !updateApprovedByList.IsEmpty() || !updateApprovedOnList.IsEmpty() || !updateRejectedByList.IsEmpty() || !updateRejectedOnList.IsEmpty() || !updateIsReassignedList.IsEmpty() || !updateIsSubstituteForList.IsEmpty()){
await using(var updateSqlCmd = trans.CreateCommand(updateSql)){
executionService.CreateParameter(updateSqlCmd,"@ssId",DbType.Int64,updateIdList);
executionService.CreateParameter(updateSqlCmd,"@ssOrderRequestFileApprovalId",DbType.Int64,updateOrderRequestFileApprovalIdList);
executionService.CreateParameter(updateSqlCmd,"@ssLevelNumber",DbType.Int32,updateLevelNumberList);
executionService.CreateParameter(updateSqlCmd,"@ssEntraRoleId",DbType.Int64,updateEntraRoleIdList);
executionService.CreateParameter(updateSqlCmd,"@ssAssignedTo",DbType.String,updateAssignedToList);
executionService.CreateParameter(updateSqlCmd,"@ssApprovalStatusId",DbType.Int32,updateApprovalStatusIdList);
executionService.CreateParameter(updateSqlCmd,"@ssApprovedBy",DbType.String,updateApprovedByList);
executionService.CreateParameter(updateSqlCmd,"@ssApprovedOn",DbType.DateTime,updateApprovedOnList);
executionService.CreateParameter(updateSqlCmd,"@ssRejectedBy",DbType.String,updateRejectedByList);
executionService.CreateParameter(updateSqlCmd,"@ssRejectedOn",DbType.DateTime,updateRejectedOnList);
executionService.CreateParameter(updateSqlCmd,"@ssIsReassigned",DbType.Boolean,updateIsReassignedList);
executionService.CreateParameter(updateSqlCmd,"@ssIsSubstituteFor",DbType.String,updateIsSubstituteForList);
await updateSqlCmd.PrepareAsync(cancellationToken);
await updateSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeOrderRequestFileApprovalLevel (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(updateSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteOrderRequestFileApprovalLevel
/// </summary>

public static async Task DeleteOrderRequestFileApprovalLevel(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteOrderRequestFileApprovalLevel", "2226eab2-3395-4540-8bb3-30c80928b458.#DeleteEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteOrderRequestFileApprovalLevel", "2226eab2-3395-4540-8bb3-30c80928b458.#DeleteEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENOrderRequestFileApprovalLevelEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteOrderRequestFileApprovalLevel", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllOrderRequestFileApprovalLevel
/// </summary>

public static async Task DeleteAllOrderRequestFileApprovalLevel(IRequestContext requestContext,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteAllOrderRequestFileApprovalLevel", "2226eab2-3395-4540-8bb3-30c80928b458.#DeleteAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllOrderRequestFileApprovalLevel", "2226eab2-3395-4540-8bb3-30c80928b458.#DeleteAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENOrderRequestFileApprovalLevelEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteOrderRequestFileApprovalLevel", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetOrderRequestFileApprovalLevel
/// </summary>

public static async Task<RC_daa6040aa65b55c2574e6a4e976766ce> GetOrderRequestFileApprovalLevel(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_daa6040aa65b55c2574e6a4e976766ce outParamRecord = default;
outParamRecord = new RC_daa6040aa65b55c2574e6a4e976766ce();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetOrderRequestFileApprovalLevel", "2226eab2-3395-4540-8bb3-30c80928b458.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetOrderRequestFileApprovalLevel", "2226eab2-3395-4540-8bb3-30c80928b458.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@OrderRequestFileApprovalId, "orderrequestfileapprovalid") ?? "orderrequestfileapprovalid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@LevelNumber, "levelnumber") ?? "levelnumber", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@EntraRoleId, "entraroleid") ?? "entraroleid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@AssignedTo, "assignedto") ?? "assignedto", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@ApprovalStatusId, "approvalstatusid") ?? "approvalstatusid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@ApprovedBy, "approvedby") ?? "approvedby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@ApprovedOn, "approvedon") ?? "approvedon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@RejectedBy, "rejectedby") ?? "rejectedby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@RejectedOn, "rejectedon") ?? "rejectedon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@IsReassigned, "isreassigned") ?? "isreassigned", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@IsSubstituteFor, "issubstitutefor") ?? "issubstitutefor", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
" FROM " + ENOrderRequestFileApprovalLevelEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetOrderRequestFileApprovalLevel", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(12,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENOrderRequestFileApprovalLevelEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetOrderRequestFileApprovalLevelForUpdate
/// </summary>

public static async Task<RC_daa6040aa65b55c2574e6a4e976766ce> GetOrderRequestFileApprovalLevelForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_daa6040aa65b55c2574e6a4e976766ce outParamRecord = default;
outParamRecord = new RC_daa6040aa65b55c2574e6a4e976766ce();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetOrderRequestFileApprovalLevelForUpdate", "2226eab2-3395-4540-8bb3-30c80928b458.#GetEntityForUpdate");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetOrderRequestFileApprovalLevelForUpdate", "2226eab2-3395-4540-8bb3-30c80928b458.#GetEntityForUpdate", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@OrderRequestFileApprovalId, "orderrequestfileapprovalid") ?? "orderrequestfileapprovalid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@LevelNumber, "levelnumber") ?? "levelnumber", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@EntraRoleId, "entraroleid") ?? "entraroleid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@AssignedTo, "assignedto") ?? "assignedto", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@ApprovalStatusId, "approvalstatusid") ?? "approvalstatusid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@ApprovedBy, "approvedby") ?? "approvedby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@ApprovedOn, "approvedon") ?? "approvedon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@RejectedBy, "rejectedby") ?? "rejectedby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@RejectedOn, "rejectedon") ?? "rejectedon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@IsReassigned, "isreassigned") ?? "isreassigned", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@IsSubstituteFor, "issubstitutefor") ?? "issubstitutefor", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
" FROM " + ENOrderRequestFileApprovalLevelEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@Id, "id") ?? "id") + " = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetOrderRequestFileApprovalLevelForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(12,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENOrderRequestFileApprovalLevelEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateOrderRequestFileApprovalLevel
/// </summary>

public static async Task UpdateOrderRequestFileApprovalLevel(IRequestContext requestContext,BitArray usedFields,RC_daa6040aa65b55c2574e6a4e976766ce inParamSource,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("UpdateOrderRequestFileApprovalLevel", "2226eab2-3395-4540-8bb3-30c80928b458.#UpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateOrderRequestFileApprovalLevel", "2226eab2-3395-4540-8bb3-30c80928b458.#UpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_80af67ecab8f43d464cc57955285a024EntityRecord ssENOrderRequestFileApprovalLevel = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(12,true);
}
string updateSet = "UPDATE " + ENOrderRequestFileApprovalLevelEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@OrderRequestFileApprovalId, "orderrequestfileapprovalid") ?? "orderrequestfileapprovalid") + " = @ssOrderRequestFileApprovalId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@LevelNumber, "levelnumber") ?? "levelnumber") + " = @ssLevelNumber"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@EntraRoleId, "entraroleid") ?? "entraroleid") + " = @ssEntraRoleId"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@AssignedTo, "assignedto") ?? "assignedto") + " = @ssAssignedTo"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@ApprovalStatusId, "approvalstatusid") ?? "approvalstatusid") + " = @ssApprovalStatusId"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@ApprovedBy, "approvedby") ?? "approvedby") + " = @ssApprovedBy"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@ApprovedOn, "approvedon") ?? "approvedon") + " = @ssApprovedOn"): parameters);
parameters = (usedFields[8] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@RejectedBy, "rejectedby") ?? "rejectedby") + " = @ssRejectedBy"): parameters);
parameters = (usedFields[9] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@RejectedOn, "rejectedon") ?? "rejectedon") + " = @ssRejectedOn"): parameters);
parameters = (usedFields[10] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@IsReassigned, "isreassigned") ?? "isreassigned") + " = @ssIsReassigned"): parameters);
parameters = (usedFields[11] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@IsSubstituteFor, "issubstitutefor") ?? "issubstitutefor") + " = @ssIsSubstituteFor"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENOrderRequeeApprovalLevel_OrderRequestFApprovalLevel";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@IsReassigned, "isreassigned") ?? "isreassigned") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@IsReassigned, "isreassigned") ?? "isreassigned") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENOrderRequestFileApprovalLevel.ssOrderRequestFileApprovalId==0L)) {
sqlCmd.CreateParameter("@ssOrderRequestFileApprovalId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssOrderRequestFileApprovalId", DbType.Int64, ssENOrderRequestFileApprovalLevel.ssOrderRequestFileApprovalId);

}
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssLevelNumber", DbType.Int32, ssENOrderRequestFileApprovalLevel.ssLevelNumber);
}
if(usedFields[3]) {
if ((ssENOrderRequestFileApprovalLevel.ssEntraRoleId==0L)) {
sqlCmd.CreateParameter("@ssEntraRoleId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssEntraRoleId", DbType.Int64, ssENOrderRequestFileApprovalLevel.ssEntraRoleId);

}
}
if(usedFields[4]) {
if ((ssENOrderRequestFileApprovalLevel.ssAssignedTo=="")) {
sqlCmd.CreateParameter("@ssAssignedTo", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssAssignedTo", DbType.String, ssENOrderRequestFileApprovalLevel.ssAssignedTo);

}
}
if(usedFields[5]) {
if ((ssENOrderRequestFileApprovalLevel.ssApprovalStatusId==0)) {
sqlCmd.CreateParameter("@ssApprovalStatusId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssApprovalStatusId", DbType.Int32, ssENOrderRequestFileApprovalLevel.ssApprovalStatusId);

}
}
if(usedFields[6]) {
if ((ssENOrderRequestFileApprovalLevel.ssApprovedBy=="")) {
sqlCmd.CreateParameter("@ssApprovedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssApprovedBy", DbType.String, ssENOrderRequestFileApprovalLevel.ssApprovedBy);

}
}
if(usedFields[7]) {
sqlCmd.CreateParameter("@ssApprovedOn", DbType.DateTime, ssENOrderRequestFileApprovalLevel.ssApprovedOn);
}
if(usedFields[8]) {
if ((ssENOrderRequestFileApprovalLevel.ssRejectedBy=="")) {
sqlCmd.CreateParameter("@ssRejectedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssRejectedBy", DbType.String, ssENOrderRequestFileApprovalLevel.ssRejectedBy);

}
}
if(usedFields[9]) {
sqlCmd.CreateParameter("@ssRejectedOn", DbType.DateTime, ssENOrderRequestFileApprovalLevel.ssRejectedOn);
}
if(usedFields[10]) {
sqlCmd.CreateParameter("@ssIsReassigned", DbType.Boolean, ssENOrderRequestFileApprovalLevel.ssIsReassigned);
}
if(usedFields[11]) {
if ((ssENOrderRequestFileApprovalLevel.ssIsSubstituteFor=="")) {
sqlCmd.CreateParameter("@ssIsSubstituteFor", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssIsSubstituteFor", DbType.String, ssENOrderRequestFileApprovalLevel.ssIsSubstituteFor);

}
}
sqlCmd.CreateParameter("@idparam_ssENOrderRequeeApprovalLevel_OrderRequestFApprovalLevel", DbType.Int64, ssENOrderRequestFileApprovalLevel.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateOrderRequestFileApprovalLevel", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("OrderRequestFileApprovalLevel", ssENOrderRequestFileApprovalLevel.ssId.ToString()); }}
}
return;
}

}
}
