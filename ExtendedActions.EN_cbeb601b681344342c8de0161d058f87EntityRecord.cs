using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateRequisitionComment
/// </summary>

public static async Task<long> CreateRequisitionComment(IRequestContext requestContext,RC_08daffa670c72e7502779e59a7b292d3 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateRequisitionComment", "f2da5d7d-6966-4c0b-8288-ddeb4aec4033.#CreateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateRequisitionComment", "f2da5d7d-6966-4c0b-8288-ddeb4aec4033.#CreateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_cbeb601b681344342c8de0161d058f87EntityRecord ssENRequisitionComment = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENRequisitionCommentEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@CommentTypeId, "commenttypeid") ?? "commenttypeid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@RequisitionApprovalLevelId, "requisitionapprovallevelid") ?? "requisitionapprovallevelid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@Message, "message") ?? "message") + "" +
" ) VALUES (" +
" @ssCommentTypeId" +
", @ssRequisitionId" +
", @ssRequisitionApprovalLevelId" +
", @ssApplicationRoleId" +
", @ssCreatedOn" +
", @ssCreatedBy" +
", @ssMessage" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENRequisitionComment.ssCommentTypeId==0)) {
insertSqlCmd.CreateParameter("@ssCommentTypeId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCommentTypeId", DbType.Int32, ssENRequisitionComment.ssCommentTypeId);

}
if ((ssENRequisitionComment.ssRequisitionId==0L)) {
insertSqlCmd.CreateParameter("@ssRequisitionId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssRequisitionId", DbType.Int64, ssENRequisitionComment.ssRequisitionId);

}
if ((ssENRequisitionComment.ssRequisitionApprovalLevelId==0L)) {
insertSqlCmd.CreateParameter("@ssRequisitionApprovalLevelId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssRequisitionApprovalLevelId", DbType.Int64, ssENRequisitionComment.ssRequisitionApprovalLevelId);

}
if ((ssENRequisitionComment.ssApplicationRoleId==0L)) {
insertSqlCmd.CreateParameter("@ssApplicationRoleId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssApplicationRoleId", DbType.Int64, ssENRequisitionComment.ssApplicationRoleId);

}
insertSqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENRequisitionComment.ssCreatedOn);
if ((ssENRequisitionComment.ssCreatedBy=="")) {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENRequisitionComment.ssCreatedBy);

}
insertSqlCmd.CreateParameter("@ssMessage", DbType.String, ssENRequisitionComment.ssMessage);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateRequisitionComment", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateRequisitionComment
/// </summary>

public static async Task<long> CreateOrUpdateRequisitionComment(IRequestContext requestContext,BitArray usedFields,RC_08daffa670c72e7502779e59a7b292d3 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateRequisitionComment", "f2da5d7d-6966-4c0b-8288-ddeb4aec4033.#CreateOrUpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateRequisitionComment", "f2da5d7d-6966-4c0b-8288-ddeb4aec4033.#CreateOrUpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_cbeb601b681344342c8de0161d058f87EntityRecord ssENRequisitionComment = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(8,true);
}
string updateSet = "UPDATE " + ENRequisitionCommentEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@CommentTypeId, "commenttypeid") ?? "commenttypeid") + " = @ssCommentTypeId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid") + " = @ssRequisitionId"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@RequisitionApprovalLevelId, "requisitionapprovallevelid") ?? "requisitionapprovallevelid") + " = @ssRequisitionApprovalLevelId"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid") + " = @ssApplicationRoleId"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = @ssCreatedOn"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = @ssCreatedBy"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@Message, "message") ?? "message") + " = @ssMessage"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENRequisitionComment_ssId_RequisitionComment";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@CommentTypeId, "commenttypeid") ?? "commenttypeid") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@CommentTypeId, "commenttypeid") ?? "commenttypeid") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENRequisitionComment.ssCommentTypeId==0)) {
sqlCmd.CreateParameter("@ssCommentTypeId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCommentTypeId", DbType.Int32, ssENRequisitionComment.ssCommentTypeId);

}
}
if(usedFields[2]) {
if ((ssENRequisitionComment.ssRequisitionId==0L)) {
sqlCmd.CreateParameter("@ssRequisitionId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssRequisitionId", DbType.Int64, ssENRequisitionComment.ssRequisitionId);

}
}
if(usedFields[3]) {
if ((ssENRequisitionComment.ssRequisitionApprovalLevelId==0L)) {
sqlCmd.CreateParameter("@ssRequisitionApprovalLevelId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssRequisitionApprovalLevelId", DbType.Int64, ssENRequisitionComment.ssRequisitionApprovalLevelId);

}
}
if(usedFields[4]) {
if ((ssENRequisitionComment.ssApplicationRoleId==0L)) {
sqlCmd.CreateParameter("@ssApplicationRoleId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssApplicationRoleId", DbType.Int64, ssENRequisitionComment.ssApplicationRoleId);

}
}
if(usedFields[5]) {
sqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENRequisitionComment.ssCreatedOn);
}
if(usedFields[6]) {
if ((ssENRequisitionComment.ssCreatedBy=="")) {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENRequisitionComment.ssCreatedBy);

}
}
if(usedFields[7]) {
sqlCmd.CreateParameter("@ssMessage", DbType.String, ssENRequisitionComment.ssMessage);
}
sqlCmd.CreateParameter("@idparam_ssENRequisitionComment_ssId_RequisitionComment", DbType.Int64, ssENRequisitionComment.ssId);
int counter = 0;
if(ssENRequisitionComment.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateRequisitionComment (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENRequisitionCommentEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@CommentTypeId, "commenttypeid") ?? "commenttypeid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@RequisitionApprovalLevelId, "requisitionapprovallevelid") ?? "requisitionapprovallevelid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@Message, "message") ?? "message") + "" +
" ) VALUES (" +
" @ssCommentTypeId" +
", @ssRequisitionId" +
", @ssRequisitionApprovalLevelId" +
", @ssApplicationRoleId" +
", @ssCreatedOn" +
", @ssCreatedBy" +
", @ssMessage" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENRequisitionComment.ssCommentTypeId==0)) {
insertSqlCmd.CreateParameter("@ssCommentTypeId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCommentTypeId", DbType.Int32, ssENRequisitionComment.ssCommentTypeId);

}
if ((ssENRequisitionComment.ssRequisitionId==0L)) {
insertSqlCmd.CreateParameter("@ssRequisitionId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssRequisitionId", DbType.Int64, ssENRequisitionComment.ssRequisitionId);

}
if ((ssENRequisitionComment.ssRequisitionApprovalLevelId==0L)) {
insertSqlCmd.CreateParameter("@ssRequisitionApprovalLevelId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssRequisitionApprovalLevelId", DbType.Int64, ssENRequisitionComment.ssRequisitionApprovalLevelId);

}
if ((ssENRequisitionComment.ssApplicationRoleId==0L)) {
insertSqlCmd.CreateParameter("@ssApplicationRoleId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssApplicationRoleId", DbType.Int64, ssENRequisitionComment.ssApplicationRoleId);

}
insertSqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENRequisitionComment.ssCreatedOn);
if ((ssENRequisitionComment.ssCreatedBy=="")) {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENRequisitionComment.ssCreatedBy);

}
insertSqlCmd.CreateParameter("@ssMessage", DbType.String, ssENRequisitionComment.ssMessage);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateRequisitionComment", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENRequisitionComment.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeRequisitionComment
/// </summary>

public static async Task CreateOrUpdateSomeRequisitionComment(IRequestContext requestContext,RL_3933323760320045e42588bf0a23c855 inParamSourceList,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateSomeRequisitionComment", "f2da5d7d-6966-4c0b-8288-ddeb4aec4033.#CreateOrUpdateAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeRequisitionComment", "f2da5d7d-6966-4c0b-8288-ddeb4aec4033.#CreateOrUpdateAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
string entityTableName = ENRequisitionCommentEntity.LocalViewName(null);
string insertSql = "INSERT INTO " + entityTableName + " (" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@CommentTypeId, "commenttypeid") ?? "commenttypeid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@RequisitionApprovalLevelId, "requisitionapprovallevelid") ?? "requisitionapprovallevelid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@Message, "message") ?? "message") + ") VALUES ( unnest(@ssCommentTypeId),  unnest(@ssRequisitionId),  unnest(@ssRequisitionApprovalLevelId),  unnest(@ssApplicationRoleId),  unnest(@ssCreatedOn),  unnest(@ssCreatedBy),  unnest(@ssMessage)) ";
insertSql += "";

string updateSql = "UPDATE " + entityTableName + " SET " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@CommentTypeId, "commenttypeid") ?? "commenttypeid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@CommentTypeId, "commenttypeid") ?? "commenttypeid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@RequisitionApprovalLevelId, "requisitionapprovallevelid") ?? "requisitionapprovallevelid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@RequisitionApprovalLevelId, "requisitionapprovallevelid") ?? "requisitionapprovallevelid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@Message, "message") ?? "message") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@Message, "message") ?? "message") + " from ( select  unnest(@ssId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@Id, "id") ?? "id") + ",  unnest(@ssCommentTypeId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@CommentTypeId, "commenttypeid") ?? "commenttypeid") + ",  unnest(@ssRequisitionId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid") + ",  unnest(@ssRequisitionApprovalLevelId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@RequisitionApprovalLevelId, "requisitionapprovallevelid") ?? "requisitionapprovallevelid") + ",  unnest(@ssApplicationRoleId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid") + ",  unnest(@ssCreatedOn) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + ",  unnest(@ssCreatedBy) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + ",  unnest(@ssMessage) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@Message, "message") ?? "message") + " ) as updateTable where " + entityTableName + "." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@Id, "id") ?? "id") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@Id, "id") ?? "id") + " ";
updateSql += "";

List<object> insertCommentTypeIdList = new List<object>();
List<object> insertRequisitionIdList = new List<object>();
List<object> insertRequisitionApprovalLevelIdList = new List<object>();
List<object> insertApplicationRoleIdList = new List<object>();
List<DateTime> insertCreatedOnList = new List<DateTime>();
List<object> insertCreatedByList = new List<object>();
List<string> insertMessageList = new List<string>();

List<long> updateIdList = new List<long>();
List<object> updateCommentTypeIdList = new List<object>();
List<object> updateRequisitionIdList = new List<object>();
List<object> updateRequisitionApprovalLevelIdList = new List<object>();
List<object> updateApplicationRoleIdList = new List<object>();
List<DateTime> updateCreatedOnList = new List<DateTime>();
List<object> updateCreatedByList = new List<object>();
List<string> updateMessageList = new List<string>();

var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_08daffa670c72e7502779e59a7b292d3)inParamSourceList.Current).ssENRequisitionComment;
if (record.ssId != 0L) {
updateIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
if ((record.ssCommentTypeId==0)) {
updateCommentTypeIdList.Add(null);
} else {
updateCommentTypeIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssCommentTypeId));
}
if ((record.ssRequisitionId==0L)) {
updateRequisitionIdList.Add(null);
} else {
updateRequisitionIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssRequisitionId));
}
if ((record.ssRequisitionApprovalLevelId==0L)) {
updateRequisitionApprovalLevelIdList.Add(null);
} else {
updateRequisitionApprovalLevelIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssRequisitionApprovalLevelId));
}
if ((record.ssApplicationRoleId==0L)) {
updateApplicationRoleIdList.Add(null);
} else {
updateApplicationRoleIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssApplicationRoleId));
}
updateCreatedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssCreatedOn));
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
if ((record.ssRequisitionId==0L)) {
insertRequisitionIdList.Add(null);
} else {
insertRequisitionIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssRequisitionId));
}
if ((record.ssRequisitionApprovalLevelId==0L)) {
insertRequisitionApprovalLevelIdList.Add(null);
} else {
insertRequisitionApprovalLevelIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssRequisitionApprovalLevelId));
}
if ((record.ssApplicationRoleId==0L)) {
insertApplicationRoleIdList.Add(null);
} else {
insertApplicationRoleIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssApplicationRoleId));
}
insertCreatedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssCreatedOn));
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
if (!insertCommentTypeIdList.IsEmpty() || !insertRequisitionIdList.IsEmpty() || !insertRequisitionApprovalLevelIdList.IsEmpty() || !insertApplicationRoleIdList.IsEmpty() || !insertCreatedOnList.IsEmpty() || !insertCreatedByList.IsEmpty() || !insertMessageList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssCommentTypeId",DbType.Int32,insertCommentTypeIdList);
executionService.CreateParameter(insertSqlCmd,"@ssRequisitionId",DbType.Int64,insertRequisitionIdList);
executionService.CreateParameter(insertSqlCmd,"@ssRequisitionApprovalLevelId",DbType.Int64,insertRequisitionApprovalLevelIdList);
executionService.CreateParameter(insertSqlCmd,"@ssApplicationRoleId",DbType.Int64,insertApplicationRoleIdList);
executionService.CreateParameter(insertSqlCmd,"@ssCreatedOn",DbType.DateTime,insertCreatedOnList);
executionService.CreateParameter(insertSqlCmd,"@ssCreatedBy",DbType.String,insertCreatedByList);
executionService.CreateParameter(insertSqlCmd,"@ssMessage",DbType.String,insertMessageList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeRequisitionComment (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
if(!updateCommentTypeIdList.IsEmpty() || !updateRequisitionIdList.IsEmpty() || !updateRequisitionApprovalLevelIdList.IsEmpty() || !updateApplicationRoleIdList.IsEmpty() || !updateCreatedOnList.IsEmpty() || !updateCreatedByList.IsEmpty() || !updateMessageList.IsEmpty()){
await using(var updateSqlCmd = trans.CreateCommand(updateSql)){
executionService.CreateParameter(updateSqlCmd,"@ssId",DbType.Int64,updateIdList);
executionService.CreateParameter(updateSqlCmd,"@ssCommentTypeId",DbType.Int32,updateCommentTypeIdList);
executionService.CreateParameter(updateSqlCmd,"@ssRequisitionId",DbType.Int64,updateRequisitionIdList);
executionService.CreateParameter(updateSqlCmd,"@ssRequisitionApprovalLevelId",DbType.Int64,updateRequisitionApprovalLevelIdList);
executionService.CreateParameter(updateSqlCmd,"@ssApplicationRoleId",DbType.Int64,updateApplicationRoleIdList);
executionService.CreateParameter(updateSqlCmd,"@ssCreatedOn",DbType.DateTime,updateCreatedOnList);
executionService.CreateParameter(updateSqlCmd,"@ssCreatedBy",DbType.String,updateCreatedByList);
executionService.CreateParameter(updateSqlCmd,"@ssMessage",DbType.String,updateMessageList);
await updateSqlCmd.PrepareAsync(cancellationToken);
await updateSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeRequisitionComment (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(updateSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteRequisitionComment
/// </summary>

public static async Task DeleteRequisitionComment(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteRequisitionComment", "f2da5d7d-6966-4c0b-8288-ddeb4aec4033.#DeleteEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteRequisitionComment", "f2da5d7d-6966-4c0b-8288-ddeb4aec4033.#DeleteEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENRequisitionCommentEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteRequisitionComment", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllRequisitionComment
/// </summary>

public static async Task DeleteAllRequisitionComment(IRequestContext requestContext,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteAllRequisitionComment", "f2da5d7d-6966-4c0b-8288-ddeb4aec4033.#DeleteAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllRequisitionComment", "f2da5d7d-6966-4c0b-8288-ddeb4aec4033.#DeleteAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENRequisitionCommentEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteRequisitionComment", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetRequisitionComment
/// </summary>

public static async Task<RC_08daffa670c72e7502779e59a7b292d3> GetRequisitionComment(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_08daffa670c72e7502779e59a7b292d3 outParamRecord = default;
outParamRecord = new RC_08daffa670c72e7502779e59a7b292d3();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetRequisitionComment", "f2da5d7d-6966-4c0b-8288-ddeb4aec4033.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetRequisitionComment", "f2da5d7d-6966-4c0b-8288-ddeb4aec4033.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@CommentTypeId, "commenttypeid") ?? "commenttypeid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@RequisitionApprovalLevelId, "requisitionapprovallevelid") ?? "requisitionapprovallevelid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@CreatedOn, "createdon") ?? "createdon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@CreatedBy, "createdby") ?? "createdby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@Message, "message") ?? "message", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
" FROM " + ENRequisitionCommentEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetRequisitionComment", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(8,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENRequisitionCommentEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetRequisitionCommentForUpdate
/// </summary>

public static async Task<RC_08daffa670c72e7502779e59a7b292d3> GetRequisitionCommentForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_08daffa670c72e7502779e59a7b292d3 outParamRecord = default;
outParamRecord = new RC_08daffa670c72e7502779e59a7b292d3();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetRequisitionCommentForUpdate", "f2da5d7d-6966-4c0b-8288-ddeb4aec4033.#GetEntityForUpdate");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetRequisitionCommentForUpdate", "f2da5d7d-6966-4c0b-8288-ddeb4aec4033.#GetEntityForUpdate", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@CommentTypeId, "commenttypeid") ?? "commenttypeid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@RequisitionApprovalLevelId, "requisitionapprovallevelid") ?? "requisitionapprovallevelid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@CreatedOn, "createdon") ?? "createdon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@CreatedBy, "createdby") ?? "createdby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@Message, "message") ?? "message", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
" FROM " + ENRequisitionCommentEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@Id, "id") ?? "id") + " = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetRequisitionCommentForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(8,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENRequisitionCommentEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateRequisitionComment
/// </summary>

public static async Task UpdateRequisitionComment(IRequestContext requestContext,BitArray usedFields,RC_08daffa670c72e7502779e59a7b292d3 inParamSource,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("UpdateRequisitionComment", "f2da5d7d-6966-4c0b-8288-ddeb4aec4033.#UpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateRequisitionComment", "f2da5d7d-6966-4c0b-8288-ddeb4aec4033.#UpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_cbeb601b681344342c8de0161d058f87EntityRecord ssENRequisitionComment = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(8,true);
}
string updateSet = "UPDATE " + ENRequisitionCommentEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@CommentTypeId, "commenttypeid") ?? "commenttypeid") + " = @ssCommentTypeId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid") + " = @ssRequisitionId"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@RequisitionApprovalLevelId, "requisitionapprovallevelid") ?? "requisitionapprovallevelid") + " = @ssRequisitionApprovalLevelId"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid") + " = @ssApplicationRoleId"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = @ssCreatedOn"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = @ssCreatedBy"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@Message, "message") ?? "message") + " = @ssMessage"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENRequisitionComment_ssId_RequisitionComment";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@CommentTypeId, "commenttypeid") ?? "commenttypeid") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@CommentTypeId, "commenttypeid") ?? "commenttypeid") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENRequisitionComment.ssCommentTypeId==0)) {
sqlCmd.CreateParameter("@ssCommentTypeId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCommentTypeId", DbType.Int32, ssENRequisitionComment.ssCommentTypeId);

}
}
if(usedFields[2]) {
if ((ssENRequisitionComment.ssRequisitionId==0L)) {
sqlCmd.CreateParameter("@ssRequisitionId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssRequisitionId", DbType.Int64, ssENRequisitionComment.ssRequisitionId);

}
}
if(usedFields[3]) {
if ((ssENRequisitionComment.ssRequisitionApprovalLevelId==0L)) {
sqlCmd.CreateParameter("@ssRequisitionApprovalLevelId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssRequisitionApprovalLevelId", DbType.Int64, ssENRequisitionComment.ssRequisitionApprovalLevelId);

}
}
if(usedFields[4]) {
if ((ssENRequisitionComment.ssApplicationRoleId==0L)) {
sqlCmd.CreateParameter("@ssApplicationRoleId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssApplicationRoleId", DbType.Int64, ssENRequisitionComment.ssApplicationRoleId);

}
}
if(usedFields[5]) {
sqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENRequisitionComment.ssCreatedOn);
}
if(usedFields[6]) {
if ((ssENRequisitionComment.ssCreatedBy=="")) {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENRequisitionComment.ssCreatedBy);

}
}
if(usedFields[7]) {
sqlCmd.CreateParameter("@ssMessage", DbType.String, ssENRequisitionComment.ssMessage);
}
sqlCmd.CreateParameter("@idparam_ssENRequisitionComment_ssId_RequisitionComment", DbType.Int64, ssENRequisitionComment.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateRequisitionComment", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("RequisitionComment", ssENRequisitionComment.ssId.ToString()); }}
}
return;
}

}
}
