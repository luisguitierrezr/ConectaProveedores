using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateRequisitionCostCenter
/// </summary>

public static async Task<long> CreateRequisitionCostCenter(IRequestContext requestContext,RC_508355980a3676af946819914b6b1546 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateRequisitionCostCenter", "d8868f91-7269-4fe1-a586-98a11930a354.#CreateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateRequisitionCostCenter", "d8868f91-7269-4fe1-a586-98a11930a354.#CreateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_114fcf95674648310a3efb0d78529a37EntityRecord ssENRequisitionCostCenter = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENRequisitionCostCenterEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionCostCenter, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCostCenterAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionCostCenter, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCostCenterAttributeKeys.@CostcenterSAP, "costcentersap") ?? "costcentersap") + "" +
" ) VALUES (" +
" @ssRequisitionId" +
", @ssCostcenterSAP" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENRequisitionCostCenter.ssRequisitionId==0L)) {
insertSqlCmd.CreateParameter("@ssRequisitionId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssRequisitionId", DbType.Int64, ssENRequisitionCostCenter.ssRequisitionId);

}
if ((ssENRequisitionCostCenter.ssCostcenterSAP==0L)) {
insertSqlCmd.CreateParameter("@ssCostcenterSAP", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCostcenterSAP", DbType.Int64, ssENRequisitionCostCenter.ssCostcenterSAP);

}
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateRequisitionCostCenter", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateRequisitionCostCenter
/// </summary>

public static async Task<long> CreateOrUpdateRequisitionCostCenter(IRequestContext requestContext,BitArray usedFields,RC_508355980a3676af946819914b6b1546 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateRequisitionCostCenter", "d8868f91-7269-4fe1-a586-98a11930a354.#CreateOrUpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateRequisitionCostCenter", "d8868f91-7269-4fe1-a586-98a11930a354.#CreateOrUpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_114fcf95674648310a3efb0d78529a37EntityRecord ssENRequisitionCostCenter = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(3,true);
}
string updateSet = "UPDATE " + ENRequisitionCostCenterEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionCostCenter, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCostCenterAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid") + " = @ssRequisitionId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionCostCenter, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCostCenterAttributeKeys.@CostcenterSAP, "costcentersap") ?? "costcentersap") + " = @ssCostcenterSAP"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionCostCenter, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCostCenterAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENRequisitionCostCenter_ssId_RequisitionCostCenter";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionCostCenter, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCostCenterAttributeKeys.@CostcenterSAP, "costcentersap") ?? "costcentersap") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionCostCenter, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCostCenterAttributeKeys.@CostcenterSAP, "costcentersap") ?? "costcentersap") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENRequisitionCostCenter.ssRequisitionId==0L)) {
sqlCmd.CreateParameter("@ssRequisitionId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssRequisitionId", DbType.Int64, ssENRequisitionCostCenter.ssRequisitionId);

}
}
if(usedFields[2]) {
if ((ssENRequisitionCostCenter.ssCostcenterSAP==0L)) {
sqlCmd.CreateParameter("@ssCostcenterSAP", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCostcenterSAP", DbType.Int64, ssENRequisitionCostCenter.ssCostcenterSAP);

}
}
sqlCmd.CreateParameter("@idparam_ssENRequisitionCostCenter_ssId_RequisitionCostCenter", DbType.Int64, ssENRequisitionCostCenter.ssId);
int counter = 0;
if(ssENRequisitionCostCenter.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateRequisitionCostCenter (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENRequisitionCostCenterEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionCostCenter, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCostCenterAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionCostCenter, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCostCenterAttributeKeys.@CostcenterSAP, "costcentersap") ?? "costcentersap") + "" +
" ) VALUES (" +
" @ssRequisitionId" +
", @ssCostcenterSAP" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENRequisitionCostCenter.ssRequisitionId==0L)) {
insertSqlCmd.CreateParameter("@ssRequisitionId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssRequisitionId", DbType.Int64, ssENRequisitionCostCenter.ssRequisitionId);

}
if ((ssENRequisitionCostCenter.ssCostcenterSAP==0L)) {
insertSqlCmd.CreateParameter("@ssCostcenterSAP", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCostcenterSAP", DbType.Int64, ssENRequisitionCostCenter.ssCostcenterSAP);

}
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateRequisitionCostCenter", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENRequisitionCostCenter.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeRequisitionCostCenter
/// </summary>

public static async Task CreateOrUpdateSomeRequisitionCostCenter(IRequestContext requestContext,RL_d3e0bac8462c62ccd7f8cc475394c310 inParamSourceList,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateSomeRequisitionCostCenter", "d8868f91-7269-4fe1-a586-98a11930a354.#CreateOrUpdateAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeRequisitionCostCenter", "d8868f91-7269-4fe1-a586-98a11930a354.#CreateOrUpdateAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
string entityTableName = ENRequisitionCostCenterEntity.LocalViewName(null);
string insertSql = "INSERT INTO " + entityTableName + " (" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionCostCenter, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCostCenterAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionCostCenter, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCostCenterAttributeKeys.@CostcenterSAP, "costcentersap") ?? "costcentersap") + ") VALUES ( unnest(@ssRequisitionId),  unnest(@ssCostcenterSAP)) ";
insertSql += "";

string updateSql = "UPDATE " + entityTableName + " SET " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionCostCenter, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCostCenterAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionCostCenter, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCostCenterAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionCostCenter, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCostCenterAttributeKeys.@CostcenterSAP, "costcentersap") ?? "costcentersap") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionCostCenter, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCostCenterAttributeKeys.@CostcenterSAP, "costcentersap") ?? "costcentersap") + " from ( select  unnest(@ssId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionCostCenter, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCostCenterAttributeKeys.@Id, "id") ?? "id") + ",  unnest(@ssRequisitionId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionCostCenter, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCostCenterAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid") + ",  unnest(@ssCostcenterSAP) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionCostCenter, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCostCenterAttributeKeys.@CostcenterSAP, "costcentersap") ?? "costcentersap") + " ) as updateTable where " + entityTableName + "." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionCostCenter, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCostCenterAttributeKeys.@Id, "id") ?? "id") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionCostCenter, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCostCenterAttributeKeys.@Id, "id") ?? "id") + " ";
updateSql += "";

List<object> insertRequisitionIdList = new List<object>();
List<object> insertCostcenterSAPList = new List<object>();

List<long> updateIdList = new List<long>();
List<object> updateRequisitionIdList = new List<object>();
List<object> updateCostcenterSAPList = new List<object>();

var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_508355980a3676af946819914b6b1546)inParamSourceList.Current).ssENRequisitionCostCenter;
if (record.ssId != 0L) {
updateIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
if ((record.ssRequisitionId==0L)) {
updateRequisitionIdList.Add(null);
} else {
updateRequisitionIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssRequisitionId));
}
if ((record.ssCostcenterSAP==0L)) {
updateCostcenterSAPList.Add(null);
} else {
updateCostcenterSAPList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssCostcenterSAP));
}
} else {
if ((record.ssRequisitionId==0L)) {
insertRequisitionIdList.Add(null);
} else {
insertRequisitionIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssRequisitionId));
}
if ((record.ssCostcenterSAP==0L)) {
insertCostcenterSAPList.Add(null);
} else {
insertCostcenterSAPList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssCostcenterSAP));
}
}
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertRequisitionIdList.IsEmpty() || !insertCostcenterSAPList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssRequisitionId",DbType.Int64,insertRequisitionIdList);
executionService.CreateParameter(insertSqlCmd,"@ssCostcenterSAP",DbType.Int64,insertCostcenterSAPList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeRequisitionCostCenter (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
if(!updateRequisitionIdList.IsEmpty() || !updateCostcenterSAPList.IsEmpty()){
await using(var updateSqlCmd = trans.CreateCommand(updateSql)){
executionService.CreateParameter(updateSqlCmd,"@ssId",DbType.Int64,updateIdList);
executionService.CreateParameter(updateSqlCmd,"@ssRequisitionId",DbType.Int64,updateRequisitionIdList);
executionService.CreateParameter(updateSqlCmd,"@ssCostcenterSAP",DbType.Int64,updateCostcenterSAPList);
await updateSqlCmd.PrepareAsync(cancellationToken);
await updateSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeRequisitionCostCenter (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(updateSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteRequisitionCostCenter
/// </summary>

public static async Task DeleteRequisitionCostCenter(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteRequisitionCostCenter", "d8868f91-7269-4fe1-a586-98a11930a354.#DeleteEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteRequisitionCostCenter", "d8868f91-7269-4fe1-a586-98a11930a354.#DeleteEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENRequisitionCostCenterEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionCostCenter, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCostCenterAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteRequisitionCostCenter", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllRequisitionCostCenter
/// </summary>

public static async Task DeleteAllRequisitionCostCenter(IRequestContext requestContext,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteAllRequisitionCostCenter", "d8868f91-7269-4fe1-a586-98a11930a354.#DeleteAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllRequisitionCostCenter", "d8868f91-7269-4fe1-a586-98a11930a354.#DeleteAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENRequisitionCostCenterEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteRequisitionCostCenter", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetRequisitionCostCenter
/// </summary>

public static async Task<RC_508355980a3676af946819914b6b1546> GetRequisitionCostCenter(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_508355980a3676af946819914b6b1546 outParamRecord = default;
outParamRecord = new RC_508355980a3676af946819914b6b1546();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetRequisitionCostCenter", "d8868f91-7269-4fe1-a586-98a11930a354.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetRequisitionCostCenter", "d8868f91-7269-4fe1-a586-98a11930a354.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionCostCenter, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCostCenterAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionCostCenter, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCostCenterAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionCostCenter, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCostCenterAttributeKeys.@CostcenterSAP, "costcentersap") ?? "costcentersap", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
" FROM " + ENRequisitionCostCenterEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionCostCenter, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCostCenterAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetRequisitionCostCenter", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(3,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENRequisitionCostCenterEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetRequisitionCostCenterForUpdate
/// </summary>

public static async Task<RC_508355980a3676af946819914b6b1546> GetRequisitionCostCenterForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_508355980a3676af946819914b6b1546 outParamRecord = default;
outParamRecord = new RC_508355980a3676af946819914b6b1546();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetRequisitionCostCenterForUpdate", "d8868f91-7269-4fe1-a586-98a11930a354.#GetEntityForUpdate");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetRequisitionCostCenterForUpdate", "d8868f91-7269-4fe1-a586-98a11930a354.#GetEntityForUpdate", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionCostCenter, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCostCenterAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionCostCenter, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCostCenterAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionCostCenter, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCostCenterAttributeKeys.@CostcenterSAP, "costcentersap") ?? "costcentersap", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
" FROM " + ENRequisitionCostCenterEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionCostCenter, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCostCenterAttributeKeys.@Id, "id") ?? "id") + " = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetRequisitionCostCenterForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(3,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENRequisitionCostCenterEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateRequisitionCostCenter
/// </summary>

public static async Task UpdateRequisitionCostCenter(IRequestContext requestContext,BitArray usedFields,RC_508355980a3676af946819914b6b1546 inParamSource,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("UpdateRequisitionCostCenter", "d8868f91-7269-4fe1-a586-98a11930a354.#UpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateRequisitionCostCenter", "d8868f91-7269-4fe1-a586-98a11930a354.#UpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_114fcf95674648310a3efb0d78529a37EntityRecord ssENRequisitionCostCenter = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(3,true);
}
string updateSet = "UPDATE " + ENRequisitionCostCenterEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionCostCenter, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCostCenterAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid") + " = @ssRequisitionId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionCostCenter, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCostCenterAttributeKeys.@CostcenterSAP, "costcentersap") ?? "costcentersap") + " = @ssCostcenterSAP"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionCostCenter, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCostCenterAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENRequisitionCostCenter_ssId_RequisitionCostCenter";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionCostCenter, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCostCenterAttributeKeys.@CostcenterSAP, "costcentersap") ?? "costcentersap") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionCostCenter, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCostCenterAttributeKeys.@CostcenterSAP, "costcentersap") ?? "costcentersap") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENRequisitionCostCenter.ssRequisitionId==0L)) {
sqlCmd.CreateParameter("@ssRequisitionId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssRequisitionId", DbType.Int64, ssENRequisitionCostCenter.ssRequisitionId);

}
}
if(usedFields[2]) {
if ((ssENRequisitionCostCenter.ssCostcenterSAP==0L)) {
sqlCmd.CreateParameter("@ssCostcenterSAP", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCostcenterSAP", DbType.Int64, ssENRequisitionCostCenter.ssCostcenterSAP);

}
}
sqlCmd.CreateParameter("@idparam_ssENRequisitionCostCenter_ssId_RequisitionCostCenter", DbType.Int64, ssENRequisitionCostCenter.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateRequisitionCostCenter", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("RequisitionCostCenter", ssENRequisitionCostCenter.ssId.ToString()); }}
}
return;
}

}
}
