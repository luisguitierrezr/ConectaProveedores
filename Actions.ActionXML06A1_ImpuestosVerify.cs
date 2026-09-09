namespace ssConectaProveedores;

public partial class Actions {
public class lcvXML06A1_ImpuestosVerify : VarsBag {
public string inParamValue;
public Actions.lcoLogsAccountingCreate resLogsXMLValidationCreate12 =  new Actions.lcoLogsAccountingCreate();
public RL_bf188616de0f0f2f6ca06ba5dba27490 queryResGetTaxIndicatorsByValue_outParamList = new RL_bf188616de0f0f2f6ca06ba5dba27490();
public long queryResGetTaxIndicatorsByValue_outParamCount = 0L;

public lcvXML06A1_ImpuestosVerify(string inParamValue) {
this.inParamValue = inParamValue;
}
}
public class lcoXML06A1_ImpuestosVerify : VarsBag {
public string outParamErrorMsg = "";

public lcoXML06A1_ImpuestosVerify() {
}
}
/// <summary>
/// Action <code>XML06A1_ImpuestosVerify</code> that represents the Service Studio action
///  <code>XML06A1_ImpuestosVerify</code> <p> Description: </p>
/// </summary>
public static async Task<string> ActionXML06A1_ImpuestosVerify(IRequestContext requestContext,string inParamValue,CancellationToken cancellationToken) {
string outParamErrorMsg = default;
lcoXML06A1_ImpuestosVerify result = new lcoXML06A1_ImpuestosVerify();
lcvXML06A1_ImpuestosVerify localVars = new lcvXML06A1_ImpuestosVerify(inParamValue);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("XML06A1_ImpuestosVerify", "ad846893-2cf3-4c96-8ce3-075e91edc76e"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("XML06A1_ImpuestosVerify", "ad846893-2cf3-4c96-8ce3-075e91edc76e", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetTaxIndicatorsByValue
cancellationToken.ThrowIfCancellationRequested();
int datasetGetTaxIndicatorsByValue_maxRecords = 0;
int datasetGetTaxIndicatorsByValue_startIndex = 0;(localVars.queryResGetTaxIndicatorsByValue_outParamList,localVars.queryResGetTaxIndicatorsByValue_outParamCount) = await FuncActionXML06A1_ImpuestosVerify.datasetGetTaxIndicatorsByValue(requestContext,datasetGetTaxIndicatorsByValue_maxRecords,datasetGetTaxIndicatorsByValue_startIndex,IterationMultiplicity.Never,cancellationToken);

// error?
if((localVars.queryResGetTaxIndicatorsByValue_outParamList.Empty)) {
// ErrorMsg = "Error in Tax field"
result.outParamErrorMsg=AppUtils.GetStringResource("nYhP13402EyEq1BwHqsfug#Value.1805579810.1", "Error in Tax field");
// Value = Value
localVars.inParamValue=localVars.inParamValue;
// LogsXMLValidationCreate12
localVars.resLogsXMLValidationCreate12.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = "Error in Tax field", ssDescription = (("Indicator"+localVars.inParamValue)+" inexistent in table TaxIndicators"), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("DeuxnejeQkCHc_yHj_40kQ"))).ssId },cancellationToken);

}

} //close CreateActionActivity using block
} // try

finally {
outParamErrorMsg = result.outParamErrorMsg;
} // inner-finally
RETURN_STATEMENT:
return outParamErrorMsg;
}

public static class FuncActionXML06A1_ImpuestosVerify {

// Query Function "GetTaxIndicatorsByValue" 8DZ3zOjbRUumFMWO9sIdIA of Action "XML06A1_ImpuestosVerify"
public static async Task<(RL_bf188616de0f0f2f6ca06ba5dba27490,long)> datasetGetTaxIndicatorsByValue(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("XML06A1_ImpuestosVerify.GetTaxIndicatorsByValue", "cc7736f0-dbe8-4b45-a614-c58ef6c21d20");
using var queryActivity = activitySource.CreateAggregateQueryActivity("XML06A1_ImpuestosVerify.GetTaxIndicatorsByValue", "cc7736f0-dbe8-4b45-a614-c58ef6c21d20", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.k2iErfMslkyM4wdeke3Hbg/NodesNotShownInESpaceTree.8DZ3zOjbRUumFMWO9sIdIA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6");
fromBuilder.Append(" FROM {TaxIndicator} \"entaxindicator4\"");
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
RL_bf188616de0f0f2f6ca06ba5dba27490 outParamList = new RL_bf188616de0f0f2f6ca06ba5dba27490();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query XML06A1_ImpuestosVerify.GetTaxIndicatorsByValue.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_bf188616de0f0f2f6ca06ba5dba27490 _tmp = new RL_bf188616de0f0f2f6ca06ba5dba27490();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query XML06A1_ImpuestosVerify.GetTaxIndicatorsByValue.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_bf188616de0f0f2f6ca06ba5dba27490)_tmp;
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
