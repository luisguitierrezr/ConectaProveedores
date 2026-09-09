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

    public class S4PIServiceEntryOrder_UpdateInput {
[JsonProperty("Request")]
public JSONST_2f2ec31e2efdad4ee20db1f76bfc2aa4Structure inParamRequest;
public S4PIServiceEntryOrder_UpdateInput(JSONST_2f2ec31e2efdad4ee20db1f76bfc2aa4Structure inParamRequest) {
this.inParamRequest = inParamRequest;
}

}

public class S4PIServiceEntryOrder_UpdateOutput {
[JsonProperty("Response")]
public JSONST_5a17d82af8397abda9cf3915ce9c082fStructure outParamResponse;
public S4PIServiceEntryOrder_UpdateOutput(JSONST_5a17d82af8397abda9cf3915ce9c082fStructure outParamResponse) {
this.outParamResponse = outParamResponse;
}

}

[HttpPost()]
[Route("serviceapi/serviceentryorder_update")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "ServiceEntryOrder_Update", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIServiceEntryOrder_Update(CancellationToken cancellationToken) {return await EndpointAsync<S4PIServiceEntryOrder_UpdateInput, S4PIServiceEntryOrder_UpdateOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
ST_5a17d82af8397abda9cf3915ce9c082fStructure outParamResponse;
S4PIServiceEntryOrder_UpdateInput inputs = serviceActionInput.InputParameters;
System.Collections.Generic.Dictionary<string,string[]> validationErrors = new System.Collections.Generic.Dictionary<string,string[]>();
if((inputs.inParamRequest == null)) {
validationErrors["Request"]=new string[] {"The Request mandatory parameter is missing in the request."};
}

if(validationErrors.Any()) {
throw RestExposeErrorsHelper.BadRequest(validationErrors);
}

ctx.ThrowIfCancellationRequested();
outParamResponse = await Flows.ActionServiceEntryOrder_Update(context,JSONST_2f2ec31e2efdad4ee20db1f76bfc2aa4Structure.ToStructure(inputs.inParamRequest, behaviorsConfiguration),ctx);

return new S4PIServiceEntryOrder_UpdateOutput(JSONST_5a17d82af8397abda9cf3915ce9c082fStructure.FromStructure(outParamResponse, behaviorsConfiguration));
}
, cancellationToken);
}



    public partial class Flows {
        public class lcvServiceEntryOrder_Update : VarsBag {
public ST_2f2ec31e2efdad4ee20db1f76bfc2aa4Structure inParamRequest;
public Actions.lcoLogsAccountingCreate resLogsAccountingCreate2 =  new Actions.lcoLogsAccountingCreate();
public string resJSONSerialize1_outParamJSON = "";
public Actions.lcoLogsAccountingCreate resLogsAccountingCreate =  new Actions.lcoLogsAccountingCreate();
public Actions.lcoLogsAccountingCreate resLogsAccountingCreate3 =  new Actions.lcoLogsAccountingCreate();
public RL_339e5fbd74448809f3620bf1c8c54b9a queryResGetOrderMainsByOrderNumber_outParamList = new RL_339e5fbd74448809f3620bf1c8c54b9a();
public long queryResGetOrderMainsByOrderNumber_outParamCount = 0L;

public Actions.lcoOrder_SAPNewEntry resOrder_SAPNewEntry =  new Actions.lcoOrder_SAPNewEntry();
public lcvServiceEntryOrder_Update(ST_2f2ec31e2efdad4ee20db1f76bfc2aa4Structure inParamRequest) {
this.inParamRequest = inParamRequest;
}
}
public class lcoServiceEntryOrder_Update : VarsBag {
public ST_5a17d82af8397abda9cf3915ce9c082fStructure outParamResponse = new ST_5a17d82af8397abda9cf3915ce9c082fStructure();

public lcoServiceEntryOrder_Update() {
}
}
/// <summary>
/// Action <code>ServiceEntryOrder_Update</code> that represents the Service Studio action
///  <code>ServiceEntryOrder_Update</code> <p> Description: Notifies Conecta of Entries that happene
/// d from SAP</p>
/// </summary>
public static async Task<ST_5a17d82af8397abda9cf3915ce9c082fStructure> ActionServiceEntryOrder_Update(IRequestContext requestContext,ST_2f2ec31e2efdad4ee20db1f76bfc2aa4Structure inParamRequest,CancellationToken cancellationToken) {
ST_5a17d82af8397abda9cf3915ce9c082fStructure outParamResponse = default;
lcoServiceEntryOrder_Update result = new lcoServiceEntryOrder_Update();
lcvServiceEntryOrder_Update localVars = new lcvServiceEntryOrder_Update(inParamRequest);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("ServiceEntryOrder_Update", "a803f15d-7142-458e-a3ed-86c2f69fd802"))
using (activitySource.CreateServiceActionActivity("ServiceEntryOrder_Update")){
// SetCurrentLocale
await ExtendedActions.SetCurrentLocale(requestContext,"es-MX",cancellationToken);

// JSON Serialize JsonSerializeServiceEntryOrder_UpdateJSONSerialize1
FuncActionServiceEntryOrder_Update.JsonSerializeServiceEntryOrder_UpdateJSONSerialize1(localVars.inParamRequest, out localVars.resJSONSerialize1_outParamJSON);
// LogsAccountingCreate
localVars.resLogsAccountingCreate.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = "Call Entry Update API", ssDescription = localVars.resJSONSerialize1_outParamJSON, ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("p5v2rxHHU0us2h+De0gQag"))).ssId },cancellationToken);

// Query datasetGetOrderMainsByOrderNumber
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderMainsByOrderNumber_maxRecords = 1;
if (datasetGetOrderMainsByOrderNumber_maxRecords < 1) datasetGetOrderMainsByOrderNumber_maxRecords = 1;
int datasetGetOrderMainsByOrderNumber_startIndex = 0;(localVars.queryResGetOrderMainsByOrderNumber_outParamList,localVars.queryResGetOrderMainsByOrderNumber_outParamCount) = await FuncActionServiceEntryOrder_Update.datasetGetOrderMainsByOrderNumber(requestContext,datasetGetOrderMainsByOrderNumber_maxRecords,datasetGetOrderMainsByOrderNumber_startIndex,IterationMultiplicity.Never,localVars.inParamRequest.ssOrderNumber,cancellationToken);

// order number empty?
if((localVars.queryResGetOrderMainsByOrderNumber_outParamList.Empty)) {
// set error
// Response.OrderNumber = ""
result.outParamResponse.ssOrderNumber = "";

// Response.HasSuccess = False
result.outParamResponse.ssHasSuccess = false;

// Response.ErrorMessage = "E - 002 - " + "Error validating Order Number" + "."
result.outParamResponse.ssErrorMessage = (("E - 002 - "+AppUtils.GetStringResource("AGr4d4r8G0S4uC+_9gNsVQ#Value.-1027459824.1", "Error validating Order Number"))+".");
// LogsAccountingCreate3
localVars.resLogsAccountingCreate3.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = "Resposta Entry Update API", ssDescription = (((AppUtils.GetStringResource("5zfT8iS0JkKkMSe2JLctCw#Value.-1924903246.1", "Order ")+localVars.inParamRequest.ssOrderNumber)+" // ErrorMsg ")+result.outParamResponse.ssErrorMessage), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("p5v2rxHHU0us2h+De0gQag"))).ssId },cancellationToken);

} else {
// Order_SAPNewEntry
localVars.resOrder_SAPNewEntry.outParamMsg = await Actions.ActionOrder_SAPNewEntry(requestContext,localVars.inParamRequest,(localVars.inParamRequest.ssMovementClass=="102"),localVars.queryResGetOrderMainsByOrderNumber_outParamList.CurrentRec.ssENOrderMain.ssId,cancellationToken);

// Response.HasSuccess = True
result.outParamResponse.ssHasSuccess = true;

// Response.ErrorMessage = Order_SAPNewEntry.Msg
result.outParamResponse.ssErrorMessage = localVars.resOrder_SAPNewEntry.outParamMsg;
// LogsAccountingCreate2
localVars.resLogsAccountingCreate2.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = "Resposta Entry Update API", ssDescription = ((AppUtils.GetStringResource("fn6bvEsvF0+OeCw7xPboqA#Value.-1924903246.1", "Order ")+localVars.inParamRequest.ssOrderNumber)+(((result.outParamResponse.ssErrorMessage!="")) ? ((" // ErrorMsg "+result.outParamResponse.ssErrorMessage)) : (" ha devolvido successo"))), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("p5v2rxHHU0us2h+De0gQag"))).ssId },cancellationToken);

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
result.outParamResponse.ssErrorMessage = (("E - 000 - "+AppUtils.GetStringResource("rVpQSODugUeHBulMn1suDw#Value.-341728106.1", "Unknown error in the Portal. Please contact an administrator"))+".");
goto RETURN_STATEMENT;

} // Catch
finally {
outParamResponse = result.outParamResponse;
cancellationToken.ThrowIfCancellationRequested();
} // inner-finally
RETURN_STATEMENT:
return outParamResponse;
}

        public static class FuncActionServiceEntryOrder_Update {
            
// Query Function "GetOrderMainsByOrderNumber" c_3j14EOdkawgBIfpOE6lA of Action "ServiceEntryOrder_Update"
public static async Task<(RL_339e5fbd74448809f3620bf1c8c54b9a,long)> datasetGetOrderMainsByOrderNumber(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteOrderNumber,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ServiceEntryOrder_Update.GetOrderMainsByOrderNumber", "d7e3fd73-0e81-4676-b080-121fa4e13a94");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ServiceEntryOrder_Update.GetOrderMainsByOrderNumber", "d7e3fd73-0e81-4676-b080-121fa4e13a94", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /ServiceAPIMethods.XfEDqEJxjkWj7YbC9p_YAg/NodesNotShownInESpaceTree.c_3j14EOdkawgBIfpOE6lA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enordermain74\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28");
fromBuilder.Append(" FROM {OrderMain} \"enordermain74\"");
whereBuilder.Append(" WHERE (\"enordermain74\".\"ordernumber\" = @qpteOrderNumber)");
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
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ServiceEntryOrder_Update.GetOrderMainsByOrderNumber.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ServiceEntryOrder_Update.GetOrderMainsByOrderNumber.List", cancellationToken: cancellationToken);
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
/// JSONSerialize: JsonSerializeServiceEntryOrder_UpdateJSONSerialize1 (Kqw_EFtuqAkiPMlU9jOdcow)  of
///  Action "ServiceEntryOrder_Update"
/// </summary>
public static void JsonSerializeServiceEntryOrder_UpdateJSONSerialize1 (ST_2f2ec31e2efdad4ee20db1f76bfc2aa4Structure inParamRecord, out string outParamJSON) {
var config = new OutSystems.RESTService.Runtime.Abstractions.Controllers.BaseRestServiceControllerConfiguration() {
DefaultValuesBehavior = OutSystems.RESTService.Runtime.Abstractions.Behaviors.DefaultValuesBehavior.DontSend,
DateTimeFormat = OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO
};

var holder = ssConectaProveedores.RestRecords.JSONST_2f2ec31e2efdad4ee20db1f76bfc2aa4Structure.FromStructure(inParamRecord, config);
outParamJSON = Newtonsoft.Json.JsonConvert.SerializeObject(holder, config.SerializerSettings);

}

        }
    }
}
