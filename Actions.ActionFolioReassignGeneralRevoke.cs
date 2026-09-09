namespace ssConectaProveedores;

public partial class Actions {
public class lcvFolioReassignGeneralRevoke : VarsBag {
public long inParami_ReassignmentId;
public Actions.lcoReassignmentsCreateOrUpdate resReassignmentsCreateOrUpdate =  new Actions.lcoReassignmentsCreateOrUpdate();
public RL_ae9182bb38290e8d92b0cbd2d4f71569 queryResGetFolioApprovalLevelById_outParamList = new RL_ae9182bb38290e8d92b0cbd2d4f71569();
public long queryResGetFolioApprovalLevelById_outParamCount = 0L;

public RL_a37f5f153582e24adaea3ae8b54b3101 queryResGetOriginalUserById_outParamList = new RL_a37f5f153582e24adaea3ae8b54b3101();
public long queryResGetOriginalUserById_outParamCount = 0L;

public Actions.lcoFolioLogAdd resFolioLogAdd =  new Actions.lcoFolioLogAdd();
public RL_462b16c1ddedb19ce2dbad5e94ccb4ef queryResGetReassignmentById_outParamList = new RL_462b16c1ddedb19ce2dbad5e94ccb4ef();
public long queryResGetReassignmentById_outParamCount = 0L;

public Actions.lcoFolioApprovalLevelCreateOrUpdate resFolioApprovalLevelCreateOrUpdate =  new Actions.lcoFolioApprovalLevelCreateOrUpdate();
public RL_a37f5f153582e24adaea3ae8b54b3101 queryResGetRevokedUserById_outParamList = new RL_a37f5f153582e24adaea3ae8b54b3101();
public long queryResGetRevokedUserById_outParamCount = 0L;

public lcvFolioReassignGeneralRevoke(long inParami_ReassignmentId) {
this.inParami_ReassignmentId = inParami_ReassignmentId;
}
}
public class lcoFolioReassignGeneralRevoke : VarsBag {
public string outParamErrorMessage = "";

public lcoFolioReassignGeneralRevoke() {
}
}
/// <summary>
/// Action <code>FolioReassignGeneralRevoke</code> that represents the Service Studio action
///  <code>FolioReassignGeneralRevoke</code> <p> Description: </p>
/// </summary>
public static async Task<string> ActionFolioReassignGeneralRevoke(IRequestContext requestContext,long inParami_ReassignmentId,CancellationToken cancellationToken) {
string outParamErrorMessage = default;
lcoFolioReassignGeneralRevoke result = new lcoFolioReassignGeneralRevoke();
lcvFolioReassignGeneralRevoke localVars = new lcvFolioReassignGeneralRevoke(inParami_ReassignmentId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("FolioReassignGeneralRevoke", "cd8a9fd9-3f04-4102-aaad-6e35232b86f3"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("FolioReassignGeneralRevoke", "cd8a9fd9-3f04-4102-aaad-6e35232b86f3", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetReassignmentById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetReassignmentById_maxRecords = 1;
if (datasetGetReassignmentById_maxRecords < 1) datasetGetReassignmentById_maxRecords = 1;
int datasetGetReassignmentById_startIndex = 0;(localVars.queryResGetReassignmentById_outParamList,localVars.queryResGetReassignmentById_outParamCount) = await FuncActionFolioReassignGeneralRevoke.datasetGetReassignmentById(requestContext,datasetGetReassignmentById_maxRecords,datasetGetReassignmentById_startIndex,IterationMultiplicity.Never,localVars.inParami_ReassignmentId,cancellationToken);

// Empty?
if((localVars.queryResGetReassignmentById_outParamList.Empty)) {
// ErrorMessage = "Reassignment not found!"
result.outParamErrorMessage=AppUtils.GetStringResource("GhuO_UoZH0u9XclaIvBW_g#Value.-1485960820.1", "Reassignment not found!");
} else {
// Query datasetGetFolioApprovalLevelById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioApprovalLevelById_maxRecords = 1;
if (datasetGetFolioApprovalLevelById_maxRecords < 1) datasetGetFolioApprovalLevelById_maxRecords = 1;
int datasetGetFolioApprovalLevelById_startIndex = 0;(localVars.queryResGetFolioApprovalLevelById_outParamList,localVars.queryResGetFolioApprovalLevelById_outParamCount) = await FuncActionFolioReassignGeneralRevoke.datasetGetFolioApprovalLevelById(requestContext,datasetGetFolioApprovalLevelById_maxRecords,datasetGetFolioApprovalLevelById_startIndex,IterationMultiplicity.Never,localVars.queryResGetReassignmentById_outParamList.CurrentRec.ssENReassignments.ssFolioApprovalLevelId,cancellationToken);

// Query datasetGetOriginalUserById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOriginalUserById_maxRecords = 1;
if (datasetGetOriginalUserById_maxRecords < 1) datasetGetOriginalUserById_maxRecords = 1;
int datasetGetOriginalUserById_startIndex = 0;(localVars.queryResGetOriginalUserById_outParamList,localVars.queryResGetOriginalUserById_outParamCount) = await FuncActionFolioReassignGeneralRevoke.datasetGetOriginalUserById(requestContext,datasetGetOriginalUserById_maxRecords,datasetGetOriginalUserById_startIndex,IterationMultiplicity.Never,localVars.queryResGetReassignmentById_outParamList.CurrentRec.ssENReassignments.ssSourceUserId,cancellationToken);

// Query datasetGetRevokedUserById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRevokedUserById_maxRecords = 1;
if (datasetGetRevokedUserById_maxRecords < 1) datasetGetRevokedUserById_maxRecords = 1;
int datasetGetRevokedUserById_startIndex = 0;(localVars.queryResGetRevokedUserById_outParamList,localVars.queryResGetRevokedUserById_outParamCount) = await FuncActionFolioReassignGeneralRevoke.datasetGetRevokedUserById(requestContext,datasetGetRevokedUserById_maxRecords,datasetGetRevokedUserById_startIndex,IterationMultiplicity.Never,localVars.queryResGetReassignmentById_outParamList.CurrentRec.ssENReassignments.ssTargetUserId,cancellationToken);

// Approval status not allowed for revoke?
if((((localVars.queryResGetFolioApprovalLevelById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssApprovalStatusId!=(ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId)&&(localVars.queryResGetFolioApprovalLevelById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssApprovalStatusId!=(ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("RvhtMOVzUke_jX9z3pm9HA"))).ssId)))) {
// ErrorMessage = "This reassignment cannot be revoked!"
result.outParamErrorMessage=AppUtils.GetStringResource("vm2v_1TwTEy+lDG3Rb05vg#Value.-1645093279.1", "This reassignment cannot be revoked!");
} else {
// FolioApprovalLevel
// GetFolioApprovalLevelById.List.Current.FolioApprovalLevel.IsReassigned = False
localVars.queryResGetFolioApprovalLevelById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssIsReassigned = false;

// GetFolioApprovalLevelById.List.Current.FolioApprovalLevel.IsSubstituteFor = NullTextIdentifier
localVars.queryResGetFolioApprovalLevelById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssIsSubstituteFor = BuiltInFunction.NullTextIdentifier ();

// GetFolioApprovalLevelById.List.Current.FolioApprovalLevel.AssignedTo = If
localVars.queryResGetFolioApprovalLevelById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssAssignedTo = (((localVars.queryResGetFolioApprovalLevelById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssAssignedTo!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.queryResGetReassignmentById_outParamList.CurrentRec.ssENReassignments.ssSourceUserId) : (BuiltInFunction.NullTextIdentifier ()));

// GetFolioApprovalLevelById.List.Current.FolioApprovalLevel.EntraJobTitle = If
localVars.queryResGetFolioApprovalLevelById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssEntraJobTitle = (((localVars.queryResGetFolioApprovalLevelById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssEntraJobTitle!="")) ? (localVars.queryResGetOriginalUserById_outParamList.CurrentRec.ssENEntraRole.ssRoleName) : (""));

// GetFolioApprovalLevelById.List.Current.FolioApprovalLevel.EntraRoleId = If
localVars.queryResGetFolioApprovalLevelById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssEntraRoleId = (((localVars.queryResGetFolioApprovalLevelById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssEntraRoleId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ()))) ? (localVars.queryResGetOriginalUserById_outParamList.CurrentRec.ssENUser_Extended_Internal.ssEntraRoleId) : (Convert.ToInt64(BuiltInFunction.NullIdentifier ())));
// FolioApprovalLevelCreateOrUpdate
localVars.resFolioApprovalLevelCreateOrUpdate.outParamId = await Actions.ActionFolioApprovalLevelCreateOrUpdate(requestContext,localVars.queryResGetFolioApprovalLevelById_outParamList.CurrentRec.ssENFolioApprovalLevel,cancellationToken);

// FolioLogAdd
localVars.resFolioLogAdd.outParamId = await Actions.ActionFolioLogAdd(requestContext,new EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssFolioId = localVars.queryResGetFolioApprovalLevelById_outParamList.CurrentRec.ssENFolio.ssId, ssMessage = (((localVars.queryResGetFolioApprovalLevelById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssAssignedTo!=BuiltInFunction.NullTextIdentifier ())) ? (((((AppUtils.GetStringResource("Lu5oqESDW0Wfb_9lH1ta5g#Value.1483110428.1", "Reassignment revoked:")+" ")+localVars.queryResGetRevokedUserById_outParamList.CurrentRec.ssENUser.ssName)+" -> ")+localVars.queryResGetOriginalUserById_outParamList.CurrentRec.ssENUser.ssName)) : (((((AppUtils.GetStringResource("Lu5oqESDW0Wfb_9lH1ta5g#Value.1483110428.2", "Reassignment revoked:")+" ")+localVars.queryResGetRevokedUserById_outParamList.CurrentRec.ssENEntraRole.ssRoleName)+" -> ")+localVars.queryResGetOriginalUserById_outParamList.CurrentRec.ssENEntraRole.ssRoleName))), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssIsForSupplier = false },cancellationToken);

// GetReassignmentById.List.Current.Reassignments.RevokedBy = GetUserId
localVars.queryResGetReassignmentById_outParamList.CurrentRec.ssENReassignments.ssRevokedBy = BuiltInFunction.GetUserId ();

// GetReassignmentById.List.Current.Reassignments.RevokedOn = CurrDateTime
localVars.queryResGetReassignmentById_outParamList.CurrentRec.ssENReassignments.ssRevokedOn = BuiltInFunction.CurrDateTime ();
// ReassignmentsCreateOrUpdate
localVars.resReassignmentsCreateOrUpdate.outParamId = await Actions.ActionReassignmentsCreateOrUpdate(requestContext,localVars.queryResGetReassignmentById_outParamList.CurrentRec.ssENReassignments,cancellationToken);

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

public static class FuncActionFolioReassignGeneralRevoke {

private static async Task<RC_1b390f8e281aa018cfe8a81d34cdb757> datasetGetFolioApprovalLevelByIdReadDbAsync(RC_1b390f8e281aa018cfe8a81d34cdb757 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFolio.Read( r, ref index);
rec.ssENFolioApproval.Read( r, ref index);
rec.ssENFolioApprovalLevel.Read( r, ref index);
return rec;
}
// Query Function "GetFolioApprovalLevelById" wRl5GDykX06KGN6JmfP+nw of Action "FolioReassignGeneralRevoke"
public static async Task<(RL_ae9182bb38290e8d92b0cbd2d4f71569,long)> datasetGetFolioApprovalLevelById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolioApprovalLevel_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("FolioReassignGeneralRevoke.GetFolioApprovalLevelById", "187919c1-a43c-4e5f-8a18-de8999f3fe9f");
using var queryActivity = activitySource.CreateAggregateQueryActivity("FolioReassignGeneralRevoke.GetFolioApprovalLevelById", "187919c1-a43c-4e5f-8a18-de8999f3fe9f", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.2Z+KzQQ_AkGqrW41IyuG8w/NodesNotShownInESpaceTree.wRl5GDykX06KGN6JmfP+nw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enfolio52\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, \"enfolioapprovallevel26\".\"id\" o30, \"enfolioapprovallevel26\".\"folioapprovalid\" o31, \"enfolioapprovallevel26\".\"levelnumber\" o32, \"enfolioapprovallevel26\".\"applicationroleid\" o33, \"enfolioapprovallevel26\".\"entrajobtitle\" o34, \"enfolioapprovallevel26\".\"entraroleid\" o35, \"enfolioapprovallevel26\".\"departmentid\" o36, \"enfolioapprovallevel26\".\"assignedto\" o37, \"enfolioapprovallevel26\".\"approvalstatusid\" o38, \"enfolioapprovallevel26\".\"ismandatory\" o39, \"enfolioapprovallevel26\".\"isreassigned\" o40, \"enfolioapprovallevel26\".\"approvedby\" o41, \"enfolioapprovallevel26\".\"approvedon\" o42, \"enfolioapprovallevel26\".\"canceledby\" o43, \"enfolioapprovallevel26\".\"canceledon\" o44, \"enfolioapprovallevel26\".\"rejectedby\" o45, \"enfolioapprovallevel26\".\"rejectedon\" o46, \"enfolioapprovallevel26\".\"issubstitutefor\" o47, \"enfolioapprovallevel26\".\"rejectreason\" o48, \"enfolioapprovallevel26\".\"isinvoiceapproval\" o49");
fromBuilder.Append(" FROM (({FolioApprovalLevel} \"enfolioapprovallevel26\" Left JOIN {FolioApproval} \"enfolioapproval29\" ON (\"enfolioapprovallevel26\".\"folioapprovalid\" = \"enfolioapproval29\".\"id\"))  Left JOIN {Folio} \"enfolio52\" ON (\"enfolioapproval29\".\"folioid\" = \"enfolio52\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoFolioApprovalLevel_Id != 0) {
whereBuilder.Append("((\"enfolioapprovallevel26\".\"id\" = @qpfoFolioApprovalLevel_Id) AND (\"enfolioapprovallevel26\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolioApprovalLevel_Id", DbType.Int64, qpfoFolioApprovalLevel_Id);
} else {
whereBuilder.Append("(\"enfolioapprovallevel26\".\"id\" IS NULL)");
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
RL_ae9182bb38290e8d92b0cbd2d4f71569 outParamList = new RL_ae9182bb38290e8d92b0cbd2d4f71569();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetFolioApprovalLevelByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query FolioReassignGeneralRevoke.GetFolioApprovalLevelById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_ae9182bb38290e8d92b0cbd2d4f71569 _tmp = new RL_ae9182bb38290e8d92b0cbd2d4f71569();
_tmp.AlternateReadDbMethodAsync = datasetGetFolioApprovalLevelByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query FolioReassignGeneralRevoke.GetFolioApprovalLevelById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_ae9182bb38290e8d92b0cbd2d4f71569)_tmp;
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

private static async Task<RC_aad5e0f2e56c05eeddd020d008f4b3d7> datasetGetOriginalUserByIdReadDbAsync(RC_aad5e0f2e56c05eeddd020d008f4b3d7 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENEntraRole.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
return rec;
}
// Query Function "GetOriginalUserById" zS0bI5SNaUqah0PB8rnlvQ of Action "FolioReassignGeneralRevoke"
public static async Task<(RL_a37f5f153582e24adaea3ae8b54b3101,long)> datasetGetOriginalUserById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("FolioReassignGeneralRevoke.GetOriginalUserById", "231b2dcd-8d94-4a69-9a87-43c1f2b9e5bd");
using var queryActivity = activitySource.CreateAggregateQueryActivity("FolioReassignGeneralRevoke.GetOriginalUserById", "231b2dcd-8d94-4a69-9a87-43c1f2b9e5bd", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.2Z+KzQQ_AkGqrW41IyuG8w/NodesNotShownInESpaceTree.zS0bI5SNaUqah0PB8rnlvQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enentrarole31\".\"rolename\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, \"enuser114\".\"name\" o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, \"enuser_extended_internal65\".\"entraroleid\" o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30");
fromBuilder.Append(" FROM (({User} \"enuser114\" Left JOIN {User_Extended_Internal} \"enuser_extended_internal65\" ON (\"enuser114\".\"id\" = \"enuser_extended_internal65\".\"id\"))  Left JOIN {EntraRole} \"enentrarole31\" ON (\"enuser_extended_internal65\".\"entraroleid\" = \"enentrarole31\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser114\".\"id\" = @qpusUser_Id) AND (\"enuser114\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser114\".\"id\" IS NULL)");
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
RL_a37f5f153582e24adaea3ae8b54b3101 outParamList = new RL_a37f5f153582e24adaea3ae8b54b3101();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOriginalUserByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, false, true, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query FolioReassignGeneralRevoke.GetOriginalUserById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_a37f5f153582e24adaea3ae8b54b3101 _tmp = new RL_a37f5f153582e24adaea3ae8b54b3101();
_tmp.AlternateReadDbMethodAsync = datasetGetOriginalUserByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query FolioReassignGeneralRevoke.GetOriginalUserById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_a37f5f153582e24adaea3ae8b54b3101)_tmp;
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

// Query Function "GetReassignmentById" caTClTgbIEGhfKQFUVBEdQ of Action "FolioReassignGeneralRevoke"
public static async Task<(RL_462b16c1ddedb19ce2dbad5e94ccb4ef,long)> datasetGetReassignmentById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("FolioReassignGeneralRevoke.GetReassignmentById", "95c2a471-1b38-4120-a17c-a40551504475");
using var queryActivity = activitySource.CreateAggregateQueryActivity("FolioReassignGeneralRevoke.GetReassignmentById", "95c2a471-1b38-4120-a17c-a40551504475", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.2Z+KzQQ_AkGqrW41IyuG8w/NodesNotShownInESpaceTree.caTClTgbIEGhfKQFUVBEdQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enreassignments1\".\"id\" o0, \"enreassignments1\".\"sourceuserid\" o1, \"enreassignments1\".\"targetuserid\" o2, \"enreassignments1\".\"requisitionid\" o3, \"enreassignments1\".\"requisitionapprovallevelid\" o4, \"enreassignments1\".\"invoiceid\" o5, \"enreassignments1\".\"invoiceapprovallevelid\" o6, \"enreassignments1\".\"reason\" o7, \"enreassignments1\".\"createdby\" o8, \"enreassignments1\".\"createdon\" o9, \"enreassignments1\".\"revokedby\" o10, \"enreassignments1\".\"revokedon\" o11, \"enreassignments1\".\"folioid\" o12, \"enreassignments1\".\"folioapprovallevelid\" o13, \"enreassignments1\".\"sourceentraroleid\" o14, \"enreassignments1\".\"targetentraroleid\" o15, \"enreassignments1\".\"isfolioapprovallevelinvoice\" o16");
fromBuilder.Append(" FROM {Reassignments} \"enreassignments1\"");
whereBuilder.Append(" WHERE ");
if (qpreId != 0) {
whereBuilder.Append("((\"enreassignments1\".\"id\" = @qpreId) AND (\"enreassignments1\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreId", DbType.Int64, qpreId);
} else {
whereBuilder.Append("(\"enreassignments1\".\"id\" IS NULL)");
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
RL_462b16c1ddedb19ce2dbad5e94ccb4ef outParamList = new RL_462b16c1ddedb19ce2dbad5e94ccb4ef();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query FolioReassignGeneralRevoke.GetReassignmentById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_462b16c1ddedb19ce2dbad5e94ccb4ef _tmp = new RL_462b16c1ddedb19ce2dbad5e94ccb4ef();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query FolioReassignGeneralRevoke.GetReassignmentById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_462b16c1ddedb19ce2dbad5e94ccb4ef)_tmp;
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

private static async Task<RC_aad5e0f2e56c05eeddd020d008f4b3d7> datasetGetRevokedUserByIdReadDbAsync(RC_aad5e0f2e56c05eeddd020d008f4b3d7 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENEntraRole.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
return rec;
}
// Query Function "GetRevokedUserById" fILB1ApRGkWJ0OrWUJKFRA of Action "FolioReassignGeneralRevoke"
public static async Task<(RL_a37f5f153582e24adaea3ae8b54b3101,long)> datasetGetRevokedUserById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("FolioReassignGeneralRevoke.GetRevokedUserById", "d4c1827c-510a-451a-89d0-ead650928544");
using var queryActivity = activitySource.CreateAggregateQueryActivity("FolioReassignGeneralRevoke.GetRevokedUserById", "d4c1827c-510a-451a-89d0-ead650928544", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.2Z+KzQQ_AkGqrW41IyuG8w/NodesNotShownInESpaceTree.fILB1ApRGkWJ0OrWUJKFRA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enentrarole32\".\"rolename\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, \"enuser115\".\"name\" o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30");
fromBuilder.Append(" FROM (({User} \"enuser115\" Left JOIN {User_Extended_Internal} \"enuser_extended_internal66\" ON (\"enuser115\".\"id\" = \"enuser_extended_internal66\".\"id\"))  Left JOIN {EntraRole} \"enentrarole32\" ON (\"enuser_extended_internal66\".\"entraroleid\" = \"enentrarole32\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser115\".\"id\" = @qpusUser_Id) AND (\"enuser115\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser115\".\"id\" IS NULL)");
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
RL_a37f5f153582e24adaea3ae8b54b3101 outParamList = new RL_a37f5f153582e24adaea3ae8b54b3101();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetRevokedUserByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, false, true, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query FolioReassignGeneralRevoke.GetRevokedUserById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_a37f5f153582e24adaea3ae8b54b3101 _tmp = new RL_a37f5f153582e24adaea3ae8b54b3101();
_tmp.AlternateReadDbMethodAsync = datasetGetRevokedUserByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query FolioReassignGeneralRevoke.GetRevokedUserById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_a37f5f153582e24adaea3ae8b54b3101)_tmp;
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
