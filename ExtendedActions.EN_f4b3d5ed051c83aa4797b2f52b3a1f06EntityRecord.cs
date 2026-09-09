using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateInvoiceFile
/// </summary>

public static async Task<long> CreateInvoiceFile(IRequestContext requestContext,RC_18990af86f7169e92b712b468e13b947 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateInvoiceFile", "2af6ce65-cd2e-44c8-b7c5-477228181d7d.#CreateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateInvoiceFile", "2af6ce65-cd2e-44c8-b7c5-477228181d7d.#CreateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord ssENInvoiceFile = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENInvoiceFileEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@Filename, "filename") ?? "filename") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@IsExtra, "isextra") ?? "isextra") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@IsReport, "isreport") ?? "isreport") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@StorageId, "storageid") ?? "storageid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + "" +
" ) VALUES (" +
" @ssInvoiceId" +
", @ssFilename" +
", @ssIsExtra" +
", @ssIsReport" +
", @ssStorageId" +
", @ssCreatedBy" +
", @ssCreatedOn" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, ssENInvoiceFile.ssInvoiceId);
insertSqlCmd.CreateParameter("@ssFilename", DbType.String, ssENInvoiceFile.ssFilename);
insertSqlCmd.CreateParameter("@ssIsExtra", DbType.Boolean, ssENInvoiceFile.ssIsExtra);
insertSqlCmd.CreateParameter("@ssIsReport", DbType.Boolean, ssENInvoiceFile.ssIsReport);
if ((ssENInvoiceFile.ssStorageId==0L)) {
insertSqlCmd.CreateParameter("@ssStorageId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssStorageId", DbType.Int64, ssENInvoiceFile.ssStorageId);

}
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENInvoiceFile.ssCreatedBy);
insertSqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENInvoiceFile.ssCreatedOn);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateInvoiceFile", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateInvoiceFile
/// </summary>

public static async Task<long> CreateOrUpdateInvoiceFile(IRequestContext requestContext,BitArray usedFields,RC_18990af86f7169e92b712b468e13b947 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateInvoiceFile", "2af6ce65-cd2e-44c8-b7c5-477228181d7d.#CreateOrUpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateInvoiceFile", "2af6ce65-cd2e-44c8-b7c5-477228181d7d.#CreateOrUpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord ssENInvoiceFile = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(8,true);
}
string updateSet = "UPDATE " + ENInvoiceFileEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + " = @ssInvoiceId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@Filename, "filename") ?? "filename") + " = @ssFilename"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@IsExtra, "isextra") ?? "isextra") + " = @ssIsExtra"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@IsReport, "isreport") ?? "isreport") + " = @ssIsReport"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@StorageId, "storageid") ?? "storageid") + " = @ssStorageId"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = @ssCreatedBy"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = @ssCreatedOn"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENInvoiceFile_ssId_InvoiceFile";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@IsExtra, "isextra") ?? "isextra") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@IsExtra, "isextra") ?? "isextra") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, ssENInvoiceFile.ssInvoiceId);
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssFilename", DbType.String, ssENInvoiceFile.ssFilename);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssIsExtra", DbType.Boolean, ssENInvoiceFile.ssIsExtra);
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssIsReport", DbType.Boolean, ssENInvoiceFile.ssIsReport);
}
if(usedFields[5]) {
if ((ssENInvoiceFile.ssStorageId==0L)) {
sqlCmd.CreateParameter("@ssStorageId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssStorageId", DbType.Int64, ssENInvoiceFile.ssStorageId);

}
}
if(usedFields[6]) {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENInvoiceFile.ssCreatedBy);
}
if(usedFields[7]) {
sqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENInvoiceFile.ssCreatedOn);
}
sqlCmd.CreateParameter("@idparam_ssENInvoiceFile_ssId_InvoiceFile", DbType.Int64, ssENInvoiceFile.ssId);
int counter = 0;
if(ssENInvoiceFile.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateInvoiceFile (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENInvoiceFileEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@Filename, "filename") ?? "filename") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@IsExtra, "isextra") ?? "isextra") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@IsReport, "isreport") ?? "isreport") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@StorageId, "storageid") ?? "storageid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + "" +
" ) VALUES (" +
" @ssInvoiceId" +
", @ssFilename" +
", @ssIsExtra" +
", @ssIsReport" +
", @ssStorageId" +
", @ssCreatedBy" +
", @ssCreatedOn" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, ssENInvoiceFile.ssInvoiceId);
insertSqlCmd.CreateParameter("@ssFilename", DbType.String, ssENInvoiceFile.ssFilename);
insertSqlCmd.CreateParameter("@ssIsExtra", DbType.Boolean, ssENInvoiceFile.ssIsExtra);
insertSqlCmd.CreateParameter("@ssIsReport", DbType.Boolean, ssENInvoiceFile.ssIsReport);
if ((ssENInvoiceFile.ssStorageId==0L)) {
insertSqlCmd.CreateParameter("@ssStorageId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssStorageId", DbType.Int64, ssENInvoiceFile.ssStorageId);

}
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENInvoiceFile.ssCreatedBy);
insertSqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENInvoiceFile.ssCreatedOn);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateInvoiceFile", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENInvoiceFile.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeInvoiceFile
/// </summary>

public static async Task CreateOrUpdateSomeInvoiceFile(IRequestContext requestContext,RL_00a03f803f0d49826089181417370afb inParamSourceList,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateSomeInvoiceFile", "2af6ce65-cd2e-44c8-b7c5-477228181d7d.#CreateOrUpdateAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeInvoiceFile", "2af6ce65-cd2e-44c8-b7c5-477228181d7d.#CreateOrUpdateAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
string entityTableName = ENInvoiceFileEntity.LocalViewName(null);
string insertSql = "INSERT INTO " + entityTableName + " (" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@Filename, "filename") ?? "filename") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@IsExtra, "isextra") ?? "isextra") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@IsReport, "isreport") ?? "isreport") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@StorageId, "storageid") ?? "storageid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + ") VALUES ( unnest(@ssInvoiceId),  unnest(@ssFilename),  unnest(@ssIsExtra),  unnest(@ssIsReport),  unnest(@ssStorageId),  unnest(@ssCreatedBy),  unnest(@ssCreatedOn)) ";
insertSql += "";

string updateSql = "UPDATE " + entityTableName + " SET " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@Filename, "filename") ?? "filename") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@Filename, "filename") ?? "filename") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@IsExtra, "isextra") ?? "isextra") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@IsExtra, "isextra") ?? "isextra") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@IsReport, "isreport") ?? "isreport") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@IsReport, "isreport") ?? "isreport") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@StorageId, "storageid") ?? "storageid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@StorageId, "storageid") ?? "storageid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " from ( select  unnest(@ssId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@Id, "id") ?? "id") + ",  unnest(@ssInvoiceId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + ",  unnest(@ssFilename) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@Filename, "filename") ?? "filename") + ",  unnest(@ssIsExtra) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@IsExtra, "isextra") ?? "isextra") + ",  unnest(@ssIsReport) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@IsReport, "isreport") ?? "isreport") + ",  unnest(@ssStorageId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@StorageId, "storageid") ?? "storageid") + ",  unnest(@ssCreatedBy) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + ",  unnest(@ssCreatedOn) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " ) as updateTable where " + entityTableName + "." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@Id, "id") ?? "id") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@Id, "id") ?? "id") + " ";
updateSql += "";

List<object> insertInvoiceIdList = new List<object>();
List<string> insertFilenameList = new List<string>();
List<bool> insertIsExtraList = new List<bool>();
List<bool> insertIsReportList = new List<bool>();
List<object> insertStorageIdList = new List<object>();
List<object> insertCreatedByList = new List<object>();
List<DateTime> insertCreatedOnList = new List<DateTime>();

List<long> updateIdList = new List<long>();
List<object> updateInvoiceIdList = new List<object>();
List<string> updateFilenameList = new List<string>();
List<bool> updateIsExtraList = new List<bool>();
List<bool> updateIsReportList = new List<bool>();
List<object> updateStorageIdList = new List<object>();
List<object> updateCreatedByList = new List<object>();
List<DateTime> updateCreatedOnList = new List<DateTime>();

var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_18990af86f7169e92b712b468e13b947)inParamSourceList.Current).ssENInvoiceFile;
if (record.ssId != 0L) {
updateIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
updateInvoiceIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssInvoiceId));
updateFilenameList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssFilename));
updateIsExtraList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsExtra));
updateIsReportList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsReport));
if ((record.ssStorageId==0L)) {
updateStorageIdList.Add(null);
} else {
updateStorageIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssStorageId));
}
updateCreatedByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssCreatedBy));
updateCreatedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssCreatedOn));
} else {
insertInvoiceIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssInvoiceId));
insertFilenameList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssFilename));
insertIsExtraList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsExtra));
insertIsReportList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsReport));
if ((record.ssStorageId==0L)) {
insertStorageIdList.Add(null);
} else {
insertStorageIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssStorageId));
}
insertCreatedByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssCreatedBy));
insertCreatedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssCreatedOn));
}
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertInvoiceIdList.IsEmpty() || !insertFilenameList.IsEmpty() || !insertIsExtraList.IsEmpty() || !insertIsReportList.IsEmpty() || !insertStorageIdList.IsEmpty() || !insertCreatedByList.IsEmpty() || !insertCreatedOnList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssInvoiceId",DbType.Int64,insertInvoiceIdList);
executionService.CreateParameter(insertSqlCmd,"@ssFilename",DbType.String,insertFilenameList);
executionService.CreateParameter(insertSqlCmd,"@ssIsExtra",DbType.Boolean,insertIsExtraList);
executionService.CreateParameter(insertSqlCmd,"@ssIsReport",DbType.Boolean,insertIsReportList);
executionService.CreateParameter(insertSqlCmd,"@ssStorageId",DbType.Int64,insertStorageIdList);
executionService.CreateParameter(insertSqlCmd,"@ssCreatedBy",DbType.String,insertCreatedByList);
executionService.CreateParameter(insertSqlCmd,"@ssCreatedOn",DbType.DateTime,insertCreatedOnList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeInvoiceFile (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
if(!updateInvoiceIdList.IsEmpty() || !updateFilenameList.IsEmpty() || !updateIsExtraList.IsEmpty() || !updateIsReportList.IsEmpty() || !updateStorageIdList.IsEmpty() || !updateCreatedByList.IsEmpty() || !updateCreatedOnList.IsEmpty()){
await using(var updateSqlCmd = trans.CreateCommand(updateSql)){
executionService.CreateParameter(updateSqlCmd,"@ssId",DbType.Int64,updateIdList);
executionService.CreateParameter(updateSqlCmd,"@ssInvoiceId",DbType.Int64,updateInvoiceIdList);
executionService.CreateParameter(updateSqlCmd,"@ssFilename",DbType.String,updateFilenameList);
executionService.CreateParameter(updateSqlCmd,"@ssIsExtra",DbType.Boolean,updateIsExtraList);
executionService.CreateParameter(updateSqlCmd,"@ssIsReport",DbType.Boolean,updateIsReportList);
executionService.CreateParameter(updateSqlCmd,"@ssStorageId",DbType.Int64,updateStorageIdList);
executionService.CreateParameter(updateSqlCmd,"@ssCreatedBy",DbType.String,updateCreatedByList);
executionService.CreateParameter(updateSqlCmd,"@ssCreatedOn",DbType.DateTime,updateCreatedOnList);
await updateSqlCmd.PrepareAsync(cancellationToken);
await updateSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeInvoiceFile (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(updateSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteInvoiceFile
/// </summary>

public static async Task DeleteInvoiceFile(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteInvoiceFile", "2af6ce65-cd2e-44c8-b7c5-477228181d7d.#DeleteEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteInvoiceFile", "2af6ce65-cd2e-44c8-b7c5-477228181d7d.#DeleteEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENInvoiceFileEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteInvoiceFile", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllInvoiceFile
/// </summary>

public static async Task DeleteAllInvoiceFile(IRequestContext requestContext,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteAllInvoiceFile", "2af6ce65-cd2e-44c8-b7c5-477228181d7d.#DeleteAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllInvoiceFile", "2af6ce65-cd2e-44c8-b7c5-477228181d7d.#DeleteAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENInvoiceFileEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteInvoiceFile", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetInvoiceFile
/// </summary>

public static async Task<RC_18990af86f7169e92b712b468e13b947> GetInvoiceFile(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_18990af86f7169e92b712b468e13b947 outParamRecord = default;
outParamRecord = new RC_18990af86f7169e92b712b468e13b947();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetInvoiceFile", "2af6ce65-cd2e-44c8-b7c5-477228181d7d.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetInvoiceFile", "2af6ce65-cd2e-44c8-b7c5-477228181d7d.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@Filename, "filename") ?? "filename", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@IsExtra, "isextra") ?? "isextra", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@IsReport, "isreport") ?? "isreport", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@StorageId, "storageid") ?? "storageid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@CreatedBy, "createdby") ?? "createdby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@CreatedOn, "createdon") ?? "createdon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
" FROM " + ENInvoiceFileEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetInvoiceFile", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(8,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENInvoiceFileEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetInvoiceFileForUpdate
/// </summary>

public static async Task<RC_18990af86f7169e92b712b468e13b947> GetInvoiceFileForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_18990af86f7169e92b712b468e13b947 outParamRecord = default;
outParamRecord = new RC_18990af86f7169e92b712b468e13b947();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetInvoiceFileForUpdate", "2af6ce65-cd2e-44c8-b7c5-477228181d7d.#GetEntityForUpdate");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetInvoiceFileForUpdate", "2af6ce65-cd2e-44c8-b7c5-477228181d7d.#GetEntityForUpdate", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@Filename, "filename") ?? "filename", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@IsExtra, "isextra") ?? "isextra", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@IsReport, "isreport") ?? "isreport", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@StorageId, "storageid") ?? "storageid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@CreatedBy, "createdby") ?? "createdby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@CreatedOn, "createdon") ?? "createdon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
" FROM " + ENInvoiceFileEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@Id, "id") ?? "id") + " = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetInvoiceFileForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(8,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENInvoiceFileEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateInvoiceFile
/// </summary>

public static async Task UpdateInvoiceFile(IRequestContext requestContext,BitArray usedFields,RC_18990af86f7169e92b712b468e13b947 inParamSource,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("UpdateInvoiceFile", "2af6ce65-cd2e-44c8-b7c5-477228181d7d.#UpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateInvoiceFile", "2af6ce65-cd2e-44c8-b7c5-477228181d7d.#UpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord ssENInvoiceFile = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(8,true);
}
string updateSet = "UPDATE " + ENInvoiceFileEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + " = @ssInvoiceId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@Filename, "filename") ?? "filename") + " = @ssFilename"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@IsExtra, "isextra") ?? "isextra") + " = @ssIsExtra"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@IsReport, "isreport") ?? "isreport") + " = @ssIsReport"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@StorageId, "storageid") ?? "storageid") + " = @ssStorageId"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = @ssCreatedBy"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = @ssCreatedOn"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENInvoiceFile_ssId_InvoiceFile";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@IsExtra, "isextra") ?? "isextra") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceFileAttributeKeys.@IsExtra, "isextra") ?? "isextra") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, ssENInvoiceFile.ssInvoiceId);
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssFilename", DbType.String, ssENInvoiceFile.ssFilename);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssIsExtra", DbType.Boolean, ssENInvoiceFile.ssIsExtra);
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssIsReport", DbType.Boolean, ssENInvoiceFile.ssIsReport);
}
if(usedFields[5]) {
if ((ssENInvoiceFile.ssStorageId==0L)) {
sqlCmd.CreateParameter("@ssStorageId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssStorageId", DbType.Int64, ssENInvoiceFile.ssStorageId);

}
}
if(usedFields[6]) {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENInvoiceFile.ssCreatedBy);
}
if(usedFields[7]) {
sqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENInvoiceFile.ssCreatedOn);
}
sqlCmd.CreateParameter("@idparam_ssENInvoiceFile_ssId_InvoiceFile", DbType.Int64, ssENInvoiceFile.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateInvoiceFile", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("InvoiceFile", ssENInvoiceFile.ssId.ToString()); }}
}
return;
}

}
}
