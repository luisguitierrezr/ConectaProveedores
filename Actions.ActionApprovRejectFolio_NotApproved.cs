namespace ssConectaProveedores;

public partial class Actions {
public class lcvApprovRejectFolio_NotApproved : VarsBag {
public long inParami_FolioId;
public long inParamCurrFolioApprovalId;
public int inParamCurrLevelNumber;
public string inParami_Comment;
public EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord inParamFolioApprovalLevel;
public EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord inParamFolioApproval;
public EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord inParamFolio;
public string inParami_GetUserId;
public Actions.lcoFolioApprovalLevelCreateOrUpdate resPrevFolioApprovalLevelCreateOrUpdate =  new Actions.lcoFolioApprovalLevelCreateOrUpdate();
public Actions.lcoFolioLogAdd resFolioLogAddReject =  new Actions.lcoFolioLogAdd();
public Actions.lcoFolioApprovalCreateOrUpdate resFolioApprovalCreateOrUpdate =  new Actions.lcoFolioApprovalCreateOrUpdate();
public Actions.lcoFolioCreateOrUpdate resFolioCreateOrUpdate =  new Actions.lcoFolioCreateOrUpdate();
public Actions.lcoFolioApprovalLevelCreateOrUpdate resCurrFolioApprovalLevelCreateOrUpdate2 =  new Actions.lcoFolioApprovalLevelCreateOrUpdate();
public RL_8ba9481252bc5c90efb1f40f454c1643 queryResGetPrevFolioApprovalLevel_outParamList = new RL_8ba9481252bc5c90efb1f40f454c1643();
public long queryResGetPrevFolioApprovalLevel_outParamCount = 0L;

public Actions.lcoFolioCommentCreateOrUpdate resFolioCommentCreateOrUpdate =  new Actions.lcoFolioCommentCreateOrUpdate();
public lcvApprovRejectFolio_NotApproved(long inParami_FolioId, long inParamCurrFolioApprovalId, int inParamCurrLevelNumber, string inParami_Comment, EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord inParamFolioApprovalLevel, EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord inParamFolioApproval, EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord inParamFolio, string inParami_GetUserId) {
this.inParami_FolioId = inParami_FolioId;
this.inParamCurrFolioApprovalId = inParamCurrFolioApprovalId;
this.inParamCurrLevelNumber = inParamCurrLevelNumber;
this.inParami_Comment = inParami_Comment;
this.inParamFolioApprovalLevel = inParamFolioApprovalLevel;
this.inParamFolioApproval = inParamFolioApproval;
this.inParamFolio = inParamFolio;
this.inParami_GetUserId = inParami_GetUserId;
}
}
public class lcoApprovRejectFolio_NotApproved : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public lcoApprovRejectFolio_NotApproved() {
}
}
/// <summary>
/// Action <code>ApprovRejectFolio_NotApproved</code> that represents the Service Studio action
///  <code>ApprovRejectFolio_NotApproved</code> <p> Description: </p>
/// </summary>
public static async Task<ST_046fb53ebbe142526d95e87ef1ae9711Structure> ActionApprovRejectFolio_NotApproved(IRequestContext requestContext,long inParami_FolioId,long inParamCurrFolioApprovalId,int inParamCurrLevelNumber,string inParami_Comment,EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord inParamFolioApprovalLevel,EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord inParamFolioApproval,EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord inParamFolio,string inParami_GetUserId,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
lcoApprovRejectFolio_NotApproved result = new lcoApprovRejectFolio_NotApproved();
lcvApprovRejectFolio_NotApproved localVars = new lcvApprovRejectFolio_NotApproved(inParami_FolioId, inParamCurrFolioApprovalId, inParamCurrLevelNumber, inParami_Comment, inParamFolioApprovalLevel, inParamFolioApproval, inParamFolio, inParami_GetUserId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("ApprovRejectFolio_NotApproved", "7d0356c4-74b8-47d7-a038-4ac9b2e7cf99"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("ApprovRejectFolio_NotApproved", "7d0356c4-74b8-47d7-a038-4ac9b2e7cf99", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetPrevFolioApprovalLevel
cancellationToken.ThrowIfCancellationRequested();
int datasetGetPrevFolioApprovalLevel_maxRecords = 1;
if (datasetGetPrevFolioApprovalLevel_maxRecords < 1) datasetGetPrevFolioApprovalLevel_maxRecords = 1;
int datasetGetPrevFolioApprovalLevel_startIndex = 0;(localVars.queryResGetPrevFolioApprovalLevel_outParamList,localVars.queryResGetPrevFolioApprovalLevel_outParamCount) = await FuncActionApprovRejectFolio_NotApproved.datasetGetPrevFolioApprovalLevel(requestContext,datasetGetPrevFolioApprovalLevel_maxRecords,datasetGetPrevFolioApprovalLevel_startIndex,IterationMultiplicity.Never,localVars.inParamCurrFolioApprovalId,localVars.inParamCurrLevelNumber,cancellationToken);

if((localVars.queryResGetPrevFolioApprovalLevel_outParamList.Empty)) {
// o_Output
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "Rejection not available, since there are no previous approval levels."
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("FIgwiG6Pnkyx3gw3gjb_tw#Value.-324912941.1", "Rejection not available, since there are no previous approval levels.");
} else {
// FolioApprovalLevel.RejectedBy = i_GetUserId
localVars.inParamFolioApprovalLevel.ssRejectedBy = localVars.inParami_GetUserId;

// FolioApprovalLevel.RejectedOn = CurrDateTime
localVars.inParamFolioApprovalLevel.ssRejectedOn = BuiltInFunction.CurrDateTime ();

// FolioApprovalLevel.ApprovalStatusId = Rejected
localVars.inParamFolioApprovalLevel.ssApprovalStatusId = (ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("rm4bAZ7dOEqgMcZKM9wLxg"))).ssId;

// FolioApproval.CurrentLevel = FolioApproval.CurrentLevel - 1
localVars.inParamFolioApproval.ssCurrentLevel = (localVars.inParamFolioApproval.ssCurrentLevel-1);

// GetPrevFolioApprovalLevel.List.Current.FolioApprovalLevel.ApprovalStatusId = NotApproved
localVars.queryResGetPrevFolioApprovalLevel_outParamList.CurrentRec.ssENFolioApprovalLevel.ssApprovalStatusId = (ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId;

// FolioApprovalLevel.AssignedTo = If
localVars.inParamFolioApprovalLevel.ssAssignedTo = (((localVars.inParamFolioApprovalLevel.ssAssignedTo!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.inParamFolioApprovalLevel.ssAssignedTo) : (localVars.inParami_GetUserId));

// GetPrevFolioApprovalLevel.List.Current.FolioApprovalLevel.ApprovedBy = NullTextIdentifier
localVars.queryResGetPrevFolioApprovalLevel_outParamList.CurrentRec.ssENFolioApprovalLevel.ssApprovedBy = BuiltInFunction.NullTextIdentifier ();

// GetPrevFolioApprovalLevel.List.Current.FolioApprovalLevel.ApprovedOn = NullDate
localVars.queryResGetPrevFolioApprovalLevel_outParamList.CurrentRec.ssENFolioApprovalLevel.ssApprovedOn = BuiltInFunction.NullDate ();

// FolioApprovalLevel.RejectReason = i_Comment
localVars.inParamFolioApprovalLevel.ssRejectReason = localVars.inParami_Comment;
// CurrFolioApprovalLevelCreateOrUpdate2
localVars.resCurrFolioApprovalLevelCreateOrUpdate2.outParamId = await Actions.ActionFolioApprovalLevelCreateOrUpdate(requestContext,localVars.inParamFolioApprovalLevel,cancellationToken);

// FolioCommentCreateOrUpdate
localVars.resFolioCommentCreateOrUpdate.outParamId = await Actions.ActionFolioCommentCreateOrUpdate(requestContext,new EN_a75639301080da49357fc03810b8d65fEntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssFolioId = localVars.inParami_FolioId, ssFolioApprovalLevelId = localVars.inParamFolioApprovalLevel.ssId, ssCommentTypeId = (ENCommentTypeEntity.GetRecordByKey(ObjectKey.Parse("r_wbgKYi4kyW+X8YHLObXA"))).ssId, ssApplicationRoleId = localVars.inParamFolioApprovalLevel.ssApplicationRoleId, ssCreatedOn = BuiltInFunction.CurrDateTime (), ssCreatedBy = localVars.inParami_GetUserId, ssMessage = localVars.inParami_Comment, ssIsPublic = true },cancellationToken);

// FolioLogAddReject
localVars.resFolioLogAddReject.outParamId = await Actions.ActionFolioLogAdd(requestContext,new EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssFolioId = localVars.inParami_FolioId, ssMessage = ((((((((AppUtils.GetStringResource("6i0skrbLqk6a+pugw+DaRA#Value.2195684.1", "Form")+" ")+localVars.inParamFolio.ssFolioNumber)+" ")+AppUtils.GetStringResource("6i0skrbLqk6a+pugw+DaRA#Value.-608496514.1", "rejected"))+(((localVars.inParamFolioApprovalLevel.ssIsSubstituteFor!=BuiltInFunction.NullTextIdentifier ())) ? (((" "+AppUtils.GetStringResource("6i0skrbLqk6a+pugw+DaRA#Value.1391357666.1", "by a substitute"))+" ")) : (" ")))+AppUtils.GetStringResource("6i0skrbLqk6a+pugw+DaRA#Value.448016147.1", "with the following comment:"))+" ")+localVars.inParami_Comment), ssCreatedBy = localVars.inParami_GetUserId, ssCreatedOn = BuiltInFunction.CurrDateTime (), ssIsError = true, ssIsForSupplier = false },cancellationToken);

// Reject from first cxp approver?
if(((localVars.inParamFolioApprovalLevel.ssIsInvoiceApproval&&(!localVars.queryResGetPrevFolioApprovalLevel_outParamList.CurrentRec.ssENFolioApprovalLevel.ssIsInvoiceApproval)))) {
// Folio.FolioStatusId = IncorrectInvoice
localVars.inParamFolio.ssFolioStatusId = (ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("OvBzn51W8EyWJHs2cALRmQ"))).ssId;

// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
// FolioCreateOrUpdate
localVars.resFolioCreateOrUpdate.outParamId = await Actions.ActionFolioCreateOrUpdate(requestContext,localVars.inParamFolio,cancellationToken);

// CommitTransaction
await ExtendedActions.CommitTransaction(requestContext,cancellationToken);

{
    using (AppHealthProvider.CreateGlobalEventTriggerMetric("OnSendEmailSupplierFolioInvoiceRejected", "7f69d524-a5d0-4057-90ac-778ab6e9e303"))
    using (activitySource.CreateTriggerEventActivity("OnSendEmailSupplierFolioInvoiceRejected", "7f69d524-a5d0-4057-90ac-778ab6e9e303", "79e14446-5ffa-490c-bb2c-b0c9b5300bd6", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828")) {
        var input = new EventPayloads.GlobalEventOnSendEmailSupplierFolioInvoiceRejectedPayload() {inParami_FolioId = localVars.inParami_FolioId,inParami_RejectMotive1 = localVars.inParami_Comment};

        var eventPublisher = ServiceLocator.GetService<IEventPublisher>();
        await eventPublisher.PublishEventAsync("OnSendEmailSupplierFolioInvoiceRejected", "79e14446-5ffa-490c-bb2c-b0c9b5300bd6", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828", input, cancellationToken);
    }
}

} else {
// PrevFolioApprovalLevelCreateOrUpdate
localVars.resPrevFolioApprovalLevelCreateOrUpdate.outParamId = await Actions.ActionFolioApprovalLevelCreateOrUpdate(requestContext,localVars.queryResGetPrevFolioApprovalLevel_outParamList.CurrentRec.ssENFolioApprovalLevel,cancellationToken);

// FolioApprovalCreateOrUpdate
localVars.resFolioApprovalCreateOrUpdate.outParamId = await Actions.ActionFolioApprovalCreateOrUpdate(requestContext,localVars.inParamFolioApproval,cancellationToken);

// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
// SendFolioNextApproverEmailOnReject
await Actions.ActionSendEmailApprover_RejectFolioPrevApprover(requestContext,localVars.inParami_FolioId,cancellationToken);

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

public static class FuncActionApprovRejectFolio_NotApproved {

private static async Task<RC_c4212a2ad9aed3b4ecb882ed30f5e868> datasetGetPrevFolioApprovalLevelReadDbAsync(RC_c4212a2ad9aed3b4ecb882ed30f5e868 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApplicationRole.Read( r, ref index);
rec.ssENFolio.Read( r, ref index);
rec.ssENFolioApproval.Read( r, ref index);
rec.ssENFolioApprovalLevel.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
return rec;
}
// Query Function "GetPrevFolioApprovalLevel" AgH85yLXYUW_6QLNUGB0_w of Action "ApprovRejectFolio_NotApproved"
public static async Task<(RL_8ba9481252bc5c90efb1f40f454c1643,long)> datasetGetPrevFolioApprovalLevel(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolioApproval_Id,int qpinCurrLevelNumber,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ApprovRejectFolio_NotApproved.GetPrevFolioApprovalLevel", "e7fc0102-d722-4561-bfe9-02cd506074ff");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ApprovRejectFolio_NotApproved.GetPrevFolioApprovalLevel", "e7fc0102-d722-4561-bfe9-02cd506074ff", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.xFYDfbh010egOErJsufPmQ/NodesNotShownInESpaceTree.AgH85yLXYUW_6QLNUGB0_w, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, \"enfolioapprovallevel12\".\"id\" o37, \"enfolioapprovallevel12\".\"folioapprovalid\" o38, \"enfolioapprovallevel12\".\"levelnumber\" o39, \"enfolioapprovallevel12\".\"applicationroleid\" o40, \"enfolioapprovallevel12\".\"entrajobtitle\" o41, \"enfolioapprovallevel12\".\"entraroleid\" o42, \"enfolioapprovallevel12\".\"departmentid\" o43, \"enfolioapprovallevel12\".\"assignedto\" o44, \"enfolioapprovallevel12\".\"approvalstatusid\" o45, \"enfolioapprovallevel12\".\"ismandatory\" o46, \"enfolioapprovallevel12\".\"isreassigned\" o47, \"enfolioapprovallevel12\".\"approvedby\" o48, \"enfolioapprovallevel12\".\"approvedon\" o49, \"enfolioapprovallevel12\".\"canceledby\" o50, \"enfolioapprovallevel12\".\"canceledon\" o51, \"enfolioapprovallevel12\".\"rejectedby\" o52, \"enfolioapprovallevel12\".\"rejectedon\" o53, \"enfolioapprovallevel12\".\"issubstitutefor\" o54, \"enfolioapprovallevel12\".\"rejectreason\" o55, \"enfolioapprovallevel12\".\"isinvoiceapproval\" o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85");
fromBuilder.Append(" FROM (((({Folio} \"enfolio24\" Left JOIN {FolioApproval} \"enfolioapproval13\" ON (\"enfolio24\".\"id\" = \"enfolioapproval13\".\"folioid\"))  Left JOIN {FolioApprovalLevel} \"enfolioapprovallevel12\" ON (\"enfolioapproval13\".\"id\" = \"enfolioapprovallevel12\".\"folioapprovalid\"))  Left JOIN {ApplicationRole} \"enapplicationrole11\" ON (\"enfolioapprovallevel12\".\"applicationroleid\" = \"enapplicationrole11\".\"id\"))  Left JOIN {OrderMain} \"enordermain37\" ON (\"enfolio24\".\"orderid\" = \"enordermain37\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoFolioApproval_Id != 0) {
whereBuilder.Append("((\"enfolioapproval13\".\"id\" = @qpfoFolioApproval_Id) AND (\"enfolioapproval13\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolioApproval_Id", DbType.Int64, qpfoFolioApproval_Id);
} else {
whereBuilder.Append("(\"enfolioapproval13\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND (\"enfolioapprovallevel12\".\"levelnumber\" < @qpinCurrLevelNumber)");
orderByBuilder.Append(" ORDER BY \"enfolioapprovallevel12\".\"levelnumber\" DESC ");
sqlCmd.CreateParameterWithoutReplacements("@qpinCurrLevelNumber", DbType.Int32, qpinCurrLevelNumber);
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
RL_8ba9481252bc5c90efb1f40f454c1643 outParamList = new RL_8ba9481252bc5c90efb1f40f454c1643();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetPrevFolioApprovalLevelReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[5];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ApprovRejectFolio_NotApproved.GetPrevFolioApprovalLevel.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_8ba9481252bc5c90efb1f40f454c1643 _tmp = new RL_8ba9481252bc5c90efb1f40f454c1643();
_tmp.AlternateReadDbMethodAsync = datasetGetPrevFolioApprovalLevelReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ApprovRejectFolio_NotApproved.GetPrevFolioApprovalLevel.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_8ba9481252bc5c90efb1f40f454c1643)_tmp;
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
