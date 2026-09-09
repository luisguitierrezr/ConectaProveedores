using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateInvoiceExtendedIssuer
/// </summary>

public static async Task<long> CreateInvoiceExtendedIssuer(IRequestContext requestContext,RC_bceddfb85670aa95e44aa049194f2b7c inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateInvoiceExtendedIssuer", "a86d3b50-53d4-4657-98b9-95d4c12655a2.#CreateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateInvoiceExtendedIssuer", "a86d3b50-53d4-4657-98b9-95d4c12655a2.#CreateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_1ca446167f1a5fee035306f622895668EntityRecord ssENInvoiceExtendedIssuer = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENInvoiceExtendedIssuerEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedIssuer, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedIssuerAttributeKeys.@Id, "id") ?? "id") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedIssuer, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedIssuerAttributeKeys.@RFC, "rfc") ?? "rfc") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedIssuer, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedIssuerAttributeKeys.@Nombre, "nombre") ?? "nombre") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedIssuer, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedIssuerAttributeKeys.@RegimenFiscal, "regimenfiscal") ?? "regimenfiscal") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedIssuer, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedIssuerAttributeKeys.@CodigoPostal, "codigopostal") ?? "codigopostal") + "" +
" ) VALUES (" +
" @ssId" +
", @ssRFC" +
", @ssNombre" +
", @ssRegimenFiscal" +
", @ssCodigoPostal" +
" )";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssId", DbType.Int64, ssENInvoiceExtendedIssuer.ssId);
insertSqlCmd.CreateParameter("@ssRFC", DbType.String, ssENInvoiceExtendedIssuer.ssRFC);
insertSqlCmd.CreateParameter("@ssNombre", DbType.String, ssENInvoiceExtendedIssuer.ssNombre);
insertSqlCmd.CreateParameter("@ssRegimenFiscal", DbType.String, ssENInvoiceExtendedIssuer.ssRegimenFiscal);
insertSqlCmd.CreateParameter("@ssCodigoPostal", DbType.String, ssENInvoiceExtendedIssuer.ssCodigoPostal);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateInvoiceExtendedIssuer", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
outParamId = ssENInvoiceExtendedIssuer.ssId;
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateInvoiceExtendedIssuer
/// </summary>

public static async Task<long> CreateOrUpdateInvoiceExtendedIssuer(IRequestContext requestContext,BitArray usedFields,RC_bceddfb85670aa95e44aa049194f2b7c inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateInvoiceExtendedIssuer", "a86d3b50-53d4-4657-98b9-95d4c12655a2.#CreateOrUpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateInvoiceExtendedIssuer", "a86d3b50-53d4-4657-98b9-95d4c12655a2.#CreateOrUpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_1ca446167f1a5fee035306f622895668EntityRecord ssENInvoiceExtendedIssuer = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(5,true);
}
string updateSet = "UPDATE " + ENInvoiceExtendedIssuerEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedIssuer, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedIssuerAttributeKeys.@RFC, "rfc") ?? "rfc") + " = @ssRFC"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedIssuer, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedIssuerAttributeKeys.@Nombre, "nombre") ?? "nombre") + " = @ssNombre"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedIssuer, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedIssuerAttributeKeys.@RegimenFiscal, "regimenfiscal") ?? "regimenfiscal") + " = @ssRegimenFiscal"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedIssuer, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedIssuerAttributeKeys.@CodigoPostal, "codigopostal") ?? "codigopostal") + " = @ssCodigoPostal"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedIssuer, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedIssuerAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENInvoiceExtendedIssuer_ssId_InvoiceExtendedIssuer";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedIssuer, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedIssuerAttributeKeys.@RFC, "rfc") ?? "rfc") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedIssuer, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedIssuerAttributeKeys.@RFC, "rfc") ?? "rfc") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssRFC", DbType.String, ssENInvoiceExtendedIssuer.ssRFC);
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssNombre", DbType.String, ssENInvoiceExtendedIssuer.ssNombre);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssRegimenFiscal", DbType.String, ssENInvoiceExtendedIssuer.ssRegimenFiscal);
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssCodigoPostal", DbType.String, ssENInvoiceExtendedIssuer.ssCodigoPostal);
}
sqlCmd.CreateParameter("@idparam_ssENInvoiceExtendedIssuer_ssId_InvoiceExtendedIssuer", DbType.Int64, ssENInvoiceExtendedIssuer.ssId);
int counter = 0;
if(ssENInvoiceExtendedIssuer.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateInvoiceExtendedIssuer (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENInvoiceExtendedIssuerEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedIssuer, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedIssuerAttributeKeys.@Id, "id") ?? "id") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedIssuer, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedIssuerAttributeKeys.@RFC, "rfc") ?? "rfc") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedIssuer, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedIssuerAttributeKeys.@Nombre, "nombre") ?? "nombre") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedIssuer, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedIssuerAttributeKeys.@RegimenFiscal, "regimenfiscal") ?? "regimenfiscal") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedIssuer, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedIssuerAttributeKeys.@CodigoPostal, "codigopostal") ?? "codigopostal") + "" +
" ) VALUES (" +
" @ssId" +
", @ssRFC" +
", @ssNombre" +
", @ssRegimenFiscal" +
", @ssCodigoPostal" +
" )";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssId", DbType.Int64, ssENInvoiceExtendedIssuer.ssId);
insertSqlCmd.CreateParameter("@ssRFC", DbType.String, ssENInvoiceExtendedIssuer.ssRFC);
insertSqlCmd.CreateParameter("@ssNombre", DbType.String, ssENInvoiceExtendedIssuer.ssNombre);
insertSqlCmd.CreateParameter("@ssRegimenFiscal", DbType.String, ssENInvoiceExtendedIssuer.ssRegimenFiscal);
insertSqlCmd.CreateParameter("@ssCodigoPostal", DbType.String, ssENInvoiceExtendedIssuer.ssCodigoPostal);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateInvoiceExtendedIssuer", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
outParamId = ssENInvoiceExtendedIssuer.ssId;
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENInvoiceExtendedIssuer.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeInvoiceExtendedIssuer
/// </summary>

public static async Task CreateOrUpdateSomeInvoiceExtendedIssuer(IRequestContext requestContext,RL_58fbe7ce84d153fe733fe1ed5bd56616 inParamSourceList,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateSomeInvoiceExtendedIssuer", "a86d3b50-53d4-4657-98b9-95d4c12655a2.#CreateOrUpdateAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeInvoiceExtendedIssuer", "a86d3b50-53d4-4657-98b9-95d4c12655a2.#CreateOrUpdateAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
string entityTableName = ENInvoiceExtendedIssuerEntity.LocalViewName(null);
string insertSql = "INSERT INTO " + entityTableName + " (" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedIssuer, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedIssuerAttributeKeys.@Id, "id") ?? "id") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedIssuer, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedIssuerAttributeKeys.@RFC, "rfc") ?? "rfc") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedIssuer, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedIssuerAttributeKeys.@Nombre, "nombre") ?? "nombre") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedIssuer, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedIssuerAttributeKeys.@RegimenFiscal, "regimenfiscal") ?? "regimenfiscal") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedIssuer, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedIssuerAttributeKeys.@CodigoPostal, "codigopostal") ?? "codigopostal") + ") VALUES ( unnest(@ssId),  unnest(@ssRFC),  unnest(@ssNombre),  unnest(@ssRegimenFiscal),  unnest(@ssCodigoPostal)) ON CONFLICT(" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedIssuer, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedIssuerAttributeKeys.@Id, "id") ?? "id") + ") do update set " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedIssuer, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedIssuerAttributeKeys.@RFC, "rfc") ?? "rfc") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedIssuer, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedIssuerAttributeKeys.@RFC, "rfc") ?? "rfc") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedIssuer, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedIssuerAttributeKeys.@Nombre, "nombre") ?? "nombre") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedIssuer, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedIssuerAttributeKeys.@Nombre, "nombre") ?? "nombre") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedIssuer, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedIssuerAttributeKeys.@RegimenFiscal, "regimenfiscal") ?? "regimenfiscal") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedIssuer, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedIssuerAttributeKeys.@RegimenFiscal, "regimenfiscal") ?? "regimenfiscal") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedIssuer, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedIssuerAttributeKeys.@CodigoPostal, "codigopostal") ?? "codigopostal") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedIssuer, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedIssuerAttributeKeys.@CodigoPostal, "codigopostal") ?? "codigopostal") + " ";
insertSql += "";


List<object> insertIdList = new List<object>();
List<string> insertRFCList = new List<string>();
List<string> insertNombreList = new List<string>();
List<string> insertRegimenFiscalList = new List<string>();
List<string> insertCodigoPostalList = new List<string>();


var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_bceddfb85670aa95e44aa049194f2b7c)inParamSourceList.Current).ssENInvoiceExtendedIssuer;
insertIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
insertRFCList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssRFC));
insertNombreList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssNombre));
insertRegimenFiscalList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssRegimenFiscal));
insertCodigoPostalList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssCodigoPostal));
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertIdList.IsEmpty() || !insertRFCList.IsEmpty() || !insertNombreList.IsEmpty() || !insertRegimenFiscalList.IsEmpty() || !insertCodigoPostalList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssId",DbType.Int64,insertIdList);
executionService.CreateParameter(insertSqlCmd,"@ssRFC",DbType.String,insertRFCList);
executionService.CreateParameter(insertSqlCmd,"@ssNombre",DbType.String,insertNombreList);
executionService.CreateParameter(insertSqlCmd,"@ssRegimenFiscal",DbType.String,insertRegimenFiscalList);
executionService.CreateParameter(insertSqlCmd,"@ssCodigoPostal",DbType.String,insertCodigoPostalList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeInvoiceExtendedIssuer (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteInvoiceExtendedIssuer
/// </summary>

public static async Task DeleteInvoiceExtendedIssuer(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteInvoiceExtendedIssuer", "a86d3b50-53d4-4657-98b9-95d4c12655a2.#DeleteEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteInvoiceExtendedIssuer", "a86d3b50-53d4-4657-98b9-95d4c12655a2.#DeleteEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENInvoiceExtendedIssuerEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedIssuer, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedIssuerAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteInvoiceExtendedIssuer", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllInvoiceExtendedIssuer
/// </summary>

public static async Task DeleteAllInvoiceExtendedIssuer(IRequestContext requestContext,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteAllInvoiceExtendedIssuer", "a86d3b50-53d4-4657-98b9-95d4c12655a2.#DeleteAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllInvoiceExtendedIssuer", "a86d3b50-53d4-4657-98b9-95d4c12655a2.#DeleteAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENInvoiceExtendedIssuerEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteInvoiceExtendedIssuer", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetInvoiceExtendedIssuer
/// </summary>

public static async Task<RC_bceddfb85670aa95e44aa049194f2b7c> GetInvoiceExtendedIssuer(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_bceddfb85670aa95e44aa049194f2b7c outParamRecord = default;
outParamRecord = new RC_bceddfb85670aa95e44aa049194f2b7c();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetInvoiceExtendedIssuer", "a86d3b50-53d4-4657-98b9-95d4c12655a2.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetInvoiceExtendedIssuer", "a86d3b50-53d4-4657-98b9-95d4c12655a2.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedIssuer, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedIssuerAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedIssuer, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedIssuerAttributeKeys.@RFC, "rfc") ?? "rfc", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedIssuer, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedIssuerAttributeKeys.@Nombre, "nombre") ?? "nombre", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedIssuer, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedIssuerAttributeKeys.@RegimenFiscal, "regimenfiscal") ?? "regimenfiscal", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedIssuer, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedIssuerAttributeKeys.@CodigoPostal, "codigopostal") ?? "codigopostal", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
" FROM " + ENInvoiceExtendedIssuerEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedIssuer, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedIssuerAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetInvoiceExtendedIssuer", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(5,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENInvoiceExtendedIssuerEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetInvoiceExtendedIssuerForUpdate
/// </summary>

public static async Task<RC_bceddfb85670aa95e44aa049194f2b7c> GetInvoiceExtendedIssuerForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_bceddfb85670aa95e44aa049194f2b7c outParamRecord = default;
outParamRecord = new RC_bceddfb85670aa95e44aa049194f2b7c();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetInvoiceExtendedIssuerForUpdate", "a86d3b50-53d4-4657-98b9-95d4c12655a2.#GetEntityForUpdate");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetInvoiceExtendedIssuerForUpdate", "a86d3b50-53d4-4657-98b9-95d4c12655a2.#GetEntityForUpdate", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedIssuer, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedIssuerAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedIssuer, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedIssuerAttributeKeys.@RFC, "rfc") ?? "rfc", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedIssuer, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedIssuerAttributeKeys.@Nombre, "nombre") ?? "nombre", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedIssuer, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedIssuerAttributeKeys.@RegimenFiscal, "regimenfiscal") ?? "regimenfiscal", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedIssuer, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedIssuerAttributeKeys.@CodigoPostal, "codigopostal") ?? "codigopostal", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
" FROM " + ENInvoiceExtendedIssuerEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedIssuer, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedIssuerAttributeKeys.@Id, "id") ?? "id") + " = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetInvoiceExtendedIssuerForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(5,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENInvoiceExtendedIssuerEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateInvoiceExtendedIssuer
/// </summary>

public static async Task UpdateInvoiceExtendedIssuer(IRequestContext requestContext,BitArray usedFields,RC_bceddfb85670aa95e44aa049194f2b7c inParamSource,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("UpdateInvoiceExtendedIssuer", "a86d3b50-53d4-4657-98b9-95d4c12655a2.#UpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateInvoiceExtendedIssuer", "a86d3b50-53d4-4657-98b9-95d4c12655a2.#UpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_1ca446167f1a5fee035306f622895668EntityRecord ssENInvoiceExtendedIssuer = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(5,true);
}
string updateSet = "UPDATE " + ENInvoiceExtendedIssuerEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedIssuer, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedIssuerAttributeKeys.@RFC, "rfc") ?? "rfc") + " = @ssRFC"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedIssuer, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedIssuerAttributeKeys.@Nombre, "nombre") ?? "nombre") + " = @ssNombre"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedIssuer, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedIssuerAttributeKeys.@RegimenFiscal, "regimenfiscal") ?? "regimenfiscal") + " = @ssRegimenFiscal"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedIssuer, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedIssuerAttributeKeys.@CodigoPostal, "codigopostal") ?? "codigopostal") + " = @ssCodigoPostal"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedIssuer, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedIssuerAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENInvoiceExtendedIssuer_ssId_InvoiceExtendedIssuer";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedIssuer, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedIssuerAttributeKeys.@RFC, "rfc") ?? "rfc") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedIssuer, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedIssuerAttributeKeys.@RFC, "rfc") ?? "rfc") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssRFC", DbType.String, ssENInvoiceExtendedIssuer.ssRFC);
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssNombre", DbType.String, ssENInvoiceExtendedIssuer.ssNombre);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssRegimenFiscal", DbType.String, ssENInvoiceExtendedIssuer.ssRegimenFiscal);
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssCodigoPostal", DbType.String, ssENInvoiceExtendedIssuer.ssCodigoPostal);
}
sqlCmd.CreateParameter("@idparam_ssENInvoiceExtendedIssuer_ssId_InvoiceExtendedIssuer", DbType.Int64, ssENInvoiceExtendedIssuer.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateInvoiceExtendedIssuer", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("InvoiceExtendedIssuer", ssENInvoiceExtendedIssuer.ssId.ToString()); }}
}
return;
}

}
}
