using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateInvoiceApproval
/// </summary>

public static async Task<long> CreateInvoiceApproval(IRequestContext requestContext,RC_8ecd20e9afb5cd14c3f1aea1a6262374 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateInvoiceApproval", "1b529e04-da4d-42ea-8aa3-6683674718fc.#CreateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateInvoiceApproval", "1b529e04-da4d-42ea-8aa3-6683674718fc.#CreateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_c2bd0675fed3aedb585c484c59155eddEntityRecord ssENInvoiceApproval = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENInvoiceApprovalEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@AprovalProcessId, "aprovalprocessid") ?? "aprovalprocessid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@ProcessTypeCode, "processtypecode") ?? "processtypecode") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@ApprovalProcessVersion, "approvalprocessversion") ?? "approvalprocessversion") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@CurrentLevel, "currentlevel") ?? "currentlevel") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@MaxLevel, "maxlevel") ?? "maxlevel") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@StartedOn, "startedon") ?? "startedon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@FinishedOn, "finishedon") ?? "finishedon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@HasStartedAccounting, "hasstartedaccounting") ?? "hasstartedaccounting") + "" +
" ) VALUES (" +
" @ssInvoiceId" +
", @ssAprovalProcessId" +
", @ssProcessTypeCode" +
", @ssApprovalProcessVersion" +
", @ssCurrentLevel" +
", @ssMaxLevel" +
", @ssStartedOn" +
", @ssFinishedOn" +
", @ssHasStartedAccounting" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENInvoiceApproval.ssInvoiceId==0L)) {
insertSqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, ssENInvoiceApproval.ssInvoiceId);

}
insertSqlCmd.CreateParameter("@ssAprovalProcessId", DbType.Int64, ssENInvoiceApproval.ssAprovalProcessId);
insertSqlCmd.CreateParameter("@ssProcessTypeCode", DbType.String, ssENInvoiceApproval.ssProcessTypeCode);
insertSqlCmd.CreateParameter("@ssApprovalProcessVersion", DbType.String, ssENInvoiceApproval.ssApprovalProcessVersion);
insertSqlCmd.CreateParameter("@ssCurrentLevel", DbType.Int32, ssENInvoiceApproval.ssCurrentLevel);
insertSqlCmd.CreateParameter("@ssMaxLevel", DbType.Int32, ssENInvoiceApproval.ssMaxLevel);
insertSqlCmd.CreateParameter("@ssStartedOn", DbType.DateTime, ssENInvoiceApproval.ssStartedOn);
insertSqlCmd.CreateParameter("@ssFinishedOn", DbType.DateTime, ssENInvoiceApproval.ssFinishedOn);
insertSqlCmd.CreateParameter("@ssHasStartedAccounting", DbType.Boolean, ssENInvoiceApproval.ssHasStartedAccounting);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateInvoiceApproval", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateInvoiceApproval
/// </summary>

public static async Task<long> CreateOrUpdateInvoiceApproval(IRequestContext requestContext,BitArray usedFields,RC_8ecd20e9afb5cd14c3f1aea1a6262374 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateInvoiceApproval", "1b529e04-da4d-42ea-8aa3-6683674718fc.#CreateOrUpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateInvoiceApproval", "1b529e04-da4d-42ea-8aa3-6683674718fc.#CreateOrUpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_c2bd0675fed3aedb585c484c59155eddEntityRecord ssENInvoiceApproval = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(10,true);
}
string updateSet = "UPDATE " + ENInvoiceApprovalEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + " = @ssInvoiceId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@AprovalProcessId, "aprovalprocessid") ?? "aprovalprocessid") + " = @ssAprovalProcessId"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@ProcessTypeCode, "processtypecode") ?? "processtypecode") + " = @ssProcessTypeCode"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@ApprovalProcessVersion, "approvalprocessversion") ?? "approvalprocessversion") + " = @ssApprovalProcessVersion"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@CurrentLevel, "currentlevel") ?? "currentlevel") + " = @ssCurrentLevel"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@MaxLevel, "maxlevel") ?? "maxlevel") + " = @ssMaxLevel"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@StartedOn, "startedon") ?? "startedon") + " = @ssStartedOn"): parameters);
parameters = (usedFields[8] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@FinishedOn, "finishedon") ?? "finishedon") + " = @ssFinishedOn"): parameters);
parameters = (usedFields[9] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@HasStartedAccounting, "hasstartedaccounting") ?? "hasstartedaccounting") + " = @ssHasStartedAccounting"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENInvoiceApproval_ssId_InvoiceApproval";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@HasStartedAccounting, "hasstartedaccounting") ?? "hasstartedaccounting") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@HasStartedAccounting, "hasstartedaccounting") ?? "hasstartedaccounting") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENInvoiceApproval.ssInvoiceId==0L)) {
sqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, ssENInvoiceApproval.ssInvoiceId);

}
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssAprovalProcessId", DbType.Int64, ssENInvoiceApproval.ssAprovalProcessId);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssProcessTypeCode", DbType.String, ssENInvoiceApproval.ssProcessTypeCode);
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssApprovalProcessVersion", DbType.String, ssENInvoiceApproval.ssApprovalProcessVersion);
}
if(usedFields[5]) {
sqlCmd.CreateParameter("@ssCurrentLevel", DbType.Int32, ssENInvoiceApproval.ssCurrentLevel);
}
if(usedFields[6]) {
sqlCmd.CreateParameter("@ssMaxLevel", DbType.Int32, ssENInvoiceApproval.ssMaxLevel);
}
if(usedFields[7]) {
sqlCmd.CreateParameter("@ssStartedOn", DbType.DateTime, ssENInvoiceApproval.ssStartedOn);
}
if(usedFields[8]) {
sqlCmd.CreateParameter("@ssFinishedOn", DbType.DateTime, ssENInvoiceApproval.ssFinishedOn);
}
if(usedFields[9]) {
sqlCmd.CreateParameter("@ssHasStartedAccounting", DbType.Boolean, ssENInvoiceApproval.ssHasStartedAccounting);
}
sqlCmd.CreateParameter("@idparam_ssENInvoiceApproval_ssId_InvoiceApproval", DbType.Int64, ssENInvoiceApproval.ssId);
int counter = 0;
if(ssENInvoiceApproval.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateInvoiceApproval (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENInvoiceApprovalEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@AprovalProcessId, "aprovalprocessid") ?? "aprovalprocessid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@ProcessTypeCode, "processtypecode") ?? "processtypecode") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@ApprovalProcessVersion, "approvalprocessversion") ?? "approvalprocessversion") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@CurrentLevel, "currentlevel") ?? "currentlevel") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@MaxLevel, "maxlevel") ?? "maxlevel") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@StartedOn, "startedon") ?? "startedon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@FinishedOn, "finishedon") ?? "finishedon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@HasStartedAccounting, "hasstartedaccounting") ?? "hasstartedaccounting") + "" +
" ) VALUES (" +
" @ssInvoiceId" +
", @ssAprovalProcessId" +
", @ssProcessTypeCode" +
", @ssApprovalProcessVersion" +
", @ssCurrentLevel" +
", @ssMaxLevel" +
", @ssStartedOn" +
", @ssFinishedOn" +
", @ssHasStartedAccounting" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENInvoiceApproval.ssInvoiceId==0L)) {
insertSqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, ssENInvoiceApproval.ssInvoiceId);

}
insertSqlCmd.CreateParameter("@ssAprovalProcessId", DbType.Int64, ssENInvoiceApproval.ssAprovalProcessId);
insertSqlCmd.CreateParameter("@ssProcessTypeCode", DbType.String, ssENInvoiceApproval.ssProcessTypeCode);
insertSqlCmd.CreateParameter("@ssApprovalProcessVersion", DbType.String, ssENInvoiceApproval.ssApprovalProcessVersion);
insertSqlCmd.CreateParameter("@ssCurrentLevel", DbType.Int32, ssENInvoiceApproval.ssCurrentLevel);
insertSqlCmd.CreateParameter("@ssMaxLevel", DbType.Int32, ssENInvoiceApproval.ssMaxLevel);
insertSqlCmd.CreateParameter("@ssStartedOn", DbType.DateTime, ssENInvoiceApproval.ssStartedOn);
insertSqlCmd.CreateParameter("@ssFinishedOn", DbType.DateTime, ssENInvoiceApproval.ssFinishedOn);
insertSqlCmd.CreateParameter("@ssHasStartedAccounting", DbType.Boolean, ssENInvoiceApproval.ssHasStartedAccounting);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateInvoiceApproval", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENInvoiceApproval.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeInvoiceApproval
/// </summary>

public static async Task CreateOrUpdateSomeInvoiceApproval(IRequestContext requestContext,RL_b496b6dad8a76ef02aafdb1cf78f19ec inParamSourceList,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateSomeInvoiceApproval", "1b529e04-da4d-42ea-8aa3-6683674718fc.#CreateOrUpdateAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeInvoiceApproval", "1b529e04-da4d-42ea-8aa3-6683674718fc.#CreateOrUpdateAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
string entityTableName = ENInvoiceApprovalEntity.LocalViewName(null);
string insertSql = "INSERT INTO " + entityTableName + " (" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@AprovalProcessId, "aprovalprocessid") ?? "aprovalprocessid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@ProcessTypeCode, "processtypecode") ?? "processtypecode") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@ApprovalProcessVersion, "approvalprocessversion") ?? "approvalprocessversion") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@CurrentLevel, "currentlevel") ?? "currentlevel") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@MaxLevel, "maxlevel") ?? "maxlevel") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@StartedOn, "startedon") ?? "startedon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@FinishedOn, "finishedon") ?? "finishedon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@HasStartedAccounting, "hasstartedaccounting") ?? "hasstartedaccounting") + ") VALUES ( unnest(@ssInvoiceId),  unnest(@ssAprovalProcessId),  unnest(@ssProcessTypeCode),  unnest(@ssApprovalProcessVersion),  unnest(@ssCurrentLevel),  unnest(@ssMaxLevel),  unnest(@ssStartedOn),  unnest(@ssFinishedOn),  unnest(@ssHasStartedAccounting)) ";
insertSql += "";

string updateSql = "UPDATE " + entityTableName + " SET " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@AprovalProcessId, "aprovalprocessid") ?? "aprovalprocessid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@AprovalProcessId, "aprovalprocessid") ?? "aprovalprocessid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@ProcessTypeCode, "processtypecode") ?? "processtypecode") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@ProcessTypeCode, "processtypecode") ?? "processtypecode") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@ApprovalProcessVersion, "approvalprocessversion") ?? "approvalprocessversion") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@ApprovalProcessVersion, "approvalprocessversion") ?? "approvalprocessversion") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@CurrentLevel, "currentlevel") ?? "currentlevel") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@CurrentLevel, "currentlevel") ?? "currentlevel") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@MaxLevel, "maxlevel") ?? "maxlevel") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@MaxLevel, "maxlevel") ?? "maxlevel") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@StartedOn, "startedon") ?? "startedon") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@StartedOn, "startedon") ?? "startedon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@FinishedOn, "finishedon") ?? "finishedon") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@FinishedOn, "finishedon") ?? "finishedon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@HasStartedAccounting, "hasstartedaccounting") ?? "hasstartedaccounting") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@HasStartedAccounting, "hasstartedaccounting") ?? "hasstartedaccounting") + " from ( select  unnest(@ssId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@Id, "id") ?? "id") + ",  unnest(@ssInvoiceId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + ",  unnest(@ssAprovalProcessId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@AprovalProcessId, "aprovalprocessid") ?? "aprovalprocessid") + ",  unnest(@ssProcessTypeCode) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@ProcessTypeCode, "processtypecode") ?? "processtypecode") + ",  unnest(@ssApprovalProcessVersion) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@ApprovalProcessVersion, "approvalprocessversion") ?? "approvalprocessversion") + ",  unnest(@ssCurrentLevel) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@CurrentLevel, "currentlevel") ?? "currentlevel") + ",  unnest(@ssMaxLevel) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@MaxLevel, "maxlevel") ?? "maxlevel") + ",  unnest(@ssStartedOn) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@StartedOn, "startedon") ?? "startedon") + ",  unnest(@ssFinishedOn) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@FinishedOn, "finishedon") ?? "finishedon") + ",  unnest(@ssHasStartedAccounting) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@HasStartedAccounting, "hasstartedaccounting") ?? "hasstartedaccounting") + " ) as updateTable where " + entityTableName + "." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@Id, "id") ?? "id") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@Id, "id") ?? "id") + " ";
updateSql += "";

List<object> insertInvoiceIdList = new List<object>();
List<long> insertAprovalProcessIdList = new List<long>();
List<string> insertProcessTypeCodeList = new List<string>();
List<string> insertApprovalProcessVersionList = new List<string>();
List<int> insertCurrentLevelList = new List<int>();
List<int> insertMaxLevelList = new List<int>();
List<DateTime> insertStartedOnList = new List<DateTime>();
List<DateTime> insertFinishedOnList = new List<DateTime>();
List<bool> insertHasStartedAccountingList = new List<bool>();

List<long> updateIdList = new List<long>();
List<object> updateInvoiceIdList = new List<object>();
List<long> updateAprovalProcessIdList = new List<long>();
List<string> updateProcessTypeCodeList = new List<string>();
List<string> updateApprovalProcessVersionList = new List<string>();
List<int> updateCurrentLevelList = new List<int>();
List<int> updateMaxLevelList = new List<int>();
List<DateTime> updateStartedOnList = new List<DateTime>();
List<DateTime> updateFinishedOnList = new List<DateTime>();
List<bool> updateHasStartedAccountingList = new List<bool>();

var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_8ecd20e9afb5cd14c3f1aea1a6262374)inParamSourceList.Current).ssENInvoiceApproval;
if (record.ssId != 0L) {
updateIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
if ((record.ssInvoiceId==0L)) {
updateInvoiceIdList.Add(null);
} else {
updateInvoiceIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssInvoiceId));
}
updateAprovalProcessIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssAprovalProcessId));
updateProcessTypeCodeList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssProcessTypeCode));
updateApprovalProcessVersionList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssApprovalProcessVersion));
updateCurrentLevelList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssCurrentLevel));
updateMaxLevelList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssMaxLevel));
updateStartedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssStartedOn));
updateFinishedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssFinishedOn));
updateHasStartedAccountingList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssHasStartedAccounting));
} else {
if ((record.ssInvoiceId==0L)) {
insertInvoiceIdList.Add(null);
} else {
insertInvoiceIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssInvoiceId));
}
insertAprovalProcessIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssAprovalProcessId));
insertProcessTypeCodeList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssProcessTypeCode));
insertApprovalProcessVersionList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssApprovalProcessVersion));
insertCurrentLevelList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssCurrentLevel));
insertMaxLevelList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssMaxLevel));
insertStartedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssStartedOn));
insertFinishedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssFinishedOn));
insertHasStartedAccountingList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssHasStartedAccounting));
}
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertInvoiceIdList.IsEmpty() || !insertAprovalProcessIdList.IsEmpty() || !insertProcessTypeCodeList.IsEmpty() || !insertApprovalProcessVersionList.IsEmpty() || !insertCurrentLevelList.IsEmpty() || !insertMaxLevelList.IsEmpty() || !insertStartedOnList.IsEmpty() || !insertFinishedOnList.IsEmpty() || !insertHasStartedAccountingList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssInvoiceId",DbType.Int64,insertInvoiceIdList);
executionService.CreateParameter(insertSqlCmd,"@ssAprovalProcessId",DbType.Int64,insertAprovalProcessIdList);
executionService.CreateParameter(insertSqlCmd,"@ssProcessTypeCode",DbType.String,insertProcessTypeCodeList);
executionService.CreateParameter(insertSqlCmd,"@ssApprovalProcessVersion",DbType.String,insertApprovalProcessVersionList);
executionService.CreateParameter(insertSqlCmd,"@ssCurrentLevel",DbType.Int32,insertCurrentLevelList);
executionService.CreateParameter(insertSqlCmd,"@ssMaxLevel",DbType.Int32,insertMaxLevelList);
executionService.CreateParameter(insertSqlCmd,"@ssStartedOn",DbType.DateTime,insertStartedOnList);
executionService.CreateParameter(insertSqlCmd,"@ssFinishedOn",DbType.DateTime,insertFinishedOnList);
executionService.CreateParameter(insertSqlCmd,"@ssHasStartedAccounting",DbType.Boolean,insertHasStartedAccountingList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeInvoiceApproval (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
if(!updateInvoiceIdList.IsEmpty() || !updateAprovalProcessIdList.IsEmpty() || !updateProcessTypeCodeList.IsEmpty() || !updateApprovalProcessVersionList.IsEmpty() || !updateCurrentLevelList.IsEmpty() || !updateMaxLevelList.IsEmpty() || !updateStartedOnList.IsEmpty() || !updateFinishedOnList.IsEmpty() || !updateHasStartedAccountingList.IsEmpty()){
await using(var updateSqlCmd = trans.CreateCommand(updateSql)){
executionService.CreateParameter(updateSqlCmd,"@ssId",DbType.Int64,updateIdList);
executionService.CreateParameter(updateSqlCmd,"@ssInvoiceId",DbType.Int64,updateInvoiceIdList);
executionService.CreateParameter(updateSqlCmd,"@ssAprovalProcessId",DbType.Int64,updateAprovalProcessIdList);
executionService.CreateParameter(updateSqlCmd,"@ssProcessTypeCode",DbType.String,updateProcessTypeCodeList);
executionService.CreateParameter(updateSqlCmd,"@ssApprovalProcessVersion",DbType.String,updateApprovalProcessVersionList);
executionService.CreateParameter(updateSqlCmd,"@ssCurrentLevel",DbType.Int32,updateCurrentLevelList);
executionService.CreateParameter(updateSqlCmd,"@ssMaxLevel",DbType.Int32,updateMaxLevelList);
executionService.CreateParameter(updateSqlCmd,"@ssStartedOn",DbType.DateTime,updateStartedOnList);
executionService.CreateParameter(updateSqlCmd,"@ssFinishedOn",DbType.DateTime,updateFinishedOnList);
executionService.CreateParameter(updateSqlCmd,"@ssHasStartedAccounting",DbType.Boolean,updateHasStartedAccountingList);
await updateSqlCmd.PrepareAsync(cancellationToken);
await updateSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeInvoiceApproval (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(updateSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteInvoiceApproval
/// </summary>

public static async Task DeleteInvoiceApproval(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteInvoiceApproval", "1b529e04-da4d-42ea-8aa3-6683674718fc.#DeleteEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteInvoiceApproval", "1b529e04-da4d-42ea-8aa3-6683674718fc.#DeleteEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENInvoiceApprovalEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteInvoiceApproval", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllInvoiceApproval
/// </summary>

public static async Task DeleteAllInvoiceApproval(IRequestContext requestContext,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteAllInvoiceApproval", "1b529e04-da4d-42ea-8aa3-6683674718fc.#DeleteAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllInvoiceApproval", "1b529e04-da4d-42ea-8aa3-6683674718fc.#DeleteAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENInvoiceApprovalEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteInvoiceApproval", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetInvoiceApproval
/// </summary>

public static async Task<RC_8ecd20e9afb5cd14c3f1aea1a6262374> GetInvoiceApproval(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_8ecd20e9afb5cd14c3f1aea1a6262374 outParamRecord = default;
outParamRecord = new RC_8ecd20e9afb5cd14c3f1aea1a6262374();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetInvoiceApproval", "1b529e04-da4d-42ea-8aa3-6683674718fc.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetInvoiceApproval", "1b529e04-da4d-42ea-8aa3-6683674718fc.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@AprovalProcessId, "aprovalprocessid") ?? "aprovalprocessid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@ProcessTypeCode, "processtypecode") ?? "processtypecode", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@ApprovalProcessVersion, "approvalprocessversion") ?? "approvalprocessversion", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@CurrentLevel, "currentlevel") ?? "currentlevel", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@MaxLevel, "maxlevel") ?? "maxlevel", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@StartedOn, "startedon") ?? "startedon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@FinishedOn, "finishedon") ?? "finishedon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@HasStartedAccounting, "hasstartedaccounting") ?? "hasstartedaccounting", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
" FROM " + ENInvoiceApprovalEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetInvoiceApproval", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(10,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENInvoiceApprovalEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetInvoiceApprovalForUpdate
/// </summary>

public static async Task<RC_8ecd20e9afb5cd14c3f1aea1a6262374> GetInvoiceApprovalForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_8ecd20e9afb5cd14c3f1aea1a6262374 outParamRecord = default;
outParamRecord = new RC_8ecd20e9afb5cd14c3f1aea1a6262374();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetInvoiceApprovalForUpdate", "1b529e04-da4d-42ea-8aa3-6683674718fc.#GetEntityForUpdate");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetInvoiceApprovalForUpdate", "1b529e04-da4d-42ea-8aa3-6683674718fc.#GetEntityForUpdate", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@AprovalProcessId, "aprovalprocessid") ?? "aprovalprocessid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@ProcessTypeCode, "processtypecode") ?? "processtypecode", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@ApprovalProcessVersion, "approvalprocessversion") ?? "approvalprocessversion", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@CurrentLevel, "currentlevel") ?? "currentlevel", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@MaxLevel, "maxlevel") ?? "maxlevel", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@StartedOn, "startedon") ?? "startedon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@FinishedOn, "finishedon") ?? "finishedon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@HasStartedAccounting, "hasstartedaccounting") ?? "hasstartedaccounting", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
" FROM " + ENInvoiceApprovalEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@Id, "id") ?? "id") + " = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetInvoiceApprovalForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(10,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENInvoiceApprovalEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateInvoiceApproval
/// </summary>

public static async Task UpdateInvoiceApproval(IRequestContext requestContext,BitArray usedFields,RC_8ecd20e9afb5cd14c3f1aea1a6262374 inParamSource,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("UpdateInvoiceApproval", "1b529e04-da4d-42ea-8aa3-6683674718fc.#UpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateInvoiceApproval", "1b529e04-da4d-42ea-8aa3-6683674718fc.#UpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_c2bd0675fed3aedb585c484c59155eddEntityRecord ssENInvoiceApproval = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(10,true);
}
string updateSet = "UPDATE " + ENInvoiceApprovalEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + " = @ssInvoiceId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@AprovalProcessId, "aprovalprocessid") ?? "aprovalprocessid") + " = @ssAprovalProcessId"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@ProcessTypeCode, "processtypecode") ?? "processtypecode") + " = @ssProcessTypeCode"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@ApprovalProcessVersion, "approvalprocessversion") ?? "approvalprocessversion") + " = @ssApprovalProcessVersion"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@CurrentLevel, "currentlevel") ?? "currentlevel") + " = @ssCurrentLevel"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@MaxLevel, "maxlevel") ?? "maxlevel") + " = @ssMaxLevel"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@StartedOn, "startedon") ?? "startedon") + " = @ssStartedOn"): parameters);
parameters = (usedFields[8] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@FinishedOn, "finishedon") ?? "finishedon") + " = @ssFinishedOn"): parameters);
parameters = (usedFields[9] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@HasStartedAccounting, "hasstartedaccounting") ?? "hasstartedaccounting") + " = @ssHasStartedAccounting"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENInvoiceApproval_ssId_InvoiceApproval";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@HasStartedAccounting, "hasstartedaccounting") ?? "hasstartedaccounting") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalAttributeKeys.@HasStartedAccounting, "hasstartedaccounting") ?? "hasstartedaccounting") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENInvoiceApproval.ssInvoiceId==0L)) {
sqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, ssENInvoiceApproval.ssInvoiceId);

}
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssAprovalProcessId", DbType.Int64, ssENInvoiceApproval.ssAprovalProcessId);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssProcessTypeCode", DbType.String, ssENInvoiceApproval.ssProcessTypeCode);
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssApprovalProcessVersion", DbType.String, ssENInvoiceApproval.ssApprovalProcessVersion);
}
if(usedFields[5]) {
sqlCmd.CreateParameter("@ssCurrentLevel", DbType.Int32, ssENInvoiceApproval.ssCurrentLevel);
}
if(usedFields[6]) {
sqlCmd.CreateParameter("@ssMaxLevel", DbType.Int32, ssENInvoiceApproval.ssMaxLevel);
}
if(usedFields[7]) {
sqlCmd.CreateParameter("@ssStartedOn", DbType.DateTime, ssENInvoiceApproval.ssStartedOn);
}
if(usedFields[8]) {
sqlCmd.CreateParameter("@ssFinishedOn", DbType.DateTime, ssENInvoiceApproval.ssFinishedOn);
}
if(usedFields[9]) {
sqlCmd.CreateParameter("@ssHasStartedAccounting", DbType.Boolean, ssENInvoiceApproval.ssHasStartedAccounting);
}
sqlCmd.CreateParameter("@idparam_ssENInvoiceApproval_ssId_InvoiceApproval", DbType.Int64, ssENInvoiceApproval.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateInvoiceApproval", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("InvoiceApproval", ssENInvoiceApproval.ssId.ToString()); }}
}
return;
}

}
}
