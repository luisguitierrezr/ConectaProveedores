using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateInvoiceComment
/// </summary>

public static async Task<long> CreateInvoiceComment(IRequestContext requestContext,RC_85ff0b93155717e6346b97d39d3b0222 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateInvoiceComment", "3d967be5-a4be-4dd9-88b0-bfde9c1c6ffe.#CreateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateInvoiceComment", "3d967be5-a4be-4dd9-88b0-bfde9c1c6ffe.#CreateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord ssENInvoiceComment = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENInvoiceCommentEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@InvoiceApprovalLevelId, "invoiceapprovallevelid") ?? "invoiceapprovallevelid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@Message, "message") ?? "message") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@IsPublic, "ispublic") ?? "ispublic") + "" +
" ) VALUES (" +
" @ssInvoiceId" +
", @ssInvoiceApprovalLevelId" +
", @ssApplicationRoleId" +
", @ssCreatedOn" +
", @ssCreatedBy" +
", @ssMessage" +
", @ssIsPublic" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENInvoiceComment.ssInvoiceId==0L)) {
insertSqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, ssENInvoiceComment.ssInvoiceId);

}
if ((ssENInvoiceComment.ssInvoiceApprovalLevelId==0L)) {
insertSqlCmd.CreateParameter("@ssInvoiceApprovalLevelId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssInvoiceApprovalLevelId", DbType.Int64, ssENInvoiceComment.ssInvoiceApprovalLevelId);

}
if ((ssENInvoiceComment.ssApplicationRoleId==0L)) {
insertSqlCmd.CreateParameter("@ssApplicationRoleId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssApplicationRoleId", DbType.Int64, ssENInvoiceComment.ssApplicationRoleId);

}
insertSqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENInvoiceComment.ssCreatedOn);
if ((ssENInvoiceComment.ssCreatedBy=="")) {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENInvoiceComment.ssCreatedBy);

}
insertSqlCmd.CreateParameter("@ssMessage", DbType.String, ssENInvoiceComment.ssMessage);
insertSqlCmd.CreateParameter("@ssIsPublic", DbType.Boolean, ssENInvoiceComment.ssIsPublic);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateInvoiceComment", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateInvoiceComment
/// </summary>

public static async Task<long> CreateOrUpdateInvoiceComment(IRequestContext requestContext,BitArray usedFields,RC_85ff0b93155717e6346b97d39d3b0222 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateInvoiceComment", "3d967be5-a4be-4dd9-88b0-bfde9c1c6ffe.#CreateOrUpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateInvoiceComment", "3d967be5-a4be-4dd9-88b0-bfde9c1c6ffe.#CreateOrUpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord ssENInvoiceComment = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(8,true);
}
string updateSet = "UPDATE " + ENInvoiceCommentEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + " = @ssInvoiceId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@InvoiceApprovalLevelId, "invoiceapprovallevelid") ?? "invoiceapprovallevelid") + " = @ssInvoiceApprovalLevelId"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid") + " = @ssApplicationRoleId"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = @ssCreatedOn"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = @ssCreatedBy"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@Message, "message") ?? "message") + " = @ssMessage"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@IsPublic, "ispublic") ?? "ispublic") + " = @ssIsPublic"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENInvoiceComment_ssId_InvoiceComment";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@IsPublic, "ispublic") ?? "ispublic") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@IsPublic, "ispublic") ?? "ispublic") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENInvoiceComment.ssInvoiceId==0L)) {
sqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, ssENInvoiceComment.ssInvoiceId);

}
}
if(usedFields[2]) {
if ((ssENInvoiceComment.ssInvoiceApprovalLevelId==0L)) {
sqlCmd.CreateParameter("@ssInvoiceApprovalLevelId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssInvoiceApprovalLevelId", DbType.Int64, ssENInvoiceComment.ssInvoiceApprovalLevelId);

}
}
if(usedFields[3]) {
if ((ssENInvoiceComment.ssApplicationRoleId==0L)) {
sqlCmd.CreateParameter("@ssApplicationRoleId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssApplicationRoleId", DbType.Int64, ssENInvoiceComment.ssApplicationRoleId);

}
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENInvoiceComment.ssCreatedOn);
}
if(usedFields[5]) {
if ((ssENInvoiceComment.ssCreatedBy=="")) {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENInvoiceComment.ssCreatedBy);

}
}
if(usedFields[6]) {
sqlCmd.CreateParameter("@ssMessage", DbType.String, ssENInvoiceComment.ssMessage);
}
if(usedFields[7]) {
sqlCmd.CreateParameter("@ssIsPublic", DbType.Boolean, ssENInvoiceComment.ssIsPublic);
}
sqlCmd.CreateParameter("@idparam_ssENInvoiceComment_ssId_InvoiceComment", DbType.Int64, ssENInvoiceComment.ssId);
int counter = 0;
if(ssENInvoiceComment.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateInvoiceComment (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENInvoiceCommentEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@InvoiceApprovalLevelId, "invoiceapprovallevelid") ?? "invoiceapprovallevelid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@Message, "message") ?? "message") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@IsPublic, "ispublic") ?? "ispublic") + "" +
" ) VALUES (" +
" @ssInvoiceId" +
", @ssInvoiceApprovalLevelId" +
", @ssApplicationRoleId" +
", @ssCreatedOn" +
", @ssCreatedBy" +
", @ssMessage" +
", @ssIsPublic" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENInvoiceComment.ssInvoiceId==0L)) {
insertSqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, ssENInvoiceComment.ssInvoiceId);

}
if ((ssENInvoiceComment.ssInvoiceApprovalLevelId==0L)) {
insertSqlCmd.CreateParameter("@ssInvoiceApprovalLevelId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssInvoiceApprovalLevelId", DbType.Int64, ssENInvoiceComment.ssInvoiceApprovalLevelId);

}
if ((ssENInvoiceComment.ssApplicationRoleId==0L)) {
insertSqlCmd.CreateParameter("@ssApplicationRoleId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssApplicationRoleId", DbType.Int64, ssENInvoiceComment.ssApplicationRoleId);

}
insertSqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENInvoiceComment.ssCreatedOn);
if ((ssENInvoiceComment.ssCreatedBy=="")) {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENInvoiceComment.ssCreatedBy);

}
insertSqlCmd.CreateParameter("@ssMessage", DbType.String, ssENInvoiceComment.ssMessage);
insertSqlCmd.CreateParameter("@ssIsPublic", DbType.Boolean, ssENInvoiceComment.ssIsPublic);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateInvoiceComment", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENInvoiceComment.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeInvoiceComment
/// </summary>

public static async Task CreateOrUpdateSomeInvoiceComment(IRequestContext requestContext,RL_2e7f130f9df070446bc2a9ac7dcde539 inParamSourceList,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateSomeInvoiceComment", "3d967be5-a4be-4dd9-88b0-bfde9c1c6ffe.#CreateOrUpdateAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeInvoiceComment", "3d967be5-a4be-4dd9-88b0-bfde9c1c6ffe.#CreateOrUpdateAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
string entityTableName = ENInvoiceCommentEntity.LocalViewName(null);
string insertSql = "INSERT INTO " + entityTableName + " (" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@InvoiceApprovalLevelId, "invoiceapprovallevelid") ?? "invoiceapprovallevelid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@Message, "message") ?? "message") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@IsPublic, "ispublic") ?? "ispublic") + ") VALUES ( unnest(@ssInvoiceId),  unnest(@ssInvoiceApprovalLevelId),  unnest(@ssApplicationRoleId),  unnest(@ssCreatedOn),  unnest(@ssCreatedBy),  unnest(@ssMessage),  unnest(@ssIsPublic)) ";
insertSql += "";

string updateSql = "UPDATE " + entityTableName + " SET " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@InvoiceApprovalLevelId, "invoiceapprovallevelid") ?? "invoiceapprovallevelid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@InvoiceApprovalLevelId, "invoiceapprovallevelid") ?? "invoiceapprovallevelid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@Message, "message") ?? "message") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@Message, "message") ?? "message") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@IsPublic, "ispublic") ?? "ispublic") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@IsPublic, "ispublic") ?? "ispublic") + " from ( select  unnest(@ssId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@Id, "id") ?? "id") + ",  unnest(@ssInvoiceId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + ",  unnest(@ssInvoiceApprovalLevelId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@InvoiceApprovalLevelId, "invoiceapprovallevelid") ?? "invoiceapprovallevelid") + ",  unnest(@ssApplicationRoleId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid") + ",  unnest(@ssCreatedOn) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + ",  unnest(@ssCreatedBy) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + ",  unnest(@ssMessage) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@Message, "message") ?? "message") + ",  unnest(@ssIsPublic) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@IsPublic, "ispublic") ?? "ispublic") + " ) as updateTable where " + entityTableName + "." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@Id, "id") ?? "id") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@Id, "id") ?? "id") + " ";
updateSql += "";

List<object> insertInvoiceIdList = new List<object>();
List<object> insertInvoiceApprovalLevelIdList = new List<object>();
List<object> insertApplicationRoleIdList = new List<object>();
List<DateTime> insertCreatedOnList = new List<DateTime>();
List<object> insertCreatedByList = new List<object>();
List<string> insertMessageList = new List<string>();
List<bool> insertIsPublicList = new List<bool>();

List<long> updateIdList = new List<long>();
List<object> updateInvoiceIdList = new List<object>();
List<object> updateInvoiceApprovalLevelIdList = new List<object>();
List<object> updateApplicationRoleIdList = new List<object>();
List<DateTime> updateCreatedOnList = new List<DateTime>();
List<object> updateCreatedByList = new List<object>();
List<string> updateMessageList = new List<string>();
List<bool> updateIsPublicList = new List<bool>();

var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_85ff0b93155717e6346b97d39d3b0222)inParamSourceList.Current).ssENInvoiceComment;
if (record.ssId != 0L) {
updateIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
if ((record.ssInvoiceId==0L)) {
updateInvoiceIdList.Add(null);
} else {
updateInvoiceIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssInvoiceId));
}
if ((record.ssInvoiceApprovalLevelId==0L)) {
updateInvoiceApprovalLevelIdList.Add(null);
} else {
updateInvoiceApprovalLevelIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssInvoiceApprovalLevelId));
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
if ((record.ssInvoiceId==0L)) {
insertInvoiceIdList.Add(null);
} else {
insertInvoiceIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssInvoiceId));
}
if ((record.ssInvoiceApprovalLevelId==0L)) {
insertInvoiceApprovalLevelIdList.Add(null);
} else {
insertInvoiceApprovalLevelIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssInvoiceApprovalLevelId));
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
if (!insertInvoiceIdList.IsEmpty() || !insertInvoiceApprovalLevelIdList.IsEmpty() || !insertApplicationRoleIdList.IsEmpty() || !insertCreatedOnList.IsEmpty() || !insertCreatedByList.IsEmpty() || !insertMessageList.IsEmpty() || !insertIsPublicList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssInvoiceId",DbType.Int64,insertInvoiceIdList);
executionService.CreateParameter(insertSqlCmd,"@ssInvoiceApprovalLevelId",DbType.Int64,insertInvoiceApprovalLevelIdList);
executionService.CreateParameter(insertSqlCmd,"@ssApplicationRoleId",DbType.Int64,insertApplicationRoleIdList);
executionService.CreateParameter(insertSqlCmd,"@ssCreatedOn",DbType.DateTime,insertCreatedOnList);
executionService.CreateParameter(insertSqlCmd,"@ssCreatedBy",DbType.String,insertCreatedByList);
executionService.CreateParameter(insertSqlCmd,"@ssMessage",DbType.String,insertMessageList);
executionService.CreateParameter(insertSqlCmd,"@ssIsPublic",DbType.Boolean,insertIsPublicList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeInvoiceComment (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
if(!updateInvoiceIdList.IsEmpty() || !updateInvoiceApprovalLevelIdList.IsEmpty() || !updateApplicationRoleIdList.IsEmpty() || !updateCreatedOnList.IsEmpty() || !updateCreatedByList.IsEmpty() || !updateMessageList.IsEmpty() || !updateIsPublicList.IsEmpty()){
await using(var updateSqlCmd = trans.CreateCommand(updateSql)){
executionService.CreateParameter(updateSqlCmd,"@ssId",DbType.Int64,updateIdList);
executionService.CreateParameter(updateSqlCmd,"@ssInvoiceId",DbType.Int64,updateInvoiceIdList);
executionService.CreateParameter(updateSqlCmd,"@ssInvoiceApprovalLevelId",DbType.Int64,updateInvoiceApprovalLevelIdList);
executionService.CreateParameter(updateSqlCmd,"@ssApplicationRoleId",DbType.Int64,updateApplicationRoleIdList);
executionService.CreateParameter(updateSqlCmd,"@ssCreatedOn",DbType.DateTime,updateCreatedOnList);
executionService.CreateParameter(updateSqlCmd,"@ssCreatedBy",DbType.String,updateCreatedByList);
executionService.CreateParameter(updateSqlCmd,"@ssMessage",DbType.String,updateMessageList);
executionService.CreateParameter(updateSqlCmd,"@ssIsPublic",DbType.Boolean,updateIsPublicList);
await updateSqlCmd.PrepareAsync(cancellationToken);
await updateSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeInvoiceComment (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(updateSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteInvoiceComment
/// </summary>

public static async Task DeleteInvoiceComment(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteInvoiceComment", "3d967be5-a4be-4dd9-88b0-bfde9c1c6ffe.#DeleteEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteInvoiceComment", "3d967be5-a4be-4dd9-88b0-bfde9c1c6ffe.#DeleteEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENInvoiceCommentEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteInvoiceComment", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllInvoiceComment
/// </summary>

public static async Task DeleteAllInvoiceComment(IRequestContext requestContext,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteAllInvoiceComment", "3d967be5-a4be-4dd9-88b0-bfde9c1c6ffe.#DeleteAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllInvoiceComment", "3d967be5-a4be-4dd9-88b0-bfde9c1c6ffe.#DeleteAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENInvoiceCommentEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteInvoiceComment", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetInvoiceComment
/// </summary>

public static async Task<RC_85ff0b93155717e6346b97d39d3b0222> GetInvoiceComment(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_85ff0b93155717e6346b97d39d3b0222 outParamRecord = default;
outParamRecord = new RC_85ff0b93155717e6346b97d39d3b0222();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetInvoiceComment", "3d967be5-a4be-4dd9-88b0-bfde9c1c6ffe.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetInvoiceComment", "3d967be5-a4be-4dd9-88b0-bfde9c1c6ffe.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@InvoiceApprovalLevelId, "invoiceapprovallevelid") ?? "invoiceapprovallevelid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@CreatedOn, "createdon") ?? "createdon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@CreatedBy, "createdby") ?? "createdby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@Message, "message") ?? "message", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@IsPublic, "ispublic") ?? "ispublic", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
" FROM " + ENInvoiceCommentEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetInvoiceComment", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(8,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENInvoiceCommentEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetInvoiceCommentForUpdate
/// </summary>

public static async Task<RC_85ff0b93155717e6346b97d39d3b0222> GetInvoiceCommentForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_85ff0b93155717e6346b97d39d3b0222 outParamRecord = default;
outParamRecord = new RC_85ff0b93155717e6346b97d39d3b0222();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetInvoiceCommentForUpdate", "3d967be5-a4be-4dd9-88b0-bfde9c1c6ffe.#GetEntityForUpdate");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetInvoiceCommentForUpdate", "3d967be5-a4be-4dd9-88b0-bfde9c1c6ffe.#GetEntityForUpdate", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@InvoiceApprovalLevelId, "invoiceapprovallevelid") ?? "invoiceapprovallevelid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@CreatedOn, "createdon") ?? "createdon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@CreatedBy, "createdby") ?? "createdby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@Message, "message") ?? "message", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@IsPublic, "ispublic") ?? "ispublic", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
" FROM " + ENInvoiceCommentEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@Id, "id") ?? "id") + " = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetInvoiceCommentForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(8,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENInvoiceCommentEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateInvoiceComment
/// </summary>

public static async Task UpdateInvoiceComment(IRequestContext requestContext,BitArray usedFields,RC_85ff0b93155717e6346b97d39d3b0222 inParamSource,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("UpdateInvoiceComment", "3d967be5-a4be-4dd9-88b0-bfde9c1c6ffe.#UpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateInvoiceComment", "3d967be5-a4be-4dd9-88b0-bfde9c1c6ffe.#UpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord ssENInvoiceComment = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(8,true);
}
string updateSet = "UPDATE " + ENInvoiceCommentEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + " = @ssInvoiceId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@InvoiceApprovalLevelId, "invoiceapprovallevelid") ?? "invoiceapprovallevelid") + " = @ssInvoiceApprovalLevelId"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid") + " = @ssApplicationRoleId"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = @ssCreatedOn"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = @ssCreatedBy"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@Message, "message") ?? "message") + " = @ssMessage"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@IsPublic, "ispublic") ?? "ispublic") + " = @ssIsPublic"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENInvoiceComment_ssId_InvoiceComment";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@IsPublic, "ispublic") ?? "ispublic") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@IsPublic, "ispublic") ?? "ispublic") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENInvoiceComment.ssInvoiceId==0L)) {
sqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, ssENInvoiceComment.ssInvoiceId);

}
}
if(usedFields[2]) {
if ((ssENInvoiceComment.ssInvoiceApprovalLevelId==0L)) {
sqlCmd.CreateParameter("@ssInvoiceApprovalLevelId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssInvoiceApprovalLevelId", DbType.Int64, ssENInvoiceComment.ssInvoiceApprovalLevelId);

}
}
if(usedFields[3]) {
if ((ssENInvoiceComment.ssApplicationRoleId==0L)) {
sqlCmd.CreateParameter("@ssApplicationRoleId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssApplicationRoleId", DbType.Int64, ssENInvoiceComment.ssApplicationRoleId);

}
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENInvoiceComment.ssCreatedOn);
}
if(usedFields[5]) {
if ((ssENInvoiceComment.ssCreatedBy=="")) {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENInvoiceComment.ssCreatedBy);

}
}
if(usedFields[6]) {
sqlCmd.CreateParameter("@ssMessage", DbType.String, ssENInvoiceComment.ssMessage);
}
if(usedFields[7]) {
sqlCmd.CreateParameter("@ssIsPublic", DbType.Boolean, ssENInvoiceComment.ssIsPublic);
}
sqlCmd.CreateParameter("@idparam_ssENInvoiceComment_ssId_InvoiceComment", DbType.Int64, ssENInvoiceComment.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateInvoiceComment", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("InvoiceComment", ssENInvoiceComment.ssId.ToString()); }}
}
return;
}

}
}
