using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using OutSystems.HubEdition.RuntimePlatform.Internal;
using OutSystems.RESTService;
using OutSystems.RESTService.Runtime.Core.Filters;
using OutSystems.RESTService.Runtime.Abstractions.PropertyAttributes;


namespace ssConectaProveedores;

public partial class ServiceAPIController : OutSystems.RESTService.Runtime.Core.Controllers.ServiceActions.ServiceActionsApiController {

    public class S4PIInvFCP_1CallAccountingInput {
[JsonProperty("InvoiceAccountingProcessId")]
public long? inParamInvoiceAccountingProcessId;
public S4PIInvFCP_1CallAccountingInput(long? inParamInvoiceAccountingProcessId) {
this.inParamInvoiceAccountingProcessId = inParamInvoiceAccountingProcessId;
}

}

public class S4PIInvFCP_1CallAccountingOutput {
[JsonProperty("IsAmortization")]
public bool outParamIsAmortization;
public S4PIInvFCP_1CallAccountingOutput(bool outParamIsAmortization) {
this.outParamIsAmortization = outParamIsAmortization;
}

public bool ShouldSerializeoutParamIsAmortization() {return (this.outParamIsAmortization != false);
}
}

[HttpPost()]
[Route("serviceapi/invfcp_1callaccounting")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "InvFCP_1CallAccounting", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIInvFCP_1CallAccounting(CancellationToken cancellationToken) {return await EndpointAsync<S4PIInvFCP_1CallAccountingInput, S4PIInvFCP_1CallAccountingOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
bool outParamIsAmortization;
S4PIInvFCP_1CallAccountingInput inputs = serviceActionInput.InputParameters;
System.Collections.Generic.Dictionary<string,string[]> validationErrors = new System.Collections.Generic.Dictionary<string,string[]>();
if((inputs.inParamInvoiceAccountingProcessId == null)) {
validationErrors["InvoiceAccountingProcessId"]=new string[] {"The InvoiceAccountingProcessId mandatory parameter is missing in the request."};
}

if(validationErrors.Any()) {
throw RestExposeErrorsHelper.BadRequest(validationErrors);
}

ctx.ThrowIfCancellationRequested();
outParamIsAmortization = await Flows.ActionInvFCP_1CallAccounting(context,inputs.inParamInvoiceAccountingProcessId.Value,ctx);

return new S4PIInvFCP_1CallAccountingOutput(outParamIsAmortization);
}
, cancellationToken);
}



    public partial class Flows {
        public class lcvInvFCP_1CallAccounting : VarsBag {
public long inParamInvoiceAccountingProcessId;
/// <summary>
/// Variable <code>l_StartedOn</code> that represents the Service Studio DateTime
///  <code>l_StartedOn</code> <p>Description: </p>
/// </summary>
public DateTime varLcl_StartedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);

public Actions.lcoEntryAccounting_CheckRetentionsException resEntryAccounting_CheckRetentionsException =  new Actions.lcoEntryAccounting_CheckRetentionsException();
public RL_5b87df59357fc2d11e377efaebb2d7d6 queryResGetInvoiceAccountingProcessById_outParamList = new RL_5b87df59357fc2d11e377efaebb2d7d6();
public long queryResGetInvoiceAccountingProcessById_outParamCount = 0L;

public Actions.lcoLogsAccountingCreate resLogsAccountingCreate =  new Actions.lcoLogsAccountingCreate();
public Actions.lcoOrderLogAdd resOrderLogAdd =  new Actions.lcoOrderLogAdd();
public Actions.lcoFolioLogAdd resFolioLogAdd =  new Actions.lcoFolioLogAdd();
public RL_fdf4c80e3fbd3f0ec2f926acd9363b33 queryResGetInvoiceById_outParamList = new RL_fdf4c80e3fbd3f0ec2f926acd9363b33();
public long queryResGetInvoiceById_outParamCount = 0L;

public lcvInvFCP_1CallAccounting(long inParamInvoiceAccountingProcessId) {
this.inParamInvoiceAccountingProcessId = inParamInvoiceAccountingProcessId;
}
}
public class lcoInvFCP_1CallAccounting : VarsBag {
public bool outParamIsAmortization = false;

public lcoInvFCP_1CallAccounting() {
}
}
/// <summary>
/// Action <code>InvFCP_1CallAccounting</code> that represents the Service Studio action
///  <code>InvFCP_1CallAccounting</code> <p> Description: </p>
/// </summary>
public static async Task<bool> ActionInvFCP_1CallAccounting(IRequestContext requestContext,long inParamInvoiceAccountingProcessId,CancellationToken cancellationToken) {
bool outParamIsAmortization = default;
lcoInvFCP_1CallAccounting result = new lcoInvFCP_1CallAccounting();
lcvInvFCP_1CallAccounting localVars = new lcvInvFCP_1CallAccounting(inParamInvoiceAccountingProcessId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("InvFCP_1CallAccounting", "81e1cbed-b980-477c-a233-9e03edb148ec"))
using (activitySource.CreateServiceActionActivity("InvFCP_1CallAccounting")){
// Query datasetGetInvoiceAccountingProcessById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceAccountingProcessById_maxRecords = 1;
if (datasetGetInvoiceAccountingProcessById_maxRecords < 1) datasetGetInvoiceAccountingProcessById_maxRecords = 1;
int datasetGetInvoiceAccountingProcessById_startIndex = 0;(localVars.queryResGetInvoiceAccountingProcessById_outParamList,localVars.queryResGetInvoiceAccountingProcessById_outParamCount) = await FuncActionInvFCP_1CallAccounting.datasetGetInvoiceAccountingProcessById(requestContext,datasetGetInvoiceAccountingProcessById_maxRecords,datasetGetInvoiceAccountingProcessById_startIndex,IterationMultiplicity.Never,localVars.inParamInvoiceAccountingProcessId,cancellationToken);

// l_StartedOn = CurrDateTime
localVars.varLcl_StartedOn=BuiltInFunction.CurrDateTime ();
// SetCurrentLocale
await ExtendedActions.SetCurrentLocale(requestContext,"es-MX",cancellationToken);

// Query datasetGetInvoiceById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceById_maxRecords = 1;
if (datasetGetInvoiceById_maxRecords < 1) datasetGetInvoiceById_maxRecords = 1;
int datasetGetInvoiceById_startIndex = 0;(localVars.queryResGetInvoiceById_outParamList,localVars.queryResGetInvoiceById_outParamCount) = await FuncActionInvFCP_1CallAccounting.datasetGetInvoiceById(requestContext,datasetGetInvoiceById_maxRecords,datasetGetInvoiceById_startIndex,IterationMultiplicity.Never,localVars.queryResGetInvoiceAccountingProcessById_outParamList.CurrentRec.ssENInvoiceAccountingProcess.ssInvoiceId,cancellationToken);

// EntryAccounting_CheckRetentionsException
localVars.resEntryAccounting_CheckRetentionsException.outParamCountRetentions = await Actions.ActionEntryAccounting_CheckRetentionsException(requestContext,localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssId,localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssOrderAccConceptsID,cancellationToken);

// is amortization
if((((localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssAmortization!=(((decimal)0)))||(localVars.resEntryAccounting_CheckRetentionsException.outParamCountRetentions>=2)))) {
// EntryAccountingRequest_OnAmortization
await Actions.ActionEntryAccountingRequest_OnAmortization(requestContext,localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice,localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENFolio,localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENOrderMain,cancellationToken);

// IsAmortization = True
result.outParamIsAmortization=true;
} else {
// OrderLogAdd
localVars.resOrderLogAdd.outParamId = await Actions.ActionOrderLogAdd(requestContext,new EN_a8e484428097204171df8a1feecb2534EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssOrderId = localVars.queryResGetInvoiceAccountingProcessById_outParamList.CurrentRec.ssENInvoice.ssOrderMainId, ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssMessage = (((((AppUtils.GetStringResource("unFZuJ+0H0q3TgMkvOnwmA#Value.2189724.1", "File")+" ")+localVars.queryResGetInvoiceAccountingProcessById_outParamList.CurrentRec.ssENInvoice.ssName)+" ")+AppUtils.GetStringResource("unFZuJ+0H0q3TgMkvOnwmA#Value.970177874.1", "has started an accounting process"))+".") },cancellationToken);

// has folio
if(((localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssFolioId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// FolioLogAdd
localVars.resFolioLogAdd.outParamId = await Actions.ActionFolioLogAdd(requestContext,new EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssFolioId = localVars.queryResGetInvoiceAccountingProcessById_outParamList.CurrentRec.ssENInvoice.ssFolioId, ssMessage = (((((AppUtils.GetStringResource("hsNzGpeLekGelbKKHC9cmQ#Value.2189724.1", "File")+" ")+localVars.queryResGetInvoiceAccountingProcessById_outParamList.CurrentRec.ssENInvoice.ssName)+" ")+AppUtils.GetStringResource("hsNzGpeLekGelbKKHC9cmQ#Value.970177874.1", "has started an accounting process"))+"."), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssIsError = false, ssIsForSupplier = true },cancellationToken);

}

// LogsAccountingCreate
localVars.resLogsAccountingCreate.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = AppUtils.GetStringResource("i+QpyonJQU6Qz_h4KPoJpQ#Value.-579364467.1", "Document type for accounting"), ssAssociatedId = ("Process "+BuiltInFunction.LongIntegerToText(localVars.inParamInvoiceAccountingProcessId)), ssDescription = ((((((AppUtils.GetStringResource("z5KciKg0aEyS+diZ8ITCDg#Value.-670115059.1", "Invoice")+": ")+localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssName)+" // Folio: ")+localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENFolio.ssFolioNumber)+" // CFDI Type: ")+localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENAccountingDataType.ssLabel), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("KTnl+i02eUSozHPzTg81rA"))).ssId },cancellationToken);

}

} //close CreateActionActivity using block
} // try

finally {
outParamIsAmortization = result.outParamIsAmortization;
} // inner-finally
RETURN_STATEMENT:
return outParamIsAmortization;
}

        public static class FuncActionInvFCP_1CallAccounting {
            
private static async Task<RC_23a1d959d7c6821c1ced3d87b6f84ab7> datasetGetInvoiceAccountingProcessByIdReadDbAsync(RC_23a1d959d7c6821c1ced3d87b6f84ab7 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceAccountingProcess.Read( r, ref index);
return rec;
}
// Query Function "GetInvoiceAccountingProcessById" jMbbffms9EKc2sYM3k1I3Q of Action "InvFCP_1CallAccounting"
public static async Task<(RL_5b87df59357fc2d11e377efaebb2d7d6,long)> datasetGetInvoiceAccountingProcessById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceAccountingProcess_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InvFCP_1CallAccounting.GetInvoiceAccountingProcessById", "7ddbc68c-acf9-42f4-9cda-c60cde4d48dd");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InvFCP_1CallAccounting.GetInvoiceAccountingProcessById", "7ddbc68c-acf9-42f4-9cda-c60cde4d48dd", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /ServiceAPIMethods.7cvhgYC5fEeiM54D7bFI7A/NodesNotShownInESpaceTree.jMbbffms9EKc2sYM3k1I3Q, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"eninvoice86\".\"name\" o1, NULL o2, \"eninvoice86\".\"folioid\" o3, \"eninvoice86\".\"ordermainid\" o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, \"eninvoiceaccountingprocess16\".\"invoiceid\" o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32");
fromBuilder.Append(" FROM ({InvoiceAccountingProcess} \"eninvoiceaccountingprocess16\" Left JOIN {Invoice} \"eninvoice86\" ON (\"eninvoiceaccountingprocess16\".\"invoiceid\" = \"eninvoice86\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceAccountingProcess_Id != 0) {
whereBuilder.Append("((\"eninvoiceaccountingprocess16\".\"id\" = @qpinInvoiceAccountingProcess_Id) AND (\"eninvoiceaccountingprocess16\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceAccountingProcess_Id", DbType.Int64, qpinInvoiceAccountingProcess_Id);
} else {
whereBuilder.Append("(\"eninvoiceaccountingprocess16\".\"id\" IS NULL)");
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
RL_5b87df59357fc2d11e377efaebb2d7d6 outParamList = new RL_5b87df59357fc2d11e377efaebb2d7d6();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoiceAccountingProcessByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, false, true, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InvFCP_1CallAccounting.GetInvoiceAccountingProcessById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_5b87df59357fc2d11e377efaebb2d7d6 _tmp = new RL_5b87df59357fc2d11e377efaebb2d7d6();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoiceAccountingProcessByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InvFCP_1CallAccounting.GetInvoiceAccountingProcessById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_5b87df59357fc2d11e377efaebb2d7d6)_tmp;
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

private static async Task<RC_9ae567d0cf6d3095d7119747b95be259> datasetGetInvoiceByIdReadDbAsync(RC_9ae567d0cf6d3095d7119747b95be259 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENAccountingDataType.Read( r, ref index);
rec.ssENFolio.Read( r, ref index);
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceFile.Read( r, ref index);
rec.ssENOrderAccConcepts.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
return rec;
}
// Query Function "GetInvoiceById" ZNSQytsty0uerbfG9fy2xQ of Action "InvFCP_1CallAccounting"
public static async Task<(RL_fdf4c80e3fbd3f0ec2f926acd9363b33,long)> datasetGetInvoiceById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoice_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InvFCP_1CallAccounting.GetInvoiceById", "ca90d464-2ddb-4bcb-9ead-b7c6f5fcb6c5");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InvFCP_1CallAccounting.GetInvoiceById", "ca90d464-2ddb-4bcb-9ead-b7c6f5fcb6c5", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /ServiceAPIMethods.7cvhgYC5fEeiM54D7bFI7A/NodesNotShownInESpaceTree.ZNSQytsty0uerbfG9fy2xQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enaccountingdatatype7\".\"label\" o1, NULL o2, NULL o3, NULL o4, \"enfolio62\".\"id\" o5, \"enfolio62\".\"isdraft\" o6, \"enfolio62\".\"folionumber\" o7, \"enfolio62\".\"canproveedorcancel\" o8, \"enfolio62\".\"orderid\" o9, \"enfolio62\".\"supplierid\" o10, \"enfolio62\".\"companyid\" o11, \"enfolio62\".\"foliostatusid\" o12, trim_scale(\"enfolio62\".\"totalamount\"::numeric) o13, trim_scale(\"enfolio62\".\"totaliva_amount\"::numeric) o14, trim_scale(\"enfolio62\".\"partialamount\"::numeric) o15, \"enfolio62\".\"currencyid\" o16, \"enfolio62\".\"firstapproveruserid\" o17, \"enfolio62\".\"approvalprocesstypeid\" o18, \"enfolio62\".\"sapentryerror\" o19, \"enfolio62\".\"createdby\" o20, \"enfolio62\".\"createdon\" o21, \"enfolio62\".\"updatedby\" o22, \"enfolio62\".\"updatedon\" o23, \"enfolio62\".\"minuteselected\" o24, \"eninvoice87\".\"id\" o25, \"eninvoice87\".\"name\" o26, \"eninvoice87\".\"requisitionid\" o27, \"eninvoice87\".\"folioid\" o28, \"eninvoice87\".\"ordermainid\" o29, \"eninvoice87\".\"cfditypeid\" o30, trim_scale(\"eninvoice87\".\"totalamount\"::numeric) o31, \"eninvoice87\".\"currency\" o32, \"eninvoice87\".\"invoicestatusid\" o33, \"eninvoice87\".\"accountingdatetime\" o34, \"eninvoice87\".\"paymentdatetime\" o35, \"eninvoice87\".\"createdon\" o36, \"eninvoice87\".\"createdby\" o37, \"eninvoice87\".\"updatedon\" o38, \"eninvoice87\".\"updatedby\" o39, \"eninvoice87\".\"submittedon\" o40, \"eninvoice87\".\"isnewversion\" o41, \"eninvoice87\".\"id_poliza\" o42, \"eninvoice87\".\"id_poliza_sap\" o43, \"eninvoice87\".\"doc51\" o44, \"eninvoice87\".\"accountingerror\" o45, \"eninvoice87\".\"orderaccconceptsid\" o46, trim_scale(\"eninvoice87\".\"amortization\"::numeric) o47, \"eninvoice87\".\"creditnoteinvoiceid\" o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, \"enordermain72\".\"id\" o71, \"enordermain72\".\"ordernumber\" o72, \"enordermain72\".\"orderdate\" o73, \"enordermain72\".\"orderstatusid\" o74, \"enordermain72\".\"previousorderstatusid\" o75, \"enordermain72\".\"assignmentcode\" o76, \"enordermain72\".\"supplierid\" o77, \"enordermain72\".\"companyid\" o78, \"enordermain72\".\"documenttypeid\" o79, \"enordermain72\".\"currencyid\" o80, \"enordermain72\".\"telceldirectionid\" o81, \"enordermain72\".\"procurementgroup\" o82, \"enordermain72\".\"creatorsapnumber\" o83, \"enordermain72\".\"creatorsapname\" o84, \"enordermain72\".\"country\" o85, \"enordermain72\".\"isdeleted\" o86, \"enordermain72\".\"isreleased\" o87, trim_scale(\"enordermain72\".\"exchangerate\"::numeric) o88, \"enordermain72\".\"sustainabilitycategory\" o89, \"enordermain72\".\"sustainabilitysubcategory\" o90, trim_scale(\"enordermain72\".\"totalamount\"::numeric) o91, \"enordermain72\".\"fromcosmoz\" o92, \"enordermain72\".\"regionid\" o93, \"enordermain72\".\"divisionid\" o94, \"enordermain72\".\"applicant\" o95, \"enordermain72\".\"createdby\" o96, \"enordermain72\".\"createdon\" o97, \"enordermain72\".\"updatedby\" o98, \"enordermain72\".\"updatedon\" o99");
fromBuilder.Append(" FROM ((((({Invoice} \"eninvoice87\" Inner JOIN {InvoiceFile} \"eninvoicefile28\" ON (\"eninvoice87\".\"id\" = \"eninvoicefile28\".\"invoiceid\"))  Left JOIN {Folio} \"enfolio62\" ON (\"eninvoice87\".\"folioid\" = \"enfolio62\".\"id\"))  Left JOIN {OrderAccConcepts} \"enorderaccconcepts9\" ON (\"eninvoice87\".\"orderaccconceptsid\" = \"enorderaccconcepts9\".\"id\"))  Left JOIN {AccountingDataType} \"enaccountingdatatype7\" ON (\"enorderaccconcepts9\".\"accountingdatatypeid\" = \"enaccountingdatatype7\".\"id\"))  Left JOIN {OrderMain} \"enordermain72\" ON (\"enfolio62\".\"orderid\" = \"enordermain72\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpinInvoice_Id != 0) {
whereBuilder.Append("((\"eninvoice87\".\"id\" = @qpinInvoice_Id) AND (\"eninvoice87\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoice_Id", DbType.Int64, qpinInvoice_Id);
} else {
whereBuilder.Append("(\"eninvoice87\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND (NOT (\"eninvoicefile28\".\"isextra\" = 1))");
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
RL_fdf4c80e3fbd3f0ec2f926acd9363b33 outParamList = new RL_fdf4c80e3fbd3f0ec2f926acd9363b33();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoiceByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[6];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[5] = new BitArray(new bool[] {true, false, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InvFCP_1CallAccounting.GetInvoiceById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_fdf4c80e3fbd3f0ec2f926acd9363b33 _tmp = new RL_fdf4c80e3fbd3f0ec2f926acd9363b33();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoiceByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InvFCP_1CallAccounting.GetInvoiceById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_fdf4c80e3fbd3f0ec2f926acd9363b33)_tmp;
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
