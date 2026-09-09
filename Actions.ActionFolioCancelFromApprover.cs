namespace ssConectaProveedores;

public partial class Actions {
public class lcvFolioCancelFromApprover : VarsBag {
public long inParami_FolioId;
public long inParami_FolioApprovalLevelId;
public string inParami_CancelReason;
public Actions.lcoFolioCreateOrUpdate resFolioCreateOrUpdate =  new Actions.lcoFolioCreateOrUpdate();
public Actions.lcoFolioLogAdd resFolioLogAdd =  new Actions.lcoFolioLogAdd();
public RL_57593cd225237ead1eaddf28b138c8a4 queryResGetFolioById_outParamList = new RL_57593cd225237ead1eaddf28b138c8a4();
public long queryResGetFolioById_outParamCount = 0L;

public Actions.lcoFolioApprovalCreateOrUpdate resFolioApprovalCreateOrUpdate =  new Actions.lcoFolioApprovalCreateOrUpdate();
public Actions.lcoFolioApprovalLevelCreateOrUpdate resFolioApprovalLevelCreateOrUpdate =  new Actions.lcoFolioApprovalLevelCreateOrUpdate();
public Actions.lcoFolioApprovalLevelCreateOrUpdate resFolioApprovalLevelCreateOrUpdate2 =  new Actions.lcoFolioApprovalLevelCreateOrUpdate();
public Actions.lcoGetUserEntraRoleName resGetUserEntraRoleName =  new Actions.lcoGetUserEntraRoleName();
public Actions.lcoFolioCommentCreateOrUpdate resFolioCommentCreateOrUpdate =  new Actions.lcoFolioCommentCreateOrUpdate();
public RL_52e01c48f1745de5266c16d6fe2c0564 queryResGetFolioApprovalsByFolioId_outParamList = new RL_52e01c48f1745de5266c16d6fe2c0564();
public long queryResGetFolioApprovalsByFolioId_outParamCount = 0L;

public lcvFolioCancelFromApprover(long inParami_FolioId, long inParami_FolioApprovalLevelId, string inParami_CancelReason) {
this.inParami_FolioId = inParami_FolioId;
this.inParami_FolioApprovalLevelId = inParami_FolioApprovalLevelId;
this.inParami_CancelReason = inParami_CancelReason;
}
}
public class lcoFolioCancelFromApprover : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public lcoFolioCancelFromApprover() {
}
}
/// <summary>
/// Action <code>FolioCancelFromApprover</code> that represents the Service Studio action
///  <code>FolioCancelFromApprover</code> <p> Description: Action to Cancel Folio.</p>
/// </summary>
public static async Task<ST_046fb53ebbe142526d95e87ef1ae9711Structure> ActionFolioCancelFromApprover(IRequestContext requestContext,long inParami_FolioId,long inParami_FolioApprovalLevelId,string inParami_CancelReason,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
lcoFolioCancelFromApprover result = new lcoFolioCancelFromApprover();
lcvFolioCancelFromApprover localVars = new lcvFolioCancelFromApprover(inParami_FolioId, inParami_FolioApprovalLevelId, inParami_CancelReason);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("FolioCancelFromApprover", "a00d88ea-810f-4cc2-9f03-b210b3188175"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("FolioCancelFromApprover", "a00d88ea-810f-4cc2-9f03-b210b3188175", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetFolioById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioById_maxRecords = 1;
if (datasetGetFolioById_maxRecords < 1) datasetGetFolioById_maxRecords = 1;
int datasetGetFolioById_startIndex = 0;(localVars.queryResGetFolioById_outParamList,localVars.queryResGetFolioById_outParamCount) = await FuncActionFolioCancelFromApprover.datasetGetFolioById(requestContext,datasetGetFolioById_maxRecords,datasetGetFolioById_startIndex,IterationMultiplicity.Never,localVars.inParami_FolioApprovalLevelId,localVars.inParami_FolioId,cancellationToken);

// Empty?
if((localVars.queryResGetFolioById_outParamList.Empty)) {
// o_Output
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "Folio not found!"
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("jzTOyiwaJ0i1i0GJ5IKeBw#Value.1482511939.1", "Folio not found!");
} else {
// Level Not Approved?
if((((localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssApprovalStatusId!=(ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId)&&(localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssApprovalStatusId!=(ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("RvhtMOVzUke_jX9z3pm9HA"))).ssId)))) {
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "Folio cannot be updated!"
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("yKysCyTRLkKbgWvbbcg4OA#Value.1911675613.1", "Folio cannot be updated!");
} else {
// GetUserEntraRoleName
localVars.resGetUserEntraRoleName.outParamo_EntraRoleName = await Actions.ActionGetUserEntraRoleName(requestContext,"",cancellationToken);

// Folio Fields
// GetFolioById.List.Current.FolioApproval.FinishedOn = CurrDateTime
localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApproval.ssFinishedOn = BuiltInFunction.CurrDateTime ();

// GetFolioById.List.Current.FolioApprovalLevel.ApprovalStatusId = Canceled
localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssApprovalStatusId = (ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("YBJlnXS8SkKRSq9aruxhkg"))).ssId;

// GetFolioById.List.Current.FolioApprovalLevel.CanceledBy = GetUserId
localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssCanceledBy = BuiltInFunction.GetUserId ();

// GetFolioById.List.Current.FolioApprovalLevel.CanceledOn = CurrDateTime
localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssCanceledOn = BuiltInFunction.CurrDateTime ();

// GetFolioById.List.Current.Folio.FolioStatusId = Canceled
localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssFolioStatusId = (ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("cklscJNc0UyOgKXGwg51TQ"))).ssId;

// GetFolioById.List.Current.Folio.CanProveedorCancel = False
localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssCanProveedorCancel = false;

// GetFolioById.List.Current.FolioApprovalLevel.EntraJobTitle = GetUserEntraRoleName.o_EntraRoleName
localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssEntraJobTitle = localVars.resGetUserEntraRoleName.outParamo_EntraRoleName;

// GetFolioById.List.Current.FolioApprovalLevel.AssignedTo = If
localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssAssignedTo = (((localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssAssignedTo!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssAssignedTo) : (BuiltInFunction.GetUserId ()));
// FolioApprovalLevelCreateOrUpdate
localVars.resFolioApprovalLevelCreateOrUpdate.outParamId = await Actions.ActionFolioApprovalLevelCreateOrUpdate(requestContext,localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApprovalLevel,cancellationToken);

// FolioApprovalCreateOrUpdate
localVars.resFolioApprovalCreateOrUpdate.outParamId = await Actions.ActionFolioApprovalCreateOrUpdate(requestContext,localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApproval,cancellationToken);

// FolioCreateOrUpdate
localVars.resFolioCreateOrUpdate.outParamId = await Actions.ActionFolioCreateOrUpdate(requestContext,localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio,cancellationToken);

// CancelInvoiceByFolioId
await Actions.ActionCancelInvoiceByFolioId(requestContext,localVars.resFolioCreateOrUpdate.outParamId,cancellationToken);

// FolioCommentCreateOrUpdate
localVars.resFolioCommentCreateOrUpdate.outParamId = await Actions.ActionFolioCommentCreateOrUpdate(requestContext,new EN_a75639301080da49357fc03810b8d65fEntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssFolioId = localVars.inParami_FolioId, ssFolioApprovalLevelId = localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssId, ssApplicationRoleId = localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssApplicationRoleId, ssCreatedOn = BuiltInFunction.CurrDateTime (), ssCreatedBy = BuiltInFunction.GetUserId (), ssMessage = localVars.inParami_CancelReason, ssIsPublic = true },cancellationToken);

// FolioLogAdd
localVars.resFolioLogAdd.outParamId = await Actions.ActionFolioLogAdd(requestContext,new EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssFolioId = localVars.inParami_FolioId, ssMessage = (((((((AppUtils.GetStringResource("z8vj_CoUckaBXkOtDJlOBA#Value.2195684.1", "Form")+" ")+localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssFolioNumber)+" ")+AppUtils.GetStringResource("z8vj_CoUckaBXkOtDJlOBA#Value.666913335.1", "manually cancelled with the following comment:"))+" ")+localVars.inParami_CancelReason)+"."), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssIsError = true, ssIsForSupplier = true },cancellationToken);

// ClearOtherPossibleApprovers
await Actions.ActionClearOtherPossibleApprovers(requestContext,localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApproval.ssId,localVars.inParami_FolioApprovalLevelId,localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssLevelNumber,cancellationToken);

// Query datasetGetFolioApprovalsByFolioId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioApprovalsByFolioId_maxRecords = 0;
int datasetGetFolioApprovalsByFolioId_startIndex = 0;(localVars.queryResGetFolioApprovalsByFolioId_outParamList,localVars.queryResGetFolioApprovalsByFolioId_outParamCount) = await FuncActionFolioCancelFromApprover.datasetGetFolioApprovalsByFolioId(requestContext,datasetGetFolioApprovalsByFolioId_maxRecords,datasetGetFolioApprovalsByFolioId_startIndex,IterationMultiplicity.Single,localVars.inParami_FolioId,cancellationToken);

// Foreach GetFolioApprovalsByFolioId.List
localVars.queryResGetFolioApprovalsByFolioId_outParamList.StartIteration();
try {while (!((localVars.queryResGetFolioApprovalsByFolioId_outParamList.Eof))) {
// GetFolioApprovalsByFolioId.List.Current.FolioApprovalLevel.ApprovalStatusId = Pending
localVars.queryResGetFolioApprovalsByFolioId_outParamList.CurrentRec.ssENFolioApprovalLevel.ssApprovalStatusId = (ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("fEmjvBqEH0eHrf5_YVeo0g"))).ssId;
// FolioApprovalLevelCreateOrUpdate2
localVars.resFolioApprovalLevelCreateOrUpdate2.outParamId = await Actions.ActionFolioApprovalLevelCreateOrUpdate(requestContext,localVars.queryResGetFolioApprovalsByFolioId_outParamList.CurrentRec.ssENFolioApprovalLevel,cancellationToken);

localVars.queryResGetFolioApprovalsByFolioId_outParamList.Advance();
}

} finally {
localVars.queryResGetFolioApprovalsByFolioId_outParamList.EndIteration();
}

// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
// SendEmailApprovers_FolioCancel
await Actions.ActionSendEmailApprovers_FolioCancel(requestContext,localVars.inParami_FolioId,localVars.inParami_CancelReason,"",cancellationToken);

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

public static class FuncActionFolioCancelFromApprover {

private static async Task<RC_497f735a522829d94999357ea05280c6> datasetGetFolioByIdReadDbAsync(RC_497f735a522829d94999357ea05280c6 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFolio.Read( r, ref index);
rec.ssENFolioApproval.Read( r, ref index);
rec.ssENFolioApprovalLevel.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
return rec;
}
// Query Function "GetFolioById" 7V9LcAw3aUOxBm3YvtBUuA of Action "FolioCancelFromApprover"
public static async Task<(RL_57593cd225237ead1eaddf28b138c8a4,long)> datasetGetFolioById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolioApprovalLevel_Id,long qpfoFolio_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("FolioCancelFromApprover.GetFolioById", "704b5fed-370c-4369-b106-6dd8bed054b8");
using var queryActivity = activitySource.CreateAggregateQueryActivity("FolioCancelFromApprover.GetFolioById", "704b5fed-370c-4369-b106-6dd8bed054b8", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.6ogNoA+BwkyfA7IQsxiBdQ/NodesNotShownInESpaceTree.7V9LcAw3aUOxBm3YvtBUuA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enfolio37\".\"id\" o0, \"enfolio37\".\"isdraft\" o1, \"enfolio37\".\"folionumber\" o2, \"enfolio37\".\"canproveedorcancel\" o3, \"enfolio37\".\"orderid\" o4, \"enfolio37\".\"supplierid\" o5, \"enfolio37\".\"companyid\" o6, \"enfolio37\".\"foliostatusid\" o7, trim_scale(\"enfolio37\".\"totalamount\"::numeric) o8, trim_scale(\"enfolio37\".\"totaliva_amount\"::numeric) o9, trim_scale(\"enfolio37\".\"partialamount\"::numeric) o10, \"enfolio37\".\"currencyid\" o11, \"enfolio37\".\"firstapproveruserid\" o12, \"enfolio37\".\"approvalprocesstypeid\" o13, \"enfolio37\".\"sapentryerror\" o14, \"enfolio37\".\"createdby\" o15, \"enfolio37\".\"createdon\" o16, \"enfolio37\".\"updatedby\" o17, \"enfolio37\".\"updatedon\" o18, \"enfolio37\".\"minuteselected\" o19, \"enfolioapproval19\".\"id\" o20, \"enfolioapproval19\".\"folioid\" o21, \"enfolioapproval19\".\"approvalprocessid\" o22, \"enfolioapproval19\".\"processtypecode\" o23, \"enfolioapproval19\".\"approvalprocessversion\" o24, \"enfolioapproval19\".\"currentlevel\" o25, \"enfolioapproval19\".\"maxlevel\" o26, \"enfolioapproval19\".\"startedon\" o27, \"enfolioapproval19\".\"finishedon\" o28, \"enfolioapproval19\".\"regionid\" o29, \"enfolioapprovallevel18\".\"id\" o30, \"enfolioapprovallevel18\".\"folioapprovalid\" o31, \"enfolioapprovallevel18\".\"levelnumber\" o32, \"enfolioapprovallevel18\".\"applicationroleid\" o33, \"enfolioapprovallevel18\".\"entrajobtitle\" o34, \"enfolioapprovallevel18\".\"entraroleid\" o35, \"enfolioapprovallevel18\".\"departmentid\" o36, \"enfolioapprovallevel18\".\"assignedto\" o37, \"enfolioapprovallevel18\".\"approvalstatusid\" o38, \"enfolioapprovallevel18\".\"ismandatory\" o39, \"enfolioapprovallevel18\".\"isreassigned\" o40, \"enfolioapprovallevel18\".\"approvedby\" o41, \"enfolioapprovallevel18\".\"approvedon\" o42, \"enfolioapprovallevel18\".\"canceledby\" o43, \"enfolioapprovallevel18\".\"canceledon\" o44, \"enfolioapprovallevel18\".\"rejectedby\" o45, \"enfolioapprovallevel18\".\"rejectedon\" o46, \"enfolioapprovallevel18\".\"issubstitutefor\" o47, \"enfolioapprovallevel18\".\"rejectreason\" o48, \"enfolioapprovallevel18\".\"isinvoiceapproval\" o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78");
fromBuilder.Append(" FROM ((({Folio} \"enfolio37\" Left JOIN {FolioApproval} \"enfolioapproval19\" ON (\"enfolio37\".\"id\" = \"enfolioapproval19\".\"folioid\"))  Left JOIN {FolioApprovalLevel} \"enfolioapprovallevel18\" ON (\"enfolioapproval19\".\"id\" = \"enfolioapprovallevel18\".\"folioapprovalid\"))  Inner JOIN {OrderMain} \"enordermain43\" ON (\"enfolio37\".\"orderid\" = \"enordermain43\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoFolio_Id != 0) {
whereBuilder.Append("((\"enfolio37\".\"id\" = @qpfoFolio_Id) AND (\"enfolio37\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolio_Id", DbType.Int64, qpfoFolio_Id);
} else {
whereBuilder.Append("(\"enfolio37\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND ");
if (qpfoFolioApprovalLevel_Id != 0) {
whereBuilder.Append("((\"enfolioapprovallevel18\".\"id\" = @qpfoFolioApprovalLevel_Id) AND (\"enfolioapprovallevel18\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolioApprovalLevel_Id", DbType.Int64, qpfoFolioApprovalLevel_Id);
} else {
whereBuilder.Append("(\"enfolioapprovallevel18\".\"id\" IS NULL)");
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
RL_57593cd225237ead1eaddf28b138c8a4 outParamList = new RL_57593cd225237ead1eaddf28b138c8a4();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetFolioByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[4];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[2] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query FolioCancelFromApprover.GetFolioById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_57593cd225237ead1eaddf28b138c8a4 _tmp = new RL_57593cd225237ead1eaddf28b138c8a4();
_tmp.AlternateReadDbMethodAsync = datasetGetFolioByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query FolioCancelFromApprover.GetFolioById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_57593cd225237ead1eaddf28b138c8a4)_tmp;
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

private static async Task<RC_131b941598d8581e5466dbb966f5f0a8> datasetGetFolioApprovalsByFolioIdReadDbAsync(RC_131b941598d8581e5466dbb966f5f0a8 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFolioApproval.Read( r, ref index);
rec.ssENFolioApprovalLevel.Read( r, ref index);
return rec;
}
// Query Function "GetFolioApprovalsByFolioId" nM2p8Utvf0mMyL4oDY4CDg of Action "FolioCancelFromApprover"
public static async Task<(RL_52e01c48f1745de5266c16d6fe2c0564,long)> datasetGetFolioApprovalsByFolioId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolioApproval_FolioId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("FolioCancelFromApprover.GetFolioApprovalsByFolioId", "f1a9cd9c-6f4b-497f-8cc8-be280d8e020e");
using var queryActivity = activitySource.CreateAggregateQueryActivity("FolioCancelFromApprover.GetFolioApprovalsByFolioId", "f1a9cd9c-6f4b-497f-8cc8-be280d8e020e", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.6ogNoA+BwkyfA7IQsxiBdQ/NodesNotShownInESpaceTree.nM2p8Utvf0mMyL4oDY4CDg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, \"enfolioapprovallevel19\".\"id\" o10, \"enfolioapprovallevel19\".\"folioapprovalid\" o11, \"enfolioapprovallevel19\".\"levelnumber\" o12, \"enfolioapprovallevel19\".\"applicationroleid\" o13, \"enfolioapprovallevel19\".\"entrajobtitle\" o14, \"enfolioapprovallevel19\".\"entraroleid\" o15, \"enfolioapprovallevel19\".\"departmentid\" o16, \"enfolioapprovallevel19\".\"assignedto\" o17, \"enfolioapprovallevel19\".\"approvalstatusid\" o18, \"enfolioapprovallevel19\".\"ismandatory\" o19, \"enfolioapprovallevel19\".\"isreassigned\" o20, \"enfolioapprovallevel19\".\"approvedby\" o21, \"enfolioapprovallevel19\".\"approvedon\" o22, \"enfolioapprovallevel19\".\"canceledby\" o23, \"enfolioapprovallevel19\".\"canceledon\" o24, \"enfolioapprovallevel19\".\"rejectedby\" o25, \"enfolioapprovallevel19\".\"rejectedon\" o26, \"enfolioapprovallevel19\".\"issubstitutefor\" o27, \"enfolioapprovallevel19\".\"rejectreason\" o28, \"enfolioapprovallevel19\".\"isinvoiceapproval\" o29");
fromBuilder.Append(" FROM ({FolioApproval} \"enfolioapproval20\" Left JOIN {FolioApprovalLevel} \"enfolioapprovallevel19\" ON (\"enfolioapproval20\".\"id\" = \"enfolioapprovallevel19\".\"folioapprovalid\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoFolioApproval_FolioId != 0) {
whereBuilder.Append("((\"enfolioapproval20\".\"folioid\" = @qpfoFolioApproval_FolioId) AND (\"enfolioapproval20\".\"folioid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolioApproval_FolioId", DbType.Int64, qpfoFolioApproval_FolioId);
} else {
whereBuilder.Append("(\"enfolioapproval20\".\"folioid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enfolioapprovallevel19\".\"approvalstatusid\" = ");
whereBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId);
whereBuilder.Append(")");
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
outParamList.AlternateReadDbMethodAsync = datasetGetFolioApprovalsByFolioIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query FolioCancelFromApprover.GetFolioApprovalsByFolioId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_52e01c48f1745de5266c16d6fe2c0564 _tmp = new RL_52e01c48f1745de5266c16d6fe2c0564();
_tmp.AlternateReadDbMethodAsync = datasetGetFolioApprovalsByFolioIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query FolioCancelFromApprover.GetFolioApprovalsByFolioId.List", cancellationToken: cancellationToken);
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
