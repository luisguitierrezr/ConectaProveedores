using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateInvoicePoliza
/// </summary>

public static async Task<long> CreateInvoicePoliza(IRequestContext requestContext,RC_14fd6714905cc16780383cc2da86ee0d inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateInvoicePoliza", "d366ba16-4999-4864-8beb-319281c4d1d5.#CreateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateInvoicePoliza", "d366ba16-4999-4864-8beb-319281c4d1d5.#CreateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_40f7c2dd79fcf6f1dd71369cb12f9d79EntityRecord ssENInvoicePoliza = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENInvoicePolizaEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@Id, "id") ?? "id") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@PolizaId, "polizaid") ?? "polizaid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@PolizaSAP, "polizasap") ?? "polizasap") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@SAPObject, "sapobject") ?? "sapobject") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@Sent, "sent") ?? "sent") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@SentWhen, "sentwhen") ?? "sentwhen") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@WithError, "witherror") ?? "witherror") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@Error_Message, "error_message") ?? "error_message") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + "" +
" ) VALUES (" +
" @ssId" +
", @ssPolizaId" +
", @ssPolizaSAP" +
", @ssSAPObject" +
", @ssSent" +
", @ssSentWhen" +
", @ssWithError" +
", @ssError_Message" +
", @ssCreatedOn" +
" )";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssId", DbType.Int64, ssENInvoicePoliza.ssId);
insertSqlCmd.CreateParameter("@ssPolizaId", DbType.String, ssENInvoicePoliza.ssPolizaId);
insertSqlCmd.CreateParameter("@ssPolizaSAP", DbType.String, ssENInvoicePoliza.ssPolizaSAP);
insertSqlCmd.CreateParameter("@ssSAPObject", DbType.String, ssENInvoicePoliza.ssSAPObject);
insertSqlCmd.CreateParameter("@ssSent", DbType.Boolean, ssENInvoicePoliza.ssSent);
insertSqlCmd.CreateParameter("@ssSentWhen", DbType.DateTime, ssENInvoicePoliza.ssSentWhen);
insertSqlCmd.CreateParameter("@ssWithError", DbType.Boolean, ssENInvoicePoliza.ssWithError);
insertSqlCmd.CreateParameter("@ssError_Message", DbType.String, ssENInvoicePoliza.ssError_Message);
insertSqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENInvoicePoliza.ssCreatedOn);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateInvoicePoliza", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
outParamId = ssENInvoicePoliza.ssId;
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateInvoicePoliza
/// </summary>

public static async Task<long> CreateOrUpdateInvoicePoliza(IRequestContext requestContext,BitArray usedFields,RC_14fd6714905cc16780383cc2da86ee0d inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateInvoicePoliza", "d366ba16-4999-4864-8beb-319281c4d1d5.#CreateOrUpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateInvoicePoliza", "d366ba16-4999-4864-8beb-319281c4d1d5.#CreateOrUpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_40f7c2dd79fcf6f1dd71369cb12f9d79EntityRecord ssENInvoicePoliza = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(9,true);
}
string updateSet = "UPDATE " + ENInvoicePolizaEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@PolizaId, "polizaid") ?? "polizaid") + " = @ssPolizaId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@PolizaSAP, "polizasap") ?? "polizasap") + " = @ssPolizaSAP"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@SAPObject, "sapobject") ?? "sapobject") + " = @ssSAPObject"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@Sent, "sent") ?? "sent") + " = @ssSent"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@SentWhen, "sentwhen") ?? "sentwhen") + " = @ssSentWhen"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@WithError, "witherror") ?? "witherror") + " = @ssWithError"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@Error_Message, "error_message") ?? "error_message") + " = @ssError_Message"): parameters);
parameters = (usedFields[8] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = @ssCreatedOn"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENInvoicePoliza_ssId_InvoicePoliza";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@WithError, "witherror") ?? "witherror") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@WithError, "witherror") ?? "witherror") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssPolizaId", DbType.String, ssENInvoicePoliza.ssPolizaId);
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssPolizaSAP", DbType.String, ssENInvoicePoliza.ssPolizaSAP);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssSAPObject", DbType.String, ssENInvoicePoliza.ssSAPObject);
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssSent", DbType.Boolean, ssENInvoicePoliza.ssSent);
}
if(usedFields[5]) {
sqlCmd.CreateParameter("@ssSentWhen", DbType.DateTime, ssENInvoicePoliza.ssSentWhen);
}
if(usedFields[6]) {
sqlCmd.CreateParameter("@ssWithError", DbType.Boolean, ssENInvoicePoliza.ssWithError);
}
if(usedFields[7]) {
sqlCmd.CreateParameter("@ssError_Message", DbType.String, ssENInvoicePoliza.ssError_Message);
}
if(usedFields[8]) {
sqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENInvoicePoliza.ssCreatedOn);
}
sqlCmd.CreateParameter("@idparam_ssENInvoicePoliza_ssId_InvoicePoliza", DbType.Int64, ssENInvoicePoliza.ssId);
int counter = 0;
if(ssENInvoicePoliza.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateInvoicePoliza (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENInvoicePolizaEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@Id, "id") ?? "id") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@PolizaId, "polizaid") ?? "polizaid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@PolizaSAP, "polizasap") ?? "polizasap") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@SAPObject, "sapobject") ?? "sapobject") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@Sent, "sent") ?? "sent") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@SentWhen, "sentwhen") ?? "sentwhen") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@WithError, "witherror") ?? "witherror") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@Error_Message, "error_message") ?? "error_message") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + "" +
" ) VALUES (" +
" @ssId" +
", @ssPolizaId" +
", @ssPolizaSAP" +
", @ssSAPObject" +
", @ssSent" +
", @ssSentWhen" +
", @ssWithError" +
", @ssError_Message" +
", @ssCreatedOn" +
" )";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssId", DbType.Int64, ssENInvoicePoliza.ssId);
insertSqlCmd.CreateParameter("@ssPolizaId", DbType.String, ssENInvoicePoliza.ssPolizaId);
insertSqlCmd.CreateParameter("@ssPolizaSAP", DbType.String, ssENInvoicePoliza.ssPolizaSAP);
insertSqlCmd.CreateParameter("@ssSAPObject", DbType.String, ssENInvoicePoliza.ssSAPObject);
insertSqlCmd.CreateParameter("@ssSent", DbType.Boolean, ssENInvoicePoliza.ssSent);
insertSqlCmd.CreateParameter("@ssSentWhen", DbType.DateTime, ssENInvoicePoliza.ssSentWhen);
insertSqlCmd.CreateParameter("@ssWithError", DbType.Boolean, ssENInvoicePoliza.ssWithError);
insertSqlCmd.CreateParameter("@ssError_Message", DbType.String, ssENInvoicePoliza.ssError_Message);
insertSqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENInvoicePoliza.ssCreatedOn);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateInvoicePoliza", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
outParamId = ssENInvoicePoliza.ssId;
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENInvoicePoliza.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeInvoicePoliza
/// </summary>

public static async Task CreateOrUpdateSomeInvoicePoliza(IRequestContext requestContext,RL_9f2cc0799550a1f105537904fd426c3d inParamSourceList,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateSomeInvoicePoliza", "d366ba16-4999-4864-8beb-319281c4d1d5.#CreateOrUpdateAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeInvoicePoliza", "d366ba16-4999-4864-8beb-319281c4d1d5.#CreateOrUpdateAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
string entityTableName = ENInvoicePolizaEntity.LocalViewName(null);
string insertSql = "INSERT INTO " + entityTableName + " (" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@Id, "id") ?? "id") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@PolizaId, "polizaid") ?? "polizaid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@PolizaSAP, "polizasap") ?? "polizasap") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@SAPObject, "sapobject") ?? "sapobject") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@Sent, "sent") ?? "sent") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@SentWhen, "sentwhen") ?? "sentwhen") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@WithError, "witherror") ?? "witherror") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@Error_Message, "error_message") ?? "error_message") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + ") VALUES ( unnest(@ssId),  unnest(@ssPolizaId),  unnest(@ssPolizaSAP),  unnest(@ssSAPObject),  unnest(@ssSent),  unnest(@ssSentWhen),  unnest(@ssWithError),  unnest(@ssError_Message),  unnest(@ssCreatedOn)) ON CONFLICT(" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@Id, "id") ?? "id") + ") do update set " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@PolizaId, "polizaid") ?? "polizaid") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@PolizaId, "polizaid") ?? "polizaid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@PolizaSAP, "polizasap") ?? "polizasap") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@PolizaSAP, "polizasap") ?? "polizasap") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@SAPObject, "sapobject") ?? "sapobject") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@SAPObject, "sapobject") ?? "sapobject") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@Sent, "sent") ?? "sent") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@Sent, "sent") ?? "sent") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@SentWhen, "sentwhen") ?? "sentwhen") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@SentWhen, "sentwhen") ?? "sentwhen") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@WithError, "witherror") ?? "witherror") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@WithError, "witherror") ?? "witherror") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@Error_Message, "error_message") ?? "error_message") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@Error_Message, "error_message") ?? "error_message") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " ";
insertSql += "";


List<object> insertIdList = new List<object>();
List<string> insertPolizaIdList = new List<string>();
List<string> insertPolizaSAPList = new List<string>();
List<string> insertSAPObjectList = new List<string>();
List<bool> insertSentList = new List<bool>();
List<DateTime> insertSentWhenList = new List<DateTime>();
List<bool> insertWithErrorList = new List<bool>();
List<string> insertError_MessageList = new List<string>();
List<DateTime> insertCreatedOnList = new List<DateTime>();


var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_14fd6714905cc16780383cc2da86ee0d)inParamSourceList.Current).ssENInvoicePoliza;
insertIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
insertPolizaIdList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssPolizaId));
insertPolizaSAPList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssPolizaSAP));
insertSAPObjectList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssSAPObject));
insertSentList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssSent));
insertSentWhenList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssSentWhen));
insertWithErrorList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssWithError));
insertError_MessageList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssError_Message));
insertCreatedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssCreatedOn));
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertIdList.IsEmpty() || !insertPolizaIdList.IsEmpty() || !insertPolizaSAPList.IsEmpty() || !insertSAPObjectList.IsEmpty() || !insertSentList.IsEmpty() || !insertSentWhenList.IsEmpty() || !insertWithErrorList.IsEmpty() || !insertError_MessageList.IsEmpty() || !insertCreatedOnList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssId",DbType.Int64,insertIdList);
executionService.CreateParameter(insertSqlCmd,"@ssPolizaId",DbType.String,insertPolizaIdList);
executionService.CreateParameter(insertSqlCmd,"@ssPolizaSAP",DbType.String,insertPolizaSAPList);
executionService.CreateParameter(insertSqlCmd,"@ssSAPObject",DbType.String,insertSAPObjectList);
executionService.CreateParameter(insertSqlCmd,"@ssSent",DbType.Boolean,insertSentList);
executionService.CreateParameter(insertSqlCmd,"@ssSentWhen",DbType.DateTime,insertSentWhenList);
executionService.CreateParameter(insertSqlCmd,"@ssWithError",DbType.Boolean,insertWithErrorList);
executionService.CreateParameter(insertSqlCmd,"@ssError_Message",DbType.String,insertError_MessageList);
executionService.CreateParameter(insertSqlCmd,"@ssCreatedOn",DbType.DateTime,insertCreatedOnList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeInvoicePoliza (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteInvoicePoliza
/// </summary>

public static async Task DeleteInvoicePoliza(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteInvoicePoliza", "d366ba16-4999-4864-8beb-319281c4d1d5.#DeleteEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteInvoicePoliza", "d366ba16-4999-4864-8beb-319281c4d1d5.#DeleteEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENInvoicePolizaEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteInvoicePoliza", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllInvoicePoliza
/// </summary>

public static async Task DeleteAllInvoicePoliza(IRequestContext requestContext,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteAllInvoicePoliza", "d366ba16-4999-4864-8beb-319281c4d1d5.#DeleteAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllInvoicePoliza", "d366ba16-4999-4864-8beb-319281c4d1d5.#DeleteAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENInvoicePolizaEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteInvoicePoliza", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetInvoicePoliza
/// </summary>

public static async Task<RC_14fd6714905cc16780383cc2da86ee0d> GetInvoicePoliza(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_14fd6714905cc16780383cc2da86ee0d outParamRecord = default;
outParamRecord = new RC_14fd6714905cc16780383cc2da86ee0d();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetInvoicePoliza", "d366ba16-4999-4864-8beb-319281c4d1d5.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetInvoicePoliza", "d366ba16-4999-4864-8beb-319281c4d1d5.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@PolizaId, "polizaid") ?? "polizaid", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@PolizaSAP, "polizasap") ?? "polizasap", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@SAPObject, "sapobject") ?? "sapobject", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@Sent, "sent") ?? "sent", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@SentWhen, "sentwhen") ?? "sentwhen", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@WithError, "witherror") ?? "witherror", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@Error_Message, "error_message") ?? "error_message", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@CreatedOn, "createdon") ?? "createdon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
" FROM " + ENInvoicePolizaEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetInvoicePoliza", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(9,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENInvoicePolizaEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetInvoicePolizaForUpdate
/// </summary>

public static async Task<RC_14fd6714905cc16780383cc2da86ee0d> GetInvoicePolizaForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_14fd6714905cc16780383cc2da86ee0d outParamRecord = default;
outParamRecord = new RC_14fd6714905cc16780383cc2da86ee0d();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetInvoicePolizaForUpdate", "d366ba16-4999-4864-8beb-319281c4d1d5.#GetEntityForUpdate");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetInvoicePolizaForUpdate", "d366ba16-4999-4864-8beb-319281c4d1d5.#GetEntityForUpdate", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@PolizaId, "polizaid") ?? "polizaid", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@PolizaSAP, "polizasap") ?? "polizasap", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@SAPObject, "sapobject") ?? "sapobject", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@Sent, "sent") ?? "sent", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@SentWhen, "sentwhen") ?? "sentwhen", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@WithError, "witherror") ?? "witherror", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@Error_Message, "error_message") ?? "error_message", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@CreatedOn, "createdon") ?? "createdon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
" FROM " + ENInvoicePolizaEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@Id, "id") ?? "id") + " = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetInvoicePolizaForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(9,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENInvoicePolizaEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateInvoicePoliza
/// </summary>

public static async Task UpdateInvoicePoliza(IRequestContext requestContext,BitArray usedFields,RC_14fd6714905cc16780383cc2da86ee0d inParamSource,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("UpdateInvoicePoliza", "d366ba16-4999-4864-8beb-319281c4d1d5.#UpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateInvoicePoliza", "d366ba16-4999-4864-8beb-319281c4d1d5.#UpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_40f7c2dd79fcf6f1dd71369cb12f9d79EntityRecord ssENInvoicePoliza = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(9,true);
}
string updateSet = "UPDATE " + ENInvoicePolizaEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@PolizaId, "polizaid") ?? "polizaid") + " = @ssPolizaId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@PolizaSAP, "polizasap") ?? "polizasap") + " = @ssPolizaSAP"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@SAPObject, "sapobject") ?? "sapobject") + " = @ssSAPObject"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@Sent, "sent") ?? "sent") + " = @ssSent"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@SentWhen, "sentwhen") ?? "sentwhen") + " = @ssSentWhen"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@WithError, "witherror") ?? "witherror") + " = @ssWithError"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@Error_Message, "error_message") ?? "error_message") + " = @ssError_Message"): parameters);
parameters = (usedFields[8] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = @ssCreatedOn"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENInvoicePoliza_ssId_InvoicePoliza";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@WithError, "witherror") ?? "witherror") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoicePoliza, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoicePolizaAttributeKeys.@WithError, "witherror") ?? "witherror") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssPolizaId", DbType.String, ssENInvoicePoliza.ssPolizaId);
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssPolizaSAP", DbType.String, ssENInvoicePoliza.ssPolizaSAP);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssSAPObject", DbType.String, ssENInvoicePoliza.ssSAPObject);
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssSent", DbType.Boolean, ssENInvoicePoliza.ssSent);
}
if(usedFields[5]) {
sqlCmd.CreateParameter("@ssSentWhen", DbType.DateTime, ssENInvoicePoliza.ssSentWhen);
}
if(usedFields[6]) {
sqlCmd.CreateParameter("@ssWithError", DbType.Boolean, ssENInvoicePoliza.ssWithError);
}
if(usedFields[7]) {
sqlCmd.CreateParameter("@ssError_Message", DbType.String, ssENInvoicePoliza.ssError_Message);
}
if(usedFields[8]) {
sqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENInvoicePoliza.ssCreatedOn);
}
sqlCmd.CreateParameter("@idparam_ssENInvoicePoliza_ssId_InvoicePoliza", DbType.Int64, ssENInvoicePoliza.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateInvoicePoliza", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("InvoicePoliza", ssENInvoicePoliza.ssId.ToString()); }}
}
return;
}

}
}
