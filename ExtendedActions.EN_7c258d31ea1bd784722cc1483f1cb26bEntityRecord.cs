using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateOrderApproval
/// </summary>

public static async Task<long> CreateOrderApproval(IRequestContext requestContext,RC_51831f8bbf408689b196be5dba3a91ea inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrderApproval", "4975f080-49cb-4941-8486-26f276a5196a.#CreateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrderApproval", "4975f080-49cb-4941-8486-26f276a5196a.#CreateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord ssENOrderApproval = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENOrderApprovalEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@OrderId, "orderid") ?? "orderid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@CurrentLevel, "currentlevel") ?? "currentlevel") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@MaxLevel, "maxlevel") ?? "maxlevel") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@StartedOn, "startedon") ?? "startedon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@FinishedOn, "finishedon") ?? "finishedon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@LastApproverPuestodelGerente, "lastapproverpuestodelgerente") ?? "lastapproverpuestodelgerente") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@LastApproverPuestodelJefe, "lastapproverpuestodeljefe") ?? "lastapproverpuestodeljefe") + "" +
" ) VALUES (" +
" @ssOrderId" +
", @ssCurrentLevel" +
", @ssMaxLevel" +
", @ssStartedOn" +
", @ssFinishedOn" +
", @ssLastApproverPuestodelGerente" +
", @ssLastApproverPuestodelJefe" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENOrderApproval.ssOrderId==0L)) {
insertSqlCmd.CreateParameter("@ssOrderId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssOrderId", DbType.Int64, ssENOrderApproval.ssOrderId);

}
insertSqlCmd.CreateParameter("@ssCurrentLevel", DbType.Int32, ssENOrderApproval.ssCurrentLevel);
insertSqlCmd.CreateParameter("@ssMaxLevel", DbType.Int32, ssENOrderApproval.ssMaxLevel);
insertSqlCmd.CreateParameter("@ssStartedOn", DbType.DateTime, ssENOrderApproval.ssStartedOn);
insertSqlCmd.CreateParameter("@ssFinishedOn", DbType.DateTime, ssENOrderApproval.ssFinishedOn);
insertSqlCmd.CreateParameter("@ssLastApproverPuestodelGerente", DbType.String, ssENOrderApproval.ssLastApproverPuestodelGerente);
insertSqlCmd.CreateParameter("@ssLastApproverPuestodelJefe", DbType.String, ssENOrderApproval.ssLastApproverPuestodelJefe);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrderApproval", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateOrderApproval
/// </summary>

public static async Task<long> CreateOrUpdateOrderApproval(IRequestContext requestContext,BitArray usedFields,RC_51831f8bbf408689b196be5dba3a91ea inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateOrderApproval", "4975f080-49cb-4941-8486-26f276a5196a.#CreateOrUpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateOrderApproval", "4975f080-49cb-4941-8486-26f276a5196a.#CreateOrUpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord ssENOrderApproval = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(8,true);
}
string updateSet = "UPDATE " + ENOrderApprovalEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@OrderId, "orderid") ?? "orderid") + " = @ssOrderId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@CurrentLevel, "currentlevel") ?? "currentlevel") + " = @ssCurrentLevel"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@MaxLevel, "maxlevel") ?? "maxlevel") + " = @ssMaxLevel"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@StartedOn, "startedon") ?? "startedon") + " = @ssStartedOn"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@FinishedOn, "finishedon") ?? "finishedon") + " = @ssFinishedOn"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@LastApproverPuestodelGerente, "lastapproverpuestodelgerente") ?? "lastapproverpuestodelgerente") + " = @ssLastApproverPuestodelGerente"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@LastApproverPuestodelJefe, "lastapproverpuestodeljefe") ?? "lastapproverpuestodeljefe") + " = @ssLastApproverPuestodelJefe"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENOrderApproval_ssId_OrderApproval";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@CurrentLevel, "currentlevel") ?? "currentlevel") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@CurrentLevel, "currentlevel") ?? "currentlevel") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENOrderApproval.ssOrderId==0L)) {
sqlCmd.CreateParameter("@ssOrderId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssOrderId", DbType.Int64, ssENOrderApproval.ssOrderId);

}
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssCurrentLevel", DbType.Int32, ssENOrderApproval.ssCurrentLevel);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssMaxLevel", DbType.Int32, ssENOrderApproval.ssMaxLevel);
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssStartedOn", DbType.DateTime, ssENOrderApproval.ssStartedOn);
}
if(usedFields[5]) {
sqlCmd.CreateParameter("@ssFinishedOn", DbType.DateTime, ssENOrderApproval.ssFinishedOn);
}
if(usedFields[6]) {
sqlCmd.CreateParameter("@ssLastApproverPuestodelGerente", DbType.String, ssENOrderApproval.ssLastApproverPuestodelGerente);
}
if(usedFields[7]) {
sqlCmd.CreateParameter("@ssLastApproverPuestodelJefe", DbType.String, ssENOrderApproval.ssLastApproverPuestodelJefe);
}
sqlCmd.CreateParameter("@idparam_ssENOrderApproval_ssId_OrderApproval", DbType.Int64, ssENOrderApproval.ssId);
int counter = 0;
if(ssENOrderApproval.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateOrderApproval (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENOrderApprovalEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@OrderId, "orderid") ?? "orderid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@CurrentLevel, "currentlevel") ?? "currentlevel") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@MaxLevel, "maxlevel") ?? "maxlevel") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@StartedOn, "startedon") ?? "startedon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@FinishedOn, "finishedon") ?? "finishedon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@LastApproverPuestodelGerente, "lastapproverpuestodelgerente") ?? "lastapproverpuestodelgerente") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@LastApproverPuestodelJefe, "lastapproverpuestodeljefe") ?? "lastapproverpuestodeljefe") + "" +
" ) VALUES (" +
" @ssOrderId" +
", @ssCurrentLevel" +
", @ssMaxLevel" +
", @ssStartedOn" +
", @ssFinishedOn" +
", @ssLastApproverPuestodelGerente" +
", @ssLastApproverPuestodelJefe" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENOrderApproval.ssOrderId==0L)) {
insertSqlCmd.CreateParameter("@ssOrderId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssOrderId", DbType.Int64, ssENOrderApproval.ssOrderId);

}
insertSqlCmd.CreateParameter("@ssCurrentLevel", DbType.Int32, ssENOrderApproval.ssCurrentLevel);
insertSqlCmd.CreateParameter("@ssMaxLevel", DbType.Int32, ssENOrderApproval.ssMaxLevel);
insertSqlCmd.CreateParameter("@ssStartedOn", DbType.DateTime, ssENOrderApproval.ssStartedOn);
insertSqlCmd.CreateParameter("@ssFinishedOn", DbType.DateTime, ssENOrderApproval.ssFinishedOn);
insertSqlCmd.CreateParameter("@ssLastApproverPuestodelGerente", DbType.String, ssENOrderApproval.ssLastApproverPuestodelGerente);
insertSqlCmd.CreateParameter("@ssLastApproverPuestodelJefe", DbType.String, ssENOrderApproval.ssLastApproverPuestodelJefe);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateOrderApproval", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENOrderApproval.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeOrderApproval
/// </summary>

public static async Task CreateOrUpdateSomeOrderApproval(IRequestContext requestContext,RL_7d3e8b1b39200784907c841002075329 inParamSourceList,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateSomeOrderApproval", "4975f080-49cb-4941-8486-26f276a5196a.#CreateOrUpdateAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeOrderApproval", "4975f080-49cb-4941-8486-26f276a5196a.#CreateOrUpdateAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
string entityTableName = ENOrderApprovalEntity.LocalViewName(null);
string insertSql = "INSERT INTO " + entityTableName + " (" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@OrderId, "orderid") ?? "orderid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@CurrentLevel, "currentlevel") ?? "currentlevel") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@MaxLevel, "maxlevel") ?? "maxlevel") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@StartedOn, "startedon") ?? "startedon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@FinishedOn, "finishedon") ?? "finishedon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@LastApproverPuestodelGerente, "lastapproverpuestodelgerente") ?? "lastapproverpuestodelgerente") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@LastApproverPuestodelJefe, "lastapproverpuestodeljefe") ?? "lastapproverpuestodeljefe") + ") VALUES ( unnest(@ssOrderId),  unnest(@ssCurrentLevel),  unnest(@ssMaxLevel),  unnest(@ssStartedOn),  unnest(@ssFinishedOn),  unnest(@ssLastApproverPuestodelGerente),  unnest(@ssLastApproverPuestodelJefe)) ";
insertSql += "";

string updateSql = "UPDATE " + entityTableName + " SET " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@OrderId, "orderid") ?? "orderid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@OrderId, "orderid") ?? "orderid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@CurrentLevel, "currentlevel") ?? "currentlevel") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@CurrentLevel, "currentlevel") ?? "currentlevel") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@MaxLevel, "maxlevel") ?? "maxlevel") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@MaxLevel, "maxlevel") ?? "maxlevel") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@StartedOn, "startedon") ?? "startedon") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@StartedOn, "startedon") ?? "startedon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@FinishedOn, "finishedon") ?? "finishedon") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@FinishedOn, "finishedon") ?? "finishedon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@LastApproverPuestodelGerente, "lastapproverpuestodelgerente") ?? "lastapproverpuestodelgerente") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@LastApproverPuestodelGerente, "lastapproverpuestodelgerente") ?? "lastapproverpuestodelgerente") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@LastApproverPuestodelJefe, "lastapproverpuestodeljefe") ?? "lastapproverpuestodeljefe") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@LastApproverPuestodelJefe, "lastapproverpuestodeljefe") ?? "lastapproverpuestodeljefe") + " from ( select  unnest(@ssId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@Id, "id") ?? "id") + ",  unnest(@ssOrderId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@OrderId, "orderid") ?? "orderid") + ",  unnest(@ssCurrentLevel) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@CurrentLevel, "currentlevel") ?? "currentlevel") + ",  unnest(@ssMaxLevel) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@MaxLevel, "maxlevel") ?? "maxlevel") + ",  unnest(@ssStartedOn) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@StartedOn, "startedon") ?? "startedon") + ",  unnest(@ssFinishedOn) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@FinishedOn, "finishedon") ?? "finishedon") + ",  unnest(@ssLastApproverPuestodelGerente) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@LastApproverPuestodelGerente, "lastapproverpuestodelgerente") ?? "lastapproverpuestodelgerente") + ",  unnest(@ssLastApproverPuestodelJefe) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@LastApproverPuestodelJefe, "lastapproverpuestodeljefe") ?? "lastapproverpuestodeljefe") + " ) as updateTable where " + entityTableName + "." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@Id, "id") ?? "id") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@Id, "id") ?? "id") + " ";
updateSql += "";

List<object> insertOrderIdList = new List<object>();
List<int> insertCurrentLevelList = new List<int>();
List<int> insertMaxLevelList = new List<int>();
List<DateTime> insertStartedOnList = new List<DateTime>();
List<DateTime> insertFinishedOnList = new List<DateTime>();
List<string> insertLastApproverPuestodelGerenteList = new List<string>();
List<string> insertLastApproverPuestodelJefeList = new List<string>();

List<long> updateIdList = new List<long>();
List<object> updateOrderIdList = new List<object>();
List<int> updateCurrentLevelList = new List<int>();
List<int> updateMaxLevelList = new List<int>();
List<DateTime> updateStartedOnList = new List<DateTime>();
List<DateTime> updateFinishedOnList = new List<DateTime>();
List<string> updateLastApproverPuestodelGerenteList = new List<string>();
List<string> updateLastApproverPuestodelJefeList = new List<string>();

var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_51831f8bbf408689b196be5dba3a91ea)inParamSourceList.Current).ssENOrderApproval;
if (record.ssId != 0L) {
updateIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
if ((record.ssOrderId==0L)) {
updateOrderIdList.Add(null);
} else {
updateOrderIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssOrderId));
}
updateCurrentLevelList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssCurrentLevel));
updateMaxLevelList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssMaxLevel));
updateStartedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssStartedOn));
updateFinishedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssFinishedOn));
updateLastApproverPuestodelGerenteList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssLastApproverPuestodelGerente));
updateLastApproverPuestodelJefeList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssLastApproverPuestodelJefe));
} else {
if ((record.ssOrderId==0L)) {
insertOrderIdList.Add(null);
} else {
insertOrderIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssOrderId));
}
insertCurrentLevelList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssCurrentLevel));
insertMaxLevelList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssMaxLevel));
insertStartedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssStartedOn));
insertFinishedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssFinishedOn));
insertLastApproverPuestodelGerenteList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssLastApproverPuestodelGerente));
insertLastApproverPuestodelJefeList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssLastApproverPuestodelJefe));
}
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertOrderIdList.IsEmpty() || !insertCurrentLevelList.IsEmpty() || !insertMaxLevelList.IsEmpty() || !insertStartedOnList.IsEmpty() || !insertFinishedOnList.IsEmpty() || !insertLastApproverPuestodelGerenteList.IsEmpty() || !insertLastApproverPuestodelJefeList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssOrderId",DbType.Int64,insertOrderIdList);
executionService.CreateParameter(insertSqlCmd,"@ssCurrentLevel",DbType.Int32,insertCurrentLevelList);
executionService.CreateParameter(insertSqlCmd,"@ssMaxLevel",DbType.Int32,insertMaxLevelList);
executionService.CreateParameter(insertSqlCmd,"@ssStartedOn",DbType.DateTime,insertStartedOnList);
executionService.CreateParameter(insertSqlCmd,"@ssFinishedOn",DbType.DateTime,insertFinishedOnList);
executionService.CreateParameter(insertSqlCmd,"@ssLastApproverPuestodelGerente",DbType.String,insertLastApproverPuestodelGerenteList);
executionService.CreateParameter(insertSqlCmd,"@ssLastApproverPuestodelJefe",DbType.String,insertLastApproverPuestodelJefeList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeOrderApproval (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
if(!updateOrderIdList.IsEmpty() || !updateCurrentLevelList.IsEmpty() || !updateMaxLevelList.IsEmpty() || !updateStartedOnList.IsEmpty() || !updateFinishedOnList.IsEmpty() || !updateLastApproverPuestodelGerenteList.IsEmpty() || !updateLastApproverPuestodelJefeList.IsEmpty()){
await using(var updateSqlCmd = trans.CreateCommand(updateSql)){
executionService.CreateParameter(updateSqlCmd,"@ssId",DbType.Int64,updateIdList);
executionService.CreateParameter(updateSqlCmd,"@ssOrderId",DbType.Int64,updateOrderIdList);
executionService.CreateParameter(updateSqlCmd,"@ssCurrentLevel",DbType.Int32,updateCurrentLevelList);
executionService.CreateParameter(updateSqlCmd,"@ssMaxLevel",DbType.Int32,updateMaxLevelList);
executionService.CreateParameter(updateSqlCmd,"@ssStartedOn",DbType.DateTime,updateStartedOnList);
executionService.CreateParameter(updateSqlCmd,"@ssFinishedOn",DbType.DateTime,updateFinishedOnList);
executionService.CreateParameter(updateSqlCmd,"@ssLastApproverPuestodelGerente",DbType.String,updateLastApproverPuestodelGerenteList);
executionService.CreateParameter(updateSqlCmd,"@ssLastApproverPuestodelJefe",DbType.String,updateLastApproverPuestodelJefeList);
await updateSqlCmd.PrepareAsync(cancellationToken);
await updateSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeOrderApproval (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(updateSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteOrderApproval
/// </summary>

public static async Task DeleteOrderApproval(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteOrderApproval", "4975f080-49cb-4941-8486-26f276a5196a.#DeleteEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteOrderApproval", "4975f080-49cb-4941-8486-26f276a5196a.#DeleteEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENOrderApprovalEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteOrderApproval", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllOrderApproval
/// </summary>

public static async Task DeleteAllOrderApproval(IRequestContext requestContext,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteAllOrderApproval", "4975f080-49cb-4941-8486-26f276a5196a.#DeleteAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllOrderApproval", "4975f080-49cb-4941-8486-26f276a5196a.#DeleteAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENOrderApprovalEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteOrderApproval", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetOrderApproval
/// </summary>

public static async Task<RC_51831f8bbf408689b196be5dba3a91ea> GetOrderApproval(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_51831f8bbf408689b196be5dba3a91ea outParamRecord = default;
outParamRecord = new RC_51831f8bbf408689b196be5dba3a91ea();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetOrderApproval", "4975f080-49cb-4941-8486-26f276a5196a.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetOrderApproval", "4975f080-49cb-4941-8486-26f276a5196a.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@OrderId, "orderid") ?? "orderid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@CurrentLevel, "currentlevel") ?? "currentlevel", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@MaxLevel, "maxlevel") ?? "maxlevel", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@StartedOn, "startedon") ?? "startedon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@FinishedOn, "finishedon") ?? "finishedon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@LastApproverPuestodelGerente, "lastapproverpuestodelgerente") ?? "lastapproverpuestodelgerente", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@LastApproverPuestodelJefe, "lastapproverpuestodeljefe") ?? "lastapproverpuestodeljefe", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
" FROM " + ENOrderApprovalEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetOrderApproval", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(8,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENOrderApprovalEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetOrderApprovalForUpdate
/// </summary>

public static async Task<RC_51831f8bbf408689b196be5dba3a91ea> GetOrderApprovalForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_51831f8bbf408689b196be5dba3a91ea outParamRecord = default;
outParamRecord = new RC_51831f8bbf408689b196be5dba3a91ea();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetOrderApprovalForUpdate", "4975f080-49cb-4941-8486-26f276a5196a.#GetEntityForUpdate");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetOrderApprovalForUpdate", "4975f080-49cb-4941-8486-26f276a5196a.#GetEntityForUpdate", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@OrderId, "orderid") ?? "orderid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@CurrentLevel, "currentlevel") ?? "currentlevel", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@MaxLevel, "maxlevel") ?? "maxlevel", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@StartedOn, "startedon") ?? "startedon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@FinishedOn, "finishedon") ?? "finishedon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@LastApproverPuestodelGerente, "lastapproverpuestodelgerente") ?? "lastapproverpuestodelgerente", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@LastApproverPuestodelJefe, "lastapproverpuestodeljefe") ?? "lastapproverpuestodeljefe", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
" FROM " + ENOrderApprovalEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@Id, "id") ?? "id") + " = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetOrderApprovalForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(8,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENOrderApprovalEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateOrderApproval
/// </summary>

public static async Task UpdateOrderApproval(IRequestContext requestContext,BitArray usedFields,RC_51831f8bbf408689b196be5dba3a91ea inParamSource,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("UpdateOrderApproval", "4975f080-49cb-4941-8486-26f276a5196a.#UpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateOrderApproval", "4975f080-49cb-4941-8486-26f276a5196a.#UpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord ssENOrderApproval = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(8,true);
}
string updateSet = "UPDATE " + ENOrderApprovalEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@OrderId, "orderid") ?? "orderid") + " = @ssOrderId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@CurrentLevel, "currentlevel") ?? "currentlevel") + " = @ssCurrentLevel"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@MaxLevel, "maxlevel") ?? "maxlevel") + " = @ssMaxLevel"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@StartedOn, "startedon") ?? "startedon") + " = @ssStartedOn"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@FinishedOn, "finishedon") ?? "finishedon") + " = @ssFinishedOn"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@LastApproverPuestodelGerente, "lastapproverpuestodelgerente") ?? "lastapproverpuestodelgerente") + " = @ssLastApproverPuestodelGerente"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@LastApproverPuestodelJefe, "lastapproverpuestodeljefe") ?? "lastapproverpuestodeljefe") + " = @ssLastApproverPuestodelJefe"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENOrderApproval_ssId_OrderApproval";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@CurrentLevel, "currentlevel") ?? "currentlevel") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@CurrentLevel, "currentlevel") ?? "currentlevel") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENOrderApproval.ssOrderId==0L)) {
sqlCmd.CreateParameter("@ssOrderId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssOrderId", DbType.Int64, ssENOrderApproval.ssOrderId);

}
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssCurrentLevel", DbType.Int32, ssENOrderApproval.ssCurrentLevel);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssMaxLevel", DbType.Int32, ssENOrderApproval.ssMaxLevel);
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssStartedOn", DbType.DateTime, ssENOrderApproval.ssStartedOn);
}
if(usedFields[5]) {
sqlCmd.CreateParameter("@ssFinishedOn", DbType.DateTime, ssENOrderApproval.ssFinishedOn);
}
if(usedFields[6]) {
sqlCmd.CreateParameter("@ssLastApproverPuestodelGerente", DbType.String, ssENOrderApproval.ssLastApproverPuestodelGerente);
}
if(usedFields[7]) {
sqlCmd.CreateParameter("@ssLastApproverPuestodelJefe", DbType.String, ssENOrderApproval.ssLastApproverPuestodelJefe);
}
sqlCmd.CreateParameter("@idparam_ssENOrderApproval_ssId_OrderApproval", DbType.Int64, ssENOrderApproval.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateOrderApproval", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("OrderApproval", ssENOrderApproval.ssId.ToString()); }}
}
return;
}

}
}
