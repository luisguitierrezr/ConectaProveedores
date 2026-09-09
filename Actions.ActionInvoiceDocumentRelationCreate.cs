namespace ssConectaProveedores;

public partial class Actions {
public class lcvInvoiceDocumentRelationCreate : VarsBag {
public long inParamInvoiceId;
public string inParamPoliza;
public string inParamPolizaSAP;
public string inParamSapObject;
public RL_00a03f803f0d49826089181417370afb queryResGetInvoiceFilesByInvoiceId_outParamList = new RL_00a03f803f0d49826089181417370afb();
public long queryResGetInvoiceFilesByInvoiceId_outParamCount = 0L;

public long resCreateInvoicePolizaStorage_outParamId = 0L;

public long resCreateInvoicePoliza_outParamId = 0L;

public lcvInvoiceDocumentRelationCreate(long inParamInvoiceId, string inParamPoliza, string inParamPolizaSAP, string inParamSapObject) {
this.inParamInvoiceId = inParamInvoiceId;
this.inParamPoliza = inParamPoliza;
this.inParamPolizaSAP = inParamPolizaSAP;
this.inParamSapObject = inParamSapObject;
}
}
/// <summary>
/// Action <code>InvoiceDocumentRelationCreate</code> that represents the Service Studio action
///  <code>InvoiceDocumentRelationCreate</code> <p> Description: </p>
/// </summary>
public static async Task ActionInvoiceDocumentRelationCreate(IRequestContext requestContext,long inParamInvoiceId,string inParamPoliza,string inParamPolizaSAP,string inParamSapObject,CancellationToken cancellationToken) {
lcvInvoiceDocumentRelationCreate localVars = new lcvInvoiceDocumentRelationCreate(inParamInvoiceId, inParamPoliza, inParamPolizaSAP, inParamSapObject);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("InvoiceDocumentRelationCreate", "3944fbaf-dd2f-40a7-986d-9b6b9d7eaf6b"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("InvoiceDocumentRelationCreate", "3944fbaf-dd2f-40a7-986d-9b6b9d7eaf6b", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetInvoiceFilesByInvoiceId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceFilesByInvoiceId_maxRecords = 0;
int datasetGetInvoiceFilesByInvoiceId_startIndex = 0;(localVars.queryResGetInvoiceFilesByInvoiceId_outParamList,localVars.queryResGetInvoiceFilesByInvoiceId_outParamCount) = await FuncActionInvoiceDocumentRelationCreate.datasetGetInvoiceFilesByInvoiceId(requestContext,datasetGetInvoiceFilesByInvoiceId_maxRecords,datasetGetInvoiceFilesByInvoiceId_startIndex,IterationMultiplicity.Single,localVars.inParamInvoiceId,cancellationToken);

// CheckFiles
if((!(localVars.queryResGetInvoiceFilesByInvoiceId_outParamList.Empty))) {
// CreateInvoicePoliza
localVars.resCreateInvoicePoliza_outParamId = await ExtendedActions.CreateInvoicePoliza(requestContext,new RC_14fd6714905cc16780383cc2da86ee0d(){ ssENInvoicePoliza = new EN_40f7c2dd79fcf6f1dd71369cb12f9d79EntityRecord(){ ssId = localVars.inParamInvoiceId, ssPolizaId = localVars.inParamPoliza, ssPolizaSAP = localVars.inParamPolizaSAP, ssSAPObject = localVars.inParamSapObject, ssSent = false, ssSentWhen = BuiltInFunction.NullDate (), ssWithError = false, ssError_Message = "", ssCreatedOn = BuiltInFunction.CurrDateTime () } },cancellationToken);

// Foreach GetInvoiceFilesByInvoiceId.List
localVars.queryResGetInvoiceFilesByInvoiceId_outParamList.StartIteration();
try {while (!((localVars.queryResGetInvoiceFilesByInvoiceId_outParamList.Eof))) {
// CreateInvoicePolizaStorage
localVars.resCreateInvoicePolizaStorage_outParamId = await ExtendedActions.CreateInvoicePolizaStorage(requestContext,new RC_285d5103004edd69f9105c056eb9d2a6(){ ssENInvoicePolizaStorage = new EN_c914a6fdb165c9751808adf2e01e2226EntityRecord(){ ssPolizaFlowId = localVars.resCreateInvoicePoliza_outParamId, ssStorageId = localVars.queryResGetInvoiceFilesByInvoiceId_outParamList.CurrentRec.ssENInvoiceFile.ssStorageId } },cancellationToken);

localVars.queryResGetInvoiceFilesByInvoiceId_outParamList.Advance();
}

} finally {
localVars.queryResGetInvoiceFilesByInvoiceId_outParamList.EndIteration();
}

}

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionInvoiceDocumentRelationCreate {

// Query Function "GetInvoiceFilesByInvoiceId" IW+fOsjTI06cjoZZRDJr2Q of Action "InvoiceDocumentRelationCreate"
public static async Task<(RL_00a03f803f0d49826089181417370afb,long)> datasetGetInvoiceFilesByInvoiceId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InvoiceDocumentRelationCreate.GetInvoiceFilesByInvoiceId", "3a9f6f21-d3c8-4e23-9c8e-865944326bd9");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InvoiceDocumentRelationCreate.GetInvoiceFilesByInvoiceId", "3a9f6f21-d3c8-4e23-9c8e-865944326bd9", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.r_tEOS_dp0CYbZtrnX6vaw/NodesNotShownInESpaceTree.IW+fOsjTI06cjoZZRDJr2Q, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, \"eninvoicefile2\".\"storageid\" o5, NULL o6, NULL o7");
fromBuilder.Append(" FROM {InvoiceFile} \"eninvoicefile2\"");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceId != 0) {
whereBuilder.Append("((\"eninvoicefile2\".\"invoiceid\" = @qpinInvoiceId) AND (\"eninvoicefile2\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceId", DbType.Int64, qpinInvoiceId);
} else {
whereBuilder.Append("(\"eninvoicefile2\".\"invoiceid\" IS NULL)");
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
RL_00a03f803f0d49826089181417370afb outParamList = new RL_00a03f803f0d49826089181417370afb();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, false, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InvoiceDocumentRelationCreate.GetInvoiceFilesByInvoiceId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_00a03f803f0d49826089181417370afb _tmp = new RL_00a03f803f0d49826089181417370afb();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InvoiceDocumentRelationCreate.GetInvoiceFilesByInvoiceId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_00a03f803f0d49826089181417370afb)_tmp;
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
