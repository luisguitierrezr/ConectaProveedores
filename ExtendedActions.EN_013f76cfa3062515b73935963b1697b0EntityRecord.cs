using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateProposalLogs
/// </summary>

public static async Task<long> CreateProposalLogs(IRequestContext requestContext,RC_42d297db5356ec5acb8465e0977849c0 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateProposalLogs", "1a3baa6f-e5aa-4d07-af97-ed583a363d6d.#CreateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateProposalLogs", "1a3baa6f-e5aa-4d07-af97-ed583a363d6d.#CreateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_013f76cfa3062515b73935963b1697b0EntityRecord ssENProposalLogs = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENProposalLogsEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLogsAttributeKeys.@ProposalId, "proposalid") ?? "proposalid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLogsAttributeKeys.@ProposalLineId, "proposallineid") ?? "proposallineid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLogsAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLogsAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLogsAttributeKeys.@Message, "message") ?? "message") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLogsAttributeKeys.@IsError, "iserror") ?? "iserror") + "" +
" ) VALUES (" +
" @ssProposalId" +
", @ssProposalLineId" +
", @ssCreatedBy" +
", @ssCreatedOn" +
", @ssMessage" +
", @ssIsError" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssProposalId", DbType.Int64, ssENProposalLogs.ssProposalId);
if ((ssENProposalLogs.ssProposalLineId==0L)) {
insertSqlCmd.CreateParameter("@ssProposalLineId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssProposalLineId", DbType.Int64, ssENProposalLogs.ssProposalLineId);

}
if ((ssENProposalLogs.ssCreatedBy=="")) {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENProposalLogs.ssCreatedBy);

}
insertSqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENProposalLogs.ssCreatedOn);
insertSqlCmd.CreateParameter("@ssMessage", DbType.String, ssENProposalLogs.ssMessage);
insertSqlCmd.CreateParameter("@ssIsError", DbType.Boolean, ssENProposalLogs.ssIsError);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateProposalLogs", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateProposalLogs
/// </summary>

public static async Task<long> CreateOrUpdateProposalLogs(IRequestContext requestContext,BitArray usedFields,RC_42d297db5356ec5acb8465e0977849c0 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateProposalLogs", "1a3baa6f-e5aa-4d07-af97-ed583a363d6d.#CreateOrUpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateProposalLogs", "1a3baa6f-e5aa-4d07-af97-ed583a363d6d.#CreateOrUpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_013f76cfa3062515b73935963b1697b0EntityRecord ssENProposalLogs = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(7,true);
}
string updateSet = "UPDATE " + ENProposalLogsEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLogsAttributeKeys.@ProposalId, "proposalid") ?? "proposalid") + " = @ssProposalId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLogsAttributeKeys.@ProposalLineId, "proposallineid") ?? "proposallineid") + " = @ssProposalLineId"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLogsAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = @ssCreatedBy"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLogsAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = @ssCreatedOn"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLogsAttributeKeys.@Message, "message") ?? "message") + " = @ssMessage"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLogsAttributeKeys.@IsError, "iserror") ?? "iserror") + " = @ssIsError"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLogsAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENProposalLogs_ssId_ProposalLogs";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLogsAttributeKeys.@IsError, "iserror") ?? "iserror") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLogsAttributeKeys.@IsError, "iserror") ?? "iserror") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssProposalId", DbType.Int64, ssENProposalLogs.ssProposalId);
}
if(usedFields[2]) {
if ((ssENProposalLogs.ssProposalLineId==0L)) {
sqlCmd.CreateParameter("@ssProposalLineId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssProposalLineId", DbType.Int64, ssENProposalLogs.ssProposalLineId);

}
}
if(usedFields[3]) {
if ((ssENProposalLogs.ssCreatedBy=="")) {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENProposalLogs.ssCreatedBy);

}
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENProposalLogs.ssCreatedOn);
}
if(usedFields[5]) {
sqlCmd.CreateParameter("@ssMessage", DbType.String, ssENProposalLogs.ssMessage);
}
if(usedFields[6]) {
sqlCmd.CreateParameter("@ssIsError", DbType.Boolean, ssENProposalLogs.ssIsError);
}
sqlCmd.CreateParameter("@idparam_ssENProposalLogs_ssId_ProposalLogs", DbType.Int64, ssENProposalLogs.ssId);
int counter = 0;
if(ssENProposalLogs.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateProposalLogs (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENProposalLogsEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLogsAttributeKeys.@ProposalId, "proposalid") ?? "proposalid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLogsAttributeKeys.@ProposalLineId, "proposallineid") ?? "proposallineid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLogsAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLogsAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLogsAttributeKeys.@Message, "message") ?? "message") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLogsAttributeKeys.@IsError, "iserror") ?? "iserror") + "" +
" ) VALUES (" +
" @ssProposalId" +
", @ssProposalLineId" +
", @ssCreatedBy" +
", @ssCreatedOn" +
", @ssMessage" +
", @ssIsError" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssProposalId", DbType.Int64, ssENProposalLogs.ssProposalId);
if ((ssENProposalLogs.ssProposalLineId==0L)) {
insertSqlCmd.CreateParameter("@ssProposalLineId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssProposalLineId", DbType.Int64, ssENProposalLogs.ssProposalLineId);

}
if ((ssENProposalLogs.ssCreatedBy=="")) {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENProposalLogs.ssCreatedBy);

}
insertSqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENProposalLogs.ssCreatedOn);
insertSqlCmd.CreateParameter("@ssMessage", DbType.String, ssENProposalLogs.ssMessage);
insertSqlCmd.CreateParameter("@ssIsError", DbType.Boolean, ssENProposalLogs.ssIsError);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateProposalLogs", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENProposalLogs.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeProposalLogs
/// </summary>

public static async Task CreateOrUpdateSomeProposalLogs(IRequestContext requestContext,RL_4c366307482ae336e685dced00a25d87 inParamSourceList,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateSomeProposalLogs", "1a3baa6f-e5aa-4d07-af97-ed583a363d6d.#CreateOrUpdateAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeProposalLogs", "1a3baa6f-e5aa-4d07-af97-ed583a363d6d.#CreateOrUpdateAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
string entityTableName = ENProposalLogsEntity.LocalViewName(null);
string insertSql = "INSERT INTO " + entityTableName + " (" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLogsAttributeKeys.@ProposalId, "proposalid") ?? "proposalid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLogsAttributeKeys.@ProposalLineId, "proposallineid") ?? "proposallineid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLogsAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLogsAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLogsAttributeKeys.@Message, "message") ?? "message") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLogsAttributeKeys.@IsError, "iserror") ?? "iserror") + ") VALUES ( unnest(@ssProposalId),  unnest(@ssProposalLineId),  unnest(@ssCreatedBy),  unnest(@ssCreatedOn),  unnest(@ssMessage),  unnest(@ssIsError)) ";
insertSql += "";

string updateSql = "UPDATE " + entityTableName + " SET " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLogsAttributeKeys.@ProposalId, "proposalid") ?? "proposalid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLogsAttributeKeys.@ProposalId, "proposalid") ?? "proposalid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLogsAttributeKeys.@ProposalLineId, "proposallineid") ?? "proposallineid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLogsAttributeKeys.@ProposalLineId, "proposallineid") ?? "proposallineid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLogsAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLogsAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLogsAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLogsAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLogsAttributeKeys.@Message, "message") ?? "message") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLogsAttributeKeys.@Message, "message") ?? "message") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLogsAttributeKeys.@IsError, "iserror") ?? "iserror") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLogsAttributeKeys.@IsError, "iserror") ?? "iserror") + " from ( select  unnest(@ssId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLogsAttributeKeys.@Id, "id") ?? "id") + ",  unnest(@ssProposalId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLogsAttributeKeys.@ProposalId, "proposalid") ?? "proposalid") + ",  unnest(@ssProposalLineId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLogsAttributeKeys.@ProposalLineId, "proposallineid") ?? "proposallineid") + ",  unnest(@ssCreatedBy) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLogsAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + ",  unnest(@ssCreatedOn) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLogsAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + ",  unnest(@ssMessage) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLogsAttributeKeys.@Message, "message") ?? "message") + ",  unnest(@ssIsError) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLogsAttributeKeys.@IsError, "iserror") ?? "iserror") + " ) as updateTable where " + entityTableName + "." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLogsAttributeKeys.@Id, "id") ?? "id") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLogsAttributeKeys.@Id, "id") ?? "id") + " ";
updateSql += "";

List<object> insertProposalIdList = new List<object>();
List<object> insertProposalLineIdList = new List<object>();
List<object> insertCreatedByList = new List<object>();
List<DateTime> insertCreatedOnList = new List<DateTime>();
List<string> insertMessageList = new List<string>();
List<bool> insertIsErrorList = new List<bool>();

List<long> updateIdList = new List<long>();
List<object> updateProposalIdList = new List<object>();
List<object> updateProposalLineIdList = new List<object>();
List<object> updateCreatedByList = new List<object>();
List<DateTime> updateCreatedOnList = new List<DateTime>();
List<string> updateMessageList = new List<string>();
List<bool> updateIsErrorList = new List<bool>();

var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_42d297db5356ec5acb8465e0977849c0)inParamSourceList.Current).ssENProposalLogs;
if (record.ssId != 0L) {
updateIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
updateProposalIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssProposalId));
if ((record.ssProposalLineId==0L)) {
updateProposalLineIdList.Add(null);
} else {
updateProposalLineIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssProposalLineId));
}
if ((record.ssCreatedBy=="")) {
updateCreatedByList.Add(null);
} else {
updateCreatedByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssCreatedBy));
}
updateCreatedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssCreatedOn));
updateMessageList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssMessage));
updateIsErrorList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsError));
} else {
insertProposalIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssProposalId));
if ((record.ssProposalLineId==0L)) {
insertProposalLineIdList.Add(null);
} else {
insertProposalLineIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssProposalLineId));
}
if ((record.ssCreatedBy=="")) {
insertCreatedByList.Add(null);
} else {
insertCreatedByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssCreatedBy));
}
insertCreatedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssCreatedOn));
insertMessageList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssMessage));
insertIsErrorList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsError));
}
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertProposalIdList.IsEmpty() || !insertProposalLineIdList.IsEmpty() || !insertCreatedByList.IsEmpty() || !insertCreatedOnList.IsEmpty() || !insertMessageList.IsEmpty() || !insertIsErrorList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssProposalId",DbType.Int64,insertProposalIdList);
executionService.CreateParameter(insertSqlCmd,"@ssProposalLineId",DbType.Int64,insertProposalLineIdList);
executionService.CreateParameter(insertSqlCmd,"@ssCreatedBy",DbType.String,insertCreatedByList);
executionService.CreateParameter(insertSqlCmd,"@ssCreatedOn",DbType.DateTime,insertCreatedOnList);
executionService.CreateParameter(insertSqlCmd,"@ssMessage",DbType.String,insertMessageList);
executionService.CreateParameter(insertSqlCmd,"@ssIsError",DbType.Boolean,insertIsErrorList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeProposalLogs (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
if(!updateProposalIdList.IsEmpty() || !updateProposalLineIdList.IsEmpty() || !updateCreatedByList.IsEmpty() || !updateCreatedOnList.IsEmpty() || !updateMessageList.IsEmpty() || !updateIsErrorList.IsEmpty()){
await using(var updateSqlCmd = trans.CreateCommand(updateSql)){
executionService.CreateParameter(updateSqlCmd,"@ssId",DbType.Int64,updateIdList);
executionService.CreateParameter(updateSqlCmd,"@ssProposalId",DbType.Int64,updateProposalIdList);
executionService.CreateParameter(updateSqlCmd,"@ssProposalLineId",DbType.Int64,updateProposalLineIdList);
executionService.CreateParameter(updateSqlCmd,"@ssCreatedBy",DbType.String,updateCreatedByList);
executionService.CreateParameter(updateSqlCmd,"@ssCreatedOn",DbType.DateTime,updateCreatedOnList);
executionService.CreateParameter(updateSqlCmd,"@ssMessage",DbType.String,updateMessageList);
executionService.CreateParameter(updateSqlCmd,"@ssIsError",DbType.Boolean,updateIsErrorList);
await updateSqlCmd.PrepareAsync(cancellationToken);
await updateSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeProposalLogs (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(updateSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteProposalLogs
/// </summary>

public static async Task DeleteProposalLogs(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteProposalLogs", "1a3baa6f-e5aa-4d07-af97-ed583a363d6d.#DeleteEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteProposalLogs", "1a3baa6f-e5aa-4d07-af97-ed583a363d6d.#DeleteEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENProposalLogsEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLogsAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteProposalLogs", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllProposalLogs
/// </summary>

public static async Task DeleteAllProposalLogs(IRequestContext requestContext,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteAllProposalLogs", "1a3baa6f-e5aa-4d07-af97-ed583a363d6d.#DeleteAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllProposalLogs", "1a3baa6f-e5aa-4d07-af97-ed583a363d6d.#DeleteAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENProposalLogsEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteProposalLogs", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetProposalLogs
/// </summary>

public static async Task<RC_42d297db5356ec5acb8465e0977849c0> GetProposalLogs(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_42d297db5356ec5acb8465e0977849c0 outParamRecord = default;
outParamRecord = new RC_42d297db5356ec5acb8465e0977849c0();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetProposalLogs", "1a3baa6f-e5aa-4d07-af97-ed583a363d6d.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetProposalLogs", "1a3baa6f-e5aa-4d07-af97-ed583a363d6d.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLogsAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLogsAttributeKeys.@ProposalId, "proposalid") ?? "proposalid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLogsAttributeKeys.@ProposalLineId, "proposallineid") ?? "proposallineid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLogsAttributeKeys.@CreatedBy, "createdby") ?? "createdby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLogsAttributeKeys.@CreatedOn, "createdon") ?? "createdon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLogsAttributeKeys.@Message, "message") ?? "message", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLogsAttributeKeys.@IsError, "iserror") ?? "iserror", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
" FROM " + ENProposalLogsEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLogsAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetProposalLogs", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(7,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENProposalLogsEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetProposalLogsForUpdate
/// </summary>

public static async Task<RC_42d297db5356ec5acb8465e0977849c0> GetProposalLogsForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_42d297db5356ec5acb8465e0977849c0 outParamRecord = default;
outParamRecord = new RC_42d297db5356ec5acb8465e0977849c0();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetProposalLogsForUpdate", "1a3baa6f-e5aa-4d07-af97-ed583a363d6d.#GetEntityForUpdate");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetProposalLogsForUpdate", "1a3baa6f-e5aa-4d07-af97-ed583a363d6d.#GetEntityForUpdate", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLogsAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLogsAttributeKeys.@ProposalId, "proposalid") ?? "proposalid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLogsAttributeKeys.@ProposalLineId, "proposallineid") ?? "proposallineid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLogsAttributeKeys.@CreatedBy, "createdby") ?? "createdby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLogsAttributeKeys.@CreatedOn, "createdon") ?? "createdon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLogsAttributeKeys.@Message, "message") ?? "message", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLogsAttributeKeys.@IsError, "iserror") ?? "iserror", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
" FROM " + ENProposalLogsEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLogsAttributeKeys.@Id, "id") ?? "id") + " = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetProposalLogsForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(7,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENProposalLogsEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateProposalLogs
/// </summary>

public static async Task UpdateProposalLogs(IRequestContext requestContext,BitArray usedFields,RC_42d297db5356ec5acb8465e0977849c0 inParamSource,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("UpdateProposalLogs", "1a3baa6f-e5aa-4d07-af97-ed583a363d6d.#UpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateProposalLogs", "1a3baa6f-e5aa-4d07-af97-ed583a363d6d.#UpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_013f76cfa3062515b73935963b1697b0EntityRecord ssENProposalLogs = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(7,true);
}
string updateSet = "UPDATE " + ENProposalLogsEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLogsAttributeKeys.@ProposalId, "proposalid") ?? "proposalid") + " = @ssProposalId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLogsAttributeKeys.@ProposalLineId, "proposallineid") ?? "proposallineid") + " = @ssProposalLineId"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLogsAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = @ssCreatedBy"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLogsAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = @ssCreatedOn"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLogsAttributeKeys.@Message, "message") ?? "message") + " = @ssMessage"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLogsAttributeKeys.@IsError, "iserror") ?? "iserror") + " = @ssIsError"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLogsAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENProposalLogs_ssId_ProposalLogs";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLogsAttributeKeys.@IsError, "iserror") ?? "iserror") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLogsAttributeKeys.@IsError, "iserror") ?? "iserror") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssProposalId", DbType.Int64, ssENProposalLogs.ssProposalId);
}
if(usedFields[2]) {
if ((ssENProposalLogs.ssProposalLineId==0L)) {
sqlCmd.CreateParameter("@ssProposalLineId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssProposalLineId", DbType.Int64, ssENProposalLogs.ssProposalLineId);

}
}
if(usedFields[3]) {
if ((ssENProposalLogs.ssCreatedBy=="")) {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENProposalLogs.ssCreatedBy);

}
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENProposalLogs.ssCreatedOn);
}
if(usedFields[5]) {
sqlCmd.CreateParameter("@ssMessage", DbType.String, ssENProposalLogs.ssMessage);
}
if(usedFields[6]) {
sqlCmd.CreateParameter("@ssIsError", DbType.Boolean, ssENProposalLogs.ssIsError);
}
sqlCmd.CreateParameter("@idparam_ssENProposalLogs_ssId_ProposalLogs", DbType.Int64, ssENProposalLogs.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateProposalLogs", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("ProposalLogs", ssENProposalLogs.ssId.ToString()); }}
}
return;
}

}
}
