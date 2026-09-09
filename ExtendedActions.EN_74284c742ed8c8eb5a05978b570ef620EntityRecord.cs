using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateRequisitionVersion
/// </summary>

public static async Task<long> CreateRequisitionVersion(IRequestContext requestContext,RC_47cc380fa539ce90830b02515458ecd2 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateRequisitionVersion", "86fa8668-36d1-4cc9-93c4-aeaf2e2bf72b.#CreateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateRequisitionVersion", "86fa8668-36d1-4cc9-93c4-aeaf2e2bf72b.#CreateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_74284c742ed8c8eb5a05978b570ef620EntityRecord ssENRequisitionVersion = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENRequisitionVersionEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionVersion, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionVersionAttributeKeys.@OriginalRequisitionId, "originalrequisitionid") ?? "originalrequisitionid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionVersion, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionVersionAttributeKeys.@NewRequisitionId, "newrequisitionid") ?? "newrequisitionid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionVersion, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionVersionAttributeKeys.@Version, "version") ?? "version") + "" +
" ) VALUES (" +
" @ssOriginalRequisitionId" +
", @ssNewRequisitionId" +
", @ssVersion" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENRequisitionVersion.ssOriginalRequisitionId==0L)) {
insertSqlCmd.CreateParameter("@ssOriginalRequisitionId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssOriginalRequisitionId", DbType.Int64, ssENRequisitionVersion.ssOriginalRequisitionId);

}
if ((ssENRequisitionVersion.ssNewRequisitionId==0L)) {
insertSqlCmd.CreateParameter("@ssNewRequisitionId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssNewRequisitionId", DbType.Int64, ssENRequisitionVersion.ssNewRequisitionId);

}
insertSqlCmd.CreateParameter("@ssVersion", DbType.Int32, ssENRequisitionVersion.ssVersion);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateRequisitionVersion", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateRequisitionVersion
/// </summary>

public static async Task<long> CreateOrUpdateRequisitionVersion(IRequestContext requestContext,BitArray usedFields,RC_47cc380fa539ce90830b02515458ecd2 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateRequisitionVersion", "86fa8668-36d1-4cc9-93c4-aeaf2e2bf72b.#CreateOrUpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateRequisitionVersion", "86fa8668-36d1-4cc9-93c4-aeaf2e2bf72b.#CreateOrUpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_74284c742ed8c8eb5a05978b570ef620EntityRecord ssENRequisitionVersion = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(4,true);
}
string updateSet = "UPDATE " + ENRequisitionVersionEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionVersion, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionVersionAttributeKeys.@OriginalRequisitionId, "originalrequisitionid") ?? "originalrequisitionid") + " = @ssOriginalRequisitionId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionVersion, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionVersionAttributeKeys.@NewRequisitionId, "newrequisitionid") ?? "newrequisitionid") + " = @ssNewRequisitionId"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionVersion, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionVersionAttributeKeys.@Version, "version") ?? "version") + " = @ssVersion"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionVersion, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionVersionAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENRequisitionVersion_ssId_RequisitionVersion";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionVersion, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionVersionAttributeKeys.@Version, "version") ?? "version") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionVersion, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionVersionAttributeKeys.@Version, "version") ?? "version") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENRequisitionVersion.ssOriginalRequisitionId==0L)) {
sqlCmd.CreateParameter("@ssOriginalRequisitionId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssOriginalRequisitionId", DbType.Int64, ssENRequisitionVersion.ssOriginalRequisitionId);

}
}
if(usedFields[2]) {
if ((ssENRequisitionVersion.ssNewRequisitionId==0L)) {
sqlCmd.CreateParameter("@ssNewRequisitionId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssNewRequisitionId", DbType.Int64, ssENRequisitionVersion.ssNewRequisitionId);

}
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssVersion", DbType.Int32, ssENRequisitionVersion.ssVersion);
}
sqlCmd.CreateParameter("@idparam_ssENRequisitionVersion_ssId_RequisitionVersion", DbType.Int64, ssENRequisitionVersion.ssId);
int counter = 0;
if(ssENRequisitionVersion.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateRequisitionVersion (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENRequisitionVersionEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionVersion, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionVersionAttributeKeys.@OriginalRequisitionId, "originalrequisitionid") ?? "originalrequisitionid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionVersion, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionVersionAttributeKeys.@NewRequisitionId, "newrequisitionid") ?? "newrequisitionid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionVersion, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionVersionAttributeKeys.@Version, "version") ?? "version") + "" +
" ) VALUES (" +
" @ssOriginalRequisitionId" +
", @ssNewRequisitionId" +
", @ssVersion" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENRequisitionVersion.ssOriginalRequisitionId==0L)) {
insertSqlCmd.CreateParameter("@ssOriginalRequisitionId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssOriginalRequisitionId", DbType.Int64, ssENRequisitionVersion.ssOriginalRequisitionId);

}
if ((ssENRequisitionVersion.ssNewRequisitionId==0L)) {
insertSqlCmd.CreateParameter("@ssNewRequisitionId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssNewRequisitionId", DbType.Int64, ssENRequisitionVersion.ssNewRequisitionId);

}
insertSqlCmd.CreateParameter("@ssVersion", DbType.Int32, ssENRequisitionVersion.ssVersion);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateRequisitionVersion", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENRequisitionVersion.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeRequisitionVersion
/// </summary>

public static async Task CreateOrUpdateSomeRequisitionVersion(IRequestContext requestContext,RL_16a3629886d5e012aa547b904dd63379 inParamSourceList,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateSomeRequisitionVersion", "86fa8668-36d1-4cc9-93c4-aeaf2e2bf72b.#CreateOrUpdateAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeRequisitionVersion", "86fa8668-36d1-4cc9-93c4-aeaf2e2bf72b.#CreateOrUpdateAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
string entityTableName = ENRequisitionVersionEntity.LocalViewName(null);
string insertSql = "INSERT INTO " + entityTableName + " (" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionVersion, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionVersionAttributeKeys.@OriginalRequisitionId, "originalrequisitionid") ?? "originalrequisitionid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionVersion, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionVersionAttributeKeys.@NewRequisitionId, "newrequisitionid") ?? "newrequisitionid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionVersion, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionVersionAttributeKeys.@Version, "version") ?? "version") + ") VALUES ( unnest(@ssOriginalRequisitionId),  unnest(@ssNewRequisitionId),  unnest(@ssVersion)) ";
insertSql += "";

string updateSql = "UPDATE " + entityTableName + " SET " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionVersion, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionVersionAttributeKeys.@OriginalRequisitionId, "originalrequisitionid") ?? "originalrequisitionid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionVersion, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionVersionAttributeKeys.@OriginalRequisitionId, "originalrequisitionid") ?? "originalrequisitionid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionVersion, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionVersionAttributeKeys.@NewRequisitionId, "newrequisitionid") ?? "newrequisitionid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionVersion, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionVersionAttributeKeys.@NewRequisitionId, "newrequisitionid") ?? "newrequisitionid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionVersion, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionVersionAttributeKeys.@Version, "version") ?? "version") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionVersion, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionVersionAttributeKeys.@Version, "version") ?? "version") + " from ( select  unnest(@ssId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionVersion, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionVersionAttributeKeys.@Id, "id") ?? "id") + ",  unnest(@ssOriginalRequisitionId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionVersion, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionVersionAttributeKeys.@OriginalRequisitionId, "originalrequisitionid") ?? "originalrequisitionid") + ",  unnest(@ssNewRequisitionId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionVersion, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionVersionAttributeKeys.@NewRequisitionId, "newrequisitionid") ?? "newrequisitionid") + ",  unnest(@ssVersion) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionVersion, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionVersionAttributeKeys.@Version, "version") ?? "version") + " ) as updateTable where " + entityTableName + "." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionVersion, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionVersionAttributeKeys.@Id, "id") ?? "id") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionVersion, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionVersionAttributeKeys.@Id, "id") ?? "id") + " ";
updateSql += "";

List<object> insertOriginalRequisitionIdList = new List<object>();
List<object> insertNewRequisitionIdList = new List<object>();
List<int> insertVersionList = new List<int>();

List<long> updateIdList = new List<long>();
List<object> updateOriginalRequisitionIdList = new List<object>();
List<object> updateNewRequisitionIdList = new List<object>();
List<int> updateVersionList = new List<int>();

var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_47cc380fa539ce90830b02515458ecd2)inParamSourceList.Current).ssENRequisitionVersion;
if (record.ssId != 0L) {
updateIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
if ((record.ssOriginalRequisitionId==0L)) {
updateOriginalRequisitionIdList.Add(null);
} else {
updateOriginalRequisitionIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssOriginalRequisitionId));
}
if ((record.ssNewRequisitionId==0L)) {
updateNewRequisitionIdList.Add(null);
} else {
updateNewRequisitionIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssNewRequisitionId));
}
updateVersionList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssVersion));
} else {
if ((record.ssOriginalRequisitionId==0L)) {
insertOriginalRequisitionIdList.Add(null);
} else {
insertOriginalRequisitionIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssOriginalRequisitionId));
}
if ((record.ssNewRequisitionId==0L)) {
insertNewRequisitionIdList.Add(null);
} else {
insertNewRequisitionIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssNewRequisitionId));
}
insertVersionList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssVersion));
}
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertOriginalRequisitionIdList.IsEmpty() || !insertNewRequisitionIdList.IsEmpty() || !insertVersionList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssOriginalRequisitionId",DbType.Int64,insertOriginalRequisitionIdList);
executionService.CreateParameter(insertSqlCmd,"@ssNewRequisitionId",DbType.Int64,insertNewRequisitionIdList);
executionService.CreateParameter(insertSqlCmd,"@ssVersion",DbType.Int32,insertVersionList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeRequisitionVersion (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
if(!updateOriginalRequisitionIdList.IsEmpty() || !updateNewRequisitionIdList.IsEmpty() || !updateVersionList.IsEmpty()){
await using(var updateSqlCmd = trans.CreateCommand(updateSql)){
executionService.CreateParameter(updateSqlCmd,"@ssId",DbType.Int64,updateIdList);
executionService.CreateParameter(updateSqlCmd,"@ssOriginalRequisitionId",DbType.Int64,updateOriginalRequisitionIdList);
executionService.CreateParameter(updateSqlCmd,"@ssNewRequisitionId",DbType.Int64,updateNewRequisitionIdList);
executionService.CreateParameter(updateSqlCmd,"@ssVersion",DbType.Int32,updateVersionList);
await updateSqlCmd.PrepareAsync(cancellationToken);
await updateSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeRequisitionVersion (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(updateSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteRequisitionVersion
/// </summary>

public static async Task DeleteRequisitionVersion(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteRequisitionVersion", "86fa8668-36d1-4cc9-93c4-aeaf2e2bf72b.#DeleteEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteRequisitionVersion", "86fa8668-36d1-4cc9-93c4-aeaf2e2bf72b.#DeleteEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENRequisitionVersionEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionVersion, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionVersionAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteRequisitionVersion", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllRequisitionVersion
/// </summary>

public static async Task DeleteAllRequisitionVersion(IRequestContext requestContext,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteAllRequisitionVersion", "86fa8668-36d1-4cc9-93c4-aeaf2e2bf72b.#DeleteAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllRequisitionVersion", "86fa8668-36d1-4cc9-93c4-aeaf2e2bf72b.#DeleteAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENRequisitionVersionEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteRequisitionVersion", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetRequisitionVersion
/// </summary>

public static async Task<RC_47cc380fa539ce90830b02515458ecd2> GetRequisitionVersion(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_47cc380fa539ce90830b02515458ecd2 outParamRecord = default;
outParamRecord = new RC_47cc380fa539ce90830b02515458ecd2();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetRequisitionVersion", "86fa8668-36d1-4cc9-93c4-aeaf2e2bf72b.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetRequisitionVersion", "86fa8668-36d1-4cc9-93c4-aeaf2e2bf72b.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionVersion, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionVersionAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionVersion, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionVersionAttributeKeys.@OriginalRequisitionId, "originalrequisitionid") ?? "originalrequisitionid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionVersion, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionVersionAttributeKeys.@NewRequisitionId, "newrequisitionid") ?? "newrequisitionid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionVersion, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionVersionAttributeKeys.@Version, "version") ?? "version", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
" FROM " + ENRequisitionVersionEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionVersion, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionVersionAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetRequisitionVersion", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(4,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENRequisitionVersionEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetRequisitionVersionForUpdate
/// </summary>

public static async Task<RC_47cc380fa539ce90830b02515458ecd2> GetRequisitionVersionForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_47cc380fa539ce90830b02515458ecd2 outParamRecord = default;
outParamRecord = new RC_47cc380fa539ce90830b02515458ecd2();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetRequisitionVersionForUpdate", "86fa8668-36d1-4cc9-93c4-aeaf2e2bf72b.#GetEntityForUpdate");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetRequisitionVersionForUpdate", "86fa8668-36d1-4cc9-93c4-aeaf2e2bf72b.#GetEntityForUpdate", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionVersion, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionVersionAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionVersion, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionVersionAttributeKeys.@OriginalRequisitionId, "originalrequisitionid") ?? "originalrequisitionid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionVersion, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionVersionAttributeKeys.@NewRequisitionId, "newrequisitionid") ?? "newrequisitionid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionVersion, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionVersionAttributeKeys.@Version, "version") ?? "version", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
" FROM " + ENRequisitionVersionEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionVersion, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionVersionAttributeKeys.@Id, "id") ?? "id") + " = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetRequisitionVersionForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(4,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENRequisitionVersionEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateRequisitionVersion
/// </summary>

public static async Task UpdateRequisitionVersion(IRequestContext requestContext,BitArray usedFields,RC_47cc380fa539ce90830b02515458ecd2 inParamSource,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("UpdateRequisitionVersion", "86fa8668-36d1-4cc9-93c4-aeaf2e2bf72b.#UpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateRequisitionVersion", "86fa8668-36d1-4cc9-93c4-aeaf2e2bf72b.#UpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_74284c742ed8c8eb5a05978b570ef620EntityRecord ssENRequisitionVersion = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(4,true);
}
string updateSet = "UPDATE " + ENRequisitionVersionEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionVersion, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionVersionAttributeKeys.@OriginalRequisitionId, "originalrequisitionid") ?? "originalrequisitionid") + " = @ssOriginalRequisitionId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionVersion, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionVersionAttributeKeys.@NewRequisitionId, "newrequisitionid") ?? "newrequisitionid") + " = @ssNewRequisitionId"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionVersion, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionVersionAttributeKeys.@Version, "version") ?? "version") + " = @ssVersion"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionVersion, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionVersionAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENRequisitionVersion_ssId_RequisitionVersion";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionVersion, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionVersionAttributeKeys.@Version, "version") ?? "version") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionVersion, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionVersionAttributeKeys.@Version, "version") ?? "version") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENRequisitionVersion.ssOriginalRequisitionId==0L)) {
sqlCmd.CreateParameter("@ssOriginalRequisitionId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssOriginalRequisitionId", DbType.Int64, ssENRequisitionVersion.ssOriginalRequisitionId);

}
}
if(usedFields[2]) {
if ((ssENRequisitionVersion.ssNewRequisitionId==0L)) {
sqlCmd.CreateParameter("@ssNewRequisitionId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssNewRequisitionId", DbType.Int64, ssENRequisitionVersion.ssNewRequisitionId);

}
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssVersion", DbType.Int32, ssENRequisitionVersion.ssVersion);
}
sqlCmd.CreateParameter("@idparam_ssENRequisitionVersion_ssId_RequisitionVersion", DbType.Int64, ssENRequisitionVersion.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateRequisitionVersion", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("RequisitionVersion", ssENRequisitionVersion.ssId.ToString()); }}
}
return;
}

}
}
