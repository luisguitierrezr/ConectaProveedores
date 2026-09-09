using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateInvoiceExtendedSelloDigital
/// </summary>

public static async Task<long> CreateInvoiceExtendedSelloDigital(IRequestContext requestContext,RC_d5bae0a1e64415dc86dedbeae539158c inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateInvoiceExtendedSelloDigital", "ef2e0c81-507b-4d10-9a84-290d874c1619.#CreateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateInvoiceExtendedSelloDigital", "ef2e0c81-507b-4d10-9a84-290d874c1619.#CreateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_5d65ad71be8ce0e9ccb95bcaf92c4383EntityRecord ssENInvoiceExtendedSelloDigital = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENInvoiceExtendedSelloDigitalEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedSelloDigital, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedSelloDigitalAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedSelloDigital, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedSelloDigitalAttributeKeys.@SelloDigital, "sellodigital") ?? "sellodigital") + "" +
" ) VALUES (" +
" @ssInvoiceId" +
", @ssSelloDigital" +
" )";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, ssENInvoiceExtendedSelloDigital.ssInvoiceId);
insertSqlCmd.CreateParameter("@ssSelloDigital", DbType.Binary, ssENInvoiceExtendedSelloDigital.ssSelloDigital);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateInvoiceExtendedSelloDigital", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
outParamId = ssENInvoiceExtendedSelloDigital.ssInvoiceId;
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateInvoiceExtendedSelloDigital
/// </summary>

public static async Task<long> CreateOrUpdateInvoiceExtendedSelloDigital(IRequestContext requestContext,BitArray usedFields,RC_d5bae0a1e64415dc86dedbeae539158c inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateInvoiceExtendedSelloDigital", "ef2e0c81-507b-4d10-9a84-290d874c1619.#CreateOrUpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateInvoiceExtendedSelloDigital", "ef2e0c81-507b-4d10-9a84-290d874c1619.#CreateOrUpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_5d65ad71be8ce0e9ccb95bcaf92c4383EntityRecord ssENInvoiceExtendedSelloDigital = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(2,true);
}
string updateSet = "UPDATE " + ENInvoiceExtendedSelloDigitalEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedSelloDigital, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedSelloDigitalAttributeKeys.@SelloDigital, "sellodigital") ?? "sellodigital") + " = @ssSelloDigital"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedSelloDigital, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedSelloDigitalAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + " = @idparam_ssENInvoiceExSelloDigital_ssIeId_InvoiceExteelloDigital";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedSelloDigital, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedSelloDigitalAttributeKeys.@SelloDigital, "sellodigital") ?? "sellodigital") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedSelloDigital, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedSelloDigitalAttributeKeys.@SelloDigital, "sellodigital") ?? "sellodigital") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssSelloDigital", DbType.Binary, ssENInvoiceExtendedSelloDigital.ssSelloDigital);
}
sqlCmd.CreateParameter("@idparam_ssENInvoiceExSelloDigital_ssIeId_InvoiceExteelloDigital", DbType.Int64, ssENInvoiceExtendedSelloDigital.ssInvoiceId);
int counter = 0;
if(ssENInvoiceExtendedSelloDigital.ssInvoiceId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateInvoiceExtendedSelloDigital (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENInvoiceExtendedSelloDigitalEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedSelloDigital, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedSelloDigitalAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedSelloDigital, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedSelloDigitalAttributeKeys.@SelloDigital, "sellodigital") ?? "sellodigital") + "" +
" ) VALUES (" +
" @ssInvoiceId" +
", @ssSelloDigital" +
" )";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, ssENInvoiceExtendedSelloDigital.ssInvoiceId);
insertSqlCmd.CreateParameter("@ssSelloDigital", DbType.Binary, ssENInvoiceExtendedSelloDigital.ssSelloDigital);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateInvoiceExtendedSelloDigital", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
outParamId = ssENInvoiceExtendedSelloDigital.ssInvoiceId;
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENInvoiceExtendedSelloDigital.ssInvoiceId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeInvoiceExtendedSelloDigital
/// </summary>

public static async Task CreateOrUpdateSomeInvoiceExtendedSelloDigital(IRequestContext requestContext,RL_5f6ddbbedd52a55ae6452e6c4929a917 inParamSourceList,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateSomeInvoiceExtendedSelloDigital", "ef2e0c81-507b-4d10-9a84-290d874c1619.#CreateOrUpdateAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeInvoiceExtendedSelloDigital", "ef2e0c81-507b-4d10-9a84-290d874c1619.#CreateOrUpdateAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
string entityTableName = ENInvoiceExtendedSelloDigitalEntity.LocalViewName(null);
string insertSql = "INSERT INTO " + entityTableName + " (" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedSelloDigital, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedSelloDigitalAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedSelloDigital, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedSelloDigitalAttributeKeys.@SelloDigital, "sellodigital") ?? "sellodigital") + ") VALUES ( unnest(@ssInvoiceId),  unnest(@ssSelloDigital)) ON CONFLICT(" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedSelloDigital, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedSelloDigitalAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + ") do update set " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedSelloDigital, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedSelloDigitalAttributeKeys.@SelloDigital, "sellodigital") ?? "sellodigital") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedSelloDigital, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedSelloDigitalAttributeKeys.@SelloDigital, "sellodigital") ?? "sellodigital") + " ";
insertSql += "";


List<object> insertInvoiceIdList = new List<object>();
List<byte[]> insertSelloDigitalList = new List<byte[]>();


var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_d5bae0a1e64415dc86dedbeae539158c)inParamSourceList.Current).ssENInvoiceExtendedSelloDigital;
insertInvoiceIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssInvoiceId));
insertSelloDigitalList.Add((byte[])executionService.TransformRuntimeToDatabaseValue(DbType.Binary, record.ssSelloDigital));
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertInvoiceIdList.IsEmpty() || !insertSelloDigitalList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssInvoiceId",DbType.Int64,insertInvoiceIdList);
executionService.CreateParameter(insertSqlCmd,"@ssSelloDigital",DbType.Binary,insertSelloDigitalList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeInvoiceExtendedSelloDigital (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteInvoiceExtendedSelloDigital
/// </summary>

public static async Task DeleteInvoiceExtendedSelloDigital(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteInvoiceExtendedSelloDigital", "ef2e0c81-507b-4d10-9a84-290d874c1619.#DeleteEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteInvoiceExtendedSelloDigital", "ef2e0c81-507b-4d10-9a84-290d874c1619.#DeleteEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENInvoiceExtendedSelloDigitalEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedSelloDigital, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedSelloDigitalAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteInvoiceExtendedSelloDigital", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllInvoiceExtendedSelloDigital
/// </summary>

public static async Task DeleteAllInvoiceExtendedSelloDigital(IRequestContext requestContext,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteAllInvoiceExtendedSelloDigital", "ef2e0c81-507b-4d10-9a84-290d874c1619.#DeleteAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllInvoiceExtendedSelloDigital", "ef2e0c81-507b-4d10-9a84-290d874c1619.#DeleteAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENInvoiceExtendedSelloDigitalEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteInvoiceExtendedSelloDigital", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetInvoiceExtendedSelloDigital
/// </summary>

public static async Task<RC_d5bae0a1e64415dc86dedbeae539158c> GetInvoiceExtendedSelloDigital(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_d5bae0a1e64415dc86dedbeae539158c outParamRecord = default;
outParamRecord = new RC_d5bae0a1e64415dc86dedbeae539158c();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetInvoiceExtendedSelloDigital", "ef2e0c81-507b-4d10-9a84-290d874c1619.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetInvoiceExtendedSelloDigital", "ef2e0c81-507b-4d10-9a84-290d874c1619.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedSelloDigital, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedSelloDigitalAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedSelloDigital, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedSelloDigitalAttributeKeys.@SelloDigital, "sellodigital") ?? "sellodigital", OutSystems.HubEdition.Extensibility.Data.DBDataType.BINARY_DATA) + "" +
" FROM " + ENInvoiceExtendedSelloDigitalEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedSelloDigital, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedSelloDigitalAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetInvoiceExtendedSelloDigital", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(2,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENInvoiceExtendedSelloDigitalEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetInvoiceExtendedSelloDigitalForUpdate
/// </summary>

public static async Task<RC_d5bae0a1e64415dc86dedbeae539158c> GetInvoiceExtendedSelloDigitalForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_d5bae0a1e64415dc86dedbeae539158c outParamRecord = default;
outParamRecord = new RC_d5bae0a1e64415dc86dedbeae539158c();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetInvoiceExtendedSelloDigitalForUpdate", "ef2e0c81-507b-4d10-9a84-290d874c1619.#GetEntityForUpdate");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetInvoiceExtendedSelloDigitalForUpdate", "ef2e0c81-507b-4d10-9a84-290d874c1619.#GetEntityForUpdate", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedSelloDigital, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedSelloDigitalAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedSelloDigital, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedSelloDigitalAttributeKeys.@SelloDigital, "sellodigital") ?? "sellodigital", OutSystems.HubEdition.Extensibility.Data.DBDataType.BINARY_DATA) + "" +
" FROM " + ENInvoiceExtendedSelloDigitalEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedSelloDigital, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedSelloDigitalAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + " = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetInvoiceExtendedSelloDigitalForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(2,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENInvoiceExtendedSelloDigitalEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateInvoiceExtendedSelloDigital
/// </summary>

public static async Task UpdateInvoiceExtendedSelloDigital(IRequestContext requestContext,BitArray usedFields,RC_d5bae0a1e64415dc86dedbeae539158c inParamSource,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("UpdateInvoiceExtendedSelloDigital", "ef2e0c81-507b-4d10-9a84-290d874c1619.#UpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateInvoiceExtendedSelloDigital", "ef2e0c81-507b-4d10-9a84-290d874c1619.#UpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_5d65ad71be8ce0e9ccb95bcaf92c4383EntityRecord ssENInvoiceExtendedSelloDigital = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(2,true);
}
string updateSet = "UPDATE " + ENInvoiceExtendedSelloDigitalEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedSelloDigital, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedSelloDigitalAttributeKeys.@SelloDigital, "sellodigital") ?? "sellodigital") + " = @ssSelloDigital"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedSelloDigital, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedSelloDigitalAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + " = @idparam_ssENInvoiceExSelloDigital_ssIeId_InvoiceExteelloDigital";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedSelloDigital, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedSelloDigitalAttributeKeys.@SelloDigital, "sellodigital") ?? "sellodigital") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedSelloDigital, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedSelloDigitalAttributeKeys.@SelloDigital, "sellodigital") ?? "sellodigital") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssSelloDigital", DbType.Binary, ssENInvoiceExtendedSelloDigital.ssSelloDigital);
}
sqlCmd.CreateParameter("@idparam_ssENInvoiceExSelloDigital_ssIeId_InvoiceExteelloDigital", DbType.Int64, ssENInvoiceExtendedSelloDigital.ssInvoiceId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateInvoiceExtendedSelloDigital", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("InvoiceExtendedSelloDigital", ssENInvoiceExtendedSelloDigital.ssInvoiceId.ToString()); }}
}
return;
}

}
}
