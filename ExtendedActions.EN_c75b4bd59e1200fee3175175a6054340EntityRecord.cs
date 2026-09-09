using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateProposalComment
/// </summary>

public static async Task<long> CreateProposalComment(IRequestContext requestContext,RC_cd5101cd31ffd8dc09aecaca6d77004a inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateProposalComment", "a5a4bad7-74d8-4843-bfeb-815b3d216d00.#CreateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateProposalComment", "a5a4bad7-74d8-4843-bfeb-815b3d216d00.#CreateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_c75b4bd59e1200fee3175175a6054340EntityRecord ssENProposalComment = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENProposalCommentEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@CommentTypeId, "commenttypeid") ?? "commenttypeid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@ProposalId, "proposalid") ?? "proposalid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@ProposalLineId, "proposallineid") ?? "proposallineid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@ProposalLineApprovalLevelId, "proposallineapprovallevelid") ?? "proposallineapprovallevelid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@Message, "message") ?? "message") + "" +
" ) VALUES (" +
" @ssCommentTypeId" +
", @ssProposalId" +
", @ssProposalLineId" +
", @ssProposalLineApprovalLevelId" +
", @ssApplicationRoleId" +
", @ssCreatedBy" +
", @ssMessage" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENProposalComment.ssCommentTypeId==0)) {
insertSqlCmd.CreateParameter("@ssCommentTypeId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCommentTypeId", DbType.Int32, ssENProposalComment.ssCommentTypeId);

}
if ((ssENProposalComment.ssProposalId==0L)) {
insertSqlCmd.CreateParameter("@ssProposalId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssProposalId", DbType.Int64, ssENProposalComment.ssProposalId);

}
if ((ssENProposalComment.ssProposalLineId==0L)) {
insertSqlCmd.CreateParameter("@ssProposalLineId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssProposalLineId", DbType.Int64, ssENProposalComment.ssProposalLineId);

}
if ((ssENProposalComment.ssProposalLineApprovalLevelId==0L)) {
insertSqlCmd.CreateParameter("@ssProposalLineApprovalLevelId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssProposalLineApprovalLevelId", DbType.Int64, ssENProposalComment.ssProposalLineApprovalLevelId);

}
if ((ssENProposalComment.ssApplicationRoleId==0L)) {
insertSqlCmd.CreateParameter("@ssApplicationRoleId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssApplicationRoleId", DbType.Int64, ssENProposalComment.ssApplicationRoleId);

}
if ((ssENProposalComment.ssCreatedBy=="")) {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENProposalComment.ssCreatedBy);

}
insertSqlCmd.CreateParameter("@ssMessage", DbType.String, ssENProposalComment.ssMessage);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateProposalComment", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateProposalComment
/// </summary>

public static async Task<long> CreateOrUpdateProposalComment(IRequestContext requestContext,BitArray usedFields,RC_cd5101cd31ffd8dc09aecaca6d77004a inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateProposalComment", "a5a4bad7-74d8-4843-bfeb-815b3d216d00.#CreateOrUpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateProposalComment", "a5a4bad7-74d8-4843-bfeb-815b3d216d00.#CreateOrUpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_c75b4bd59e1200fee3175175a6054340EntityRecord ssENProposalComment = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(8,true);
}
string updateSet = "UPDATE " + ENProposalCommentEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@CommentTypeId, "commenttypeid") ?? "commenttypeid") + " = @ssCommentTypeId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@ProposalId, "proposalid") ?? "proposalid") + " = @ssProposalId"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@ProposalLineId, "proposallineid") ?? "proposallineid") + " = @ssProposalLineId"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@ProposalLineApprovalLevelId, "proposallineapprovallevelid") ?? "proposallineapprovallevelid") + " = @ssProposalLineApprovalLevelId"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid") + " = @ssApplicationRoleId"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = @ssCreatedBy"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@Message, "message") ?? "message") + " = @ssMessage"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENProposalComment_ssId_ProposalComment";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENProposalComment.ssCommentTypeId==0)) {
sqlCmd.CreateParameter("@ssCommentTypeId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCommentTypeId", DbType.Int32, ssENProposalComment.ssCommentTypeId);

}
}
if(usedFields[2]) {
if ((ssENProposalComment.ssProposalId==0L)) {
sqlCmd.CreateParameter("@ssProposalId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssProposalId", DbType.Int64, ssENProposalComment.ssProposalId);

}
}
if(usedFields[3]) {
if ((ssENProposalComment.ssProposalLineId==0L)) {
sqlCmd.CreateParameter("@ssProposalLineId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssProposalLineId", DbType.Int64, ssENProposalComment.ssProposalLineId);

}
}
if(usedFields[4]) {
if ((ssENProposalComment.ssProposalLineApprovalLevelId==0L)) {
sqlCmd.CreateParameter("@ssProposalLineApprovalLevelId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssProposalLineApprovalLevelId", DbType.Int64, ssENProposalComment.ssProposalLineApprovalLevelId);

}
}
if(usedFields[5]) {
if ((ssENProposalComment.ssApplicationRoleId==0L)) {
sqlCmd.CreateParameter("@ssApplicationRoleId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssApplicationRoleId", DbType.Int64, ssENProposalComment.ssApplicationRoleId);

}
}
if(usedFields[6]) {
if ((ssENProposalComment.ssCreatedBy=="")) {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENProposalComment.ssCreatedBy);

}
}
if(usedFields[7]) {
sqlCmd.CreateParameter("@ssMessage", DbType.String, ssENProposalComment.ssMessage);
}
sqlCmd.CreateParameter("@idparam_ssENProposalComment_ssId_ProposalComment", DbType.Int64, ssENProposalComment.ssId);
int counter = 0;
if(ssENProposalComment.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateProposalComment (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENProposalCommentEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@CommentTypeId, "commenttypeid") ?? "commenttypeid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@ProposalId, "proposalid") ?? "proposalid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@ProposalLineId, "proposallineid") ?? "proposallineid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@ProposalLineApprovalLevelId, "proposallineapprovallevelid") ?? "proposallineapprovallevelid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@Message, "message") ?? "message") + "" +
" ) VALUES (" +
" @ssCommentTypeId" +
", @ssProposalId" +
", @ssProposalLineId" +
", @ssProposalLineApprovalLevelId" +
", @ssApplicationRoleId" +
", @ssCreatedBy" +
", @ssMessage" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENProposalComment.ssCommentTypeId==0)) {
insertSqlCmd.CreateParameter("@ssCommentTypeId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCommentTypeId", DbType.Int32, ssENProposalComment.ssCommentTypeId);

}
if ((ssENProposalComment.ssProposalId==0L)) {
insertSqlCmd.CreateParameter("@ssProposalId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssProposalId", DbType.Int64, ssENProposalComment.ssProposalId);

}
if ((ssENProposalComment.ssProposalLineId==0L)) {
insertSqlCmd.CreateParameter("@ssProposalLineId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssProposalLineId", DbType.Int64, ssENProposalComment.ssProposalLineId);

}
if ((ssENProposalComment.ssProposalLineApprovalLevelId==0L)) {
insertSqlCmd.CreateParameter("@ssProposalLineApprovalLevelId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssProposalLineApprovalLevelId", DbType.Int64, ssENProposalComment.ssProposalLineApprovalLevelId);

}
if ((ssENProposalComment.ssApplicationRoleId==0L)) {
insertSqlCmd.CreateParameter("@ssApplicationRoleId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssApplicationRoleId", DbType.Int64, ssENProposalComment.ssApplicationRoleId);

}
if ((ssENProposalComment.ssCreatedBy=="")) {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENProposalComment.ssCreatedBy);

}
insertSqlCmd.CreateParameter("@ssMessage", DbType.String, ssENProposalComment.ssMessage);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateProposalComment", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENProposalComment.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeProposalComment
/// </summary>

public static async Task CreateOrUpdateSomeProposalComment(IRequestContext requestContext,RL_6f7a73531f09191ac235a09fbbea38a5 inParamSourceList,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateSomeProposalComment", "a5a4bad7-74d8-4843-bfeb-815b3d216d00.#CreateOrUpdateAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeProposalComment", "a5a4bad7-74d8-4843-bfeb-815b3d216d00.#CreateOrUpdateAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
string entityTableName = ENProposalCommentEntity.LocalViewName(null);
string insertSql = "INSERT INTO " + entityTableName + " (" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@CommentTypeId, "commenttypeid") ?? "commenttypeid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@ProposalId, "proposalid") ?? "proposalid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@ProposalLineId, "proposallineid") ?? "proposallineid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@ProposalLineApprovalLevelId, "proposallineapprovallevelid") ?? "proposallineapprovallevelid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@Message, "message") ?? "message") + ") VALUES ( unnest(@ssCommentTypeId),  unnest(@ssProposalId),  unnest(@ssProposalLineId),  unnest(@ssProposalLineApprovalLevelId),  unnest(@ssApplicationRoleId),  unnest(@ssCreatedBy),  unnest(@ssMessage)) ";
insertSql += "";

string updateSql = "UPDATE " + entityTableName + " SET " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@CommentTypeId, "commenttypeid") ?? "commenttypeid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@CommentTypeId, "commenttypeid") ?? "commenttypeid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@ProposalId, "proposalid") ?? "proposalid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@ProposalId, "proposalid") ?? "proposalid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@ProposalLineId, "proposallineid") ?? "proposallineid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@ProposalLineId, "proposallineid") ?? "proposallineid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@ProposalLineApprovalLevelId, "proposallineapprovallevelid") ?? "proposallineapprovallevelid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@ProposalLineApprovalLevelId, "proposallineapprovallevelid") ?? "proposallineapprovallevelid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@Message, "message") ?? "message") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@Message, "message") ?? "message") + " from ( select  unnest(@ssId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@Id, "id") ?? "id") + ",  unnest(@ssCommentTypeId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@CommentTypeId, "commenttypeid") ?? "commenttypeid") + ",  unnest(@ssProposalId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@ProposalId, "proposalid") ?? "proposalid") + ",  unnest(@ssProposalLineId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@ProposalLineId, "proposallineid") ?? "proposallineid") + ",  unnest(@ssProposalLineApprovalLevelId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@ProposalLineApprovalLevelId, "proposallineapprovallevelid") ?? "proposallineapprovallevelid") + ",  unnest(@ssApplicationRoleId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid") + ",  unnest(@ssCreatedBy) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + ",  unnest(@ssMessage) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@Message, "message") ?? "message") + " ) as updateTable where " + entityTableName + "." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@Id, "id") ?? "id") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@Id, "id") ?? "id") + " ";
updateSql += "";

List<object> insertCommentTypeIdList = new List<object>();
List<object> insertProposalIdList = new List<object>();
List<object> insertProposalLineIdList = new List<object>();
List<object> insertProposalLineApprovalLevelIdList = new List<object>();
List<object> insertApplicationRoleIdList = new List<object>();
List<object> insertCreatedByList = new List<object>();
List<string> insertMessageList = new List<string>();

List<long> updateIdList = new List<long>();
List<object> updateCommentTypeIdList = new List<object>();
List<object> updateProposalIdList = new List<object>();
List<object> updateProposalLineIdList = new List<object>();
List<object> updateProposalLineApprovalLevelIdList = new List<object>();
List<object> updateApplicationRoleIdList = new List<object>();
List<object> updateCreatedByList = new List<object>();
List<string> updateMessageList = new List<string>();

var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_cd5101cd31ffd8dc09aecaca6d77004a)inParamSourceList.Current).ssENProposalComment;
if (record.ssId != 0L) {
updateIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
if ((record.ssCommentTypeId==0)) {
updateCommentTypeIdList.Add(null);
} else {
updateCommentTypeIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssCommentTypeId));
}
if ((record.ssProposalId==0L)) {
updateProposalIdList.Add(null);
} else {
updateProposalIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssProposalId));
}
if ((record.ssProposalLineId==0L)) {
updateProposalLineIdList.Add(null);
} else {
updateProposalLineIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssProposalLineId));
}
if ((record.ssProposalLineApprovalLevelId==0L)) {
updateProposalLineApprovalLevelIdList.Add(null);
} else {
updateProposalLineApprovalLevelIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssProposalLineApprovalLevelId));
}
if ((record.ssApplicationRoleId==0L)) {
updateApplicationRoleIdList.Add(null);
} else {
updateApplicationRoleIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssApplicationRoleId));
}
if ((record.ssCreatedBy=="")) {
updateCreatedByList.Add(null);
} else {
updateCreatedByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssCreatedBy));
}
updateMessageList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssMessage));
} else {
if ((record.ssCommentTypeId==0)) {
insertCommentTypeIdList.Add(null);
} else {
insertCommentTypeIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssCommentTypeId));
}
if ((record.ssProposalId==0L)) {
insertProposalIdList.Add(null);
} else {
insertProposalIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssProposalId));
}
if ((record.ssProposalLineId==0L)) {
insertProposalLineIdList.Add(null);
} else {
insertProposalLineIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssProposalLineId));
}
if ((record.ssProposalLineApprovalLevelId==0L)) {
insertProposalLineApprovalLevelIdList.Add(null);
} else {
insertProposalLineApprovalLevelIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssProposalLineApprovalLevelId));
}
if ((record.ssApplicationRoleId==0L)) {
insertApplicationRoleIdList.Add(null);
} else {
insertApplicationRoleIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssApplicationRoleId));
}
if ((record.ssCreatedBy=="")) {
insertCreatedByList.Add(null);
} else {
insertCreatedByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssCreatedBy));
}
insertMessageList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssMessage));
}
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertCommentTypeIdList.IsEmpty() || !insertProposalIdList.IsEmpty() || !insertProposalLineIdList.IsEmpty() || !insertProposalLineApprovalLevelIdList.IsEmpty() || !insertApplicationRoleIdList.IsEmpty() || !insertCreatedByList.IsEmpty() || !insertMessageList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssCommentTypeId",DbType.Int32,insertCommentTypeIdList);
executionService.CreateParameter(insertSqlCmd,"@ssProposalId",DbType.Int64,insertProposalIdList);
executionService.CreateParameter(insertSqlCmd,"@ssProposalLineId",DbType.Int64,insertProposalLineIdList);
executionService.CreateParameter(insertSqlCmd,"@ssProposalLineApprovalLevelId",DbType.Int64,insertProposalLineApprovalLevelIdList);
executionService.CreateParameter(insertSqlCmd,"@ssApplicationRoleId",DbType.Int64,insertApplicationRoleIdList);
executionService.CreateParameter(insertSqlCmd,"@ssCreatedBy",DbType.String,insertCreatedByList);
executionService.CreateParameter(insertSqlCmd,"@ssMessage",DbType.String,insertMessageList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeProposalComment (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
if(!updateCommentTypeIdList.IsEmpty() || !updateProposalIdList.IsEmpty() || !updateProposalLineIdList.IsEmpty() || !updateProposalLineApprovalLevelIdList.IsEmpty() || !updateApplicationRoleIdList.IsEmpty() || !updateCreatedByList.IsEmpty() || !updateMessageList.IsEmpty()){
await using(var updateSqlCmd = trans.CreateCommand(updateSql)){
executionService.CreateParameter(updateSqlCmd,"@ssId",DbType.Int64,updateIdList);
executionService.CreateParameter(updateSqlCmd,"@ssCommentTypeId",DbType.Int32,updateCommentTypeIdList);
executionService.CreateParameter(updateSqlCmd,"@ssProposalId",DbType.Int64,updateProposalIdList);
executionService.CreateParameter(updateSqlCmd,"@ssProposalLineId",DbType.Int64,updateProposalLineIdList);
executionService.CreateParameter(updateSqlCmd,"@ssProposalLineApprovalLevelId",DbType.Int64,updateProposalLineApprovalLevelIdList);
executionService.CreateParameter(updateSqlCmd,"@ssApplicationRoleId",DbType.Int64,updateApplicationRoleIdList);
executionService.CreateParameter(updateSqlCmd,"@ssCreatedBy",DbType.String,updateCreatedByList);
executionService.CreateParameter(updateSqlCmd,"@ssMessage",DbType.String,updateMessageList);
await updateSqlCmd.PrepareAsync(cancellationToken);
await updateSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeProposalComment (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(updateSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteProposalComment
/// </summary>

public static async Task DeleteProposalComment(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteProposalComment", "a5a4bad7-74d8-4843-bfeb-815b3d216d00.#DeleteEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteProposalComment", "a5a4bad7-74d8-4843-bfeb-815b3d216d00.#DeleteEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENProposalCommentEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteProposalComment", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllProposalComment
/// </summary>

public static async Task DeleteAllProposalComment(IRequestContext requestContext,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteAllProposalComment", "a5a4bad7-74d8-4843-bfeb-815b3d216d00.#DeleteAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllProposalComment", "a5a4bad7-74d8-4843-bfeb-815b3d216d00.#DeleteAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENProposalCommentEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteProposalComment", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetProposalComment
/// </summary>

public static async Task<RC_cd5101cd31ffd8dc09aecaca6d77004a> GetProposalComment(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_cd5101cd31ffd8dc09aecaca6d77004a outParamRecord = default;
outParamRecord = new RC_cd5101cd31ffd8dc09aecaca6d77004a();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetProposalComment", "a5a4bad7-74d8-4843-bfeb-815b3d216d00.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetProposalComment", "a5a4bad7-74d8-4843-bfeb-815b3d216d00.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@CommentTypeId, "commenttypeid") ?? "commenttypeid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@ProposalId, "proposalid") ?? "proposalid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@ProposalLineId, "proposallineid") ?? "proposallineid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@ProposalLineApprovalLevelId, "proposallineapprovallevelid") ?? "proposallineapprovallevelid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@CreatedBy, "createdby") ?? "createdby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@Message, "message") ?? "message", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
" FROM " + ENProposalCommentEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetProposalComment", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(8,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENProposalCommentEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetProposalCommentForUpdate
/// </summary>

public static async Task<RC_cd5101cd31ffd8dc09aecaca6d77004a> GetProposalCommentForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_cd5101cd31ffd8dc09aecaca6d77004a outParamRecord = default;
outParamRecord = new RC_cd5101cd31ffd8dc09aecaca6d77004a();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetProposalCommentForUpdate", "a5a4bad7-74d8-4843-bfeb-815b3d216d00.#GetEntityForUpdate");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetProposalCommentForUpdate", "a5a4bad7-74d8-4843-bfeb-815b3d216d00.#GetEntityForUpdate", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@CommentTypeId, "commenttypeid") ?? "commenttypeid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@ProposalId, "proposalid") ?? "proposalid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@ProposalLineId, "proposallineid") ?? "proposallineid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@ProposalLineApprovalLevelId, "proposallineapprovallevelid") ?? "proposallineapprovallevelid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@CreatedBy, "createdby") ?? "createdby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@Message, "message") ?? "message", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
" FROM " + ENProposalCommentEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@Id, "id") ?? "id") + " = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetProposalCommentForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(8,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENProposalCommentEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateProposalComment
/// </summary>

public static async Task UpdateProposalComment(IRequestContext requestContext,BitArray usedFields,RC_cd5101cd31ffd8dc09aecaca6d77004a inParamSource,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("UpdateProposalComment", "a5a4bad7-74d8-4843-bfeb-815b3d216d00.#UpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateProposalComment", "a5a4bad7-74d8-4843-bfeb-815b3d216d00.#UpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_c75b4bd59e1200fee3175175a6054340EntityRecord ssENProposalComment = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(8,true);
}
string updateSet = "UPDATE " + ENProposalCommentEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@CommentTypeId, "commenttypeid") ?? "commenttypeid") + " = @ssCommentTypeId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@ProposalId, "proposalid") ?? "proposalid") + " = @ssProposalId"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@ProposalLineId, "proposallineid") ?? "proposallineid") + " = @ssProposalLineId"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@ProposalLineApprovalLevelId, "proposallineapprovallevelid") ?? "proposallineapprovallevelid") + " = @ssProposalLineApprovalLevelId"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid") + " = @ssApplicationRoleId"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = @ssCreatedBy"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@Message, "message") ?? "message") + " = @ssMessage"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENProposalComment_ssId_ProposalComment";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENProposalComment.ssCommentTypeId==0)) {
sqlCmd.CreateParameter("@ssCommentTypeId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCommentTypeId", DbType.Int32, ssENProposalComment.ssCommentTypeId);

}
}
if(usedFields[2]) {
if ((ssENProposalComment.ssProposalId==0L)) {
sqlCmd.CreateParameter("@ssProposalId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssProposalId", DbType.Int64, ssENProposalComment.ssProposalId);

}
}
if(usedFields[3]) {
if ((ssENProposalComment.ssProposalLineId==0L)) {
sqlCmd.CreateParameter("@ssProposalLineId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssProposalLineId", DbType.Int64, ssENProposalComment.ssProposalLineId);

}
}
if(usedFields[4]) {
if ((ssENProposalComment.ssProposalLineApprovalLevelId==0L)) {
sqlCmd.CreateParameter("@ssProposalLineApprovalLevelId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssProposalLineApprovalLevelId", DbType.Int64, ssENProposalComment.ssProposalLineApprovalLevelId);

}
}
if(usedFields[5]) {
if ((ssENProposalComment.ssApplicationRoleId==0L)) {
sqlCmd.CreateParameter("@ssApplicationRoleId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssApplicationRoleId", DbType.Int64, ssENProposalComment.ssApplicationRoleId);

}
}
if(usedFields[6]) {
if ((ssENProposalComment.ssCreatedBy=="")) {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENProposalComment.ssCreatedBy);

}
}
if(usedFields[7]) {
sqlCmd.CreateParameter("@ssMessage", DbType.String, ssENProposalComment.ssMessage);
}
sqlCmd.CreateParameter("@idparam_ssENProposalComment_ssId_ProposalComment", DbType.Int64, ssENProposalComment.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateProposalComment", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("ProposalComment", ssENProposalComment.ssId.ToString()); }}
}
return;
}

}
}
