using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateProposalStatusHistory
/// </summary>

public static async Task<long> CreateProposalStatusHistory(IRequestContext requestContext,RC_e6d370b8387bb43d90dc90a766ecdf20 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateProposalStatusHistory", "3c95abf9-fd12-4247-a19e-39b26f2bd62d.#CreateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateProposalStatusHistory", "3c95abf9-fd12-4247-a19e-39b26f2bd62d.#CreateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_f6d34ae04169ae9164103e8797ea11d4EntityRecord ssENProposalStatusHistory = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENProposalStatusHistoryEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalStatusHistoryAttributeKeys.@ProposalId, "proposalid") ?? "proposalid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalStatusHistoryAttributeKeys.@ProposalStatusId, "proposalstatusid") ?? "proposalstatusid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalStatusHistoryAttributeKeys.@TimeStamp, "timestamp") ?? "timestamp") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalStatusHistoryAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + "" +
" ) VALUES (" +
" @ssProposalId" +
", @ssProposalStatusId" +
", @ssTimeStamp" +
", @ssCreatedBy" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENProposalStatusHistory.ssProposalId==0L)) {
insertSqlCmd.CreateParameter("@ssProposalId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssProposalId", DbType.Int64, ssENProposalStatusHistory.ssProposalId);

}
if ((ssENProposalStatusHistory.ssProposalStatusId==0)) {
insertSqlCmd.CreateParameter("@ssProposalStatusId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssProposalStatusId", DbType.Int32, ssENProposalStatusHistory.ssProposalStatusId);

}
insertSqlCmd.CreateParameter("@ssTimeStamp", DbType.DateTime, ssENProposalStatusHistory.ssTimeStamp);
if ((ssENProposalStatusHistory.ssCreatedBy=="")) {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENProposalStatusHistory.ssCreatedBy);

}
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateProposalStatusHistory", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateProposalStatusHistory
/// </summary>

public static async Task<long> CreateOrUpdateProposalStatusHistory(IRequestContext requestContext,BitArray usedFields,RC_e6d370b8387bb43d90dc90a766ecdf20 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateProposalStatusHistory", "3c95abf9-fd12-4247-a19e-39b26f2bd62d.#CreateOrUpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateProposalStatusHistory", "3c95abf9-fd12-4247-a19e-39b26f2bd62d.#CreateOrUpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_f6d34ae04169ae9164103e8797ea11d4EntityRecord ssENProposalStatusHistory = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(5,true);
}
string updateSet = "UPDATE " + ENProposalStatusHistoryEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalStatusHistoryAttributeKeys.@ProposalId, "proposalid") ?? "proposalid") + " = @ssProposalId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalStatusHistoryAttributeKeys.@ProposalStatusId, "proposalstatusid") ?? "proposalstatusid") + " = @ssProposalStatusId"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalStatusHistoryAttributeKeys.@TimeStamp, "timestamp") ?? "timestamp") + " = @ssTimeStamp"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalStatusHistoryAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = @ssCreatedBy"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalStatusHistoryAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENProposalStatusHistory_ssId_ProposalStatusHistory";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalStatusHistoryAttributeKeys.@TimeStamp, "timestamp") ?? "timestamp") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalStatusHistoryAttributeKeys.@TimeStamp, "timestamp") ?? "timestamp") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENProposalStatusHistory.ssProposalId==0L)) {
sqlCmd.CreateParameter("@ssProposalId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssProposalId", DbType.Int64, ssENProposalStatusHistory.ssProposalId);

}
}
if(usedFields[2]) {
if ((ssENProposalStatusHistory.ssProposalStatusId==0)) {
sqlCmd.CreateParameter("@ssProposalStatusId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssProposalStatusId", DbType.Int32, ssENProposalStatusHistory.ssProposalStatusId);

}
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssTimeStamp", DbType.DateTime, ssENProposalStatusHistory.ssTimeStamp);
}
if(usedFields[4]) {
if ((ssENProposalStatusHistory.ssCreatedBy=="")) {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENProposalStatusHistory.ssCreatedBy);

}
}
sqlCmd.CreateParameter("@idparam_ssENProposalStatusHistory_ssId_ProposalStatusHistory", DbType.Int64, ssENProposalStatusHistory.ssId);
int counter = 0;
if(ssENProposalStatusHistory.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateProposalStatusHistory (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENProposalStatusHistoryEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalStatusHistoryAttributeKeys.@ProposalId, "proposalid") ?? "proposalid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalStatusHistoryAttributeKeys.@ProposalStatusId, "proposalstatusid") ?? "proposalstatusid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalStatusHistoryAttributeKeys.@TimeStamp, "timestamp") ?? "timestamp") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalStatusHistoryAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + "" +
" ) VALUES (" +
" @ssProposalId" +
", @ssProposalStatusId" +
", @ssTimeStamp" +
", @ssCreatedBy" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENProposalStatusHistory.ssProposalId==0L)) {
insertSqlCmd.CreateParameter("@ssProposalId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssProposalId", DbType.Int64, ssENProposalStatusHistory.ssProposalId);

}
if ((ssENProposalStatusHistory.ssProposalStatusId==0)) {
insertSqlCmd.CreateParameter("@ssProposalStatusId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssProposalStatusId", DbType.Int32, ssENProposalStatusHistory.ssProposalStatusId);

}
insertSqlCmd.CreateParameter("@ssTimeStamp", DbType.DateTime, ssENProposalStatusHistory.ssTimeStamp);
if ((ssENProposalStatusHistory.ssCreatedBy=="")) {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENProposalStatusHistory.ssCreatedBy);

}
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateProposalStatusHistory", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENProposalStatusHistory.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeProposalStatusHistory
/// </summary>

public static async Task CreateOrUpdateSomeProposalStatusHistory(IRequestContext requestContext,RL_43faae938c012f4de2479cbeb914558b inParamSourceList,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateSomeProposalStatusHistory", "3c95abf9-fd12-4247-a19e-39b26f2bd62d.#CreateOrUpdateAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeProposalStatusHistory", "3c95abf9-fd12-4247-a19e-39b26f2bd62d.#CreateOrUpdateAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
string entityTableName = ENProposalStatusHistoryEntity.LocalViewName(null);
string insertSql = "INSERT INTO " + entityTableName + " (" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalStatusHistoryAttributeKeys.@ProposalId, "proposalid") ?? "proposalid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalStatusHistoryAttributeKeys.@ProposalStatusId, "proposalstatusid") ?? "proposalstatusid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalStatusHistoryAttributeKeys.@TimeStamp, "timestamp") ?? "timestamp") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalStatusHistoryAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + ") VALUES ( unnest(@ssProposalId),  unnest(@ssProposalStatusId),  unnest(@ssTimeStamp),  unnest(@ssCreatedBy)) ";
insertSql += "";

string updateSql = "UPDATE " + entityTableName + " SET " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalStatusHistoryAttributeKeys.@ProposalId, "proposalid") ?? "proposalid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalStatusHistoryAttributeKeys.@ProposalId, "proposalid") ?? "proposalid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalStatusHistoryAttributeKeys.@ProposalStatusId, "proposalstatusid") ?? "proposalstatusid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalStatusHistoryAttributeKeys.@ProposalStatusId, "proposalstatusid") ?? "proposalstatusid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalStatusHistoryAttributeKeys.@TimeStamp, "timestamp") ?? "timestamp") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalStatusHistoryAttributeKeys.@TimeStamp, "timestamp") ?? "timestamp") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalStatusHistoryAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalStatusHistoryAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " from ( select  unnest(@ssId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalStatusHistoryAttributeKeys.@Id, "id") ?? "id") + ",  unnest(@ssProposalId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalStatusHistoryAttributeKeys.@ProposalId, "proposalid") ?? "proposalid") + ",  unnest(@ssProposalStatusId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalStatusHistoryAttributeKeys.@ProposalStatusId, "proposalstatusid") ?? "proposalstatusid") + ",  unnest(@ssTimeStamp) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalStatusHistoryAttributeKeys.@TimeStamp, "timestamp") ?? "timestamp") + ",  unnest(@ssCreatedBy) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalStatusHistoryAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " ) as updateTable where " + entityTableName + "." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalStatusHistoryAttributeKeys.@Id, "id") ?? "id") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalStatusHistoryAttributeKeys.@Id, "id") ?? "id") + " ";
updateSql += "";

List<object> insertProposalIdList = new List<object>();
List<object> insertProposalStatusIdList = new List<object>();
List<DateTime> insertTimeStampList = new List<DateTime>();
List<object> insertCreatedByList = new List<object>();

List<long> updateIdList = new List<long>();
List<object> updateProposalIdList = new List<object>();
List<object> updateProposalStatusIdList = new List<object>();
List<DateTime> updateTimeStampList = new List<DateTime>();
List<object> updateCreatedByList = new List<object>();

var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_e6d370b8387bb43d90dc90a766ecdf20)inParamSourceList.Current).ssENProposalStatusHistory;
if (record.ssId != 0L) {
updateIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
if ((record.ssProposalId==0L)) {
updateProposalIdList.Add(null);
} else {
updateProposalIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssProposalId));
}
if ((record.ssProposalStatusId==0)) {
updateProposalStatusIdList.Add(null);
} else {
updateProposalStatusIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssProposalStatusId));
}
updateTimeStampList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssTimeStamp));
if ((record.ssCreatedBy=="")) {
updateCreatedByList.Add(null);
} else {
updateCreatedByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssCreatedBy));
}
} else {
if ((record.ssProposalId==0L)) {
insertProposalIdList.Add(null);
} else {
insertProposalIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssProposalId));
}
if ((record.ssProposalStatusId==0)) {
insertProposalStatusIdList.Add(null);
} else {
insertProposalStatusIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssProposalStatusId));
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
if (!insertProposalIdList.IsEmpty() || !insertProposalStatusIdList.IsEmpty() || !insertTimeStampList.IsEmpty() || !insertCreatedByList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssProposalId",DbType.Int64,insertProposalIdList);
executionService.CreateParameter(insertSqlCmd,"@ssProposalStatusId",DbType.Int32,insertProposalStatusIdList);
executionService.CreateParameter(insertSqlCmd,"@ssTimeStamp",DbType.DateTime,insertTimeStampList);
executionService.CreateParameter(insertSqlCmd,"@ssCreatedBy",DbType.String,insertCreatedByList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeProposalStatusHistory (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
if(!updateProposalIdList.IsEmpty() || !updateProposalStatusIdList.IsEmpty() || !updateTimeStampList.IsEmpty() || !updateCreatedByList.IsEmpty()){
await using(var updateSqlCmd = trans.CreateCommand(updateSql)){
executionService.CreateParameter(updateSqlCmd,"@ssId",DbType.Int64,updateIdList);
executionService.CreateParameter(updateSqlCmd,"@ssProposalId",DbType.Int64,updateProposalIdList);
executionService.CreateParameter(updateSqlCmd,"@ssProposalStatusId",DbType.Int32,updateProposalStatusIdList);
executionService.CreateParameter(updateSqlCmd,"@ssTimeStamp",DbType.DateTime,updateTimeStampList);
executionService.CreateParameter(updateSqlCmd,"@ssCreatedBy",DbType.String,updateCreatedByList);
await updateSqlCmd.PrepareAsync(cancellationToken);
await updateSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeProposalStatusHistory (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(updateSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteProposalStatusHistory
/// </summary>

public static async Task DeleteProposalStatusHistory(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteProposalStatusHistory", "3c95abf9-fd12-4247-a19e-39b26f2bd62d.#DeleteEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteProposalStatusHistory", "3c95abf9-fd12-4247-a19e-39b26f2bd62d.#DeleteEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENProposalStatusHistoryEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalStatusHistoryAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteProposalStatusHistory", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllProposalStatusHistory
/// </summary>

public static async Task DeleteAllProposalStatusHistory(IRequestContext requestContext,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteAllProposalStatusHistory", "3c95abf9-fd12-4247-a19e-39b26f2bd62d.#DeleteAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllProposalStatusHistory", "3c95abf9-fd12-4247-a19e-39b26f2bd62d.#DeleteAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENProposalStatusHistoryEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteProposalStatusHistory", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetProposalStatusHistory
/// </summary>

public static async Task<RC_e6d370b8387bb43d90dc90a766ecdf20> GetProposalStatusHistory(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_e6d370b8387bb43d90dc90a766ecdf20 outParamRecord = default;
outParamRecord = new RC_e6d370b8387bb43d90dc90a766ecdf20();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetProposalStatusHistory", "3c95abf9-fd12-4247-a19e-39b26f2bd62d.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetProposalStatusHistory", "3c95abf9-fd12-4247-a19e-39b26f2bd62d.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalStatusHistoryAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalStatusHistoryAttributeKeys.@ProposalId, "proposalid") ?? "proposalid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalStatusHistoryAttributeKeys.@ProposalStatusId, "proposalstatusid") ?? "proposalstatusid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalStatusHistoryAttributeKeys.@TimeStamp, "timestamp") ?? "timestamp", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalStatusHistoryAttributeKeys.@CreatedBy, "createdby") ?? "createdby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
" FROM " + ENProposalStatusHistoryEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalStatusHistoryAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetProposalStatusHistory", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(5,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENProposalStatusHistoryEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetProposalStatusHistoryForUpdate
/// </summary>

public static async Task<RC_e6d370b8387bb43d90dc90a766ecdf20> GetProposalStatusHistoryForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_e6d370b8387bb43d90dc90a766ecdf20 outParamRecord = default;
outParamRecord = new RC_e6d370b8387bb43d90dc90a766ecdf20();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetProposalStatusHistoryForUpdate", "3c95abf9-fd12-4247-a19e-39b26f2bd62d.#GetEntityForUpdate");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetProposalStatusHistoryForUpdate", "3c95abf9-fd12-4247-a19e-39b26f2bd62d.#GetEntityForUpdate", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalStatusHistoryAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalStatusHistoryAttributeKeys.@ProposalId, "proposalid") ?? "proposalid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalStatusHistoryAttributeKeys.@ProposalStatusId, "proposalstatusid") ?? "proposalstatusid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalStatusHistoryAttributeKeys.@TimeStamp, "timestamp") ?? "timestamp", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalStatusHistoryAttributeKeys.@CreatedBy, "createdby") ?? "createdby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
" FROM " + ENProposalStatusHistoryEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalStatusHistoryAttributeKeys.@Id, "id") ?? "id") + " = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetProposalStatusHistoryForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(5,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENProposalStatusHistoryEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateProposalStatusHistory
/// </summary>

public static async Task UpdateProposalStatusHistory(IRequestContext requestContext,BitArray usedFields,RC_e6d370b8387bb43d90dc90a766ecdf20 inParamSource,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("UpdateProposalStatusHistory", "3c95abf9-fd12-4247-a19e-39b26f2bd62d.#UpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateProposalStatusHistory", "3c95abf9-fd12-4247-a19e-39b26f2bd62d.#UpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_f6d34ae04169ae9164103e8797ea11d4EntityRecord ssENProposalStatusHistory = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(5,true);
}
string updateSet = "UPDATE " + ENProposalStatusHistoryEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalStatusHistoryAttributeKeys.@ProposalId, "proposalid") ?? "proposalid") + " = @ssProposalId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalStatusHistoryAttributeKeys.@ProposalStatusId, "proposalstatusid") ?? "proposalstatusid") + " = @ssProposalStatusId"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalStatusHistoryAttributeKeys.@TimeStamp, "timestamp") ?? "timestamp") + " = @ssTimeStamp"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalStatusHistoryAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = @ssCreatedBy"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalStatusHistoryAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENProposalStatusHistory_ssId_ProposalStatusHistory";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalStatusHistoryAttributeKeys.@TimeStamp, "timestamp") ?? "timestamp") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalStatusHistoryAttributeKeys.@TimeStamp, "timestamp") ?? "timestamp") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENProposalStatusHistory.ssProposalId==0L)) {
sqlCmd.CreateParameter("@ssProposalId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssProposalId", DbType.Int64, ssENProposalStatusHistory.ssProposalId);

}
}
if(usedFields[2]) {
if ((ssENProposalStatusHistory.ssProposalStatusId==0)) {
sqlCmd.CreateParameter("@ssProposalStatusId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssProposalStatusId", DbType.Int32, ssENProposalStatusHistory.ssProposalStatusId);

}
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssTimeStamp", DbType.DateTime, ssENProposalStatusHistory.ssTimeStamp);
}
if(usedFields[4]) {
if ((ssENProposalStatusHistory.ssCreatedBy=="")) {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENProposalStatusHistory.ssCreatedBy);

}
}
sqlCmd.CreateParameter("@idparam_ssENProposalStatusHistory_ssId_ProposalStatusHistory", DbType.Int64, ssENProposalStatusHistory.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateProposalStatusHistory", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("ProposalStatusHistory", ssENProposalStatusHistory.ssId.ToString()); }}
}
return;
}

}
}
