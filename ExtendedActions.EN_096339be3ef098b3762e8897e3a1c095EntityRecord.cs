using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateOrderFile
/// </summary>

public static async Task<long> CreateOrderFile(IRequestContext requestContext,RC_a7394a353dc1b7f636aaced209e66116 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrderFile", "bacf7bc5-01cb-43e6-b8fd-854d767b218f.#CreateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrderFile", "bacf7bc5-01cb-43e6-b8fd-854d767b218f.#CreateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_096339be3ef098b3762e8897e3a1c095EntityRecord ssENOrderFile = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENOrderFileEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@Filename, "filename") ?? "filename") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@VENDOR, "vendor") ?? "vendor") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@DOC_TYPE, "doc_type") ?? "doc_type") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@SAP_OBJECT, "sap_object") ?? "sap_object") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@StorageId, "storageid") ?? "storageid") + "" +
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
insertSqlCmd.CreateParameter("@ssFilename", DbType.String, ssENOrderFile.ssFilename);
insertSqlCmd.CreateParameter("@ssVENDOR", DbType.String, ssENOrderFile.ssVENDOR);
insertSqlCmd.CreateParameter("@ssDOC_TYPE", DbType.String, ssENOrderFile.ssDOC_TYPE);
insertSqlCmd.CreateParameter("@ssSAP_OBJECT", DbType.String, ssENOrderFile.ssSAP_OBJECT);
if ((ssENOrderFile.ssCreatedBy=="")) {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENOrderFile.ssCreatedBy);

}
insertSqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENOrderFile.ssCreatedOn);
if ((ssENOrderFile.ssStorageId==0L)) {
insertSqlCmd.CreateParameter("@ssStorageId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssStorageId", DbType.Int64, ssENOrderFile.ssStorageId);

}
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrderFile", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateOrderFile
/// </summary>

public static async Task<long> CreateOrUpdateOrderFile(IRequestContext requestContext,BitArray usedFields,RC_a7394a353dc1b7f636aaced209e66116 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateOrderFile", "bacf7bc5-01cb-43e6-b8fd-854d767b218f.#CreateOrUpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateOrderFile", "bacf7bc5-01cb-43e6-b8fd-854d767b218f.#CreateOrUpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_096339be3ef098b3762e8897e3a1c095EntityRecord ssENOrderFile = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(8,true);
}
string updateSet = "UPDATE " + ENOrderFileEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@Filename, "filename") ?? "filename") + " = @ssFilename"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@VENDOR, "vendor") ?? "vendor") + " = @ssVENDOR"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@DOC_TYPE, "doc_type") ?? "doc_type") + " = @ssDOC_TYPE"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@SAP_OBJECT, "sap_object") ?? "sap_object") + " = @ssSAP_OBJECT"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = @ssCreatedBy"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = @ssCreatedOn"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@StorageId, "storageid") ?? "storageid") + " = @ssStorageId"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENOrderFile_ssId_OrderFile";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssFilename", DbType.String, ssENOrderFile.ssFilename);
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssVENDOR", DbType.String, ssENOrderFile.ssVENDOR);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssDOC_TYPE", DbType.String, ssENOrderFile.ssDOC_TYPE);
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssSAP_OBJECT", DbType.String, ssENOrderFile.ssSAP_OBJECT);
}
if(usedFields[5]) {
if ((ssENOrderFile.ssCreatedBy=="")) {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENOrderFile.ssCreatedBy);

}
}
if(usedFields[6]) {
sqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENOrderFile.ssCreatedOn);
}
if(usedFields[7]) {
if ((ssENOrderFile.ssStorageId==0L)) {
sqlCmd.CreateParameter("@ssStorageId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssStorageId", DbType.Int64, ssENOrderFile.ssStorageId);

}
}
sqlCmd.CreateParameter("@idparam_ssENOrderFile_ssId_OrderFile", DbType.Int64, ssENOrderFile.ssId);
int counter = 0;
if(ssENOrderFile.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateOrderFile (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENOrderFileEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@Filename, "filename") ?? "filename") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@VENDOR, "vendor") ?? "vendor") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@DOC_TYPE, "doc_type") ?? "doc_type") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@SAP_OBJECT, "sap_object") ?? "sap_object") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@StorageId, "storageid") ?? "storageid") + "" +
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
insertSqlCmd.CreateParameter("@ssFilename", DbType.String, ssENOrderFile.ssFilename);
insertSqlCmd.CreateParameter("@ssVENDOR", DbType.String, ssENOrderFile.ssVENDOR);
insertSqlCmd.CreateParameter("@ssDOC_TYPE", DbType.String, ssENOrderFile.ssDOC_TYPE);
insertSqlCmd.CreateParameter("@ssSAP_OBJECT", DbType.String, ssENOrderFile.ssSAP_OBJECT);
if ((ssENOrderFile.ssCreatedBy=="")) {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENOrderFile.ssCreatedBy);

}
insertSqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENOrderFile.ssCreatedOn);
if ((ssENOrderFile.ssStorageId==0L)) {
insertSqlCmd.CreateParameter("@ssStorageId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssStorageId", DbType.Int64, ssENOrderFile.ssStorageId);

}
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateOrderFile", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENOrderFile.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeOrderFile
/// </summary>

public static async Task CreateOrUpdateSomeOrderFile(IRequestContext requestContext,RL_1952495fe738735251c431fd1e1fd0f1 inParamSourceList,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateSomeOrderFile", "bacf7bc5-01cb-43e6-b8fd-854d767b218f.#CreateOrUpdateAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeOrderFile", "bacf7bc5-01cb-43e6-b8fd-854d767b218f.#CreateOrUpdateAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
string entityTableName = ENOrderFileEntity.LocalViewName(null);
string insertSql = "INSERT INTO " + entityTableName + " (" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@Filename, "filename") ?? "filename") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@VENDOR, "vendor") ?? "vendor") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@DOC_TYPE, "doc_type") ?? "doc_type") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@SAP_OBJECT, "sap_object") ?? "sap_object") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@StorageId, "storageid") ?? "storageid") + ") VALUES ( unnest(@ssFilename),  unnest(@ssVENDOR),  unnest(@ssDOC_TYPE),  unnest(@ssSAP_OBJECT),  unnest(@ssCreatedBy),  unnest(@ssCreatedOn),  unnest(@ssStorageId)) ";
insertSql += "";

string updateSql = "UPDATE " + entityTableName + " SET " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@Filename, "filename") ?? "filename") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@Filename, "filename") ?? "filename") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@VENDOR, "vendor") ?? "vendor") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@VENDOR, "vendor") ?? "vendor") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@DOC_TYPE, "doc_type") ?? "doc_type") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@DOC_TYPE, "doc_type") ?? "doc_type") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@SAP_OBJECT, "sap_object") ?? "sap_object") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@SAP_OBJECT, "sap_object") ?? "sap_object") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@StorageId, "storageid") ?? "storageid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@StorageId, "storageid") ?? "storageid") + " from ( select  unnest(@ssId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@Id, "id") ?? "id") + ",  unnest(@ssFilename) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@Filename, "filename") ?? "filename") + ",  unnest(@ssVENDOR) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@VENDOR, "vendor") ?? "vendor") + ",  unnest(@ssDOC_TYPE) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@DOC_TYPE, "doc_type") ?? "doc_type") + ",  unnest(@ssSAP_OBJECT) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@SAP_OBJECT, "sap_object") ?? "sap_object") + ",  unnest(@ssCreatedBy) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + ",  unnest(@ssCreatedOn) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + ",  unnest(@ssStorageId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@StorageId, "storageid") ?? "storageid") + " ) as updateTable where " + entityTableName + "." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@Id, "id") ?? "id") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@Id, "id") ?? "id") + " ";
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
var record = ((RC_a7394a353dc1b7f636aaced209e66116)inParamSourceList.Current).ssENOrderFile;
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
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeOrderFile (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
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
await updateSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeOrderFile (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(updateSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteOrderFile
/// </summary>

public static async Task DeleteOrderFile(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteOrderFile", "bacf7bc5-01cb-43e6-b8fd-854d767b218f.#DeleteEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteOrderFile", "bacf7bc5-01cb-43e6-b8fd-854d767b218f.#DeleteEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENOrderFileEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteOrderFile", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllOrderFile
/// </summary>

public static async Task DeleteAllOrderFile(IRequestContext requestContext,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteAllOrderFile", "bacf7bc5-01cb-43e6-b8fd-854d767b218f.#DeleteAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllOrderFile", "bacf7bc5-01cb-43e6-b8fd-854d767b218f.#DeleteAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENOrderFileEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteOrderFile", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetOrderFile
/// </summary>

public static async Task<RC_a7394a353dc1b7f636aaced209e66116> GetOrderFile(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_a7394a353dc1b7f636aaced209e66116 outParamRecord = default;
outParamRecord = new RC_a7394a353dc1b7f636aaced209e66116();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetOrderFile", "bacf7bc5-01cb-43e6-b8fd-854d767b218f.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetOrderFile", "bacf7bc5-01cb-43e6-b8fd-854d767b218f.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@Filename, "filename") ?? "filename", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@VENDOR, "vendor") ?? "vendor", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@DOC_TYPE, "doc_type") ?? "doc_type", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@SAP_OBJECT, "sap_object") ?? "sap_object", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@CreatedBy, "createdby") ?? "createdby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@CreatedOn, "createdon") ?? "createdon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@StorageId, "storageid") ?? "storageid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
" FROM " + ENOrderFileEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetOrderFile", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(8,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENOrderFileEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetOrderFileForUpdate
/// </summary>

public static async Task<RC_a7394a353dc1b7f636aaced209e66116> GetOrderFileForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_a7394a353dc1b7f636aaced209e66116 outParamRecord = default;
outParamRecord = new RC_a7394a353dc1b7f636aaced209e66116();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetOrderFileForUpdate", "bacf7bc5-01cb-43e6-b8fd-854d767b218f.#GetEntityForUpdate");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetOrderFileForUpdate", "bacf7bc5-01cb-43e6-b8fd-854d767b218f.#GetEntityForUpdate", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@Filename, "filename") ?? "filename", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@VENDOR, "vendor") ?? "vendor", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@DOC_TYPE, "doc_type") ?? "doc_type", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@SAP_OBJECT, "sap_object") ?? "sap_object", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@CreatedBy, "createdby") ?? "createdby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@CreatedOn, "createdon") ?? "createdon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@StorageId, "storageid") ?? "storageid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
" FROM " + ENOrderFileEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@Id, "id") ?? "id") + " = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetOrderFileForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(8,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENOrderFileEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateOrderFile
/// </summary>

public static async Task UpdateOrderFile(IRequestContext requestContext,BitArray usedFields,RC_a7394a353dc1b7f636aaced209e66116 inParamSource,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("UpdateOrderFile", "bacf7bc5-01cb-43e6-b8fd-854d767b218f.#UpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateOrderFile", "bacf7bc5-01cb-43e6-b8fd-854d767b218f.#UpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_096339be3ef098b3762e8897e3a1c095EntityRecord ssENOrderFile = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(8,true);
}
string updateSet = "UPDATE " + ENOrderFileEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@Filename, "filename") ?? "filename") + " = @ssFilename"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@VENDOR, "vendor") ?? "vendor") + " = @ssVENDOR"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@DOC_TYPE, "doc_type") ?? "doc_type") + " = @ssDOC_TYPE"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@SAP_OBJECT, "sap_object") ?? "sap_object") + " = @ssSAP_OBJECT"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = @ssCreatedBy"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = @ssCreatedOn"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@StorageId, "storageid") ?? "storageid") + " = @ssStorageId"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENOrderFile_ssId_OrderFile";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderFileAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssFilename", DbType.String, ssENOrderFile.ssFilename);
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssVENDOR", DbType.String, ssENOrderFile.ssVENDOR);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssDOC_TYPE", DbType.String, ssENOrderFile.ssDOC_TYPE);
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssSAP_OBJECT", DbType.String, ssENOrderFile.ssSAP_OBJECT);
}
if(usedFields[5]) {
if ((ssENOrderFile.ssCreatedBy=="")) {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENOrderFile.ssCreatedBy);

}
}
if(usedFields[6]) {
sqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENOrderFile.ssCreatedOn);
}
if(usedFields[7]) {
if ((ssENOrderFile.ssStorageId==0L)) {
sqlCmd.CreateParameter("@ssStorageId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssStorageId", DbType.Int64, ssENOrderFile.ssStorageId);

}
}
sqlCmd.CreateParameter("@idparam_ssENOrderFile_ssId_OrderFile", DbType.Int64, ssENOrderFile.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateOrderFile", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("OrderFile", ssENOrderFile.ssId.ToString()); }}
}
return;
}

}
}
