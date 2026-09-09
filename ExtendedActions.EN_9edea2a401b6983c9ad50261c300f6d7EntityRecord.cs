using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateInvoiceStatusHistory
/// </summary>

public static async Task<long> CreateInvoiceStatusHistory(IRequestContext requestContext,RC_a2551032116fa7acb5fb1896fd9acdf2 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateInvoiceStatusHistory", "778b7417-f9dd-448f-b714-951f39abdd61.#CreateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateInvoiceStatusHistory", "778b7417-f9dd-448f-b714-951f39abdd61.#CreateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_9edea2a401b6983c9ad50261c300f6d7EntityRecord ssENInvoiceStatusHistory = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENInvoiceStatusHistoryEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceStatusHistoryAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceStatusHistoryAttributeKeys.@InvoiceStatusId, "invoicestatusid") ?? "invoicestatusid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceStatusHistoryAttributeKeys.@TimeStamp, "timestamp") ?? "timestamp") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceStatusHistoryAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + "" +
" ) VALUES (" +
" @ssInvoiceId" +
", @ssInvoiceStatusId" +
", @ssTimeStamp" +
", @ssCreatedBy" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENInvoiceStatusHistory.ssInvoiceId==0L)) {
insertSqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, ssENInvoiceStatusHistory.ssInvoiceId);

}
if ((ssENInvoiceStatusHistory.ssInvoiceStatusId==0)) {
insertSqlCmd.CreateParameter("@ssInvoiceStatusId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssInvoiceStatusId", DbType.Int32, ssENInvoiceStatusHistory.ssInvoiceStatusId);

}
insertSqlCmd.CreateParameter("@ssTimeStamp", DbType.DateTime, ssENInvoiceStatusHistory.ssTimeStamp);
if ((ssENInvoiceStatusHistory.ssCreatedBy=="")) {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENInvoiceStatusHistory.ssCreatedBy);

}
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateInvoiceStatusHistory", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateInvoiceStatusHistory
/// </summary>

public static async Task<long> CreateOrUpdateInvoiceStatusHistory(IRequestContext requestContext,BitArray usedFields,RC_a2551032116fa7acb5fb1896fd9acdf2 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateInvoiceStatusHistory", "778b7417-f9dd-448f-b714-951f39abdd61.#CreateOrUpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateInvoiceStatusHistory", "778b7417-f9dd-448f-b714-951f39abdd61.#CreateOrUpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_9edea2a401b6983c9ad50261c300f6d7EntityRecord ssENInvoiceStatusHistory = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(5,true);
}
string updateSet = "UPDATE " + ENInvoiceStatusHistoryEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceStatusHistoryAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + " = @ssInvoiceId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceStatusHistoryAttributeKeys.@InvoiceStatusId, "invoicestatusid") ?? "invoicestatusid") + " = @ssInvoiceStatusId"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceStatusHistoryAttributeKeys.@TimeStamp, "timestamp") ?? "timestamp") + " = @ssTimeStamp"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceStatusHistoryAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = @ssCreatedBy"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceStatusHistoryAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENInvoiceStatusHistory_ssId_InvoiceStatusHistory";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceStatusHistoryAttributeKeys.@TimeStamp, "timestamp") ?? "timestamp") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceStatusHistoryAttributeKeys.@TimeStamp, "timestamp") ?? "timestamp") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENInvoiceStatusHistory.ssInvoiceId==0L)) {
sqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, ssENInvoiceStatusHistory.ssInvoiceId);

}
}
if(usedFields[2]) {
if ((ssENInvoiceStatusHistory.ssInvoiceStatusId==0)) {
sqlCmd.CreateParameter("@ssInvoiceStatusId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssInvoiceStatusId", DbType.Int32, ssENInvoiceStatusHistory.ssInvoiceStatusId);

}
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssTimeStamp", DbType.DateTime, ssENInvoiceStatusHistory.ssTimeStamp);
}
if(usedFields[4]) {
if ((ssENInvoiceStatusHistory.ssCreatedBy=="")) {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENInvoiceStatusHistory.ssCreatedBy);

}
}
sqlCmd.CreateParameter("@idparam_ssENInvoiceStatusHistory_ssId_InvoiceStatusHistory", DbType.Int64, ssENInvoiceStatusHistory.ssId);
int counter = 0;
if(ssENInvoiceStatusHistory.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateInvoiceStatusHistory (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENInvoiceStatusHistoryEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceStatusHistoryAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceStatusHistoryAttributeKeys.@InvoiceStatusId, "invoicestatusid") ?? "invoicestatusid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceStatusHistoryAttributeKeys.@TimeStamp, "timestamp") ?? "timestamp") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceStatusHistoryAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + "" +
" ) VALUES (" +
" @ssInvoiceId" +
", @ssInvoiceStatusId" +
", @ssTimeStamp" +
", @ssCreatedBy" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENInvoiceStatusHistory.ssInvoiceId==0L)) {
insertSqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, ssENInvoiceStatusHistory.ssInvoiceId);

}
if ((ssENInvoiceStatusHistory.ssInvoiceStatusId==0)) {
insertSqlCmd.CreateParameter("@ssInvoiceStatusId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssInvoiceStatusId", DbType.Int32, ssENInvoiceStatusHistory.ssInvoiceStatusId);

}
insertSqlCmd.CreateParameter("@ssTimeStamp", DbType.DateTime, ssENInvoiceStatusHistory.ssTimeStamp);
if ((ssENInvoiceStatusHistory.ssCreatedBy=="")) {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENInvoiceStatusHistory.ssCreatedBy);

}
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateInvoiceStatusHistory", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENInvoiceStatusHistory.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeInvoiceStatusHistory
/// </summary>

public static async Task CreateOrUpdateSomeInvoiceStatusHistory(IRequestContext requestContext,RL_61b7015322a190028a6e9742f654db41 inParamSourceList,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateSomeInvoiceStatusHistory", "778b7417-f9dd-448f-b714-951f39abdd61.#CreateOrUpdateAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeInvoiceStatusHistory", "778b7417-f9dd-448f-b714-951f39abdd61.#CreateOrUpdateAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
string entityTableName = ENInvoiceStatusHistoryEntity.LocalViewName(null);
string insertSql = "INSERT INTO " + entityTableName + " (" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceStatusHistoryAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceStatusHistoryAttributeKeys.@InvoiceStatusId, "invoicestatusid") ?? "invoicestatusid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceStatusHistoryAttributeKeys.@TimeStamp, "timestamp") ?? "timestamp") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceStatusHistoryAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + ") VALUES ( unnest(@ssInvoiceId),  unnest(@ssInvoiceStatusId),  unnest(@ssTimeStamp),  unnest(@ssCreatedBy)) ";
insertSql += "";

string updateSql = "UPDATE " + entityTableName + " SET " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceStatusHistoryAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceStatusHistoryAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceStatusHistoryAttributeKeys.@InvoiceStatusId, "invoicestatusid") ?? "invoicestatusid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceStatusHistoryAttributeKeys.@InvoiceStatusId, "invoicestatusid") ?? "invoicestatusid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceStatusHistoryAttributeKeys.@TimeStamp, "timestamp") ?? "timestamp") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceStatusHistoryAttributeKeys.@TimeStamp, "timestamp") ?? "timestamp") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceStatusHistoryAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceStatusHistoryAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " from ( select  unnest(@ssId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceStatusHistoryAttributeKeys.@Id, "id") ?? "id") + ",  unnest(@ssInvoiceId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceStatusHistoryAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + ",  unnest(@ssInvoiceStatusId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceStatusHistoryAttributeKeys.@InvoiceStatusId, "invoicestatusid") ?? "invoicestatusid") + ",  unnest(@ssTimeStamp) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceStatusHistoryAttributeKeys.@TimeStamp, "timestamp") ?? "timestamp") + ",  unnest(@ssCreatedBy) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceStatusHistoryAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " ) as updateTable where " + entityTableName + "." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceStatusHistoryAttributeKeys.@Id, "id") ?? "id") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceStatusHistoryAttributeKeys.@Id, "id") ?? "id") + " ";
updateSql += "";

List<object> insertInvoiceIdList = new List<object>();
List<object> insertInvoiceStatusIdList = new List<object>();
List<DateTime> insertTimeStampList = new List<DateTime>();
List<object> insertCreatedByList = new List<object>();

List<long> updateIdList = new List<long>();
List<object> updateInvoiceIdList = new List<object>();
List<object> updateInvoiceStatusIdList = new List<object>();
List<DateTime> updateTimeStampList = new List<DateTime>();
List<object> updateCreatedByList = new List<object>();

var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_a2551032116fa7acb5fb1896fd9acdf2)inParamSourceList.Current).ssENInvoiceStatusHistory;
if (record.ssId != 0L) {
updateIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
if ((record.ssInvoiceId==0L)) {
updateInvoiceIdList.Add(null);
} else {
updateInvoiceIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssInvoiceId));
}
if ((record.ssInvoiceStatusId==0)) {
updateInvoiceStatusIdList.Add(null);
} else {
updateInvoiceStatusIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssInvoiceStatusId));
}
updateTimeStampList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssTimeStamp));
if ((record.ssCreatedBy=="")) {
updateCreatedByList.Add(null);
} else {
updateCreatedByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssCreatedBy));
}
} else {
if ((record.ssInvoiceId==0L)) {
insertInvoiceIdList.Add(null);
} else {
insertInvoiceIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssInvoiceId));
}
if ((record.ssInvoiceStatusId==0)) {
insertInvoiceStatusIdList.Add(null);
} else {
insertInvoiceStatusIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssInvoiceStatusId));
}
insertTimeStampList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssTimeStamp));
if ((record.ssCreatedBy=="")) {
insertCreatedByList.Add(null);
} else {
insertCreatedByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssCreatedBy));
}
}
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertInvoiceIdList.IsEmpty() || !insertInvoiceStatusIdList.IsEmpty() || !insertTimeStampList.IsEmpty() || !insertCreatedByList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssInvoiceId",DbType.Int64,insertInvoiceIdList);
executionService.CreateParameter(insertSqlCmd,"@ssInvoiceStatusId",DbType.Int32,insertInvoiceStatusIdList);
executionService.CreateParameter(insertSqlCmd,"@ssTimeStamp",DbType.DateTime,insertTimeStampList);
executionService.CreateParameter(insertSqlCmd,"@ssCreatedBy",DbType.String,insertCreatedByList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeInvoiceStatusHistory (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
if(!updateInvoiceIdList.IsEmpty() || !updateInvoiceStatusIdList.IsEmpty() || !updateTimeStampList.IsEmpty() || !updateCreatedByList.IsEmpty()){
await using(var updateSqlCmd = trans.CreateCommand(updateSql)){
executionService.CreateParameter(updateSqlCmd,"@ssId",DbType.Int64,updateIdList);
executionService.CreateParameter(updateSqlCmd,"@ssInvoiceId",DbType.Int64,updateInvoiceIdList);
executionService.CreateParameter(updateSqlCmd,"@ssInvoiceStatusId",DbType.Int32,updateInvoiceStatusIdList);
executionService.CreateParameter(updateSqlCmd,"@ssTimeStamp",DbType.DateTime,updateTimeStampList);
executionService.CreateParameter(updateSqlCmd,"@ssCreatedBy",DbType.String,updateCreatedByList);
await updateSqlCmd.PrepareAsync(cancellationToken);
await updateSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeInvoiceStatusHistory (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(updateSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteInvoiceStatusHistory
/// </summary>

public static async Task DeleteInvoiceStatusHistory(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteInvoiceStatusHistory", "778b7417-f9dd-448f-b714-951f39abdd61.#DeleteEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteInvoiceStatusHistory", "778b7417-f9dd-448f-b714-951f39abdd61.#DeleteEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENInvoiceStatusHistoryEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceStatusHistoryAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteInvoiceStatusHistory", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllInvoiceStatusHistory
/// </summary>

public static async Task DeleteAllInvoiceStatusHistory(IRequestContext requestContext,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteAllInvoiceStatusHistory", "778b7417-f9dd-448f-b714-951f39abdd61.#DeleteAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllInvoiceStatusHistory", "778b7417-f9dd-448f-b714-951f39abdd61.#DeleteAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENInvoiceStatusHistoryEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteInvoiceStatusHistory", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetInvoiceStatusHistory
/// </summary>

public static async Task<RC_a2551032116fa7acb5fb1896fd9acdf2> GetInvoiceStatusHistory(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_a2551032116fa7acb5fb1896fd9acdf2 outParamRecord = default;
outParamRecord = new RC_a2551032116fa7acb5fb1896fd9acdf2();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetInvoiceStatusHistory", "778b7417-f9dd-448f-b714-951f39abdd61.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetInvoiceStatusHistory", "778b7417-f9dd-448f-b714-951f39abdd61.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceStatusHistoryAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceStatusHistoryAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceStatusHistoryAttributeKeys.@InvoiceStatusId, "invoicestatusid") ?? "invoicestatusid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceStatusHistoryAttributeKeys.@TimeStamp, "timestamp") ?? "timestamp", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceStatusHistoryAttributeKeys.@CreatedBy, "createdby") ?? "createdby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
" FROM " + ENInvoiceStatusHistoryEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceStatusHistoryAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetInvoiceStatusHistory", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(5,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENInvoiceStatusHistoryEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetInvoiceStatusHistoryForUpdate
/// </summary>

public static async Task<RC_a2551032116fa7acb5fb1896fd9acdf2> GetInvoiceStatusHistoryForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_a2551032116fa7acb5fb1896fd9acdf2 outParamRecord = default;
outParamRecord = new RC_a2551032116fa7acb5fb1896fd9acdf2();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetInvoiceStatusHistoryForUpdate", "778b7417-f9dd-448f-b714-951f39abdd61.#GetEntityForUpdate");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetInvoiceStatusHistoryForUpdate", "778b7417-f9dd-448f-b714-951f39abdd61.#GetEntityForUpdate", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceStatusHistoryAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceStatusHistoryAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceStatusHistoryAttributeKeys.@InvoiceStatusId, "invoicestatusid") ?? "invoicestatusid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceStatusHistoryAttributeKeys.@TimeStamp, "timestamp") ?? "timestamp", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceStatusHistoryAttributeKeys.@CreatedBy, "createdby") ?? "createdby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
" FROM " + ENInvoiceStatusHistoryEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceStatusHistoryAttributeKeys.@Id, "id") ?? "id") + " = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetInvoiceStatusHistoryForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(5,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENInvoiceStatusHistoryEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateInvoiceStatusHistory
/// </summary>

public static async Task UpdateInvoiceStatusHistory(IRequestContext requestContext,BitArray usedFields,RC_a2551032116fa7acb5fb1896fd9acdf2 inParamSource,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("UpdateInvoiceStatusHistory", "778b7417-f9dd-448f-b714-951f39abdd61.#UpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateInvoiceStatusHistory", "778b7417-f9dd-448f-b714-951f39abdd61.#UpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_9edea2a401b6983c9ad50261c300f6d7EntityRecord ssENInvoiceStatusHistory = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(5,true);
}
string updateSet = "UPDATE " + ENInvoiceStatusHistoryEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceStatusHistoryAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + " = @ssInvoiceId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceStatusHistoryAttributeKeys.@InvoiceStatusId, "invoicestatusid") ?? "invoicestatusid") + " = @ssInvoiceStatusId"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceStatusHistoryAttributeKeys.@TimeStamp, "timestamp") ?? "timestamp") + " = @ssTimeStamp"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceStatusHistoryAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = @ssCreatedBy"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceStatusHistoryAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENInvoiceStatusHistory_ssId_InvoiceStatusHistory";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceStatusHistoryAttributeKeys.@TimeStamp, "timestamp") ?? "timestamp") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceStatusHistoryAttributeKeys.@TimeStamp, "timestamp") ?? "timestamp") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENInvoiceStatusHistory.ssInvoiceId==0L)) {
sqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, ssENInvoiceStatusHistory.ssInvoiceId);

}
}
if(usedFields[2]) {
if ((ssENInvoiceStatusHistory.ssInvoiceStatusId==0)) {
sqlCmd.CreateParameter("@ssInvoiceStatusId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssInvoiceStatusId", DbType.Int32, ssENInvoiceStatusHistory.ssInvoiceStatusId);

}
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssTimeStamp", DbType.DateTime, ssENInvoiceStatusHistory.ssTimeStamp);
}
if(usedFields[4]) {
if ((ssENInvoiceStatusHistory.ssCreatedBy=="")) {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENInvoiceStatusHistory.ssCreatedBy);

}
}
sqlCmd.CreateParameter("@idparam_ssENInvoiceStatusHistory_ssId_InvoiceStatusHistory", DbType.Int64, ssENInvoiceStatusHistory.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateInvoiceStatusHistory", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("InvoiceStatusHistory", ssENInvoiceStatusHistory.ssId.ToString()); }}
}
return;
}

}
}
