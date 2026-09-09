using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateProposalLineApprovalLevel
/// </summary>

public static async Task<long> CreateProposalLineApprovalLevel(IRequestContext requestContext,RC_875fb45d4123a91fce83831f0f554d8e inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateProposalLineApprovalLevel", "a810edd3-3ebe-4591-833e-78d2c483942e.#CreateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateProposalLineApprovalLevel", "a810edd3-3ebe-4591-833e-78d2c483942e.#CreateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord ssENProposalLineApprovalLevel = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENProposalLineApprovalLevelEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@ProposalLineId, "proposallineid") ?? "proposallineid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@ProposalApprovalLevelId, "proposalapprovallevelid") ?? "proposalapprovallevelid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@ApprovalStatusId, "approvalstatusid") ?? "approvalstatusid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@ApprovedBy, "approvedby") ?? "approvedby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@ApprovedOn, "approvedon") ?? "approvedon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@RejectedBy, "rejectedby") ?? "rejectedby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@RejectedOn, "rejectedon") ?? "rejectedon") + "" +
" ) VALUES (" +
" @ssProposalLineId" +
", @ssProposalApprovalLevelId" +
", @ssApplicationRoleId" +
", @ssApprovalStatusId" +
", @ssApprovedBy" +
", @ssApprovedOn" +
", @ssRejectedBy" +
", @ssRejectedOn" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENProposalLineApprovalLevel.ssProposalLineId==0L)) {
insertSqlCmd.CreateParameter("@ssProposalLineId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssProposalLineId", DbType.Int64, ssENProposalLineApprovalLevel.ssProposalLineId);

}
if ((ssENProposalLineApprovalLevel.ssProposalApprovalLevelId==0L)) {
insertSqlCmd.CreateParameter("@ssProposalApprovalLevelId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssProposalApprovalLevelId", DbType.Int64, ssENProposalLineApprovalLevel.ssProposalApprovalLevelId);

}
if ((ssENProposalLineApprovalLevel.ssApplicationRoleId==0L)) {
insertSqlCmd.CreateParameter("@ssApplicationRoleId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssApplicationRoleId", DbType.Int64, ssENProposalLineApprovalLevel.ssApplicationRoleId);

}
if ((ssENProposalLineApprovalLevel.ssApprovalStatusId==0)) {
insertSqlCmd.CreateParameter("@ssApprovalStatusId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssApprovalStatusId", DbType.Int32, ssENProposalLineApprovalLevel.ssApprovalStatusId);

}
if ((ssENProposalLineApprovalLevel.ssApprovedBy=="")) {
insertSqlCmd.CreateParameter("@ssApprovedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssApprovedBy", DbType.String, ssENProposalLineApprovalLevel.ssApprovedBy);

}
insertSqlCmd.CreateParameter("@ssApprovedOn", DbType.DateTime, ssENProposalLineApprovalLevel.ssApprovedOn);
if ((ssENProposalLineApprovalLevel.ssRejectedBy=="")) {
insertSqlCmd.CreateParameter("@ssRejectedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssRejectedBy", DbType.String, ssENProposalLineApprovalLevel.ssRejectedBy);

}
insertSqlCmd.CreateParameter("@ssRejectedOn", DbType.DateTime, ssENProposalLineApprovalLevel.ssRejectedOn);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateProposalLineApprovalLevel", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateProposalLineApprovalLevel
/// </summary>

public static async Task<long> CreateOrUpdateProposalLineApprovalLevel(IRequestContext requestContext,BitArray usedFields,RC_875fb45d4123a91fce83831f0f554d8e inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateProposalLineApprovalLevel", "a810edd3-3ebe-4591-833e-78d2c483942e.#CreateOrUpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateProposalLineApprovalLevel", "a810edd3-3ebe-4591-833e-78d2c483942e.#CreateOrUpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord ssENProposalLineApprovalLevel = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(9,true);
}
string updateSet = "UPDATE " + ENProposalLineApprovalLevelEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@ProposalLineId, "proposallineid") ?? "proposallineid") + " = @ssProposalLineId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@ProposalApprovalLevelId, "proposalapprovallevelid") ?? "proposalapprovallevelid") + " = @ssProposalApprovalLevelId"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid") + " = @ssApplicationRoleId"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@ApprovalStatusId, "approvalstatusid") ?? "approvalstatusid") + " = @ssApprovalStatusId"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@ApprovedBy, "approvedby") ?? "approvedby") + " = @ssApprovedBy"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@ApprovedOn, "approvedon") ?? "approvedon") + " = @ssApprovedOn"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@RejectedBy, "rejectedby") ?? "rejectedby") + " = @ssRejectedBy"): parameters);
parameters = (usedFields[8] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@RejectedOn, "rejectedon") ?? "rejectedon") + " = @ssRejectedOn"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENProposalLiApprovalLevel_sd_ProposalLinepprovalLevel";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@ApprovalStatusId, "approvalstatusid") ?? "approvalstatusid") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@ApprovalStatusId, "approvalstatusid") ?? "approvalstatusid") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENProposalLineApprovalLevel.ssProposalLineId==0L)) {
sqlCmd.CreateParameter("@ssProposalLineId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssProposalLineId", DbType.Int64, ssENProposalLineApprovalLevel.ssProposalLineId);

}
}
if(usedFields[2]) {
if ((ssENProposalLineApprovalLevel.ssProposalApprovalLevelId==0L)) {
sqlCmd.CreateParameter("@ssProposalApprovalLevelId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssProposalApprovalLevelId", DbType.Int64, ssENProposalLineApprovalLevel.ssProposalApprovalLevelId);

}
}
if(usedFields[3]) {
if ((ssENProposalLineApprovalLevel.ssApplicationRoleId==0L)) {
sqlCmd.CreateParameter("@ssApplicationRoleId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssApplicationRoleId", DbType.Int64, ssENProposalLineApprovalLevel.ssApplicationRoleId);

}
}
if(usedFields[4]) {
if ((ssENProposalLineApprovalLevel.ssApprovalStatusId==0)) {
sqlCmd.CreateParameter("@ssApprovalStatusId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssApprovalStatusId", DbType.Int32, ssENProposalLineApprovalLevel.ssApprovalStatusId);

}
}
if(usedFields[5]) {
if ((ssENProposalLineApprovalLevel.ssApprovedBy=="")) {
sqlCmd.CreateParameter("@ssApprovedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssApprovedBy", DbType.String, ssENProposalLineApprovalLevel.ssApprovedBy);

}
}
if(usedFields[6]) {
sqlCmd.CreateParameter("@ssApprovedOn", DbType.DateTime, ssENProposalLineApprovalLevel.ssApprovedOn);
}
if(usedFields[7]) {
if ((ssENProposalLineApprovalLevel.ssRejectedBy=="")) {
sqlCmd.CreateParameter("@ssRejectedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssRejectedBy", DbType.String, ssENProposalLineApprovalLevel.ssRejectedBy);

}
}
if(usedFields[8]) {
sqlCmd.CreateParameter("@ssRejectedOn", DbType.DateTime, ssENProposalLineApprovalLevel.ssRejectedOn);
}
sqlCmd.CreateParameter("@idparam_ssENProposalLiApprovalLevel_sd_ProposalLinepprovalLevel", DbType.Int64, ssENProposalLineApprovalLevel.ssId);
int counter = 0;
if(ssENProposalLineApprovalLevel.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateProposalLineApprovalLevel (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENProposalLineApprovalLevelEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@ProposalLineId, "proposallineid") ?? "proposallineid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@ProposalApprovalLevelId, "proposalapprovallevelid") ?? "proposalapprovallevelid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@ApprovalStatusId, "approvalstatusid") ?? "approvalstatusid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@ApprovedBy, "approvedby") ?? "approvedby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@ApprovedOn, "approvedon") ?? "approvedon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@RejectedBy, "rejectedby") ?? "rejectedby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@RejectedOn, "rejectedon") ?? "rejectedon") + "" +
" ) VALUES (" +
" @ssProposalLineId" +
", @ssProposalApprovalLevelId" +
", @ssApplicationRoleId" +
", @ssApprovalStatusId" +
", @ssApprovedBy" +
", @ssApprovedOn" +
", @ssRejectedBy" +
", @ssRejectedOn" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENProposalLineApprovalLevel.ssProposalLineId==0L)) {
insertSqlCmd.CreateParameter("@ssProposalLineId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssProposalLineId", DbType.Int64, ssENProposalLineApprovalLevel.ssProposalLineId);

}
if ((ssENProposalLineApprovalLevel.ssProposalApprovalLevelId==0L)) {
insertSqlCmd.CreateParameter("@ssProposalApprovalLevelId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssProposalApprovalLevelId", DbType.Int64, ssENProposalLineApprovalLevel.ssProposalApprovalLevelId);

}
if ((ssENProposalLineApprovalLevel.ssApplicationRoleId==0L)) {
insertSqlCmd.CreateParameter("@ssApplicationRoleId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssApplicationRoleId", DbType.Int64, ssENProposalLineApprovalLevel.ssApplicationRoleId);

}
if ((ssENProposalLineApprovalLevel.ssApprovalStatusId==0)) {
insertSqlCmd.CreateParameter("@ssApprovalStatusId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssApprovalStatusId", DbType.Int32, ssENProposalLineApprovalLevel.ssApprovalStatusId);

}
if ((ssENProposalLineApprovalLevel.ssApprovedBy=="")) {
insertSqlCmd.CreateParameter("@ssApprovedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssApprovedBy", DbType.String, ssENProposalLineApprovalLevel.ssApprovedBy);

}
insertSqlCmd.CreateParameter("@ssApprovedOn", DbType.DateTime, ssENProposalLineApprovalLevel.ssApprovedOn);
if ((ssENProposalLineApprovalLevel.ssRejectedBy=="")) {
insertSqlCmd.CreateParameter("@ssRejectedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssRejectedBy", DbType.String, ssENProposalLineApprovalLevel.ssRejectedBy);

}
insertSqlCmd.CreateParameter("@ssRejectedOn", DbType.DateTime, ssENProposalLineApprovalLevel.ssRejectedOn);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateProposalLineApprovalLevel", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENProposalLineApprovalLevel.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeProposalLineApprovalLevel
/// </summary>

public static async Task CreateOrUpdateSomeProposalLineApprovalLevel(IRequestContext requestContext,RL_cb657a85ad5767a90a0cf2a0623ecec3 inParamSourceList,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateSomeProposalLineApprovalLevel", "a810edd3-3ebe-4591-833e-78d2c483942e.#CreateOrUpdateAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeProposalLineApprovalLevel", "a810edd3-3ebe-4591-833e-78d2c483942e.#CreateOrUpdateAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
string entityTableName = ENProposalLineApprovalLevelEntity.LocalViewName(null);
string insertSql = "INSERT INTO " + entityTableName + " (" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@ProposalLineId, "proposallineid") ?? "proposallineid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@ProposalApprovalLevelId, "proposalapprovallevelid") ?? "proposalapprovallevelid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@ApprovalStatusId, "approvalstatusid") ?? "approvalstatusid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@ApprovedBy, "approvedby") ?? "approvedby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@ApprovedOn, "approvedon") ?? "approvedon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@RejectedBy, "rejectedby") ?? "rejectedby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@RejectedOn, "rejectedon") ?? "rejectedon") + ") VALUES ( unnest(@ssProposalLineId),  unnest(@ssProposalApprovalLevelId),  unnest(@ssApplicationRoleId),  unnest(@ssApprovalStatusId),  unnest(@ssApprovedBy),  unnest(@ssApprovedOn),  unnest(@ssRejectedBy),  unnest(@ssRejectedOn)) ";
insertSql += "";

string updateSql = "UPDATE " + entityTableName + " SET " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@ProposalLineId, "proposallineid") ?? "proposallineid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@ProposalLineId, "proposallineid") ?? "proposallineid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@ProposalApprovalLevelId, "proposalapprovallevelid") ?? "proposalapprovallevelid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@ProposalApprovalLevelId, "proposalapprovallevelid") ?? "proposalapprovallevelid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@ApprovalStatusId, "approvalstatusid") ?? "approvalstatusid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@ApprovalStatusId, "approvalstatusid") ?? "approvalstatusid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@ApprovedBy, "approvedby") ?? "approvedby") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@ApprovedBy, "approvedby") ?? "approvedby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@ApprovedOn, "approvedon") ?? "approvedon") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@ApprovedOn, "approvedon") ?? "approvedon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@RejectedBy, "rejectedby") ?? "rejectedby") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@RejectedBy, "rejectedby") ?? "rejectedby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@RejectedOn, "rejectedon") ?? "rejectedon") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@RejectedOn, "rejectedon") ?? "rejectedon") + " from ( select  unnest(@ssId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@Id, "id") ?? "id") + ",  unnest(@ssProposalLineId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@ProposalLineId, "proposallineid") ?? "proposallineid") + ",  unnest(@ssProposalApprovalLevelId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@ProposalApprovalLevelId, "proposalapprovallevelid") ?? "proposalapprovallevelid") + ",  unnest(@ssApplicationRoleId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid") + ",  unnest(@ssApprovalStatusId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@ApprovalStatusId, "approvalstatusid") ?? "approvalstatusid") + ",  unnest(@ssApprovedBy) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@ApprovedBy, "approvedby") ?? "approvedby") + ",  unnest(@ssApprovedOn) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@ApprovedOn, "approvedon") ?? "approvedon") + ",  unnest(@ssRejectedBy) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@RejectedBy, "rejectedby") ?? "rejectedby") + ",  unnest(@ssRejectedOn) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@RejectedOn, "rejectedon") ?? "rejectedon") + " ) as updateTable where " + entityTableName + "." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@Id, "id") ?? "id") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@Id, "id") ?? "id") + " ";
updateSql += "";

List<object> insertProposalLineIdList = new List<object>();
List<object> insertProposalApprovalLevelIdList = new List<object>();
List<object> insertApplicationRoleIdList = new List<object>();
List<object> insertApprovalStatusIdList = new List<object>();
List<object> insertApprovedByList = new List<object>();
List<DateTime> insertApprovedOnList = new List<DateTime>();
List<object> insertRejectedByList = new List<object>();
List<DateTime> insertRejectedOnList = new List<DateTime>();

List<long> updateIdList = new List<long>();
List<object> updateProposalLineIdList = new List<object>();
List<object> updateProposalApprovalLevelIdList = new List<object>();
List<object> updateApplicationRoleIdList = new List<object>();
List<object> updateApprovalStatusIdList = new List<object>();
List<object> updateApprovedByList = new List<object>();
List<DateTime> updateApprovedOnList = new List<DateTime>();
List<object> updateRejectedByList = new List<object>();
List<DateTime> updateRejectedOnList = new List<DateTime>();

var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_875fb45d4123a91fce83831f0f554d8e)inParamSourceList.Current).ssENProposalLineApprovalLevel;
if (record.ssId != 0L) {
updateIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
if ((record.ssProposalLineId==0L)) {
updateProposalLineIdList.Add(null);
} else {
updateProposalLineIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssProposalLineId));
}
if ((record.ssProposalApprovalLevelId==0L)) {
updateProposalApprovalLevelIdList.Add(null);
} else {
updateProposalApprovalLevelIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssProposalApprovalLevelId));
}
if ((record.ssApplicationRoleId==0L)) {
updateApplicationRoleIdList.Add(null);
} else {
updateApplicationRoleIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssApplicationRoleId));
}
if ((record.ssApprovalStatusId==0)) {
updateApprovalStatusIdList.Add(null);
} else {
updateApprovalStatusIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssApprovalStatusId));
}
if ((record.ssApprovedBy=="")) {
updateApprovedByList.Add(null);
} else {
updateApprovedByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssApprovedBy));
}
updateApprovedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssApprovedOn));
if ((record.ssRejectedBy=="")) {
updateRejectedByList.Add(null);
} else {
updateRejectedByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssRejectedBy));
}
updateRejectedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssRejectedOn));
} else {
if ((record.ssProposalLineId==0L)) {
insertProposalLineIdList.Add(null);
} else {
insertProposalLineIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssProposalLineId));
}
if ((record.ssProposalApprovalLevelId==0L)) {
insertProposalApprovalLevelIdList.Add(null);
} else {
insertProposalApprovalLevelIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssProposalApprovalLevelId));
}
if ((record.ssApplicationRoleId==0L)) {
insertApplicationRoleIdList.Add(null);
} else {
insertApplicationRoleIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssApplicationRoleId));
}
if ((record.ssApprovalStatusId==0)) {
insertApprovalStatusIdList.Add(null);
} else {
insertApprovalStatusIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssApprovalStatusId));
}
if ((record.ssApprovedBy=="")) {
insertApprovedByList.Add(null);
} else {
insertApprovedByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssApprovedBy));
}
insertApprovedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssApprovedOn));
if ((record.ssRejectedBy=="")) {
insertRejectedByList.Add(null);
} else {
insertRejectedByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssRejectedBy));
}
insertRejectedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssRejectedOn));
}
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertProposalLineIdList.IsEmpty() || !insertProposalApprovalLevelIdList.IsEmpty() || !insertApplicationRoleIdList.IsEmpty() || !insertApprovalStatusIdList.IsEmpty() || !insertApprovedByList.IsEmpty() || !insertApprovedOnList.IsEmpty() || !insertRejectedByList.IsEmpty() || !insertRejectedOnList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssProposalLineId",DbType.Int64,insertProposalLineIdList);
executionService.CreateParameter(insertSqlCmd,"@ssProposalApprovalLevelId",DbType.Int64,insertProposalApprovalLevelIdList);
executionService.CreateParameter(insertSqlCmd,"@ssApplicationRoleId",DbType.Int64,insertApplicationRoleIdList);
executionService.CreateParameter(insertSqlCmd,"@ssApprovalStatusId",DbType.Int32,insertApprovalStatusIdList);
executionService.CreateParameter(insertSqlCmd,"@ssApprovedBy",DbType.String,insertApprovedByList);
executionService.CreateParameter(insertSqlCmd,"@ssApprovedOn",DbType.DateTime,insertApprovedOnList);
executionService.CreateParameter(insertSqlCmd,"@ssRejectedBy",DbType.String,insertRejectedByList);
executionService.CreateParameter(insertSqlCmd,"@ssRejectedOn",DbType.DateTime,insertRejectedOnList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeProposalLineApprovalLevel (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
if(!updateProposalLineIdList.IsEmpty() || !updateProposalApprovalLevelIdList.IsEmpty() || !updateApplicationRoleIdList.IsEmpty() || !updateApprovalStatusIdList.IsEmpty() || !updateApprovedByList.IsEmpty() || !updateApprovedOnList.IsEmpty() || !updateRejectedByList.IsEmpty() || !updateRejectedOnList.IsEmpty()){
await using(var updateSqlCmd = trans.CreateCommand(updateSql)){
executionService.CreateParameter(updateSqlCmd,"@ssId",DbType.Int64,updateIdList);
executionService.CreateParameter(updateSqlCmd,"@ssProposalLineId",DbType.Int64,updateProposalLineIdList);
executionService.CreateParameter(updateSqlCmd,"@ssProposalApprovalLevelId",DbType.Int64,updateProposalApprovalLevelIdList);
executionService.CreateParameter(updateSqlCmd,"@ssApplicationRoleId",DbType.Int64,updateApplicationRoleIdList);
executionService.CreateParameter(updateSqlCmd,"@ssApprovalStatusId",DbType.Int32,updateApprovalStatusIdList);
executionService.CreateParameter(updateSqlCmd,"@ssApprovedBy",DbType.String,updateApprovedByList);
executionService.CreateParameter(updateSqlCmd,"@ssApprovedOn",DbType.DateTime,updateApprovedOnList);
executionService.CreateParameter(updateSqlCmd,"@ssRejectedBy",DbType.String,updateRejectedByList);
executionService.CreateParameter(updateSqlCmd,"@ssRejectedOn",DbType.DateTime,updateRejectedOnList);
await updateSqlCmd.PrepareAsync(cancellationToken);
await updateSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeProposalLineApprovalLevel (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(updateSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteProposalLineApprovalLevel
/// </summary>

public static async Task DeleteProposalLineApprovalLevel(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteProposalLineApprovalLevel", "a810edd3-3ebe-4591-833e-78d2c483942e.#DeleteEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteProposalLineApprovalLevel", "a810edd3-3ebe-4591-833e-78d2c483942e.#DeleteEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENProposalLineApprovalLevelEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteProposalLineApprovalLevel", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllProposalLineApprovalLevel
/// </summary>

public static async Task DeleteAllProposalLineApprovalLevel(IRequestContext requestContext,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteAllProposalLineApprovalLevel", "a810edd3-3ebe-4591-833e-78d2c483942e.#DeleteAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllProposalLineApprovalLevel", "a810edd3-3ebe-4591-833e-78d2c483942e.#DeleteAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENProposalLineApprovalLevelEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteProposalLineApprovalLevel", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetProposalLineApprovalLevel
/// </summary>

public static async Task<RC_875fb45d4123a91fce83831f0f554d8e> GetProposalLineApprovalLevel(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_875fb45d4123a91fce83831f0f554d8e outParamRecord = default;
outParamRecord = new RC_875fb45d4123a91fce83831f0f554d8e();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetProposalLineApprovalLevel", "a810edd3-3ebe-4591-833e-78d2c483942e.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetProposalLineApprovalLevel", "a810edd3-3ebe-4591-833e-78d2c483942e.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@ProposalLineId, "proposallineid") ?? "proposallineid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@ProposalApprovalLevelId, "proposalapprovallevelid") ?? "proposalapprovallevelid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@ApprovalStatusId, "approvalstatusid") ?? "approvalstatusid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@ApprovedBy, "approvedby") ?? "approvedby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@ApprovedOn, "approvedon") ?? "approvedon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@RejectedBy, "rejectedby") ?? "rejectedby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@RejectedOn, "rejectedon") ?? "rejectedon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
" FROM " + ENProposalLineApprovalLevelEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetProposalLineApprovalLevel", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(9,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENProposalLineApprovalLevelEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetProposalLineApprovalLevelForUpdate
/// </summary>

public static async Task<RC_875fb45d4123a91fce83831f0f554d8e> GetProposalLineApprovalLevelForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_875fb45d4123a91fce83831f0f554d8e outParamRecord = default;
outParamRecord = new RC_875fb45d4123a91fce83831f0f554d8e();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetProposalLineApprovalLevelForUpdate", "a810edd3-3ebe-4591-833e-78d2c483942e.#GetEntityForUpdate");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetProposalLineApprovalLevelForUpdate", "a810edd3-3ebe-4591-833e-78d2c483942e.#GetEntityForUpdate", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@ProposalLineId, "proposallineid") ?? "proposallineid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@ProposalApprovalLevelId, "proposalapprovallevelid") ?? "proposalapprovallevelid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@ApprovalStatusId, "approvalstatusid") ?? "approvalstatusid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@ApprovedBy, "approvedby") ?? "approvedby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@ApprovedOn, "approvedon") ?? "approvedon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@RejectedBy, "rejectedby") ?? "rejectedby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@RejectedOn, "rejectedon") ?? "rejectedon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
" FROM " + ENProposalLineApprovalLevelEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@Id, "id") ?? "id") + " = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetProposalLineApprovalLevelForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(9,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENProposalLineApprovalLevelEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateProposalLineApprovalLevel
/// </summary>

public static async Task UpdateProposalLineApprovalLevel(IRequestContext requestContext,BitArray usedFields,RC_875fb45d4123a91fce83831f0f554d8e inParamSource,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("UpdateProposalLineApprovalLevel", "a810edd3-3ebe-4591-833e-78d2c483942e.#UpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateProposalLineApprovalLevel", "a810edd3-3ebe-4591-833e-78d2c483942e.#UpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord ssENProposalLineApprovalLevel = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(9,true);
}
string updateSet = "UPDATE " + ENProposalLineApprovalLevelEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@ProposalLineId, "proposallineid") ?? "proposallineid") + " = @ssProposalLineId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@ProposalApprovalLevelId, "proposalapprovallevelid") ?? "proposalapprovallevelid") + " = @ssProposalApprovalLevelId"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid") + " = @ssApplicationRoleId"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@ApprovalStatusId, "approvalstatusid") ?? "approvalstatusid") + " = @ssApprovalStatusId"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@ApprovedBy, "approvedby") ?? "approvedby") + " = @ssApprovedBy"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@ApprovedOn, "approvedon") ?? "approvedon") + " = @ssApprovedOn"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@RejectedBy, "rejectedby") ?? "rejectedby") + " = @ssRejectedBy"): parameters);
parameters = (usedFields[8] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@RejectedOn, "rejectedon") ?? "rejectedon") + " = @ssRejectedOn"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENProposalLiApprovalLevel_sd_ProposalLinepprovalLevel";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@ApprovalStatusId, "approvalstatusid") ?? "approvalstatusid") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@ApprovalStatusId, "approvalstatusid") ?? "approvalstatusid") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENProposalLineApprovalLevel.ssProposalLineId==0L)) {
sqlCmd.CreateParameter("@ssProposalLineId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssProposalLineId", DbType.Int64, ssENProposalLineApprovalLevel.ssProposalLineId);

}
}
if(usedFields[2]) {
if ((ssENProposalLineApprovalLevel.ssProposalApprovalLevelId==0L)) {
sqlCmd.CreateParameter("@ssProposalApprovalLevelId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssProposalApprovalLevelId", DbType.Int64, ssENProposalLineApprovalLevel.ssProposalApprovalLevelId);

}
}
if(usedFields[3]) {
if ((ssENProposalLineApprovalLevel.ssApplicationRoleId==0L)) {
sqlCmd.CreateParameter("@ssApplicationRoleId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssApplicationRoleId", DbType.Int64, ssENProposalLineApprovalLevel.ssApplicationRoleId);

}
}
if(usedFields[4]) {
if ((ssENProposalLineApprovalLevel.ssApprovalStatusId==0)) {
sqlCmd.CreateParameter("@ssApprovalStatusId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssApprovalStatusId", DbType.Int32, ssENProposalLineApprovalLevel.ssApprovalStatusId);

}
}
if(usedFields[5]) {
if ((ssENProposalLineApprovalLevel.ssApprovedBy=="")) {
sqlCmd.CreateParameter("@ssApprovedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssApprovedBy", DbType.String, ssENProposalLineApprovalLevel.ssApprovedBy);

}
}
if(usedFields[6]) {
sqlCmd.CreateParameter("@ssApprovedOn", DbType.DateTime, ssENProposalLineApprovalLevel.ssApprovedOn);
}
if(usedFields[7]) {
if ((ssENProposalLineApprovalLevel.ssRejectedBy=="")) {
sqlCmd.CreateParameter("@ssRejectedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssRejectedBy", DbType.String, ssENProposalLineApprovalLevel.ssRejectedBy);

}
}
if(usedFields[8]) {
sqlCmd.CreateParameter("@ssRejectedOn", DbType.DateTime, ssENProposalLineApprovalLevel.ssRejectedOn);
}
sqlCmd.CreateParameter("@idparam_ssENProposalLiApprovalLevel_sd_ProposalLinepprovalLevel", DbType.Int64, ssENProposalLineApprovalLevel.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateProposalLineApprovalLevel", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("ProposalLineApprovalLevel", ssENProposalLineApprovalLevel.ssId.ToString()); }}
}
return;
}

}
}
