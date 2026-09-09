using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateRequisitionApproval
/// </summary>

public static async Task<long> CreateRequisitionApproval(IRequestContext requestContext,RC_6d2bef4b7e32de4c7c78886eeff75224 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateRequisitionApproval", "9ade76ea-93eb-419c-9712-184a438f9d96.#CreateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateRequisitionApproval", "9ade76ea-93eb-419c-9712-184a438f9d96.#CreateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord ssENRequisitionApproval = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENRequisitionApprovalEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@AprovalProcessId, "aprovalprocessid") ?? "aprovalprocessid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@ProcessTypeCode, "processtypecode") ?? "processtypecode") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@ApprovalProcessVersion, "approvalprocessversion") ?? "approvalprocessversion") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@CurrentLevel, "currentlevel") ?? "currentlevel") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@MaxLevel, "maxlevel") ?? "maxlevel") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@StartedOn, "startedon") ?? "startedon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@FinishedOn, "finishedon") ?? "finishedon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@HasStartedAccounting, "hasstartedaccounting") ?? "hasstartedaccounting") + "" +
" ) VALUES (" +
" @ssRequisitionId" +
", @ssAprovalProcessId" +
", @ssProcessTypeCode" +
", @ssApprovalProcessVersion" +
", @ssCurrentLevel" +
", @ssMaxLevel" +
", @ssStartedOn" +
", @ssFinishedOn" +
", @ssHasStartedAccounting" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENRequisitionApproval.ssRequisitionId==0L)) {
insertSqlCmd.CreateParameter("@ssRequisitionId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssRequisitionId", DbType.Int64, ssENRequisitionApproval.ssRequisitionId);

}
insertSqlCmd.CreateParameter("@ssAprovalProcessId", DbType.Int64, ssENRequisitionApproval.ssAprovalProcessId);
insertSqlCmd.CreateParameter("@ssProcessTypeCode", DbType.String, ssENRequisitionApproval.ssProcessTypeCode);
insertSqlCmd.CreateParameter("@ssApprovalProcessVersion", DbType.String, ssENRequisitionApproval.ssApprovalProcessVersion);
insertSqlCmd.CreateParameter("@ssCurrentLevel", DbType.Int32, ssENRequisitionApproval.ssCurrentLevel);
insertSqlCmd.CreateParameter("@ssMaxLevel", DbType.Int32, ssENRequisitionApproval.ssMaxLevel);
insertSqlCmd.CreateParameter("@ssStartedOn", DbType.DateTime, ssENRequisitionApproval.ssStartedOn);
insertSqlCmd.CreateParameter("@ssFinishedOn", DbType.DateTime, ssENRequisitionApproval.ssFinishedOn);
insertSqlCmd.CreateParameter("@ssHasStartedAccounting", DbType.Boolean, ssENRequisitionApproval.ssHasStartedAccounting);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateRequisitionApproval", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateRequisitionApproval
/// </summary>

public static async Task<long> CreateOrUpdateRequisitionApproval(IRequestContext requestContext,BitArray usedFields,RC_6d2bef4b7e32de4c7c78886eeff75224 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateRequisitionApproval", "9ade76ea-93eb-419c-9712-184a438f9d96.#CreateOrUpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateRequisitionApproval", "9ade76ea-93eb-419c-9712-184a438f9d96.#CreateOrUpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord ssENRequisitionApproval = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(10,true);
}
string updateSet = "UPDATE " + ENRequisitionApprovalEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid") + " = @ssRequisitionId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@AprovalProcessId, "aprovalprocessid") ?? "aprovalprocessid") + " = @ssAprovalProcessId"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@ProcessTypeCode, "processtypecode") ?? "processtypecode") + " = @ssProcessTypeCode"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@ApprovalProcessVersion, "approvalprocessversion") ?? "approvalprocessversion") + " = @ssApprovalProcessVersion"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@CurrentLevel, "currentlevel") ?? "currentlevel") + " = @ssCurrentLevel"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@MaxLevel, "maxlevel") ?? "maxlevel") + " = @ssMaxLevel"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@StartedOn, "startedon") ?? "startedon") + " = @ssStartedOn"): parameters);
parameters = (usedFields[8] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@FinishedOn, "finishedon") ?? "finishedon") + " = @ssFinishedOn"): parameters);
parameters = (usedFields[9] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@HasStartedAccounting, "hasstartedaccounting") ?? "hasstartedaccounting") + " = @ssHasStartedAccounting"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENRequisitionApproval_ssId_RequisitionApproval";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@HasStartedAccounting, "hasstartedaccounting") ?? "hasstartedaccounting") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@HasStartedAccounting, "hasstartedaccounting") ?? "hasstartedaccounting") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENRequisitionApproval.ssRequisitionId==0L)) {
sqlCmd.CreateParameter("@ssRequisitionId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssRequisitionId", DbType.Int64, ssENRequisitionApproval.ssRequisitionId);

}
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssAprovalProcessId", DbType.Int64, ssENRequisitionApproval.ssAprovalProcessId);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssProcessTypeCode", DbType.String, ssENRequisitionApproval.ssProcessTypeCode);
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssApprovalProcessVersion", DbType.String, ssENRequisitionApproval.ssApprovalProcessVersion);
}
if(usedFields[5]) {
sqlCmd.CreateParameter("@ssCurrentLevel", DbType.Int32, ssENRequisitionApproval.ssCurrentLevel);
}
if(usedFields[6]) {
sqlCmd.CreateParameter("@ssMaxLevel", DbType.Int32, ssENRequisitionApproval.ssMaxLevel);
}
if(usedFields[7]) {
sqlCmd.CreateParameter("@ssStartedOn", DbType.DateTime, ssENRequisitionApproval.ssStartedOn);
}
if(usedFields[8]) {
sqlCmd.CreateParameter("@ssFinishedOn", DbType.DateTime, ssENRequisitionApproval.ssFinishedOn);
}
if(usedFields[9]) {
sqlCmd.CreateParameter("@ssHasStartedAccounting", DbType.Boolean, ssENRequisitionApproval.ssHasStartedAccounting);
}
sqlCmd.CreateParameter("@idparam_ssENRequisitionApproval_ssId_RequisitionApproval", DbType.Int64, ssENRequisitionApproval.ssId);
int counter = 0;
if(ssENRequisitionApproval.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateRequisitionApproval (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENRequisitionApprovalEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@AprovalProcessId, "aprovalprocessid") ?? "aprovalprocessid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@ProcessTypeCode, "processtypecode") ?? "processtypecode") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@ApprovalProcessVersion, "approvalprocessversion") ?? "approvalprocessversion") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@CurrentLevel, "currentlevel") ?? "currentlevel") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@MaxLevel, "maxlevel") ?? "maxlevel") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@StartedOn, "startedon") ?? "startedon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@FinishedOn, "finishedon") ?? "finishedon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@HasStartedAccounting, "hasstartedaccounting") ?? "hasstartedaccounting") + "" +
" ) VALUES (" +
" @ssRequisitionId" +
", @ssAprovalProcessId" +
", @ssProcessTypeCode" +
", @ssApprovalProcessVersion" +
", @ssCurrentLevel" +
", @ssMaxLevel" +
", @ssStartedOn" +
", @ssFinishedOn" +
", @ssHasStartedAccounting" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENRequisitionApproval.ssRequisitionId==0L)) {
insertSqlCmd.CreateParameter("@ssRequisitionId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssRequisitionId", DbType.Int64, ssENRequisitionApproval.ssRequisitionId);

}
insertSqlCmd.CreateParameter("@ssAprovalProcessId", DbType.Int64, ssENRequisitionApproval.ssAprovalProcessId);
insertSqlCmd.CreateParameter("@ssProcessTypeCode", DbType.String, ssENRequisitionApproval.ssProcessTypeCode);
insertSqlCmd.CreateParameter("@ssApprovalProcessVersion", DbType.String, ssENRequisitionApproval.ssApprovalProcessVersion);
insertSqlCmd.CreateParameter("@ssCurrentLevel", DbType.Int32, ssENRequisitionApproval.ssCurrentLevel);
insertSqlCmd.CreateParameter("@ssMaxLevel", DbType.Int32, ssENRequisitionApproval.ssMaxLevel);
insertSqlCmd.CreateParameter("@ssStartedOn", DbType.DateTime, ssENRequisitionApproval.ssStartedOn);
insertSqlCmd.CreateParameter("@ssFinishedOn", DbType.DateTime, ssENRequisitionApproval.ssFinishedOn);
insertSqlCmd.CreateParameter("@ssHasStartedAccounting", DbType.Boolean, ssENRequisitionApproval.ssHasStartedAccounting);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateRequisitionApproval", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENRequisitionApproval.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeRequisitionApproval
/// </summary>

public static async Task CreateOrUpdateSomeRequisitionApproval(IRequestContext requestContext,RL_7f2260a280cd6c85f68a2e5dbb44ffad inParamSourceList,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateSomeRequisitionApproval", "9ade76ea-93eb-419c-9712-184a438f9d96.#CreateOrUpdateAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeRequisitionApproval", "9ade76ea-93eb-419c-9712-184a438f9d96.#CreateOrUpdateAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
string entityTableName = ENRequisitionApprovalEntity.LocalViewName(null);
string insertSql = "INSERT INTO " + entityTableName + " (" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@AprovalProcessId, "aprovalprocessid") ?? "aprovalprocessid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@ProcessTypeCode, "processtypecode") ?? "processtypecode") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@ApprovalProcessVersion, "approvalprocessversion") ?? "approvalprocessversion") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@CurrentLevel, "currentlevel") ?? "currentlevel") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@MaxLevel, "maxlevel") ?? "maxlevel") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@StartedOn, "startedon") ?? "startedon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@FinishedOn, "finishedon") ?? "finishedon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@HasStartedAccounting, "hasstartedaccounting") ?? "hasstartedaccounting") + ") VALUES ( unnest(@ssRequisitionId),  unnest(@ssAprovalProcessId),  unnest(@ssProcessTypeCode),  unnest(@ssApprovalProcessVersion),  unnest(@ssCurrentLevel),  unnest(@ssMaxLevel),  unnest(@ssStartedOn),  unnest(@ssFinishedOn),  unnest(@ssHasStartedAccounting)) ";
insertSql += "";

string updateSql = "UPDATE " + entityTableName + " SET " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@AprovalProcessId, "aprovalprocessid") ?? "aprovalprocessid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@AprovalProcessId, "aprovalprocessid") ?? "aprovalprocessid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@ProcessTypeCode, "processtypecode") ?? "processtypecode") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@ProcessTypeCode, "processtypecode") ?? "processtypecode") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@ApprovalProcessVersion, "approvalprocessversion") ?? "approvalprocessversion") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@ApprovalProcessVersion, "approvalprocessversion") ?? "approvalprocessversion") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@CurrentLevel, "currentlevel") ?? "currentlevel") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@CurrentLevel, "currentlevel") ?? "currentlevel") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@MaxLevel, "maxlevel") ?? "maxlevel") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@MaxLevel, "maxlevel") ?? "maxlevel") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@StartedOn, "startedon") ?? "startedon") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@StartedOn, "startedon") ?? "startedon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@FinishedOn, "finishedon") ?? "finishedon") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@FinishedOn, "finishedon") ?? "finishedon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@HasStartedAccounting, "hasstartedaccounting") ?? "hasstartedaccounting") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@HasStartedAccounting, "hasstartedaccounting") ?? "hasstartedaccounting") + " from ( select  unnest(@ssId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@Id, "id") ?? "id") + ",  unnest(@ssRequisitionId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid") + ",  unnest(@ssAprovalProcessId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@AprovalProcessId, "aprovalprocessid") ?? "aprovalprocessid") + ",  unnest(@ssProcessTypeCode) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@ProcessTypeCode, "processtypecode") ?? "processtypecode") + ",  unnest(@ssApprovalProcessVersion) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@ApprovalProcessVersion, "approvalprocessversion") ?? "approvalprocessversion") + ",  unnest(@ssCurrentLevel) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@CurrentLevel, "currentlevel") ?? "currentlevel") + ",  unnest(@ssMaxLevel) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@MaxLevel, "maxlevel") ?? "maxlevel") + ",  unnest(@ssStartedOn) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@StartedOn, "startedon") ?? "startedon") + ",  unnest(@ssFinishedOn) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@FinishedOn, "finishedon") ?? "finishedon") + ",  unnest(@ssHasStartedAccounting) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@HasStartedAccounting, "hasstartedaccounting") ?? "hasstartedaccounting") + " ) as updateTable where " + entityTableName + "." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@Id, "id") ?? "id") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@Id, "id") ?? "id") + " ";
updateSql += "";

List<object> insertRequisitionIdList = new List<object>();
List<long> insertAprovalProcessIdList = new List<long>();
List<string> insertProcessTypeCodeList = new List<string>();
List<string> insertApprovalProcessVersionList = new List<string>();
List<int> insertCurrentLevelList = new List<int>();
List<int> insertMaxLevelList = new List<int>();
List<DateTime> insertStartedOnList = new List<DateTime>();
List<DateTime> insertFinishedOnList = new List<DateTime>();
List<bool> insertHasStartedAccountingList = new List<bool>();

List<long> updateIdList = new List<long>();
List<object> updateRequisitionIdList = new List<object>();
List<long> updateAprovalProcessIdList = new List<long>();
List<string> updateProcessTypeCodeList = new List<string>();
List<string> updateApprovalProcessVersionList = new List<string>();
List<int> updateCurrentLevelList = new List<int>();
List<int> updateMaxLevelList = new List<int>();
List<DateTime> updateStartedOnList = new List<DateTime>();
List<DateTime> updateFinishedOnList = new List<DateTime>();
List<bool> updateHasStartedAccountingList = new List<bool>();

var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_6d2bef4b7e32de4c7c78886eeff75224)inParamSourceList.Current).ssENRequisitionApproval;
if (record.ssId != 0L) {
updateIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
if ((record.ssRequisitionId==0L)) {
updateRequisitionIdList.Add(null);
} else {
updateRequisitionIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssRequisitionId));
}
updateAprovalProcessIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssAprovalProcessId));
updateProcessTypeCodeList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssProcessTypeCode));
updateApprovalProcessVersionList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssApprovalProcessVersion));
updateCurrentLevelList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssCurrentLevel));
updateMaxLevelList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssMaxLevel));
updateStartedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssStartedOn));
updateFinishedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssFinishedOn));
updateHasStartedAccountingList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssHasStartedAccounting));
} else {
if ((record.ssRequisitionId==0L)) {
insertRequisitionIdList.Add(null);
} else {
insertRequisitionIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssRequisitionId));
}
insertAprovalProcessIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssAprovalProcessId));
insertProcessTypeCodeList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssProcessTypeCode));
insertApprovalProcessVersionList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssApprovalProcessVersion));
insertCurrentLevelList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssCurrentLevel));
insertMaxLevelList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssMaxLevel));
insertStartedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssStartedOn));
insertFinishedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssFinishedOn));
insertHasStartedAccountingList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssHasStartedAccounting));
}
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertRequisitionIdList.IsEmpty() || !insertAprovalProcessIdList.IsEmpty() || !insertProcessTypeCodeList.IsEmpty() || !insertApprovalProcessVersionList.IsEmpty() || !insertCurrentLevelList.IsEmpty() || !insertMaxLevelList.IsEmpty() || !insertStartedOnList.IsEmpty() || !insertFinishedOnList.IsEmpty() || !insertHasStartedAccountingList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssRequisitionId",DbType.Int64,insertRequisitionIdList);
executionService.CreateParameter(insertSqlCmd,"@ssAprovalProcessId",DbType.Int64,insertAprovalProcessIdList);
executionService.CreateParameter(insertSqlCmd,"@ssProcessTypeCode",DbType.String,insertProcessTypeCodeList);
executionService.CreateParameter(insertSqlCmd,"@ssApprovalProcessVersion",DbType.String,insertApprovalProcessVersionList);
executionService.CreateParameter(insertSqlCmd,"@ssCurrentLevel",DbType.Int32,insertCurrentLevelList);
executionService.CreateParameter(insertSqlCmd,"@ssMaxLevel",DbType.Int32,insertMaxLevelList);
executionService.CreateParameter(insertSqlCmd,"@ssStartedOn",DbType.DateTime,insertStartedOnList);
executionService.CreateParameter(insertSqlCmd,"@ssFinishedOn",DbType.DateTime,insertFinishedOnList);
executionService.CreateParameter(insertSqlCmd,"@ssHasStartedAccounting",DbType.Boolean,insertHasStartedAccountingList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeRequisitionApproval (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
if(!updateRequisitionIdList.IsEmpty() || !updateAprovalProcessIdList.IsEmpty() || !updateProcessTypeCodeList.IsEmpty() || !updateApprovalProcessVersionList.IsEmpty() || !updateCurrentLevelList.IsEmpty() || !updateMaxLevelList.IsEmpty() || !updateStartedOnList.IsEmpty() || !updateFinishedOnList.IsEmpty() || !updateHasStartedAccountingList.IsEmpty()){
await using(var updateSqlCmd = trans.CreateCommand(updateSql)){
executionService.CreateParameter(updateSqlCmd,"@ssId",DbType.Int64,updateIdList);
executionService.CreateParameter(updateSqlCmd,"@ssRequisitionId",DbType.Int64,updateRequisitionIdList);
executionService.CreateParameter(updateSqlCmd,"@ssAprovalProcessId",DbType.Int64,updateAprovalProcessIdList);
executionService.CreateParameter(updateSqlCmd,"@ssProcessTypeCode",DbType.String,updateProcessTypeCodeList);
executionService.CreateParameter(updateSqlCmd,"@ssApprovalProcessVersion",DbType.String,updateApprovalProcessVersionList);
executionService.CreateParameter(updateSqlCmd,"@ssCurrentLevel",DbType.Int32,updateCurrentLevelList);
executionService.CreateParameter(updateSqlCmd,"@ssMaxLevel",DbType.Int32,updateMaxLevelList);
executionService.CreateParameter(updateSqlCmd,"@ssStartedOn",DbType.DateTime,updateStartedOnList);
executionService.CreateParameter(updateSqlCmd,"@ssFinishedOn",DbType.DateTime,updateFinishedOnList);
executionService.CreateParameter(updateSqlCmd,"@ssHasStartedAccounting",DbType.Boolean,updateHasStartedAccountingList);
await updateSqlCmd.PrepareAsync(cancellationToken);
await updateSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeRequisitionApproval (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(updateSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteRequisitionApproval
/// </summary>

public static async Task DeleteRequisitionApproval(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteRequisitionApproval", "9ade76ea-93eb-419c-9712-184a438f9d96.#DeleteEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteRequisitionApproval", "9ade76ea-93eb-419c-9712-184a438f9d96.#DeleteEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENRequisitionApprovalEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteRequisitionApproval", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllRequisitionApproval
/// </summary>

public static async Task DeleteAllRequisitionApproval(IRequestContext requestContext,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteAllRequisitionApproval", "9ade76ea-93eb-419c-9712-184a438f9d96.#DeleteAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllRequisitionApproval", "9ade76ea-93eb-419c-9712-184a438f9d96.#DeleteAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENRequisitionApprovalEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteRequisitionApproval", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetRequisitionApproval
/// </summary>

public static async Task<RC_6d2bef4b7e32de4c7c78886eeff75224> GetRequisitionApproval(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_6d2bef4b7e32de4c7c78886eeff75224 outParamRecord = default;
outParamRecord = new RC_6d2bef4b7e32de4c7c78886eeff75224();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetRequisitionApproval", "9ade76ea-93eb-419c-9712-184a438f9d96.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetRequisitionApproval", "9ade76ea-93eb-419c-9712-184a438f9d96.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@AprovalProcessId, "aprovalprocessid") ?? "aprovalprocessid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@ProcessTypeCode, "processtypecode") ?? "processtypecode", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@ApprovalProcessVersion, "approvalprocessversion") ?? "approvalprocessversion", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@CurrentLevel, "currentlevel") ?? "currentlevel", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@MaxLevel, "maxlevel") ?? "maxlevel", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@StartedOn, "startedon") ?? "startedon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@FinishedOn, "finishedon") ?? "finishedon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@HasStartedAccounting, "hasstartedaccounting") ?? "hasstartedaccounting", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
" FROM " + ENRequisitionApprovalEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetRequisitionApproval", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(10,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENRequisitionApprovalEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetRequisitionApprovalForUpdate
/// </summary>

public static async Task<RC_6d2bef4b7e32de4c7c78886eeff75224> GetRequisitionApprovalForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_6d2bef4b7e32de4c7c78886eeff75224 outParamRecord = default;
outParamRecord = new RC_6d2bef4b7e32de4c7c78886eeff75224();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetRequisitionApprovalForUpdate", "9ade76ea-93eb-419c-9712-184a438f9d96.#GetEntityForUpdate");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetRequisitionApprovalForUpdate", "9ade76ea-93eb-419c-9712-184a438f9d96.#GetEntityForUpdate", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@AprovalProcessId, "aprovalprocessid") ?? "aprovalprocessid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@ProcessTypeCode, "processtypecode") ?? "processtypecode", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@ApprovalProcessVersion, "approvalprocessversion") ?? "approvalprocessversion", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@CurrentLevel, "currentlevel") ?? "currentlevel", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@MaxLevel, "maxlevel") ?? "maxlevel", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@StartedOn, "startedon") ?? "startedon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@FinishedOn, "finishedon") ?? "finishedon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@HasStartedAccounting, "hasstartedaccounting") ?? "hasstartedaccounting", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
" FROM " + ENRequisitionApprovalEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@Id, "id") ?? "id") + " = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetRequisitionApprovalForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(10,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENRequisitionApprovalEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateRequisitionApproval
/// </summary>

public static async Task UpdateRequisitionApproval(IRequestContext requestContext,BitArray usedFields,RC_6d2bef4b7e32de4c7c78886eeff75224 inParamSource,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("UpdateRequisitionApproval", "9ade76ea-93eb-419c-9712-184a438f9d96.#UpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateRequisitionApproval", "9ade76ea-93eb-419c-9712-184a438f9d96.#UpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord ssENRequisitionApproval = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(10,true);
}
string updateSet = "UPDATE " + ENRequisitionApprovalEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid") + " = @ssRequisitionId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@AprovalProcessId, "aprovalprocessid") ?? "aprovalprocessid") + " = @ssAprovalProcessId"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@ProcessTypeCode, "processtypecode") ?? "processtypecode") + " = @ssProcessTypeCode"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@ApprovalProcessVersion, "approvalprocessversion") ?? "approvalprocessversion") + " = @ssApprovalProcessVersion"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@CurrentLevel, "currentlevel") ?? "currentlevel") + " = @ssCurrentLevel"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@MaxLevel, "maxlevel") ?? "maxlevel") + " = @ssMaxLevel"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@StartedOn, "startedon") ?? "startedon") + " = @ssStartedOn"): parameters);
parameters = (usedFields[8] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@FinishedOn, "finishedon") ?? "finishedon") + " = @ssFinishedOn"): parameters);
parameters = (usedFields[9] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@HasStartedAccounting, "hasstartedaccounting") ?? "hasstartedaccounting") + " = @ssHasStartedAccounting"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENRequisitionApproval_ssId_RequisitionApproval";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@HasStartedAccounting, "hasstartedaccounting") ?? "hasstartedaccounting") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@HasStartedAccounting, "hasstartedaccounting") ?? "hasstartedaccounting") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENRequisitionApproval.ssRequisitionId==0L)) {
sqlCmd.CreateParameter("@ssRequisitionId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssRequisitionId", DbType.Int64, ssENRequisitionApproval.ssRequisitionId);

}
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssAprovalProcessId", DbType.Int64, ssENRequisitionApproval.ssAprovalProcessId);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssProcessTypeCode", DbType.String, ssENRequisitionApproval.ssProcessTypeCode);
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssApprovalProcessVersion", DbType.String, ssENRequisitionApproval.ssApprovalProcessVersion);
}
if(usedFields[5]) {
sqlCmd.CreateParameter("@ssCurrentLevel", DbType.Int32, ssENRequisitionApproval.ssCurrentLevel);
}
if(usedFields[6]) {
sqlCmd.CreateParameter("@ssMaxLevel", DbType.Int32, ssENRequisitionApproval.ssMaxLevel);
}
if(usedFields[7]) {
sqlCmd.CreateParameter("@ssStartedOn", DbType.DateTime, ssENRequisitionApproval.ssStartedOn);
}
if(usedFields[8]) {
sqlCmd.CreateParameter("@ssFinishedOn", DbType.DateTime, ssENRequisitionApproval.ssFinishedOn);
}
if(usedFields[9]) {
sqlCmd.CreateParameter("@ssHasStartedAccounting", DbType.Boolean, ssENRequisitionApproval.ssHasStartedAccounting);
}
sqlCmd.CreateParameter("@idparam_ssENRequisitionApproval_ssId_RequisitionApproval", DbType.Int64, ssENRequisitionApproval.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateRequisitionApproval", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("RequisitionApproval", ssENRequisitionApproval.ssId.ToString()); }}
}
return;
}

}
}
