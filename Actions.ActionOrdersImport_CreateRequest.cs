namespace ssConectaProveedores;

public partial class Actions {
public class lcvOrdersImport_CreateRequest : VarsBag {
public string inParamOrigin;
public ST_9c87dd52bd762501ef8a064794927f08Structure inParamRequest;
public bool inParamAllowCreation;
public Actions.lcoLogsAccountingCreate resLogsAccountingCreate2 =  new Actions.lcoLogsAccountingCreate();
public Actions.lcoLogsAccountingCreate resLogsAccountingCreate3 =  new Actions.lcoLogsAccountingCreate();
public Actions.lcoOrdersImport_RequestCreate resOrdersImport_RequestCreate =  new Actions.lcoOrdersImport_RequestCreate();
public Actions.lcoEvent_OrdersImportRequest_OnCreate resEvent_OrdersImportRequest_OnCreate =  new Actions.lcoEvent_OrdersImportRequest_OnCreate();
public Actions.lcoLogsAccountingCreate resLogsAccountingCreate =  new Actions.lcoLogsAccountingCreate();
public string resJSONSerialize1_outParamJSON = "";
public RL_339e5fbd74448809f3620bf1c8c54b9a queryResGetOrderMains_outParamList = new RL_339e5fbd74448809f3620bf1c8c54b9a();
public long queryResGetOrderMains_outParamCount = 0L;

public byte[] resTextToBinaryData_outParamBinaryData = new byte[] {};

public Actions.lcoOrdersImport_Validations resOrdersImport_Validations =  new Actions.lcoOrdersImport_Validations();
public lcvOrdersImport_CreateRequest(string inParamOrigin, ST_9c87dd52bd762501ef8a064794927f08Structure inParamRequest, bool inParamAllowCreation) {
this.inParamOrigin = inParamOrigin;
this.inParamRequest = inParamRequest;
this.inParamAllowCreation = inParamAllowCreation;
}
}
public class lcoOrdersImport_CreateRequest : VarsBag {
public ST_5a17d82af8397abda9cf3915ce9c082fStructure outParamResponse = new ST_5a17d82af8397abda9cf3915ce9c082fStructure();

public lcoOrdersImport_CreateRequest() {
}
}
/// <summary>
/// Action <code>OrdersImport_CreateRequest</code> that represents the Service Studio action
///  <code>OrdersImport_CreateRequest</code> <p> Description: </p>
/// </summary>
public static async Task<ST_5a17d82af8397abda9cf3915ce9c082fStructure> ActionOrdersImport_CreateRequest(IRequestContext requestContext,string inParamOrigin,ST_9c87dd52bd762501ef8a064794927f08Structure inParamRequest,bool inParamAllowCreation,CancellationToken cancellationToken) {
ST_5a17d82af8397abda9cf3915ce9c082fStructure outParamResponse = default;
lcoOrdersImport_CreateRequest result = new lcoOrdersImport_CreateRequest();
lcvOrdersImport_CreateRequest localVars = new lcvOrdersImport_CreateRequest(inParamOrigin, inParamRequest, inParamAllowCreation);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("OrdersImport_CreateRequest", "6cabba7d-71cb-4b7c-9ea9-fa43fd47cf36"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("OrdersImport_CreateRequest", "6cabba7d-71cb-4b7c-9ea9-fa43fd47cf36", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// order number empty?
if(((localVars.inParamRequest.ssOrderNumber==""))) {
// set error
// Response.OrderNumber = ""
result.outParamResponse.ssOrderNumber = "";

// Response.HasSuccess = False
result.outParamResponse.ssHasSuccess = false;

// Response.ErrorMessage = "E - 002 - " + "Error validating Order Number" + "."
result.outParamResponse.ssErrorMessage = (("E - 002 - "+AppUtils.GetStringResource("y9GCLDj4DUutSsMEM9q3pg#Value.-1027459824.1", "Error validating Order Number"))+".");
} else {
if(!((localVars.inParamAllowCreation))) {
// IgnoreOrderCreationFromApi
if((((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIgnoreOrderCreationFromAPI]))))) {
// Query datasetGetOrderMains
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderMains_maxRecords = 1;
if (datasetGetOrderMains_maxRecords < 1) datasetGetOrderMains_maxRecords = 1;
int datasetGetOrderMains_startIndex = 0;(localVars.queryResGetOrderMains_outParamList,localVars.queryResGetOrderMains_outParamCount) = await FuncActionOrdersImport_CreateRequest.datasetGetOrderMains(requestContext,datasetGetOrderMains_maxRecords,datasetGetOrderMains_startIndex,IterationMultiplicity.Never,localVars.inParamRequest.ssOrderNumber,cancellationToken);

if((localVars.queryResGetOrderMains_outParamList.Empty)) {
// LogMessage
await ExtendedActions.LogMessage(requestContext,("Order Rejected:"+localVars.inParamRequest.ssOrderNumber),"Order Rejected",cancellationToken);

// Success
// Response.OrderNumber = Request.OrderNumber
result.outParamResponse.ssOrderNumber = localVars.inParamRequest.ssOrderNumber;

// Response.HasSuccess = True
result.outParamResponse.ssHasSuccess = true;

// Response.ErrorMessage = ""
result.outParamResponse.ssErrorMessage = "";
goto RETURN_STATEMENT;

}

}

}

// OrdersImport_Validations
localVars.resOrdersImport_Validations.outParamo_ValidationResult = await Actions.ActionOrdersImport_Validations(requestContext,localVars.inParamRequest,cancellationToken);

// error?
if(((!localVars.resOrdersImport_Validations.outParamo_ValidationResult.ssHasSuccess))) {
// set error
// Response = OrdersImport_Validations.o_ValidationResult
result.outParamResponse=localVars.resOrdersImport_Validations.outParamo_ValidationResult;
// LogsAccountingCreate
localVars.resLogsAccountingCreate.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = AppUtils.GetStringResource("VuKgJ1B3FUeX5r6WZEzkCQ#Value.1771819683.1", "Error Validating Order Create"), ssDescription = ((localVars.resOrdersImport_Validations.outParamo_ValidationResult.ssOrderNumber+" // ")+localVars.resOrdersImport_Validations.outParamo_ValidationResult.ssErrorMessage), ssCreatedBy = BuiltInFunction.NullTextIdentifier (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("aLSmUDKuY0yTX3RQe5p3KQ"))).ssId },cancellationToken);

} else {
// JSON Serialize JsonSerializeOrdersImport_CreateRequestJSONSerialize1
FuncActionOrdersImport_CreateRequest.JsonSerializeOrdersImport_CreateRequestJSONSerialize1(localVars.inParamRequest, out localVars.resJSONSerialize1_outParamJSON);
// TextToBinaryData
localVars.resTextToBinaryData_outParamBinaryData = await Actions.ActionTextToBinaryData(requestContext,localVars.resJSONSerialize1_outParamJSON,"UTF-16",cancellationToken);

// OrdersImport_RequestCreate
localVars.resOrdersImport_RequestCreate.outParamResult = await Actions.ActionOrdersImport_RequestCreate(requestContext,localVars.inParamOrigin,localVars.resTextToBinaryData_outParamBinaryData,cancellationToken);

// error?
if(((!localVars.resOrdersImport_RequestCreate.outParamResult.ssHasSuccess))) {
// set error
// Response = OrdersImport_RequestCreate.Result
result.outParamResponse=(await RecordUtils.ConvertAsync(localVars.resOrdersImport_RequestCreate.outParamResult, new ST_5a17d82af8397abda9cf3915ce9c082fStructure(), async (ST_9f3831cec6ebd34416b59b8df7a27893Structure source, ST_5a17d82af8397abda9cf3915ce9c082fStructure target, CancellationToken cancellationToken) => {
target.ssOrderNumber = localVars.inParamRequest.ssOrderNumber;
target.ssHasSuccess = source.ssHasSuccess;
target.ssErrorMessage = source.ssErrorMessage;
return target;
}, cancellationToken));
// LogsAccountingCreate2
localVars.resLogsAccountingCreate2.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = AppUtils.GetStringResource("qXtlnO31c0mBPpUK_ElReg#Value.65116311.1", "Error On Order Create"), ssDescription = ((localVars.resOrdersImport_Validations.outParamo_ValidationResult.ssOrderNumber+" // ")+localVars.resOrdersImport_RequestCreate.outParamResult.ssErrorMessage), ssCreatedBy = BuiltInFunction.NullTextIdentifier (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("aLSmUDKuY0yTX3RQe5p3KQ"))).ssId },cancellationToken);

} else {
// Event_OrdersImportRequest_OnCreate
localVars.resEvent_OrdersImportRequest_OnCreate.outParamResult = await Actions.ActionEvent_OrdersImportRequest_OnCreate(requestContext,BuiltInFunction.LongIntegerToIdentifier (localVars.resOrdersImport_RequestCreate.outParamResult.ssIdentifier),cancellationToken);

// error?
if(((!localVars.resEvent_OrdersImportRequest_OnCreate.outParamResult.ssHasSuccess))) {
// set error
// Response = Event_OrdersImportRequest_OnCreate.Result
result.outParamResponse=(await RecordUtils.ConvertAsync(localVars.resEvent_OrdersImportRequest_OnCreate.outParamResult, new ST_5a17d82af8397abda9cf3915ce9c082fStructure(), async (ST_9f3831cec6ebd34416b59b8df7a27893Structure source, ST_5a17d82af8397abda9cf3915ce9c082fStructure target, CancellationToken cancellationToken) => {
target.ssOrderNumber = localVars.inParamRequest.ssOrderNumber;
target.ssHasSuccess = source.ssHasSuccess;
target.ssErrorMessage = source.ssErrorMessage;
return target;
}, cancellationToken));
// LogsAccountingCreate3
localVars.resLogsAccountingCreate3.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = AppUtils.GetStringResource("o4I62ZwEeUSGh+to289gdg#Value.65116311.1", "Error On Order Create"), ssDescription = ((localVars.resOrdersImport_Validations.outParamo_ValidationResult.ssOrderNumber+" // ")+localVars.resOrdersImport_RequestCreate.outParamResult.ssErrorMessage), ssCreatedBy = BuiltInFunction.NullTextIdentifier (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("aLSmUDKuY0yTX3RQe5p3KQ"))).ssId },cancellationToken);

} else {
// Success
// Response.OrderNumber = Request.OrderNumber
result.outParamResponse.ssOrderNumber = localVars.inParamRequest.ssOrderNumber;

// Response.HasSuccess = True
result.outParamResponse.ssHasSuccess = true;

// Response.ErrorMessage = ""
result.outParamResponse.ssErrorMessage = "";
}

}

}

}

} //close CreateActionActivity using block
} // try

finally {
outParamResponse = result.outParamResponse;
} // inner-finally
RETURN_STATEMENT:
return outParamResponse;
}

public static class FuncActionOrdersImport_CreateRequest {

// Query Function "GetOrderMains" sWkbwiNYvUyXL__78_RPng of Action "OrdersImport_CreateRequest"
public static async Task<(RL_339e5fbd74448809f3620bf1c8c54b9a,long)> datasetGetOrderMains(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteOrderNumber,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("OrdersImport_CreateRequest.GetOrderMains", "c21b69b1-5823-4cbd-972f-fffbf3f44f9e");
using var queryActivity = activitySource.CreateAggregateQueryActivity("OrdersImport_CreateRequest.GetOrderMains", "c21b69b1-5823-4cbd-972f-fffbf3f44f9e", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.fbqrbMtxfEueqfpD_UfPNg/NodesNotShownInESpaceTree.sWkbwiNYvUyXL__78_RPng, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28");
fromBuilder.Append(" FROM {OrderMain} \"enordermain31\"");
whereBuilder.Append(" WHERE ((trim(\"enordermain31\".\"ordernumber\")) = (trim(@qpteOrderNumber)))");
orderByBuilder.Append(" ORDER BY \"enordermain31\".\"ordernumber\" ASC ");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query OrdersImport_CreateRequest.GetOrderMains.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query OrdersImport_CreateRequest.GetOrderMains.List", cancellationToken: cancellationToken);
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
/// JSONSerialize: JsonSerializeOrdersImport_CreateRequestJSONSerialize1 (KbWLnvl2ia0Cba3M84r08Kw)  of
///  Action "OrdersImport_CreateRequest"
/// </summary>
public static void JsonSerializeOrdersImport_CreateRequestJSONSerialize1 (ST_9c87dd52bd762501ef8a064794927f08Structure inParamRecord, out string outParamJSON) {
var config = new OutSystems.RESTService.Runtime.Abstractions.Controllers.BaseRestServiceControllerConfiguration() {
DefaultValuesBehavior = OutSystems.RESTService.Runtime.Abstractions.Behaviors.DefaultValuesBehavior.Send,
DateTimeFormat = OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO
};

var holder = ssConectaProveedores.RestRecords.JSONST_9c87dd52bd762501ef8a064794927f08Structure.FromStructure(inParamRecord, config);
outParamJSON = Newtonsoft.Json.JsonConvert.SerializeObject(holder, config.SerializerSettings);

}

}


}
