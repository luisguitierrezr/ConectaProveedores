using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateFolioComment
/// </summary>

public static async Task<long> CreateFolioComment(IRequestContext requestContext,RC_bd4c69fd286a3fa1bae388a3d68ac007 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateFolioComment", "6b7ae17d-b0b2-455d-9574-0b1d3ce312ee.#CreateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateFolioComment", "6b7ae17d-b0b2-455d-9574-0b1d3ce312ee.#CreateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_a75639301080da49357fc03810b8d65fEntityRecord ssENFolioComment = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENFolioCommentEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@FolioId, "folioid") ?? "folioid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@FolioApprovalLevelId, "folioapprovallevelid") ?? "folioapprovallevelid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@CommentTypeId, "commenttypeid") ?? "commenttypeid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@Message, "message") ?? "message") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@IsPublic, "ispublic") ?? "ispublic") + "" +
" ) VALUES (" +
" @ssFolioId" +
", @ssFolioApprovalLevelId" +
", @ssCommentTypeId" +
", @ssApplicationRoleId" +
", @ssCreatedOn" +
", @ssCreatedBy" +
", @ssMessage" +
", @ssIsPublic" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENFolioComment.ssFolioId==0L)) {
insertSqlCmd.CreateParameter("@ssFolioId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssFolioId", DbType.Int64, ssENFolioComment.ssFolioId);

}
if ((ssENFolioComment.ssFolioApprovalLevelId==0L)) {
insertSqlCmd.CreateParameter("@ssFolioApprovalLevelId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssFolioApprovalLevelId", DbType.Int64, ssENFolioComment.ssFolioApprovalLevelId);

}
if ((ssENFolioComment.ssCommentTypeId==0)) {
insertSqlCmd.CreateParameter("@ssCommentTypeId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCommentTypeId", DbType.Int32, ssENFolioComment.ssCommentTypeId);

}
if ((ssENFolioComment.ssApplicationRoleId==0L)) {
insertSqlCmd.CreateParameter("@ssApplicationRoleId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssApplicationRoleId", DbType.Int64, ssENFolioComment.ssApplicationRoleId);

}
insertSqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENFolioComment.ssCreatedOn);
if ((ssENFolioComment.ssCreatedBy=="")) {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENFolioComment.ssCreatedBy);

}
insertSqlCmd.CreateParameter("@ssMessage", DbType.String, ssENFolioComment.ssMessage);
insertSqlCmd.CreateParameter("@ssIsPublic", DbType.Boolean, ssENFolioComment.ssIsPublic);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateFolioComment", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateFolioComment
/// </summary>

public static async Task<long> CreateOrUpdateFolioComment(IRequestContext requestContext,BitArray usedFields,RC_bd4c69fd286a3fa1bae388a3d68ac007 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateFolioComment", "6b7ae17d-b0b2-455d-9574-0b1d3ce312ee.#CreateOrUpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateFolioComment", "6b7ae17d-b0b2-455d-9574-0b1d3ce312ee.#CreateOrUpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_a75639301080da49357fc03810b8d65fEntityRecord ssENFolioComment = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(9,true);
}
string updateSet = "UPDATE " + ENFolioCommentEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@FolioId, "folioid") ?? "folioid") + " = @ssFolioId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@FolioApprovalLevelId, "folioapprovallevelid") ?? "folioapprovallevelid") + " = @ssFolioApprovalLevelId"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@CommentTypeId, "commenttypeid") ?? "commenttypeid") + " = @ssCommentTypeId"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid") + " = @ssApplicationRoleId"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = @ssCreatedOn"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = @ssCreatedBy"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@Message, "message") ?? "message") + " = @ssMessage"): parameters);
parameters = (usedFields[8] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@IsPublic, "ispublic") ?? "ispublic") + " = @ssIsPublic"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENFolioComment_ssId_FolioComment";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@IsPublic, "ispublic") ?? "ispublic") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@IsPublic, "ispublic") ?? "ispublic") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENFolioComment.ssFolioId==0L)) {
sqlCmd.CreateParameter("@ssFolioId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssFolioId", DbType.Int64, ssENFolioComment.ssFolioId);

}
}
if(usedFields[2]) {
if ((ssENFolioComment.ssFolioApprovalLevelId==0L)) {
sqlCmd.CreateParameter("@ssFolioApprovalLevelId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssFolioApprovalLevelId", DbType.Int64, ssENFolioComment.ssFolioApprovalLevelId);

}
}
if(usedFields[3]) {
if ((ssENFolioComment.ssCommentTypeId==0)) {
sqlCmd.CreateParameter("@ssCommentTypeId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCommentTypeId", DbType.Int32, ssENFolioComment.ssCommentTypeId);

}
}
if(usedFields[4]) {
if ((ssENFolioComment.ssApplicationRoleId==0L)) {
sqlCmd.CreateParameter("@ssApplicationRoleId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssApplicationRoleId", DbType.Int64, ssENFolioComment.ssApplicationRoleId);

}
}
if(usedFields[5]) {
sqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENFolioComment.ssCreatedOn);
}
if(usedFields[6]) {
if ((ssENFolioComment.ssCreatedBy=="")) {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENFolioComment.ssCreatedBy);

}
}
if(usedFields[7]) {
sqlCmd.CreateParameter("@ssMessage", DbType.String, ssENFolioComment.ssMessage);
}
if(usedFields[8]) {
sqlCmd.CreateParameter("@ssIsPublic", DbType.Boolean, ssENFolioComment.ssIsPublic);
}
sqlCmd.CreateParameter("@idparam_ssENFolioComment_ssId_FolioComment", DbType.Int64, ssENFolioComment.ssId);
int counter = 0;
if(ssENFolioComment.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateFolioComment (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENFolioCommentEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@FolioId, "folioid") ?? "folioid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@FolioApprovalLevelId, "folioapprovallevelid") ?? "folioapprovallevelid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@CommentTypeId, "commenttypeid") ?? "commenttypeid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@Message, "message") ?? "message") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@IsPublic, "ispublic") ?? "ispublic") + "" +
" ) VALUES (" +
" @ssFolioId" +
", @ssFolioApprovalLevelId" +
", @ssCommentTypeId" +
", @ssApplicationRoleId" +
", @ssCreatedOn" +
", @ssCreatedBy" +
", @ssMessage" +
", @ssIsPublic" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENFolioComment.ssFolioId==0L)) {
insertSqlCmd.CreateParameter("@ssFolioId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssFolioId", DbType.Int64, ssENFolioComment.ssFolioId);

}
if ((ssENFolioComment.ssFolioApprovalLevelId==0L)) {
insertSqlCmd.CreateParameter("@ssFolioApprovalLevelId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssFolioApprovalLevelId", DbType.Int64, ssENFolioComment.ssFolioApprovalLevelId);

}
if ((ssENFolioComment.ssCommentTypeId==0)) {
insertSqlCmd.CreateParameter("@ssCommentTypeId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCommentTypeId", DbType.Int32, ssENFolioComment.ssCommentTypeId);

}
if ((ssENFolioComment.ssApplicationRoleId==0L)) {
insertSqlCmd.CreateParameter("@ssApplicationRoleId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssApplicationRoleId", DbType.Int64, ssENFolioComment.ssApplicationRoleId);

}
insertSqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENFolioComment.ssCreatedOn);
if ((ssENFolioComment.ssCreatedBy=="")) {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENFolioComment.ssCreatedBy);

}
insertSqlCmd.CreateParameter("@ssMessage", DbType.String, ssENFolioComment.ssMessage);
insertSqlCmd.CreateParameter("@ssIsPublic", DbType.Boolean, ssENFolioComment.ssIsPublic);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateFolioComment", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENFolioComment.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeFolioComment
/// </summary>

public static async Task CreateOrUpdateSomeFolioComment(IRequestContext requestContext,RL_09242f4ee71e01bd257c449a944930cd inParamSourceList,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateSomeFolioComment", "6b7ae17d-b0b2-455d-9574-0b1d3ce312ee.#CreateOrUpdateAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeFolioComment", "6b7ae17d-b0b2-455d-9574-0b1d3ce312ee.#CreateOrUpdateAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
string entityTableName = ENFolioCommentEntity.LocalViewName(null);
string insertSql = "INSERT INTO " + entityTableName + " (" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@FolioId, "folioid") ?? "folioid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@FolioApprovalLevelId, "folioapprovallevelid") ?? "folioapprovallevelid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@CommentTypeId, "commenttypeid") ?? "commenttypeid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@Message, "message") ?? "message") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@IsPublic, "ispublic") ?? "ispublic") + ") VALUES ( unnest(@ssFolioId),  unnest(@ssFolioApprovalLevelId),  unnest(@ssCommentTypeId),  unnest(@ssApplicationRoleId),  unnest(@ssCreatedOn),  unnest(@ssCreatedBy),  unnest(@ssMessage),  unnest(@ssIsPublic)) ";
insertSql += "";

string updateSql = "UPDATE " + entityTableName + " SET " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@FolioId, "folioid") ?? "folioid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@FolioId, "folioid") ?? "folioid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@FolioApprovalLevelId, "folioapprovallevelid") ?? "folioapprovallevelid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@FolioApprovalLevelId, "folioapprovallevelid") ?? "folioapprovallevelid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@CommentTypeId, "commenttypeid") ?? "commenttypeid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@CommentTypeId, "commenttypeid") ?? "commenttypeid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@Message, "message") ?? "message") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@Message, "message") ?? "message") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@IsPublic, "ispublic") ?? "ispublic") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@IsPublic, "ispublic") ?? "ispublic") + " from ( select  unnest(@ssId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@Id, "id") ?? "id") + ",  unnest(@ssFolioId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@FolioId, "folioid") ?? "folioid") + ",  unnest(@ssFolioApprovalLevelId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@FolioApprovalLevelId, "folioapprovallevelid") ?? "folioapprovallevelid") + ",  unnest(@ssCommentTypeId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@CommentTypeId, "commenttypeid") ?? "commenttypeid") + ",  unnest(@ssApplicationRoleId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid") + ",  unnest(@ssCreatedOn) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + ",  unnest(@ssCreatedBy) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + ",  unnest(@ssMessage) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@Message, "message") ?? "message") + ",  unnest(@ssIsPublic) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@IsPublic, "ispublic") ?? "ispublic") + " ) as updateTable where " + entityTableName + "." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@Id, "id") ?? "id") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@Id, "id") ?? "id") + " ";
updateSql += "";

List<object> insertFolioIdList = new List<object>();
List<object> insertFolioApprovalLevelIdList = new List<object>();
List<object> insertCommentTypeIdList = new List<object>();
List<object> insertApplicationRoleIdList = new List<object>();
List<DateTime> insertCreatedOnList = new List<DateTime>();
List<object> insertCreatedByList = new List<object>();
List<string> insertMessageList = new List<string>();
List<bool> insertIsPublicList = new List<bool>();

List<long> updateIdList = new List<long>();
List<object> updateFolioIdList = new List<object>();
List<object> updateFolioApprovalLevelIdList = new List<object>();
List<object> updateCommentTypeIdList = new List<object>();
List<object> updateApplicationRoleIdList = new List<object>();
List<DateTime> updateCreatedOnList = new List<DateTime>();
List<object> updateCreatedByList = new List<object>();
List<string> updateMessageList = new List<string>();
List<bool> updateIsPublicList = new List<bool>();

var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_bd4c69fd286a3fa1bae388a3d68ac007)inParamSourceList.Current).ssENFolioComment;
if (record.ssId != 0L) {
updateIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
if ((record.ssFolioId==0L)) {
updateFolioIdList.Add(null);
} else {
updateFolioIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssFolioId));
}
if ((record.ssFolioApprovalLevelId==0L)) {
updateFolioApprovalLevelIdList.Add(null);
} else {
updateFolioApprovalLevelIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssFolioApprovalLevelId));
}
if ((record.ssCommentTypeId==0)) {
updateCommentTypeIdList.Add(null);
} else {
updateCommentTypeIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssCommentTypeId));
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
updateIsPublicList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsPublic));
} else {
if ((record.ssFolioId==0L)) {
insertFolioIdList.Add(null);
} else {
insertFolioIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssFolioId));
}
if ((record.ssFolioApprovalLevelId==0L)) {
insertFolioApprovalLevelIdList.Add(null);
} else {
insertFolioApprovalLevelIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssFolioApprovalLevelId));
}
if ((record.ssCommentTypeId==0)) {
insertCommentTypeIdList.Add(null);
} else {
insertCommentTypeIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssCommentTypeId));
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
insertIsPublicList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsPublic));
}
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertFolioIdList.IsEmpty() || !insertFolioApprovalLevelIdList.IsEmpty() || !insertCommentTypeIdList.IsEmpty() || !insertApplicationRoleIdList.IsEmpty() || !insertCreatedOnList.IsEmpty() || !insertCreatedByList.IsEmpty() || !insertMessageList.IsEmpty() || !insertIsPublicList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssFolioId",DbType.Int64,insertFolioIdList);
executionService.CreateParameter(insertSqlCmd,"@ssFolioApprovalLevelId",DbType.Int64,insertFolioApprovalLevelIdList);
executionService.CreateParameter(insertSqlCmd,"@ssCommentTypeId",DbType.Int32,insertCommentTypeIdList);
executionService.CreateParameter(insertSqlCmd,"@ssApplicationRoleId",DbType.Int64,insertApplicationRoleIdList);
executionService.CreateParameter(insertSqlCmd,"@ssCreatedOn",DbType.DateTime,insertCreatedOnList);
executionService.CreateParameter(insertSqlCmd,"@ssCreatedBy",DbType.String,insertCreatedByList);
executionService.CreateParameter(insertSqlCmd,"@ssMessage",DbType.String,insertMessageList);
executionService.CreateParameter(insertSqlCmd,"@ssIsPublic",DbType.Boolean,insertIsPublicList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeFolioComment (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
if(!updateFolioIdList.IsEmpty() || !updateFolioApprovalLevelIdList.IsEmpty() || !updateCommentTypeIdList.IsEmpty() || !updateApplicationRoleIdList.IsEmpty() || !updateCreatedOnList.IsEmpty() || !updateCreatedByList.IsEmpty() || !updateMessageList.IsEmpty() || !updateIsPublicList.IsEmpty()){
await using(var updateSqlCmd = trans.CreateCommand(updateSql)){
executionService.CreateParameter(updateSqlCmd,"@ssId",DbType.Int64,updateIdList);
executionService.CreateParameter(updateSqlCmd,"@ssFolioId",DbType.Int64,updateFolioIdList);
executionService.CreateParameter(updateSqlCmd,"@ssFolioApprovalLevelId",DbType.Int64,updateFolioApprovalLevelIdList);
executionService.CreateParameter(updateSqlCmd,"@ssCommentTypeId",DbType.Int32,updateCommentTypeIdList);
executionService.CreateParameter(updateSqlCmd,"@ssApplicationRoleId",DbType.Int64,updateApplicationRoleIdList);
executionService.CreateParameter(updateSqlCmd,"@ssCreatedOn",DbType.DateTime,updateCreatedOnList);
executionService.CreateParameter(updateSqlCmd,"@ssCreatedBy",DbType.String,updateCreatedByList);
executionService.CreateParameter(updateSqlCmd,"@ssMessage",DbType.String,updateMessageList);
executionService.CreateParameter(updateSqlCmd,"@ssIsPublic",DbType.Boolean,updateIsPublicList);
await updateSqlCmd.PrepareAsync(cancellationToken);
await updateSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeFolioComment (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(updateSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteFolioComment
/// </summary>

public static async Task DeleteFolioComment(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteFolioComment", "6b7ae17d-b0b2-455d-9574-0b1d3ce312ee.#DeleteEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteFolioComment", "6b7ae17d-b0b2-455d-9574-0b1d3ce312ee.#DeleteEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENFolioCommentEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteFolioComment", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllFolioComment
/// </summary>

public static async Task DeleteAllFolioComment(IRequestContext requestContext,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteAllFolioComment", "6b7ae17d-b0b2-455d-9574-0b1d3ce312ee.#DeleteAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllFolioComment", "6b7ae17d-b0b2-455d-9574-0b1d3ce312ee.#DeleteAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENFolioCommentEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteFolioComment", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetFolioComment
/// </summary>

public static async Task<RC_bd4c69fd286a3fa1bae388a3d68ac007> GetFolioComment(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_bd4c69fd286a3fa1bae388a3d68ac007 outParamRecord = default;
outParamRecord = new RC_bd4c69fd286a3fa1bae388a3d68ac007();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetFolioComment", "6b7ae17d-b0b2-455d-9574-0b1d3ce312ee.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetFolioComment", "6b7ae17d-b0b2-455d-9574-0b1d3ce312ee.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@FolioId, "folioid") ?? "folioid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@FolioApprovalLevelId, "folioapprovallevelid") ?? "folioapprovallevelid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@CommentTypeId, "commenttypeid") ?? "commenttypeid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@CreatedOn, "createdon") ?? "createdon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@CreatedBy, "createdby") ?? "createdby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@Message, "message") ?? "message", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@IsPublic, "ispublic") ?? "ispublic", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
" FROM " + ENFolioCommentEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetFolioComment", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(9,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENFolioCommentEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetFolioCommentForUpdate
/// </summary>

public static async Task<RC_bd4c69fd286a3fa1bae388a3d68ac007> GetFolioCommentForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_bd4c69fd286a3fa1bae388a3d68ac007 outParamRecord = default;
outParamRecord = new RC_bd4c69fd286a3fa1bae388a3d68ac007();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetFolioCommentForUpdate", "6b7ae17d-b0b2-455d-9574-0b1d3ce312ee.#GetEntityForUpdate");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetFolioCommentForUpdate", "6b7ae17d-b0b2-455d-9574-0b1d3ce312ee.#GetEntityForUpdate", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@FolioId, "folioid") ?? "folioid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@FolioApprovalLevelId, "folioapprovallevelid") ?? "folioapprovallevelid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@CommentTypeId, "commenttypeid") ?? "commenttypeid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@CreatedOn, "createdon") ?? "createdon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@CreatedBy, "createdby") ?? "createdby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@Message, "message") ?? "message", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@IsPublic, "ispublic") ?? "ispublic", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
" FROM " + ENFolioCommentEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@Id, "id") ?? "id") + " = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetFolioCommentForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(9,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENFolioCommentEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateFolioComment
/// </summary>

public static async Task UpdateFolioComment(IRequestContext requestContext,BitArray usedFields,RC_bd4c69fd286a3fa1bae388a3d68ac007 inParamSource,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("UpdateFolioComment", "6b7ae17d-b0b2-455d-9574-0b1d3ce312ee.#UpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateFolioComment", "6b7ae17d-b0b2-455d-9574-0b1d3ce312ee.#UpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_a75639301080da49357fc03810b8d65fEntityRecord ssENFolioComment = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(9,true);
}
string updateSet = "UPDATE " + ENFolioCommentEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@FolioId, "folioid") ?? "folioid") + " = @ssFolioId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@FolioApprovalLevelId, "folioapprovallevelid") ?? "folioapprovallevelid") + " = @ssFolioApprovalLevelId"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@CommentTypeId, "commenttypeid") ?? "commenttypeid") + " = @ssCommentTypeId"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid") + " = @ssApplicationRoleId"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = @ssCreatedOn"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = @ssCreatedBy"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@Message, "message") ?? "message") + " = @ssMessage"): parameters);
parameters = (usedFields[8] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@IsPublic, "ispublic") ?? "ispublic") + " = @ssIsPublic"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENFolioComment_ssId_FolioComment";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@IsPublic, "ispublic") ?? "ispublic") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioCommentAttributeKeys.@IsPublic, "ispublic") ?? "ispublic") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENFolioComment.ssFolioId==0L)) {
sqlCmd.CreateParameter("@ssFolioId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssFolioId", DbType.Int64, ssENFolioComment.ssFolioId);

}
}
if(usedFields[2]) {
if ((ssENFolioComment.ssFolioApprovalLevelId==0L)) {
sqlCmd.CreateParameter("@ssFolioApprovalLevelId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssFolioApprovalLevelId", DbType.Int64, ssENFolioComment.ssFolioApprovalLevelId);

}
}
if(usedFields[3]) {
if ((ssENFolioComment.ssCommentTypeId==0)) {
sqlCmd.CreateParameter("@ssCommentTypeId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCommentTypeId", DbType.Int32, ssENFolioComment.ssCommentTypeId);

}
}
if(usedFields[4]) {
if ((ssENFolioComment.ssApplicationRoleId==0L)) {
sqlCmd.CreateParameter("@ssApplicationRoleId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssApplicationRoleId", DbType.Int64, ssENFolioComment.ssApplicationRoleId);

}
}
if(usedFields[5]) {
sqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENFolioComment.ssCreatedOn);
}
if(usedFields[6]) {
if ((ssENFolioComment.ssCreatedBy=="")) {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENFolioComment.ssCreatedBy);

}
}
if(usedFields[7]) {
sqlCmd.CreateParameter("@ssMessage", DbType.String, ssENFolioComment.ssMessage);
}
if(usedFields[8]) {
sqlCmd.CreateParameter("@ssIsPublic", DbType.Boolean, ssENFolioComment.ssIsPublic);
}
sqlCmd.CreateParameter("@idparam_ssENFolioComment_ssId_FolioComment", DbType.Int64, ssENFolioComment.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateFolioComment", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("FolioComment", ssENFolioComment.ssId.ToString()); }}
}
return;
}

}
}
