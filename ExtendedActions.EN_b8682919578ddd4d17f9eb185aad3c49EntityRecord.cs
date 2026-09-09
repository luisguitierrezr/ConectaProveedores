using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateColumnSettings
/// </summary>

public static async Task<long> CreateColumnSettings(IRequestContext requestContext,RC_25c6d4ad26c50e9400baa0d709166594 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateColumnSettings", "124674ba-816d-447f-93e6-154044294e15.#CreateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateColumnSettings", "124674ba-816d-447f-93e6-154044294e15.#CreateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_b8682919578ddd4d17f9eb185aad3c49EntityRecord ssENColumnSettings = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENColumnSettingsEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ColumnSettings, _EntityKeyConstants._ConectaProveedoresEntityKeys._ColumnSettingsAttributeKeys.@TableName, "tablename") ?? "tablename") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ColumnSettings, _EntityKeyConstants._ConectaProveedoresEntityKeys._ColumnSettingsAttributeKeys.@JSONData, "jsondata") ?? "jsondata") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ColumnSettings, _EntityKeyConstants._ConectaProveedoresEntityKeys._ColumnSettingsAttributeKeys.@UserId, "userid") ?? "userid") + "" +
" ) VALUES (" +
" @ssTableName" +
", @ssJSONData" +
", @ssUserId" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssTableName", DbType.String, ssENColumnSettings.ssTableName);
insertSqlCmd.CreateParameter("@ssJSONData", DbType.Binary, ssENColumnSettings.ssJSONData);
if ((ssENColumnSettings.ssUserId=="")) {
insertSqlCmd.CreateParameter("@ssUserId", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssUserId", DbType.String, ssENColumnSettings.ssUserId);

}
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateColumnSettings", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateColumnSettings
/// </summary>

public static async Task<long> CreateOrUpdateColumnSettings(IRequestContext requestContext,BitArray usedFields,RC_25c6d4ad26c50e9400baa0d709166594 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateColumnSettings", "124674ba-816d-447f-93e6-154044294e15.#CreateOrUpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateColumnSettings", "124674ba-816d-447f-93e6-154044294e15.#CreateOrUpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_b8682919578ddd4d17f9eb185aad3c49EntityRecord ssENColumnSettings = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(4,true);
}
string updateSet = "UPDATE " + ENColumnSettingsEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ColumnSettings, _EntityKeyConstants._ConectaProveedoresEntityKeys._ColumnSettingsAttributeKeys.@TableName, "tablename") ?? "tablename") + " = @ssTableName"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ColumnSettings, _EntityKeyConstants._ConectaProveedoresEntityKeys._ColumnSettingsAttributeKeys.@JSONData, "jsondata") ?? "jsondata") + " = @ssJSONData"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ColumnSettings, _EntityKeyConstants._ConectaProveedoresEntityKeys._ColumnSettingsAttributeKeys.@UserId, "userid") ?? "userid") + " = @ssUserId"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ColumnSettings, _EntityKeyConstants._ConectaProveedoresEntityKeys._ColumnSettingsAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENColumnSettings_ssId_ColumnSettings";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ColumnSettings, _EntityKeyConstants._ConectaProveedoresEntityKeys._ColumnSettingsAttributeKeys.@UserId, "userid") ?? "userid") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ColumnSettings, _EntityKeyConstants._ConectaProveedoresEntityKeys._ColumnSettingsAttributeKeys.@UserId, "userid") ?? "userid") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssTableName", DbType.String, ssENColumnSettings.ssTableName);
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssJSONData", DbType.Binary, ssENColumnSettings.ssJSONData);
}
if(usedFields[3]) {
if ((ssENColumnSettings.ssUserId=="")) {
sqlCmd.CreateParameter("@ssUserId", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssUserId", DbType.String, ssENColumnSettings.ssUserId);

}
}
sqlCmd.CreateParameter("@idparam_ssENColumnSettings_ssId_ColumnSettings", DbType.Int64, ssENColumnSettings.ssId);
int counter = 0;
if(ssENColumnSettings.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateColumnSettings (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENColumnSettingsEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ColumnSettings, _EntityKeyConstants._ConectaProveedoresEntityKeys._ColumnSettingsAttributeKeys.@TableName, "tablename") ?? "tablename") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ColumnSettings, _EntityKeyConstants._ConectaProveedoresEntityKeys._ColumnSettingsAttributeKeys.@JSONData, "jsondata") ?? "jsondata") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ColumnSettings, _EntityKeyConstants._ConectaProveedoresEntityKeys._ColumnSettingsAttributeKeys.@UserId, "userid") ?? "userid") + "" +
" ) VALUES (" +
" @ssTableName" +
", @ssJSONData" +
", @ssUserId" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssTableName", DbType.String, ssENColumnSettings.ssTableName);
insertSqlCmd.CreateParameter("@ssJSONData", DbType.Binary, ssENColumnSettings.ssJSONData);
if ((ssENColumnSettings.ssUserId=="")) {
insertSqlCmd.CreateParameter("@ssUserId", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssUserId", DbType.String, ssENColumnSettings.ssUserId);

}
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateColumnSettings", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENColumnSettings.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeColumnSettings
/// </summary>

public static async Task CreateOrUpdateSomeColumnSettings(IRequestContext requestContext,RL_12d8bb3d9ae5ae3d570d3e14f2e9595e inParamSourceList,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateSomeColumnSettings", "124674ba-816d-447f-93e6-154044294e15.#CreateOrUpdateAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeColumnSettings", "124674ba-816d-447f-93e6-154044294e15.#CreateOrUpdateAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
string entityTableName = ENColumnSettingsEntity.LocalViewName(null);
string insertSql = "INSERT INTO " + entityTableName + " (" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ColumnSettings, _EntityKeyConstants._ConectaProveedoresEntityKeys._ColumnSettingsAttributeKeys.@TableName, "tablename") ?? "tablename") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ColumnSettings, _EntityKeyConstants._ConectaProveedoresEntityKeys._ColumnSettingsAttributeKeys.@JSONData, "jsondata") ?? "jsondata") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ColumnSettings, _EntityKeyConstants._ConectaProveedoresEntityKeys._ColumnSettingsAttributeKeys.@UserId, "userid") ?? "userid") + ") VALUES ( unnest(@ssTableName),  unnest(@ssJSONData),  unnest(@ssUserId)) ";
insertSql += "";

string updateSql = "UPDATE " + entityTableName + " SET " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ColumnSettings, _EntityKeyConstants._ConectaProveedoresEntityKeys._ColumnSettingsAttributeKeys.@TableName, "tablename") ?? "tablename") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ColumnSettings, _EntityKeyConstants._ConectaProveedoresEntityKeys._ColumnSettingsAttributeKeys.@TableName, "tablename") ?? "tablename") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ColumnSettings, _EntityKeyConstants._ConectaProveedoresEntityKeys._ColumnSettingsAttributeKeys.@JSONData, "jsondata") ?? "jsondata") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ColumnSettings, _EntityKeyConstants._ConectaProveedoresEntityKeys._ColumnSettingsAttributeKeys.@JSONData, "jsondata") ?? "jsondata") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ColumnSettings, _EntityKeyConstants._ConectaProveedoresEntityKeys._ColumnSettingsAttributeKeys.@UserId, "userid") ?? "userid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ColumnSettings, _EntityKeyConstants._ConectaProveedoresEntityKeys._ColumnSettingsAttributeKeys.@UserId, "userid") ?? "userid") + " from ( select  unnest(@ssId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ColumnSettings, _EntityKeyConstants._ConectaProveedoresEntityKeys._ColumnSettingsAttributeKeys.@Id, "id") ?? "id") + ",  unnest(@ssTableName) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ColumnSettings, _EntityKeyConstants._ConectaProveedoresEntityKeys._ColumnSettingsAttributeKeys.@TableName, "tablename") ?? "tablename") + ",  unnest(@ssJSONData) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ColumnSettings, _EntityKeyConstants._ConectaProveedoresEntityKeys._ColumnSettingsAttributeKeys.@JSONData, "jsondata") ?? "jsondata") + ",  unnest(@ssUserId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ColumnSettings, _EntityKeyConstants._ConectaProveedoresEntityKeys._ColumnSettingsAttributeKeys.@UserId, "userid") ?? "userid") + " ) as updateTable where " + entityTableName + "." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ColumnSettings, _EntityKeyConstants._ConectaProveedoresEntityKeys._ColumnSettingsAttributeKeys.@Id, "id") ?? "id") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ColumnSettings, _EntityKeyConstants._ConectaProveedoresEntityKeys._ColumnSettingsAttributeKeys.@Id, "id") ?? "id") + " ";
updateSql += "";

List<string> insertTableNameList = new List<string>();
List<byte[]> insertJSONDataList = new List<byte[]>();
List<object> insertUserIdList = new List<object>();

List<long> updateIdList = new List<long>();
List<string> updateTableNameList = new List<string>();
List<byte[]> updateJSONDataList = new List<byte[]>();
List<object> updateUserIdList = new List<object>();

var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_25c6d4ad26c50e9400baa0d709166594)inParamSourceList.Current).ssENColumnSettings;
if (record.ssId != 0L) {
updateIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
updateTableNameList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssTableName));
updateJSONDataList.Add((byte[])executionService.TransformRuntimeToDatabaseValue(DbType.Binary, record.ssJSONData));
if ((record.ssUserId=="")) {
updateUserIdList.Add(null);
} else {
updateUserIdList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssUserId));
}
} else {
insertTableNameList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssTableName));
insertJSONDataList.Add((byte[])executionService.TransformRuntimeToDatabaseValue(DbType.Binary, record.ssJSONData));
if ((record.ssUserId=="")) {
insertUserIdList.Add(null);
} else {
insertUserIdList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssUserId));
}
}
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertTableNameList.IsEmpty() || !insertJSONDataList.IsEmpty() || !insertUserIdList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssTableName",DbType.String,insertTableNameList);
executionService.CreateParameter(insertSqlCmd,"@ssJSONData",DbType.Binary,insertJSONDataList);
executionService.CreateParameter(insertSqlCmd,"@ssUserId",DbType.String,insertUserIdList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeColumnSettings (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
if(!updateTableNameList.IsEmpty() || !updateJSONDataList.IsEmpty() || !updateUserIdList.IsEmpty()){
await using(var updateSqlCmd = trans.CreateCommand(updateSql)){
executionService.CreateParameter(updateSqlCmd,"@ssId",DbType.Int64,updateIdList);
executionService.CreateParameter(updateSqlCmd,"@ssTableName",DbType.String,updateTableNameList);
executionService.CreateParameter(updateSqlCmd,"@ssJSONData",DbType.Binary,updateJSONDataList);
executionService.CreateParameter(updateSqlCmd,"@ssUserId",DbType.String,updateUserIdList);
await updateSqlCmd.PrepareAsync(cancellationToken);
await updateSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeColumnSettings (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(updateSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteColumnSettings
/// </summary>

public static async Task DeleteColumnSettings(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteColumnSettings", "124674ba-816d-447f-93e6-154044294e15.#DeleteEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteColumnSettings", "124674ba-816d-447f-93e6-154044294e15.#DeleteEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENColumnSettingsEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ColumnSettings, _EntityKeyConstants._ConectaProveedoresEntityKeys._ColumnSettingsAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteColumnSettings", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllColumnSettings
/// </summary>

public static async Task DeleteAllColumnSettings(IRequestContext requestContext,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteAllColumnSettings", "124674ba-816d-447f-93e6-154044294e15.#DeleteAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllColumnSettings", "124674ba-816d-447f-93e6-154044294e15.#DeleteAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENColumnSettingsEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteColumnSettings", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetColumnSettings
/// </summary>

public static async Task<RC_25c6d4ad26c50e9400baa0d709166594> GetColumnSettings(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_25c6d4ad26c50e9400baa0d709166594 outParamRecord = default;
outParamRecord = new RC_25c6d4ad26c50e9400baa0d709166594();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetColumnSettings", "124674ba-816d-447f-93e6-154044294e15.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetColumnSettings", "124674ba-816d-447f-93e6-154044294e15.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ColumnSettings, _EntityKeyConstants._ConectaProveedoresEntityKeys._ColumnSettingsAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ColumnSettings, _EntityKeyConstants._ConectaProveedoresEntityKeys._ColumnSettingsAttributeKeys.@TableName, "tablename") ?? "tablename", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ColumnSettings, _EntityKeyConstants._ConectaProveedoresEntityKeys._ColumnSettingsAttributeKeys.@JSONData, "jsondata") ?? "jsondata", OutSystems.HubEdition.Extensibility.Data.DBDataType.BINARY_DATA) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ColumnSettings, _EntityKeyConstants._ConectaProveedoresEntityKeys._ColumnSettingsAttributeKeys.@UserId, "userid") ?? "userid", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
" FROM " + ENColumnSettingsEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ColumnSettings, _EntityKeyConstants._ConectaProveedoresEntityKeys._ColumnSettingsAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetColumnSettings", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(4,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENColumnSettingsEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetColumnSettingsForUpdate
/// </summary>

public static async Task<RC_25c6d4ad26c50e9400baa0d709166594> GetColumnSettingsForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_25c6d4ad26c50e9400baa0d709166594 outParamRecord = default;
outParamRecord = new RC_25c6d4ad26c50e9400baa0d709166594();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetColumnSettingsForUpdate", "124674ba-816d-447f-93e6-154044294e15.#GetEntityForUpdate");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetColumnSettingsForUpdate", "124674ba-816d-447f-93e6-154044294e15.#GetEntityForUpdate", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ColumnSettings, _EntityKeyConstants._ConectaProveedoresEntityKeys._ColumnSettingsAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ColumnSettings, _EntityKeyConstants._ConectaProveedoresEntityKeys._ColumnSettingsAttributeKeys.@TableName, "tablename") ?? "tablename", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ColumnSettings, _EntityKeyConstants._ConectaProveedoresEntityKeys._ColumnSettingsAttributeKeys.@JSONData, "jsondata") ?? "jsondata", OutSystems.HubEdition.Extensibility.Data.DBDataType.BINARY_DATA) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ColumnSettings, _EntityKeyConstants._ConectaProveedoresEntityKeys._ColumnSettingsAttributeKeys.@UserId, "userid") ?? "userid", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
" FROM " + ENColumnSettingsEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ColumnSettings, _EntityKeyConstants._ConectaProveedoresEntityKeys._ColumnSettingsAttributeKeys.@Id, "id") ?? "id") + " = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetColumnSettingsForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(4,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENColumnSettingsEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateColumnSettings
/// </summary>

public static async Task UpdateColumnSettings(IRequestContext requestContext,BitArray usedFields,RC_25c6d4ad26c50e9400baa0d709166594 inParamSource,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("UpdateColumnSettings", "124674ba-816d-447f-93e6-154044294e15.#UpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateColumnSettings", "124674ba-816d-447f-93e6-154044294e15.#UpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_b8682919578ddd4d17f9eb185aad3c49EntityRecord ssENColumnSettings = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(4,true);
}
string updateSet = "UPDATE " + ENColumnSettingsEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ColumnSettings, _EntityKeyConstants._ConectaProveedoresEntityKeys._ColumnSettingsAttributeKeys.@TableName, "tablename") ?? "tablename") + " = @ssTableName"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ColumnSettings, _EntityKeyConstants._ConectaProveedoresEntityKeys._ColumnSettingsAttributeKeys.@JSONData, "jsondata") ?? "jsondata") + " = @ssJSONData"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ColumnSettings, _EntityKeyConstants._ConectaProveedoresEntityKeys._ColumnSettingsAttributeKeys.@UserId, "userid") ?? "userid") + " = @ssUserId"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ColumnSettings, _EntityKeyConstants._ConectaProveedoresEntityKeys._ColumnSettingsAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENColumnSettings_ssId_ColumnSettings";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ColumnSettings, _EntityKeyConstants._ConectaProveedoresEntityKeys._ColumnSettingsAttributeKeys.@UserId, "userid") ?? "userid") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ColumnSettings, _EntityKeyConstants._ConectaProveedoresEntityKeys._ColumnSettingsAttributeKeys.@UserId, "userid") ?? "userid") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssTableName", DbType.String, ssENColumnSettings.ssTableName);
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssJSONData", DbType.Binary, ssENColumnSettings.ssJSONData);
}
if(usedFields[3]) {
if ((ssENColumnSettings.ssUserId=="")) {
sqlCmd.CreateParameter("@ssUserId", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssUserId", DbType.String, ssENColumnSettings.ssUserId);

}
}
sqlCmd.CreateParameter("@idparam_ssENColumnSettings_ssId_ColumnSettings", DbType.Int64, ssENColumnSettings.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateColumnSettings", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("ColumnSettings", ssENColumnSettings.ssId.ToString()); }}
}
return;
}

}
}
