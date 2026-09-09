using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateOrderRequestFileApproval
/// </summary>

public static async Task<long> CreateOrderRequestFileApproval(IRequestContext requestContext,RC_64c70b8a3f72d1283f18a3da8f8eb3d5 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrderRequestFileApproval", "1da59bef-e230-464b-87cc-141569e58355.#CreateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrderRequestFileApproval", "1da59bef-e230-464b-87cc-141569e58355.#CreateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_1710c672f4d7138b664ee1411114271eEntityRecord ssENOrderRequestFileApproval = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENOrderRequestFileApprovalEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalAttributeKeys.@OrderRequestFileId, "orderrequestfileid") ?? "orderrequestfileid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalAttributeKeys.@CurrentLevel, "currentlevel") ?? "currentlevel") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalAttributeKeys.@MaxLevel, "maxlevel") ?? "maxlevel") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalAttributeKeys.@StartedOn, "startedon") ?? "startedon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalAttributeKeys.@FinishedOn, "finishedon") ?? "finishedon") + "" +
" ) VALUES (" +
" @ssOrderRequestFileId" +
", @ssCurrentLevel" +
", @ssMaxLevel" +
", @ssStartedOn" +
", @ssFinishedOn" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENOrderRequestFileApproval.ssOrderRequestFileId==0L)) {
insertSqlCmd.CreateParameter("@ssOrderRequestFileId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssOrderRequestFileId", DbType.Int64, ssENOrderRequestFileApproval.ssOrderRequestFileId);

}
insertSqlCmd.CreateParameter("@ssCurrentLevel", DbType.Int32, ssENOrderRequestFileApproval.ssCurrentLevel);
insertSqlCmd.CreateParameter("@ssMaxLevel", DbType.Int32, ssENOrderRequestFileApproval.ssMaxLevel);
insertSqlCmd.CreateParameter("@ssStartedOn", DbType.DateTime, ssENOrderRequestFileApproval.ssStartedOn);
insertSqlCmd.CreateParameter("@ssFinishedOn", DbType.DateTime, ssENOrderRequestFileApproval.ssFinishedOn);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrderRequestFileApproval", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateOrderRequestFileApproval
/// </summary>

public static async Task<long> CreateOrUpdateOrderRequestFileApproval(IRequestContext requestContext,BitArray usedFields,RC_64c70b8a3f72d1283f18a3da8f8eb3d5 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateOrderRequestFileApproval", "1da59bef-e230-464b-87cc-141569e58355.#CreateOrUpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateOrderRequestFileApproval", "1da59bef-e230-464b-87cc-141569e58355.#CreateOrUpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_1710c672f4d7138b664ee1411114271eEntityRecord ssENOrderRequestFileApproval = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(6,true);
}
string updateSet = "UPDATE " + ENOrderRequestFileApprovalEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalAttributeKeys.@OrderRequestFileId, "orderrequestfileid") ?? "orderrequestfileid") + " = @ssOrderRequestFileId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalAttributeKeys.@CurrentLevel, "currentlevel") ?? "currentlevel") + " = @ssCurrentLevel"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalAttributeKeys.@MaxLevel, "maxlevel") ?? "maxlevel") + " = @ssMaxLevel"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalAttributeKeys.@StartedOn, "startedon") ?? "startedon") + " = @ssStartedOn"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalAttributeKeys.@FinishedOn, "finishedon") ?? "finishedon") + " = @ssFinishedOn"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENOrderRequetFileApproval_ssd_OrderRequestileApproval";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalAttributeKeys.@CurrentLevel, "currentlevel") ?? "currentlevel") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalAttributeKeys.@CurrentLevel, "currentlevel") ?? "currentlevel") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENOrderRequestFileApproval.ssOrderRequestFileId==0L)) {
sqlCmd.CreateParameter("@ssOrderRequestFileId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssOrderRequestFileId", DbType.Int64, ssENOrderRequestFileApproval.ssOrderRequestFileId);

}
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssCurrentLevel", DbType.Int32, ssENOrderRequestFileApproval.ssCurrentLevel);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssMaxLevel", DbType.Int32, ssENOrderRequestFileApproval.ssMaxLevel);
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssStartedOn", DbType.DateTime, ssENOrderRequestFileApproval.ssStartedOn);
}
if(usedFields[5]) {
sqlCmd.CreateParameter("@ssFinishedOn", DbType.DateTime, ssENOrderRequestFileApproval.ssFinishedOn);
}
sqlCmd.CreateParameter("@idparam_ssENOrderRequetFileApproval_ssd_OrderRequestileApproval", DbType.Int64, ssENOrderRequestFileApproval.ssId);
int counter = 0;
if(ssENOrderRequestFileApproval.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateOrderRequestFileApproval (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENOrderRequestFileApprovalEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalAttributeKeys.@OrderRequestFileId, "orderrequestfileid") ?? "orderrequestfileid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalAttributeKeys.@CurrentLevel, "currentlevel") ?? "currentlevel") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalAttributeKeys.@MaxLevel, "maxlevel") ?? "maxlevel") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalAttributeKeys.@StartedOn, "startedon") ?? "startedon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalAttributeKeys.@FinishedOn, "finishedon") ?? "finishedon") + "" +
" ) VALUES (" +
" @ssOrderRequestFileId" +
", @ssCurrentLevel" +
", @ssMaxLevel" +
", @ssStartedOn" +
", @ssFinishedOn" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENOrderRequestFileApproval.ssOrderRequestFileId==0L)) {
insertSqlCmd.CreateParameter("@ssOrderRequestFileId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssOrderRequestFileId", DbType.Int64, ssENOrderRequestFileApproval.ssOrderRequestFileId);

}
insertSqlCmd.CreateParameter("@ssCurrentLevel", DbType.Int32, ssENOrderRequestFileApproval.ssCurrentLevel);
insertSqlCmd.CreateParameter("@ssMaxLevel", DbType.Int32, ssENOrderRequestFileApproval.ssMaxLevel);
insertSqlCmd.CreateParameter("@ssStartedOn", DbType.DateTime, ssENOrderRequestFileApproval.ssStartedOn);
insertSqlCmd.CreateParameter("@ssFinishedOn", DbType.DateTime, ssENOrderRequestFileApproval.ssFinishedOn);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateOrderRequestFileApproval", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENOrderRequestFileApproval.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeOrderRequestFileApproval
/// </summary>

public static async Task CreateOrUpdateSomeOrderRequestFileApproval(IRequestContext requestContext,RL_a38636e8cdfa0597b0a4df54d4425f9d inParamSourceList,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateSomeOrderRequestFileApproval", "1da59bef-e230-464b-87cc-141569e58355.#CreateOrUpdateAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeOrderRequestFileApproval", "1da59bef-e230-464b-87cc-141569e58355.#CreateOrUpdateAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
string entityTableName = ENOrderRequestFileApprovalEntity.LocalViewName(null);
string insertSql = "INSERT INTO " + entityTableName + " (" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalAttributeKeys.@OrderRequestFileId, "orderrequestfileid") ?? "orderrequestfileid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalAttributeKeys.@CurrentLevel, "currentlevel") ?? "currentlevel") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalAttributeKeys.@MaxLevel, "maxlevel") ?? "maxlevel") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalAttributeKeys.@StartedOn, "startedon") ?? "startedon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalAttributeKeys.@FinishedOn, "finishedon") ?? "finishedon") + ") VALUES ( unnest(@ssOrderRequestFileId),  unnest(@ssCurrentLevel),  unnest(@ssMaxLevel),  unnest(@ssStartedOn),  unnest(@ssFinishedOn)) ";
insertSql += "";

string updateSql = "UPDATE " + entityTableName + " SET " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalAttributeKeys.@OrderRequestFileId, "orderrequestfileid") ?? "orderrequestfileid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalAttributeKeys.@OrderRequestFileId, "orderrequestfileid") ?? "orderrequestfileid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalAttributeKeys.@CurrentLevel, "currentlevel") ?? "currentlevel") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalAttributeKeys.@CurrentLevel, "currentlevel") ?? "currentlevel") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalAttributeKeys.@MaxLevel, "maxlevel") ?? "maxlevel") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalAttributeKeys.@MaxLevel, "maxlevel") ?? "maxlevel") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalAttributeKeys.@StartedOn, "startedon") ?? "startedon") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalAttributeKeys.@StartedOn, "startedon") ?? "startedon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalAttributeKeys.@FinishedOn, "finishedon") ?? "finishedon") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalAttributeKeys.@FinishedOn, "finishedon") ?? "finishedon") + " from ( select  unnest(@ssId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalAttributeKeys.@Id, "id") ?? "id") + ",  unnest(@ssOrderRequestFileId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalAttributeKeys.@OrderRequestFileId, "orderrequestfileid") ?? "orderrequestfileid") + ",  unnest(@ssCurrentLevel) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalAttributeKeys.@CurrentLevel, "currentlevel") ?? "currentlevel") + ",  unnest(@ssMaxLevel) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalAttributeKeys.@MaxLevel, "maxlevel") ?? "maxlevel") + ",  unnest(@ssStartedOn) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalAttributeKeys.@StartedOn, "startedon") ?? "startedon") + ",  unnest(@ssFinishedOn) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalAttributeKeys.@FinishedOn, "finishedon") ?? "finishedon") + " ) as updateTable where " + entityTableName + "." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalAttributeKeys.@Id, "id") ?? "id") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalAttributeKeys.@Id, "id") ?? "id") + " ";
updateSql += "";

List<object> insertOrderRequestFileIdList = new List<object>();
List<int> insertCurrentLevelList = new List<int>();
List<int> insertMaxLevelList = new List<int>();
List<DateTime> insertStartedOnList = new List<DateTime>();
List<DateTime> insertFinishedOnList = new List<DateTime>();

List<long> updateIdList = new List<long>();
List<object> updateOrderRequestFileIdList = new List<object>();
List<int> updateCurrentLevelList = new List<int>();
List<int> updateMaxLevelList = new List<int>();
List<DateTime> updateStartedOnList = new List<DateTime>();
List<DateTime> updateFinishedOnList = new List<DateTime>();

var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_64c70b8a3f72d1283f18a3da8f8eb3d5)inParamSourceList.Current).ssENOrderRequestFileApproval;
if (record.ssId != 0L) {
updateIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
if ((record.ssOrderRequestFileId==0L)) {
updateOrderRequestFileIdList.Add(null);
} else {
updateOrderRequestFileIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssOrderRequestFileId));
}
updateCurrentLevelList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssCurrentLevel));
updateMaxLevelList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssMaxLevel));
updateStartedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssStartedOn));
updateFinishedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssFinishedOn));
} else {
if ((record.ssOrderRequestFileId==0L)) {
insertOrderRequestFileIdList.Add(null);
} else {
insertOrderRequestFileIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssOrderRequestFileId));
}
insertCurrentLevelList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssCurrentLevel));
insertMaxLevelList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssMaxLevel));
insertStartedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssStartedOn));
insertFinishedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssFinishedOn));
}
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertOrderRequestFileIdList.IsEmpty() || !insertCurrentLevelList.IsEmpty() || !insertMaxLevelList.IsEmpty() || !insertStartedOnList.IsEmpty() || !insertFinishedOnList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssOrderRequestFileId",DbType.Int64,insertOrderRequestFileIdList);
executionService.CreateParameter(insertSqlCmd,"@ssCurrentLevel",DbType.Int32,insertCurrentLevelList);
executionService.CreateParameter(insertSqlCmd,"@ssMaxLevel",DbType.Int32,insertMaxLevelList);
executionService.CreateParameter(insertSqlCmd,"@ssStartedOn",DbType.DateTime,insertStartedOnList);
executionService.CreateParameter(insertSqlCmd,"@ssFinishedOn",DbType.DateTime,insertFinishedOnList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeOrderRequestFileApproval (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
if(!updateOrderRequestFileIdList.IsEmpty() || !updateCurrentLevelList.IsEmpty() || !updateMaxLevelList.IsEmpty() || !updateStartedOnList.IsEmpty() || !updateFinishedOnList.IsEmpty()){
await using(var updateSqlCmd = trans.CreateCommand(updateSql)){
executionService.CreateParameter(updateSqlCmd,"@ssId",DbType.Int64,updateIdList);
executionService.CreateParameter(updateSqlCmd,"@ssOrderRequestFileId",DbType.Int64,updateOrderRequestFileIdList);
executionService.CreateParameter(updateSqlCmd,"@ssCurrentLevel",DbType.Int32,updateCurrentLevelList);
executionService.CreateParameter(updateSqlCmd,"@ssMaxLevel",DbType.Int32,updateMaxLevelList);
executionService.CreateParameter(updateSqlCmd,"@ssStartedOn",DbType.DateTime,updateStartedOnList);
executionService.CreateParameter(updateSqlCmd,"@ssFinishedOn",DbType.DateTime,updateFinishedOnList);
await updateSqlCmd.PrepareAsync(cancellationToken);
await updateSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeOrderRequestFileApproval (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(updateSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteOrderRequestFileApproval
/// </summary>

public static async Task DeleteOrderRequestFileApproval(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteOrderRequestFileApproval", "1da59bef-e230-464b-87cc-141569e58355.#DeleteEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteOrderRequestFileApproval", "1da59bef-e230-464b-87cc-141569e58355.#DeleteEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENOrderRequestFileApprovalEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteOrderRequestFileApproval", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllOrderRequestFileApproval
/// </summary>

public static async Task DeleteAllOrderRequestFileApproval(IRequestContext requestContext,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteAllOrderRequestFileApproval", "1da59bef-e230-464b-87cc-141569e58355.#DeleteAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllOrderRequestFileApproval", "1da59bef-e230-464b-87cc-141569e58355.#DeleteAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENOrderRequestFileApprovalEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteOrderRequestFileApproval", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetOrderRequestFileApproval
/// </summary>

public static async Task<RC_64c70b8a3f72d1283f18a3da8f8eb3d5> GetOrderRequestFileApproval(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_64c70b8a3f72d1283f18a3da8f8eb3d5 outParamRecord = default;
outParamRecord = new RC_64c70b8a3f72d1283f18a3da8f8eb3d5();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetOrderRequestFileApproval", "1da59bef-e230-464b-87cc-141569e58355.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetOrderRequestFileApproval", "1da59bef-e230-464b-87cc-141569e58355.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalAttributeKeys.@OrderRequestFileId, "orderrequestfileid") ?? "orderrequestfileid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalAttributeKeys.@CurrentLevel, "currentlevel") ?? "currentlevel", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalAttributeKeys.@MaxLevel, "maxlevel") ?? "maxlevel", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalAttributeKeys.@StartedOn, "startedon") ?? "startedon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalAttributeKeys.@FinishedOn, "finishedon") ?? "finishedon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
" FROM " + ENOrderRequestFileApprovalEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetOrderRequestFileApproval", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(6,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENOrderRequestFileApprovalEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetOrderRequestFileApprovalForUpdate
/// </summary>

public static async Task<RC_64c70b8a3f72d1283f18a3da8f8eb3d5> GetOrderRequestFileApprovalForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_64c70b8a3f72d1283f18a3da8f8eb3d5 outParamRecord = default;
outParamRecord = new RC_64c70b8a3f72d1283f18a3da8f8eb3d5();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetOrderRequestFileApprovalForUpdate", "1da59bef-e230-464b-87cc-141569e58355.#GetEntityForUpdate");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetOrderRequestFileApprovalForUpdate", "1da59bef-e230-464b-87cc-141569e58355.#GetEntityForUpdate", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalAttributeKeys.@OrderRequestFileId, "orderrequestfileid") ?? "orderrequestfileid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalAttributeKeys.@CurrentLevel, "currentlevel") ?? "currentlevel", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalAttributeKeys.@MaxLevel, "maxlevel") ?? "maxlevel", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalAttributeKeys.@StartedOn, "startedon") ?? "startedon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalAttributeKeys.@FinishedOn, "finishedon") ?? "finishedon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
" FROM " + ENOrderRequestFileApprovalEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalAttributeKeys.@Id, "id") ?? "id") + " = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetOrderRequestFileApprovalForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(6,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENOrderRequestFileApprovalEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateOrderRequestFileApproval
/// </summary>

public static async Task UpdateOrderRequestFileApproval(IRequestContext requestContext,BitArray usedFields,RC_64c70b8a3f72d1283f18a3da8f8eb3d5 inParamSource,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("UpdateOrderRequestFileApproval", "1da59bef-e230-464b-87cc-141569e58355.#UpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateOrderRequestFileApproval", "1da59bef-e230-464b-87cc-141569e58355.#UpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_1710c672f4d7138b664ee1411114271eEntityRecord ssENOrderRequestFileApproval = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(6,true);
}
string updateSet = "UPDATE " + ENOrderRequestFileApprovalEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalAttributeKeys.@OrderRequestFileId, "orderrequestfileid") ?? "orderrequestfileid") + " = @ssOrderRequestFileId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalAttributeKeys.@CurrentLevel, "currentlevel") ?? "currentlevel") + " = @ssCurrentLevel"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalAttributeKeys.@MaxLevel, "maxlevel") ?? "maxlevel") + " = @ssMaxLevel"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalAttributeKeys.@StartedOn, "startedon") ?? "startedon") + " = @ssStartedOn"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalAttributeKeys.@FinishedOn, "finishedon") ?? "finishedon") + " = @ssFinishedOn"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENOrderRequetFileApproval_ssd_OrderRequestileApproval";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalAttributeKeys.@CurrentLevel, "currentlevel") ?? "currentlevel") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalAttributeKeys.@CurrentLevel, "currentlevel") ?? "currentlevel") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENOrderRequestFileApproval.ssOrderRequestFileId==0L)) {
sqlCmd.CreateParameter("@ssOrderRequestFileId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssOrderRequestFileId", DbType.Int64, ssENOrderRequestFileApproval.ssOrderRequestFileId);

}
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssCurrentLevel", DbType.Int32, ssENOrderRequestFileApproval.ssCurrentLevel);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssMaxLevel", DbType.Int32, ssENOrderRequestFileApproval.ssMaxLevel);
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssStartedOn", DbType.DateTime, ssENOrderRequestFileApproval.ssStartedOn);
}
if(usedFields[5]) {
sqlCmd.CreateParameter("@ssFinishedOn", DbType.DateTime, ssENOrderRequestFileApproval.ssFinishedOn);
}
sqlCmd.CreateParameter("@idparam_ssENOrderRequetFileApproval_ssd_OrderRequestileApproval", DbType.Int64, ssENOrderRequestFileApproval.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateOrderRequestFileApproval", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("OrderRequestFileApproval", ssENOrderRequestFileApproval.ssId.ToString()); }}
}
return;
}

}
}
