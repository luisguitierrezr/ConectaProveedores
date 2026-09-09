namespace ssConectaProveedores;

public partial class Actions {
public class lcvDeleteInvoiceTablesById : VarsBag {
public long inParamInvoiceId;
public RL_2e7f130f9df070446bc2a9ac7dcde539 queryResGetInvoiceCommentsByInvoiceId_outParamList = new RL_2e7f130f9df070446bc2a9ac7dcde539();
public long queryResGetInvoiceCommentsByInvoiceId_outParamCount = 0L;

public RL_61b7015322a190028a6e9742f654db41 queryResGetInvoiceStatusHistoriesByInvoiceId_outParamList = new RL_61b7015322a190028a6e9742f654db41();
public long queryResGetInvoiceStatusHistoriesByInvoiceId_outParamCount = 0L;

public RL_741430f005c8952521bfb8de73240573 queryResGetInvoiceLogsByInvoiceId_outParamList = new RL_741430f005c8952521bfb8de73240573();
public long queryResGetInvoiceLogsByInvoiceId_outParamCount = 0L;

public RL_b496b6dad8a76ef02aafdb1cf78f19ec queryResGetInvoiceApprovalsByInvoiceId_outParamList = new RL_b496b6dad8a76ef02aafdb1cf78f19ec();
public long queryResGetInvoiceApprovalsByInvoiceId_outParamCount = 0L;

public RL_5b975f6376260cc87a4dc39e570700ae queryResGetInvoiceExtendedItemTaxsByInvoiceExtendedItemId_outParamList = new RL_5b975f6376260cc87a4dc39e570700ae();
public long queryResGetInvoiceExtendedItemTaxsByInvoiceExtendedItemId_outParamCount = 0L;

public RL_00a03f803f0d49826089181417370afb queryResGetInvoiceFilesByInvoiceId_outParamList = new RL_00a03f803f0d49826089181417370afb();
public long queryResGetInvoiceFilesByInvoiceId_outParamCount = 0L;

public RL_ccf70f600f06def33a14ca10a1120a68 queryResGetInvoiceAccountingsByInvoiceId_outParamList = new RL_ccf70f600f06def33a14ca10a1120a68();
public long queryResGetInvoiceAccountingsByInvoiceId_outParamCount = 0L;

public RL_9404dc36b913809894c7e4e44e8e1dd8 queryResGetInvoiceExtendedTaxsByInvoiceId_outParamList = new RL_9404dc36b913809894c7e4e44e8e1dd8();
public long queryResGetInvoiceExtendedTaxsByInvoiceId_outParamCount = 0L;

public RL_ef088826c46241557fb82e7c7f21d334 queryResGetInvoiceExtendedMoreChargesByInvoiceId_outParamList = new RL_ef088826c46241557fb82e7c7f21d334();
public long queryResGetInvoiceExtendedMoreChargesByInvoiceId_outParamCount = 0L;

public RL_b2132c93db5fd1f839353b7412eed8f5 queryResGetInvoiceApprovalLevelsByInvoiceApprovalId_outParamList = new RL_b2132c93db5fd1f839353b7412eed8f5();
public long queryResGetInvoiceApprovalLevelsByInvoiceApprovalId_outParamCount = 0L;

public RL_ce67f504f77874aaecc91ad036f8a95a queryResGetInvoiceAccountingCostCentersByInvoiceAccounting_outParamList = new RL_ce67f504f77874aaecc91ad036f8a95a();
public long queryResGetInvoiceAccountingCostCentersByInvoiceAccounting_outParamCount = 0L;

public RL_d07e089b14ae41d13cfd90c5313de016 queryResGetInvoiceExtendedRelationsByInvoiceId_outParamList = new RL_d07e089b14ae41d13cfd90c5313de016();
public long queryResGetInvoiceExtendedRelationsByInvoiceId_outParamCount = 0L;

public RL_772f048f6ee632348101044a1e0eef2f queryResGetInvoiceExtendedItemsByInvoiceId_outParamList = new RL_772f048f6ee632348101044a1e0eef2f();
public long queryResGetInvoiceExtendedItemsByInvoiceId_outParamCount = 0L;

public lcvDeleteInvoiceTablesById(long inParamInvoiceId) {
this.inParamInvoiceId = inParamInvoiceId;
}
}
/// <summary>
/// Action <code>DeleteInvoiceTablesById</code> that represents the Service Studio action
///  <code>DeleteInvoiceTablesById</code> <p> Description: </p>
/// </summary>
public static async Task ActionDeleteInvoiceTablesById(IRequestContext requestContext,long inParamInvoiceId,CancellationToken cancellationToken) {
lcvDeleteInvoiceTablesById localVars = new lcvDeleteInvoiceTablesById(inParamInvoiceId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("DeleteInvoiceTablesById", "c9a0d882-9c8a-40ee-9583-f8d5724aa806"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("DeleteInvoiceTablesById", "c9a0d882-9c8a-40ee-9583-f8d5724aa806", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetInvoiceExtendedItemsByInvoiceId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceExtendedItemsByInvoiceId_maxRecords = 0;
int datasetGetInvoiceExtendedItemsByInvoiceId_startIndex = 0;(localVars.queryResGetInvoiceExtendedItemsByInvoiceId_outParamList,localVars.queryResGetInvoiceExtendedItemsByInvoiceId_outParamCount) = await FuncActionDeleteInvoiceTablesById.datasetGetInvoiceExtendedItemsByInvoiceId(requestContext,datasetGetInvoiceExtendedItemsByInvoiceId_maxRecords,datasetGetInvoiceExtendedItemsByInvoiceId_startIndex,IterationMultiplicity.Single,localVars.inParamInvoiceId,cancellationToken);

// Foreach GetInvoiceExtendedItemsByInvoiceId.List
localVars.queryResGetInvoiceExtendedItemsByInvoiceId_outParamList.StartIteration();
try {while (!((localVars.queryResGetInvoiceExtendedItemsByInvoiceId_outParamList.Eof))) {
// Query datasetGetInvoiceExtendedItemTaxsByInvoiceExtendedItemId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceExtendedItemTaxsByInvoiceExtendedItemId_maxRecords = 0;
int datasetGetInvoiceExtendedItemTaxsByInvoiceExtendedItemId_startIndex = 0;(localVars.queryResGetInvoiceExtendedItemTaxsByInvoiceExtendedItemId_outParamList,localVars.queryResGetInvoiceExtendedItemTaxsByInvoiceExtendedItemId_outParamCount) = await FuncActionDeleteInvoiceTablesById.datasetGetInvoiceExtendedItemTaxsByInvoiceExtendedItemId(requestContext,datasetGetInvoiceExtendedItemTaxsByInvoiceExtendedItemId_maxRecords,datasetGetInvoiceExtendedItemTaxsByInvoiceExtendedItemId_startIndex,IterationMultiplicity.Single,localVars.queryResGetInvoiceExtendedItemsByInvoiceId_outParamList.CurrentRec.ssENInvoiceExtendedItem.ssId,cancellationToken);

// Foreach GetInvoiceExtendedItemTaxsByInvoiceExtendedItemId.List
localVars.queryResGetInvoiceExtendedItemTaxsByInvoiceExtendedItemId_outParamList.StartIteration();
try {while (!((localVars.queryResGetInvoiceExtendedItemTaxsByInvoiceExtendedItemId_outParamList.Eof))) {
// DeleteInvoiceExtendedItemTax
await ExtendedActions.DeleteInvoiceExtendedItemTax(requestContext,localVars.queryResGetInvoiceExtendedItemTaxsByInvoiceExtendedItemId_outParamList.CurrentRec.ssENInvoiceExtendedItemTax.ssId,cancellationToken);

localVars.queryResGetInvoiceExtendedItemTaxsByInvoiceExtendedItemId_outParamList.Advance();
}

} finally {
localVars.queryResGetInvoiceExtendedItemTaxsByInvoiceExtendedItemId_outParamList.EndIteration();
}

// DeleteInvoiceExtendedItem
await ExtendedActions.DeleteInvoiceExtendedItem(requestContext,localVars.queryResGetInvoiceExtendedItemsByInvoiceId_outParamList.CurrentRec.ssENInvoiceExtendedItem.ssId,cancellationToken);

localVars.queryResGetInvoiceExtendedItemsByInvoiceId_outParamList.Advance();
}

} finally {
localVars.queryResGetInvoiceExtendedItemsByInvoiceId_outParamList.EndIteration();
}

// Query datasetGetInvoiceExtendedMoreChargesByInvoiceId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceExtendedMoreChargesByInvoiceId_maxRecords = 0;
int datasetGetInvoiceExtendedMoreChargesByInvoiceId_startIndex = 0;(localVars.queryResGetInvoiceExtendedMoreChargesByInvoiceId_outParamList,localVars.queryResGetInvoiceExtendedMoreChargesByInvoiceId_outParamCount) = await FuncActionDeleteInvoiceTablesById.datasetGetInvoiceExtendedMoreChargesByInvoiceId(requestContext,datasetGetInvoiceExtendedMoreChargesByInvoiceId_maxRecords,datasetGetInvoiceExtendedMoreChargesByInvoiceId_startIndex,IterationMultiplicity.Single,localVars.inParamInvoiceId,cancellationToken);

// Foreach GetInvoiceExtendedMoreChargesByInvoiceId.List
localVars.queryResGetInvoiceExtendedMoreChargesByInvoiceId_outParamList.StartIteration();
try {while (!((localVars.queryResGetInvoiceExtendedMoreChargesByInvoiceId_outParamList.Eof))) {
// DeleteInvoiceExtendedMoreCharges
await ExtendedActions.DeleteInvoiceExtendedMoreCharges(requestContext,localVars.queryResGetInvoiceExtendedMoreChargesByInvoiceId_outParamList.CurrentRec.ssENInvoiceExtendedMoreCharges.ssId,cancellationToken);

localVars.queryResGetInvoiceExtendedMoreChargesByInvoiceId_outParamList.Advance();
}

} finally {
localVars.queryResGetInvoiceExtendedMoreChargesByInvoiceId_outParamList.EndIteration();
}

// DeleteInvoiceExtendedCartaPorte
await ExtendedActions.DeleteInvoiceExtendedCartaPorte(requestContext,localVars.inParamInvoiceId,cancellationToken);

// Query datasetGetInvoiceExtendedRelationsByInvoiceId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceExtendedRelationsByInvoiceId_maxRecords = 0;
int datasetGetInvoiceExtendedRelationsByInvoiceId_startIndex = 0;(localVars.queryResGetInvoiceExtendedRelationsByInvoiceId_outParamList,localVars.queryResGetInvoiceExtendedRelationsByInvoiceId_outParamCount) = await FuncActionDeleteInvoiceTablesById.datasetGetInvoiceExtendedRelationsByInvoiceId(requestContext,datasetGetInvoiceExtendedRelationsByInvoiceId_maxRecords,datasetGetInvoiceExtendedRelationsByInvoiceId_startIndex,IterationMultiplicity.Single,localVars.inParamInvoiceId,cancellationToken);

// Foreach GetInvoiceExtendedRelationsByInvoiceId.List
localVars.queryResGetInvoiceExtendedRelationsByInvoiceId_outParamList.StartIteration();
try {while (!((localVars.queryResGetInvoiceExtendedRelationsByInvoiceId_outParamList.Eof))) {
// DeleteInvoiceExtendedRelations
await ExtendedActions.DeleteInvoiceExtendedRelations(requestContext,localVars.queryResGetInvoiceExtendedRelationsByInvoiceId_outParamList.CurrentRec.ssENInvoiceExtendedRelations.ssId,cancellationToken);

localVars.queryResGetInvoiceExtendedRelationsByInvoiceId_outParamList.Advance();
}

} finally {
localVars.queryResGetInvoiceExtendedRelationsByInvoiceId_outParamList.EndIteration();
}

// DeleteInvoiceExtendedSelloDigital
await ExtendedActions.DeleteInvoiceExtendedSelloDigital(requestContext,localVars.inParamInvoiceId,cancellationToken);

// DeleteInvoiceExtendedReceiver
await ExtendedActions.DeleteInvoiceExtendedReceiver(requestContext,localVars.inParamInvoiceId,cancellationToken);

// DeleteInvoiceExtendedIssuer
await ExtendedActions.DeleteInvoiceExtendedIssuer(requestContext,localVars.inParamInvoiceId,cancellationToken);

// Query datasetGetInvoiceExtendedTaxsByInvoiceId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceExtendedTaxsByInvoiceId_maxRecords = 0;
int datasetGetInvoiceExtendedTaxsByInvoiceId_startIndex = 0;(localVars.queryResGetInvoiceExtendedTaxsByInvoiceId_outParamList,localVars.queryResGetInvoiceExtendedTaxsByInvoiceId_outParamCount) = await FuncActionDeleteInvoiceTablesById.datasetGetInvoiceExtendedTaxsByInvoiceId(requestContext,datasetGetInvoiceExtendedTaxsByInvoiceId_maxRecords,datasetGetInvoiceExtendedTaxsByInvoiceId_startIndex,IterationMultiplicity.Single,localVars.inParamInvoiceId,cancellationToken);

// Foreach GetInvoiceExtendedTaxsByInvoiceId.List
localVars.queryResGetInvoiceExtendedTaxsByInvoiceId_outParamList.StartIteration();
try {while (!((localVars.queryResGetInvoiceExtendedTaxsByInvoiceId_outParamList.Eof))) {
// DeleteInvoiceExtendedTax
await ExtendedActions.DeleteInvoiceExtendedTax(requestContext,localVars.queryResGetInvoiceExtendedTaxsByInvoiceId_outParamList.CurrentRec.ssENInvoiceExtendedTax.ssId,cancellationToken);

localVars.queryResGetInvoiceExtendedTaxsByInvoiceId_outParamList.Advance();
}

} finally {
localVars.queryResGetInvoiceExtendedTaxsByInvoiceId_outParamList.EndIteration();
}

// DeleteInvoiceExtended
await ExtendedActions.DeleteInvoiceExtended(requestContext,localVars.inParamInvoiceId,cancellationToken);

// Query datasetGetInvoiceCommentsByInvoiceId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceCommentsByInvoiceId_maxRecords = 0;
int datasetGetInvoiceCommentsByInvoiceId_startIndex = 0;(localVars.queryResGetInvoiceCommentsByInvoiceId_outParamList,localVars.queryResGetInvoiceCommentsByInvoiceId_outParamCount) = await FuncActionDeleteInvoiceTablesById.datasetGetInvoiceCommentsByInvoiceId(requestContext,datasetGetInvoiceCommentsByInvoiceId_maxRecords,datasetGetInvoiceCommentsByInvoiceId_startIndex,IterationMultiplicity.Single,localVars.inParamInvoiceId,cancellationToken);

// Foreach GetInvoiceCommentsByInvoiceId.List
localVars.queryResGetInvoiceCommentsByInvoiceId_outParamList.StartIteration();
try {while (!((localVars.queryResGetInvoiceCommentsByInvoiceId_outParamList.Eof))) {
// DeleteInvoiceComment
await ExtendedActions.DeleteInvoiceComment(requestContext,localVars.queryResGetInvoiceCommentsByInvoiceId_outParamList.CurrentRec.ssENInvoiceComment.ssId,cancellationToken);

localVars.queryResGetInvoiceCommentsByInvoiceId_outParamList.Advance();
}

} finally {
localVars.queryResGetInvoiceCommentsByInvoiceId_outParamList.EndIteration();
}

// Query datasetGetInvoiceApprovalsByInvoiceId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceApprovalsByInvoiceId_maxRecords = 0;
int datasetGetInvoiceApprovalsByInvoiceId_startIndex = 0;(localVars.queryResGetInvoiceApprovalsByInvoiceId_outParamList,localVars.queryResGetInvoiceApprovalsByInvoiceId_outParamCount) = await FuncActionDeleteInvoiceTablesById.datasetGetInvoiceApprovalsByInvoiceId(requestContext,datasetGetInvoiceApprovalsByInvoiceId_maxRecords,datasetGetInvoiceApprovalsByInvoiceId_startIndex,IterationMultiplicity.Single,localVars.inParamInvoiceId,cancellationToken);

// Foreach GetInvoiceApprovalsByInvoiceId.List
localVars.queryResGetInvoiceApprovalsByInvoiceId_outParamList.StartIteration();
try {while (!((localVars.queryResGetInvoiceApprovalsByInvoiceId_outParamList.Eof))) {
// Query datasetGetInvoiceApprovalLevelsByInvoiceApprovalId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceApprovalLevelsByInvoiceApprovalId_maxRecords = 0;
int datasetGetInvoiceApprovalLevelsByInvoiceApprovalId_startIndex = 0;(localVars.queryResGetInvoiceApprovalLevelsByInvoiceApprovalId_outParamList,localVars.queryResGetInvoiceApprovalLevelsByInvoiceApprovalId_outParamCount) = await FuncActionDeleteInvoiceTablesById.datasetGetInvoiceApprovalLevelsByInvoiceApprovalId(requestContext,datasetGetInvoiceApprovalLevelsByInvoiceApprovalId_maxRecords,datasetGetInvoiceApprovalLevelsByInvoiceApprovalId_startIndex,IterationMultiplicity.Single,localVars.queryResGetInvoiceApprovalsByInvoiceId_outParamList.CurrentRec.ssENInvoiceApproval.ssId,cancellationToken);

// Foreach GetInvoiceApprovalLevelsByInvoiceApprovalId.List
localVars.queryResGetInvoiceApprovalLevelsByInvoiceApprovalId_outParamList.StartIteration();
try {while (!((localVars.queryResGetInvoiceApprovalLevelsByInvoiceApprovalId_outParamList.Eof))) {
// DeleteInvoiceApprovalLevel
await ExtendedActions.DeleteInvoiceApprovalLevel(requestContext,localVars.queryResGetInvoiceApprovalLevelsByInvoiceApprovalId_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssId,cancellationToken);

localVars.queryResGetInvoiceApprovalLevelsByInvoiceApprovalId_outParamList.Advance();
}

} finally {
localVars.queryResGetInvoiceApprovalLevelsByInvoiceApprovalId_outParamList.EndIteration();
}

// DeleteInvoiceApproval
await ExtendedActions.DeleteInvoiceApproval(requestContext,localVars.queryResGetInvoiceApprovalsByInvoiceId_outParamList.CurrentRec.ssENInvoiceApproval.ssId,cancellationToken);

localVars.queryResGetInvoiceApprovalsByInvoiceId_outParamList.Advance();
}

} finally {
localVars.queryResGetInvoiceApprovalsByInvoiceId_outParamList.EndIteration();
}

// Query datasetGetInvoiceAccountingsByInvoiceId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceAccountingsByInvoiceId_maxRecords = 0;
int datasetGetInvoiceAccountingsByInvoiceId_startIndex = 0;(localVars.queryResGetInvoiceAccountingsByInvoiceId_outParamList,localVars.queryResGetInvoiceAccountingsByInvoiceId_outParamCount) = await FuncActionDeleteInvoiceTablesById.datasetGetInvoiceAccountingsByInvoiceId(requestContext,datasetGetInvoiceAccountingsByInvoiceId_maxRecords,datasetGetInvoiceAccountingsByInvoiceId_startIndex,IterationMultiplicity.Single,localVars.inParamInvoiceId,cancellationToken);

// Foreach GetInvoiceAccountingsByInvoiceId.List
localVars.queryResGetInvoiceAccountingsByInvoiceId_outParamList.StartIteration();
try {while (!((localVars.queryResGetInvoiceAccountingsByInvoiceId_outParamList.Eof))) {
// Query datasetGetInvoiceAccountingCostCentersByInvoiceAccounting
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceAccountingCostCentersByInvoiceAccounting_maxRecords = 0;
int datasetGetInvoiceAccountingCostCentersByInvoiceAccounting_startIndex = 0;(localVars.queryResGetInvoiceAccountingCostCentersByInvoiceAccounting_outParamList,localVars.queryResGetInvoiceAccountingCostCentersByInvoiceAccounting_outParamCount) = await FuncActionDeleteInvoiceTablesById.datasetGetInvoiceAccountingCostCentersByInvoiceAccounting(requestContext,datasetGetInvoiceAccountingCostCentersByInvoiceAccounting_maxRecords,datasetGetInvoiceAccountingCostCentersByInvoiceAccounting_startIndex,IterationMultiplicity.Single,localVars.queryResGetInvoiceAccountingsByInvoiceId_outParamList.CurrentRec.ssENInvoiceAccounting.ssId,cancellationToken);

// Foreach GetInvoiceAccountingCostCentersByInvoiceAccounting.List
localVars.queryResGetInvoiceAccountingCostCentersByInvoiceAccounting_outParamList.StartIteration();
try {while (!((localVars.queryResGetInvoiceAccountingCostCentersByInvoiceAccounting_outParamList.Eof))) {
// DeleteInvoiceAccountingServices
await ExtendedActions.DeleteInvoiceAccountingServices(requestContext,localVars.queryResGetInvoiceAccountingCostCentersByInvoiceAccounting_outParamList.CurrentRec.ssENInvoiceAccountingServices.ssId,cancellationToken);

localVars.queryResGetInvoiceAccountingCostCentersByInvoiceAccounting_outParamList.Advance();
}

} finally {
localVars.queryResGetInvoiceAccountingCostCentersByInvoiceAccounting_outParamList.EndIteration();
}

// DeleteInvoiceAccounting
await ExtendedActions.DeleteInvoiceAccounting(requestContext,localVars.queryResGetInvoiceAccountingsByInvoiceId_outParamList.CurrentRec.ssENInvoiceAccounting.ssId,cancellationToken);

localVars.queryResGetInvoiceAccountingsByInvoiceId_outParamList.Advance();
}

} finally {
localVars.queryResGetInvoiceAccountingsByInvoiceId_outParamList.EndIteration();
}

// Query datasetGetInvoiceFilesByInvoiceId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceFilesByInvoiceId_maxRecords = 0;
int datasetGetInvoiceFilesByInvoiceId_startIndex = 0;(localVars.queryResGetInvoiceFilesByInvoiceId_outParamList,localVars.queryResGetInvoiceFilesByInvoiceId_outParamCount) = await FuncActionDeleteInvoiceTablesById.datasetGetInvoiceFilesByInvoiceId(requestContext,datasetGetInvoiceFilesByInvoiceId_maxRecords,datasetGetInvoiceFilesByInvoiceId_startIndex,IterationMultiplicity.Single,localVars.inParamInvoiceId,cancellationToken);

// Foreach GetInvoiceFilesByInvoiceId.List
localVars.queryResGetInvoiceFilesByInvoiceId_outParamList.StartIteration();
try {while (!((localVars.queryResGetInvoiceFilesByInvoiceId_outParamList.Eof))) {
// DeleteInvoiceFile
await ExtendedActions.DeleteInvoiceFile(requestContext,localVars.queryResGetInvoiceFilesByInvoiceId_outParamList.CurrentRec.ssENInvoiceFile.ssId,cancellationToken);

// ServiceStorageDelete
await ServiceAPIs.ServiceAPIServiceStorageDelete(requestContext,localVars.queryResGetInvoiceFilesByInvoiceId_outParamList.CurrentRec.ssENInvoiceFile.ssStorageId,cancellationToken);

localVars.queryResGetInvoiceFilesByInvoiceId_outParamList.Advance();
}

} finally {
localVars.queryResGetInvoiceFilesByInvoiceId_outParamList.EndIteration();
}

// Query datasetGetInvoiceLogsByInvoiceId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceLogsByInvoiceId_maxRecords = 0;
int datasetGetInvoiceLogsByInvoiceId_startIndex = 0;(localVars.queryResGetInvoiceLogsByInvoiceId_outParamList,localVars.queryResGetInvoiceLogsByInvoiceId_outParamCount) = await FuncActionDeleteInvoiceTablesById.datasetGetInvoiceLogsByInvoiceId(requestContext,datasetGetInvoiceLogsByInvoiceId_maxRecords,datasetGetInvoiceLogsByInvoiceId_startIndex,IterationMultiplicity.Single,localVars.inParamInvoiceId,cancellationToken);

// Foreach GetInvoiceLogsByInvoiceId.List
localVars.queryResGetInvoiceLogsByInvoiceId_outParamList.StartIteration();
try {while (!((localVars.queryResGetInvoiceLogsByInvoiceId_outParamList.Eof))) {
// DeleteInvoiceLog
await ExtendedActions.DeleteInvoiceLog(requestContext,localVars.queryResGetInvoiceLogsByInvoiceId_outParamList.CurrentRec.ssENInvoiceLog.ssId,cancellationToken);

localVars.queryResGetInvoiceLogsByInvoiceId_outParamList.Advance();
}

} finally {
localVars.queryResGetInvoiceLogsByInvoiceId_outParamList.EndIteration();
}

// Query datasetGetInvoiceStatusHistoriesByInvoiceId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceStatusHistoriesByInvoiceId_maxRecords = 0;
int datasetGetInvoiceStatusHistoriesByInvoiceId_startIndex = 0;(localVars.queryResGetInvoiceStatusHistoriesByInvoiceId_outParamList,localVars.queryResGetInvoiceStatusHistoriesByInvoiceId_outParamCount) = await FuncActionDeleteInvoiceTablesById.datasetGetInvoiceStatusHistoriesByInvoiceId(requestContext,datasetGetInvoiceStatusHistoriesByInvoiceId_maxRecords,datasetGetInvoiceStatusHistoriesByInvoiceId_startIndex,IterationMultiplicity.Single,localVars.inParamInvoiceId,cancellationToken);

// Foreach GetInvoiceStatusHistoriesByInvoiceId.List
localVars.queryResGetInvoiceStatusHistoriesByInvoiceId_outParamList.StartIteration();
try {while (!((localVars.queryResGetInvoiceStatusHistoriesByInvoiceId_outParamList.Eof))) {
// DeleteInvoiceStatusHistory
await ExtendedActions.DeleteInvoiceStatusHistory(requestContext,localVars.queryResGetInvoiceStatusHistoriesByInvoiceId_outParamList.CurrentRec.ssENInvoiceStatusHistory.ssId,cancellationToken);

localVars.queryResGetInvoiceStatusHistoriesByInvoiceId_outParamList.Advance();
}

} finally {
localVars.queryResGetInvoiceStatusHistoriesByInvoiceId_outParamList.EndIteration();
}

// DeleteInvoice
await ExtendedActions.DeleteInvoice(requestContext,localVars.inParamInvoiceId,cancellationToken);

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionDeleteInvoiceTablesById {

// Query Function "GetInvoiceCommentsByInvoiceId" nipMEAJdvEyifam_cOCUtg of Action "DeleteInvoiceTablesById"
public static async Task<(RL_2e7f130f9df070446bc2a9ac7dcde539,long)> datasetGetInvoiceCommentsByInvoiceId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("DeleteInvoiceTablesById.GetInvoiceCommentsByInvoiceId", "104c2a9e-5d02-4cbc-a27d-a9bf70e094b6");
using var queryActivity = activitySource.CreateAggregateQueryActivity("DeleteInvoiceTablesById.GetInvoiceCommentsByInvoiceId", "104c2a9e-5d02-4cbc-a27d-a9bf70e094b6", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.gtigyYqc7kCVg_jVckqoBg/NodesNotShownInESpaceTree.nipMEAJdvEyifam_cOCUtg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoicecomment\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7");
fromBuilder.Append(" FROM {InvoiceComment} \"eninvoicecomment\"");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceId != 0) {
whereBuilder.Append("((\"eninvoicecomment\".\"invoiceid\" = @qpinInvoiceId) AND (\"eninvoicecomment\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceId", DbType.Int64, qpinInvoiceId);
} else {
whereBuilder.Append("(\"eninvoicecomment\".\"invoiceid\" IS NULL)");
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
RL_2e7f130f9df070446bc2a9ac7dcde539 outParamList = new RL_2e7f130f9df070446bc2a9ac7dcde539();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query DeleteInvoiceTablesById.GetInvoiceCommentsByInvoiceId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_2e7f130f9df070446bc2a9ac7dcde539 _tmp = new RL_2e7f130f9df070446bc2a9ac7dcde539();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query DeleteInvoiceTablesById.GetInvoiceCommentsByInvoiceId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_2e7f130f9df070446bc2a9ac7dcde539)_tmp;
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

// Query Function "GetInvoiceStatusHistoriesByInvoiceId" CJrlHwIxm0GZr_mqVMGC6g of Action "DeleteInvoiceTablesById"
public static async Task<(RL_61b7015322a190028a6e9742f654db41,long)> datasetGetInvoiceStatusHistoriesByInvoiceId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("DeleteInvoiceTablesById.GetInvoiceStatusHistoriesByInvoiceId", "1fe59a08-3102-419b-99af-f9aa54c182ea");
using var queryActivity = activitySource.CreateAggregateQueryActivity("DeleteInvoiceTablesById.GetInvoiceStatusHistoriesByInvoiceId", "1fe59a08-3102-419b-99af-f9aa54c182ea", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.gtigyYqc7kCVg_jVckqoBg/NodesNotShownInESpaceTree.CJrlHwIxm0GZr_mqVMGC6g, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoicestatushistory\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4");
fromBuilder.Append(" FROM {InvoiceStatusHistory} \"eninvoicestatushistory\"");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceId != 0) {
whereBuilder.Append("((\"eninvoicestatushistory\".\"invoiceid\" = @qpinInvoiceId) AND (\"eninvoicestatushistory\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceId", DbType.Int64, qpinInvoiceId);
} else {
whereBuilder.Append("(\"eninvoicestatushistory\".\"invoiceid\" IS NULL)");
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
RL_61b7015322a190028a6e9742f654db41 outParamList = new RL_61b7015322a190028a6e9742f654db41();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query DeleteInvoiceTablesById.GetInvoiceStatusHistoriesByInvoiceId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_61b7015322a190028a6e9742f654db41 _tmp = new RL_61b7015322a190028a6e9742f654db41();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query DeleteInvoiceTablesById.GetInvoiceStatusHistoriesByInvoiceId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_61b7015322a190028a6e9742f654db41)_tmp;
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

// Query Function "GetInvoiceLogsByInvoiceId" 0cLrI7166U2ubZqswmA5cw of Action "DeleteInvoiceTablesById"
public static async Task<(RL_741430f005c8952521bfb8de73240573,long)> datasetGetInvoiceLogsByInvoiceId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("DeleteInvoiceTablesById.GetInvoiceLogsByInvoiceId", "23ebc2d1-7abd-4de9-ae6d-9aacc2603973");
using var queryActivity = activitySource.CreateAggregateQueryActivity("DeleteInvoiceTablesById.GetInvoiceLogsByInvoiceId", "23ebc2d1-7abd-4de9-ae6d-9aacc2603973", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.gtigyYqc7kCVg_jVckqoBg/NodesNotShownInESpaceTree.0cLrI7166U2ubZqswmA5cw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoicelog1\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5");
fromBuilder.Append(" FROM {InvoiceLog} \"eninvoicelog1\"");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceId != 0) {
whereBuilder.Append("((\"eninvoicelog1\".\"invoiceid\" = @qpinInvoiceId) AND (\"eninvoicelog1\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceId", DbType.Int64, qpinInvoiceId);
} else {
whereBuilder.Append("(\"eninvoicelog1\".\"invoiceid\" IS NULL)");
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
RL_741430f005c8952521bfb8de73240573 outParamList = new RL_741430f005c8952521bfb8de73240573();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query DeleteInvoiceTablesById.GetInvoiceLogsByInvoiceId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_741430f005c8952521bfb8de73240573 _tmp = new RL_741430f005c8952521bfb8de73240573();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query DeleteInvoiceTablesById.GetInvoiceLogsByInvoiceId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_741430f005c8952521bfb8de73240573)_tmp;
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

// Query Function "GetInvoiceApprovalsByInvoiceId" BsgAPqxtfki_dZKOmVeIVQ of Action "DeleteInvoiceTablesById"
public static async Task<(RL_b496b6dad8a76ef02aafdb1cf78f19ec,long)> datasetGetInvoiceApprovalsByInvoiceId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("DeleteInvoiceTablesById.GetInvoiceApprovalsByInvoiceId", "3e00c806-6dac-487e-bf75-928e99578855");
using var queryActivity = activitySource.CreateAggregateQueryActivity("DeleteInvoiceTablesById.GetInvoiceApprovalsByInvoiceId", "3e00c806-6dac-487e-bf75-928e99578855", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.gtigyYqc7kCVg_jVckqoBg/NodesNotShownInESpaceTree.BsgAPqxtfki_dZKOmVeIVQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoiceapproval18\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9");
fromBuilder.Append(" FROM {InvoiceApproval} \"eninvoiceapproval18\"");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceId != 0) {
whereBuilder.Append("((\"eninvoiceapproval18\".\"invoiceid\" = @qpinInvoiceId) AND (\"eninvoiceapproval18\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceId", DbType.Int64, qpinInvoiceId);
} else {
whereBuilder.Append("(\"eninvoiceapproval18\".\"invoiceid\" IS NULL)");
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
RL_b496b6dad8a76ef02aafdb1cf78f19ec outParamList = new RL_b496b6dad8a76ef02aafdb1cf78f19ec();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query DeleteInvoiceTablesById.GetInvoiceApprovalsByInvoiceId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_b496b6dad8a76ef02aafdb1cf78f19ec _tmp = new RL_b496b6dad8a76ef02aafdb1cf78f19ec();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query DeleteInvoiceTablesById.GetInvoiceApprovalsByInvoiceId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_b496b6dad8a76ef02aafdb1cf78f19ec)_tmp;
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

// Query Function "GetInvoiceExtendedItemTaxsByInvoiceExtendedItemId" oO9mYF26MU+HrHALLV3sug of Action "DeleteInvoiceTablesById"
public static async Task<(RL_5b975f6376260cc87a4dc39e570700ae,long)> datasetGetInvoiceExtendedItemTaxsByInvoiceExtendedItemId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceExtendedItemId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("DeleteInvoiceTablesById.GetInvoiceExtendedItemTaxsByInvoiceExtendedItemId", "6066efa0-ba5d-4f31-87ac-700b2d5decba");
using var queryActivity = activitySource.CreateAggregateQueryActivity("DeleteInvoiceTablesById.GetInvoiceExtendedItemTaxsByInvoiceExtendedItemId", "6066efa0-ba5d-4f31-87ac-700b2d5decba", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.gtigyYqc7kCVg_jVckqoBg/NodesNotShownInESpaceTree.oO9mYF26MU+HrHALLV3sug, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoiceextendeditemtax4\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7");
fromBuilder.Append(" FROM {InvoiceExtendedItemTax} \"eninvoiceextendeditemtax4\"");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceExtendedItemId != 0) {
whereBuilder.Append("((\"eninvoiceextendeditemtax4\".\"invoiceextendeditemid\" = @qpinInvoiceExtendedItemId) AND (\"eninvoiceextendeditemtax4\".\"invoiceextendeditemid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceExtendedItemId", DbType.Int64, qpinInvoiceExtendedItemId);
} else {
whereBuilder.Append("(\"eninvoiceextendeditemtax4\".\"invoiceextendeditemid\" IS NULL)");
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
RL_5b975f6376260cc87a4dc39e570700ae outParamList = new RL_5b975f6376260cc87a4dc39e570700ae();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query DeleteInvoiceTablesById.GetInvoiceExtendedItemTaxsByInvoiceExtendedItemId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_5b975f6376260cc87a4dc39e570700ae _tmp = new RL_5b975f6376260cc87a4dc39e570700ae();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query DeleteInvoiceTablesById.GetInvoiceExtendedItemTaxsByInvoiceExtendedItemId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_5b975f6376260cc87a4dc39e570700ae)_tmp;
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

// Query Function "GetInvoiceFilesByInvoiceId" h06jZGQWmku6eyNs6MbcFQ of Action "DeleteInvoiceTablesById"
public static async Task<(RL_00a03f803f0d49826089181417370afb,long)> datasetGetInvoiceFilesByInvoiceId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("DeleteInvoiceTablesById.GetInvoiceFilesByInvoiceId", "64a34e87-1664-4b9a-ba7b-236ce8c6dc15");
using var queryActivity = activitySource.CreateAggregateQueryActivity("DeleteInvoiceTablesById.GetInvoiceFilesByInvoiceId", "64a34e87-1664-4b9a-ba7b-236ce8c6dc15", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.gtigyYqc7kCVg_jVckqoBg/NodesNotShownInESpaceTree.h06jZGQWmku6eyNs6MbcFQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoicefile21\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, \"eninvoicefile21\".\"storageid\" o5, NULL o6, NULL o7");
fromBuilder.Append(" FROM {InvoiceFile} \"eninvoicefile21\"");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceId != 0) {
whereBuilder.Append("((\"eninvoicefile21\".\"invoiceid\" = @qpinInvoiceId) AND (\"eninvoicefile21\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceId", DbType.Int64, qpinInvoiceId);
} else {
whereBuilder.Append("(\"eninvoicefile21\".\"invoiceid\" IS NULL)");
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
RL_00a03f803f0d49826089181417370afb outParamList = new RL_00a03f803f0d49826089181417370afb();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, false, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query DeleteInvoiceTablesById.GetInvoiceFilesByInvoiceId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_00a03f803f0d49826089181417370afb _tmp = new RL_00a03f803f0d49826089181417370afb();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query DeleteInvoiceTablesById.GetInvoiceFilesByInvoiceId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_00a03f803f0d49826089181417370afb)_tmp;
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

// Query Function "GetInvoiceAccountingsByInvoiceId" gxHIh7zAXUiEcmHutjpobA of Action "DeleteInvoiceTablesById"
public static async Task<(RL_ccf70f600f06def33a14ca10a1120a68,long)> datasetGetInvoiceAccountingsByInvoiceId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("DeleteInvoiceTablesById.GetInvoiceAccountingsByInvoiceId", "87c81183-c0bc-485d-8472-61eeb63a686c");
using var queryActivity = activitySource.CreateAggregateQueryActivity("DeleteInvoiceTablesById.GetInvoiceAccountingsByInvoiceId", "87c81183-c0bc-485d-8472-61eeb63a686c", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.gtigyYqc7kCVg_jVckqoBg/NodesNotShownInESpaceTree.gxHIh7zAXUiEcmHutjpobA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoiceaccounting14\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20");
fromBuilder.Append(" FROM {InvoiceAccounting} \"eninvoiceaccounting14\"");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceId != 0) {
whereBuilder.Append("((\"eninvoiceaccounting14\".\"invoiceid\" = @qpinInvoiceId) AND (\"eninvoiceaccounting14\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceId", DbType.Int64, qpinInvoiceId);
} else {
whereBuilder.Append("(\"eninvoiceaccounting14\".\"invoiceid\" IS NULL)");
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
RL_ccf70f600f06def33a14ca10a1120a68 outParamList = new RL_ccf70f600f06def33a14ca10a1120a68();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query DeleteInvoiceTablesById.GetInvoiceAccountingsByInvoiceId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_ccf70f600f06def33a14ca10a1120a68 _tmp = new RL_ccf70f600f06def33a14ca10a1120a68();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query DeleteInvoiceTablesById.GetInvoiceAccountingsByInvoiceId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_ccf70f600f06def33a14ca10a1120a68)_tmp;
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

// Query Function "GetInvoiceExtendedTaxsByInvoiceId" sXm8jnuzvka6fZXBur1X6A of Action "DeleteInvoiceTablesById"
public static async Task<(RL_9404dc36b913809894c7e4e44e8e1dd8,long)> datasetGetInvoiceExtendedTaxsByInvoiceId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("DeleteInvoiceTablesById.GetInvoiceExtendedTaxsByInvoiceId", "8ebc79b1-b37b-46be-ba7d-95c1babd57e8");
using var queryActivity = activitySource.CreateAggregateQueryActivity("DeleteInvoiceTablesById.GetInvoiceExtendedTaxsByInvoiceId", "8ebc79b1-b37b-46be-ba7d-95c1babd57e8", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.gtigyYqc7kCVg_jVckqoBg/NodesNotShownInESpaceTree.sXm8jnuzvka6fZXBur1X6A, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoiceextendedtax6\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7");
fromBuilder.Append(" FROM {InvoiceExtendedTax} \"eninvoiceextendedtax6\"");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceId != 0) {
whereBuilder.Append("((\"eninvoiceextendedtax6\".\"invoiceid\" = @qpinInvoiceId) AND (\"eninvoiceextendedtax6\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceId", DbType.Int64, qpinInvoiceId);
} else {
whereBuilder.Append("(\"eninvoiceextendedtax6\".\"invoiceid\" IS NULL)");
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
RL_9404dc36b913809894c7e4e44e8e1dd8 outParamList = new RL_9404dc36b913809894c7e4e44e8e1dd8();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query DeleteInvoiceTablesById.GetInvoiceExtendedTaxsByInvoiceId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_9404dc36b913809894c7e4e44e8e1dd8 _tmp = new RL_9404dc36b913809894c7e4e44e8e1dd8();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query DeleteInvoiceTablesById.GetInvoiceExtendedTaxsByInvoiceId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_9404dc36b913809894c7e4e44e8e1dd8)_tmp;
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

// Query Function "GetInvoiceExtendedMoreChargesByInvoiceId" cfcSmzMyukqtlId_28+Mjw of Action "DeleteInvoiceTablesById"
public static async Task<(RL_ef088826c46241557fb82e7c7f21d334,long)> datasetGetInvoiceExtendedMoreChargesByInvoiceId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("DeleteInvoiceTablesById.GetInvoiceExtendedMoreChargesByInvoiceId", "9b12f771-3233-4aba-ad94-877fdbcf8c8f");
using var queryActivity = activitySource.CreateAggregateQueryActivity("DeleteInvoiceTablesById.GetInvoiceExtendedMoreChargesByInvoiceId", "9b12f771-3233-4aba-ad94-877fdbcf8c8f", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.gtigyYqc7kCVg_jVckqoBg/NodesNotShownInESpaceTree.cfcSmzMyukqtlId_28+Mjw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoiceextendedmorecharges3\".\"id\" o0, NULL o1, NULL o2, NULL o3");
fromBuilder.Append(" FROM {InvoiceExtendedMoreCharges} \"eninvoiceextendedmorecharges3\"");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceId != 0) {
whereBuilder.Append("((\"eninvoiceextendedmorecharges3\".\"invoiceid\" = @qpinInvoiceId) AND (\"eninvoiceextendedmorecharges3\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceId", DbType.Int64, qpinInvoiceId);
} else {
whereBuilder.Append("(\"eninvoiceextendedmorecharges3\".\"invoiceid\" IS NULL)");
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
RL_ef088826c46241557fb82e7c7f21d334 outParamList = new RL_ef088826c46241557fb82e7c7f21d334();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query DeleteInvoiceTablesById.GetInvoiceExtendedMoreChargesByInvoiceId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_ef088826c46241557fb82e7c7f21d334 _tmp = new RL_ef088826c46241557fb82e7c7f21d334();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query DeleteInvoiceTablesById.GetInvoiceExtendedMoreChargesByInvoiceId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_ef088826c46241557fb82e7c7f21d334)_tmp;
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

// Query Function "GetInvoiceApprovalLevelsByInvoiceApprovalId" 5G3D1NG8NkK3DkvshCoV3Q of Action "DeleteInvoiceTablesById"
public static async Task<(RL_b2132c93db5fd1f839353b7412eed8f5,long)> datasetGetInvoiceApprovalLevelsByInvoiceApprovalId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceApprovalId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("DeleteInvoiceTablesById.GetInvoiceApprovalLevelsByInvoiceApprovalId", "d4c36de4-bcd1-4236-b70e-4bec842a15dd");
using var queryActivity = activitySource.CreateAggregateQueryActivity("DeleteInvoiceTablesById.GetInvoiceApprovalLevelsByInvoiceApprovalId", "d4c36de4-bcd1-4236-b70e-4bec842a15dd", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.gtigyYqc7kCVg_jVckqoBg/NodesNotShownInESpaceTree.5G3D1NG8NkK3DkvshCoV3Q, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoiceapprovallevel19\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24");
fromBuilder.Append(" FROM {InvoiceApprovalLevel} \"eninvoiceapprovallevel19\"");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceApprovalId != 0) {
whereBuilder.Append("((\"eninvoiceapprovallevel19\".\"invoiceapprovalid\" = @qpinInvoiceApprovalId) AND (\"eninvoiceapprovallevel19\".\"invoiceapprovalid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceApprovalId", DbType.Int64, qpinInvoiceApprovalId);
} else {
whereBuilder.Append("(\"eninvoiceapprovallevel19\".\"invoiceapprovalid\" IS NULL)");
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
RL_b2132c93db5fd1f839353b7412eed8f5 outParamList = new RL_b2132c93db5fd1f839353b7412eed8f5();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query DeleteInvoiceTablesById.GetInvoiceApprovalLevelsByInvoiceApprovalId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_b2132c93db5fd1f839353b7412eed8f5 _tmp = new RL_b2132c93db5fd1f839353b7412eed8f5();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query DeleteInvoiceTablesById.GetInvoiceApprovalLevelsByInvoiceApprovalId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_b2132c93db5fd1f839353b7412eed8f5)_tmp;
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

// Query Function "GetInvoiceAccountingCostCentersByInvoiceAccounting" iUdC3tX9okuU3KVe2DmcWA of Action "DeleteInvoiceTablesById"
public static async Task<(RL_ce67f504f77874aaecc91ad036f8a95a,long)> datasetGetInvoiceAccountingCostCentersByInvoiceAccounting(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceAccountingId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("DeleteInvoiceTablesById.GetInvoiceAccountingCostCentersByInvoiceAccounting", "de424789-fdd5-4ba2-94dc-a55ed8399c58");
using var queryActivity = activitySource.CreateAggregateQueryActivity("DeleteInvoiceTablesById.GetInvoiceAccountingCostCentersByInvoiceAccounting", "de424789-fdd5-4ba2-94dc-a55ed8399c58", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.gtigyYqc7kCVg_jVckqoBg/NodesNotShownInESpaceTree.iUdC3tX9okuU3KVe2DmcWA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoiceaccountingservices3\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13");
fromBuilder.Append(" FROM {InvoiceAccountingServices} \"eninvoiceaccountingservices3\"");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceAccountingId != 0) {
whereBuilder.Append("((\"eninvoiceaccountingservices3\".\"invoiceaccountingid\" = @qpinInvoiceAccountingId) AND (\"eninvoiceaccountingservices3\".\"invoiceaccountingid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceAccountingId", DbType.Int64, qpinInvoiceAccountingId);
} else {
whereBuilder.Append("(\"eninvoiceaccountingservices3\".\"invoiceaccountingid\" IS NULL)");
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
RL_ce67f504f77874aaecc91ad036f8a95a outParamList = new RL_ce67f504f77874aaecc91ad036f8a95a();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query DeleteInvoiceTablesById.GetInvoiceAccountingCostCentersByInvoiceAccounting.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_ce67f504f77874aaecc91ad036f8a95a _tmp = new RL_ce67f504f77874aaecc91ad036f8a95a();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query DeleteInvoiceTablesById.GetInvoiceAccountingCostCentersByInvoiceAccounting.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_ce67f504f77874aaecc91ad036f8a95a)_tmp;
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

// Query Function "GetInvoiceExtendedRelationsByInvoiceId" AmHX7Gz_NEalptKY2iSX7A of Action "DeleteInvoiceTablesById"
public static async Task<(RL_d07e089b14ae41d13cfd90c5313de016,long)> datasetGetInvoiceExtendedRelationsByInvoiceId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("DeleteInvoiceTablesById.GetInvoiceExtendedRelationsByInvoiceId", "ecd76102-ff6c-4634-a5a6-d298da2497ec");
using var queryActivity = activitySource.CreateAggregateQueryActivity("DeleteInvoiceTablesById.GetInvoiceExtendedRelationsByInvoiceId", "ecd76102-ff6c-4634-a5a6-d298da2497ec", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.gtigyYqc7kCVg_jVckqoBg/NodesNotShownInESpaceTree.AmHX7Gz_NEalptKY2iSX7A, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoiceextendedrelations1\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4");
fromBuilder.Append(" FROM {InvoiceExtendedRelations} \"eninvoiceextendedrelations1\"");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceId != 0) {
whereBuilder.Append("((\"eninvoiceextendedrelations1\".\"invoiceid\" = @qpinInvoiceId) AND (\"eninvoiceextendedrelations1\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceId", DbType.Int64, qpinInvoiceId);
} else {
whereBuilder.Append("(\"eninvoiceextendedrelations1\".\"invoiceid\" IS NULL)");
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
RL_d07e089b14ae41d13cfd90c5313de016 outParamList = new RL_d07e089b14ae41d13cfd90c5313de016();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query DeleteInvoiceTablesById.GetInvoiceExtendedRelationsByInvoiceId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_d07e089b14ae41d13cfd90c5313de016 _tmp = new RL_d07e089b14ae41d13cfd90c5313de016();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query DeleteInvoiceTablesById.GetInvoiceExtendedRelationsByInvoiceId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_d07e089b14ae41d13cfd90c5313de016)_tmp;
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

// Query Function "GetInvoiceExtendedItemsByInvoiceId" 6KM87gsCFEGYIabqfiSskg of Action "DeleteInvoiceTablesById"
public static async Task<(RL_772f048f6ee632348101044a1e0eef2f,long)> datasetGetInvoiceExtendedItemsByInvoiceId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("DeleteInvoiceTablesById.GetInvoiceExtendedItemsByInvoiceId", "ee3ca3e8-020b-4114-9821-a6ea7e24ac92");
using var queryActivity = activitySource.CreateAggregateQueryActivity("DeleteInvoiceTablesById.GetInvoiceExtendedItemsByInvoiceId", "ee3ca3e8-020b-4114-9821-a6ea7e24ac92", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.gtigyYqc7kCVg_jVckqoBg/NodesNotShownInESpaceTree.6KM87gsCFEGYIabqfiSskg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoiceextendeditem1\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7");
fromBuilder.Append(" FROM {InvoiceExtendedItem} \"eninvoiceextendeditem1\"");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceId != 0) {
whereBuilder.Append("((\"eninvoiceextendeditem1\".\"invoiceid\" = @qpinInvoiceId) AND (\"eninvoiceextendeditem1\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceId", DbType.Int64, qpinInvoiceId);
} else {
whereBuilder.Append("(\"eninvoiceextendeditem1\".\"invoiceid\" IS NULL)");
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
RL_772f048f6ee632348101044a1e0eef2f outParamList = new RL_772f048f6ee632348101044a1e0eef2f();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query DeleteInvoiceTablesById.GetInvoiceExtendedItemsByInvoiceId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_772f048f6ee632348101044a1e0eef2f _tmp = new RL_772f048f6ee632348101044a1e0eef2f();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query DeleteInvoiceTablesById.GetInvoiceExtendedItemsByInvoiceId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_772f048f6ee632348101044a1e0eef2f)_tmp;
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
