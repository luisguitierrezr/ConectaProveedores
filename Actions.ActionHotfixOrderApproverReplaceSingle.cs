namespace ssConectaProveedores;

public partial class Actions {
public class lcvHotfixOrderApproverReplaceSingle : VarsBag {
public string inParamUserOriginal;
public string inParamUserSubstitute;
public long inParamOrderApprovalLevelIdSelected;
public RL_f518d708e7bb15a03a65b75b9f603096 queryResGetUserSubstitute_outParamList = new RL_f518d708e7bb15a03a65b75b9f603096();
public long queryResGetUserSubstitute_outParamCount = 0L;

public Actions.lcoOrderApprovalLevelCreateOrUpdate resOrderApprovalLevelCreateOrUpdate =  new Actions.lcoOrderApprovalLevelCreateOrUpdate();
public RL_f518d708e7bb15a03a65b75b9f603096 queryResGetUserOriginal_outParamList = new RL_f518d708e7bb15a03a65b75b9f603096();
public long queryResGetUserOriginal_outParamCount = 0L;

public Actions.lcoOrderLogAdd resOrderLogAdd =  new Actions.lcoOrderLogAdd();
public RL_6a0d508a138cc1e49e6d938f0b4069dd queryResGetOrderApprovalLevelsByAssignedTo_outParamList = new RL_6a0d508a138cc1e49e6d938f0b4069dd();
public long queryResGetOrderApprovalLevelsByAssignedTo_outParamCount = 0L;

public lcvHotfixOrderApproverReplaceSingle(string inParamUserOriginal, string inParamUserSubstitute, long inParamOrderApprovalLevelIdSelected) {
this.inParamUserOriginal = inParamUserOriginal;
this.inParamUserSubstitute = inParamUserSubstitute;
this.inParamOrderApprovalLevelIdSelected = inParamOrderApprovalLevelIdSelected;
}
}
public class lcoHotfixOrderApproverReplaceSingle : VarsBag {
public string outParamErrorMessage = "";

public lcoHotfixOrderApproverReplaceSingle() {
}
}
/// <summary>
/// Action <code>HotfixOrderApproverReplaceSingle</code> that represents the Service Studio action
///  <code>HotfixOrderApproverReplaceSingle</code> <p> Description: </p>
/// </summary>
public static async Task<string> ActionHotfixOrderApproverReplaceSingle(IRequestContext requestContext,string inParamUserOriginal,string inParamUserSubstitute,long inParamOrderApprovalLevelIdSelected,CancellationToken cancellationToken) {
string outParamErrorMessage = default;
lcoHotfixOrderApproverReplaceSingle result = new lcoHotfixOrderApproverReplaceSingle();
lcvHotfixOrderApproverReplaceSingle localVars = new lcvHotfixOrderApproverReplaceSingle(inParamUserOriginal, inParamUserSubstitute, inParamOrderApprovalLevelIdSelected);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("HotfixOrderApproverReplaceSingle", "e89996a6-7959-4264-b5bc-62dce7757bc4"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("HotfixOrderApproverReplaceSingle", "e89996a6-7959-4264-b5bc-62dce7757bc4", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetUserOriginal
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserOriginal_maxRecords = 1;
if (datasetGetUserOriginal_maxRecords < 1) datasetGetUserOriginal_maxRecords = 1;
int datasetGetUserOriginal_startIndex = 0;(localVars.queryResGetUserOriginal_outParamList,localVars.queryResGetUserOriginal_outParamCount) = await FuncActionHotfixOrderApproverReplaceSingle.datasetGetUserOriginal(requestContext,datasetGetUserOriginal_maxRecords,datasetGetUserOriginal_startIndex,IterationMultiplicity.Never,localVars.inParamUserOriginal,cancellationToken);

// Query datasetGetOrderApprovalLevelsByAssignedTo
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderApprovalLevelsByAssignedTo_maxRecords = 1;
if (datasetGetOrderApprovalLevelsByAssignedTo_maxRecords < 1) datasetGetOrderApprovalLevelsByAssignedTo_maxRecords = 1;
int datasetGetOrderApprovalLevelsByAssignedTo_startIndex = 0;(localVars.queryResGetOrderApprovalLevelsByAssignedTo_outParamList,localVars.queryResGetOrderApprovalLevelsByAssignedTo_outParamCount) = await FuncActionHotfixOrderApproverReplaceSingle.datasetGetOrderApprovalLevelsByAssignedTo(requestContext,datasetGetOrderApprovalLevelsByAssignedTo_maxRecords,datasetGetOrderApprovalLevelsByAssignedTo_startIndex,IterationMultiplicity.Never,localVars.inParamOrderApprovalLevelIdSelected,cancellationToken);

// Query datasetGetUserSubstitute
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserSubstitute_maxRecords = 1;
if (datasetGetUserSubstitute_maxRecords < 1) datasetGetUserSubstitute_maxRecords = 1;
int datasetGetUserSubstitute_startIndex = 0;(localVars.queryResGetUserSubstitute_outParamList,localVars.queryResGetUserSubstitute_outParamCount) = await FuncActionHotfixOrderApproverReplaceSingle.datasetGetUserSubstitute(requestContext,datasetGetUserSubstitute_maxRecords,datasetGetUserSubstitute_startIndex,IterationMultiplicity.Never,localVars.inParamUserSubstitute,cancellationToken);

if(((localVars.queryResGetUserSubstitute_outParamList.CurrentRec.ssENUser_Extended_Internal.ssEntraRoleId==Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// ErrorMessage = "El usuario de destino no tiene un puesto definido!"
result.outParamErrorMessage="El usuario de destino no tiene un puesto definido!";
} else {
// GetOrderApprovalLevelsByAssignedTo.List.Current.OrderApprovalLevel.EntraRoleId = If
localVars.queryResGetOrderApprovalLevelsByAssignedTo_outParamList.CurrentRec.ssENOrderApprovalLevel.ssEntraRoleId = ((((localVars.queryResGetOrderApprovalLevelsByAssignedTo_outParamList.CurrentRec.ssENOrderApprovalLevel.ssEntraRoleId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ()))&&(localVars.queryResGetOrderApprovalLevelsByAssignedTo_outParamList.CurrentRec.ssENOrderApprovalLevel.ssEntraRoleId==localVars.queryResGetUserOriginal_outParamList.CurrentRec.ssENEntraRole.ssId))) ? (localVars.queryResGetUserSubstitute_outParamList.CurrentRec.ssENUser_Extended_Internal.ssEntraRoleId) : (localVars.queryResGetOrderApprovalLevelsByAssignedTo_outParamList.CurrentRec.ssENOrderApprovalLevel.ssEntraRoleId));

// GetOrderApprovalLevelsByAssignedTo.List.Current.OrderApprovalLevel.AssignedTo = If
localVars.queryResGetOrderApprovalLevelsByAssignedTo_outParamList.CurrentRec.ssENOrderApprovalLevel.ssAssignedTo = (((localVars.queryResGetOrderApprovalLevelsByAssignedTo_outParamList.CurrentRec.ssENOrderApprovalLevel.ssAssignedTo!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.inParamUserSubstitute) : (localVars.queryResGetOrderApprovalLevelsByAssignedTo_outParamList.CurrentRec.ssENOrderApprovalLevel.ssAssignedTo));

// GetOrderApprovalLevelsByAssignedTo.List.Current.OrderApprovalLevel.ApprovedBy = If
localVars.queryResGetOrderApprovalLevelsByAssignedTo_outParamList.CurrentRec.ssENOrderApprovalLevel.ssApprovedBy = (((localVars.queryResGetOrderApprovalLevelsByAssignedTo_outParamList.CurrentRec.ssENOrderApprovalLevel.ssApprovedBy==localVars.inParamUserOriginal)) ? (localVars.inParamUserSubstitute) : (localVars.queryResGetOrderApprovalLevelsByAssignedTo_outParamList.CurrentRec.ssENOrderApprovalLevel.ssApprovedBy));

// GetOrderApprovalLevelsByAssignedTo.List.Current.OrderApprovalLevel.RejectedBy = If
localVars.queryResGetOrderApprovalLevelsByAssignedTo_outParamList.CurrentRec.ssENOrderApprovalLevel.ssRejectedBy = (((localVars.queryResGetOrderApprovalLevelsByAssignedTo_outParamList.CurrentRec.ssENOrderApprovalLevel.ssRejectedBy==localVars.inParamUserOriginal)) ? (localVars.inParamUserSubstitute) : (localVars.queryResGetOrderApprovalLevelsByAssignedTo_outParamList.CurrentRec.ssENOrderApprovalLevel.ssRejectedBy));

// GetOrderApprovalLevelsByAssignedTo.List.Current.OrderApprovalLevel.ToModifyBy = If
localVars.queryResGetOrderApprovalLevelsByAssignedTo_outParamList.CurrentRec.ssENOrderApprovalLevel.ssToModifyBy = (((localVars.queryResGetOrderApprovalLevelsByAssignedTo_outParamList.CurrentRec.ssENOrderApprovalLevel.ssToModifyBy==localVars.inParamUserOriginal)) ? (localVars.inParamUserSubstitute) : (localVars.queryResGetOrderApprovalLevelsByAssignedTo_outParamList.CurrentRec.ssENOrderApprovalLevel.ssToModifyBy));

// GetOrderApprovalLevelsByAssignedTo.List.Current.OrderApprovalLevel.WasCanceledBy = If
localVars.queryResGetOrderApprovalLevelsByAssignedTo_outParamList.CurrentRec.ssENOrderApprovalLevel.ssWasCanceledBy = (((localVars.queryResGetOrderApprovalLevelsByAssignedTo_outParamList.CurrentRec.ssENOrderApprovalLevel.ssWasCanceledBy==localVars.inParamUserOriginal)) ? (localVars.inParamUserSubstitute) : (localVars.queryResGetOrderApprovalLevelsByAssignedTo_outParamList.CurrentRec.ssENOrderApprovalLevel.ssWasCanceledBy));
// OrderApprovalLevelCreateOrUpdate
localVars.resOrderApprovalLevelCreateOrUpdate.outParamId = await Actions.ActionOrderApprovalLevelCreateOrUpdate(requestContext,localVars.queryResGetOrderApprovalLevelsByAssignedTo_outParamList.CurrentRec.ssENOrderApprovalLevel,cancellationToken);

// OrderLogAdd
localVars.resOrderLogAdd.outParamId = await Actions.ActionOrderLogAdd(requestContext,new EN_a8e484428097204171df8a1feecb2534EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssOrderId = localVars.queryResGetOrderApprovalLevelsByAssignedTo_outParamList.CurrentRec.ssENOrderMain.ssId, ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssMessage = (((localVars.queryResGetOrderApprovalLevelsByAssignedTo_outParamList.CurrentRec.ssENOrderApprovalLevel.ssAssignedTo!=BuiltInFunction.NullTextIdentifier ())) ? ((((localVars.queryResGetUserOriginal_outParamList.CurrentRec.ssENUser.ssName+" se ha sustituido por ")+localVars.queryResGetUserSubstitute_outParamList.CurrentRec.ssENUser.ssName)+".")) : ((((localVars.queryResGetUserOriginal_outParamList.CurrentRec.ssENEntraRole.ssRoleName+" se ha sustituido por ")+localVars.queryResGetUserSubstitute_outParamList.CurrentRec.ssENEntraRole.ssRoleName)+"."))) },cancellationToken);

}

} //close CreateActionActivity using block
} // try

finally {
outParamErrorMessage = result.outParamErrorMessage;
} // inner-finally
RETURN_STATEMENT:
return outParamErrorMessage;
}

public static class FuncActionHotfixOrderApproverReplaceSingle {

private static async Task<RC_77956dae907db5f208e8a848dc366336> datasetGetUserSubstituteReadDbAsync(RC_77956dae907db5f208e8a848dc366336 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENEntraRole.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
rec.ssENUserExtension.Read( r, ref index);
return rec;
}
// Query Function "GetUserSubstitute" ryOPCgO7g0qpWC9fK8USaQ of Action "HotfixOrderApproverReplaceSingle"
public static async Task<(RL_f518d708e7bb15a03a65b75b9f603096,long)> datasetGetUserSubstitute(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("HotfixOrderApproverReplaceSingle.GetUserSubstitute", "0a8f23af-bb03-4a83-a958-2f5f2bc51269");
using var queryActivity = activitySource.CreateAggregateQueryActivity("HotfixOrderApproverReplaceSingle.GetUserSubstitute", "0a8f23af-bb03-4a83-a958-2f5f2bc51269", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.ppaZ6Fl5ZEK1vGLc53V7xA/NodesNotShownInESpaceTree.ryOPCgO7g0qpWC9fK8USaQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enentrarole36\".\"rolename\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, \"enuser126\".\"name\" o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, \"enuser_extended_internal75\".\"entraroleid\" o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33");
fromBuilder.Append(" FROM ((({User} \"enuser126\" Left JOIN {User_Extended_Internal} \"enuser_extended_internal75\" ON (\"enuser126\".\"id\" = \"enuser_extended_internal75\".\"id\"))  Left JOIN {UserExtension} \"enuserextension58\" ON (\"enuser126\".\"id\" = \"enuserextension58\".\"id\"))  Left JOIN {EntraRole} \"enentrarole36\" ON (\"enuser_extended_internal75\".\"entraroleid\" = \"enentrarole36\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser126\".\"id\" = @qpusUser_Id) AND (\"enuser126\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser126\".\"id\" IS NULL)");
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
RL_f518d708e7bb15a03a65b75b9f603096 outParamList = new RL_f518d708e7bb15a03a65b75b9f603096();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetUserSubstituteReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[4];
opt[0] = new BitArray(new bool[] {true, false, true, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query HotfixOrderApproverReplaceSingle.GetUserSubstitute.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_f518d708e7bb15a03a65b75b9f603096 _tmp = new RL_f518d708e7bb15a03a65b75b9f603096();
_tmp.AlternateReadDbMethodAsync = datasetGetUserSubstituteReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query HotfixOrderApproverReplaceSingle.GetUserSubstitute.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_f518d708e7bb15a03a65b75b9f603096)_tmp;
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

private static async Task<RC_77956dae907db5f208e8a848dc366336> datasetGetUserOriginalReadDbAsync(RC_77956dae907db5f208e8a848dc366336 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENEntraRole.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
rec.ssENUserExtension.Read( r, ref index);
return rec;
}
// Query Function "GetUserOriginal" cpDjIijKF0evrwMShw2Uyg of Action "HotfixOrderApproverReplaceSingle"
public static async Task<(RL_f518d708e7bb15a03a65b75b9f603096,long)> datasetGetUserOriginal(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("HotfixOrderApproverReplaceSingle.GetUserOriginal", "22e39072-ca28-4717-afaf-0312870d94ca");
using var queryActivity = activitySource.CreateAggregateQueryActivity("HotfixOrderApproverReplaceSingle.GetUserOriginal", "22e39072-ca28-4717-afaf-0312870d94ca", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.ppaZ6Fl5ZEK1vGLc53V7xA/NodesNotShownInESpaceTree.cpDjIijKF0evrwMShw2Uyg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enentrarole37\".\"id\" o0, \"enentrarole37\".\"rolename\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, \"enuser127\".\"name\" o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33");
fromBuilder.Append(" FROM ((({User} \"enuser127\" Left JOIN {User_Extended_Internal} \"enuser_extended_internal76\" ON (\"enuser127\".\"id\" = \"enuser_extended_internal76\".\"id\"))  Left JOIN {UserExtension} \"enuserextension59\" ON (\"enuser127\".\"id\" = \"enuserextension59\".\"id\"))  Left JOIN {EntraRole} \"enentrarole37\" ON (\"enuser_extended_internal76\".\"entraroleid\" = \"enentrarole37\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser127\".\"id\" = @qpusUser_Id) AND (\"enuser127\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser127\".\"id\" IS NULL)");
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
RL_f518d708e7bb15a03a65b75b9f603096 outParamList = new RL_f518d708e7bb15a03a65b75b9f603096();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetUserOriginalReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[4];
opt[0] = new BitArray(new bool[] {true, false, true, true, true});
opt[1] = new BitArray(new bool[] {false, false, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query HotfixOrderApproverReplaceSingle.GetUserOriginal.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_f518d708e7bb15a03a65b75b9f603096 _tmp = new RL_f518d708e7bb15a03a65b75b9f603096();
_tmp.AlternateReadDbMethodAsync = datasetGetUserOriginalReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query HotfixOrderApproverReplaceSingle.GetUserOriginal.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_f518d708e7bb15a03a65b75b9f603096)_tmp;
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

private static async Task<RC_a2ea85a9f362412e4b6f04be74bb4c8a> datasetGetOrderApprovalLevelsByAssignedToReadDbAsync(RC_a2ea85a9f362412e4b6f04be74bb4c8a rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENEntraRole.Read( r, ref index);
rec.ssENOrderApproval.Read( r, ref index);
rec.ssENOrderApprovalLevel.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
return rec;
}
// Query Function "GetOrderApprovalLevelsByAssignedTo" w_HD+_s630WSzi_5kTITNQ of Action "HotfixOrderApproverReplaceSingle"
public static async Task<(RL_6a0d508a138cc1e49e6d938f0b4069dd,long)> datasetGetOrderApprovalLevelsByAssignedTo(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderApprovalLevel_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("HotfixOrderApproverReplaceSingle.GetOrderApprovalLevelsByAssignedTo", "fbc3f1c3-3afb-45df-92ce-2ff991321335");
using var queryActivity = activitySource.CreateAggregateQueryActivity("HotfixOrderApproverReplaceSingle.GetOrderApprovalLevelsByAssignedTo", "fbc3f1c3-3afb-45df-92ce-2ff991321335", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.ppaZ6Fl5ZEK1vGLc53V7xA/NodesNotShownInESpaceTree.w_HD+_s630WSzi_5kTITNQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, \"enorderapprovallevel14\".\"id\" o14, \"enorderapprovallevel14\".\"orderapprovalid\" o15, \"enorderapprovallevel14\".\"levelnumber\" o16, \"enorderapprovallevel14\".\"entraroleid\" o17, \"enorderapprovallevel14\".\"assignedto\" o18, \"enorderapprovallevel14\".\"assignedon\" o19, \"enorderapprovallevel14\".\"approvalstatusid\" o20, \"enorderapprovallevel14\".\"approvedby\" o21, \"enorderapprovallevel14\".\"approvedon\" o22, \"enorderapprovallevel14\".\"rejectedby\" o23, \"enorderapprovallevel14\".\"rejectedon\" o24, \"enorderapprovallevel14\".\"iscomplement\" o25, \"enorderapprovallevel14\".\"isreassigned\" o26, \"enorderapprovallevel14\".\"issubstitutefor\" o27, \"enorderapprovallevel14\".\"tomodifyby\" o28, \"enorderapprovallevel14\".\"tomodifyon\" o29, \"enorderapprovallevel14\".\"wascanceledby\" o30, \"enordermain59\".\"id\" o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64");
fromBuilder.Append(" FROM (((({OrderApprovalLevel} \"enorderapprovallevel14\" Left JOIN {OrderApproval} \"enorderapproval15\" ON (\"enorderapprovallevel14\".\"orderapprovalid\" = \"enorderapproval15\".\"id\"))  Left JOIN {EntraRole} \"enentrarole38\" ON (\"enorderapprovallevel14\".\"entraroleid\" = \"enentrarole38\".\"id\"))  Left JOIN {User} \"enuser128\" ON (\"enorderapprovallevel14\".\"assignedto\" = \"enuser128\".\"id\"))  Left JOIN {OrderMain} \"enordermain59\" ON (\"enorderapproval15\".\"orderid\" = \"enordermain59\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qporOrderApprovalLevel_Id != 0) {
whereBuilder.Append("((\"enorderapprovallevel14\".\"id\" = @qporOrderApprovalLevel_Id) AND (\"enorderapprovallevel14\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderApprovalLevel_Id", DbType.Int64, qporOrderApprovalLevel_Id);
} else {
whereBuilder.Append("(\"enorderapprovallevel14\".\"id\" IS NULL)");
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
RL_6a0d508a138cc1e49e6d938f0b4069dd outParamList = new RL_6a0d508a138cc1e49e6d938f0b4069dd();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrderApprovalLevelsByAssignedToReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[5];
opt[0] = new BitArray(new bool[] {true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[4] = new BitArray(new bool[] {true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query HotfixOrderApproverReplaceSingle.GetOrderApprovalLevelsByAssignedTo.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_6a0d508a138cc1e49e6d938f0b4069dd _tmp = new RL_6a0d508a138cc1e49e6d938f0b4069dd();
_tmp.AlternateReadDbMethodAsync = datasetGetOrderApprovalLevelsByAssignedToReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query HotfixOrderApproverReplaceSingle.GetOrderApprovalLevelsByAssignedTo.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_6a0d508a138cc1e49e6d938f0b4069dd)_tmp;
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
