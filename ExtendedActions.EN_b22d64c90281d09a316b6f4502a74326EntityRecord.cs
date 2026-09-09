using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateActionTimestamps
/// </summary>

public static async Task<long> CreateActionTimestamps(IRequestContext requestContext,RC_00310a262abd8758c59d6849f2a2be40 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateActionTimestamps", "cfc06667-dda9-4522-84f1-f16b150b59da.#CreateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateActionTimestamps", "cfc06667-dda9-4522-84f1-f16b150b59da.#CreateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_b22d64c90281d09a316b6f4502a74326EntityRecord ssENActionTimestamps = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENActionTimestampsEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ActionTimestamps, _EntityKeyConstants._ConectaProveedoresEntityKeys._ActionTimestampsAttributeKeys.@Description, "description") ?? "description") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ActionTimestamps, _EntityKeyConstants._ConectaProveedoresEntityKeys._ActionTimestampsAttributeKeys.@StartedOn, "startedon") ?? "startedon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ActionTimestamps, _EntityKeyConstants._ConectaProveedoresEntityKeys._ActionTimestampsAttributeKeys.@FinishedOn, "finishedon") ?? "finishedon") + "" +
" ) VALUES (" +
" @ssDescription" +
", @ssStartedOn" +
", @ssFinishedOn" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssDescription", DbType.String, ssENActionTimestamps.ssDescription);
insertSqlCmd.CreateParameter("@ssStartedOn", DbType.DateTime, ssENActionTimestamps.ssStartedOn);
insertSqlCmd.CreateParameter("@ssFinishedOn", DbType.DateTime, ssENActionTimestamps.ssFinishedOn);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateActionTimestamps", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateActionTimestamps
/// </summary>

public static async Task<long> CreateOrUpdateActionTimestamps(IRequestContext requestContext,BitArray usedFields,RC_00310a262abd8758c59d6849f2a2be40 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateActionTimestamps", "cfc06667-dda9-4522-84f1-f16b150b59da.#CreateOrUpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateActionTimestamps", "cfc06667-dda9-4522-84f1-f16b150b59da.#CreateOrUpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_b22d64c90281d09a316b6f4502a74326EntityRecord ssENActionTimestamps = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(4,true);
}
string updateSet = "UPDATE " + ENActionTimestampsEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ActionTimestamps, _EntityKeyConstants._ConectaProveedoresEntityKeys._ActionTimestampsAttributeKeys.@Description, "description") ?? "description") + " = @ssDescription"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ActionTimestamps, _EntityKeyConstants._ConectaProveedoresEntityKeys._ActionTimestampsAttributeKeys.@StartedOn, "startedon") ?? "startedon") + " = @ssStartedOn"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ActionTimestamps, _EntityKeyConstants._ConectaProveedoresEntityKeys._ActionTimestampsAttributeKeys.@FinishedOn, "finishedon") ?? "finishedon") + " = @ssFinishedOn"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ActionTimestamps, _EntityKeyConstants._ConectaProveedoresEntityKeys._ActionTimestampsAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENActionTimestamps_ssId_ActionTimestamps";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ActionTimestamps, _EntityKeyConstants._ConectaProveedoresEntityKeys._ActionTimestampsAttributeKeys.@StartedOn, "startedon") ?? "startedon") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ActionTimestamps, _EntityKeyConstants._ConectaProveedoresEntityKeys._ActionTimestampsAttributeKeys.@StartedOn, "startedon") ?? "startedon") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssDescription", DbType.String, ssENActionTimestamps.ssDescription);
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssStartedOn", DbType.DateTime, ssENActionTimestamps.ssStartedOn);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssFinishedOn", DbType.DateTime, ssENActionTimestamps.ssFinishedOn);
}
sqlCmd.CreateParameter("@idparam_ssENActionTimestamps_ssId_ActionTimestamps", DbType.Int64, ssENActionTimestamps.ssId);
int counter = 0;
if(ssENActionTimestamps.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateActionTimestamps (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENActionTimestampsEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ActionTimestamps, _EntityKeyConstants._ConectaProveedoresEntityKeys._ActionTimestampsAttributeKeys.@Description, "description") ?? "description") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ActionTimestamps, _EntityKeyConstants._ConectaProveedoresEntityKeys._ActionTimestampsAttributeKeys.@StartedOn, "startedon") ?? "startedon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ActionTimestamps, _EntityKeyConstants._ConectaProveedoresEntityKeys._ActionTimestampsAttributeKeys.@FinishedOn, "finishedon") ?? "finishedon") + "" +
" ) VALUES (" +
" @ssDescription" +
", @ssStartedOn" +
", @ssFinishedOn" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssDescription", DbType.String, ssENActionTimestamps.ssDescription);
insertSqlCmd.CreateParameter("@ssStartedOn", DbType.DateTime, ssENActionTimestamps.ssStartedOn);
insertSqlCmd.CreateParameter("@ssFinishedOn", DbType.DateTime, ssENActionTimestamps.ssFinishedOn);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateActionTimestamps", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENActionTimestamps.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeActionTimestamps
/// </summary>

public static async Task CreateOrUpdateSomeActionTimestamps(IRequestContext requestContext,RL_13faa545ce925ae37def82ba33666b71 inParamSourceList,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateSomeActionTimestamps", "cfc06667-dda9-4522-84f1-f16b150b59da.#CreateOrUpdateAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeActionTimestamps", "cfc06667-dda9-4522-84f1-f16b150b59da.#CreateOrUpdateAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
string entityTableName = ENActionTimestampsEntity.LocalViewName(null);
string insertSql = "INSERT INTO " + entityTableName + " (" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ActionTimestamps, _EntityKeyConstants._ConectaProveedoresEntityKeys._ActionTimestampsAttributeKeys.@Description, "description") ?? "description") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ActionTimestamps, _EntityKeyConstants._ConectaProveedoresEntityKeys._ActionTimestampsAttributeKeys.@StartedOn, "startedon") ?? "startedon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ActionTimestamps, _EntityKeyConstants._ConectaProveedoresEntityKeys._ActionTimestampsAttributeKeys.@FinishedOn, "finishedon") ?? "finishedon") + ") VALUES ( unnest(@ssDescription),  unnest(@ssStartedOn),  unnest(@ssFinishedOn)) ";
insertSql += "";

string updateSql = "UPDATE " + entityTableName + " SET " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ActionTimestamps, _EntityKeyConstants._ConectaProveedoresEntityKeys._ActionTimestampsAttributeKeys.@Description, "description") ?? "description") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ActionTimestamps, _EntityKeyConstants._ConectaProveedoresEntityKeys._ActionTimestampsAttributeKeys.@Description, "description") ?? "description") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ActionTimestamps, _EntityKeyConstants._ConectaProveedoresEntityKeys._ActionTimestampsAttributeKeys.@StartedOn, "startedon") ?? "startedon") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ActionTimestamps, _EntityKeyConstants._ConectaProveedoresEntityKeys._ActionTimestampsAttributeKeys.@StartedOn, "startedon") ?? "startedon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ActionTimestamps, _EntityKeyConstants._ConectaProveedoresEntityKeys._ActionTimestampsAttributeKeys.@FinishedOn, "finishedon") ?? "finishedon") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ActionTimestamps, _EntityKeyConstants._ConectaProveedoresEntityKeys._ActionTimestampsAttributeKeys.@FinishedOn, "finishedon") ?? "finishedon") + " from ( select  unnest(@ssId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ActionTimestamps, _EntityKeyConstants._ConectaProveedoresEntityKeys._ActionTimestampsAttributeKeys.@Id, "id") ?? "id") + ",  unnest(@ssDescription) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ActionTimestamps, _EntityKeyConstants._ConectaProveedoresEntityKeys._ActionTimestampsAttributeKeys.@Description, "description") ?? "description") + ",  unnest(@ssStartedOn) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ActionTimestamps, _EntityKeyConstants._ConectaProveedoresEntityKeys._ActionTimestampsAttributeKeys.@StartedOn, "startedon") ?? "startedon") + ",  unnest(@ssFinishedOn) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ActionTimestamps, _EntityKeyConstants._ConectaProveedoresEntityKeys._ActionTimestampsAttributeKeys.@FinishedOn, "finishedon") ?? "finishedon") + " ) as updateTable where " + entityTableName + "." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ActionTimestamps, _EntityKeyConstants._ConectaProveedoresEntityKeys._ActionTimestampsAttributeKeys.@Id, "id") ?? "id") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ActionTimestamps, _EntityKeyConstants._ConectaProveedoresEntityKeys._ActionTimestampsAttributeKeys.@Id, "id") ?? "id") + " ";
updateSql += "";

List<string> insertDescriptionList = new List<string>();
List<DateTime> insertStartedOnList = new List<DateTime>();
List<DateTime> insertFinishedOnList = new List<DateTime>();

List<long> updateIdList = new List<long>();
List<string> updateDescriptionList = new List<string>();
List<DateTime> updateStartedOnList = new List<DateTime>();
List<DateTime> updateFinishedOnList = new List<DateTime>();

var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_00310a262abd8758c59d6849f2a2be40)inParamSourceList.Current).ssENActionTimestamps;
if (record.ssId != 0L) {
updateIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
updateDescriptionList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssDescription));
updateStartedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssStartedOn));
updateFinishedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssFinishedOn));
} else {
insertDescriptionList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssDescription));
insertStartedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssStartedOn));
insertFinishedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssFinishedOn));
}
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertDescriptionList.IsEmpty() || !insertStartedOnList.IsEmpty() || !insertFinishedOnList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssDescription",DbType.String,insertDescriptionList);
executionService.CreateParameter(insertSqlCmd,"@ssStartedOn",DbType.DateTime,insertStartedOnList);
executionService.CreateParameter(insertSqlCmd,"@ssFinishedOn",DbType.DateTime,insertFinishedOnList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeActionTimestamps (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
if(!updateDescriptionList.IsEmpty() || !updateStartedOnList.IsEmpty() || !updateFinishedOnList.IsEmpty()){
await using(var updateSqlCmd = trans.CreateCommand(updateSql)){
executionService.CreateParameter(updateSqlCmd,"@ssId",DbType.Int64,updateIdList);
executionService.CreateParameter(updateSqlCmd,"@ssDescription",DbType.String,updateDescriptionList);
executionService.CreateParameter(updateSqlCmd,"@ssStartedOn",DbType.DateTime,updateStartedOnList);
executionService.CreateParameter(updateSqlCmd,"@ssFinishedOn",DbType.DateTime,updateFinishedOnList);
await updateSqlCmd.PrepareAsync(cancellationToken);
await updateSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeActionTimestamps (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(updateSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteActionTimestamps
/// </summary>

public static async Task DeleteActionTimestamps(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteActionTimestamps", "cfc06667-dda9-4522-84f1-f16b150b59da.#DeleteEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteActionTimestamps", "cfc06667-dda9-4522-84f1-f16b150b59da.#DeleteEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENActionTimestampsEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ActionTimestamps, _EntityKeyConstants._ConectaProveedoresEntityKeys._ActionTimestampsAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteActionTimestamps", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllActionTimestamps
/// </summary>

public static async Task DeleteAllActionTimestamps(IRequestContext requestContext,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteAllActionTimestamps", "cfc06667-dda9-4522-84f1-f16b150b59da.#DeleteAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllActionTimestamps", "cfc06667-dda9-4522-84f1-f16b150b59da.#DeleteAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENActionTimestampsEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteActionTimestamps", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetActionTimestamps
/// </summary>

public static async Task<RC_00310a262abd8758c59d6849f2a2be40> GetActionTimestamps(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_00310a262abd8758c59d6849f2a2be40 outParamRecord = default;
outParamRecord = new RC_00310a262abd8758c59d6849f2a2be40();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetActionTimestamps", "cfc06667-dda9-4522-84f1-f16b150b59da.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetActionTimestamps", "cfc06667-dda9-4522-84f1-f16b150b59da.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ActionTimestamps, _EntityKeyConstants._ConectaProveedoresEntityKeys._ActionTimestampsAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ActionTimestamps, _EntityKeyConstants._ConectaProveedoresEntityKeys._ActionTimestampsAttributeKeys.@Description, "description") ?? "description", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ActionTimestamps, _EntityKeyConstants._ConectaProveedoresEntityKeys._ActionTimestampsAttributeKeys.@StartedOn, "startedon") ?? "startedon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ActionTimestamps, _EntityKeyConstants._ConectaProveedoresEntityKeys._ActionTimestampsAttributeKeys.@FinishedOn, "finishedon") ?? "finishedon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
" FROM " + ENActionTimestampsEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ActionTimestamps, _EntityKeyConstants._ConectaProveedoresEntityKeys._ActionTimestampsAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetActionTimestamps", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(4,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENActionTimestampsEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetActionTimestampsForUpdate
/// </summary>

public static async Task<RC_00310a262abd8758c59d6849f2a2be40> GetActionTimestampsForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_00310a262abd8758c59d6849f2a2be40 outParamRecord = default;
outParamRecord = new RC_00310a262abd8758c59d6849f2a2be40();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetActionTimestampsForUpdate", "cfc06667-dda9-4522-84f1-f16b150b59da.#GetEntityForUpdate");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetActionTimestampsForUpdate", "cfc06667-dda9-4522-84f1-f16b150b59da.#GetEntityForUpdate", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ActionTimestamps, _EntityKeyConstants._ConectaProveedoresEntityKeys._ActionTimestampsAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ActionTimestamps, _EntityKeyConstants._ConectaProveedoresEntityKeys._ActionTimestampsAttributeKeys.@Description, "description") ?? "description", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ActionTimestamps, _EntityKeyConstants._ConectaProveedoresEntityKeys._ActionTimestampsAttributeKeys.@StartedOn, "startedon") ?? "startedon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ActionTimestamps, _EntityKeyConstants._ConectaProveedoresEntityKeys._ActionTimestampsAttributeKeys.@FinishedOn, "finishedon") ?? "finishedon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
" FROM " + ENActionTimestampsEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ActionTimestamps, _EntityKeyConstants._ConectaProveedoresEntityKeys._ActionTimestampsAttributeKeys.@Id, "id") ?? "id") + " = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetActionTimestampsForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(4,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENActionTimestampsEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateActionTimestamps
/// </summary>

public static async Task UpdateActionTimestamps(IRequestContext requestContext,BitArray usedFields,RC_00310a262abd8758c59d6849f2a2be40 inParamSource,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("UpdateActionTimestamps", "cfc06667-dda9-4522-84f1-f16b150b59da.#UpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateActionTimestamps", "cfc06667-dda9-4522-84f1-f16b150b59da.#UpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_b22d64c90281d09a316b6f4502a74326EntityRecord ssENActionTimestamps = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(4,true);
}
string updateSet = "UPDATE " + ENActionTimestampsEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ActionTimestamps, _EntityKeyConstants._ConectaProveedoresEntityKeys._ActionTimestampsAttributeKeys.@Description, "description") ?? "description") + " = @ssDescription"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ActionTimestamps, _EntityKeyConstants._ConectaProveedoresEntityKeys._ActionTimestampsAttributeKeys.@StartedOn, "startedon") ?? "startedon") + " = @ssStartedOn"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ActionTimestamps, _EntityKeyConstants._ConectaProveedoresEntityKeys._ActionTimestampsAttributeKeys.@FinishedOn, "finishedon") ?? "finishedon") + " = @ssFinishedOn"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ActionTimestamps, _EntityKeyConstants._ConectaProveedoresEntityKeys._ActionTimestampsAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENActionTimestamps_ssId_ActionTimestamps";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ActionTimestamps, _EntityKeyConstants._ConectaProveedoresEntityKeys._ActionTimestampsAttributeKeys.@StartedOn, "startedon") ?? "startedon") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ActionTimestamps, _EntityKeyConstants._ConectaProveedoresEntityKeys._ActionTimestampsAttributeKeys.@StartedOn, "startedon") ?? "startedon") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssDescription", DbType.String, ssENActionTimestamps.ssDescription);
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssStartedOn", DbType.DateTime, ssENActionTimestamps.ssStartedOn);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssFinishedOn", DbType.DateTime, ssENActionTimestamps.ssFinishedOn);
}
sqlCmd.CreateParameter("@idparam_ssENActionTimestamps_ssId_ActionTimestamps", DbType.Int64, ssENActionTimestamps.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateActionTimestamps", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("ActionTimestamps", ssENActionTimestamps.ssId.ToString()); }}
}
return;
}

}
}
