namespace ssConectaProveedores;

public partial class Actions {
public class lcvInitializeOrderAccounting : VarsBag {
public long inParami_OrderId;
public Actions.lcoOrderAccConceptsCreateOrUpdate resOrderAccConceptsCreateOrUpdate2 =  new Actions.lcoOrderAccConceptsCreateOrUpdate();
public RL_d567d658fa66fc955f880e37985e7f35 queryResGetAccountingDataTypes_outParamList = new RL_d567d658fa66fc955f880e37985e7f35();
public long queryResGetAccountingDataTypes_outParamCount = 0L;

public RL_339e5fbd74448809f3620bf1c8c54b9a queryResGetOrderById_outParamList = new RL_339e5fbd74448809f3620bf1c8c54b9a();
public long queryResGetOrderById_outParamCount = 0L;

public Actions.lcoOrderAccountingCreateOrUpdate resOrderAccountingCreateOrUpdate =  new Actions.lcoOrderAccountingCreateOrUpdate();
public Actions.lcoOrderAccConceptsCreateOrUpdate resOrderAccConceptsCreateOrUpdate =  new Actions.lcoOrderAccConceptsCreateOrUpdate();
public lcvInitializeOrderAccounting(long inParami_OrderId) {
this.inParami_OrderId = inParami_OrderId;
}
}
/// <summary>
/// Action <code>InitializeOrderAccounting</code> that represents the Service Studio action
///  <code>InitializeOrderAccounting</code> <p> Description: Initialize Order Accounting data</p>
/// </summary>
public static async Task ActionInitializeOrderAccounting(IRequestContext requestContext,long inParami_OrderId,CancellationToken cancellationToken) {
lcvInitializeOrderAccounting localVars = new lcvInitializeOrderAccounting(inParami_OrderId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("InitializeOrderAccounting", "18e68e23-0547-4a0f-8c53-3a3e963c81c4"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("InitializeOrderAccounting", "18e68e23-0547-4a0f-8c53-3a3e963c81c4", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetOrderById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderById_maxRecords = 1;
if (datasetGetOrderById_maxRecords < 1) datasetGetOrderById_maxRecords = 1;
int datasetGetOrderById_startIndex = 0;(localVars.queryResGetOrderById_outParamList,localVars.queryResGetOrderById_outParamCount) = await FuncActionInitializeOrderAccounting.datasetGetOrderById(requestContext,datasetGetOrderById_maxRecords,datasetGetOrderById_startIndex,IterationMultiplicity.Never,localVars.inParami_OrderId,cancellationToken);

// OrderAccountingCreateOrUpdate
localVars.resOrderAccountingCreateOrUpdate.outParamId = await Actions.ActionOrderAccountingCreateOrUpdate(requestContext,new EN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssOrderId = localVars.inParami_OrderId, ssNegociatedExchangeRateAcc = localVars.queryResGetOrderById_outParamList.CurrentRec.ssENOrderMain.ssExchangeRate },cancellationToken);

// Query datasetGetAccountingDataTypes
cancellationToken.ThrowIfCancellationRequested();
int datasetGetAccountingDataTypes_maxRecords = 0;
int datasetGetAccountingDataTypes_startIndex = 0;(localVars.queryResGetAccountingDataTypes_outParamList,localVars.queryResGetAccountingDataTypes_outParamCount) = await FuncActionInitializeOrderAccounting.datasetGetAccountingDataTypes(requestContext,datasetGetAccountingDataTypes_maxRecords,datasetGetAccountingDataTypes_startIndex,IterationMultiplicity.Single,cancellationToken);

// OrderAccConceptsCreateOrUpdate2
localVars.resOrderAccConceptsCreateOrUpdate2.outParamId = await Actions.ActionOrderAccConceptsCreateOrUpdate(requestContext,new EN_3e07a23619060cc7dc5624548803f5fdEntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssOrderAccountingId = localVars.resOrderAccountingCreateOrUpdate.outParamId, ssAccountingDataTypeId = 7, ssNumberOfPayments = 0, ssAmount = (((decimal)0)), ssCurrencyId = BuiltInFunction.NullTextIdentifier (), ssOrderAccConceptsId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssIsActive = false },cancellationToken);

// Foreach GetAccountingDataTypes.List
localVars.queryResGetAccountingDataTypes_outParamList.StartIteration();
try {while (!((localVars.queryResGetAccountingDataTypes_outParamList.Eof))) {
// OrderAccConceptsCreateOrUpdate
localVars.resOrderAccConceptsCreateOrUpdate.outParamId = await Actions.ActionOrderAccConceptsCreateOrUpdate(requestContext,new EN_3e07a23619060cc7dc5624548803f5fdEntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssOrderAccountingId = localVars.resOrderAccountingCreateOrUpdate.outParamId, ssAccountingDataTypeId = localVars.queryResGetAccountingDataTypes_outParamList.CurrentRec.ssENAccountingDataType.ssId, ssNumberOfPayments = 0, ssAmount = (((decimal)0)), ssCurrencyId = BuiltInFunction.NullTextIdentifier (), ssOrderAccConceptsId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssIsActive = false },cancellationToken);

localVars.queryResGetAccountingDataTypes_outParamList.Advance();
}

} finally {
localVars.queryResGetAccountingDataTypes_outParamList.EndIteration();
}

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionInitializeOrderAccounting {

// Query Function "GetAccountingDataTypes" 7oa0YTKm2Emf9bV7WzqeOQ of Action "InitializeOrderAccounting"
public static async Task<(RL_d567d658fa66fc955f880e37985e7f35,long)> datasetGetAccountingDataTypes(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InitializeOrderAccounting.GetAccountingDataTypes", "61b486ee-a632-49d8-9ff5-b57b5b3a9e39");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InitializeOrderAccounting.GetAccountingDataTypes", "61b486ee-a632-49d8-9ff5-b57b5b3a9e39", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Single
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
selectBuilder.Append("/* /UserActions.I47mGEcFD0qMUzo+ljyBxA/NodesNotShownInESpaceTree.7oa0YTKm2Emf9bV7WzqeOQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enaccountingdatatype\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4");
fromBuilder.Append(" FROM {AccountingDataType} \"enaccountingdatatype\"");
whereBuilder.Append(" WHERE (\"enaccountingdatatype\".\"is_active\" = 1) AND (NOT (\"enaccountingdatatype\".\"isestim_equal_agreed\" = 1)) AND (\"enaccountingdatatype\".\"id\" <> ");
whereBuilder.Append(7
);
whereBuilder.Append(")");
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
RL_d567d658fa66fc955f880e37985e7f35 outParamList = new RL_d567d658fa66fc955f880e37985e7f35();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InitializeOrderAccounting.GetAccountingDataTypes.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_d567d658fa66fc955f880e37985e7f35 _tmp = new RL_d567d658fa66fc955f880e37985e7f35();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InitializeOrderAccounting.GetAccountingDataTypes.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_d567d658fa66fc955f880e37985e7f35)_tmp;
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

// Query Function "GetOrderById" Rv_tt8KG6UWbyQRfDR+bMQ of Action "InitializeOrderAccounting"
public static async Task<(RL_339e5fbd74448809f3620bf1c8c54b9a,long)> datasetGetOrderById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InitializeOrderAccounting.GetOrderById", "b7edff46-86c2-45e9-9bc9-045f0d1f9b31");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InitializeOrderAccounting.GetOrderById", "b7edff46-86c2-45e9-9bc9-045f0d1f9b31", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.I47mGEcFD0qMUzo+ljyBxA/NodesNotShownInESpaceTree.Rv_tt8KG6UWbyQRfDR+bMQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, trim_scale(\"enordermain6\".\"exchangerate\"::numeric) o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28");
fromBuilder.Append(" FROM {OrderMain} \"enordermain6\"");
whereBuilder.Append(" WHERE ");
if (qporId != 0) {
whereBuilder.Append("((\"enordermain6\".\"id\" = @qporId) AND (\"enordermain6\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporId", DbType.Int64, qporId);
} else {
whereBuilder.Append("(\"enordermain6\".\"id\" IS NULL)");
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
RL_339e5fbd74448809f3620bf1c8c54b9a outParamList = new RL_339e5fbd74448809f3620bf1c8c54b9a();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InitializeOrderAccounting.GetOrderById.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InitializeOrderAccounting.GetOrderById.List", cancellationToken: cancellationToken);
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



}


}
