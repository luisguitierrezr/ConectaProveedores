namespace ssConectaProveedores;

public partial class Actions {
public class lcvRevertReassign : VarsBag {
public long inParami_ReassignmentId;
public Actions.lcoRequisitionApprovalLevelCreateOrUpdate resRequisitionApprovalLevelCreateOrUpdate =  new Actions.lcoRequisitionApprovalLevelCreateOrUpdate();
public RL_e8a2bfdbad62aa404e80d55d80faa387 queryResGetInvoiceApprovalLevel_outParamList = new RL_e8a2bfdbad62aa404e80d55d80faa387();
public long queryResGetInvoiceApprovalLevel_outParamCount = 0L;

public Actions.lcoReassignmentsCreateOrUpdate resReassignmentsCreateOrUpdate =  new Actions.lcoReassignmentsCreateOrUpdate();
public Actions.lcoInvoiceApprovalLevelCreateOrUpdate resInvoiceApprovalLevelCreateOrUpdate =  new Actions.lcoInvoiceApprovalLevelCreateOrUpdate();
public RL_8430333e95ceffc00def96d8abb01f75 queryResGetUserOriginal_outParamList = new RL_8430333e95ceffc00def96d8abb01f75();
public long queryResGetUserOriginal_outParamCount = 0L;

public Actions.lcoRequisitionLogAdd resRequisitionLogAdd =  new Actions.lcoRequisitionLogAdd();
public RL_8430333e95ceffc00def96d8abb01f75 queryResGetUserRevoked_outParamList = new RL_8430333e95ceffc00def96d8abb01f75();
public long queryResGetUserRevoked_outParamCount = 0L;

public RL_1f3e9ea72dc7b010c56ee9146ee277c5 queryResGetRequisitionApprovalLevel_outParamList = new RL_1f3e9ea72dc7b010c56ee9146ee277c5();
public long queryResGetRequisitionApprovalLevel_outParamCount = 0L;

public Actions.lcoInvoiceLogAdd resInvoiceLogAdd =  new Actions.lcoInvoiceLogAdd();
public RL_462b16c1ddedb19ce2dbad5e94ccb4ef queryResGetReassignmentById_outParamList = new RL_462b16c1ddedb19ce2dbad5e94ccb4ef();
public long queryResGetReassignmentById_outParamCount = 0L;

public Actions.lcoReassignmentsCreateOrUpdate resReassignmentsCreateOrUpdate2 =  new Actions.lcoReassignmentsCreateOrUpdate();
public lcvRevertReassign(long inParami_ReassignmentId) {
this.inParami_ReassignmentId = inParami_ReassignmentId;
}
}
public class lcoRevertReassign : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public lcoRevertReassign() {
}
}
/// <summary>
/// Action <code>RevertReassign</code> that represents the Service Studio action
///  <code>RevertReassign</code> <p> Description: </p>
/// </summary>
public static async Task<ST_046fb53ebbe142526d95e87ef1ae9711Structure> ActionRevertReassign(IRequestContext requestContext,long inParami_ReassignmentId,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
lcoRevertReassign result = new lcoRevertReassign();
lcvRevertReassign localVars = new lcvRevertReassign(inParami_ReassignmentId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("RevertReassign", "15881ced-2143-48ba-af20-0f6f938797d5"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("RevertReassign", "15881ced-2143-48ba-af20-0f6f938797d5", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetReassignmentById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetReassignmentById_maxRecords = 1;
if (datasetGetReassignmentById_maxRecords < 1) datasetGetReassignmentById_maxRecords = 1;
int datasetGetReassignmentById_startIndex = 0;(localVars.queryResGetReassignmentById_outParamList,localVars.queryResGetReassignmentById_outParamCount) = await FuncActionRevertReassign.datasetGetReassignmentById(requestContext,datasetGetReassignmentById_maxRecords,datasetGetReassignmentById_startIndex,IterationMultiplicity.Never,localVars.inParami_ReassignmentId,cancellationToken);

// Empty?
if((localVars.queryResGetReassignmentById_outParamList.Empty)) {
// o_Output
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "Reassignment not found!"
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("oBt1Omc14k2wVhT8UdkznA#Value.-1485960820.1", "Reassignment not found!");
} else {
// Query datasetGetUserOriginal
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserOriginal_maxRecords = 0;
int datasetGetUserOriginal_startIndex = 0;(localVars.queryResGetUserOriginal_outParamList,localVars.queryResGetUserOriginal_outParamCount) = await FuncActionRevertReassign.datasetGetUserOriginal(requestContext,datasetGetUserOriginal_maxRecords,datasetGetUserOriginal_startIndex,IterationMultiplicity.Never,localVars.queryResGetReassignmentById_outParamList.CurrentRec.ssENReassignments.ssSourceUserId,cancellationToken);

// Query datasetGetUserRevoked
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserRevoked_maxRecords = 0;
int datasetGetUserRevoked_startIndex = 0;(localVars.queryResGetUserRevoked_outParamList,localVars.queryResGetUserRevoked_outParamCount) = await FuncActionRevertReassign.datasetGetUserRevoked(requestContext,datasetGetUserRevoked_maxRecords,datasetGetUserRevoked_startIndex,IterationMultiplicity.Never,localVars.queryResGetReassignmentById_outParamList.CurrentRec.ssENReassignments.ssTargetUserId,cancellationToken);

// Is for requisition?
if(((localVars.queryResGetReassignmentById_outParamList.CurrentRec.ssENReassignments.ssRequisitionApprovalLevelId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// Query datasetGetRequisitionApprovalLevel
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequisitionApprovalLevel_maxRecords = 1;
if (datasetGetRequisitionApprovalLevel_maxRecords < 1) datasetGetRequisitionApprovalLevel_maxRecords = 1;
int datasetGetRequisitionApprovalLevel_startIndex = 0;(localVars.queryResGetRequisitionApprovalLevel_outParamList,localVars.queryResGetRequisitionApprovalLevel_outParamCount) = await FuncActionRevertReassign.datasetGetRequisitionApprovalLevel(requestContext,datasetGetRequisitionApprovalLevel_maxRecords,datasetGetRequisitionApprovalLevel_startIndex,IterationMultiplicity.Never,localVars.queryResGetReassignmentById_outParamList.CurrentRec.ssENReassignments.ssRequisitionApprovalLevelId,cancellationToken);

// Has status to be revoked?
if(((localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssApprovalStatusId==(ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId))) {
// GetReassignmentById.List.Current.Reassignments.RevokedBy = GetUserId
localVars.queryResGetReassignmentById_outParamList.CurrentRec.ssENReassignments.ssRevokedBy = BuiltInFunction.GetUserId ();

// GetReassignmentById.List.Current.Reassignments.RevokedOn = CurrDateTime
localVars.queryResGetReassignmentById_outParamList.CurrentRec.ssENReassignments.ssRevokedOn = BuiltInFunction.CurrDateTime ();

// GetRequisitionApprovalLevel.List.Current.RequisitionApprovalLevel.AssignedTo = GetReassignmentById.List.Current.Reassignments.SourceUserId
localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssAssignedTo = localVars.queryResGetReassignmentById_outParamList.CurrentRec.ssENReassignments.ssSourceUserId;

// GetRequisitionApprovalLevel.List.Current.RequisitionApprovalLevel.IsReassigned = False
localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssIsReassigned = false;

// GetRequisitionApprovalLevel.List.Current.RequisitionApprovalLevel.IsSubstituteFor = NullTextIdentifier
localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssIsSubstituteFor = BuiltInFunction.NullTextIdentifier ();
// ReassignmentsCreateOrUpdate
localVars.resReassignmentsCreateOrUpdate.outParamId = await Actions.ActionReassignmentsCreateOrUpdate(requestContext,localVars.queryResGetReassignmentById_outParamList.CurrentRec.ssENReassignments,cancellationToken);

// RequisitionApprovalLevelCreateOrUpdate
localVars.resRequisitionApprovalLevelCreateOrUpdate.outParamId = await Actions.ActionRequisitionApprovalLevelCreateOrUpdate(requestContext,localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel,cancellationToken);

// RequisitionLogAdd
localVars.resRequisitionLogAdd.outParamId = await Actions.ActionRequisitionLogAdd(requestContext,new EN_fca813b8ca96d6759e00225744caa7d4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssRequisitionId = localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisition.ssId, ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssMessage = ((((AppUtils.GetStringResource("+_pz5cVdbUa4mb8xWuxycw#Value.1483110428.1", "Reassignment revoked:")+" ")+localVars.queryResGetUserRevoked_outParamList.CurrentRec.ssENUser.ssName)+" -> ")+localVars.queryResGetUserOriginal_outParamList.CurrentRec.ssENUser.ssName) },cancellationToken);

// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
} else {
// o_Output
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "Reassignment cannot be revoked!"
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("NOtOXDHHKkWot4PPOqkyhw#Value.1947439011.1", "Reassignment cannot be revoked!");
}

} else {
// Query datasetGetInvoiceApprovalLevel
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceApprovalLevel_maxRecords = 0;
int datasetGetInvoiceApprovalLevel_startIndex = 0;(localVars.queryResGetInvoiceApprovalLevel_outParamList,localVars.queryResGetInvoiceApprovalLevel_outParamCount) = await FuncActionRevertReassign.datasetGetInvoiceApprovalLevel(requestContext,datasetGetInvoiceApprovalLevel_maxRecords,datasetGetInvoiceApprovalLevel_startIndex,IterationMultiplicity.Never,localVars.queryResGetReassignmentById_outParamList.CurrentRec.ssENReassignments.ssInvoiceApprovalLevelId,cancellationToken);

// Has status to be revoked?
if((((localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssApprovalStatusId==(ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId)||(localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssApprovalStatusId==(ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("BjgcXy0kFU+8e5Ko3emFig"))).ssId)))) {
// GetReassignmentById.List.Current.Reassignments.RevokedBy = GetUserId
localVars.queryResGetReassignmentById_outParamList.CurrentRec.ssENReassignments.ssRevokedBy = BuiltInFunction.GetUserId ();

// GetReassignmentById.List.Current.Reassignments.RevokedOn = CurrDateTime
localVars.queryResGetReassignmentById_outParamList.CurrentRec.ssENReassignments.ssRevokedOn = BuiltInFunction.CurrDateTime ();

// GetInvoiceApprovalLevel.List.Current.InvoiceApprovalLevel.AssignedTo = GetReassignmentById.List.Current.Reassignments.SourceUserId
localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssAssignedTo = localVars.queryResGetReassignmentById_outParamList.CurrentRec.ssENReassignments.ssSourceUserId;

// GetInvoiceApprovalLevel.List.Current.InvoiceApprovalLevel.IsReassigned = False
localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssIsReassigned = false;

// GetInvoiceApprovalLevel.List.Current.InvoiceApprovalLevel.IsSubstituteFor = NullTextIdentifier
localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssIsSubstituteFor = BuiltInFunction.NullTextIdentifier ();
// ReassignmentsCreateOrUpdate2
localVars.resReassignmentsCreateOrUpdate2.outParamId = await Actions.ActionReassignmentsCreateOrUpdate(requestContext,localVars.queryResGetReassignmentById_outParamList.CurrentRec.ssENReassignments,cancellationToken);

// InvoiceApprovalLevelCreateOrUpdate
localVars.resInvoiceApprovalLevelCreateOrUpdate.outParamId = await Actions.ActionInvoiceApprovalLevelCreateOrUpdate(requestContext,localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel,cancellationToken);

// InvoiceLogAdd
localVars.resInvoiceLogAdd.outParamId = await Actions.ActionInvoiceLogAdd(requestContext,new EN_bf34270fdd0f7785895f41a998e724e8EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssInvoiceId = localVars.queryResGetReassignmentById_outParamList.CurrentRec.ssENReassignments.ssInvoiceId, ssMessage = ((((AppUtils.GetStringResource("FS9keDy6xUaZakQz8VJjPA#Value.1483110428.1", "Reassignment revoked:")+" ")+localVars.queryResGetUserRevoked_outParamList.CurrentRec.ssENUser.ssName)+" -> ")+localVars.queryResGetUserOriginal_outParamList.CurrentRec.ssENUser.ssName), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssCreatedBy = BuiltInFunction.GetUserId () },cancellationToken);

// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
} else {
// o_Output
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "Reassignment cannot be revoked!"
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("eZMyAaXJmEW2KOgFFl8brw#Value.1947439011.1", "Reassignment cannot be revoked!");
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

public static class FuncActionRevertReassign {

private static async Task<RC_bc68025e789d69992aef27aed0947c65> datasetGetInvoiceApprovalLevelReadDbAsync(RC_bc68025e789d69992aef27aed0947c65 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceApproval.Read( r, ref index);
rec.ssENInvoiceApprovalLevel.Read( r, ref index);
return rec;
}
// Query Function "GetInvoiceApprovalLevel" DU33EgJGjE+QdlXfMJVcsw of Action "RevertReassign"
public static async Task<(RL_e8a2bfdbad62aa404e80d55d80faa387,long)> datasetGetInvoiceApprovalLevel(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceApprovalLevel_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("RevertReassign.GetInvoiceApprovalLevel", "12f74d0d-4602-4f8c-9076-55df30955cb3");
using var queryActivity = activitySource.CreateAggregateQueryActivity("RevertReassign.GetInvoiceApprovalLevel", "12f74d0d-4602-4f8c-9076-55df30955cb3", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.7RyIFUMhukivIA9vk4eX1Q/NodesNotShownInESpaceTree.DU33EgJGjE+QdlXfMJVcsw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, \"eninvoiceapprovallevel\".\"id\" o34, \"eninvoiceapprovallevel\".\"invoiceapprovalid\" o35, \"eninvoiceapprovallevel\".\"levelnumber\" o36, \"eninvoiceapprovallevel\".\"assignedto\" o37, \"eninvoiceapprovallevel\".\"applicationroleid\" o38, \"eninvoiceapprovallevel\".\"entrajobtitle\" o39, \"eninvoiceapprovallevel\".\"departmentid\" o40, \"eninvoiceapprovallevel\".\"managementid\" o41, \"eninvoiceapprovallevel\".\"subdirectionid\" o42, \"eninvoiceapprovallevel\".\"entraroleid\" o43, \"eninvoiceapprovallevel\".\"approvalstatusid\" o44, \"eninvoiceapprovallevel\".\"canbefirstapprover\" o45, \"eninvoiceapprovallevel\".\"selectsnextapprover\" o46, \"eninvoiceapprovallevel\".\"selectsfirstapprover\" o47, \"eninvoiceapprovallevel\".\"isaccounting\" o48, \"eninvoiceapprovallevel\".\"isstartaccounting\" o49, \"eninvoiceapprovallevel\".\"approvedby\" o50, \"eninvoiceapprovallevel\".\"approvedon\" o51, \"eninvoiceapprovallevel\".\"requesttomodifyby\" o52, \"eninvoiceapprovallevel\".\"requesttomodifyon\" o53, \"eninvoiceapprovallevel\".\"canceledby\" o54, \"eninvoiceapprovallevel\".\"canceledon\" o55, \"eninvoiceapprovallevel\".\"needscontract_deprec\" o56, \"eninvoiceapprovallevel\".\"isreassigned\" o57, \"eninvoiceapprovallevel\".\"issubstitutefor\" o58");
fromBuilder.Append(" FROM (({Invoice} \"eninvoice3\" Left JOIN {InvoiceApproval} \"eninvoiceapproval\" ON (\"eninvoice3\".\"id\" = \"eninvoiceapproval\".\"invoiceid\"))  Left JOIN {InvoiceApprovalLevel} \"eninvoiceapprovallevel\" ON (\"eninvoiceapproval\".\"id\" = \"eninvoiceapprovallevel\".\"invoiceapprovalid\")) ");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceApprovalLevel_Id != 0) {
whereBuilder.Append("((\"eninvoiceapprovallevel\".\"id\" = @qpinInvoiceApprovalLevel_Id) AND (\"eninvoiceapprovallevel\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceApprovalLevel_Id", DbType.Int64, qpinInvoiceApprovalLevel_Id);
} else {
whereBuilder.Append("(\"eninvoiceapprovallevel\".\"id\" IS NULL)");
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
RL_e8a2bfdbad62aa404e80d55d80faa387 outParamList = new RL_e8a2bfdbad62aa404e80d55d80faa387();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoiceApprovalLevelReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query RevertReassign.GetInvoiceApprovalLevel.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_e8a2bfdbad62aa404e80d55d80faa387 _tmp = new RL_e8a2bfdbad62aa404e80d55d80faa387();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoiceApprovalLevelReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query RevertReassign.GetInvoiceApprovalLevel.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_e8a2bfdbad62aa404e80d55d80faa387)_tmp;
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

// Query Function "GetUserOriginal" PTbqcf1Cyk2X5dZyYYUCmQ of Action "RevertReassign"
public static async Task<(RL_8430333e95ceffc00def96d8abb01f75,long)> datasetGetUserOriginal(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("RevertReassign.GetUserOriginal", "71ea363d-42fd-4dca-97e5-d67261850299");
using var queryActivity = activitySource.CreateAggregateQueryActivity("RevertReassign.GetUserOriginal", "71ea363d-42fd-4dca-97e5-d67261850299", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.7RyIFUMhukivIA9vk4eX1Q/NodesNotShownInESpaceTree.PTbqcf1Cyk2X5dZyYYUCmQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enuser14\".\"name\" o1, NULL o2, NULL o3, NULL o4");
fromBuilder.Append(" FROM {User} \"enuser14\"");
whereBuilder.Append(" WHERE ");
if ((qpusId.Trim()!="")) {
whereBuilder.Append("((\"enuser14\".\"id\" = @qpusId) AND (\"enuser14\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusId", DbType.String, qpusId);
} else {
whereBuilder.Append("(\"enuser14\".\"id\" IS NULL)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query RevertReassign.GetUserOriginal.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query RevertReassign.GetUserOriginal.List", cancellationToken: cancellationToken);
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

// Query Function "GetUserRevoked" H3sclqW7jEu9JoARaY6dCQ of Action "RevertReassign"
public static async Task<(RL_8430333e95ceffc00def96d8abb01f75,long)> datasetGetUserRevoked(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("RevertReassign.GetUserRevoked", "961c7b1f-bba5-4b8c-bd26-8011698e9d09");
using var queryActivity = activitySource.CreateAggregateQueryActivity("RevertReassign.GetUserRevoked", "961c7b1f-bba5-4b8c-bd26-8011698e9d09", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.7RyIFUMhukivIA9vk4eX1Q/NodesNotShownInESpaceTree.H3sclqW7jEu9JoARaY6dCQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enuser15\".\"name\" o1, NULL o2, NULL o3, NULL o4");
fromBuilder.Append(" FROM {User} \"enuser15\"");
whereBuilder.Append(" WHERE ");
if ((qpusId.Trim()!="")) {
whereBuilder.Append("((\"enuser15\".\"id\" = @qpusId) AND (\"enuser15\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusId", DbType.String, qpusId);
} else {
whereBuilder.Append("(\"enuser15\".\"id\" IS NULL)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query RevertReassign.GetUserRevoked.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query RevertReassign.GetUserRevoked.List", cancellationToken: cancellationToken);
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

private static async Task<RC_11c2ac4c5bdce01960ee8371ad40d262> datasetGetRequisitionApprovalLevelReadDbAsync(RC_11c2ac4c5bdce01960ee8371ad40d262 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENRequisition.Read( r, ref index);
rec.ssENRequisitionApproval.Read( r, ref index);
rec.ssENRequisitionApprovalLevel.Read( r, ref index);
return rec;
}
// Query Function "GetRequisitionApprovalLevel" hnfuvq0wgUKw148hBPjteQ of Action "RevertReassign"
public static async Task<(RL_1f3e9ea72dc7b010c56ee9146ee277c5,long)> datasetGetRequisitionApprovalLevel(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRequisitionApprovalLevel_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("RevertReassign.GetRequisitionApprovalLevel", "beee7786-30ad-4281-b0d7-8f2104f8ed79");
using var queryActivity = activitySource.CreateAggregateQueryActivity("RevertReassign.GetRequisitionApprovalLevel", "beee7786-30ad-4281-b0d7-8f2104f8ed79", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.7RyIFUMhukivIA9vk4eX1Q/NodesNotShownInESpaceTree.hnfuvq0wgUKw148hBPjteQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enrequisition7\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, \"enrequisitionapprovallevel4\".\"id\" o68, \"enrequisitionapprovallevel4\".\"requisitionapprovalid\" o69, \"enrequisitionapprovallevel4\".\"levelnumber\" o70, \"enrequisitionapprovallevel4\".\"applicationroleid\" o71, \"enrequisitionapprovallevel4\".\"entrajobtitle\" o72, \"enrequisitionapprovallevel4\".\"departmentid\" o73, \"enrequisitionapprovallevel4\".\"managementid\" o74, \"enrequisitionapprovallevel4\".\"subdirectionid\" o75, \"enrequisitionapprovallevel4\".\"entraroleid\" o76, \"enrequisitionapprovallevel4\".\"entrausername\" o77, \"enrequisitionapprovallevel4\".\"assignedto\" o78, \"enrequisitionapprovallevel4\".\"needscontract\" o79, \"enrequisitionapprovallevel4\".\"approvalstatusid\" o80, \"enrequisitionapprovallevel4\".\"approvedby\" o81, \"enrequisitionapprovallevel4\".\"approvedon\" o82, \"enrequisitionapprovallevel4\".\"requesttomodifyby\" o83, \"enrequisitionapprovallevel4\".\"requesttomodifyon\" o84, \"enrequisitionapprovallevel4\".\"canceledby\" o85, \"enrequisitionapprovallevel4\".\"canceledon_deprec\" o86, \"enrequisitionapprovallevel4\".\"isaccounting\" o87, \"enrequisitionapprovallevel4\".\"isstartaccounting\" o88, \"enrequisitionapprovallevel4\".\"canceledon_\" o89, \"enrequisitionapprovallevel4\".\"approveasareausuaria\" o90, \"enrequisitionapprovallevel4\".\"ismandatory\" o91, \"enrequisitionapprovallevel4\".\"isreassigned\" o92, \"enrequisitionapprovallevel4\".\"issubstitutefor\" o93");
fromBuilder.Append(" FROM (({Requisition} \"enrequisition7\" Left JOIN {RequisitionApproval} \"enrequisitionapproval4\" ON (\"enrequisition7\".\"id\" = \"enrequisitionapproval4\".\"requisitionid\"))  Left JOIN {RequisitionApprovalLevel} \"enrequisitionapprovallevel4\" ON (\"enrequisitionapproval4\".\"id\" = \"enrequisitionapprovallevel4\".\"requisitionapprovalid\")) ");
whereBuilder.Append(" WHERE ");
if (qpreRequisitionApprovalLevel_Id != 0) {
whereBuilder.Append("((\"enrequisitionapprovallevel4\".\"id\" = @qpreRequisitionApprovalLevel_Id) AND (\"enrequisitionapprovallevel4\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisitionApprovalLevel_Id", DbType.Int64, qpreRequisitionApprovalLevel_Id);
} else {
whereBuilder.Append("(\"enrequisitionapprovallevel4\".\"id\" IS NULL)");
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
RL_1f3e9ea72dc7b010c56ee9146ee277c5 outParamList = new RL_1f3e9ea72dc7b010c56ee9146ee277c5();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetRequisitionApprovalLevelReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query RevertReassign.GetRequisitionApprovalLevel.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_1f3e9ea72dc7b010c56ee9146ee277c5 _tmp = new RL_1f3e9ea72dc7b010c56ee9146ee277c5();
_tmp.AlternateReadDbMethodAsync = datasetGetRequisitionApprovalLevelReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query RevertReassign.GetRequisitionApprovalLevel.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_1f3e9ea72dc7b010c56ee9146ee277c5)_tmp;
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

// Query Function "GetReassignmentById" rSK554RywUmgI4isgI9ggQ of Action "RevertReassign"
public static async Task<(RL_462b16c1ddedb19ce2dbad5e94ccb4ef,long)> datasetGetReassignmentById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("RevertReassign.GetReassignmentById", "e7b922ad-7284-49c1-a023-88ac808f6081");
using var queryActivity = activitySource.CreateAggregateQueryActivity("RevertReassign.GetReassignmentById", "e7b922ad-7284-49c1-a023-88ac808f6081", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.7RyIFUMhukivIA9vk4eX1Q/NodesNotShownInESpaceTree.rSK554RywUmgI4isgI9ggQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enreassignments\".\"id\" o0, \"enreassignments\".\"sourceuserid\" o1, \"enreassignments\".\"targetuserid\" o2, \"enreassignments\".\"requisitionid\" o3, \"enreassignments\".\"requisitionapprovallevelid\" o4, \"enreassignments\".\"invoiceid\" o5, \"enreassignments\".\"invoiceapprovallevelid\" o6, \"enreassignments\".\"reason\" o7, \"enreassignments\".\"createdby\" o8, \"enreassignments\".\"createdon\" o9, \"enreassignments\".\"revokedby\" o10, \"enreassignments\".\"revokedon\" o11, \"enreassignments\".\"folioid\" o12, \"enreassignments\".\"folioapprovallevelid\" o13, \"enreassignments\".\"sourceentraroleid\" o14, \"enreassignments\".\"targetentraroleid\" o15, \"enreassignments\".\"isfolioapprovallevelinvoice\" o16");
fromBuilder.Append(" FROM {Reassignments} \"enreassignments\"");
whereBuilder.Append(" WHERE ");
if (qpreId != 0) {
whereBuilder.Append("((\"enreassignments\".\"id\" = @qpreId) AND (\"enreassignments\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreId", DbType.Int64, qpreId);
} else {
whereBuilder.Append("(\"enreassignments\".\"id\" IS NULL)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query RevertReassign.GetReassignmentById.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query RevertReassign.GetReassignmentById.List", cancellationToken: cancellationToken);
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



}


}
