using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateInvoicePolizaStorage
/// </summary>

public static async Task<long> CreateInvoicePolizaStorage(IRequestContext requestContext,RC_285d5103004edd69f9105c056eb9d2a6 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateInvoicePolizaStorage", "98af29fa-d38f-4de4-ad93-02d7e0cff932.#CreateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateInvoicePolizaStorage", "98af29fa-d38f-4de4-ad93-02d7e0cff932.#CreateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_c914a6fdb165c9751808adf2e01e2226EntityRecord ssENInvoicePolizaStorage = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENInvoicePolizaStorageEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePolizaStorage, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaStorageAttributeKeys.@PolizaFlowId, "polizaflowid") ?? "polizaflowid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePolizaStorage, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaStorageAttributeKeys.@StorageId, "storageid") ?? "storageid") + "" +
" ) VALUES (" +
" @ssPolizaFlowId" +
", @ssStorageId" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENInvoicePolizaStorage.ssPolizaFlowId==0L)) {
insertSqlCmd.CreateParameter("@ssPolizaFlowId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssPolizaFlowId", DbType.Int64, ssENInvoicePolizaStorage.ssPolizaFlowId);

}
if ((ssENInvoicePolizaStorage.ssStorageId==0L)) {
insertSqlCmd.CreateParameter("@ssStorageId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssStorageId", DbType.Int64, ssENInvoicePolizaStorage.ssStorageId);

}
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateInvoicePolizaStorage", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateInvoicePolizaStorage
/// </summary>

public static async Task<long> CreateOrUpdateInvoicePolizaStorage(IRequestContext requestContext,BitArray usedFields,RC_285d5103004edd69f9105c056eb9d2a6 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateInvoicePolizaStorage", "98af29fa-d38f-4de4-ad93-02d7e0cff932.#CreateOrUpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateInvoicePolizaStorage", "98af29fa-d38f-4de4-ad93-02d7e0cff932.#CreateOrUpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_c914a6fdb165c9751808adf2e01e2226EntityRecord ssENInvoicePolizaStorage = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(3,true);
}
string updateSet = "UPDATE " + ENInvoicePolizaStorageEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePolizaStorage, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaStorageAttributeKeys.@PolizaFlowId, "polizaflowid") ?? "polizaflowid") + " = @ssPolizaFlowId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePolizaStorage, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaStorageAttributeKeys.@StorageId, "storageid") ?? "storageid") + " = @ssStorageId"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePolizaStorage, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaStorageAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENInvoicePolizaStorage_ssId_InvoicePolizaStorage";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePolizaStorage, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaStorageAttributeKeys.@StorageId, "storageid") ?? "storageid") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePolizaStorage, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaStorageAttributeKeys.@StorageId, "storageid") ?? "storageid") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENInvoicePolizaStorage.ssPolizaFlowId==0L)) {
sqlCmd.CreateParameter("@ssPolizaFlowId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssPolizaFlowId", DbType.Int64, ssENInvoicePolizaStorage.ssPolizaFlowId);

}
}
if(usedFields[2]) {
if ((ssENInvoicePolizaStorage.ssStorageId==0L)) {
sqlCmd.CreateParameter("@ssStorageId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssStorageId", DbType.Int64, ssENInvoicePolizaStorage.ssStorageId);

}
}
sqlCmd.CreateParameter("@idparam_ssENInvoicePolizaStorage_ssId_InvoicePolizaStorage", DbType.Int64, ssENInvoicePolizaStorage.ssId);
int counter = 0;
if(ssENInvoicePolizaStorage.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateInvoicePolizaStorage (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENInvoicePolizaStorageEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePolizaStorage, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaStorageAttributeKeys.@PolizaFlowId, "polizaflowid") ?? "polizaflowid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePolizaStorage, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaStorageAttributeKeys.@StorageId, "storageid") ?? "storageid") + "" +
" ) VALUES (" +
" @ssPolizaFlowId" +
", @ssStorageId" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENInvoicePolizaStorage.ssPolizaFlowId==0L)) {
insertSqlCmd.CreateParameter("@ssPolizaFlowId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssPolizaFlowId", DbType.Int64, ssENInvoicePolizaStorage.ssPolizaFlowId);

}
if ((ssENInvoicePolizaStorage.ssStorageId==0L)) {
insertSqlCmd.CreateParameter("@ssStorageId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssStorageId", DbType.Int64, ssENInvoicePolizaStorage.ssStorageId);

}
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateInvoicePolizaStorage", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENInvoicePolizaStorage.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeInvoicePolizaStorage
/// </summary>

public static async Task CreateOrUpdateSomeInvoicePolizaStorage(IRequestContext requestContext,RL_07ac56adaf714bda8c987b24888a8934 inParamSourceList,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateSomeInvoicePolizaStorage", "98af29fa-d38f-4de4-ad93-02d7e0cff932.#CreateOrUpdateAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeInvoicePolizaStorage", "98af29fa-d38f-4de4-ad93-02d7e0cff932.#CreateOrUpdateAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
string entityTableName = ENInvoicePolizaStorageEntity.LocalViewName(null);
string insertSql = "INSERT INTO " + entityTableName + " (" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePolizaStorage, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaStorageAttributeKeys.@PolizaFlowId, "polizaflowid") ?? "polizaflowid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePolizaStorage, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaStorageAttributeKeys.@StorageId, "storageid") ?? "storageid") + ") VALUES ( unnest(@ssPolizaFlowId),  unnest(@ssStorageId)) ";
insertSql += "";

string updateSql = "UPDATE " + entityTableName + " SET " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePolizaStorage, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaStorageAttributeKeys.@PolizaFlowId, "polizaflowid") ?? "polizaflowid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePolizaStorage, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaStorageAttributeKeys.@PolizaFlowId, "polizaflowid") ?? "polizaflowid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePolizaStorage, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaStorageAttributeKeys.@StorageId, "storageid") ?? "storageid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePolizaStorage, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaStorageAttributeKeys.@StorageId, "storageid") ?? "storageid") + " from ( select  unnest(@ssId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePolizaStorage, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaStorageAttributeKeys.@Id, "id") ?? "id") + ",  unnest(@ssPolizaFlowId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePolizaStorage, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaStorageAttributeKeys.@PolizaFlowId, "polizaflowid") ?? "polizaflowid") + ",  unnest(@ssStorageId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePolizaStorage, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaStorageAttributeKeys.@StorageId, "storageid") ?? "storageid") + " ) as updateTable where " + entityTableName + "." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePolizaStorage, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaStorageAttributeKeys.@Id, "id") ?? "id") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePolizaStorage, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaStorageAttributeKeys.@Id, "id") ?? "id") + " ";
updateSql += "";

List<object> insertPolizaFlowIdList = new List<object>();
List<object> insertStorageIdList = new List<object>();

List<long> updateIdList = new List<long>();
List<object> updatePolizaFlowIdList = new List<object>();
List<object> updateStorageIdList = new List<object>();

var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_285d5103004edd69f9105c056eb9d2a6)inParamSourceList.Current).ssENInvoicePolizaStorage;
if (record.ssId != 0L) {
updateIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
if ((record.ssPolizaFlowId==0L)) {
updatePolizaFlowIdList.Add(null);
} else {
updatePolizaFlowIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssPolizaFlowId));
}
if ((record.ssStorageId==0L)) {
updateStorageIdList.Add(null);
} else {
updateStorageIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssStorageId));
}
} else {
if ((record.ssPolizaFlowId==0L)) {
insertPolizaFlowIdList.Add(null);
} else {
insertPolizaFlowIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssPolizaFlowId));
}
if ((record.ssStorageId==0L)) {
insertStorageIdList.Add(null);
} else {
insertStorageIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssStorageId));
}
}
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertPolizaFlowIdList.IsEmpty() || !insertStorageIdList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssPolizaFlowId",DbType.Int64,insertPolizaFlowIdList);
executionService.CreateParameter(insertSqlCmd,"@ssStorageId",DbType.Int64,insertStorageIdList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeInvoicePolizaStorage (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
if(!updatePolizaFlowIdList.IsEmpty() || !updateStorageIdList.IsEmpty()){
await using(var updateSqlCmd = trans.CreateCommand(updateSql)){
executionService.CreateParameter(updateSqlCmd,"@ssId",DbType.Int64,updateIdList);
executionService.CreateParameter(updateSqlCmd,"@ssPolizaFlowId",DbType.Int64,updatePolizaFlowIdList);
executionService.CreateParameter(updateSqlCmd,"@ssStorageId",DbType.Int64,updateStorageIdList);
await updateSqlCmd.PrepareAsync(cancellationToken);
await updateSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeInvoicePolizaStorage (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(updateSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteInvoicePolizaStorage
/// </summary>

public static async Task DeleteInvoicePolizaStorage(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteInvoicePolizaStorage", "98af29fa-d38f-4de4-ad93-02d7e0cff932.#DeleteEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteInvoicePolizaStorage", "98af29fa-d38f-4de4-ad93-02d7e0cff932.#DeleteEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENInvoicePolizaStorageEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePolizaStorage, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaStorageAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteInvoicePolizaStorage", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllInvoicePolizaStorage
/// </summary>

public static async Task DeleteAllInvoicePolizaStorage(IRequestContext requestContext,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteAllInvoicePolizaStorage", "98af29fa-d38f-4de4-ad93-02d7e0cff932.#DeleteAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllInvoicePolizaStorage", "98af29fa-d38f-4de4-ad93-02d7e0cff932.#DeleteAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENInvoicePolizaStorageEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteInvoicePolizaStorage", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetInvoicePolizaStorage
/// </summary>

public static async Task<RC_285d5103004edd69f9105c056eb9d2a6> GetInvoicePolizaStorage(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_285d5103004edd69f9105c056eb9d2a6 outParamRecord = default;
outParamRecord = new RC_285d5103004edd69f9105c056eb9d2a6();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetInvoicePolizaStorage", "98af29fa-d38f-4de4-ad93-02d7e0cff932.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetInvoicePolizaStorage", "98af29fa-d38f-4de4-ad93-02d7e0cff932.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePolizaStorage, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaStorageAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePolizaStorage, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaStorageAttributeKeys.@PolizaFlowId, "polizaflowid") ?? "polizaflowid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePolizaStorage, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaStorageAttributeKeys.@StorageId, "storageid") ?? "storageid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
" FROM " + ENInvoicePolizaStorageEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePolizaStorage, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaStorageAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetInvoicePolizaStorage", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(3,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENInvoicePolizaStorageEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetInvoicePolizaStorageForUpdate
/// </summary>

public static async Task<RC_285d5103004edd69f9105c056eb9d2a6> GetInvoicePolizaStorageForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_285d5103004edd69f9105c056eb9d2a6 outParamRecord = default;
outParamRecord = new RC_285d5103004edd69f9105c056eb9d2a6();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetInvoicePolizaStorageForUpdate", "98af29fa-d38f-4de4-ad93-02d7e0cff932.#GetEntityForUpdate");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetInvoicePolizaStorageForUpdate", "98af29fa-d38f-4de4-ad93-02d7e0cff932.#GetEntityForUpdate", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePolizaStorage, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaStorageAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePolizaStorage, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaStorageAttributeKeys.@PolizaFlowId, "polizaflowid") ?? "polizaflowid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePolizaStorage, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaStorageAttributeKeys.@StorageId, "storageid") ?? "storageid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
" FROM " + ENInvoicePolizaStorageEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePolizaStorage, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaStorageAttributeKeys.@Id, "id") ?? "id") + " = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetInvoicePolizaStorageForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(3,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENInvoicePolizaStorageEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateInvoicePolizaStorage
/// </summary>

public static async Task UpdateInvoicePolizaStorage(IRequestContext requestContext,BitArray usedFields,RC_285d5103004edd69f9105c056eb9d2a6 inParamSource,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("UpdateInvoicePolizaStorage", "98af29fa-d38f-4de4-ad93-02d7e0cff932.#UpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateInvoicePolizaStorage", "98af29fa-d38f-4de4-ad93-02d7e0cff932.#UpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_c914a6fdb165c9751808adf2e01e2226EntityRecord ssENInvoicePolizaStorage = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(3,true);
}
string updateSet = "UPDATE " + ENInvoicePolizaStorageEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePolizaStorage, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaStorageAttributeKeys.@PolizaFlowId, "polizaflowid") ?? "polizaflowid") + " = @ssPolizaFlowId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePolizaStorage, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaStorageAttributeKeys.@StorageId, "storageid") ?? "storageid") + " = @ssStorageId"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePolizaStorage, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaStorageAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENInvoicePolizaStorage_ssId_InvoicePolizaStorage";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePolizaStorage, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaStorageAttributeKeys.@StorageId, "storageid") ?? "storageid") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePolizaStorage, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaStorageAttributeKeys.@StorageId, "storageid") ?? "storageid") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENInvoicePolizaStorage.ssPolizaFlowId==0L)) {
sqlCmd.CreateParameter("@ssPolizaFlowId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssPolizaFlowId", DbType.Int64, ssENInvoicePolizaStorage.ssPolizaFlowId);

}
}
if(usedFields[2]) {
if ((ssENInvoicePolizaStorage.ssStorageId==0L)) {
sqlCmd.CreateParameter("@ssStorageId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssStorageId", DbType.Int64, ssENInvoicePolizaStorage.ssStorageId);

}
}
sqlCmd.CreateParameter("@idparam_ssENInvoicePolizaStorage_ssId_InvoicePolizaStorage", DbType.Int64, ssENInvoicePolizaStorage.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateInvoicePolizaStorage", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("InvoicePolizaStorage", ssENInvoicePolizaStorage.ssId.ToString()); }}
}
return;
}

}
}
