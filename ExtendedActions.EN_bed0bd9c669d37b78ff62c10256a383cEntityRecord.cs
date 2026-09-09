using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateInvoiceExtendedRelations
/// </summary>

public static async Task<long> CreateInvoiceExtendedRelations(IRequestContext requestContext,RC_759c053ad9cffaec26c59da8e40042d4 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateInvoiceExtendedRelations", "19c31d35-ba15-49c3-809b-a37df040be59.#CreateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateInvoiceExtendedRelations", "19c31d35-ba15-49c3-809b-a37df040be59.#CreateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_bed0bd9c669d37b78ff62c10256a383cEntityRecord ssENInvoiceExtendedRelations = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENInvoiceExtendedRelationsEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedRelations, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedRelationsAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedRelations, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedRelationsAttributeKeys.@TipoRelacion, "tiporelacion") ?? "tiporelacion") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedRelations, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedRelationsAttributeKeys.@UUIDRelacionado, "uuidrelacionado") ?? "uuidrelacionado") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedRelations, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedRelationsAttributeKeys.@FolioRelacionado, "foliorelacionado") ?? "foliorelacionado") + "" +
" ) VALUES (" +
" @ssInvoiceId" +
", @ssTipoRelacion" +
", @ssUUIDRelacionado" +
", @ssFolioRelacionado" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENInvoiceExtendedRelations.ssInvoiceId==0L)) {
insertSqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, ssENInvoiceExtendedRelations.ssInvoiceId);

}
insertSqlCmd.CreateParameter("@ssTipoRelacion", DbType.String, ssENInvoiceExtendedRelations.ssTipoRelacion);
insertSqlCmd.CreateParameter("@ssUUIDRelacionado", DbType.String, ssENInvoiceExtendedRelations.ssUUIDRelacionado);
insertSqlCmd.CreateParameter("@ssFolioRelacionado", DbType.String, ssENInvoiceExtendedRelations.ssFolioRelacionado);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateInvoiceExtendedRelations", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateInvoiceExtendedRelations
/// </summary>

public static async Task<long> CreateOrUpdateInvoiceExtendedRelations(IRequestContext requestContext,BitArray usedFields,RC_759c053ad9cffaec26c59da8e40042d4 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateInvoiceExtendedRelations", "19c31d35-ba15-49c3-809b-a37df040be59.#CreateOrUpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateInvoiceExtendedRelations", "19c31d35-ba15-49c3-809b-a37df040be59.#CreateOrUpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_bed0bd9c669d37b78ff62c10256a383cEntityRecord ssENInvoiceExtendedRelations = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(5,true);
}
string updateSet = "UPDATE " + ENInvoiceExtendedRelationsEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedRelations, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedRelationsAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + " = @ssInvoiceId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedRelations, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedRelationsAttributeKeys.@TipoRelacion, "tiporelacion") ?? "tiporelacion") + " = @ssTipoRelacion"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedRelations, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedRelationsAttributeKeys.@UUIDRelacionado, "uuidrelacionado") ?? "uuidrelacionado") + " = @ssUUIDRelacionado"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedRelations, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedRelationsAttributeKeys.@FolioRelacionado, "foliorelacionado") ?? "foliorelacionado") + " = @ssFolioRelacionado"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedRelations, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedRelationsAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENInvoiceExtndedRelations_ssd_InvoiceExtenedRelations";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedRelations, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedRelationsAttributeKeys.@TipoRelacion, "tiporelacion") ?? "tiporelacion") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedRelations, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedRelationsAttributeKeys.@TipoRelacion, "tiporelacion") ?? "tiporelacion") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENInvoiceExtendedRelations.ssInvoiceId==0L)) {
sqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, ssENInvoiceExtendedRelations.ssInvoiceId);

}
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssTipoRelacion", DbType.String, ssENInvoiceExtendedRelations.ssTipoRelacion);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssUUIDRelacionado", DbType.String, ssENInvoiceExtendedRelations.ssUUIDRelacionado);
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssFolioRelacionado", DbType.String, ssENInvoiceExtendedRelations.ssFolioRelacionado);
}
sqlCmd.CreateParameter("@idparam_ssENInvoiceExtndedRelations_ssd_InvoiceExtenedRelations", DbType.Int64, ssENInvoiceExtendedRelations.ssId);
int counter = 0;
if(ssENInvoiceExtendedRelations.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateInvoiceExtendedRelations (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENInvoiceExtendedRelationsEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedRelations, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedRelationsAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedRelations, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedRelationsAttributeKeys.@TipoRelacion, "tiporelacion") ?? "tiporelacion") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedRelations, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedRelationsAttributeKeys.@UUIDRelacionado, "uuidrelacionado") ?? "uuidrelacionado") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedRelations, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedRelationsAttributeKeys.@FolioRelacionado, "foliorelacionado") ?? "foliorelacionado") + "" +
" ) VALUES (" +
" @ssInvoiceId" +
", @ssTipoRelacion" +
", @ssUUIDRelacionado" +
", @ssFolioRelacionado" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENInvoiceExtendedRelations.ssInvoiceId==0L)) {
insertSqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, ssENInvoiceExtendedRelations.ssInvoiceId);

}
insertSqlCmd.CreateParameter("@ssTipoRelacion", DbType.String, ssENInvoiceExtendedRelations.ssTipoRelacion);
insertSqlCmd.CreateParameter("@ssUUIDRelacionado", DbType.String, ssENInvoiceExtendedRelations.ssUUIDRelacionado);
insertSqlCmd.CreateParameter("@ssFolioRelacionado", DbType.String, ssENInvoiceExtendedRelations.ssFolioRelacionado);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateInvoiceExtendedRelations", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENInvoiceExtendedRelations.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeInvoiceExtendedRelations
/// </summary>

public static async Task CreateOrUpdateSomeInvoiceExtendedRelations(IRequestContext requestContext,RL_d07e089b14ae41d13cfd90c5313de016 inParamSourceList,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateSomeInvoiceExtendedRelations", "19c31d35-ba15-49c3-809b-a37df040be59.#CreateOrUpdateAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeInvoiceExtendedRelations", "19c31d35-ba15-49c3-809b-a37df040be59.#CreateOrUpdateAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
string entityTableName = ENInvoiceExtendedRelationsEntity.LocalViewName(null);
string insertSql = "INSERT INTO " + entityTableName + " (" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedRelations, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedRelationsAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedRelations, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedRelationsAttributeKeys.@TipoRelacion, "tiporelacion") ?? "tiporelacion") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedRelations, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedRelationsAttributeKeys.@UUIDRelacionado, "uuidrelacionado") ?? "uuidrelacionado") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedRelations, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedRelationsAttributeKeys.@FolioRelacionado, "foliorelacionado") ?? "foliorelacionado") + ") VALUES ( unnest(@ssInvoiceId),  unnest(@ssTipoRelacion),  unnest(@ssUUIDRelacionado),  unnest(@ssFolioRelacionado)) ";
insertSql += "";

string updateSql = "UPDATE " + entityTableName + " SET " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedRelations, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedRelationsAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedRelations, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedRelationsAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedRelations, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedRelationsAttributeKeys.@TipoRelacion, "tiporelacion") ?? "tiporelacion") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedRelations, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedRelationsAttributeKeys.@TipoRelacion, "tiporelacion") ?? "tiporelacion") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedRelations, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedRelationsAttributeKeys.@UUIDRelacionado, "uuidrelacionado") ?? "uuidrelacionado") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedRelations, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedRelationsAttributeKeys.@UUIDRelacionado, "uuidrelacionado") ?? "uuidrelacionado") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedRelations, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedRelationsAttributeKeys.@FolioRelacionado, "foliorelacionado") ?? "foliorelacionado") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedRelations, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedRelationsAttributeKeys.@FolioRelacionado, "foliorelacionado") ?? "foliorelacionado") + " from ( select  unnest(@ssId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedRelations, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedRelationsAttributeKeys.@Id, "id") ?? "id") + ",  unnest(@ssInvoiceId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedRelations, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedRelationsAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + ",  unnest(@ssTipoRelacion) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedRelations, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedRelationsAttributeKeys.@TipoRelacion, "tiporelacion") ?? "tiporelacion") + ",  unnest(@ssUUIDRelacionado) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedRelations, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedRelationsAttributeKeys.@UUIDRelacionado, "uuidrelacionado") ?? "uuidrelacionado") + ",  unnest(@ssFolioRelacionado) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedRelations, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedRelationsAttributeKeys.@FolioRelacionado, "foliorelacionado") ?? "foliorelacionado") + " ) as updateTable where " + entityTableName + "." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedRelations, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedRelationsAttributeKeys.@Id, "id") ?? "id") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedRelations, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedRelationsAttributeKeys.@Id, "id") ?? "id") + " ";
updateSql += "";

List<object> insertInvoiceIdList = new List<object>();
List<string> insertTipoRelacionList = new List<string>();
List<string> insertUUIDRelacionadoList = new List<string>();
List<string> insertFolioRelacionadoList = new List<string>();

List<long> updateIdList = new List<long>();
List<object> updateInvoiceIdList = new List<object>();
List<string> updateTipoRelacionList = new List<string>();
List<string> updateUUIDRelacionadoList = new List<string>();
List<string> updateFolioRelacionadoList = new List<string>();

var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_759c053ad9cffaec26c59da8e40042d4)inParamSourceList.Current).ssENInvoiceExtendedRelations;
if (record.ssId != 0L) {
updateIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
if ((record.ssInvoiceId==0L)) {
updateInvoiceIdList.Add(null);
} else {
updateInvoiceIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssInvoiceId));
}
updateTipoRelacionList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssTipoRelacion));
updateUUIDRelacionadoList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssUUIDRelacionado));
updateFolioRelacionadoList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssFolioRelacionado));
} else {
if ((record.ssInvoiceId==0L)) {
insertInvoiceIdList.Add(null);
} else {
insertInvoiceIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssInvoiceId));
}
insertTipoRelacionList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssTipoRelacion));
insertUUIDRelacionadoList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssUUIDRelacionado));
insertFolioRelacionadoList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssFolioRelacionado));
}
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertInvoiceIdList.IsEmpty() || !insertTipoRelacionList.IsEmpty() || !insertUUIDRelacionadoList.IsEmpty() || !insertFolioRelacionadoList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssInvoiceId",DbType.Int64,insertInvoiceIdList);
executionService.CreateParameter(insertSqlCmd,"@ssTipoRelacion",DbType.String,insertTipoRelacionList);
executionService.CreateParameter(insertSqlCmd,"@ssUUIDRelacionado",DbType.String,insertUUIDRelacionadoList);
executionService.CreateParameter(insertSqlCmd,"@ssFolioRelacionado",DbType.String,insertFolioRelacionadoList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeInvoiceExtendedRelations (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
if(!updateInvoiceIdList.IsEmpty() || !updateTipoRelacionList.IsEmpty() || !updateUUIDRelacionadoList.IsEmpty() || !updateFolioRelacionadoList.IsEmpty()){
await using(var updateSqlCmd = trans.CreateCommand(updateSql)){
executionService.CreateParameter(updateSqlCmd,"@ssId",DbType.Int64,updateIdList);
executionService.CreateParameter(updateSqlCmd,"@ssInvoiceId",DbType.Int64,updateInvoiceIdList);
executionService.CreateParameter(updateSqlCmd,"@ssTipoRelacion",DbType.String,updateTipoRelacionList);
executionService.CreateParameter(updateSqlCmd,"@ssUUIDRelacionado",DbType.String,updateUUIDRelacionadoList);
executionService.CreateParameter(updateSqlCmd,"@ssFolioRelacionado",DbType.String,updateFolioRelacionadoList);
await updateSqlCmd.PrepareAsync(cancellationToken);
await updateSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeInvoiceExtendedRelations (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(updateSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteInvoiceExtendedRelations
/// </summary>

public static async Task DeleteInvoiceExtendedRelations(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteInvoiceExtendedRelations", "19c31d35-ba15-49c3-809b-a37df040be59.#DeleteEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteInvoiceExtendedRelations", "19c31d35-ba15-49c3-809b-a37df040be59.#DeleteEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENInvoiceExtendedRelationsEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedRelations, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedRelationsAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteInvoiceExtendedRelations", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllInvoiceExtendedRelations
/// </summary>

public static async Task DeleteAllInvoiceExtendedRelations(IRequestContext requestContext,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteAllInvoiceExtendedRelations", "19c31d35-ba15-49c3-809b-a37df040be59.#DeleteAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllInvoiceExtendedRelations", "19c31d35-ba15-49c3-809b-a37df040be59.#DeleteAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENInvoiceExtendedRelationsEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteInvoiceExtendedRelations", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetInvoiceExtendedRelations
/// </summary>

public static async Task<RC_759c053ad9cffaec26c59da8e40042d4> GetInvoiceExtendedRelations(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_759c053ad9cffaec26c59da8e40042d4 outParamRecord = default;
outParamRecord = new RC_759c053ad9cffaec26c59da8e40042d4();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetInvoiceExtendedRelations", "19c31d35-ba15-49c3-809b-a37df040be59.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetInvoiceExtendedRelations", "19c31d35-ba15-49c3-809b-a37df040be59.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedRelations, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedRelationsAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedRelations, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedRelationsAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedRelations, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedRelationsAttributeKeys.@TipoRelacion, "tiporelacion") ?? "tiporelacion", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedRelations, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedRelationsAttributeKeys.@UUIDRelacionado, "uuidrelacionado") ?? "uuidrelacionado", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedRelations, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedRelationsAttributeKeys.@FolioRelacionado, "foliorelacionado") ?? "foliorelacionado", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
" FROM " + ENInvoiceExtendedRelationsEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedRelations, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedRelationsAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetInvoiceExtendedRelations", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(5,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENInvoiceExtendedRelationsEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetInvoiceExtendedRelationsForUpdate
/// </summary>

public static async Task<RC_759c053ad9cffaec26c59da8e40042d4> GetInvoiceExtendedRelationsForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_759c053ad9cffaec26c59da8e40042d4 outParamRecord = default;
outParamRecord = new RC_759c053ad9cffaec26c59da8e40042d4();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetInvoiceExtendedRelationsForUpdate", "19c31d35-ba15-49c3-809b-a37df040be59.#GetEntityForUpdate");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetInvoiceExtendedRelationsForUpdate", "19c31d35-ba15-49c3-809b-a37df040be59.#GetEntityForUpdate", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedRelations, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedRelationsAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedRelations, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedRelationsAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedRelations, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedRelationsAttributeKeys.@TipoRelacion, "tiporelacion") ?? "tiporelacion", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedRelations, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedRelationsAttributeKeys.@UUIDRelacionado, "uuidrelacionado") ?? "uuidrelacionado", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedRelations, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedRelationsAttributeKeys.@FolioRelacionado, "foliorelacionado") ?? "foliorelacionado", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
" FROM " + ENInvoiceExtendedRelationsEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedRelations, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedRelationsAttributeKeys.@Id, "id") ?? "id") + " = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetInvoiceExtendedRelationsForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(5,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENInvoiceExtendedRelationsEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateInvoiceExtendedRelations
/// </summary>

public static async Task UpdateInvoiceExtendedRelations(IRequestContext requestContext,BitArray usedFields,RC_759c053ad9cffaec26c59da8e40042d4 inParamSource,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("UpdateInvoiceExtendedRelations", "19c31d35-ba15-49c3-809b-a37df040be59.#UpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateInvoiceExtendedRelations", "19c31d35-ba15-49c3-809b-a37df040be59.#UpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_bed0bd9c669d37b78ff62c10256a383cEntityRecord ssENInvoiceExtendedRelations = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(5,true);
}
string updateSet = "UPDATE " + ENInvoiceExtendedRelationsEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedRelations, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedRelationsAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + " = @ssInvoiceId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedRelations, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedRelationsAttributeKeys.@TipoRelacion, "tiporelacion") ?? "tiporelacion") + " = @ssTipoRelacion"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedRelations, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedRelationsAttributeKeys.@UUIDRelacionado, "uuidrelacionado") ?? "uuidrelacionado") + " = @ssUUIDRelacionado"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedRelations, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedRelationsAttributeKeys.@FolioRelacionado, "foliorelacionado") ?? "foliorelacionado") + " = @ssFolioRelacionado"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedRelations, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedRelationsAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENInvoiceExtndedRelations_ssd_InvoiceExtenedRelations";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedRelations, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedRelationsAttributeKeys.@TipoRelacion, "tiporelacion") ?? "tiporelacion") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedRelations, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedRelationsAttributeKeys.@TipoRelacion, "tiporelacion") ?? "tiporelacion") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENInvoiceExtendedRelations.ssInvoiceId==0L)) {
sqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, ssENInvoiceExtendedRelations.ssInvoiceId);

}
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssTipoRelacion", DbType.String, ssENInvoiceExtendedRelations.ssTipoRelacion);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssUUIDRelacionado", DbType.String, ssENInvoiceExtendedRelations.ssUUIDRelacionado);
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssFolioRelacionado", DbType.String, ssENInvoiceExtendedRelations.ssFolioRelacionado);
}
sqlCmd.CreateParameter("@idparam_ssENInvoiceExtndedRelations_ssd_InvoiceExtenedRelations", DbType.Int64, ssENInvoiceExtendedRelations.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateInvoiceExtendedRelations", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("InvoiceExtendedRelations", ssENInvoiceExtendedRelations.ssId.ToString()); }}
}
return;
}

}
}
