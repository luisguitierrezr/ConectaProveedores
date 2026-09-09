namespace ssConectaProveedores;

public partial class Actions {
public class lcvFolioIncorrectAssignment : VarsBag {
public long inParami_FolioId;
public long inParami_FolioApprovalLevelId;
public string inParami_Motive;
public Actions.lcoFolioLogAdd resFolioLogAdd =  new Actions.lcoFolioLogAdd();
public Actions.lcoFolioApprovalLevelCreateOrUpdate resFolioApprovalLevelCreateOrUpdate =  new Actions.lcoFolioApprovalLevelCreateOrUpdate();
public RL_ecaf6a267327a661b83be973ba99d46b queryResGetFolioApprovalLevelsByFolioApprovalId_outParamList = new RL_ecaf6a267327a661b83be973ba99d46b();
public long queryResGetFolioApprovalLevelsByFolioApprovalId_outParamCount = 0L;

public RL_ae9182bb38290e8d92b0cbd2d4f71569 queryResGetFolioById_outParamList = new RL_ae9182bb38290e8d92b0cbd2d4f71569();
public long queryResGetFolioById_outParamCount = 0L;

public lcvFolioIncorrectAssignment(long inParami_FolioId, long inParami_FolioApprovalLevelId, string inParami_Motive) {
this.inParami_FolioId = inParami_FolioId;
this.inParami_FolioApprovalLevelId = inParami_FolioApprovalLevelId;
this.inParami_Motive = inParami_Motive;
}
}
public class lcoFolioIncorrectAssignment : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public lcoFolioIncorrectAssignment() {
}
}
/// <summary>
/// Action <code>FolioIncorrectAssignment</code> that represents the Service Studio action
///  <code>FolioIncorrectAssignment</code> <p> Description: </p>
/// </summary>
public static async Task<ST_046fb53ebbe142526d95e87ef1ae9711Structure> ActionFolioIncorrectAssignment(IRequestContext requestContext,long inParami_FolioId,long inParami_FolioApprovalLevelId,string inParami_Motive,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
lcoFolioIncorrectAssignment result = new lcoFolioIncorrectAssignment();
lcvFolioIncorrectAssignment localVars = new lcvFolioIncorrectAssignment(inParami_FolioId, inParami_FolioApprovalLevelId, inParami_Motive);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("FolioIncorrectAssignment", "77297736-bde9-44a2-95d3-1a821a506bed"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("FolioIncorrectAssignment", "77297736-bde9-44a2-95d3-1a821a506bed", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetFolioById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioById_maxRecords = 1;
if (datasetGetFolioById_maxRecords < 1) datasetGetFolioById_maxRecords = 1;
int datasetGetFolioById_startIndex = 0;(localVars.queryResGetFolioById_outParamList,localVars.queryResGetFolioById_outParamCount) = await FuncActionFolioIncorrectAssignment.datasetGetFolioById(requestContext,datasetGetFolioById_maxRecords,datasetGetFolioById_startIndex,IterationMultiplicity.Never,localVars.inParami_FolioApprovalLevelId,localVars.inParami_FolioId,cancellationToken);

// Empty?
if((localVars.queryResGetFolioById_outParamList.Empty)) {
// o_Output
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "Folio not found!"
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("0_n0jmbgVES_W_vJZP0hPQ#Value.1482511939.1", "Folio not found!");
} else {
// Level Not Approved?
if(((localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssApprovalStatusId!=(ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId))) {
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "Folio cannot be updated!"
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("MQmMfxK6TEi6z7NuXR_Pjw#Value.1911675613.1", "Folio cannot be updated!");
} else {
// Query datasetGetFolioApprovalLevelsByFolioApprovalId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioApprovalLevelsByFolioApprovalId_maxRecords = 0;
int datasetGetFolioApprovalLevelsByFolioApprovalId_startIndex = 0;(localVars.queryResGetFolioApprovalLevelsByFolioApprovalId_outParamList,localVars.queryResGetFolioApprovalLevelsByFolioApprovalId_outParamCount) = await FuncActionFolioIncorrectAssignment.datasetGetFolioApprovalLevelsByFolioApprovalId(requestContext,datasetGetFolioApprovalLevelsByFolioApprovalId_maxRecords,datasetGetFolioApprovalLevelsByFolioApprovalId_startIndex,IterationMultiplicity.Single,localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApproval.ssId,localVars.inParami_FolioApprovalLevelId,cancellationToken);

// Foreach GetFolioApprovalLevelsByFolioApprovalId.List
localVars.queryResGetFolioApprovalLevelsByFolioApprovalId_outParamList.StartIteration();
try {while (!((localVars.queryResGetFolioApprovalLevelsByFolioApprovalId_outParamList.Eof))) {
// FolioApprovalLevelDelete
await Actions.ActionFolioApprovalLevelDelete(requestContext,localVars.queryResGetFolioApprovalLevelsByFolioApprovalId_outParamList.CurrentRec.ssENFolioApprovalLevel.ssId,cancellationToken);

localVars.queryResGetFolioApprovalLevelsByFolioApprovalId_outParamList.Advance();
}

} finally {
localVars.queryResGetFolioApprovalLevelsByFolioApprovalId_outParamList.EndIteration();
}

// GetFolioById.List.Current.FolioApprovalLevel.AssignedTo = NullTextIdentifier
localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssAssignedTo = BuiltInFunction.NullTextIdentifier ();

// GetFolioById.List.Current.FolioApprovalLevel.EntraJobTitle = ""
localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssEntraJobTitle = "";

// GetFolioById.List.Current.FolioApprovalLevel.EntraRoleId = NullIdentifier
localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssEntraRoleId = Convert.ToInt64(BuiltInFunction.NullIdentifier ());

// GetFolioById.List.Current.FolioApprovalLevel.RejectedBy = GetUserId
localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssRejectedBy = BuiltInFunction.GetUserId ();

// GetFolioById.List.Current.FolioApprovalLevel.RejectedOn = CurrDateTime
localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssRejectedOn = BuiltInFunction.CurrDateTime ();

// GetFolioById.List.Current.FolioApprovalLevel.RejectReason = i_Motive
localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssRejectReason = localVars.inParami_Motive;

// GetFolioById.List.Current.FolioApprovalLevel.ApprovalStatusId = Pending
localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssApprovalStatusId = (ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("fEmjvBqEH0eHrf5_YVeo0g"))).ssId;
// FolioApprovalLevelCreateOrUpdate
localVars.resFolioApprovalLevelCreateOrUpdate.outParamId = await Actions.ActionFolioApprovalLevelCreateOrUpdate(requestContext,localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApprovalLevel,cancellationToken);

// FolioLogAdd
localVars.resFolioLogAdd.outParamId = await Actions.ActionFolioLogAdd(requestContext,new EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssFolioId = localVars.inParami_FolioId, ssMessage = ((((((((AppUtils.GetStringResource("YXFeLlqpCE6ZbWHp6ec3IQ#Value.68060425.1", "Folio")+" ")+localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssFolioNumber)+" ")+AppUtils.GetStringResource("YXFeLlqpCE6ZbWHp6ec3IQ#Value.1205994220.1", "has been rejected"))+". ")+AppUtils.GetStringResource("YXFeLlqpCE6ZbWHp6ec3IQ#Value.-1851097500.1", "Reason"))+": ")+localVars.inParami_Motive), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssIsError = true },cancellationToken);

// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
{
    using (AppHealthProvider.CreateGlobalEventTriggerMetric("OnSendFolioIncorrectAssignment", "9418e88c-6c38-4a62-8946-82b71c6c7906"))
    using (activitySource.CreateTriggerEventActivity("OnSendFolioIncorrectAssignment", "9418e88c-6c38-4a62-8946-82b71c6c7906", "ce812e4f-9978-4373-8236-2e58e6f59d99", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828")) {
        var input = new EventPayloads.GlobalEventOnSendFolioIncorrectAssignmentPayload() {inParami_FolioId = localVars.inParami_FolioId,inParami_RejectMotive = localVars.inParami_Motive};

        var eventPublisher = ServiceLocator.GetService<IEventPublisher>();
        await eventPublisher.PublishEventAsync("OnSendFolioIncorrectAssignment", "ce812e4f-9978-4373-8236-2e58e6f59d99", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828", input, cancellationToken);
    }
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

public static class FuncActionFolioIncorrectAssignment {

// Query Function "GetFolioApprovalLevelsByFolioApprovalId" hveAPFHtXEqudOOzes_Awg of Action "FolioIncorrectAssignment"
public static async Task<(RL_ecaf6a267327a661b83be973ba99d46b,long)> datasetGetFolioApprovalLevelsByFolioApprovalId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolioApprovalId,long qpfoId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("FolioIncorrectAssignment.GetFolioApprovalLevelsByFolioApprovalId", "3c80f786-ed51-4a5c-ae74-e3b37acfc0c2");
using var queryActivity = activitySource.CreateAggregateQueryActivity("FolioIncorrectAssignment.GetFolioApprovalLevelsByFolioApprovalId", "3c80f786-ed51-4a5c-ae74-e3b37acfc0c2", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.Nncpd+m9okSV0xqCGlBr7Q/NodesNotShownInESpaceTree.hveAPFHtXEqudOOzes_Awg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enfolioapprovallevel10\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19");
fromBuilder.Append(" FROM {FolioApprovalLevel} \"enfolioapprovallevel10\"");
whereBuilder.Append(" WHERE ");
if (qpfoFolioApprovalId != 0) {
whereBuilder.Append("((\"enfolioapprovallevel10\".\"folioapprovalid\" = @qpfoFolioApprovalId) AND (\"enfolioapprovallevel10\".\"folioapprovalid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolioApprovalId", DbType.Int64, qpfoFolioApprovalId);
} else {
whereBuilder.Append("(\"enfolioapprovallevel10\".\"folioapprovalid\" IS NULL)");
}
whereBuilder.Append(" AND ");
if (qpfoId != 0) {
whereBuilder.Append("((\"enfolioapprovallevel10\".\"id\" <> @qpfoId) OR (\"enfolioapprovallevel10\".\"id\" IS NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoId", DbType.Int64, qpfoId);
} else {
whereBuilder.Append("(\"enfolioapprovallevel10\".\"id\" IS NOT NULL)");
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
RL_ecaf6a267327a661b83be973ba99d46b outParamList = new RL_ecaf6a267327a661b83be973ba99d46b();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query FolioIncorrectAssignment.GetFolioApprovalLevelsByFolioApprovalId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_ecaf6a267327a661b83be973ba99d46b _tmp = new RL_ecaf6a267327a661b83be973ba99d46b();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query FolioIncorrectAssignment.GetFolioApprovalLevelsByFolioApprovalId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_ecaf6a267327a661b83be973ba99d46b)_tmp;
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
// Query Function "GetFolioById" quhvtfC2s02JQzBaKOXA6g of Action "FolioIncorrectAssignment"
public static async Task<(RL_ae9182bb38290e8d92b0cbd2d4f71569,long)> datasetGetFolioById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolioApprovalLevel_Id,long qpfoFolio_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("FolioIncorrectAssignment.GetFolioById", "b56fe8aa-b6f0-4db3-8943-305a28e5c0ea");
using var queryActivity = activitySource.CreateAggregateQueryActivity("FolioIncorrectAssignment.GetFolioById", "b56fe8aa-b6f0-4db3-8943-305a28e5c0ea", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.Nncpd+m9okSV0xqCGlBr7Q/NodesNotShownInESpaceTree.quhvtfC2s02JQzBaKOXA6g, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, \"enfolio22\".\"folionumber\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, \"enfolioapproval12\".\"id\" o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, \"enfolioapprovallevel11\".\"id\" o30, \"enfolioapprovallevel11\".\"folioapprovalid\" o31, \"enfolioapprovallevel11\".\"levelnumber\" o32, \"enfolioapprovallevel11\".\"applicationroleid\" o33, \"enfolioapprovallevel11\".\"entrajobtitle\" o34, \"enfolioapprovallevel11\".\"entraroleid\" o35, \"enfolioapprovallevel11\".\"departmentid\" o36, \"enfolioapprovallevel11\".\"assignedto\" o37, \"enfolioapprovallevel11\".\"approvalstatusid\" o38, \"enfolioapprovallevel11\".\"ismandatory\" o39, \"enfolioapprovallevel11\".\"isreassigned\" o40, \"enfolioapprovallevel11\".\"approvedby\" o41, \"enfolioapprovallevel11\".\"approvedon\" o42, \"enfolioapprovallevel11\".\"canceledby\" o43, \"enfolioapprovallevel11\".\"canceledon\" o44, \"enfolioapprovallevel11\".\"rejectedby\" o45, \"enfolioapprovallevel11\".\"rejectedon\" o46, \"enfolioapprovallevel11\".\"issubstitutefor\" o47, \"enfolioapprovallevel11\".\"rejectreason\" o48, \"enfolioapprovallevel11\".\"isinvoiceapproval\" o49");
fromBuilder.Append(" FROM (({Folio} \"enfolio22\" Left JOIN {FolioApproval} \"enfolioapproval12\" ON (\"enfolio22\".\"id\" = \"enfolioapproval12\".\"folioid\"))  Left JOIN {FolioApprovalLevel} \"enfolioapprovallevel11\" ON (\"enfolioapproval12\".\"id\" = \"enfolioapprovallevel11\".\"folioapprovalid\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoFolio_Id != 0) {
whereBuilder.Append("((\"enfolio22\".\"id\" = @qpfoFolio_Id) AND (\"enfolio22\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolio_Id", DbType.Int64, qpfoFolio_Id);
} else {
whereBuilder.Append("(\"enfolio22\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND ");
if (qpfoFolioApprovalLevel_Id != 0) {
whereBuilder.Append("((\"enfolioapprovallevel11\".\"id\" = @qpfoFolioApprovalLevel_Id) AND (\"enfolioapprovallevel11\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolioApprovalLevel_Id", DbType.Int64, qpfoFolioApprovalLevel_Id);
} else {
whereBuilder.Append("(\"enfolioapprovallevel11\".\"id\" IS NULL)");
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
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query FolioIncorrectAssignment.GetFolioById.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query FolioIncorrectAssignment.GetFolioById.List", cancellationToken: cancellationToken);
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
