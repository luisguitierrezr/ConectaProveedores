namespace ssConectaProveedores;

public partial class Actions {
public class lcvFindReqNextApprover : VarsBag {
public long inParami_ApplicationRoleId;
public string inParami_ApplicationRoleName;
public string inParami_UserId;
public long inParami_RegionId;
/// <summary>
/// Variable <code>l_IsEndCycle</code> that represents the Service Studio Boolean
///  <code>l_IsEndCycle</code> <p>Description: </p>
/// </summary>
public bool varLcl_IsEndCycle = false;

/// <summary>
/// Variable <code>l_CurrentUserId</code> that represents the Service Studio UserIdentifier
///  <code>l_CurrentUserId</code> <p>Description: </p>
/// </summary>
public string varLcl_CurrentUserId = "";

public ST_d32097d2629a99529d77b865dae9fb0cStructure resGetUserManager_outParamResponse = new ST_d32097d2629a99529d77b865dae9fb0cStructure();
public ST_38509e9fbd36a9b928c2f4e34a1342aeStructure resGetUserManager_outParamResult = new ST_38509e9fbd36a9b928c2f4e34a1342aeStructure();

public Actions.lcoHasRoleNeeded resHasRoleNeeded =  new Actions.lcoHasRoleNeeded();
public Actions.lcoHasRoleNeeded resHasRoleNeeded2 =  new Actions.lcoHasRoleNeeded();
public RL_752c66ffcb633a1081093541635464e7 queryResGetUserExtendedInternal_outParamList = new RL_752c66ffcb633a1081093541635464e7();
public long queryResGetUserExtendedInternal_outParamCount = 0L;

public RL_752c66ffcb633a1081093541635464e7 queryResGetUserExtendedInternalByEntraId_outParamList = new RL_752c66ffcb633a1081093541635464e7();
public long queryResGetUserExtendedInternalByEntraId_outParamCount = 0L;

public lcvFindReqNextApprover(long inParami_ApplicationRoleId, string inParami_ApplicationRoleName, string inParami_UserId, long inParami_RegionId) {
this.inParami_ApplicationRoleId = inParami_ApplicationRoleId;
this.inParami_ApplicationRoleName = inParami_ApplicationRoleName;
this.inParami_UserId = inParami_UserId;
this.inParami_RegionId = inParami_RegionId;
}
}
public class lcoFindReqNextApprover : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public string outParamo_UserId = "";

public lcoFindReqNextApprover() {
}
}
/// <summary>
/// Action <code>FindReqNextApprover</code> that represents the Service Studio action
///  <code>FindReqNextApprover</code> <p> Description: </p>
/// </summary>
public static async Task<(ST_046fb53ebbe142526d95e87ef1ae9711Structure,string)> ActionFindReqNextApprover(IRequestContext requestContext,long inParami_ApplicationRoleId,string inParami_ApplicationRoleName,string inParami_UserId,long inParami_RegionId,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
string outParamo_UserId = default;
lcoFindReqNextApprover result = new lcoFindReqNextApprover();
lcvFindReqNextApprover localVars = new lcvFindReqNextApprover(inParami_ApplicationRoleId, inParami_ApplicationRoleName, inParami_UserId, inParami_RegionId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("FindReqNextApprover", "1c6027d6-3c72-462d-bc4c-9eb19f96a757"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("FindReqNextApprover", "1c6027d6-3c72-462d-bc4c-9eb19f96a757", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
if(((localVars.inParami_UserId!=BuiltInFunction.NullTextIdentifier ()))) {
// l_CurrentUserId = i_UserId
localVars.varLcl_CurrentUserId=localVars.inParami_UserId;
while ((!(localVars.varLcl_IsEndCycle))) {
// Query datasetGetUserExtendedInternal
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserExtendedInternal_maxRecords = 1;
if (datasetGetUserExtendedInternal_maxRecords < 1) datasetGetUserExtendedInternal_maxRecords = 1;
int datasetGetUserExtendedInternal_startIndex = 0;(localVars.queryResGetUserExtendedInternal_outParamList,localVars.queryResGetUserExtendedInternal_outParamCount) = await FuncActionFindReqNextApprover.datasetGetUserExtendedInternal(requestContext,datasetGetUserExtendedInternal_maxRecords,datasetGetUserExtendedInternal_startIndex,IterationMultiplicity.Never,localVars.varLcl_CurrentUserId,cancellationToken);

// Empty
if(((localVars.queryResGetUserExtendedInternal_outParamList.Empty||(localVars.queryResGetUserExtendedInternal_outParamList.CurrentRec.ssENUser_Extended_Internal.ssEntraId=="")))) {
// o_Output
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "User not found or External Id not found!"
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("5K2sRr4sfkmtKromEEzatw#Value.1702721561.1", "User not found or External Id not found!");
goto RETURN_STATEMENT;

} else {
// GetUserManager
(localVars.resGetUserManager_outParamResponse,localVars.resGetUserManager_outParamResult) = await Actions.ActionGetUserManager(requestContext,localVars.queryResGetUserExtendedInternal_outParamList.CurrentRec.ssENUser_Extended_Internal.ssEntraId,cancellationToken);

// IsSuccess
if((localVars.resGetUserManager_outParamResult.ssIsSuccess)) {
// ReportsToHimself
if(((localVars.resGetUserManager_outParamResponse.ssId==localVars.queryResGetUserExtendedInternal_outParamList.CurrentRec.ssENUser_Extended_Internal.ssEntraId))) {
// o_Output
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "Cannot determine the next approver!"
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("9O3nwLa9NUmBozRwtA2y2g#Value.-1052843160.1", "Cannot determine the next approver!");
goto RETURN_STATEMENT;

} else {
// Query datasetGetUserExtendedInternalByEntraId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserExtendedInternalByEntraId_maxRecords = 1;
if (datasetGetUserExtendedInternalByEntraId_maxRecords < 1) datasetGetUserExtendedInternalByEntraId_maxRecords = 1;
int datasetGetUserExtendedInternalByEntraId_startIndex = 0;(localVars.queryResGetUserExtendedInternalByEntraId_outParamList,localVars.queryResGetUserExtendedInternalByEntraId_outParamCount) = await FuncActionFindReqNextApprover.datasetGetUserExtendedInternalByEntraId(requestContext,datasetGetUserExtendedInternalByEntraId_maxRecords,datasetGetUserExtendedInternalByEntraId_startIndex,IterationMultiplicity.Never,localVars.resGetUserManager_outParamResponse.ssId,cancellationToken);

// Empty
if((localVars.queryResGetUserExtendedInternalByEntraId_outParamList.Empty)) {
// o_Output
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "Cannot determine the next approver!"
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("b1xYB5vvqkG_VbefKY9WfQ#Value.-1052843160.1", "Cannot determine the next approver!");
goto RETURN_STATEMENT;

} else {
// l_CurrentUserId = GetUserExtendedInternalByEntraId.List.Current.User.Id
localVars.varLcl_CurrentUserId=localVars.queryResGetUserExtendedInternalByEntraId_outParamList.CurrentRec.ssENUser.ssId;
// HasRoleNeeded2
(localVars.resHasRoleNeeded2.outParamo_Output,localVars.resHasRoleNeeded2.outParamo_UserId) = await Actions.ActionHasRoleNeeded(requestContext,localVars.inParami_ApplicationRoleId,localVars.inParami_ApplicationRoleName,localVars.queryResGetUserExtendedInternalByEntraId_outParamList.CurrentRec.ssENUser.ssId,0L,3,cancellationToken);

// IsSuccess
if((localVars.resHasRoleNeeded2.outParamo_Output.ssIsSuccess)) {
// o_UserId = l_CurrentUserId
result.outParamo_UserId=localVars.varLcl_CurrentUserId;

// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
goto RETURN_STATEMENT;

}

}

}

} else {
// o_Output
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = GetUserManager.Result.ErrorMessage
result.outParamo_Output.ssMessage = localVars.resGetUserManager_outParamResult.ssErrorMessage;
goto RETURN_STATEMENT;

}

}

}

} else {
// HasRoleNeeded
(localVars.resHasRoleNeeded.outParamo_Output,localVars.resHasRoleNeeded.outParamo_UserId) = await Actions.ActionHasRoleNeeded(requestContext,localVars.inParami_ApplicationRoleId,localVars.inParami_ApplicationRoleName,"",localVars.inParami_RegionId,3,cancellationToken);

// IsSuccess
if((localVars.resHasRoleNeeded.outParamo_Output.ssIsSuccess)) {
// o_UserId = HasRoleNeeded.o_UserId
result.outParamo_UserId=localVars.resHasRoleNeeded.outParamo_UserId;

// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
} else {
// o_Output = HasRoleNeeded.o_Output
result.outParamo_Output=localVars.resHasRoleNeeded.outParamo_Output;
}

}

} //close CreateActionActivity using block
} // try

finally {
outParamo_Output = result.outParamo_Output;
outParamo_UserId = result.outParamo_UserId;
} // inner-finally
RETURN_STATEMENT:
return (outParamo_Output,outParamo_UserId);
}

public static class FuncActionFindReqNextApprover {

private static async Task<RC_34272dae45b4de5e1332f46c6e8700b9> datasetGetUserExtendedInternalReadDbAsync(RC_34272dae45b4de5e1332f46c6e8700b9 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
return rec;
}
// Query Function "GetUserExtendedInternal" ShcSiLftzEqTknSWG70ujg of Action "FindReqNextApprover"
public static async Task<(RL_752c66ffcb633a1081093541635464e7,long)> datasetGetUserExtendedInternal(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("FindReqNextApprover.GetUserExtendedInternal", "8812174a-edb7-4acc-9392-74961bbd2e8e");
using var queryActivity = activitySource.CreateAggregateQueryActivity("FindReqNextApprover.GetUserExtendedInternal", "8812174a-edb7-4acc-9392-74961bbd2e8e", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.1idgHHI8LUa8TJ6xn5anVw/NodesNotShownInESpaceTree.ShcSiLftzEqTknSWG70ujg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, \"enuser_extended_internal11\".\"entraid\" o23, NULL o24");
fromBuilder.Append(" FROM ({User_Extended_Internal} \"enuser_extended_internal11\" Inner JOIN {User} \"enuser18\" ON (\"enuser_extended_internal11\".\"id\" = \"enuser18\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser18\".\"id\" = @qpusUser_Id) AND (\"enuser18\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser18\".\"id\" IS NULL)");
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
RL_752c66ffcb633a1081093541635464e7 outParamList = new RL_752c66ffcb633a1081093541635464e7();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetUserExtendedInternalReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query FindReqNextApprover.GetUserExtendedInternal.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_752c66ffcb633a1081093541635464e7 _tmp = new RL_752c66ffcb633a1081093541635464e7();
_tmp.AlternateReadDbMethodAsync = datasetGetUserExtendedInternalReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query FindReqNextApprover.GetUserExtendedInternal.List", cancellationToken: cancellationToken);
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

private static async Task<RC_34272dae45b4de5e1332f46c6e8700b9> datasetGetUserExtendedInternalByEntraIdReadDbAsync(RC_34272dae45b4de5e1332f46c6e8700b9 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
return rec;
}
// Query Function "GetUserExtendedInternalByEntraId" EBsqsHOLn0y_CHwTM33JXA of Action "FindReqNextApprover"
public static async Task<(RL_752c66ffcb633a1081093541635464e7,long)> datasetGetUserExtendedInternalByEntraId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteUser_Extended_Internal_EntraId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("FindReqNextApprover.GetUserExtendedInternalByEntraId", "b02a1b10-8b73-4c9f-bf08-7c13337dc95c");
using var queryActivity = activitySource.CreateAggregateQueryActivity("FindReqNextApprover.GetUserExtendedInternalByEntraId", "b02a1b10-8b73-4c9f-bf08-7c13337dc95c", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.1idgHHI8LUa8TJ6xn5anVw/NodesNotShownInESpaceTree.EBsqsHOLn0y_CHwTM33JXA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enuser19\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24");
fromBuilder.Append(" FROM ({User_Extended_Internal} \"enuser_extended_internal12\" Inner JOIN {User} \"enuser19\" ON (\"enuser_extended_internal12\".\"id\" = \"enuser19\".\"id\")) ");
whereBuilder.Append(" WHERE (\"enuser_extended_internal12\".\"entraid\" = @qpteUser_Extended_Internal_EntraId)");
sqlCmd.CreateParameterWithoutReplacements("@qpteUser_Extended_Internal_EntraId", DbType.String, qpteUser_Extended_Internal_EntraId);
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
outParamList.AlternateReadDbMethodAsync = datasetGetUserExtendedInternalByEntraIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {false, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query FindReqNextApprover.GetUserExtendedInternalByEntraId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_752c66ffcb633a1081093541635464e7 _tmp = new RL_752c66ffcb633a1081093541635464e7();
_tmp.AlternateReadDbMethodAsync = datasetGetUserExtendedInternalByEntraIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query FindReqNextApprover.GetUserExtendedInternalByEntraId.List", cancellationToken: cancellationToken);
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
