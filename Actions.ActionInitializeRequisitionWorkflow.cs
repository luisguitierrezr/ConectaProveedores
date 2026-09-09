namespace ssConectaProveedores;

public partial class Actions {
public class lcvInitializeRequisitionWorkflow : VarsBag {
public long inParami_RequisitionId;
public Actions.lcoGetReqApprovalProcessLevels resGetReqApprovalProcessLevels =  new Actions.lcoGetReqApprovalProcessLevels();
public RL_0ad79b64673379e41188da81c3628c0f queryResGetRequisitionById_outParamList = new RL_0ad79b64673379e41188da81c3628c0f();
public long queryResGetRequisitionById_outParamCount = 0L;

public Actions.lcoGetReqApprovalProcess resGetReqApprovalProcess =  new Actions.lcoGetReqApprovalProcess();
public lcvInitializeRequisitionWorkflow(long inParami_RequisitionId) {
this.inParami_RequisitionId = inParami_RequisitionId;
}
}
public class lcoInitializeRequisitionWorkflow : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public lcoInitializeRequisitionWorkflow() {
}
}
/// <summary>
/// Action <code>InitializeRequisitionWorkflow</code> that represents the Service Studio action
///  <code>InitializeRequisitionWorkflow</code> <p> Description: </p>
/// </summary>
public static async Task<ST_046fb53ebbe142526d95e87ef1ae9711Structure> ActionInitializeRequisitionWorkflow(IRequestContext requestContext,long inParami_RequisitionId,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
lcoInitializeRequisitionWorkflow result = new lcoInitializeRequisitionWorkflow();
lcvInitializeRequisitionWorkflow localVars = new lcvInitializeRequisitionWorkflow(inParami_RequisitionId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("InitializeRequisitionWorkflow", "cf1922b9-b4c0-4eec-afaa-2e417e907ecf"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("InitializeRequisitionWorkflow", "cf1922b9-b4c0-4eec-afaa-2e417e907ecf", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetRequisitionById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequisitionById_maxRecords = 1;
if (datasetGetRequisitionById_maxRecords < 1) datasetGetRequisitionById_maxRecords = 1;
int datasetGetRequisitionById_startIndex = 0;(localVars.queryResGetRequisitionById_outParamList,localVars.queryResGetRequisitionById_outParamCount) = await FuncActionInitializeRequisitionWorkflow.datasetGetRequisitionById(requestContext,datasetGetRequisitionById_maxRecords,datasetGetRequisitionById_startIndex,IterationMultiplicity.Never,localVars.inParami_RequisitionId,cancellationToken);

// GetReqApprovalProcess
(localVars.resGetReqApprovalProcess.outParamo_ApprovalProcess,localVars.resGetReqApprovalProcess.outParamo_Output) = await Actions.ActionGetReqApprovalProcess(requestContext,"REQ",localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition.ssRegionId,"",cancellationToken);

// ApprovalProcess not found?
if((localVars.resGetReqApprovalProcess.outParamo_Output.ssIsSuccess)) {
// GetReqApprovalProcessLevels
localVars.resGetReqApprovalProcessLevels.outParamo_Output = await Actions.ActionGetReqApprovalProcessLevels(requestContext,localVars.resGetReqApprovalProcess.outParamo_ApprovalProcess,localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition,cancellationToken);

if(((!localVars.resGetReqApprovalProcessLevels.outParamo_Output.ssIsSuccess))) {
// o_Output
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = GetReqApprovalProcessLevels.o_Output.Message
result.outParamo_Output.ssMessage = localVars.resGetReqApprovalProcessLevels.outParamo_Output.ssMessage;
} else {
// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
}

} else {
// o_Output
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = GetReqApprovalProcess.o_Output.Message
result.outParamo_Output.ssMessage = localVars.resGetReqApprovalProcess.outParamo_Output.ssMessage;
}

} //close CreateActionActivity using block
} // try

catch (Ex_GetNextApproverUserException ex) {
ApplicationLogger.Error(ex, "Error executing action");
requestContext.LastException = ex;

// Error Handler
await DatabaseAccess.RollbackAllTransactionsAsync(cancellationToken);

// o_Output
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = GetNextApprover.ExceptionMessage
result.outParamo_Output.ssMessage = ex.Message;
goto RETURN_STATEMENT;

} // Catch
finally {
outParamo_Output = result.outParamo_Output;
cancellationToken.ThrowIfCancellationRequested();
} // inner-finally
RETURN_STATEMENT:
return outParamo_Output;
}

public static class FuncActionInitializeRequisitionWorkflow {

// Query Function "GetRequisitionById" iRS3VYhYe0aUtdfC1bds4g of Action "InitializeRequisitionWorkflow"
public static async Task<(RL_0ad79b64673379e41188da81c3628c0f,long)> datasetGetRequisitionById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InitializeRequisitionWorkflow.GetRequisitionById", "55b71489-5888-467b-94b5-d7c2d5b76ce2");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InitializeRequisitionWorkflow.GetRequisitionById", "55b71489-5888-467b-94b5-d7c2d5b76ce2", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.uSIZz8C07E6vqi5BfpB+zw/NodesNotShownInESpaceTree.iRS3VYhYe0aUtdfC1bds4g, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enrequisition58\".\"id\" o0, \"enrequisition58\".\"name\" o1, \"enrequisition58\".\"counter\" o2, \"enrequisition58\".\"requisitionstatusid\" o3, \"enrequisition58\".\"supplierid\" o4, \"enrequisition58\".\"regionid\" o5, \"enrequisition58\".\"accountingregionid\" o6, \"enrequisition58\".\"applicantid\" o7, \"enrequisition58\".\"maxdatefinishcapture\" o8, \"enrequisition58\".\"projectassetserviceid\" o9, \"enrequisition58\".\"projectassetservice\" o10, \"enrequisition58\".\"projectdescription\" o11, \"enrequisition58\".\"frequencyid\" o12, \"enrequisition58\".\"issustainability\" o13, \"enrequisition58\".\"sustainabilityid\" o14, \"enrequisition58\".\"businessvaluecategoryid\" o15, \"enrequisition58\".\"businessvaluesubcategoryid\" o16, trim_scale(\"enrequisition58\".\"totalamount\"::numeric) o17, \"enrequisition58\".\"currencyid\" o18, \"enrequisition58\".\"distributionid\" o19, \"enrequisition58\".\"costcenterid\" o20, \"enrequisition58\".\"hascontract\" o21, \"enrequisition58\".\"iscontractpending\" o22, \"enrequisition58\".\"hasdeposit\" o23, \"enrequisition58\".\"hasinsurance\" o24, \"enrequisition58\".\"hasadvancepayment\" o25, \"enrequisition58\".\"accountingservicetypeid_depr\" o26, \"enrequisition58\".\"servicedescription_deprec\" o27, \"enrequisition58\".\"invoiceusageid_deprec\" o28, \"enrequisition58\".\"serviceformatid\" o29, \"enrequisition58\".\"companyid\" o30, trim_scale(\"enrequisition58\".\"retentionrate\"::numeric) o31, trim_scale(\"enrequisition58\".\"negotiatedexchangerate\"::numeric) o32, \"enrequisition58\".\"paymentmethodid\" o33, \"enrequisition58\".\"paymenttermsid\" o34, \"enrequisition58\".\"isautomaticaccounting\" o35, \"enrequisition58\".\"createdby\" o36, \"enrequisition58\".\"createdon\" o37, \"enrequisition58\".\"updatedon\" o38, \"enrequisition58\".\"updatedby\" o39, \"enrequisition58\".\"createdbyapplicationrole\" o40, \"enrequisition58\".\"dateofcommitment\" o41, \"enrequisition58\".\"hascontractfileuploaded\" o42, \"enrequisition58\".\"hasupdateddateofcommitment\" o43, \"enrequisition58\".\"submittedon\" o44, \"enrequisition58\".\"isdonation\" o45, \"enrequisition58\".\"advwithoutinvoice\" o46, \"enrequisition58\".\"wasadvwithoutinvoice\" o47, \"enrequisition58\".\"isadvanced\" o48, \"enrequisition58\".\"documenttypeid\" o49, \"enrequisition58\".\"iscreatedbyanassistente\" o50, \"enrequisition58\".\"telceldirectionid\" o51, \"enrequisition58\".\"hasmultiupload\" o52, \"enrequisition58\".\"accountingdate\" o53, \"enrequisition58\".\"paymentoptionsid\" o54, \"enrequisition58\".\"paymentwaysid\" o55, \"enrequisition58\".\"buydocnumber\" o56, \"enrequisition58\".\"buydocposition\" o57");
fromBuilder.Append(" FROM {Requisition} \"enrequisition58\"");
whereBuilder.Append(" WHERE ");
if (qpreId != 0) {
whereBuilder.Append("((\"enrequisition58\".\"id\" = @qpreId) AND (\"enrequisition58\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreId", DbType.Int64, qpreId);
} else {
whereBuilder.Append("(\"enrequisition58\".\"id\" IS NULL)");
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
RL_0ad79b64673379e41188da81c3628c0f outParamList = new RL_0ad79b64673379e41188da81c3628c0f();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InitializeRequisitionWorkflow.GetRequisitionById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_0ad79b64673379e41188da81c3628c0f _tmp = new RL_0ad79b64673379e41188da81c3628c0f();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InitializeRequisitionWorkflow.GetRequisitionById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_0ad79b64673379e41188da81c3628c0f)_tmp;
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
