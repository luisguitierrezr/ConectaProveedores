namespace ssConectaProveedores;

public partial class Actions {
public class lcvInvoiceAccountingInitialCreate_Serv : VarsBag {
public long inParamInvoiceAccountingId;
public long inParamRequisitionId;
public long inParamRequisitionCostCenterId;
public string inParamRequisitionTotalAmount;
public decimal inParamInvoiceTotalAmount;
public string inParamDivision;
public string inParamFreeText;
public long inParamTaxIndicatorId;
public bool inParamIsAnticipoWithInv;
/// <summary>
/// Variable <code>l_InvoiceAccountingServices</code> that represents the Service Studio
///  InvoiceAccountingServices <code>l_InvoiceAccountingServices</code> <p>Description
/// : InvoiceAccountingCostCenters record to create or modify</p>
/// </summary>
public EN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord varLcl_InvoiceAccountingServices = new EN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord();

public Actions.lcoInvoiceAccountingServicesCreateOrUpdate resInvoiceAccountingServicesCreateOrUpdate =  new Actions.lcoInvoiceAccountingServicesCreateOrUpdate();
public RL_b47d9310671b1b627f451a333bb8980a queryResGetRequisitionServicesByRequisitionId_outParamList = new RL_b47d9310671b1b627f451a333bb8980a();
public long queryResGetRequisitionServicesByRequisitionId_outParamCount = 0L;

public lcvInvoiceAccountingInitialCreate_Serv(long inParamInvoiceAccountingId, long inParamRequisitionId, long inParamRequisitionCostCenterId, string inParamRequisitionTotalAmount, decimal inParamInvoiceTotalAmount, string inParamDivision, string inParamFreeText, long inParamTaxIndicatorId, bool inParamIsAnticipoWithInv) {
this.inParamInvoiceAccountingId = inParamInvoiceAccountingId;
this.inParamRequisitionId = inParamRequisitionId;
this.inParamRequisitionCostCenterId = inParamRequisitionCostCenterId;
this.inParamRequisitionTotalAmount = inParamRequisitionTotalAmount;
this.inParamInvoiceTotalAmount = inParamInvoiceTotalAmount;
this.inParamDivision = inParamDivision;
this.inParamFreeText = inParamFreeText;
this.inParamTaxIndicatorId = inParamTaxIndicatorId;
this.inParamIsAnticipoWithInv = inParamIsAnticipoWithInv;
}
}
/// <summary>
/// Action <code>InvoiceAccountingInitialCreate_Serv</code> that represents the Service Studio action
///  <code>InvoiceAccountingInitialCreate_Serv</code> <p> Description: </p>
/// </summary>
public static async Task ActionInvoiceAccountingInitialCreate_Serv(IRequestContext requestContext,long inParamInvoiceAccountingId,long inParamRequisitionId,long inParamRequisitionCostCenterId,string inParamRequisitionTotalAmount,decimal inParamInvoiceTotalAmount,string inParamDivision,string inParamFreeText,long inParamTaxIndicatorId,bool inParamIsAnticipoWithInv,CancellationToken cancellationToken) {
lcvInvoiceAccountingInitialCreate_Serv localVars = new lcvInvoiceAccountingInitialCreate_Serv(inParamInvoiceAccountingId, inParamRequisitionId, inParamRequisitionCostCenterId, inParamRequisitionTotalAmount, inParamInvoiceTotalAmount, inParamDivision, inParamFreeText, inParamTaxIndicatorId, inParamIsAnticipoWithInv);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("InvoiceAccountingInitialCreate_Serv", "2a2dc0ea-f261-470d-a8e9-81a9ce8c3dd0"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("InvoiceAccountingInitialCreate_Serv", "2a2dc0ea-f261-470d-a8e9-81a9ce8c3dd0", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// not req
if((!((localVars.inParamRequisitionId==Convert.ToInt64(BuiltInFunction.NullIdentifier ()))))) {
// Query datasetGetRequisitionServicesByRequisitionId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequisitionServicesByRequisitionId_maxRecords = 0;
int datasetGetRequisitionServicesByRequisitionId_startIndex = 0;(localVars.queryResGetRequisitionServicesByRequisitionId_outParamList,localVars.queryResGetRequisitionServicesByRequisitionId_outParamCount) = await FuncActionInvoiceAccountingInitialCreate_Serv.datasetGetRequisitionServicesByRequisitionId(requestContext,datasetGetRequisitionServicesByRequisitionId_maxRecords,datasetGetRequisitionServicesByRequisitionId_startIndex,IterationMultiplicity.Single,localVars.inParamRequisitionId,cancellationToken);

// Foreach GetRequisitionServicesByRequisitionId.List
localVars.queryResGetRequisitionServicesByRequisitionId_outParamList.StartIteration();
try {while (!((localVars.queryResGetRequisitionServicesByRequisitionId_outParamList.Eof))) {
// l_InvoiceAccountingServices.InvoiceAccountingId = InvoiceAccountingId
localVars.varLcl_InvoiceAccountingServices.ssInvoiceAccountingId = localVars.inParamInvoiceAccountingId;

// l_InvoiceAccountingServices.CostCenterId = RequisitionCostCenterId
localVars.varLcl_InvoiceAccountingServices.ssCostCenterId = localVars.inParamRequisitionCostCenterId;

// l_InvoiceAccountingServices.Amount = If
localVars.varLcl_InvoiceAccountingServices.ssAmount = (((localVars.inParamInvoiceTotalAmount==localVars.queryResGetRequisitionServicesByRequisitionId_outParamList.CurrentRec.ssENRequisitionService.ssAmount)) ? (BuiltInFunction.TextToDecimal (localVars.inParamRequisitionTotalAmount)) : ((((decimal)0))));

// l_InvoiceAccountingServices.ServiceTypeId = GetRequisitionServicesByRequisitionId.List.Current.RequisitionService.AccountingServiceTypeId
localVars.varLcl_InvoiceAccountingServices.ssServiceTypeId = localVars.queryResGetRequisitionServicesByRequisitionId_outParamList.CurrentRec.ssENRequisitionService.ssAccountingServiceTypeId;

// l_InvoiceAccountingServices.Division = Division
localVars.varLcl_InvoiceAccountingServices.ssDivision = localVars.inParamDivision;

// l_InvoiceAccountingServices.FreeText = FreeText
localVars.varLcl_InvoiceAccountingServices.ssFreeText = localVars.inParamFreeText;

// l_InvoiceAccountingServices.IVAIndicatorId = TaxIndicatorId
localVars.varLcl_InvoiceAccountingServices.ssIVAIndicatorId = localVars.inParamTaxIndicatorId;

// l_InvoiceAccountingServices.ICME = If
localVars.varLcl_InvoiceAccountingServices.ssICME = ((localVars.inParamIsAnticipoWithInv) ? ("A") : (""));
// InvoiceAccountingServicesCreateOrUpdate
localVars.resInvoiceAccountingServicesCreateOrUpdate.outParamId = await Actions.ActionInvoiceAccountingServicesCreateOrUpdate(requestContext,localVars.varLcl_InvoiceAccountingServices,cancellationToken);

localVars.queryResGetRequisitionServicesByRequisitionId_outParamList.Advance();
}

} finally {
localVars.queryResGetRequisitionServicesByRequisitionId_outParamList.EndIteration();
}

}

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionInvoiceAccountingInitialCreate_Serv {

// Query Function "GetRequisitionServicesByRequisitionId" tQ6F9EBfTEyphCoUoTRr_A of Action "InvoiceAccountingInitialCreate_Serv"
public static async Task<(RL_b47d9310671b1b627f451a333bb8980a,long)> datasetGetRequisitionServicesByRequisitionId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRequisitionId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InvoiceAccountingInitialCreate_Serv.GetRequisitionServicesByRequisitionId", "f4850eb5-5f40-4c4c-a984-2a14a1346bfc");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InvoiceAccountingInitialCreate_Serv.GetRequisitionServicesByRequisitionId", "f4850eb5-5f40-4c4c-a984-2a14a1346bfc", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.6sAtKmHyDUeo6YGpzow90A/NodesNotShownInESpaceTree.tQ6F9EBfTEyphCoUoTRr_A, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, \"enrequisitionservice\".\"accountingservicetypeid\" o2, NULL o3, trim_scale(\"enrequisitionservice\".\"amount\"::numeric) o4, NULL o5, NULL o6");
fromBuilder.Append(" FROM {RequisitionService} \"enrequisitionservice\"");
whereBuilder.Append(" WHERE ");
if (qpreRequisitionId != 0) {
whereBuilder.Append("((\"enrequisitionservice\".\"requisitionid\" = @qpreRequisitionId) AND (\"enrequisitionservice\".\"requisitionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisitionId", DbType.Int64, qpreRequisitionId);
} else {
whereBuilder.Append("(\"enrequisitionservice\".\"requisitionid\" IS NULL)");
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
RL_b47d9310671b1b627f451a333bb8980a outParamList = new RL_b47d9310671b1b627f451a333bb8980a();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, false, true, false, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InvoiceAccountingInitialCreate_Serv.GetRequisitionServicesByRequisitionId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_b47d9310671b1b627f451a333bb8980a _tmp = new RL_b47d9310671b1b627f451a333bb8980a();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InvoiceAccountingInitialCreate_Serv.GetRequisitionServicesByRequisitionId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_b47d9310671b1b627f451a333bb8980a)_tmp;
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
