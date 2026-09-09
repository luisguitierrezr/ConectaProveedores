namespace ssConectaProveedores;

public partial class Actions {
public class lcvInvoiceGetIVACodeByTaxSupplierExcep : VarsBag {
public string inParamSupplierNumber;
public RL_13bf94cd07d1032d5b0048443a2062e5 queryResGetIVAExceptionM9SuppliersBySupplierNumber_outParamList = new RL_13bf94cd07d1032d5b0048443a2062e5();
public long queryResGetIVAExceptionM9SuppliersBySupplierNumber_outParamCount = 0L;

public lcvInvoiceGetIVACodeByTaxSupplierExcep(string inParamSupplierNumber) {
this.inParamSupplierNumber = inParamSupplierNumber;
}
}
public class lcoInvoiceGetIVACodeByTaxSupplierExcep : VarsBag {
public bool outParamIsM9 = false;

public lcoInvoiceGetIVACodeByTaxSupplierExcep() {
}
}
/// <summary>
/// Action <code>InvoiceGetIVACodeByTaxSupplierExcep</code> that represents the Service Studio action
///  <code>InvoiceGetIVACodeByTaxSupplierExcep</code> <p> Description: </p>
/// </summary>
public static async Task<bool> ActionInvoiceGetIVACodeByTaxSupplierExcep(IRequestContext requestContext,string inParamSupplierNumber,CancellationToken cancellationToken) {
bool outParamIsM9 = default;
lcoInvoiceGetIVACodeByTaxSupplierExcep result = new lcoInvoiceGetIVACodeByTaxSupplierExcep();
lcvInvoiceGetIVACodeByTaxSupplierExcep localVars = new lcvInvoiceGetIVACodeByTaxSupplierExcep(inParamSupplierNumber);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("InvoiceGetIVACodeByTaxSupplierExcep", "448757e0-541b-455a-ab38-81f063f83782"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("InvoiceGetIVACodeByTaxSupplierExcep", "448757e0-541b-455a-ab38-81f063f83782", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetIVAExceptionM9SuppliersBySupplierNumber
cancellationToken.ThrowIfCancellationRequested();
int datasetGetIVAExceptionM9SuppliersBySupplierNumber_maxRecords = 0;
int datasetGetIVAExceptionM9SuppliersBySupplierNumber_startIndex = 0;(localVars.queryResGetIVAExceptionM9SuppliersBySupplierNumber_outParamList,localVars.queryResGetIVAExceptionM9SuppliersBySupplierNumber_outParamCount) = await FuncActionInvoiceGetIVACodeByTaxSupplierExcep.datasetGetIVAExceptionM9SuppliersBySupplierNumber(requestContext,datasetGetIVAExceptionM9SuppliersBySupplierNumber_maxRecords,datasetGetIVAExceptionM9SuppliersBySupplierNumber_startIndex,IterationMultiplicity.Never,localVars.inParamSupplierNumber,cancellationToken);

// IsM9 = notGetIVAExceptionM9SuppliersBySupplierNumber.List.Empty
result.outParamIsM9=(!localVars.queryResGetIVAExceptionM9SuppliersBySupplierNumber_outParamList.Empty);
} //close CreateActionActivity using block
} // try

finally {
outParamIsM9 = result.outParamIsM9;
} // inner-finally
RETURN_STATEMENT:
return outParamIsM9;
}

public static class FuncActionInvoiceGetIVACodeByTaxSupplierExcep {

// Query Function "GetIVAExceptionM9SuppliersBySupplierNumber" EivzQNFbZUqKTJkb5TfnjA of Action "InvoiceGetIVACodeByTaxSupplierExcep"
public static async Task<(RL_13bf94cd07d1032d5b0048443a2062e5,long)> datasetGetIVAExceptionM9SuppliersBySupplierNumber(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteSupplierNumber,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InvoiceGetIVACodeByTaxSupplierExcep.GetIVAExceptionM9SuppliersBySupplierNumber", "40f32b12-5bd1-4a65-8a4c-991be537e78c");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InvoiceGetIVACodeByTaxSupplierExcep.GetIVAExceptionM9SuppliersBySupplierNumber", "40f32b12-5bd1-4a65-8a4c-991be537e78c", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.4FeHRBtUWkWrOIHwY_g3gg/NodesNotShownInESpaceTree.EivzQNFbZUqKTJkb5TfnjA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5");
fromBuilder.Append(" FROM {IVAExceptionM9Suppliers} \"enivaexceptionm9suppliers\"");
whereBuilder.Append(" WHERE (cast(\"enivaexceptionm9suppliers\".\"suppliernumber\" as text) = @qpteSupplierNumber)");
sqlCmd.CreateParameterWithoutReplacements("@qpteSupplierNumber", DbType.String, qpteSupplierNumber);
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
RL_13bf94cd07d1032d5b0048443a2062e5 outParamList = new RL_13bf94cd07d1032d5b0048443a2062e5();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InvoiceGetIVACodeByTaxSupplierExcep.GetIVAExceptionM9SuppliersBySupplierNumber.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_13bf94cd07d1032d5b0048443a2062e5 _tmp = new RL_13bf94cd07d1032d5b0048443a2062e5();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InvoiceGetIVACodeByTaxSupplierExcep.GetIVAExceptionM9SuppliersBySupplierNumber.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_13bf94cd07d1032d5b0048443a2062e5)_tmp;
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
