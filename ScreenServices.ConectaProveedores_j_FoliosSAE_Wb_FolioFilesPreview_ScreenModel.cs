using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_j_FoliosSAE_Wb_FolioFilesPreview_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_j_FoliosSAE_Wb_FolioFilesPreview_ScreenModel).Namespace);

    public long inParami_FolioId;
public string inParami_FolioNumber;
public ST_a158c76eb93396680623c04244f48b6cStructure varLcl_File;
public bool varLcl_ShowPopupUpload;
public ConectaProveedores_j_FoliosSAE_Wb_FolioFilesPreview_DataActionGetFolioFiles2_Model varLcGetFolioFiles2;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_j_FoliosSAE_Wb_FolioFilesPreview_ScreenModel() {
}



    public ConectaProveedores_j_FoliosSAE_Wb_FolioFilesPreview_ScreenModel(long inParami_FolioId, string inParami_FolioNumber, ST_a158c76eb93396680623c04244f48b6cStructure varLcl_File, bool varLcl_ShowPopupUpload, ConectaProveedores_j_FoliosSAE_Wb_FolioFilesPreview_DataActionGetFolioFiles2_Model varLcGetFolioFiles2, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"i_FolioId", "i_FolioNumber", "l_File", "l_ShowPopupUpload", "GetFolioFiles2", "ClientVars"}, new string[] {"inParami_FolioId", "inParami_FolioNumber", "varLcl_File", "varLcl_ShowPopupUpload", "varLcGetFolioFiles2", "clientVariables"});
this.inParami_FolioId = inParami_FolioId;
this.inParami_FolioNumber = inParami_FolioNumber;
this.varLcl_File = varLcl_File;
this.varLcl_ShowPopupUpload = varLcl_ShowPopupUpload;
this.varLcGetFolioFiles2 = varLcGetFolioFiles2;
this.clientVariables = clientVariables;
}



    

    public class lcvGetFolioFiles2 : VarsBag {
/// <summary>
/// Variable <code>FileJsonList</code> that represents the Service Studio FilesJsonList
///  <code>FileJsonList</code> <p>Description: </p>
/// </summary>
public RL_e2f87228588c7237002d108caedf9018 varLcFileJsonList = new RL_e2f87228588c7237002d108caedf9018();

public RL_3a91e4d1ce6fecfc0c9a887200ab0325 resListFilterExtra2_outParamFilteredList = new RL_3a91e4d1ce6fecfc0c9a887200ab0325();

public RL_f3a656d1fdc6bd4ad6371c5743799e57 queryResGetInvoicesByFolioId2_outParamList = new RL_f3a656d1fdc6bd4ad6371c5743799e57();
public long queryResGetInvoicesByFolioId2_outParamCount = 0L;

public RL_3a91e4d1ce6fecfc0c9a887200ab0325 queryResGetFolioFiles_outParamList = new RL_3a91e4d1ce6fecfc0c9a887200ab0325();
public long queryResGetFolioFiles_outParamCount = 0L;

public RL_e2c4aba060d96fb21cd52a1f134b9b47 queryResGetFolioById_outParamList = new RL_e2c4aba060d96fb21cd52a1f134b9b47();
public long queryResGetFolioById_outParamCount = 0L;

public RL_a18358ba225612b834f3458f070d11b3 resListFilterExtra_outParamFilteredList = new RL_a18358ba225612b834f3458f070d11b3();

public RL_a18358ba225612b834f3458f070d11b3 resListFilterMain_outParamFilteredList = new RL_a18358ba225612b834f3458f070d11b3();

public string resJSONSerialize1_outParamJSON = "";
public RL_a18358ba225612b834f3458f070d11b3 queryResGetInvoicesByFolioId_outParamList = new RL_a18358ba225612b834f3458f070d11b3();
public long queryResGetInvoicesByFolioId_outParamCount = 0L;

public Actions.lcoGetInvoiceFilesCreditNotes resGetInvoiceFilesCreditNotes =  new Actions.lcoGetInvoiceFilesCreditNotes();
public Actions.lcoGetInvoiceFilesCreditNotes resGetInvoiceFilesCreditNotes2 =  new Actions.lcoGetInvoiceFilesCreditNotes();
public RL_3a91e4d1ce6fecfc0c9a887200ab0325 resListFilterMain2_outParamFilteredList = new RL_3a91e4d1ce6fecfc0c9a887200ab0325();

public string resJSONSerialize2_outParamJSON = "";
public lcvGetFolioFiles2() {
}
}
public class lcoGetFolioFiles2 : VarsBag {
public RL_89dfc296578aaa53d7fbc0b8af34fb54 outParamFolioMainFiles = new RL_89dfc296578aaa53d7fbc0b8af34fb54();

public RL_89dfc296578aaa53d7fbc0b8af34fb54 outParamFolioExtraFiles = new RL_89dfc296578aaa53d7fbc0b8af34fb54();

public RL_cc11123f1ba1bfd417e2f33be28138e9 outParamInvoiceMainFiles = new RL_cc11123f1ba1bfd417e2f33be28138e9();

public RL_cc11123f1ba1bfd417e2f33be28138e9 outParamInvoiceExtraFiles = new RL_cc11123f1ba1bfd417e2f33be28138e9();

public bool outParamIsConstruction = false;

public int outParamFolioStatusId = 0;

public bool outParamCanSupplierChange = false;

public long outParamInvoiceID = 0L;

public EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord outParamFolio = new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord();

public string outParamSupplierNumber = "";

public EN_d1d0320db36efbb094ad0082361435a0EntityRecord outParamInvoice = new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();

public string outParamFilesForDownload = "";

public lcoGetFolioFiles2() {
}
}
/// <summary>
/// Action <code>GetFolioFiles2</code> that represents the Service Studio action
///  <code>GetFolioFiles2</code> <p> Description: </p>
/// </summary>
public async Task<(RL_89dfc296578aaa53d7fbc0b8af34fb54,RL_89dfc296578aaa53d7fbc0b8af34fb54,RL_cc11123f1ba1bfd417e2f33be28138e9,RL_cc11123f1ba1bfd417e2f33be28138e9,bool,int,bool,long,EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord,string,EN_d1d0320db36efbb094ad0082361435a0EntityRecord,string)> DataActionGetFolioFiles2(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_89dfc296578aaa53d7fbc0b8af34fb54 outParamFolioMainFiles = default;
RL_89dfc296578aaa53d7fbc0b8af34fb54 outParamFolioExtraFiles = default;
RL_cc11123f1ba1bfd417e2f33be28138e9 outParamInvoiceMainFiles = default;
RL_cc11123f1ba1bfd417e2f33be28138e9 outParamInvoiceExtraFiles = default;
bool outParamIsConstruction = default;
int outParamFolioStatusId = default;
bool outParamCanSupplierChange = default;
long outParamInvoiceID = default;
EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord outParamFolio = default;
string outParamSupplierNumber = default;
EN_d1d0320db36efbb094ad0082361435a0EntityRecord outParamInvoice = default;
string outParamFilesForDownload = default;
lcoGetFolioFiles2 result = new lcoGetFolioFiles2();
lcvGetFolioFiles2 localVars = new lcvGetFolioFiles2();
ConectaProveedores_j_FoliosSAE_Wb_FolioFilesPreview_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetFolioFiles2", "3c097206-2f10-4aac-a7c8-7c6a0188ce77"))
using (activitySource.CreateScreenDataActionActivity("Wb_FolioFilesPreview", "GetFolioFiles2")){
// Query datasetGetFolioById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioById_maxRecords = 0;
int datasetGetFolioById_startIndex = 0;(localVars.queryResGetFolioById_outParamList,localVars.queryResGetFolioById_outParamCount) = await FuncDataActionGetFolioFiles2.datasetGetFolioById(requestContext,datasetGetFolioById_maxRecords,datasetGetFolioById_startIndex,IterationMultiplicity.Never,inParami_FolioId,cancellationToken);

// IsConstruction = GetFolioById.List.Current.Folio.ApprovalProcessTypeId = Construction
result.outParamIsConstruction=(localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssApprovalProcessTypeId==1);

// FolioStatusId = GetFolioById.List.Current.Folio.FolioStatusId
result.outParamFolioStatusId=localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssFolioStatusId;

// CanSupplierChange = GetFolioById.List.Current.Folio.CanProveedorCancel
result.outParamCanSupplierChange=localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssCanProveedorCancel;

// SupplierNumber = GetFolioById.List.Current.Supplier.Number
result.outParamSupplierNumber=localVars.queryResGetFolioById_outParamList.CurrentRec.ssENSupplier.ssNumber;
// Is Construction
if(((localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssApprovalProcessTypeId==1))) {
// Query datasetGetInvoicesByFolioId2
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoicesByFolioId2_maxRecords = 999999999;
if (datasetGetInvoicesByFolioId2_maxRecords < 1) datasetGetInvoicesByFolioId2_maxRecords = 1;
int datasetGetInvoicesByFolioId2_startIndex = 0;(localVars.queryResGetInvoicesByFolioId2_outParamList,localVars.queryResGetInvoicesByFolioId2_outParamCount) = await FuncDataActionGetFolioFiles2.datasetGetInvoicesByFolioId2(requestContext,datasetGetInvoicesByFolioId2_maxRecords,datasetGetInvoicesByFolioId2_startIndex,IterationMultiplicity.Multiple,inParami_FolioId,cancellationToken);

// Query datasetGetFolioFiles
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioFiles_maxRecords = 500;
if (datasetGetFolioFiles_maxRecords < 1) datasetGetFolioFiles_maxRecords = 1;
int datasetGetFolioFiles_startIndex = 0;(localVars.queryResGetFolioFiles_outParamList,localVars.queryResGetFolioFiles_outParamCount) = await FuncDataActionGetFolioFiles2.datasetGetFolioFiles(requestContext,datasetGetFolioFiles_maxRecords,datasetGetFolioFiles_startIndex,IterationMultiplicity.Multiple,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),inParami_FolioId,cancellationToken);

// ListFilterMain2
localVars.resListFilterMain2_outParamFilteredList = (((RL_3a91e4d1ce6fecfc0c9a887200ab0325)await  localVars.queryResGetFolioFiles_outParamList.FilterAsync(async (p, cancellationToken) => (!p.ssENFolioFiles.ssIsExtra), cancellationToken)));

// ListFilterExtra2
localVars.resListFilterExtra2_outParamFilteredList = (((RL_3a91e4d1ce6fecfc0c9a887200ab0325)await  localVars.queryResGetFolioFiles_outParamList.FilterAsync(async (p, cancellationToken) => p.ssENFolioFiles.ssIsExtra, cancellationToken)));

// empty
if((!(localVars.queryResGetInvoicesByFolioId2_outParamList.Empty))) {
// ListAppendAll
await ExtendedActions.ListAppendAll(requestContext,localVars.resListFilterMain2_outParamFilteredList,(await RL_3a91e4d1ce6fecfc0c9a887200ab0325.ConvertAsync(localVars.queryResGetInvoicesByFolioId2_outParamList, new RL_3a91e4d1ce6fecfc0c9a887200ab0325(), async (RC_f5e20bd4e0a7c754f3e99b7ff28d38d9 source, RC_524c288faf455ce3a30a531f7ff5854e target, CancellationToken cancellationToken) => {
target.ssENFolioFiles.ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ());
target.ssENFolioFiles.ssFilename = source.ssENInvoiceFile.ssFilename;
target.ssENFolioFiles.ssFolioId = source.ssENInvoice.ssFolioId;
target.ssENFolioFiles.ssIsExtra = source.ssENInvoiceFile.ssIsExtra;
target.ssENFolioFiles.ssStorageId = source.ssENInvoiceFile.ssStorageId;
target.ssENFolioFiles.ssCreatedBy = source.ssENInvoiceFile.ssCreatedBy;
target.ssENFolioFiles.ssCreatedOn = localVars.queryResGetInvoicesByFolioId2_outParamList.CurrentRec.ssENInvoiceFile.ssCreatedOn;
target.ssENFolioFiles.ssIsNewFile = false;
target.ssENStorage.ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ());
target.ssENStorage.ssInternalConceptId = BuiltInFunction.NullIdentifier ();
target.ssENStorage.ssFilename = source.ssENInvoiceFile.ssFilename;
target.ssENStorage.ssVendor = "";
target.ssENUser = source.ssENUser;
return target;
}, cancellationToken)),cancellationToken);

}

// FolioMainFiles = ListFilterMain2.FilteredList
result.outParamFolioMainFiles=(await RL_89dfc296578aaa53d7fbc0b8af34fb54.ConvertAsync(localVars.resListFilterMain2_outParamFilteredList, new RL_89dfc296578aaa53d7fbc0b8af34fb54(), async (RC_524c288faf455ce3a30a531f7ff5854e source, ST_a23a10e9592e51ca9ffbbbc42c558496Structure target, CancellationToken cancellationToken) => {
target.ssId = source.ssENFolioFiles.ssId;
target.ssFilename = source.ssENFolioFiles.ssFilename;
target.ssFolioId = source.ssENFolioFiles.ssFolioId;
target.ssIsExtra = source.ssENFolioFiles.ssIsExtra;
target.ssStorageId = source.ssENFolioFiles.ssStorageId;
target.ssCreatedBy = source.ssENFolioFiles.ssCreatedBy;
target.ssCreatedByName = source.ssENUser.ssName;
target.ssCreatedOn = source.ssENFolioFiles.ssCreatedOn;
target.ssSize = source.ssENStorage.ssSize;
target.ssIsNewFile = source.ssENFolioFiles.ssIsNewFile;
return target;
}, cancellationToken));

// FolioExtraFiles = ListFilterExtra2.FilteredList
result.outParamFolioExtraFiles=(await RL_89dfc296578aaa53d7fbc0b8af34fb54.ConvertAsync(localVars.resListFilterExtra2_outParamFilteredList, new RL_89dfc296578aaa53d7fbc0b8af34fb54(), async (RC_524c288faf455ce3a30a531f7ff5854e source, ST_a23a10e9592e51ca9ffbbbc42c558496Structure target, CancellationToken cancellationToken) => {
target.ssId = source.ssENFolioFiles.ssId;
target.ssFilename = source.ssENFolioFiles.ssFilename;
target.ssFolioId = source.ssENFolioFiles.ssFolioId;
target.ssIsExtra = source.ssENFolioFiles.ssIsExtra;
target.ssStorageId = source.ssENFolioFiles.ssStorageId;
target.ssCreatedBy = source.ssENFolioFiles.ssCreatedBy;
target.ssCreatedByName = source.ssENUser.ssName;
target.ssCreatedOn = source.ssENFolioFiles.ssCreatedOn;
target.ssSize = source.ssENStorage.ssSize;
target.ssIsNewFile = source.ssENFolioFiles.ssIsNewFile;
return target;
}, cancellationToken));

// InvoiceID = NullIdentifier
result.outParamInvoiceID=Convert.ToInt64(BuiltInFunction.NullIdentifier ());
// GetInvoiceFilesCreditNotes2
localVars.resGetInvoiceFilesCreditNotes2.outParamCreditNoteInvoiceList = await Actions.ActionGetInvoiceFilesCreditNotes(requestContext,(await RL_2d16aaaf46aa59a96936af8c3c3547a0.ConvertAsync(localVars.queryResGetInvoicesByFolioId2_outParamList, new RL_2d16aaaf46aa59a96936af8c3c3547a0(), async (RC_f5e20bd4e0a7c754f3e99b7ff28d38d9 source, EN_d1d0320db36efbb094ad0082361435a0EntityRecord target, CancellationToken cancellationToken) => {
target.ssId = source.ssENInvoice.ssId;
target.ssDoc51 = source.ssENInvoice.ssDoc51;
target.ssCreditNoteInvoiceId = source.ssENInvoice.ssCreditNoteInvoiceId;
return target;
}, cancellationToken)),cancellationToken);

// ListAppendCN2
await ExtendedActions.ListAppendAll(requestContext,result.outParamFolioMainFiles,(await RL_89dfc296578aaa53d7fbc0b8af34fb54.ConvertAsync(localVars.resGetInvoiceFilesCreditNotes2.outParamCreditNoteInvoiceList, new RL_89dfc296578aaa53d7fbc0b8af34fb54(), async (RC_e89a3df29980b4bfe26cbaac4d2e6d26 source, ST_a23a10e9592e51ca9ffbbbc42c558496Structure target, CancellationToken cancellationToken) => {
target.ssId = source.ssENInvoiceFile.ssId;
target.ssFilename = source.ssENInvoiceFile.ssFilename;
target.ssFolioId = source.ssENInvoice.ssFolioId;
target.ssIsExtra = source.ssENInvoiceFile.ssIsExtra;
target.ssStorageId = source.ssENInvoiceFile.ssStorageId;
target.ssCreatedBy = source.ssENInvoice.ssCreatedBy;
target.ssCreatedByName = source.ssENUser.ssName;
target.ssCreatedOn = source.ssENInvoiceFile.ssCreatedOn;
target.ssSize = source.ssENStorage.ssSize;
target.ssIsNewFile = source.ssENInvoice.ssIsNewVersion;
return target;
}, cancellationToken)),cancellationToken);

// ListAppendAll2
await ExtendedActions.ListAppendAll(requestContext,localVars.varLcFileJsonList,(await RL_e2f87228588c7237002d108caedf9018.ConvertAsync(result.outParamFolioMainFiles, new RL_e2f87228588c7237002d108caedf9018(), async (ST_a23a10e9592e51ca9ffbbbc42c558496Structure source, ST_6c0a0d3b1d72414f90bb9301bad200fbStructure target, CancellationToken cancellationToken) => {
target.ssFileId = source.ssStorageId;
target.ssFileName = source.ssFilename;
target.ssFileSize = source.ssSize;
target.ssTotalChunks = (((int)(((source.ssSize==Convert.ToInt64(0))) ? ((((decimal)1))) : ((((source.ssSize<=Convert.ToInt64(((3*1024)*1024)))) ? ((((decimal)1))) : ((((BuiltInFunction.Mod ((((decimal)source.ssSize)), (((decimal)((3*1024)*1024))))==(((decimal)0)))) ? (((decimal)(((decimal)source.ssSize))/
(decimal)(((decimal)((3*1024)*1024))))) : ((BuiltInFunction.Trunc (((decimal)(((decimal)source.ssSize))/
(decimal)(((decimal)((3*1024)*1024)))))+(((decimal)1)))))))))));
return target;
}, cancellationToken)),cancellationToken);

// ListAppendAll3
await ExtendedActions.ListAppendAll(requestContext,localVars.varLcFileJsonList,(await RL_e2f87228588c7237002d108caedf9018.ConvertAsync(result.outParamFolioExtraFiles, new RL_e2f87228588c7237002d108caedf9018(), async (ST_a23a10e9592e51ca9ffbbbc42c558496Structure source, ST_6c0a0d3b1d72414f90bb9301bad200fbStructure target, CancellationToken cancellationToken) => {
target.ssFileId = source.ssStorageId;
target.ssFileName = source.ssFilename;
target.ssFileSize = source.ssSize;
target.ssTotalChunks = (((int)(((source.ssSize==Convert.ToInt64(0))) ? ((((decimal)1))) : ((((source.ssSize<=Convert.ToInt64(((3*1024)*1024)))) ? ((((decimal)1))) : ((((BuiltInFunction.Mod ((((decimal)source.ssSize)), (((decimal)((3*1024)*1024))))==(((decimal)0)))) ? (((decimal)(((decimal)source.ssSize))/
(decimal)(((decimal)((3*1024)*1024))))) : ((BuiltInFunction.Trunc (((decimal)(((decimal)source.ssSize))/
(decimal)(((decimal)((3*1024)*1024)))))+(((decimal)1)))))))))));
return target;
}, cancellationToken)),cancellationToken);

// JSON Serialize JsonSerializeJSONSerialize1
FuncDataActionGetFolioFiles2.JsonSerializeJSONSerialize1(localVars.varLcFileJsonList, out localVars.resJSONSerialize1_outParamJSON);
// FilesForDownload = JSONSerialize1.JSON
result.outParamFilesForDownload=localVars.resJSONSerialize1_outParamJSON;
} else {
// Query datasetGetInvoicesByFolioId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoicesByFolioId_maxRecords = 999999999;
if (datasetGetInvoicesByFolioId_maxRecords < 1) datasetGetInvoicesByFolioId_maxRecords = 1;
int datasetGetInvoicesByFolioId_startIndex = 0;(localVars.queryResGetInvoicesByFolioId_outParamList,localVars.queryResGetInvoicesByFolioId_outParamCount) = await FuncDataActionGetFolioFiles2.datasetGetInvoicesByFolioId(requestContext,datasetGetInvoicesByFolioId_maxRecords,datasetGetInvoicesByFolioId_startIndex,IterationMultiplicity.Multiple,inParami_FolioId,cancellationToken);

// ListFilterMain
localVars.resListFilterMain_outParamFilteredList = (((RL_a18358ba225612b834f3458f070d11b3)await  localVars.queryResGetInvoicesByFolioId_outParamList.FilterAsync(async (p, cancellationToken) => (!p.ssENInvoiceFile.ssIsExtra), cancellationToken)));

// ListFilterExtra
localVars.resListFilterExtra_outParamFilteredList = (((RL_a18358ba225612b834f3458f070d11b3)await  localVars.queryResGetInvoicesByFolioId_outParamList.FilterAsync(async (p, cancellationToken) => p.ssENInvoiceFile.ssIsExtra, cancellationToken)));

// InvoiceMainFiles = ListFilterMain.FilteredList
result.outParamInvoiceMainFiles=(await RL_cc11123f1ba1bfd417e2f33be28138e9.ConvertAsync(localVars.resListFilterMain_outParamFilteredList, new RL_cc11123f1ba1bfd417e2f33be28138e9(), async (RC_e89a3df29980b4bfe26cbaac4d2e6d26 source, ST_d381fba44897ce4382b17d5149465d51Structure target, CancellationToken cancellationToken) => {
target.ssId = source.ssENInvoiceFile.ssId;
target.ssInvoiceId = source.ssENInvoiceFile.ssInvoiceId;
target.ssFilename = source.ssENInvoiceFile.ssFilename;
target.ssIsExtra = source.ssENInvoiceFile.ssIsExtra;
target.ssStorageId = source.ssENInvoiceFile.ssStorageId;
target.ssCreatedByName = source.ssENUser.ssName;
target.ssCreatedBy = source.ssENInvoice.ssCreatedBy;
target.ssCreatedOn = source.ssENInvoiceFile.ssCreatedOn;
target.ssSize = source.ssENStorage.ssSize;
return target;
}, cancellationToken));

// InvoiceExtraFiles = ListFilterExtra.FilteredList
result.outParamInvoiceExtraFiles=(await RL_cc11123f1ba1bfd417e2f33be28138e9.ConvertAsync(localVars.resListFilterExtra_outParamFilteredList, new RL_cc11123f1ba1bfd417e2f33be28138e9(), async (RC_e89a3df29980b4bfe26cbaac4d2e6d26 source, ST_d381fba44897ce4382b17d5149465d51Structure target, CancellationToken cancellationToken) => {
target.ssId = source.ssENInvoiceFile.ssId;
target.ssInvoiceId = source.ssENInvoiceFile.ssInvoiceId;
target.ssFilename = source.ssENInvoiceFile.ssFilename;
target.ssIsExtra = source.ssENInvoiceFile.ssIsExtra;
target.ssStorageId = source.ssENInvoiceFile.ssStorageId;
target.ssCreatedByName = source.ssENUser.ssName;
target.ssCreatedBy = source.ssENInvoice.ssCreatedBy;
target.ssCreatedOn = source.ssENInvoiceFile.ssCreatedOn;
target.ssSize = source.ssENStorage.ssSize;
return target;
}, cancellationToken));

// InvoiceID = GetInvoicesByFolioId.List.Current.Invoice.Id
result.outParamInvoiceID=localVars.queryResGetInvoicesByFolioId_outParamList.CurrentRec.ssENInvoice.ssId;

// Folio = GetFolioById.List.Current.Folio
result.outParamFolio=localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio;

// Invoice = GetInvoicesByFolioId.List.Current.Invoice
result.outParamInvoice=localVars.queryResGetInvoicesByFolioId_outParamList.CurrentRec.ssENInvoice;
// GetInvoiceFilesCreditNotes
localVars.resGetInvoiceFilesCreditNotes.outParamCreditNoteInvoiceList = await Actions.ActionGetInvoiceFilesCreditNotes(requestContext,(await RL_2d16aaaf46aa59a96936af8c3c3547a0.ConvertAsync(localVars.resListFilterMain_outParamFilteredList, new RL_2d16aaaf46aa59a96936af8c3c3547a0(), async (RC_e89a3df29980b4bfe26cbaac4d2e6d26 source, EN_d1d0320db36efbb094ad0082361435a0EntityRecord target, CancellationToken cancellationToken) => {
target = source.ssENInvoice;
return target;
}, cancellationToken)),cancellationToken);

// ListAppendCN
await ExtendedActions.ListAppendAll(requestContext,result.outParamInvoiceMainFiles,(await RL_cc11123f1ba1bfd417e2f33be28138e9.ConvertAsync(localVars.resGetInvoiceFilesCreditNotes.outParamCreditNoteInvoiceList, new RL_cc11123f1ba1bfd417e2f33be28138e9(), async (RC_e89a3df29980b4bfe26cbaac4d2e6d26 source, ST_d381fba44897ce4382b17d5149465d51Structure target, CancellationToken cancellationToken) => {
target.ssId = source.ssENInvoiceFile.ssId;
target.ssInvoiceId = source.ssENInvoiceFile.ssInvoiceId;
target.ssFilename = source.ssENInvoiceFile.ssFilename;
target.ssIsExtra = source.ssENInvoiceFile.ssIsExtra;
target.ssStorageId = source.ssENInvoiceFile.ssStorageId;
target.ssCreatedByName = source.ssENUser.ssName;
target.ssCreatedBy = source.ssENInvoice.ssCreatedBy;
target.ssCreatedOn = source.ssENInvoiceFile.ssCreatedOn;
target.ssSize = source.ssENStorage.ssSize;
return target;
}, cancellationToken)),cancellationToken);

// ListAppendAll5
await ExtendedActions.ListAppendAll(requestContext,localVars.varLcFileJsonList,(await RL_e2f87228588c7237002d108caedf9018.ConvertAsync(result.outParamInvoiceMainFiles, new RL_e2f87228588c7237002d108caedf9018(), async (ST_d381fba44897ce4382b17d5149465d51Structure source, ST_6c0a0d3b1d72414f90bb9301bad200fbStructure target, CancellationToken cancellationToken) => {
target.ssFileId = source.ssStorageId;
target.ssFileName = source.ssFilename;
target.ssFileSize = source.ssSize;
target.ssTotalChunks = (((int)(((source.ssSize==Convert.ToInt64(0))) ? ((((decimal)1))) : ((((source.ssSize<=Convert.ToInt64(((3*1024)*1024)))) ? ((((decimal)1))) : ((((BuiltInFunction.Mod ((((decimal)source.ssSize)), (((decimal)((3*1024)*1024))))==(((decimal)0)))) ? (((decimal)(((decimal)source.ssSize))/
(decimal)(((decimal)((3*1024)*1024))))) : ((BuiltInFunction.Trunc (((decimal)(((decimal)source.ssSize))/
(decimal)(((decimal)((3*1024)*1024)))))+(((decimal)1)))))))))));
return target;
}, cancellationToken)),cancellationToken);

// ListAppendAll4
await ExtendedActions.ListAppendAll(requestContext,localVars.varLcFileJsonList,(await RL_e2f87228588c7237002d108caedf9018.ConvertAsync(result.outParamInvoiceExtraFiles, new RL_e2f87228588c7237002d108caedf9018(), async (ST_d381fba44897ce4382b17d5149465d51Structure source, ST_6c0a0d3b1d72414f90bb9301bad200fbStructure target, CancellationToken cancellationToken) => {
target.ssFileId = source.ssStorageId;
target.ssFileName = source.ssFilename;
target.ssFileSize = source.ssSize;
target.ssTotalChunks = (((int)(((source.ssSize==Convert.ToInt64(0))) ? ((((decimal)1))) : ((((source.ssSize<=Convert.ToInt64(((3*1024)*1024)))) ? ((((decimal)1))) : ((((BuiltInFunction.Mod ((((decimal)source.ssSize)), (((decimal)((3*1024)*1024))))==(((decimal)0)))) ? (((decimal)(((decimal)source.ssSize))/
(decimal)(((decimal)((3*1024)*1024))))) : ((BuiltInFunction.Trunc (((decimal)(((decimal)source.ssSize))/
(decimal)(((decimal)((3*1024)*1024)))))+(((decimal)1)))))))))));
return target;
}, cancellationToken)),cancellationToken);

// JSON Serialize JsonSerializeJSONSerialize2
FuncDataActionGetFolioFiles2.JsonSerializeJSONSerialize2(localVars.varLcFileJsonList, out localVars.resJSONSerialize2_outParamJSON);
// FilesForDownload = JSONSerialize2.JSON
result.outParamFilesForDownload=localVars.resJSONSerialize2_outParamJSON;
}

} //close CreateActionActivity using block
} // try

finally {
outParamFolioMainFiles = result.outParamFolioMainFiles;
outParamFolioExtraFiles = result.outParamFolioExtraFiles;
outParamInvoiceMainFiles = result.outParamInvoiceMainFiles;
outParamInvoiceExtraFiles = result.outParamInvoiceExtraFiles;
outParamIsConstruction = result.outParamIsConstruction;
outParamFolioStatusId = result.outParamFolioStatusId;
outParamCanSupplierChange = result.outParamCanSupplierChange;
outParamInvoiceID = result.outParamInvoiceID;
outParamFolio = result.outParamFolio;
outParamSupplierNumber = result.outParamSupplierNumber;
outParamInvoice = result.outParamInvoice;
outParamFilesForDownload = result.outParamFilesForDownload;
} // inner-finally
RETURN_STATEMENT:
return (outParamFolioMainFiles,outParamFolioExtraFiles,outParamInvoiceMainFiles,outParamInvoiceExtraFiles,outParamIsConstruction,outParamFolioStatusId,outParamCanSupplierChange,outParamInvoiceID,outParamFolio,outParamSupplierNumber,outParamInvoice,outParamFilesForDownload);
}


    public static class FuncDataActionGetFolioFiles2 {

private static async Task<RC_f5e20bd4e0a7c754f3e99b7ff28d38d9> datasetGetInvoicesByFolioId2ReadDbAsync(RC_f5e20bd4e0a7c754f3e99b7ff28d38d9 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceFile.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
return rec;
}
// Query Function "GetInvoicesByFolioId2" _ehvDz97JUGApC2jf0TbHw of Action "GetFolioFiles2"
public static async Task<(RL_f3a656d1fdc6bd4ad6371c5743799e57,long)> datasetGetInvoicesByFolioId2(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoInvoice_FolioId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("j_FoliosSAE.Wb_FolioFilesPreview.GetFolioFiles2.GetInvoicesByFolioId2", "0f6fe8fd-7b3f-4125-80a4-2da37f44db1f");
using var queryActivity = activitySource.CreateAggregateQueryActivity("j_FoliosSAE.Wb_FolioFilesPreview.GetFolioFiles2.GetInvoicesByFolioId2", "0f6fe8fd-7b3f-4125-80a4-2da37f44db1f", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.KZkCPzeOrE6ciI9e4OteIw/DataActions.BnIJPBAvrEqnyHxqAYjOdw/NodesNotShownInESpaceTree._ehvDz97JUGApC2jf0TbHw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoice149\".\"id\" o0, NULL o1, NULL o2, \"eninvoice149\".\"folioid\" o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, \"eninvoice149\".\"doc51\" o19, NULL o20, NULL o21, NULL o22, \"eninvoice149\".\"creditnoteinvoiceid\" o23, NULL o24, NULL o25, \"eninvoicefile53\".\"filename\" o26, \"eninvoicefile53\".\"isextra\" o27, NULL o28, \"eninvoicefile53\".\"storageid\" o29, \"eninvoicefile53\".\"createdby\" o30, \"eninvoicefile53\".\"createdon\" o31, \"enuser233\".\"id\" o32, \"enuser233\".\"name\" o33, \"enuser233\".\"email\" o34, \"enuser233\".\"photourl\" o35, \"enuser233\".\"username\" o36");
fromBuilder.Append(" FROM (({Invoice} \"eninvoice149\" Inner JOIN {InvoiceFile} \"eninvoicefile53\" ON (\"eninvoice149\".\"id\" = \"eninvoicefile53\".\"invoiceid\"))  Left JOIN {User} \"enuser233\" ON (\"eninvoicefile53\".\"createdby\" = \"enuser233\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoInvoice_FolioId != 0) {
whereBuilder.Append("((\"eninvoice149\".\"folioid\" = @qpfoInvoice_FolioId) AND (\"eninvoice149\".\"folioid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoInvoice_FolioId", DbType.Int64, qpfoInvoice_FolioId);
} else {
whereBuilder.Append("(\"eninvoice149\".\"folioid\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"eninvoice149\".\"name\" ASC ");
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
RL_f3a656d1fdc6bd4ad6371c5743799e57 outParamList = new RL_f3a656d1fdc6bd4ad6371c5743799e57();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoicesByFolioId2ReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {false, false, false, false, false});
opt[1] = new BitArray(new bool[] {false, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, true, true, false});
opt[2] = new BitArray(new bool[] {true, true, false, false, true, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_FolioFilesPreview.GetFolioFiles2.GetInvoicesByFolioId2.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_f3a656d1fdc6bd4ad6371c5743799e57 _tmp = new RL_f3a656d1fdc6bd4ad6371c5743799e57();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoicesByFolioId2ReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_FolioFilesPreview.GetFolioFiles2.GetInvoicesByFolioId2.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_f3a656d1fdc6bd4ad6371c5743799e57)_tmp;
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

private static async Task<RC_524c288faf455ce3a30a531f7ff5854e> datasetGetFolioFilesReadDbAsync(RC_524c288faf455ce3a30a531f7ff5854e rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFolioFiles.Read( r, ref index);
rec.ssENStorage.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
return rec;
}
// Query Function "GetFolioFiles" IexhFoNG3kebKZLCHjauAQ of Action "GetFolioFiles2"
public static async Task<(RL_3a91e4d1ce6fecfc0c9a887200ab0325,long)> datasetGetFolioFiles(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,long qpfoFolioFiles_FolioId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("j_FoliosSAE.Wb_FolioFilesPreview.GetFolioFiles2.GetFolioFiles", "1661ec21-4683-47de-9b29-92c21e36ae01");
using var queryActivity = activitySource.CreateAggregateQueryActivity("j_FoliosSAE.Wb_FolioFilesPreview.GetFolioFiles2.GetFolioFiles", "1661ec21-4683-47de-9b29-92c21e36ae01", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.KZkCPzeOrE6ciI9e4OteIw/DataActions.BnIJPBAvrEqnyHxqAYjOdw/NodesNotShownInESpaceTree.IexhFoNG3kebKZLCHjauAQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enfoliofiles8\".\"id\" o0, \"enfoliofiles8\".\"filename\" o1, \"enfoliofiles8\".\"folioid\" o2, \"enfoliofiles8\".\"isextra\" o3, \"enfoliofiles8\".\"storageid\" o4, \"enfoliofiles8\".\"createdby\" o5, \"enfoliofiles8\".\"createdon\" o6, \"enfoliofiles8\".\"isnewfile\" o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, \"enstorage34\".\"size\" o26, NULL o27, NULL o28, \"enuser234\".\"name\" o29, NULL o30, NULL o31, NULL o32");
fromBuilder.Append(" FROM (({FolioFiles} \"enfoliofiles8\" Inner JOIN {User} \"enuser234\" ON (\"enfoliofiles8\".\"createdby\" = \"enuser234\".\"id\"))  Left JOIN {Storage} \"enstorage34\" ON (\"enfoliofiles8\".\"storageid\" = \"enstorage34\".\"id\")) ");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if (qpfoFolioFiles_FolioId != 0) {
whereBuilder.Append("((\"enfoliofiles8\".\"folioid\" = @qpfoFolioFiles_FolioId) AND (\"enfoliofiles8\".\"folioid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolioFiles_FolioId", DbType.Int64, qpfoFolioFiles_FolioId);
} else {
whereBuilder.Append("(\"enfoliofiles8\".\"folioid\" IS NULL)");
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
RL_3a91e4d1ce6fecfc0c9a887200ab0325 outParamList = new RL_3a91e4d1ce6fecfc0c9a887200ab0325();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetFolioFilesReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, false, true, true, true});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_FolioFilesPreview.GetFolioFiles2.GetFolioFiles.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_3a91e4d1ce6fecfc0c9a887200ab0325 _tmp = new RL_3a91e4d1ce6fecfc0c9a887200ab0325();
_tmp.AlternateReadDbMethodAsync = datasetGetFolioFilesReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_FolioFilesPreview.GetFolioFiles2.GetFolioFiles.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_3a91e4d1ce6fecfc0c9a887200ab0325)_tmp;
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

private static async Task<RC_95ccc9074d33a4c760deaadf0253611a> datasetGetFolioByIdReadDbAsync(RC_95ccc9074d33a4c760deaadf0253611a rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFolio.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
return rec;
}
// Query Function "GetFolioById" QAQ6JMotw0ScIKrpnKPhRw of Action "GetFolioFiles2"
public static async Task<(RL_e2c4aba060d96fb21cd52a1f134b9b47,long)> datasetGetFolioById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolio_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("j_FoliosSAE.Wb_FolioFilesPreview.GetFolioFiles2.GetFolioById", "243a0440-2dca-44c3-9c20-aae99ca3e147");
using var queryActivity = activitySource.CreateAggregateQueryActivity("j_FoliosSAE.Wb_FolioFilesPreview.GetFolioFiles2.GetFolioById", "243a0440-2dca-44c3-9c20-aae99ca3e147", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.KZkCPzeOrE6ciI9e4OteIw/DataActions.BnIJPBAvrEqnyHxqAYjOdw/NodesNotShownInESpaceTree.QAQ6JMotw0ScIKrpnKPhRw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enfolio90\".\"id\" o0, \"enfolio90\".\"isdraft\" o1, \"enfolio90\".\"folionumber\" o2, \"enfolio90\".\"canproveedorcancel\" o3, \"enfolio90\".\"orderid\" o4, \"enfolio90\".\"supplierid\" o5, \"enfolio90\".\"companyid\" o6, \"enfolio90\".\"foliostatusid\" o7, trim_scale(\"enfolio90\".\"totalamount\"::numeric) o8, trim_scale(\"enfolio90\".\"totaliva_amount\"::numeric) o9, trim_scale(\"enfolio90\".\"partialamount\"::numeric) o10, \"enfolio90\".\"currencyid\" o11, \"enfolio90\".\"firstapproveruserid\" o12, \"enfolio90\".\"approvalprocesstypeid\" o13, \"enfolio90\".\"sapentryerror\" o14, \"enfolio90\".\"createdby\" o15, \"enfolio90\".\"createdon\" o16, \"enfolio90\".\"updatedby\" o17, \"enfolio90\".\"updatedon\" o18, \"enfolio90\".\"minuteselected\" o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, \"ensupplier136\".\"number\" o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76");
fromBuilder.Append(" FROM (({Folio} \"enfolio90\" Left JOIN {OrderMain} \"enordermain131\" ON (\"enfolio90\".\"orderid\" = \"enordermain131\".\"id\"))  Left JOIN {Supplier} \"ensupplier136\" ON (\"enfolio90\".\"supplierid\" = \"ensupplier136\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoFolio_Id != 0) {
whereBuilder.Append("((\"enfolio90\".\"id\" = @qpfoFolio_Id) AND (\"enfolio90\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolio_Id", DbType.Int64, qpfoFolio_Id);
} else {
whereBuilder.Append("(\"enfolio90\".\"id\" IS NULL)");
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
RL_e2c4aba060d96fb21cd52a1f134b9b47 outParamList = new RL_e2c4aba060d96fb21cd52a1f134b9b47();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetFolioByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_FolioFilesPreview.GetFolioFiles2.GetFolioById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_e2c4aba060d96fb21cd52a1f134b9b47 _tmp = new RL_e2c4aba060d96fb21cd52a1f134b9b47();
_tmp.AlternateReadDbMethodAsync = datasetGetFolioByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_FolioFilesPreview.GetFolioFiles2.GetFolioById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_e2c4aba060d96fb21cd52a1f134b9b47)_tmp;
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

private static async Task<RC_e89a3df29980b4bfe26cbaac4d2e6d26> datasetGetInvoicesByFolioIdReadDbAsync(RC_e89a3df29980b4bfe26cbaac4d2e6d26 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceFile.Read( r, ref index);
rec.ssENStorage.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
return rec;
}
// Query Function "GetInvoicesByFolioId" kI5HtqPMaECCDB_DRIeJmw of Action "GetFolioFiles2"
public static async Task<(RL_a18358ba225612b834f3458f070d11b3,long)> datasetGetInvoicesByFolioId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoInvoice_FolioId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("j_FoliosSAE.Wb_FolioFilesPreview.GetFolioFiles2.GetInvoicesByFolioId", "b6478e90-cca3-4068-820c-1fc34487899b");
using var queryActivity = activitySource.CreateAggregateQueryActivity("j_FoliosSAE.Wb_FolioFilesPreview.GetFolioFiles2.GetInvoicesByFolioId", "b6478e90-cca3-4068-820c-1fc34487899b", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.KZkCPzeOrE6ciI9e4OteIw/DataActions.BnIJPBAvrEqnyHxqAYjOdw/NodesNotShownInESpaceTree.kI5HtqPMaECCDB_DRIeJmw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoice150\".\"id\" o0, \"eninvoice150\".\"name\" o1, \"eninvoice150\".\"requisitionid\" o2, \"eninvoice150\".\"folioid\" o3, \"eninvoice150\".\"ordermainid\" o4, \"eninvoice150\".\"cfditypeid\" o5, trim_scale(\"eninvoice150\".\"totalamount\"::numeric) o6, \"eninvoice150\".\"currency\" o7, \"eninvoice150\".\"invoicestatusid\" o8, \"eninvoice150\".\"accountingdatetime\" o9, \"eninvoice150\".\"paymentdatetime\" o10, \"eninvoice150\".\"createdon\" o11, \"eninvoice150\".\"createdby\" o12, \"eninvoice150\".\"updatedon\" o13, \"eninvoice150\".\"updatedby\" o14, \"eninvoice150\".\"submittedon\" o15, \"eninvoice150\".\"isnewversion\" o16, \"eninvoice150\".\"id_poliza\" o17, \"eninvoice150\".\"id_poliza_sap\" o18, \"eninvoice150\".\"doc51\" o19, \"eninvoice150\".\"accountingerror\" o20, \"eninvoice150\".\"orderaccconceptsid\" o21, trim_scale(\"eninvoice150\".\"amortization\"::numeric) o22, \"eninvoice150\".\"creditnoteinvoiceid\" o23, \"eninvoicefile54\".\"id\" o24, \"eninvoicefile54\".\"invoiceid\" o25, \"eninvoicefile54\".\"filename\" o26, \"eninvoicefile54\".\"isextra\" o27, NULL o28, \"eninvoicefile54\".\"storageid\" o29, NULL o30, \"eninvoicefile54\".\"createdon\" o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, \"enstorage35\".\"size\" o50, NULL o51, NULL o52, \"enuser235\".\"name\" o53, NULL o54, NULL o55, NULL o56");
fromBuilder.Append(" FROM ((({Invoice} \"eninvoice150\" Inner JOIN {InvoiceFile} \"eninvoicefile54\" ON (\"eninvoice150\".\"id\" = \"eninvoicefile54\".\"invoiceid\"))  Left JOIN {User} \"enuser235\" ON (\"eninvoicefile54\".\"createdby\" = \"enuser235\".\"id\"))  Left JOIN {Storage} \"enstorage35\" ON (\"eninvoicefile54\".\"storageid\" = \"enstorage35\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoInvoice_FolioId != 0) {
whereBuilder.Append("((\"eninvoice150\".\"folioid\" = @qpfoInvoice_FolioId) AND (\"eninvoice150\".\"folioid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoInvoice_FolioId", DbType.Int64, qpfoInvoice_FolioId);
} else {
whereBuilder.Append("(\"eninvoice150\".\"folioid\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"eninvoice150\".\"name\" ASC ");
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
RL_a18358ba225612b834f3458f070d11b3 outParamList = new RL_a18358ba225612b834f3458f070d11b3();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoicesByFolioIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[4];
opt[0] = new BitArray(new bool[] {true, false, true, true, true});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[2] = new BitArray(new bool[] {false, false, false, false, true, false, true, false});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_FolioFilesPreview.GetFolioFiles2.GetInvoicesByFolioId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_a18358ba225612b834f3458f070d11b3 _tmp = new RL_a18358ba225612b834f3458f070d11b3();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoicesByFolioIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_FolioFilesPreview.GetFolioFiles2.GetInvoicesByFolioId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_a18358ba225612b834f3458f070d11b3)_tmp;
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

/// <summary>
/// JSONSerialize: JsonSerializeJSONSerialize1 (KHbVMi7g2ukOylFS8HHl7ew)  of Action "GetFolioFiles2"
/// </summary>
public static void JsonSerializeJSONSerialize1 (RL_e2f87228588c7237002d108caedf9018 inParamRecordList, out string outParamJSON) {
var config = new OutSystems.RESTService.Runtime.Abstractions.Controllers.BaseRestServiceControllerConfiguration() {
DefaultValuesBehavior = OutSystems.RESTService.Runtime.Abstractions.Behaviors.DefaultValuesBehavior.DontSend,
DateTimeFormat = OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO
};

var holder = inParamRecordList.ToArray<ssConectaProveedores.RestRecords.JSONST_6c0a0d3b1d72414f90bb9301bad200fbStructure>(ssConectaProveedores.RestRecords.JSONST_6c0a0d3b1d72414f90bb9301bad200fbStructure.FromStructureDelegate(config));
outParamJSON = Newtonsoft.Json.JsonConvert.SerializeObject(holder, config.SerializerSettings);

}

/// <summary>
/// JSONSerialize: JsonSerializeJSONSerialize2 (KAcuM8iXWNkmYIF6sEYzK_w)  of Action "GetFolioFiles2"
/// </summary>
public static void JsonSerializeJSONSerialize2 (RL_e2f87228588c7237002d108caedf9018 inParamRecordList, out string outParamJSON) {
var config = new OutSystems.RESTService.Runtime.Abstractions.Controllers.BaseRestServiceControllerConfiguration() {
DefaultValuesBehavior = OutSystems.RESTService.Runtime.Abstractions.Behaviors.DefaultValuesBehavior.DontSend,
DateTimeFormat = OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO
};

var holder = inParamRecordList.ToArray<ssConectaProveedores.RestRecords.JSONST_6c0a0d3b1d72414f90bb9301bad200fbStructure>(ssConectaProveedores.RestRecords.JSONST_6c0a0d3b1d72414f90bb9301bad200fbStructure.FromStructureDelegate(config));
outParamJSON = Newtonsoft.Json.JsonConvert.SerializeObject(holder, config.SerializerSettings);

}
}


}
