namespace ssConectaProveedores;

public partial class Actions {
public class lcvCancelFolioSAEC : VarsBag {
public long inParami_FolioId;
public Actions.lcoFolioApprovalCreateOrUpdate resFolioApprovalCreateOrUpdate =  new Actions.lcoFolioApprovalCreateOrUpdate();
public RL_f2334acea7cfd80330b429c488fa4f97 queryResGetFolioById_outParamList = new RL_f2334acea7cfd80330b429c488fa4f97();
public long queryResGetFolioById_outParamCount = 0L;

public Actions.lcoFolioCreateOrUpdate resFolioCreateOrUpdate =  new Actions.lcoFolioCreateOrUpdate();
public RL_52e01c48f1745de5266c16d6fe2c0564 queryResGetFolioApprovalsByFolioId_outParamList = new RL_52e01c48f1745de5266c16d6fe2c0564();
public long queryResGetFolioApprovalsByFolioId_outParamCount = 0L;

public Actions.lcoFolioApprovalLevelCreateOrUpdate resFolioApprovalLevelCreateOrUpdate =  new Actions.lcoFolioApprovalLevelCreateOrUpdate();
public lcvCancelFolioSAEC(long inParami_FolioId) {
this.inParami_FolioId = inParami_FolioId;
}
}
public class lcoCancelFolioSAEC : VarsBag {
public string outParamo_FolioNumber = "";

public lcoCancelFolioSAEC() {
}
}
/// <summary>
/// Action <code>CancelFolioSAEC</code> that represents the Service Studio action
///  <code>CancelFolioSAEC</code> <p> Description: </p>
/// </summary>
public static async Task<string> ActionCancelFolioSAEC(IRequestContext requestContext,long inParami_FolioId,CancellationToken cancellationToken) {
string outParamo_FolioNumber = default;
lcoCancelFolioSAEC result = new lcoCancelFolioSAEC();
lcvCancelFolioSAEC localVars = new lcvCancelFolioSAEC(inParami_FolioId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("CancelFolioSAEC", "5af0cebf-eec1-491f-88a3-70cb3c09ae74"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("CancelFolioSAEC", "5af0cebf-eec1-491f-88a3-70cb3c09ae74", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetFolioById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioById_maxRecords = 1;
if (datasetGetFolioById_maxRecords < 1) datasetGetFolioById_maxRecords = 1;
int datasetGetFolioById_startIndex = 0;(localVars.queryResGetFolioById_outParamList,localVars.queryResGetFolioById_outParamCount) = await FuncActionCancelFolioSAEC.datasetGetFolioById(requestContext,datasetGetFolioById_maxRecords,datasetGetFolioById_startIndex,IterationMultiplicity.Never,localVars.inParami_FolioId,cancellationToken);

// GetFolioById.List.Current.Folio.FolioStatusId = Canceled
localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssFolioStatusId = (ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("cklscJNc0UyOgKXGwg51TQ"))).ssId;

// GetFolioById.List.Current.Folio.CanProveedorCancel = False
localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssCanProveedorCancel = false;

// GetFolioById.List.Current.FolioApproval.FinishedOn = CurrDateTime
localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApproval.ssFinishedOn = BuiltInFunction.CurrDateTime ();

// GetFolioById.List.Current.FolioApproval.MaxLevel = GetFolioById.List.Current.FolioApproval.CurrentLevel
localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApproval.ssMaxLevel = localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApproval.ssCurrentLevel;
// FolioCreateOrUpdate
localVars.resFolioCreateOrUpdate.outParamId = await Actions.ActionFolioCreateOrUpdate(requestContext,localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio,cancellationToken);

// FolioApprovalCreateOrUpdate
localVars.resFolioApprovalCreateOrUpdate.outParamId = await Actions.ActionFolioApprovalCreateOrUpdate(requestContext,localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApproval,cancellationToken);

// Query datasetGetFolioApprovalsByFolioId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioApprovalsByFolioId_maxRecords = 0;
int datasetGetFolioApprovalsByFolioId_startIndex = 0;(localVars.queryResGetFolioApprovalsByFolioId_outParamList,localVars.queryResGetFolioApprovalsByFolioId_outParamCount) = await FuncActionCancelFolioSAEC.datasetGetFolioApprovalsByFolioId(requestContext,datasetGetFolioApprovalsByFolioId_maxRecords,datasetGetFolioApprovalsByFolioId_startIndex,IterationMultiplicity.Single,localVars.inParami_FolioId,cancellationToken);

// Foreach GetFolioApprovalsByFolioId.List
localVars.queryResGetFolioApprovalsByFolioId_outParamList.StartIteration();
try {while (!((localVars.queryResGetFolioApprovalsByFolioId_outParamList.Eof))) {
// GetFolioApprovalsByFolioId.List.Current.FolioApprovalLevel.ApprovalStatusId = Pending
localVars.queryResGetFolioApprovalsByFolioId_outParamList.CurrentRec.ssENFolioApprovalLevel.ssApprovalStatusId = (ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("fEmjvBqEH0eHrf5_YVeo0g"))).ssId;
// FolioApprovalLevelCreateOrUpdate
localVars.resFolioApprovalLevelCreateOrUpdate.outParamId = await Actions.ActionFolioApprovalLevelCreateOrUpdate(requestContext,localVars.queryResGetFolioApprovalsByFolioId_outParamList.CurrentRec.ssENFolioApprovalLevel,cancellationToken);

localVars.queryResGetFolioApprovalsByFolioId_outParamList.Advance();
}

} finally {
localVars.queryResGetFolioApprovalsByFolioId_outParamList.EndIteration();
}

// CancelInvoiceByFolioId
await Actions.ActionCancelInvoiceByFolioId(requestContext,localVars.inParami_FolioId,cancellationToken);

// o_FolioNumber = GetFolioById.List.Current.Folio.FolioNumber
result.outParamo_FolioNumber=localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssFolioNumber;
} //close CreateActionActivity using block
} // try

finally {
outParamo_FolioNumber = result.outParamo_FolioNumber;
} // inner-finally
RETURN_STATEMENT:
return outParamo_FolioNumber;
}

public static class FuncActionCancelFolioSAEC {

private static async Task<RC_d62ad7391a87381616a77aeae304e183> datasetGetFolioByIdReadDbAsync(RC_d62ad7391a87381616a77aeae304e183 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFolio.Read( r, ref index);
rec.ssENFolioApproval.Read( r, ref index);
return rec;
}
// Query Function "GetFolioById" kIr8YbLXOUurIYeLZQKG7Q of Action "CancelFolioSAEC"
public static async Task<(RL_f2334acea7cfd80330b429c488fa4f97,long)> datasetGetFolioById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolio_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("CancelFolioSAEC.GetFolioById", "61fc8a90-d7b2-4b39-ab21-878b650286ed");
using var queryActivity = activitySource.CreateAggregateQueryActivity("CancelFolioSAEC.GetFolioById", "61fc8a90-d7b2-4b39-ab21-878b650286ed", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.v87wWsHuH0mIo3DLPAmudA/NodesNotShownInESpaceTree.kIr8YbLXOUurIYeLZQKG7Q, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enfolio16\".\"id\" o0, \"enfolio16\".\"isdraft\" o1, \"enfolio16\".\"folionumber\" o2, \"enfolio16\".\"canproveedorcancel\" o3, \"enfolio16\".\"orderid\" o4, \"enfolio16\".\"supplierid\" o5, \"enfolio16\".\"companyid\" o6, \"enfolio16\".\"foliostatusid\" o7, trim_scale(\"enfolio16\".\"totalamount\"::numeric) o8, trim_scale(\"enfolio16\".\"totaliva_amount\"::numeric) o9, trim_scale(\"enfolio16\".\"partialamount\"::numeric) o10, \"enfolio16\".\"currencyid\" o11, \"enfolio16\".\"firstapproveruserid\" o12, \"enfolio16\".\"approvalprocesstypeid\" o13, \"enfolio16\".\"sapentryerror\" o14, \"enfolio16\".\"createdby\" o15, \"enfolio16\".\"createdon\" o16, \"enfolio16\".\"updatedby\" o17, \"enfolio16\".\"updatedon\" o18, \"enfolio16\".\"minuteselected\" o19, \"enfolioapproval10\".\"id\" o20, \"enfolioapproval10\".\"folioid\" o21, \"enfolioapproval10\".\"approvalprocessid\" o22, \"enfolioapproval10\".\"processtypecode\" o23, \"enfolioapproval10\".\"approvalprocessversion\" o24, \"enfolioapproval10\".\"currentlevel\" o25, \"enfolioapproval10\".\"maxlevel\" o26, \"enfolioapproval10\".\"startedon\" o27, \"enfolioapproval10\".\"finishedon\" o28, \"enfolioapproval10\".\"regionid\" o29");
fromBuilder.Append(" FROM ({Folio} \"enfolio16\" Left JOIN {FolioApproval} \"enfolioapproval10\" ON (\"enfolio16\".\"id\" = \"enfolioapproval10\".\"folioid\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoFolio_Id != 0) {
whereBuilder.Append("((\"enfolio16\".\"id\" = @qpfoFolio_Id) AND (\"enfolio16\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolio_Id", DbType.Int64, qpfoFolio_Id);
} else {
whereBuilder.Append("(\"enfolio16\".\"id\" IS NULL)");
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
RL_f2334acea7cfd80330b429c488fa4f97 outParamList = new RL_f2334acea7cfd80330b429c488fa4f97();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetFolioByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query CancelFolioSAEC.GetFolioById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_f2334acea7cfd80330b429c488fa4f97 _tmp = new RL_f2334acea7cfd80330b429c488fa4f97();
_tmp.AlternateReadDbMethodAsync = datasetGetFolioByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query CancelFolioSAEC.GetFolioById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_f2334acea7cfd80330b429c488fa4f97)_tmp;
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
// Query Function "GetFolioApprovalsByFolioId" U6UvhPh+3UGtzbg8efrTzA of Action "CancelFolioSAEC"
public static async Task<(RL_52e01c48f1745de5266c16d6fe2c0564,long)> datasetGetFolioApprovalsByFolioId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolioApproval_FolioId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("CancelFolioSAEC.GetFolioApprovalsByFolioId", "842fa553-7ef8-41dd-adcd-b83c79fad3cc");
using var queryActivity = activitySource.CreateAggregateQueryActivity("CancelFolioSAEC.GetFolioApprovalsByFolioId", "842fa553-7ef8-41dd-adcd-b83c79fad3cc", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.v87wWsHuH0mIo3DLPAmudA/NodesNotShownInESpaceTree.U6UvhPh+3UGtzbg8efrTzA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, \"enfolioapprovallevel9\".\"id\" o10, \"enfolioapprovallevel9\".\"folioapprovalid\" o11, \"enfolioapprovallevel9\".\"levelnumber\" o12, \"enfolioapprovallevel9\".\"applicationroleid\" o13, \"enfolioapprovallevel9\".\"entrajobtitle\" o14, \"enfolioapprovallevel9\".\"entraroleid\" o15, \"enfolioapprovallevel9\".\"departmentid\" o16, \"enfolioapprovallevel9\".\"assignedto\" o17, \"enfolioapprovallevel9\".\"approvalstatusid\" o18, \"enfolioapprovallevel9\".\"ismandatory\" o19, \"enfolioapprovallevel9\".\"isreassigned\" o20, \"enfolioapprovallevel9\".\"approvedby\" o21, \"enfolioapprovallevel9\".\"approvedon\" o22, \"enfolioapprovallevel9\".\"canceledby\" o23, \"enfolioapprovallevel9\".\"canceledon\" o24, \"enfolioapprovallevel9\".\"rejectedby\" o25, \"enfolioapprovallevel9\".\"rejectedon\" o26, \"enfolioapprovallevel9\".\"issubstitutefor\" o27, \"enfolioapprovallevel9\".\"rejectreason\" o28, \"enfolioapprovallevel9\".\"isinvoiceapproval\" o29");
fromBuilder.Append(" FROM ({FolioApproval} \"enfolioapproval11\" Left JOIN {FolioApprovalLevel} \"enfolioapprovallevel9\" ON (\"enfolioapproval11\".\"id\" = \"enfolioapprovallevel9\".\"folioapprovalid\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoFolioApproval_FolioId != 0) {
whereBuilder.Append("((\"enfolioapproval11\".\"folioid\" = @qpfoFolioApproval_FolioId) AND (\"enfolioapproval11\".\"folioid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolioApproval_FolioId", DbType.Int64, qpfoFolioApproval_FolioId);
} else {
whereBuilder.Append("(\"enfolioapproval11\".\"folioid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enfolioapprovallevel9\".\"approvalstatusid\" = ");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query CancelFolioSAEC.GetFolioApprovalsByFolioId.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query CancelFolioSAEC.GetFolioApprovalsByFolioId.List", cancellationToken: cancellationToken);
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
