namespace ssConectaProveedores;

public partial class Actions {
public class lcvSaveContractPendingInfo : VarsBag {
public EN_98680591dcf3728e0877a90eb5e1e552EntityRecord inParami_Requisition;
public ST_26b16bea631cbd94cf555acb5c7a4be3Structure inParami_RequisitionFileTypesStruct;
public DateTime inParami_OG_DateOfCommitment;
public RL_d5c1b2482ff109e80580d8b5fb920193 queryResGetSupplierById_outParamList = new RL_d5c1b2482ff109e80580d8b5fb920193();
public long queryResGetSupplierById_outParamCount = 0L;

public Actions.lcoRequisitionFileCreateOrUpdate resRequisitionFileCreateOrUpdate =  new Actions.lcoRequisitionFileCreateOrUpdate();
public Actions.lcoRequisitionLogAdd resRequisitionLogAdd =  new Actions.lcoRequisitionLogAdd();
public long resServiceStorageCreateOrUpdate_outParamId = 0L;

public Actions.lcoRequisitionCreateOrUpdate resRequisitionCreateOrUpdate =  new Actions.lcoRequisitionCreateOrUpdate();
public Actions.lcoRequisitionContractFileCreateOrUpdate resRequisitionContractFileCreateOrUpdate2 =  new Actions.lcoRequisitionContractFileCreateOrUpdate();
public Actions.lcoRequisitionLogAdd resRequisitionLogAdd2 =  new Actions.lcoRequisitionLogAdd();
public lcvSaveContractPendingInfo(EN_98680591dcf3728e0877a90eb5e1e552EntityRecord inParami_Requisition, ST_26b16bea631cbd94cf555acb5c7a4be3Structure inParami_RequisitionFileTypesStruct, DateTime inParami_OG_DateOfCommitment) {
this.inParami_Requisition = inParami_Requisition;
this.inParami_RequisitionFileTypesStruct = inParami_RequisitionFileTypesStruct;
this.inParami_OG_DateOfCommitment = inParami_OG_DateOfCommitment;
}
}
/// <summary>
/// Action <code>SaveContractPendingInfo</code> that represents the Service Studio action
///  <code>SaveContractPendingInfo</code> <p> Description: </p>
/// </summary>
public static async Task ActionSaveContractPendingInfo(IRequestContext requestContext,EN_98680591dcf3728e0877a90eb5e1e552EntityRecord inParami_Requisition,ST_26b16bea631cbd94cf555acb5c7a4be3Structure inParami_RequisitionFileTypesStruct,DateTime inParami_OG_DateOfCommitment,CancellationToken cancellationToken) {
lcvSaveContractPendingInfo localVars = new lcvSaveContractPendingInfo(inParami_Requisition, inParami_RequisitionFileTypesStruct, inParami_OG_DateOfCommitment);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("SaveContractPendingInfo", "bf53efa2-b5d1-47fd-8742-a14b58679029"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("SaveContractPendingInfo", "bf53efa2-b5d1-47fd-8742-a14b58679029", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
if((((!(BinaryContentUtils.AreBothBinariesNull(localVars.inParami_RequisitionFileTypesStruct.ssBinary, BuiltInFunction.NullBinary ()))&&(localVars.inParami_RequisitionFileTypesStruct.ssRequisitionFile.ssFilename!=""))&&(localVars.inParami_RequisitionFileTypesStruct.ssRequisitionContractFile.ssId==Convert.ToInt64(BuiltInFunction.NullIdentifier ()))))) {
// Query datasetGetSupplierById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetSupplierById_maxRecords = 0;
int datasetGetSupplierById_startIndex = 0;(localVars.queryResGetSupplierById_outParamList,localVars.queryResGetSupplierById_outParamCount) = await FuncActionSaveContractPendingInfo.datasetGetSupplierById(requestContext,datasetGetSupplierById_maxRecords,datasetGetSupplierById_startIndex,IterationMultiplicity.Never,localVars.inParami_Requisition.ssSupplierId,cancellationToken);

// ServiceStorageCreateOrUpdate
localVars.resServiceStorageCreateOrUpdate_outParamId = await ServiceAPIs.ServiceAPIServiceStorageCreateOrUpdate(requestContext,(await RecordUtils.ConvertAsync(localVars.inParami_RequisitionFileTypesStruct, new EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord(), async (ST_26b16bea631cbd94cf555acb5c7a4be3Structure source, EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord target, CancellationToken cancellationToken) => {
target.ssId = source.ssRequisitionFile.ssStorageId;
target.ssConcept = localVars.inParami_Requisition.ssName;
target.ssInternalConceptId = 1;
target.ssFile = source.ssBinary;
target.ssFilename = source.ssRequisitionFile.ssFilename;
target.ssVendor = localVars.queryResGetSupplierById_outParamList.CurrentRec.ssENSupplier.ssNumber;
target.ssDoc_Type = (((BuiltInFunction.IndexSC (BuiltInFunction.ToLower (source.ssRequisitionFile.ssFilename), ".pdf", 0, false, false)!=(-1))) ? (((((string)AppUtils.SiteProperties[SitePropertiesModel.spRequisitionsPDF])))) : ((((BuiltInFunction.IndexSC (BuiltInFunction.ToLower (source.ssRequisitionFile.ssFilename), ".xml", 0, false, false)!=(-1))) ? (((((string)AppUtils.SiteProperties[SitePropertiesModel.spRequisitionsXML])))) : (((((string)AppUtils.SiteProperties[SitePropertiesModel.spRequisitionsOther])))))));
target.ssObject_type = ((((string)AppUtils.SiteProperties[SitePropertiesModel.spRequisitionsTable])));
target.ssIstoSendToExternal = true;
return target;
}, cancellationToken)),false,cancellationToken);

// SetStorageId
// i_RequisitionFileTypesStruct.RequisitionFile.StorageId = ServiceStorageCreateOrUpdate.Id
localVars.inParami_RequisitionFileTypesStruct.ssRequisitionFile.ssStorageId = localVars.resServiceStorageCreateOrUpdate_outParamId;
// RequisitionFileCreateOrUpdate
localVars.resRequisitionFileCreateOrUpdate.outParamId = await Actions.ActionRequisitionFileCreateOrUpdate(requestContext,localVars.inParami_RequisitionFileTypesStruct.ssRequisitionFile,cancellationToken);

// i_RequisitionFileTypesStruct.RequisitionContractFile.RequisitionId = i_Requisition.Id
localVars.inParami_RequisitionFileTypesStruct.ssRequisitionContractFile.ssRequisitionId = localVars.inParami_Requisition.ssId;

// i_RequisitionFileTypesStruct.RequisitionContractFile.RequisitionFileId = RequisitionFileCreateOrUpdate.Id
localVars.inParami_RequisitionFileTypesStruct.ssRequisitionContractFile.ssRequisitionFileId = localVars.resRequisitionFileCreateOrUpdate.outParamId;

// i_Requisition.HasContractFileUploaded = True
localVars.inParami_Requisition.ssHasContractFileUploaded = true;
// RequisitionContractFileCreateOrUpdate2
localVars.resRequisitionContractFileCreateOrUpdate2.outParamId = await Actions.ActionRequisitionContractFileCreateOrUpdate(requestContext,localVars.inParami_RequisitionFileTypesStruct.ssRequisitionContractFile,cancellationToken);

// RequisitionLogAdd
localVars.resRequisitionLogAdd.outParamId = await Actions.ActionRequisitionLogAdd(requestContext,new EN_fca813b8ca96d6759e00225744caa7d4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssRequisitionId = localVars.inParami_Requisition.ssId, ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssMessage = AppUtils.GetStringResource("gWJbZX7asEWo70jgze4F1w#Value.1371365718.1", "Contract file has been uploaded.") },cancellationToken);

// RemoveNeedsContractApprovalLevels
await Actions.ActionRemoveNeedsContractApprovalLevels(requestContext,localVars.inParami_Requisition.ssId,cancellationToken);

} else {
// RequisitionLogAdd2
localVars.resRequisitionLogAdd2.outParamId = await Actions.ActionRequisitionLogAdd(requestContext,new EN_fca813b8ca96d6759e00225744caa7d4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssRequisitionId = localVars.inParami_Requisition.ssId, ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssMessage = (((((((AppUtils.GetStringResource("7quHg6eU+UmQGsQ32pVsDw#Value.1239729769.1", "Date of commitment has been updated from")+" ")+BuiltInFunction.FormatDateTime (localVars.inParami_OG_DateOfCommitment, "dd/MM/yyyy"))+" ")+AppUtils.GetStringResource("7quHg6eU+UmQGsQ32pVsDw#Value.3707.1", "to"))+" ")+BuiltInFunction.FormatDateTime (localVars.inParami_Requisition.ssDateOfCommitment, "dd/MM/yyyy"))+".") },cancellationToken);

}

// RequisitionCreateOrUpdate
localVars.resRequisitionCreateOrUpdate.outParamId = await Actions.ActionRequisitionCreateOrUpdate(requestContext,localVars.inParami_Requisition,cancellationToken);

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionSaveContractPendingInfo {

// Query Function "GetSupplierById" z92vLoTdzki6hz1EODwuaw of Action "SaveContractPendingInfo"
public static async Task<(RL_d5c1b2482ff109e80580d8b5fb920193,long)> datasetGetSupplierById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpsuId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("SaveContractPendingInfo.GetSupplierById", "2eafddcf-dd84-48ce-ba87-3d44383c2e6b");
using var queryActivity = activitySource.CreateAggregateQueryActivity("SaveContractPendingInfo.GetSupplierById", "2eafddcf-dd84-48ce-ba87-3d44383c2e6b", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.ou9Tv9G1_UeHQqFLWGeQKQ/NodesNotShownInESpaceTree.z92vLoTdzki6hz1EODwuaw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, \"ensupplier40\".\"number\" o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27");
fromBuilder.Append(" FROM {Supplier} \"ensupplier40\"");
whereBuilder.Append(" WHERE ");
if (qpsuId != 0) {
whereBuilder.Append("((\"ensupplier40\".\"id\" = @qpsuId) AND (\"ensupplier40\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuId", DbType.Int64, qpsuId);
} else {
whereBuilder.Append("(\"ensupplier40\".\"id\" IS NULL)");
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
opt[0] = new BitArray(new bool[] {true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query SaveContractPendingInfo.GetSupplierById.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query SaveContractPendingInfo.GetSupplierById.List", cancellationToken: cancellationToken);
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



}


}
