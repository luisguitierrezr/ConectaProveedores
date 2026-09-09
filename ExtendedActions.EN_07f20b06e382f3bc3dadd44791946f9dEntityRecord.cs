using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateOrderCostCenter
/// </summary>

public static async Task<long> CreateOrderCostCenter(IRequestContext requestContext,RC_5460c4bf9b3f96576a08e29ae969cbe7 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrderCostCenter", "56e2c56b-57b8-4cde-9023-f553f7054a6a.#CreateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrderCostCenter", "56e2c56b-57b8-4cde-9023-f553f7054a6a.#CreateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_07f20b06e382f3bc3dadd44791946f9dEntityRecord ssENOrderCostCenter = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENOrderCostCenterEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderCostCenter, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCostCenterAttributeKeys.@OrderId, "orderid") ?? "orderid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderCostCenter, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCostCenterAttributeKeys.@CostcenterSAP, "costcentersap") ?? "costcentersap") + "" +
" ) VALUES (" +
" @ssOrderId" +
", @ssCostcenterSAP" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENOrderCostCenter.ssOrderId==0L)) {
insertSqlCmd.CreateParameter("@ssOrderId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssOrderId", DbType.Int64, ssENOrderCostCenter.ssOrderId);

}
if ((ssENOrderCostCenter.ssCostcenterSAP==0L)) {
insertSqlCmd.CreateParameter("@ssCostcenterSAP", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCostcenterSAP", DbType.Int64, ssENOrderCostCenter.ssCostcenterSAP);

}
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrderCostCenter", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateOrderCostCenter
/// </summary>

public static async Task<long> CreateOrUpdateOrderCostCenter(IRequestContext requestContext,BitArray usedFields,RC_5460c4bf9b3f96576a08e29ae969cbe7 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateOrderCostCenter", "56e2c56b-57b8-4cde-9023-f553f7054a6a.#CreateOrUpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateOrderCostCenter", "56e2c56b-57b8-4cde-9023-f553f7054a6a.#CreateOrUpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_07f20b06e382f3bc3dadd44791946f9dEntityRecord ssENOrderCostCenter = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(3,true);
}
string updateSet = "UPDATE " + ENOrderCostCenterEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderCostCenter, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCostCenterAttributeKeys.@OrderId, "orderid") ?? "orderid") + " = @ssOrderId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderCostCenter, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCostCenterAttributeKeys.@CostcenterSAP, "costcentersap") ?? "costcentersap") + " = @ssCostcenterSAP"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderCostCenter, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCostCenterAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENOrderCostCenter_ssId_OrderCostCenter";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderCostCenter, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCostCenterAttributeKeys.@CostcenterSAP, "costcentersap") ?? "costcentersap") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderCostCenter, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCostCenterAttributeKeys.@CostcenterSAP, "costcentersap") ?? "costcentersap") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENOrderCostCenter.ssOrderId==0L)) {
sqlCmd.CreateParameter("@ssOrderId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssOrderId", DbType.Int64, ssENOrderCostCenter.ssOrderId);

}
}
if(usedFields[2]) {
if ((ssENOrderCostCenter.ssCostcenterSAP==0L)) {
sqlCmd.CreateParameter("@ssCostcenterSAP", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCostcenterSAP", DbType.Int64, ssENOrderCostCenter.ssCostcenterSAP);

}
}
sqlCmd.CreateParameter("@idparam_ssENOrderCostCenter_ssId_OrderCostCenter", DbType.Int64, ssENOrderCostCenter.ssId);
int counter = 0;
if(ssENOrderCostCenter.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateOrderCostCenter (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENOrderCostCenterEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderCostCenter, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCostCenterAttributeKeys.@OrderId, "orderid") ?? "orderid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderCostCenter, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCostCenterAttributeKeys.@CostcenterSAP, "costcentersap") ?? "costcentersap") + "" +
" ) VALUES (" +
" @ssOrderId" +
", @ssCostcenterSAP" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENOrderCostCenter.ssOrderId==0L)) {
insertSqlCmd.CreateParameter("@ssOrderId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssOrderId", DbType.Int64, ssENOrderCostCenter.ssOrderId);

}
if ((ssENOrderCostCenter.ssCostcenterSAP==0L)) {
insertSqlCmd.CreateParameter("@ssCostcenterSAP", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCostcenterSAP", DbType.Int64, ssENOrderCostCenter.ssCostcenterSAP);

}
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateOrderCostCenter", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENOrderCostCenter.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeOrderCostCenter
/// </summary>

public static async Task CreateOrUpdateSomeOrderCostCenter(IRequestContext requestContext,RL_43938fed4828c141405588b16ed6882e inParamSourceList,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateSomeOrderCostCenter", "56e2c56b-57b8-4cde-9023-f553f7054a6a.#CreateOrUpdateAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeOrderCostCenter", "56e2c56b-57b8-4cde-9023-f553f7054a6a.#CreateOrUpdateAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
string entityTableName = ENOrderCostCenterEntity.LocalViewName(null);
string insertSql = "INSERT INTO " + entityTableName + " (" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderCostCenter, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCostCenterAttributeKeys.@OrderId, "orderid") ?? "orderid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderCostCenter, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCostCenterAttributeKeys.@CostcenterSAP, "costcentersap") ?? "costcentersap") + ") VALUES ( unnest(@ssOrderId),  unnest(@ssCostcenterSAP)) ";
insertSql += "";

string updateSql = "UPDATE " + entityTableName + " SET " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderCostCenter, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCostCenterAttributeKeys.@OrderId, "orderid") ?? "orderid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderCostCenter, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCostCenterAttributeKeys.@OrderId, "orderid") ?? "orderid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderCostCenter, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCostCenterAttributeKeys.@CostcenterSAP, "costcentersap") ?? "costcentersap") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderCostCenter, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCostCenterAttributeKeys.@CostcenterSAP, "costcentersap") ?? "costcentersap") + " from ( select  unnest(@ssId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderCostCenter, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCostCenterAttributeKeys.@Id, "id") ?? "id") + ",  unnest(@ssOrderId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderCostCenter, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCostCenterAttributeKeys.@OrderId, "orderid") ?? "orderid") + ",  unnest(@ssCostcenterSAP) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderCostCenter, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCostCenterAttributeKeys.@CostcenterSAP, "costcentersap") ?? "costcentersap") + " ) as updateTable where " + entityTableName + "." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderCostCenter, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCostCenterAttributeKeys.@Id, "id") ?? "id") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderCostCenter, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCostCenterAttributeKeys.@Id, "id") ?? "id") + " ";
updateSql += "";

List<object> insertOrderIdList = new List<object>();
List<object> insertCostcenterSAPList = new List<object>();

List<long> updateIdList = new List<long>();
List<object> updateOrderIdList = new List<object>();
List<object> updateCostcenterSAPList = new List<object>();

var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_5460c4bf9b3f96576a08e29ae969cbe7)inParamSourceList.Current).ssENOrderCostCenter;
if (record.ssId != 0L) {
updateIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
if ((record.ssOrderId==0L)) {
updateOrderIdList.Add(null);
} else {
updateOrderIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssOrderId));
}
if ((record.ssCostcenterSAP==0L)) {
updateCostcenterSAPList.Add(null);
} else {
updateCostcenterSAPList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssCostcenterSAP));
}
} else {
if ((record.ssOrderId==0L)) {
insertOrderIdList.Add(null);
} else {
insertOrderIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssOrderId));
}
if ((record.ssCostcenterSAP==0L)) {
insertCostcenterSAPList.Add(null);
} else {
insertCostcenterSAPList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssCostcenterSAP));
}
}
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertOrderIdList.IsEmpty() || !insertCostcenterSAPList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssOrderId",DbType.Int64,insertOrderIdList);
executionService.CreateParameter(insertSqlCmd,"@ssCostcenterSAP",DbType.Int64,insertCostcenterSAPList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeOrderCostCenter (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
if(!updateOrderIdList.IsEmpty() || !updateCostcenterSAPList.IsEmpty()){
await using(var updateSqlCmd = trans.CreateCommand(updateSql)){
executionService.CreateParameter(updateSqlCmd,"@ssId",DbType.Int64,updateIdList);
executionService.CreateParameter(updateSqlCmd,"@ssOrderId",DbType.Int64,updateOrderIdList);
executionService.CreateParameter(updateSqlCmd,"@ssCostcenterSAP",DbType.Int64,updateCostcenterSAPList);
await updateSqlCmd.PrepareAsync(cancellationToken);
await updateSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeOrderCostCenter (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(updateSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteOrderCostCenter
/// </summary>

public static async Task DeleteOrderCostCenter(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteOrderCostCenter", "56e2c56b-57b8-4cde-9023-f553f7054a6a.#DeleteEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteOrderCostCenter", "56e2c56b-57b8-4cde-9023-f553f7054a6a.#DeleteEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENOrderCostCenterEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderCostCenter, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCostCenterAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteOrderCostCenter", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllOrderCostCenter
/// </summary>

public static async Task DeleteAllOrderCostCenter(IRequestContext requestContext,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteAllOrderCostCenter", "56e2c56b-57b8-4cde-9023-f553f7054a6a.#DeleteAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllOrderCostCenter", "56e2c56b-57b8-4cde-9023-f553f7054a6a.#DeleteAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENOrderCostCenterEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteOrderCostCenter", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetOrderCostCenter
/// </summary>

public static async Task<RC_5460c4bf9b3f96576a08e29ae969cbe7> GetOrderCostCenter(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_5460c4bf9b3f96576a08e29ae969cbe7 outParamRecord = default;
outParamRecord = new RC_5460c4bf9b3f96576a08e29ae969cbe7();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetOrderCostCenter", "56e2c56b-57b8-4cde-9023-f553f7054a6a.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetOrderCostCenter", "56e2c56b-57b8-4cde-9023-f553f7054a6a.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderCostCenter, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCostCenterAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderCostCenter, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCostCenterAttributeKeys.@OrderId, "orderid") ?? "orderid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderCostCenter, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCostCenterAttributeKeys.@CostcenterSAP, "costcentersap") ?? "costcentersap", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
" FROM " + ENOrderCostCenterEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderCostCenter, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCostCenterAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetOrderCostCenter", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(3,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENOrderCostCenterEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetOrderCostCenterForUpdate
/// </summary>

public static async Task<RC_5460c4bf9b3f96576a08e29ae969cbe7> GetOrderCostCenterForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_5460c4bf9b3f96576a08e29ae969cbe7 outParamRecord = default;
outParamRecord = new RC_5460c4bf9b3f96576a08e29ae969cbe7();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetOrderCostCenterForUpdate", "56e2c56b-57b8-4cde-9023-f553f7054a6a.#GetEntityForUpdate");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetOrderCostCenterForUpdate", "56e2c56b-57b8-4cde-9023-f553f7054a6a.#GetEntityForUpdate", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderCostCenter, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCostCenterAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderCostCenter, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCostCenterAttributeKeys.@OrderId, "orderid") ?? "orderid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderCostCenter, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCostCenterAttributeKeys.@CostcenterSAP, "costcentersap") ?? "costcentersap", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
" FROM " + ENOrderCostCenterEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderCostCenter, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCostCenterAttributeKeys.@Id, "id") ?? "id") + " = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetOrderCostCenterForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(3,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENOrderCostCenterEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateOrderCostCenter
/// </summary>

public static async Task UpdateOrderCostCenter(IRequestContext requestContext,BitArray usedFields,RC_5460c4bf9b3f96576a08e29ae969cbe7 inParamSource,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("UpdateOrderCostCenter", "56e2c56b-57b8-4cde-9023-f553f7054a6a.#UpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateOrderCostCenter", "56e2c56b-57b8-4cde-9023-f553f7054a6a.#UpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_07f20b06e382f3bc3dadd44791946f9dEntityRecord ssENOrderCostCenter = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(3,true);
}
string updateSet = "UPDATE " + ENOrderCostCenterEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderCostCenter, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCostCenterAttributeKeys.@OrderId, "orderid") ?? "orderid") + " = @ssOrderId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderCostCenter, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCostCenterAttributeKeys.@CostcenterSAP, "costcentersap") ?? "costcentersap") + " = @ssCostcenterSAP"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderCostCenter, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCostCenterAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENOrderCostCenter_ssId_OrderCostCenter";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderCostCenter, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCostCenterAttributeKeys.@CostcenterSAP, "costcentersap") ?? "costcentersap") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderCostCenter, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCostCenterAttributeKeys.@CostcenterSAP, "costcentersap") ?? "costcentersap") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENOrderCostCenter.ssOrderId==0L)) {
sqlCmd.CreateParameter("@ssOrderId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssOrderId", DbType.Int64, ssENOrderCostCenter.ssOrderId);

}
}
if(usedFields[2]) {
if ((ssENOrderCostCenter.ssCostcenterSAP==0L)) {
sqlCmd.CreateParameter("@ssCostcenterSAP", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCostcenterSAP", DbType.Int64, ssENOrderCostCenter.ssCostcenterSAP);

}
}
sqlCmd.CreateParameter("@idparam_ssENOrderCostCenter_ssId_OrderCostCenter", DbType.Int64, ssENOrderCostCenter.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateOrderCostCenter", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("OrderCostCenter", ssENOrderCostCenter.ssId.ToString()); }}
}
return;
}

}
}
