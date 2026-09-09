namespace ssConectaProveedores;

public partial class Actions {
public class lcvHasActiveSubstitution : VarsBag {
public string inParami_UserId;
public RL_87311ea350338b4dcd53388d23fa3f86 queryResGetActiveSubstitutionsForGivenUser_outParamList = new RL_87311ea350338b4dcd53388d23fa3f86();
public long queryResGetActiveSubstitutionsForGivenUser_outParamCount = 0L;

public lcvHasActiveSubstitution(string inParami_UserId) {
this.inParami_UserId = inParami_UserId;
}
}
public class lcoHasActiveSubstitution : VarsBag {
public string outParamo_SubstituteUserId = "";

public string outParamo_IsSubstituteFor = "";

public lcoHasActiveSubstitution() {
}
}
/// <summary>
/// Action <code>HasActiveSubstitution</code> that represents the Service Studio action
///  <code>HasActiveSubstitution</code> <p> Description: </p>
/// </summary>
public static async Task<(string,string)> ActionHasActiveSubstitution(IRequestContext requestContext,string inParami_UserId,CancellationToken cancellationToken) {
string outParamo_SubstituteUserId = default;
string outParamo_IsSubstituteFor = default;
lcoHasActiveSubstitution result = new lcoHasActiveSubstitution();
lcvHasActiveSubstitution localVars = new lcvHasActiveSubstitution(inParami_UserId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("HasActiveSubstitution", "5e24c963-5f18-4b5b-ad9b-150a7fd5ec20"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("HasActiveSubstitution", "5e24c963-5f18-4b5b-ad9b-150a7fd5ec20", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetActiveSubstitutionsForGivenUser
cancellationToken.ThrowIfCancellationRequested();
int datasetGetActiveSubstitutionsForGivenUser_maxRecords = 1;
if (datasetGetActiveSubstitutionsForGivenUser_maxRecords < 1) datasetGetActiveSubstitutionsForGivenUser_maxRecords = 1;
int datasetGetActiveSubstitutionsForGivenUser_startIndex = 0;(localVars.queryResGetActiveSubstitutionsForGivenUser_outParamList,localVars.queryResGetActiveSubstitutionsForGivenUser_outParamCount) = await FuncActionHasActiveSubstitution.datasetGetActiveSubstitutionsForGivenUser(requestContext,datasetGetActiveSubstitutionsForGivenUser_maxRecords,datasetGetActiveSubstitutionsForGivenUser_startIndex,IterationMultiplicity.Never,localVars.inParami_UserId,cancellationToken);

// o_SubstituteUserId = GetActiveSubstitutionsForGivenUser.List.Current.UserApplicationRoleTemp.UserId
result.outParamo_SubstituteUserId=localVars.queryResGetActiveSubstitutionsForGivenUser_outParamList.CurrentRec.ssENUserApplicationRoleTemp.ssUserId;

// o_IsSubstituteFor = If
result.outParamo_IsSubstituteFor=(((localVars.queryResGetActiveSubstitutionsForGivenUser_outParamList.CurrentRec.ssENUserApplicationRoleTemp.ssUserId==BuiltInFunction.NullTextIdentifier ())) ? (BuiltInFunction.NullTextIdentifier ()) : (localVars.inParami_UserId));
} //close CreateActionActivity using block
} // try

finally {
outParamo_SubstituteUserId = result.outParamo_SubstituteUserId;
outParamo_IsSubstituteFor = result.outParamo_IsSubstituteFor;
} // inner-finally
RETURN_STATEMENT:
return (outParamo_SubstituteUserId,outParamo_IsSubstituteFor);
}

public static class FuncActionHasActiveSubstitution {

// Query Function "GetActiveSubstitutionsForGivenUser" n1+8ZSk5LkOEtQfSY0JxIw of Action "HasActiveSubstitution"
public static async Task<(RL_87311ea350338b4dcd53388d23fa3f86,long)> datasetGetActiveSubstitutionsForGivenUser(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusAssignedBy,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("HasActiveSubstitution.GetActiveSubstitutionsForGivenUser", "65bc5f9f-3929-432e-84b5-07d263427123");
using var queryActivity = activitySource.CreateAggregateQueryActivity("HasActiveSubstitution.GetActiveSubstitutionsForGivenUser", "65bc5f9f-3929-432e-84b5-07d263427123", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.Y8kkXhhfW0utmxUKf9XsIA/NodesNotShownInESpaceTree.n1+8ZSk5LkOEtQfSY0JxIw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enuserapplicationroletemp\".\"userid\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13");
fromBuilder.Append(" FROM {UserApplicationRoleTemp} \"enuserapplicationroletemp\"");
whereBuilder.Append(" WHERE ");
if ((qpusAssignedBy.Trim()!="")) {
whereBuilder.Append("((\"enuserapplicationroletemp\".\"assignedby\" = @qpusAssignedBy) AND (\"enuserapplicationroletemp\".\"assignedby\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusAssignedBy", DbType.String, qpusAssignedBy);
} else {
whereBuilder.Append("(\"enuserapplicationroletemp\".\"assignedby\" IS NULL)");
}
whereBuilder.Append(" AND (\"enuserapplicationroletemp\".\"rolestatusid\" = ");
whereBuilder.Append(2
);
whereBuilder.Append(")");
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
RL_87311ea350338b4dcd53388d23fa3f86 outParamList = new RL_87311ea350338b4dcd53388d23fa3f86();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query HasActiveSubstitution.GetActiveSubstitutionsForGivenUser.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_87311ea350338b4dcd53388d23fa3f86 _tmp = new RL_87311ea350338b4dcd53388d23fa3f86();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query HasActiveSubstitution.GetActiveSubstitutionsForGivenUser.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_87311ea350338b4dcd53388d23fa3f86)_tmp;
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
