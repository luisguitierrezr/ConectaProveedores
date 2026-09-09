namespace ssConectaProveedores;

public partial class Actions {
public class lcvFolioReassign : VarsBag {
public long inParami_FolioId;
public string inParami_AssignUserId;
public long inParami_FolioApprovalLevelId;
public RL_8430333e95ceffc00def96d8abb01f75 queryResGetUserById_outParamList = new RL_8430333e95ceffc00def96d8abb01f75();
public long queryResGetUserById_outParamCount = 0L;

public RL_ae9182bb38290e8d92b0cbd2d4f71569 queryResGetFolioById_outParamList = new RL_ae9182bb38290e8d92b0cbd2d4f71569();
public long queryResGetFolioById_outParamCount = 0L;

public Actions.lcoFolioLogAdd resFolioLogAdd =  new Actions.lcoFolioLogAdd();
public Actions.lcoFolioApprovalLevelCreateOrUpdate resFolioApprovalLevelCreateOrUpdate =  new Actions.lcoFolioApprovalLevelCreateOrUpdate();
public lcvFolioReassign(long inParami_FolioId, string inParami_AssignUserId, long inParami_FolioApprovalLevelId) {
this.inParami_FolioId = inParami_FolioId;
this.inParami_AssignUserId = inParami_AssignUserId;
this.inParami_FolioApprovalLevelId = inParami_FolioApprovalLevelId;
}
}
public class lcoFolioReassign : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public lcoFolioReassign() {
}
}
/// <summary>
/// Action <code>FolioReassign</code> that represents the Service Studio action
///  <code>FolioReassign</code> <p> Description: Action to Reassign Folio.</p>
/// </summary>
public static async Task<ST_046fb53ebbe142526d95e87ef1ae9711Structure> ActionFolioReassign(IRequestContext requestContext,long inParami_FolioId,string inParami_AssignUserId,long inParami_FolioApprovalLevelId,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
lcoFolioReassign result = new lcoFolioReassign();
lcvFolioReassign localVars = new lcvFolioReassign(inParami_FolioId, inParami_AssignUserId, inParami_FolioApprovalLevelId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("FolioReassign", "a8c35d8c-caa5-441f-ac61-1d48ceb4a878"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("FolioReassign", "a8c35d8c-caa5-441f-ac61-1d48ceb4a878", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetFolioById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioById_maxRecords = 1;
if (datasetGetFolioById_maxRecords < 1) datasetGetFolioById_maxRecords = 1;
int datasetGetFolioById_startIndex = 0;(localVars.queryResGetFolioById_outParamList,localVars.queryResGetFolioById_outParamCount) = await FuncActionFolioReassign.datasetGetFolioById(requestContext,datasetGetFolioById_maxRecords,datasetGetFolioById_startIndex,IterationMultiplicity.Never,localVars.inParami_FolioApprovalLevelId,localVars.inParami_FolioId,cancellationToken);

// Empty?
if((localVars.queryResGetFolioById_outParamList.Empty)) {
// o_Output
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "Folio not found!"
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("2Fj3MI_f1kG8rjss7rCkkA#Value.1482511939.1", "Folio not found!");
} else {
// Level Not Approved?
if(((localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssApprovalStatusId!=(ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId))) {
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "Folio cannot be updated!"
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("Sibm2_bXVkiMqp7ghTISzA#Value.1911675613.1", "Folio cannot be updated!");
} else {
// Query datasetGetUserById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserById_maxRecords = 1;
if (datasetGetUserById_maxRecords < 1) datasetGetUserById_maxRecords = 1;
int datasetGetUserById_startIndex = 0;(localVars.queryResGetUserById_outParamList,localVars.queryResGetUserById_outParamCount) = await FuncActionFolioReassign.datasetGetUserById(requestContext,datasetGetUserById_maxRecords,datasetGetUserById_startIndex,IterationMultiplicity.Never,localVars.inParami_AssignUserId,cancellationToken);

// Empty?
if((localVars.queryResGetUserById_outParamList.Empty)) {
// o_Output
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "User to assign not found!"
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("qJHCOX3DVE6jsYdTOAVSfQ#Value.-102311603.1", "User to assign not found!");
} else {
// Folio Fields
// GetFolioById.List.Current.FolioApprovalLevel.AssignedTo = i_AssignUserId
localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssAssignedTo = localVars.inParami_AssignUserId;
// FolioApprovalLevelCreateOrUpdate
localVars.resFolioApprovalLevelCreateOrUpdate.outParamId = await Actions.ActionFolioApprovalLevelCreateOrUpdate(requestContext,localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApprovalLevel,cancellationToken);

// FolioLogAdd
localVars.resFolioLogAdd.outParamId = await Actions.ActionFolioLogAdd(requestContext,new EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssFolioId = localVars.inParami_FolioId, ssMessage = (((((((AppUtils.GetStringResource("n1HafyF8+UKK5oEpMwyJPQ#Value.68060425.1", "Folio")+" ")+localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssFolioNumber)+" ")+AppUtils.GetStringResource("n1HafyF8+UKK5oEpMwyJPQ#Value.-588554410.1", "was assigned to"))+": ")+localVars.queryResGetUserById_outParamList.CurrentRec.ssENUser.ssName)+"."), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime () },cancellationToken);

// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
}

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

public static class FuncActionFolioReassign {

// Query Function "GetUserById" qkVvQRpdg0mjoxJ7RWvgvw of Action "FolioReassign"
public static async Task<(RL_8430333e95ceffc00def96d8abb01f75,long)> datasetGetUserById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("FolioReassign.GetUserById", "416f45aa-5d1a-4983-a3a3-127b456be0bf");
using var queryActivity = activitySource.CreateAggregateQueryActivity("FolioReassign.GetUserById", "416f45aa-5d1a-4983-a3a3-127b456be0bf", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.jF3DqKXKH0SsYR1IzrSoeA/NodesNotShownInESpaceTree.qkVvQRpdg0mjoxJ7RWvgvw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enuser96\".\"name\" o1, NULL o2, NULL o3, NULL o4");
fromBuilder.Append(" FROM {User} \"enuser96\"");
whereBuilder.Append(" WHERE ");
if ((qpusId.Trim()!="")) {
whereBuilder.Append("((\"enuser96\".\"id\" = @qpusId) AND (\"enuser96\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusId", DbType.String, qpusId);
} else {
whereBuilder.Append("(\"enuser96\".\"id\" IS NULL)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query FolioReassign.GetUserById.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query FolioReassign.GetUserById.List", cancellationToken: cancellationToken);
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

private static async Task<RC_1b390f8e281aa018cfe8a81d34cdb757> datasetGetFolioByIdReadDbAsync(RC_1b390f8e281aa018cfe8a81d34cdb757 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFolio.Read( r, ref index);
rec.ssENFolioApproval.Read( r, ref index);
rec.ssENFolioApprovalLevel.Read( r, ref index);
return rec;
}
// Query Function "GetFolioById" +lS6eQ6LckGh9KCeio35iA of Action "FolioReassign"
public static async Task<(RL_ae9182bb38290e8d92b0cbd2d4f71569,long)> datasetGetFolioById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolioApprovalLevel_Id,long qpfoFolio_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("FolioReassign.GetFolioById", "79ba54fa-8b0e-4172-a1f4-a09e8a8df988");
using var queryActivity = activitySource.CreateAggregateQueryActivity("FolioReassign.GetFolioById", "79ba54fa-8b0e-4172-a1f4-a09e8a8df988", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.jF3DqKXKH0SsYR1IzrSoeA/NodesNotShownInESpaceTree.+lS6eQ6LckGh9KCeio35iA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, \"enfolio39\".\"folionumber\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, \"enfolioapprovallevel20\".\"id\" o30, \"enfolioapprovallevel20\".\"folioapprovalid\" o31, \"enfolioapprovallevel20\".\"levelnumber\" o32, \"enfolioapprovallevel20\".\"applicationroleid\" o33, \"enfolioapprovallevel20\".\"entrajobtitle\" o34, \"enfolioapprovallevel20\".\"entraroleid\" o35, \"enfolioapprovallevel20\".\"departmentid\" o36, \"enfolioapprovallevel20\".\"assignedto\" o37, \"enfolioapprovallevel20\".\"approvalstatusid\" o38, \"enfolioapprovallevel20\".\"ismandatory\" o39, \"enfolioapprovallevel20\".\"isreassigned\" o40, \"enfolioapprovallevel20\".\"approvedby\" o41, \"enfolioapprovallevel20\".\"approvedon\" o42, \"enfolioapprovallevel20\".\"canceledby\" o43, \"enfolioapprovallevel20\".\"canceledon\" o44, \"enfolioapprovallevel20\".\"rejectedby\" o45, \"enfolioapprovallevel20\".\"rejectedon\" o46, \"enfolioapprovallevel20\".\"issubstitutefor\" o47, \"enfolioapprovallevel20\".\"rejectreason\" o48, \"enfolioapprovallevel20\".\"isinvoiceapproval\" o49");
fromBuilder.Append(" FROM (({Folio} \"enfolio39\" Left JOIN {FolioApproval} \"enfolioapproval21\" ON (\"enfolio39\".\"id\" = \"enfolioapproval21\".\"folioid\"))  Left JOIN {FolioApprovalLevel} \"enfolioapprovallevel20\" ON (\"enfolioapproval21\".\"id\" = \"enfolioapprovallevel20\".\"folioapprovalid\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoFolio_Id != 0) {
whereBuilder.Append("((\"enfolio39\".\"id\" = @qpfoFolio_Id) AND (\"enfolio39\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolio_Id", DbType.Int64, qpfoFolio_Id);
} else {
whereBuilder.Append("(\"enfolio39\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND ");
if (qpfoFolioApprovalLevel_Id != 0) {
whereBuilder.Append("((\"enfolioapprovallevel20\".\"id\" = @qpfoFolioApprovalLevel_Id) AND (\"enfolioapprovallevel20\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolioApprovalLevel_Id", DbType.Int64, qpfoFolioApprovalLevel_Id);
} else {
whereBuilder.Append("(\"enfolioapprovallevel20\".\"id\" IS NULL)");
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
outParamList.AlternateReadDbMethodAsync = datasetGetFolioByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query FolioReassign.GetFolioById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_ae9182bb38290e8d92b0cbd2d4f71569 _tmp = new RL_ae9182bb38290e8d92b0cbd2d4f71569();
_tmp.AlternateReadDbMethodAsync = datasetGetFolioByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query FolioReassign.GetFolioById.List", cancellationToken: cancellationToken);
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
