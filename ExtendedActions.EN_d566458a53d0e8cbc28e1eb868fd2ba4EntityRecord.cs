using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateRequisitionStatusHistory
/// </summary>

public static async Task<long> CreateRequisitionStatusHistory(IRequestContext requestContext,RC_aa9fab59faf7c7de355dae43478ba7e5 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateRequisitionStatusHistory", "2c84790e-ca77-4a56-a332-02068858c4de.#CreateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateRequisitionStatusHistory", "2c84790e-ca77-4a56-a332-02068858c4de.#CreateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_d566458a53d0e8cbc28e1eb868fd2ba4EntityRecord ssENRequisitionStatusHistory = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENRequisitionStatusHistoryEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionStatusHistoryAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionStatusHistoryAttributeKeys.@RequisitionStatusId, "requisitionstatusid") ?? "requisitionstatusid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionStatusHistoryAttributeKeys.@TimeStamp, "timestamp") ?? "timestamp") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionStatusHistoryAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + "" +
" ) VALUES (" +
" @ssRequisitionId" +
", @ssRequisitionStatusId" +
", @ssTimeStamp" +
", @ssCreatedBy" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENRequisitionStatusHistory.ssRequisitionId==0L)) {
insertSqlCmd.CreateParameter("@ssRequisitionId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssRequisitionId", DbType.Int64, ssENRequisitionStatusHistory.ssRequisitionId);

}
if ((ssENRequisitionStatusHistory.ssRequisitionStatusId==0)) {
insertSqlCmd.CreateParameter("@ssRequisitionStatusId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssRequisitionStatusId", DbType.Int32, ssENRequisitionStatusHistory.ssRequisitionStatusId);

}
insertSqlCmd.CreateParameter("@ssTimeStamp", DbType.DateTime, ssENRequisitionStatusHistory.ssTimeStamp);
if ((ssENRequisitionStatusHistory.ssCreatedBy=="")) {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENRequisitionStatusHistory.ssCreatedBy);

}
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateRequisitionStatusHistory", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateRequisitionStatusHistory
/// </summary>

public static async Task<long> CreateOrUpdateRequisitionStatusHistory(IRequestContext requestContext,BitArray usedFields,RC_aa9fab59faf7c7de355dae43478ba7e5 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateRequisitionStatusHistory", "2c84790e-ca77-4a56-a332-02068858c4de.#CreateOrUpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateRequisitionStatusHistory", "2c84790e-ca77-4a56-a332-02068858c4de.#CreateOrUpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_d566458a53d0e8cbc28e1eb868fd2ba4EntityRecord ssENRequisitionStatusHistory = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(5,true);
}
string updateSet = "UPDATE " + ENRequisitionStatusHistoryEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionStatusHistoryAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid") + " = @ssRequisitionId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionStatusHistoryAttributeKeys.@RequisitionStatusId, "requisitionstatusid") ?? "requisitionstatusid") + " = @ssRequisitionStatusId"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionStatusHistoryAttributeKeys.@TimeStamp, "timestamp") ?? "timestamp") + " = @ssTimeStamp"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionStatusHistoryAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = @ssCreatedBy"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionStatusHistoryAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENRequisitioStatusHistory_ssd_RequisitionSatusHistory";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionStatusHistoryAttributeKeys.@TimeStamp, "timestamp") ?? "timestamp") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionStatusHistoryAttributeKeys.@TimeStamp, "timestamp") ?? "timestamp") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENRequisitionStatusHistory.ssRequisitionId==0L)) {
sqlCmd.CreateParameter("@ssRequisitionId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssRequisitionId", DbType.Int64, ssENRequisitionStatusHistory.ssRequisitionId);

}
}
if(usedFields[2]) {
if ((ssENRequisitionStatusHistory.ssRequisitionStatusId==0)) {
sqlCmd.CreateParameter("@ssRequisitionStatusId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssRequisitionStatusId", DbType.Int32, ssENRequisitionStatusHistory.ssRequisitionStatusId);

}
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssTimeStamp", DbType.DateTime, ssENRequisitionStatusHistory.ssTimeStamp);
}
if(usedFields[4]) {
if ((ssENRequisitionStatusHistory.ssCreatedBy=="")) {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENRequisitionStatusHistory.ssCreatedBy);

}
}
sqlCmd.CreateParameter("@idparam_ssENRequisitioStatusHistory_ssd_RequisitionSatusHistory", DbType.Int64, ssENRequisitionStatusHistory.ssId);
int counter = 0;
if(ssENRequisitionStatusHistory.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateRequisitionStatusHistory (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENRequisitionStatusHistoryEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionStatusHistoryAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionStatusHistoryAttributeKeys.@RequisitionStatusId, "requisitionstatusid") ?? "requisitionstatusid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionStatusHistoryAttributeKeys.@TimeStamp, "timestamp") ?? "timestamp") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionStatusHistoryAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + "" +
" ) VALUES (" +
" @ssRequisitionId" +
", @ssRequisitionStatusId" +
", @ssTimeStamp" +
", @ssCreatedBy" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENRequisitionStatusHistory.ssRequisitionId==0L)) {
insertSqlCmd.CreateParameter("@ssRequisitionId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssRequisitionId", DbType.Int64, ssENRequisitionStatusHistory.ssRequisitionId);

}
if ((ssENRequisitionStatusHistory.ssRequisitionStatusId==0)) {
insertSqlCmd.CreateParameter("@ssRequisitionStatusId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssRequisitionStatusId", DbType.Int32, ssENRequisitionStatusHistory.ssRequisitionStatusId);

}
insertSqlCmd.CreateParameter("@ssTimeStamp", DbType.DateTime, ssENRequisitionStatusHistory.ssTimeStamp);
if ((ssENRequisitionStatusHistory.ssCreatedBy=="")) {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENRequisitionStatusHistory.ssCreatedBy);

}
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateRequisitionStatusHistory", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENRequisitionStatusHistory.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeRequisitionStatusHistory
/// </summary>

public static async Task CreateOrUpdateSomeRequisitionStatusHistory(IRequestContext requestContext,RL_40212690d01342e9b25b0ac7249068cf inParamSourceList,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateSomeRequisitionStatusHistory", "2c84790e-ca77-4a56-a332-02068858c4de.#CreateOrUpdateAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeRequisitionStatusHistory", "2c84790e-ca77-4a56-a332-02068858c4de.#CreateOrUpdateAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
string entityTableName = ENRequisitionStatusHistoryEntity.LocalViewName(null);
string insertSql = "INSERT INTO " + entityTableName + " (" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionStatusHistoryAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionStatusHistoryAttributeKeys.@RequisitionStatusId, "requisitionstatusid") ?? "requisitionstatusid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionStatusHistoryAttributeKeys.@TimeStamp, "timestamp") ?? "timestamp") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionStatusHistoryAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + ") VALUES ( unnest(@ssRequisitionId),  unnest(@ssRequisitionStatusId),  unnest(@ssTimeStamp),  unnest(@ssCreatedBy)) ";
insertSql += "";

string updateSql = "UPDATE " + entityTableName + " SET " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionStatusHistoryAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionStatusHistoryAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionStatusHistoryAttributeKeys.@RequisitionStatusId, "requisitionstatusid") ?? "requisitionstatusid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionStatusHistoryAttributeKeys.@RequisitionStatusId, "requisitionstatusid") ?? "requisitionstatusid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionStatusHistoryAttributeKeys.@TimeStamp, "timestamp") ?? "timestamp") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionStatusHistoryAttributeKeys.@TimeStamp, "timestamp") ?? "timestamp") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionStatusHistoryAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionStatusHistoryAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " from ( select  unnest(@ssId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionStatusHistoryAttributeKeys.@Id, "id") ?? "id") + ",  unnest(@ssRequisitionId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionStatusHistoryAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid") + ",  unnest(@ssRequisitionStatusId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionStatusHistoryAttributeKeys.@RequisitionStatusId, "requisitionstatusid") ?? "requisitionstatusid") + ",  unnest(@ssTimeStamp) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionStatusHistoryAttributeKeys.@TimeStamp, "timestamp") ?? "timestamp") + ",  unnest(@ssCreatedBy) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionStatusHistoryAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " ) as updateTable where " + entityTableName + "." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionStatusHistoryAttributeKeys.@Id, "id") ?? "id") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionStatusHistoryAttributeKeys.@Id, "id") ?? "id") + " ";
updateSql += "";

List<object> insertRequisitionIdList = new List<object>();
List<object> insertRequisitionStatusIdList = new List<object>();
List<DateTime> insertTimeStampList = new List<DateTime>();
List<object> insertCreatedByList = new List<object>();

List<long> updateIdList = new List<long>();
List<object> updateRequisitionIdList = new List<object>();
List<object> updateRequisitionStatusIdList = new List<object>();
List<DateTime> updateTimeStampList = new List<DateTime>();
List<object> updateCreatedByList = new List<object>();

var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_aa9fab59faf7c7de355dae43478ba7e5)inParamSourceList.Current).ssENRequisitionStatusHistory;
if (record.ssId != 0L) {
updateIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
if ((record.ssRequisitionId==0L)) {
updateRequisitionIdList.Add(null);
} else {
updateRequisitionIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssRequisitionId));
}
if ((record.ssRequisitionStatusId==0)) {
updateRequisitionStatusIdList.Add(null);
} else {
updateRequisitionStatusIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssRequisitionStatusId));
}
updateTimeStampList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssTimeStamp));
if ((record.ssCreatedBy=="")) {
updateCreatedByList.Add(null);
} else {
updateCreatedByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssCreatedBy));
}
} else {
if ((record.ssRequisitionId==0L)) {
insertRequisitionIdList.Add(null);
} else {
insertRequisitionIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssRequisitionId));
}
if ((record.ssRequisitionStatusId==0)) {
insertRequisitionStatusIdList.Add(null);
} else {
insertRequisitionStatusIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssRequisitionStatusId));
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
if (!insertRequisitionIdList.IsEmpty() || !insertRequisitionStatusIdList.IsEmpty() || !insertTimeStampList.IsEmpty() || !insertCreatedByList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssRequisitionId",DbType.Int64,insertRequisitionIdList);
executionService.CreateParameter(insertSqlCmd,"@ssRequisitionStatusId",DbType.Int32,insertRequisitionStatusIdList);
executionService.CreateParameter(insertSqlCmd,"@ssTimeStamp",DbType.DateTime,insertTimeStampList);
executionService.CreateParameter(insertSqlCmd,"@ssCreatedBy",DbType.String,insertCreatedByList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeRequisitionStatusHistory (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
if(!updateRequisitionIdList.IsEmpty() || !updateRequisitionStatusIdList.IsEmpty() || !updateTimeStampList.IsEmpty() || !updateCreatedByList.IsEmpty()){
await using(var updateSqlCmd = trans.CreateCommand(updateSql)){
executionService.CreateParameter(updateSqlCmd,"@ssId",DbType.Int64,updateIdList);
executionService.CreateParameter(updateSqlCmd,"@ssRequisitionId",DbType.Int64,updateRequisitionIdList);
executionService.CreateParameter(updateSqlCmd,"@ssRequisitionStatusId",DbType.Int32,updateRequisitionStatusIdList);
executionService.CreateParameter(updateSqlCmd,"@ssTimeStamp",DbType.DateTime,updateTimeStampList);
executionService.CreateParameter(updateSqlCmd,"@ssCreatedBy",DbType.String,updateCreatedByList);
await updateSqlCmd.PrepareAsync(cancellationToken);
await updateSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeRequisitionStatusHistory (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(updateSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteRequisitionStatusHistory
/// </summary>

public static async Task DeleteRequisitionStatusHistory(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteRequisitionStatusHistory", "2c84790e-ca77-4a56-a332-02068858c4de.#DeleteEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteRequisitionStatusHistory", "2c84790e-ca77-4a56-a332-02068858c4de.#DeleteEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENRequisitionStatusHistoryEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionStatusHistoryAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteRequisitionStatusHistory", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllRequisitionStatusHistory
/// </summary>

public static async Task DeleteAllRequisitionStatusHistory(IRequestContext requestContext,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteAllRequisitionStatusHistory", "2c84790e-ca77-4a56-a332-02068858c4de.#DeleteAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllRequisitionStatusHistory", "2c84790e-ca77-4a56-a332-02068858c4de.#DeleteAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENRequisitionStatusHistoryEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteRequisitionStatusHistory", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetRequisitionStatusHistory
/// </summary>

public static async Task<RC_aa9fab59faf7c7de355dae43478ba7e5> GetRequisitionStatusHistory(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_aa9fab59faf7c7de355dae43478ba7e5 outParamRecord = default;
outParamRecord = new RC_aa9fab59faf7c7de355dae43478ba7e5();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetRequisitionStatusHistory", "2c84790e-ca77-4a56-a332-02068858c4de.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetRequisitionStatusHistory", "2c84790e-ca77-4a56-a332-02068858c4de.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionStatusHistoryAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionStatusHistoryAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionStatusHistoryAttributeKeys.@RequisitionStatusId, "requisitionstatusid") ?? "requisitionstatusid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionStatusHistoryAttributeKeys.@TimeStamp, "timestamp") ?? "timestamp", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionStatusHistoryAttributeKeys.@CreatedBy, "createdby") ?? "createdby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
" FROM " + ENRequisitionStatusHistoryEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionStatusHistoryAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetRequisitionStatusHistory", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(5,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENRequisitionStatusHistoryEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetRequisitionStatusHistoryForUpdate
/// </summary>

public static async Task<RC_aa9fab59faf7c7de355dae43478ba7e5> GetRequisitionStatusHistoryForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_aa9fab59faf7c7de355dae43478ba7e5 outParamRecord = default;
outParamRecord = new RC_aa9fab59faf7c7de355dae43478ba7e5();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetRequisitionStatusHistoryForUpdate", "2c84790e-ca77-4a56-a332-02068858c4de.#GetEntityForUpdate");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetRequisitionStatusHistoryForUpdate", "2c84790e-ca77-4a56-a332-02068858c4de.#GetEntityForUpdate", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionStatusHistoryAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionStatusHistoryAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionStatusHistoryAttributeKeys.@RequisitionStatusId, "requisitionstatusid") ?? "requisitionstatusid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionStatusHistoryAttributeKeys.@TimeStamp, "timestamp") ?? "timestamp", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionStatusHistoryAttributeKeys.@CreatedBy, "createdby") ?? "createdby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
" FROM " + ENRequisitionStatusHistoryEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionStatusHistoryAttributeKeys.@Id, "id") ?? "id") + " = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetRequisitionStatusHistoryForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(5,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENRequisitionStatusHistoryEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateRequisitionStatusHistory
/// </summary>

public static async Task UpdateRequisitionStatusHistory(IRequestContext requestContext,BitArray usedFields,RC_aa9fab59faf7c7de355dae43478ba7e5 inParamSource,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("UpdateRequisitionStatusHistory", "2c84790e-ca77-4a56-a332-02068858c4de.#UpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateRequisitionStatusHistory", "2c84790e-ca77-4a56-a332-02068858c4de.#UpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_d566458a53d0e8cbc28e1eb868fd2ba4EntityRecord ssENRequisitionStatusHistory = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(5,true);
}
string updateSet = "UPDATE " + ENRequisitionStatusHistoryEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionStatusHistoryAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid") + " = @ssRequisitionId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionStatusHistoryAttributeKeys.@RequisitionStatusId, "requisitionstatusid") ?? "requisitionstatusid") + " = @ssRequisitionStatusId"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionStatusHistoryAttributeKeys.@TimeStamp, "timestamp") ?? "timestamp") + " = @ssTimeStamp"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionStatusHistoryAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = @ssCreatedBy"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionStatusHistoryAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENRequisitioStatusHistory_ssd_RequisitionSatusHistory";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionStatusHistoryAttributeKeys.@TimeStamp, "timestamp") ?? "timestamp") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionStatusHistoryAttributeKeys.@TimeStamp, "timestamp") ?? "timestamp") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENRequisitionStatusHistory.ssRequisitionId==0L)) {
sqlCmd.CreateParameter("@ssRequisitionId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssRequisitionId", DbType.Int64, ssENRequisitionStatusHistory.ssRequisitionId);

}
}
if(usedFields[2]) {
if ((ssENRequisitionStatusHistory.ssRequisitionStatusId==0)) {
sqlCmd.CreateParameter("@ssRequisitionStatusId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssRequisitionStatusId", DbType.Int32, ssENRequisitionStatusHistory.ssRequisitionStatusId);

}
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssTimeStamp", DbType.DateTime, ssENRequisitionStatusHistory.ssTimeStamp);
}
if(usedFields[4]) {
if ((ssENRequisitionStatusHistory.ssCreatedBy=="")) {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENRequisitionStatusHistory.ssCreatedBy);

}
}
sqlCmd.CreateParameter("@idparam_ssENRequisitioStatusHistory_ssd_RequisitionSatusHistory", DbType.Int64, ssENRequisitionStatusHistory.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateRequisitionStatusHistory", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("RequisitionStatusHistory", ssENRequisitionStatusHistory.ssId.ToString()); }}
}
return;
}

}
}
