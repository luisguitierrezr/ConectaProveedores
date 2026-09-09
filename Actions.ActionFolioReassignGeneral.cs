namespace ssConectaProveedores;

public partial class Actions {
public class lcvFolioReassignGeneral : VarsBag {
public string inParami_SourceUserId;
public string inParami_TargetUserId;
public string inParami_Motive;
public BasicTypeList<long> inParami_FolioApprovalLevelList;
public bool inParami_IsInvoiceApproval;
/// <summary>
/// Variable <code>l_FolioApprovalLevels</code> that represents the Service Studio
///  FolioApprovalLevelList <code>l_FolioApprovalLevels</code> <p>Description: FolioApprovalLeve
/// l List</p>
/// </summary>
public RL_4391d3239f28e5f33772aaade6de0b0d varLcl_FolioApprovalLevels = new RL_4391d3239f28e5f33772aaade6de0b0d();

/// <summary>
/// Variable <code>l_Reassignments</code> that represents the Service Studio ReassignmentsList
///  <code>l_Reassignments</code> <p>Description: Reassignments List</p>
/// </summary>
public RL_1baaef4f70e46e094f278bb36a3e6c6e varLcl_Reassignments = new RL_1baaef4f70e46e094f278bb36a3e6c6e();

/// <summary>
/// Variable <code>l_FolioLogs</code> that represents the Service Studio FolioLogList
///  <code>l_FolioLogs</code> <p>Description: FolioLog List</p>
/// </summary>
public RL_26de074a1a259636771c9a11cce45c0c varLcl_FolioLogs = new RL_26de074a1a259636771c9a11cce45c0c();

/// <summary>
/// Variable <code>l_FolioListReassigned</code> that represents the Service Studio Text
///  <code>l_FolioListReassigned</code> <p>Description: FolioListReassigned</p>
/// </summary>
public string varLcl_FolioListReassigned = "";

public RL_8430333e95ceffc00def96d8abb01f75 queryResGetUserById_outParamList = new RL_8430333e95ceffc00def96d8abb01f75();
public long queryResGetUserById_outParamCount = 0L;

public RL_a37f5f153582e24adaea3ae8b54b3101 queryResGetTargetUserById_outParamList = new RL_a37f5f153582e24adaea3ae8b54b3101();
public long queryResGetTargetUserById_outParamCount = 0L;

public RL_a37f5f153582e24adaea3ae8b54b3101 queryResGetSourceUserById_outParamList = new RL_a37f5f153582e24adaea3ae8b54b3101();
public long queryResGetSourceUserById_outParamCount = 0L;

public RL_ae9182bb38290e8d92b0cbd2d4f71569 queryResGetFolioApprovalLevelById_outParamList = new RL_ae9182bb38290e8d92b0cbd2d4f71569();
public long queryResGetFolioApprovalLevelById_outParamCount = 0L;

public lcvFolioReassignGeneral(string inParami_SourceUserId, string inParami_TargetUserId, string inParami_Motive, BasicTypeList<long> inParami_FolioApprovalLevelList, bool inParami_IsInvoiceApproval) {
this.inParami_SourceUserId = inParami_SourceUserId;
this.inParami_TargetUserId = inParami_TargetUserId;
this.inParami_Motive = inParami_Motive;
this.inParami_FolioApprovalLevelList = inParami_FolioApprovalLevelList;
this.inParami_IsInvoiceApproval = inParami_IsInvoiceApproval;
}
}
public class lcoFolioReassignGeneral : VarsBag {
public ST_6fc999fa8f6e0055c73f2f167c4bad19Structure outParamo_NotificationContent = new ST_6fc999fa8f6e0055c73f2f167c4bad19Structure();

public string outParamErrorMessage = "";

public lcoFolioReassignGeneral() {
}
}
/// <summary>
/// Action <code>FolioReassignGeneral</code> that represents the Service Studio action
///  <code>FolioReassignGeneral</code> <p> Description: </p>
/// </summary>
public static async Task<(ST_6fc999fa8f6e0055c73f2f167c4bad19Structure,string)> ActionFolioReassignGeneral(IRequestContext requestContext,string inParami_SourceUserId,string inParami_TargetUserId,string inParami_Motive,BasicTypeList<long> inParami_FolioApprovalLevelList,bool inParami_IsInvoiceApproval,CancellationToken cancellationToken) {
ST_6fc999fa8f6e0055c73f2f167c4bad19Structure outParamo_NotificationContent = default;
string outParamErrorMessage = default;
lcoFolioReassignGeneral result = new lcoFolioReassignGeneral();
lcvFolioReassignGeneral localVars = new lcvFolioReassignGeneral(inParami_SourceUserId, inParami_TargetUserId, inParami_Motive, inParami_FolioApprovalLevelList, inParami_IsInvoiceApproval);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("FolioReassignGeneral", "948f5f87-ddfb-4804-890c-c79a190662b7"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("FolioReassignGeneral", "948f5f87-ddfb-4804-890c-c79a190662b7", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetSourceUserById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetSourceUserById_maxRecords = 1;
if (datasetGetSourceUserById_maxRecords < 1) datasetGetSourceUserById_maxRecords = 1;
int datasetGetSourceUserById_startIndex = 0;(localVars.queryResGetSourceUserById_outParamList,localVars.queryResGetSourceUserById_outParamCount) = await FuncActionFolioReassignGeneral.datasetGetSourceUserById(requestContext,datasetGetSourceUserById_maxRecords,datasetGetSourceUserById_startIndex,IterationMultiplicity.Never,localVars.inParami_SourceUserId,cancellationToken);

// Query datasetGetTargetUserById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetTargetUserById_maxRecords = 1;
if (datasetGetTargetUserById_maxRecords < 1) datasetGetTargetUserById_maxRecords = 1;
int datasetGetTargetUserById_startIndex = 0;(localVars.queryResGetTargetUserById_outParamList,localVars.queryResGetTargetUserById_outParamCount) = await FuncActionFolioReassignGeneral.datasetGetTargetUserById(requestContext,datasetGetTargetUserById_maxRecords,datasetGetTargetUserById_startIndex,IterationMultiplicity.Never,localVars.inParami_TargetUserId,cancellationToken);

// Foreach i_FolioApprovalLevelList
localVars.inParami_FolioApprovalLevelList.StartIteration();
try {while (!((localVars.inParami_FolioApprovalLevelList.Eof))) {
// Query datasetGetFolioApprovalLevelById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioApprovalLevelById_maxRecords = 1;
if (datasetGetFolioApprovalLevelById_maxRecords < 1) datasetGetFolioApprovalLevelById_maxRecords = 1;
int datasetGetFolioApprovalLevelById_startIndex = 0;(localVars.queryResGetFolioApprovalLevelById_outParamList,localVars.queryResGetFolioApprovalLevelById_outParamCount) = await FuncActionFolioReassignGeneral.datasetGetFolioApprovalLevelById(requestContext,datasetGetFolioApprovalLevelById_maxRecords,datasetGetFolioApprovalLevelById_startIndex,IterationMultiplicity.Never,localVars.inParami_FolioApprovalLevelList.CurrentRec,cancellationToken);

// Approval status not allowed for reassignment?
if((!(((localVars.queryResGetFolioApprovalLevelById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssApprovalStatusId!=(ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId)&&(localVars.queryResGetFolioApprovalLevelById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssApprovalStatusId!=(ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("RvhtMOVzUke_jX9z3pm9HA"))).ssId))))) {
// ListAppendReassignment
await ExtendedActions.ListAppend(requestContext,localVars.varLcl_Reassignments,new EN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssSourceUserId = localVars.inParami_SourceUserId, ssTargetUserId = localVars.inParami_TargetUserId, ssReason = localVars.inParami_Motive, ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssFolioId = localVars.queryResGetFolioApprovalLevelById_outParamList.CurrentRec.ssENFolio.ssId, ssFolioApprovalLevelId = localVars.inParami_FolioApprovalLevelList.CurrentRec, ssSourceEntraRoleId = localVars.queryResGetFolioApprovalLevelById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssEntraRoleId, ssTargetEntraRoleId = (((localVars.queryResGetFolioApprovalLevelById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssEntraRoleId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ()))) ? (localVars.queryResGetTargetUserById_outParamList.CurrentRec.ssENUser_Extended_Internal.ssEntraRoleId) : (Convert.ToInt64(BuiltInFunction.NullIdentifier ()))), ssIsFolioApprovalLevelInvoice = localVars.inParami_IsInvoiceApproval },cancellationToken);

// FolioApprovalLevelCurrent
// GetFolioApprovalLevelById.List.Current.FolioApprovalLevel.IsReassigned = True
localVars.queryResGetFolioApprovalLevelById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssIsReassigned = true;

// GetFolioApprovalLevelById.List.Current.FolioApprovalLevel.IsSubstituteFor = If
localVars.queryResGetFolioApprovalLevelById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssIsSubstituteFor = (((localVars.queryResGetFolioApprovalLevelById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssAssignedTo!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.queryResGetFolioApprovalLevelById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssAssignedTo) : (BuiltInFunction.NullTextIdentifier ()));

// GetFolioApprovalLevelById.List.Current.FolioApprovalLevel.AssignedTo = If
localVars.queryResGetFolioApprovalLevelById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssAssignedTo = (((localVars.queryResGetFolioApprovalLevelById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssAssignedTo!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.inParami_TargetUserId) : (BuiltInFunction.NullTextIdentifier ()));

// GetFolioApprovalLevelById.List.Current.FolioApprovalLevel.EntraJobTitle = If
localVars.queryResGetFolioApprovalLevelById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssEntraJobTitle = (((localVars.queryResGetFolioApprovalLevelById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssEntraJobTitle!="")) ? (localVars.queryResGetTargetUserById_outParamList.CurrentRec.ssENEntraRole.ssRoleName) : (""));

// GetFolioApprovalLevelById.List.Current.FolioApprovalLevel.EntraRoleId = If
localVars.queryResGetFolioApprovalLevelById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssEntraRoleId = (((localVars.queryResGetFolioApprovalLevelById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssEntraRoleId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ()))) ? (localVars.queryResGetTargetUserById_outParamList.CurrentRec.ssENUser_Extended_Internal.ssEntraRoleId) : (Convert.ToInt64(BuiltInFunction.NullIdentifier ())));
// ListAppendFolioApprovalLevel
await ExtendedActions.ListAppend(requestContext,localVars.varLcl_FolioApprovalLevels,localVars.queryResGetFolioApprovalLevelById_outParamList.CurrentRec.ssENFolioApprovalLevel,cancellationToken);

// ListAppendFolioLog
await ExtendedActions.ListAppend(requestContext,localVars.varLcl_FolioLogs,new EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssFolioId = localVars.queryResGetFolioApprovalLevelById_outParamList.CurrentRec.ssENFolio.ssId, ssMessage = (((localVars.queryResGetFolioApprovalLevelById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssAssignedTo!=BuiltInFunction.NullTextIdentifier ())) ? (((((AppUtils.GetStringResource("kb6kd_Qj90akwZkpzUlkow#Value.-682383654.1", "Reassignment:")+" ")+localVars.queryResGetSourceUserById_outParamList.CurrentRec.ssENUser.ssName)+" -> ")+localVars.queryResGetTargetUserById_outParamList.CurrentRec.ssENUser.ssName)) : (((((AppUtils.GetStringResource("kb6kd_Qj90akwZkpzUlkow#Value.-682383654.2", "Reassignment:")+" ")+localVars.queryResGetSourceUserById_outParamList.CurrentRec.ssENEntraRole.ssRoleName)+" -> ")+localVars.queryResGetTargetUserById_outParamList.CurrentRec.ssENEntraRole.ssRoleName))), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssIsError = false, ssIsForSupplier = false },cancellationToken);

// CreateOrUpdateSomeFolioApprovalLevel
await ExtendedActions.CreateOrUpdateSomeFolioApprovalLevel(requestContext,(await RL_ecaf6a267327a661b83be973ba99d46b.ConvertAsync(localVars.varLcl_FolioApprovalLevels, new RL_ecaf6a267327a661b83be973ba99d46b(), async (EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord source, RC_0be8bae4cc285c0288822b663818cb6c target, CancellationToken cancellationToken) => {
target = source;
return target;
}, cancellationToken)),cancellationToken);

// CreateOrUpdateSomeFolioLog
await ExtendedActions.CreateOrUpdateSomeFolioLog(requestContext,(await RL_7378b9f1001bf074e0efe8ad3a432970.ConvertAsync(localVars.varLcl_FolioLogs, new RL_7378b9f1001bf074e0efe8ad3a432970(), async (EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord source, RC_d1c5afe2a83250ad8e254ef5d2a29b01 target, CancellationToken cancellationToken) => {
target = source;
return target;
}, cancellationToken)),cancellationToken);

// CreateOrUpdateSomeReassignments
await ExtendedActions.CreateOrUpdateSomeReassignments(requestContext,(await RL_462b16c1ddedb19ce2dbad5e94ccb4ef.ConvertAsync(localVars.varLcl_Reassignments, new RL_462b16c1ddedb19ce2dbad5e94ccb4ef(), async (EN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord source, RC_c9394e1c31772209550f46c7f600d6ee target, CancellationToken cancellationToken) => {
target = source;
return target;
}, cancellationToken)),cancellationToken);

// l_FolioListReassigned = If
localVars.varLcl_FolioListReassigned=(((localVars.varLcl_FolioListReassigned=="")) ? (localVars.queryResGetFolioApprovalLevelById_outParamList.CurrentRec.ssENFolio.ssFolioNumber) : (((localVars.varLcl_FolioListReassigned+", ")+localVars.queryResGetFolioApprovalLevelById_outParamList.CurrentRec.ssENFolio.ssFolioNumber)));
}

localVars.inParami_FolioApprovalLevelList.Advance();
}

} finally {
localVars.inParami_FolioApprovalLevelList.EndIteration();
}

// o_NotificationContent
// o_NotificationContent.Email = GetTargetUserById.List.Current.User.Email
result.outParamo_NotificationContent.ssEmail = localVars.queryResGetTargetUserById_outParamList.CurrentRec.ssENUser.ssEmail;

// o_NotificationContent.Name = GetTargetUserById.List.Current.User.Name
result.outParamo_NotificationContent.ssName = localVars.queryResGetTargetUserById_outParamList.CurrentRec.ssENUser.ssName;

// o_NotificationContent.JobTitle = GetTargetUserById.List.Current.EntraRole.RoleName
result.outParamo_NotificationContent.ssJobTitle = localVars.queryResGetTargetUserById_outParamList.CurrentRec.ssENEntraRole.ssRoleName;

// o_NotificationContent.PhoneNumber = "Undefined"
result.outParamo_NotificationContent.ssPhoneNumber = AppUtils.GetStringResource("F61Rd9oBrEyqTiKR3hD4dw#Value.965837104.1", "Undefined");
// Query datasetGetUserById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserById_maxRecords = 0;
int datasetGetUserById_startIndex = 0;(localVars.queryResGetUserById_outParamList,localVars.queryResGetUserById_outParamCount) = await FuncActionFolioReassignGeneral.datasetGetUserById(requestContext,datasetGetUserById_maxRecords,datasetGetUserById_startIndex,IterationMultiplicity.Never,BuiltInFunction.GetUserId (),cancellationToken);

// SendReassignmentFolioNotifyTargetUser
await Actions.ActionSendReassignmentFolioNotifyTargetUser(requestContext,(await RecordUtils.ConvertAsync(localVars.queryResGetTargetUserById_outParamList.CurrentRec, new RC_34272dae45b4de5e1332f46c6e8700b9(), async (RC_aad5e0f2e56c05eeddd020d008f4b3d7 source, RC_34272dae45b4de5e1332f46c6e8700b9 target, CancellationToken cancellationToken) => {
target.ssENUser = source.ssENUser;
target.ssENUser_Extended_Internal = source.ssENUser_Extended_Internal;
return target;
}, cancellationToken)),localVars.varLcl_FolioListReassigned,localVars.queryResGetUserById_outParamList.CurrentRec.ssENUser.ssName,localVars.inParami_Motive,cancellationToken);

} //close CreateActionActivity using block
} // try

finally {
outParamo_NotificationContent = result.outParamo_NotificationContent;
outParamErrorMessage = result.outParamErrorMessage;
} // inner-finally
RETURN_STATEMENT:
return (outParamo_NotificationContent,outParamErrorMessage);
}

public static class FuncActionFolioReassignGeneral {

// Query Function "GetUserById" vNCiJmHOMkazoS8FKFT60w of Action "FolioReassignGeneral"
public static async Task<(RL_8430333e95ceffc00def96d8abb01f75,long)> datasetGetUserById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("FolioReassignGeneral.GetUserById", "26a2d0bc-ce61-4632-b3a1-2f052854fad3");
using var queryActivity = activitySource.CreateAggregateQueryActivity("FolioReassignGeneral.GetUserById", "26a2d0bc-ce61-4632-b3a1-2f052854fad3", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.h1+PlPvdBEiJDMeaGQZitw/NodesNotShownInESpaceTree.vNCiJmHOMkazoS8FKFT60w, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enuser89\".\"name\" o1, NULL o2, NULL o3, NULL o4");
fromBuilder.Append(" FROM {User} \"enuser89\"");
whereBuilder.Append(" WHERE ");
if ((qpusId.Trim()!="")) {
whereBuilder.Append("((\"enuser89\".\"id\" = @qpusId) AND (\"enuser89\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusId", DbType.String, qpusId);
} else {
whereBuilder.Append("(\"enuser89\".\"id\" IS NULL)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query FolioReassignGeneral.GetUserById.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query FolioReassignGeneral.GetUserById.List", cancellationToken: cancellationToken);
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

private static async Task<RC_aad5e0f2e56c05eeddd020d008f4b3d7> datasetGetTargetUserByIdReadDbAsync(RC_aad5e0f2e56c05eeddd020d008f4b3d7 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENEntraRole.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
return rec;
}
// Query Function "GetTargetUserById" YlsqNM5MqkGZv8cOA3jI1A of Action "FolioReassignGeneral"
public static async Task<(RL_a37f5f153582e24adaea3ae8b54b3101,long)> datasetGetTargetUserById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("FolioReassignGeneral.GetTargetUserById", "342a5b62-4cce-41aa-99bf-c70e0378c8d4");
using var queryActivity = activitySource.CreateAggregateQueryActivity("FolioReassignGeneral.GetTargetUserById", "342a5b62-4cce-41aa-99bf-c70e0378c8d4", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.h1+PlPvdBEiJDMeaGQZitw/NodesNotShownInESpaceTree.YlsqNM5MqkGZv8cOA3jI1A, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enentrarole25\".\"rolename\" o1, NULL o2, NULL o3, NULL o4, NULL o5, \"enuser90\".\"id\" o6, \"enuser90\".\"name\" o7, \"enuser90\".\"email\" o8, \"enuser90\".\"photourl\" o9, \"enuser90\".\"username\" o10, \"enuser_extended_internal55\".\"id\" o11, \"enuser_extended_internal55\".\"employeenumber\" o12, \"enuser_extended_internal55\".\"managedby\" o13, \"enuser_extended_internal55\".\"regionid\" o14, \"enuser_extended_internal55\".\"departmentid\" o15, \"enuser_extended_internal55\".\"managementid\" o16, \"enuser_extended_internal55\".\"subdirectionid\" o17, \"enuser_extended_internal55\".\"telceldirectionid\" o18, \"enuser_extended_internal55\".\"city\" o19, \"enuser_extended_internal55\".\"jobtitle\" o20, \"enuser_extended_internal55\".\"entraroleid\" o21, \"enuser_extended_internal55\".\"onpremisesdistinguishedname\" o22, \"enuser_extended_internal55\".\"hasrolesassigned\" o23, \"enuser_extended_internal55\".\"lastsync\" o24, \"enuser_extended_internal55\".\"createdby\" o25, \"enuser_extended_internal55\".\"createdon\" o26, \"enuser_extended_internal55\".\"updatedby\" o27, \"enuser_extended_internal55\".\"updatedon\" o28, \"enuser_extended_internal55\".\"entraid\" o29, \"enuser_extended_internal55\".\"telceldireccion\" o30");
fromBuilder.Append(" FROM (({User} \"enuser90\" Left JOIN {User_Extended_Internal} \"enuser_extended_internal55\" ON (\"enuser90\".\"id\" = \"enuser_extended_internal55\".\"id\"))  Left JOIN {EntraRole} \"enentrarole25\" ON (\"enuser_extended_internal55\".\"entraroleid\" = \"enentrarole25\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser90\".\"id\" = @qpusUser_Id) AND (\"enuser90\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser90\".\"id\" IS NULL)");
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
outParamList.AlternateReadDbMethodAsync = datasetGetTargetUserByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {false, false, false, false, false});
opt[1] = new BitArray(new bool[] {true, false, true, true, true, true});
opt[2] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query FolioReassignGeneral.GetTargetUserById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_a37f5f153582e24adaea3ae8b54b3101 _tmp = new RL_a37f5f153582e24adaea3ae8b54b3101();
_tmp.AlternateReadDbMethodAsync = datasetGetTargetUserByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query FolioReassignGeneral.GetTargetUserById.List", cancellationToken: cancellationToken);
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

private static async Task<RC_aad5e0f2e56c05eeddd020d008f4b3d7> datasetGetSourceUserByIdReadDbAsync(RC_aad5e0f2e56c05eeddd020d008f4b3d7 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENEntraRole.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
return rec;
}
// Query Function "GetSourceUserById" XmHFfFwVFk+IFhQo0fuqww of Action "FolioReassignGeneral"
public static async Task<(RL_a37f5f153582e24adaea3ae8b54b3101,long)> datasetGetSourceUserById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("FolioReassignGeneral.GetSourceUserById", "7cc5615e-155c-4f16-8816-1428d1fbaac3");
using var queryActivity = activitySource.CreateAggregateQueryActivity("FolioReassignGeneral.GetSourceUserById", "7cc5615e-155c-4f16-8816-1428d1fbaac3", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.h1+PlPvdBEiJDMeaGQZitw/NodesNotShownInESpaceTree.XmHFfFwVFk+IFhQo0fuqww, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enentrarole26\".\"rolename\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, \"enuser91\".\"name\" o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30");
fromBuilder.Append(" FROM (({User} \"enuser91\" Left JOIN {User_Extended_Internal} \"enuser_extended_internal56\" ON (\"enuser91\".\"id\" = \"enuser_extended_internal56\".\"id\"))  Left JOIN {EntraRole} \"enentrarole26\" ON (\"enuser_extended_internal56\".\"entraroleid\" = \"enentrarole26\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser91\".\"id\" = @qpusUser_Id) AND (\"enuser91\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser91\".\"id\" IS NULL)");
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
outParamList.AlternateReadDbMethodAsync = datasetGetSourceUserByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, false, true, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query FolioReassignGeneral.GetSourceUserById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_a37f5f153582e24adaea3ae8b54b3101 _tmp = new RL_a37f5f153582e24adaea3ae8b54b3101();
_tmp.AlternateReadDbMethodAsync = datasetGetSourceUserByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query FolioReassignGeneral.GetSourceUserById.List", cancellationToken: cancellationToken);
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

private static async Task<RC_1b390f8e281aa018cfe8a81d34cdb757> datasetGetFolioApprovalLevelByIdReadDbAsync(RC_1b390f8e281aa018cfe8a81d34cdb757 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFolio.Read( r, ref index);
rec.ssENFolioApproval.Read( r, ref index);
rec.ssENFolioApprovalLevel.Read( r, ref index);
return rec;
}
// Query Function "GetFolioApprovalLevelById" qONewT4agEG0wL3+kusHwQ of Action "FolioReassignGeneral"
public static async Task<(RL_ae9182bb38290e8d92b0cbd2d4f71569,long)> datasetGetFolioApprovalLevelById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolioApprovalLevel_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("FolioReassignGeneral.GetFolioApprovalLevelById", "c15ee3a8-1a3e-4180-b4c0-bdfe92eb07c1");
using var queryActivity = activitySource.CreateAggregateQueryActivity("FolioReassignGeneral.GetFolioApprovalLevelById", "c15ee3a8-1a3e-4180-b4c0-bdfe92eb07c1", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.h1+PlPvdBEiJDMeaGQZitw/NodesNotShownInESpaceTree.qONewT4agEG0wL3+kusHwQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enfolio34\".\"id\" o0, NULL o1, \"enfolio34\".\"folionumber\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, \"enfolioapprovallevel16\".\"id\" o30, \"enfolioapprovallevel16\".\"folioapprovalid\" o31, \"enfolioapprovallevel16\".\"levelnumber\" o32, \"enfolioapprovallevel16\".\"applicationroleid\" o33, \"enfolioapprovallevel16\".\"entrajobtitle\" o34, \"enfolioapprovallevel16\".\"entraroleid\" o35, \"enfolioapprovallevel16\".\"departmentid\" o36, \"enfolioapprovallevel16\".\"assignedto\" o37, \"enfolioapprovallevel16\".\"approvalstatusid\" o38, \"enfolioapprovallevel16\".\"ismandatory\" o39, \"enfolioapprovallevel16\".\"isreassigned\" o40, \"enfolioapprovallevel16\".\"approvedby\" o41, \"enfolioapprovallevel16\".\"approvedon\" o42, \"enfolioapprovallevel16\".\"canceledby\" o43, \"enfolioapprovallevel16\".\"canceledon\" o44, \"enfolioapprovallevel16\".\"rejectedby\" o45, \"enfolioapprovallevel16\".\"rejectedon\" o46, \"enfolioapprovallevel16\".\"issubstitutefor\" o47, \"enfolioapprovallevel16\".\"rejectreason\" o48, \"enfolioapprovallevel16\".\"isinvoiceapproval\" o49");
fromBuilder.Append(" FROM (({FolioApprovalLevel} \"enfolioapprovallevel16\" Left JOIN {FolioApproval} \"enfolioapproval17\" ON (\"enfolioapprovallevel16\".\"folioapprovalid\" = \"enfolioapproval17\".\"id\"))  Left JOIN {Folio} \"enfolio34\" ON (\"enfolioapproval17\".\"folioid\" = \"enfolio34\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoFolioApprovalLevel_Id != 0) {
whereBuilder.Append("((\"enfolioapprovallevel16\".\"id\" = @qpfoFolioApprovalLevel_Id) AND (\"enfolioapprovallevel16\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolioApprovalLevel_Id", DbType.Int64, qpfoFolioApprovalLevel_Id);
} else {
whereBuilder.Append("(\"enfolioapprovallevel16\".\"id\" IS NULL)");
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
opt[1] = new BitArray(new bool[] {false, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query FolioReassignGeneral.GetFolioApprovalLevelById.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query FolioReassignGeneral.GetFolioApprovalLevelById.List", cancellationToken: cancellationToken);
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



}


}
