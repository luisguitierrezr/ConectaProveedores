namespace ssConectaProveedores;

public partial class Actions {
public class lcvApprovRejectFolio_IsFinishApproval : VarsBag {
public long inParamNextFolioApprovalLevelId;
public bool inParamIsExistsNextFolioApprovalLevel;
public EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord inParamFolioApprovalLevel;
public EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord inParamFolioApproval;
public EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord inParamFolio;
public long inParami_FolioId;
public RL_d5c1b2482ff109e80580d8b5fb920193 queryResGetSupplier_outParamList = new RL_d5c1b2482ff109e80580d8b5fb920193();
public long queryResGetSupplier_outParamCount = 0L;

public Actions.lcoFolioApprovalLevelCreateOrUpdate resFolioApprovalLevelCreateOrUpdate4 =  new Actions.lcoFolioApprovalLevelCreateOrUpdate();
public Actions.lcoFolioApprovalLevelCreateOrUpdate resFolioApprovalLevelCreateOrUpdate3 =  new Actions.lcoFolioApprovalLevelCreateOrUpdate();
public RL_547a563833923ab1f4eeebb2aa95ce1a queryResGetLevelsComplementAndAbove_outParamList = new RL_547a563833923ab1f4eeebb2aa95ce1a();
public long queryResGetLevelsComplementAndAbove_outParamCount = 0L;

public Actions.lcoFolioApprovalCreateOrUpdate resFolioApprovalCreateOrUpdate =  new Actions.lcoFolioApprovalCreateOrUpdate();
public Actions.lcoFolioCreateOrUpdate resFolioCreateOrUpdate3 =  new Actions.lcoFolioCreateOrUpdate();
public Actions.lcoFolioLogAdd resFolioLogAddApprove3 =  new Actions.lcoFolioLogAdd();
public Actions.lcoFolioLogAdd resFolioLogAddApprove2 =  new Actions.lcoFolioLogAdd();
public Actions.lcoFolioApprovalCreateOrUpdate resFolioApprovalCreateOrUpdate2 =  new Actions.lcoFolioApprovalCreateOrUpdate();
public Actions.lcoFolioCreateOrUpdate resFolioCreateOrUpdate =  new Actions.lcoFolioCreateOrUpdate();
public Actions.lcoFolioLogAdd resFolioLogAdd2 =  new Actions.lcoFolioLogAdd();
public lcvApprovRejectFolio_IsFinishApproval(long inParamNextFolioApprovalLevelId, bool inParamIsExistsNextFolioApprovalLevel, EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord inParamFolioApprovalLevel, EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord inParamFolioApproval, EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord inParamFolio, long inParami_FolioId) {
this.inParamNextFolioApprovalLevelId = inParamNextFolioApprovalLevelId;
this.inParamIsExistsNextFolioApprovalLevel = inParamIsExistsNextFolioApprovalLevel;
this.inParamFolioApprovalLevel = inParamFolioApprovalLevel;
this.inParamFolioApproval = inParamFolioApproval;
this.inParamFolio = inParamFolio;
this.inParami_FolioId = inParami_FolioId;
}
}
public class lcoApprovRejectFolio_IsFinishApproval : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public bool outParamo_StillHasApprovals = false;

public lcoApprovRejectFolio_IsFinishApproval() {
}
}
/// <summary>
/// Action <code>ApprovRejectFolio_IsFinishApproval</code> that represents the Service Studio action
///  <code>ApprovRejectFolio_IsFinishApproval</code> <p> Description: </p>
/// </summary>
public static async Task<(ST_046fb53ebbe142526d95e87ef1ae9711Structure,bool)> ActionApprovRejectFolio_IsFinishApproval(IRequestContext requestContext,long inParamNextFolioApprovalLevelId,bool inParamIsExistsNextFolioApprovalLevel,EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord inParamFolioApprovalLevel,EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord inParamFolioApproval,EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord inParamFolio,long inParami_FolioId,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
bool outParamo_StillHasApprovals = default;
lcoApprovRejectFolio_IsFinishApproval result = new lcoApprovRejectFolio_IsFinishApproval();
lcvApprovRejectFolio_IsFinishApproval localVars = new lcvApprovRejectFolio_IsFinishApproval(inParamNextFolioApprovalLevelId, inParamIsExistsNextFolioApprovalLevel, inParamFolioApprovalLevel, inParamFolioApproval, inParamFolio, inParami_FolioId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("ApprovRejectFolio_IsFinishApproval", "5aa87886-6849-4dfc-8349-3413375ad010"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("ApprovRejectFolio_IsFinishApproval", "5aa87886-6849-4dfc-8349-3413375ad010", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
do {
// not empty?
if((localVars.inParamIsExistsNextFolioApprovalLevel)) {
// DeleteFolioApprovalLevel
await ExtendedActions.DeleteFolioApprovalLevel(requestContext,localVars.inParamNextFolioApprovalLevelId,cancellationToken);

}

// FolioApprovalLevel.ApprovedBy = GetUserId
localVars.inParamFolioApprovalLevel.ssApprovedBy = BuiltInFunction.GetUserId ();

// FolioApprovalLevel.ApprovedOn = CurrDateTime
localVars.inParamFolioApprovalLevel.ssApprovedOn = BuiltInFunction.CurrDateTime ();

// FolioApprovalLevel.ApprovalStatusId = If
localVars.inParamFolioApprovalLevel.ssApprovalStatusId = (((localVars.inParamFolioApprovalLevel.ssApprovalStatusId==(ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("BjgcXy0kFU+8e5Ko3emFig"))).ssId)) ? ((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("85A3EYx6OkWpq0CAyB7XJw"))).ssId) : ((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("rkrV30n0cEiW8dttOKG0gw"))).ssId));
// FolioApprovalLevelCreateOrUpdate3
localVars.resFolioApprovalLevelCreateOrUpdate3.outParamId = await Actions.ActionFolioApprovalLevelCreateOrUpdate(requestContext,localVars.inParamFolioApprovalLevel,cancellationToken);

// FolioLogAddApprove2
localVars.resFolioLogAddApprove2.outParamId = await Actions.ActionFolioLogAdd(requestContext,new EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssFolioId = localVars.inParami_FolioId, ssMessage = (((((AppUtils.GetStringResource("QQ+nrfwry0+CQplHdpfGYw#Value.68060425.1", "Folio")+" ")+localVars.inParamFolio.ssFolioNumber)+" ")+AppUtils.GetStringResource("QQ+nrfwry0+CQplHdpfGYw#Value.1185244855.1", "approved"))+(((localVars.inParamFolioApprovalLevel.ssIsSubstituteFor!=BuiltInFunction.NullTextIdentifier ())) ? ((" "+AppUtils.GetStringResource("QQ+nrfwry0+CQplHdpfGYw#Value.182414732.1", "by a substitute."))) : ("."))), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssIsForSupplier = false },cancellationToken);

// HU13046?
if(((((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveDEV_HU13046])))&&(!localVars.inParamFolioApprovalLevel.ssIsInvoiceApproval)))) {
// Query datasetGetSupplier
cancellationToken.ThrowIfCancellationRequested();
int datasetGetSupplier_maxRecords = 1;
if (datasetGetSupplier_maxRecords < 1) datasetGetSupplier_maxRecords = 1;
int datasetGetSupplier_startIndex = 0;(localVars.queryResGetSupplier_outParamList,localVars.queryResGetSupplier_outParamCount) = await FuncActionApprovRejectFolio_IsFinishApproval.datasetGetSupplier(requestContext,datasetGetSupplier_maxRecords,datasetGetSupplier_startIndex,IterationMultiplicity.Never,localVars.inParamFolio.ssSupplierId,cancellationToken);

// Foregin supplier?
if(((localVars.queryResGetSupplier_outParamList.CurrentRec.ssENSupplier.ssPais!="MX"))) {
// Construction?
if(((localVars.inParamFolio.ssApprovalProcessTypeId==1))) {
break;
} else {
// Query datasetGetLevelsComplementAndAbove
cancellationToken.ThrowIfCancellationRequested();
int datasetGetLevelsComplementAndAbove_maxRecords = 999;
if (datasetGetLevelsComplementAndAbove_maxRecords < 1) datasetGetLevelsComplementAndAbove_maxRecords = 1;
int datasetGetLevelsComplementAndAbove_startIndex = 0;(localVars.queryResGetLevelsComplementAndAbove_outParamList,localVars.queryResGetLevelsComplementAndAbove_outParamCount) = await FuncActionApprovRejectFolio_IsFinishApproval.datasetGetLevelsComplementAndAbove(requestContext,datasetGetLevelsComplementAndAbove_maxRecords,datasetGetLevelsComplementAndAbove_startIndex,IterationMultiplicity.Single,localVars.inParamFolio.ssOrderId,cancellationToken);

// Foreach GetLevelsComplementAndAbove.List
localVars.queryResGetLevelsComplementAndAbove_outParamList.StartIteration();
try {while (!((localVars.queryResGetLevelsComplementAndAbove_outParamList.Eof))) {
// FolioApprovalLevelCreateOrUpdate4
localVars.resFolioApprovalLevelCreateOrUpdate4.outParamId = await Actions.ActionFolioApprovalLevelCreateOrUpdate(requestContext,new EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssFolioApprovalId = localVars.inParamFolioApproval.ssId, ssLevelNumber = ((localVars.inParamFolioApprovalLevel.ssLevelNumber+localVars.queryResGetLevelsComplementAndAbove_outParamList.CurrentRowNumber)+1), ssEntraJobTitle = localVars.queryResGetLevelsComplementAndAbove_outParamList.CurrentRec.ssENEntraRole.ssRoleName, ssEntraRoleId = localVars.queryResGetLevelsComplementAndAbove_outParamList.CurrentRec.ssENOrderApprovalLevel.ssEntraRoleId, ssAssignedTo = localVars.queryResGetLevelsComplementAndAbove_outParamList.CurrentRec.ssENOrderApprovalLevel.ssAssignedTo, ssApprovalStatusId = (((localVars.queryResGetLevelsComplementAndAbove_outParamList.CurrentRowNumber==0)) ? ((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId) : ((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("fEmjvBqEH0eHrf5_YVeo0g"))).ssId)), ssIsInvoiceApproval = true },cancellationToken);

localVars.queryResGetLevelsComplementAndAbove_outParamList.Advance();
}

} finally {
localVars.queryResGetLevelsComplementAndAbove_outParamList.EndIteration();
}

// Folio.FolioStatusId = PendingApprovalAccounting
localVars.inParamFolio.ssFolioStatusId = (ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("ZfpLpTdXy0CRfRTjg6qPeA"))).ssId;

// FolioApproval.CurrentLevel = FolioApproval.CurrentLevel + 1
localVars.inParamFolioApproval.ssCurrentLevel = (localVars.inParamFolioApproval.ssCurrentLevel+1);
// FolioApprovalCreateOrUpdate
localVars.resFolioApprovalCreateOrUpdate.outParamId = await Actions.ActionFolioApprovalCreateOrUpdate(requestContext,localVars.inParamFolioApproval,cancellationToken);

// FolioCreateOrUpdate3
localVars.resFolioCreateOrUpdate3.outParamId = await Actions.ActionFolioCreateOrUpdate(requestContext,localVars.inParamFolio,cancellationToken);

// FolioLogAdd2
localVars.resFolioLogAdd2.outParamId = await Actions.ActionFolioLogAdd(requestContext,new EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssFolioId = localVars.inParami_FolioId, ssMessage = ((((("Folio"+" ")+localVars.inParamFolio.ssFolioNumber)+" ")+AppUtils.GetStringResource("xLDvZgvS5kyLFWz+US50NA#Value.-748838405.1", "has been updated to Pending Approval Accounting status"))+"."), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssIsForSupplier = true },cancellationToken);

// o_StillHasApprovals = True
result.outParamo_StillHasApprovals=true;
break;
}

}

}

// FolioApproval.FinishedOn = CurrDateTime
localVars.inParamFolioApproval.ssFinishedOn = BuiltInFunction.CurrDateTime ();

// Folio.FolioStatusId = Approved
localVars.inParamFolio.ssFolioStatusId = (ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("sjaNMehoxESZWJutqvvRYA"))).ssId;

// FolioApproval.MaxLevel = FolioApproval.CurrentLevel
localVars.inParamFolioApproval.ssMaxLevel = localVars.inParamFolioApproval.ssCurrentLevel;
// FolioApprovalCreateOrUpdate2
localVars.resFolioApprovalCreateOrUpdate2.outParamId = await Actions.ActionFolioApprovalCreateOrUpdate(requestContext,localVars.inParamFolioApproval,cancellationToken);

// FolioCreateOrUpdate
localVars.resFolioCreateOrUpdate.outParamId = await Actions.ActionFolioCreateOrUpdate(requestContext,localVars.inParamFolio,cancellationToken);

// FolioLogAddApprove3
localVars.resFolioLogAddApprove3.outParamId = await Actions.ActionFolioLogAdd(requestContext,new EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssFolioId = localVars.inParami_FolioId, ssMessage = (((((AppUtils.GetStringResource("ESvUnGDeg02gBncWbewS1Q#Value.68060425.1", "Folio")+" ")+localVars.inParamFolio.ssFolioNumber)+" ")+AppUtils.GetStringResource("ESvUnGDeg02gBncWbewS1Q#Value.1455861801.1", "has been updated to Approved status"))+"."), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssIsForSupplier = true },cancellationToken);

} while(false)
;
// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
} //close CreateActionActivity using block
} // try

finally {
outParamo_Output = result.outParamo_Output;
outParamo_StillHasApprovals = result.outParamo_StillHasApprovals;
} // inner-finally
RETURN_STATEMENT:
return (outParamo_Output,outParamo_StillHasApprovals);
}

public static class FuncActionApprovRejectFolio_IsFinishApproval {

// Query Function "GetSupplier" zDROSxvUA0CsXlVopVEx3A of Action "ApprovRejectFolio_IsFinishApproval"
public static async Task<(RL_d5c1b2482ff109e80580d8b5fb920193,long)> datasetGetSupplier(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpsuId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ApprovRejectFolio_IsFinishApproval.GetSupplier", "4b4e34cc-d41b-4003-ac5e-5568a55131dc");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ApprovRejectFolio_IsFinishApproval.GetSupplier", "4b4e34cc-d41b-4003-ac5e-5568a55131dc", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.hnioWklo_E2DSTQTN1rQEA/NodesNotShownInESpaceTree.zDROSxvUA0CsXlVopVEx3A, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, \"ensupplier16\".\"pais\" o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27");
fromBuilder.Append(" FROM {Supplier} \"ensupplier16\"");
whereBuilder.Append(" WHERE ");
if (qpsuId != 0) {
whereBuilder.Append("((\"ensupplier16\".\"id\" = @qpsuId) AND (\"ensupplier16\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuId", DbType.Int64, qpsuId);
} else {
whereBuilder.Append("(\"ensupplier16\".\"id\" IS NULL)");
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
RL_d5c1b2482ff109e80580d8b5fb920193 outParamList = new RL_d5c1b2482ff109e80580d8b5fb920193();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ApprovRejectFolio_IsFinishApproval.GetSupplier.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_d5c1b2482ff109e80580d8b5fb920193 _tmp = new RL_d5c1b2482ff109e80580d8b5fb920193();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ApprovRejectFolio_IsFinishApproval.GetSupplier.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_d5c1b2482ff109e80580d8b5fb920193)_tmp;
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

private static async Task<RC_cb3079de01243d5d6995c7751ddd690b> datasetGetLevelsComplementAndAboveReadDbAsync(RC_cb3079de01243d5d6995c7751ddd690b rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENEntraRole.Read( r, ref index);
rec.ssENOrderApproval.Read( r, ref index);
rec.ssENOrderApprovalLevel.Read( r, ref index);
return rec;
}
// Query Function "GetLevelsComplementAndAbove" vGJzbm3qA0SFWbaT2JO6Bg of Action "ApprovRejectFolio_IsFinishApproval"
public static async Task<(RL_547a563833923ab1f4eeebb2aa95ce1a,long)> datasetGetLevelsComplementAndAbove(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderApproval_OrderId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ApprovRejectFolio_IsFinishApproval.GetLevelsComplementAndAbove", "6e7362bc-ea6d-4403-8559-b693d893ba06");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ApprovRejectFolio_IsFinishApproval.GetLevelsComplementAndAbove", "6e7362bc-ea6d-4403-8559-b693d893ba06", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.hnioWklo_E2DSTQTN1rQEA/NodesNotShownInESpaceTree.vGJzbm3qA0SFWbaT2JO6Bg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enentrarole12\".\"rolename\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, \"enorderapprovallevel7\".\"entraroleid\" o17, \"enorderapprovallevel7\".\"assignedto\" o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30");
fromBuilder.Append(" FROM (({OrderApprovalLevel} \"enorderapprovallevel7\" Left JOIN {EntraRole} \"enentrarole12\" ON (\"enorderapprovallevel7\".\"entraroleid\" = \"enentrarole12\".\"id\"))  Left JOIN {OrderApproval} \"enorderapproval7\" ON (\"enorderapprovallevel7\".\"orderapprovalid\" = \"enorderapproval7\".\"id\")) ");
whereBuilder.Append(" WHERE (\"enorderapprovallevel7\".\"levelnumber\" >= 2) AND ");
if (qporOrderApproval_OrderId != 0) {
whereBuilder.Append("((\"enorderapproval7\".\"orderid\" = @qporOrderApproval_OrderId) AND (\"enorderapproval7\".\"orderid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderApproval_OrderId", DbType.Int64, qporOrderApproval_OrderId);
} else {
whereBuilder.Append("(\"enorderapproval7\".\"orderid\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"enorderapprovallevel7\".\"levelnumber\" ASC ");
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
RL_547a563833923ab1f4eeebb2aa95ce1a outParamList = new RL_547a563833923ab1f4eeebb2aa95ce1a();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetLevelsComplementAndAboveReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, false, false, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, false, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ApprovRejectFolio_IsFinishApproval.GetLevelsComplementAndAbove.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_547a563833923ab1f4eeebb2aa95ce1a _tmp = new RL_547a563833923ab1f4eeebb2aa95ce1a();
_tmp.AlternateReadDbMethodAsync = datasetGetLevelsComplementAndAboveReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ApprovRejectFolio_IsFinishApproval.GetLevelsComplementAndAbove.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_547a563833923ab1f4eeebb2aa95ce1a)_tmp;
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
