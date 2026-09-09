using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateProposalCommentFile
/// </summary>

public static async Task<long> CreateProposalCommentFile(IRequestContext requestContext,RC_1fc482b76911051ba177b5ef645edd69 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateProposalCommentFile", "cda9f4bf-5730-48c4-ae78-9905854248ad.#CreateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateProposalCommentFile", "cda9f4bf-5730-48c4-ae78-9905854248ad.#CreateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_7db82b55fc996c1dcfda575a9310d307EntityRecord ssENProposalCommentFile = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENProposalCommentFileEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalCommentFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentFileAttributeKeys.@CommentId, "commentid") ?? "commentid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalCommentFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentFileAttributeKeys.@Filename, "filename") ?? "filename") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalCommentFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentFileAttributeKeys.@Binary, "binary") ?? "binary") + "" +
" ) VALUES (" +
" @ssCommentId" +
", @ssFilename" +
", @ssBinary" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENProposalCommentFile.ssCommentId==0L)) {
insertSqlCmd.CreateParameter("@ssCommentId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCommentId", DbType.Int64, ssENProposalCommentFile.ssCommentId);

}
insertSqlCmd.CreateParameter("@ssFilename", DbType.String, ssENProposalCommentFile.ssFilename);
insertSqlCmd.CreateParameter("@ssBinary", DbType.Binary, ssENProposalCommentFile.ssBinary);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateProposalCommentFile", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateProposalCommentFile
/// </summary>

public static async Task<long> CreateOrUpdateProposalCommentFile(IRequestContext requestContext,BitArray usedFields,RC_1fc482b76911051ba177b5ef645edd69 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateProposalCommentFile", "cda9f4bf-5730-48c4-ae78-9905854248ad.#CreateOrUpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateProposalCommentFile", "cda9f4bf-5730-48c4-ae78-9905854248ad.#CreateOrUpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_7db82b55fc996c1dcfda575a9310d307EntityRecord ssENProposalCommentFile = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(4,true);
}
string updateSet = "UPDATE " + ENProposalCommentFileEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalCommentFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentFileAttributeKeys.@CommentId, "commentid") ?? "commentid") + " = @ssCommentId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalCommentFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentFileAttributeKeys.@Filename, "filename") ?? "filename") + " = @ssFilename"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalCommentFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentFileAttributeKeys.@Binary, "binary") ?? "binary") + " = @ssBinary"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalCommentFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentFileAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENProposalCommentFile_ssId_ProposalCommentFile";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalCommentFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentFileAttributeKeys.@Filename, "filename") ?? "filename") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalCommentFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentFileAttributeKeys.@Filename, "filename") ?? "filename") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENProposalCommentFile.ssCommentId==0L)) {
sqlCmd.CreateParameter("@ssCommentId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCommentId", DbType.Int64, ssENProposalCommentFile.ssCommentId);

}
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssFilename", DbType.String, ssENProposalCommentFile.ssFilename);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssBinary", DbType.Binary, ssENProposalCommentFile.ssBinary);
}
sqlCmd.CreateParameter("@idparam_ssENProposalCommentFile_ssId_ProposalCommentFile", DbType.Int64, ssENProposalCommentFile.ssId);
int counter = 0;
if(ssENProposalCommentFile.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateProposalCommentFile (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENProposalCommentFileEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalCommentFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentFileAttributeKeys.@CommentId, "commentid") ?? "commentid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalCommentFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentFileAttributeKeys.@Filename, "filename") ?? "filename") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalCommentFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentFileAttributeKeys.@Binary, "binary") ?? "binary") + "" +
" ) VALUES (" +
" @ssCommentId" +
", @ssFilename" +
", @ssBinary" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENProposalCommentFile.ssCommentId==0L)) {
insertSqlCmd.CreateParameter("@ssCommentId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCommentId", DbType.Int64, ssENProposalCommentFile.ssCommentId);

}
insertSqlCmd.CreateParameter("@ssFilename", DbType.String, ssENProposalCommentFile.ssFilename);
insertSqlCmd.CreateParameter("@ssBinary", DbType.Binary, ssENProposalCommentFile.ssBinary);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateProposalCommentFile", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENProposalCommentFile.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeProposalCommentFile
/// </summary>

public static async Task CreateOrUpdateSomeProposalCommentFile(IRequestContext requestContext,RL_4d8e6569493646a791571648fa0a998d inParamSourceList,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateSomeProposalCommentFile", "cda9f4bf-5730-48c4-ae78-9905854248ad.#CreateOrUpdateAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeProposalCommentFile", "cda9f4bf-5730-48c4-ae78-9905854248ad.#CreateOrUpdateAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
string entityTableName = ENProposalCommentFileEntity.LocalViewName(null);
string insertSql = "INSERT INTO " + entityTableName + " (" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalCommentFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentFileAttributeKeys.@CommentId, "commentid") ?? "commentid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalCommentFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentFileAttributeKeys.@Filename, "filename") ?? "filename") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalCommentFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentFileAttributeKeys.@Binary, "binary") ?? "binary") + ") VALUES ( unnest(@ssCommentId),  unnest(@ssFilename),  unnest(@ssBinary)) ";
insertSql += "";

string updateSql = "UPDATE " + entityTableName + " SET " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalCommentFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentFileAttributeKeys.@CommentId, "commentid") ?? "commentid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalCommentFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentFileAttributeKeys.@CommentId, "commentid") ?? "commentid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalCommentFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentFileAttributeKeys.@Filename, "filename") ?? "filename") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalCommentFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentFileAttributeKeys.@Filename, "filename") ?? "filename") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalCommentFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentFileAttributeKeys.@Binary, "binary") ?? "binary") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalCommentFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentFileAttributeKeys.@Binary, "binary") ?? "binary") + " from ( select  unnest(@ssId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalCommentFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentFileAttributeKeys.@Id, "id") ?? "id") + ",  unnest(@ssCommentId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalCommentFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentFileAttributeKeys.@CommentId, "commentid") ?? "commentid") + ",  unnest(@ssFilename) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalCommentFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentFileAttributeKeys.@Filename, "filename") ?? "filename") + ",  unnest(@ssBinary) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalCommentFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentFileAttributeKeys.@Binary, "binary") ?? "binary") + " ) as updateTable where " + entityTableName + "." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalCommentFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentFileAttributeKeys.@Id, "id") ?? "id") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalCommentFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentFileAttributeKeys.@Id, "id") ?? "id") + " ";
updateSql += "";

List<object> insertCommentIdList = new List<object>();
List<string> insertFilenameList = new List<string>();
List<byte[]> insertBinaryList = new List<byte[]>();

List<long> updateIdList = new List<long>();
List<object> updateCommentIdList = new List<object>();
List<string> updateFilenameList = new List<string>();
List<byte[]> updateBinaryList = new List<byte[]>();

var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_1fc482b76911051ba177b5ef645edd69)inParamSourceList.Current).ssENProposalCommentFile;
if (record.ssId != 0L) {
updateIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
if ((record.ssCommentId==0L)) {
updateCommentIdList.Add(null);
} else {
updateCommentIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssCommentId));
}
updateFilenameList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssFilename));
updateBinaryList.Add((byte[])executionService.TransformRuntimeToDatabaseValue(DbType.Binary, record.ssBinary));
} else {
if ((record.ssCommentId==0L)) {
insertCommentIdList.Add(null);
} else {
insertCommentIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssCommentId));
}
insertFilenameList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssFilename));
insertBinaryList.Add((byte[])executionService.TransformRuntimeToDatabaseValue(DbType.Binary, record.ssBinary));
}
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertCommentIdList.IsEmpty() || !insertFilenameList.IsEmpty() || !insertBinaryList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssCommentId",DbType.Int64,insertCommentIdList);
executionService.CreateParameter(insertSqlCmd,"@ssFilename",DbType.String,insertFilenameList);
executionService.CreateParameter(insertSqlCmd,"@ssBinary",DbType.Binary,insertBinaryList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeProposalCommentFile (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
if(!updateCommentIdList.IsEmpty() || !updateFilenameList.IsEmpty() || !updateBinaryList.IsEmpty()){
await using(var updateSqlCmd = trans.CreateCommand(updateSql)){
executionService.CreateParameter(updateSqlCmd,"@ssId",DbType.Int64,updateIdList);
executionService.CreateParameter(updateSqlCmd,"@ssCommentId",DbType.Int64,updateCommentIdList);
executionService.CreateParameter(updateSqlCmd,"@ssFilename",DbType.String,updateFilenameList);
executionService.CreateParameter(updateSqlCmd,"@ssBinary",DbType.Binary,updateBinaryList);
await updateSqlCmd.PrepareAsync(cancellationToken);
await updateSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeProposalCommentFile (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(updateSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteProposalCommentFile
/// </summary>

public static async Task DeleteProposalCommentFile(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteProposalCommentFile", "cda9f4bf-5730-48c4-ae78-9905854248ad.#DeleteEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteProposalCommentFile", "cda9f4bf-5730-48c4-ae78-9905854248ad.#DeleteEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENProposalCommentFileEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalCommentFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentFileAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteProposalCommentFile", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllProposalCommentFile
/// </summary>

public static async Task DeleteAllProposalCommentFile(IRequestContext requestContext,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteAllProposalCommentFile", "cda9f4bf-5730-48c4-ae78-9905854248ad.#DeleteAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllProposalCommentFile", "cda9f4bf-5730-48c4-ae78-9905854248ad.#DeleteAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENProposalCommentFileEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteProposalCommentFile", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetProposalCommentFile
/// </summary>

public static async Task<RC_1fc482b76911051ba177b5ef645edd69> GetProposalCommentFile(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_1fc482b76911051ba177b5ef645edd69 outParamRecord = default;
outParamRecord = new RC_1fc482b76911051ba177b5ef645edd69();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetProposalCommentFile", "cda9f4bf-5730-48c4-ae78-9905854248ad.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetProposalCommentFile", "cda9f4bf-5730-48c4-ae78-9905854248ad.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalCommentFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentFileAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalCommentFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentFileAttributeKeys.@CommentId, "commentid") ?? "commentid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalCommentFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentFileAttributeKeys.@Filename, "filename") ?? "filename", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalCommentFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentFileAttributeKeys.@Binary, "binary") ?? "binary", OutSystems.HubEdition.Extensibility.Data.DBDataType.BINARY_DATA) + "" +
" FROM " + ENProposalCommentFileEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalCommentFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentFileAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetProposalCommentFile", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(4,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENProposalCommentFileEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetProposalCommentFileForUpdate
/// </summary>

public static async Task<RC_1fc482b76911051ba177b5ef645edd69> GetProposalCommentFileForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_1fc482b76911051ba177b5ef645edd69 outParamRecord = default;
outParamRecord = new RC_1fc482b76911051ba177b5ef645edd69();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetProposalCommentFileForUpdate", "cda9f4bf-5730-48c4-ae78-9905854248ad.#GetEntityForUpdate");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetProposalCommentFileForUpdate", "cda9f4bf-5730-48c4-ae78-9905854248ad.#GetEntityForUpdate", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalCommentFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentFileAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalCommentFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentFileAttributeKeys.@CommentId, "commentid") ?? "commentid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalCommentFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentFileAttributeKeys.@Filename, "filename") ?? "filename", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalCommentFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentFileAttributeKeys.@Binary, "binary") ?? "binary", OutSystems.HubEdition.Extensibility.Data.DBDataType.BINARY_DATA) + "" +
" FROM " + ENProposalCommentFileEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalCommentFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentFileAttributeKeys.@Id, "id") ?? "id") + " = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetProposalCommentFileForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(4,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENProposalCommentFileEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateProposalCommentFile
/// </summary>

public static async Task UpdateProposalCommentFile(IRequestContext requestContext,BitArray usedFields,RC_1fc482b76911051ba177b5ef645edd69 inParamSource,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("UpdateProposalCommentFile", "cda9f4bf-5730-48c4-ae78-9905854248ad.#UpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateProposalCommentFile", "cda9f4bf-5730-48c4-ae78-9905854248ad.#UpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_7db82b55fc996c1dcfda575a9310d307EntityRecord ssENProposalCommentFile = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(4,true);
}
string updateSet = "UPDATE " + ENProposalCommentFileEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalCommentFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentFileAttributeKeys.@CommentId, "commentid") ?? "commentid") + " = @ssCommentId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalCommentFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentFileAttributeKeys.@Filename, "filename") ?? "filename") + " = @ssFilename"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalCommentFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentFileAttributeKeys.@Binary, "binary") ?? "binary") + " = @ssBinary"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalCommentFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentFileAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENProposalCommentFile_ssId_ProposalCommentFile";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalCommentFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentFileAttributeKeys.@Filename, "filename") ?? "filename") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalCommentFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentFileAttributeKeys.@Filename, "filename") ?? "filename") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENProposalCommentFile.ssCommentId==0L)) {
sqlCmd.CreateParameter("@ssCommentId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCommentId", DbType.Int64, ssENProposalCommentFile.ssCommentId);

}
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssFilename", DbType.String, ssENProposalCommentFile.ssFilename);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssBinary", DbType.Binary, ssENProposalCommentFile.ssBinary);
}
sqlCmd.CreateParameter("@idparam_ssENProposalCommentFile_ssId_ProposalCommentFile", DbType.Int64, ssENProposalCommentFile.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateProposalCommentFile", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("ProposalCommentFile", ssENProposalCommentFile.ssId.ToString()); }}
}
return;
}

}
}
