namespace ssConectaProveedores;

public partial class Actions {
public class lcvGetPaymentTermSpecial : VarsBag {
public RL_375b9dd8c8b0d6d7bccf4d550f48644d queryResGetPaymentTermsSpecial_outParamList = new RL_375b9dd8c8b0d6d7bccf4d550f48644d();
public long queryResGetPaymentTermsSpecial_outParamCount = 0L;

public lcvGetPaymentTermSpecial() {
}
}
public class lcoGetPaymentTermSpecial : VarsBag {
public long outParamId = 0L;

public lcoGetPaymentTermSpecial() {
}
}
/// <summary>
/// Action <code>GetPaymentTermSpecial</code> that represents the Service Studio action
///  <code>GetPaymentTermSpecial</code> <p> Description: </p>
/// </summary>
public static async Task<long> ActionGetPaymentTermSpecial(IRequestContext requestContext,CancellationToken cancellationToken) {
long outParamId = default;
lcoGetPaymentTermSpecial result = new lcoGetPaymentTermSpecial();
lcvGetPaymentTermSpecial localVars = new lcvGetPaymentTermSpecial();
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GetPaymentTermSpecial", "a8cb243a-c2bc-4c7f-8809-22bfcaa906bf"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GetPaymentTermSpecial", "a8cb243a-c2bc-4c7f-8809-22bfcaa906bf", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetPaymentTermsSpecial
cancellationToken.ThrowIfCancellationRequested();
int datasetGetPaymentTermsSpecial_maxRecords = 1;
if (datasetGetPaymentTermsSpecial_maxRecords < 1) datasetGetPaymentTermsSpecial_maxRecords = 1;
int datasetGetPaymentTermsSpecial_startIndex = 0;(localVars.queryResGetPaymentTermsSpecial_outParamList,localVars.queryResGetPaymentTermsSpecial_outParamCount) = await FuncActionGetPaymentTermSpecial.datasetGetPaymentTermsSpecial(requestContext,datasetGetPaymentTermsSpecial_maxRecords,datasetGetPaymentTermsSpecial_startIndex,IterationMultiplicity.Never,cancellationToken);

// Id = GetPaymentTermsSpecial.List.Current.PaymentTerms.Id
result.outParamId=localVars.queryResGetPaymentTermsSpecial_outParamList.CurrentRec.ssENPaymentTerms.ssId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionGetPaymentTermSpecial {

// Query Function "GetPaymentTermsSpecial" UO9Yi+aqv060Wtec4lm_Cw of Action "GetPaymentTermSpecial"
public static async Task<(RL_375b9dd8c8b0d6d7bccf4d550f48644d,long)> datasetGetPaymentTermsSpecial(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetPaymentTermSpecial.GetPaymentTermsSpecial", "8b58ef50-aae6-4ebf-b45a-d79ce259bf0b");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetPaymentTermSpecial.GetPaymentTermsSpecial", "8b58ef50-aae6-4ebf-b45a-d79ce259bf0b", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.OiTLqLzCf0yICSK_yqkGvw/NodesNotShownInESpaceTree.UO9Yi+aqv060Wtec4lm_Cw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enpaymentterms9\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10");
fromBuilder.Append(" FROM {PaymentTerms} \"enpaymentterms9\"");
whereBuilder.Append(" WHERE (\"enpaymentterms9\".\"isspecial\" = 1)");
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
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetPaymentTermSpecial.GetPaymentTermsSpecial.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetPaymentTermSpecial.GetPaymentTermsSpecial.List", cancellationToken: cancellationToken);
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
