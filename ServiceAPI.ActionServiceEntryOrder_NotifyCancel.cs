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

    public class S4PIServiceEntryOrder_NotifyCancelInput {
[JsonProperty("Request")]
public JSONST_ed201ff180bb2dd4a51ad889e8debcfaStructure inParamRequest;
public S4PIServiceEntryOrder_NotifyCancelInput(JSONST_ed201ff180bb2dd4a51ad889e8debcfaStructure inParamRequest) {
this.inParamRequest = inParamRequest;
}

}

public class S4PIServiceEntryOrder_NotifyCancelOutput {
[JsonProperty("Response")]
public JSONST_5a17d82af8397abda9cf3915ce9c082fStructure outParamResponse;
public S4PIServiceEntryOrder_NotifyCancelOutput(JSONST_5a17d82af8397abda9cf3915ce9c082fStructure outParamResponse) {
this.outParamResponse = outParamResponse;
}

}

[HttpPost()]
[Route("serviceapi/serviceentryorder_notifycancel")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "ServiceEntryOrder_NotifyCancel", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIServiceEntryOrder_NotifyCancel(CancellationToken cancellationToken) {return await EndpointAsync<S4PIServiceEntryOrder_NotifyCancelInput, S4PIServiceEntryOrder_NotifyCancelOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
ST_5a17d82af8397abda9cf3915ce9c082fStructure outParamResponse;
S4PIServiceEntryOrder_NotifyCancelInput inputs = serviceActionInput.InputParameters;
System.Collections.Generic.Dictionary<string,string[]> validationErrors = new System.Collections.Generic.Dictionary<string,string[]>();
if((inputs.inParamRequest == null)) {
validationErrors["Request"]=new string[] {"The Request mandatory parameter is missing in the request."};
}

if(validationErrors.Any()) {
throw RestExposeErrorsHelper.BadRequest(validationErrors);
}

ctx.ThrowIfCancellationRequested();
outParamResponse = await Flows.ActionServiceEntryOrder_NotifyCancel(context,JSONST_ed201ff180bb2dd4a51ad889e8debcfaStructure.ToStructure(inputs.inParamRequest, behaviorsConfiguration),ctx);

return new S4PIServiceEntryOrder_NotifyCancelOutput(JSONST_5a17d82af8397abda9cf3915ce9c082fStructure.FromStructure(outParamResponse, behaviorsConfiguration));
}
, cancellationToken);
}



    public partial class Flows {
        public class lcvServiceEntryOrder_NotifyCancel : VarsBag {
public ST_ed201ff180bb2dd4a51ad889e8debcfaStructure inParamRequest;
public RL_339e5fbd74448809f3620bf1c8c54b9a queryResGetOrderMainsByOrderNumber_outParamList = new RL_339e5fbd74448809f3620bf1c8c54b9a();
public long queryResGetOrderMainsByOrderNumber_outParamCount = 0L;

public Actions.lcoOrder_SAPCancelEM resOrder_SAPCancelEM =  new Actions.lcoOrder_SAPCancelEM();
public Actions.lcoLogsAccountingCreate resLogsAccountingCreate =  new Actions.lcoLogsAccountingCreate();
public Actions.lcoLogsAccountingCreate resLogsAccountingCreate2 =  new Actions.lcoLogsAccountingCreate();
public string resJSONSerialize1_outParamJSON = "";
public Actions.lcoLogsAccountingCreate resLogsAccountingCreate3 =  new Actions.lcoLogsAccountingCreate();
public lcvServiceEntryOrder_NotifyCancel(ST_ed201ff180bb2dd4a51ad889e8debcfaStructure inParamRequest) {
this.inParamRequest = inParamRequest;
}
}
public class lcoServiceEntryOrder_NotifyCancel : VarsBag {
public ST_5a17d82af8397abda9cf3915ce9c082fStructure outParamResponse = new ST_5a17d82af8397abda9cf3915ce9c082fStructure();

public lcoServiceEntryOrder_NotifyCancel() {
}
}
/// <summary>
/// Action <code>ServiceEntryOrder_NotifyCancel</code> that represents the Service Studio action
///  <code>ServiceEntryOrder_NotifyCancel</code> <p> Description: Updates an Entry made in Conecta</p>
/// </summary>
public static async Task<ST_5a17d82af8397abda9cf3915ce9c082fStructure> ActionServiceEntryOrder_NotifyCancel(IRequestContext requestContext,ST_ed201ff180bb2dd4a51ad889e8debcfaStructure inParamRequest,CancellationToken cancellationToken) {
ST_5a17d82af8397abda9cf3915ce9c082fStructure outParamResponse = default;
lcoServiceEntryOrder_NotifyCancel result = new lcoServiceEntryOrder_NotifyCancel();
lcvServiceEntryOrder_NotifyCancel localVars = new lcvServiceEntryOrder_NotifyCancel(inParamRequest);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("ServiceEntryOrder_NotifyCancel", "07a9bc90-f0e1-48cf-9abc-ddc418d11aab"))
using (activitySource.CreateServiceActionActivity("ServiceEntryOrder_NotifyCancel")){
// JSON Serialize JsonSerializeServiceEntryOrder_NotifyCancelJSONSerialize1
FuncActionServiceEntryOrder_NotifyCancel.JsonSerializeServiceEntryOrder_NotifyCancelJSONSerialize1(localVars.inParamRequest, out localVars.resJSONSerialize1_outParamJSON);
// LogsAccountingCreate
localVars.resLogsAccountingCreate.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = "Call Entry Notify Cancel API", ssDescription = localVars.resJSONSerialize1_outParamJSON, ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("D2owrMPiwEiolOK12zfaJg"))).ssId },cancellationToken);

// Query datasetGetOrderMainsByOrderNumber
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderMainsByOrderNumber_maxRecords = 1;
if (datasetGetOrderMainsByOrderNumber_maxRecords < 1) datasetGetOrderMainsByOrderNumber_maxRecords = 1;
int datasetGetOrderMainsByOrderNumber_startIndex = 0;(localVars.queryResGetOrderMainsByOrderNumber_outParamList,localVars.queryResGetOrderMainsByOrderNumber_outParamCount) = await FuncActionServiceEntryOrder_NotifyCancel.datasetGetOrderMainsByOrderNumber(requestContext,datasetGetOrderMainsByOrderNumber_maxRecords,datasetGetOrderMainsByOrderNumber_startIndex,IterationMultiplicity.Never,localVars.inParamRequest.ssOrderNumber,cancellationToken);

// Response.OrderNumber = Request.OrderNumber
result.outParamResponse.ssOrderNumber = localVars.inParamRequest.ssOrderNumber;
// order number empty?
if((localVars.queryResGetOrderMainsByOrderNumber_outParamList.Empty)) {
// set error
// Response.OrderNumber = ""
result.outParamResponse.ssOrderNumber = "";

// Response.HasSuccess = False
result.outParamResponse.ssHasSuccess = false;

// Response.ErrorMessage = "E - 002 - " + "Error validating Order Number" + "."
result.outParamResponse.ssErrorMessage = (("E - 002 - "+AppUtils.GetStringResource("Yp7dpW0odUifvuUMAL7pHw#Value.-1027459824.1", "Error validating Order Number"))+".");
// LogsAccountingCreate3
localVars.resLogsAccountingCreate3.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = "Resposta Entry Notify Cancel API", ssDescription = (((AppUtils.GetStringResource("MejtUkPSGEqco_QvwA6PkQ#Value.-1924903246.1", "Order ")+localVars.inParamRequest.ssOrderNumber)+" // ErrorMsg ")+result.outParamResponse.ssErrorMessage), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("D2owrMPiwEiolOK12zfaJg"))).ssId },cancellationToken);

} else {
// Order_SAPCancelEM
localVars.resOrder_SAPCancelEM.outParamResponse = await Actions.ActionOrder_SAPCancelEM(requestContext,localVars.inParamRequest,(localVars.inParamRequest.ssSMDocMaterial==""),6,cancellationToken);

// Response = Order_SAPCancelEM.Response
result.outParamResponse=localVars.resOrder_SAPCancelEM.outParamResponse;
// LogsAccountingCreate2
localVars.resLogsAccountingCreate2.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = "Resposta Entry Notify Cancel API", ssDescription = ((AppUtils.GetStringResource("fxhDxpLiF0SAZsk+8ydQzw#Value.-1924903246.1", "Order ")+result.outParamResponse.ssOrderNumber)+(((result.outParamResponse.ssErrorMessage!="")) ? ((" // ErrorMsg "+result.outParamResponse.ssErrorMessage)) : (" ha devolvido successo"))), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("D2owrMPiwEiolOK12zfaJg"))).ssId },cancellationToken);

}

} //close CreateActionActivity using block
} // try

catch (Exception ex) {
ApplicationLogger.Error(ex, "Error executing action");
requestContext.LastException = ex;

// Error Handler
await DatabaseAccess.RollbackAllTransactionsAsync(cancellationToken);

// set error
// Response.OrderNumber = ""
result.outParamResponse.ssOrderNumber = "";

// Response.HasSuccess = False
result.outParamResponse.ssHasSuccess = false;

// Response.ErrorMessage = "E - 000 - " + "Unknown error in the Portal. Please contact an administrator" + "."
result.outParamResponse.ssErrorMessage = (("E - 000 - "+AppUtils.GetStringResource("uzSrsYstIU6d3756If9LDw#Value.-341728106.1", "Unknown error in the Portal. Please contact an administrator"))+".");
goto RETURN_STATEMENT;

} // Catch
finally {
outParamResponse = result.outParamResponse;
cancellationToken.ThrowIfCancellationRequested();
} // inner-finally
RETURN_STATEMENT:
return outParamResponse;
}

        public static class FuncActionServiceEntryOrder_NotifyCancel {
            
// Query Function "GetOrderMainsByOrderNumber" IZ2YNXLVvkKJpGN_djj6rw of Action "ServiceEntryOrder_NotifyCancel"
public static async Task<(RL_339e5fbd74448809f3620bf1c8c54b9a,long)> datasetGetOrderMainsByOrderNumber(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteOrderNumber,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ServiceEntryOrder_NotifyCancel.GetOrderMainsByOrderNumber", "35989d21-d572-42be-89a4-637f7638faaf");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ServiceEntryOrder_NotifyCancel.GetOrderMainsByOrderNumber", "35989d21-d572-42be-89a4-637f7638faaf", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /ServiceAPIMethods.kLypB+Hwz0iavN3EGNEaqw/NodesNotShownInESpaceTree.IZ2YNXLVvkKJpGN_djj6rw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28");
fromBuilder.Append(" FROM {OrderMain} \"enordermain68\"");
whereBuilder.Append(" WHERE (\"enordermain68\".\"ordernumber\" = @qpteOrderNumber)");
sqlCmd.CreateParameterWithoutReplacements("@qpteOrderNumber", DbType.String, qpteOrderNumber);
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
RL_339e5fbd74448809f3620bf1c8c54b9a outParamList = new RL_339e5fbd74448809f3620bf1c8c54b9a();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ServiceEntryOrder_NotifyCancel.GetOrderMainsByOrderNumber.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_339e5fbd74448809f3620bf1c8c54b9a _tmp = new RL_339e5fbd74448809f3620bf1c8c54b9a();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ServiceEntryOrder_NotifyCancel.GetOrderMainsByOrderNumber.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_339e5fbd74448809f3620bf1c8c54b9a)_tmp;
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

/// <summary>
/// JSONSerialize: JsonSerializeServiceEntryOrder_NotifyCancelJSONSerialize1 (KDHF02iUk7E6fFiabhaa2Ww) 
///  of Action "ServiceEntryOrder_NotifyCancel"
/// </summary>
public static void JsonSerializeServiceEntryOrder_NotifyCancelJSONSerialize1 (ST_ed201ff180bb2dd4a51ad889e8debcfaStructure inParamRecord, out string outParamJSON) {
var config = new OutSystems.RESTService.Runtime.Abstractions.Controllers.BaseRestServiceControllerConfiguration() {
DefaultValuesBehavior = OutSystems.RESTService.Runtime.Abstractions.Behaviors.DefaultValuesBehavior.DontSend,
DateTimeFormat = OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO
};

var holder = ssConectaProveedores.RestRecords.JSONST_ed201ff180bb2dd4a51ad889e8debcfaStructure.FromStructure(inParamRecord, config);
outParamJSON = Newtonsoft.Json.JsonConvert.SerializeObject(holder, config.SerializerSettings);

}

        }
    }
}
