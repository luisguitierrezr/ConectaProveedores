namespace ssConectaProveedores;

public partial class Actions {
public class lcvOrderMainValidateAllFilesApproved : VarsBag {
public long inParami_OrderMainId;
public RL_9129a40e214c2e67892c6ae5dfbfb7b5 queryResGetOrderMainById_outParamList = new RL_9129a40e214c2e67892c6ae5dfbfb7b5();
public long queryResGetOrderMainById_outParamCount = 0L;

public RL_2ece488b15c9ecc6303dcb8130b7d6de queryResGetInvoicesByOrderMainId_outParamList = new RL_2ece488b15c9ecc6303dcb8130b7d6de();
public long queryResGetInvoicesByOrderMainId_outParamCount = 0L;

public RC_7f0ffeffec7d0864eb8855fe8e873743 resGetOrderDetail_outParamRecord = new RC_7f0ffeffec7d0864eb8855fe8e873743();

public string resCall_ZMXFFIMF_ACC_DOC_CHANGE_outParamResponse = "";

public RL_aa7c4357ade22a558be456b32e011ece queryResGetOrderFileById_outParamList = new RL_aa7c4357ade22a558be456b32e011ece();
public long queryResGetOrderFileById_outParamCount = 0L;

public ST_98371f99cd7bfeee4fab07e43606a1b5Structure resGetTimeZone_outParamTimeZone = new ST_98371f99cd7bfeee4fab07e43606a1b5Structure();

public lcvOrderMainValidateAllFilesApproved(long inParami_OrderMainId) {
this.inParami_OrderMainId = inParami_OrderMainId;
}
}
/// <summary>
/// Action <code>OrderMainValidateAllFilesApproved</code> that represents the Service Studio action
///  <code>OrderMainValidateAllFilesApproved</code> <p> Description: </p>
/// </summary>
public static async Task ActionOrderMainValidateAllFilesApproved(IRequestContext requestContext,long inParami_OrderMainId,CancellationToken cancellationToken) {
lcvOrderMainValidateAllFilesApproved localVars = new lcvOrderMainValidateAllFilesApproved(inParami_OrderMainId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("OrderMainValidateAllFilesApproved", "c4bc3e05-3551-4522-9d2b-287f05c5a82f"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("OrderMainValidateAllFilesApproved", "c4bc3e05-3551-4522-9d2b-287f05c5a82f", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetOrderMainById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderMainById_maxRecords = 0;
int datasetGetOrderMainById_startIndex = 0;(localVars.queryResGetOrderMainById_outParamList,localVars.queryResGetOrderMainById_outParamCount) = await FuncActionOrderMainValidateAllFilesApproved.datasetGetOrderMainById(requestContext,datasetGetOrderMainById_maxRecords,datasetGetOrderMainById_startIndex,IterationMultiplicity.Never,localVars.inParami_OrderMainId,cancellationToken);

// All approved?
if((!(localVars.queryResGetOrderMainById_outParamList.CurrentRec.ssENOrderDetail.ssAllContactFilesValidated))) {
// Query datasetGetOrderFileById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderFileById_maxRecords = 999999999;
if (datasetGetOrderFileById_maxRecords < 1) datasetGetOrderFileById_maxRecords = 1;
int datasetGetOrderFileById_startIndex = 0;(localVars.queryResGetOrderFileById_outParamList,localVars.queryResGetOrderFileById_outParamCount) = await FuncActionOrderMainValidateAllFilesApproved.datasetGetOrderFileById(requestContext,datasetGetOrderFileById_maxRecords,datasetGetOrderFileById_startIndex,IterationMultiplicity.Never,localVars.inParami_OrderMainId,cancellationToken);

// All Files are Validated
if((localVars.queryResGetOrderFileById_outParamList.Empty)) {
// GetOrderDetail
localVars.resGetOrderDetail_outParamRecord = await ExtendedActions.GetOrderDetail(requestContext,localVars.inParami_OrderMainId,cancellationToken);

// Set All Files are validated
// GetOrderDetail.Record.OrderDetail.AllContactFilesValidated = True
localVars.resGetOrderDetail_outParamRecord.ssENOrderDetail.ssAllContactFilesValidated = true;
// UpdateOrderDetail
await ExtendedActions.UpdateOrderDetail(requestContext,localVars.resGetOrderDetail_outParamRecord.ChangedAttributes,localVars.resGetOrderDetail_outParamRecord,cancellationToken);

// Query datasetGetInvoicesByOrderMainId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoicesByOrderMainId_maxRecords = 0;
int datasetGetInvoicesByOrderMainId_startIndex = 0;(localVars.queryResGetInvoicesByOrderMainId_outParamList,localVars.queryResGetInvoicesByOrderMainId_outParamCount) = await FuncActionOrderMainValidateAllFilesApproved.datasetGetInvoicesByOrderMainId(requestContext,datasetGetInvoicesByOrderMainId_maxRecords,datasetGetInvoicesByOrderMainId_startIndex,IterationMultiplicity.Single,localVars.inParami_OrderMainId,cancellationToken);

// Foreach GetInvoicesByOrderMainId.List
localVars.queryResGetInvoicesByOrderMainId_outParamList.StartIteration();
try {while (!((localVars.queryResGetInvoicesByOrderMainId_outParamList.Eof))) {
if(((BuiltInFunction.Trim (localVars.queryResGetInvoicesByOrderMainId_outParamList.CurrentRec.ssENInvoice.ssID_POLIZA_SAP)!=""))) {
// GetTimeZone
localVars.resGetTimeZone_outParamTimeZone = await Actions.ActionGetTimeZone(requestContext,"America/Mexico_City",cancellationToken);

// Call_ZMXFFIMF_ACC_DOC_CHANGE
localVars.resCall_ZMXFFIMF_ACC_DOC_CHANGE_outParamResponse = await ServiceAPIs.ServiceAPICall_ZMXFFIMF_ACC_DOC_CHANGE(requestContext,new ST_0cb1a5ee06af693baf5508d00a19d139Structure(){ ssPI_BELNR = localVars.queryResGetInvoicesByOrderMainId_outParamList.CurrentRec.ssENInvoice.ssID_POLIZA_SAP, ssPI_BUKRS = localVars.queryResGetInvoicesByOrderMainId_outParamList.CurrentRec.ssENCompany.ssExternalId, ssPI_GJAHR = BuiltInFunction.Year (BuiltInFunction.CurrDate ()), ssPI_ZTERM = localVars.queryResGetInvoicesByOrderMainId_outParamList.CurrentRec.ssENPaymentTerms.ssEstructuraDescripcionPROP },cancellationToken);

}

localVars.queryResGetInvoicesByOrderMainId_outParamList.Advance();
}

} finally {
localVars.queryResGetInvoicesByOrderMainId_outParamList.EndIteration();
}

}

}

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionOrderMainValidateAllFilesApproved {

private static async Task<RC_64337b445a88908182ed34f64cf1399b> datasetGetOrderMainByIdReadDbAsync(RC_64337b445a88908182ed34f64cf1399b rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENOrderDetail.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
return rec;
}
// Query Function "GetOrderMainById" _Zj9adPnd0C1Y+zLK3lrmQ of Action "OrderMainValidateAllFilesApproved"
public static async Task<(RL_9129a40e214c2e67892c6ae5dfbfb7b5,long)> datasetGetOrderMainById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderMain_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("OrderMainValidateAllFilesApproved.GetOrderMainById", "69fd98fd-e7d3-4077-b563-eccb2b796b99");
using var queryActivity = activitySource.CreateAggregateQueryActivity("OrderMainValidateAllFilesApproved.GetOrderMainById", "69fd98fd-e7d3-4077-b563-eccb2b796b99", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /UserActions.BT68xFE1IkWdKyh_BcWoLw/NodesNotShownInESpaceTree._Zj9adPnd0C1Y+zLK3lrmQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, \"enorderdetail7\".\"allcontactfilesvalidated\" o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67");
fromBuilder.Append(" FROM ({OrderMain} \"enordermain51\" Inner JOIN {OrderDetail} \"enorderdetail7\" ON (\"enordermain51\".\"id\" = \"enorderdetail7\".\"orderid\")) ");
whereBuilder.Append(" WHERE ");
if (qporOrderMain_Id != 0) {
whereBuilder.Append("((\"enordermain51\".\"id\" = @qporOrderMain_Id) AND (\"enordermain51\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderMain_Id", DbType.Int64, qporOrderMain_Id);
} else {
whereBuilder.Append("(\"enordermain51\".\"id\" IS NULL)");
}
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_9129a40e214c2e67892c6ae5dfbfb7b5 outParamList = new RL_9129a40e214c2e67892c6ae5dfbfb7b5();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrderMainByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query OrderMainValidateAllFilesApproved.GetOrderMainById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_9129a40e214c2e67892c6ae5dfbfb7b5 _tmp = new RL_9129a40e214c2e67892c6ae5dfbfb7b5();
_tmp.AlternateReadDbMethodAsync = datasetGetOrderMainByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query OrderMainValidateAllFilesApproved.GetOrderMainById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_9129a40e214c2e67892c6ae5dfbfb7b5)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}

private static async Task<RC_ff6aa2b6e9ff9861ddfa27919ed0cfed> datasetGetInvoicesByOrderMainIdReadDbAsync(RC_ff6aa2b6e9ff9861ddfa27919ed0cfed rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENCompany.Read( r, ref index);
rec.ssENInvoice.Read( r, ref index);
rec.ssENOrderAccConcepts.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
rec.ssENPaymentTerms.Read( r, ref index);
return rec;
}
// Query Function "GetInvoicesByOrderMainId" JSPTdLKI6UyFY3XP3axpLA of Action "OrderMainValidateAllFilesApproved"
public static async Task<(RL_2ece488b15c9ecc6303dcb8130b7d6de,long)> datasetGetInvoicesByOrderMainId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporInvoice_OrderMainId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("OrderMainValidateAllFilesApproved.GetInvoicesByOrderMainId", "74d32325-88b2-4ce9-8563-75cfddac692c");
using var queryActivity = activitySource.CreateAggregateQueryActivity("OrderMainValidateAllFilesApproved.GetInvoicesByOrderMainId", "74d32325-88b2-4ce9-8563-75cfddac692c", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Single
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /UserActions.BT68xFE1IkWdKyh_BcWoLw/NodesNotShownInESpaceTree.JSPTdLKI6UyFY3XP3axpLA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"encompany12\".\"externalid\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, \"eninvoice57\".\"id_poliza_sap\" o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, \"enpaymentterms11\".\"estructuradescripcionprop\" o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88");
fromBuilder.Append(" FROM ((({Invoice} \"eninvoice57\" Inner JOIN {OrderAccConcepts} \"enorderaccconcepts7\" ON (\"eninvoice57\".\"orderaccconceptsid\" = \"enorderaccconcepts7\".\"id\"))  Left JOIN ({OrderMain} \"enordermain52\" Inner JOIN {Company} \"encompany12\" ON (\"enordermain52\".\"companyid\" = \"encompany12\".\"id\"))  ON (\"eninvoice57\".\"ordermainid\" = \"enordermain52\".\"id\"))  Left JOIN {PaymentTerms} \"enpaymentterms11\" ON (\"enorderaccconcepts7\".\"paymenttermid\" = \"enpaymentterms11\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qporInvoice_OrderMainId != 0) {
whereBuilder.Append("((\"eninvoice57\".\"ordermainid\" = @qporInvoice_OrderMainId) AND (\"eninvoice57\".\"ordermainid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporInvoice_OrderMainId", DbType.Int64, qporInvoice_OrderMainId);
} else {
whereBuilder.Append("(\"eninvoice57\".\"ordermainid\" IS NULL)");
}
whereBuilder.Append(" AND (\"eninvoice57\".\"invoicestatusid\" = ");
whereBuilder.Append((ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("h+R+u64a50K6vJ2dkkiVXQ"))).ssId);
whereBuilder.Append(")");
orderByBuilder.Append(" ORDER BY \"eninvoice57\".\"name\" ASC ");
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_2ece488b15c9ecc6303dcb8130b7d6de outParamList = new RL_2ece488b15c9ecc6303dcb8130b7d6de();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoicesByOrderMainIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[5];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, true, true, true, true, false, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query OrderMainValidateAllFilesApproved.GetInvoicesByOrderMainId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_2ece488b15c9ecc6303dcb8130b7d6de _tmp = new RL_2ece488b15c9ecc6303dcb8130b7d6de();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoicesByOrderMainIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query OrderMainValidateAllFilesApproved.GetInvoicesByOrderMainId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_2ece488b15c9ecc6303dcb8130b7d6de)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}

private static async Task<RC_ede323d374bfaaf1250e4715618dd7eb> datasetGetOrderFileByIdReadDbAsync(RC_ede323d374bfaaf1250e4715618dd7eb rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENContractFileType.Read( r, ref index);
rec.ssENCurrency.Read( r, ref index);
rec.ssENOrderContractFile.Read( r, ref index);
rec.ssENOrderDetail.Read( r, ref index);
rec.ssENOrderFile.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
rec.ssENOrderRequestFile.Read( r, ref index);
return rec;
}
// Query Function "GetOrderFileById" ozHMvIGdOk+fasEFsmU3vg of Action "OrderMainValidateAllFilesApproved"
public static async Task<(RL_aa7c4357ade22a558be456b32e011ece,long)> datasetGetOrderFileById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderContractFile_OrderId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("OrderMainValidateAllFilesApproved.GetOrderFileById", "bccc31a3-9d81-4f3a-9f6a-c105b26537be");
using var queryActivity = activitySource.CreateAggregateQueryActivity("OrderMainValidateAllFilesApproved.GetOrderFileById", "bccc31a3-9d81-4f3a-9f6a-c105b26537be", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /UserActions.BT68xFE1IkWdKyh_BcWoLw/NodesNotShownInESpaceTree.ozHMvIGdOk+fasEFsmU3vg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, NULL o101, NULL o102, NULL o103, NULL o104, NULL o105, NULL o106, NULL o107, NULL o108, NULL o109, NULL o110, NULL o111, NULL o112, NULL o113, NULL o114, NULL o115");
fromBuilder.Append(" FROM (((((({OrderContractFile} \"enordercontractfile3\" Left JOIN {OrderFile} \"enorderfile3\" ON (\"enordercontractfile3\".\"orderfileid\" = \"enorderfile3\".\"id\"))  Left JOIN {ContractFileType} \"encontractfiletype\" ON (\"enordercontractfile3\".\"contractfiletypeid\" = \"encontractfiletype\".\"id\"))  Left JOIN {OrderRequestFile} \"enorderrequestfile7\" ON (\"enordercontractfile3\".\"id\" = \"enorderrequestfile7\".\"ordercontractfile\"))  Left JOIN {Currency} \"encurrency5\" ON (\"enordercontractfile3\".\"currencyid\" = \"encurrency5\".\"code\"))  Inner JOIN {OrderMain} \"enordermain53\" ON (\"enordermain53\".\"id\" = \"enordercontractfile3\".\"orderid\"))  Left JOIN {OrderDetail} \"enorderdetail8\" ON (\"enordermain53\".\"id\" = \"enorderdetail8\".\"orderid\")) ");
whereBuilder.Append(" WHERE ");
if (qporOrderContractFile_OrderId != 0) {
whereBuilder.Append("((\"enordercontractfile3\".\"orderid\" = @qporOrderContractFile_OrderId) AND (\"enordercontractfile3\".\"orderid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderContractFile_OrderId", DbType.Int64, qporOrderContractFile_OrderId);
} else {
whereBuilder.Append("(\"enordercontractfile3\".\"orderid\" IS NULL)");
}
whereBuilder.Append(" AND (\"encontractfiletype\".\"id\" <> ");
whereBuilder.Append((ENContractFileTypeEntity.GetRecordByKey(ObjectKey.Parse("G8yzk1VC6kuuzlQ40OJi8Q"))).ssId);
whereBuilder.Append(") AND (\"enorderrequestfile7\".\"isapproved\" = 0)");
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_aa7c4357ade22a558be456b32e011ece outParamList = new RL_aa7c4357ade22a558be456b32e011ece();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrderFileByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[7];
opt[0] = new BitArray(new bool[] {true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[6] = new BitArray(new bool[] {true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query OrderMainValidateAllFilesApproved.GetOrderFileById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_aa7c4357ade22a558be456b32e011ece _tmp = new RL_aa7c4357ade22a558be456b32e011ece();
_tmp.AlternateReadDbMethodAsync = datasetGetOrderFileByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query OrderMainValidateAllFilesApproved.GetOrderFileById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_aa7c4357ade22a558be456b32e011ece)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}



}


}
