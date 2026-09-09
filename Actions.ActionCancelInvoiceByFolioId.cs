namespace ssConectaProveedores;

public partial class Actions {
public class lcvCancelInvoiceByFolioId : VarsBag {
public long inParamFolioId;
public RL_ff28012de5324af3e81e5ace09ecb1f0 queryResGetInvoiceFilesByFolioId_outParamList = new RL_ff28012de5324af3e81e5ace09ecb1f0();
public long queryResGetInvoiceFilesByFolioId_outParamCount = 0L;

public Actions.lcoInvoiceCreateOrUpdate resInvoiceCreateOrUpdate =  new Actions.lcoInvoiceCreateOrUpdate();
public lcvCancelInvoiceByFolioId(long inParamFolioId) {
this.inParamFolioId = inParamFolioId;
}
}
/// <summary>
/// Action <code>CancelInvoiceByFolioId</code> that represents the Service Studio action
///  <code>CancelInvoiceByFolioId</code> <p> Description: </p>
/// </summary>
public static async Task ActionCancelInvoiceByFolioId(IRequestContext requestContext,long inParamFolioId,CancellationToken cancellationToken) {
lcvCancelInvoiceByFolioId localVars = new lcvCancelInvoiceByFolioId(inParamFolioId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("CancelInvoiceByFolioId", "82ddf0c5-21bf-44cd-b400-01e6db8f73d2"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("CancelInvoiceByFolioId", "82ddf0c5-21bf-44cd-b400-01e6db8f73d2", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetInvoiceFilesByFolioId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceFilesByFolioId_maxRecords = 0;
int datasetGetInvoiceFilesByFolioId_startIndex = 0;(localVars.queryResGetInvoiceFilesByFolioId_outParamList,localVars.queryResGetInvoiceFilesByFolioId_outParamCount) = await FuncActionCancelInvoiceByFolioId.datasetGetInvoiceFilesByFolioId(requestContext,datasetGetInvoiceFilesByFolioId_maxRecords,datasetGetInvoiceFilesByFolioId_startIndex,IterationMultiplicity.Single,localVars.inParamFolioId,cancellationToken);

// Empty?
if((!(localVars.queryResGetInvoiceFilesByFolioId_outParamList.Empty))) {
// Foreach GetInvoiceFilesByFolioId.List
localVars.queryResGetInvoiceFilesByFolioId_outParamList.StartIteration();
try {while (!((localVars.queryResGetInvoiceFilesByFolioId_outParamList.Eof))) {
// ServiceStorageDelete
await ServiceAPIs.ServiceAPIServiceStorageDelete(requestContext,localVars.queryResGetInvoiceFilesByFolioId_outParamList.CurrentRec.ssENInvoiceFile.ssStorageId,cancellationToken);

localVars.queryResGetInvoiceFilesByFolioId_outParamList.Advance();
}

} finally {
localVars.queryResGetInvoiceFilesByFolioId_outParamList.EndIteration();
}

// GetInvoiceFilesByFolioId.List.Current.Invoice.InvoiceStatusId = Canceled
localVars.queryResGetInvoiceFilesByFolioId_outParamList.CurrentRec.ssENInvoice.ssInvoiceStatusId = (ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("RteygpK6NkexqZHONe6zkg"))).ssId;
// InvoiceCreateOrUpdate
localVars.resInvoiceCreateOrUpdate.outParamId = await Actions.ActionInvoiceCreateOrUpdate(requestContext,localVars.queryResGetInvoiceFilesByFolioId_outParamList.CurrentRec.ssENInvoice,false,cancellationToken);

}

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionCancelInvoiceByFolioId {

private static async Task<RC_2b77a78552d1dad3876c3ebd8f5c8ec1> datasetGetInvoiceFilesByFolioIdReadDbAsync(RC_2b77a78552d1dad3876c3ebd8f5c8ec1 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceFile.Read( r, ref index);
return rec;
}
// Query Function "GetInvoiceFilesByFolioId" TaKmKE3eXUm_B03QsZDtgw of Action "CancelInvoiceByFolioId"
public static async Task<(RL_ff28012de5324af3e81e5ace09ecb1f0,long)> datasetGetInvoiceFilesByFolioId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoInvoice_FolioId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("CancelInvoiceByFolioId.GetInvoiceFilesByFolioId", "28a6a24d-de4d-495d-bf07-4dd0b190ed83");
using var queryActivity = activitySource.CreateAggregateQueryActivity("CancelInvoiceByFolioId.GetInvoiceFilesByFolioId", "28a6a24d-de4d-495d-bf07-4dd0b190ed83", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.xfDdgr8hzUS0AAHm249z0g/NodesNotShownInESpaceTree.TaKmKE3eXUm_B03QsZDtgw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoice35\".\"id\" o0, \"eninvoice35\".\"name\" o1, \"eninvoice35\".\"requisitionid\" o2, \"eninvoice35\".\"folioid\" o3, \"eninvoice35\".\"ordermainid\" o4, \"eninvoice35\".\"cfditypeid\" o5, trim_scale(\"eninvoice35\".\"totalamount\"::numeric) o6, \"eninvoice35\".\"currency\" o7, \"eninvoice35\".\"invoicestatusid\" o8, \"eninvoice35\".\"accountingdatetime\" o9, \"eninvoice35\".\"paymentdatetime\" o10, \"eninvoice35\".\"createdon\" o11, \"eninvoice35\".\"createdby\" o12, \"eninvoice35\".\"updatedon\" o13, \"eninvoice35\".\"updatedby\" o14, \"eninvoice35\".\"submittedon\" o15, \"eninvoice35\".\"isnewversion\" o16, \"eninvoice35\".\"id_poliza\" o17, \"eninvoice35\".\"id_poliza_sap\" o18, \"eninvoice35\".\"doc51\" o19, \"eninvoice35\".\"accountingerror\" o20, \"eninvoice35\".\"orderaccconceptsid\" o21, trim_scale(\"eninvoice35\".\"amortization\"::numeric) o22, \"eninvoice35\".\"creditnoteinvoiceid\" o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, \"eninvoicefile11\".\"storageid\" o29, NULL o30, NULL o31");
fromBuilder.Append(" FROM ({Invoice} \"eninvoice35\" Inner JOIN {InvoiceFile} \"eninvoicefile11\" ON (\"eninvoice35\".\"id\" = \"eninvoicefile11\".\"invoiceid\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoInvoice_FolioId != 0) {
whereBuilder.Append("((\"eninvoice35\".\"folioid\" = @qpfoInvoice_FolioId) AND (\"eninvoice35\".\"folioid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoInvoice_FolioId", DbType.Int64, qpfoInvoice_FolioId);
} else {
whereBuilder.Append("(\"eninvoice35\".\"folioid\" IS NULL)");
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
RL_ff28012de5324af3e81e5ace09ecb1f0 outParamList = new RL_ff28012de5324af3e81e5ace09ecb1f0();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoiceFilesByFolioIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, false, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query CancelInvoiceByFolioId.GetInvoiceFilesByFolioId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_ff28012de5324af3e81e5ace09ecb1f0 _tmp = new RL_ff28012de5324af3e81e5ace09ecb1f0();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoiceFilesByFolioIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query CancelInvoiceByFolioId.GetInvoiceFilesByFolioId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_ff28012de5324af3e81e5ace09ecb1f0)_tmp;
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
