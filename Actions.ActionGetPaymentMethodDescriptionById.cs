namespace ssConectaProveedores;

public partial class Actions {
public class lcvGetPaymentMethodDescriptionById : VarsBag {
public long inParamPaymentMethodsId;
public RL_0dcbcba642ca8b22e87f690d4de9d077 queryResGetPaymentMethodById_outParamList = new RL_0dcbcba642ca8b22e87f690d4de9d077();
public long queryResGetPaymentMethodById_outParamCount = 0L;

public lcvGetPaymentMethodDescriptionById(long inParamPaymentMethodsId) {
this.inParamPaymentMethodsId = inParamPaymentMethodsId;
}
}
public class lcoGetPaymentMethodDescriptionById : VarsBag {
public string outParamDesc = "";

public lcoGetPaymentMethodDescriptionById() {
}
}
/// <summary>
/// Action <code>GetPaymentMethodDescriptionById</code> that represents the Service Studio action
///  <code>GetPaymentMethodDescriptionById</code> <p> Description: </p>
/// </summary>
public static async Task<string> ActionGetPaymentMethodDescriptionById(IRequestContext requestContext,long inParamPaymentMethodsId,CancellationToken cancellationToken) {
string outParamDesc = default;
lcoGetPaymentMethodDescriptionById result = new lcoGetPaymentMethodDescriptionById();
lcvGetPaymentMethodDescriptionById localVars = new lcvGetPaymentMethodDescriptionById(inParamPaymentMethodsId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GetPaymentMethodDescriptionById", "88122f10-a035-4d8f-a94b-5cdce94260f8"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GetPaymentMethodDescriptionById", "88122f10-a035-4d8f-a94b-5cdce94260f8", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetPaymentMethodById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetPaymentMethodById_maxRecords = 0;
int datasetGetPaymentMethodById_startIndex = 0;(localVars.queryResGetPaymentMethodById_outParamList,localVars.queryResGetPaymentMethodById_outParamCount) = await FuncActionGetPaymentMethodDescriptionById.datasetGetPaymentMethodById(requestContext,datasetGetPaymentMethodById_maxRecords,datasetGetPaymentMethodById_startIndex,IterationMultiplicity.Never,localVars.inParamPaymentMethodsId,cancellationToken);

// Desc = GetPaymentMethodById.List.Current.PaymentMethods.Description
result.outParamDesc=localVars.queryResGetPaymentMethodById_outParamList.CurrentRec.ssENPaymentMethods.ssDescription;
} //close CreateActionActivity using block
} // try

finally {
outParamDesc = result.outParamDesc;
} // inner-finally
RETURN_STATEMENT:
return outParamDesc;
}

public static class FuncActionGetPaymentMethodDescriptionById {

// Query Function "GetPaymentMethodById" VPoTc0ye_UetMZ7Lz+Hy9A of Action "GetPaymentMethodDescriptionById"
public static async Task<(RL_0dcbcba642ca8b22e87f690d4de9d077,long)> datasetGetPaymentMethodById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qppaId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetPaymentMethodDescriptionById.GetPaymentMethodById", "7313fa54-9e4c-47fd-ad31-9ecbcfe1f2f4");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetPaymentMethodDescriptionById.GetPaymentMethodById", "7313fa54-9e4c-47fd-ad31-9ecbcfe1f2f4", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.EC8SiDWgj02pS1zc6UJg+A/NodesNotShownInESpaceTree.VPoTc0ye_UetMZ7Lz+Hy9A, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enpaymentmethods4\".\"description\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8");
fromBuilder.Append(" FROM {PaymentMethods} \"enpaymentmethods4\"");
whereBuilder.Append(" WHERE ");
if (qppaId != 0) {
whereBuilder.Append("((\"enpaymentmethods4\".\"id\" = @qppaId) AND (\"enpaymentmethods4\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qppaId", DbType.Int64, qppaId);
} else {
whereBuilder.Append("(\"enpaymentmethods4\".\"id\" IS NULL)");
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
RL_0dcbcba642ca8b22e87f690d4de9d077 outParamList = new RL_0dcbcba642ca8b22e87f690d4de9d077();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetPaymentMethodDescriptionById.GetPaymentMethodById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_0dcbcba642ca8b22e87f690d4de9d077 _tmp = new RL_0dcbcba642ca8b22e87f690d4de9d077();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetPaymentMethodDescriptionById.GetPaymentMethodById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_0dcbcba642ca8b22e87f690d4de9d077)_tmp;
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
