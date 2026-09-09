namespace ssConectaProveedores;

public partial class Actions {
public class lcvShowIsDonationSwitch : VarsBag {
public RL_8dbe9b3349c28479d314d27fe2f03197 queryResGetApprovalProcess_outParamList = new RL_8dbe9b3349c28479d314d27fe2f03197();
public long queryResGetApprovalProcess_outParamCount = 0L;

public RL_752c66ffcb633a1081093541635464e7 queryResGetUserExtendedInternalJobTitle_outParamList = new RL_752c66ffcb633a1081093541635464e7();
public long queryResGetUserExtendedInternalJobTitle_outParamCount = 0L;

public lcvShowIsDonationSwitch() {
}
}
public class lcoShowIsDonationSwitch : VarsBag {
public bool outParamo_ShowSwitch = false;

public lcoShowIsDonationSwitch() {
}
}
/// <summary>
/// Action <code>ShowIsDonationSwitch</code> that represents the Service Studio action
///  <code>ShowIsDonationSwitch</code> <p> Description: </p>
/// </summary>
public static async Task<bool> ActionShowIsDonationSwitch(IRequestContext requestContext,CancellationToken cancellationToken) {
bool outParamo_ShowSwitch = default;
lcoShowIsDonationSwitch result = new lcoShowIsDonationSwitch();
lcvShowIsDonationSwitch localVars = new lcvShowIsDonationSwitch();
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("ShowIsDonationSwitch", "c36858f5-23d8-4987-a413-53a6f0f0fad8"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("ShowIsDonationSwitch", "c36858f5-23d8-4987-a413-53a6f0f0fad8", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetUserExtendedInternalJobTitle
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserExtendedInternalJobTitle_maxRecords = 1;
if (datasetGetUserExtendedInternalJobTitle_maxRecords < 1) datasetGetUserExtendedInternalJobTitle_maxRecords = 1;
int datasetGetUserExtendedInternalJobTitle_startIndex = 0;(localVars.queryResGetUserExtendedInternalJobTitle_outParamList,localVars.queryResGetUserExtendedInternalJobTitle_outParamCount) = await FuncActionShowIsDonationSwitch.datasetGetUserExtendedInternalJobTitle(requestContext,datasetGetUserExtendedInternalJobTitle_maxRecords,datasetGetUserExtendedInternalJobTitle_startIndex,IterationMultiplicity.Never,BuiltInFunction.GetUserId (),cancellationToken);

// Query datasetGetApprovalProcess
cancellationToken.ThrowIfCancellationRequested();
int datasetGetApprovalProcess_maxRecords = 1;
if (datasetGetApprovalProcess_maxRecords < 1) datasetGetApprovalProcess_maxRecords = 1;
int datasetGetApprovalProcess_startIndex = 0;(localVars.queryResGetApprovalProcess_outParamList,localVars.queryResGetApprovalProcess_outParamCount) = await FuncActionShowIsDonationSwitch.datasetGetApprovalProcess(requestContext,datasetGetApprovalProcess_maxRecords,datasetGetApprovalProcess_startIndex,IterationMultiplicity.Never,localVars.queryResGetUserExtendedInternalJobTitle_outParamList.CurrentRec.ssENUser_Extended_Internal.ssEntraRoleId,cancellationToken);

// o_ShowSwitch = notGetApprovalProcess.List.Empty
result.outParamo_ShowSwitch=(!localVars.queryResGetApprovalProcess_outParamList.Empty);
} //close CreateActionActivity using block
} // try

finally {
outParamo_ShowSwitch = result.outParamo_ShowSwitch;
} // inner-finally
RETURN_STATEMENT:
return outParamo_ShowSwitch;
}

public static class FuncActionShowIsDonationSwitch {

private static async Task<RC_1c307c6ba13b1609f542644719b6e56b> datasetGetApprovalProcessReadDbAsync(RC_1c307c6ba13b1609f542644719b6e56b rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApprovalProcess.Read( r, ref index);
rec.ssENApprovalProcessLevel.Read( r, ref index);
return rec;
}
// Query Function "GetApprovalProcess" GkwOJ_7jf0mFErDI3cFbiA of Action "ShowIsDonationSwitch"
public static async Task<(RL_8dbe9b3349c28479d314d27fe2f03197,long)> datasetGetApprovalProcess(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpenApprovalProcessLevel_EntraRoleId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ShowIsDonationSwitch.GetApprovalProcess", "270e4c1a-e3fe-497f-8512-b0c8ddc15b88");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ShowIsDonationSwitch.GetApprovalProcess", "270e4c1a-e3fe-497f-8512-b0c8ddc15b88", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.9Vhow9gjh0mkE1Om8PD62A/NodesNotShownInESpaceTree.GkwOJ_7jf0mFErDI3cFbiA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44");
fromBuilder.Append(" FROM ({ApprovalProcess} \"enapprovalprocess30\" Left JOIN {ApprovalProcessLevel} \"enapprovalprocesslevel13\" ON (\"enapprovalprocess30\".\"id\" = \"enapprovalprocesslevel13\".\"approvalprocessid\")) ");
whereBuilder.Append(" WHERE (");
if (qpenApprovalProcessLevel_EntraRoleId != 0) {
whereBuilder.Append("((\"enapprovalprocesslevel13\".\"entraroleid\" = @qpenApprovalProcessLevel_EntraRoleId) AND (\"enapprovalprocesslevel13\".\"entraroleid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpenApprovalProcessLevel_EntraRoleId", DbType.Int64, qpenApprovalProcessLevel_EntraRoleId);
} else {
whereBuilder.Append("(\"enapprovalprocesslevel13\".\"entraroleid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enapprovalprocesslevel13\".\"levelnumber\" = 1)) AND (\"enapprovalprocess30\".\"isdonation\" = 1) AND (\"enapprovalprocess30\".\"isactive\" = 1)");
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
RL_8dbe9b3349c28479d314d27fe2f03197 outParamList = new RL_8dbe9b3349c28479d314d27fe2f03197();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetApprovalProcessReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ShowIsDonationSwitch.GetApprovalProcess.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_8dbe9b3349c28479d314d27fe2f03197 _tmp = new RL_8dbe9b3349c28479d314d27fe2f03197();
_tmp.AlternateReadDbMethodAsync = datasetGetApprovalProcessReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ShowIsDonationSwitch.GetApprovalProcess.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_8dbe9b3349c28479d314d27fe2f03197)_tmp;
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

private static async Task<RC_34272dae45b4de5e1332f46c6e8700b9> datasetGetUserExtendedInternalJobTitleReadDbAsync(RC_34272dae45b4de5e1332f46c6e8700b9 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
return rec;
}
// Query Function "GetUserExtendedInternalJobTitle" zShw9BdaP0uDXxZke3OLlw of Action "ShowIsDonationSwitch"
public static async Task<(RL_752c66ffcb633a1081093541635464e7,long)> datasetGetUserExtendedInternalJobTitle(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ShowIsDonationSwitch.GetUserExtendedInternalJobTitle", "f47028cd-5a17-4b3f-835f-16647b738b97");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ShowIsDonationSwitch.GetUserExtendedInternalJobTitle", "f47028cd-5a17-4b3f-835f-16647b738b97", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.9Vhow9gjh0mkE1Om8PD62A/NodesNotShownInESpaceTree.zShw9BdaP0uDXxZke3OLlw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, \"enuser_extended_internal62\".\"entraroleid\" o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24");
fromBuilder.Append(" FROM ({User_Extended_Internal} \"enuser_extended_internal62\" Inner JOIN {User} \"enuser108\" ON (\"enuser_extended_internal62\".\"id\" = \"enuser108\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser108\".\"id\" = @qpusUser_Id) AND (\"enuser108\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser108\".\"id\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"enuser108\".\"name\" ASC ");
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
RL_752c66ffcb633a1081093541635464e7 outParamList = new RL_752c66ffcb633a1081093541635464e7();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetUserExtendedInternalJobTitleReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ShowIsDonationSwitch.GetUserExtendedInternalJobTitle.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_752c66ffcb633a1081093541635464e7 _tmp = new RL_752c66ffcb633a1081093541635464e7();
_tmp.AlternateReadDbMethodAsync = datasetGetUserExtendedInternalJobTitleReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ShowIsDonationSwitch.GetUserExtendedInternalJobTitle.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_752c66ffcb633a1081093541635464e7)_tmp;
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
