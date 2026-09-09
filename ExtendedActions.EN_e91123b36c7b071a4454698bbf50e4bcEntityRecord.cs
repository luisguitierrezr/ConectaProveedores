using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateInvoiceAccountingProcessResponse
/// </summary>

public static async Task<long> CreateInvoiceAccountingProcessResponse(IRequestContext requestContext,RC_8d2c7f494e763d54feb138104c341adb inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateInvoiceAccountingProcessResponse", "538e17ca-1754-48c0-9213-3aad1099e5ce.#CreateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateInvoiceAccountingProcessResponse", "538e17ca-1754-48c0-9213-3aad1099e5ce.#CreateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_e91123b36c7b071a4454698bbf50e4bcEntityRecord ssENInvoiceAccountingProcessResponse = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENInvoiceAccountingProcessResponseEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessResponse, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessResponseAttributeKeys.@InvoiceAccountingProcessId, "invoiceaccountingprocessid") ?? "invoiceaccountingprocessid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessResponse, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessResponseAttributeKeys.@IsSuccess, "issuccess") ?? "issuccess") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessResponse, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessResponseAttributeKeys.@ID_POLIZA, "id_poliza") ?? "id_poliza") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessResponse, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessResponseAttributeKeys.@TEXTO, "texto") ?? "texto") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessResponse, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessResponseAttributeKeys.@PO_RESULTADO, "po_resultado") ?? "po_resultado") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessResponse, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessResponseAttributeKeys.@CODIGO, "codigo") ?? "codigo") + "" +
" ) VALUES (" +
" @ssInvoiceAccountingProcessId" +
", @ssIsSuccess" +
", @ssID_POLIZA" +
", @ssTEXTO" +
", @ssPO_RESULTADO" +
", @ssCODIGO" +
" )";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssInvoiceAccountingProcessId", DbType.Int64, ssENInvoiceAccountingProcessResponse.ssInvoiceAccountingProcessId);
insertSqlCmd.CreateParameter("@ssIsSuccess", DbType.Boolean, ssENInvoiceAccountingProcessResponse.ssIsSuccess);
insertSqlCmd.CreateParameter("@ssID_POLIZA", DbType.String, ssENInvoiceAccountingProcessResponse.ssID_POLIZA);
insertSqlCmd.CreateParameter("@ssTEXTO", DbType.String, ssENInvoiceAccountingProcessResponse.ssTEXTO);
insertSqlCmd.CreateParameter("@ssPO_RESULTADO", DbType.String, ssENInvoiceAccountingProcessResponse.ssPO_RESULTADO);
insertSqlCmd.CreateParameter("@ssCODIGO", DbType.String, ssENInvoiceAccountingProcessResponse.ssCODIGO);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateInvoiceAccountingProcessResponse", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
outParamId = ssENInvoiceAccountingProcessResponse.ssInvoiceAccountingProcessId;
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateInvoiceAccountingProcessResponse
/// </summary>

public static async Task<long> CreateOrUpdateInvoiceAccountingProcessResponse(IRequestContext requestContext,BitArray usedFields,RC_8d2c7f494e763d54feb138104c341adb inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateInvoiceAccountingProcessResponse", "538e17ca-1754-48c0-9213-3aad1099e5ce.#CreateOrUpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateInvoiceAccountingProcessResponse", "538e17ca-1754-48c0-9213-3aad1099e5ce.#CreateOrUpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_e91123b36c7b071a4454698bbf50e4bcEntityRecord ssENInvoiceAccountingProcessResponse = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(6,true);
}
string updateSet = "UPDATE " + ENInvoiceAccountingProcessResponseEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessResponse, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessResponseAttributeKeys.@IsSuccess, "issuccess") ?? "issuccess") + " = @ssIsSuccess"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessResponse, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessResponseAttributeKeys.@ID_POLIZA, "id_poliza") ?? "id_poliza") + " = @ssID_POLIZA"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessResponse, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessResponseAttributeKeys.@TEXTO, "texto") ?? "texto") + " = @ssTEXTO"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessResponse, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessResponseAttributeKeys.@PO_RESULTADO, "po_resultado") ?? "po_resultado") + " = @ssPO_RESULTADO"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessResponse, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessResponseAttributeKeys.@CODIGO, "codigo") ?? "codigo") + " = @ssCODIGO"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessResponse, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessResponseAttributeKeys.@InvoiceAccountingProcessId, "invoiceaccountingprocessid") ?? "invoiceaccountingprocessid") + " = @idparam_ssENInvoicessResponse_ssInvoiocessId_InvoiceAcsResponse";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessResponse, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessResponseAttributeKeys.@IsSuccess, "issuccess") ?? "issuccess") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessResponse, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessResponseAttributeKeys.@IsSuccess, "issuccess") ?? "issuccess") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssIsSuccess", DbType.Boolean, ssENInvoiceAccountingProcessResponse.ssIsSuccess);
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssID_POLIZA", DbType.String, ssENInvoiceAccountingProcessResponse.ssID_POLIZA);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssTEXTO", DbType.String, ssENInvoiceAccountingProcessResponse.ssTEXTO);
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssPO_RESULTADO", DbType.String, ssENInvoiceAccountingProcessResponse.ssPO_RESULTADO);
}
if(usedFields[5]) {
sqlCmd.CreateParameter("@ssCODIGO", DbType.String, ssENInvoiceAccountingProcessResponse.ssCODIGO);
}
sqlCmd.CreateParameter("@idparam_ssENInvoicessResponse_ssInvoiocessId_InvoiceAcsResponse", DbType.Int64, ssENInvoiceAccountingProcessResponse.ssInvoiceAccountingProcessId);
int counter = 0;
if(ssENInvoiceAccountingProcessResponse.ssInvoiceAccountingProcessId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateInvoiceAccountingProcessResponse (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENInvoiceAccountingProcessResponseEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessResponse, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessResponseAttributeKeys.@InvoiceAccountingProcessId, "invoiceaccountingprocessid") ?? "invoiceaccountingprocessid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessResponse, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessResponseAttributeKeys.@IsSuccess, "issuccess") ?? "issuccess") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessResponse, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessResponseAttributeKeys.@ID_POLIZA, "id_poliza") ?? "id_poliza") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessResponse, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessResponseAttributeKeys.@TEXTO, "texto") ?? "texto") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessResponse, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessResponseAttributeKeys.@PO_RESULTADO, "po_resultado") ?? "po_resultado") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessResponse, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessResponseAttributeKeys.@CODIGO, "codigo") ?? "codigo") + "" +
" ) VALUES (" +
" @ssInvoiceAccountingProcessId" +
", @ssIsSuccess" +
", @ssID_POLIZA" +
", @ssTEXTO" +
", @ssPO_RESULTADO" +
", @ssCODIGO" +
" )";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssInvoiceAccountingProcessId", DbType.Int64, ssENInvoiceAccountingProcessResponse.ssInvoiceAccountingProcessId);
insertSqlCmd.CreateParameter("@ssIsSuccess", DbType.Boolean, ssENInvoiceAccountingProcessResponse.ssIsSuccess);
insertSqlCmd.CreateParameter("@ssID_POLIZA", DbType.String, ssENInvoiceAccountingProcessResponse.ssID_POLIZA);
insertSqlCmd.CreateParameter("@ssTEXTO", DbType.String, ssENInvoiceAccountingProcessResponse.ssTEXTO);
insertSqlCmd.CreateParameter("@ssPO_RESULTADO", DbType.String, ssENInvoiceAccountingProcessResponse.ssPO_RESULTADO);
insertSqlCmd.CreateParameter("@ssCODIGO", DbType.String, ssENInvoiceAccountingProcessResponse.ssCODIGO);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateInvoiceAccountingProcessResponse", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
outParamId = ssENInvoiceAccountingProcessResponse.ssInvoiceAccountingProcessId;
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENInvoiceAccountingProcessResponse.ssInvoiceAccountingProcessId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeInvoiceAccountingProcessResponse
/// </summary>

public static async Task CreateOrUpdateSomeInvoiceAccountingProcessResponse(IRequestContext requestContext,RL_c523bce2fb9ae799ea203ce8adb1c163 inParamSourceList,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateSomeInvoiceAccountingProcessResponse", "538e17ca-1754-48c0-9213-3aad1099e5ce.#CreateOrUpdateAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeInvoiceAccountingProcessResponse", "538e17ca-1754-48c0-9213-3aad1099e5ce.#CreateOrUpdateAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
string entityTableName = ENInvoiceAccountingProcessResponseEntity.LocalViewName(null);
string insertSql = "INSERT INTO " + entityTableName + " (" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessResponse, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessResponseAttributeKeys.@InvoiceAccountingProcessId, "invoiceaccountingprocessid") ?? "invoiceaccountingprocessid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessResponse, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessResponseAttributeKeys.@IsSuccess, "issuccess") ?? "issuccess") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessResponse, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessResponseAttributeKeys.@ID_POLIZA, "id_poliza") ?? "id_poliza") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessResponse, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessResponseAttributeKeys.@TEXTO, "texto") ?? "texto") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessResponse, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessResponseAttributeKeys.@PO_RESULTADO, "po_resultado") ?? "po_resultado") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessResponse, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessResponseAttributeKeys.@CODIGO, "codigo") ?? "codigo") + ") VALUES ( unnest(@ssInvoiceAccountingProcessId),  unnest(@ssIsSuccess),  unnest(@ssID_POLIZA),  unnest(@ssTEXTO),  unnest(@ssPO_RESULTADO),  unnest(@ssCODIGO)) ON CONFLICT(" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessResponse, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessResponseAttributeKeys.@InvoiceAccountingProcessId, "invoiceaccountingprocessid") ?? "invoiceaccountingprocessid") + ") do update set " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessResponse, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessResponseAttributeKeys.@IsSuccess, "issuccess") ?? "issuccess") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessResponse, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessResponseAttributeKeys.@IsSuccess, "issuccess") ?? "issuccess") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessResponse, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessResponseAttributeKeys.@ID_POLIZA, "id_poliza") ?? "id_poliza") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessResponse, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessResponseAttributeKeys.@ID_POLIZA, "id_poliza") ?? "id_poliza") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessResponse, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessResponseAttributeKeys.@TEXTO, "texto") ?? "texto") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessResponse, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessResponseAttributeKeys.@TEXTO, "texto") ?? "texto") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessResponse, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessResponseAttributeKeys.@PO_RESULTADO, "po_resultado") ?? "po_resultado") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessResponse, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessResponseAttributeKeys.@PO_RESULTADO, "po_resultado") ?? "po_resultado") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessResponse, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessResponseAttributeKeys.@CODIGO, "codigo") ?? "codigo") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessResponse, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessResponseAttributeKeys.@CODIGO, "codigo") ?? "codigo") + " ";
insertSql += "";


List<object> insertInvoiceAccountingProcessIdList = new List<object>();
List<bool> insertIsSuccessList = new List<bool>();
List<string> insertID_POLIZAList = new List<string>();
List<string> insertTEXTOList = new List<string>();
List<string> insertPO_RESULTADOList = new List<string>();
List<string> insertCODIGOList = new List<string>();


var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_8d2c7f494e763d54feb138104c341adb)inParamSourceList.Current).ssENInvoiceAccountingProcessResponse;
insertInvoiceAccountingProcessIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssInvoiceAccountingProcessId));
insertIsSuccessList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsSuccess));
insertID_POLIZAList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssID_POLIZA));
insertTEXTOList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssTEXTO));
insertPO_RESULTADOList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssPO_RESULTADO));
insertCODIGOList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssCODIGO));
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertInvoiceAccountingProcessIdList.IsEmpty() || !insertIsSuccessList.IsEmpty() || !insertID_POLIZAList.IsEmpty() || !insertTEXTOList.IsEmpty() || !insertPO_RESULTADOList.IsEmpty() || !insertCODIGOList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssInvoiceAccountingProcessId",DbType.Int64,insertInvoiceAccountingProcessIdList);
executionService.CreateParameter(insertSqlCmd,"@ssIsSuccess",DbType.Boolean,insertIsSuccessList);
executionService.CreateParameter(insertSqlCmd,"@ssID_POLIZA",DbType.String,insertID_POLIZAList);
executionService.CreateParameter(insertSqlCmd,"@ssTEXTO",DbType.String,insertTEXTOList);
executionService.CreateParameter(insertSqlCmd,"@ssPO_RESULTADO",DbType.String,insertPO_RESULTADOList);
executionService.CreateParameter(insertSqlCmd,"@ssCODIGO",DbType.String,insertCODIGOList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeInvoiceAccountingProcessResponse (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteInvoiceAccountingProcessResponse
/// </summary>

public static async Task DeleteInvoiceAccountingProcessResponse(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteInvoiceAccountingProcessResponse", "538e17ca-1754-48c0-9213-3aad1099e5ce.#DeleteEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteInvoiceAccountingProcessResponse", "538e17ca-1754-48c0-9213-3aad1099e5ce.#DeleteEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENInvoiceAccountingProcessResponseEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessResponse, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessResponseAttributeKeys.@InvoiceAccountingProcessId, "invoiceaccountingprocessid") ?? "invoiceaccountingprocessid") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteInvoiceAccountingProcessResponse", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllInvoiceAccountingProcessResponse
/// </summary>

public static async Task DeleteAllInvoiceAccountingProcessResponse(IRequestContext requestContext,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteAllInvoiceAccountingProcessResponse", "538e17ca-1754-48c0-9213-3aad1099e5ce.#DeleteAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllInvoiceAccountingProcessResponse", "538e17ca-1754-48c0-9213-3aad1099e5ce.#DeleteAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENInvoiceAccountingProcessResponseEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteInvoiceAccountingProcessResponse", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetInvoiceAccountingProcessResponse
/// </summary>

public static async Task<RC_8d2c7f494e763d54feb138104c341adb> GetInvoiceAccountingProcessResponse(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_8d2c7f494e763d54feb138104c341adb outParamRecord = default;
outParamRecord = new RC_8d2c7f494e763d54feb138104c341adb();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetInvoiceAccountingProcessResponse", "538e17ca-1754-48c0-9213-3aad1099e5ce.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetInvoiceAccountingProcessResponse", "538e17ca-1754-48c0-9213-3aad1099e5ce.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessResponse, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessResponseAttributeKeys.@InvoiceAccountingProcessId, "invoiceaccountingprocessid") ?? "invoiceaccountingprocessid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessResponse, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessResponseAttributeKeys.@IsSuccess, "issuccess") ?? "issuccess", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessResponse, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessResponseAttributeKeys.@ID_POLIZA, "id_poliza") ?? "id_poliza", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessResponse, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessResponseAttributeKeys.@TEXTO, "texto") ?? "texto", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessResponse, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessResponseAttributeKeys.@PO_RESULTADO, "po_resultado") ?? "po_resultado", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessResponse, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessResponseAttributeKeys.@CODIGO, "codigo") ?? "codigo", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
" FROM " + ENInvoiceAccountingProcessResponseEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessResponse, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessResponseAttributeKeys.@InvoiceAccountingProcessId, "invoiceaccountingprocessid") ?? "invoiceaccountingprocessid") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetInvoiceAccountingProcessResponse", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(6,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENInvoiceAccountingProcessResponseEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetInvoiceAccountingProcessResponseForUpdate
/// </summary>

public static async Task<RC_8d2c7f494e763d54feb138104c341adb> GetInvoiceAccountingProcessResponseForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_8d2c7f494e763d54feb138104c341adb outParamRecord = default;
outParamRecord = new RC_8d2c7f494e763d54feb138104c341adb();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetInvoiceAccountingProcessResponseForUpdate", "538e17ca-1754-48c0-9213-3aad1099e5ce.#GetEntityForUpdate");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetInvoiceAccountingProcessResponseForUpdate", "538e17ca-1754-48c0-9213-3aad1099e5ce.#GetEntityForUpdate", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessResponse, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessResponseAttributeKeys.@InvoiceAccountingProcessId, "invoiceaccountingprocessid") ?? "invoiceaccountingprocessid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessResponse, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessResponseAttributeKeys.@IsSuccess, "issuccess") ?? "issuccess", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessResponse, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessResponseAttributeKeys.@ID_POLIZA, "id_poliza") ?? "id_poliza", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessResponse, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessResponseAttributeKeys.@TEXTO, "texto") ?? "texto", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessResponse, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessResponseAttributeKeys.@PO_RESULTADO, "po_resultado") ?? "po_resultado", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessResponse, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessResponseAttributeKeys.@CODIGO, "codigo") ?? "codigo", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
" FROM " + ENInvoiceAccountingProcessResponseEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessResponse, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessResponseAttributeKeys.@InvoiceAccountingProcessId, "invoiceaccountingprocessid") ?? "invoiceaccountingprocessid") + " = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetInvoiceAccountingProcessResponseForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(6,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENInvoiceAccountingProcessResponseEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateInvoiceAccountingProcessResponse
/// </summary>

public static async Task UpdateInvoiceAccountingProcessResponse(IRequestContext requestContext,BitArray usedFields,RC_8d2c7f494e763d54feb138104c341adb inParamSource,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("UpdateInvoiceAccountingProcessResponse", "538e17ca-1754-48c0-9213-3aad1099e5ce.#UpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateInvoiceAccountingProcessResponse", "538e17ca-1754-48c0-9213-3aad1099e5ce.#UpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_e91123b36c7b071a4454698bbf50e4bcEntityRecord ssENInvoiceAccountingProcessResponse = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(6,true);
}
string updateSet = "UPDATE " + ENInvoiceAccountingProcessResponseEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessResponse, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessResponseAttributeKeys.@IsSuccess, "issuccess") ?? "issuccess") + " = @ssIsSuccess"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessResponse, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessResponseAttributeKeys.@ID_POLIZA, "id_poliza") ?? "id_poliza") + " = @ssID_POLIZA"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessResponse, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessResponseAttributeKeys.@TEXTO, "texto") ?? "texto") + " = @ssTEXTO"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessResponse, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessResponseAttributeKeys.@PO_RESULTADO, "po_resultado") ?? "po_resultado") + " = @ssPO_RESULTADO"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessResponse, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessResponseAttributeKeys.@CODIGO, "codigo") ?? "codigo") + " = @ssCODIGO"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessResponse, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessResponseAttributeKeys.@InvoiceAccountingProcessId, "invoiceaccountingprocessid") ?? "invoiceaccountingprocessid") + " = @idparam_ssENInvoicessResponse_ssInvoiocessId_InvoiceAcsResponse";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessResponse, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessResponseAttributeKeys.@IsSuccess, "issuccess") ?? "issuccess") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessResponse, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessResponseAttributeKeys.@IsSuccess, "issuccess") ?? "issuccess") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssIsSuccess", DbType.Boolean, ssENInvoiceAccountingProcessResponse.ssIsSuccess);
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssID_POLIZA", DbType.String, ssENInvoiceAccountingProcessResponse.ssID_POLIZA);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssTEXTO", DbType.String, ssENInvoiceAccountingProcessResponse.ssTEXTO);
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssPO_RESULTADO", DbType.String, ssENInvoiceAccountingProcessResponse.ssPO_RESULTADO);
}
if(usedFields[5]) {
sqlCmd.CreateParameter("@ssCODIGO", DbType.String, ssENInvoiceAccountingProcessResponse.ssCODIGO);
}
sqlCmd.CreateParameter("@idparam_ssENInvoicessResponse_ssInvoiocessId_InvoiceAcsResponse", DbType.Int64, ssENInvoiceAccountingProcessResponse.ssInvoiceAccountingProcessId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateInvoiceAccountingProcessResponse", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("InvoiceAccountingProcessResponse", ssENInvoiceAccountingProcessResponse.ssInvoiceAccountingProcessId.ToString()); }}
}
return;
}

}
}
