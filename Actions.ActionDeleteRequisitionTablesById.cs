namespace ssConectaProveedores;

public partial class Actions {
public class lcvDeleteRequisitionTablesById : VarsBag {
public long inParamRequisitionId;
public RL_b47d9310671b1b627f451a333bb8980a queryResGetRequisitionServicesByRequisitionId_outParamList = new RL_b47d9310671b1b627f451a333bb8980a();
public long queryResGetRequisitionServicesByRequisitionId_outParamCount = 0L;

public RL_991db829ff4e7fe204109f106256f023 queryResGetRequisitionAccountingsByRequisitionId_outParamList = new RL_991db829ff4e7fe204109f106256f023();
public long queryResGetRequisitionAccountingsByRequisitionId_outParamCount = 0L;

public RL_2895ef65cfa24878b5b55c2c334b2f76 queryResGetRequisitionFileById_outParamList = new RL_2895ef65cfa24878b5b55c2c334b2f76();
public long queryResGetRequisitionFileById_outParamCount = 0L;

public RL_7b3475883ca90ad6eb7fc983e868c456 queryResGetInvoicesByRequisitionId_outParamList = new RL_7b3475883ca90ad6eb7fc983e868c456();
public long queryResGetInvoicesByRequisitionId_outParamCount = 0L;

public RL_7f2260a280cd6c85f68a2e5dbb44ffad queryResGetRequisitionApprovalsByRequisitionId_outParamList = new RL_7f2260a280cd6c85f68a2e5dbb44ffad();
public long queryResGetRequisitionApprovalsByRequisitionId_outParamCount = 0L;

public RL_67eeb6e2fea6e1fe75fd0bc7d38796a5 queryResGetRequisitionAccConceptsByRequisitionAccountingId_outParamList = new RL_67eeb6e2fea6e1fe75fd0bc7d38796a5();
public long queryResGetRequisitionAccConceptsByRequisitionAccountingId_outParamCount = 0L;

public RL_57c324e581f9aea86c504fb7e70730b1 queryResGetRequisitionLogsByRequisitionId_outParamList = new RL_57c324e581f9aea86c504fb7e70730b1();
public long queryResGetRequisitionLogsByRequisitionId_outParamCount = 0L;

public RL_3933323760320045e42588bf0a23c855 queryResGetRequisitionCommentsByRequisitionId_outParamList = new RL_3933323760320045e42588bf0a23c855();
public long queryResGetRequisitionCommentsByRequisitionId_outParamCount = 0L;

public RL_40212690d01342e9b25b0ac7249068cf queryResGetRequisitionStatusHistoriesByRequisitionId_outParamList = new RL_40212690d01342e9b25b0ac7249068cf();
public long queryResGetRequisitionStatusHistoriesByRequisitionId_outParamCount = 0L;

public RL_16a3629886d5e012aa547b904dd63379 queryResGetRequisitionVersionsByOriginalRequisitionId_outParamList = new RL_16a3629886d5e012aa547b904dd63379();
public long queryResGetRequisitionVersionsByOriginalRequisitionId_outParamCount = 0L;

public RL_25486e09ba20acde3d8ef9d3e8a6e625 queryResGetRequisitionContractFilesByRequisitionId_outParamList = new RL_25486e09ba20acde3d8ef9d3e8a6e625();
public long queryResGetRequisitionContractFilesByRequisitionId_outParamCount = 0L;

public RL_d8bc800f4e3c344ab91bf54150e31a34 queryResGetRequisitionApprovalLevelsByRequisitionApprovalI_outParamList = new RL_d8bc800f4e3c344ab91bf54150e31a34();
public long queryResGetRequisitionApprovalLevelsByRequisitionApprovalI_outParamCount = 0L;

public RL_d3e0bac8462c62ccd7f8cc475394c310 queryResGetRequisitionCostCentersByRequisitionId_outParamList = new RL_d3e0bac8462c62ccd7f8cc475394c310();
public long queryResGetRequisitionCostCentersByRequisitionId_outParamCount = 0L;

public lcvDeleteRequisitionTablesById(long inParamRequisitionId) {
this.inParamRequisitionId = inParamRequisitionId;
}
}
/// <summary>
/// Action <code>DeleteRequisitionTablesById</code> that represents the Service Studio action
///  <code>DeleteRequisitionTablesById</code> <p> Description: </p>
/// </summary>
public static async Task ActionDeleteRequisitionTablesById(IRequestContext requestContext,long inParamRequisitionId,CancellationToken cancellationToken) {
lcvDeleteRequisitionTablesById localVars = new lcvDeleteRequisitionTablesById(inParamRequisitionId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("DeleteRequisitionTablesById", "d3b67374-b74b-480f-904b-781db1a04f35"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("DeleteRequisitionTablesById", "d3b67374-b74b-480f-904b-781db1a04f35", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetInvoicesByRequisitionId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoicesByRequisitionId_maxRecords = 0;
int datasetGetInvoicesByRequisitionId_startIndex = 0;(localVars.queryResGetInvoicesByRequisitionId_outParamList,localVars.queryResGetInvoicesByRequisitionId_outParamCount) = await FuncActionDeleteRequisitionTablesById.datasetGetInvoicesByRequisitionId(requestContext,datasetGetInvoicesByRequisitionId_maxRecords,datasetGetInvoicesByRequisitionId_startIndex,IterationMultiplicity.Single,localVars.inParamRequisitionId,cancellationToken);

// Foreach GetInvoicesByRequisitionId.List
localVars.queryResGetInvoicesByRequisitionId_outParamList.StartIteration();
try {while (!((localVars.queryResGetInvoicesByRequisitionId_outParamList.Eof))) {
// DeleteInvoiceTablesById
await Actions.ActionDeleteInvoiceTablesById(requestContext,localVars.queryResGetInvoicesByRequisitionId_outParamList.CurrentRec.ssENInvoice.ssId,cancellationToken);

localVars.queryResGetInvoicesByRequisitionId_outParamList.Advance();
}

} finally {
localVars.queryResGetInvoicesByRequisitionId_outParamList.EndIteration();
}

// Query datasetGetRequisitionAccountingsByRequisitionId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequisitionAccountingsByRequisitionId_maxRecords = 0;
int datasetGetRequisitionAccountingsByRequisitionId_startIndex = 0;(localVars.queryResGetRequisitionAccountingsByRequisitionId_outParamList,localVars.queryResGetRequisitionAccountingsByRequisitionId_outParamCount) = await FuncActionDeleteRequisitionTablesById.datasetGetRequisitionAccountingsByRequisitionId(requestContext,datasetGetRequisitionAccountingsByRequisitionId_maxRecords,datasetGetRequisitionAccountingsByRequisitionId_startIndex,IterationMultiplicity.Single,localVars.inParamRequisitionId,cancellationToken);

// Foreach GetRequisitionAccountingsByRequisitionId.List
localVars.queryResGetRequisitionAccountingsByRequisitionId_outParamList.StartIteration();
try {while (!((localVars.queryResGetRequisitionAccountingsByRequisitionId_outParamList.Eof))) {
// Query datasetGetRequisitionAccConceptsByRequisitionAccountingId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequisitionAccConceptsByRequisitionAccountingId_maxRecords = 0;
int datasetGetRequisitionAccConceptsByRequisitionAccountingId_startIndex = 0;(localVars.queryResGetRequisitionAccConceptsByRequisitionAccountingId_outParamList,localVars.queryResGetRequisitionAccConceptsByRequisitionAccountingId_outParamCount) = await FuncActionDeleteRequisitionTablesById.datasetGetRequisitionAccConceptsByRequisitionAccountingId(requestContext,datasetGetRequisitionAccConceptsByRequisitionAccountingId_maxRecords,datasetGetRequisitionAccConceptsByRequisitionAccountingId_startIndex,IterationMultiplicity.Single,localVars.queryResGetRequisitionAccountingsByRequisitionId_outParamList.CurrentRec.ssENRequisitionAccounting.ssId,cancellationToken);

// Foreach GetRequisitionAccConceptsByRequisitionAccountingId.List
localVars.queryResGetRequisitionAccConceptsByRequisitionAccountingId_outParamList.StartIteration();
try {while (!((localVars.queryResGetRequisitionAccConceptsByRequisitionAccountingId_outParamList.Eof))) {
// DeleteRequisitionAccConcepts
await ExtendedActions.DeleteRequisitionAccConcepts(requestContext,localVars.queryResGetRequisitionAccConceptsByRequisitionAccountingId_outParamList.CurrentRec.ssENRequisitionAccConcepts.ssId,cancellationToken);

localVars.queryResGetRequisitionAccConceptsByRequisitionAccountingId_outParamList.Advance();
}

} finally {
localVars.queryResGetRequisitionAccConceptsByRequisitionAccountingId_outParamList.EndIteration();
}

// DeleteRequisitionAccounting
await ExtendedActions.DeleteRequisitionAccounting(requestContext,localVars.queryResGetRequisitionAccountingsByRequisitionId_outParamList.CurrentRec.ssENRequisitionAccounting.ssId,cancellationToken);

localVars.queryResGetRequisitionAccountingsByRequisitionId_outParamList.Advance();
}

} finally {
localVars.queryResGetRequisitionAccountingsByRequisitionId_outParamList.EndIteration();
}

// Query datasetGetRequisitionContractFilesByRequisitionId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequisitionContractFilesByRequisitionId_maxRecords = 0;
int datasetGetRequisitionContractFilesByRequisitionId_startIndex = 0;(localVars.queryResGetRequisitionContractFilesByRequisitionId_outParamList,localVars.queryResGetRequisitionContractFilesByRequisitionId_outParamCount) = await FuncActionDeleteRequisitionTablesById.datasetGetRequisitionContractFilesByRequisitionId(requestContext,datasetGetRequisitionContractFilesByRequisitionId_maxRecords,datasetGetRequisitionContractFilesByRequisitionId_startIndex,IterationMultiplicity.Single,localVars.inParamRequisitionId,cancellationToken);

// Foreach GetRequisitionContractFilesByRequisitionId.List
localVars.queryResGetRequisitionContractFilesByRequisitionId_outParamList.StartIteration();
try {while (!((localVars.queryResGetRequisitionContractFilesByRequisitionId_outParamList.Eof))) {
// Query datasetGetRequisitionFileById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequisitionFileById_maxRecords = 0;
int datasetGetRequisitionFileById_startIndex = 0;(localVars.queryResGetRequisitionFileById_outParamList,localVars.queryResGetRequisitionFileById_outParamCount) = await FuncActionDeleteRequisitionTablesById.datasetGetRequisitionFileById(requestContext,datasetGetRequisitionFileById_maxRecords,datasetGetRequisitionFileById_startIndex,IterationMultiplicity.Single,localVars.queryResGetRequisitionContractFilesByRequisitionId_outParamList.CurrentRec.ssENRequisitionContractFile.ssRequisitionFileId,cancellationToken);

// Foreach GetRequisitionFileById.List
localVars.queryResGetRequisitionFileById_outParamList.StartIteration();
try {while (!((localVars.queryResGetRequisitionFileById_outParamList.Eof))) {
// DeleteRequisitionFile2
await ExtendedActions.DeleteRequisitionFile2(requestContext,localVars.queryResGetRequisitionFileById_outParamList.CurrentRec.ssENRequisitionFile2.ssId,cancellationToken);

localVars.queryResGetRequisitionFileById_outParamList.Advance();
}

} finally {
localVars.queryResGetRequisitionFileById_outParamList.EndIteration();
}

// DeleteRequisitionContractFile
await ExtendedActions.DeleteRequisitionContractFile(requestContext,localVars.queryResGetRequisitionContractFilesByRequisitionId_outParamList.CurrentRec.ssENRequisitionContractFile.ssId,cancellationToken);

localVars.queryResGetRequisitionContractFilesByRequisitionId_outParamList.Advance();
}

} finally {
localVars.queryResGetRequisitionContractFilesByRequisitionId_outParamList.EndIteration();
}

// Query datasetGetRequisitionCommentsByRequisitionId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequisitionCommentsByRequisitionId_maxRecords = 0;
int datasetGetRequisitionCommentsByRequisitionId_startIndex = 0;(localVars.queryResGetRequisitionCommentsByRequisitionId_outParamList,localVars.queryResGetRequisitionCommentsByRequisitionId_outParamCount) = await FuncActionDeleteRequisitionTablesById.datasetGetRequisitionCommentsByRequisitionId(requestContext,datasetGetRequisitionCommentsByRequisitionId_maxRecords,datasetGetRequisitionCommentsByRequisitionId_startIndex,IterationMultiplicity.Single,localVars.inParamRequisitionId,cancellationToken);

// Foreach GetRequisitionCommentsByRequisitionId.List
localVars.queryResGetRequisitionCommentsByRequisitionId_outParamList.StartIteration();
try {while (!((localVars.queryResGetRequisitionCommentsByRequisitionId_outParamList.Eof))) {
// DeleteRequisitionComment
await ExtendedActions.DeleteRequisitionComment(requestContext,localVars.queryResGetRequisitionCommentsByRequisitionId_outParamList.CurrentRec.ssENRequisitionComment.ssId,cancellationToken);

localVars.queryResGetRequisitionCommentsByRequisitionId_outParamList.Advance();
}

} finally {
localVars.queryResGetRequisitionCommentsByRequisitionId_outParamList.EndIteration();
}

// Query datasetGetRequisitionApprovalsByRequisitionId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequisitionApprovalsByRequisitionId_maxRecords = 0;
int datasetGetRequisitionApprovalsByRequisitionId_startIndex = 0;(localVars.queryResGetRequisitionApprovalsByRequisitionId_outParamList,localVars.queryResGetRequisitionApprovalsByRequisitionId_outParamCount) = await FuncActionDeleteRequisitionTablesById.datasetGetRequisitionApprovalsByRequisitionId(requestContext,datasetGetRequisitionApprovalsByRequisitionId_maxRecords,datasetGetRequisitionApprovalsByRequisitionId_startIndex,IterationMultiplicity.Single,localVars.inParamRequisitionId,cancellationToken);

// Foreach GetRequisitionApprovalsByRequisitionId.List
localVars.queryResGetRequisitionApprovalsByRequisitionId_outParamList.StartIteration();
try {while (!((localVars.queryResGetRequisitionApprovalsByRequisitionId_outParamList.Eof))) {
// Query datasetGetRequisitionApprovalLevelsByRequisitionApprovalI
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequisitionApprovalLevelsByRequisitionApprovalI_maxRecords = 0;
int datasetGetRequisitionApprovalLevelsByRequisitionApprovalI_startIndex = 0;(localVars.queryResGetRequisitionApprovalLevelsByRequisitionApprovalI_outParamList,localVars.queryResGetRequisitionApprovalLevelsByRequisitionApprovalI_outParamCount) = await FuncActionDeleteRequisitionTablesById.datasetGetRequisitionApprovalLevelsByRequisitionApprovalI(requestContext,datasetGetRequisitionApprovalLevelsByRequisitionApprovalI_maxRecords,datasetGetRequisitionApprovalLevelsByRequisitionApprovalI_startIndex,IterationMultiplicity.Single,localVars.queryResGetRequisitionApprovalsByRequisitionId_outParamList.CurrentRec.ssENRequisitionApproval.ssId,cancellationToken);

// Foreach GetRequisitionApprovalLevelsByRequisitionApprovalI.List
localVars.queryResGetRequisitionApprovalLevelsByRequisitionApprovalI_outParamList.StartIteration();
try {while (!((localVars.queryResGetRequisitionApprovalLevelsByRequisitionApprovalI_outParamList.Eof))) {
// DeleteRequisitionApprovalLevel
await ExtendedActions.DeleteRequisitionApprovalLevel(requestContext,localVars.queryResGetRequisitionApprovalLevelsByRequisitionApprovalI_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssId,cancellationToken);

localVars.queryResGetRequisitionApprovalLevelsByRequisitionApprovalI_outParamList.Advance();
}

} finally {
localVars.queryResGetRequisitionApprovalLevelsByRequisitionApprovalI_outParamList.EndIteration();
}

// DeleteRequisitionApproval
await ExtendedActions.DeleteRequisitionApproval(requestContext,localVars.queryResGetRequisitionApprovalsByRequisitionId_outParamList.CurrentRec.ssENRequisitionApproval.ssId,cancellationToken);

localVars.queryResGetRequisitionApprovalsByRequisitionId_outParamList.Advance();
}

} finally {
localVars.queryResGetRequisitionApprovalsByRequisitionId_outParamList.EndIteration();
}

// Query datasetGetRequisitionCostCentersByRequisitionId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequisitionCostCentersByRequisitionId_maxRecords = 0;
int datasetGetRequisitionCostCentersByRequisitionId_startIndex = 0;(localVars.queryResGetRequisitionCostCentersByRequisitionId_outParamList,localVars.queryResGetRequisitionCostCentersByRequisitionId_outParamCount) = await FuncActionDeleteRequisitionTablesById.datasetGetRequisitionCostCentersByRequisitionId(requestContext,datasetGetRequisitionCostCentersByRequisitionId_maxRecords,datasetGetRequisitionCostCentersByRequisitionId_startIndex,IterationMultiplicity.Single,localVars.inParamRequisitionId,cancellationToken);

// Foreach GetRequisitionCostCentersByRequisitionId.List
localVars.queryResGetRequisitionCostCentersByRequisitionId_outParamList.StartIteration();
try {while (!((localVars.queryResGetRequisitionCostCentersByRequisitionId_outParamList.Eof))) {
// DeleteRequisitionCostCenter
await ExtendedActions.DeleteRequisitionCostCenter(requestContext,localVars.queryResGetRequisitionCostCentersByRequisitionId_outParamList.CurrentRec.ssENRequisitionCostCenter.ssId,cancellationToken);

localVars.queryResGetRequisitionCostCentersByRequisitionId_outParamList.Advance();
}

} finally {
localVars.queryResGetRequisitionCostCentersByRequisitionId_outParamList.EndIteration();
}

// Query datasetGetRequisitionServicesByRequisitionId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequisitionServicesByRequisitionId_maxRecords = 0;
int datasetGetRequisitionServicesByRequisitionId_startIndex = 0;(localVars.queryResGetRequisitionServicesByRequisitionId_outParamList,localVars.queryResGetRequisitionServicesByRequisitionId_outParamCount) = await FuncActionDeleteRequisitionTablesById.datasetGetRequisitionServicesByRequisitionId(requestContext,datasetGetRequisitionServicesByRequisitionId_maxRecords,datasetGetRequisitionServicesByRequisitionId_startIndex,IterationMultiplicity.Single,localVars.inParamRequisitionId,cancellationToken);

// Foreach GetRequisitionServicesByRequisitionId.List
localVars.queryResGetRequisitionServicesByRequisitionId_outParamList.StartIteration();
try {while (!((localVars.queryResGetRequisitionServicesByRequisitionId_outParamList.Eof))) {
// DeleteRequisitionService
await ExtendedActions.DeleteRequisitionService(requestContext,localVars.queryResGetRequisitionServicesByRequisitionId_outParamList.CurrentRec.ssENRequisitionService.ssId,cancellationToken);

localVars.queryResGetRequisitionServicesByRequisitionId_outParamList.Advance();
}

} finally {
localVars.queryResGetRequisitionServicesByRequisitionId_outParamList.EndIteration();
}

// Query datasetGetRequisitionVersionsByOriginalRequisitionId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequisitionVersionsByOriginalRequisitionId_maxRecords = 0;
int datasetGetRequisitionVersionsByOriginalRequisitionId_startIndex = 0;(localVars.queryResGetRequisitionVersionsByOriginalRequisitionId_outParamList,localVars.queryResGetRequisitionVersionsByOriginalRequisitionId_outParamCount) = await FuncActionDeleteRequisitionTablesById.datasetGetRequisitionVersionsByOriginalRequisitionId(requestContext,datasetGetRequisitionVersionsByOriginalRequisitionId_maxRecords,datasetGetRequisitionVersionsByOriginalRequisitionId_startIndex,IterationMultiplicity.Single,localVars.inParamRequisitionId,cancellationToken);

// Foreach GetRequisitionVersionsByOriginalRequisitionId.List
localVars.queryResGetRequisitionVersionsByOriginalRequisitionId_outParamList.StartIteration();
try {while (!((localVars.queryResGetRequisitionVersionsByOriginalRequisitionId_outParamList.Eof))) {
// DeleteRequisitionVersion
await ExtendedActions.DeleteRequisitionVersion(requestContext,localVars.queryResGetRequisitionVersionsByOriginalRequisitionId_outParamList.CurrentRec.ssENRequisitionVersion.ssId,cancellationToken);

localVars.queryResGetRequisitionVersionsByOriginalRequisitionId_outParamList.Advance();
}

} finally {
localVars.queryResGetRequisitionVersionsByOriginalRequisitionId_outParamList.EndIteration();
}

// Query datasetGetRequisitionStatusHistoriesByRequisitionId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequisitionStatusHistoriesByRequisitionId_maxRecords = 0;
int datasetGetRequisitionStatusHistoriesByRequisitionId_startIndex = 0;(localVars.queryResGetRequisitionStatusHistoriesByRequisitionId_outParamList,localVars.queryResGetRequisitionStatusHistoriesByRequisitionId_outParamCount) = await FuncActionDeleteRequisitionTablesById.datasetGetRequisitionStatusHistoriesByRequisitionId(requestContext,datasetGetRequisitionStatusHistoriesByRequisitionId_maxRecords,datasetGetRequisitionStatusHistoriesByRequisitionId_startIndex,IterationMultiplicity.Single,localVars.inParamRequisitionId,cancellationToken);

// Foreach GetRequisitionStatusHistoriesByRequisitionId.List
localVars.queryResGetRequisitionStatusHistoriesByRequisitionId_outParamList.StartIteration();
try {while (!((localVars.queryResGetRequisitionStatusHistoriesByRequisitionId_outParamList.Eof))) {
// DeleteRequisitionStatusHistory
await ExtendedActions.DeleteRequisitionStatusHistory(requestContext,localVars.queryResGetRequisitionStatusHistoriesByRequisitionId_outParamList.CurrentRec.ssENRequisitionStatusHistory.ssId,cancellationToken);

localVars.queryResGetRequisitionStatusHistoriesByRequisitionId_outParamList.Advance();
}

} finally {
localVars.queryResGetRequisitionStatusHistoriesByRequisitionId_outParamList.EndIteration();
}

// Query datasetGetRequisitionLogsByRequisitionId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequisitionLogsByRequisitionId_maxRecords = 0;
int datasetGetRequisitionLogsByRequisitionId_startIndex = 0;(localVars.queryResGetRequisitionLogsByRequisitionId_outParamList,localVars.queryResGetRequisitionLogsByRequisitionId_outParamCount) = await FuncActionDeleteRequisitionTablesById.datasetGetRequisitionLogsByRequisitionId(requestContext,datasetGetRequisitionLogsByRequisitionId_maxRecords,datasetGetRequisitionLogsByRequisitionId_startIndex,IterationMultiplicity.Single,localVars.inParamRequisitionId,cancellationToken);

// Foreach GetRequisitionLogsByRequisitionId.List
localVars.queryResGetRequisitionLogsByRequisitionId_outParamList.StartIteration();
try {while (!((localVars.queryResGetRequisitionLogsByRequisitionId_outParamList.Eof))) {
// DeleteRequisitionLogs
await ExtendedActions.DeleteRequisitionLogs(requestContext,localVars.queryResGetRequisitionLogsByRequisitionId_outParamList.CurrentRec.ssENRequisitionLogs.ssId,cancellationToken);

localVars.queryResGetRequisitionLogsByRequisitionId_outParamList.Advance();
}

} finally {
localVars.queryResGetRequisitionLogsByRequisitionId_outParamList.EndIteration();
}

// DeleteRequisition
await ExtendedActions.DeleteRequisition(requestContext,localVars.inParamRequisitionId,cancellationToken);

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionDeleteRequisitionTablesById {

// Query Function "GetRequisitionServicesByRequisitionId" ig4oCBv9JkKyTMEKNK32Cg of Action "DeleteRequisitionTablesById"
public static async Task<(RL_b47d9310671b1b627f451a333bb8980a,long)> datasetGetRequisitionServicesByRequisitionId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRequisitionId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("DeleteRequisitionTablesById.GetRequisitionServicesByRequisitionId", "08280e8a-fd1b-4226-b24c-c10a34adf60a");
using var queryActivity = activitySource.CreateAggregateQueryActivity("DeleteRequisitionTablesById.GetRequisitionServicesByRequisitionId", "08280e8a-fd1b-4226-b24c-c10a34adf60a", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.dHO200u3D0iQS3gdsaBPNQ/NodesNotShownInESpaceTree.ig4oCBv9JkKyTMEKNK32Cg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enrequisitionservice3\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6");
fromBuilder.Append(" FROM {RequisitionService} \"enrequisitionservice3\"");
whereBuilder.Append(" WHERE ");
if (qpreRequisitionId != 0) {
whereBuilder.Append("((\"enrequisitionservice3\".\"requisitionid\" = @qpreRequisitionId) AND (\"enrequisitionservice3\".\"requisitionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisitionId", DbType.Int64, qpreRequisitionId);
} else {
whereBuilder.Append("(\"enrequisitionservice3\".\"requisitionid\" IS NULL)");
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
RL_b47d9310671b1b627f451a333bb8980a outParamList = new RL_b47d9310671b1b627f451a333bb8980a();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query DeleteRequisitionTablesById.GetRequisitionServicesByRequisitionId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_b47d9310671b1b627f451a333bb8980a _tmp = new RL_b47d9310671b1b627f451a333bb8980a();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query DeleteRequisitionTablesById.GetRequisitionServicesByRequisitionId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_b47d9310671b1b627f451a333bb8980a)_tmp;
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

// Query Function "GetRequisitionAccountingsByRequisitionId" iv6_EtsXmUSM48Wzv4Urxg of Action "DeleteRequisitionTablesById"
public static async Task<(RL_991db829ff4e7fe204109f106256f023,long)> datasetGetRequisitionAccountingsByRequisitionId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRequisitionId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("DeleteRequisitionTablesById.GetRequisitionAccountingsByRequisitionId", "12bffe8a-17db-4499-8ce3-c5b3bf852bc6");
using var queryActivity = activitySource.CreateAggregateQueryActivity("DeleteRequisitionTablesById.GetRequisitionAccountingsByRequisitionId", "12bffe8a-17db-4499-8ce3-c5b3bf852bc6", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.dHO200u3D0iQS3gdsaBPNQ/NodesNotShownInESpaceTree.iv6_EtsXmUSM48Wzv4Urxg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enrequisitionaccounting5\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18");
fromBuilder.Append(" FROM {RequisitionAccounting} \"enrequisitionaccounting5\"");
whereBuilder.Append(" WHERE ");
if (qpreRequisitionId != 0) {
whereBuilder.Append("((\"enrequisitionaccounting5\".\"requisitionid\" = @qpreRequisitionId) AND (\"enrequisitionaccounting5\".\"requisitionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisitionId", DbType.Int64, qpreRequisitionId);
} else {
whereBuilder.Append("(\"enrequisitionaccounting5\".\"requisitionid\" IS NULL)");
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
RL_991db829ff4e7fe204109f106256f023 outParamList = new RL_991db829ff4e7fe204109f106256f023();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query DeleteRequisitionTablesById.GetRequisitionAccountingsByRequisitionId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_991db829ff4e7fe204109f106256f023 _tmp = new RL_991db829ff4e7fe204109f106256f023();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query DeleteRequisitionTablesById.GetRequisitionAccountingsByRequisitionId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_991db829ff4e7fe204109f106256f023)_tmp;
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

// Query Function "GetRequisitionFileById" MqS7IctL4kWu5BTIvrbpIg of Action "DeleteRequisitionTablesById"
public static async Task<(RL_2895ef65cfa24878b5b55c2c334b2f76,long)> datasetGetRequisitionFileById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("DeleteRequisitionTablesById.GetRequisitionFileById", "21bba432-4bcb-45e2-aee4-14c8beb6e922");
using var queryActivity = activitySource.CreateAggregateQueryActivity("DeleteRequisitionTablesById.GetRequisitionFileById", "21bba432-4bcb-45e2-aee4-14c8beb6e922", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.dHO200u3D0iQS3gdsaBPNQ/NodesNotShownInESpaceTree.MqS7IctL4kWu5BTIvrbpIg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enrequisitionfile28\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7");
fromBuilder.Append(" FROM {RequisitionFile2} \"enrequisitionfile28\"");
whereBuilder.Append(" WHERE ");
if (qpreId != 0) {
whereBuilder.Append("((\"enrequisitionfile28\".\"id\" = @qpreId) AND (\"enrequisitionfile28\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreId", DbType.Int64, qpreId);
} else {
whereBuilder.Append("(\"enrequisitionfile28\".\"id\" IS NULL)");
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
RL_2895ef65cfa24878b5b55c2c334b2f76 outParamList = new RL_2895ef65cfa24878b5b55c2c334b2f76();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query DeleteRequisitionTablesById.GetRequisitionFileById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_2895ef65cfa24878b5b55c2c334b2f76 _tmp = new RL_2895ef65cfa24878b5b55c2c334b2f76();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query DeleteRequisitionTablesById.GetRequisitionFileById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_2895ef65cfa24878b5b55c2c334b2f76)_tmp;
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

// Query Function "GetInvoicesByRequisitionId" 0qMZK7MCFEyEqg2sSSrMXQ of Action "DeleteRequisitionTablesById"
public static async Task<(RL_7b3475883ca90ad6eb7fc983e868c456,long)> datasetGetInvoicesByRequisitionId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRequisitionId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("DeleteRequisitionTablesById.GetInvoicesByRequisitionId", "2b19a3d2-02b3-4c14-84aa-0dac492acc5d");
using var queryActivity = activitySource.CreateAggregateQueryActivity("DeleteRequisitionTablesById.GetInvoicesByRequisitionId", "2b19a3d2-02b3-4c14-84aa-0dac492acc5d", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.dHO200u3D0iQS3gdsaBPNQ/NodesNotShownInESpaceTree.0qMZK7MCFEyEqg2sSSrMXQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoice66\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23");
fromBuilder.Append(" FROM {Invoice} \"eninvoice66\"");
whereBuilder.Append(" WHERE ");
if (qpreRequisitionId != 0) {
whereBuilder.Append("((\"eninvoice66\".\"requisitionid\" = @qpreRequisitionId) AND (\"eninvoice66\".\"requisitionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisitionId", DbType.Int64, qpreRequisitionId);
} else {
whereBuilder.Append("(\"eninvoice66\".\"requisitionid\" IS NULL)");
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
RL_7b3475883ca90ad6eb7fc983e868c456 outParamList = new RL_7b3475883ca90ad6eb7fc983e868c456();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query DeleteRequisitionTablesById.GetInvoicesByRequisitionId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_7b3475883ca90ad6eb7fc983e868c456 _tmp = new RL_7b3475883ca90ad6eb7fc983e868c456();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query DeleteRequisitionTablesById.GetInvoicesByRequisitionId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_7b3475883ca90ad6eb7fc983e868c456)_tmp;
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

// Query Function "GetRequisitionApprovalsByRequisitionId" AkefS0DdiEON6Q7uX_RMYw of Action "DeleteRequisitionTablesById"
public static async Task<(RL_7f2260a280cd6c85f68a2e5dbb44ffad,long)> datasetGetRequisitionApprovalsByRequisitionId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRequisitionId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("DeleteRequisitionTablesById.GetRequisitionApprovalsByRequisitionId", "4b9f4702-dd40-4388-8de9-0eee5ff44c63");
using var queryActivity = activitySource.CreateAggregateQueryActivity("DeleteRequisitionTablesById.GetRequisitionApprovalsByRequisitionId", "4b9f4702-dd40-4388-8de9-0eee5ff44c63", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.dHO200u3D0iQS3gdsaBPNQ/NodesNotShownInESpaceTree.AkefS0DdiEON6Q7uX_RMYw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enrequisitionapproval16\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9");
fromBuilder.Append(" FROM {RequisitionApproval} \"enrequisitionapproval16\"");
whereBuilder.Append(" WHERE ");
if (qpreRequisitionId != 0) {
whereBuilder.Append("((\"enrequisitionapproval16\".\"requisitionid\" = @qpreRequisitionId) AND (\"enrequisitionapproval16\".\"requisitionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisitionId", DbType.Int64, qpreRequisitionId);
} else {
whereBuilder.Append("(\"enrequisitionapproval16\".\"requisitionid\" IS NULL)");
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
RL_7f2260a280cd6c85f68a2e5dbb44ffad outParamList = new RL_7f2260a280cd6c85f68a2e5dbb44ffad();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query DeleteRequisitionTablesById.GetRequisitionApprovalsByRequisitionId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_7f2260a280cd6c85f68a2e5dbb44ffad _tmp = new RL_7f2260a280cd6c85f68a2e5dbb44ffad();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query DeleteRequisitionTablesById.GetRequisitionApprovalsByRequisitionId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_7f2260a280cd6c85f68a2e5dbb44ffad)_tmp;
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

// Query Function "GetRequisitionAccConceptsByRequisitionAccountingId" Is6fWjrOeEigQKvBvTZmUg of Action "DeleteRequisitionTablesById"
public static async Task<(RL_67eeb6e2fea6e1fe75fd0bc7d38796a5,long)> datasetGetRequisitionAccConceptsByRequisitionAccountingId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRequisitionAccountingId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("DeleteRequisitionTablesById.GetRequisitionAccConceptsByRequisitionAccountingId", "5a9fce22-ce3a-4878-a040-abc1bd366652");
using var queryActivity = activitySource.CreateAggregateQueryActivity("DeleteRequisitionTablesById.GetRequisitionAccConceptsByRequisitionAccountingId", "5a9fce22-ce3a-4878-a040-abc1bd366652", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.dHO200u3D0iQS3gdsaBPNQ/NodesNotShownInESpaceTree.Is6fWjrOeEigQKvBvTZmUg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enrequisitionaccconcepts4\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7");
fromBuilder.Append(" FROM {RequisitionAccConcepts} \"enrequisitionaccconcepts4\"");
whereBuilder.Append(" WHERE ");
if (qpreRequisitionAccountingId != 0) {
whereBuilder.Append("((\"enrequisitionaccconcepts4\".\"requisitionaccountingid\" = @qpreRequisitionAccountingId) AND (\"enrequisitionaccconcepts4\".\"requisitionaccountingid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisitionAccountingId", DbType.Int64, qpreRequisitionAccountingId);
} else {
whereBuilder.Append("(\"enrequisitionaccconcepts4\".\"requisitionaccountingid\" IS NULL)");
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
RL_67eeb6e2fea6e1fe75fd0bc7d38796a5 outParamList = new RL_67eeb6e2fea6e1fe75fd0bc7d38796a5();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query DeleteRequisitionTablesById.GetRequisitionAccConceptsByRequisitionAccountingId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_67eeb6e2fea6e1fe75fd0bc7d38796a5 _tmp = new RL_67eeb6e2fea6e1fe75fd0bc7d38796a5();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query DeleteRequisitionTablesById.GetRequisitionAccConceptsByRequisitionAccountingId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_67eeb6e2fea6e1fe75fd0bc7d38796a5)_tmp;
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

// Query Function "GetRequisitionLogsByRequisitionId" xd5aZ3whTUO88fyw7x86zw of Action "DeleteRequisitionTablesById"
public static async Task<(RL_57c324e581f9aea86c504fb7e70730b1,long)> datasetGetRequisitionLogsByRequisitionId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRequisitionId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("DeleteRequisitionTablesById.GetRequisitionLogsByRequisitionId", "675adec5-217c-434d-bcf1-fcb0ef1f3acf");
using var queryActivity = activitySource.CreateAggregateQueryActivity("DeleteRequisitionTablesById.GetRequisitionLogsByRequisitionId", "675adec5-217c-434d-bcf1-fcb0ef1f3acf", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.dHO200u3D0iQS3gdsaBPNQ/NodesNotShownInESpaceTree.xd5aZ3whTUO88fyw7x86zw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enrequisitionlogs1\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5");
fromBuilder.Append(" FROM {RequisitionLogs} \"enrequisitionlogs1\"");
whereBuilder.Append(" WHERE ");
if (qpreRequisitionId != 0) {
whereBuilder.Append("((\"enrequisitionlogs1\".\"requisitionid\" = @qpreRequisitionId) AND (\"enrequisitionlogs1\".\"requisitionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisitionId", DbType.Int64, qpreRequisitionId);
} else {
whereBuilder.Append("(\"enrequisitionlogs1\".\"requisitionid\" IS NULL)");
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
RL_57c324e581f9aea86c504fb7e70730b1 outParamList = new RL_57c324e581f9aea86c504fb7e70730b1();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query DeleteRequisitionTablesById.GetRequisitionLogsByRequisitionId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_57c324e581f9aea86c504fb7e70730b1 _tmp = new RL_57c324e581f9aea86c504fb7e70730b1();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query DeleteRequisitionTablesById.GetRequisitionLogsByRequisitionId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_57c324e581f9aea86c504fb7e70730b1)_tmp;
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

// Query Function "GetRequisitionCommentsByRequisitionId" MfZ7c29+m0muxDbk1TP6zw of Action "DeleteRequisitionTablesById"
public static async Task<(RL_3933323760320045e42588bf0a23c855,long)> datasetGetRequisitionCommentsByRequisitionId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRequisitionId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("DeleteRequisitionTablesById.GetRequisitionCommentsByRequisitionId", "737bf631-7e6f-499b-aec4-36e4d533facf");
using var queryActivity = activitySource.CreateAggregateQueryActivity("DeleteRequisitionTablesById.GetRequisitionCommentsByRequisitionId", "737bf631-7e6f-499b-aec4-36e4d533facf", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.dHO200u3D0iQS3gdsaBPNQ/NodesNotShownInESpaceTree.MfZ7c29+m0muxDbk1TP6zw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enrequisitioncomment\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7");
fromBuilder.Append(" FROM {RequisitionComment} \"enrequisitioncomment\"");
whereBuilder.Append(" WHERE ");
if (qpreRequisitionId != 0) {
whereBuilder.Append("((\"enrequisitioncomment\".\"requisitionid\" = @qpreRequisitionId) AND (\"enrequisitioncomment\".\"requisitionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisitionId", DbType.Int64, qpreRequisitionId);
} else {
whereBuilder.Append("(\"enrequisitioncomment\".\"requisitionid\" IS NULL)");
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
RL_3933323760320045e42588bf0a23c855 outParamList = new RL_3933323760320045e42588bf0a23c855();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query DeleteRequisitionTablesById.GetRequisitionCommentsByRequisitionId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_3933323760320045e42588bf0a23c855 _tmp = new RL_3933323760320045e42588bf0a23c855();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query DeleteRequisitionTablesById.GetRequisitionCommentsByRequisitionId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_3933323760320045e42588bf0a23c855)_tmp;
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

// Query Function "GetRequisitionStatusHistoriesByRequisitionId" Y8lifBjHKU+hNqpKvQuTPw of Action "DeleteRequisitionTablesById"
public static async Task<(RL_40212690d01342e9b25b0ac7249068cf,long)> datasetGetRequisitionStatusHistoriesByRequisitionId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRequisitionId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("DeleteRequisitionTablesById.GetRequisitionStatusHistoriesByRequisitionId", "7c62c963-c718-4f29-a136-aa4abd0b933f");
using var queryActivity = activitySource.CreateAggregateQueryActivity("DeleteRequisitionTablesById.GetRequisitionStatusHistoriesByRequisitionId", "7c62c963-c718-4f29-a136-aa4abd0b933f", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.dHO200u3D0iQS3gdsaBPNQ/NodesNotShownInESpaceTree.Y8lifBjHKU+hNqpKvQuTPw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enrequisitionstatushistory\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4");
fromBuilder.Append(" FROM {RequisitionStatusHistory} \"enrequisitionstatushistory\"");
whereBuilder.Append(" WHERE ");
if (qpreRequisitionId != 0) {
whereBuilder.Append("((\"enrequisitionstatushistory\".\"requisitionid\" = @qpreRequisitionId) AND (\"enrequisitionstatushistory\".\"requisitionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisitionId", DbType.Int64, qpreRequisitionId);
} else {
whereBuilder.Append("(\"enrequisitionstatushistory\".\"requisitionid\" IS NULL)");
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
RL_40212690d01342e9b25b0ac7249068cf outParamList = new RL_40212690d01342e9b25b0ac7249068cf();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query DeleteRequisitionTablesById.GetRequisitionStatusHistoriesByRequisitionId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_40212690d01342e9b25b0ac7249068cf _tmp = new RL_40212690d01342e9b25b0ac7249068cf();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query DeleteRequisitionTablesById.GetRequisitionStatusHistoriesByRequisitionId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_40212690d01342e9b25b0ac7249068cf)_tmp;
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

// Query Function "GetRequisitionVersionsByOriginalRequisitionId" Ev+wmgXY70eijJK8sWMnnA of Action "DeleteRequisitionTablesById"
public static async Task<(RL_16a3629886d5e012aa547b904dd63379,long)> datasetGetRequisitionVersionsByOriginalRequisitionId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreNewRequisitionId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("DeleteRequisitionTablesById.GetRequisitionVersionsByOriginalRequisitionId", "9ab0ff12-d805-47ef-a28c-92bcb163279c");
using var queryActivity = activitySource.CreateAggregateQueryActivity("DeleteRequisitionTablesById.GetRequisitionVersionsByOriginalRequisitionId", "9ab0ff12-d805-47ef-a28c-92bcb163279c", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.dHO200u3D0iQS3gdsaBPNQ/NodesNotShownInESpaceTree.Ev+wmgXY70eijJK8sWMnnA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enrequisitionversion\".\"id\" o0, NULL o1, NULL o2, NULL o3");
fromBuilder.Append(" FROM {RequisitionVersion} \"enrequisitionversion\"");
whereBuilder.Append(" WHERE ");
if (qpreNewRequisitionId != 0) {
whereBuilder.Append("((\"enrequisitionversion\".\"newrequisitionid\" = @qpreNewRequisitionId) AND (\"enrequisitionversion\".\"newrequisitionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreNewRequisitionId", DbType.Int64, qpreNewRequisitionId);
} else {
whereBuilder.Append("(\"enrequisitionversion\".\"newrequisitionid\" IS NULL)");
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
RL_16a3629886d5e012aa547b904dd63379 outParamList = new RL_16a3629886d5e012aa547b904dd63379();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query DeleteRequisitionTablesById.GetRequisitionVersionsByOriginalRequisitionId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_16a3629886d5e012aa547b904dd63379 _tmp = new RL_16a3629886d5e012aa547b904dd63379();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query DeleteRequisitionTablesById.GetRequisitionVersionsByOriginalRequisitionId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_16a3629886d5e012aa547b904dd63379)_tmp;
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

// Query Function "GetRequisitionContractFilesByRequisitionId" WrO2r4t6lUaKtoyi2aU7Cg of Action "DeleteRequisitionTablesById"
public static async Task<(RL_25486e09ba20acde3d8ef9d3e8a6e625,long)> datasetGetRequisitionContractFilesByRequisitionId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRequisitionId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("DeleteRequisitionTablesById.GetRequisitionContractFilesByRequisitionId", "afb6b35a-7a8b-4695-8ab6-8ca2d9a53b0a");
using var queryActivity = activitySource.CreateAggregateQueryActivity("DeleteRequisitionTablesById.GetRequisitionContractFilesByRequisitionId", "afb6b35a-7a8b-4695-8ab6-8ca2d9a53b0a", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.dHO200u3D0iQS3gdsaBPNQ/NodesNotShownInESpaceTree.WrO2r4t6lUaKtoyi2aU7Cg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enrequisitioncontractfile9\".\"id\" o0, NULL o1, \"enrequisitioncontractfile9\".\"requisitionfileid\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8");
fromBuilder.Append(" FROM {RequisitionContractFile} \"enrequisitioncontractfile9\"");
whereBuilder.Append(" WHERE ");
if (qpreRequisitionId != 0) {
whereBuilder.Append("((\"enrequisitioncontractfile9\".\"requisitionid\" = @qpreRequisitionId) AND (\"enrequisitioncontractfile9\".\"requisitionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisitionId", DbType.Int64, qpreRequisitionId);
} else {
whereBuilder.Append("(\"enrequisitioncontractfile9\".\"requisitionid\" IS NULL)");
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
RL_25486e09ba20acde3d8ef9d3e8a6e625 outParamList = new RL_25486e09ba20acde3d8ef9d3e8a6e625();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, false, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query DeleteRequisitionTablesById.GetRequisitionContractFilesByRequisitionId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_25486e09ba20acde3d8ef9d3e8a6e625 _tmp = new RL_25486e09ba20acde3d8ef9d3e8a6e625();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query DeleteRequisitionTablesById.GetRequisitionContractFilesByRequisitionId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_25486e09ba20acde3d8ef9d3e8a6e625)_tmp;
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

// Query Function "GetRequisitionApprovalLevelsByRequisitionApprovalI" RzH6zAzoAEqLmsADwwnfOg of Action "DeleteRequisitionTablesById"
public static async Task<(RL_d8bc800f4e3c344ab91bf54150e31a34,long)> datasetGetRequisitionApprovalLevelsByRequisitionApprovalI(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRequisitionApprovalId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("DeleteRequisitionTablesById.GetRequisitionApprovalLevelsByRequisitionApprovalI", "ccfa3147-e80c-4a00-8b9a-c003c309df3a");
using var queryActivity = activitySource.CreateAggregateQueryActivity("DeleteRequisitionTablesById.GetRequisitionApprovalLevelsByRequisitionApprovalI", "ccfa3147-e80c-4a00-8b9a-c003c309df3a", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.dHO200u3D0iQS3gdsaBPNQ/NodesNotShownInESpaceTree.RzH6zAzoAEqLmsADwwnfOg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enrequisitionapprovallevel14\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25");
fromBuilder.Append(" FROM {RequisitionApprovalLevel} \"enrequisitionapprovallevel14\"");
whereBuilder.Append(" WHERE ");
if (qpreRequisitionApprovalId != 0) {
whereBuilder.Append("((\"enrequisitionapprovallevel14\".\"requisitionapprovalid\" = @qpreRequisitionApprovalId) AND (\"enrequisitionapprovallevel14\".\"requisitionapprovalid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisitionApprovalId", DbType.Int64, qpreRequisitionApprovalId);
} else {
whereBuilder.Append("(\"enrequisitionapprovallevel14\".\"requisitionapprovalid\" IS NULL)");
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
RL_d8bc800f4e3c344ab91bf54150e31a34 outParamList = new RL_d8bc800f4e3c344ab91bf54150e31a34();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query DeleteRequisitionTablesById.GetRequisitionApprovalLevelsByRequisitionApprovalI.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_d8bc800f4e3c344ab91bf54150e31a34 _tmp = new RL_d8bc800f4e3c344ab91bf54150e31a34();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query DeleteRequisitionTablesById.GetRequisitionApprovalLevelsByRequisitionApprovalI.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_d8bc800f4e3c344ab91bf54150e31a34)_tmp;
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

// Query Function "GetRequisitionCostCentersByRequisitionId" Rpid+5oY4UGr9DTgeX2Q6Q of Action "DeleteRequisitionTablesById"
public static async Task<(RL_d3e0bac8462c62ccd7f8cc475394c310,long)> datasetGetRequisitionCostCentersByRequisitionId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRequisitionId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("DeleteRequisitionTablesById.GetRequisitionCostCentersByRequisitionId", "fb9d9846-189a-41e1-abf4-34e0797d90e9");
using var queryActivity = activitySource.CreateAggregateQueryActivity("DeleteRequisitionTablesById.GetRequisitionCostCentersByRequisitionId", "fb9d9846-189a-41e1-abf4-34e0797d90e9", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.dHO200u3D0iQS3gdsaBPNQ/NodesNotShownInESpaceTree.Rpid+5oY4UGr9DTgeX2Q6Q, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enrequisitioncostcenter1\".\"id\" o0, NULL o1, NULL o2");
fromBuilder.Append(" FROM {RequisitionCostCenter} \"enrequisitioncostcenter1\"");
whereBuilder.Append(" WHERE ");
if (qpreRequisitionId != 0) {
whereBuilder.Append("((\"enrequisitioncostcenter1\".\"requisitionid\" = @qpreRequisitionId) AND (\"enrequisitioncostcenter1\".\"requisitionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisitionId", DbType.Int64, qpreRequisitionId);
} else {
whereBuilder.Append("(\"enrequisitioncostcenter1\".\"requisitionid\" IS NULL)");
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
RL_d3e0bac8462c62ccd7f8cc475394c310 outParamList = new RL_d3e0bac8462c62ccd7f8cc475394c310();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query DeleteRequisitionTablesById.GetRequisitionCostCentersByRequisitionId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_d3e0bac8462c62ccd7f8cc475394c310 _tmp = new RL_d3e0bac8462c62ccd7f8cc475394c310();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query DeleteRequisitionTablesById.GetRequisitionCostCentersByRequisitionId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_d3e0bac8462c62ccd7f8cc475394c310)_tmp;
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
