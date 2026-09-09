using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateOrderRequestFileComment
/// </summary>

public static async Task<long> CreateOrderRequestFileComment(IRequestContext requestContext,RC_003b51eef272cce91f55924f504b1b11 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrderRequestFileComment", "fb518f51-1d90-43dd-b9c2-7829371fd93c.#CreateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrderRequestFileComment", "fb518f51-1d90-43dd-b9c2-7829371fd93c.#CreateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_4cb32cdf21d9078134019b8cfde83f76EntityRecord ssENOrderRequestFileComment = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENOrderRequestFileCommentEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileCommentAttributeKeys.@OrderRequestFileId, "orderrequestfileid") ?? "orderrequestfileid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileCommentAttributeKeys.@CommentTypeId, "commenttypeid") ?? "commenttypeid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileCommentAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileCommentAttributeKeys.@Message, "message") ?? "message") + "" +
" ) VALUES (" +
" @ssOrderRequestFileId" +
", @ssCommentTypeId" +
", @ssCreatedBy" +
", @ssMessage" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENOrderRequestFileComment.ssOrderRequestFileId==0L)) {
insertSqlCmd.CreateParameter("@ssOrderRequestFileId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssOrderRequestFileId", DbType.Int64, ssENOrderRequestFileComment.ssOrderRequestFileId);

}
if ((ssENOrderRequestFileComment.ssCommentTypeId==0)) {
insertSqlCmd.CreateParameter("@ssCommentTypeId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCommentTypeId", DbType.Int32, ssENOrderRequestFileComment.ssCommentTypeId);

}
if ((ssENOrderRequestFileComment.ssCreatedBy=="")) {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENOrderRequestFileComment.ssCreatedBy);

}
insertSqlCmd.CreateParameter("@ssMessage", DbType.String, ssENOrderRequestFileComment.ssMessage);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrderRequestFileComment", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateOrderRequestFileComment
/// </summary>

public static async Task<long> CreateOrUpdateOrderRequestFileComment(IRequestContext requestContext,BitArray usedFields,RC_003b51eef272cce91f55924f504b1b11 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateOrderRequestFileComment", "fb518f51-1d90-43dd-b9c2-7829371fd93c.#CreateOrUpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateOrderRequestFileComment", "fb518f51-1d90-43dd-b9c2-7829371fd93c.#CreateOrUpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_4cb32cdf21d9078134019b8cfde83f76EntityRecord ssENOrderRequestFileComment = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(5,true);
}
string updateSet = "UPDATE " + ENOrderRequestFileCommentEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileCommentAttributeKeys.@OrderRequestFileId, "orderrequestfileid") ?? "orderrequestfileid") + " = @ssOrderRequestFileId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileCommentAttributeKeys.@CommentTypeId, "commenttypeid") ?? "commenttypeid") + " = @ssCommentTypeId"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileCommentAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = @ssCreatedBy"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileCommentAttributeKeys.@Message, "message") ?? "message") + " = @ssMessage"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileCommentAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENOrderRequstFileComment_ssId_OrderRequestFileComment";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileCommentAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileCommentAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENOrderRequestFileComment.ssOrderRequestFileId==0L)) {
sqlCmd.CreateParameter("@ssOrderRequestFileId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssOrderRequestFileId", DbType.Int64, ssENOrderRequestFileComment.ssOrderRequestFileId);

}
}
if(usedFields[2]) {
if ((ssENOrderRequestFileComment.ssCommentTypeId==0)) {
sqlCmd.CreateParameter("@ssCommentTypeId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCommentTypeId", DbType.Int32, ssENOrderRequestFileComment.ssCommentTypeId);

}
}
if(usedFields[3]) {
if ((ssENOrderRequestFileComment.ssCreatedBy=="")) {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENOrderRequestFileComment.ssCreatedBy);

}
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssMessage", DbType.String, ssENOrderRequestFileComment.ssMessage);
}
sqlCmd.CreateParameter("@idparam_ssENOrderRequstFileComment_ssId_OrderRequestFileComment", DbType.Int64, ssENOrderRequestFileComment.ssId);
int counter = 0;
if(ssENOrderRequestFileComment.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateOrderRequestFileComment (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENOrderRequestFileCommentEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileCommentAttributeKeys.@OrderRequestFileId, "orderrequestfileid") ?? "orderrequestfileid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileCommentAttributeKeys.@CommentTypeId, "commenttypeid") ?? "commenttypeid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileCommentAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileCommentAttributeKeys.@Message, "message") ?? "message") + "" +
" ) VALUES (" +
" @ssOrderRequestFileId" +
", @ssCommentTypeId" +
", @ssCreatedBy" +
", @ssMessage" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENOrderRequestFileComment.ssOrderRequestFileId==0L)) {
insertSqlCmd.CreateParameter("@ssOrderRequestFileId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssOrderRequestFileId", DbType.Int64, ssENOrderRequestFileComment.ssOrderRequestFileId);

}
if ((ssENOrderRequestFileComment.ssCommentTypeId==0)) {
insertSqlCmd.CreateParameter("@ssCommentTypeId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCommentTypeId", DbType.Int32, ssENOrderRequestFileComment.ssCommentTypeId);

}
if ((ssENOrderRequestFileComment.ssCreatedBy=="")) {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENOrderRequestFileComment.ssCreatedBy);

}
insertSqlCmd.CreateParameter("@ssMessage", DbType.String, ssENOrderRequestFileComment.ssMessage);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateOrderRequestFileComment", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENOrderRequestFileComment.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeOrderRequestFileComment
/// </summary>

public static async Task CreateOrUpdateSomeOrderRequestFileComment(IRequestContext requestContext,RL_fdc18c89a95b980ffc7dc5524f9f65d7 inParamSourceList,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateSomeOrderRequestFileComment", "fb518f51-1d90-43dd-b9c2-7829371fd93c.#CreateOrUpdateAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeOrderRequestFileComment", "fb518f51-1d90-43dd-b9c2-7829371fd93c.#CreateOrUpdateAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
string entityTableName = ENOrderRequestFileCommentEntity.LocalViewName(null);
string insertSql = "INSERT INTO " + entityTableName + " (" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileCommentAttributeKeys.@OrderRequestFileId, "orderrequestfileid") ?? "orderrequestfileid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileCommentAttributeKeys.@CommentTypeId, "commenttypeid") ?? "commenttypeid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileCommentAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileCommentAttributeKeys.@Message, "message") ?? "message") + ") VALUES ( unnest(@ssOrderRequestFileId),  unnest(@ssCommentTypeId),  unnest(@ssCreatedBy),  unnest(@ssMessage)) ";
insertSql += "";

string updateSql = "UPDATE " + entityTableName + " SET " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileCommentAttributeKeys.@OrderRequestFileId, "orderrequestfileid") ?? "orderrequestfileid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileCommentAttributeKeys.@OrderRequestFileId, "orderrequestfileid") ?? "orderrequestfileid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileCommentAttributeKeys.@CommentTypeId, "commenttypeid") ?? "commenttypeid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileCommentAttributeKeys.@CommentTypeId, "commenttypeid") ?? "commenttypeid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileCommentAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileCommentAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileCommentAttributeKeys.@Message, "message") ?? "message") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileCommentAttributeKeys.@Message, "message") ?? "message") + " from ( select  unnest(@ssId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileCommentAttributeKeys.@Id, "id") ?? "id") + ",  unnest(@ssOrderRequestFileId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileCommentAttributeKeys.@OrderRequestFileId, "orderrequestfileid") ?? "orderrequestfileid") + ",  unnest(@ssCommentTypeId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileCommentAttributeKeys.@CommentTypeId, "commenttypeid") ?? "commenttypeid") + ",  unnest(@ssCreatedBy) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileCommentAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + ",  unnest(@ssMessage) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileCommentAttributeKeys.@Message, "message") ?? "message") + " ) as updateTable where " + entityTableName + "." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileCommentAttributeKeys.@Id, "id") ?? "id") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileCommentAttributeKeys.@Id, "id") ?? "id") + " ";
updateSql += "";

List<object> insertOrderRequestFileIdList = new List<object>();
List<object> insertCommentTypeIdList = new List<object>();
List<object> insertCreatedByList = new List<object>();
List<string> insertMessageList = new List<string>();

List<long> updateIdList = new List<long>();
List<object> updateOrderRequestFileIdList = new List<object>();
List<object> updateCommentTypeIdList = new List<object>();
List<object> updateCreatedByList = new List<object>();
List<string> updateMessageList = new List<string>();

var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_003b51eef272cce91f55924f504b1b11)inParamSourceList.Current).ssENOrderRequestFileComment;
if (record.ssId != 0L) {
updateIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
if ((record.ssOrderRequestFileId==0L)) {
updateOrderRequestFileIdList.Add(null);
} else {
updateOrderRequestFileIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssOrderRequestFileId));
}
if ((record.ssCommentTypeId==0)) {
updateCommentTypeIdList.Add(null);
} else {
updateCommentTypeIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssCommentTypeId));
}
if ((record.ssCreatedBy=="")) {
updateCreatedByList.Add(null);
} else {
updateCreatedByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssCreatedBy));
}
updateMessageList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssMessage));
} else {
if ((record.ssOrderRequestFileId==0L)) {
insertOrderRequestFileIdList.Add(null);
} else {
insertOrderRequestFileIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssOrderRequestFileId));
}
if ((record.ssCommentTypeId==0)) {
insertCommentTypeIdList.Add(null);
} else {
insertCommentTypeIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssCommentTypeId));
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
if (!insertOrderRequestFileIdList.IsEmpty() || !insertCommentTypeIdList.IsEmpty() || !insertCreatedByList.IsEmpty() || !insertMessageList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssOrderRequestFileId",DbType.Int64,insertOrderRequestFileIdList);
executionService.CreateParameter(insertSqlCmd,"@ssCommentTypeId",DbType.Int32,insertCommentTypeIdList);
executionService.CreateParameter(insertSqlCmd,"@ssCreatedBy",DbType.String,insertCreatedByList);
executionService.CreateParameter(insertSqlCmd,"@ssMessage",DbType.String,insertMessageList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeOrderRequestFileComment (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
if(!updateOrderRequestFileIdList.IsEmpty() || !updateCommentTypeIdList.IsEmpty() || !updateCreatedByList.IsEmpty() || !updateMessageList.IsEmpty()){
await using(var updateSqlCmd = trans.CreateCommand(updateSql)){
executionService.CreateParameter(updateSqlCmd,"@ssId",DbType.Int64,updateIdList);
executionService.CreateParameter(updateSqlCmd,"@ssOrderRequestFileId",DbType.Int64,updateOrderRequestFileIdList);
executionService.CreateParameter(updateSqlCmd,"@ssCommentTypeId",DbType.Int32,updateCommentTypeIdList);
executionService.CreateParameter(updateSqlCmd,"@ssCreatedBy",DbType.String,updateCreatedByList);
executionService.CreateParameter(updateSqlCmd,"@ssMessage",DbType.String,updateMessageList);
await updateSqlCmd.PrepareAsync(cancellationToken);
await updateSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeOrderRequestFileComment (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(updateSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteOrderRequestFileComment
/// </summary>

public static async Task DeleteOrderRequestFileComment(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteOrderRequestFileComment", "fb518f51-1d90-43dd-b9c2-7829371fd93c.#DeleteEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteOrderRequestFileComment", "fb518f51-1d90-43dd-b9c2-7829371fd93c.#DeleteEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENOrderRequestFileCommentEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileCommentAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteOrderRequestFileComment", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllOrderRequestFileComment
/// </summary>

public static async Task DeleteAllOrderRequestFileComment(IRequestContext requestContext,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteAllOrderRequestFileComment", "fb518f51-1d90-43dd-b9c2-7829371fd93c.#DeleteAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllOrderRequestFileComment", "fb518f51-1d90-43dd-b9c2-7829371fd93c.#DeleteAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENOrderRequestFileCommentEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteOrderRequestFileComment", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetOrderRequestFileComment
/// </summary>

public static async Task<RC_003b51eef272cce91f55924f504b1b11> GetOrderRequestFileComment(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_003b51eef272cce91f55924f504b1b11 outParamRecord = default;
outParamRecord = new RC_003b51eef272cce91f55924f504b1b11();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetOrderRequestFileComment", "fb518f51-1d90-43dd-b9c2-7829371fd93c.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetOrderRequestFileComment", "fb518f51-1d90-43dd-b9c2-7829371fd93c.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileCommentAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileCommentAttributeKeys.@OrderRequestFileId, "orderrequestfileid") ?? "orderrequestfileid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileCommentAttributeKeys.@CommentTypeId, "commenttypeid") ?? "commenttypeid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileCommentAttributeKeys.@CreatedBy, "createdby") ?? "createdby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileCommentAttributeKeys.@Message, "message") ?? "message", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
" FROM " + ENOrderRequestFileCommentEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileCommentAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetOrderRequestFileComment", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(5,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENOrderRequestFileCommentEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetOrderRequestFileCommentForUpdate
/// </summary>

public static async Task<RC_003b51eef272cce91f55924f504b1b11> GetOrderRequestFileCommentForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_003b51eef272cce91f55924f504b1b11 outParamRecord = default;
outParamRecord = new RC_003b51eef272cce91f55924f504b1b11();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetOrderRequestFileCommentForUpdate", "fb518f51-1d90-43dd-b9c2-7829371fd93c.#GetEntityForUpdate");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetOrderRequestFileCommentForUpdate", "fb518f51-1d90-43dd-b9c2-7829371fd93c.#GetEntityForUpdate", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileCommentAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileCommentAttributeKeys.@OrderRequestFileId, "orderrequestfileid") ?? "orderrequestfileid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileCommentAttributeKeys.@CommentTypeId, "commenttypeid") ?? "commenttypeid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileCommentAttributeKeys.@CreatedBy, "createdby") ?? "createdby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileCommentAttributeKeys.@Message, "message") ?? "message", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
" FROM " + ENOrderRequestFileCommentEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileCommentAttributeKeys.@Id, "id") ?? "id") + " = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetOrderRequestFileCommentForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(5,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENOrderRequestFileCommentEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateOrderRequestFileComment
/// </summary>

public static async Task UpdateOrderRequestFileComment(IRequestContext requestContext,BitArray usedFields,RC_003b51eef272cce91f55924f504b1b11 inParamSource,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("UpdateOrderRequestFileComment", "fb518f51-1d90-43dd-b9c2-7829371fd93c.#UpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateOrderRequestFileComment", "fb518f51-1d90-43dd-b9c2-7829371fd93c.#UpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_4cb32cdf21d9078134019b8cfde83f76EntityRecord ssENOrderRequestFileComment = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(5,true);
}
string updateSet = "UPDATE " + ENOrderRequestFileCommentEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileCommentAttributeKeys.@OrderRequestFileId, "orderrequestfileid") ?? "orderrequestfileid") + " = @ssOrderRequestFileId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileCommentAttributeKeys.@CommentTypeId, "commenttypeid") ?? "commenttypeid") + " = @ssCommentTypeId"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileCommentAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = @ssCreatedBy"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileCommentAttributeKeys.@Message, "message") ?? "message") + " = @ssMessage"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileCommentAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENOrderRequstFileComment_ssId_OrderRequestFileComment";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileCommentAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileCommentAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENOrderRequestFileComment.ssOrderRequestFileId==0L)) {
sqlCmd.CreateParameter("@ssOrderRequestFileId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssOrderRequestFileId", DbType.Int64, ssENOrderRequestFileComment.ssOrderRequestFileId);

}
}
if(usedFields[2]) {
if ((ssENOrderRequestFileComment.ssCommentTypeId==0)) {
sqlCmd.CreateParameter("@ssCommentTypeId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCommentTypeId", DbType.Int32, ssENOrderRequestFileComment.ssCommentTypeId);

}
}
if(usedFields[3]) {
if ((ssENOrderRequestFileComment.ssCreatedBy=="")) {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENOrderRequestFileComment.ssCreatedBy);

}
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssMessage", DbType.String, ssENOrderRequestFileComment.ssMessage);
}
sqlCmd.CreateParameter("@idparam_ssENOrderRequstFileComment_ssId_OrderRequestFileComment", DbType.Int64, ssENOrderRequestFileComment.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateOrderRequestFileComment", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("OrderRequestFileComment", ssENOrderRequestFileComment.ssId.ToString()); }}
}
return;
}

}
}
