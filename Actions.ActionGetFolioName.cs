namespace ssConectaProveedores;

public partial class Actions {
public class lcvGetFolioName : VarsBag {
public long inParamRegionId;
public RL_321dd0d04a3c06ceeabbe51d5902cdbf queryResGetFolioRegionSeqsByRegionId_outParamList = new RL_321dd0d04a3c06ceeabbe51d5902cdbf();
public long queryResGetFolioRegionSeqsByRegionId_outParamCount = 0L;

public RC_ba02c963eabdf75d57d498152c3db2fa resGetFolioRegionSeqForUpdate_outParamRecord = new RC_ba02c963eabdf75d57d498152c3db2fa();

public RL_5d3a02aa993c7474297e33d992f39ad0 queryResGetRegionById_outParamList = new RL_5d3a02aa993c7474297e33d992f39ad0();
public long queryResGetRegionById_outParamCount = 0L;

public lcvGetFolioName(long inParamRegionId) {
this.inParamRegionId = inParamRegionId;
}
}
public class lcoGetFolioName : VarsBag {
public string outParamFolioNumber = "";

public lcoGetFolioName() {
}
}
/// <summary>
/// Action <code>GetFolioName</code> that represents the Service Studio action
///  <code>GetFolioName</code> <p> Description: </p>
/// </summary>
public static async Task<string> ActionGetFolioName(IRequestContext requestContext,long inParamRegionId,CancellationToken cancellationToken) {
string outParamFolioNumber = default;
lcoGetFolioName result = new lcoGetFolioName();
lcvGetFolioName localVars = new lcvGetFolioName(inParamRegionId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GetFolioName", "6bc58a16-25c7-41cb-97e8-c281802e1f09"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GetFolioName", "6bc58a16-25c7-41cb-97e8-c281802e1f09", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetRegionById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRegionById_maxRecords = 0;
int datasetGetRegionById_startIndex = 0;(localVars.queryResGetRegionById_outParamList,localVars.queryResGetRegionById_outParamCount) = await FuncActionGetFolioName.datasetGetRegionById(requestContext,datasetGetRegionById_maxRecords,datasetGetRegionById_startIndex,IterationMultiplicity.Never,localVars.inParamRegionId,cancellationToken);

if((localVars.queryResGetRegionById_outParamList.Empty)) {
// RaiseError EntityException
throw new Ex_EntityExceptionUserException (AppUtils.GetStringResource("+4Gmv58DsEabAcJnIpJNxw#Message.-2037628249.1", "No region defined for this order"));

} else {
// Query datasetGetFolioRegionSeqsByRegionId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioRegionSeqsByRegionId_maxRecords = 0;
int datasetGetFolioRegionSeqsByRegionId_startIndex = 0;(localVars.queryResGetFolioRegionSeqsByRegionId_outParamList,localVars.queryResGetFolioRegionSeqsByRegionId_outParamCount) = await FuncActionGetFolioName.datasetGetFolioRegionSeqsByRegionId(requestContext,datasetGetFolioRegionSeqsByRegionId_maxRecords,datasetGetFolioRegionSeqsByRegionId_startIndex,IterationMultiplicity.Never,localVars.inParamRegionId,cancellationToken);

// GetFolioRegionSeqForUpdate
localVars.resGetFolioRegionSeqForUpdate_outParamRecord = await ExtendedActions.GetFolioRegionSeqForUpdate(requestContext,localVars.queryResGetFolioRegionSeqsByRegionId_outParamList.CurrentRec.ssENFolioRegionSeq.ssId,cancellationToken);

// FolioNumber = "SAEC" + Substr + Substr + FormatText
result.outParamFolioNumber=((("SAEC"+BuiltInFunction.SubstrSC (Convert.ToString(BuiltInFunction.Year (BuiltInFunction.CurrDate ())), 2, 3))+BuiltInFunction.SubstrSC (localVars.queryResGetRegionById_outParamList.CurrentRec.ssENRegion.ssCode, 2, 2))+BuiltInFunction.FormatTextSC (Convert.ToString(localVars.resGetFolioRegionSeqForUpdate_outParamRecord.ssENFolioRegionSeq.ssSeqValue), 5, 5, true, "0"));
// SetNextValue
// GetFolioRegionSeqForUpdate.Record.FolioRegionSeq.SeqValue = GetFolioRegionSeqForUpdate.Record.FolioRegionSeq.SeqValue + 1
localVars.resGetFolioRegionSeqForUpdate_outParamRecord.ssENFolioRegionSeq.ssSeqValue = (localVars.resGetFolioRegionSeqForUpdate_outParamRecord.ssENFolioRegionSeq.ssSeqValue+1);
// UpdateFolioRegionSeq
await ExtendedActions.UpdateFolioRegionSeq(requestContext,localVars.resGetFolioRegionSeqForUpdate_outParamRecord.ChangedAttributes,localVars.resGetFolioRegionSeqForUpdate_outParamRecord,cancellationToken);

}

} //close CreateActionActivity using block
} // try

finally {
outParamFolioNumber = result.outParamFolioNumber;
} // inner-finally
RETURN_STATEMENT:
return outParamFolioNumber;
}

public static class FuncActionGetFolioName {

// Query Function "GetFolioRegionSeqsByRegionId" GW88BpdrAkq3MDhsGqngCg of Action "GetFolioName"
public static async Task<(RL_321dd0d04a3c06ceeabbe51d5902cdbf,long)> datasetGetFolioRegionSeqsByRegionId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRegionId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetFolioName.GetFolioRegionSeqsByRegionId", "063c6f19-6b97-4a02-b730-386c1aa9e00a");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetFolioName.GetFolioRegionSeqsByRegionId", "063c6f19-6b97-4a02-b730-386c1aa9e00a", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.ForFa8cly0GX6MKBgC4fCQ/NodesNotShownInESpaceTree.GW88BpdrAkq3MDhsGqngCg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enfolioregionseq1\".\"id\" o0, NULL o1, NULL o2");
fromBuilder.Append(" FROM {FolioRegionSeq} \"enfolioregionseq1\"");
whereBuilder.Append(" WHERE ");
if (qpreRegionId != 0) {
whereBuilder.Append("((\"enfolioregionseq1\".\"regionid\" = @qpreRegionId) AND (\"enfolioregionseq1\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRegionId", DbType.Int64, qpreRegionId);
} else {
whereBuilder.Append("(\"enfolioregionseq1\".\"regionid\" IS NULL)");
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
RL_321dd0d04a3c06ceeabbe51d5902cdbf outParamList = new RL_321dd0d04a3c06ceeabbe51d5902cdbf();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetFolioName.GetFolioRegionSeqsByRegionId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_321dd0d04a3c06ceeabbe51d5902cdbf _tmp = new RL_321dd0d04a3c06ceeabbe51d5902cdbf();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetFolioName.GetFolioRegionSeqsByRegionId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_321dd0d04a3c06ceeabbe51d5902cdbf)_tmp;
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

// Query Function "GetRegionById" 97jq_e3axkysqCvrCL3zJQ of Action "GetFolioName"
public static async Task<(RL_5d3a02aa993c7474297e33d992f39ad0,long)> datasetGetRegionById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetFolioName.GetRegionById", "fdeab8f7-daed-4cc6-aca8-2beb08bdf325");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetFolioName.GetRegionById", "fdeab8f7-daed-4cc6-aca8-2beb08bdf325", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.ForFa8cly0GX6MKBgC4fCQ/NodesNotShownInESpaceTree.97jq_e3axkysqCvrCL3zJQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enregion28\".\"code\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12");
fromBuilder.Append(" FROM {Region} \"enregion28\"");
whereBuilder.Append(" WHERE ");
if (qpreId != 0) {
whereBuilder.Append("((\"enregion28\".\"id\" = @qpreId) AND (\"enregion28\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreId", DbType.Int64, qpreId);
} else {
whereBuilder.Append("(\"enregion28\".\"id\" IS NULL)");
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
RL_5d3a02aa993c7474297e33d992f39ad0 outParamList = new RL_5d3a02aa993c7474297e33d992f39ad0();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetFolioName.GetRegionById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_5d3a02aa993c7474297e33d992f39ad0 _tmp = new RL_5d3a02aa993c7474297e33d992f39ad0();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetFolioName.GetRegionById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_5d3a02aa993c7474297e33d992f39ad0)_tmp;
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
