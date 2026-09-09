namespace ssConectaProveedores;

public partial class Actions {
public class lcvValidateSupplier : VarsBag {
public string inParami_SupplierNumber;
public RL_d5c1b2482ff109e80580d8b5fb920193 queryResGetSuppliersByNumber_outParamList = new RL_d5c1b2482ff109e80580d8b5fb920193();
public long queryResGetSuppliersByNumber_outParamCount = 0L;

public lcvValidateSupplier(string inParami_SupplierNumber) {
this.inParami_SupplierNumber = inParami_SupplierNumber;
}
}
public class lcoValidateSupplier : VarsBag {
public bool outParamo_IsValid = true;

public lcoValidateSupplier() {
}
}
/// <summary>
/// Action <code>ValidateSupplier</code> that represents the Service Studio action
///  <code>ValidateSupplier</code> <p> Description: </p>
/// </summary>
public static async Task<bool> ActionValidateSupplier(IRequestContext requestContext,string inParami_SupplierNumber,CancellationToken cancellationToken) {
bool outParamo_IsValid = default;
lcoValidateSupplier result = new lcoValidateSupplier();
lcvValidateSupplier localVars = new lcvValidateSupplier(inParami_SupplierNumber);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("ValidateSupplier", "e1d8f4f4-f15e-46dd-9413-1b8bf42db763"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("ValidateSupplier", "e1d8f4f4-f15e-46dd-9413-1b8bf42db763", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetSuppliersByNumber
cancellationToken.ThrowIfCancellationRequested();
int datasetGetSuppliersByNumber_maxRecords = 1;
if (datasetGetSuppliersByNumber_maxRecords < 1) datasetGetSuppliersByNumber_maxRecords = 1;
int datasetGetSuppliersByNumber_startIndex = 0;(localVars.queryResGetSuppliersByNumber_outParamList,localVars.queryResGetSuppliersByNumber_outParamCount) = await FuncActionValidateSupplier.datasetGetSuppliersByNumber(requestContext,datasetGetSuppliersByNumber_maxRecords,datasetGetSuppliersByNumber_startIndex,IterationMultiplicity.Never,localVars.inParami_SupplierNumber,cancellationToken);

// o_IsValid = notGetSuppliersByNumber.List.Empty
result.outParamo_IsValid=(!localVars.queryResGetSuppliersByNumber_outParamList.Empty);
} //close CreateActionActivity using block
} // try

finally {
outParamo_IsValid = result.outParamo_IsValid;
} // inner-finally
RETURN_STATEMENT:
return outParamo_IsValid;
}

public static class FuncActionValidateSupplier {

// Query Function "GetSuppliersByNumber" kH_XUZXHc0GeQRDmvn++cw of Action "ValidateSupplier"
public static async Task<(RL_d5c1b2482ff109e80580d8b5fb920193,long)> datasetGetSuppliersByNumber(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteNumber,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ValidateSupplier.GetSuppliersByNumber", "51d77f90-c795-4173-9e41-10e6be7fbe73");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ValidateSupplier.GetSuppliersByNumber", "51d77f90-c795-4173-9e41-10e6be7fbe73", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.9PTY4V7x3UaUExuL9C23Yw/NodesNotShownInESpaceTree.kH_XUZXHc0GeQRDmvn++cw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27");
fromBuilder.Append(" FROM {Supplier} \"ensupplier45\"");
whereBuilder.Append(" WHERE (\"ensupplier45\".\"number\" = (trim(@qpteNumber)))");
sqlCmd.CreateParameterWithoutReplacements("@qpteNumber", DbType.String, qpteNumber);
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
RL_d5c1b2482ff109e80580d8b5fb920193 outParamList = new RL_d5c1b2482ff109e80580d8b5fb920193();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ValidateSupplier.GetSuppliersByNumber.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_d5c1b2482ff109e80580d8b5fb920193 _tmp = new RL_d5c1b2482ff109e80580d8b5fb920193();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ValidateSupplier.GetSuppliersByNumber.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_d5c1b2482ff109e80580d8b5fb920193)_tmp;
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
