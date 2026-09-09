using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateRequisitionFile2
/// </summary>

public static async Task<long> CreateRequisitionFile2(IRequestContext requestContext,RC_3e0fb635eefe948054fa75421546a901 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateRequisitionFile2", "ee5a0533-850e-497a-8b5d-925f433484c3.#CreateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateRequisitionFile2", "ee5a0533-850e-497a-8b5d-925f433484c3.#CreateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_4cce425e15647f937e21de4e52849889EntityRecord ssENRequisitionFile2 = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENRequisitionFile2Entity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@Filename, "filename") ?? "filename") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@VENDOR, "vendor") ?? "vendor") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@DOC_TYPE, "doc_type") ?? "doc_type") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@SAP_OBJECT, "sap_object") ?? "sap_object") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@CreatedBy, "createdby") ?? "createdby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@CreatedOn, "createdon") ?? "createdon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@StorageId, "storageid") ?? "storageid") + "" +
" ) VALUES (" +
" @ssFilename" +
", @ssVENDOR" +
", @ssDOC_TYPE" +
", @ssSAP_OBJECT" +
", @ssCreatedBy" +
", @ssCreatedOn" +
", @ssStorageId" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssFilename", DbType.String, ssENRequisitionFile2.ssFilename);
insertSqlCmd.CreateParameter("@ssVENDOR", DbType.String, ssENRequisitionFile2.ssVENDOR);
insertSqlCmd.CreateParameter("@ssDOC_TYPE", DbType.String, ssENRequisitionFile2.ssDOC_TYPE);
insertSqlCmd.CreateParameter("@ssSAP_OBJECT", DbType.String, ssENRequisitionFile2.ssSAP_OBJECT);
if ((ssENRequisitionFile2.ssCreatedBy=="")) {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENRequisitionFile2.ssCreatedBy);

}
insertSqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENRequisitionFile2.ssCreatedOn);
if ((ssENRequisitionFile2.ssStorageId==0L)) {
insertSqlCmd.CreateParameter("@ssStorageId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssStorageId", DbType.Int64, ssENRequisitionFile2.ssStorageId);

}
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateRequisitionFile2", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateRequisitionFile2
/// </summary>

public static async Task<long> CreateOrUpdateRequisitionFile2(IRequestContext requestContext,BitArray usedFields,RC_3e0fb635eefe948054fa75421546a901 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateRequisitionFile2", "ee5a0533-850e-497a-8b5d-925f433484c3.#CreateOrUpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateRequisitionFile2", "ee5a0533-850e-497a-8b5d-925f433484c3.#CreateOrUpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_4cce425e15647f937e21de4e52849889EntityRecord ssENRequisitionFile2 = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(8,true);
}
string updateSet = "UPDATE " + ENRequisitionFile2Entity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@Filename, "filename") ?? "filename") + " = @ssFilename"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@VENDOR, "vendor") ?? "vendor") + " = @ssVENDOR"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@DOC_TYPE, "doc_type") ?? "doc_type") + " = @ssDOC_TYPE"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@SAP_OBJECT, "sap_object") ?? "sap_object") + " = @ssSAP_OBJECT"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = @ssCreatedBy"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = @ssCreatedOn"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@StorageId, "storageid") ?? "storageid") + " = @ssStorageId"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENRequisitionFile2_ssId_RequisitionFile2";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@CreatedOn, "createdon") ?? "createdon") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssFilename", DbType.String, ssENRequisitionFile2.ssFilename);
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssVENDOR", DbType.String, ssENRequisitionFile2.ssVENDOR);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssDOC_TYPE", DbType.String, ssENRequisitionFile2.ssDOC_TYPE);
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssSAP_OBJECT", DbType.String, ssENRequisitionFile2.ssSAP_OBJECT);
}
if(usedFields[5]) {
if ((ssENRequisitionFile2.ssCreatedBy=="")) {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENRequisitionFile2.ssCreatedBy);

}
}
if(usedFields[6]) {
sqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENRequisitionFile2.ssCreatedOn);
}
if(usedFields[7]) {
if ((ssENRequisitionFile2.ssStorageId==0L)) {
sqlCmd.CreateParameter("@ssStorageId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssStorageId", DbType.Int64, ssENRequisitionFile2.ssStorageId);

}
}
sqlCmd.CreateParameter("@idparam_ssENRequisitionFile2_ssId_RequisitionFile2", DbType.Int64, ssENRequisitionFile2.ssId);
int counter = 0;
if(ssENRequisitionFile2.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateRequisitionFile2 (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENRequisitionFile2Entity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@Filename, "filename") ?? "filename") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@VENDOR, "vendor") ?? "vendor") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@DOC_TYPE, "doc_type") ?? "doc_type") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@SAP_OBJECT, "sap_object") ?? "sap_object") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@CreatedBy, "createdby") ?? "createdby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@CreatedOn, "createdon") ?? "createdon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@StorageId, "storageid") ?? "storageid") + "" +
" ) VALUES (" +
" @ssFilename" +
", @ssVENDOR" +
", @ssDOC_TYPE" +
", @ssSAP_OBJECT" +
", @ssCreatedBy" +
", @ssCreatedOn" +
", @ssStorageId" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssFilename", DbType.String, ssENRequisitionFile2.ssFilename);
insertSqlCmd.CreateParameter("@ssVENDOR", DbType.String, ssENRequisitionFile2.ssVENDOR);
insertSqlCmd.CreateParameter("@ssDOC_TYPE", DbType.String, ssENRequisitionFile2.ssDOC_TYPE);
insertSqlCmd.CreateParameter("@ssSAP_OBJECT", DbType.String, ssENRequisitionFile2.ssSAP_OBJECT);
if ((ssENRequisitionFile2.ssCreatedBy=="")) {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENRequisitionFile2.ssCreatedBy);

}
insertSqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENRequisitionFile2.ssCreatedOn);
if ((ssENRequisitionFile2.ssStorageId==0L)) {
insertSqlCmd.CreateParameter("@ssStorageId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssStorageId", DbType.Int64, ssENRequisitionFile2.ssStorageId);

}
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateRequisitionFile2", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENRequisitionFile2.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeRequisitionFile2
/// </summary>

public static async Task CreateOrUpdateSomeRequisitionFile2(IRequestContext requestContext,RL_2895ef65cfa24878b5b55c2c334b2f76 inParamSourceList,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateSomeRequisitionFile2", "ee5a0533-850e-497a-8b5d-925f433484c3.#CreateOrUpdateAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeRequisitionFile2", "ee5a0533-850e-497a-8b5d-925f433484c3.#CreateOrUpdateAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
string entityTableName = ENRequisitionFile2Entity.LocalViewName(null);
string insertSql = "INSERT INTO " + entityTableName + " (" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@Filename, "filename") ?? "filename") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@VENDOR, "vendor") ?? "vendor") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@DOC_TYPE, "doc_type") ?? "doc_type") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@SAP_OBJECT, "sap_object") ?? "sap_object") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@CreatedBy, "createdby") ?? "createdby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@CreatedOn, "createdon") ?? "createdon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@StorageId, "storageid") ?? "storageid") + ") VALUES ( unnest(@ssFilename),  unnest(@ssVENDOR),  unnest(@ssDOC_TYPE),  unnest(@ssSAP_OBJECT),  unnest(@ssCreatedBy),  unnest(@ssCreatedOn),  unnest(@ssStorageId)) ";
insertSql += "";

string updateSql = "UPDATE " + entityTableName + " SET " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@Filename, "filename") ?? "filename") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@Filename, "filename") ?? "filename") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@VENDOR, "vendor") ?? "vendor") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@VENDOR, "vendor") ?? "vendor") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@DOC_TYPE, "doc_type") ?? "doc_type") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@DOC_TYPE, "doc_type") ?? "doc_type") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@SAP_OBJECT, "sap_object") ?? "sap_object") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@SAP_OBJECT, "sap_object") ?? "sap_object") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@CreatedBy, "createdby") ?? "createdby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@CreatedOn, "createdon") ?? "createdon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@StorageId, "storageid") ?? "storageid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@StorageId, "storageid") ?? "storageid") + " from ( select  unnest(@ssId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@Id, "id") ?? "id") + ",  unnest(@ssFilename) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@Filename, "filename") ?? "filename") + ",  unnest(@ssVENDOR) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@VENDOR, "vendor") ?? "vendor") + ",  unnest(@ssDOC_TYPE) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@DOC_TYPE, "doc_type") ?? "doc_type") + ",  unnest(@ssSAP_OBJECT) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@SAP_OBJECT, "sap_object") ?? "sap_object") + ",  unnest(@ssCreatedBy) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@CreatedBy, "createdby") ?? "createdby") + ",  unnest(@ssCreatedOn) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@CreatedOn, "createdon") ?? "createdon") + ",  unnest(@ssStorageId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@StorageId, "storageid") ?? "storageid") + " ) as updateTable where " + entityTableName + "." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@Id, "id") ?? "id") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@Id, "id") ?? "id") + " ";
updateSql += "";

List<string> insertFilenameList = new List<string>();
List<string> insertVENDORList = new List<string>();
List<string> insertDOC_TYPEList = new List<string>();
List<string> insertSAP_OBJECTList = new List<string>();
List<object> insertCreatedByList = new List<object>();
List<DateTime> insertCreatedOnList = new List<DateTime>();
List<object> insertStorageIdList = new List<object>();

List<long> updateIdList = new List<long>();
List<string> updateFilenameList = new List<string>();
List<string> updateVENDORList = new List<string>();
List<string> updateDOC_TYPEList = new List<string>();
List<string> updateSAP_OBJECTList = new List<string>();
List<object> updateCreatedByList = new List<object>();
List<DateTime> updateCreatedOnList = new List<DateTime>();
List<object> updateStorageIdList = new List<object>();

var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_3e0fb635eefe948054fa75421546a901)inParamSourceList.Current).ssENRequisitionFile2;
if (record.ssId != 0L) {
updateIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
updateFilenameList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssFilename));
updateVENDORList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssVENDOR));
updateDOC_TYPEList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssDOC_TYPE));
updateSAP_OBJECTList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssSAP_OBJECT));
if ((record.ssCreatedBy=="")) {
updateCreatedByList.Add(null);
} else {
updateCreatedByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssCreatedBy));
}
updateCreatedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssCreatedOn));
if ((record.ssStorageId==0L)) {
updateStorageIdList.Add(null);
} else {
updateStorageIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssStorageId));
}
} else {
insertFilenameList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssFilename));
insertVENDORList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssVENDOR));
insertDOC_TYPEList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssDOC_TYPE));
insertSAP_OBJECTList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssSAP_OBJECT));
if ((record.ssCreatedBy=="")) {
insertCreatedByList.Add(null);
} else {
insertCreatedByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssCreatedBy));
}
insertCreatedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssCreatedOn));
if ((record.ssStorageId==0L)) {
insertStorageIdList.Add(null);
} else {
insertStorageIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssStorageId));
}
}
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertFilenameList.IsEmpty() || !insertVENDORList.IsEmpty() || !insertDOC_TYPEList.IsEmpty() || !insertSAP_OBJECTList.IsEmpty() || !insertCreatedByList.IsEmpty() || !insertCreatedOnList.IsEmpty() || !insertStorageIdList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssFilename",DbType.String,insertFilenameList);
executionService.CreateParameter(insertSqlCmd,"@ssVENDOR",DbType.String,insertVENDORList);
executionService.CreateParameter(insertSqlCmd,"@ssDOC_TYPE",DbType.String,insertDOC_TYPEList);
executionService.CreateParameter(insertSqlCmd,"@ssSAP_OBJECT",DbType.String,insertSAP_OBJECTList);
executionService.CreateParameter(insertSqlCmd,"@ssCreatedBy",DbType.String,insertCreatedByList);
executionService.CreateParameter(insertSqlCmd,"@ssCreatedOn",DbType.DateTime,insertCreatedOnList);
executionService.CreateParameter(insertSqlCmd,"@ssStorageId",DbType.Int64,insertStorageIdList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeRequisitionFile2 (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
if(!updateFilenameList.IsEmpty() || !updateVENDORList.IsEmpty() || !updateDOC_TYPEList.IsEmpty() || !updateSAP_OBJECTList.IsEmpty() || !updateCreatedByList.IsEmpty() || !updateCreatedOnList.IsEmpty() || !updateStorageIdList.IsEmpty()){
await using(var updateSqlCmd = trans.CreateCommand(updateSql)){
executionService.CreateParameter(updateSqlCmd,"@ssId",DbType.Int64,updateIdList);
executionService.CreateParameter(updateSqlCmd,"@ssFilename",DbType.String,updateFilenameList);
executionService.CreateParameter(updateSqlCmd,"@ssVENDOR",DbType.String,updateVENDORList);
executionService.CreateParameter(updateSqlCmd,"@ssDOC_TYPE",DbType.String,updateDOC_TYPEList);
executionService.CreateParameter(updateSqlCmd,"@ssSAP_OBJECT",DbType.String,updateSAP_OBJECTList);
executionService.CreateParameter(updateSqlCmd,"@ssCreatedBy",DbType.String,updateCreatedByList);
executionService.CreateParameter(updateSqlCmd,"@ssCreatedOn",DbType.DateTime,updateCreatedOnList);
executionService.CreateParameter(updateSqlCmd,"@ssStorageId",DbType.Int64,updateStorageIdList);
await updateSqlCmd.PrepareAsync(cancellationToken);
await updateSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeRequisitionFile2 (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(updateSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteRequisitionFile2
/// </summary>

public static async Task DeleteRequisitionFile2(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteRequisitionFile2", "ee5a0533-850e-497a-8b5d-925f433484c3.#DeleteEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteRequisitionFile2", "ee5a0533-850e-497a-8b5d-925f433484c3.#DeleteEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENRequisitionFile2Entity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteRequisitionFile2", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllRequisitionFile2
/// </summary>

public static async Task DeleteAllRequisitionFile2(IRequestContext requestContext,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteAllRequisitionFile2", "ee5a0533-850e-497a-8b5d-925f433484c3.#DeleteAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllRequisitionFile2", "ee5a0533-850e-497a-8b5d-925f433484c3.#DeleteAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENRequisitionFile2Entity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteRequisitionFile2", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetRequisitionFile2
/// </summary>

public static async Task<RC_3e0fb635eefe948054fa75421546a901> GetRequisitionFile2(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_3e0fb635eefe948054fa75421546a901 outParamRecord = default;
outParamRecord = new RC_3e0fb635eefe948054fa75421546a901();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetRequisitionFile2", "ee5a0533-850e-497a-8b5d-925f433484c3.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetRequisitionFile2", "ee5a0533-850e-497a-8b5d-925f433484c3.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@Filename, "filename") ?? "filename", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@VENDOR, "vendor") ?? "vendor", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@DOC_TYPE, "doc_type") ?? "doc_type", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@SAP_OBJECT, "sap_object") ?? "sap_object", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@CreatedBy, "createdby") ?? "createdby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@CreatedOn, "createdon") ?? "createdon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@StorageId, "storageid") ?? "storageid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
" FROM " + ENRequisitionFile2Entity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetRequisitionFile2", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(8,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENRequisitionFile2Entity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetRequisitionFile2ForUpdate
/// </summary>

public static async Task<RC_3e0fb635eefe948054fa75421546a901> GetRequisitionFile2ForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_3e0fb635eefe948054fa75421546a901 outParamRecord = default;
outParamRecord = new RC_3e0fb635eefe948054fa75421546a901();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetRequisitionFile2ForUpdate", "ee5a0533-850e-497a-8b5d-925f433484c3.#GetEntityForUpdate");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetRequisitionFile2ForUpdate", "ee5a0533-850e-497a-8b5d-925f433484c3.#GetEntityForUpdate", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@Filename, "filename") ?? "filename", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@VENDOR, "vendor") ?? "vendor", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@DOC_TYPE, "doc_type") ?? "doc_type", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@SAP_OBJECT, "sap_object") ?? "sap_object", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@CreatedBy, "createdby") ?? "createdby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@CreatedOn, "createdon") ?? "createdon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@StorageId, "storageid") ?? "storageid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
" FROM " + ENRequisitionFile2Entity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@Id, "id") ?? "id") + " = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetRequisitionFile2ForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(8,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENRequisitionFile2Entity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateRequisitionFile2
/// </summary>

public static async Task UpdateRequisitionFile2(IRequestContext requestContext,BitArray usedFields,RC_3e0fb635eefe948054fa75421546a901 inParamSource,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("UpdateRequisitionFile2", "ee5a0533-850e-497a-8b5d-925f433484c3.#UpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateRequisitionFile2", "ee5a0533-850e-497a-8b5d-925f433484c3.#UpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_4cce425e15647f937e21de4e52849889EntityRecord ssENRequisitionFile2 = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(8,true);
}
string updateSet = "UPDATE " + ENRequisitionFile2Entity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@Filename, "filename") ?? "filename") + " = @ssFilename"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@VENDOR, "vendor") ?? "vendor") + " = @ssVENDOR"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@DOC_TYPE, "doc_type") ?? "doc_type") + " = @ssDOC_TYPE"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@SAP_OBJECT, "sap_object") ?? "sap_object") + " = @ssSAP_OBJECT"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = @ssCreatedBy"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = @ssCreatedOn"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@StorageId, "storageid") ?? "storageid") + " = @ssStorageId"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENRequisitionFile2_ssId_RequisitionFile2";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionFile2, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionFile2AttributeKeys.@CreatedOn, "createdon") ?? "createdon") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssFilename", DbType.String, ssENRequisitionFile2.ssFilename);
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssVENDOR", DbType.String, ssENRequisitionFile2.ssVENDOR);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssDOC_TYPE", DbType.String, ssENRequisitionFile2.ssDOC_TYPE);
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssSAP_OBJECT", DbType.String, ssENRequisitionFile2.ssSAP_OBJECT);
}
if(usedFields[5]) {
if ((ssENRequisitionFile2.ssCreatedBy=="")) {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENRequisitionFile2.ssCreatedBy);

}
}
if(usedFields[6]) {
sqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENRequisitionFile2.ssCreatedOn);
}
if(usedFields[7]) {
if ((ssENRequisitionFile2.ssStorageId==0L)) {
sqlCmd.CreateParameter("@ssStorageId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssStorageId", DbType.Int64, ssENRequisitionFile2.ssStorageId);

}
}
sqlCmd.CreateParameter("@idparam_ssENRequisitionFile2_ssId_RequisitionFile2", DbType.Int64, ssENRequisitionFile2.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateRequisitionFile2", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("RequisitionFile2", ssENRequisitionFile2.ssId.ToString()); }}
}
return;
}

}
}
