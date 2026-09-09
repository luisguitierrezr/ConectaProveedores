namespace ssConectaProveedores;

public partial class Actions {
public class lcvUploadInvoiceFiles_CreateFiles : VarsBag {
public RL_7b4ceb84b6a1255d3a42c8932279bc3c inParamFilesList;
public RL_7b4ceb84b6a1255d3a42c8932279bc3c inParamExtraFilesList;
public long inParamInvoiceId;
public long resServiceStorageCreateOrUpdateBigFile_outParamId = 0L;

public Actions.lcoInvoiceFileCreateOrUpdate resInvoiceFileCreateOrUpdate3 =  new Actions.lcoInvoiceFileCreateOrUpdate();
public Actions.lcoInvoiceFileCreateOrUpdate resInvoiceFileCreateOrUpdate =  new Actions.lcoInvoiceFileCreateOrUpdate();
public RL_57f9395b59a284b640e8ea9444ea4ae8 queryResGetInvoiceById_outParamList = new RL_57f9395b59a284b640e8ea9444ea4ae8();
public long queryResGetInvoiceById_outParamCount = 0L;

public Actions.lcoInvoiceFileCreateOrUpdate resInvoiceFileCreateOrUpdate2 =  new Actions.lcoInvoiceFileCreateOrUpdate();
public RL_7b4ceb84b6a1255d3a42c8932279bc3c resListFilter2_outParamFilteredList = new RL_7b4ceb84b6a1255d3a42c8932279bc3c();

public RL_7b4ceb84b6a1255d3a42c8932279bc3c resListFilter_outParamFilteredList = new RL_7b4ceb84b6a1255d3a42c8932279bc3c();

public long resServiceStorageCreate_outParamId = 0L;

public long resServiceStorageCreate2_outParamId = 0L;

public lcvUploadInvoiceFiles_CreateFiles(RL_7b4ceb84b6a1255d3a42c8932279bc3c inParamFilesList, RL_7b4ceb84b6a1255d3a42c8932279bc3c inParamExtraFilesList, long inParamInvoiceId) {
this.inParamFilesList = inParamFilesList;
this.inParamExtraFilesList = inParamExtraFilesList;
this.inParamInvoiceId = inParamInvoiceId;
}
}
/// <summary>
/// Action <code>UploadInvoiceFiles_CreateFiles</code> that represents the Service Studio action
///  <code>UploadInvoiceFiles_CreateFiles</code> <p> Description: </p>
/// </summary>
public static async Task ActionUploadInvoiceFiles_CreateFiles(IRequestContext requestContext,RL_7b4ceb84b6a1255d3a42c8932279bc3c inParamFilesList,RL_7b4ceb84b6a1255d3a42c8932279bc3c inParamExtraFilesList,long inParamInvoiceId,CancellationToken cancellationToken) {
lcvUploadInvoiceFiles_CreateFiles localVars = new lcvUploadInvoiceFiles_CreateFiles(inParamFilesList, inParamExtraFilesList, inParamInvoiceId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("UploadInvoiceFiles_CreateFiles", "dcb90055-a20d-4eb5-95f6-95bdf3002337"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("UploadInvoiceFiles_CreateFiles", "dcb90055-a20d-4eb5-95f6-95bdf3002337", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// InvoiceFilesDeleteAll
await Actions.ActionInvoiceFilesDeleteAll(requestContext,localVars.inParamInvoiceId,localVars.inParamFilesList,localVars.inParamExtraFilesList,cancellationToken);

// Query datasetGetInvoiceById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceById_maxRecords = 0;
int datasetGetInvoiceById_startIndex = 0;(localVars.queryResGetInvoiceById_outParamList,localVars.queryResGetInvoiceById_outParamCount) = await FuncActionUploadInvoiceFiles_CreateFiles.datasetGetInvoiceById(requestContext,datasetGetInvoiceById_maxRecords,datasetGetInvoiceById_startIndex,IterationMultiplicity.Never,localVars.inParamInvoiceId,cancellationToken);

// ListFilter
localVars.resListFilter_outParamFilteredList = (((RL_7b4ceb84b6a1255d3a42c8932279bc3c)await  localVars.inParamFilesList.FilterAsync(async (p, cancellationToken) => (p.ssStorageId==Convert.ToInt64(BuiltInFunction.NullIdentifier ())), cancellationToken)));

// ListFilter2
localVars.resListFilter2_outParamFilteredList = (((RL_7b4ceb84b6a1255d3a42c8932279bc3c)await  localVars.inParamExtraFilesList.FilterAsync(async (p, cancellationToken) => (p.ssStorageId==Convert.ToInt64(BuiltInFunction.NullIdentifier ())), cancellationToken)));

// Foreach ListFilter.FilteredList
localVars.resListFilter_outParamFilteredList.StartIteration();
try {while (!((localVars.resListFilter_outParamFilteredList.Eof))) {
// ServiceStorageCreate
localVars.resServiceStorageCreate_outParamId = await ServiceAPIs.ServiceAPIServiceStorageCreate(requestContext,new EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssConcept = (((localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENRequisition.ssId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ()))) ? (localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENRequisition.ssName) : ((((localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENFolio.ssId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ()))) ? (localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENFolio.ssFolioNumber) : ((((localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENOrderMain.ssId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ()))) ? (localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENOrderMain.ssOrderNumber) : ("")))))), ssInternalConceptId = 1, ssFile = localVars.resListFilter_outParamFilteredList.CurrentRec.ssBinaryData, ssFilename = localVars.resListFilter_outParamFilteredList.CurrentRec.ssName, ssVendor = (((localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENRequisition.ssId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ()))) ? (localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENSupplierReq.ssNumber) : ((((localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENFolio.ssId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ()))) ? (localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENSupplierFolio.ssNumber) : ((((localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENOrderMain.ssId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ()))) ? (localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENSupplierOrder.ssNumber) : ("")))))), ssDoc_Type = (((localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENRequisition.ssId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ()))) ? ((((BuiltInFunction.IndexSC (BuiltInFunction.ToLower (localVars.resListFilter_outParamFilteredList.CurrentRec.ssName), ".pdf", 0, false, false)!=(-1))) ? (((((string)AppUtils.SiteProperties[SitePropertiesModel.spInvoiceWithNoContractPDF])))) : ((((BuiltInFunction.IndexSC (BuiltInFunction.ToLower (localVars.resListFilter_outParamFilteredList.CurrentRec.ssName), ".xml", 0, false, false)!=(-1))) ? (((((string)AppUtils.SiteProperties[SitePropertiesModel.spInvoiceWithNoContractXML])))) : (((((string)AppUtils.SiteProperties[SitePropertiesModel.spInvoiceWithNoContractOther])))))))) : ((((localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENFolio.ssId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ()))) ? ((((BuiltInFunction.IndexSC (BuiltInFunction.ToLower (localVars.resListFilter_outParamFilteredList.CurrentRec.ssName), ".pdf", 0, false, false)!=(-1))) ? (((((string)AppUtils.SiteProperties[SitePropertiesModel.spInvoiceWithNoContractPDF])))) : ((((BuiltInFunction.IndexSC (BuiltInFunction.ToLower (localVars.resListFilter_outParamFilteredList.CurrentRec.ssName), ".xml", 0, false, false)!=(-1))) ? (((((string)AppUtils.SiteProperties[SitePropertiesModel.spInvoiceWithNoContractXML])))) : (((((string)AppUtils.SiteProperties[SitePropertiesModel.spInvoiceWithNoContractOther])))))))) : ((((localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENOrderMain.ssId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ()))) ? ((((BuiltInFunction.IndexSC (BuiltInFunction.ToLower (localVars.resListFilter_outParamFilteredList.CurrentRec.ssName), ".pdf", 0, false, false)!=(-1))) ? (((((string)AppUtils.SiteProperties[SitePropertiesModel.spPurchaseOrderPDF])))) : ((((BuiltInFunction.IndexSC (BuiltInFunction.ToLower (localVars.resListFilter_outParamFilteredList.CurrentRec.ssName), ".xml", 0, false, false)!=(-1))) ? (((((string)AppUtils.SiteProperties[SitePropertiesModel.spPurchaseOrderXML])))) : (((((string)AppUtils.SiteProperties[SitePropertiesModel.spPurchaseOrderOther])))))))) : ("")))))), ssObject_type = (((localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENRequisition.ssId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ()))) ? (((((string)AppUtils.SiteProperties[SitePropertiesModel.spInvoiceWithNoContractTable])))) : ((((localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENFolio.ssId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ()))) ? (((((string)AppUtils.SiteProperties[SitePropertiesModel.spInvoiceWithNoContractTable])))) : ((((localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENOrderMain.ssId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ()))) ? (((((string)AppUtils.SiteProperties[SitePropertiesModel.spPurchaseOrderTable])))) : ("")))))), ssIstoSendToExternal = true },false,cancellationToken);

// InvoiceFileCreateOrUpdate
localVars.resInvoiceFileCreateOrUpdate.outParamId = await Actions.ActionInvoiceFileCreateOrUpdate(requestContext,new EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord(){ ssId = localVars.resListFilter_outParamFilteredList.CurrentRec.ssInvoiceFileId, ssInvoiceId = localVars.inParamInvoiceId, ssFilename = localVars.resListFilter_outParamFilteredList.CurrentRec.ssName, ssIsExtra = false, ssStorageId = localVars.resServiceStorageCreate_outParamId, ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime () },cancellationToken);

localVars.resListFilter_outParamFilteredList.Advance();
}

} finally {
localVars.resListFilter_outParamFilteredList.EndIteration();
}

// Foreach ListFilter2.FilteredList
localVars.resListFilter2_outParamFilteredList.StartIteration();
try {while (!((localVars.resListFilter2_outParamFilteredList.Eof))) {
// With FileId
if(((localVars.resListFilter2_outParamFilteredList.CurrentRec.ssFileId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// ServiceStorageCreateOrUpdateBigFile
localVars.resServiceStorageCreateOrUpdateBigFile_outParamId = await ServiceAPIs.ServiceAPIServiceStorageCreateOrUpdateBigFile(requestContext,new EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssConcept = (((localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENRequisition.ssId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ()))) ? (localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENRequisition.ssName) : ((((localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENFolio.ssId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ()))) ? (localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENFolio.ssFolioNumber) : ((((localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENOrderMain.ssId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ()))) ? (localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENOrderMain.ssOrderNumber) : ("")))))), ssInternalConceptId = 1, ssFile = BuiltInFunction.NullBinary (), ssFilename = localVars.resListFilter2_outParamFilteredList.CurrentRec.ssName, ssVendor = (((localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENRequisition.ssId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ()))) ? (localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENSupplierReq.ssNumber) : ((((localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENFolio.ssId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ()))) ? (localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENSupplierFolio.ssNumber) : ((((localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENOrderMain.ssId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ()))) ? (localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENSupplierOrder.ssNumber) : ("")))))), ssDoc_Type = (((localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENRequisition.ssId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ()))) ? ((((BuiltInFunction.IndexSC (BuiltInFunction.ToLower (localVars.resListFilter2_outParamFilteredList.CurrentRec.ssName), ".pdf", 0, false, false)!=(-1))) ? (((((string)AppUtils.SiteProperties[SitePropertiesModel.spInvoiceWithNoContractPDF])))) : ((((BuiltInFunction.IndexSC (BuiltInFunction.ToLower (localVars.resListFilter2_outParamFilteredList.CurrentRec.ssName), ".xml", 0, false, false)!=(-1))) ? (((((string)AppUtils.SiteProperties[SitePropertiesModel.spInvoiceWithNoContractXML])))) : (((((string)AppUtils.SiteProperties[SitePropertiesModel.spInvoiceWithNoContractOther])))))))) : ((((localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENFolio.ssId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ()))) ? ((((BuiltInFunction.IndexSC (BuiltInFunction.ToLower (localVars.resListFilter2_outParamFilteredList.CurrentRec.ssName), ".pdf", 0, false, false)!=(-1))) ? (((((string)AppUtils.SiteProperties[SitePropertiesModel.spInvoiceWithNoContractPDF])))) : ((((BuiltInFunction.IndexSC (BuiltInFunction.ToLower (localVars.resListFilter2_outParamFilteredList.CurrentRec.ssName), ".xml", 0, false, false)!=(-1))) ? (((((string)AppUtils.SiteProperties[SitePropertiesModel.spInvoiceWithNoContractXML])))) : (((((string)AppUtils.SiteProperties[SitePropertiesModel.spInvoiceWithNoContractOther])))))))) : ((((localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENOrderMain.ssId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ()))) ? ((((BuiltInFunction.IndexSC (BuiltInFunction.ToLower (localVars.resListFilter2_outParamFilteredList.CurrentRec.ssName), ".pdf", 0, false, false)!=(-1))) ? (((((string)AppUtils.SiteProperties[SitePropertiesModel.spPurchaseOrderPDF])))) : ((((BuiltInFunction.IndexSC (BuiltInFunction.ToLower (localVars.resListFilter2_outParamFilteredList.CurrentRec.ssName), ".xml", 0, false, false)!=(-1))) ? (((((string)AppUtils.SiteProperties[SitePropertiesModel.spPurchaseOrderXML])))) : (((((string)AppUtils.SiteProperties[SitePropertiesModel.spPurchaseOrderOther])))))))) : ("")))))), ssObject_type = (((localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENRequisition.ssId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ()))) ? (((((string)AppUtils.SiteProperties[SitePropertiesModel.spInvoiceWithNoContractTable])))) : ((((localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENFolio.ssId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ()))) ? (((((string)AppUtils.SiteProperties[SitePropertiesModel.spInvoiceWithNoContractTable])))) : ((((localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENOrderMain.ssId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ()))) ? (((((string)AppUtils.SiteProperties[SitePropertiesModel.spPurchaseOrderTable])))) : ("")))))), ssIstoSendToExternal = true },false,localVars.resListFilter2_outParamFilteredList.CurrentRec.ssFileId,cancellationToken);

// InvoiceFileCreateOrUpdate3
localVars.resInvoiceFileCreateOrUpdate3.outParamId = await Actions.ActionInvoiceFileCreateOrUpdate(requestContext,new EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord(){ ssId = localVars.resListFilter2_outParamFilteredList.CurrentRec.ssInvoiceFileId, ssInvoiceId = localVars.inParamInvoiceId, ssFilename = localVars.resListFilter2_outParamFilteredList.CurrentRec.ssName, ssIsExtra = true, ssStorageId = localVars.resServiceStorageCreateOrUpdateBigFile_outParamId, ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime () },cancellationToken);

} else {
// ServiceStorageCreate2
localVars.resServiceStorageCreate2_outParamId = await ServiceAPIs.ServiceAPIServiceStorageCreate(requestContext,new EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssConcept = (((localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENRequisition.ssId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ()))) ? (localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENRequisition.ssName) : ((((localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENFolio.ssId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ()))) ? (localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENFolio.ssFolioNumber) : ((((localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENOrderMain.ssId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ()))) ? (localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENOrderMain.ssOrderNumber) : ("")))))), ssInternalConceptId = 1, ssFile = localVars.resListFilter2_outParamFilteredList.CurrentRec.ssBinaryData, ssFilename = localVars.resListFilter2_outParamFilteredList.CurrentRec.ssName, ssVendor = (((localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENRequisition.ssId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ()))) ? (localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENSupplierReq.ssNumber) : ((((localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENFolio.ssId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ()))) ? (localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENSupplierFolio.ssNumber) : ((((localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENOrderMain.ssId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ()))) ? (localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENSupplierOrder.ssNumber) : ("")))))), ssDoc_Type = (((localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENRequisition.ssId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ()))) ? ((((BuiltInFunction.IndexSC (BuiltInFunction.ToLower (localVars.resListFilter2_outParamFilteredList.CurrentRec.ssName), ".pdf", 0, false, false)!=(-1))) ? (((((string)AppUtils.SiteProperties[SitePropertiesModel.spInvoiceWithNoContractPDF])))) : ((((BuiltInFunction.IndexSC (BuiltInFunction.ToLower (localVars.resListFilter2_outParamFilteredList.CurrentRec.ssName), ".xml", 0, false, false)!=(-1))) ? (((((string)AppUtils.SiteProperties[SitePropertiesModel.spInvoiceWithNoContractXML])))) : (((((string)AppUtils.SiteProperties[SitePropertiesModel.spInvoiceWithNoContractOther])))))))) : ((((localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENFolio.ssId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ()))) ? ((((BuiltInFunction.IndexSC (BuiltInFunction.ToLower (localVars.resListFilter2_outParamFilteredList.CurrentRec.ssName), ".pdf", 0, false, false)!=(-1))) ? (((((string)AppUtils.SiteProperties[SitePropertiesModel.spInvoiceWithNoContractPDF])))) : ((((BuiltInFunction.IndexSC (BuiltInFunction.ToLower (localVars.resListFilter2_outParamFilteredList.CurrentRec.ssName), ".xml", 0, false, false)!=(-1))) ? (((((string)AppUtils.SiteProperties[SitePropertiesModel.spInvoiceWithNoContractXML])))) : (((((string)AppUtils.SiteProperties[SitePropertiesModel.spInvoiceWithNoContractOther])))))))) : ((((localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENOrderMain.ssId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ()))) ? ((((BuiltInFunction.IndexSC (BuiltInFunction.ToLower (localVars.resListFilter2_outParamFilteredList.CurrentRec.ssName), ".pdf", 0, false, false)!=(-1))) ? (((((string)AppUtils.SiteProperties[SitePropertiesModel.spPurchaseOrderPDF])))) : ((((BuiltInFunction.IndexSC (BuiltInFunction.ToLower (localVars.resListFilter2_outParamFilteredList.CurrentRec.ssName), ".xml", 0, false, false)!=(-1))) ? (((((string)AppUtils.SiteProperties[SitePropertiesModel.spPurchaseOrderXML])))) : (((((string)AppUtils.SiteProperties[SitePropertiesModel.spPurchaseOrderOther])))))))) : ("")))))), ssObject_type = (((localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENRequisition.ssId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ()))) ? (((((string)AppUtils.SiteProperties[SitePropertiesModel.spInvoiceWithNoContractTable])))) : ((((localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENFolio.ssId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ()))) ? (((((string)AppUtils.SiteProperties[SitePropertiesModel.spInvoiceWithNoContractTable])))) : ((((localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENOrderMain.ssId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ()))) ? (((((string)AppUtils.SiteProperties[SitePropertiesModel.spPurchaseOrderTable])))) : ("")))))), ssIstoSendToExternal = true },false,cancellationToken);

// InvoiceFileCreateOrUpdate2
localVars.resInvoiceFileCreateOrUpdate2.outParamId = await Actions.ActionInvoiceFileCreateOrUpdate(requestContext,new EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord(){ ssId = localVars.resListFilter2_outParamFilteredList.CurrentRec.ssInvoiceFileId, ssInvoiceId = localVars.inParamInvoiceId, ssFilename = localVars.resListFilter2_outParamFilteredList.CurrentRec.ssName, ssIsExtra = true, ssStorageId = localVars.resServiceStorageCreate2_outParamId, ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime () },cancellationToken);

}

localVars.resListFilter2_outParamFilteredList.Advance();
}

} finally {
localVars.resListFilter2_outParamFilteredList.EndIteration();
}

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionUploadInvoiceFiles_CreateFiles {

private static async Task<RC_bbceb04a99cf02c4edcf63fc8b805b9f> datasetGetInvoiceByIdReadDbAsync(RC_bbceb04a99cf02c4edcf63fc8b805b9f rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFolio.Read( r, ref index);
rec.ssENInvoice.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
rec.ssENRequisition.Read( r, ref index);
rec.ssENSupplierFolio.Read( r, ref index);
rec.ssENSupplierOrder.Read( r, ref index);
rec.ssENSupplierReq.Read( r, ref index);
return rec;
}
// Query Function "GetInvoiceById" nH9dj7rvS0Wgg9rPr7pzpw of Action "UploadInvoiceFiles_CreateFiles"
public static async Task<(RL_57f9395b59a284b640e8ea9444ea4ae8,long)> datasetGetInvoiceById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoice_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("UploadInvoiceFiles_CreateFiles.GetInvoiceById", "8f5d7f9c-efba-454b-a083-dacfafba73a7");
using var queryActivity = activitySource.CreateAggregateQueryActivity("UploadInvoiceFiles_CreateFiles.GetInvoiceById", "8f5d7f9c-efba-454b-a083-dacfafba73a7", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.VQC53A2itU6V9pW98wAjNw/NodesNotShownInESpaceTree.nH9dj7rvS0Wgg9rPr7pzpw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enfolio55\".\"id\" o0, NULL o1, \"enfolio55\".\"folionumber\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, \"enordermain57\".\"id\" o44, \"enordermain57\".\"ordernumber\" o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, \"enrequisition64\".\"id\" o73, \"enrequisition64\".\"name\" o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, NULL o101, NULL o102, NULL o103, NULL o104, NULL o105, NULL o106, NULL o107, NULL o108, NULL o109, NULL o110, NULL o111, NULL o112, NULL o113, NULL o114, NULL o115, NULL o116, NULL o117, NULL o118, NULL o119, NULL o120, NULL o121, NULL o122, NULL o123, NULL o124, NULL o125, NULL o126, NULL o127, NULL o128, NULL o129, NULL o130, NULL o131, NULL o132, NULL o133, \"ensupplierfolio\".\"number\" o134, NULL o135, NULL o136, NULL o137, NULL o138, NULL o139, NULL o140, NULL o141, NULL o142, NULL o143, NULL o144, NULL o145, NULL o146, NULL o147, NULL o148, NULL o149, NULL o150, NULL o151, NULL o152, NULL o153, NULL o154, NULL o155, NULL o156, NULL o157, NULL o158, NULL o159, NULL o160, NULL o161, \"ensupplierorder\".\"number\" o162, NULL o163, NULL o164, NULL o165, NULL o166, NULL o167, NULL o168, NULL o169, NULL o170, NULL o171, NULL o172, NULL o173, NULL o174, NULL o175, NULL o176, NULL o177, NULL o178, NULL o179, NULL o180, NULL o181, NULL o182, NULL o183, NULL o184, NULL o185, NULL o186, NULL o187, NULL o188, NULL o189, \"ensupplierreq\".\"number\" o190, NULL o191, NULL o192, NULL o193, NULL o194, NULL o195, NULL o196, NULL o197, NULL o198, NULL o199, NULL o200, NULL o201, NULL o202, NULL o203, NULL o204, NULL o205, NULL o206, NULL o207, NULL o208, NULL o209, NULL o210, NULL o211, NULL o212, NULL o213, NULL o214");
fromBuilder.Append(" FROM ((((({Invoice} \"eninvoice67\" Left JOIN {Requisition} \"enrequisition64\" ON (\"eninvoice67\".\"requisitionid\" = \"enrequisition64\".\"id\"))  Left JOIN {Supplier} \"ensupplierreq\" ON (\"enrequisition64\".\"supplierid\" = \"ensupplierreq\".\"id\"))  Left JOIN {Folio} \"enfolio55\" ON (\"eninvoice67\".\"folioid\" = \"enfolio55\".\"id\"))  Left JOIN {Supplier} \"ensupplierfolio\" ON (\"enfolio55\".\"supplierid\" = \"ensupplierfolio\".\"id\"))  Left JOIN ({OrderMain} \"enordermain57\" Inner JOIN {Supplier} \"ensupplierorder\" ON (\"enordermain57\".\"supplierid\" = \"ensupplierorder\".\"id\"))  ON (\"eninvoice67\".\"ordermainid\" = \"enordermain57\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpinInvoice_Id != 0) {
whereBuilder.Append("((\"eninvoice67\".\"id\" = @qpinInvoice_Id) AND (\"eninvoice67\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoice_Id", DbType.Int64, qpinInvoice_Id);
} else {
whereBuilder.Append("(\"eninvoice67\".\"id\" IS NULL)");
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
RL_57f9395b59a284b640e8ea9444ea4ae8 outParamList = new RL_57f9395b59a284b640e8ea9444ea4ae8();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoiceByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[7];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {false, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[6] = new BitArray(new bool[] {true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query UploadInvoiceFiles_CreateFiles.GetInvoiceById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_57f9395b59a284b640e8ea9444ea4ae8 _tmp = new RL_57f9395b59a284b640e8ea9444ea4ae8();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoiceByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query UploadInvoiceFiles_CreateFiles.GetInvoiceById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_57f9395b59a284b640e8ea9444ea4ae8)_tmp;
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
