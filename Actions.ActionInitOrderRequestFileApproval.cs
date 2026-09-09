namespace ssConectaProveedores;

public partial class Actions {
public class lcvInitOrderRequestFileApproval : VarsBag {
public long inParamOrderRequestFileId;
/// <summary>
/// Variable <code>l_SubstituteUserId</code> that represents the Service Studio UserIdentifier
///  <code>l_SubstituteUserId</code> <p>Description: </p>
/// </summary>
public string varLcl_SubstituteUserId = "";

/// <summary>
/// Variable <code>l_IsSubstituteFor</code> that represents the Service Studio UserIdentifier
///  <code>l_IsSubstituteFor</code> <p>Description: User Identifier</p>
/// </summary>
public string varLcl_IsSubstituteFor = "";

public Actions.lcoOrderLogAdd resOrderLogAdd =  new Actions.lcoOrderLogAdd();
public RL_3c2483fef931c35c62e6128a52ac9903 queryResGetOrderApprovalLevels_outParamList = new RL_3c2483fef931c35c62e6128a52ac9903();
public long queryResGetOrderApprovalLevels_outParamCount = 0L;

public Actions.lcoOrderRequestFileApprovalCreateOrUpdate resOrderRequestFileApprovalCreateOrUpdate =  new Actions.lcoOrderRequestFileApprovalCreateOrUpdate();
public RL_a38636e8cdfa0597b0a4df54d4425f9d queryResGetPrevApproval_outParamList = new RL_a38636e8cdfa0597b0a4df54d4425f9d();
public long queryResGetPrevApproval_outParamCount = 0L;

public Actions.lcoOrderRequestFileApprovalLevelCreateOrUpdate resOrderRequestFileApprovalLevelCreateOrUpdate =  new Actions.lcoOrderRequestFileApprovalLevelCreateOrUpdate();
public RL_c628da75cf1ff630b097c83103a52e40 queryResGetOrderRequestFileById_outParamList = new RL_c628da75cf1ff630b097c83103a52e40();
public long queryResGetOrderRequestFileById_outParamCount = 0L;

public Actions.lcoHasActiveSubstitution resHasActiveSubstitution =  new Actions.lcoHasActiveSubstitution();
public lcvInitOrderRequestFileApproval(long inParamOrderRequestFileId) {
this.inParamOrderRequestFileId = inParamOrderRequestFileId;
}
}
public class lcoInitOrderRequestFileApproval : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamOutput = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public lcoInitOrderRequestFileApproval() {
}
}
/// <summary>
/// Action <code>InitOrderRequestFileApproval</code> that represents the Service Studio action
///  <code>InitOrderRequestFileApproval</code> <p> Description: </p>
/// </summary>
public static async Task<ST_046fb53ebbe142526d95e87ef1ae9711Structure> ActionInitOrderRequestFileApproval(IRequestContext requestContext,long inParamOrderRequestFileId,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamOutput = default;
lcoInitOrderRequestFileApproval result = new lcoInitOrderRequestFileApproval();
lcvInitOrderRequestFileApproval localVars = new lcvInitOrderRequestFileApproval(inParamOrderRequestFileId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("InitOrderRequestFileApproval", "86a03168-366e-4dda-a641-229098683259"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("InitOrderRequestFileApproval", "86a03168-366e-4dda-a641-229098683259", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetOrderRequestFileById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderRequestFileById_maxRecords = 1;
if (datasetGetOrderRequestFileById_maxRecords < 1) datasetGetOrderRequestFileById_maxRecords = 1;
int datasetGetOrderRequestFileById_startIndex = 0;(localVars.queryResGetOrderRequestFileById_outParamList,localVars.queryResGetOrderRequestFileById_outParamCount) = await FuncActionInitOrderRequestFileApproval.datasetGetOrderRequestFileById(requestContext,datasetGetOrderRequestFileById_maxRecords,datasetGetOrderRequestFileById_startIndex,IterationMultiplicity.Never,localVars.inParamOrderRequestFileId,cancellationToken);

// Not found?
if((localVars.queryResGetOrderRequestFileById_outParamList.Empty)) {
// Output
// Output.IsSuccess = False
result.outParamOutput.ssIsSuccess = false;

// Output.Message = "File not found!"
result.outParamOutput.ssMessage = AppUtils.GetStringResource("MP7wYO4TxUmOraVFBsKXQA#Value.525723600.1", "File not found!");
} else {
// Query datasetGetPrevApproval
cancellationToken.ThrowIfCancellationRequested();
int datasetGetPrevApproval_maxRecords = 1;
if (datasetGetPrevApproval_maxRecords < 1) datasetGetPrevApproval_maxRecords = 1;
int datasetGetPrevApproval_startIndex = 0;(localVars.queryResGetPrevApproval_outParamList,localVars.queryResGetPrevApproval_outParamCount) = await FuncActionInitOrderRequestFileApproval.datasetGetPrevApproval(requestContext,datasetGetPrevApproval_maxRecords,datasetGetPrevApproval_startIndex,IterationMultiplicity.Never,localVars.inParamOrderRequestFileId,cancellationToken);

// Found?
if(((!localVars.queryResGetPrevApproval_outParamList.Empty))) {
// OrderRequestFileApprovalDelete
await Actions.ActionOrderRequestFileApprovalDelete(requestContext,localVars.queryResGetPrevApproval_outParamList.CurrentRec.ssENOrderRequestFileApproval.ssId,cancellationToken);

// GetOrderRequestFileById.List.Current.OrderRequestFile.IsApproved = False
localVars.queryResGetOrderRequestFileById_outParamList.CurrentRec.ssENOrderRequestFile.ssIsApproved = false;

// GetOrderRequestFileById.List.Current.OrderRequestFile.IsRejected = False
localVars.queryResGetOrderRequestFileById_outParamList.CurrentRec.ssENOrderRequestFile.ssIsRejected = false;
}

// Query datasetGetOrderApprovalLevels
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderApprovalLevels_maxRecords = 0;
int datasetGetOrderApprovalLevels_startIndex = 0;(localVars.queryResGetOrderApprovalLevels_outParamList,localVars.queryResGetOrderApprovalLevels_outParamCount) = await FuncActionInitOrderRequestFileApproval.datasetGetOrderApprovalLevels(requestContext,datasetGetOrderApprovalLevels_maxRecords,datasetGetOrderApprovalLevels_startIndex,IterationMultiplicity.Multiple,localVars.queryResGetOrderRequestFileById_outParamList.CurrentRec.ssENOrderMain.ssId,cancellationToken);

// OrderRequestFileApprovalCreateOrUpdate
localVars.resOrderRequestFileApprovalCreateOrUpdate.outParamId = await Actions.ActionOrderRequestFileApprovalCreateOrUpdate(requestContext,new EN_1710c672f4d7138b664ee1411114271eEntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssOrderRequestFileId = localVars.inParamOrderRequestFileId, ssCurrentLevel = 1, ssMaxLevel = localVars.queryResGetOrderApprovalLevels_outParamList.Length, ssStartedOn = BuiltInFunction.CurrDateTime () },cancellationToken);

// Foreach GetOrderApprovalLevels.List
localVars.queryResGetOrderApprovalLevels_outParamList.StartIteration();
try {while (!((localVars.queryResGetOrderApprovalLevels_outParamList.Eof))) {
// l_SubstituteUserId = NullTextIdentifier
localVars.varLcl_SubstituteUserId=BuiltInFunction.NullTextIdentifier ();

// l_IsSubstituteFor = NullTextIdentifier
localVars.varLcl_IsSubstituteFor=BuiltInFunction.NullTextIdentifier ();
if(((localVars.queryResGetOrderApprovalLevels_outParamList.CurrentRowNumber==0))) {
// HasActiveSubstitution
(localVars.resHasActiveSubstitution.outParamo_SubstituteUserId,localVars.resHasActiveSubstitution.outParamo_IsSubstituteFor) = await Actions.ActionHasActiveSubstitution(requestContext,localVars.queryResGetOrderApprovalLevels_outParamList.CurrentRec.ssENOrderApprovalLevel.ssApprovedBy,cancellationToken);

// l_SubstituteUserId = HasActiveSubstitution.o_SubstituteUserId
localVars.varLcl_SubstituteUserId=localVars.resHasActiveSubstitution.outParamo_SubstituteUserId;

// l_IsSubstituteFor = HasActiveSubstitution.o_IsSubstituteFor
localVars.varLcl_IsSubstituteFor=localVars.resHasActiveSubstitution.outParamo_IsSubstituteFor;
}

// OrderRequestFileApprovalLevelCreateOrUpdate
localVars.resOrderRequestFileApprovalLevelCreateOrUpdate.outParamId = await Actions.ActionOrderRequestFileApprovalLevelCreateOrUpdate(requestContext,new EN_80af67ecab8f43d464cc57955285a024EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssOrderRequestFileApprovalId = localVars.resOrderRequestFileApprovalCreateOrUpdate.outParamId, ssLevelNumber = (localVars.queryResGetOrderApprovalLevels_outParamList.CurrentRowNumber+1), ssEntraRoleId = localVars.queryResGetOrderApprovalLevels_outParamList.CurrentRec.ssENOrderApprovalLevel.ssEntraRoleId, ssAssignedTo = (((localVars.varLcl_SubstituteUserId!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.varLcl_SubstituteUserId) : (localVars.queryResGetOrderApprovalLevels_outParamList.CurrentRec.ssENOrderApprovalLevel.ssApprovedBy)), ssApprovalStatusId = (((localVars.queryResGetOrderApprovalLevels_outParamList.CurrentRowNumber==0)) ? ((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId) : ((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("fEmjvBqEH0eHrf5_YVeo0g"))).ssId)), ssIsSubstituteFor = localVars.varLcl_IsSubstituteFor },cancellationToken);

localVars.queryResGetOrderApprovalLevels_outParamList.Advance();
}

} finally {
localVars.queryResGetOrderApprovalLevels_outParamList.EndIteration();
}

// OrderLogAdd
localVars.resOrderLogAdd.outParamId = await Actions.ActionOrderLogAdd(requestContext,new EN_a8e484428097204171df8a1feecb2534EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssOrderId = localVars.queryResGetOrderRequestFileById_outParamList.CurrentRec.ssENOrderMain.ssId, ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssMessage = ((((AppUtils.GetStringResource("wakLaX+dYkSxlWuxIb7uvA#Value.2189724.1", "File")+" ")+localVars.queryResGetOrderRequestFileById_outParamList.CurrentRec.ssENOrderRequestFile.ssFilename)+" ")+(((!localVars.queryResGetPrevApproval_outParamList.Empty)) ? ((AppUtils.GetStringResource("wakLaX+dYkSxlWuxIb7uvA#Value.-746774432.1", "has reinitiated approval process")+".")) : ((AppUtils.GetStringResource("wakLaX+dYkSxlWuxIb7uvA#Value.-2021362323.1", "has initiated approval process")+".")))) },cancellationToken);

// Output.IsSuccess = True
result.outParamOutput.ssIsSuccess = true;
// SendOrdReqFileFirstApproverEmail
await Actions.ActionSendOrdReqFileFirstApproverEmail(requestContext,localVars.inParamOrderRequestFileId,cancellationToken);

}

} //close CreateActionActivity using block
} // try

finally {
outParamOutput = result.outParamOutput;
} // inner-finally
RETURN_STATEMENT:
return outParamOutput;
}

public static class FuncActionInitOrderRequestFileApproval {

private static async Task<RC_2929b54077988f623db253f22a62f498> datasetGetOrderApprovalLevelsReadDbAsync(RC_2929b54077988f623db253f22a62f498 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENOrderApproval.Read( r, ref index);
rec.ssENOrderApprovalLevel.Read( r, ref index);
return rec;
}
// Query Function "GetOrderApprovalLevels" +SgcRVW3OUqjxwwbZZEJ9g of Action "InitOrderRequestFileApproval"
public static async Task<(RL_3c2483fef931c35c62e6128a52ac9903,long)> datasetGetOrderApprovalLevels(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderApproval_OrderId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InitOrderRequestFileApproval.GetOrderApprovalLevels", "451c28f9-b755-4a39-a3c7-0c1b659109f6");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InitOrderRequestFileApproval.GetOrderApprovalLevels", "451c28f9-b755-4a39-a3c7-0c1b659109f6", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.aDGghm422k2mQSKQmGgyWQ/NodesNotShownInESpaceTree.+SgcRVW3OUqjxwwbZZEJ9g, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, \"enorderapprovallevel10\".\"entraroleid\" o11, NULL o12, NULL o13, NULL o14, \"enorderapprovallevel10\".\"approvedby\" o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24");
fromBuilder.Append(" FROM ({OrderApprovalLevel} \"enorderapprovallevel10\" Left JOIN {OrderApproval} \"enorderapproval11\" ON (\"enorderapprovallevel10\".\"orderapprovalid\" = \"enorderapproval11\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qporOrderApproval_OrderId != 0) {
whereBuilder.Append("((\"enorderapproval11\".\"orderid\" = @qporOrderApproval_OrderId) AND (\"enorderapproval11\".\"orderid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderApproval_OrderId", DbType.Int64, qporOrderApproval_OrderId);
} else {
whereBuilder.Append("(\"enorderapproval11\".\"orderid\" IS NULL)");
}
whereBuilder.Append(" AND ((\"enorderapprovallevel10\".\"approvalstatusid\" = ");
whereBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("rkrV30n0cEiW8dttOKG0gw"))).ssId);
whereBuilder.Append(") OR (\"enorderapprovallevel10\".\"approvalstatusid\" = ");
whereBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("EW9OOAC7ZEm3iGeypPwFAg"))).ssId);
whereBuilder.Append("))");
orderByBuilder.Append(" ORDER BY \"enorderapprovallevel10\".\"levelnumber\" ASC ");
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
RL_3c2483fef931c35c62e6128a52ac9903 outParamList = new RL_3c2483fef931c35c62e6128a52ac9903();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrderApprovalLevelsReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, false, true, true, true, false, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InitOrderRequestFileApproval.GetOrderApprovalLevels.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_3c2483fef931c35c62e6128a52ac9903 _tmp = new RL_3c2483fef931c35c62e6128a52ac9903();
_tmp.AlternateReadDbMethodAsync = datasetGetOrderApprovalLevelsReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InitOrderRequestFileApproval.GetOrderApprovalLevels.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_3c2483fef931c35c62e6128a52ac9903)_tmp;
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

// Query Function "GetPrevApproval" Mthea3nF9UmJmxWk03kTNQ of Action "InitOrderRequestFileApproval"
public static async Task<(RL_a38636e8cdfa0597b0a4df54d4425f9d,long)> datasetGetPrevApproval(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderRequestFileId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InitOrderRequestFileApproval.GetPrevApproval", "6b5ed832-c579-49f5-899b-15a4d3791335");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InitOrderRequestFileApproval.GetPrevApproval", "6b5ed832-c579-49f5-899b-15a4d3791335", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.aDGghm422k2mQSKQmGgyWQ/NodesNotShownInESpaceTree.Mthea3nF9UmJmxWk03kTNQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enorderrequestfileapproval2\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5");
fromBuilder.Append(" FROM {OrderRequestFileApproval} \"enorderrequestfileapproval2\"");
whereBuilder.Append(" WHERE ");
if (qporOrderRequestFileId != 0) {
whereBuilder.Append("((\"enorderrequestfileapproval2\".\"orderrequestfileid\" = @qporOrderRequestFileId) AND (\"enorderrequestfileapproval2\".\"orderrequestfileid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderRequestFileId", DbType.Int64, qporOrderRequestFileId);
} else {
whereBuilder.Append("(\"enorderrequestfileapproval2\".\"orderrequestfileid\" IS NULL)");
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
RL_a38636e8cdfa0597b0a4df54d4425f9d outParamList = new RL_a38636e8cdfa0597b0a4df54d4425f9d();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InitOrderRequestFileApproval.GetPrevApproval.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_a38636e8cdfa0597b0a4df54d4425f9d _tmp = new RL_a38636e8cdfa0597b0a4df54d4425f9d();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InitOrderRequestFileApproval.GetPrevApproval.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_a38636e8cdfa0597b0a4df54d4425f9d)_tmp;
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

private static async Task<RC_924fb1c0e7e255405c78f78b86a50c36> datasetGetOrderRequestFileByIdReadDbAsync(RC_924fb1c0e7e255405c78f78b86a50c36 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENOrderMain.Read( r, ref index);
rec.ssENOrderRequestFile.Read( r, ref index);
return rec;
}
// Query Function "GetOrderRequestFileById" hPR3s4IPo0C0B7tYb7xZiw of Action "InitOrderRequestFileApproval"
public static async Task<(RL_c628da75cf1ff630b097c83103a52e40,long)> datasetGetOrderRequestFileById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderRequestFile_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InitOrderRequestFileApproval.GetOrderRequestFileById", "b377f484-0f82-40a3-b407-bb586fbc598b");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InitOrderRequestFileApproval.GetOrderRequestFileById", "b377f484-0f82-40a3-b407-bb586fbc598b", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.aDGghm422k2mQSKQmGgyWQ/NodesNotShownInESpaceTree.hPR3s4IPo0C0B7tYb7xZiw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enordermain40\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, \"enorderrequestfile6\".\"filename\" o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45");
fromBuilder.Append(" FROM ({OrderRequestFile} \"enorderrequestfile6\" Inner JOIN {OrderMain} \"enordermain40\" ON (\"enorderrequestfile6\".\"orderid\" = \"enordermain40\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qporOrderRequestFile_Id != 0) {
whereBuilder.Append("((\"enorderrequestfile6\".\"id\" = @qporOrderRequestFile_Id) AND (\"enorderrequestfile6\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderRequestFile_Id", DbType.Int64, qporOrderRequestFile_Id);
} else {
whereBuilder.Append("(\"enorderrequestfile6\".\"id\" IS NULL)");
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
RL_c628da75cf1ff630b097c83103a52e40 outParamList = new RL_c628da75cf1ff630b097c83103a52e40();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrderRequestFileByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InitOrderRequestFileApproval.GetOrderRequestFileById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_c628da75cf1ff630b097c83103a52e40 _tmp = new RL_c628da75cf1ff630b097c83103a52e40();
_tmp.AlternateReadDbMethodAsync = datasetGetOrderRequestFileByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InitOrderRequestFileApproval.GetOrderRequestFileById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_c628da75cf1ff630b097c83103a52e40)_tmp;
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
