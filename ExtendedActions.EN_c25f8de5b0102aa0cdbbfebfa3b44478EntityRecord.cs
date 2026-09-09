using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateFolioApproval
/// </summary>

public static async Task<long> CreateFolioApproval(IRequestContext requestContext,RC_8f1c2b4902cba2d0c0cbb5fb1e978b50 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateFolioApproval", "0ff4cdb3-f11d-422b-89e0-c379f6ef41f6.#CreateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateFolioApproval", "0ff4cdb3-f11d-422b-89e0-c379f6ef41f6.#CreateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord ssENFolioApproval = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENFolioApprovalEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@FolioId, "folioid") ?? "folioid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@ApprovalProcessId, "approvalprocessid") ?? "approvalprocessid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@ProcessTypeCode, "processtypecode") ?? "processtypecode") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@ApprovalProcessVersion, "approvalprocessversion") ?? "approvalprocessversion") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@CurrentLevel, "currentlevel") ?? "currentlevel") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@MaxLevel, "maxlevel") ?? "maxlevel") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@StartedOn, "startedon") ?? "startedon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@FinishedOn, "finishedon") ?? "finishedon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@RegionId, "regionid") ?? "regionid") + "" +
" ) VALUES (" +
" @ssFolioId" +
", @ssApprovalProcessId" +
", @ssProcessTypeCode" +
", @ssApprovalProcessVersion" +
", @ssCurrentLevel" +
", @ssMaxLevel" +
", @ssStartedOn" +
", @ssFinishedOn" +
", @ssRegionId" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENFolioApproval.ssFolioId==0L)) {
insertSqlCmd.CreateParameter("@ssFolioId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssFolioId", DbType.Int64, ssENFolioApproval.ssFolioId);

}
insertSqlCmd.CreateParameter("@ssApprovalProcessId", DbType.Int64, ssENFolioApproval.ssApprovalProcessId);
insertSqlCmd.CreateParameter("@ssProcessTypeCode", DbType.String, ssENFolioApproval.ssProcessTypeCode);
insertSqlCmd.CreateParameter("@ssApprovalProcessVersion", DbType.String, ssENFolioApproval.ssApprovalProcessVersion);
insertSqlCmd.CreateParameter("@ssCurrentLevel", DbType.Int32, ssENFolioApproval.ssCurrentLevel);
insertSqlCmd.CreateParameter("@ssMaxLevel", DbType.Int32, ssENFolioApproval.ssMaxLevel);
insertSqlCmd.CreateParameter("@ssStartedOn", DbType.DateTime, ssENFolioApproval.ssStartedOn);
insertSqlCmd.CreateParameter("@ssFinishedOn", DbType.DateTime, ssENFolioApproval.ssFinishedOn);
if ((ssENFolioApproval.ssRegionId==0L)) {
insertSqlCmd.CreateParameter("@ssRegionId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssRegionId", DbType.Int64, ssENFolioApproval.ssRegionId);

}
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateFolioApproval", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateFolioApproval
/// </summary>

public static async Task<long> CreateOrUpdateFolioApproval(IRequestContext requestContext,BitArray usedFields,RC_8f1c2b4902cba2d0c0cbb5fb1e978b50 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateFolioApproval", "0ff4cdb3-f11d-422b-89e0-c379f6ef41f6.#CreateOrUpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateFolioApproval", "0ff4cdb3-f11d-422b-89e0-c379f6ef41f6.#CreateOrUpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord ssENFolioApproval = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(10,true);
}
string updateSet = "UPDATE " + ENFolioApprovalEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@FolioId, "folioid") ?? "folioid") + " = @ssFolioId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@ApprovalProcessId, "approvalprocessid") ?? "approvalprocessid") + " = @ssApprovalProcessId"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@ProcessTypeCode, "processtypecode") ?? "processtypecode") + " = @ssProcessTypeCode"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@ApprovalProcessVersion, "approvalprocessversion") ?? "approvalprocessversion") + " = @ssApprovalProcessVersion"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@CurrentLevel, "currentlevel") ?? "currentlevel") + " = @ssCurrentLevel"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@MaxLevel, "maxlevel") ?? "maxlevel") + " = @ssMaxLevel"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@StartedOn, "startedon") ?? "startedon") + " = @ssStartedOn"): parameters);
parameters = (usedFields[8] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@FinishedOn, "finishedon") ?? "finishedon") + " = @ssFinishedOn"): parameters);
parameters = (usedFields[9] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@RegionId, "regionid") ?? "regionid") + " = @ssRegionId"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENFolioApproval_ssId_FolioApproval";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@CurrentLevel, "currentlevel") ?? "currentlevel") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@CurrentLevel, "currentlevel") ?? "currentlevel") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENFolioApproval.ssFolioId==0L)) {
sqlCmd.CreateParameter("@ssFolioId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssFolioId", DbType.Int64, ssENFolioApproval.ssFolioId);

}
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssApprovalProcessId", DbType.Int64, ssENFolioApproval.ssApprovalProcessId);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssProcessTypeCode", DbType.String, ssENFolioApproval.ssProcessTypeCode);
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssApprovalProcessVersion", DbType.String, ssENFolioApproval.ssApprovalProcessVersion);
}
if(usedFields[5]) {
sqlCmd.CreateParameter("@ssCurrentLevel", DbType.Int32, ssENFolioApproval.ssCurrentLevel);
}
if(usedFields[6]) {
sqlCmd.CreateParameter("@ssMaxLevel", DbType.Int32, ssENFolioApproval.ssMaxLevel);
}
if(usedFields[7]) {
sqlCmd.CreateParameter("@ssStartedOn", DbType.DateTime, ssENFolioApproval.ssStartedOn);
}
if(usedFields[8]) {
sqlCmd.CreateParameter("@ssFinishedOn", DbType.DateTime, ssENFolioApproval.ssFinishedOn);
}
if(usedFields[9]) {
if ((ssENFolioApproval.ssRegionId==0L)) {
sqlCmd.CreateParameter("@ssRegionId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssRegionId", DbType.Int64, ssENFolioApproval.ssRegionId);

}
}
sqlCmd.CreateParameter("@idparam_ssENFolioApproval_ssId_FolioApproval", DbType.Int64, ssENFolioApproval.ssId);
int counter = 0;
if(ssENFolioApproval.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateFolioApproval (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENFolioApprovalEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@FolioId, "folioid") ?? "folioid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@ApprovalProcessId, "approvalprocessid") ?? "approvalprocessid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@ProcessTypeCode, "processtypecode") ?? "processtypecode") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@ApprovalProcessVersion, "approvalprocessversion") ?? "approvalprocessversion") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@CurrentLevel, "currentlevel") ?? "currentlevel") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@MaxLevel, "maxlevel") ?? "maxlevel") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@StartedOn, "startedon") ?? "startedon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@FinishedOn, "finishedon") ?? "finishedon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@RegionId, "regionid") ?? "regionid") + "" +
" ) VALUES (" +
" @ssFolioId" +
", @ssApprovalProcessId" +
", @ssProcessTypeCode" +
", @ssApprovalProcessVersion" +
", @ssCurrentLevel" +
", @ssMaxLevel" +
", @ssStartedOn" +
", @ssFinishedOn" +
", @ssRegionId" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENFolioApproval.ssFolioId==0L)) {
insertSqlCmd.CreateParameter("@ssFolioId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssFolioId", DbType.Int64, ssENFolioApproval.ssFolioId);

}
insertSqlCmd.CreateParameter("@ssApprovalProcessId", DbType.Int64, ssENFolioApproval.ssApprovalProcessId);
insertSqlCmd.CreateParameter("@ssProcessTypeCode", DbType.String, ssENFolioApproval.ssProcessTypeCode);
insertSqlCmd.CreateParameter("@ssApprovalProcessVersion", DbType.String, ssENFolioApproval.ssApprovalProcessVersion);
insertSqlCmd.CreateParameter("@ssCurrentLevel", DbType.Int32, ssENFolioApproval.ssCurrentLevel);
insertSqlCmd.CreateParameter("@ssMaxLevel", DbType.Int32, ssENFolioApproval.ssMaxLevel);
insertSqlCmd.CreateParameter("@ssStartedOn", DbType.DateTime, ssENFolioApproval.ssStartedOn);
insertSqlCmd.CreateParameter("@ssFinishedOn", DbType.DateTime, ssENFolioApproval.ssFinishedOn);
if ((ssENFolioApproval.ssRegionId==0L)) {
insertSqlCmd.CreateParameter("@ssRegionId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssRegionId", DbType.Int64, ssENFolioApproval.ssRegionId);

}
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateFolioApproval", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENFolioApproval.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeFolioApproval
/// </summary>

public static async Task CreateOrUpdateSomeFolioApproval(IRequestContext requestContext,RL_b442351480b89deb6222b9dd043cac65 inParamSourceList,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateSomeFolioApproval", "0ff4cdb3-f11d-422b-89e0-c379f6ef41f6.#CreateOrUpdateAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeFolioApproval", "0ff4cdb3-f11d-422b-89e0-c379f6ef41f6.#CreateOrUpdateAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
string entityTableName = ENFolioApprovalEntity.LocalViewName(null);
string insertSql = "INSERT INTO " + entityTableName + " (" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@FolioId, "folioid") ?? "folioid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@ApprovalProcessId, "approvalprocessid") ?? "approvalprocessid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@ProcessTypeCode, "processtypecode") ?? "processtypecode") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@ApprovalProcessVersion, "approvalprocessversion") ?? "approvalprocessversion") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@CurrentLevel, "currentlevel") ?? "currentlevel") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@MaxLevel, "maxlevel") ?? "maxlevel") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@StartedOn, "startedon") ?? "startedon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@FinishedOn, "finishedon") ?? "finishedon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@RegionId, "regionid") ?? "regionid") + ") VALUES ( unnest(@ssFolioId),  unnest(@ssApprovalProcessId),  unnest(@ssProcessTypeCode),  unnest(@ssApprovalProcessVersion),  unnest(@ssCurrentLevel),  unnest(@ssMaxLevel),  unnest(@ssStartedOn),  unnest(@ssFinishedOn),  unnest(@ssRegionId)) ";
insertSql += "";

string updateSql = "UPDATE " + entityTableName + " SET " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@FolioId, "folioid") ?? "folioid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@FolioId, "folioid") ?? "folioid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@ApprovalProcessId, "approvalprocessid") ?? "approvalprocessid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@ApprovalProcessId, "approvalprocessid") ?? "approvalprocessid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@ProcessTypeCode, "processtypecode") ?? "processtypecode") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@ProcessTypeCode, "processtypecode") ?? "processtypecode") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@ApprovalProcessVersion, "approvalprocessversion") ?? "approvalprocessversion") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@ApprovalProcessVersion, "approvalprocessversion") ?? "approvalprocessversion") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@CurrentLevel, "currentlevel") ?? "currentlevel") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@CurrentLevel, "currentlevel") ?? "currentlevel") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@MaxLevel, "maxlevel") ?? "maxlevel") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@MaxLevel, "maxlevel") ?? "maxlevel") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@StartedOn, "startedon") ?? "startedon") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@StartedOn, "startedon") ?? "startedon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@FinishedOn, "finishedon") ?? "finishedon") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@FinishedOn, "finishedon") ?? "finishedon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@RegionId, "regionid") ?? "regionid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@RegionId, "regionid") ?? "regionid") + " from ( select  unnest(@ssId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@Id, "id") ?? "id") + ",  unnest(@ssFolioId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@FolioId, "folioid") ?? "folioid") + ",  unnest(@ssApprovalProcessId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@ApprovalProcessId, "approvalprocessid") ?? "approvalprocessid") + ",  unnest(@ssProcessTypeCode) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@ProcessTypeCode, "processtypecode") ?? "processtypecode") + ",  unnest(@ssApprovalProcessVersion) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@ApprovalProcessVersion, "approvalprocessversion") ?? "approvalprocessversion") + ",  unnest(@ssCurrentLevel) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@CurrentLevel, "currentlevel") ?? "currentlevel") + ",  unnest(@ssMaxLevel) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@MaxLevel, "maxlevel") ?? "maxlevel") + ",  unnest(@ssStartedOn) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@StartedOn, "startedon") ?? "startedon") + ",  unnest(@ssFinishedOn) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@FinishedOn, "finishedon") ?? "finishedon") + ",  unnest(@ssRegionId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@RegionId, "regionid") ?? "regionid") + " ) as updateTable where " + entityTableName + "." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@Id, "id") ?? "id") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@Id, "id") ?? "id") + " ";
updateSql += "";

List<object> insertFolioIdList = new List<object>();
List<long> insertApprovalProcessIdList = new List<long>();
List<string> insertProcessTypeCodeList = new List<string>();
List<string> insertApprovalProcessVersionList = new List<string>();
List<int> insertCurrentLevelList = new List<int>();
List<int> insertMaxLevelList = new List<int>();
List<DateTime> insertStartedOnList = new List<DateTime>();
List<DateTime> insertFinishedOnList = new List<DateTime>();
List<object> insertRegionIdList = new List<object>();

List<long> updateIdList = new List<long>();
List<object> updateFolioIdList = new List<object>();
List<long> updateApprovalProcessIdList = new List<long>();
List<string> updateProcessTypeCodeList = new List<string>();
List<string> updateApprovalProcessVersionList = new List<string>();
List<int> updateCurrentLevelList = new List<int>();
List<int> updateMaxLevelList = new List<int>();
List<DateTime> updateStartedOnList = new List<DateTime>();
List<DateTime> updateFinishedOnList = new List<DateTime>();
List<object> updateRegionIdList = new List<object>();

var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_8f1c2b4902cba2d0c0cbb5fb1e978b50)inParamSourceList.Current).ssENFolioApproval;
if (record.ssId != 0L) {
updateIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
if ((record.ssFolioId==0L)) {
updateFolioIdList.Add(null);
} else {
updateFolioIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssFolioId));
}
updateApprovalProcessIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssApprovalProcessId));
updateProcessTypeCodeList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssProcessTypeCode));
updateApprovalProcessVersionList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssApprovalProcessVersion));
updateCurrentLevelList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssCurrentLevel));
updateMaxLevelList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssMaxLevel));
updateStartedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssStartedOn));
updateFinishedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssFinishedOn));
if ((record.ssRegionId==0L)) {
updateRegionIdList.Add(null);
} else {
updateRegionIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssRegionId));
}
} else {
if ((record.ssFolioId==0L)) {
insertFolioIdList.Add(null);
} else {
insertFolioIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssFolioId));
}
insertApprovalProcessIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssApprovalProcessId));
insertProcessTypeCodeList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssProcessTypeCode));
insertApprovalProcessVersionList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssApprovalProcessVersion));
insertCurrentLevelList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssCurrentLevel));
insertMaxLevelList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssMaxLevel));
insertStartedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssStartedOn));
insertFinishedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssFinishedOn));
if ((record.ssRegionId==0L)) {
insertRegionIdList.Add(null);
} else {
insertRegionIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssRegionId));
}
}
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertFolioIdList.IsEmpty() || !insertApprovalProcessIdList.IsEmpty() || !insertProcessTypeCodeList.IsEmpty() || !insertApprovalProcessVersionList.IsEmpty() || !insertCurrentLevelList.IsEmpty() || !insertMaxLevelList.IsEmpty() || !insertStartedOnList.IsEmpty() || !insertFinishedOnList.IsEmpty() || !insertRegionIdList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssFolioId",DbType.Int64,insertFolioIdList);
executionService.CreateParameter(insertSqlCmd,"@ssApprovalProcessId",DbType.Int64,insertApprovalProcessIdList);
executionService.CreateParameter(insertSqlCmd,"@ssProcessTypeCode",DbType.String,insertProcessTypeCodeList);
executionService.CreateParameter(insertSqlCmd,"@ssApprovalProcessVersion",DbType.String,insertApprovalProcessVersionList);
executionService.CreateParameter(insertSqlCmd,"@ssCurrentLevel",DbType.Int32,insertCurrentLevelList);
executionService.CreateParameter(insertSqlCmd,"@ssMaxLevel",DbType.Int32,insertMaxLevelList);
executionService.CreateParameter(insertSqlCmd,"@ssStartedOn",DbType.DateTime,insertStartedOnList);
executionService.CreateParameter(insertSqlCmd,"@ssFinishedOn",DbType.DateTime,insertFinishedOnList);
executionService.CreateParameter(insertSqlCmd,"@ssRegionId",DbType.Int64,insertRegionIdList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeFolioApproval (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
if(!updateFolioIdList.IsEmpty() || !updateApprovalProcessIdList.IsEmpty() || !updateProcessTypeCodeList.IsEmpty() || !updateApprovalProcessVersionList.IsEmpty() || !updateCurrentLevelList.IsEmpty() || !updateMaxLevelList.IsEmpty() || !updateStartedOnList.IsEmpty() || !updateFinishedOnList.IsEmpty() || !updateRegionIdList.IsEmpty()){
await using(var updateSqlCmd = trans.CreateCommand(updateSql)){
executionService.CreateParameter(updateSqlCmd,"@ssId",DbType.Int64,updateIdList);
executionService.CreateParameter(updateSqlCmd,"@ssFolioId",DbType.Int64,updateFolioIdList);
executionService.CreateParameter(updateSqlCmd,"@ssApprovalProcessId",DbType.Int64,updateApprovalProcessIdList);
executionService.CreateParameter(updateSqlCmd,"@ssProcessTypeCode",DbType.String,updateProcessTypeCodeList);
executionService.CreateParameter(updateSqlCmd,"@ssApprovalProcessVersion",DbType.String,updateApprovalProcessVersionList);
executionService.CreateParameter(updateSqlCmd,"@ssCurrentLevel",DbType.Int32,updateCurrentLevelList);
executionService.CreateParameter(updateSqlCmd,"@ssMaxLevel",DbType.Int32,updateMaxLevelList);
executionService.CreateParameter(updateSqlCmd,"@ssStartedOn",DbType.DateTime,updateStartedOnList);
executionService.CreateParameter(updateSqlCmd,"@ssFinishedOn",DbType.DateTime,updateFinishedOnList);
executionService.CreateParameter(updateSqlCmd,"@ssRegionId",DbType.Int64,updateRegionIdList);
await updateSqlCmd.PrepareAsync(cancellationToken);
await updateSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeFolioApproval (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(updateSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteFolioApproval
/// </summary>

public static async Task DeleteFolioApproval(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteFolioApproval", "0ff4cdb3-f11d-422b-89e0-c379f6ef41f6.#DeleteEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteFolioApproval", "0ff4cdb3-f11d-422b-89e0-c379f6ef41f6.#DeleteEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENFolioApprovalEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteFolioApproval", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllFolioApproval
/// </summary>

public static async Task DeleteAllFolioApproval(IRequestContext requestContext,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteAllFolioApproval", "0ff4cdb3-f11d-422b-89e0-c379f6ef41f6.#DeleteAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllFolioApproval", "0ff4cdb3-f11d-422b-89e0-c379f6ef41f6.#DeleteAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENFolioApprovalEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteFolioApproval", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetFolioApproval
/// </summary>

public static async Task<RC_8f1c2b4902cba2d0c0cbb5fb1e978b50> GetFolioApproval(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_8f1c2b4902cba2d0c0cbb5fb1e978b50 outParamRecord = default;
outParamRecord = new RC_8f1c2b4902cba2d0c0cbb5fb1e978b50();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetFolioApproval", "0ff4cdb3-f11d-422b-89e0-c379f6ef41f6.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetFolioApproval", "0ff4cdb3-f11d-422b-89e0-c379f6ef41f6.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@FolioId, "folioid") ?? "folioid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@ApprovalProcessId, "approvalprocessid") ?? "approvalprocessid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@ProcessTypeCode, "processtypecode") ?? "processtypecode", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@ApprovalProcessVersion, "approvalprocessversion") ?? "approvalprocessversion", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@CurrentLevel, "currentlevel") ?? "currentlevel", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@MaxLevel, "maxlevel") ?? "maxlevel", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@StartedOn, "startedon") ?? "startedon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@FinishedOn, "finishedon") ?? "finishedon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@RegionId, "regionid") ?? "regionid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
" FROM " + ENFolioApprovalEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetFolioApproval", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(10,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENFolioApprovalEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetFolioApprovalForUpdate
/// </summary>

public static async Task<RC_8f1c2b4902cba2d0c0cbb5fb1e978b50> GetFolioApprovalForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_8f1c2b4902cba2d0c0cbb5fb1e978b50 outParamRecord = default;
outParamRecord = new RC_8f1c2b4902cba2d0c0cbb5fb1e978b50();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetFolioApprovalForUpdate", "0ff4cdb3-f11d-422b-89e0-c379f6ef41f6.#GetEntityForUpdate");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetFolioApprovalForUpdate", "0ff4cdb3-f11d-422b-89e0-c379f6ef41f6.#GetEntityForUpdate", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@FolioId, "folioid") ?? "folioid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@ApprovalProcessId, "approvalprocessid") ?? "approvalprocessid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@ProcessTypeCode, "processtypecode") ?? "processtypecode", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@ApprovalProcessVersion, "approvalprocessversion") ?? "approvalprocessversion", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@CurrentLevel, "currentlevel") ?? "currentlevel", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@MaxLevel, "maxlevel") ?? "maxlevel", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@StartedOn, "startedon") ?? "startedon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@FinishedOn, "finishedon") ?? "finishedon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@RegionId, "regionid") ?? "regionid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
" FROM " + ENFolioApprovalEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@Id, "id") ?? "id") + " = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetFolioApprovalForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(10,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENFolioApprovalEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateFolioApproval
/// </summary>

public static async Task UpdateFolioApproval(IRequestContext requestContext,BitArray usedFields,RC_8f1c2b4902cba2d0c0cbb5fb1e978b50 inParamSource,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("UpdateFolioApproval", "0ff4cdb3-f11d-422b-89e0-c379f6ef41f6.#UpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateFolioApproval", "0ff4cdb3-f11d-422b-89e0-c379f6ef41f6.#UpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord ssENFolioApproval = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(10,true);
}
string updateSet = "UPDATE " + ENFolioApprovalEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@FolioId, "folioid") ?? "folioid") + " = @ssFolioId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@ApprovalProcessId, "approvalprocessid") ?? "approvalprocessid") + " = @ssApprovalProcessId"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@ProcessTypeCode, "processtypecode") ?? "processtypecode") + " = @ssProcessTypeCode"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@ApprovalProcessVersion, "approvalprocessversion") ?? "approvalprocessversion") + " = @ssApprovalProcessVersion"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@CurrentLevel, "currentlevel") ?? "currentlevel") + " = @ssCurrentLevel"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@MaxLevel, "maxlevel") ?? "maxlevel") + " = @ssMaxLevel"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@StartedOn, "startedon") ?? "startedon") + " = @ssStartedOn"): parameters);
parameters = (usedFields[8] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@FinishedOn, "finishedon") ?? "finishedon") + " = @ssFinishedOn"): parameters);
parameters = (usedFields[9] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@RegionId, "regionid") ?? "regionid") + " = @ssRegionId"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENFolioApproval_ssId_FolioApproval";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@CurrentLevel, "currentlevel") ?? "currentlevel") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@CurrentLevel, "currentlevel") ?? "currentlevel") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENFolioApproval.ssFolioId==0L)) {
sqlCmd.CreateParameter("@ssFolioId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssFolioId", DbType.Int64, ssENFolioApproval.ssFolioId);

}
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssApprovalProcessId", DbType.Int64, ssENFolioApproval.ssApprovalProcessId);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssProcessTypeCode", DbType.String, ssENFolioApproval.ssProcessTypeCode);
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssApprovalProcessVersion", DbType.String, ssENFolioApproval.ssApprovalProcessVersion);
}
if(usedFields[5]) {
sqlCmd.CreateParameter("@ssCurrentLevel", DbType.Int32, ssENFolioApproval.ssCurrentLevel);
}
if(usedFields[6]) {
sqlCmd.CreateParameter("@ssMaxLevel", DbType.Int32, ssENFolioApproval.ssMaxLevel);
}
if(usedFields[7]) {
sqlCmd.CreateParameter("@ssStartedOn", DbType.DateTime, ssENFolioApproval.ssStartedOn);
}
if(usedFields[8]) {
sqlCmd.CreateParameter("@ssFinishedOn", DbType.DateTime, ssENFolioApproval.ssFinishedOn);
}
if(usedFields[9]) {
if ((ssENFolioApproval.ssRegionId==0L)) {
sqlCmd.CreateParameter("@ssRegionId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssRegionId", DbType.Int64, ssENFolioApproval.ssRegionId);

}
}
sqlCmd.CreateParameter("@idparam_ssENFolioApproval_ssId_FolioApproval", DbType.Int64, ssENFolioApproval.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateFolioApproval", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("FolioApproval", ssENFolioApproval.ssId.ToString()); }}
}
return;
}

}
}
