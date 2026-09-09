namespace ssConectaProveedores;

public partial class Actions {
public class lcvGetOrderK012 : VarsBag {
public long inParamOrderMainId;
public RL_e5767287da79a139581b76b6fbb20753 queryResGetOrderDetailByOrderId_outParamList = new RL_e5767287da79a139581b76b6fbb20753();
public long queryResGetOrderDetailByOrderId_outParamCount = 0L;

public RL_375b9dd8c8b0d6d7bccf4d550f48644d queryResGetPaymentTerms_outParamList = new RL_375b9dd8c8b0d6d7bccf4d550f48644d();
public long queryResGetPaymentTerms_outParamCount = 0L;

public lcvGetOrderK012(long inParamOrderMainId) {
this.inParamOrderMainId = inParamOrderMainId;
}
}
public class lcoGetOrderK012 : VarsBag {
public string outParamPaymentTermsDesc = "";

public int outParamPaymentTermDays = 0;

public lcoGetOrderK012() {
}
}
/// <summary>
/// Action <code>GetOrderK012</code> that represents the Service Studio action
///  <code>GetOrderK012</code> <p> Description: </p>
/// </summary>
public static async Task<(string,int)> ActionGetOrderK012(IRequestContext requestContext,long inParamOrderMainId,CancellationToken cancellationToken) {
string outParamPaymentTermsDesc = default;
int outParamPaymentTermDays = default;
lcoGetOrderK012 result = new lcoGetOrderK012();
lcvGetOrderK012 localVars = new lcvGetOrderK012(inParamOrderMainId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GetOrderK012", "130ad76e-f240-449e-8177-15d2ff644e5c"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GetOrderK012", "130ad76e-f240-449e-8177-15d2ff644e5c", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetOrderDetailByOrderId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderDetailByOrderId_maxRecords = 1;
if (datasetGetOrderDetailByOrderId_maxRecords < 1) datasetGetOrderDetailByOrderId_maxRecords = 1;
int datasetGetOrderDetailByOrderId_startIndex = 0;(localVars.queryResGetOrderDetailByOrderId_outParamList,localVars.queryResGetOrderDetailByOrderId_outParamCount) = await FuncActionGetOrderK012.datasetGetOrderDetailByOrderId(requestContext,datasetGetOrderDetailByOrderId_maxRecords,datasetGetOrderDetailByOrderId_startIndex,IterationMultiplicity.Never,localVars.inParamOrderMainId,cancellationToken);

// is all validated
if((!(localVars.queryResGetOrderDetailByOrderId_outParamList.CurrentRec.ssENOrderDetail.ssAllContactFilesValidated))) {
// Query datasetGetPaymentTerms
cancellationToken.ThrowIfCancellationRequested();
int datasetGetPaymentTerms_maxRecords = 0;
int datasetGetPaymentTerms_startIndex = 0;(localVars.queryResGetPaymentTerms_outParamList,localVars.queryResGetPaymentTerms_outParamCount) = await FuncActionGetOrderK012.datasetGetPaymentTerms(requestContext,datasetGetPaymentTerms_maxRecords,datasetGetPaymentTerms_startIndex,IterationMultiplicity.Never,cancellationToken);

// PaymentTermsDesc = "K012"
result.outParamPaymentTermsDesc="K012";

// PaymentTermDays = TextToInteger
result.outParamPaymentTermDays=BuiltInFunction.TextToInteger (localVars.queryResGetPaymentTerms_outParamList.CurrentRec.ssENPaymentTerms.ssCtd_dias);
}

} //close CreateActionActivity using block
} // try

finally {
outParamPaymentTermsDesc = result.outParamPaymentTermsDesc;
outParamPaymentTermDays = result.outParamPaymentTermDays;
} // inner-finally
RETURN_STATEMENT:
return (outParamPaymentTermsDesc,outParamPaymentTermDays);
}

public static class FuncActionGetOrderK012 {

// Query Function "GetOrderDetailByOrderId" _hfozkMoakeKqIFWUBUCpw of Action "GetOrderK012"
public static async Task<(RL_e5767287da79a139581b76b6fbb20753,long)> datasetGetOrderDetailByOrderId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetOrderK012.GetOrderDetailByOrderId", "cee817fe-2843-476a-8aa8-8156501502a7");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetOrderK012.GetOrderDetailByOrderId", "cee817fe-2843-476a-8aa8-8156501502a7", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.btcKE0DynkSBdxXS_2ROXA/NodesNotShownInESpaceTree._hfozkMoakeKqIFWUBUCpw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, \"enorderdetail\".\"allcontactfilesvalidated\" o37, NULL o38");
fromBuilder.Append(" FROM {OrderDetail} \"enorderdetail\"");
whereBuilder.Append(" WHERE ");
if (qporOrderId != 0) {
whereBuilder.Append("((\"enorderdetail\".\"orderid\" = @qporOrderId) AND (\"enorderdetail\".\"orderid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderId", DbType.Int64, qporOrderId);
} else {
whereBuilder.Append("(\"enorderdetail\".\"orderid\" IS NULL)");
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
RL_e5767287da79a139581b76b6fbb20753 outParamList = new RL_e5767287da79a139581b76b6fbb20753();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetOrderK012.GetOrderDetailByOrderId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_e5767287da79a139581b76b6fbb20753 _tmp = new RL_e5767287da79a139581b76b6fbb20753();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetOrderK012.GetOrderDetailByOrderId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_e5767287da79a139581b76b6fbb20753)_tmp;
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

// Query Function "GetPaymentTerms" oGSK3LeBwE6RiwzFlSZvOg of Action "GetOrderK012"
public static async Task<(RL_375b9dd8c8b0d6d7bccf4d550f48644d,long)> datasetGetPaymentTerms(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetOrderK012.GetPaymentTerms", "dc8a64a0-81b7-4ec0-918b-0cc595266f3a");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetOrderK012.GetPaymentTerms", "dc8a64a0-81b7-4ec0-918b-0cc595266f3a", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.btcKE0DynkSBdxXS_2ROXA/NodesNotShownInESpaceTree.oGSK3LeBwE6RiwzFlSZvOg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, \"enpaymentterms1\".\"ctd_dias\" o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10");
fromBuilder.Append(" FROM {PaymentTerms} \"enpaymentterms1\"");
whereBuilder.Append(" WHERE (\"enpaymentterms1\".\"description\" = 'K012')");
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
RL_375b9dd8c8b0d6d7bccf4d550f48644d outParamList = new RL_375b9dd8c8b0d6d7bccf4d550f48644d();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, true, false, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetOrderK012.GetPaymentTerms.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_375b9dd8c8b0d6d7bccf4d550f48644d _tmp = new RL_375b9dd8c8b0d6d7bccf4d550f48644d();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetOrderK012.GetPaymentTerms.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_375b9dd8c8b0d6d7bccf4d550f48644d)_tmp;
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
