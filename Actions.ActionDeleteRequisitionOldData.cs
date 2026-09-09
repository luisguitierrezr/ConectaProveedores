namespace ssConectaProveedores;

public partial class Actions {
public class lcvDeleteRequisitionOldData : VarsBag {
public long inParami_RequisitionId;
public RL_67eeb6e2fea6e1fe75fd0bc7d38796a5 queryResGetRestOfRequisitionAccConcepts_outParamList = new RL_67eeb6e2fea6e1fe75fd0bc7d38796a5();
public long queryResGetRestOfRequisitionAccConcepts_outParamCount = 0L;

public RL_67eeb6e2fea6e1fe75fd0bc7d38796a5 queryResGetRequisitionAccConceptsWithFK_outParamList = new RL_67eeb6e2fea6e1fe75fd0bc7d38796a5();
public long queryResGetRequisitionAccConceptsWithFK_outParamCount = 0L;

public RL_2895ef65cfa24878b5b55c2c334b2f76 queryResGetRequisitionFileById_outParamList = new RL_2895ef65cfa24878b5b55c2c334b2f76();
public long queryResGetRequisitionFileById_outParamCount = 0L;

public RL_7f2260a280cd6c85f68a2e5dbb44ffad queryResGetRequisitionApprovalByRequisitionId_outParamList = new RL_7f2260a280cd6c85f68a2e5dbb44ffad();
public long queryResGetRequisitionApprovalByRequisitionId_outParamCount = 0L;

public RL_991db829ff4e7fe204109f106256f023 queryResGetRequisitionAccountingByRequisitionId_outParamList = new RL_991db829ff4e7fe204109f106256f023();
public long queryResGetRequisitionAccountingByRequisitionId_outParamCount = 0L;

public lcvDeleteRequisitionOldData(long inParami_RequisitionId) {
this.inParami_RequisitionId = inParami_RequisitionId;
}
}
/// <summary>
/// Action <code>DeleteRequisitionOldData</code> that represents the Service Studio action
///  <code>DeleteRequisitionOldData</code> <p> Description: Action to delete old requisition data</p>
/// </summary>
public static async Task ActionDeleteRequisitionOldData(IRequestContext requestContext,long inParami_RequisitionId,CancellationToken cancellationToken) {
lcvDeleteRequisitionOldData localVars = new lcvDeleteRequisitionOldData(inParami_RequisitionId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("DeleteRequisitionOldData", "70285b03-a9e2-472f-8245-dc114305463c"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("DeleteRequisitionOldData", "70285b03-a9e2-472f-8245-dc114305463c", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetRequisitionApprovalByRequisitionId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequisitionApprovalByRequisitionId_maxRecords = 1;
if (datasetGetRequisitionApprovalByRequisitionId_maxRecords < 1) datasetGetRequisitionApprovalByRequisitionId_maxRecords = 1;
int datasetGetRequisitionApprovalByRequisitionId_startIndex = 0;(localVars.queryResGetRequisitionApprovalByRequisitionId_outParamList,localVars.queryResGetRequisitionApprovalByRequisitionId_outParamCount) = await FuncActionDeleteRequisitionOldData.datasetGetRequisitionApprovalByRequisitionId(requestContext,datasetGetRequisitionApprovalByRequisitionId_maxRecords,datasetGetRequisitionApprovalByRequisitionId_startIndex,IterationMultiplicity.Never,localVars.inParami_RequisitionId,cancellationToken);

if(((!localVars.queryResGetRequisitionApprovalByRequisitionId_outParamList.Empty))) {
// RequisitionApprovalDelete
await Actions.ActionRequisitionApprovalDelete(requestContext,localVars.queryResGetRequisitionApprovalByRequisitionId_outParamList.CurrentRec.ssENRequisitionApproval.ssId,cancellationToken);

}

// Query datasetGetRequisitionAccountingByRequisitionId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequisitionAccountingByRequisitionId_maxRecords = 1;
if (datasetGetRequisitionAccountingByRequisitionId_maxRecords < 1) datasetGetRequisitionAccountingByRequisitionId_maxRecords = 1;
int datasetGetRequisitionAccountingByRequisitionId_startIndex = 0;(localVars.queryResGetRequisitionAccountingByRequisitionId_outParamList,localVars.queryResGetRequisitionAccountingByRequisitionId_outParamCount) = await FuncActionDeleteRequisitionOldData.datasetGetRequisitionAccountingByRequisitionId(requestContext,datasetGetRequisitionAccountingByRequisitionId_maxRecords,datasetGetRequisitionAccountingByRequisitionId_startIndex,IterationMultiplicity.Never,localVars.inParami_RequisitionId,cancellationToken);

if(((!localVars.queryResGetRequisitionAccountingByRequisitionId_outParamList.Empty))) {
// Query datasetGetRequisitionAccConceptsWithFK
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequisitionAccConceptsWithFK_maxRecords = 0;
int datasetGetRequisitionAccConceptsWithFK_startIndex = 0;(localVars.queryResGetRequisitionAccConceptsWithFK_outParamList,localVars.queryResGetRequisitionAccConceptsWithFK_outParamCount) = await FuncActionDeleteRequisitionOldData.datasetGetRequisitionAccConceptsWithFK(requestContext,datasetGetRequisitionAccConceptsWithFK_maxRecords,datasetGetRequisitionAccConceptsWithFK_startIndex,IterationMultiplicity.Single,localVars.queryResGetRequisitionAccountingByRequisitionId_outParamList.CurrentRec.ssENRequisitionAccounting.ssId,cancellationToken);

// Foreach GetRequisitionAccConceptsWithFK.List
localVars.queryResGetRequisitionAccConceptsWithFK_outParamList.StartIteration();
try {while (!((localVars.queryResGetRequisitionAccConceptsWithFK_outParamList.Eof))) {
// RequisitionAccConceptsDelete
await Actions.ActionRequisitionAccConceptsDelete(requestContext,localVars.queryResGetRequisitionAccConceptsWithFK_outParamList.CurrentRec.ssENRequisitionAccConcepts.ssRequisitionAccConceptsId,cancellationToken);

localVars.queryResGetRequisitionAccConceptsWithFK_outParamList.Advance();
}

} finally {
localVars.queryResGetRequisitionAccConceptsWithFK_outParamList.EndIteration();
}

// Query datasetGetRestOfRequisitionAccConcepts
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRestOfRequisitionAccConcepts_maxRecords = 0;
int datasetGetRestOfRequisitionAccConcepts_startIndex = 0;(localVars.queryResGetRestOfRequisitionAccConcepts_outParamList,localVars.queryResGetRestOfRequisitionAccConcepts_outParamCount) = await FuncActionDeleteRequisitionOldData.datasetGetRestOfRequisitionAccConcepts(requestContext,datasetGetRestOfRequisitionAccConcepts_maxRecords,datasetGetRestOfRequisitionAccConcepts_startIndex,IterationMultiplicity.Single,localVars.queryResGetRequisitionAccountingByRequisitionId_outParamList.CurrentRec.ssENRequisitionAccounting.ssId,cancellationToken);

// Foreach GetRestOfRequisitionAccConcepts.List
localVars.queryResGetRestOfRequisitionAccConcepts_outParamList.StartIteration();
try {while (!((localVars.queryResGetRestOfRequisitionAccConcepts_outParamList.Eof))) {
// RequisitionAccConceptsDelete2
await Actions.ActionRequisitionAccConceptsDelete(requestContext,localVars.queryResGetRestOfRequisitionAccConcepts_outParamList.CurrentRec.ssENRequisitionAccConcepts.ssId,cancellationToken);

localVars.queryResGetRestOfRequisitionAccConcepts_outParamList.Advance();
}

} finally {
localVars.queryResGetRestOfRequisitionAccConcepts_outParamList.EndIteration();
}

// Query datasetGetRequisitionFileById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequisitionFileById_maxRecords = 1;
if (datasetGetRequisitionFileById_maxRecords < 1) datasetGetRequisitionFileById_maxRecords = 1;
int datasetGetRequisitionFileById_startIndex = 0;(localVars.queryResGetRequisitionFileById_outParamList,localVars.queryResGetRequisitionFileById_outParamCount) = await FuncActionDeleteRequisitionOldData.datasetGetRequisitionFileById(requestContext,datasetGetRequisitionFileById_maxRecords,datasetGetRequisitionFileById_startIndex,IterationMultiplicity.Never,localVars.queryResGetRequisitionAccountingByRequisitionId_outParamList.CurrentRec.ssENRequisitionAccounting.ssEvidenceFileId,cancellationToken);

if(((!localVars.queryResGetRequisitionFileById_outParamList.Empty))) {
// RequisitionFileDelete
await Actions.ActionRequisitionFileDelete(requestContext,localVars.queryResGetRequisitionFileById_outParamList.CurrentRec.ssENRequisitionFile2.ssId,cancellationToken);

}

// RequisitionAccountingDelete
await Actions.ActionRequisitionAccountingDelete(requestContext,localVars.queryResGetRequisitionAccountingByRequisitionId_outParamList.CurrentRec.ssENRequisitionAccounting.ssId,cancellationToken);

}

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionDeleteRequisitionOldData {

// Query Function "GetRestOfRequisitionAccConcepts" YtD4CreEqU2zH9AhfxYywA of Action "DeleteRequisitionOldData"
public static async Task<(RL_67eeb6e2fea6e1fe75fd0bc7d38796a5,long)> datasetGetRestOfRequisitionAccConcepts(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRequisitionAccountingId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("DeleteRequisitionOldData.GetRestOfRequisitionAccConcepts", "0af8d062-84b7-4da9-b31f-d0217f1632c0");
using var queryActivity = activitySource.CreateAggregateQueryActivity("DeleteRequisitionOldData.GetRestOfRequisitionAccConcepts", "0af8d062-84b7-4da9-b31f-d0217f1632c0", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.A1socOKpL0eCRdwRQwVGPA/NodesNotShownInESpaceTree.YtD4CreEqU2zH9AhfxYywA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enrequisitionaccconcepts1\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7");
fromBuilder.Append(" FROM {RequisitionAccConcepts} \"enrequisitionaccconcepts1\"");
whereBuilder.Append(" WHERE ");
if (qpreRequisitionAccountingId != 0) {
whereBuilder.Append("((\"enrequisitionaccconcepts1\".\"requisitionaccountingid\" = @qpreRequisitionAccountingId) AND (\"enrequisitionaccconcepts1\".\"requisitionaccountingid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisitionAccountingId", DbType.Int64, qpreRequisitionAccountingId);
} else {
whereBuilder.Append("(\"enrequisitionaccconcepts1\".\"requisitionaccountingid\" IS NULL)");
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
RL_67eeb6e2fea6e1fe75fd0bc7d38796a5 outParamList = new RL_67eeb6e2fea6e1fe75fd0bc7d38796a5();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query DeleteRequisitionOldData.GetRestOfRequisitionAccConcepts.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_67eeb6e2fea6e1fe75fd0bc7d38796a5 _tmp = new RL_67eeb6e2fea6e1fe75fd0bc7d38796a5();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query DeleteRequisitionOldData.GetRestOfRequisitionAccConcepts.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_67eeb6e2fea6e1fe75fd0bc7d38796a5)_tmp;
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

// Query Function "GetRequisitionAccConceptsWithFK" r02USUHjU0qkX6W+L1szAA of Action "DeleteRequisitionOldData"
public static async Task<(RL_67eeb6e2fea6e1fe75fd0bc7d38796a5,long)> datasetGetRequisitionAccConceptsWithFK(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRequisitionAccountingId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("DeleteRequisitionOldData.GetRequisitionAccConceptsWithFK", "49944daf-e341-4a53-a45f-a5be2f5b3300");
using var queryActivity = activitySource.CreateAggregateQueryActivity("DeleteRequisitionOldData.GetRequisitionAccConceptsWithFK", "49944daf-e341-4a53-a45f-a5be2f5b3300", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.A1socOKpL0eCRdwRQwVGPA/NodesNotShownInESpaceTree.r02USUHjU0qkX6W+L1szAA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, \"enrequisitionaccconcepts2\".\"requisitionaccconceptsid\" o6, NULL o7");
fromBuilder.Append(" FROM {RequisitionAccConcepts} \"enrequisitionaccconcepts2\"");
whereBuilder.Append(" WHERE ");
if (qpreRequisitionAccountingId != 0) {
whereBuilder.Append("((\"enrequisitionaccconcepts2\".\"requisitionaccountingid\" = @qpreRequisitionAccountingId) AND (\"enrequisitionaccconcepts2\".\"requisitionaccountingid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisitionAccountingId", DbType.Int64, qpreRequisitionAccountingId);
} else {
whereBuilder.Append("(\"enrequisitionaccconcepts2\".\"requisitionaccountingid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enrequisitionaccconcepts2\".\"requisitionaccconceptsid\" IS NOT NULL)");
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
RL_67eeb6e2fea6e1fe75fd0bc7d38796a5 outParamList = new RL_67eeb6e2fea6e1fe75fd0bc7d38796a5();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, false, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query DeleteRequisitionOldData.GetRequisitionAccConceptsWithFK.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_67eeb6e2fea6e1fe75fd0bc7d38796a5 _tmp = new RL_67eeb6e2fea6e1fe75fd0bc7d38796a5();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query DeleteRequisitionOldData.GetRequisitionAccConceptsWithFK.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_67eeb6e2fea6e1fe75fd0bc7d38796a5)_tmp;
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

// Query Function "GetRequisitionFileById" gi4dS16rKUKMxZ89l+x5zA of Action "DeleteRequisitionOldData"
public static async Task<(RL_2895ef65cfa24878b5b55c2c334b2f76,long)> datasetGetRequisitionFileById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("DeleteRequisitionOldData.GetRequisitionFileById", "4b1d2e82-ab5e-4229-8cc5-9f3d97ec79cc");
using var queryActivity = activitySource.CreateAggregateQueryActivity("DeleteRequisitionOldData.GetRequisitionFileById", "4b1d2e82-ab5e-4229-8cc5-9f3d97ec79cc", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.A1socOKpL0eCRdwRQwVGPA/NodesNotShownInESpaceTree.gi4dS16rKUKMxZ89l+x5zA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enrequisitionfile27\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7");
fromBuilder.Append(" FROM {RequisitionFile2} \"enrequisitionfile27\"");
whereBuilder.Append(" WHERE ");
if (qpreId != 0) {
whereBuilder.Append("((\"enrequisitionfile27\".\"id\" = @qpreId) AND (\"enrequisitionfile27\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreId", DbType.Int64, qpreId);
} else {
whereBuilder.Append("(\"enrequisitionfile27\".\"id\" IS NULL)");
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
RL_2895ef65cfa24878b5b55c2c334b2f76 outParamList = new RL_2895ef65cfa24878b5b55c2c334b2f76();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query DeleteRequisitionOldData.GetRequisitionFileById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_2895ef65cfa24878b5b55c2c334b2f76 _tmp = new RL_2895ef65cfa24878b5b55c2c334b2f76();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query DeleteRequisitionOldData.GetRequisitionFileById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_2895ef65cfa24878b5b55c2c334b2f76)_tmp;
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

// Query Function "GetRequisitionApprovalByRequisitionId" gSxRfMurH0KB3lcOrGISbg of Action "DeleteRequisitionOldData"
public static async Task<(RL_7f2260a280cd6c85f68a2e5dbb44ffad,long)> datasetGetRequisitionApprovalByRequisitionId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRequisitionId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("DeleteRequisitionOldData.GetRequisitionApprovalByRequisitionId", "7c512c81-abcb-421f-81de-570eac62126e");
using var queryActivity = activitySource.CreateAggregateQueryActivity("DeleteRequisitionOldData.GetRequisitionApprovalByRequisitionId", "7c512c81-abcb-421f-81de-570eac62126e", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.A1socOKpL0eCRdwRQwVGPA/NodesNotShownInESpaceTree.gSxRfMurH0KB3lcOrGISbg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enrequisitionapproval11\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9");
fromBuilder.Append(" FROM {RequisitionApproval} \"enrequisitionapproval11\"");
whereBuilder.Append(" WHERE ");
if (qpreRequisitionId != 0) {
whereBuilder.Append("((\"enrequisitionapproval11\".\"requisitionid\" = @qpreRequisitionId) AND (\"enrequisitionapproval11\".\"requisitionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisitionId", DbType.Int64, qpreRequisitionId);
} else {
whereBuilder.Append("(\"enrequisitionapproval11\".\"requisitionid\" IS NULL)");
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
RL_7f2260a280cd6c85f68a2e5dbb44ffad outParamList = new RL_7f2260a280cd6c85f68a2e5dbb44ffad();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query DeleteRequisitionOldData.GetRequisitionApprovalByRequisitionId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_7f2260a280cd6c85f68a2e5dbb44ffad _tmp = new RL_7f2260a280cd6c85f68a2e5dbb44ffad();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query DeleteRequisitionOldData.GetRequisitionApprovalByRequisitionId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_7f2260a280cd6c85f68a2e5dbb44ffad)_tmp;
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

// Query Function "GetRequisitionAccountingByRequisitionId" 3r_F6b3TpUe0XGpkkgkVyA of Action "DeleteRequisitionOldData"
public static async Task<(RL_991db829ff4e7fe204109f106256f023,long)> datasetGetRequisitionAccountingByRequisitionId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRequisitionId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("DeleteRequisitionOldData.GetRequisitionAccountingByRequisitionId", "e9c5bfde-d3bd-47a5-b45c-6a64920915c8");
using var queryActivity = activitySource.CreateAggregateQueryActivity("DeleteRequisitionOldData.GetRequisitionAccountingByRequisitionId", "e9c5bfde-d3bd-47a5-b45c-6a64920915c8", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.A1socOKpL0eCRdwRQwVGPA/NodesNotShownInESpaceTree.3r_F6b3TpUe0XGpkkgkVyA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enrequisitionaccounting2\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, \"enrequisitionaccounting2\".\"evidencefileid\" o14, NULL o15, NULL o16, NULL o17, NULL o18");
fromBuilder.Append(" FROM {RequisitionAccounting} \"enrequisitionaccounting2\"");
whereBuilder.Append(" WHERE ");
if (qpreRequisitionId != 0) {
whereBuilder.Append("((\"enrequisitionaccounting2\".\"requisitionid\" = @qpreRequisitionId) AND (\"enrequisitionaccounting2\".\"requisitionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisitionId", DbType.Int64, qpreRequisitionId);
} else {
whereBuilder.Append("(\"enrequisitionaccounting2\".\"requisitionid\" IS NULL)");
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
RL_991db829ff4e7fe204109f106256f023 outParamList = new RL_991db829ff4e7fe204109f106256f023();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query DeleteRequisitionOldData.GetRequisitionAccountingByRequisitionId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_991db829ff4e7fe204109f106256f023 _tmp = new RL_991db829ff4e7fe204109f106256f023();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query DeleteRequisitionOldData.GetRequisitionAccountingByRequisitionId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_991db829ff4e7fe204109f106256f023)_tmp;
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
