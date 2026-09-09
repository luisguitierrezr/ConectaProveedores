namespace ssConectaProveedores;

public partial class Actions {
public class lcvAssignOrderToUser : VarsBag {
public long inParami_OrderId;
public long inParami_OrderApprovalLevelId;
public string inParami_UserId;
public Actions.lcoOrderApprovalCreateOrUpdate resOrderApprovalCreateOrUpdate =  new Actions.lcoOrderApprovalCreateOrUpdate();
public Actions.lcoOrderApprovalLevelCreateOrUpdate resCurrOrderApprovalLevelCU =  new Actions.lcoOrderApprovalLevelCreateOrUpdate();
public RL_ee0c9b1586585bb225d3aea45637d365 queryResGetNextOrderApprovalLevel_outParamList = new RL_ee0c9b1586585bb225d3aea45637d365();
public long queryResGetNextOrderApprovalLevel_outParamCount = 0L;

public Actions.lcoOrderApprovalLevelCreateOrUpdate resNextOrderApprovalLevelCU =  new Actions.lcoOrderApprovalLevelCreateOrUpdate();
public RL_8430333e95ceffc00def96d8abb01f75 queryResGetUserById_outParamList = new RL_8430333e95ceffc00def96d8abb01f75();
public long queryResGetUserById_outParamCount = 0L;

public Actions.lcoOrderLogAdd resOrderLogAdd =  new Actions.lcoOrderLogAdd();
public Actions.lcoGetUserEntraRoleId resGetUserEntraRoleId =  new Actions.lcoGetUserEntraRoleId();
public Actions.lcoOrderMainCreateOrUpdate resOrderMainCreateOrUpdate =  new Actions.lcoOrderMainCreateOrUpdate();
public Actions.lcoOrderLogAdd resOrderLogAdd2 =  new Actions.lcoOrderLogAdd();
public RL_466c605dd07558761818d5a27c59c2b8 queryResGetCurrentOrderApprovalLevel_outParamList = new RL_466c605dd07558761818d5a27c59c2b8();
public long queryResGetCurrentOrderApprovalLevel_outParamCount = 0L;

public lcvAssignOrderToUser(long inParami_OrderId, long inParami_OrderApprovalLevelId, string inParami_UserId) {
this.inParami_OrderId = inParami_OrderId;
this.inParami_OrderApprovalLevelId = inParami_OrderApprovalLevelId;
this.inParami_UserId = inParami_UserId;
}
}
public class lcoAssignOrderToUser : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public lcoAssignOrderToUser() {
}
}
/// <summary>
/// Action <code>AssignOrderToUser</code> that represents the Service Studio action
///  <code>AssignOrderToUser</code> <p> Description: Server action to assign an order to someone.</p>
/// </summary>
public static async Task<ST_046fb53ebbe142526d95e87ef1ae9711Structure> ActionAssignOrderToUser(IRequestContext requestContext,long inParami_OrderId,long inParami_OrderApprovalLevelId,string inParami_UserId,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
lcoAssignOrderToUser result = new lcoAssignOrderToUser();
lcvAssignOrderToUser localVars = new lcvAssignOrderToUser(inParami_OrderId, inParami_OrderApprovalLevelId, inParami_UserId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("AssignOrderToUser", "f34d8387-e740-42d7-82e3-97de656062a8"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("AssignOrderToUser", "f34d8387-e740-42d7-82e3-97de656062a8", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Null id?
if(((localVars.inParami_OrderId==Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// RaiseError EntityException
throw new Ex_EntityExceptionUserException (AppUtils.GetStringResource("sSex4Qmoh06NGQQ+64d_Pg#Message.48399450.1", "Identifier is mandatory"));

} else {
// Query datasetGetCurrentOrderApprovalLevel
cancellationToken.ThrowIfCancellationRequested();
int datasetGetCurrentOrderApprovalLevel_maxRecords = 1;
if (datasetGetCurrentOrderApprovalLevel_maxRecords < 1) datasetGetCurrentOrderApprovalLevel_maxRecords = 1;
int datasetGetCurrentOrderApprovalLevel_startIndex = 0;(localVars.queryResGetCurrentOrderApprovalLevel_outParamList,localVars.queryResGetCurrentOrderApprovalLevel_outParamCount) = await FuncActionAssignOrderToUser.datasetGetCurrentOrderApprovalLevel(requestContext,datasetGetCurrentOrderApprovalLevel_maxRecords,datasetGetCurrentOrderApprovalLevel_startIndex,IterationMultiplicity.Never,localVars.inParami_OrderApprovalLevelId,cancellationToken);

// not in ToComplement?
if(((localVars.queryResGetCurrentOrderApprovalLevel_outParamList.CurrentRec.ssENOrderApprovalLevel.ssApprovalStatusId!=(ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("bxcfUQnAU0CWvUsA+ZfAjw"))).ssId))) {
// RaiseError EntityException
throw new Ex_EntityExceptionUserException (AppUtils.GetStringResource("4VfiffQJk0Sx0s9lPgqO9Q#Message.-387704703.1", "Order cannot be assigned!"));

} else {
// Query datasetGetNextOrderApprovalLevel
cancellationToken.ThrowIfCancellationRequested();
int datasetGetNextOrderApprovalLevel_maxRecords = 0;
int datasetGetNextOrderApprovalLevel_startIndex = 0;(localVars.queryResGetNextOrderApprovalLevel_outParamList,localVars.queryResGetNextOrderApprovalLevel_outParamCount) = await FuncActionAssignOrderToUser.datasetGetNextOrderApprovalLevel(requestContext,datasetGetNextOrderApprovalLevel_maxRecords,datasetGetNextOrderApprovalLevel_startIndex,IterationMultiplicity.Never,localVars.queryResGetCurrentOrderApprovalLevel_outParamList.CurrentRec.ssENOrderApprovalLevel.ssLevelNumber,localVars.queryResGetCurrentOrderApprovalLevel_outParamList.CurrentRec.ssENOrderApprovalLevel.ssOrderApprovalId,cancellationToken);

// CurrentOrderApprovalLevel
// GetCurrentOrderApprovalLevel.List.Current.OrderApprovalLevel.ApprovalStatusId = Assigned
localVars.queryResGetCurrentOrderApprovalLevel_outParamList.CurrentRec.ssENOrderApprovalLevel.ssApprovalStatusId = (ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("85A3EYx6OkWpq0CAyB7XJw"))).ssId;

// GetCurrentOrderApprovalLevel.List.Current.OrderApprovalLevel.ApprovedBy = GetUserId
localVars.queryResGetCurrentOrderApprovalLevel_outParamList.CurrentRec.ssENOrderApprovalLevel.ssApprovedBy = BuiltInFunction.GetUserId ();

// GetCurrentOrderApprovalLevel.List.Current.OrderApprovalLevel.ApprovedOn = CurrDateTime
localVars.queryResGetCurrentOrderApprovalLevel_outParamList.CurrentRec.ssENOrderApprovalLevel.ssApprovedOn = BuiltInFunction.CurrDateTime ();

// GetCurrentOrderApprovalLevel.List.Current.OrderApprovalLevel.AssignedTo = If
localVars.queryResGetCurrentOrderApprovalLevel_outParamList.CurrentRec.ssENOrderApprovalLevel.ssAssignedTo = (((localVars.queryResGetCurrentOrderApprovalLevel_outParamList.CurrentRec.ssENOrderApprovalLevel.ssAssignedTo!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.queryResGetCurrentOrderApprovalLevel_outParamList.CurrentRec.ssENOrderApprovalLevel.ssAssignedTo) : (BuiltInFunction.GetUserId ()));
if(((localVars.inParami_UserId==BuiltInFunction.GetUserId ()))) {
// GetUserEntraRoleId
localVars.resGetUserEntraRoleId.outParamo_EntraRoleId = await Actions.ActionGetUserEntraRoleId(requestContext,localVars.inParami_UserId,cancellationToken);

// NextOrderApprovalLevel_EntraRoleId
// GetNextOrderApprovalLevel.List.Current.OrderApprovalLevel.EntraRoleId = GetUserEntraRoleId.o_EntraRoleId
localVars.queryResGetNextOrderApprovalLevel_outParamList.CurrentRec.ssENOrderApprovalLevel.ssEntraRoleId = localVars.resGetUserEntraRoleId.outParamo_EntraRoleId;
}

// GetCurrentOrderApprovalLevel.List.Current.OrderApproval.CurrentLevel = GetNextOrderApprovalLevel.List.Current.OrderApprovalLevel.LevelNumber
localVars.queryResGetCurrentOrderApprovalLevel_outParamList.CurrentRec.ssENOrderApproval.ssCurrentLevel = localVars.queryResGetNextOrderApprovalLevel_outParamList.CurrentRec.ssENOrderApprovalLevel.ssLevelNumber;

// GetNextOrderApprovalLevel.List.Current.OrderApprovalLevel.AssignedTo = i_UserId
localVars.queryResGetNextOrderApprovalLevel_outParamList.CurrentRec.ssENOrderApprovalLevel.ssAssignedTo = localVars.inParami_UserId;

// GetNextOrderApprovalLevel.List.Current.OrderApprovalLevel.AssignedOn = CurrDateTime
localVars.queryResGetNextOrderApprovalLevel_outParamList.CurrentRec.ssENOrderApprovalLevel.ssAssignedOn = BuiltInFunction.CurrDateTime ();

// GetNextOrderApprovalLevel.List.Current.OrderApprovalLevel.ApprovalStatusId = InInformationCompletion
localVars.queryResGetNextOrderApprovalLevel_outParamList.CurrentRec.ssENOrderApprovalLevel.ssApprovalStatusId = (ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("2bH5k51Eqk+iM0PUO3cbyg"))).ssId;

// GetNextOrderApprovalLevel.List.Current.OrderApprovalLevel.IsComplement = True
localVars.queryResGetNextOrderApprovalLevel_outParamList.CurrentRec.ssENOrderApprovalLevel.ssIsComplement = true;

// GetCurrentOrderApprovalLevel.List.Current.OrderMain.OrderStatusId = InInformationCompletion
localVars.queryResGetCurrentOrderApprovalLevel_outParamList.CurrentRec.ssENOrderMain.ssOrderStatusId = (ENOrderStatusEntity.GetRecordByKey(ObjectKey.Parse("M7Q91hYooUaA8nlePjiPnQ"))).ssId;
// CurrOrderApprovalLevelCU
localVars.resCurrOrderApprovalLevelCU.outParamId = await Actions.ActionOrderApprovalLevelCreateOrUpdate(requestContext,localVars.queryResGetCurrentOrderApprovalLevel_outParamList.CurrentRec.ssENOrderApprovalLevel,cancellationToken);

// NextOrderApprovalLevelCU
localVars.resNextOrderApprovalLevelCU.outParamId = await Actions.ActionOrderApprovalLevelCreateOrUpdate(requestContext,localVars.queryResGetNextOrderApprovalLevel_outParamList.CurrentRec.ssENOrderApprovalLevel,cancellationToken);

// Query datasetGetUserById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserById_maxRecords = 1;
if (datasetGetUserById_maxRecords < 1) datasetGetUserById_maxRecords = 1;
int datasetGetUserById_startIndex = 0;(localVars.queryResGetUserById_outParamList,localVars.queryResGetUserById_outParamCount) = await FuncActionAssignOrderToUser.datasetGetUserById(requestContext,datasetGetUserById_maxRecords,datasetGetUserById_startIndex,IterationMultiplicity.Never,localVars.inParami_UserId,cancellationToken);

// OrderLogAdd
localVars.resOrderLogAdd.outParamId = await Actions.ActionOrderLogAdd(requestContext,new EN_a8e484428097204171df8a1feecb2534EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssOrderId = localVars.inParami_OrderId, ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssMessage = (((((((AppUtils.GetStringResource("4058MMWwfUqDkavc1+idbA#Value.76453678.1", "Order")+" ")+(await Functions.ssGetOrderMain(requestContext,localVars.inParami_OrderId,cancellationToken)).ssENOrderMain.ssOrderNumber)+" ")+AppUtils.GetStringResource("4058MMWwfUqDkavc1+idbA#Value.-588554410.1", "was assigned to"))+": ")+localVars.queryResGetUserById_outParamList.CurrentRec.ssENUser.ssName)+".") },cancellationToken);

// OrderApprovalCreateOrUpdate
localVars.resOrderApprovalCreateOrUpdate.outParamId = await Actions.ActionOrderApprovalCreateOrUpdate(requestContext,localVars.queryResGetCurrentOrderApprovalLevel_outParamList.CurrentRec.ssENOrderApproval,cancellationToken);

// OrderMainCreateOrUpdate
(localVars.resOrderMainCreateOrUpdate.outParamId,localVars.resOrderMainCreateOrUpdate.outParamHasSuccess,localVars.resOrderMainCreateOrUpdate.outParamErrorMessage,localVars.resOrderMainCreateOrUpdate.outParamSource_Out) = await Actions.ActionOrderMainCreateOrUpdate(requestContext,localVars.queryResGetCurrentOrderApprovalLevel_outParamList.CurrentRec.ssENOrderMain,cancellationToken);

// OrderLogAdd2
localVars.resOrderLogAdd2.outParamId = await Actions.ActionOrderLogAdd(requestContext,new EN_a8e484428097204171df8a1feecb2534EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssOrderId = localVars.queryResGetCurrentOrderApprovalLevel_outParamList.CurrentRec.ssENOrderMain.ssId, ssCreatedOn = BuiltInFunction.CurrDateTime (), ssMessage = ((((AppUtils.GetStringResource("jelmXR4rSkiAr6_vSFWZvg#Value.76453678.1", "Order")+" ")+localVars.queryResGetCurrentOrderApprovalLevel_outParamList.CurrentRec.ssENOrderMain.ssOrderNumber)+" ")+AppUtils.GetStringResource("jelmXR4rSkiAr6_vSFWZvg#Value.1839106449.1", "updated to status In Information Completion.")) },cancellationToken);

// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
// SendOrderFirstApproverEmail
await Actions.ActionSendOrderFirstApproverEmail(requestContext,localVars.inParami_OrderId,localVars.inParami_UserId,cancellationToken);

}

}

} //close CreateActionActivity using block
} // try

finally {
outParamo_Output = result.outParamo_Output;
} // inner-finally
RETURN_STATEMENT:
return outParamo_Output;
}

public static class FuncActionAssignOrderToUser {

// Query Function "GetNextOrderApprovalLevel" eWhBaqSMIkWYeS920GPEEA of Action "AssignOrderToUser"
public static async Task<(RL_ee0c9b1586585bb225d3aea45637d365,long)> datasetGetNextOrderApprovalLevel(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,int qpinLevelNumber,long qporOrderApprovalId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("AssignOrderToUser.GetNextOrderApprovalLevel", "6a416879-8ca4-4522-9879-2f76d063c410");
using var queryActivity = activitySource.CreateAggregateQueryActivity("AssignOrderToUser.GetNextOrderApprovalLevel", "6a416879-8ca4-4522-9879-2f76d063c410", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.h4NN80Dn10KC45feZWBiqA/NodesNotShownInESpaceTree.eWhBaqSMIkWYeS920GPEEA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enorderapprovallevel15\".\"id\" o0, \"enorderapprovallevel15\".\"orderapprovalid\" o1, \"enorderapprovallevel15\".\"levelnumber\" o2, \"enorderapprovallevel15\".\"entraroleid\" o3, \"enorderapprovallevel15\".\"assignedto\" o4, \"enorderapprovallevel15\".\"assignedon\" o5, \"enorderapprovallevel15\".\"approvalstatusid\" o6, \"enorderapprovallevel15\".\"approvedby\" o7, \"enorderapprovallevel15\".\"approvedon\" o8, \"enorderapprovallevel15\".\"rejectedby\" o9, \"enorderapprovallevel15\".\"rejectedon\" o10, \"enorderapprovallevel15\".\"iscomplement\" o11, \"enorderapprovallevel15\".\"isreassigned\" o12, \"enorderapprovallevel15\".\"issubstitutefor\" o13, \"enorderapprovallevel15\".\"tomodifyby\" o14, \"enorderapprovallevel15\".\"tomodifyon\" o15, \"enorderapprovallevel15\".\"wascanceledby\" o16");
fromBuilder.Append(" FROM {OrderApprovalLevel} \"enorderapprovallevel15\"");
whereBuilder.Append(" WHERE ");
if (qporOrderApprovalId != 0) {
whereBuilder.Append("((\"enorderapprovallevel15\".\"orderapprovalid\" = @qporOrderApprovalId) AND (\"enorderapprovallevel15\".\"orderapprovalid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderApprovalId", DbType.Int64, qporOrderApprovalId);
} else {
whereBuilder.Append("(\"enorderapprovallevel15\".\"orderapprovalid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enorderapprovallevel15\".\"levelnumber\" > @qpinLevelNumber)");
orderByBuilder.Append(" ORDER BY \"enorderapprovallevel15\".\"levelnumber\" ASC ");
sqlCmd.CreateParameterWithoutReplacements("@qpinLevelNumber", DbType.Int32, qpinLevelNumber);
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
RL_ee0c9b1586585bb225d3aea45637d365 outParamList = new RL_ee0c9b1586585bb225d3aea45637d365();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query AssignOrderToUser.GetNextOrderApprovalLevel.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_ee0c9b1586585bb225d3aea45637d365 _tmp = new RL_ee0c9b1586585bb225d3aea45637d365();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query AssignOrderToUser.GetNextOrderApprovalLevel.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_ee0c9b1586585bb225d3aea45637d365)_tmp;
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

// Query Function "GetUserById" m6YakB9j5EijFxC6mwGsuQ of Action "AssignOrderToUser"
public static async Task<(RL_8430333e95ceffc00def96d8abb01f75,long)> datasetGetUserById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("AssignOrderToUser.GetUserById", "901aa69b-631f-48e4-a317-10ba9b01acb9");
using var queryActivity = activitySource.CreateAggregateQueryActivity("AssignOrderToUser.GetUserById", "901aa69b-631f-48e4-a317-10ba9b01acb9", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.h4NN80Dn10KC45feZWBiqA/NodesNotShownInESpaceTree.m6YakB9j5EijFxC6mwGsuQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enuser134\".\"name\" o1, NULL o2, NULL o3, NULL o4");
fromBuilder.Append(" FROM {User} \"enuser134\"");
whereBuilder.Append(" WHERE ");
if ((qpusId.Trim()!="")) {
whereBuilder.Append("((\"enuser134\".\"id\" = @qpusId) AND (\"enuser134\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusId", DbType.String, qpusId);
} else {
whereBuilder.Append("(\"enuser134\".\"id\" IS NULL)");
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
RL_8430333e95ceffc00def96d8abb01f75 outParamList = new RL_8430333e95ceffc00def96d8abb01f75();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, false, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query AssignOrderToUser.GetUserById.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query AssignOrderToUser.GetUserById.List", cancellationToken: cancellationToken);
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

private static async Task<RC_7074703fd377ca40d733f2d5d8d3fde2> datasetGetCurrentOrderApprovalLevelReadDbAsync(RC_7074703fd377ca40d733f2d5d8d3fde2 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENOrderApproval.Read( r, ref index);
rec.ssENOrderApprovalLevel.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
return rec;
}
// Query Function "GetCurrentOrderApprovalLevel" R6vO39AK1k2VRpU5OedLRQ of Action "AssignOrderToUser"
public static async Task<(RL_466c605dd07558761818d5a27c59c2b8,long)> datasetGetCurrentOrderApprovalLevel(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderApprovalLevel_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("AssignOrderToUser.GetCurrentOrderApprovalLevel", "dfceab47-0ad0-4dd6-9546-953939e74b45");
using var queryActivity = activitySource.CreateAggregateQueryActivity("AssignOrderToUser.GetCurrentOrderApprovalLevel", "dfceab47-0ad0-4dd6-9546-953939e74b45", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.h4NN80Dn10KC45feZWBiqA/NodesNotShownInESpaceTree.R6vO39AK1k2VRpU5OedLRQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enorderapproval17\".\"id\" o0, \"enorderapproval17\".\"orderid\" o1, \"enorderapproval17\".\"currentlevel\" o2, \"enorderapproval17\".\"maxlevel\" o3, \"enorderapproval17\".\"startedon\" o4, \"enorderapproval17\".\"finishedon\" o5, \"enorderapproval17\".\"lastapproverpuestodelgerente\" o6, \"enorderapproval17\".\"lastapproverpuestodeljefe\" o7, \"enorderapprovallevel16\".\"id\" o8, \"enorderapprovallevel16\".\"orderapprovalid\" o9, \"enorderapprovallevel16\".\"levelnumber\" o10, \"enorderapprovallevel16\".\"entraroleid\" o11, \"enorderapprovallevel16\".\"assignedto\" o12, \"enorderapprovallevel16\".\"assignedon\" o13, \"enorderapprovallevel16\".\"approvalstatusid\" o14, \"enorderapprovallevel16\".\"approvedby\" o15, \"enorderapprovallevel16\".\"approvedon\" o16, \"enorderapprovallevel16\".\"rejectedby\" o17, \"enorderapprovallevel16\".\"rejectedon\" o18, \"enorderapprovallevel16\".\"iscomplement\" o19, \"enorderapprovallevel16\".\"isreassigned\" o20, \"enorderapprovallevel16\".\"issubstitutefor\" o21, \"enorderapprovallevel16\".\"tomodifyby\" o22, \"enorderapprovallevel16\".\"tomodifyon\" o23, \"enorderapprovallevel16\".\"wascanceledby\" o24, \"enordermain62\".\"id\" o25, \"enordermain62\".\"ordernumber\" o26, \"enordermain62\".\"orderdate\" o27, \"enordermain62\".\"orderstatusid\" o28, \"enordermain62\".\"previousorderstatusid\" o29, \"enordermain62\".\"assignmentcode\" o30, \"enordermain62\".\"supplierid\" o31, \"enordermain62\".\"companyid\" o32, \"enordermain62\".\"documenttypeid\" o33, \"enordermain62\".\"currencyid\" o34, \"enordermain62\".\"telceldirectionid\" o35, \"enordermain62\".\"procurementgroup\" o36, \"enordermain62\".\"creatorsapnumber\" o37, \"enordermain62\".\"creatorsapname\" o38, \"enordermain62\".\"country\" o39, \"enordermain62\".\"isdeleted\" o40, \"enordermain62\".\"isreleased\" o41, trim_scale(\"enordermain62\".\"exchangerate\"::numeric) o42, \"enordermain62\".\"sustainabilitycategory\" o43, \"enordermain62\".\"sustainabilitysubcategory\" o44, trim_scale(\"enordermain62\".\"totalamount\"::numeric) o45, \"enordermain62\".\"fromcosmoz\" o46, \"enordermain62\".\"regionid\" o47, \"enordermain62\".\"divisionid\" o48, \"enordermain62\".\"applicant\" o49, \"enordermain62\".\"createdby\" o50, \"enordermain62\".\"createdon\" o51, \"enordermain62\".\"updatedby\" o52, \"enordermain62\".\"updatedon\" o53");
fromBuilder.Append(" FROM (({OrderApprovalLevel} \"enorderapprovallevel16\" Left JOIN {OrderApproval} \"enorderapproval17\" ON (\"enorderapprovallevel16\".\"orderapprovalid\" = \"enorderapproval17\".\"id\"))  Left JOIN {OrderMain} \"enordermain62\" ON (\"enorderapproval17\".\"orderid\" = \"enordermain62\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qporOrderApprovalLevel_Id != 0) {
whereBuilder.Append("((\"enorderapprovallevel16\".\"id\" = @qporOrderApprovalLevel_Id) AND (\"enorderapprovallevel16\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderApprovalLevel_Id", DbType.Int64, qporOrderApprovalLevel_Id);
} else {
whereBuilder.Append("(\"enorderapprovallevel16\".\"id\" IS NULL)");
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
RL_466c605dd07558761818d5a27c59c2b8 outParamList = new RL_466c605dd07558761818d5a27c59c2b8();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetCurrentOrderApprovalLevelReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[2] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query AssignOrderToUser.GetCurrentOrderApprovalLevel.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_466c605dd07558761818d5a27c59c2b8 _tmp = new RL_466c605dd07558761818d5a27c59c2b8();
_tmp.AlternateReadDbMethodAsync = datasetGetCurrentOrderApprovalLevelReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query AssignOrderToUser.GetCurrentOrderApprovalLevel.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_466c605dd07558761818d5a27c59c2b8)_tmp;
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
