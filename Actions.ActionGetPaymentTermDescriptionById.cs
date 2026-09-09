namespace ssConectaProveedores;

public partial class Actions {
public class lcvGetPaymentTermDescriptionById : VarsBag {
public long inParamPaymentTermsId;
public RL_375b9dd8c8b0d6d7bccf4d550f48644d queryResGetPaymentTermById_outParamList = new RL_375b9dd8c8b0d6d7bccf4d550f48644d();
public long queryResGetPaymentTermById_outParamCount = 0L;

public lcvGetPaymentTermDescriptionById(long inParamPaymentTermsId) {
this.inParamPaymentTermsId = inParamPaymentTermsId;
}
}
public class lcoGetPaymentTermDescriptionById : VarsBag {
public string outParamDesc = "";

public lcoGetPaymentTermDescriptionById() {
}
}
/// <summary>
/// Action <code>GetPaymentTermDescriptionById</code> that represents the Service Studio action
///  <code>GetPaymentTermDescriptionById</code> <p> Description: </p>
/// </summary>
public static async Task<string> ActionGetPaymentTermDescriptionById(IRequestContext requestContext,long inParamPaymentTermsId,CancellationToken cancellationToken) {
string outParamDesc = default;
lcoGetPaymentTermDescriptionById result = new lcoGetPaymentTermDescriptionById();
lcvGetPaymentTermDescriptionById localVars = new lcvGetPaymentTermDescriptionById(inParamPaymentTermsId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GetPaymentTermDescriptionById", "a828f986-00bc-4787-8635-9724622cff93"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GetPaymentTermDescriptionById", "a828f986-00bc-4787-8635-9724622cff93", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetPaymentTermById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetPaymentTermById_maxRecords = 0;
int datasetGetPaymentTermById_startIndex = 0;(localVars.queryResGetPaymentTermById_outParamList,localVars.queryResGetPaymentTermById_outParamCount) = await FuncActionGetPaymentTermDescriptionById.datasetGetPaymentTermById(requestContext,datasetGetPaymentTermById_maxRecords,datasetGetPaymentTermById_startIndex,IterationMultiplicity.Never,localVars.inParamPaymentTermsId,cancellationToken);

// Desc = GetPaymentTermById.List.Current.PaymentTerms.Description
result.outParamDesc=localVars.queryResGetPaymentTermById_outParamList.CurrentRec.ssENPaymentTerms.ssDescription;
} //close CreateActionActivity using block
} // try

finally {
outParamDesc = result.outParamDesc;
} // inner-finally
RETURN_STATEMENT:
return outParamDesc;
}

public static class FuncActionGetPaymentTermDescriptionById {

// Query Function "GetPaymentTermById" 0UXMZ0oqKE2nlslRdl6Igw of Action "GetPaymentTermDescriptionById"
public static async Task<(RL_375b9dd8c8b0d6d7bccf4d550f48644d,long)> datasetGetPaymentTermById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qppaId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetPaymentTermDescriptionById.GetPaymentTermById", "67cc45d1-2a4a-4d28-a796-c951765e8883");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetPaymentTermDescriptionById.GetPaymentTermById", "67cc45d1-2a4a-4d28-a796-c951765e8883", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.hvkoqLwAh0eGNZckYiz_kw/NodesNotShownInESpaceTree.0UXMZ0oqKE2nlslRdl6Igw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enpaymentterms8\".\"description\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10");
fromBuilder.Append(" FROM {PaymentTerms} \"enpaymentterms8\"");
whereBuilder.Append(" WHERE ");
if (qppaId != 0) {
whereBuilder.Append("((\"enpaymentterms8\".\"id\" = @qppaId) AND (\"enpaymentterms8\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qppaId", DbType.Int64, qppaId);
} else {
whereBuilder.Append("(\"enpaymentterms8\".\"id\" IS NULL)");
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
RL_375b9dd8c8b0d6d7bccf4d550f48644d outParamList = new RL_375b9dd8c8b0d6d7bccf4d550f48644d();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetPaymentTermDescriptionById.GetPaymentTermById.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetPaymentTermDescriptionById.GetPaymentTermById.List", cancellationToken: cancellationToken);
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
