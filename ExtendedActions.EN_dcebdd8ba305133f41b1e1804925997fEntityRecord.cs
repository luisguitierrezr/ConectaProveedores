using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateFileExtended
/// </summary>

public static async Task<long> CreateFileExtended(IRequestContext requestContext,RC_6e3ea28d2c552bc2cc129f42297e5982 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateFileExtended", "259e9689-91d4-400f-8edb-227ba5ffa5a5.#CreateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateFileExtended", "259e9689-91d4-400f-8edb-227ba5ffa5a5.#CreateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_dcebdd8ba305133f41b1e1804925997fEntityRecord ssENFileExtended = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENFileExtendedEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileExtendedAttributeKeys.@Id, "id") ?? "id") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileExtendedAttributeKeys.@Filename, "filename") ?? "filename") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileExtendedAttributeKeys.@IsProcessed, "isprocessed") ?? "isprocessed") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileExtendedAttributeKeys.@HasError, "haserror") ?? "haserror") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileExtendedAttributeKeys.@ErrorMessage, "errormessage") ?? "errormessage") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileExtendedAttributeKeys.@UploadedBy, "uploadedby") ?? "uploadedby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileExtendedAttributeKeys.@UploadedOn, "uploadedon") ?? "uploadedon") + "" +
" ) VALUES (" +
" @ssId" +
", @ssFilename" +
", @ssIsProcessed" +
", @ssHasError" +
", @ssErrorMessage" +
", @ssUploadedBy" +
", @ssUploadedOn" +
" )";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssId", DbType.Int64, ssENFileExtended.ssId);
insertSqlCmd.CreateParameter("@ssFilename", DbType.String, ssENFileExtended.ssFilename);
insertSqlCmd.CreateParameter("@ssIsProcessed", DbType.Boolean, ssENFileExtended.ssIsProcessed);
insertSqlCmd.CreateParameter("@ssHasError", DbType.Boolean, ssENFileExtended.ssHasError);
insertSqlCmd.CreateParameter("@ssErrorMessage", DbType.String, ssENFileExtended.ssErrorMessage);
if ((ssENFileExtended.ssUploadedBy=="")) {
insertSqlCmd.CreateParameter("@ssUploadedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssUploadedBy", DbType.String, ssENFileExtended.ssUploadedBy);

}
insertSqlCmd.CreateParameter("@ssUploadedOn", DbType.DateTime, ssENFileExtended.ssUploadedOn);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateFileExtended", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
outParamId = ssENFileExtended.ssId;
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateFileExtended
/// </summary>

public static async Task<long> CreateOrUpdateFileExtended(IRequestContext requestContext,BitArray usedFields,RC_6e3ea28d2c552bc2cc129f42297e5982 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateFileExtended", "259e9689-91d4-400f-8edb-227ba5ffa5a5.#CreateOrUpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateFileExtended", "259e9689-91d4-400f-8edb-227ba5ffa5a5.#CreateOrUpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_dcebdd8ba305133f41b1e1804925997fEntityRecord ssENFileExtended = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(7,true);
}
string updateSet = "UPDATE " + ENFileExtendedEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileExtendedAttributeKeys.@Filename, "filename") ?? "filename") + " = @ssFilename"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileExtendedAttributeKeys.@IsProcessed, "isprocessed") ?? "isprocessed") + " = @ssIsProcessed"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileExtendedAttributeKeys.@HasError, "haserror") ?? "haserror") + " = @ssHasError"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileExtendedAttributeKeys.@ErrorMessage, "errormessage") ?? "errormessage") + " = @ssErrorMessage"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileExtendedAttributeKeys.@UploadedBy, "uploadedby") ?? "uploadedby") + " = @ssUploadedBy"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileExtendedAttributeKeys.@UploadedOn, "uploadedon") ?? "uploadedon") + " = @ssUploadedOn"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileExtendedAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENFileExtended_ssId_FileExtended";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileExtendedAttributeKeys.@IsProcessed, "isprocessed") ?? "isprocessed") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileExtendedAttributeKeys.@IsProcessed, "isprocessed") ?? "isprocessed") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssFilename", DbType.String, ssENFileExtended.ssFilename);
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssIsProcessed", DbType.Boolean, ssENFileExtended.ssIsProcessed);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssHasError", DbType.Boolean, ssENFileExtended.ssHasError);
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssErrorMessage", DbType.String, ssENFileExtended.ssErrorMessage);
}
if(usedFields[5]) {
if ((ssENFileExtended.ssUploadedBy=="")) {
sqlCmd.CreateParameter("@ssUploadedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssUploadedBy", DbType.String, ssENFileExtended.ssUploadedBy);

}
}
if(usedFields[6]) {
sqlCmd.CreateParameter("@ssUploadedOn", DbType.DateTime, ssENFileExtended.ssUploadedOn);
}
sqlCmd.CreateParameter("@idparam_ssENFileExtended_ssId_FileExtended", DbType.Int64, ssENFileExtended.ssId);
int counter = 0;
if(ssENFileExtended.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateFileExtended (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENFileExtendedEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileExtendedAttributeKeys.@Id, "id") ?? "id") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileExtendedAttributeKeys.@Filename, "filename") ?? "filename") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileExtendedAttributeKeys.@IsProcessed, "isprocessed") ?? "isprocessed") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileExtendedAttributeKeys.@HasError, "haserror") ?? "haserror") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileExtendedAttributeKeys.@ErrorMessage, "errormessage") ?? "errormessage") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileExtendedAttributeKeys.@UploadedBy, "uploadedby") ?? "uploadedby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileExtendedAttributeKeys.@UploadedOn, "uploadedon") ?? "uploadedon") + "" +
" ) VALUES (" +
" @ssId" +
", @ssFilename" +
", @ssIsProcessed" +
", @ssHasError" +
", @ssErrorMessage" +
", @ssUploadedBy" +
", @ssUploadedOn" +
" )";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssId", DbType.Int64, ssENFileExtended.ssId);
insertSqlCmd.CreateParameter("@ssFilename", DbType.String, ssENFileExtended.ssFilename);
insertSqlCmd.CreateParameter("@ssIsProcessed", DbType.Boolean, ssENFileExtended.ssIsProcessed);
insertSqlCmd.CreateParameter("@ssHasError", DbType.Boolean, ssENFileExtended.ssHasError);
insertSqlCmd.CreateParameter("@ssErrorMessage", DbType.String, ssENFileExtended.ssErrorMessage);
if ((ssENFileExtended.ssUploadedBy=="")) {
insertSqlCmd.CreateParameter("@ssUploadedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssUploadedBy", DbType.String, ssENFileExtended.ssUploadedBy);

}
insertSqlCmd.CreateParameter("@ssUploadedOn", DbType.DateTime, ssENFileExtended.ssUploadedOn);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateFileExtended", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
outParamId = ssENFileExtended.ssId;
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENFileExtended.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeFileExtended
/// </summary>

public static async Task CreateOrUpdateSomeFileExtended(IRequestContext requestContext,RL_6de96902c907b264dc4c48e378eca40b inParamSourceList,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateSomeFileExtended", "259e9689-91d4-400f-8edb-227ba5ffa5a5.#CreateOrUpdateAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeFileExtended", "259e9689-91d4-400f-8edb-227ba5ffa5a5.#CreateOrUpdateAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
string entityTableName = ENFileExtendedEntity.LocalViewName(null);
string insertSql = "INSERT INTO " + entityTableName + " (" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileExtendedAttributeKeys.@Id, "id") ?? "id") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileExtendedAttributeKeys.@Filename, "filename") ?? "filename") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileExtendedAttributeKeys.@IsProcessed, "isprocessed") ?? "isprocessed") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileExtendedAttributeKeys.@HasError, "haserror") ?? "haserror") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileExtendedAttributeKeys.@ErrorMessage, "errormessage") ?? "errormessage") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileExtendedAttributeKeys.@UploadedBy, "uploadedby") ?? "uploadedby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileExtendedAttributeKeys.@UploadedOn, "uploadedon") ?? "uploadedon") + ") VALUES ( unnest(@ssId),  unnest(@ssFilename),  unnest(@ssIsProcessed),  unnest(@ssHasError),  unnest(@ssErrorMessage),  unnest(@ssUploadedBy),  unnest(@ssUploadedOn)) ON CONFLICT(" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileExtendedAttributeKeys.@Id, "id") ?? "id") + ") do update set " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileExtendedAttributeKeys.@Filename, "filename") ?? "filename") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileExtendedAttributeKeys.@Filename, "filename") ?? "filename") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileExtendedAttributeKeys.@IsProcessed, "isprocessed") ?? "isprocessed") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileExtendedAttributeKeys.@IsProcessed, "isprocessed") ?? "isprocessed") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileExtendedAttributeKeys.@HasError, "haserror") ?? "haserror") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileExtendedAttributeKeys.@HasError, "haserror") ?? "haserror") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileExtendedAttributeKeys.@ErrorMessage, "errormessage") ?? "errormessage") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileExtendedAttributeKeys.@ErrorMessage, "errormessage") ?? "errormessage") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileExtendedAttributeKeys.@UploadedBy, "uploadedby") ?? "uploadedby") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileExtendedAttributeKeys.@UploadedBy, "uploadedby") ?? "uploadedby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileExtendedAttributeKeys.@UploadedOn, "uploadedon") ?? "uploadedon") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileExtendedAttributeKeys.@UploadedOn, "uploadedon") ?? "uploadedon") + " ";
insertSql += "";


List<object> insertIdList = new List<object>();
List<string> insertFilenameList = new List<string>();
List<bool> insertIsProcessedList = new List<bool>();
List<bool> insertHasErrorList = new List<bool>();
List<string> insertErrorMessageList = new List<string>();
List<object> insertUploadedByList = new List<object>();
List<DateTime> insertUploadedOnList = new List<DateTime>();


var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_6e3ea28d2c552bc2cc129f42297e5982)inParamSourceList.Current).ssENFileExtended;
insertIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
insertFilenameList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssFilename));
insertIsProcessedList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsProcessed));
insertHasErrorList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssHasError));
insertErrorMessageList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssErrorMessage));
if ((record.ssUploadedBy=="")) {
insertUploadedByList.Add(null);
} else {
insertUploadedByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssUploadedBy));
}
insertUploadedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssUploadedOn));
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertIdList.IsEmpty() || !insertFilenameList.IsEmpty() || !insertIsProcessedList.IsEmpty() || !insertHasErrorList.IsEmpty() || !insertErrorMessageList.IsEmpty() || !insertUploadedByList.IsEmpty() || !insertUploadedOnList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssId",DbType.Int64,insertIdList);
executionService.CreateParameter(insertSqlCmd,"@ssFilename",DbType.String,insertFilenameList);
executionService.CreateParameter(insertSqlCmd,"@ssIsProcessed",DbType.Boolean,insertIsProcessedList);
executionService.CreateParameter(insertSqlCmd,"@ssHasError",DbType.Boolean,insertHasErrorList);
executionService.CreateParameter(insertSqlCmd,"@ssErrorMessage",DbType.String,insertErrorMessageList);
executionService.CreateParameter(insertSqlCmd,"@ssUploadedBy",DbType.String,insertUploadedByList);
executionService.CreateParameter(insertSqlCmd,"@ssUploadedOn",DbType.DateTime,insertUploadedOnList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeFileExtended (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteFileExtended
/// </summary>

public static async Task DeleteFileExtended(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteFileExtended", "259e9689-91d4-400f-8edb-227ba5ffa5a5.#DeleteEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteFileExtended", "259e9689-91d4-400f-8edb-227ba5ffa5a5.#DeleteEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENFileExtendedEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileExtendedAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteFileExtended", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllFileExtended
/// </summary>

public static async Task DeleteAllFileExtended(IRequestContext requestContext,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteAllFileExtended", "259e9689-91d4-400f-8edb-227ba5ffa5a5.#DeleteAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllFileExtended", "259e9689-91d4-400f-8edb-227ba5ffa5a5.#DeleteAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENFileExtendedEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteFileExtended", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetFileExtended
/// </summary>

public static async Task<RC_6e3ea28d2c552bc2cc129f42297e5982> GetFileExtended(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_6e3ea28d2c552bc2cc129f42297e5982 outParamRecord = default;
outParamRecord = new RC_6e3ea28d2c552bc2cc129f42297e5982();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetFileExtended", "259e9689-91d4-400f-8edb-227ba5ffa5a5.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetFileExtended", "259e9689-91d4-400f-8edb-227ba5ffa5a5.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileExtendedAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileExtendedAttributeKeys.@Filename, "filename") ?? "filename", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileExtendedAttributeKeys.@IsProcessed, "isprocessed") ?? "isprocessed", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileExtendedAttributeKeys.@HasError, "haserror") ?? "haserror", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileExtendedAttributeKeys.@ErrorMessage, "errormessage") ?? "errormessage", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileExtendedAttributeKeys.@UploadedBy, "uploadedby") ?? "uploadedby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileExtendedAttributeKeys.@UploadedOn, "uploadedon") ?? "uploadedon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
" FROM " + ENFileExtendedEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileExtendedAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetFileExtended", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(7,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENFileExtendedEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetFileExtendedForUpdate
/// </summary>

public static async Task<RC_6e3ea28d2c552bc2cc129f42297e5982> GetFileExtendedForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_6e3ea28d2c552bc2cc129f42297e5982 outParamRecord = default;
outParamRecord = new RC_6e3ea28d2c552bc2cc129f42297e5982();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetFileExtendedForUpdate", "259e9689-91d4-400f-8edb-227ba5ffa5a5.#GetEntityForUpdate");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetFileExtendedForUpdate", "259e9689-91d4-400f-8edb-227ba5ffa5a5.#GetEntityForUpdate", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileExtendedAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileExtendedAttributeKeys.@Filename, "filename") ?? "filename", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileExtendedAttributeKeys.@IsProcessed, "isprocessed") ?? "isprocessed", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileExtendedAttributeKeys.@HasError, "haserror") ?? "haserror", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileExtendedAttributeKeys.@ErrorMessage, "errormessage") ?? "errormessage", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileExtendedAttributeKeys.@UploadedBy, "uploadedby") ?? "uploadedby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileExtendedAttributeKeys.@UploadedOn, "uploadedon") ?? "uploadedon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
" FROM " + ENFileExtendedEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileExtendedAttributeKeys.@Id, "id") ?? "id") + " = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetFileExtendedForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(7,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENFileExtendedEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateFileExtended
/// </summary>

public static async Task UpdateFileExtended(IRequestContext requestContext,BitArray usedFields,RC_6e3ea28d2c552bc2cc129f42297e5982 inParamSource,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("UpdateFileExtended", "259e9689-91d4-400f-8edb-227ba5ffa5a5.#UpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateFileExtended", "259e9689-91d4-400f-8edb-227ba5ffa5a5.#UpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_dcebdd8ba305133f41b1e1804925997fEntityRecord ssENFileExtended = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(7,true);
}
string updateSet = "UPDATE " + ENFileExtendedEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileExtendedAttributeKeys.@Filename, "filename") ?? "filename") + " = @ssFilename"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileExtendedAttributeKeys.@IsProcessed, "isprocessed") ?? "isprocessed") + " = @ssIsProcessed"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileExtendedAttributeKeys.@HasError, "haserror") ?? "haserror") + " = @ssHasError"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileExtendedAttributeKeys.@ErrorMessage, "errormessage") ?? "errormessage") + " = @ssErrorMessage"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileExtendedAttributeKeys.@UploadedBy, "uploadedby") ?? "uploadedby") + " = @ssUploadedBy"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileExtendedAttributeKeys.@UploadedOn, "uploadedon") ?? "uploadedon") + " = @ssUploadedOn"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileExtendedAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENFileExtended_ssId_FileExtended";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileExtendedAttributeKeys.@IsProcessed, "isprocessed") ?? "isprocessed") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileExtendedAttributeKeys.@IsProcessed, "isprocessed") ?? "isprocessed") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssFilename", DbType.String, ssENFileExtended.ssFilename);
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssIsProcessed", DbType.Boolean, ssENFileExtended.ssIsProcessed);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssHasError", DbType.Boolean, ssENFileExtended.ssHasError);
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssErrorMessage", DbType.String, ssENFileExtended.ssErrorMessage);
}
if(usedFields[5]) {
if ((ssENFileExtended.ssUploadedBy=="")) {
sqlCmd.CreateParameter("@ssUploadedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssUploadedBy", DbType.String, ssENFileExtended.ssUploadedBy);

}
}
if(usedFields[6]) {
sqlCmd.CreateParameter("@ssUploadedOn", DbType.DateTime, ssENFileExtended.ssUploadedOn);
}
sqlCmd.CreateParameter("@idparam_ssENFileExtended_ssId_FileExtended", DbType.Int64, ssENFileExtended.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateFileExtended", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("FileExtended", ssENFileExtended.ssId.ToString()); }}
}
return;
}

}
}
