namespace ssConectaProveedores;

public partial class Actions {
public class lcvEvent_OrdersImportRequest_OnCreate : VarsBag {
public long inParamId;
/// <summary>
/// Variable <code>DateTimeStamp</code> that represents the Service Studio DateTime
///  <code>DateTimeStamp</code> <p>Description: </p>
/// </summary>
public DateTime varLcDateTimeStamp = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);

/// <summary>
/// Variable <code>RowsWithError</code> that represents the Service Studio IntegerList
///  <code>RowsWithError</code> <p>Description: </p>
/// </summary>
public BasicTypeList<int> varLcRowsWithError = new BasicTypeList<int>();

public Actions.lcoOrdersImport_RequestUpdate resOrdersImportRequestUpdate2 =  new Actions.lcoOrdersImport_RequestUpdate();
public Actions.lcoOrdersImport_Order resOrdersImport_Order =  new Actions.lcoOrdersImport_Order();
public Actions.lcoOrdersImport_RequestUpdateStatus resOrdersImportRequestUpdateStatus =  new Actions.lcoOrdersImport_RequestUpdateStatus();
public Actions.lcoOrdersImport_RequestUpdate resOrdersImportRequestUpdate =  new Actions.lcoOrdersImport_RequestUpdate();
public RL_40391f6554740b0683ce6790af83e1c0 queryResGetOrdersImportRequestById_outParamList = new RL_40391f6554740b0683ce6790af83e1c0();
public long queryResGetOrdersImportRequestById_outParamCount = 0L;

public Actions.lcoOrderLogAdd resOrderLogAdd =  new Actions.lcoOrderLogAdd();
public ST_9c87dd52bd762501ef8a064794927f08Structure resJSONDeserialize_OrdersImportRawStruc_outParamData = new ST_9c87dd52bd762501ef8a064794927f08Structure();
public BasicTypeList<int> resJSONDeserialize_RowsWithError_outParamData = new BasicTypeList<int>();
public string resBinaryDataToText_outParamText = "";

public lcvEvent_OrdersImportRequest_OnCreate(long inParamId) {
this.inParamId = inParamId;
}
}
public class lcoEvent_OrdersImportRequest_OnCreate : VarsBag {
public ST_9f3831cec6ebd34416b59b8df7a27893Structure outParamResult = new ST_9f3831cec6ebd34416b59b8df7a27893Structure();

public lcoEvent_OrdersImportRequest_OnCreate() {
}
}
/// <summary>
/// Action <code>Event_OrdersImportRequest_OnCreate</code> that represents the Service Studio action
///  <code>Event_OrdersImportRequest_OnCreate</code> <p> Description: </p>
/// </summary>
public static async Task<ST_9f3831cec6ebd34416b59b8df7a27893Structure> ActionEvent_OrdersImportRequest_OnCreate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
ST_9f3831cec6ebd34416b59b8df7a27893Structure outParamResult = default;
lcoEvent_OrdersImportRequest_OnCreate result = new lcoEvent_OrdersImportRequest_OnCreate();
lcvEvent_OrdersImportRequest_OnCreate localVars = new lcvEvent_OrdersImportRequest_OnCreate(inParamId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("Event_OrdersImportRequest_OnCreate", "476fef31-a6d3-43bc-afff-282f9e637f59"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("Event_OrdersImportRequest_OnCreate", "476fef31-a6d3-43bc-afff-282f9e637f59", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// SetCurrentLocale
await ExtendedActions.SetCurrentLocale(requestContext,"es-MX",cancellationToken);

// DateTimeStamp = AddMinutes
localVars.varLcDateTimeStamp=BuiltInFunction.AddMinutes (BuiltInFunction.CurrDateTime (), ((((int)AppUtils.SiteProperties[SitePropertiesModel.spBatchTimeDuration]))));
// Query datasetGetOrdersImportRequestById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrdersImportRequestById_maxRecords = 1;
if (datasetGetOrdersImportRequestById_maxRecords < 1) datasetGetOrdersImportRequestById_maxRecords = 1;
int datasetGetOrdersImportRequestById_startIndex = 0;(localVars.queryResGetOrdersImportRequestById_outParamList,localVars.queryResGetOrdersImportRequestById_outParamCount) = await FuncActionEvent_OrdersImportRequest_OnCreate.datasetGetOrdersImportRequestById(requestContext,datasetGetOrdersImportRequestById_maxRecords,datasetGetOrdersImportRequestById_startIndex,IterationMultiplicity.Never,localVars.inParamId,cancellationToken);

// JSON Deserialize JsonDeserializeEvent_OrdersImportRequest_OnCreateJSONDeserialize_RowsWithError
FuncActionEvent_OrdersImportRequest_OnCreate.JsonDeserializeEvent_OrdersImportRequest_OnCreateJSONDeserialize_RowsWithError(localVars.queryResGetOrdersImportRequestById_outParamList.CurrentRec.ssENOrdersImportRequest.ssRowsWithError, out localVars.resJSONDeserialize_RowsWithError_outParamData);
// RowsWithError = JSONDeserialize_RowsWithError.Data
localVars.varLcRowsWithError=localVars.resJSONDeserialize_RowsWithError_outParamData;
// ControledLogMessage
await Actions.ActionControledLogMessage(requestContext,((((bool)AppUtils.SiteProperties[SitePropertiesModel.spOrdersImportLog_IsActive]))),((localVars.queryResGetOrdersImportRequestById_outParamList.Empty) ? (((AppUtils.GetStringResource("EKxDh75Hh0ierTKGfLs_6w#Value.-1556973955.1", "Order not found.(")+BuiltInFunction.LongIntegerToText(localVars.inParamId))+")")) : (((("OrderId: "+BuiltInFunction.LongIntegerToText (localVars.queryResGetOrdersImportRequestById_outParamList.CurrentRec.ssENOrdersImportRequest.ssId))+" | Status: ")+(await Functions.ssGetImportStatus(requestContext,localVars.queryResGetOrdersImportRequestById_outParamList.CurrentRec.ssENOrdersImportRequest.ssStatus,cancellationToken)).ssENImportStatus.ssLabel))),"Event_OrdersImportRequest_OnCreate",cancellationToken);

// OrdersImportRequestUpdateStatus
localVars.resOrdersImportRequestUpdateStatus.outParamResult = await Actions.ActionOrdersImport_RequestUpdateStatus(requestContext,localVars.inParamId,(ENImportStatusEntity.GetRecordByKey(ObjectKey.Parse("oao0OfBC6EeEu3RhczS__A"))).ssId,cancellationToken);

// BinaryDataToText
localVars.resBinaryDataToText_outParamText = await Actions.ActionBinaryDataToText(requestContext,localVars.queryResGetOrdersImportRequestById_outParamList.CurrentRec.ssENOrdersImportRequest.ssImportedData,"UTF-16",cancellationToken);

// JSON Deserialize JsonDeserializeEvent_OrdersImportRequest_OnCreateJSONDeserialize_OrdersImportRawStruc
FuncActionEvent_OrdersImportRequest_OnCreate.JsonDeserializeEvent_OrdersImportRequest_OnCreateJSONDeserialize_OrdersImportRawStruc(localVars.resBinaryDataToText_outParamText, out localVars.resJSONDeserialize_OrdersImportRawStruc_outParamData);
// OrdersImport_Order
(localVars.resOrdersImport_Order.outParamResult,localVars.resOrdersImport_Order.outParamIsNewOrder) = await Actions.ActionOrdersImport_Order(requestContext,localVars.inParamId,localVars.resJSONDeserialize_OrdersImportRawStruc_outParamData,cancellationToken);

// error?
if(((!localVars.resOrdersImport_Order.outParamResult.ssHasSuccess))) {
// OrdersImportRequestUpdate
localVars.resOrdersImportRequestUpdate.outParamResult = await Actions.ActionOrdersImport_RequestUpdate(requestContext,localVars.inParamId,Convert.ToInt64(BuiltInFunction.NullIdentifier ()),0,localVars.resOrdersImport_Order.outParamResult.ssErrorMessage,(ENImportStatusEntity.GetRecordByKey(ObjectKey.Parse("F3Dz4ZMIg06wBPLdoUfwiw"))).ssId,cancellationToken);

// Result
// Result.Identifier = NullIdentifier
result.outParamResult.ssIdentifier = Convert.ToInt64(BuiltInFunction.NullIdentifier ());

// Result.HasSuccess = False
result.outParamResult.ssHasSuccess = false;

// Result.ErrorMessage = OrdersImport_Order.Result.ErrorMessage
result.outParamResult.ssErrorMessage = localVars.resOrdersImport_Order.outParamResult.ssErrorMessage;
} else {
// OrderLogAdd
localVars.resOrderLogAdd.outParamId = await Actions.ActionOrderLogAdd(requestContext,new EN_a8e484428097204171df8a1feecb2534EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssOrderId = localVars.queryResGetOrdersImportRequestById_outParamList.CurrentRec.ssENOrdersImportRequest.ssOrderMainId, ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssMessage = ((AppUtils.GetStringResource("s5PeZN0_HUW3EhTTu9XgCQ#Value.-1924903246.1", "Order ")+localVars.resJSONDeserialize_OrdersImportRawStruc_outParamData.ssOrderNumber)+((localVars.resOrdersImport_Order.outParamIsNewOrder) ? (" was added with success") : (" was updated with success"))) },cancellationToken);

// OrdersImportRequestUpdate2
localVars.resOrdersImportRequestUpdate2.outParamResult = await Actions.ActionOrdersImport_RequestUpdate(requestContext,localVars.inParamId,BuiltInFunction.LongIntegerToIdentifier (localVars.resOrdersImport_Order.outParamResult.ssIdentifier),0,"",(ENImportStatusEntity.GetRecordByKey(ObjectKey.Parse("RHEbPl76h0mij_c4OsqnJA"))).ssId,cancellationToken);

// OrderDistributionForApproval
await Actions.ActionOrdersDistribution_Creation(requestContext,localVars.inParamId,cancellationToken);

// Result
// Result.Identifier = Id
result.outParamResult.ssIdentifier = localVars.inParamId;

// Result.HasSuccess = True
result.outParamResult.ssHasSuccess = true;

// Result.ErrorMessage = ""
result.outParamResult.ssErrorMessage = "";
}

} //close CreateActionActivity using block
} // try

finally {
outParamResult = result.outParamResult;
} // inner-finally
RETURN_STATEMENT:
return outParamResult;
}

public static class FuncActionEvent_OrdersImportRequest_OnCreate {

// Query Function "GetOrdersImportRequestById" st1mZ9UtiEq7k3KjU7q1og of Action "Event_OrdersImportRequest_OnCreate"
public static async Task<(RL_40391f6554740b0683ce6790af83e1c0,long)> datasetGetOrdersImportRequestById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("Event_OrdersImportRequest_OnCreate.GetOrdersImportRequestById", "6766ddb2-2dd5-4a88-bb93-72a353bab5a2");
using var queryActivity = activitySource.CreateAggregateQueryActivity("Event_OrdersImportRequest_OnCreate.GetOrdersImportRequestById", "6766ddb2-2dd5-4a88-bb93-72a353bab5a2", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.Me9vR9OmvEOv_ygvnmN_WQ/NodesNotShownInESpaceTree.st1mZ9UtiEq7k3KjU7q1og, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enordersimportrequest2\".\"id\" o0, NULL o1, \"enordersimportrequest2\".\"importeddata\" o2, \"enordersimportrequest2\".\"ordermainid\" o3, \"enordersimportrequest2\".\"status\" o4, NULL o5, \"enordersimportrequest2\".\"rowswitherror\" o6, NULL o7, NULL o8, NULL o9");
fromBuilder.Append(" FROM {OrdersImportRequest} \"enordersimportrequest2\"");
whereBuilder.Append(" WHERE ");
if (qporId != 0) {
whereBuilder.Append("((\"enordersimportrequest2\".\"id\" = @qporId) AND (\"enordersimportrequest2\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporId", DbType.Int64, qporId);
} else {
whereBuilder.Append("(\"enordersimportrequest2\".\"id\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"enordersimportrequest2\".\"origin\" ASC ");
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
RL_40391f6554740b0683ce6790af83e1c0 outParamList = new RL_40391f6554740b0683ce6790af83e1c0();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, false, false, false, true, false, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query Event_OrdersImportRequest_OnCreate.GetOrdersImportRequestById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_40391f6554740b0683ce6790af83e1c0 _tmp = new RL_40391f6554740b0683ce6790af83e1c0();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query Event_OrdersImportRequest_OnCreate.GetOrdersImportRequestById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_40391f6554740b0683ce6790af83e1c0)_tmp;
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
/// JSON Deserialize :
///  JsonDeserializeEvent_OrdersImportRequest_OnCreateJSONDeserialize_OrdersImportRawStru
/// c (K3K_VzDCXO0WJEKTlg6RQgA)  of Action "Event_OrdersImportRequest_OnCreate"
/// </summary>
public static void JsonDeserializeEvent_OrdersImportRequest_OnCreateJSONDeserialize_OrdersImportRawStruc (string inParamJson, out ST_9c87dd52bd762501ef8a064794927f08Structure outParamData) {
outParamData = new ST_9c87dd52bd762501ef8a064794927f08Structure();;
ssConectaProveedores.RestRecords.JSONST_9c87dd52bd762501ef8a064794927f08Structure holder = null;

var config = new OutSystems.RESTService.Runtime.Abstractions.Controllers.BaseRestServiceControllerConfiguration() {
    DateTimeFormat = OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO
};

var serializerSettings = config.SerializerSettings;

try {
	holder = Newtonsoft.Json.JsonConvert.DeserializeObject<ssConectaProveedores.RestRecords.JSONST_9c87dd52bd762501ef8a064794927f08Structure>(inParamJson, serializerSettings);
    outParamData = ssConectaProveedores.RestRecords.JSONST_9c87dd52bd762501ef8a064794927f08Structure.ToStructure(holder, config);
} catch (Exception e) {
    throw InvalidJsonErrorsHelper.FailedToDeserialize("OrdersRequest", e);
}

}

/// <summary>
/// JSON Deserialize : JsonDeserializeEvent_OrdersImportRequest_OnCreateJSONDeserialize_RowsWithError
///  (K1PHzzLz9DE2KbpUCqac2RQ)  of Action "Event_OrdersImportRequest_OnCreate"
/// </summary>
public static void JsonDeserializeEvent_OrdersImportRequest_OnCreateJSONDeserialize_RowsWithError (string inParamJson, out BasicTypeList<int> outParamData) {
outParamData = new BasicTypeList<int>();;
int[] holder = null;

var config = new OutSystems.RESTService.Runtime.Abstractions.Controllers.BaseRestServiceControllerConfiguration() {
    DateTimeFormat = OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO
};

var serializerSettings = config.SerializerSettings;

try {
	holder = Newtonsoft.Json.JsonConvert.DeserializeObject<int[]>(inParamJson, serializerSettings);
    outParamData = BasicTypeList<int>.ToList(holder);
} catch (Exception e) {
    throw InvalidJsonErrorsHelper.FailedToDeserialize("IntegerList", e);
}

}

}


}
