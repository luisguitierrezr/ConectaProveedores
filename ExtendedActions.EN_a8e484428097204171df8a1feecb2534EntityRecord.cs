using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateOrderLogs
/// </summary>

public static async Task<long> CreateOrderLogs(IRequestContext requestContext,RC_aa950ad3dd0235488db9d65307673199 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrderLogs", "8f2a7b27-7778-4a54-b960-e018cb7e762c.#CreateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrderLogs", "8f2a7b27-7778-4a54-b960-e018cb7e762c.#CreateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_a8e484428097204171df8a1feecb2534EntityRecord ssENOrderLogs = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENOrderLogsEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderLogsAttributeKeys.@OrderId, "orderid") ?? "orderid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderLogsAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderLogsAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderLogsAttributeKeys.@Message, "message") ?? "message") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderLogsAttributeKeys.@IsError, "iserror") ?? "iserror") + "" +
" ) VALUES (" +
" @ssOrderId" +
", @ssCreatedBy" +
", @ssCreatedOn" +
", @ssMessage" +
", @ssIsError" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENOrderLogs.ssOrderId==0L)) {
insertSqlCmd.CreateParameter("@ssOrderId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssOrderId", DbType.Int64, ssENOrderLogs.ssOrderId);

}
if ((ssENOrderLogs.ssCreatedBy=="")) {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENOrderLogs.ssCreatedBy);

}
insertSqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENOrderLogs.ssCreatedOn);
insertSqlCmd.CreateParameter("@ssMessage", DbType.String, ssENOrderLogs.ssMessage);
insertSqlCmd.CreateParameter("@ssIsError", DbType.Boolean, ssENOrderLogs.ssIsError);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrderLogs", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateOrderLogs
/// </summary>

public static async Task<long> CreateOrUpdateOrderLogs(IRequestContext requestContext,BitArray usedFields,RC_aa950ad3dd0235488db9d65307673199 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateOrderLogs", "8f2a7b27-7778-4a54-b960-e018cb7e762c.#CreateOrUpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateOrderLogs", "8f2a7b27-7778-4a54-b960-e018cb7e762c.#CreateOrUpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_a8e484428097204171df8a1feecb2534EntityRecord ssENOrderLogs = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(6,true);
}
string updateSet = "UPDATE " + ENOrderLogsEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderLogsAttributeKeys.@OrderId, "orderid") ?? "orderid") + " = @ssOrderId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderLogsAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = @ssCreatedBy"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderLogsAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = @ssCreatedOn"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderLogsAttributeKeys.@Message, "message") ?? "message") + " = @ssMessage"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderLogsAttributeKeys.@IsError, "iserror") ?? "iserror") + " = @ssIsError"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderLogsAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENOrderLogs_ssId_OrderLogs";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderLogsAttributeKeys.@IsError, "iserror") ?? "iserror") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderLogsAttributeKeys.@IsError, "iserror") ?? "iserror") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENOrderLogs.ssOrderId==0L)) {
sqlCmd.CreateParameter("@ssOrderId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssOrderId", DbType.Int64, ssENOrderLogs.ssOrderId);

}
}
if(usedFields[2]) {
if ((ssENOrderLogs.ssCreatedBy=="")) {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENOrderLogs.ssCreatedBy);

}
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENOrderLogs.ssCreatedOn);
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssMessage", DbType.String, ssENOrderLogs.ssMessage);
}
if(usedFields[5]) {
sqlCmd.CreateParameter("@ssIsError", DbType.Boolean, ssENOrderLogs.ssIsError);
}
sqlCmd.CreateParameter("@idparam_ssENOrderLogs_ssId_OrderLogs", DbType.Int64, ssENOrderLogs.ssId);
int counter = 0;
if(ssENOrderLogs.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateOrderLogs (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENOrderLogsEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderLogsAttributeKeys.@OrderId, "orderid") ?? "orderid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderLogsAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderLogsAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderLogsAttributeKeys.@Message, "message") ?? "message") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderLogsAttributeKeys.@IsError, "iserror") ?? "iserror") + "" +
" ) VALUES (" +
" @ssOrderId" +
", @ssCreatedBy" +
", @ssCreatedOn" +
", @ssMessage" +
", @ssIsError" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENOrderLogs.ssOrderId==0L)) {
insertSqlCmd.CreateParameter("@ssOrderId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssOrderId", DbType.Int64, ssENOrderLogs.ssOrderId);

}
if ((ssENOrderLogs.ssCreatedBy=="")) {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENOrderLogs.ssCreatedBy);

}
insertSqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENOrderLogs.ssCreatedOn);
insertSqlCmd.CreateParameter("@ssMessage", DbType.String, ssENOrderLogs.ssMessage);
insertSqlCmd.CreateParameter("@ssIsError", DbType.Boolean, ssENOrderLogs.ssIsError);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateOrderLogs", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENOrderLogs.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeOrderLogs
/// </summary>

public static async Task CreateOrUpdateSomeOrderLogs(IRequestContext requestContext,RL_2ff7502185db3c03acfc62a4b98a3a5f inParamSourceList,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateSomeOrderLogs", "8f2a7b27-7778-4a54-b960-e018cb7e762c.#CreateOrUpdateAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeOrderLogs", "8f2a7b27-7778-4a54-b960-e018cb7e762c.#CreateOrUpdateAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
string entityTableName = ENOrderLogsEntity.LocalViewName(null);
string insertSql = "INSERT INTO " + entityTableName + " (" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderLogsAttributeKeys.@OrderId, "orderid") ?? "orderid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderLogsAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderLogsAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderLogsAttributeKeys.@Message, "message") ?? "message") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderLogsAttributeKeys.@IsError, "iserror") ?? "iserror") + ") VALUES ( unnest(@ssOrderId),  unnest(@ssCreatedBy),  unnest(@ssCreatedOn),  unnest(@ssMessage),  unnest(@ssIsError)) ";
insertSql += "";

string updateSql = "UPDATE " + entityTableName + " SET " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderLogsAttributeKeys.@OrderId, "orderid") ?? "orderid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderLogsAttributeKeys.@OrderId, "orderid") ?? "orderid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderLogsAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderLogsAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderLogsAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderLogsAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderLogsAttributeKeys.@Message, "message") ?? "message") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderLogsAttributeKeys.@Message, "message") ?? "message") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderLogsAttributeKeys.@IsError, "iserror") ?? "iserror") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderLogsAttributeKeys.@IsError, "iserror") ?? "iserror") + " from ( select  unnest(@ssId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderLogsAttributeKeys.@Id, "id") ?? "id") + ",  unnest(@ssOrderId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderLogsAttributeKeys.@OrderId, "orderid") ?? "orderid") + ",  unnest(@ssCreatedBy) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderLogsAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + ",  unnest(@ssCreatedOn) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderLogsAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + ",  unnest(@ssMessage) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderLogsAttributeKeys.@Message, "message") ?? "message") + ",  unnest(@ssIsError) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderLogsAttributeKeys.@IsError, "iserror") ?? "iserror") + " ) as updateTable where " + entityTableName + "." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderLogsAttributeKeys.@Id, "id") ?? "id") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderLogsAttributeKeys.@Id, "id") ?? "id") + " ";
updateSql += "";

List<object> insertOrderIdList = new List<object>();
List<object> insertCreatedByList = new List<object>();
List<DateTime> insertCreatedOnList = new List<DateTime>();
List<string> insertMessageList = new List<string>();
List<bool> insertIsErrorList = new List<bool>();

List<long> updateIdList = new List<long>();
List<object> updateOrderIdList = new List<object>();
List<object> updateCreatedByList = new List<object>();
List<DateTime> updateCreatedOnList = new List<DateTime>();
List<string> updateMessageList = new List<string>();
List<bool> updateIsErrorList = new List<bool>();

var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_aa950ad3dd0235488db9d65307673199)inParamSourceList.Current).ssENOrderLogs;
if (record.ssId != 0L) {
updateIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
if ((record.ssOrderId==0L)) {
updateOrderIdList.Add(null);
} else {
updateOrderIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssOrderId));
}
if ((record.ssCreatedBy=="")) {
updateCreatedByList.Add(null);
} else {
updateCreatedByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssCreatedBy));
}
updateCreatedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssCreatedOn));
updateMessageList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssMessage));
updateIsErrorList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsError));
} else {
if ((record.ssOrderId==0L)) {
insertOrderIdList.Add(null);
} else {
insertOrderIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssOrderId));
}
if ((record.ssCreatedBy=="")) {
insertCreatedByList.Add(null);
} else {
insertCreatedByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssCreatedBy));
}
insertCreatedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssCreatedOn));
insertMessageList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssMessage));
insertIsErrorList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsError));
}
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertOrderIdList.IsEmpty() || !insertCreatedByList.IsEmpty() || !insertCreatedOnList.IsEmpty() || !insertMessageList.IsEmpty() || !insertIsErrorList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssOrderId",DbType.Int64,insertOrderIdList);
executionService.CreateParameter(insertSqlCmd,"@ssCreatedBy",DbType.String,insertCreatedByList);
executionService.CreateParameter(insertSqlCmd,"@ssCreatedOn",DbType.DateTime,insertCreatedOnList);
executionService.CreateParameter(insertSqlCmd,"@ssMessage",DbType.String,insertMessageList);
executionService.CreateParameter(insertSqlCmd,"@ssIsError",DbType.Boolean,insertIsErrorList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeOrderLogs (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
if(!updateOrderIdList.IsEmpty() || !updateCreatedByList.IsEmpty() || !updateCreatedOnList.IsEmpty() || !updateMessageList.IsEmpty() || !updateIsErrorList.IsEmpty()){
await using(var updateSqlCmd = trans.CreateCommand(updateSql)){
executionService.CreateParameter(updateSqlCmd,"@ssId",DbType.Int64,updateIdList);
executionService.CreateParameter(updateSqlCmd,"@ssOrderId",DbType.Int64,updateOrderIdList);
executionService.CreateParameter(updateSqlCmd,"@ssCreatedBy",DbType.String,updateCreatedByList);
executionService.CreateParameter(updateSqlCmd,"@ssCreatedOn",DbType.DateTime,updateCreatedOnList);
executionService.CreateParameter(updateSqlCmd,"@ssMessage",DbType.String,updateMessageList);
executionService.CreateParameter(updateSqlCmd,"@ssIsError",DbType.Boolean,updateIsErrorList);
await updateSqlCmd.PrepareAsync(cancellationToken);
await updateSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeOrderLogs (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(updateSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteOrderLogs
/// </summary>

public static async Task DeleteOrderLogs(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteOrderLogs", "8f2a7b27-7778-4a54-b960-e018cb7e762c.#DeleteEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteOrderLogs", "8f2a7b27-7778-4a54-b960-e018cb7e762c.#DeleteEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENOrderLogsEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderLogsAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteOrderLogs", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllOrderLogs
/// </summary>

public static async Task DeleteAllOrderLogs(IRequestContext requestContext,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteAllOrderLogs", "8f2a7b27-7778-4a54-b960-e018cb7e762c.#DeleteAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllOrderLogs", "8f2a7b27-7778-4a54-b960-e018cb7e762c.#DeleteAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENOrderLogsEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteOrderLogs", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetOrderLogs
/// </summary>

public static async Task<RC_aa950ad3dd0235488db9d65307673199> GetOrderLogs(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_aa950ad3dd0235488db9d65307673199 outParamRecord = default;
outParamRecord = new RC_aa950ad3dd0235488db9d65307673199();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetOrderLogs", "8f2a7b27-7778-4a54-b960-e018cb7e762c.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetOrderLogs", "8f2a7b27-7778-4a54-b960-e018cb7e762c.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderLogsAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderLogsAttributeKeys.@OrderId, "orderid") ?? "orderid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderLogsAttributeKeys.@CreatedBy, "createdby") ?? "createdby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderLogsAttributeKeys.@CreatedOn, "createdon") ?? "createdon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderLogsAttributeKeys.@Message, "message") ?? "message", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderLogsAttributeKeys.@IsError, "iserror") ?? "iserror", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
" FROM " + ENOrderLogsEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderLogsAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetOrderLogs", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(6,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENOrderLogsEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetOrderLogsForUpdate
/// </summary>

public static async Task<RC_aa950ad3dd0235488db9d65307673199> GetOrderLogsForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_aa950ad3dd0235488db9d65307673199 outParamRecord = default;
outParamRecord = new RC_aa950ad3dd0235488db9d65307673199();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetOrderLogsForUpdate", "8f2a7b27-7778-4a54-b960-e018cb7e762c.#GetEntityForUpdate");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetOrderLogsForUpdate", "8f2a7b27-7778-4a54-b960-e018cb7e762c.#GetEntityForUpdate", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderLogsAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderLogsAttributeKeys.@OrderId, "orderid") ?? "orderid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderLogsAttributeKeys.@CreatedBy, "createdby") ?? "createdby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderLogsAttributeKeys.@CreatedOn, "createdon") ?? "createdon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderLogsAttributeKeys.@Message, "message") ?? "message", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderLogsAttributeKeys.@IsError, "iserror") ?? "iserror", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
" FROM " + ENOrderLogsEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderLogsAttributeKeys.@Id, "id") ?? "id") + " = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetOrderLogsForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(6,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENOrderLogsEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateOrderLogs
/// </summary>

public static async Task UpdateOrderLogs(IRequestContext requestContext,BitArray usedFields,RC_aa950ad3dd0235488db9d65307673199 inParamSource,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("UpdateOrderLogs", "8f2a7b27-7778-4a54-b960-e018cb7e762c.#UpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateOrderLogs", "8f2a7b27-7778-4a54-b960-e018cb7e762c.#UpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_a8e484428097204171df8a1feecb2534EntityRecord ssENOrderLogs = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(6,true);
}
string updateSet = "UPDATE " + ENOrderLogsEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderLogsAttributeKeys.@OrderId, "orderid") ?? "orderid") + " = @ssOrderId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderLogsAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = @ssCreatedBy"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderLogsAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = @ssCreatedOn"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderLogsAttributeKeys.@Message, "message") ?? "message") + " = @ssMessage"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderLogsAttributeKeys.@IsError, "iserror") ?? "iserror") + " = @ssIsError"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderLogsAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENOrderLogs_ssId_OrderLogs";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderLogsAttributeKeys.@IsError, "iserror") ?? "iserror") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderLogsAttributeKeys.@IsError, "iserror") ?? "iserror") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENOrderLogs.ssOrderId==0L)) {
sqlCmd.CreateParameter("@ssOrderId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssOrderId", DbType.Int64, ssENOrderLogs.ssOrderId);

}
}
if(usedFields[2]) {
if ((ssENOrderLogs.ssCreatedBy=="")) {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENOrderLogs.ssCreatedBy);

}
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENOrderLogs.ssCreatedOn);
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssMessage", DbType.String, ssENOrderLogs.ssMessage);
}
if(usedFields[5]) {
sqlCmd.CreateParameter("@ssIsError", DbType.Boolean, ssENOrderLogs.ssIsError);
}
sqlCmd.CreateParameter("@idparam_ssENOrderLogs_ssId_OrderLogs", DbType.Int64, ssENOrderLogs.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateOrderLogs", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("OrderLogs", ssENOrderLogs.ssId.ToString()); }}
}
return;
}

}
}
