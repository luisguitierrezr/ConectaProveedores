using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using OutSystems.HubEdition.RuntimePlatform.Internal;
using OutSystems.RESTService;
using OutSystems.RESTService.Runtime.Core.Filters;
using OutSystems.RESTService.Runtime.Abstractions.PropertyAttributes;


namespace ssConectaProveedores;

public partial class ServiceAPIController : OutSystems.RESTService.Runtime.Core.Controllers.ServiceActions.ServiceActionsApiController {

    public class S4PIInvAcc_6EndInput {
[JsonProperty("InvoiceAccountingProcessId")]
public long? inParamInvoiceAccountingProcessId;
[JsonProperty("IsError")]
public bool? inParamIsError;
[JsonProperty("IsServiceError")]
public bool? inParamIsServiceError;
[JsonProperty("ErrorMsg")]
public string inParamErrorMsg;
public S4PIInvAcc_6EndInput(long? inParamInvoiceAccountingProcessId, bool? inParamIsError, bool? inParamIsServiceError, string inParamErrorMsg) {
this.inParamInvoiceAccountingProcessId = inParamInvoiceAccountingProcessId;
this.inParamIsError = inParamIsError;
this.inParamIsServiceError = inParamIsServiceError;
this.inParamErrorMsg = inParamErrorMsg;
}

}

public class S4PIInvAcc_6EndOutput {
public S4PIInvAcc_6EndOutput() {
}

}

[HttpPost()]
[Route("serviceapi/invacc_6end")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "InvAcc_6End", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIInvAcc_6End(CancellationToken cancellationToken) {return await EndpointAsync<S4PIInvAcc_6EndInput, S4PIInvAcc_6EndOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
S4PIInvAcc_6EndInput inputs = serviceActionInput.InputParameters;
System.Collections.Generic.Dictionary<string,string[]> validationErrors = new System.Collections.Generic.Dictionary<string,string[]>();
if((inputs.inParamInvoiceAccountingProcessId == null)) {
validationErrors["InvoiceAccountingProcessId"]=new string[] {"The InvoiceAccountingProcessId mandatory parameter is missing in the request."};
}

if((inputs.inParamIsError == null)) {
validationErrors["IsError"]=new string[] {"The IsError mandatory parameter is missing in the request."};
}

if((inputs.inParamIsServiceError == null)) {
validationErrors["IsServiceError"]=new string[] {"The IsServiceError mandatory parameter is missing in the request."};
}

if((inputs.inParamErrorMsg == null)) {
validationErrors["ErrorMsg"]=new string[] {"The ErrorMsg mandatory parameter is missing in the request."};
}

if(validationErrors.Any()) {
throw RestExposeErrorsHelper.BadRequest(validationErrors);
}

ctx.ThrowIfCancellationRequested();
await Flows.ActionInvAcc_6End(context,inputs.inParamInvoiceAccountingProcessId.Value,inputs.inParamIsError.Value,inputs.inParamIsServiceError.Value,inputs.inParamErrorMsg,ctx);

return new S4PIInvAcc_6EndOutput();
}
, cancellationToken);
}



    public partial class Flows {
        public class lcvInvAcc_6End : VarsBag {
public long inParamInvoiceAccountingProcessId;
public bool inParamIsError;
public bool inParamIsServiceError;
public string inParamErrorMsg;
/// <summary>
/// Variable <code>InvoiceId</code> that represents the Service Studio InvoiceIdentifier
///  <code>InvoiceId</code> <p>Description: </p>
/// </summary>
public long varLcInvoiceId = 0L;

public Actions.lcoClearInvoiceApprovalAccounting resClearInvoiceApprovalAccounting =  new Actions.lcoClearInvoiceApprovalAccounting();
public Actions.lcoInvoiceLogAdd resInvoiceLogAddApprove4 =  new Actions.lcoInvoiceLogAdd();
public Actions.lcoInvoiceLogAdd resInvoiceLogAddApprove3 =  new Actions.lcoInvoiceLogAdd();
public Actions.lcoInvoiceCreateOrUpdate resInvoiceCreateOrUpdate =  new Actions.lcoInvoiceCreateOrUpdate();
public Actions.lcoInvoiceStatusHistoryCreateOrUpdate resInvoiceStatusHistoryCreateOrUpdate =  new Actions.lcoInvoiceStatusHistoryCreateOrUpdate();
public Actions.lcoInvoiceCreateOrUpdate resInvoiceCreateOrUpdate3 =  new Actions.lcoInvoiceCreateOrUpdate();
public RL_5e0ca6ca9da3af4b1d8149758c39c2cf queryResGetApprovalProcess_outParamList = new RL_5e0ca6ca9da3af4b1d8149758c39c2cf();
public long queryResGetApprovalProcess_outParamCount = 0L;

public RL_4d0a053561fa4a3aef04e507b83b31d1 queryResGetInvoiceById_outParamList = new RL_4d0a053561fa4a3aef04e507b83b31d1();
public long queryResGetInvoiceById_outParamCount = 0L;

public RL_1337c15efa2eafb36e59edff0fd662c9 queryResGetInvoiceAccountingProcessById_outParamList = new RL_1337c15efa2eafb36e59edff0fd662c9();
public long queryResGetInvoiceAccountingProcessById_outParamCount = 0L;

public Actions.lcoInvoiceApprovalCreateOrUpdate resInvoiceApprovalCreateOrUpdate2 =  new Actions.lcoInvoiceApprovalCreateOrUpdate();
public Actions.lcoInvoiceApprovalLevelCreateOrUpdate resInvoiceApprovalLevelCreateOrUpdate =  new Actions.lcoInvoiceApprovalLevelCreateOrUpdate();
public RL_6dc54c806e79e3021c958eb2cb6d90be queryResGetLastInvoiceApprovalLevel_outParamList = new RL_6dc54c806e79e3021c958eb2cb6d90be();
public long queryResGetLastInvoiceApprovalLevel_outParamCount = 0L;

public Actions.lcoInvoiceLogAdd resInvoiceLogAddApprove5 =  new Actions.lcoInvoiceLogAdd();
public RL_b496b6dad8a76ef02aafdb1cf78f19ec queryResGetInvoiceApproval_outParamList = new RL_b496b6dad8a76ef02aafdb1cf78f19ec();
public long queryResGetInvoiceApproval_outParamCount = 0L;

public lcvInvAcc_6End(long inParamInvoiceAccountingProcessId, bool inParamIsError, bool inParamIsServiceError, string inParamErrorMsg) {
this.inParamInvoiceAccountingProcessId = inParamInvoiceAccountingProcessId;
this.inParamIsError = inParamIsError;
this.inParamIsServiceError = inParamIsServiceError;
this.inParamErrorMsg = inParamErrorMsg;
}
}
/// <summary>
/// Action <code>InvAcc_6End</code> that represents the Service Studio action <code>InvAcc_6End</code>
///  <p> Description: Save invoice approval levels and status</p>
/// </summary>
public static async Task ActionInvAcc_6End(IRequestContext requestContext,long inParamInvoiceAccountingProcessId,bool inParamIsError,bool inParamIsServiceError,string inParamErrorMsg,CancellationToken cancellationToken) {
lcvInvAcc_6End localVars = new lcvInvAcc_6End(inParamInvoiceAccountingProcessId, inParamIsError, inParamIsServiceError, inParamErrorMsg);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("InvAcc_6End", "ba587191-c7f9-49c6-b101-d481201e2958"))
using (activitySource.CreateServiceActionActivity("InvAcc_6End")){
// SetCurrentLocale
await ExtendedActions.SetCurrentLocale(requestContext,"es-MX",cancellationToken);

// Query datasetGetInvoiceAccountingProcessById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceAccountingProcessById_maxRecords = 1;
if (datasetGetInvoiceAccountingProcessById_maxRecords < 1) datasetGetInvoiceAccountingProcessById_maxRecords = 1;
int datasetGetInvoiceAccountingProcessById_startIndex = 0;(localVars.queryResGetInvoiceAccountingProcessById_outParamList,localVars.queryResGetInvoiceAccountingProcessById_outParamCount) = await FuncActionInvAcc_6End.datasetGetInvoiceAccountingProcessById(requestContext,datasetGetInvoiceAccountingProcessById_maxRecords,datasetGetInvoiceAccountingProcessById_startIndex,IterationMultiplicity.Never,localVars.inParamInvoiceAccountingProcessId,cancellationToken);

// InvoiceId = GetInvoiceAccountingProcessById.List.Current.InvoiceAccountingProcess.InvoiceId
localVars.varLcInvoiceId=localVars.queryResGetInvoiceAccountingProcessById_outParamList.CurrentRec.ssENInvoiceAccountingProcess.ssInvoiceId;
// Query datasetGetInvoiceById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceById_maxRecords = 1;
if (datasetGetInvoiceById_maxRecords < 1) datasetGetInvoiceById_maxRecords = 1;
int datasetGetInvoiceById_startIndex = 0;(localVars.queryResGetInvoiceById_outParamList,localVars.queryResGetInvoiceById_outParamCount) = await FuncActionInvAcc_6End.datasetGetInvoiceById(requestContext,datasetGetInvoiceById_maxRecords,datasetGetInvoiceById_startIndex,IterationMultiplicity.Never,localVars.varLcInvoiceId,cancellationToken);

if((localVars.inParamIsServiceError)) {
// Query datasetGetLastInvoiceApprovalLevel
cancellationToken.ThrowIfCancellationRequested();
int datasetGetLastInvoiceApprovalLevel_maxRecords = 0;
int datasetGetLastInvoiceApprovalLevel_startIndex = 0;(localVars.queryResGetLastInvoiceApprovalLevel_outParamList,localVars.queryResGetLastInvoiceApprovalLevel_outParamCount) = await FuncActionInvAcc_6End.datasetGetLastInvoiceApprovalLevel(requestContext,datasetGetLastInvoiceApprovalLevel_maxRecords,datasetGetLastInvoiceApprovalLevel_startIndex,IterationMultiplicity.Never,localVars.varLcInvoiceId,cancellationToken);

// GetLastInvoiceApprovalLevel.List.Current.InvoiceApprovalLevel.ApprovalStatusId = NotApproved
localVars.queryResGetLastInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssApprovalStatusId = (ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId;

// GetLastInvoiceApprovalLevel.List.Current.InvoiceApprovalLevel.ApprovedBy = NullTextIdentifier
localVars.queryResGetLastInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssApprovedBy = BuiltInFunction.NullTextIdentifier ();

// GetLastInvoiceApprovalLevel.List.Current.InvoiceApprovalLevel.ApprovedOn = NullDate
localVars.queryResGetLastInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssApprovedOn = BuiltInFunction.NullDate ();
// InvoiceApprovalLevelCreateOrUpdate
localVars.resInvoiceApprovalLevelCreateOrUpdate.outParamId = await Actions.ActionInvoiceApprovalLevelCreateOrUpdate(requestContext,localVars.queryResGetLastInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel,cancellationToken);

// InvoiceLogAddApprove4
localVars.resInvoiceLogAddApprove4.outParamId = await Actions.ActionInvoiceLogAdd(requestContext,new EN_bf34270fdd0f7785895f41a998e724e8EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssInvoiceId = localVars.varLcInvoiceId, ssMessage = (((((AppUtils.GetStringResource("ZPRnM_wJ3EGQQFxA38GycA#Value.-670115059.1", "Invoice")+" ")+localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssName)+" ")+AppUtils.GetStringResource("ZPRnM_wJ3EGQQFxA38GycA#Value.218867982.1", "sent back to same level. Please contact an administrator."))+(((localVars.inParamErrorMsg!="")) ? ((" - "+localVars.inParamErrorMsg)) : (""))), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssCreatedBy = BuiltInFunction.GetUserId (), ssIsError = true },cancellationToken);

// set InApproval_CxP
// GetInvoiceById.List.Current.Invoice.InvoiceStatusId = InApproval_CxP
localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssInvoiceStatusId = (ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("IImA0NKHIEiNrWap8beugQ"))).ssId;
// InvoiceCreateOrUpdate3
localVars.resInvoiceCreateOrUpdate3.outParamId = await Actions.ActionInvoiceCreateOrUpdate(requestContext,localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice,false,cancellationToken);

} else {
// Query datasetGetInvoiceApproval
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceApproval_maxRecords = 1;
if (datasetGetInvoiceApproval_maxRecords < 1) datasetGetInvoiceApproval_maxRecords = 1;
int datasetGetInvoiceApproval_startIndex = 0;(localVars.queryResGetInvoiceApproval_outParamList,localVars.queryResGetInvoiceApproval_outParamCount) = await FuncActionInvAcc_6End.datasetGetInvoiceApproval(requestContext,datasetGetInvoiceApproval_maxRecords,datasetGetInvoiceApproval_startIndex,IterationMultiplicity.Never,localVars.varLcInvoiceId,cancellationToken);

// error?
if(((localVars.inParamIsError&&(!((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveSkipAccountingError]))))))) {
// InvoiceLogAddApprove5
localVars.resInvoiceLogAddApprove5.outParamId = await Actions.ActionInvoiceLogAdd(requestContext,new EN_bf34270fdd0f7785895f41a998e724e8EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssInvoiceId = localVars.varLcInvoiceId, ssMessage = (((((AppUtils.GetStringResource("qfP6oIHAeEyoT2CnzJ2DAQ#Value.-670115059.1", "Invoice")+" ")+localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssName)+" ")+AppUtils.GetStringResource("qfP6oIHAeEyoT2CnzJ2DAQ#Value.1364093178.1", "had an accounting error and was sent back to the first user cxp."))+(((localVars.inParamErrorMsg!="")) ? ((" - "+localVars.inParamErrorMsg)) : (""))), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssCreatedBy = BuiltInFunction.GetUserId (), ssIsError = true },cancellationToken);

// Query datasetGetApprovalProcess
cancellationToken.ThrowIfCancellationRequested();
int datasetGetApprovalProcess_maxRecords = 1;
if (datasetGetApprovalProcess_maxRecords < 1) datasetGetApprovalProcess_maxRecords = 1;
int datasetGetApprovalProcess_startIndex = 0;(localVars.queryResGetApprovalProcess_outParamList,localVars.queryResGetApprovalProcess_outParamCount) = await FuncActionInvAcc_6End.datasetGetApprovalProcess(requestContext,datasetGetApprovalProcess_maxRecords,datasetGetApprovalProcess_startIndex,IterationMultiplicity.Never,localVars.queryResGetInvoiceApproval_outParamList.CurrentRec.ssENInvoiceApproval.ssAprovalProcessId,cancellationToken);

// ClearInvoiceApprovalAccounting
localVars.resClearInvoiceApprovalAccounting.outParamo_Output = await Actions.ActionClearInvoiceApprovalAccounting(requestContext,localVars.varLcInvoiceId,localVars.queryResGetApprovalProcess_outParamList.CurrentRec.ssENApprovalProcess.ssId,cancellationToken);

} else {
// GetInvoiceApproval.List.Current.InvoiceApproval.FinishedOn = CurrDateTime
localVars.queryResGetInvoiceApproval_outParamList.CurrentRec.ssENInvoiceApproval.ssFinishedOn = BuiltInFunction.CurrDateTime ();

// GetInvoiceById.List.Current.Invoice.InvoiceStatusId = ContabilizationSuccess
localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssInvoiceStatusId = (ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("h+R+u64a50K6vJ2dkkiVXQ"))).ssId;

// GetInvoiceApproval.List.Current.InvoiceApproval.MaxLevel = GetInvoiceApproval.List.Current.InvoiceApproval.CurrentLevel
localVars.queryResGetInvoiceApproval_outParamList.CurrentRec.ssENInvoiceApproval.ssMaxLevel = localVars.queryResGetInvoiceApproval_outParamList.CurrentRec.ssENInvoiceApproval.ssCurrentLevel;
// InvoiceApprovalCreateOrUpdate2
localVars.resInvoiceApprovalCreateOrUpdate2.outParamId = await Actions.ActionInvoiceApprovalCreateOrUpdate(requestContext,localVars.queryResGetInvoiceApproval_outParamList.CurrentRec.ssENInvoiceApproval,cancellationToken);

// InvoiceCreateOrUpdate
localVars.resInvoiceCreateOrUpdate.outParamId = await Actions.ActionInvoiceCreateOrUpdate(requestContext,localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice,false,cancellationToken);

// InvoiceLogAddApprove3
localVars.resInvoiceLogAddApprove3.outParamId = await Actions.ActionInvoiceLogAdd(requestContext,new EN_bf34270fdd0f7785895f41a998e724e8EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssInvoiceId = localVars.varLcInvoiceId, ssMessage = ((((((AppUtils.GetStringResource("5NL0Q9n8PUy0kXwzDme5Ew#Value.-670115059.1", "Invoice")+" ")+localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssName)+" ")+AppUtils.GetStringResource("5NL0Q9n8PUy0kXwzDme5Ew#Value.-336586051.1", "accounted with success"))+" - ")+localVars.queryResGetInvoiceAccountingProcessById_outParamList.CurrentRec.ssENInvoiceAccountingProcessResponse.ssTEXTO), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssCreatedBy = BuiltInFunction.GetUserId () },cancellationToken);

// InvoiceStatusHistoryCreateOrUpdate
localVars.resInvoiceStatusHistoryCreateOrUpdate.outParamId = await Actions.ActionInvoiceStatusHistoryCreateOrUpdate(requestContext,new EN_9edea2a401b6983c9ad50261c300f6d7EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssInvoiceId = localVars.varLcInvoiceId, ssInvoiceStatusId = (ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("4NyjEZqqGEqzQUUvdWYJqw"))).ssId, ssTimeStamp = BuiltInFunction.CurrDateTime (), ssCreatedBy = BuiltInFunction.GetUserId () },cancellationToken);

}

}

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

        public static class FuncActionInvAcc_6End {
            
// Query Function "GetApprovalProcess" TgtseCCbBkS8sROX2ZPY1A of Action "InvAcc_6End"
public static async Task<(RL_5e0ca6ca9da3af4b1d8149758c39c2cf,long)> datasetGetApprovalProcess(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qploId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InvAcc_6End.GetApprovalProcess", "786c0b4e-9b20-4406-bcb1-1397d993d8d4");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InvAcc_6End.GetApprovalProcess", "786c0b4e-9b20-4406-bcb1-1397d993d8d4", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /ServiceAPIMethods.kXFYuvnHxkmxAdSBIB4pWA/NodesNotShownInESpaceTree.TgtseCCbBkS8sROX2ZPY1A, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enapprovalprocess41\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18");
fromBuilder.Append(" FROM {ApprovalProcess} \"enapprovalprocess41\"");
whereBuilder.Append(" WHERE (\"enapprovalprocess41\".\"id\" = (@qploId))");
sqlCmd.CreateParameterWithoutReplacements("@qploId", DbType.Int64, qploId);
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
RL_5e0ca6ca9da3af4b1d8149758c39c2cf outParamList = new RL_5e0ca6ca9da3af4b1d8149758c39c2cf();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InvAcc_6End.GetApprovalProcess.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_5e0ca6ca9da3af4b1d8149758c39c2cf _tmp = new RL_5e0ca6ca9da3af4b1d8149758c39c2cf();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InvAcc_6End.GetApprovalProcess.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_5e0ca6ca9da3af4b1d8149758c39c2cf)_tmp;
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

private static async Task<RC_003d65e5661b449409d67ebedc16a923> datasetGetInvoiceByIdReadDbAsync(RC_003d65e5661b449409d67ebedc16a923 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoice.Read( r, ref index);
rec.ssENRequisition.Read( r, ref index);
return rec;
}
// Query Function "GetInvoiceById" aTgHqG8J_kOc2cxWtjVXcw of Action "InvAcc_6End"
public static async Task<(RL_4d0a053561fa4a3aef04e507b83b31d1,long)> datasetGetInvoiceById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoice_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InvAcc_6End.GetInvoiceById", "a8073869-096f-43fe-9cd9-cc56b6355773");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InvAcc_6End.GetInvoiceById", "a8073869-096f-43fe-9cd9-cc56b6355773", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /ServiceAPIMethods.kXFYuvnHxkmxAdSBIB4pWA/NodesNotShownInESpaceTree.aTgHqG8J_kOc2cxWtjVXcw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoice93\".\"id\" o0, \"eninvoice93\".\"name\" o1, \"eninvoice93\".\"requisitionid\" o2, \"eninvoice93\".\"folioid\" o3, \"eninvoice93\".\"ordermainid\" o4, \"eninvoice93\".\"cfditypeid\" o5, trim_scale(\"eninvoice93\".\"totalamount\"::numeric) o6, \"eninvoice93\".\"currency\" o7, \"eninvoice93\".\"invoicestatusid\" o8, \"eninvoice93\".\"accountingdatetime\" o9, \"eninvoice93\".\"paymentdatetime\" o10, \"eninvoice93\".\"createdon\" o11, \"eninvoice93\".\"createdby\" o12, \"eninvoice93\".\"updatedon\" o13, \"eninvoice93\".\"updatedby\" o14, \"eninvoice93\".\"submittedon\" o15, \"eninvoice93\".\"isnewversion\" o16, \"eninvoice93\".\"id_poliza\" o17, \"eninvoice93\".\"id_poliza_sap\" o18, \"eninvoice93\".\"doc51\" o19, \"eninvoice93\".\"accountingerror\" o20, \"eninvoice93\".\"orderaccconceptsid\" o21, trim_scale(\"eninvoice93\".\"amortization\"::numeric) o22, \"eninvoice93\".\"creditnoteinvoiceid\" o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81");
fromBuilder.Append(" FROM ({Invoice} \"eninvoice93\" Left JOIN {Requisition} \"enrequisition82\" ON (\"eninvoice93\".\"requisitionid\" = \"enrequisition82\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpinInvoice_Id != 0) {
whereBuilder.Append("((\"eninvoice93\".\"id\" = @qpinInvoice_Id) AND (\"eninvoice93\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoice_Id", DbType.Int64, qpinInvoice_Id);
} else {
whereBuilder.Append("(\"eninvoice93\".\"id\" IS NULL)");
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
RL_4d0a053561fa4a3aef04e507b83b31d1 outParamList = new RL_4d0a053561fa4a3aef04e507b83b31d1();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoiceByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InvAcc_6End.GetInvoiceById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_4d0a053561fa4a3aef04e507b83b31d1 _tmp = new RL_4d0a053561fa4a3aef04e507b83b31d1();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoiceByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InvAcc_6End.GetInvoiceById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_4d0a053561fa4a3aef04e507b83b31d1)_tmp;
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

private static async Task<RC_bec85b4f53f0fb643f61e8bb4fa47a4b> datasetGetInvoiceAccountingProcessByIdReadDbAsync(RC_bec85b4f53f0fb643f61e8bb4fa47a4b rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoiceAccountingProcess.Read( r, ref index);
rec.ssENInvoiceAccountingProcessResponse.Read( r, ref index);
return rec;
}
// Query Function "GetInvoiceAccountingProcessById" wMsrqsngk0SHprvTwS9CNA of Action "InvAcc_6End"
public static async Task<(RL_1337c15efa2eafb36e59edff0fd662c9,long)> datasetGetInvoiceAccountingProcessById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceAccountingProcess_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InvAcc_6End.GetInvoiceAccountingProcessById", "aa2bcbc0-e0c9-4493-87a6-bbd3c12f4234");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InvAcc_6End.GetInvoiceAccountingProcessById", "aa2bcbc0-e0c9-4493-87a6-bbd3c12f4234", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /ServiceAPIMethods.kXFYuvnHxkmxAdSBIB4pWA/NodesNotShownInESpaceTree.wMsrqsngk0SHprvTwS9CNA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"eninvoiceaccountingprocess20\".\"invoiceid\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, \"eninvoiceaccountingprocessresponse2\".\"texto\" o12, NULL o13, NULL o14");
fromBuilder.Append(" FROM ({InvoiceAccountingProcess} \"eninvoiceaccountingprocess20\" Left JOIN {InvoiceAccountingProcessResponse} \"eninvoiceaccountingprocessresponse2\" ON (\"eninvoiceaccountingprocess20\".\"id\" = \"eninvoiceaccountingprocessresponse2\".\"invoiceaccountingprocessid\")) ");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceAccountingProcess_Id != 0) {
whereBuilder.Append("((\"eninvoiceaccountingprocess20\".\"id\" = @qpinInvoiceAccountingProcess_Id) AND (\"eninvoiceaccountingprocess20\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceAccountingProcess_Id", DbType.Int64, qpinInvoiceAccountingProcess_Id);
} else {
whereBuilder.Append("(\"eninvoiceaccountingprocess20\".\"id\" IS NULL)");
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
RL_1337c15efa2eafb36e59edff0fd662c9 outParamList = new RL_1337c15efa2eafb36e59edff0fd662c9();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoiceAccountingProcessByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, false, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InvAcc_6End.GetInvoiceAccountingProcessById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_1337c15efa2eafb36e59edff0fd662c9 _tmp = new RL_1337c15efa2eafb36e59edff0fd662c9();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoiceAccountingProcessByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InvAcc_6End.GetInvoiceAccountingProcessById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_1337c15efa2eafb36e59edff0fd662c9)_tmp;
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

private static async Task<RC_bdad25a559cd2f146ec69d1aec036546> datasetGetLastInvoiceApprovalLevelReadDbAsync(RC_bdad25a559cd2f146ec69d1aec036546 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoiceApproval.Read( r, ref index);
rec.ssENInvoiceApprovalLevel.Read( r, ref index);
return rec;
}
// Query Function "GetLastInvoiceApprovalLevel" 3Tn_0ellqE+skjNcUsaQZQ of Action "InvAcc_6End"
public static async Task<(RL_6dc54c806e79e3021c958eb2cb6d90be,long)> datasetGetLastInvoiceApprovalLevel(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceApproval_InvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InvAcc_6End.GetLastInvoiceApprovalLevel", "d1ff39dd-65e9-4fa8-ac92-335c52c69065");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InvAcc_6End.GetLastInvoiceApprovalLevel", "d1ff39dd-65e9-4fa8-ac92-335c52c69065", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /ServiceAPIMethods.kXFYuvnHxkmxAdSBIB4pWA/NodesNotShownInESpaceTree.3Tn_0ellqE+skjNcUsaQZQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, \"eninvoiceapprovallevel30\".\"id\" o10, \"eninvoiceapprovallevel30\".\"invoiceapprovalid\" o11, \"eninvoiceapprovallevel30\".\"levelnumber\" o12, \"eninvoiceapprovallevel30\".\"assignedto\" o13, \"eninvoiceapprovallevel30\".\"applicationroleid\" o14, \"eninvoiceapprovallevel30\".\"entrajobtitle\" o15, \"eninvoiceapprovallevel30\".\"departmentid\" o16, \"eninvoiceapprovallevel30\".\"managementid\" o17, \"eninvoiceapprovallevel30\".\"subdirectionid\" o18, \"eninvoiceapprovallevel30\".\"entraroleid\" o19, \"eninvoiceapprovallevel30\".\"approvalstatusid\" o20, \"eninvoiceapprovallevel30\".\"canbefirstapprover\" o21, \"eninvoiceapprovallevel30\".\"selectsnextapprover\" o22, \"eninvoiceapprovallevel30\".\"selectsfirstapprover\" o23, \"eninvoiceapprovallevel30\".\"isaccounting\" o24, \"eninvoiceapprovallevel30\".\"isstartaccounting\" o25, \"eninvoiceapprovallevel30\".\"approvedby\" o26, \"eninvoiceapprovallevel30\".\"approvedon\" o27, \"eninvoiceapprovallevel30\".\"requesttomodifyby\" o28, \"eninvoiceapprovallevel30\".\"requesttomodifyon\" o29, \"eninvoiceapprovallevel30\".\"canceledby\" o30, \"eninvoiceapprovallevel30\".\"canceledon\" o31, \"eninvoiceapprovallevel30\".\"needscontract_deprec\" o32, \"eninvoiceapprovallevel30\".\"isreassigned\" o33, \"eninvoiceapprovallevel30\".\"issubstitutefor\" o34");
fromBuilder.Append(" FROM ({InvoiceApproval} \"eninvoiceapproval29\" Left JOIN {InvoiceApprovalLevel} \"eninvoiceapprovallevel30\" ON (\"eninvoiceapproval29\".\"id\" = \"eninvoiceapprovallevel30\".\"invoiceapprovalid\")) ");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceApproval_InvoiceId != 0) {
whereBuilder.Append("((\"eninvoiceapproval29\".\"invoiceid\" = @qpinInvoiceApproval_InvoiceId) AND (\"eninvoiceapproval29\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceApproval_InvoiceId", DbType.Int64, qpinInvoiceApproval_InvoiceId);
} else {
whereBuilder.Append("(\"eninvoiceapproval29\".\"invoiceid\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"eninvoiceapprovallevel30\".\"levelnumber\" DESC ");
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
RL_6dc54c806e79e3021c958eb2cb6d90be outParamList = new RL_6dc54c806e79e3021c958eb2cb6d90be();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetLastInvoiceApprovalLevelReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InvAcc_6End.GetLastInvoiceApprovalLevel.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_6dc54c806e79e3021c958eb2cb6d90be _tmp = new RL_6dc54c806e79e3021c958eb2cb6d90be();
_tmp.AlternateReadDbMethodAsync = datasetGetLastInvoiceApprovalLevelReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InvAcc_6End.GetLastInvoiceApprovalLevel.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_6dc54c806e79e3021c958eb2cb6d90be)_tmp;
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

// Query Function "GetInvoiceApproval" Vtfu_9IT+UqrXm59rqoJlw of Action "InvAcc_6End"
public static async Task<(RL_b496b6dad8a76ef02aafdb1cf78f19ec,long)> datasetGetInvoiceApproval(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InvAcc_6End.GetInvoiceApproval", "ffeed756-13d2-4af9-ab5e-6e7daeaa0997");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InvAcc_6End.GetInvoiceApproval", "ffeed756-13d2-4af9-ab5e-6e7daeaa0997", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /ServiceAPIMethods.kXFYuvnHxkmxAdSBIB4pWA/NodesNotShownInESpaceTree.Vtfu_9IT+UqrXm59rqoJlw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoiceapproval30\".\"id\" o0, \"eninvoiceapproval30\".\"invoiceid\" o1, \"eninvoiceapproval30\".\"aprovalprocessid\" o2, \"eninvoiceapproval30\".\"processtypecode\" o3, \"eninvoiceapproval30\".\"approvalprocessversion\" o4, \"eninvoiceapproval30\".\"currentlevel\" o5, \"eninvoiceapproval30\".\"maxlevel\" o6, \"eninvoiceapproval30\".\"startedon\" o7, \"eninvoiceapproval30\".\"finishedon\" o8, \"eninvoiceapproval30\".\"hasstartedaccounting\" o9");
fromBuilder.Append(" FROM {InvoiceApproval} \"eninvoiceapproval30\"");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceId != 0) {
whereBuilder.Append("((\"eninvoiceapproval30\".\"invoiceid\" = @qpinInvoiceId) AND (\"eninvoiceapproval30\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceId", DbType.Int64, qpinInvoiceId);
} else {
whereBuilder.Append("(\"eninvoiceapproval30\".\"invoiceid\" IS NULL)");
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
RL_b496b6dad8a76ef02aafdb1cf78f19ec outParamList = new RL_b496b6dad8a76ef02aafdb1cf78f19ec();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InvAcc_6End.GetInvoiceApproval.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_b496b6dad8a76ef02aafdb1cf78f19ec _tmp = new RL_b496b6dad8a76ef02aafdb1cf78f19ec();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InvAcc_6End.GetInvoiceApproval.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_b496b6dad8a76ef02aafdb1cf78f19ec)_tmp;
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
}
