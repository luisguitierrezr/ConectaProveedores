namespace ssConectaProveedores;

public partial class Actions {
public class lcvApprovRejectFolio_InApproval : VarsBag {
public EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord inParamFolioApprovalLevel;
public EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord inParamFolioLog;
public EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord inParamFolioApproval;
public long inParamFolioId;
public int inParamNextApprovalLevelNumber;
public RL_52e01c48f1745de5266c16d6fe2c0564 queryResGetFolioApprovalLevelsByLevelNumber_outParamList = new RL_52e01c48f1745de5266c16d6fe2c0564();
public long queryResGetFolioApprovalLevelsByLevelNumber_outParamCount = 0L;

public Actions.lcoFolioApprovalCreateOrUpdate resFolioApprovalCreateOrUpdate =  new Actions.lcoFolioApprovalCreateOrUpdate();
public Actions.lcoFolioLogAdd resFolioLogAddApprove =  new Actions.lcoFolioLogAdd();
public Actions.lcoFolioApprovalLevelCreateOrUpdate resFolioApprovalLevelCreateOrUpdate6 =  new Actions.lcoFolioApprovalLevelCreateOrUpdate();
public lcvApprovRejectFolio_InApproval(EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord inParamFolioApprovalLevel, EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord inParamFolioLog, EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord inParamFolioApproval, long inParamFolioId, int inParamNextApprovalLevelNumber) {
this.inParamFolioApprovalLevel = inParamFolioApprovalLevel;
this.inParamFolioLog = inParamFolioLog;
this.inParamFolioApproval = inParamFolioApproval;
this.inParamFolioId = inParamFolioId;
this.inParamNextApprovalLevelNumber = inParamNextApprovalLevelNumber;
}
}
/// <summary>
/// Action <code>ApprovRejectFolio_InApproval</code> that represents the Service Studio action
///  <code>ApprovRejectFolio_InApproval</code> <p> Description: </p>
/// </summary>
public static async Task ActionApprovRejectFolio_InApproval(IRequestContext requestContext,EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord inParamFolioApprovalLevel,EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord inParamFolioLog,EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord inParamFolioApproval,long inParamFolioId,int inParamNextApprovalLevelNumber,CancellationToken cancellationToken) {
lcvApprovRejectFolio_InApproval localVars = new lcvApprovRejectFolio_InApproval(inParamFolioApprovalLevel, inParamFolioLog, inParamFolioApproval, inParamFolioId, inParamNextApprovalLevelNumber);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("ApprovRejectFolio_InApproval", "3376918c-83e9-4c24-9e52-c7d83b70627b"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("ApprovRejectFolio_InApproval", "3376918c-83e9-4c24-9e52-c7d83b70627b", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// FolioApproval.CurrentLevel = If
localVars.inParamFolioApproval.ssCurrentLevel = (((localVars.inParamNextApprovalLevelNumber==0)) ? ((localVars.inParamFolioApproval.ssCurrentLevel+1)) : (localVars.inParamNextApprovalLevelNumber));
// FolioApprovalLevelCreateOrUpdate6
localVars.resFolioApprovalLevelCreateOrUpdate6.outParamId = await Actions.ActionFolioApprovalLevelCreateOrUpdate(requestContext,localVars.inParamFolioApprovalLevel,cancellationToken);

// FolioLogAddApprove
localVars.resFolioLogAddApprove.outParamId = await Actions.ActionFolioLogAdd(requestContext,localVars.inParamFolioLog,cancellationToken);

if(((localVars.inParamNextApprovalLevelNumber!=0))) {
// Query datasetGetFolioApprovalLevelsByLevelNumber
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioApprovalLevelsByLevelNumber_maxRecords = 0;
int datasetGetFolioApprovalLevelsByLevelNumber_startIndex = 0;(localVars.queryResGetFolioApprovalLevelsByLevelNumber_outParamList,localVars.queryResGetFolioApprovalLevelsByLevelNumber_outParamCount) = await FuncActionApprovRejectFolio_InApproval.datasetGetFolioApprovalLevelsByLevelNumber(requestContext,datasetGetFolioApprovalLevelsByLevelNumber_maxRecords,datasetGetFolioApprovalLevelsByLevelNumber_startIndex,IterationMultiplicity.Multiple,localVars.inParamFolioId,localVars.inParamNextApprovalLevelNumber,cancellationToken);

// Foreach GetFolioApprovalLevelsByLevelNumber.List
localVars.queryResGetFolioApprovalLevelsByLevelNumber_outParamList.StartIteration();
try {while (!((localVars.queryResGetFolioApprovalLevelsByLevelNumber_outParamList.Eof))) {
// l_FormApprovalLevel
// GetFolioApprovalLevelsByLevelNumber.List.Current.FolioApprovalLevel.ApprovalStatusId = NotApproved
localVars.queryResGetFolioApprovalLevelsByLevelNumber_outParamList.CurrentRec.ssENFolioApprovalLevel.ssApprovalStatusId = (ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId;

// GetFolioApprovalLevelsByLevelNumber.List.Current.FolioApprovalLevel.RejectedBy = NullTextIdentifier
localVars.queryResGetFolioApprovalLevelsByLevelNumber_outParamList.CurrentRec.ssENFolioApprovalLevel.ssRejectedBy = BuiltInFunction.NullTextIdentifier ();

// GetFolioApprovalLevelsByLevelNumber.List.Current.FolioApprovalLevel.RejectedOn = NullDate
localVars.queryResGetFolioApprovalLevelsByLevelNumber_outParamList.CurrentRec.ssENFolioApprovalLevel.ssRejectedOn = BuiltInFunction.NullDate ();

// GetFolioApprovalLevelsByLevelNumber.List.Current.FolioApprovalLevel.ApprovedBy = NullTextIdentifier
localVars.queryResGetFolioApprovalLevelsByLevelNumber_outParamList.CurrentRec.ssENFolioApprovalLevel.ssApprovedBy = BuiltInFunction.NullTextIdentifier ();

// GetFolioApprovalLevelsByLevelNumber.List.Current.FolioApprovalLevel.ApprovedOn = NullDate
localVars.queryResGetFolioApprovalLevelsByLevelNumber_outParamList.CurrentRec.ssENFolioApprovalLevel.ssApprovedOn = BuiltInFunction.NullDate ();

// GetFolioApprovalLevelsByLevelNumber.List.Current.FolioApprovalLevel.RejectReason = ""
localVars.queryResGetFolioApprovalLevelsByLevelNumber_outParamList.CurrentRec.ssENFolioApprovalLevel.ssRejectReason = "";
localVars.queryResGetFolioApprovalLevelsByLevelNumber_outParamList.Advance();
}

} finally {
localVars.queryResGetFolioApprovalLevelsByLevelNumber_outParamList.EndIteration();
}

// CreateOrUpdateSomeFolioApprovalLevel
await ExtendedActions.CreateOrUpdateSomeFolioApprovalLevel(requestContext,(await RL_ecaf6a267327a661b83be973ba99d46b.ConvertAsync(localVars.queryResGetFolioApprovalLevelsByLevelNumber_outParamList, new RL_ecaf6a267327a661b83be973ba99d46b(), async (RC_131b941598d8581e5466dbb966f5f0a8 source, RC_0be8bae4cc285c0288822b663818cb6c target, CancellationToken cancellationToken) => {
target.ssENFolioApprovalLevel = source.ssENFolioApprovalLevel;
return target;
}, cancellationToken)),cancellationToken);

}

// FolioApprovalCreateOrUpdate
localVars.resFolioApprovalCreateOrUpdate.outParamId = await Actions.ActionFolioApprovalCreateOrUpdate(requestContext,localVars.inParamFolioApproval,cancellationToken);

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionApprovRejectFolio_InApproval {

private static async Task<RC_131b941598d8581e5466dbb966f5f0a8> datasetGetFolioApprovalLevelsByLevelNumberReadDbAsync(RC_131b941598d8581e5466dbb966f5f0a8 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFolioApproval.Read( r, ref index);
rec.ssENFolioApprovalLevel.Read( r, ref index);
return rec;
}
// Query Function "GetFolioApprovalLevelsByLevelNumber" _B7_DMDKZ0e2iseHnKciJQ of Action "ApprovRejectFolio_InApproval"
public static async Task<(RL_52e01c48f1745de5266c16d6fe2c0564,long)> datasetGetFolioApprovalLevelsByLevelNumber(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolioApproval_FolioId,int qpinFolioApprovalLevel_LevelNumber,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ApprovRejectFolio_InApproval.GetFolioApprovalLevelsByLevelNumber", "0cff1efc-cac0-4767-b68a-c7879ca72225");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ApprovRejectFolio_InApproval.GetFolioApprovalLevelsByLevelNumber", "0cff1efc-cac0-4767-b68a-c7879ca72225", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Multiple
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
selectBuilder.Append("/* /UserActions.jJF2M+mDJEyeUsfYO3Biew/NodesNotShownInESpaceTree._B7_DMDKZ0e2iseHnKciJQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, \"enfolioapprovallevel6\".\"id\" o10, \"enfolioapprovallevel6\".\"folioapprovalid\" o11, \"enfolioapprovallevel6\".\"levelnumber\" o12, \"enfolioapprovallevel6\".\"applicationroleid\" o13, \"enfolioapprovallevel6\".\"entrajobtitle\" o14, \"enfolioapprovallevel6\".\"entraroleid\" o15, \"enfolioapprovallevel6\".\"departmentid\" o16, \"enfolioapprovallevel6\".\"assignedto\" o17, \"enfolioapprovallevel6\".\"approvalstatusid\" o18, \"enfolioapprovallevel6\".\"ismandatory\" o19, \"enfolioapprovallevel6\".\"isreassigned\" o20, \"enfolioapprovallevel6\".\"approvedby\" o21, \"enfolioapprovallevel6\".\"approvedon\" o22, \"enfolioapprovallevel6\".\"canceledby\" o23, \"enfolioapprovallevel6\".\"canceledon\" o24, \"enfolioapprovallevel6\".\"rejectedby\" o25, \"enfolioapprovallevel6\".\"rejectedon\" o26, \"enfolioapprovallevel6\".\"issubstitutefor\" o27, \"enfolioapprovallevel6\".\"rejectreason\" o28, \"enfolioapprovallevel6\".\"isinvoiceapproval\" o29");
fromBuilder.Append(" FROM ({FolioApprovalLevel} \"enfolioapprovallevel6\" Left JOIN {FolioApproval} \"enfolioapproval7\" ON (\"enfolioapprovallevel6\".\"folioapprovalid\" = \"enfolioapproval7\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoFolioApproval_FolioId != 0) {
whereBuilder.Append("((\"enfolioapproval7\".\"folioid\" = @qpfoFolioApproval_FolioId) AND (\"enfolioapproval7\".\"folioid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolioApproval_FolioId", DbType.Int64, qpfoFolioApproval_FolioId);
} else {
whereBuilder.Append("(\"enfolioapproval7\".\"folioid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enfolioapprovallevel6\".\"levelnumber\" = @qpinFolioApprovalLevel_LevelNumber)");
sqlCmd.CreateParameterWithoutReplacements("@qpinFolioApprovalLevel_LevelNumber", DbType.Int32, qpinFolioApprovalLevel_LevelNumber);
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
RL_52e01c48f1745de5266c16d6fe2c0564 outParamList = new RL_52e01c48f1745de5266c16d6fe2c0564();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetFolioApprovalLevelsByLevelNumberReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ApprovRejectFolio_InApproval.GetFolioApprovalLevelsByLevelNumber.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_52e01c48f1745de5266c16d6fe2c0564 _tmp = new RL_52e01c48f1745de5266c16d6fe2c0564();
_tmp.AlternateReadDbMethodAsync = datasetGetFolioApprovalLevelsByLevelNumberReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ApprovRejectFolio_InApproval.GetFolioApprovalLevelsByLevelNumber.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_52e01c48f1745de5266c16d6fe2c0564)_tmp;
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
