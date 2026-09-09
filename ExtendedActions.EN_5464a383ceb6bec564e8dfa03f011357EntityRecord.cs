using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateProposalApproval
/// </summary>

public static async Task<long> CreateProposalApproval(IRequestContext requestContext,RC_1e5bc1d6d010761f865e3a0774f1c819 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateProposalApproval", "b6ee4a3b-64e6-41ae-a33b-0f4d1330fa00.#CreateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateProposalApproval", "b6ee4a3b-64e6-41ae-a33b-0f4d1330fa00.#CreateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_5464a383ceb6bec564e8dfa03f011357EntityRecord ssENProposalApproval = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENProposalApprovalEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@ProposalId, "proposalid") ?? "proposalid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@ProcessTypeCode, "processtypecode") ?? "processtypecode") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@ApprovalProcessVersion, "approvalprocessversion") ?? "approvalprocessversion") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@CurrentLevel_DEPREC, "currentlevel_deprec") ?? "currentlevel_deprec") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@MaxLevel_DEPREC, "maxlevel_deprec") ?? "maxlevel_deprec") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@StartedOn, "startedon") ?? "startedon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@FinishedOn, "finishedon") ?? "finishedon") + "" +
" ) VALUES (" +
" @ssProposalId" +
", @ssProcessTypeCode" +
", @ssApprovalProcessVersion" +
", @ssCurrentLevel_DEPREC" +
", @ssMaxLevel_DEPREC" +
", @ssStartedOn" +
", @ssFinishedOn" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENProposalApproval.ssProposalId==0L)) {
insertSqlCmd.CreateParameter("@ssProposalId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssProposalId", DbType.Int64, ssENProposalApproval.ssProposalId);

}
insertSqlCmd.CreateParameter("@ssProcessTypeCode", DbType.String, ssENProposalApproval.ssProcessTypeCode);
insertSqlCmd.CreateParameter("@ssApprovalProcessVersion", DbType.String, ssENProposalApproval.ssApprovalProcessVersion);
insertSqlCmd.CreateParameter("@ssCurrentLevel_DEPREC", DbType.Int32, ssENProposalApproval.ssCurrentLevel_DEPREC);
insertSqlCmd.CreateParameter("@ssMaxLevel_DEPREC", DbType.Int32, ssENProposalApproval.ssMaxLevel_DEPREC);
insertSqlCmd.CreateParameter("@ssStartedOn", DbType.DateTime, ssENProposalApproval.ssStartedOn);
insertSqlCmd.CreateParameter("@ssFinishedOn", DbType.DateTime, ssENProposalApproval.ssFinishedOn);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateProposalApproval", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateProposalApproval
/// </summary>

public static async Task<long> CreateOrUpdateProposalApproval(IRequestContext requestContext,BitArray usedFields,RC_1e5bc1d6d010761f865e3a0774f1c819 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateProposalApproval", "b6ee4a3b-64e6-41ae-a33b-0f4d1330fa00.#CreateOrUpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateProposalApproval", "b6ee4a3b-64e6-41ae-a33b-0f4d1330fa00.#CreateOrUpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_5464a383ceb6bec564e8dfa03f011357EntityRecord ssENProposalApproval = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(8,true);
}
string updateSet = "UPDATE " + ENProposalApprovalEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@ProposalId, "proposalid") ?? "proposalid") + " = @ssProposalId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@ProcessTypeCode, "processtypecode") ?? "processtypecode") + " = @ssProcessTypeCode"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@ApprovalProcessVersion, "approvalprocessversion") ?? "approvalprocessversion") + " = @ssApprovalProcessVersion"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@CurrentLevel_DEPREC, "currentlevel_deprec") ?? "currentlevel_deprec") + " = @ssCurrentLevel_DEPREC"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@MaxLevel_DEPREC, "maxlevel_deprec") ?? "maxlevel_deprec") + " = @ssMaxLevel_DEPREC"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@StartedOn, "startedon") ?? "startedon") + " = @ssStartedOn"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@FinishedOn, "finishedon") ?? "finishedon") + " = @ssFinishedOn"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENProposalApproval_ssId_ProposalApproval";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@CurrentLevel_DEPREC, "currentlevel_deprec") ?? "currentlevel_deprec") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@CurrentLevel_DEPREC, "currentlevel_deprec") ?? "currentlevel_deprec") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENProposalApproval.ssProposalId==0L)) {
sqlCmd.CreateParameter("@ssProposalId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssProposalId", DbType.Int64, ssENProposalApproval.ssProposalId);

}
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssProcessTypeCode", DbType.String, ssENProposalApproval.ssProcessTypeCode);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssApprovalProcessVersion", DbType.String, ssENProposalApproval.ssApprovalProcessVersion);
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssCurrentLevel_DEPREC", DbType.Int32, ssENProposalApproval.ssCurrentLevel_DEPREC);
}
if(usedFields[5]) {
sqlCmd.CreateParameter("@ssMaxLevel_DEPREC", DbType.Int32, ssENProposalApproval.ssMaxLevel_DEPREC);
}
if(usedFields[6]) {
sqlCmd.CreateParameter("@ssStartedOn", DbType.DateTime, ssENProposalApproval.ssStartedOn);
}
if(usedFields[7]) {
sqlCmd.CreateParameter("@ssFinishedOn", DbType.DateTime, ssENProposalApproval.ssFinishedOn);
}
sqlCmd.CreateParameter("@idparam_ssENProposalApproval_ssId_ProposalApproval", DbType.Int64, ssENProposalApproval.ssId);
int counter = 0;
if(ssENProposalApproval.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateProposalApproval (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENProposalApprovalEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@ProposalId, "proposalid") ?? "proposalid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@ProcessTypeCode, "processtypecode") ?? "processtypecode") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@ApprovalProcessVersion, "approvalprocessversion") ?? "approvalprocessversion") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@CurrentLevel_DEPREC, "currentlevel_deprec") ?? "currentlevel_deprec") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@MaxLevel_DEPREC, "maxlevel_deprec") ?? "maxlevel_deprec") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@StartedOn, "startedon") ?? "startedon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@FinishedOn, "finishedon") ?? "finishedon") + "" +
" ) VALUES (" +
" @ssProposalId" +
", @ssProcessTypeCode" +
", @ssApprovalProcessVersion" +
", @ssCurrentLevel_DEPREC" +
", @ssMaxLevel_DEPREC" +
", @ssStartedOn" +
", @ssFinishedOn" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENProposalApproval.ssProposalId==0L)) {
insertSqlCmd.CreateParameter("@ssProposalId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssProposalId", DbType.Int64, ssENProposalApproval.ssProposalId);

}
insertSqlCmd.CreateParameter("@ssProcessTypeCode", DbType.String, ssENProposalApproval.ssProcessTypeCode);
insertSqlCmd.CreateParameter("@ssApprovalProcessVersion", DbType.String, ssENProposalApproval.ssApprovalProcessVersion);
insertSqlCmd.CreateParameter("@ssCurrentLevel_DEPREC", DbType.Int32, ssENProposalApproval.ssCurrentLevel_DEPREC);
insertSqlCmd.CreateParameter("@ssMaxLevel_DEPREC", DbType.Int32, ssENProposalApproval.ssMaxLevel_DEPREC);
insertSqlCmd.CreateParameter("@ssStartedOn", DbType.DateTime, ssENProposalApproval.ssStartedOn);
insertSqlCmd.CreateParameter("@ssFinishedOn", DbType.DateTime, ssENProposalApproval.ssFinishedOn);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateProposalApproval", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENProposalApproval.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeProposalApproval
/// </summary>

public static async Task CreateOrUpdateSomeProposalApproval(IRequestContext requestContext,RL_b93d71fe309691533cce5003487a0187 inParamSourceList,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateSomeProposalApproval", "b6ee4a3b-64e6-41ae-a33b-0f4d1330fa00.#CreateOrUpdateAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeProposalApproval", "b6ee4a3b-64e6-41ae-a33b-0f4d1330fa00.#CreateOrUpdateAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
string entityTableName = ENProposalApprovalEntity.LocalViewName(null);
string insertSql = "INSERT INTO " + entityTableName + " (" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@ProposalId, "proposalid") ?? "proposalid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@ProcessTypeCode, "processtypecode") ?? "processtypecode") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@ApprovalProcessVersion, "approvalprocessversion") ?? "approvalprocessversion") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@CurrentLevel_DEPREC, "currentlevel_deprec") ?? "currentlevel_deprec") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@MaxLevel_DEPREC, "maxlevel_deprec") ?? "maxlevel_deprec") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@StartedOn, "startedon") ?? "startedon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@FinishedOn, "finishedon") ?? "finishedon") + ") VALUES ( unnest(@ssProposalId),  unnest(@ssProcessTypeCode),  unnest(@ssApprovalProcessVersion),  unnest(@ssCurrentLevel_DEPREC),  unnest(@ssMaxLevel_DEPREC),  unnest(@ssStartedOn),  unnest(@ssFinishedOn)) ";
insertSql += "";

string updateSql = "UPDATE " + entityTableName + " SET " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@ProposalId, "proposalid") ?? "proposalid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@ProposalId, "proposalid") ?? "proposalid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@ProcessTypeCode, "processtypecode") ?? "processtypecode") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@ProcessTypeCode, "processtypecode") ?? "processtypecode") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@ApprovalProcessVersion, "approvalprocessversion") ?? "approvalprocessversion") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@ApprovalProcessVersion, "approvalprocessversion") ?? "approvalprocessversion") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@CurrentLevel_DEPREC, "currentlevel_deprec") ?? "currentlevel_deprec") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@CurrentLevel_DEPREC, "currentlevel_deprec") ?? "currentlevel_deprec") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@MaxLevel_DEPREC, "maxlevel_deprec") ?? "maxlevel_deprec") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@MaxLevel_DEPREC, "maxlevel_deprec") ?? "maxlevel_deprec") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@StartedOn, "startedon") ?? "startedon") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@StartedOn, "startedon") ?? "startedon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@FinishedOn, "finishedon") ?? "finishedon") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@FinishedOn, "finishedon") ?? "finishedon") + " from ( select  unnest(@ssId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@Id, "id") ?? "id") + ",  unnest(@ssProposalId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@ProposalId, "proposalid") ?? "proposalid") + ",  unnest(@ssProcessTypeCode) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@ProcessTypeCode, "processtypecode") ?? "processtypecode") + ",  unnest(@ssApprovalProcessVersion) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@ApprovalProcessVersion, "approvalprocessversion") ?? "approvalprocessversion") + ",  unnest(@ssCurrentLevel_DEPREC) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@CurrentLevel_DEPREC, "currentlevel_deprec") ?? "currentlevel_deprec") + ",  unnest(@ssMaxLevel_DEPREC) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@MaxLevel_DEPREC, "maxlevel_deprec") ?? "maxlevel_deprec") + ",  unnest(@ssStartedOn) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@StartedOn, "startedon") ?? "startedon") + ",  unnest(@ssFinishedOn) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@FinishedOn, "finishedon") ?? "finishedon") + " ) as updateTable where " + entityTableName + "." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@Id, "id") ?? "id") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@Id, "id") ?? "id") + " ";
updateSql += "";

List<object> insertProposalIdList = new List<object>();
List<string> insertProcessTypeCodeList = new List<string>();
List<string> insertApprovalProcessVersionList = new List<string>();
List<int> insertCurrentLevel_DEPRECList = new List<int>();
List<int> insertMaxLevel_DEPRECList = new List<int>();
List<DateTime> insertStartedOnList = new List<DateTime>();
List<DateTime> insertFinishedOnList = new List<DateTime>();

List<long> updateIdList = new List<long>();
List<object> updateProposalIdList = new List<object>();
List<string> updateProcessTypeCodeList = new List<string>();
List<string> updateApprovalProcessVersionList = new List<string>();
List<int> updateCurrentLevel_DEPRECList = new List<int>();
List<int> updateMaxLevel_DEPRECList = new List<int>();
List<DateTime> updateStartedOnList = new List<DateTime>();
List<DateTime> updateFinishedOnList = new List<DateTime>();

var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_1e5bc1d6d010761f865e3a0774f1c819)inParamSourceList.Current).ssENProposalApproval;
if (record.ssId != 0L) {
updateIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
if ((record.ssProposalId==0L)) {
updateProposalIdList.Add(null);
} else {
updateProposalIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssProposalId));
}
updateProcessTypeCodeList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssProcessTypeCode));
updateApprovalProcessVersionList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssApprovalProcessVersion));
updateCurrentLevel_DEPRECList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssCurrentLevel_DEPREC));
updateMaxLevel_DEPRECList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssMaxLevel_DEPREC));
updateStartedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssStartedOn));
updateFinishedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssFinishedOn));
} else {
if ((record.ssProposalId==0L)) {
insertProposalIdList.Add(null);
} else {
insertProposalIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssProposalId));
}
insertProcessTypeCodeList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssProcessTypeCode));
insertApprovalProcessVersionList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssApprovalProcessVersion));
insertCurrentLevel_DEPRECList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssCurrentLevel_DEPREC));
insertMaxLevel_DEPRECList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssMaxLevel_DEPREC));
insertStartedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssStartedOn));
insertFinishedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssFinishedOn));
}
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertProposalIdList.IsEmpty() || !insertProcessTypeCodeList.IsEmpty() || !insertApprovalProcessVersionList.IsEmpty() || !insertCurrentLevel_DEPRECList.IsEmpty() || !insertMaxLevel_DEPRECList.IsEmpty() || !insertStartedOnList.IsEmpty() || !insertFinishedOnList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssProposalId",DbType.Int64,insertProposalIdList);
executionService.CreateParameter(insertSqlCmd,"@ssProcessTypeCode",DbType.String,insertProcessTypeCodeList);
executionService.CreateParameter(insertSqlCmd,"@ssApprovalProcessVersion",DbType.String,insertApprovalProcessVersionList);
executionService.CreateParameter(insertSqlCmd,"@ssCurrentLevel_DEPREC",DbType.Int32,insertCurrentLevel_DEPRECList);
executionService.CreateParameter(insertSqlCmd,"@ssMaxLevel_DEPREC",DbType.Int32,insertMaxLevel_DEPRECList);
executionService.CreateParameter(insertSqlCmd,"@ssStartedOn",DbType.DateTime,insertStartedOnList);
executionService.CreateParameter(insertSqlCmd,"@ssFinishedOn",DbType.DateTime,insertFinishedOnList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeProposalApproval (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
if(!updateProposalIdList.IsEmpty() || !updateProcessTypeCodeList.IsEmpty() || !updateApprovalProcessVersionList.IsEmpty() || !updateCurrentLevel_DEPRECList.IsEmpty() || !updateMaxLevel_DEPRECList.IsEmpty() || !updateStartedOnList.IsEmpty() || !updateFinishedOnList.IsEmpty()){
await using(var updateSqlCmd = trans.CreateCommand(updateSql)){
executionService.CreateParameter(updateSqlCmd,"@ssId",DbType.Int64,updateIdList);
executionService.CreateParameter(updateSqlCmd,"@ssProposalId",DbType.Int64,updateProposalIdList);
executionService.CreateParameter(updateSqlCmd,"@ssProcessTypeCode",DbType.String,updateProcessTypeCodeList);
executionService.CreateParameter(updateSqlCmd,"@ssApprovalProcessVersion",DbType.String,updateApprovalProcessVersionList);
executionService.CreateParameter(updateSqlCmd,"@ssCurrentLevel_DEPREC",DbType.Int32,updateCurrentLevel_DEPRECList);
executionService.CreateParameter(updateSqlCmd,"@ssMaxLevel_DEPREC",DbType.Int32,updateMaxLevel_DEPRECList);
executionService.CreateParameter(updateSqlCmd,"@ssStartedOn",DbType.DateTime,updateStartedOnList);
executionService.CreateParameter(updateSqlCmd,"@ssFinishedOn",DbType.DateTime,updateFinishedOnList);
await updateSqlCmd.PrepareAsync(cancellationToken);
await updateSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeProposalApproval (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(updateSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteProposalApproval
/// </summary>

public static async Task DeleteProposalApproval(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteProposalApproval", "b6ee4a3b-64e6-41ae-a33b-0f4d1330fa00.#DeleteEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteProposalApproval", "b6ee4a3b-64e6-41ae-a33b-0f4d1330fa00.#DeleteEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENProposalApprovalEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteProposalApproval", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllProposalApproval
/// </summary>

public static async Task DeleteAllProposalApproval(IRequestContext requestContext,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteAllProposalApproval", "b6ee4a3b-64e6-41ae-a33b-0f4d1330fa00.#DeleteAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllProposalApproval", "b6ee4a3b-64e6-41ae-a33b-0f4d1330fa00.#DeleteAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENProposalApprovalEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteProposalApproval", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetProposalApproval
/// </summary>

public static async Task<RC_1e5bc1d6d010761f865e3a0774f1c819> GetProposalApproval(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_1e5bc1d6d010761f865e3a0774f1c819 outParamRecord = default;
outParamRecord = new RC_1e5bc1d6d010761f865e3a0774f1c819();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetProposalApproval", "b6ee4a3b-64e6-41ae-a33b-0f4d1330fa00.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetProposalApproval", "b6ee4a3b-64e6-41ae-a33b-0f4d1330fa00.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@ProposalId, "proposalid") ?? "proposalid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@ProcessTypeCode, "processtypecode") ?? "processtypecode", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@ApprovalProcessVersion, "approvalprocessversion") ?? "approvalprocessversion", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@CurrentLevel_DEPREC, "currentlevel_deprec") ?? "currentlevel_deprec", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@MaxLevel_DEPREC, "maxlevel_deprec") ?? "maxlevel_deprec", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@StartedOn, "startedon") ?? "startedon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@FinishedOn, "finishedon") ?? "finishedon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
" FROM " + ENProposalApprovalEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetProposalApproval", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(8,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENProposalApprovalEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetProposalApprovalForUpdate
/// </summary>

public static async Task<RC_1e5bc1d6d010761f865e3a0774f1c819> GetProposalApprovalForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_1e5bc1d6d010761f865e3a0774f1c819 outParamRecord = default;
outParamRecord = new RC_1e5bc1d6d010761f865e3a0774f1c819();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetProposalApprovalForUpdate", "b6ee4a3b-64e6-41ae-a33b-0f4d1330fa00.#GetEntityForUpdate");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetProposalApprovalForUpdate", "b6ee4a3b-64e6-41ae-a33b-0f4d1330fa00.#GetEntityForUpdate", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@ProposalId, "proposalid") ?? "proposalid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@ProcessTypeCode, "processtypecode") ?? "processtypecode", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@ApprovalProcessVersion, "approvalprocessversion") ?? "approvalprocessversion", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@CurrentLevel_DEPREC, "currentlevel_deprec") ?? "currentlevel_deprec", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@MaxLevel_DEPREC, "maxlevel_deprec") ?? "maxlevel_deprec", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@StartedOn, "startedon") ?? "startedon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@FinishedOn, "finishedon") ?? "finishedon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
" FROM " + ENProposalApprovalEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@Id, "id") ?? "id") + " = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetProposalApprovalForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(8,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENProposalApprovalEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateProposalApproval
/// </summary>

public static async Task UpdateProposalApproval(IRequestContext requestContext,BitArray usedFields,RC_1e5bc1d6d010761f865e3a0774f1c819 inParamSource,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("UpdateProposalApproval", "b6ee4a3b-64e6-41ae-a33b-0f4d1330fa00.#UpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateProposalApproval", "b6ee4a3b-64e6-41ae-a33b-0f4d1330fa00.#UpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_5464a383ceb6bec564e8dfa03f011357EntityRecord ssENProposalApproval = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(8,true);
}
string updateSet = "UPDATE " + ENProposalApprovalEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@ProposalId, "proposalid") ?? "proposalid") + " = @ssProposalId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@ProcessTypeCode, "processtypecode") ?? "processtypecode") + " = @ssProcessTypeCode"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@ApprovalProcessVersion, "approvalprocessversion") ?? "approvalprocessversion") + " = @ssApprovalProcessVersion"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@CurrentLevel_DEPREC, "currentlevel_deprec") ?? "currentlevel_deprec") + " = @ssCurrentLevel_DEPREC"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@MaxLevel_DEPREC, "maxlevel_deprec") ?? "maxlevel_deprec") + " = @ssMaxLevel_DEPREC"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@StartedOn, "startedon") ?? "startedon") + " = @ssStartedOn"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@FinishedOn, "finishedon") ?? "finishedon") + " = @ssFinishedOn"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENProposalApproval_ssId_ProposalApproval";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@CurrentLevel_DEPREC, "currentlevel_deprec") ?? "currentlevel_deprec") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@CurrentLevel_DEPREC, "currentlevel_deprec") ?? "currentlevel_deprec") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENProposalApproval.ssProposalId==0L)) {
sqlCmd.CreateParameter("@ssProposalId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssProposalId", DbType.Int64, ssENProposalApproval.ssProposalId);

}
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssProcessTypeCode", DbType.String, ssENProposalApproval.ssProcessTypeCode);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssApprovalProcessVersion", DbType.String, ssENProposalApproval.ssApprovalProcessVersion);
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssCurrentLevel_DEPREC", DbType.Int32, ssENProposalApproval.ssCurrentLevel_DEPREC);
}
if(usedFields[5]) {
sqlCmd.CreateParameter("@ssMaxLevel_DEPREC", DbType.Int32, ssENProposalApproval.ssMaxLevel_DEPREC);
}
if(usedFields[6]) {
sqlCmd.CreateParameter("@ssStartedOn", DbType.DateTime, ssENProposalApproval.ssStartedOn);
}
if(usedFields[7]) {
sqlCmd.CreateParameter("@ssFinishedOn", DbType.DateTime, ssENProposalApproval.ssFinishedOn);
}
sqlCmd.CreateParameter("@idparam_ssENProposalApproval_ssId_ProposalApproval", DbType.Int64, ssENProposalApproval.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateProposalApproval", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("ProposalApproval", ssENProposalApproval.ssId.ToString()); }}
}
return;
}

}
}
