using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using OutSystems.HubEdition.RuntimePlatform.Internal;
using OutSystems.RESTService;
using OutSystems.RESTService.Runtime.Core.Filters;
using OutSystems.RESTService.Runtime.Abstractions.PropertyAttributes;
using ssConectaProveedores.RestRecords;

namespace ssConectaProveedores;

public partial class ServiceAPIController : OutSystems.RESTService.Runtime.Core.Controllers.ServiceActions.ServiceActionsApiController {

    public class S4PIInvAcc_3AccountingInput {
[JsonProperty("InvoiceAccountingProcessId")]
public long? inParamInvoiceAccountingProcessId;
public S4PIInvAcc_3AccountingInput(long? inParamInvoiceAccountingProcessId) {
this.inParamInvoiceAccountingProcessId = inParamInvoiceAccountingProcessId;
}

}

public class S4PIInvAcc_3AccountingOutput {
[JsonProperty("IsSuccess")]
public bool outParamIsSuccess;
[JsonProperty("Message")]
public string outParamMessage;
public S4PIInvAcc_3AccountingOutput(bool outParamIsSuccess, string outParamMessage) {
this.outParamIsSuccess = outParamIsSuccess;
this.outParamMessage = outParamMessage;
}

public bool ShouldSerializeoutParamIsSuccess() {return (this.outParamIsSuccess != true);
}
}

[HttpPost()]
[Route("serviceapi/invacc_3accounting")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "InvAcc_3Accounting", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIInvAcc_3Accounting(CancellationToken cancellationToken) {return await EndpointAsync<S4PIInvAcc_3AccountingInput, S4PIInvAcc_3AccountingOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
bool outParamIsSuccess;
string outParamMessage;
S4PIInvAcc_3AccountingInput inputs = serviceActionInput.InputParameters;
System.Collections.Generic.Dictionary<string,string[]> validationErrors = new System.Collections.Generic.Dictionary<string,string[]>();
if((inputs.inParamInvoiceAccountingProcessId == null)) {
validationErrors["InvoiceAccountingProcessId"]=new string[] {"The InvoiceAccountingProcessId mandatory parameter is missing in the request."};
}

if(validationErrors.Any()) {
throw RestExposeErrorsHelper.BadRequest(validationErrors);
}

ctx.ThrowIfCancellationRequested();
(outParamIsSuccess,outParamMessage) = await Flows.ActionInvAcc_3Accounting(context,inputs.inParamInvoiceAccountingProcessId.Value,ctx);

return new S4PIInvAcc_3AccountingOutput(outParamIsSuccess, outParamMessage);
}
, cancellationToken);
}



    public partial class Flows {
        public class lcvInvAcc_3Accounting : VarsBag {
public long inParamInvoiceAccountingProcessId;
/// <summary>
/// Variable <code>ParameterList</code> that represents the Service Studio TI_POS_InList
///  <code>ParameterList</code> <p>Description: ParameterList</p>
/// </summary>
public RL_c68103fa9d6dc1b51b6298518d880199 varLcParameterList = new RL_c68103fa9d6dc1b51b6298518d880199();

/// <summary>
/// Variable <code>l_StartedOn</code> that represents the Service Studio DateTime
///  <code>l_StartedOn</code> <p>Description: </p>
/// </summary>
public DateTime varLcl_StartedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);

public RL_75a26b2df3c5e73743b57020e6939e68 queryResGetInvoiceAccountingProcesses_outParamList = new RL_75a26b2df3c5e73743b57020e6939e68();
public long queryResGetInvoiceAccountingProcesses_outParamCount = 0L;

public Actions.lcoActionTimestampsCreateOrUpdate resActionTimestampsCreateOrUpdate5 =  new Actions.lcoActionTimestampsCreateOrUpdate();
public ST_35778da666b987b02b8cb887e66647a4Structure resCall_ZTC_GENERA_POLIZA_GRAL_outParamResponse = new ST_35778da666b987b02b8cb887e66647a4Structure();

public Actions.lcoInvoiceAccountingProcessResponseCreate resInvoiceAccountingProcessResponseCreate =  new Actions.lcoInvoiceAccountingProcessResponseCreate();
public lcvInvAcc_3Accounting(long inParamInvoiceAccountingProcessId) {
this.inParamInvoiceAccountingProcessId = inParamInvoiceAccountingProcessId;
}
}
public class lcoInvAcc_3Accounting : VarsBag {
public bool outParamIsSuccess = true;

public string outParamMessage = "";

public lcoInvAcc_3Accounting() {
}
}
/// <summary>
/// Action <code>InvAcc_3Accounting</code> that represents the Service Studio action
///  <code>InvAcc_3Accounting</code> <p> Description: Call Accounting function</p>
/// </summary>
public static async Task<(bool,string)> ActionInvAcc_3Accounting(IRequestContext requestContext,long inParamInvoiceAccountingProcessId,CancellationToken cancellationToken) {
bool outParamIsSuccess = default;
string outParamMessage = default;
lcoInvAcc_3Accounting result = new lcoInvAcc_3Accounting();
lcvInvAcc_3Accounting localVars = new lcvInvAcc_3Accounting(inParamInvoiceAccountingProcessId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("InvAcc_3Accounting", "c08085e0-0324-491c-b9bd-4130dce1f57c"))
using (activitySource.CreateServiceActionActivity("InvAcc_3Accounting")){
// SetCurrentLocale
await ExtendedActions.SetCurrentLocale(requestContext,"es-MX",cancellationToken);

// Query datasetGetInvoiceAccountingProcesses
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceAccountingProcesses_maxRecords = 0;
int datasetGetInvoiceAccountingProcesses_startIndex = 0;(localVars.queryResGetInvoiceAccountingProcesses_outParamList,localVars.queryResGetInvoiceAccountingProcesses_outParamCount) = await FuncActionInvAcc_3Accounting.datasetGetInvoiceAccountingProcesses(requestContext,datasetGetInvoiceAccountingProcesses_maxRecords,datasetGetInvoiceAccountingProcesses_startIndex,IterationMultiplicity.Multiple,localVars.inParamInvoiceAccountingProcessId,cancellationToken);

// ListAppendAll
await ExtendedActions.ListAppendAll(requestContext,localVars.varLcParameterList,(await RL_c68103fa9d6dc1b51b6298518d880199.ConvertAsync(localVars.queryResGetInvoiceAccountingProcesses_outParamList, new RL_c68103fa9d6dc1b51b6298518d880199(), async (RC_56dd61ddd73c9e3bf07414aa1c617494 source, ST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure target, CancellationToken cancellationToken) => {
target.ssPARAMETRO = source.ssENInvoiceAccountingProcessLines_F43.ssParameter;
return target;
}, cancellationToken)),cancellationToken);

// l_StartedOn = CurrDateTime
localVars.varLcl_StartedOn=BuiltInFunction.CurrDateTime ();
// Call_ZTC_GENERA_POLIZA_GRAL
localVars.resCall_ZTC_GENERA_POLIZA_GRAL_outParamResponse = await ServiceAPIs.ServiceAPICall_ZTC_GENERA_POLIZA_GRAL(requestContext,new ST_7d9ca3de97b3b074755ccb195cd9efb0Structure(){ ssPI_USUARIO = "STC_CONECTA", ssTI_POS_In = localVars.varLcParameterList },cancellationToken);

// ActionTimestampsCreateOrUpdate5
localVars.resActionTimestampsCreateOrUpdate5.outParamId = await Actions.ActionActionTimestampsCreateOrUpdate(requestContext,new EN_b22d64c90281d09a316b6f4502a74326EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssDescription = (("ProcessId: "+BuiltInFunction.LongIntegerToText(localVars.inParamInvoiceAccountingProcessId))+" - General poliza"), ssStartedOn = localVars.varLcl_StartedOn, ssFinishedOn = BuiltInFunction.CurrDateTime () },cancellationToken);

// InvoiceAccountingProcessResponseCreate
localVars.resInvoiceAccountingProcessResponseCreate.outParamId = await Actions.ActionInvoiceAccountingProcessResponseCreate(requestContext,new EN_e91123b36c7b071a4454698bbf50e4bcEntityRecord(){ ssInvoiceAccountingProcessId = localVars.inParamInvoiceAccountingProcessId, ssIsSuccess = (((BuiltInFunction.SubstrSC (localVars.resCall_ZTC_GENERA_POLIZA_GRAL_outParamResponse.ssPO_RESULTADO, 0, 1)!="E")&&(localVars.resCall_ZTC_GENERA_POLIZA_GRAL_outParamResponse.ssTO_RESULTADO_Out.CurrentRec.ssID_POLIZA!=""))&&(BuiltInFunction.SubstrSC (localVars.resCall_ZTC_GENERA_POLIZA_GRAL_outParamResponse.ssTO_RESULTADO_Out.CurrentRec.ssCODIGO, 0, 1)!="E")), ssID_POLIZA = localVars.resCall_ZTC_GENERA_POLIZA_GRAL_outParamResponse.ssTO_RESULTADO_Out.CurrentRec.ssID_POLIZA, ssTEXTO = localVars.resCall_ZTC_GENERA_POLIZA_GRAL_outParamResponse.ssTO_RESULTADO_Out.CurrentRec.ssTEXTO, ssPO_RESULTADO = localVars.resCall_ZTC_GENERA_POLIZA_GRAL_outParamResponse.ssPO_RESULTADO, ssCODIGO = localVars.resCall_ZTC_GENERA_POLIZA_GRAL_outParamResponse.ssTO_RESULTADO_Out.CurrentRec.ssCODIGO },cancellationToken);

} //close CreateActionActivity using block
} // try

catch (Exception ex) {
ApplicationLogger.Error(ex, "Error executing action");
requestContext.LastException = ex;

// Error Handler

// IsSuccess = False
result.outParamIsSuccess=false;

// Message = "There was an error calling the contabilization service. Please contact an administrator or try again later."
result.outParamMessage=AppUtils.GetStringResource("opS_lWQwV0+l43r48lzJCQ#Value.-695691710.1", "There was an error calling the contabilization service. Please contact an administrator or try again later.");
goto RETURN_STATEMENT;

} // Catch
finally {
outParamIsSuccess = result.outParamIsSuccess;
outParamMessage = result.outParamMessage;
cancellationToken.ThrowIfCancellationRequested();
} // inner-finally
RETURN_STATEMENT:
return (outParamIsSuccess,outParamMessage);
}

        public static class FuncActionInvAcc_3Accounting {
            
// Query Function "GetInvoiceAccountingProcesses" 9n3zVE3vKUi7iaXy4QOOgw of Action "InvAcc_3Accounting"
public static async Task<(RL_75a26b2df3c5e73743b57020e6939e68,long)> datasetGetInvoiceAccountingProcesses(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceAccounting_ProcessId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InvAcc_3Accounting.GetInvoiceAccountingProcesses", "54f37df6-ef4d-4829-bb89-a5f2e1038e83");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InvAcc_3Accounting.GetInvoiceAccountingProcesses", "54f37df6-ef4d-4829-bb89-a5f2e1038e83", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Multiple
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
selectBuilder.Append("/* /ServiceAPIMethods.4IWAwCQDHEm5vUEw3OH1fA/NodesNotShownInESpaceTree.9n3zVE3vKUi7iaXy4QOOgw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, \"eninvoiceaccountingprocesslines_f43\".\"parameter\" o2");
fromBuilder.Append(" FROM {InvoiceAccountingProcessLines_F43} \"eninvoiceaccountingprocesslines_f43\"");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceAccounting_ProcessId != 0) {
whereBuilder.Append("((\"eninvoiceaccountingprocesslines_f43\".\"invoiceaccounting_processid\" = @qpinInvoiceAccounting_ProcessId) AND (\"eninvoiceaccountingprocesslines_f43\".\"invoiceaccounting_processid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceAccounting_ProcessId", DbType.Int64, qpinInvoiceAccounting_ProcessId);
} else {
whereBuilder.Append("(\"eninvoiceaccountingprocesslines_f43\".\"invoiceaccounting_processid\" IS NULL)");
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
RL_75a26b2df3c5e73743b57020e6939e68 outParamList = new RL_75a26b2df3c5e73743b57020e6939e68();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InvAcc_3Accounting.GetInvoiceAccountingProcesses.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_75a26b2df3c5e73743b57020e6939e68 _tmp = new RL_75a26b2df3c5e73743b57020e6939e68();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InvAcc_3Accounting.GetInvoiceAccountingProcesses.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_75a26b2df3c5e73743b57020e6939e68)_tmp;
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
