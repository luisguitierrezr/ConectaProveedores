using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using OutSystems.HubEdition.RuntimePlatform.Internal;
using OutSystems.RESTService;
using OutSystems.RESTService.Runtime.Core.Filters;
using OutSystems.RESTService.Runtime.Abstractions.PropertyAttributes;


namespace ssConectaProveedores;

public partial class ServiceAPIController : OutSystems.RESTService.Runtime.Core.Controllers.ServiceActions.ServiceActionsApiController {

    public class S4PIInvFCP_2DocTypeInput {
[JsonProperty("InvoiceAccountingProcessId")]
public long? inParamInvoiceAccountingProcessId;
public S4PIInvFCP_2DocTypeInput(long? inParamInvoiceAccountingProcessId) {
this.inParamInvoiceAccountingProcessId = inParamInvoiceAccountingProcessId;
}

}

public class S4PIInvFCP_2DocTypeOutput {
[JsonProperty("ExchangeValue")]
public decimal outParamExchangeValue;
[JsonProperty("IsCallMIRO")]
public bool outParamIsCallMIRO;
[JsonProperty("IsCallF43")]
public bool outParamIsCallF43;
[JsonProperty("IsSuccess")]
public bool outParamIsSuccess;
[JsonProperty("Message")]
public string outParamMessage;
public S4PIInvFCP_2DocTypeOutput(decimal outParamExchangeValue, bool outParamIsCallMIRO, bool outParamIsCallF43, bool outParamIsSuccess, string outParamMessage) {
this.outParamExchangeValue = outParamExchangeValue;
this.outParamIsCallMIRO = outParamIsCallMIRO;
this.outParamIsCallF43 = outParamIsCallF43;
this.outParamIsSuccess = outParamIsSuccess;
this.outParamMessage = outParamMessage;
}

public bool ShouldSerializeoutParamIsCallMIRO() {return (this.outParamIsCallMIRO != false);
}
public bool ShouldSerializeoutParamIsCallF43() {return (this.outParamIsCallF43 != false);
}
public bool ShouldSerializeoutParamIsSuccess() {return (this.outParamIsSuccess != true);
}
}

[HttpPost()]
[Route("serviceapi/invfcp_2doctype")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "InvFCP_2DocType", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIInvFCP_2DocType(CancellationToken cancellationToken) {return await EndpointAsync<S4PIInvFCP_2DocTypeInput, S4PIInvFCP_2DocTypeOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
decimal outParamExchangeValue;
bool outParamIsCallMIRO;
bool outParamIsCallF43;
bool outParamIsSuccess;
string outParamMessage;
S4PIInvFCP_2DocTypeInput inputs = serviceActionInput.InputParameters;
System.Collections.Generic.Dictionary<string,string[]> validationErrors = new System.Collections.Generic.Dictionary<string,string[]>();
if((inputs.inParamInvoiceAccountingProcessId == null)) {
validationErrors["InvoiceAccountingProcessId"]=new string[] {"The InvoiceAccountingProcessId mandatory parameter is missing in the request."};
}

if(validationErrors.Any()) {
throw RestExposeErrorsHelper.BadRequest(validationErrors);
}

ctx.ThrowIfCancellationRequested();
(outParamExchangeValue,outParamIsCallMIRO,outParamIsCallF43,outParamIsSuccess,outParamMessage) = await Flows.ActionInvFCP_2DocType(context,inputs.inParamInvoiceAccountingProcessId.Value,ctx);

return new S4PIInvFCP_2DocTypeOutput(outParamExchangeValue, outParamIsCallMIRO, outParamIsCallF43, outParamIsSuccess, outParamMessage);
}
, cancellationToken);
}



    public partial class Flows {
        public class lcvInvFCP_2DocType : VarsBag {
public long inParamInvoiceAccountingProcessId;
/// <summary>
/// Variable <code>l_StartedOn</code> that represents the Service Studio DateTime
///  <code>l_StartedOn</code> <p>Description: </p>
/// </summary>
public DateTime varLcl_StartedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);

public RL_4e909af3a15d1687c03c789af38db7ae queryResGetInvoiceAccountingProcessById_outParamList = new RL_4e909af3a15d1687c03c789af38db7ae();
public long queryResGetInvoiceAccountingProcessById_outParamCount = 0L;

public RL_b323e0bdf1fec18079c1034e78738762 queryResGetOrderAccConceptById_outParamList = new RL_b323e0bdf1fec18079c1034e78738762();
public long queryResGetOrderAccConceptById_outParamCount = 0L;

public RL_c9f6aa71e71ab2513c8b708a5c8313ba queryResGetFolioSAPDataByFolioId_outParamList = new RL_c9f6aa71e71ab2513c8b708a5c8313ba();
public long queryResGetFolioSAPDataByFolioId_outParamCount = 0L;

public Actions.lcoEntryAccounting_CallExchange resEntryAccounting_CallExchange =  new Actions.lcoEntryAccounting_CallExchange();
public RL_a3410adc467aca89c856451800f767c9 queryResGetInvoiceById_outParamList = new RL_a3410adc467aca89c856451800f767c9();
public long queryResGetInvoiceById_outParamCount = 0L;

public Actions.lcoEntryAccountingInvProcess_ValidCFDI resEntryAccountingInvProcess_ValidCFDI =  new Actions.lcoEntryAccountingInvProcess_ValidCFDI();
public Actions.lcoLogsAccountingCreate resLogsAccountingCreate =  new Actions.lcoLogsAccountingCreate();
public lcvInvFCP_2DocType(long inParamInvoiceAccountingProcessId) {
this.inParamInvoiceAccountingProcessId = inParamInvoiceAccountingProcessId;
}
}
public class lcoInvFCP_2DocType : VarsBag {
public decimal outParamExchangeValue = 0.0M;

public bool outParamIsCallMIRO = false;

public bool outParamIsCallF43 = false;

public bool outParamIsSuccess = true;

public string outParamMessage = "";

public lcoInvFCP_2DocType() {
}
}
/// <summary>
/// Action <code>InvFCP_2DocType</code> that represents the Service Studio action
///  <code>InvFCP_2DocType</code> <p> Description: Call exchange & CFDI if needed</p>
/// </summary>
public static async Task<(decimal,bool,bool,bool,string)> ActionInvFCP_2DocType(IRequestContext requestContext,long inParamInvoiceAccountingProcessId,CancellationToken cancellationToken) {
decimal outParamExchangeValue = default;
bool outParamIsCallMIRO = default;
bool outParamIsCallF43 = default;
bool outParamIsSuccess = default;
string outParamMessage = default;
lcoInvFCP_2DocType result = new lcoInvFCP_2DocType();
lcvInvFCP_2DocType localVars = new lcvInvFCP_2DocType(inParamInvoiceAccountingProcessId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("InvFCP_2DocType", "8eb87a4b-dfbf-4be2-8262-bf88c80f91b6"))
using (activitySource.CreateServiceActionActivity("InvFCP_2DocType")){
// Query datasetGetInvoiceAccountingProcessById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceAccountingProcessById_maxRecords = 0;
int datasetGetInvoiceAccountingProcessById_startIndex = 0;(localVars.queryResGetInvoiceAccountingProcessById_outParamList,localVars.queryResGetInvoiceAccountingProcessById_outParamCount) = await FuncActionInvFCP_2DocType.datasetGetInvoiceAccountingProcessById(requestContext,datasetGetInvoiceAccountingProcessById_maxRecords,datasetGetInvoiceAccountingProcessById_startIndex,IterationMultiplicity.Never,localVars.inParamInvoiceAccountingProcessId,cancellationToken);

// l_StartedOn = CurrDateTime
localVars.varLcl_StartedOn=BuiltInFunction.CurrDateTime ();
// SetCurrentLocale
await ExtendedActions.SetCurrentLocale(requestContext,"es-MX",cancellationToken);

// Query datasetGetInvoiceById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceById_maxRecords = 1;
if (datasetGetInvoiceById_maxRecords < 1) datasetGetInvoiceById_maxRecords = 1;
int datasetGetInvoiceById_startIndex = 0;(localVars.queryResGetInvoiceById_outParamList,localVars.queryResGetInvoiceById_outParamCount) = await FuncActionInvFCP_2DocType.datasetGetInvoiceById(requestContext,datasetGetInvoiceById_maxRecords,datasetGetInvoiceById_startIndex,IterationMultiplicity.Never,localVars.queryResGetInvoiceAccountingProcessById_outParamList.CurrentRec.ssENInvoiceAccountingProcess.ssInvoiceId,cancellationToken);

// LogsAccountingCreate
localVars.resLogsAccountingCreate.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = AppUtils.GetStringResource("jk3YwfxqEk6eg2MdZbP+NQ#Value.-579364467.1", "Document type for accounting"), ssAssociatedId = ("Process "+BuiltInFunction.LongIntegerToText(localVars.inParamInvoiceAccountingProcessId)), ssDescription = ((((AppUtils.GetStringResource("0GlSkDgqeUus7_UXupCA7A#Value.-670115059.1", "Invoice")+": ")+localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssName)+" // Order: ")+localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENOrderMain.ssOrderNumber), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("KTnl+i02eUSozHPzTg81rA"))).ssId },cancellationToken);

// Query datasetGetFolioSAPDataByFolioId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioSAPDataByFolioId_maxRecords = 1;
if (datasetGetFolioSAPDataByFolioId_maxRecords < 1) datasetGetFolioSAPDataByFolioId_maxRecords = 1;
int datasetGetFolioSAPDataByFolioId_startIndex = 0;(localVars.queryResGetFolioSAPDataByFolioId_outParamList,localVars.queryResGetFolioSAPDataByFolioId_outParamCount) = await FuncActionInvFCP_2DocType.datasetGetFolioSAPDataByFolioId(requestContext,datasetGetFolioSAPDataByFolioId_maxRecords,datasetGetFolioSAPDataByFolioId_startIndex,IterationMultiplicity.Never,localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssFolioId,cancellationToken);

// EntryAccounting_CallExchange
localVars.resEntryAccounting_CallExchange.outParamExchangeValue = await Actions.ActionEntryAccounting_CallExchange(requestContext,localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssCurrency,BuiltInFunction.DateTimeToDate((await Functions.ActionUTCToLocalTime(requestContext,localVars.queryResGetFolioSAPDataByFolioId_outParamList.CurrentRec.ssENFolioSAPData.ssCreatedOn,localVars.queryResGetInvoiceAccountingProcessById_outParamList.CurrentRec.ssENInvoiceAccountingProcess.ssOffsetUtc,cancellationToken))),cancellationToken);

// ExchangeValue = EntryAccounting_CallExchange.ExchangeValue
result.outParamExchangeValue=localVars.resEntryAccounting_CallExchange.outParamExchangeValue;
// Query datasetGetOrderAccConceptById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderAccConceptById_maxRecords = 1;
if (datasetGetOrderAccConceptById_maxRecords < 1) datasetGetOrderAccConceptById_maxRecords = 1;
int datasetGetOrderAccConceptById_startIndex = 0;(localVars.queryResGetOrderAccConceptById_outParamList,localVars.queryResGetOrderAccConceptById_outParamCount) = await FuncActionInvFCP_2DocType.datasetGetOrderAccConceptById(requestContext,datasetGetOrderAccConceptById_maxRecords,datasetGetOrderAccConceptById_startIndex,IterationMultiplicity.Never,localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssOrderAccConceptsID,cancellationToken);

// national
if((((localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENSupplier.ssPais=="MX")&&((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveFCPValidationCFDI])))))) {
// EntryAccountingInvProcess_ValidCFDI
(localVars.resEntryAccountingInvProcess_ValidCFDI.outParamIsSuccess,localVars.resEntryAccountingInvProcess_ValidCFDI.outParamMessage,localVars.resEntryAccountingInvProcess_ValidCFDI.outParamCanTryAgain) = await Actions.ActionEntryAccountingInvProcess_ValidCFDI(requestContext,localVars.queryResGetInvoiceAccountingProcessById_outParamList.CurrentRec.ssENInvoiceAccountingProcess.ssInvoiceId,localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssName,localVars.queryResGetInvoiceAccountingProcessById_outParamList.CurrentRec.ssENInvoiceAccountingProcess,localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENSupplier.ssNumber,localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENRegion.ssDivisionFI,localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENCompany.ssExternalId,cancellationToken);

// error cfdi
if(((!localVars.resEntryAccountingInvProcess_ValidCFDI.outParamIsSuccess))) {
// IsSuccess = EntryAccountingInvProcess_ValidCFDI.IsSuccess
result.outParamIsSuccess=localVars.resEntryAccountingInvProcess_ValidCFDI.outParamIsSuccess;

// Message = EntryAccountingInvProcess_ValidCFDI.Message
result.outParamMessage=localVars.resEntryAccountingInvProcess_ValidCFDI.outParamMessage;
goto RETURN_STATEMENT;

}

}

// CreditNote-Anticipo-Voucher
if(((((localVars.queryResGetOrderAccConceptById_outParamList.CurrentRec.ssENOrderAccConcepts.ssAccountingDataTypeId==8)||(localVars.queryResGetOrderAccConceptById_outParamList.CurrentRec.ssENOrderAccConcepts.ssAccountingDataTypeId==5))||(localVars.queryResGetOrderAccConceptById_outParamList.CurrentRec.ssENOrderAccConcepts.ssAccountingDataTypeId==6)))) {
// IsCallF43 = True
result.outParamIsCallF43=true;
} else {
// Estim-Finiq-Invoice
if((((((localVars.queryResGetOrderAccConceptById_outParamList.CurrentRec.ssENOrderAccConcepts.ssAccountingDataTypeId==1)||(localVars.queryResGetOrderAccConceptById_outParamList.CurrentRec.ssENOrderAccConcepts.ssAccountingDataTypeId==4))||(localVars.queryResGetOrderAccConceptById_outParamList.CurrentRec.ssENOrderAccConcepts.ssAccountingDataTypeId==3))||(localVars.queryResGetOrderAccConceptById_outParamList.CurrentRec.ssENOrderAccConcepts.ssAccountingDataTypeId==2)))) {
// IsCallMIRO = True
result.outParamIsCallMIRO=true;
} else {
// IsSuccess = False
result.outParamIsSuccess=false;

// Message = "Couldn't find document type associated."
result.outParamMessage=AppUtils.GetStringResource("tEg3AgNGn0uN3xFoeH7lxA#Value.-139397178.1", "Couldn't find document type associated.");
}

}

} //close CreateActionActivity using block
} // try

catch (Exception ex) {
ApplicationLogger.Error(ex, "Error executing action");
requestContext.LastException = ex;

// Error Handler
await DatabaseAccess.RollbackAllTransactionsAsync(cancellationToken);

goto RETURN_STATEMENT;

} // Catch
finally {
outParamExchangeValue = result.outParamExchangeValue;
outParamIsCallMIRO = result.outParamIsCallMIRO;
outParamIsCallF43 = result.outParamIsCallF43;
outParamIsSuccess = result.outParamIsSuccess;
outParamMessage = result.outParamMessage;
cancellationToken.ThrowIfCancellationRequested();
} // inner-finally
RETURN_STATEMENT:
return (outParamExchangeValue,outParamIsCallMIRO,outParamIsCallF43,outParamIsSuccess,outParamMessage);
}

        public static class FuncActionInvFCP_2DocType {
            
// Query Function "GetInvoiceAccountingProcessById" wrUlQaAvfEmtVMQz+haOfQ of Action "InvFCP_2DocType"
public static async Task<(RL_4e909af3a15d1687c03c789af38db7ae,long)> datasetGetInvoiceAccountingProcessById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InvFCP_2DocType.GetInvoiceAccountingProcessById", "4125b5c2-2fa0-497c-ad54-c433fa168e7d");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InvFCP_2DocType.GetInvoiceAccountingProcessById", "4125b5c2-2fa0-497c-ad54-c433fa168e7d", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /ServiceAPIMethods.S3q4jr_f4kuCYr+IyA+Rtg/NodesNotShownInESpaceTree.wrUlQaAvfEmtVMQz+haOfQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoiceaccountingprocess17\".\"id\" o0, \"eninvoiceaccountingprocess17\".\"invoiceid\" o1, \"eninvoiceaccountingprocess17\".\"requisitionid\" o2, \"eninvoiceaccountingprocess17\".\"offsetutc\" o3, \"eninvoiceaccountingprocess17\".\"comment\" o4, \"eninvoiceaccountingprocess17\".\"processnumber\" o5, \"eninvoiceaccountingprocess17\".\"createdon\" o6, \"eninvoiceaccountingprocess17\".\"nexttry\" o7, \"eninvoiceaccountingprocess17\".\"invoiceprocessstatusid\" o8");
fromBuilder.Append(" FROM {InvoiceAccountingProcess} \"eninvoiceaccountingprocess17\"");
whereBuilder.Append(" WHERE ");
if (qpinId != 0) {
whereBuilder.Append("((\"eninvoiceaccountingprocess17\".\"id\" = @qpinId) AND (\"eninvoiceaccountingprocess17\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinId", DbType.Int64, qpinId);
} else {
whereBuilder.Append("(\"eninvoiceaccountingprocess17\".\"id\" IS NULL)");
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
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InvFCP_2DocType.GetInvoiceAccountingProcessById.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InvFCP_2DocType.GetInvoiceAccountingProcessById.List", cancellationToken: cancellationToken);
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

private static async Task<RC_fba480f5c1b92eb8b15d33020b0023b5> datasetGetOrderAccConceptByIdReadDbAsync(RC_fba480f5c1b92eb8b15d33020b0023b5 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENAdvancePaymentType.Read( r, ref index);
rec.ssENOrderAccConcepts.Read( r, ref index);
rec.ssENPaymentTerms.Read( r, ref index);
return rec;
}
// Query Function "GetOrderAccConceptById" dJriRe86u0CAAxB5djjGAg of Action "InvFCP_2DocType"
public static async Task<(RL_b323e0bdf1fec18079c1034e78738762,long)> datasetGetOrderAccConceptById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderAccConcepts_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InvFCP_2DocType.GetOrderAccConceptById", "45e29a74-3aef-40bb-8003-10797638c602");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InvFCP_2DocType.GetOrderAccConceptById", "45e29a74-3aef-40bb-8003-10797638c602", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /ServiceAPIMethods.S3q4jr_f4kuCYr+IyA+Rtg/NodesNotShownInESpaceTree.dJriRe86u0CAAxB5djjGAg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, \"enorderaccconcepts10\".\"accountingdatatypeid\" o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28");
fromBuilder.Append(" FROM (({OrderAccConcepts} \"enorderaccconcepts10\" Left JOIN {PaymentTerms} \"enpaymentterms13\" ON (\"enorderaccconcepts10\".\"paymenttermid\" = \"enpaymentterms13\".\"id\"))  Left JOIN {AdvancePaymentType} \"enadvancepaymenttype2\" ON (\"enorderaccconcepts10\".\"advancepaymenttypeid\" = \"enadvancepaymenttype2\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qporOrderAccConcepts_Id != 0) {
whereBuilder.Append("((\"enorderaccconcepts10\".\"id\" = @qporOrderAccConcepts_Id) AND (\"enorderaccconcepts10\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderAccConcepts_Id", DbType.Int64, qporOrderAccConcepts_Id);
} else {
whereBuilder.Append("(\"enorderaccconcepts10\".\"id\" IS NULL)");
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
RL_b323e0bdf1fec18079c1034e78738762 outParamList = new RL_b323e0bdf1fec18079c1034e78738762();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrderAccConceptByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, true, false, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InvFCP_2DocType.GetOrderAccConceptById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_b323e0bdf1fec18079c1034e78738762 _tmp = new RL_b323e0bdf1fec18079c1034e78738762();
_tmp.AlternateReadDbMethodAsync = datasetGetOrderAccConceptByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InvFCP_2DocType.GetOrderAccConceptById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_b323e0bdf1fec18079c1034e78738762)_tmp;
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

// Query Function "GetFolioSAPDataByFolioId" voAXrIe8VECvU+qpJKY4Aw of Action "InvFCP_2DocType"
public static async Task<(RL_c9f6aa71e71ab2513c8b708a5c8313ba,long)> datasetGetFolioSAPDataByFolioId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolioId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InvFCP_2DocType.GetFolioSAPDataByFolioId", "ac1780be-bc87-4054-af53-eaa924a63803");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InvFCP_2DocType.GetFolioSAPDataByFolioId", "ac1780be-bc87-4054-af53-eaa924a63803", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /ServiceAPIMethods.S3q4jr_f4kuCYr+IyA+Rtg/NodesNotShownInESpaceTree.voAXrIe8VECvU+qpJKY4Aw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, \"enfoliosapdata12\".\"createdon\" o14");
fromBuilder.Append(" FROM {FolioSAPData} \"enfoliosapdata12\"");
whereBuilder.Append(" WHERE ");
if (qpfoFolioId != 0) {
whereBuilder.Append("((\"enfoliosapdata12\".\"folioid\" = @qpfoFolioId) AND (\"enfoliosapdata12\".\"folioid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolioId", DbType.Int64, qpfoFolioId);
} else {
whereBuilder.Append("(\"enfoliosapdata12\".\"folioid\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"enfoliosapdata12\".\"id\" DESC ");
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
RL_c9f6aa71e71ab2513c8b708a5c8313ba outParamList = new RL_c9f6aa71e71ab2513c8b708a5c8313ba();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InvFCP_2DocType.GetFolioSAPDataByFolioId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_c9f6aa71e71ab2513c8b708a5c8313ba _tmp = new RL_c9f6aa71e71ab2513c8b708a5c8313ba();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InvFCP_2DocType.GetFolioSAPDataByFolioId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_c9f6aa71e71ab2513c8b708a5c8313ba)_tmp;
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

private static async Task<RC_9c686b5cc2dbfdbcbef82bc4cdcc5012> datasetGetInvoiceByIdReadDbAsync(RC_9c686b5cc2dbfdbcbef82bc4cdcc5012 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENCompany.Read( r, ref index);
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceExtended.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
return rec;
}
// Query Function "GetInvoiceById" 3KHkwaSVbEubBHvAvbBXvA of Action "InvFCP_2DocType"
public static async Task<(RL_a3410adc467aca89c856451800f767c9,long)> datasetGetInvoiceById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoice_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InvFCP_2DocType.GetInvoiceById", "c1e4a1dc-95a4-4b6c-9b04-7bc0bdb057bc");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InvFCP_2DocType.GetInvoiceById", "c1e4a1dc-95a4-4b6c-9b04-7bc0bdb057bc", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /ServiceAPIMethods.S3q4jr_f4kuCYr+IyA+Rtg/NodesNotShownInESpaceTree.3KHkwaSVbEubBHvAvbBXvA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"encompany17\".\"externalid\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, \"eninvoice88\".\"name\" o12, NULL o13, \"eninvoice88\".\"folioid\" o14, NULL o15, NULL o16, NULL o17, \"eninvoice88\".\"currency\" o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, \"eninvoice88\".\"orderaccconceptsid\" o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, \"enordermain73\".\"ordernumber\" o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, \"enregion70\".\"divisionfi\" o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, \"ensupplier53\".\"number\" o99, NULL o100, NULL o101, NULL o102, NULL o103, \"ensupplier53\".\"pais\" o104, NULL o105, NULL o106, NULL o107, NULL o108, NULL o109, NULL o110, NULL o111, NULL o112, NULL o113, NULL o114, NULL o115, NULL o116, NULL o117, NULL o118, NULL o119, NULL o120, NULL o121, NULL o122, NULL o123");
fromBuilder.Append(" FROM ((((({Invoice} \"eninvoice88\" Left JOIN {OrderMain} \"enordermain73\" ON (\"eninvoice88\".\"ordermainid\" = \"enordermain73\".\"id\"))  Left JOIN {InvoiceExtended} \"eninvoiceextended21\" ON (\"eninvoice88\".\"id\" = \"eninvoiceextended21\".\"id\"))  Left JOIN {Supplier} \"ensupplier53\" ON (\"enordermain73\".\"supplierid\" = \"ensupplier53\".\"id\"))  Left JOIN {Company} \"encompany17\" ON (\"enordermain73\".\"companyid\" = \"encompany17\".\"id\"))  Left JOIN {Region} \"enregion70\" ON (\"enordermain73\".\"divisionid\" = \"enregion70\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpinInvoice_Id != 0) {
whereBuilder.Append("((\"eninvoice88\".\"id\" = @qpinInvoice_Id) AND (\"eninvoice88\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoice_Id", DbType.Int64, qpinInvoice_Id);
} else {
whereBuilder.Append("(\"eninvoice88\".\"id\" IS NULL)");
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
RL_a3410adc467aca89c856451800f767c9 outParamList = new RL_a3410adc467aca89c856451800f767c9();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoiceByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[6];
opt[0] = new BitArray(new bool[] {true, false, true, false, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, true, true, false, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, true, true, false, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InvFCP_2DocType.GetInvoiceById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_a3410adc467aca89c856451800f767c9 _tmp = new RL_a3410adc467aca89c856451800f767c9();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoiceByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InvFCP_2DocType.GetInvoiceById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_a3410adc467aca89c856451800f767c9)_tmp;
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
