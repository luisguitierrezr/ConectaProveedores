namespace ssConectaProveedores;

public partial class Actions {
public class lcvGetCodeByTaxId : VarsBag {
public long inParamTaxIndicatorId;
public RL_bf188616de0f0f2f6ca06ba5dba27490 queryResGetTaxIndicatorById_outParamList = new RL_bf188616de0f0f2f6ca06ba5dba27490();
public long queryResGetTaxIndicatorById_outParamCount = 0L;

public lcvGetCodeByTaxId(long inParamTaxIndicatorId) {
this.inParamTaxIndicatorId = inParamTaxIndicatorId;
}
}
public class lcoGetCodeByTaxId : VarsBag {
public string outParamCode = "";

public lcoGetCodeByTaxId() {
}
}
/// <summary>
/// Action <code>GetCodeByTaxId</code> that represents the Service Studio action
///  <code>GetCodeByTaxId</code> <p> Description: </p>
/// </summary>
public static async Task<string> ActionGetCodeByTaxId(IRequestContext requestContext,long inParamTaxIndicatorId,CancellationToken cancellationToken) {
string outParamCode = default;
lcoGetCodeByTaxId result = new lcoGetCodeByTaxId();
lcvGetCodeByTaxId localVars = new lcvGetCodeByTaxId(inParamTaxIndicatorId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GetCodeByTaxId", "0583140c-6817-475d-b144-53dea3b43888"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GetCodeByTaxId", "0583140c-6817-475d-b144-53dea3b43888", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetTaxIndicatorById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetTaxIndicatorById_maxRecords = 0;
int datasetGetTaxIndicatorById_startIndex = 0;(localVars.queryResGetTaxIndicatorById_outParamList,localVars.queryResGetTaxIndicatorById_outParamCount) = await FuncActionGetCodeByTaxId.datasetGetTaxIndicatorById(requestContext,datasetGetTaxIndicatorById_maxRecords,datasetGetTaxIndicatorById_startIndex,IterationMultiplicity.Never,localVars.inParamTaxIndicatorId,cancellationToken);

// Code = GetTaxIndicatorById.List.Current.TaxIndicator.ExternalId
result.outParamCode=localVars.queryResGetTaxIndicatorById_outParamList.CurrentRec.ssENTaxIndicator.ssExternalId;
} //close CreateActionActivity using block
} // try

finally {
outParamCode = result.outParamCode;
} // inner-finally
RETURN_STATEMENT:
return outParamCode;
}

public static class FuncActionGetCodeByTaxId {

// Query Function "GetTaxIndicatorById" sQhZBCHtwkCaC8eTCPfDrA of Action "GetCodeByTaxId"
public static async Task<(RL_bf188616de0f0f2f6ca06ba5dba27490,long)> datasetGetTaxIndicatorById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qptaId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetCodeByTaxId.GetTaxIndicatorById", "045908b1-ed21-40c2-9a0b-c79308f7c3ac");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetCodeByTaxId.GetTaxIndicatorById", "045908b1-ed21-40c2-9a0b-c79308f7c3ac", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.DBSDBRdoXUexRFPeo7Q4iA/NodesNotShownInESpaceTree.sQhZBCHtwkCaC8eTCPfDrA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, \"entaxindicator\".\"externalid\" o2, NULL o3, NULL o4, NULL o5, NULL o6");
fromBuilder.Append(" FROM {TaxIndicator} \"entaxindicator\"");
whereBuilder.Append(" WHERE ");
if (qptaId != 0) {
whereBuilder.Append("((\"entaxindicator\".\"id\" = @qptaId) AND (\"entaxindicator\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qptaId", DbType.Int64, qptaId);
} else {
whereBuilder.Append("(\"entaxindicator\".\"id\" IS NULL)");
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
RL_bf188616de0f0f2f6ca06ba5dba27490 outParamList = new RL_bf188616de0f0f2f6ca06ba5dba27490();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, false, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetCodeByTaxId.GetTaxIndicatorById.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetCodeByTaxId.GetTaxIndicatorById.List", cancellationToken: cancellationToken);
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
