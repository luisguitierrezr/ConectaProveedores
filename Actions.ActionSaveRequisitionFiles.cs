namespace ssConectaProveedores;

public partial class Actions {
public class lcvSaveRequisitionFiles : VarsBag {
public long inParami_RequisitionId;
public RC_d66b0b09097e5f0bc1ec31076e9aa762 inParami_Requisition;
public long resServiceStorageCreateOrUpdateBigFile_outParamId = 0L;

public Actions.lcoRequisitionFileCreateOrUpdate resRequisitionFileCreateOrUpdate3 =  new Actions.lcoRequisitionFileCreateOrUpdate();
public int resListIndexOf_outParamPosition = 0;

public Actions.lcoRequisitionContractFileCreateOrUpdate resRequisitionContractFileCreateOrUpdate =  new Actions.lcoRequisitionContractFileCreateOrUpdate();
public RL_dcf9165e080aea63f7a9b95efcf09ef4 queryResGetRequisitionContractFile_outParamList = new RL_dcf9165e080aea63f7a9b95efcf09ef4();
public long queryResGetRequisitionContractFile_outParamCount = 0L;

public RL_c61f86b789e3e219b8eaddf345441d54 queryResGetRequisitionById_outParamList = new RL_c61f86b789e3e219b8eaddf345441d54();
public long queryResGetRequisitionById_outParamCount = 0L;

public Actions.lcoRequisitionFileCreateOrUpdate resRequisitionFileCreateOrUpdate2 =  new Actions.lcoRequisitionFileCreateOrUpdate();
public RL_dcf9165e080aea63f7a9b95efcf09ef4 queryResGetRequisitionContractFilesByRequisitionId_outParamList = new RL_dcf9165e080aea63f7a9b95efcf09ef4();
public long queryResGetRequisitionContractFilesByRequisitionId_outParamCount = 0L;

public Actions.lcoRequisitionContractFileCreateOrUpdate resRequisitionContractFileCreateOrUpdate2 =  new Actions.lcoRequisitionContractFileCreateOrUpdate();
public long resServiceStorageCreateOrUpdate_outParamId = 0L;

public lcvSaveRequisitionFiles(long inParami_RequisitionId, RC_d66b0b09097e5f0bc1ec31076e9aa762 inParami_Requisition) {
this.inParami_RequisitionId = inParami_RequisitionId;
this.inParami_Requisition = inParami_Requisition;
}
}
/// <summary>
/// Action <code>SaveRequisitionFiles</code> that represents the Service Studio action
///  <code>SaveRequisitionFiles</code> <p> Description: Action that saves a Requisition Contrac
/// t Files.</p>
/// </summary>
public static async Task ActionSaveRequisitionFiles(IRequestContext requestContext,long inParami_RequisitionId,RC_d66b0b09097e5f0bc1ec31076e9aa762 inParami_Requisition,CancellationToken cancellationToken) {
lcvSaveRequisitionFiles localVars = new lcvSaveRequisitionFiles(inParami_RequisitionId, inParami_Requisition);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("SaveRequisitionFiles", "47400ce6-35bc-4aeb-b2dc-e65e514a0971"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("SaveRequisitionFiles", "47400ce6-35bc-4aeb-b2dc-e65e514a0971", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetRequisitionContractFilesByRequisitionId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequisitionContractFilesByRequisitionId_maxRecords = 0;
int datasetGetRequisitionContractFilesByRequisitionId_startIndex = 0;(localVars.queryResGetRequisitionContractFilesByRequisitionId_outParamList,localVars.queryResGetRequisitionContractFilesByRequisitionId_outParamCount) = await FuncActionSaveRequisitionFiles.datasetGetRequisitionContractFilesByRequisitionId(requestContext,datasetGetRequisitionContractFilesByRequisitionId_maxRecords,datasetGetRequisitionContractFilesByRequisitionId_startIndex,IterationMultiplicity.Single,localVars.inParami_RequisitionId,cancellationToken);

// Foreach GetRequisitionContractFilesByRequisitionId.List
localVars.queryResGetRequisitionContractFilesByRequisitionId_outParamList.StartIteration();
try {while (!((localVars.queryResGetRequisitionContractFilesByRequisitionId_outParamList.Eof))) {
// ListIndexOf
localVars.resListIndexOf_outParamPosition = await ExtendedActions.ListIndexOf(requestContext,localVars.inParami_Requisition.ssRLAllFiles,async (p, cancellationToken) => (p.ssRequisitionContractFile.ssId==localVars.queryResGetRequisitionContractFilesByRequisitionId_outParamList.CurrentRec.ssENRequisitionContractFile.ssId),cancellationToken);

// Not Found?
if(((localVars.resListIndexOf_outParamPosition==(-1)))) {
// DeleteRequisitionContractFile
await ExtendedActions.DeleteRequisitionContractFile(requestContext,localVars.queryResGetRequisitionContractFilesByRequisitionId_outParamList.CurrentRec.ssENRequisitionContractFile.ssId,cancellationToken);

// ServiceStorageDelete
await ServiceAPIs.ServiceAPIServiceStorageDelete(requestContext,localVars.queryResGetRequisitionContractFilesByRequisitionId_outParamList.CurrentRec.ssENRequisitionFile2.ssStorageId,cancellationToken);

// DeleteRequisitionFile2
await ExtendedActions.DeleteRequisitionFile2(requestContext,localVars.queryResGetRequisitionContractFilesByRequisitionId_outParamList.CurrentRec.ssENRequisitionFile2.ssId,cancellationToken);

}

localVars.queryResGetRequisitionContractFilesByRequisitionId_outParamList.Advance();
}

} finally {
localVars.queryResGetRequisitionContractFilesByRequisitionId_outParamList.EndIteration();
}

// Query datasetGetRequisitionById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequisitionById_maxRecords = 0;
int datasetGetRequisitionById_startIndex = 0;(localVars.queryResGetRequisitionById_outParamList,localVars.queryResGetRequisitionById_outParamCount) = await FuncActionSaveRequisitionFiles.datasetGetRequisitionById(requestContext,datasetGetRequisitionById_maxRecords,datasetGetRequisitionById_startIndex,IterationMultiplicity.Never,localVars.inParami_RequisitionId,cancellationToken);

// Foreach i_Requisition.AllFiles
localVars.inParami_Requisition.ssRLAllFiles.StartIteration();
bool flagContinueTo_forEach = false;
try {while (!((localVars.inParami_Requisition.ssRLAllFiles.Eof))) {
flagContinueTo_forEach = false;
bool block2 = false;
// No binary and no StorageId?
do {
block2 = false;
// No binary and no StorageId?
do {
// No binary and no StorageId?
if((((BinaryContentUtils.AreBothBinariesNull(localVars.inParami_Requisition.ssRLAllFiles.CurrentRec.ssBinary, BuiltInFunction.NullBinary ())&&(localVars.inParami_Requisition.ssRLAllFiles.CurrentRec.ssRequisitionFile.ssStorageId==Convert.ToInt64(BuiltInFunction.NullIdentifier ())))&&(localVars.inParami_Requisition.ssRLAllFiles.CurrentRec.ssBigUploadfileId==Convert.ToInt64(BuiltInFunction.NullIdentifier ()))))) {
// Query datasetGetRequisitionContractFile
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequisitionContractFile_maxRecords = 1;
if (datasetGetRequisitionContractFile_maxRecords < 1) datasetGetRequisitionContractFile_maxRecords = 1;
int datasetGetRequisitionContractFile_startIndex = 0;(localVars.queryResGetRequisitionContractFile_outParamList,localVars.queryResGetRequisitionContractFile_outParamCount) = await FuncActionSaveRequisitionFiles.datasetGetRequisitionContractFile(requestContext,datasetGetRequisitionContractFile_maxRecords,datasetGetRequisitionContractFile_startIndex,IterationMultiplicity.Never,localVars.inParami_Requisition.ssRLAllFiles.CurrentRec.ssRequisitionContractFile.ssId,cancellationToken);

// Empty?
if((!(localVars.queryResGetRequisitionContractFile_outParamList.Empty))) {
// RequisitionFileId
// GetRequisitionContractFile.List.Current.RequisitionFile2.Filename = ""
localVars.queryResGetRequisitionContractFile_outParamList.CurrentRec.ssENRequisitionFile2.ssFilename = "";

// GetRequisitionContractFile.List.Current.RequisitionFile2.StorageId = NullIdentifier
localVars.queryResGetRequisitionContractFile_outParamList.CurrentRec.ssENRequisitionFile2.ssStorageId = Convert.ToInt64(BuiltInFunction.NullIdentifier ());

// GetRequisitionContractFile.List.Current.RequisitionFile2.VENDOR = ""
localVars.queryResGetRequisitionContractFile_outParamList.CurrentRec.ssENRequisitionFile2.ssVENDOR = "";

// GetRequisitionContractFile.List.Current.RequisitionFile2.DOC_TYPE = ""
localVars.queryResGetRequisitionContractFile_outParamList.CurrentRec.ssENRequisitionFile2.ssDOC_TYPE = "";

// GetRequisitionContractFile.List.Current.RequisitionFile2.SAP_OBJECT = ""
localVars.queryResGetRequisitionContractFile_outParamList.CurrentRec.ssENRequisitionFile2.ssSAP_OBJECT = "";
// RequisitionFileCreateOrUpdate3
localVars.resRequisitionFileCreateOrUpdate3.outParamId = await Actions.ActionRequisitionFileCreateOrUpdate(requestContext,localVars.queryResGetRequisitionContractFile_outParamList.CurrentRec.ssENRequisitionFile2,cancellationToken);

// ServiceStorageDelete2
await ServiceAPIs.ServiceAPIServiceStorageDelete(requestContext,localVars.queryResGetRequisitionContractFile_outParamList.CurrentRec.ssENRequisitionFile2.ssStorageId,cancellationToken);

}

} else {
// HaveBigFile?
if(((localVars.inParami_Requisition.ssRLAllFiles.CurrentRec.ssBigUploadfileId!=Convert.ToInt64(0)))) {
// ServiceStorageCreateOrUpdateBigFile
localVars.resServiceStorageCreateOrUpdateBigFile_outParamId = await ServiceAPIs.ServiceAPIServiceStorageCreateOrUpdateBigFile(requestContext,(await RecordUtils.ConvertAsync(localVars.inParami_Requisition.ssRLAllFiles.CurrentRec, new EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord(), async (ST_26b16bea631cbd94cf555acb5c7a4be3Structure source, EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord target, CancellationToken cancellationToken) => {
target.ssId = source.ssRequisitionFile.ssStorageId;
target.ssConcept = localVars.inParami_Requisition.ssENRequisition.ssName;
target.ssInternalConceptId = 1;
target.ssFilename = source.ssRequisitionFile.ssFilename;
target.ssVendor = localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENSupplier.ssNumber;
target.ssDoc_Type = (((BuiltInFunction.IndexSC (BuiltInFunction.ToLower (source.ssRequisitionFile.ssFilename), ".pdf", 0, false, false)!=(-1))) ? (((((string)AppUtils.SiteProperties[SitePropertiesModel.spRequisitionsPDF])))) : ((((BuiltInFunction.IndexSC (BuiltInFunction.ToLower (source.ssRequisitionFile.ssFilename), ".xml", 0, false, false)!=(-1))) ? (((((string)AppUtils.SiteProperties[SitePropertiesModel.spRequisitionsXML])))) : (((((string)AppUtils.SiteProperties[SitePropertiesModel.spRequisitionsOther])))))));
target.ssObject_type = ((((string)AppUtils.SiteProperties[SitePropertiesModel.spRequisitionsTable])));
target.ssIstoSendToExternal = true;
return target;
}, cancellationToken)),false,localVars.inParami_Requisition.ssRLAllFiles.CurrentRec.ssBigUploadfileId,cancellationToken);

// SetStorageId
// i_Requisition.AllFiles.Current.RequisitionFile.StorageId = ServiceStorageCreateOrUpdateBigFile.Id
localVars.inParami_Requisition.ssRLAllFiles.CurrentRec.ssRequisitionFile.ssStorageId = localVars.resServiceStorageCreateOrUpdateBigFile_outParamId;
break;
} else {
// File uploaded?
if((!(BinaryContentUtils.AreBothBinariesNull(localVars.inParami_Requisition.ssRLAllFiles.CurrentRec.ssBinary, BuiltInFunction.NullBinary ())))) {
// ServiceStorageCreateOrUpdate
localVars.resServiceStorageCreateOrUpdate_outParamId = await ServiceAPIs.ServiceAPIServiceStorageCreateOrUpdate(requestContext,(await RecordUtils.ConvertAsync(localVars.inParami_Requisition.ssRLAllFiles.CurrentRec, new EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord(), async (ST_26b16bea631cbd94cf555acb5c7a4be3Structure source, EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord target, CancellationToken cancellationToken) => {
target.ssId = source.ssRequisitionFile.ssStorageId;
target.ssConcept = localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition.ssName;
target.ssInternalConceptId = 1;
target.ssFile = source.ssBinary;
target.ssFilename = source.ssRequisitionFile.ssFilename;
target.ssVendor = localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENSupplier.ssNumber;
target.ssDoc_Type = (((BuiltInFunction.IndexSC (BuiltInFunction.ToLower (source.ssRequisitionFile.ssFilename), ".pdf", 0, false, false)!=(-1))) ? (((((string)AppUtils.SiteProperties[SitePropertiesModel.spRequisitionsPDF])))) : ((((BuiltInFunction.IndexSC (BuiltInFunction.ToLower (source.ssRequisitionFile.ssFilename), ".xml", 0, false, false)!=(-1))) ? (((((string)AppUtils.SiteProperties[SitePropertiesModel.spRequisitionsXML])))) : (((((string)AppUtils.SiteProperties[SitePropertiesModel.spRequisitionsOther])))))));
target.ssObject_type = ((((string)AppUtils.SiteProperties[SitePropertiesModel.spRequisitionsTable])));
target.ssIstoSendToExternal = true;
return target;
}, cancellationToken)),false,cancellationToken);

// SetStorageId
// i_Requisition.AllFiles.Current.RequisitionFile.StorageId = ServiceStorageCreateOrUpdate.Id
localVars.inParami_Requisition.ssRLAllFiles.CurrentRec.ssRequisitionFile.ssStorageId = localVars.resServiceStorageCreateOrUpdate_outParamId;
break;
}

}

}

// New ReqContractFile?
if((!((localVars.inParami_Requisition.ssRLAllFiles.CurrentRec.ssRequisitionContractFile.ssId==Convert.ToInt64(BuiltInFunction.NullIdentifier ()))))) {
// jump to block2
block2 = true;
break;
}

} while(false)
;
if(block2) {
break;
}

// RequisitionFileCreateOrUpdate2
localVars.resRequisitionFileCreateOrUpdate2.outParamId = await Actions.ActionRequisitionFileCreateOrUpdate(requestContext,localVars.inParami_Requisition.ssRLAllFiles.CurrentRec.ssRequisitionFile,cancellationToken);

// New?
if(((localVars.inParami_Requisition.ssRLAllFiles.CurrentRec.ssRequisitionContractFile.ssId==Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// RequisitionId
// i_Requisition.AllFiles.Current.RequisitionContractFile.RequisitionId = i_RequisitionId
localVars.inParami_Requisition.ssRLAllFiles.CurrentRec.ssRequisitionContractFile.ssRequisitionId = localVars.inParami_RequisitionId;
// RequisitionContractFileCreateOrUpdate
localVars.resRequisitionContractFileCreateOrUpdate.outParamId = await Actions.ActionRequisitionContractFileCreateOrUpdate(requestContext,new EN_aeab0089a9236dfc6c684ea98f650647EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssRequisitionId = localVars.inParami_RequisitionId, ssRequisitionFileId = localVars.resRequisitionFileCreateOrUpdate2.outParamId, ssContractFileTypeId = localVars.inParami_Requisition.ssRLAllFiles.CurrentRec.ssRequisitionContractFile.ssContractFileTypeId, ssAmount = localVars.inParami_Requisition.ssRLAllFiles.CurrentRec.ssRequisitionContractFile.ssAmount, ssCurrencyId = localVars.inParami_Requisition.ssRLAllFiles.CurrentRec.ssRequisitionContractFile.ssCurrencyId, ssDepositTypeId = localVars.inParami_Requisition.ssRLAllFiles.CurrentRec.ssRequisitionContractFile.ssDepositTypeId, ssInsuranceTypeId = localVars.inParami_Requisition.ssRLAllFiles.CurrentRec.ssRequisitionContractFile.ssInsuranceTypeId, ssAdvancePaymentTypeId = localVars.inParami_Requisition.ssRLAllFiles.CurrentRec.ssRequisitionContractFile.ssAdvancePaymentTypeId },cancellationToken);

localVars.inParami_Requisition.ssRLAllFiles.Advance();
// continue to flagContinueTo_forEach
flagContinueTo_forEach = true;
break;
}

} while(false)
;
if(flagContinueTo_forEach) {
continue;
}

// RequisitionContractFileCreateOrUpdate2
localVars.resRequisitionContractFileCreateOrUpdate2.outParamId = await Actions.ActionRequisitionContractFileCreateOrUpdate(requestContext,localVars.inParami_Requisition.ssRLAllFiles.CurrentRec.ssRequisitionContractFile,cancellationToken);

localVars.inParami_Requisition.ssRLAllFiles.Advance();
}

} finally {
localVars.inParami_Requisition.ssRLAllFiles.EndIteration();
}

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionSaveRequisitionFiles {

private static async Task<RC_dc345357879dcb92e41eacae4ac8926c> datasetGetRequisitionContractFileReadDbAsync(RC_dc345357879dcb92e41eacae4ac8926c rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENRequisitionContractFile.Read( r, ref index);
rec.ssENRequisitionFile2.Read( r, ref index);
return rec;
}
// Query Function "GetRequisitionContractFile" QDApSbthLkSEcDhIqWoQjg of Action "SaveRequisitionFiles"
public static async Task<(RL_dcf9165e080aea63f7a9b95efcf09ef4,long)> datasetGetRequisitionContractFile(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRequisitionContractFile_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("SaveRequisitionFiles.GetRequisitionContractFile", "49293040-61bb-442e-8470-3848a96a108e");
using var queryActivity = activitySource.CreateAggregateQueryActivity("SaveRequisitionFiles.GetRequisitionContractFile", "49293040-61bb-442e-8470-3848a96a108e", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.5gxAR7w160qy3OZeUUoJcQ/NodesNotShownInESpaceTree.QDApSbthLkSEcDhIqWoQjg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, \"enrequisitionfile2\".\"id\" o9, \"enrequisitionfile2\".\"filename\" o10, \"enrequisitionfile2\".\"vendor\" o11, \"enrequisitionfile2\".\"doc_type\" o12, \"enrequisitionfile2\".\"sap_object\" o13, \"enrequisitionfile2\".\"createdby\" o14, \"enrequisitionfile2\".\"createdon\" o15, \"enrequisitionfile2\".\"storageid\" o16");
fromBuilder.Append(" FROM ({RequisitionContractFile} \"enrequisitioncontractfile1\" Inner JOIN {RequisitionFile2} \"enrequisitionfile2\" ON (\"enrequisitioncontractfile1\".\"requisitionfileid\" = \"enrequisitionfile2\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpreRequisitionContractFile_Id != 0) {
whereBuilder.Append("((\"enrequisitioncontractfile1\".\"id\" = @qpreRequisitionContractFile_Id) AND (\"enrequisitioncontractfile1\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisitionContractFile_Id", DbType.Int64, qpreRequisitionContractFile_Id);
} else {
whereBuilder.Append("(\"enrequisitioncontractfile1\".\"id\" IS NULL)");
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
RL_dcf9165e080aea63f7a9b95efcf09ef4 outParamList = new RL_dcf9165e080aea63f7a9b95efcf09ef4();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetRequisitionContractFileReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query SaveRequisitionFiles.GetRequisitionContractFile.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_dcf9165e080aea63f7a9b95efcf09ef4 _tmp = new RL_dcf9165e080aea63f7a9b95efcf09ef4();
_tmp.AlternateReadDbMethodAsync = datasetGetRequisitionContractFileReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query SaveRequisitionFiles.GetRequisitionContractFile.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_dcf9165e080aea63f7a9b95efcf09ef4)_tmp;
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

private static async Task<RC_78028cb3076672e5dc4e3606fbea5d54> datasetGetRequisitionByIdReadDbAsync(RC_78028cb3076672e5dc4e3606fbea5d54 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENRequisition.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
return rec;
}
// Query Function "GetRequisitionById" Bqs1dYE3PUqV1zD1HHeSQQ of Action "SaveRequisitionFiles"
public static async Task<(RL_c61f86b789e3e219b8eaddf345441d54,long)> datasetGetRequisitionById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRequisition_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("SaveRequisitionFiles.GetRequisitionById", "7535ab06-3781-4a3d-95d7-30f51c779241");
using var queryActivity = activitySource.CreateAggregateQueryActivity("SaveRequisitionFiles.GetRequisitionById", "7535ab06-3781-4a3d-95d7-30f51c779241", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.5gxAR7w160qy3OZeUUoJcQ/NodesNotShownInESpaceTree.Bqs1dYE3PUqV1zD1HHeSQQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enrequisition20\".\"name\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, \"ensupplier11\".\"number\" o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85");
fromBuilder.Append(" FROM ({Requisition} \"enrequisition20\" Left JOIN {Supplier} \"ensupplier11\" ON (\"enrequisition20\".\"supplierid\" = \"ensupplier11\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpreRequisition_Id != 0) {
whereBuilder.Append("((\"enrequisition20\".\"id\" = @qpreRequisition_Id) AND (\"enrequisition20\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisition_Id", DbType.Int64, qpreRequisition_Id);
} else {
whereBuilder.Append("(\"enrequisition20\".\"id\" IS NULL)");
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
RL_c61f86b789e3e219b8eaddf345441d54 outParamList = new RL_c61f86b789e3e219b8eaddf345441d54();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetRequisitionByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query SaveRequisitionFiles.GetRequisitionById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_c61f86b789e3e219b8eaddf345441d54 _tmp = new RL_c61f86b789e3e219b8eaddf345441d54();
_tmp.AlternateReadDbMethodAsync = datasetGetRequisitionByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query SaveRequisitionFiles.GetRequisitionById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_c61f86b789e3e219b8eaddf345441d54)_tmp;
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

private static async Task<RC_dc345357879dcb92e41eacae4ac8926c> datasetGetRequisitionContractFilesByRequisitionIdReadDbAsync(RC_dc345357879dcb92e41eacae4ac8926c rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENRequisitionContractFile.Read( r, ref index);
rec.ssENRequisitionFile2.Read( r, ref index);
return rec;
}
// Query Function "GetRequisitionContractFilesByRequisitionId" q4cDtkc8+UOMgc8+Eoioeg of Action "SaveRequisitionFiles"
public static async Task<(RL_dcf9165e080aea63f7a9b95efcf09ef4,long)> datasetGetRequisitionContractFilesByRequisitionId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRequisitionContractFile_RequisitionId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("SaveRequisitionFiles.GetRequisitionContractFilesByRequisitionId", "b60387ab-3c47-43f9-8c81-cf3e1288a87a");
using var queryActivity = activitySource.CreateAggregateQueryActivity("SaveRequisitionFiles.GetRequisitionContractFilesByRequisitionId", "b60387ab-3c47-43f9-8c81-cf3e1288a87a", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.5gxAR7w160qy3OZeUUoJcQ/NodesNotShownInESpaceTree.q4cDtkc8+UOMgc8+Eoioeg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enrequisitioncontractfile2\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, \"enrequisitionfile21\".\"id\" o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, \"enrequisitionfile21\".\"storageid\" o16");
fromBuilder.Append(" FROM ({RequisitionContractFile} \"enrequisitioncontractfile2\" Left JOIN {RequisitionFile2} \"enrequisitionfile21\" ON (\"enrequisitioncontractfile2\".\"requisitionfileid\" = \"enrequisitionfile21\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpreRequisitionContractFile_RequisitionId != 0) {
whereBuilder.Append("((\"enrequisitioncontractfile2\".\"requisitionid\" = @qpreRequisitionContractFile_RequisitionId) AND (\"enrequisitioncontractfile2\".\"requisitionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisitionContractFile_RequisitionId", DbType.Int64, qpreRequisitionContractFile_RequisitionId);
} else {
whereBuilder.Append("(\"enrequisitioncontractfile2\".\"requisitionid\" IS NULL)");
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
RL_dcf9165e080aea63f7a9b95efcf09ef4 outParamList = new RL_dcf9165e080aea63f7a9b95efcf09ef4();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetRequisitionContractFilesByRequisitionIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {false, true, true, true, true, true, true, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query SaveRequisitionFiles.GetRequisitionContractFilesByRequisitionId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_dcf9165e080aea63f7a9b95efcf09ef4 _tmp = new RL_dcf9165e080aea63f7a9b95efcf09ef4();
_tmp.AlternateReadDbMethodAsync = datasetGetRequisitionContractFilesByRequisitionIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query SaveRequisitionFiles.GetRequisitionContractFilesByRequisitionId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_dcf9165e080aea63f7a9b95efcf09ef4)_tmp;
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
