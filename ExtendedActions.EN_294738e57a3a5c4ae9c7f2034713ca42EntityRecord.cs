using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateOrderComment
/// </summary>

public static async Task<long> CreateOrderComment(IRequestContext requestContext,RC_cd61721ee82121e78e4055ba4deb1fa6 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrderComment", "4e5377ef-07fe-40f1-af42-4f4003f4237a.#CreateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrderComment", "4e5377ef-07fe-40f1-af42-4f4003f4237a.#CreateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord ssENOrderComment = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENOrderCommentEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCommentAttributeKeys.@CommentTypeId, "commenttypeid") ?? "commenttypeid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCommentAttributeKeys.@OrderId, "orderid") ?? "orderid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCommentAttributeKeys.@OrderApprovalLevelId, "orderapprovallevelid") ?? "orderapprovallevelid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCommentAttributeKeys.@EntraRoleId, "entraroleid") ?? "entraroleid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCommentAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCommentAttributeKeys.@Message, "message") ?? "message") + "" +
" ) VALUES (" +
" @ssCommentTypeId" +
", @ssOrderId" +
", @ssOrderApprovalLevelId" +
", @ssEntraRoleId" +
", @ssCreatedBy" +
", @ssMessage" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENOrderComment.ssCommentTypeId==0)) {
insertSqlCmd.CreateParameter("@ssCommentTypeId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCommentTypeId", DbType.Int32, ssENOrderComment.ssCommentTypeId);

}
if ((ssENOrderComment.ssOrderId==0L)) {
insertSqlCmd.CreateParameter("@ssOrderId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssOrderId", DbType.Int64, ssENOrderComment.ssOrderId);

}
if ((ssENOrderComment.ssOrderApprovalLevelId==0L)) {
insertSqlCmd.CreateParameter("@ssOrderApprovalLevelId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssOrderApprovalLevelId", DbType.Int64, ssENOrderComment.ssOrderApprovalLevelId);

}
if ((ssENOrderComment.ssEntraRoleId==0L)) {
insertSqlCmd.CreateParameter("@ssEntraRoleId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssEntraRoleId", DbType.Int64, ssENOrderComment.ssEntraRoleId);

}
if ((ssENOrderComment.ssCreatedBy=="")) {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENOrderComment.ssCreatedBy);

}
insertSqlCmd.CreateParameter("@ssMessage", DbType.String, ssENOrderComment.ssMessage);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrderComment", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateOrderComment
/// </summary>

public static async Task<long> CreateOrUpdateOrderComment(IRequestContext requestContext,BitArray usedFields,RC_cd61721ee82121e78e4055ba4deb1fa6 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateOrderComment", "4e5377ef-07fe-40f1-af42-4f4003f4237a.#CreateOrUpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateOrderComment", "4e5377ef-07fe-40f1-af42-4f4003f4237a.#CreateOrUpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord ssENOrderComment = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(7,true);
}
string updateSet = "UPDATE " + ENOrderCommentEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCommentAttributeKeys.@CommentTypeId, "commenttypeid") ?? "commenttypeid") + " = @ssCommentTypeId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCommentAttributeKeys.@OrderId, "orderid") ?? "orderid") + " = @ssOrderId"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCommentAttributeKeys.@OrderApprovalLevelId, "orderapprovallevelid") ?? "orderapprovallevelid") + " = @ssOrderApprovalLevelId"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCommentAttributeKeys.@EntraRoleId, "entraroleid") ?? "entraroleid") + " = @ssEntraRoleId"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCommentAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = @ssCreatedBy"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCommentAttributeKeys.@Message, "message") ?? "message") + " = @ssMessage"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCommentAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENOrderComment_ssId_OrderComment";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCommentAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCommentAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENOrderComment.ssCommentTypeId==0)) {
sqlCmd.CreateParameter("@ssCommentTypeId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCommentTypeId", DbType.Int32, ssENOrderComment.ssCommentTypeId);

}
}
if(usedFields[2]) {
if ((ssENOrderComment.ssOrderId==0L)) {
sqlCmd.CreateParameter("@ssOrderId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssOrderId", DbType.Int64, ssENOrderComment.ssOrderId);

}
}
if(usedFields[3]) {
if ((ssENOrderComment.ssOrderApprovalLevelId==0L)) {
sqlCmd.CreateParameter("@ssOrderApprovalLevelId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssOrderApprovalLevelId", DbType.Int64, ssENOrderComment.ssOrderApprovalLevelId);

}
}
if(usedFields[4]) {
if ((ssENOrderComment.ssEntraRoleId==0L)) {
sqlCmd.CreateParameter("@ssEntraRoleId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssEntraRoleId", DbType.Int64, ssENOrderComment.ssEntraRoleId);

}
}
if(usedFields[5]) {
if ((ssENOrderComment.ssCreatedBy=="")) {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENOrderComment.ssCreatedBy);

}
}
if(usedFields[6]) {
sqlCmd.CreateParameter("@ssMessage", DbType.String, ssENOrderComment.ssMessage);
}
sqlCmd.CreateParameter("@idparam_ssENOrderComment_ssId_OrderComment", DbType.Int64, ssENOrderComment.ssId);
int counter = 0;
if(ssENOrderComment.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateOrderComment (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENOrderCommentEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCommentAttributeKeys.@CommentTypeId, "commenttypeid") ?? "commenttypeid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCommentAttributeKeys.@OrderId, "orderid") ?? "orderid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCommentAttributeKeys.@OrderApprovalLevelId, "orderapprovallevelid") ?? "orderapprovallevelid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCommentAttributeKeys.@EntraRoleId, "entraroleid") ?? "entraroleid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCommentAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCommentAttributeKeys.@Message, "message") ?? "message") + "" +
" ) VALUES (" +
" @ssCommentTypeId" +
", @ssOrderId" +
", @ssOrderApprovalLevelId" +
", @ssEntraRoleId" +
", @ssCreatedBy" +
", @ssMessage" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENOrderComment.ssCommentTypeId==0)) {
insertSqlCmd.CreateParameter("@ssCommentTypeId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCommentTypeId", DbType.Int32, ssENOrderComment.ssCommentTypeId);

}
if ((ssENOrderComment.ssOrderId==0L)) {
insertSqlCmd.CreateParameter("@ssOrderId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssOrderId", DbType.Int64, ssENOrderComment.ssOrderId);

}
if ((ssENOrderComment.ssOrderApprovalLevelId==0L)) {
insertSqlCmd.CreateParameter("@ssOrderApprovalLevelId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssOrderApprovalLevelId", DbType.Int64, ssENOrderComment.ssOrderApprovalLevelId);

}
if ((ssENOrderComment.ssEntraRoleId==0L)) {
insertSqlCmd.CreateParameter("@ssEntraRoleId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssEntraRoleId", DbType.Int64, ssENOrderComment.ssEntraRoleId);

}
if ((ssENOrderComment.ssCreatedBy=="")) {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENOrderComment.ssCreatedBy);

}
insertSqlCmd.CreateParameter("@ssMessage", DbType.String, ssENOrderComment.ssMessage);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateOrderComment", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENOrderComment.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeOrderComment
/// </summary>

public static async Task CreateOrUpdateSomeOrderComment(IRequestContext requestContext,RL_17d8289ea48572225dc9530a5725652a inParamSourceList,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateSomeOrderComment", "4e5377ef-07fe-40f1-af42-4f4003f4237a.#CreateOrUpdateAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeOrderComment", "4e5377ef-07fe-40f1-af42-4f4003f4237a.#CreateOrUpdateAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
string entityTableName = ENOrderCommentEntity.LocalViewName(null);
string insertSql = "INSERT INTO " + entityTableName + " (" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCommentAttributeKeys.@CommentTypeId, "commenttypeid") ?? "commenttypeid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCommentAttributeKeys.@OrderId, "orderid") ?? "orderid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCommentAttributeKeys.@OrderApprovalLevelId, "orderapprovallevelid") ?? "orderapprovallevelid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCommentAttributeKeys.@EntraRoleId, "entraroleid") ?? "entraroleid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCommentAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCommentAttributeKeys.@Message, "message") ?? "message") + ") VALUES ( unnest(@ssCommentTypeId),  unnest(@ssOrderId),  unnest(@ssOrderApprovalLevelId),  unnest(@ssEntraRoleId),  unnest(@ssCreatedBy),  unnest(@ssMessage)) ";
insertSql += "";

string updateSql = "UPDATE " + entityTableName + " SET " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCommentAttributeKeys.@CommentTypeId, "commenttypeid") ?? "commenttypeid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCommentAttributeKeys.@CommentTypeId, "commenttypeid") ?? "commenttypeid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCommentAttributeKeys.@OrderId, "orderid") ?? "orderid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCommentAttributeKeys.@OrderId, "orderid") ?? "orderid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCommentAttributeKeys.@OrderApprovalLevelId, "orderapprovallevelid") ?? "orderapprovallevelid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCommentAttributeKeys.@OrderApprovalLevelId, "orderapprovallevelid") ?? "orderapprovallevelid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCommentAttributeKeys.@EntraRoleId, "entraroleid") ?? "entraroleid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCommentAttributeKeys.@EntraRoleId, "entraroleid") ?? "entraroleid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCommentAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCommentAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCommentAttributeKeys.@Message, "message") ?? "message") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCommentAttributeKeys.@Message, "message") ?? "message") + " from ( select  unnest(@ssId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCommentAttributeKeys.@Id, "id") ?? "id") + ",  unnest(@ssCommentTypeId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCommentAttributeKeys.@CommentTypeId, "commenttypeid") ?? "commenttypeid") + ",  unnest(@ssOrderId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCommentAttributeKeys.@OrderId, "orderid") ?? "orderid") + ",  unnest(@ssOrderApprovalLevelId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCommentAttributeKeys.@OrderApprovalLevelId, "orderapprovallevelid") ?? "orderapprovallevelid") + ",  unnest(@ssEntraRoleId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCommentAttributeKeys.@EntraRoleId, "entraroleid") ?? "entraroleid") + ",  unnest(@ssCreatedBy) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCommentAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + ",  unnest(@ssMessage) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCommentAttributeKeys.@Message, "message") ?? "message") + " ) as updateTable where " + entityTableName + "." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCommentAttributeKeys.@Id, "id") ?? "id") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCommentAttributeKeys.@Id, "id") ?? "id") + " ";
updateSql += "";

List<object> insertCommentTypeIdList = new List<object>();
List<object> insertOrderIdList = new List<object>();
List<object> insertOrderApprovalLevelIdList = new List<object>();
List<object> insertEntraRoleIdList = new List<object>();
List<object> insertCreatedByList = new List<object>();
List<string> insertMessageList = new List<string>();

List<long> updateIdList = new List<long>();
List<object> updateCommentTypeIdList = new List<object>();
List<object> updateOrderIdList = new List<object>();
List<object> updateOrderApprovalLevelIdList = new List<object>();
List<object> updateEntraRoleIdList = new List<object>();
List<object> updateCreatedByList = new List<object>();
List<string> updateMessageList = new List<string>();

var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_cd61721ee82121e78e4055ba4deb1fa6)inParamSourceList.Current).ssENOrderComment;
if (record.ssId != 0L) {
updateIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
if ((record.ssCommentTypeId==0)) {
updateCommentTypeIdList.Add(null);
} else {
updateCommentTypeIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssCommentTypeId));
}
if ((record.ssOrderId==0L)) {
updateOrderIdList.Add(null);
} else {
updateOrderIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssOrderId));
}
if ((record.ssOrderApprovalLevelId==0L)) {
updateOrderApprovalLevelIdList.Add(null);
} else {
updateOrderApprovalLevelIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssOrderApprovalLevelId));
}
if ((record.ssEntraRoleId==0L)) {
updateEntraRoleIdList.Add(null);
} else {
updateEntraRoleIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssEntraRoleId));
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
if ((record.ssOrderId==0L)) {
insertOrderIdList.Add(null);
} else {
insertOrderIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssOrderId));
}
if ((record.ssOrderApprovalLevelId==0L)) {
insertOrderApprovalLevelIdList.Add(null);
} else {
insertOrderApprovalLevelIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssOrderApprovalLevelId));
}
if ((record.ssEntraRoleId==0L)) {
insertEntraRoleIdList.Add(null);
} else {
insertEntraRoleIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssEntraRoleId));
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
if (!insertCommentTypeIdList.IsEmpty() || !insertOrderIdList.IsEmpty() || !insertOrderApprovalLevelIdList.IsEmpty() || !insertEntraRoleIdList.IsEmpty() || !insertCreatedByList.IsEmpty() || !insertMessageList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssCommentTypeId",DbType.Int32,insertCommentTypeIdList);
executionService.CreateParameter(insertSqlCmd,"@ssOrderId",DbType.Int64,insertOrderIdList);
executionService.CreateParameter(insertSqlCmd,"@ssOrderApprovalLevelId",DbType.Int64,insertOrderApprovalLevelIdList);
executionService.CreateParameter(insertSqlCmd,"@ssEntraRoleId",DbType.Int64,insertEntraRoleIdList);
executionService.CreateParameter(insertSqlCmd,"@ssCreatedBy",DbType.String,insertCreatedByList);
executionService.CreateParameter(insertSqlCmd,"@ssMessage",DbType.String,insertMessageList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeOrderComment (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
if(!updateCommentTypeIdList.IsEmpty() || !updateOrderIdList.IsEmpty() || !updateOrderApprovalLevelIdList.IsEmpty() || !updateEntraRoleIdList.IsEmpty() || !updateCreatedByList.IsEmpty() || !updateMessageList.IsEmpty()){
await using(var updateSqlCmd = trans.CreateCommand(updateSql)){
executionService.CreateParameter(updateSqlCmd,"@ssId",DbType.Int64,updateIdList);
executionService.CreateParameter(updateSqlCmd,"@ssCommentTypeId",DbType.Int32,updateCommentTypeIdList);
executionService.CreateParameter(updateSqlCmd,"@ssOrderId",DbType.Int64,updateOrderIdList);
executionService.CreateParameter(updateSqlCmd,"@ssOrderApprovalLevelId",DbType.Int64,updateOrderApprovalLevelIdList);
executionService.CreateParameter(updateSqlCmd,"@ssEntraRoleId",DbType.Int64,updateEntraRoleIdList);
executionService.CreateParameter(updateSqlCmd,"@ssCreatedBy",DbType.String,updateCreatedByList);
executionService.CreateParameter(updateSqlCmd,"@ssMessage",DbType.String,updateMessageList);
await updateSqlCmd.PrepareAsync(cancellationToken);
await updateSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeOrderComment (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(updateSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteOrderComment
/// </summary>

public static async Task DeleteOrderComment(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteOrderComment", "4e5377ef-07fe-40f1-af42-4f4003f4237a.#DeleteEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteOrderComment", "4e5377ef-07fe-40f1-af42-4f4003f4237a.#DeleteEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENOrderCommentEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCommentAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteOrderComment", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllOrderComment
/// </summary>

public static async Task DeleteAllOrderComment(IRequestContext requestContext,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteAllOrderComment", "4e5377ef-07fe-40f1-af42-4f4003f4237a.#DeleteAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllOrderComment", "4e5377ef-07fe-40f1-af42-4f4003f4237a.#DeleteAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENOrderCommentEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteOrderComment", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetOrderComment
/// </summary>

public static async Task<RC_cd61721ee82121e78e4055ba4deb1fa6> GetOrderComment(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_cd61721ee82121e78e4055ba4deb1fa6 outParamRecord = default;
outParamRecord = new RC_cd61721ee82121e78e4055ba4deb1fa6();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetOrderComment", "4e5377ef-07fe-40f1-af42-4f4003f4237a.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetOrderComment", "4e5377ef-07fe-40f1-af42-4f4003f4237a.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCommentAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCommentAttributeKeys.@CommentTypeId, "commenttypeid") ?? "commenttypeid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCommentAttributeKeys.@OrderId, "orderid") ?? "orderid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCommentAttributeKeys.@OrderApprovalLevelId, "orderapprovallevelid") ?? "orderapprovallevelid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCommentAttributeKeys.@EntraRoleId, "entraroleid") ?? "entraroleid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCommentAttributeKeys.@CreatedBy, "createdby") ?? "createdby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCommentAttributeKeys.@Message, "message") ?? "message", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
" FROM " + ENOrderCommentEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCommentAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetOrderComment", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(7,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENOrderCommentEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetOrderCommentForUpdate
/// </summary>

public static async Task<RC_cd61721ee82121e78e4055ba4deb1fa6> GetOrderCommentForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_cd61721ee82121e78e4055ba4deb1fa6 outParamRecord = default;
outParamRecord = new RC_cd61721ee82121e78e4055ba4deb1fa6();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetOrderCommentForUpdate", "4e5377ef-07fe-40f1-af42-4f4003f4237a.#GetEntityForUpdate");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetOrderCommentForUpdate", "4e5377ef-07fe-40f1-af42-4f4003f4237a.#GetEntityForUpdate", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCommentAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCommentAttributeKeys.@CommentTypeId, "commenttypeid") ?? "commenttypeid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCommentAttributeKeys.@OrderId, "orderid") ?? "orderid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCommentAttributeKeys.@OrderApprovalLevelId, "orderapprovallevelid") ?? "orderapprovallevelid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCommentAttributeKeys.@EntraRoleId, "entraroleid") ?? "entraroleid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCommentAttributeKeys.@CreatedBy, "createdby") ?? "createdby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCommentAttributeKeys.@Message, "message") ?? "message", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
" FROM " + ENOrderCommentEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCommentAttributeKeys.@Id, "id") ?? "id") + " = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetOrderCommentForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(7,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENOrderCommentEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateOrderComment
/// </summary>

public static async Task UpdateOrderComment(IRequestContext requestContext,BitArray usedFields,RC_cd61721ee82121e78e4055ba4deb1fa6 inParamSource,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("UpdateOrderComment", "4e5377ef-07fe-40f1-af42-4f4003f4237a.#UpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateOrderComment", "4e5377ef-07fe-40f1-af42-4f4003f4237a.#UpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord ssENOrderComment = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(7,true);
}
string updateSet = "UPDATE " + ENOrderCommentEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCommentAttributeKeys.@CommentTypeId, "commenttypeid") ?? "commenttypeid") + " = @ssCommentTypeId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCommentAttributeKeys.@OrderId, "orderid") ?? "orderid") + " = @ssOrderId"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCommentAttributeKeys.@OrderApprovalLevelId, "orderapprovallevelid") ?? "orderapprovallevelid") + " = @ssOrderApprovalLevelId"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCommentAttributeKeys.@EntraRoleId, "entraroleid") ?? "entraroleid") + " = @ssEntraRoleId"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCommentAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = @ssCreatedBy"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCommentAttributeKeys.@Message, "message") ?? "message") + " = @ssMessage"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCommentAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENOrderComment_ssId_OrderComment";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCommentAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCommentAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENOrderComment.ssCommentTypeId==0)) {
sqlCmd.CreateParameter("@ssCommentTypeId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCommentTypeId", DbType.Int32, ssENOrderComment.ssCommentTypeId);

}
}
if(usedFields[2]) {
if ((ssENOrderComment.ssOrderId==0L)) {
sqlCmd.CreateParameter("@ssOrderId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssOrderId", DbType.Int64, ssENOrderComment.ssOrderId);

}
}
if(usedFields[3]) {
if ((ssENOrderComment.ssOrderApprovalLevelId==0L)) {
sqlCmd.CreateParameter("@ssOrderApprovalLevelId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssOrderApprovalLevelId", DbType.Int64, ssENOrderComment.ssOrderApprovalLevelId);

}
}
if(usedFields[4]) {
if ((ssENOrderComment.ssEntraRoleId==0L)) {
sqlCmd.CreateParameter("@ssEntraRoleId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssEntraRoleId", DbType.Int64, ssENOrderComment.ssEntraRoleId);

}
}
if(usedFields[5]) {
if ((ssENOrderComment.ssCreatedBy=="")) {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENOrderComment.ssCreatedBy);

}
}
if(usedFields[6]) {
sqlCmd.CreateParameter("@ssMessage", DbType.String, ssENOrderComment.ssMessage);
}
sqlCmd.CreateParameter("@idparam_ssENOrderComment_ssId_OrderComment", DbType.Int64, ssENOrderComment.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateOrderComment", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("OrderComment", ssENOrderComment.ssId.ToString()); }}
}
return;
}

}
}
