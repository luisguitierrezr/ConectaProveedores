using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateInvoiceAccountingProcessRetentions
/// </summary>

public static async Task<long> CreateInvoiceAccountingProcessRetentions(IRequestContext requestContext,RC_572bb5931fdd9ca097b2d3800101c49b inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateInvoiceAccountingProcessRetentions", "dca0c5ad-727f-421c-bb4c-6242a37af2b6.#CreateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateInvoiceAccountingProcessRetentions", "dca0c5ad-727f-421c-bb4c-6242a37af2b6.#CreateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_b5a4fdb73161852bf014862cdc591a06EntityRecord ssENInvoiceAccountingProcessRetentions = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENInvoiceAccountingProcessRetentionsEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessRetentions, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessRetentionsAttributeKeys.@InvoiceAccountingProcessId, "invoiceaccountingprocessid") ?? "invoiceaccountingprocessid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessRetentions, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessRetentionsAttributeKeys.@WITHT, "witht") ?? "witht") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessRetentions, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessRetentionsAttributeKeys.@WT_WITHCD, "wt_withcd") ?? "wt_withcd") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessRetentions, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessRetentionsAttributeKeys.@WT_SUBJCT, "wt_subjct") ?? "wt_subjct") + "" +
" ) VALUES (" +
" @ssInvoiceAccountingProcessId" +
", @ssWITHT" +
", @ssWT_WITHCD" +
", @ssWT_SUBJCT" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENInvoiceAccountingProcessRetentions.ssInvoiceAccountingProcessId==0L)) {
insertSqlCmd.CreateParameter("@ssInvoiceAccountingProcessId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssInvoiceAccountingProcessId", DbType.Int64, ssENInvoiceAccountingProcessRetentions.ssInvoiceAccountingProcessId);

}
insertSqlCmd.CreateParameter("@ssWITHT", DbType.String, ssENInvoiceAccountingProcessRetentions.ssWITHT);
insertSqlCmd.CreateParameter("@ssWT_WITHCD", DbType.String, ssENInvoiceAccountingProcessRetentions.ssWT_WITHCD);
insertSqlCmd.CreateParameter("@ssWT_SUBJCT", DbType.String, ssENInvoiceAccountingProcessRetentions.ssWT_SUBJCT);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateInvoiceAccountingProcessRetentions", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateInvoiceAccountingProcessRetentions
/// </summary>

public static async Task<long> CreateOrUpdateInvoiceAccountingProcessRetentions(IRequestContext requestContext,BitArray usedFields,RC_572bb5931fdd9ca097b2d3800101c49b inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateInvoiceAccountingProcessRetentions", "dca0c5ad-727f-421c-bb4c-6242a37af2b6.#CreateOrUpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateInvoiceAccountingProcessRetentions", "dca0c5ad-727f-421c-bb4c-6242a37af2b6.#CreateOrUpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_b5a4fdb73161852bf014862cdc591a06EntityRecord ssENInvoiceAccountingProcessRetentions = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(5,true);
}
string updateSet = "UPDATE " + ENInvoiceAccountingProcessRetentionsEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessRetentions, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessRetentionsAttributeKeys.@InvoiceAccountingProcessId, "invoiceaccountingprocessid") ?? "invoiceaccountingprocessid") + " = @ssInvoiceAccountingProcessId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessRetentions, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessRetentionsAttributeKeys.@WITHT, "witht") ?? "witht") + " = @ssWITHT"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessRetentions, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessRetentionsAttributeKeys.@WT_WITHCD, "wt_withcd") ?? "wt_withcd") + " = @ssWT_WITHCD"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessRetentions, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessRetentionsAttributeKeys.@WT_SUBJCT, "wt_subjct") ?? "wt_subjct") + " = @ssWT_SUBJCT"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessRetentions, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessRetentionsAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENInvoiceAcccessRetentions_InvoiceAccounessRetentions";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessRetentions, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessRetentionsAttributeKeys.@WITHT, "witht") ?? "witht") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessRetentions, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessRetentionsAttributeKeys.@WITHT, "witht") ?? "witht") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENInvoiceAccountingProcessRetentions.ssInvoiceAccountingProcessId==0L)) {
sqlCmd.CreateParameter("@ssInvoiceAccountingProcessId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssInvoiceAccountingProcessId", DbType.Int64, ssENInvoiceAccountingProcessRetentions.ssInvoiceAccountingProcessId);

}
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssWITHT", DbType.String, ssENInvoiceAccountingProcessRetentions.ssWITHT);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssWT_WITHCD", DbType.String, ssENInvoiceAccountingProcessRetentions.ssWT_WITHCD);
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssWT_SUBJCT", DbType.String, ssENInvoiceAccountingProcessRetentions.ssWT_SUBJCT);
}
sqlCmd.CreateParameter("@idparam_ssENInvoiceAcccessRetentions_InvoiceAccounessRetentions", DbType.Int64, ssENInvoiceAccountingProcessRetentions.ssId);
int counter = 0;
if(ssENInvoiceAccountingProcessRetentions.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateInvoiceAccountingProcessRetentions (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENInvoiceAccountingProcessRetentionsEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessRetentions, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessRetentionsAttributeKeys.@InvoiceAccountingProcessId, "invoiceaccountingprocessid") ?? "invoiceaccountingprocessid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessRetentions, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessRetentionsAttributeKeys.@WITHT, "witht") ?? "witht") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessRetentions, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessRetentionsAttributeKeys.@WT_WITHCD, "wt_withcd") ?? "wt_withcd") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessRetentions, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessRetentionsAttributeKeys.@WT_SUBJCT, "wt_subjct") ?? "wt_subjct") + "" +
" ) VALUES (" +
" @ssInvoiceAccountingProcessId" +
", @ssWITHT" +
", @ssWT_WITHCD" +
", @ssWT_SUBJCT" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENInvoiceAccountingProcessRetentions.ssInvoiceAccountingProcessId==0L)) {
insertSqlCmd.CreateParameter("@ssInvoiceAccountingProcessId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssInvoiceAccountingProcessId", DbType.Int64, ssENInvoiceAccountingProcessRetentions.ssInvoiceAccountingProcessId);

}
insertSqlCmd.CreateParameter("@ssWITHT", DbType.String, ssENInvoiceAccountingProcessRetentions.ssWITHT);
insertSqlCmd.CreateParameter("@ssWT_WITHCD", DbType.String, ssENInvoiceAccountingProcessRetentions.ssWT_WITHCD);
insertSqlCmd.CreateParameter("@ssWT_SUBJCT", DbType.String, ssENInvoiceAccountingProcessRetentions.ssWT_SUBJCT);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateInvoiceAccountingProcessRetentions", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENInvoiceAccountingProcessRetentions.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeInvoiceAccountingProcessRetentions
/// </summary>

public static async Task CreateOrUpdateSomeInvoiceAccountingProcessRetentions(IRequestContext requestContext,RL_d8257fba7f427e1268305606412dd313 inParamSourceList,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateSomeInvoiceAccountingProcessRetentions", "dca0c5ad-727f-421c-bb4c-6242a37af2b6.#CreateOrUpdateAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeInvoiceAccountingProcessRetentions", "dca0c5ad-727f-421c-bb4c-6242a37af2b6.#CreateOrUpdateAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
string entityTableName = ENInvoiceAccountingProcessRetentionsEntity.LocalViewName(null);
string insertSql = "INSERT INTO " + entityTableName + " (" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessRetentions, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessRetentionsAttributeKeys.@InvoiceAccountingProcessId, "invoiceaccountingprocessid") ?? "invoiceaccountingprocessid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessRetentions, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessRetentionsAttributeKeys.@WITHT, "witht") ?? "witht") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessRetentions, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessRetentionsAttributeKeys.@WT_WITHCD, "wt_withcd") ?? "wt_withcd") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessRetentions, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessRetentionsAttributeKeys.@WT_SUBJCT, "wt_subjct") ?? "wt_subjct") + ") VALUES ( unnest(@ssInvoiceAccountingProcessId),  unnest(@ssWITHT),  unnest(@ssWT_WITHCD),  unnest(@ssWT_SUBJCT)) ";
insertSql += "";

string updateSql = "UPDATE " + entityTableName + " SET " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessRetentions, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessRetentionsAttributeKeys.@InvoiceAccountingProcessId, "invoiceaccountingprocessid") ?? "invoiceaccountingprocessid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessRetentions, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessRetentionsAttributeKeys.@InvoiceAccountingProcessId, "invoiceaccountingprocessid") ?? "invoiceaccountingprocessid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessRetentions, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessRetentionsAttributeKeys.@WITHT, "witht") ?? "witht") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessRetentions, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessRetentionsAttributeKeys.@WITHT, "witht") ?? "witht") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessRetentions, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessRetentionsAttributeKeys.@WT_WITHCD, "wt_withcd") ?? "wt_withcd") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessRetentions, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessRetentionsAttributeKeys.@WT_WITHCD, "wt_withcd") ?? "wt_withcd") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessRetentions, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessRetentionsAttributeKeys.@WT_SUBJCT, "wt_subjct") ?? "wt_subjct") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessRetentions, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessRetentionsAttributeKeys.@WT_SUBJCT, "wt_subjct") ?? "wt_subjct") + " from ( select  unnest(@ssId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessRetentions, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessRetentionsAttributeKeys.@Id, "id") ?? "id") + ",  unnest(@ssInvoiceAccountingProcessId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessRetentions, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessRetentionsAttributeKeys.@InvoiceAccountingProcessId, "invoiceaccountingprocessid") ?? "invoiceaccountingprocessid") + ",  unnest(@ssWITHT) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessRetentions, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessRetentionsAttributeKeys.@WITHT, "witht") ?? "witht") + ",  unnest(@ssWT_WITHCD) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessRetentions, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessRetentionsAttributeKeys.@WT_WITHCD, "wt_withcd") ?? "wt_withcd") + ",  unnest(@ssWT_SUBJCT) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessRetentions, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessRetentionsAttributeKeys.@WT_SUBJCT, "wt_subjct") ?? "wt_subjct") + " ) as updateTable where " + entityTableName + "." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessRetentions, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessRetentionsAttributeKeys.@Id, "id") ?? "id") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessRetentions, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessRetentionsAttributeKeys.@Id, "id") ?? "id") + " ";
updateSql += "";

List<object> insertInvoiceAccountingProcessIdList = new List<object>();
List<string> insertWITHTList = new List<string>();
List<string> insertWT_WITHCDList = new List<string>();
List<string> insertWT_SUBJCTList = new List<string>();

List<long> updateIdList = new List<long>();
List<object> updateInvoiceAccountingProcessIdList = new List<object>();
List<string> updateWITHTList = new List<string>();
List<string> updateWT_WITHCDList = new List<string>();
List<string> updateWT_SUBJCTList = new List<string>();

var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_572bb5931fdd9ca097b2d3800101c49b)inParamSourceList.Current).ssENInvoiceAccountingProcessRetentions;
if (record.ssId != 0L) {
updateIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
if ((record.ssInvoiceAccountingProcessId==0L)) {
updateInvoiceAccountingProcessIdList.Add(null);
} else {
updateInvoiceAccountingProcessIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssInvoiceAccountingProcessId));
}
updateWITHTList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssWITHT));
updateWT_WITHCDList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssWT_WITHCD));
updateWT_SUBJCTList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssWT_SUBJCT));
} else {
if ((record.ssInvoiceAccountingProcessId==0L)) {
insertInvoiceAccountingProcessIdList.Add(null);
} else {
insertInvoiceAccountingProcessIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssInvoiceAccountingProcessId));
}
insertWITHTList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssWITHT));
insertWT_WITHCDList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssWT_WITHCD));
insertWT_SUBJCTList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssWT_SUBJCT));
}
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertInvoiceAccountingProcessIdList.IsEmpty() || !insertWITHTList.IsEmpty() || !insertWT_WITHCDList.IsEmpty() || !insertWT_SUBJCTList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssInvoiceAccountingProcessId",DbType.Int64,insertInvoiceAccountingProcessIdList);
executionService.CreateParameter(insertSqlCmd,"@ssWITHT",DbType.String,insertWITHTList);
executionService.CreateParameter(insertSqlCmd,"@ssWT_WITHCD",DbType.String,insertWT_WITHCDList);
executionService.CreateParameter(insertSqlCmd,"@ssWT_SUBJCT",DbType.String,insertWT_SUBJCTList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeInvoiceAccountingProcessRetentions (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
if(!updateInvoiceAccountingProcessIdList.IsEmpty() || !updateWITHTList.IsEmpty() || !updateWT_WITHCDList.IsEmpty() || !updateWT_SUBJCTList.IsEmpty()){
await using(var updateSqlCmd = trans.CreateCommand(updateSql)){
executionService.CreateParameter(updateSqlCmd,"@ssId",DbType.Int64,updateIdList);
executionService.CreateParameter(updateSqlCmd,"@ssInvoiceAccountingProcessId",DbType.Int64,updateInvoiceAccountingProcessIdList);
executionService.CreateParameter(updateSqlCmd,"@ssWITHT",DbType.String,updateWITHTList);
executionService.CreateParameter(updateSqlCmd,"@ssWT_WITHCD",DbType.String,updateWT_WITHCDList);
executionService.CreateParameter(updateSqlCmd,"@ssWT_SUBJCT",DbType.String,updateWT_SUBJCTList);
await updateSqlCmd.PrepareAsync(cancellationToken);
await updateSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeInvoiceAccountingProcessRetentions (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(updateSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteInvoiceAccountingProcessRetentions
/// </summary>

public static async Task DeleteInvoiceAccountingProcessRetentions(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteInvoiceAccountingProcessRetentions", "dca0c5ad-727f-421c-bb4c-6242a37af2b6.#DeleteEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteInvoiceAccountingProcessRetentions", "dca0c5ad-727f-421c-bb4c-6242a37af2b6.#DeleteEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENInvoiceAccountingProcessRetentionsEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessRetentions, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessRetentionsAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteInvoiceAccountingProcessRetentions", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllInvoiceAccountingProcessRetentions
/// </summary>

public static async Task DeleteAllInvoiceAccountingProcessRetentions(IRequestContext requestContext,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteAllInvoiceAccountingProcessRetentions", "dca0c5ad-727f-421c-bb4c-6242a37af2b6.#DeleteAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllInvoiceAccountingProcessRetentions", "dca0c5ad-727f-421c-bb4c-6242a37af2b6.#DeleteAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENInvoiceAccountingProcessRetentionsEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteInvoiceAccountingProcessRetentions", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetInvoiceAccountingProcessRetentions
/// </summary>

public static async Task<RC_572bb5931fdd9ca097b2d3800101c49b> GetInvoiceAccountingProcessRetentions(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_572bb5931fdd9ca097b2d3800101c49b outParamRecord = default;
outParamRecord = new RC_572bb5931fdd9ca097b2d3800101c49b();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetInvoiceAccountingProcessRetentions", "dca0c5ad-727f-421c-bb4c-6242a37af2b6.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetInvoiceAccountingProcessRetentions", "dca0c5ad-727f-421c-bb4c-6242a37af2b6.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessRetentions, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessRetentionsAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessRetentions, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessRetentionsAttributeKeys.@InvoiceAccountingProcessId, "invoiceaccountingprocessid") ?? "invoiceaccountingprocessid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessRetentions, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessRetentionsAttributeKeys.@WITHT, "witht") ?? "witht", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessRetentions, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessRetentionsAttributeKeys.@WT_WITHCD, "wt_withcd") ?? "wt_withcd", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessRetentions, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessRetentionsAttributeKeys.@WT_SUBJCT, "wt_subjct") ?? "wt_subjct", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
" FROM " + ENInvoiceAccountingProcessRetentionsEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessRetentions, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessRetentionsAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetInvoiceAccountingProcessRetentions", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(5,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENInvoiceAccountingProcessRetentionsEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetInvoiceAccountingProcessRetentionsForUpdate
/// </summary>

public static async Task<RC_572bb5931fdd9ca097b2d3800101c49b> GetInvoiceAccountingProcessRetentionsForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_572bb5931fdd9ca097b2d3800101c49b outParamRecord = default;
outParamRecord = new RC_572bb5931fdd9ca097b2d3800101c49b();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetInvoiceAccountingProcessRetentionsForUpdate", "dca0c5ad-727f-421c-bb4c-6242a37af2b6.#GetEntityForUpdate");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetInvoiceAccountingProcessRetentionsForUpdate", "dca0c5ad-727f-421c-bb4c-6242a37af2b6.#GetEntityForUpdate", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessRetentions, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessRetentionsAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessRetentions, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessRetentionsAttributeKeys.@InvoiceAccountingProcessId, "invoiceaccountingprocessid") ?? "invoiceaccountingprocessid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessRetentions, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessRetentionsAttributeKeys.@WITHT, "witht") ?? "witht", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessRetentions, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessRetentionsAttributeKeys.@WT_WITHCD, "wt_withcd") ?? "wt_withcd", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessRetentions, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessRetentionsAttributeKeys.@WT_SUBJCT, "wt_subjct") ?? "wt_subjct", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
" FROM " + ENInvoiceAccountingProcessRetentionsEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessRetentions, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessRetentionsAttributeKeys.@Id, "id") ?? "id") + " = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetInvoiceAccountingProcessRetentionsForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(5,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENInvoiceAccountingProcessRetentionsEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateInvoiceAccountingProcessRetentions
/// </summary>

public static async Task UpdateInvoiceAccountingProcessRetentions(IRequestContext requestContext,BitArray usedFields,RC_572bb5931fdd9ca097b2d3800101c49b inParamSource,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("UpdateInvoiceAccountingProcessRetentions", "dca0c5ad-727f-421c-bb4c-6242a37af2b6.#UpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateInvoiceAccountingProcessRetentions", "dca0c5ad-727f-421c-bb4c-6242a37af2b6.#UpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_b5a4fdb73161852bf014862cdc591a06EntityRecord ssENInvoiceAccountingProcessRetentions = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(5,true);
}
string updateSet = "UPDATE " + ENInvoiceAccountingProcessRetentionsEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessRetentions, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessRetentionsAttributeKeys.@InvoiceAccountingProcessId, "invoiceaccountingprocessid") ?? "invoiceaccountingprocessid") + " = @ssInvoiceAccountingProcessId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessRetentions, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessRetentionsAttributeKeys.@WITHT, "witht") ?? "witht") + " = @ssWITHT"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessRetentions, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessRetentionsAttributeKeys.@WT_WITHCD, "wt_withcd") ?? "wt_withcd") + " = @ssWT_WITHCD"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessRetentions, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessRetentionsAttributeKeys.@WT_SUBJCT, "wt_subjct") ?? "wt_subjct") + " = @ssWT_SUBJCT"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessRetentions, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessRetentionsAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENInvoiceAcccessRetentions_InvoiceAccounessRetentions";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessRetentions, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessRetentionsAttributeKeys.@WITHT, "witht") ?? "witht") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessRetentions, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessRetentionsAttributeKeys.@WITHT, "witht") ?? "witht") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENInvoiceAccountingProcessRetentions.ssInvoiceAccountingProcessId==0L)) {
sqlCmd.CreateParameter("@ssInvoiceAccountingProcessId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssInvoiceAccountingProcessId", DbType.Int64, ssENInvoiceAccountingProcessRetentions.ssInvoiceAccountingProcessId);

}
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssWITHT", DbType.String, ssENInvoiceAccountingProcessRetentions.ssWITHT);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssWT_WITHCD", DbType.String, ssENInvoiceAccountingProcessRetentions.ssWT_WITHCD);
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssWT_SUBJCT", DbType.String, ssENInvoiceAccountingProcessRetentions.ssWT_SUBJCT);
}
sqlCmd.CreateParameter("@idparam_ssENInvoiceAcccessRetentions_InvoiceAccounessRetentions", DbType.Int64, ssENInvoiceAccountingProcessRetentions.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateInvoiceAccountingProcessRetentions", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("InvoiceAccountingProcessRetentions", ssENInvoiceAccountingProcessRetentions.ssId.ToString()); }}
}
return;
}

}
}
