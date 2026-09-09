namespace ssConectaProveedores;

public partial class Actions {
public class lcvCheckUser : VarsBag {
public string inParami_UserEmail;
public RL_8430333e95ceffc00def96d8abb01f75 queryResGetUsersByEmail_outParamList = new RL_8430333e95ceffc00def96d8abb01f75();
public long queryResGetUsersByEmail_outParamCount = 0L;

public lcvCheckUser(string inParami_UserEmail) {
this.inParami_UserEmail = inParami_UserEmail;
}
}
public class lcoCheckUser : VarsBag {
public string outParamo_Role = "";

public bool outParamo_Success = false;

public string outParamo_UserId = "";

public lcoCheckUser() {
}
}
/// <summary>
/// Action <code>CheckUser</code> that represents the Service Studio action <code>CheckUser</code> <p>
///  Description: This action verifies at login if the user email exists.</p>
/// </summary>
public static async Task<(string,bool,string)> ActionCheckUser(IRequestContext requestContext,string inParami_UserEmail,CancellationToken cancellationToken) {
string outParamo_Role = default;
bool outParamo_Success = default;
string outParamo_UserId = default;
lcoCheckUser result = new lcoCheckUser();
lcvCheckUser localVars = new lcvCheckUser(inParami_UserEmail);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("CheckUser", "ca7111a4-e52a-419d-b6d7-9bbc92df3ada"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("CheckUser", "ca7111a4-e52a-419d-b6d7-9bbc92df3ada", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetUsersByEmail
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUsersByEmail_maxRecords = 0;
int datasetGetUsersByEmail_startIndex = 0;(localVars.queryResGetUsersByEmail_outParamList,localVars.queryResGetUsersByEmail_outParamCount) = await FuncActionCheckUser.datasetGetUsersByEmail(requestContext,datasetGetUsersByEmail_maxRecords,datasetGetUsersByEmail_startIndex,IterationMultiplicity.Never,localVars.inParami_UserEmail,cancellationToken);

// Email Found?
if((localVars.queryResGetUsersByEmail_outParamList.Empty)) {
// Set Success False
// o_Success = False
result.outParamo_Success=false;
} else {
// Set Success True
// o_Success = True
result.outParamo_Success=true;

// o_UserId = GetUsersByEmail.List.Current.User.Id
result.outParamo_UserId=localVars.queryResGetUsersByEmail_outParamList.CurrentRec.ssENUser.ssId;
}

} //close CreateActionActivity using block
} // try

finally {
outParamo_Role = result.outParamo_Role;
outParamo_Success = result.outParamo_Success;
outParamo_UserId = result.outParamo_UserId;
} // inner-finally
RETURN_STATEMENT:
return (outParamo_Role,outParamo_Success,outParamo_UserId);
}

public static class FuncActionCheckUser {

// Query Function "GetUsersByEmail" k1c2c36NJkqDtURoKP6inQ of Action "CheckUser"
public static async Task<(RL_8430333e95ceffc00def96d8abb01f75,long)> datasetGetUsersByEmail(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteEmail,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("CheckUser.GetUsersByEmail", "73365793-8d7e-4a26-83b5-446828fea29d");
using var queryActivity = activitySource.CreateAggregateQueryActivity("CheckUser.GetUsersByEmail", "73365793-8d7e-4a26-83b5-446828fea29d", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.pBFxyirlnUG215u8kt862g/NodesNotShownInESpaceTree.k1c2c36NJkqDtURoKP6inQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enuser112\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4");
fromBuilder.Append(" FROM {User} \"enuser112\"");
whereBuilder.Append(" WHERE (\"enuser112\".\"email\" = @qpteEmail)");
sqlCmd.CreateParameterWithoutReplacements("@qpteEmail", DbType.String, qpteEmail);
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
RL_8430333e95ceffc00def96d8abb01f75 outParamList = new RL_8430333e95ceffc00def96d8abb01f75();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query CheckUser.GetUsersByEmail.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_8430333e95ceffc00def96d8abb01f75 _tmp = new RL_8430333e95ceffc00def96d8abb01f75();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query CheckUser.GetUsersByEmail.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_8430333e95ceffc00def96d8abb01f75)_tmp;
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
