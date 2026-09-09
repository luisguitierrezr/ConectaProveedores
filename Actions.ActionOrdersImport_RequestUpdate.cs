namespace ssConectaProveedores;

public partial class Actions {
public class lcvOrdersImport_RequestUpdate : VarsBag {
public long inParamId;
public long inParamOrderMainId;
public int inParamRowNumber;
public string inParamRowsWithError;
public int inParamStatus;
/// <summary>
/// Variable <code>OrdersImportRequest</code> that represents the Service Studio OrdersImportRequest
///  <code>OrdersImportRequest</code> <p>Description: </p>
/// </summary>
public EN_8c3668a93870461b8ea1216c2848f298EntityRecord varLcOrdersImportRequest = new EN_8c3668a93870461b8ea1216c2848f298EntityRecord();

public RL_40391f6554740b0683ce6790af83e1c0 queryResGetOrdersImportRequestById_outParamList = new RL_40391f6554740b0683ce6790af83e1c0();
public long queryResGetOrdersImportRequestById_outParamCount = 0L;

public lcvOrdersImport_RequestUpdate(long inParamId, long inParamOrderMainId, int inParamRowNumber, string inParamRowsWithError, int inParamStatus) {
this.inParamId = inParamId;
this.inParamOrderMainId = inParamOrderMainId;
this.inParamRowNumber = inParamRowNumber;
this.inParamRowsWithError = inParamRowsWithError;
this.inParamStatus = inParamStatus;
}
}
public class lcoOrdersImport_RequestUpdate : VarsBag {
public ST_9f3831cec6ebd34416b59b8df7a27893Structure outParamResult = new ST_9f3831cec6ebd34416b59b8df7a27893Structure();

public lcoOrdersImport_RequestUpdate() {
}
}
/// <summary>
/// Action <code>OrdersImport_RequestUpdate</code> that represents the Service Studio action
///  <code>OrdersImport_RequestUpdate</code> <p> Description: Encapsulates the Update entity action
/// , enabling logic to run consistently before and after a record is modified.</p>
/// </summary>
public static async Task<ST_9f3831cec6ebd34416b59b8df7a27893Structure> ActionOrdersImport_RequestUpdate(IRequestContext requestContext,long inParamId,long inParamOrderMainId,int inParamRowNumber,string inParamRowsWithError,int inParamStatus,CancellationToken cancellationToken) {
ST_9f3831cec6ebd34416b59b8df7a27893Structure outParamResult = default;
lcoOrdersImport_RequestUpdate result = new lcoOrdersImport_RequestUpdate();
lcvOrdersImport_RequestUpdate localVars = new lcvOrdersImport_RequestUpdate(inParamId, inParamOrderMainId, inParamRowNumber, inParamRowsWithError, inParamStatus);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("OrdersImport_RequestUpdate", "24361888-73c5-4260-b4fd-782ae1d69655"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("OrdersImport_RequestUpdate", "24361888-73c5-4260-b4fd-782ae1d69655", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Has Identifier?
if(((localVars.inParamId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// Mandatory attributes validation
if(((localVars.inParamStatus!=BuiltInFunction.NullIdentifier ()))) {
// ControledLogMessage2
await Actions.ActionControledLogMessage(requestContext,((((bool)AppUtils.SiteProperties[SitePropertiesModel.spOrdersImportLog_IsActive]))),AppUtils.GetStringResource("8+Qz3vjLwU6j74P8QBzRIA#Value.801177448.1", "OrdersImport_RequestUpdate » Request updated"),"OrdersImport_RequestUpdate",cancellationToken);

// Query datasetGetOrdersImportRequestById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrdersImportRequestById_maxRecords = 1;
if (datasetGetOrdersImportRequestById_maxRecords < 1) datasetGetOrdersImportRequestById_maxRecords = 1;
int datasetGetOrdersImportRequestById_startIndex = 0;(localVars.queryResGetOrdersImportRequestById_outParamList,localVars.queryResGetOrdersImportRequestById_outParamCount) = await FuncActionOrdersImport_RequestUpdate.datasetGetOrdersImportRequestById(requestContext,datasetGetOrdersImportRequestById_maxRecords,datasetGetOrdersImportRequestById_startIndex,IterationMultiplicity.Never,localVars.inParamId,cancellationToken);

// OrdersImportRequest = GetOrdersImportRequestById.List.Current.OrdersImportRequest
localVars.varLcOrdersImportRequest=localVars.queryResGetOrdersImportRequestById_outParamList.CurrentRec.ssENOrdersImportRequest;
// Set basic audit attributes
// OrdersImportRequest.LastRowNumberRead = RowNumber
localVars.varLcOrdersImportRequest.ssLastRowNumberRead = localVars.inParamRowNumber;

// OrdersImportRequest.RowsWithError = RowsWithError
localVars.varLcOrdersImportRequest.ssRowsWithError = localVars.inParamRowsWithError;

// OrdersImportRequest.OrderMainId = OrderMainId
localVars.varLcOrdersImportRequest.ssOrderMainId = localVars.inParamOrderMainId;

// OrdersImportRequest.Status = Status
localVars.varLcOrdersImportRequest.ssStatus = localVars.inParamStatus;

// OrdersImportRequest.UpdatedOn = CurrDateTime
localVars.varLcOrdersImportRequest.ssUpdatedOn = BuiltInFunction.CurrDateTime ();
// UpdateOrdersImportRequest
await ExtendedActions.UpdateOrdersImportRequest(requestContext,localVars.varLcOrdersImportRequest.ChangedAttributes,(((RC_2407b5abb2cbfeaeaa8da6cdea4ccf12)localVars.varLcOrdersImportRequest)),cancellationToken);

// Set Id
// Result.Identifier = Id
result.outParamResult.ssIdentifier = localVars.inParamId;

// Result.HasSuccess = True
result.outParamResult.ssHasSuccess = true;

// Result.ErrorMessage = ""
result.outParamResult.ssErrorMessage = "";
} else {
// Result.HasSuccess = False
result.outParamResult.ssHasSuccess = false;

// Result.ErrorMessage = "Status is mandatory"
result.outParamResult.ssErrorMessage = AppUtils.GetStringResource("4Coz6UvN70C8uWNPv+RvEg#Value.1534308273.1", "Status is mandatory");

// Result.Identifier = Id
result.outParamResult.ssIdentifier = localVars.inParamId;
}

} else {
// Result.HasSuccess = False
result.outParamResult.ssHasSuccess = false;

// Result.ErrorMessage = "Identifier is mandatory"
result.outParamResult.ssErrorMessage = AppUtils.GetStringResource("ubqWEF5d0kqtn7TnS7Plmw#Value.48399450.1", "Identifier is mandatory");

// Result.Identifier = Id
result.outParamResult.ssIdentifier = localVars.inParamId;
}

} //close CreateActionActivity using block
} // try

finally {
outParamResult = result.outParamResult;
} // inner-finally
RETURN_STATEMENT:
return outParamResult;
}

public static class FuncActionOrdersImport_RequestUpdate {

// Query Function "GetOrdersImportRequestById" 8VhUn3xor02vAPZmVqxgQw of Action "OrdersImport_RequestUpdate"
public static async Task<(RL_40391f6554740b0683ce6790af83e1c0,long)> datasetGetOrdersImportRequestById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("OrdersImport_RequestUpdate.GetOrdersImportRequestById", "9f5458f1-687c-4daf-af00-f66656ac6043");
using var queryActivity = activitySource.CreateAggregateQueryActivity("OrdersImport_RequestUpdate.GetOrdersImportRequestById", "9f5458f1-687c-4daf-af00-f66656ac6043", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.iBg2JMVzYEK0_Xgq4daWVQ/NodesNotShownInESpaceTree.8VhUn3xor02vAPZmVqxgQw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enordersimportrequest1\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9");
fromBuilder.Append(" FROM {OrdersImportRequest} \"enordersimportrequest1\"");
whereBuilder.Append(" WHERE ");
if (qporId != 0) {
whereBuilder.Append("((\"enordersimportrequest1\".\"id\" = @qporId) AND (\"enordersimportrequest1\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporId", DbType.Int64, qporId);
} else {
whereBuilder.Append("(\"enordersimportrequest1\".\"id\" IS NULL)");
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
RL_40391f6554740b0683ce6790af83e1c0 outParamList = new RL_40391f6554740b0683ce6790af83e1c0();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query OrdersImport_RequestUpdate.GetOrdersImportRequestById.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query OrdersImport_RequestUpdate.GetOrdersImportRequestById.List", cancellationToken: cancellationToken);
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



}


}
