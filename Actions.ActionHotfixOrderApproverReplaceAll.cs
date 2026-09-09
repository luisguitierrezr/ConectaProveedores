namespace ssConectaProveedores;

public partial class Actions {
public class lcvHotfixOrderApproverReplaceAll : VarsBag {
public string inParamUserOriginal;
public string inParamUserSubstitute;
public string inParamOrderNumberFilter;
public int inParamOrderStatusId;
public Actions.lcoOrderLogAdd resOrderLogAdd =  new Actions.lcoOrderLogAdd();
public RL_6a0d508a138cc1e49e6d938f0b4069dd queryResGetOrderApprovalLevelsByAssignedTo_outParamList = new RL_6a0d508a138cc1e49e6d938f0b4069dd();
public long queryResGetOrderApprovalLevelsByAssignedTo_outParamCount = 0L;

public RL_f518d708e7bb15a03a65b75b9f603096 queryResGetUserSubstitute_outParamList = new RL_f518d708e7bb15a03a65b75b9f603096();
public long queryResGetUserSubstitute_outParamCount = 0L;

public RL_f518d708e7bb15a03a65b75b9f603096 queryResGetUserOriginal_outParamList = new RL_f518d708e7bb15a03a65b75b9f603096();
public long queryResGetUserOriginal_outParamCount = 0L;

public Actions.lcoOrderApprovalLevelCreateOrUpdate resOrderApprovalLevelCreateOrUpdate =  new Actions.lcoOrderApprovalLevelCreateOrUpdate();
public lcvHotfixOrderApproverReplaceAll(string inParamUserOriginal, string inParamUserSubstitute, string inParamOrderNumberFilter, int inParamOrderStatusId) {
this.inParamUserOriginal = inParamUserOriginal;
this.inParamUserSubstitute = inParamUserSubstitute;
this.inParamOrderNumberFilter = inParamOrderNumberFilter;
this.inParamOrderStatusId = inParamOrderStatusId;
}
}
public class lcoHotfixOrderApproverReplaceAll : VarsBag {
public string outParamErrorMessage = "";

public lcoHotfixOrderApproverReplaceAll() {
}
}
/// <summary>
/// Action <code>HotfixOrderApproverReplaceAll</code> that represents the Service Studio action
///  <code>HotfixOrderApproverReplaceAll</code> <p> Description: </p>
/// </summary>
public static async Task<string> ActionHotfixOrderApproverReplaceAll(IRequestContext requestContext,string inParamUserOriginal,string inParamUserSubstitute,string inParamOrderNumberFilter,int inParamOrderStatusId,CancellationToken cancellationToken) {
string outParamErrorMessage = default;
lcoHotfixOrderApproverReplaceAll result = new lcoHotfixOrderApproverReplaceAll();
lcvHotfixOrderApproverReplaceAll localVars = new lcvHotfixOrderApproverReplaceAll(inParamUserOriginal, inParamUserSubstitute, inParamOrderNumberFilter, inParamOrderStatusId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("HotfixOrderApproverReplaceAll", "51c88f50-ea0b-47b6-aea3-609e722f7729"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("HotfixOrderApproverReplaceAll", "51c88f50-ea0b-47b6-aea3-609e722f7729", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetUserOriginal
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserOriginal_maxRecords = 1;
if (datasetGetUserOriginal_maxRecords < 1) datasetGetUserOriginal_maxRecords = 1;
int datasetGetUserOriginal_startIndex = 0;(localVars.queryResGetUserOriginal_outParamList,localVars.queryResGetUserOriginal_outParamCount) = await FuncActionHotfixOrderApproverReplaceAll.datasetGetUserOriginal(requestContext,datasetGetUserOriginal_maxRecords,datasetGetUserOriginal_startIndex,IterationMultiplicity.Never,localVars.inParamUserOriginal,cancellationToken);

// Query datasetGetOrderApprovalLevelsByAssignedTo
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderApprovalLevelsByAssignedTo_maxRecords = 0;
int datasetGetOrderApprovalLevelsByAssignedTo_startIndex = 0;(localVars.queryResGetOrderApprovalLevelsByAssignedTo_outParamList,localVars.queryResGetOrderApprovalLevelsByAssignedTo_outParamCount) = await FuncActionHotfixOrderApproverReplaceAll.datasetGetOrderApprovalLevelsByAssignedTo(requestContext,datasetGetOrderApprovalLevelsByAssignedTo_maxRecords,datasetGetOrderApprovalLevelsByAssignedTo_startIndex,IterationMultiplicity.Single,localVars.queryResGetUserOriginal_outParamList.CurrentRec.ssENUser_Extended_Internal.ssEntraRoleId,localVars.queryResGetUserOriginal_outParamList.CurrentRec.ssENUser_Extended_Internal.ssRegionId,localVars.inParamOrderNumberFilter,localVars.inParamOrderStatusId,localVars.inParamUserOriginal,cancellationToken);

if((localVars.queryResGetOrderApprovalLevelsByAssignedTo_outParamList.Empty)) {
// ErrorMessage = "No se encontraron aprobaciones!"
result.outParamErrorMessage="No se encontraron aprobaciones!";
} else {
// Query datasetGetUserSubstitute
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserSubstitute_maxRecords = 1;
if (datasetGetUserSubstitute_maxRecords < 1) datasetGetUserSubstitute_maxRecords = 1;
int datasetGetUserSubstitute_startIndex = 0;(localVars.queryResGetUserSubstitute_outParamList,localVars.queryResGetUserSubstitute_outParamCount) = await FuncActionHotfixOrderApproverReplaceAll.datasetGetUserSubstitute(requestContext,datasetGetUserSubstitute_maxRecords,datasetGetUserSubstitute_startIndex,IterationMultiplicity.Never,localVars.inParamUserSubstitute,cancellationToken);

if(((localVars.queryResGetUserSubstitute_outParamList.CurrentRec.ssENUser_Extended_Internal.ssEntraRoleId==Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// ErrorMessage = "El usuario de destino no tiene un puesto definido!"
result.outParamErrorMessage="El usuario de destino no tiene un puesto definido!";
} else {
// Foreach GetOrderApprovalLevelsByAssignedTo.List
localVars.queryResGetOrderApprovalLevelsByAssignedTo_outParamList.StartIteration();
try {while (!((localVars.queryResGetOrderApprovalLevelsByAssignedTo_outParamList.Eof))) {
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

localVars.queryResGetOrderApprovalLevelsByAssignedTo_outParamList.Advance();
}

} finally {
localVars.queryResGetOrderApprovalLevelsByAssignedTo_outParamList.EndIteration();
}

}

}

} //close CreateActionActivity using block
} // try

finally {
outParamErrorMessage = result.outParamErrorMessage;
} // inner-finally
RETURN_STATEMENT:
return outParamErrorMessage;
}

public static class FuncActionHotfixOrderApproverReplaceAll {

private static async Task<RC_a2ea85a9f362412e4b6f04be74bb4c8a> datasetGetOrderApprovalLevelsByAssignedToReadDbAsync(RC_a2ea85a9f362412e4b6f04be74bb4c8a rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENEntraRole.Read( r, ref index);
rec.ssENOrderApproval.Read( r, ref index);
rec.ssENOrderApprovalLevel.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
return rec;
}
// Query Function "GetOrderApprovalLevelsByAssignedTo" TodxV+M18UC3Ksn1nq606A of Action "HotfixOrderApproverReplaceAll"
public static async Task<(RL_6a0d508a138cc1e49e6d938f0b4069dd,long)> datasetGetOrderApprovalLevelsByAssignedTo(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpenOrderApprovalLevel_EntraRoleId,long qpreOrderMain_DivisionId,string qpteOrderNumberFilter,int qporOrderMain_OrderStatusId,string qpusOrderApprovalLevel_AssignedTo,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("HotfixOrderApproverReplaceAll.GetOrderApprovalLevelsByAssignedTo", "5771874e-35e3-40f1-b72a-c9f59eaeb4e8");
using var queryActivity = activitySource.CreateAggregateQueryActivity("HotfixOrderApproverReplaceAll.GetOrderApprovalLevelsByAssignedTo", "5771874e-35e3-40f1-b72a-c9f59eaeb4e8", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.UI_IUQvqtkeuo2Ceci93KQ/NodesNotShownInESpaceTree.TodxV+M18UC3Ksn1nq606A, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, \"enorderapprovallevel5\".\"id\" o14, \"enorderapprovallevel5\".\"orderapprovalid\" o15, \"enorderapprovallevel5\".\"levelnumber\" o16, \"enorderapprovallevel5\".\"entraroleid\" o17, \"enorderapprovallevel5\".\"assignedto\" o18, \"enorderapprovallevel5\".\"assignedon\" o19, \"enorderapprovallevel5\".\"approvalstatusid\" o20, \"enorderapprovallevel5\".\"approvedby\" o21, \"enorderapprovallevel5\".\"approvedon\" o22, \"enorderapprovallevel5\".\"rejectedby\" o23, \"enorderapprovallevel5\".\"rejectedon\" o24, \"enorderapprovallevel5\".\"iscomplement\" o25, \"enorderapprovallevel5\".\"isreassigned\" o26, \"enorderapprovallevel5\".\"issubstitutefor\" o27, \"enorderapprovallevel5\".\"tomodifyby\" o28, \"enorderapprovallevel5\".\"tomodifyon\" o29, \"enorderapprovallevel5\".\"wascanceledby\" o30, \"enordermain23\".\"id\" o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64");
fromBuilder.Append(" FROM (((({OrderApprovalLevel} \"enorderapprovallevel5\" Left JOIN {OrderApproval} \"enorderapproval5\" ON (\"enorderapprovallevel5\".\"orderapprovalid\" = \"enorderapproval5\".\"id\"))  Left JOIN {EntraRole} \"enentrarole9\" ON (\"enorderapprovallevel5\".\"entraroleid\" = \"enentrarole9\".\"id\"))  Left JOIN {User} \"enuser55\" ON (\"enorderapprovallevel5\".\"assignedto\" = \"enuser55\".\"id\"))  Left JOIN {OrderMain} \"enordermain23\" ON (\"enorderapproval5\".\"orderid\" = \"enordermain23\".\"id\")) ");
whereBuilder.Append(" WHERE (");
if ((qpusOrderApprovalLevel_AssignedTo.Trim()!="")) {
whereBuilder.Append("((\"enorderapprovallevel5\".\"assignedto\" = @qpusOrderApprovalLevel_AssignedTo) AND (\"enorderapprovallevel5\".\"assignedto\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusOrderApprovalLevel_AssignedTo", DbType.String, qpusOrderApprovalLevel_AssignedTo);
} else {
whereBuilder.Append("(\"enorderapprovallevel5\".\"assignedto\" IS NULL)");
}
whereBuilder.Append(" OR (");
if (qpenOrderApprovalLevel_EntraRoleId != 0) {
whereBuilder.Append("((\"enorderapprovallevel5\".\"entraroleid\" = @qpenOrderApprovalLevel_EntraRoleId) AND (\"enorderapprovallevel5\".\"entraroleid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpenOrderApprovalLevel_EntraRoleId", DbType.Int64, qpenOrderApprovalLevel_EntraRoleId);
} else {
whereBuilder.Append("(\"enorderapprovallevel5\".\"entraroleid\" IS NULL)");
}
whereBuilder.Append(" AND ");
if (qpreOrderMain_DivisionId != 0) {
whereBuilder.Append("((\"enordermain23\".\"divisionid\" = @qpreOrderMain_DivisionId) AND (\"enordermain23\".\"divisionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreOrderMain_DivisionId", DbType.Int64, qpreOrderMain_DivisionId);
} else {
whereBuilder.Append("(\"enordermain23\".\"divisionid\" IS NULL)");
}
whereBuilder.Append(")) AND ");
if (qpteOrderNumberFilter != "" && qpteOrderNumberFilter != "") {
whereBuilder.Append("(caseaccent_normalize(\"enordermain23\".\"ordernumber\" collate \"default\") like caseaccent_normalize((('%' || @qpteOrderNumberFilter) || '%') collate \"default\")) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpteOrderNumberFilter", DbType.String, qpteOrderNumberFilter);
}
if (qporOrderMain_OrderStatusId != BuiltInFunction.NullIdentifier()) {
if (qporOrderMain_OrderStatusId != 0) {
whereBuilder.Append("((\"enordermain23\".\"orderstatusid\" = @qporOrderMain_OrderStatusId) AND (\"enordermain23\".\"orderstatusid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderMain_OrderStatusId", DbType.Int32, qporOrderMain_OrderStatusId);
} else {
whereBuilder.Append("(\"enordermain23\".\"orderstatusid\" IS NULL)");
}
}
string whereBuilderString = whereBuilder.ToString();
if (whereBuilderString.EndsWith(" AND ")) {
whereBuilder.Remove(whereBuilderString.Length - 5, 5);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query HotfixOrderApproverReplaceAll.GetOrderApprovalLevelsByAssignedTo.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query HotfixOrderApproverReplaceAll.GetOrderApprovalLevelsByAssignedTo.List", cancellationToken: cancellationToken);
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

private static async Task<RC_77956dae907db5f208e8a848dc366336> datasetGetUserSubstituteReadDbAsync(RC_77956dae907db5f208e8a848dc366336 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENEntraRole.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
rec.ssENUserExtension.Read( r, ref index);
return rec;
}
// Query Function "GetUserSubstitute" 7gzgWvIKQkGd5Yoss8O9XQ of Action "HotfixOrderApproverReplaceAll"
public static async Task<(RL_f518d708e7bb15a03a65b75b9f603096,long)> datasetGetUserSubstitute(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("HotfixOrderApproverReplaceAll.GetUserSubstitute", "5ae00cee-0af2-4142-9de5-8a2cb3c3bd5d");
using var queryActivity = activitySource.CreateAggregateQueryActivity("HotfixOrderApproverReplaceAll.GetUserSubstitute", "5ae00cee-0af2-4142-9de5-8a2cb3c3bd5d", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.UI_IUQvqtkeuo2Ceci93KQ/NodesNotShownInESpaceTree.7gzgWvIKQkGd5Yoss8O9XQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enentrarole10\".\"rolename\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, \"enuser56\".\"name\" o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, \"enuser_extended_internal33\".\"entraroleid\" o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33");
fromBuilder.Append(" FROM ((({User} \"enuser56\" Left JOIN {User_Extended_Internal} \"enuser_extended_internal33\" ON (\"enuser56\".\"id\" = \"enuser_extended_internal33\".\"id\"))  Left JOIN {UserExtension} \"enuserextension31\" ON (\"enuser56\".\"id\" = \"enuserextension31\".\"id\"))  Left JOIN {EntraRole} \"enentrarole10\" ON (\"enuser_extended_internal33\".\"entraroleid\" = \"enentrarole10\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser56\".\"id\" = @qpusUser_Id) AND (\"enuser56\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser56\".\"id\" IS NULL)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query HotfixOrderApproverReplaceAll.GetUserSubstitute.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query HotfixOrderApproverReplaceAll.GetUserSubstitute.List", cancellationToken: cancellationToken);
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
// Query Function "GetUserOriginal" uA6Nckw3gUWZ5l46Hwwrxw of Action "HotfixOrderApproverReplaceAll"
public static async Task<(RL_f518d708e7bb15a03a65b75b9f603096,long)> datasetGetUserOriginal(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("HotfixOrderApproverReplaceAll.GetUserOriginal", "728d0eb8-374c-4581-99e6-5e3a1f0c2bc7");
using var queryActivity = activitySource.CreateAggregateQueryActivity("HotfixOrderApproverReplaceAll.GetUserOriginal", "728d0eb8-374c-4581-99e6-5e3a1f0c2bc7", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.UI_IUQvqtkeuo2Ceci93KQ/NodesNotShownInESpaceTree.uA6Nckw3gUWZ5l46Hwwrxw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enentrarole11\".\"id\" o0, \"enentrarole11\".\"rolename\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, \"enuser57\".\"name\" o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, \"enuser_extended_internal34\".\"regionid\" o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, \"enuser_extended_internal34\".\"entraroleid\" o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33");
fromBuilder.Append(" FROM ((({User} \"enuser57\" Left JOIN {User_Extended_Internal} \"enuser_extended_internal34\" ON (\"enuser57\".\"id\" = \"enuser_extended_internal34\".\"id\"))  Left JOIN {UserExtension} \"enuserextension32\" ON (\"enuser57\".\"id\" = \"enuserextension32\".\"id\"))  Left JOIN {EntraRole} \"enentrarole11\" ON (\"enuser_extended_internal34\".\"entraroleid\" = \"enentrarole11\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser57\".\"id\" = @qpusUser_Id) AND (\"enuser57\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser57\".\"id\" IS NULL)");
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
opt[3] = new BitArray(new bool[] {true, true, true, false, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query HotfixOrderApproverReplaceAll.GetUserOriginal.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query HotfixOrderApproverReplaceAll.GetUserOriginal.List", cancellationToken: cancellationToken);
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



}


}
