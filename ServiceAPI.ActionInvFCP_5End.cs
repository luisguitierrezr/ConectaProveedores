using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using OutSystems.HubEdition.RuntimePlatform.Internal;
using OutSystems.RESTService;
using OutSystems.RESTService.Runtime.Core.Filters;
using OutSystems.RESTService.Runtime.Abstractions.PropertyAttributes;


namespace ssConectaProveedores;

public partial class ServiceAPIController : OutSystems.RESTService.Runtime.Core.Controllers.ServiceActions.ServiceActionsApiController {

    public class S4PIInvFCP_5EndInput {
[JsonProperty("InvoiceAccountingProcessId")]
public long? inParamInvoiceAccountingProcessId;
[JsonProperty("Message")]
public string inParamMessage;
[JsonProperty("IsSuccess")]
public bool? inParamIsSuccess;
public S4PIInvFCP_5EndInput(long? inParamInvoiceAccountingProcessId, string inParamMessage, bool? inParamIsSuccess) {
this.inParamInvoiceAccountingProcessId = inParamInvoiceAccountingProcessId;
this.inParamMessage = inParamMessage;
this.inParamIsSuccess = inParamIsSuccess;
}

}

public class S4PIInvFCP_5EndOutput {
public S4PIInvFCP_5EndOutput() {
}

}

[HttpPost()]
[Route("serviceapi/invfcp_5end")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "InvFCP_5End", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIInvFCP_5End(CancellationToken cancellationToken) {return await EndpointAsync<S4PIInvFCP_5EndInput, S4PIInvFCP_5EndOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
S4PIInvFCP_5EndInput inputs = serviceActionInput.InputParameters;
System.Collections.Generic.Dictionary<string,string[]> validationErrors = new System.Collections.Generic.Dictionary<string,string[]>();
if((inputs.inParamInvoiceAccountingProcessId == null)) {
validationErrors["InvoiceAccountingProcessId"]=new string[] {"The InvoiceAccountingProcessId mandatory parameter is missing in the request."};
}

if((inputs.inParamMessage == null)) {
validationErrors["Message"]=new string[] {"The Message mandatory parameter is missing in the request."};
}

if((inputs.inParamIsSuccess == null)) {
validationErrors["IsSuccess"]=new string[] {"The IsSuccess mandatory parameter is missing in the request."};
}

if(validationErrors.Any()) {
throw RestExposeErrorsHelper.BadRequest(validationErrors);
}

ctx.ThrowIfCancellationRequested();
await Flows.ActionInvFCP_5End(context,inputs.inParamInvoiceAccountingProcessId.Value,inputs.inParamMessage,inputs.inParamIsSuccess.Value,ctx);

return new S4PIInvFCP_5EndOutput();
}
, cancellationToken);
}



    public partial class Flows {
        public class lcvInvFCP_5End : VarsBag {
public long inParamInvoiceAccountingProcessId;
public string inParamMessage;
public bool inParamIsSuccess;
/// <summary>
/// Variable <code>LogMsg</code> that represents the Service Studio Text <code>LogMsg</code>
///  <p>Description: </p>
/// </summary>
public string varLcLogMsg = "";

/// <summary>
/// Variable <code>FolioStatusId</code> that represents the Service Studio FolioStatusIdentifier
///  <code>FolioStatusId</code> <p>Description: </p>
/// </summary>
public int varLcFolioStatusId = 0;

public RL_4f8b259bdd04db22be8fb771f1ad1d4f queryResGetFolioById_outParamList = new RL_4f8b259bdd04db22be8fb771f1ad1d4f();
public long queryResGetFolioById_outParamCount = 0L;

public Actions.lcoLogsAccountingCreate resLogsAccountingCreate =  new Actions.lcoLogsAccountingCreate();
public Actions.lcoFolioCreateOrUpdate resFolioCreateOrUpdate =  new Actions.lcoFolioCreateOrUpdate();
public Actions.lcoOrderLogAdd resOrderLogAdd =  new Actions.lcoOrderLogAdd();
public Actions.lcoFolioLogAdd resFolioLogAdd =  new Actions.lcoFolioLogAdd();
public Actions.lcoInvoiceCreateOrUpdate resInvoiceCreateOrUpdate =  new Actions.lcoInvoiceCreateOrUpdate();
public RL_94dfde238a1e776567d307c1f3f8a94e queryResGetInvoiceById_outParamList = new RL_94dfde238a1e776567d307c1f3f8a94e();
public long queryResGetInvoiceById_outParamCount = 0L;

public RL_4e909af3a15d1687c03c789af38db7ae queryResGetInvoiceAccountingProcessById_outParamList = new RL_4e909af3a15d1687c03c789af38db7ae();
public long queryResGetInvoiceAccountingProcessById_outParamCount = 0L;

public lcvInvFCP_5End(long inParamInvoiceAccountingProcessId, string inParamMessage, bool inParamIsSuccess) {
this.inParamInvoiceAccountingProcessId = inParamInvoiceAccountingProcessId;
this.inParamMessage = inParamMessage;
this.inParamIsSuccess = inParamIsSuccess;
}
}
/// <summary>
/// Action <code>InvFCP_5End</code> that represents the Service Studio action <code>InvFCP_5End</code>
///  <p> Description: </p>
/// </summary>
public static async Task ActionInvFCP_5End(IRequestContext requestContext,long inParamInvoiceAccountingProcessId,string inParamMessage,bool inParamIsSuccess,CancellationToken cancellationToken) {
lcvInvFCP_5End localVars = new lcvInvFCP_5End(inParamInvoiceAccountingProcessId, inParamMessage, inParamIsSuccess);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("InvFCP_5End", "6624b987-e407-4cab-9d32-bef2839c9c2c"))
using (activitySource.CreateServiceActionActivity("InvFCP_5End")){
// SetCurrentLocale
await ExtendedActions.SetCurrentLocale(requestContext,"es-MX",cancellationToken);

// Query datasetGetInvoiceAccountingProcessById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceAccountingProcessById_maxRecords = 1;
if (datasetGetInvoiceAccountingProcessById_maxRecords < 1) datasetGetInvoiceAccountingProcessById_maxRecords = 1;
int datasetGetInvoiceAccountingProcessById_startIndex = 0;(localVars.queryResGetInvoiceAccountingProcessById_outParamList,localVars.queryResGetInvoiceAccountingProcessById_outParamCount) = await FuncActionInvFCP_5End.datasetGetInvoiceAccountingProcessById(requestContext,datasetGetInvoiceAccountingProcessById_maxRecords,datasetGetInvoiceAccountingProcessById_startIndex,IterationMultiplicity.Never,localVars.inParamInvoiceAccountingProcessId,cancellationToken);

// Query datasetGetInvoiceById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceById_maxRecords = 1;
if (datasetGetInvoiceById_maxRecords < 1) datasetGetInvoiceById_maxRecords = 1;
int datasetGetInvoiceById_startIndex = 0;(localVars.queryResGetInvoiceById_outParamList,localVars.queryResGetInvoiceById_outParamCount) = await FuncActionInvFCP_5End.datasetGetInvoiceById(requestContext,datasetGetInvoiceById_maxRecords,datasetGetInvoiceById_startIndex,IterationMultiplicity.Never,localVars.queryResGetInvoiceAccountingProcessById_outParamList.CurrentRec.ssENInvoiceAccountingProcess.ssInvoiceId,cancellationToken);

// LogsAccountingCreate
localVars.resLogsAccountingCreate.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = "FCP Inv Accounting - On End", ssDescription = (((((((((((AppUtils.GetStringResource("BRtXQyUQcU2mK5qucMYQGw#Value.701269683.1", "Invoice ")+BuiltInFunction.LongIntegerToText(localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssId))+" - ")+localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssName)+" // Order ")+BuiltInFunction.LongIntegerToText(localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssOrderMainId))+" - ")+localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENOrderMain.ssOrderNumber)+" // Folio ")+BuiltInFunction.LongIntegerToText(localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssFolioId))+" || Success: ")+(localVars.inParamIsSuccess ? "True" : "False")), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("KTnl+i02eUSozHPzTg81rA"))).ssId },cancellationToken);

// error
if(((!localVars.inParamIsSuccess))) {
// LogMsg = "File" + " " + GetInvoiceById.List.Current.Invoice.Name + " " + "finished the accounting process with an error" + " - " + Message
localVars.varLcLogMsg=((((((AppUtils.GetStringResource("i5IBJ47FPkiZP+v9iQ8lvQ#Value.2189724.1", "File")+" ")+localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssName)+" ")+AppUtils.GetStringResource("i5IBJ47FPkiZP+v9iQ8lvQ#Value.2144532464.1", "finished the accounting process with an error"))+" - ")+localVars.inParamMessage);

// GetInvoiceById.List.Current.Invoice.InvoiceStatusId = ContabilizationError
localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssInvoiceStatusId = (ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("CJKmpdl1bUqOtDMY59Vg9Q"))).ssId;

// FolioStatusId = ContabilizationError
localVars.varLcFolioStatusId=(ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("Di5a7BHsfkq06ZPVPBbZxg"))).ssId;
} else {
// LogMsg = "File" + " " + GetInvoiceById.List.Current.Invoice.Name + " " + "has successfully finished the accounting process" + " - " + Message
localVars.varLcLogMsg=((((((AppUtils.GetStringResource("b0gH0KM0fUmziEwo9pxOOQ#Value.2189724.1", "File")+" ")+localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssName)+" ")+AppUtils.GetStringResource("b0gH0KM0fUmziEwo9pxOOQ#Value.-1813643090.1", "has successfully finished the accounting process"))+" - ")+localVars.inParamMessage);

// GetInvoiceById.List.Current.Invoice.InvoiceStatusId = ContabilizationSuccess
localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssInvoiceStatusId = (ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("h+R+u64a50K6vJ2dkkiVXQ"))).ssId;

// FolioStatusId = ContabilizationSuccess
localVars.varLcFolioStatusId=(ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("Sibqk6dY7UGlZ5CDRDlXsg"))).ssId;
}

// OrderLogAdd
localVars.resOrderLogAdd.outParamId = await Actions.ActionOrderLogAdd(requestContext,new EN_a8e484428097204171df8a1feecb2534EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssOrderId = localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssOrderMainId, ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssMessage = localVars.varLcLogMsg, ssIsError = (!localVars.inParamIsSuccess) },cancellationToken);

// has folio
if(((localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssFolioId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// Query datasetGetFolioById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioById_maxRecords = 1;
if (datasetGetFolioById_maxRecords < 1) datasetGetFolioById_maxRecords = 1;
int datasetGetFolioById_startIndex = 0;(localVars.queryResGetFolioById_outParamList,localVars.queryResGetFolioById_outParamCount) = await FuncActionInvFCP_5End.datasetGetFolioById(requestContext,datasetGetFolioById_maxRecords,datasetGetFolioById_startIndex,IterationMultiplicity.Never,localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssFolioId,cancellationToken);

// Set ContabilizationSuccess
// GetFolioById.List.Current.Folio.FolioStatusId = FolioStatusId
localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssFolioStatusId = localVars.varLcFolioStatusId;
// FolioCreateOrUpdate
localVars.resFolioCreateOrUpdate.outParamId = await Actions.ActionFolioCreateOrUpdate(requestContext,localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio,cancellationToken);

// FolioLogAdd
localVars.resFolioLogAdd.outParamId = await Actions.ActionFolioLogAdd(requestContext,new EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssFolioId = localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssFolioId, ssMessage = localVars.varLcLogMsg, ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssIsError = (!localVars.inParamIsSuccess), ssIsForSupplier = true },cancellationToken);

}

// InvoiceCreateOrUpdate
localVars.resInvoiceCreateOrUpdate.outParamId = await Actions.ActionInvoiceCreateOrUpdate(requestContext,localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice,false,cancellationToken);

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

        public static class FuncActionInvFCP_5End {
            
// Query Function "GetFolioById" Fx7MBc6z1EiaMDPINH_gCg of Action "InvFCP_5End"
public static async Task<(RL_4f8b259bdd04db22be8fb771f1ad1d4f,long)> datasetGetFolioById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InvFCP_5End.GetFolioById", "05cc1e17-b3ce-48d4-9a30-33c8347fe00a");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InvFCP_5End.GetFolioById", "05cc1e17-b3ce-48d4-9a30-33c8347fe00a", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /ServiceAPIMethods.h7kkZgfkq0ydMr7yg5ycLA/NodesNotShownInESpaceTree.Fx7MBc6z1EiaMDPINH_gCg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enfolio61\".\"id\" o0, \"enfolio61\".\"isdraft\" o1, \"enfolio61\".\"folionumber\" o2, \"enfolio61\".\"canproveedorcancel\" o3, \"enfolio61\".\"orderid\" o4, \"enfolio61\".\"supplierid\" o5, \"enfolio61\".\"companyid\" o6, \"enfolio61\".\"foliostatusid\" o7, trim_scale(\"enfolio61\".\"totalamount\"::numeric) o8, trim_scale(\"enfolio61\".\"totaliva_amount\"::numeric) o9, trim_scale(\"enfolio61\".\"partialamount\"::numeric) o10, \"enfolio61\".\"currencyid\" o11, \"enfolio61\".\"firstapproveruserid\" o12, \"enfolio61\".\"approvalprocesstypeid\" o13, \"enfolio61\".\"sapentryerror\" o14, \"enfolio61\".\"createdby\" o15, \"enfolio61\".\"createdon\" o16, \"enfolio61\".\"updatedby\" o17, \"enfolio61\".\"updatedon\" o18, \"enfolio61\".\"minuteselected\" o19");
fromBuilder.Append(" FROM {Folio} \"enfolio61\"");
whereBuilder.Append(" WHERE ");
if (qpfoId != 0) {
whereBuilder.Append("((\"enfolio61\".\"id\" = @qpfoId) AND (\"enfolio61\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoId", DbType.Int64, qpfoId);
} else {
whereBuilder.Append("(\"enfolio61\".\"id\" IS NULL)");
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
RL_4f8b259bdd04db22be8fb771f1ad1d4f outParamList = new RL_4f8b259bdd04db22be8fb771f1ad1d4f();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InvFCP_5End.GetFolioById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_4f8b259bdd04db22be8fb771f1ad1d4f _tmp = new RL_4f8b259bdd04db22be8fb771f1ad1d4f();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InvFCP_5End.GetFolioById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_4f8b259bdd04db22be8fb771f1ad1d4f)_tmp;
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

private static async Task<RC_7ea2828a21285060cce33ce8e91b5455> datasetGetInvoiceByIdReadDbAsync(RC_7ea2828a21285060cce33ce8e91b5455 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoice.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
return rec;
}
// Query Function "GetInvoiceById" Fm593ZMnbkql0yoVIP8hbA of Action "InvFCP_5End"
public static async Task<(RL_94dfde238a1e776567d307c1f3f8a94e,long)> datasetGetInvoiceById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoice_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InvFCP_5End.GetInvoiceById", "dd7d6e16-2793-4a6e-a5d3-2a1520ff216c");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InvFCP_5End.GetInvoiceById", "dd7d6e16-2793-4a6e-a5d3-2a1520ff216c", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /ServiceAPIMethods.h7kkZgfkq0ydMr7yg5ycLA/NodesNotShownInESpaceTree.Fm593ZMnbkql0yoVIP8hbA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoice85\".\"id\" o0, \"eninvoice85\".\"name\" o1, \"eninvoice85\".\"requisitionid\" o2, \"eninvoice85\".\"folioid\" o3, \"eninvoice85\".\"ordermainid\" o4, \"eninvoice85\".\"cfditypeid\" o5, trim_scale(\"eninvoice85\".\"totalamount\"::numeric) o6, \"eninvoice85\".\"currency\" o7, \"eninvoice85\".\"invoicestatusid\" o8, \"eninvoice85\".\"accountingdatetime\" o9, \"eninvoice85\".\"paymentdatetime\" o10, \"eninvoice85\".\"createdon\" o11, \"eninvoice85\".\"createdby\" o12, \"eninvoice85\".\"updatedon\" o13, \"eninvoice85\".\"updatedby\" o14, \"eninvoice85\".\"submittedon\" o15, \"eninvoice85\".\"isnewversion\" o16, \"eninvoice85\".\"id_poliza\" o17, \"eninvoice85\".\"id_poliza_sap\" o18, \"eninvoice85\".\"doc51\" o19, \"eninvoice85\".\"accountingerror\" o20, \"eninvoice85\".\"orderaccconceptsid\" o21, trim_scale(\"eninvoice85\".\"amortization\"::numeric) o22, \"eninvoice85\".\"creditnoteinvoiceid\" o23, NULL o24, \"enordermain71\".\"ordernumber\" o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52");
fromBuilder.Append(" FROM ({Invoice} \"eninvoice85\" Left JOIN {OrderMain} \"enordermain71\" ON (\"eninvoice85\".\"ordermainid\" = \"enordermain71\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpinInvoice_Id != 0) {
whereBuilder.Append("((\"eninvoice85\".\"id\" = @qpinInvoice_Id) AND (\"eninvoice85\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoice_Id", DbType.Int64, qpinInvoice_Id);
} else {
whereBuilder.Append("(\"eninvoice85\".\"id\" IS NULL)");
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
RL_94dfde238a1e776567d307c1f3f8a94e outParamList = new RL_94dfde238a1e776567d307c1f3f8a94e();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoiceByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InvFCP_5End.GetInvoiceById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_94dfde238a1e776567d307c1f3f8a94e _tmp = new RL_94dfde238a1e776567d307c1f3f8a94e();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoiceByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InvFCP_5End.GetInvoiceById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_94dfde238a1e776567d307c1f3f8a94e)_tmp;
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

// Query Function "GetInvoiceAccountingProcessById" CknG6HgroE28WOoSDYnNag of Action "InvFCP_5End"
public static async Task<(RL_4e909af3a15d1687c03c789af38db7ae,long)> datasetGetInvoiceAccountingProcessById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InvFCP_5End.GetInvoiceAccountingProcessById", "e8c6490a-2b78-4da0-bc58-ea120d89cd6a");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InvFCP_5End.GetInvoiceAccountingProcessById", "e8c6490a-2b78-4da0-bc58-ea120d89cd6a", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /ServiceAPIMethods.h7kkZgfkq0ydMr7yg5ycLA/NodesNotShownInESpaceTree.CknG6HgroE28WOoSDYnNag, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"eninvoiceaccountingprocess15\".\"invoiceid\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8");
fromBuilder.Append(" FROM {InvoiceAccountingProcess} \"eninvoiceaccountingprocess15\"");
whereBuilder.Append(" WHERE ");
if (qpinId != 0) {
whereBuilder.Append("((\"eninvoiceaccountingprocess15\".\"id\" = @qpinId) AND (\"eninvoiceaccountingprocess15\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinId", DbType.Int64, qpinId);
} else {
whereBuilder.Append("(\"eninvoiceaccountingprocess15\".\"id\" IS NULL)");
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
RL_4e909af3a15d1687c03c789af38db7ae outParamList = new RL_4e909af3a15d1687c03c789af38db7ae();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InvFCP_5End.GetInvoiceAccountingProcessById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_4e909af3a15d1687c03c789af38db7ae _tmp = new RL_4e909af3a15d1687c03c789af38db7ae();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InvFCP_5End.GetInvoiceAccountingProcessById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_4e909af3a15d1687c03c789af38db7ae)_tmp;
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
