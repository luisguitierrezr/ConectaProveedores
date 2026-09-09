using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateInvoiceAccountingProcessLines_F43
/// </summary>

public static async Task<long> CreateInvoiceAccountingProcessLines_F43(IRequestContext requestContext,RC_56dd61ddd73c9e3bf07414aa1c617494 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateInvoiceAccountingProcessLines_F43", "ba633178-69f3-4418-aeb8-b16dbdbf3f68.#CreateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateInvoiceAccountingProcessLines_F43", "ba633178-69f3-4418-aeb8-b16dbdbf3f68.#CreateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_0d662bdaada5191124d8fca5ffaaf619EntityRecord ssENInvoiceAccountingProcessLines_F43 = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENInvoiceAccountingProcessLines_F43Entity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessLines_F43, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessLines_F43AttributeKeys.@InvoiceAccounting_ProcessId, "invoiceaccounting_processid") ?? "invoiceaccounting_processid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessLines_F43, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessLines_F43AttributeKeys.@Parameter, "parameter") ?? "parameter") + "" +
" ) VALUES (" +
" @ssInvoiceAccounting_ProcessId" +
", @ssParameter" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENInvoiceAccountingProcessLines_F43.ssInvoiceAccounting_ProcessId==0L)) {
insertSqlCmd.CreateParameter("@ssInvoiceAccounting_ProcessId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssInvoiceAccounting_ProcessId", DbType.Int64, ssENInvoiceAccountingProcessLines_F43.ssInvoiceAccounting_ProcessId);

}
insertSqlCmd.CreateParameter("@ssParameter", DbType.String, ssENInvoiceAccountingProcessLines_F43.ssParameter);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateInvoiceAccountingProcessLines_F43", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateInvoiceAccountingProcessLines_F43
/// </summary>

public static async Task<long> CreateOrUpdateInvoiceAccountingProcessLines_F43(IRequestContext requestContext,BitArray usedFields,RC_56dd61ddd73c9e3bf07414aa1c617494 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateInvoiceAccountingProcessLines_F43", "ba633178-69f3-4418-aeb8-b16dbdbf3f68.#CreateOrUpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateInvoiceAccountingProcessLines_F43", "ba633178-69f3-4418-aeb8-b16dbdbf3f68.#CreateOrUpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_0d662bdaada5191124d8fca5ffaaf619EntityRecord ssENInvoiceAccountingProcessLines_F43 = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(3,true);
}
string updateSet = "UPDATE " + ENInvoiceAccountingProcessLines_F43Entity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessLines_F43, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessLines_F43AttributeKeys.@InvoiceAccounting_ProcessId, "invoiceaccounting_processid") ?? "invoiceaccounting_processid") + " = @ssInvoiceAccounting_ProcessId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessLines_F43, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessLines_F43AttributeKeys.@Parameter, "parameter") ?? "parameter") + " = @ssParameter"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessLines_F43, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessLines_F43AttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENInvoiceAccocessLines_F43_InvoiceAccouncessLines_F43";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessLines_F43, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessLines_F43AttributeKeys.@Parameter, "parameter") ?? "parameter") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessLines_F43, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessLines_F43AttributeKeys.@Parameter, "parameter") ?? "parameter") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENInvoiceAccountingProcessLines_F43.ssInvoiceAccounting_ProcessId==0L)) {
sqlCmd.CreateParameter("@ssInvoiceAccounting_ProcessId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssInvoiceAccounting_ProcessId", DbType.Int64, ssENInvoiceAccountingProcessLines_F43.ssInvoiceAccounting_ProcessId);

}
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssParameter", DbType.String, ssENInvoiceAccountingProcessLines_F43.ssParameter);
}
sqlCmd.CreateParameter("@idparam_ssENInvoiceAccocessLines_F43_InvoiceAccouncessLines_F43", DbType.Int64, ssENInvoiceAccountingProcessLines_F43.ssId);
int counter = 0;
if(ssENInvoiceAccountingProcessLines_F43.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateInvoiceAccountingProcessLines_F43 (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENInvoiceAccountingProcessLines_F43Entity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessLines_F43, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessLines_F43AttributeKeys.@InvoiceAccounting_ProcessId, "invoiceaccounting_processid") ?? "invoiceaccounting_processid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessLines_F43, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessLines_F43AttributeKeys.@Parameter, "parameter") ?? "parameter") + "" +
" ) VALUES (" +
" @ssInvoiceAccounting_ProcessId" +
", @ssParameter" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENInvoiceAccountingProcessLines_F43.ssInvoiceAccounting_ProcessId==0L)) {
insertSqlCmd.CreateParameter("@ssInvoiceAccounting_ProcessId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssInvoiceAccounting_ProcessId", DbType.Int64, ssENInvoiceAccountingProcessLines_F43.ssInvoiceAccounting_ProcessId);

}
insertSqlCmd.CreateParameter("@ssParameter", DbType.String, ssENInvoiceAccountingProcessLines_F43.ssParameter);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateInvoiceAccountingProcessLines_F43", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENInvoiceAccountingProcessLines_F43.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeInvoiceAccountingProcessLines_F43
/// </summary>

public static async Task CreateOrUpdateSomeInvoiceAccountingProcessLines_F43(IRequestContext requestContext,RL_75a26b2df3c5e73743b57020e6939e68 inParamSourceList,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateSomeInvoiceAccountingProcessLines_F43", "ba633178-69f3-4418-aeb8-b16dbdbf3f68.#CreateOrUpdateAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeInvoiceAccountingProcessLines_F43", "ba633178-69f3-4418-aeb8-b16dbdbf3f68.#CreateOrUpdateAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
string entityTableName = ENInvoiceAccountingProcessLines_F43Entity.LocalViewName(null);
string insertSql = "INSERT INTO " + entityTableName + " (" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessLines_F43, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessLines_F43AttributeKeys.@InvoiceAccounting_ProcessId, "invoiceaccounting_processid") ?? "invoiceaccounting_processid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessLines_F43, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessLines_F43AttributeKeys.@Parameter, "parameter") ?? "parameter") + ") VALUES ( unnest(@ssInvoiceAccounting_ProcessId),  unnest(@ssParameter)) ";
insertSql += "";

string updateSql = "UPDATE " + entityTableName + " SET " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessLines_F43, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessLines_F43AttributeKeys.@InvoiceAccounting_ProcessId, "invoiceaccounting_processid") ?? "invoiceaccounting_processid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessLines_F43, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessLines_F43AttributeKeys.@InvoiceAccounting_ProcessId, "invoiceaccounting_processid") ?? "invoiceaccounting_processid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessLines_F43, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessLines_F43AttributeKeys.@Parameter, "parameter") ?? "parameter") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessLines_F43, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessLines_F43AttributeKeys.@Parameter, "parameter") ?? "parameter") + " from ( select  unnest(@ssId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessLines_F43, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessLines_F43AttributeKeys.@Id, "id") ?? "id") + ",  unnest(@ssInvoiceAccounting_ProcessId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessLines_F43, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessLines_F43AttributeKeys.@InvoiceAccounting_ProcessId, "invoiceaccounting_processid") ?? "invoiceaccounting_processid") + ",  unnest(@ssParameter) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessLines_F43, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessLines_F43AttributeKeys.@Parameter, "parameter") ?? "parameter") + " ) as updateTable where " + entityTableName + "." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessLines_F43, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessLines_F43AttributeKeys.@Id, "id") ?? "id") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessLines_F43, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessLines_F43AttributeKeys.@Id, "id") ?? "id") + " ";
updateSql += "";

List<object> insertInvoiceAccounting_ProcessIdList = new List<object>();
List<string> insertParameterList = new List<string>();

List<long> updateIdList = new List<long>();
List<object> updateInvoiceAccounting_ProcessIdList = new List<object>();
List<string> updateParameterList = new List<string>();

var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_56dd61ddd73c9e3bf07414aa1c617494)inParamSourceList.Current).ssENInvoiceAccountingProcessLines_F43;
if (record.ssId != 0L) {
updateIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
if ((record.ssInvoiceAccounting_ProcessId==0L)) {
updateInvoiceAccounting_ProcessIdList.Add(null);
} else {
updateInvoiceAccounting_ProcessIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssInvoiceAccounting_ProcessId));
}
updateParameterList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssParameter));
} else {
if ((record.ssInvoiceAccounting_ProcessId==0L)) {
insertInvoiceAccounting_ProcessIdList.Add(null);
} else {
insertInvoiceAccounting_ProcessIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssInvoiceAccounting_ProcessId));
}
insertParameterList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssParameter));
}
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertInvoiceAccounting_ProcessIdList.IsEmpty() || !insertParameterList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssInvoiceAccounting_ProcessId",DbType.Int64,insertInvoiceAccounting_ProcessIdList);
executionService.CreateParameter(insertSqlCmd,"@ssParameter",DbType.String,insertParameterList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeInvoiceAccountingProcessLines_F43 (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
if(!updateInvoiceAccounting_ProcessIdList.IsEmpty() || !updateParameterList.IsEmpty()){
await using(var updateSqlCmd = trans.CreateCommand(updateSql)){
executionService.CreateParameter(updateSqlCmd,"@ssId",DbType.Int64,updateIdList);
executionService.CreateParameter(updateSqlCmd,"@ssInvoiceAccounting_ProcessId",DbType.Int64,updateInvoiceAccounting_ProcessIdList);
executionService.CreateParameter(updateSqlCmd,"@ssParameter",DbType.String,updateParameterList);
await updateSqlCmd.PrepareAsync(cancellationToken);
await updateSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeInvoiceAccountingProcessLines_F43 (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(updateSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteInvoiceAccountingProcessLines_F43
/// </summary>

public static async Task DeleteInvoiceAccountingProcessLines_F43(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteInvoiceAccountingProcessLines_F43", "ba633178-69f3-4418-aeb8-b16dbdbf3f68.#DeleteEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteInvoiceAccountingProcessLines_F43", "ba633178-69f3-4418-aeb8-b16dbdbf3f68.#DeleteEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENInvoiceAccountingProcessLines_F43Entity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessLines_F43, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessLines_F43AttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteInvoiceAccountingProcessLines_F43", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllInvoiceAccountingProcessLines_F43
/// </summary>

public static async Task DeleteAllInvoiceAccountingProcessLines_F43(IRequestContext requestContext,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteAllInvoiceAccountingProcessLines_F43", "ba633178-69f3-4418-aeb8-b16dbdbf3f68.#DeleteAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllInvoiceAccountingProcessLines_F43", "ba633178-69f3-4418-aeb8-b16dbdbf3f68.#DeleteAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENInvoiceAccountingProcessLines_F43Entity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteInvoiceAccountingProcessLines_F43", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetInvoiceAccountingProcessLines_F43
/// </summary>

public static async Task<RC_56dd61ddd73c9e3bf07414aa1c617494> GetInvoiceAccountingProcessLines_F43(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_56dd61ddd73c9e3bf07414aa1c617494 outParamRecord = default;
outParamRecord = new RC_56dd61ddd73c9e3bf07414aa1c617494();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetInvoiceAccountingProcessLines_F43", "ba633178-69f3-4418-aeb8-b16dbdbf3f68.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetInvoiceAccountingProcessLines_F43", "ba633178-69f3-4418-aeb8-b16dbdbf3f68.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessLines_F43, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessLines_F43AttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessLines_F43, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessLines_F43AttributeKeys.@InvoiceAccounting_ProcessId, "invoiceaccounting_processid") ?? "invoiceaccounting_processid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessLines_F43, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessLines_F43AttributeKeys.@Parameter, "parameter") ?? "parameter", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
" FROM " + ENInvoiceAccountingProcessLines_F43Entity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessLines_F43, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessLines_F43AttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetInvoiceAccountingProcessLines_F43", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(3,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENInvoiceAccountingProcessLines_F43Entity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetInvoiceAccountingProcessLines_F43ForUpdate
/// </summary>

public static async Task<RC_56dd61ddd73c9e3bf07414aa1c617494> GetInvoiceAccountingProcessLines_F43ForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_56dd61ddd73c9e3bf07414aa1c617494 outParamRecord = default;
outParamRecord = new RC_56dd61ddd73c9e3bf07414aa1c617494();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetInvoiceAccountingProcessLines_F43ForUpdate", "ba633178-69f3-4418-aeb8-b16dbdbf3f68.#GetEntityForUpdate");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetInvoiceAccountingProcessLines_F43ForUpdate", "ba633178-69f3-4418-aeb8-b16dbdbf3f68.#GetEntityForUpdate", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessLines_F43, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessLines_F43AttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessLines_F43, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessLines_F43AttributeKeys.@InvoiceAccounting_ProcessId, "invoiceaccounting_processid") ?? "invoiceaccounting_processid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessLines_F43, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessLines_F43AttributeKeys.@Parameter, "parameter") ?? "parameter", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
" FROM " + ENInvoiceAccountingProcessLines_F43Entity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessLines_F43, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessLines_F43AttributeKeys.@Id, "id") ?? "id") + " = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetInvoiceAccountingProcessLines_F43ForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(3,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENInvoiceAccountingProcessLines_F43Entity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateInvoiceAccountingProcessLines_F43
/// </summary>

public static async Task UpdateInvoiceAccountingProcessLines_F43(IRequestContext requestContext,BitArray usedFields,RC_56dd61ddd73c9e3bf07414aa1c617494 inParamSource,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("UpdateInvoiceAccountingProcessLines_F43", "ba633178-69f3-4418-aeb8-b16dbdbf3f68.#UpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateInvoiceAccountingProcessLines_F43", "ba633178-69f3-4418-aeb8-b16dbdbf3f68.#UpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_0d662bdaada5191124d8fca5ffaaf619EntityRecord ssENInvoiceAccountingProcessLines_F43 = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(3,true);
}
string updateSet = "UPDATE " + ENInvoiceAccountingProcessLines_F43Entity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessLines_F43, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessLines_F43AttributeKeys.@InvoiceAccounting_ProcessId, "invoiceaccounting_processid") ?? "invoiceaccounting_processid") + " = @ssInvoiceAccounting_ProcessId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessLines_F43, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessLines_F43AttributeKeys.@Parameter, "parameter") ?? "parameter") + " = @ssParameter"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessLines_F43, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessLines_F43AttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENInvoiceAccocessLines_F43_InvoiceAccouncessLines_F43";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessLines_F43, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessLines_F43AttributeKeys.@Parameter, "parameter") ?? "parameter") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessLines_F43, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessLines_F43AttributeKeys.@Parameter, "parameter") ?? "parameter") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENInvoiceAccountingProcessLines_F43.ssInvoiceAccounting_ProcessId==0L)) {
sqlCmd.CreateParameter("@ssInvoiceAccounting_ProcessId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssInvoiceAccounting_ProcessId", DbType.Int64, ssENInvoiceAccountingProcessLines_F43.ssInvoiceAccounting_ProcessId);

}
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssParameter", DbType.String, ssENInvoiceAccountingProcessLines_F43.ssParameter);
}
sqlCmd.CreateParameter("@idparam_ssENInvoiceAccocessLines_F43_InvoiceAccouncessLines_F43", DbType.Int64, ssENInvoiceAccountingProcessLines_F43.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateInvoiceAccountingProcessLines_F43", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("InvoiceAccountingProcessLines_F43", ssENInvoiceAccountingProcessLines_F43.ssId.ToString()); }}
}
return;
}

}
}
