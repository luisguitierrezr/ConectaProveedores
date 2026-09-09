using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateInvoiceExtendedReceiver
/// </summary>

public static async Task<long> CreateInvoiceExtendedReceiver(IRequestContext requestContext,RC_466f18b870f78193989904128fc2d15c inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateInvoiceExtendedReceiver", "647c756a-a8b9-4138-8f1a-99962cb77078.#CreateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateInvoiceExtendedReceiver", "647c756a-a8b9-4138-8f1a-99962cb77078.#CreateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord ssENInvoiceExtendedReceiver = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENInvoiceExtendedReceiverEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedReceiver, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedReceiverAttributeKeys.@Id, "id") ?? "id") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedReceiver, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedReceiverAttributeKeys.@RFC, "rfc") ?? "rfc") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedReceiver, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedReceiverAttributeKeys.@Nombre, "nombre") ?? "nombre") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedReceiver, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedReceiverAttributeKeys.@RegimenFiscal, "regimenfiscal") ?? "regimenfiscal") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedReceiver, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedReceiverAttributeKeys.@CodigoPostal, "codigopostal") ?? "codigopostal") + "" +
" ) VALUES (" +
" @ssId" +
", @ssRFC" +
", @ssNombre" +
", @ssRegimenFiscal" +
", @ssCodigoPostal" +
" )";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssId", DbType.Int64, ssENInvoiceExtendedReceiver.ssId);
insertSqlCmd.CreateParameter("@ssRFC", DbType.String, ssENInvoiceExtendedReceiver.ssRFC);
insertSqlCmd.CreateParameter("@ssNombre", DbType.String, ssENInvoiceExtendedReceiver.ssNombre);
insertSqlCmd.CreateParameter("@ssRegimenFiscal", DbType.String, ssENInvoiceExtendedReceiver.ssRegimenFiscal);
insertSqlCmd.CreateParameter("@ssCodigoPostal", DbType.String, ssENInvoiceExtendedReceiver.ssCodigoPostal);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateInvoiceExtendedReceiver", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
outParamId = ssENInvoiceExtendedReceiver.ssId;
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateInvoiceExtendedReceiver
/// </summary>

public static async Task<long> CreateOrUpdateInvoiceExtendedReceiver(IRequestContext requestContext,BitArray usedFields,RC_466f18b870f78193989904128fc2d15c inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateInvoiceExtendedReceiver", "647c756a-a8b9-4138-8f1a-99962cb77078.#CreateOrUpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateInvoiceExtendedReceiver", "647c756a-a8b9-4138-8f1a-99962cb77078.#CreateOrUpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord ssENInvoiceExtendedReceiver = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(5,true);
}
string updateSet = "UPDATE " + ENInvoiceExtendedReceiverEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedReceiver, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedReceiverAttributeKeys.@RFC, "rfc") ?? "rfc") + " = @ssRFC"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedReceiver, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedReceiverAttributeKeys.@Nombre, "nombre") ?? "nombre") + " = @ssNombre"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedReceiver, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedReceiverAttributeKeys.@RegimenFiscal, "regimenfiscal") ?? "regimenfiscal") + " = @ssRegimenFiscal"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedReceiver, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedReceiverAttributeKeys.@CodigoPostal, "codigopostal") ?? "codigopostal") + " = @ssCodigoPostal"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedReceiver, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedReceiverAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENInvoiceExendedReceiver_ssId_InvoiceExtendedReceiver";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedReceiver, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedReceiverAttributeKeys.@RFC, "rfc") ?? "rfc") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedReceiver, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedReceiverAttributeKeys.@RFC, "rfc") ?? "rfc") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssRFC", DbType.String, ssENInvoiceExtendedReceiver.ssRFC);
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssNombre", DbType.String, ssENInvoiceExtendedReceiver.ssNombre);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssRegimenFiscal", DbType.String, ssENInvoiceExtendedReceiver.ssRegimenFiscal);
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssCodigoPostal", DbType.String, ssENInvoiceExtendedReceiver.ssCodigoPostal);
}
sqlCmd.CreateParameter("@idparam_ssENInvoiceExendedReceiver_ssId_InvoiceExtendedReceiver", DbType.Int64, ssENInvoiceExtendedReceiver.ssId);
int counter = 0;
if(ssENInvoiceExtendedReceiver.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateInvoiceExtendedReceiver (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENInvoiceExtendedReceiverEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedReceiver, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedReceiverAttributeKeys.@Id, "id") ?? "id") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedReceiver, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedReceiverAttributeKeys.@RFC, "rfc") ?? "rfc") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedReceiver, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedReceiverAttributeKeys.@Nombre, "nombre") ?? "nombre") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedReceiver, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedReceiverAttributeKeys.@RegimenFiscal, "regimenfiscal") ?? "regimenfiscal") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedReceiver, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedReceiverAttributeKeys.@CodigoPostal, "codigopostal") ?? "codigopostal") + "" +
" ) VALUES (" +
" @ssId" +
", @ssRFC" +
", @ssNombre" +
", @ssRegimenFiscal" +
", @ssCodigoPostal" +
" )";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssId", DbType.Int64, ssENInvoiceExtendedReceiver.ssId);
insertSqlCmd.CreateParameter("@ssRFC", DbType.String, ssENInvoiceExtendedReceiver.ssRFC);
insertSqlCmd.CreateParameter("@ssNombre", DbType.String, ssENInvoiceExtendedReceiver.ssNombre);
insertSqlCmd.CreateParameter("@ssRegimenFiscal", DbType.String, ssENInvoiceExtendedReceiver.ssRegimenFiscal);
insertSqlCmd.CreateParameter("@ssCodigoPostal", DbType.String, ssENInvoiceExtendedReceiver.ssCodigoPostal);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateInvoiceExtendedReceiver", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
outParamId = ssENInvoiceExtendedReceiver.ssId;
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENInvoiceExtendedReceiver.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeInvoiceExtendedReceiver
/// </summary>

public static async Task CreateOrUpdateSomeInvoiceExtendedReceiver(IRequestContext requestContext,RL_1c4a39fc53e61bce46c269ec1ce49b95 inParamSourceList,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateSomeInvoiceExtendedReceiver", "647c756a-a8b9-4138-8f1a-99962cb77078.#CreateOrUpdateAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeInvoiceExtendedReceiver", "647c756a-a8b9-4138-8f1a-99962cb77078.#CreateOrUpdateAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
string entityTableName = ENInvoiceExtendedReceiverEntity.LocalViewName(null);
string insertSql = "INSERT INTO " + entityTableName + " (" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedReceiver, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedReceiverAttributeKeys.@Id, "id") ?? "id") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedReceiver, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedReceiverAttributeKeys.@RFC, "rfc") ?? "rfc") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedReceiver, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedReceiverAttributeKeys.@Nombre, "nombre") ?? "nombre") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedReceiver, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedReceiverAttributeKeys.@RegimenFiscal, "regimenfiscal") ?? "regimenfiscal") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedReceiver, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedReceiverAttributeKeys.@CodigoPostal, "codigopostal") ?? "codigopostal") + ") VALUES ( unnest(@ssId),  unnest(@ssRFC),  unnest(@ssNombre),  unnest(@ssRegimenFiscal),  unnest(@ssCodigoPostal)) ON CONFLICT(" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedReceiver, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedReceiverAttributeKeys.@Id, "id") ?? "id") + ") do update set " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedReceiver, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedReceiverAttributeKeys.@RFC, "rfc") ?? "rfc") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedReceiver, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedReceiverAttributeKeys.@RFC, "rfc") ?? "rfc") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedReceiver, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedReceiverAttributeKeys.@Nombre, "nombre") ?? "nombre") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedReceiver, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedReceiverAttributeKeys.@Nombre, "nombre") ?? "nombre") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedReceiver, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedReceiverAttributeKeys.@RegimenFiscal, "regimenfiscal") ?? "regimenfiscal") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedReceiver, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedReceiverAttributeKeys.@RegimenFiscal, "regimenfiscal") ?? "regimenfiscal") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedReceiver, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedReceiverAttributeKeys.@CodigoPostal, "codigopostal") ?? "codigopostal") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedReceiver, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedReceiverAttributeKeys.@CodigoPostal, "codigopostal") ?? "codigopostal") + " ";
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
var record = ((RC_466f18b870f78193989904128fc2d15c)inParamSourceList.Current).ssENInvoiceExtendedReceiver;
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
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeInvoiceExtendedReceiver (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteInvoiceExtendedReceiver
/// </summary>

public static async Task DeleteInvoiceExtendedReceiver(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteInvoiceExtendedReceiver", "647c756a-a8b9-4138-8f1a-99962cb77078.#DeleteEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteInvoiceExtendedReceiver", "647c756a-a8b9-4138-8f1a-99962cb77078.#DeleteEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENInvoiceExtendedReceiverEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedReceiver, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedReceiverAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteInvoiceExtendedReceiver", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllInvoiceExtendedReceiver
/// </summary>

public static async Task DeleteAllInvoiceExtendedReceiver(IRequestContext requestContext,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteAllInvoiceExtendedReceiver", "647c756a-a8b9-4138-8f1a-99962cb77078.#DeleteAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllInvoiceExtendedReceiver", "647c756a-a8b9-4138-8f1a-99962cb77078.#DeleteAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENInvoiceExtendedReceiverEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteInvoiceExtendedReceiver", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetInvoiceExtendedReceiver
/// </summary>

public static async Task<RC_466f18b870f78193989904128fc2d15c> GetInvoiceExtendedReceiver(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_466f18b870f78193989904128fc2d15c outParamRecord = default;
outParamRecord = new RC_466f18b870f78193989904128fc2d15c();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetInvoiceExtendedReceiver", "647c756a-a8b9-4138-8f1a-99962cb77078.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetInvoiceExtendedReceiver", "647c756a-a8b9-4138-8f1a-99962cb77078.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedReceiver, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedReceiverAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedReceiver, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedReceiverAttributeKeys.@RFC, "rfc") ?? "rfc", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedReceiver, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedReceiverAttributeKeys.@Nombre, "nombre") ?? "nombre", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedReceiver, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedReceiverAttributeKeys.@RegimenFiscal, "regimenfiscal") ?? "regimenfiscal", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedReceiver, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedReceiverAttributeKeys.@CodigoPostal, "codigopostal") ?? "codigopostal", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
" FROM " + ENInvoiceExtendedReceiverEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedReceiver, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedReceiverAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetInvoiceExtendedReceiver", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(5,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENInvoiceExtendedReceiverEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetInvoiceExtendedReceiverForUpdate
/// </summary>

public static async Task<RC_466f18b870f78193989904128fc2d15c> GetInvoiceExtendedReceiverForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_466f18b870f78193989904128fc2d15c outParamRecord = default;
outParamRecord = new RC_466f18b870f78193989904128fc2d15c();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetInvoiceExtendedReceiverForUpdate", "647c756a-a8b9-4138-8f1a-99962cb77078.#GetEntityForUpdate");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetInvoiceExtendedReceiverForUpdate", "647c756a-a8b9-4138-8f1a-99962cb77078.#GetEntityForUpdate", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedReceiver, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedReceiverAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedReceiver, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedReceiverAttributeKeys.@RFC, "rfc") ?? "rfc", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedReceiver, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedReceiverAttributeKeys.@Nombre, "nombre") ?? "nombre", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedReceiver, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedReceiverAttributeKeys.@RegimenFiscal, "regimenfiscal") ?? "regimenfiscal", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedReceiver, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedReceiverAttributeKeys.@CodigoPostal, "codigopostal") ?? "codigopostal", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
" FROM " + ENInvoiceExtendedReceiverEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedReceiver, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedReceiverAttributeKeys.@Id, "id") ?? "id") + " = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetInvoiceExtendedReceiverForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(5,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENInvoiceExtendedReceiverEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateInvoiceExtendedReceiver
/// </summary>

public static async Task UpdateInvoiceExtendedReceiver(IRequestContext requestContext,BitArray usedFields,RC_466f18b870f78193989904128fc2d15c inParamSource,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("UpdateInvoiceExtendedReceiver", "647c756a-a8b9-4138-8f1a-99962cb77078.#UpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateInvoiceExtendedReceiver", "647c756a-a8b9-4138-8f1a-99962cb77078.#UpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord ssENInvoiceExtendedReceiver = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(5,true);
}
string updateSet = "UPDATE " + ENInvoiceExtendedReceiverEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedReceiver, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedReceiverAttributeKeys.@RFC, "rfc") ?? "rfc") + " = @ssRFC"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedReceiver, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedReceiverAttributeKeys.@Nombre, "nombre") ?? "nombre") + " = @ssNombre"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedReceiver, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedReceiverAttributeKeys.@RegimenFiscal, "regimenfiscal") ?? "regimenfiscal") + " = @ssRegimenFiscal"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedReceiver, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedReceiverAttributeKeys.@CodigoPostal, "codigopostal") ?? "codigopostal") + " = @ssCodigoPostal"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedReceiver, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedReceiverAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENInvoiceExendedReceiver_ssId_InvoiceExtendedReceiver";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedReceiver, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedReceiverAttributeKeys.@RFC, "rfc") ?? "rfc") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedReceiver, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedReceiverAttributeKeys.@RFC, "rfc") ?? "rfc") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssRFC", DbType.String, ssENInvoiceExtendedReceiver.ssRFC);
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssNombre", DbType.String, ssENInvoiceExtendedReceiver.ssNombre);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssRegimenFiscal", DbType.String, ssENInvoiceExtendedReceiver.ssRegimenFiscal);
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssCodigoPostal", DbType.String, ssENInvoiceExtendedReceiver.ssCodigoPostal);
}
sqlCmd.CreateParameter("@idparam_ssENInvoiceExendedReceiver_ssId_InvoiceExtendedReceiver", DbType.Int64, ssENInvoiceExtendedReceiver.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateInvoiceExtendedReceiver", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("InvoiceExtendedReceiver", ssENInvoiceExtendedReceiver.ssId.ToString()); }}
}
return;
}

}
}
