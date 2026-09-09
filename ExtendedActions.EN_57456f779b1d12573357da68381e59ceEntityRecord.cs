using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateFileImportLog
/// </summary>

public static async Task<long> CreateFileImportLog(IRequestContext requestContext,RC_1d614602032ba1d6426327cab15c1a37 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateFileImportLog", "8f4b4d86-bdc6-422a-af0f-2cd883b8851c.#CreateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateFileImportLog", "8f4b4d86-bdc6-422a-af0f-2cd883b8851c.#CreateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_57456f779b1d12573357da68381e59ceEntityRecord ssENFileImportLog = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENFileImportLogEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileImportLog, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileImportLogAttributeKeys.@FileId, "fileid") ?? "fileid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileImportLog, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileImportLogAttributeKeys.@Timestamp, "timestamp") ?? "timestamp") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileImportLog, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileImportLogAttributeKeys.@ImportType, "importtype") ?? "importtype") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileImportLog, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileImportLogAttributeKeys.@ImportedBy, "importedby") ?? "importedby") + "" +
" ) VALUES (" +
" @ssFileId" +
", @ssTimestamp" +
", @ssImportType" +
", @ssImportedBy" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENFileImportLog.ssFileId==0L)) {
insertSqlCmd.CreateParameter("@ssFileId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssFileId", DbType.Int64, ssENFileImportLog.ssFileId);

}
insertSqlCmd.CreateParameter("@ssTimestamp", DbType.DateTime, ssENFileImportLog.ssTimestamp);
insertSqlCmd.CreateParameter("@ssImportType", DbType.String, ssENFileImportLog.ssImportType);
if ((ssENFileImportLog.ssImportedBy=="")) {
insertSqlCmd.CreateParameter("@ssImportedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssImportedBy", DbType.String, ssENFileImportLog.ssImportedBy);

}
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateFileImportLog", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateFileImportLog
/// </summary>

public static async Task<long> CreateOrUpdateFileImportLog(IRequestContext requestContext,BitArray usedFields,RC_1d614602032ba1d6426327cab15c1a37 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateFileImportLog", "8f4b4d86-bdc6-422a-af0f-2cd883b8851c.#CreateOrUpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateFileImportLog", "8f4b4d86-bdc6-422a-af0f-2cd883b8851c.#CreateOrUpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_57456f779b1d12573357da68381e59ceEntityRecord ssENFileImportLog = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(5,true);
}
string updateSet = "UPDATE " + ENFileImportLogEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileImportLog, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileImportLogAttributeKeys.@FileId, "fileid") ?? "fileid") + " = @ssFileId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileImportLog, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileImportLogAttributeKeys.@Timestamp, "timestamp") ?? "timestamp") + " = @ssTimestamp"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileImportLog, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileImportLogAttributeKeys.@ImportType, "importtype") ?? "importtype") + " = @ssImportType"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileImportLog, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileImportLogAttributeKeys.@ImportedBy, "importedby") ?? "importedby") + " = @ssImportedBy"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileImportLog, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileImportLogAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENFileImportLog_ssId_FileImportLog";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileImportLog, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileImportLogAttributeKeys.@Timestamp, "timestamp") ?? "timestamp") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileImportLog, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileImportLogAttributeKeys.@Timestamp, "timestamp") ?? "timestamp") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENFileImportLog.ssFileId==0L)) {
sqlCmd.CreateParameter("@ssFileId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssFileId", DbType.Int64, ssENFileImportLog.ssFileId);

}
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssTimestamp", DbType.DateTime, ssENFileImportLog.ssTimestamp);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssImportType", DbType.String, ssENFileImportLog.ssImportType);
}
if(usedFields[4]) {
if ((ssENFileImportLog.ssImportedBy=="")) {
sqlCmd.CreateParameter("@ssImportedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssImportedBy", DbType.String, ssENFileImportLog.ssImportedBy);

}
}
sqlCmd.CreateParameter("@idparam_ssENFileImportLog_ssId_FileImportLog", DbType.Int64, ssENFileImportLog.ssId);
int counter = 0;
if(ssENFileImportLog.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateFileImportLog (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENFileImportLogEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileImportLog, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileImportLogAttributeKeys.@FileId, "fileid") ?? "fileid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileImportLog, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileImportLogAttributeKeys.@Timestamp, "timestamp") ?? "timestamp") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileImportLog, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileImportLogAttributeKeys.@ImportType, "importtype") ?? "importtype") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileImportLog, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileImportLogAttributeKeys.@ImportedBy, "importedby") ?? "importedby") + "" +
" ) VALUES (" +
" @ssFileId" +
", @ssTimestamp" +
", @ssImportType" +
", @ssImportedBy" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENFileImportLog.ssFileId==0L)) {
insertSqlCmd.CreateParameter("@ssFileId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssFileId", DbType.Int64, ssENFileImportLog.ssFileId);

}
insertSqlCmd.CreateParameter("@ssTimestamp", DbType.DateTime, ssENFileImportLog.ssTimestamp);
insertSqlCmd.CreateParameter("@ssImportType", DbType.String, ssENFileImportLog.ssImportType);
if ((ssENFileImportLog.ssImportedBy=="")) {
insertSqlCmd.CreateParameter("@ssImportedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssImportedBy", DbType.String, ssENFileImportLog.ssImportedBy);

}
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateFileImportLog", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENFileImportLog.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeFileImportLog
/// </summary>

public static async Task CreateOrUpdateSomeFileImportLog(IRequestContext requestContext,RL_0101cfa484875f3eb391d3382eef891a inParamSourceList,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateSomeFileImportLog", "8f4b4d86-bdc6-422a-af0f-2cd883b8851c.#CreateOrUpdateAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeFileImportLog", "8f4b4d86-bdc6-422a-af0f-2cd883b8851c.#CreateOrUpdateAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
string entityTableName = ENFileImportLogEntity.LocalViewName(null);
string insertSql = "INSERT INTO " + entityTableName + " (" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileImportLog, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileImportLogAttributeKeys.@FileId, "fileid") ?? "fileid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileImportLog, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileImportLogAttributeKeys.@Timestamp, "timestamp") ?? "timestamp") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileImportLog, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileImportLogAttributeKeys.@ImportType, "importtype") ?? "importtype") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileImportLog, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileImportLogAttributeKeys.@ImportedBy, "importedby") ?? "importedby") + ") VALUES ( unnest(@ssFileId),  unnest(@ssTimestamp),  unnest(@ssImportType),  unnest(@ssImportedBy)) ";
insertSql += "";

string updateSql = "UPDATE " + entityTableName + " SET " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileImportLog, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileImportLogAttributeKeys.@FileId, "fileid") ?? "fileid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileImportLog, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileImportLogAttributeKeys.@FileId, "fileid") ?? "fileid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileImportLog, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileImportLogAttributeKeys.@Timestamp, "timestamp") ?? "timestamp") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileImportLog, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileImportLogAttributeKeys.@Timestamp, "timestamp") ?? "timestamp") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileImportLog, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileImportLogAttributeKeys.@ImportType, "importtype") ?? "importtype") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileImportLog, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileImportLogAttributeKeys.@ImportType, "importtype") ?? "importtype") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileImportLog, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileImportLogAttributeKeys.@ImportedBy, "importedby") ?? "importedby") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileImportLog, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileImportLogAttributeKeys.@ImportedBy, "importedby") ?? "importedby") + " from ( select  unnest(@ssId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileImportLog, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileImportLogAttributeKeys.@Id, "id") ?? "id") + ",  unnest(@ssFileId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileImportLog, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileImportLogAttributeKeys.@FileId, "fileid") ?? "fileid") + ",  unnest(@ssTimestamp) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileImportLog, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileImportLogAttributeKeys.@Timestamp, "timestamp") ?? "timestamp") + ",  unnest(@ssImportType) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileImportLog, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileImportLogAttributeKeys.@ImportType, "importtype") ?? "importtype") + ",  unnest(@ssImportedBy) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileImportLog, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileImportLogAttributeKeys.@ImportedBy, "importedby") ?? "importedby") + " ) as updateTable where " + entityTableName + "." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileImportLog, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileImportLogAttributeKeys.@Id, "id") ?? "id") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileImportLog, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileImportLogAttributeKeys.@Id, "id") ?? "id") + " ";
updateSql += "";

List<object> insertFileIdList = new List<object>();
List<DateTime> insertTimestampList = new List<DateTime>();
List<string> insertImportTypeList = new List<string>();
List<object> insertImportedByList = new List<object>();

List<long> updateIdList = new List<long>();
List<object> updateFileIdList = new List<object>();
List<DateTime> updateTimestampList = new List<DateTime>();
List<string> updateImportTypeList = new List<string>();
List<object> updateImportedByList = new List<object>();

var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_1d614602032ba1d6426327cab15c1a37)inParamSourceList.Current).ssENFileImportLog;
if (record.ssId != 0L) {
updateIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
if ((record.ssFileId==0L)) {
updateFileIdList.Add(null);
} else {
updateFileIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssFileId));
}
updateTimestampList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssTimestamp));
updateImportTypeList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssImportType));
if ((record.ssImportedBy=="")) {
updateImportedByList.Add(null);
} else {
updateImportedByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssImportedBy));
}
} else {
if ((record.ssFileId==0L)) {
insertFileIdList.Add(null);
} else {
insertFileIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssFileId));
}
insertTimestampList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssTimestamp));
insertImportTypeList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssImportType));
if ((record.ssImportedBy=="")) {
insertImportedByList.Add(null);
} else {
insertImportedByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssImportedBy));
}
}
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertFileIdList.IsEmpty() || !insertTimestampList.IsEmpty() || !insertImportTypeList.IsEmpty() || !insertImportedByList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssFileId",DbType.Int64,insertFileIdList);
executionService.CreateParameter(insertSqlCmd,"@ssTimestamp",DbType.DateTime,insertTimestampList);
executionService.CreateParameter(insertSqlCmd,"@ssImportType",DbType.String,insertImportTypeList);
executionService.CreateParameter(insertSqlCmd,"@ssImportedBy",DbType.String,insertImportedByList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeFileImportLog (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
if(!updateFileIdList.IsEmpty() || !updateTimestampList.IsEmpty() || !updateImportTypeList.IsEmpty() || !updateImportedByList.IsEmpty()){
await using(var updateSqlCmd = trans.CreateCommand(updateSql)){
executionService.CreateParameter(updateSqlCmd,"@ssId",DbType.Int64,updateIdList);
executionService.CreateParameter(updateSqlCmd,"@ssFileId",DbType.Int64,updateFileIdList);
executionService.CreateParameter(updateSqlCmd,"@ssTimestamp",DbType.DateTime,updateTimestampList);
executionService.CreateParameter(updateSqlCmd,"@ssImportType",DbType.String,updateImportTypeList);
executionService.CreateParameter(updateSqlCmd,"@ssImportedBy",DbType.String,updateImportedByList);
await updateSqlCmd.PrepareAsync(cancellationToken);
await updateSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeFileImportLog (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(updateSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteFileImportLog
/// </summary>

public static async Task DeleteFileImportLog(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteFileImportLog", "8f4b4d86-bdc6-422a-af0f-2cd883b8851c.#DeleteEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteFileImportLog", "8f4b4d86-bdc6-422a-af0f-2cd883b8851c.#DeleteEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENFileImportLogEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileImportLog, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileImportLogAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteFileImportLog", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllFileImportLog
/// </summary>

public static async Task DeleteAllFileImportLog(IRequestContext requestContext,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteAllFileImportLog", "8f4b4d86-bdc6-422a-af0f-2cd883b8851c.#DeleteAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllFileImportLog", "8f4b4d86-bdc6-422a-af0f-2cd883b8851c.#DeleteAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENFileImportLogEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteFileImportLog", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetFileImportLog
/// </summary>

public static async Task<RC_1d614602032ba1d6426327cab15c1a37> GetFileImportLog(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_1d614602032ba1d6426327cab15c1a37 outParamRecord = default;
outParamRecord = new RC_1d614602032ba1d6426327cab15c1a37();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetFileImportLog", "8f4b4d86-bdc6-422a-af0f-2cd883b8851c.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetFileImportLog", "8f4b4d86-bdc6-422a-af0f-2cd883b8851c.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileImportLog, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileImportLogAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileImportLog, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileImportLogAttributeKeys.@FileId, "fileid") ?? "fileid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileImportLog, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileImportLogAttributeKeys.@Timestamp, "timestamp") ?? "timestamp", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileImportLog, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileImportLogAttributeKeys.@ImportType, "importtype") ?? "importtype", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileImportLog, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileImportLogAttributeKeys.@ImportedBy, "importedby") ?? "importedby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
" FROM " + ENFileImportLogEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileImportLog, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileImportLogAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetFileImportLog", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(5,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENFileImportLogEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetFileImportLogForUpdate
/// </summary>

public static async Task<RC_1d614602032ba1d6426327cab15c1a37> GetFileImportLogForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_1d614602032ba1d6426327cab15c1a37 outParamRecord = default;
outParamRecord = new RC_1d614602032ba1d6426327cab15c1a37();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetFileImportLogForUpdate", "8f4b4d86-bdc6-422a-af0f-2cd883b8851c.#GetEntityForUpdate");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetFileImportLogForUpdate", "8f4b4d86-bdc6-422a-af0f-2cd883b8851c.#GetEntityForUpdate", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileImportLog, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileImportLogAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileImportLog, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileImportLogAttributeKeys.@FileId, "fileid") ?? "fileid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileImportLog, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileImportLogAttributeKeys.@Timestamp, "timestamp") ?? "timestamp", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileImportLog, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileImportLogAttributeKeys.@ImportType, "importtype") ?? "importtype", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileImportLog, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileImportLogAttributeKeys.@ImportedBy, "importedby") ?? "importedby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
" FROM " + ENFileImportLogEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileImportLog, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileImportLogAttributeKeys.@Id, "id") ?? "id") + " = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetFileImportLogForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(5,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENFileImportLogEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateFileImportLog
/// </summary>

public static async Task UpdateFileImportLog(IRequestContext requestContext,BitArray usedFields,RC_1d614602032ba1d6426327cab15c1a37 inParamSource,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("UpdateFileImportLog", "8f4b4d86-bdc6-422a-af0f-2cd883b8851c.#UpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateFileImportLog", "8f4b4d86-bdc6-422a-af0f-2cd883b8851c.#UpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_57456f779b1d12573357da68381e59ceEntityRecord ssENFileImportLog = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(5,true);
}
string updateSet = "UPDATE " + ENFileImportLogEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileImportLog, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileImportLogAttributeKeys.@FileId, "fileid") ?? "fileid") + " = @ssFileId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileImportLog, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileImportLogAttributeKeys.@Timestamp, "timestamp") ?? "timestamp") + " = @ssTimestamp"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileImportLog, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileImportLogAttributeKeys.@ImportType, "importtype") ?? "importtype") + " = @ssImportType"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileImportLog, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileImportLogAttributeKeys.@ImportedBy, "importedby") ?? "importedby") + " = @ssImportedBy"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileImportLog, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileImportLogAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENFileImportLog_ssId_FileImportLog";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileImportLog, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileImportLogAttributeKeys.@Timestamp, "timestamp") ?? "timestamp") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileImportLog, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileImportLogAttributeKeys.@Timestamp, "timestamp") ?? "timestamp") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENFileImportLog.ssFileId==0L)) {
sqlCmd.CreateParameter("@ssFileId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssFileId", DbType.Int64, ssENFileImportLog.ssFileId);

}
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssTimestamp", DbType.DateTime, ssENFileImportLog.ssTimestamp);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssImportType", DbType.String, ssENFileImportLog.ssImportType);
}
if(usedFields[4]) {
if ((ssENFileImportLog.ssImportedBy=="")) {
sqlCmd.CreateParameter("@ssImportedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssImportedBy", DbType.String, ssENFileImportLog.ssImportedBy);

}
}
sqlCmd.CreateParameter("@idparam_ssENFileImportLog_ssId_FileImportLog", DbType.Int64, ssENFileImportLog.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateFileImportLog", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("FileImportLog", ssENFileImportLog.ssId.ToString()); }}
}
return;
}

}
}
