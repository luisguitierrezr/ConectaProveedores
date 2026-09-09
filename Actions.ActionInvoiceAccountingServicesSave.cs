namespace ssConectaProveedores;

public partial class Actions {
public class lcvInvoiceAccountingServicesSave : VarsBag {
public RL_500d3f017443846ad96a3e45e41bf158 inParami_InvoiceAccountingServicesList;
public long inParami_InvoiceAccountingId;
public RL_ce67f504f77874aaecc91ad036f8a95a queryResGetInvoiceAccountingServicesByInvoiceAccounting_outParamList = new RL_ce67f504f77874aaecc91ad036f8a95a();
public long queryResGetInvoiceAccountingServicesByInvoiceAccounting_outParamCount = 0L;

public Actions.lcoInvoiceAccountingServicesCreateOrUpdate resInvoiceAccountingCostCentersCreateOrUpdate =  new Actions.lcoInvoiceAccountingServicesCreateOrUpdate();
public int resListIndexOf_outParamPosition = 0;

public lcvInvoiceAccountingServicesSave(RL_500d3f017443846ad96a3e45e41bf158 inParami_InvoiceAccountingServicesList, long inParami_InvoiceAccountingId) {
this.inParami_InvoiceAccountingServicesList = inParami_InvoiceAccountingServicesList;
this.inParami_InvoiceAccountingId = inParami_InvoiceAccountingId;
}
}
public class lcoInvoiceAccountingServicesSave : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public lcoInvoiceAccountingServicesSave() {
}
}
/// <summary>
/// Action <code>InvoiceAccountingServicesSave</code> that represents the Service Studio action
///  <code>InvoiceAccountingServicesSave</code> <p> Description: Action to save Accounting Cos
/// t Centers.</p>
/// </summary>
public static async Task<ST_046fb53ebbe142526d95e87ef1ae9711Structure> ActionInvoiceAccountingServicesSave(IRequestContext requestContext,RL_500d3f017443846ad96a3e45e41bf158 inParami_InvoiceAccountingServicesList,long inParami_InvoiceAccountingId,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
lcoInvoiceAccountingServicesSave result = new lcoInvoiceAccountingServicesSave();
lcvInvoiceAccountingServicesSave localVars = new lcvInvoiceAccountingServicesSave(inParami_InvoiceAccountingServicesList, inParami_InvoiceAccountingId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("InvoiceAccountingServicesSave", "738a93af-502d-48d5-b229-db4ba82aa1b5"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("InvoiceAccountingServicesSave", "738a93af-502d-48d5-b229-db4ba82aa1b5", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetInvoiceAccountingServicesByInvoiceAccounting
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceAccountingServicesByInvoiceAccounting_maxRecords = 999999;
if (datasetGetInvoiceAccountingServicesByInvoiceAccounting_maxRecords < 1) datasetGetInvoiceAccountingServicesByInvoiceAccounting_maxRecords = 1;
int datasetGetInvoiceAccountingServicesByInvoiceAccounting_startIndex = 0;(localVars.queryResGetInvoiceAccountingServicesByInvoiceAccounting_outParamList,localVars.queryResGetInvoiceAccountingServicesByInvoiceAccounting_outParamCount) = await FuncActionInvoiceAccountingServicesSave.datasetGetInvoiceAccountingServicesByInvoiceAccounting(requestContext,datasetGetInvoiceAccountingServicesByInvoiceAccounting_maxRecords,datasetGetInvoiceAccountingServicesByInvoiceAccounting_startIndex,IterationMultiplicity.Single,localVars.inParami_InvoiceAccountingId,cancellationToken);

// Foreach GetInvoiceAccountingServicesByInvoiceAccounting.List
localVars.queryResGetInvoiceAccountingServicesByInvoiceAccounting_outParamList.StartIteration();
try {while (!((localVars.queryResGetInvoiceAccountingServicesByInvoiceAccounting_outParamList.Eof))) {
// ListIndexOf
localVars.resListIndexOf_outParamPosition = await ExtendedActions.ListIndexOf(requestContext,localVars.inParami_InvoiceAccountingServicesList,async (p, cancellationToken) => (p.ssId==localVars.queryResGetInvoiceAccountingServicesByInvoiceAccounting_outParamList.CurrentRec.ssENInvoiceAccountingServices.ssId),cancellationToken);

// Not Found?
if(((localVars.resListIndexOf_outParamPosition==(-1)))) {
// DeleteInvoiceAccountingServices
await ExtendedActions.DeleteInvoiceAccountingServices(requestContext,localVars.queryResGetInvoiceAccountingServicesByInvoiceAccounting_outParamList.CurrentRec.ssENInvoiceAccountingServices.ssId,cancellationToken);

}

localVars.queryResGetInvoiceAccountingServicesByInvoiceAccounting_outParamList.Advance();
}

} finally {
localVars.queryResGetInvoiceAccountingServicesByInvoiceAccounting_outParamList.EndIteration();
}

// Foreach i_InvoiceAccountingServicesList
localVars.inParami_InvoiceAccountingServicesList.StartIteration();
try {while (!((localVars.inParami_InvoiceAccountingServicesList.Eof))) {
// InvoiceAccountingCostCentersCreateOrUpdate
localVars.resInvoiceAccountingCostCentersCreateOrUpdate.outParamId = await Actions.ActionInvoiceAccountingServicesCreateOrUpdate(requestContext,new EN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord(){ ssId = localVars.inParami_InvoiceAccountingServicesList.CurrentRec.ssId, ssInvoiceAccountingId = localVars.inParami_InvoiceAccountingId, ssServiceTypeId = localVars.inParami_InvoiceAccountingServicesList.CurrentRec.ssServiceTypeId, ssAccount = localVars.inParami_InvoiceAccountingServicesList.CurrentRec.ssAccount, ssCostCenterId = localVars.inParami_InvoiceAccountingServicesList.CurrentRec.ssCostCenterId, ssCeBeCostCenterId = localVars.inParami_InvoiceAccountingServicesList.CurrentRec.ssCeBeCostCenterId, ssAmount = localVars.inParami_InvoiceAccountingServicesList.CurrentRec.ssAmount, ssIVA_Old = localVars.inParami_InvoiceAccountingServicesList.CurrentRec.ssIVA_Old, ssIVAIndicatorId = localVars.inParami_InvoiceAccountingServicesList.CurrentRec.ssIVAIndicatorId, ssBuyDocNumber = localVars.inParami_InvoiceAccountingServicesList.CurrentRec.ssBuyDocNumber, ssBuyDocPosition = localVars.inParami_InvoiceAccountingServicesList.CurrentRec.ssBuyDocPosition, ssFreeText = localVars.inParami_InvoiceAccountingServicesList.CurrentRec.ssFreeText, ssDivision = localVars.inParami_InvoiceAccountingServicesList.CurrentRec.ssDivision, ssICME = localVars.inParami_InvoiceAccountingServicesList.CurrentRec.ssICME },cancellationToken);

localVars.inParami_InvoiceAccountingServicesList.Advance();
}

} finally {
localVars.inParami_InvoiceAccountingServicesList.EndIteration();
}

// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
} //close CreateActionActivity using block
} // try

finally {
outParamo_Output = result.outParamo_Output;
} // inner-finally
RETURN_STATEMENT:
return outParamo_Output;
}

public static class FuncActionInvoiceAccountingServicesSave {

// Query Function "GetInvoiceAccountingServicesByInvoiceAccounting" bk5SH_Zpl0K6V0am97fRcw of Action "InvoiceAccountingServicesSave"
public static async Task<(RL_ce67f504f77874aaecc91ad036f8a95a,long)> datasetGetInvoiceAccountingServicesByInvoiceAccounting(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceAccountingId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InvoiceAccountingServicesSave.GetInvoiceAccountingServicesByInvoiceAccounting", "1f524e6e-69f6-4297-ba57-46a6f7b7d173");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InvoiceAccountingServicesSave.GetInvoiceAccountingServicesByInvoiceAccounting", "1f524e6e-69f6-4297-ba57-46a6f7b7d173", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.r5OKcy1Q1UiyKdtLqCqhtQ/NodesNotShownInESpaceTree.bk5SH_Zpl0K6V0am97fRcw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoiceaccountingservices\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13");
fromBuilder.Append(" FROM {InvoiceAccountingServices} \"eninvoiceaccountingservices\"");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceAccountingId != 0) {
whereBuilder.Append("((\"eninvoiceaccountingservices\".\"invoiceaccountingid\" = @qpinInvoiceAccountingId) AND (\"eninvoiceaccountingservices\".\"invoiceaccountingid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceAccountingId", DbType.Int64, qpinInvoiceAccountingId);
} else {
whereBuilder.Append("(\"eninvoiceaccountingservices\".\"invoiceaccountingid\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"eninvoiceaccountingservices\".\"id\" ASC ");
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
RL_ce67f504f77874aaecc91ad036f8a95a outParamList = new RL_ce67f504f77874aaecc91ad036f8a95a();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InvoiceAccountingServicesSave.GetInvoiceAccountingServicesByInvoiceAccounting.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_ce67f504f77874aaecc91ad036f8a95a _tmp = new RL_ce67f504f77874aaecc91ad036f8a95a();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InvoiceAccountingServicesSave.GetInvoiceAccountingServicesByInvoiceAccounting.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_ce67f504f77874aaecc91ad036f8a95a)_tmp;
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
