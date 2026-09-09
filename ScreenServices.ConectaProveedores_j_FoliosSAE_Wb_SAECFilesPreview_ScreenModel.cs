using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_j_FoliosSAE_Wb_SAECFilesPreview_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_j_FoliosSAE_Wb_SAECFilesPreview_ScreenModel).Namespace);

    public long inParami_FolioId;
public string inParami_FolioNumber;
public ST_a158c76eb93396680623c04244f48b6cStructure varLcl_File;
public bool varLcl_ShowPopupUpload;
public ConectaProveedores_j_FoliosSAE_Wb_SAECFilesPreview_DataActionGetFolioFiles_Model varLcGetFolioFiles;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_j_FoliosSAE_Wb_SAECFilesPreview_ScreenModel() {
}



    public ConectaProveedores_j_FoliosSAE_Wb_SAECFilesPreview_ScreenModel(long inParami_FolioId, string inParami_FolioNumber, ST_a158c76eb93396680623c04244f48b6cStructure varLcl_File, bool varLcl_ShowPopupUpload, ConectaProveedores_j_FoliosSAE_Wb_SAECFilesPreview_DataActionGetFolioFiles_Model varLcGetFolioFiles, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"i_FolioId", "i_FolioNumber", "l_File", "l_ShowPopupUpload", "GetFolioFiles", "ClientVars"}, new string[] {"inParami_FolioId", "inParami_FolioNumber", "varLcl_File", "varLcl_ShowPopupUpload", "varLcGetFolioFiles", "clientVariables"});
this.inParami_FolioId = inParami_FolioId;
this.inParami_FolioNumber = inParami_FolioNumber;
this.varLcl_File = varLcl_File;
this.varLcl_ShowPopupUpload = varLcl_ShowPopupUpload;
this.varLcGetFolioFiles = varLcGetFolioFiles;
this.clientVariables = clientVariables;
}



    

    public class lcvGetFolioFiles : VarsBag {
/// <summary>
/// Variable <code>FileJsonList</code> that represents the Service Studio FilesJsonList
///  <code>FileJsonList</code> <p>Description: </p>
/// </summary>
public RL_e2f87228588c7237002d108caedf9018 varLcFileJsonList = new RL_e2f87228588c7237002d108caedf9018();

public RL_3a91e4d1ce6fecfc0c9a887200ab0325 queryResGetFolioFilesByFolioId_outParamList = new RL_3a91e4d1ce6fecfc0c9a887200ab0325();
public long queryResGetFolioFilesByFolioId_outParamCount = 0L;

public RL_a18358ba225612b834f3458f070d11b3 resListFilterMain_outParamFilteredList = new RL_a18358ba225612b834f3458f070d11b3();

public Actions.lcoGetInvoiceFilesCreditNotes resGetInvoiceFilesCreditNotes2 =  new Actions.lcoGetInvoiceFilesCreditNotes();
public string resJSONSerialize2_outParamJSON = "";
public string resJSONSerialize1_outParamJSON = "";
public RL_a18358ba225612b834f3458f070d11b3 queryResGetInvoicesByFolioId_outParamList = new RL_a18358ba225612b834f3458f070d11b3();
public long queryResGetInvoicesByFolioId_outParamCount = 0L;

public RL_3a91e4d1ce6fecfc0c9a887200ab0325 resListFilterExtra2_outParamFilteredList = new RL_3a91e4d1ce6fecfc0c9a887200ab0325();

public RL_e2c4aba060d96fb21cd52a1f134b9b47 queryResGetFolioById_outParamList = new RL_e2c4aba060d96fb21cd52a1f134b9b47();
public long queryResGetFolioById_outParamCount = 0L;

public RL_a18358ba225612b834f3458f070d11b3 resListFilterExtra_outParamFilteredList = new RL_a18358ba225612b834f3458f070d11b3();

public RL_3a91e4d1ce6fecfc0c9a887200ab0325 resListFilterMain2_outParamFilteredList = new RL_3a91e4d1ce6fecfc0c9a887200ab0325();

public Actions.lcoGetInvoiceFilesCreditNotes resGetInvoiceFilesCreditNotes =  new Actions.lcoGetInvoiceFilesCreditNotes();
public RL_f3a656d1fdc6bd4ad6371c5743799e57 queryResGetInvoicesByFolioId2_outParamList = new RL_f3a656d1fdc6bd4ad6371c5743799e57();
public long queryResGetInvoicesByFolioId2_outParamCount = 0L;

public lcvGetFolioFiles() {
}
}
public class lcoGetFolioFiles : VarsBag {
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

public lcoGetFolioFiles() {
}
}
/// <summary>
/// Action <code>GetFolioFiles</code> that represents the Service Studio action
///  <code>GetFolioFiles</code> <p> Description: </p>
/// </summary>
public async Task<(RL_89dfc296578aaa53d7fbc0b8af34fb54,RL_89dfc296578aaa53d7fbc0b8af34fb54,RL_cc11123f1ba1bfd417e2f33be28138e9,RL_cc11123f1ba1bfd417e2f33be28138e9,bool,int,bool,long,EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord,string,EN_d1d0320db36efbb094ad0082361435a0EntityRecord,string)> DataActionGetFolioFiles(IRequestContext requestContext,CancellationToken cancellationToken) {
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
lcoGetFolioFiles result = new lcoGetFolioFiles();
lcvGetFolioFiles localVars = new lcvGetFolioFiles();
ConectaProveedores_j_FoliosSAE_Wb_SAECFilesPreview_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetFolioFiles", "9aa2808d-b131-4435-8ae2-0371e5d9e675"))
using (activitySource.CreateScreenDataActionActivity("Wb_SAECFilesPreview", "GetFolioFiles")){
// Query datasetGetFolioById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioById_maxRecords = 0;
int datasetGetFolioById_startIndex = 0;(localVars.queryResGetFolioById_outParamList,localVars.queryResGetFolioById_outParamCount) = await FuncDataActionGetFolioFiles.datasetGetFolioById(requestContext,datasetGetFolioById_maxRecords,datasetGetFolioById_startIndex,IterationMultiplicity.Never,inParami_FolioId,cancellationToken);

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
int datasetGetInvoicesByFolioId2_startIndex = 0;(localVars.queryResGetInvoicesByFolioId2_outParamList,localVars.queryResGetInvoicesByFolioId2_outParamCount) = await FuncDataActionGetFolioFiles.datasetGetInvoicesByFolioId2(requestContext,datasetGetInvoicesByFolioId2_maxRecords,datasetGetInvoicesByFolioId2_startIndex,IterationMultiplicity.Multiple,inParami_FolioId,cancellationToken);

// Query datasetGetFolioFilesByFolioId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioFilesByFolioId_maxRecords = 500;
if (datasetGetFolioFilesByFolioId_maxRecords < 1) datasetGetFolioFilesByFolioId_maxRecords = 1;
int datasetGetFolioFilesByFolioId_startIndex = 0;(localVars.queryResGetFolioFilesByFolioId_outParamList,localVars.queryResGetFolioFilesByFolioId_outParamCount) = await FuncDataActionGetFolioFiles.datasetGetFolioFilesByFolioId(requestContext,datasetGetFolioFilesByFolioId_maxRecords,datasetGetFolioFilesByFolioId_startIndex,IterationMultiplicity.Multiple,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),inParami_FolioId,cancellationToken);

// ListFilterMain2
localVars.resListFilterMain2_outParamFilteredList = (((RL_3a91e4d1ce6fecfc0c9a887200ab0325)await  localVars.queryResGetFolioFilesByFolioId_outParamList.FilterAsync(async (p, cancellationToken) => (!p.ssENFolioFiles.ssIsExtra), cancellationToken)));

// ListFilterExtra2
localVars.resListFilterExtra2_outParamFilteredList = (((RL_3a91e4d1ce6fecfc0c9a887200ab0325)await  localVars.queryResGetFolioFilesByFolioId_outParamList.FilterAsync(async (p, cancellationToken) => p.ssENFolioFiles.ssIsExtra, cancellationToken)));

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
FuncDataActionGetFolioFiles.JsonSerializeJSONSerialize1(localVars.varLcFileJsonList, out localVars.resJSONSerialize1_outParamJSON);
// FilesForDownload = JSONSerialize1.JSON
result.outParamFilesForDownload=localVars.resJSONSerialize1_outParamJSON;
} else {
// Query datasetGetInvoicesByFolioId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoicesByFolioId_maxRecords = 999999999;
if (datasetGetInvoicesByFolioId_maxRecords < 1) datasetGetInvoicesByFolioId_maxRecords = 1;
int datasetGetInvoicesByFolioId_startIndex = 0;(localVars.queryResGetInvoicesByFolioId_outParamList,localVars.queryResGetInvoicesByFolioId_outParamCount) = await FuncDataActionGetFolioFiles.datasetGetInvoicesByFolioId(requestContext,datasetGetInvoicesByFolioId_maxRecords,datasetGetInvoicesByFolioId_startIndex,IterationMultiplicity.Multiple,inParami_FolioId,cancellationToken);

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
FuncDataActionGetFolioFiles.JsonSerializeJSONSerialize2(localVars.varLcFileJsonList, out localVars.resJSONSerialize2_outParamJSON);
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


    public static class FuncDataActionGetFolioFiles {

private static async Task<RC_524c288faf455ce3a30a531f7ff5854e> datasetGetFolioFilesByFolioIdReadDbAsync(RC_524c288faf455ce3a30a531f7ff5854e rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFolioFiles.Read( r, ref index);
rec.ssENStorage.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
return rec;
}
// Query Function "GetFolioFilesByFolioId" pBOwFFgi7kaW+uJabldBPA of Action "GetFolioFiles"
public static async Task<(RL_3a91e4d1ce6fecfc0c9a887200ab0325,long)> datasetGetFolioFilesByFolioId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,long qpfoFolioFiles_FolioId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("j_FoliosSAE.Wb_SAECFilesPreview.GetFolioFiles.GetFolioFilesByFolioId", "14b013a4-2258-46ee-96fa-e25a6e57413c");
using var queryActivity = activitySource.CreateAggregateQueryActivity("j_FoliosSAE.Wb_SAECFilesPreview.GetFolioFiles.GetFolioFilesByFolioId", "14b013a4-2258-46ee-96fa-e25a6e57413c", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.2TvyYk_qV0634AuMwu4VWQ/DataActions.jYCimjGxNUSK4gNx5dnmdQ/NodesNotShownInESpaceTree.pBOwFFgi7kaW+uJabldBPA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enfoliofiles10\".\"id\" o0, \"enfoliofiles10\".\"filename\" o1, \"enfoliofiles10\".\"folioid\" o2, \"enfoliofiles10\".\"isextra\" o3, \"enfoliofiles10\".\"storageid\" o4, \"enfoliofiles10\".\"createdby\" o5, \"enfoliofiles10\".\"createdon\" o6, \"enfoliofiles10\".\"isnewfile\" o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, \"enstorage37\".\"size\" o26, NULL o27, NULL o28, \"enuser236\".\"name\" o29, NULL o30, NULL o31, NULL o32");
fromBuilder.Append(" FROM (({FolioFiles} \"enfoliofiles10\" Inner JOIN {User} \"enuser236\" ON (\"enfoliofiles10\".\"createdby\" = \"enuser236\".\"id\"))  Left JOIN {Storage} \"enstorage37\" ON (\"enfoliofiles10\".\"storageid\" = \"enstorage37\".\"id\")) ");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if (qpfoFolioFiles_FolioId != 0) {
whereBuilder.Append("((\"enfoliofiles10\".\"folioid\" = @qpfoFolioFiles_FolioId) AND (\"enfoliofiles10\".\"folioid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolioFiles_FolioId", DbType.Int64, qpfoFolioFiles_FolioId);
} else {
whereBuilder.Append("(\"enfoliofiles10\".\"folioid\" IS NULL)");
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
outParamList.AlternateReadDbMethodAsync = datasetGetFolioFilesByFolioIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, false, true, true, true});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_SAECFilesPreview.GetFolioFiles.GetFolioFilesByFolioId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_3a91e4d1ce6fecfc0c9a887200ab0325 _tmp = new RL_3a91e4d1ce6fecfc0c9a887200ab0325();
_tmp.AlternateReadDbMethodAsync = datasetGetFolioFilesByFolioIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_SAECFilesPreview.GetFolioFiles.GetFolioFilesByFolioId.List", cancellationToken: cancellationToken);
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

private static async Task<RC_e89a3df29980b4bfe26cbaac4d2e6d26> datasetGetInvoicesByFolioIdReadDbAsync(RC_e89a3df29980b4bfe26cbaac4d2e6d26 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceFile.Read( r, ref index);
rec.ssENStorage.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
return rec;
}
// Query Function "GetInvoicesByFolioId" WtplhLoKLEiIjh8cuITOpQ of Action "GetFolioFiles"
public static async Task<(RL_a18358ba225612b834f3458f070d11b3,long)> datasetGetInvoicesByFolioId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoInvoice_FolioId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("j_FoliosSAE.Wb_SAECFilesPreview.GetFolioFiles.GetInvoicesByFolioId", "8465da5a-0aba-482c-888e-1f1cb884cea5");
using var queryActivity = activitySource.CreateAggregateQueryActivity("j_FoliosSAE.Wb_SAECFilesPreview.GetFolioFiles.GetInvoicesByFolioId", "8465da5a-0aba-482c-888e-1f1cb884cea5", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.2TvyYk_qV0634AuMwu4VWQ/DataActions.jYCimjGxNUSK4gNx5dnmdQ/NodesNotShownInESpaceTree.WtplhLoKLEiIjh8cuITOpQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoice153\".\"id\" o0, \"eninvoice153\".\"name\" o1, \"eninvoice153\".\"requisitionid\" o2, \"eninvoice153\".\"folioid\" o3, \"eninvoice153\".\"ordermainid\" o4, \"eninvoice153\".\"cfditypeid\" o5, trim_scale(\"eninvoice153\".\"totalamount\"::numeric) o6, \"eninvoice153\".\"currency\" o7, \"eninvoice153\".\"invoicestatusid\" o8, \"eninvoice153\".\"accountingdatetime\" o9, \"eninvoice153\".\"paymentdatetime\" o10, \"eninvoice153\".\"createdon\" o11, \"eninvoice153\".\"createdby\" o12, \"eninvoice153\".\"updatedon\" o13, \"eninvoice153\".\"updatedby\" o14, \"eninvoice153\".\"submittedon\" o15, \"eninvoice153\".\"isnewversion\" o16, \"eninvoice153\".\"id_poliza\" o17, \"eninvoice153\".\"id_poliza_sap\" o18, \"eninvoice153\".\"doc51\" o19, \"eninvoice153\".\"accountingerror\" o20, \"eninvoice153\".\"orderaccconceptsid\" o21, trim_scale(\"eninvoice153\".\"amortization\"::numeric) o22, \"eninvoice153\".\"creditnoteinvoiceid\" o23, \"eninvoicefile56\".\"id\" o24, \"eninvoicefile56\".\"invoiceid\" o25, \"eninvoicefile56\".\"filename\" o26, \"eninvoicefile56\".\"isextra\" o27, NULL o28, \"eninvoicefile56\".\"storageid\" o29, NULL o30, \"eninvoicefile56\".\"createdon\" o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, \"enstorage38\".\"size\" o50, NULL o51, NULL o52, \"enuser237\".\"name\" o53, NULL o54, NULL o55, NULL o56");
fromBuilder.Append(" FROM ((({Invoice} \"eninvoice153\" Inner JOIN {InvoiceFile} \"eninvoicefile56\" ON (\"eninvoice153\".\"id\" = \"eninvoicefile56\".\"invoiceid\"))  Left JOIN {User} \"enuser237\" ON (\"eninvoicefile56\".\"createdby\" = \"enuser237\".\"id\"))  Left JOIN {Storage} \"enstorage38\" ON (\"eninvoicefile56\".\"storageid\" = \"enstorage38\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoInvoice_FolioId != 0) {
whereBuilder.Append("((\"eninvoice153\".\"folioid\" = @qpfoInvoice_FolioId) AND (\"eninvoice153\".\"folioid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoInvoice_FolioId", DbType.Int64, qpfoInvoice_FolioId);
} else {
whereBuilder.Append("(\"eninvoice153\".\"folioid\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"eninvoice153\".\"name\" ASC ");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_SAECFilesPreview.GetFolioFiles.GetInvoicesByFolioId.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_SAECFilesPreview.GetFolioFiles.GetInvoicesByFolioId.List", cancellationToken: cancellationToken);
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

private static async Task<RC_95ccc9074d33a4c760deaadf0253611a> datasetGetFolioByIdReadDbAsync(RC_95ccc9074d33a4c760deaadf0253611a rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFolio.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
return rec;
}
// Query Function "GetFolioById" eRJZsmlat0mrhAhb3msCLQ of Action "GetFolioFiles"
public static async Task<(RL_e2c4aba060d96fb21cd52a1f134b9b47,long)> datasetGetFolioById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolio_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("j_FoliosSAE.Wb_SAECFilesPreview.GetFolioFiles.GetFolioById", "b2591279-5a69-49b7-ab84-085bde6b022d");
using var queryActivity = activitySource.CreateAggregateQueryActivity("j_FoliosSAE.Wb_SAECFilesPreview.GetFolioFiles.GetFolioById", "b2591279-5a69-49b7-ab84-085bde6b022d", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.2TvyYk_qV0634AuMwu4VWQ/DataActions.jYCimjGxNUSK4gNx5dnmdQ/NodesNotShownInESpaceTree.eRJZsmlat0mrhAhb3msCLQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enfolio93\".\"id\" o0, \"enfolio93\".\"isdraft\" o1, \"enfolio93\".\"folionumber\" o2, \"enfolio93\".\"canproveedorcancel\" o3, \"enfolio93\".\"orderid\" o4, \"enfolio93\".\"supplierid\" o5, \"enfolio93\".\"companyid\" o6, \"enfolio93\".\"foliostatusid\" o7, trim_scale(\"enfolio93\".\"totalamount\"::numeric) o8, trim_scale(\"enfolio93\".\"totaliva_amount\"::numeric) o9, trim_scale(\"enfolio93\".\"partialamount\"::numeric) o10, \"enfolio93\".\"currencyid\" o11, \"enfolio93\".\"firstapproveruserid\" o12, \"enfolio93\".\"approvalprocesstypeid\" o13, \"enfolio93\".\"sapentryerror\" o14, \"enfolio93\".\"createdby\" o15, \"enfolio93\".\"createdon\" o16, \"enfolio93\".\"updatedby\" o17, \"enfolio93\".\"updatedon\" o18, \"enfolio93\".\"minuteselected\" o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, \"ensupplier140\".\"number\" o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76");
fromBuilder.Append(" FROM (({Folio} \"enfolio93\" Left JOIN {OrderMain} \"enordermain134\" ON (\"enfolio93\".\"orderid\" = \"enordermain134\".\"id\"))  Left JOIN {Supplier} \"ensupplier140\" ON (\"enfolio93\".\"supplierid\" = \"ensupplier140\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoFolio_Id != 0) {
whereBuilder.Append("((\"enfolio93\".\"id\" = @qpfoFolio_Id) AND (\"enfolio93\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolio_Id", DbType.Int64, qpfoFolio_Id);
} else {
whereBuilder.Append("(\"enfolio93\".\"id\" IS NULL)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_SAECFilesPreview.GetFolioFiles.GetFolioById.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_SAECFilesPreview.GetFolioFiles.GetFolioById.List", cancellationToken: cancellationToken);
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

private static async Task<RC_f5e20bd4e0a7c754f3e99b7ff28d38d9> datasetGetInvoicesByFolioId2ReadDbAsync(RC_f5e20bd4e0a7c754f3e99b7ff28d38d9 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceFile.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
return rec;
}
// Query Function "GetInvoicesByFolioId2" FM6l9L_zUE20DM9F6CBJuw of Action "GetFolioFiles"
public static async Task<(RL_f3a656d1fdc6bd4ad6371c5743799e57,long)> datasetGetInvoicesByFolioId2(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoInvoice_FolioId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("j_FoliosSAE.Wb_SAECFilesPreview.GetFolioFiles.GetInvoicesByFolioId2", "f4a5ce14-f3bf-4d50-b40c-cf45e82049bb");
using var queryActivity = activitySource.CreateAggregateQueryActivity("j_FoliosSAE.Wb_SAECFilesPreview.GetFolioFiles.GetInvoicesByFolioId2", "f4a5ce14-f3bf-4d50-b40c-cf45e82049bb", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.2TvyYk_qV0634AuMwu4VWQ/DataActions.jYCimjGxNUSK4gNx5dnmdQ/NodesNotShownInESpaceTree.FM6l9L_zUE20DM9F6CBJuw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoice154\".\"id\" o0, NULL o1, NULL o2, \"eninvoice154\".\"folioid\" o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, \"eninvoice154\".\"doc51\" o19, NULL o20, NULL o21, NULL o22, \"eninvoice154\".\"creditnoteinvoiceid\" o23, NULL o24, NULL o25, \"eninvoicefile57\".\"filename\" o26, \"eninvoicefile57\".\"isextra\" o27, NULL o28, \"eninvoicefile57\".\"storageid\" o29, \"eninvoicefile57\".\"createdby\" o30, \"eninvoicefile57\".\"createdon\" o31, \"enuser238\".\"id\" o32, \"enuser238\".\"name\" o33, \"enuser238\".\"email\" o34, \"enuser238\".\"photourl\" o35, \"enuser238\".\"username\" o36");
fromBuilder.Append(" FROM (({Invoice} \"eninvoice154\" Inner JOIN {InvoiceFile} \"eninvoicefile57\" ON (\"eninvoice154\".\"id\" = \"eninvoicefile57\".\"invoiceid\"))  Left JOIN {User} \"enuser238\" ON (\"eninvoicefile57\".\"createdby\" = \"enuser238\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoInvoice_FolioId != 0) {
whereBuilder.Append("((\"eninvoice154\".\"folioid\" = @qpfoInvoice_FolioId) AND (\"eninvoice154\".\"folioid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoInvoice_FolioId", DbType.Int64, qpfoInvoice_FolioId);
} else {
whereBuilder.Append("(\"eninvoice154\".\"folioid\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"eninvoice154\".\"name\" ASC ");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_SAECFilesPreview.GetFolioFiles.GetInvoicesByFolioId2.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_SAECFilesPreview.GetFolioFiles.GetInvoicesByFolioId2.List", cancellationToken: cancellationToken);
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

/// <summary>
/// JSONSerialize: JsonSerializeJSONSerialize2 (KRUv7WPIcY02E36_UPPr_2g)  of Action "GetFolioFiles"
/// </summary>
public static void JsonSerializeJSONSerialize2 (RL_e2f87228588c7237002d108caedf9018 inParamRecordList, out string outParamJSON) {
var config = new OutSystems.RESTService.Runtime.Abstractions.Controllers.BaseRestServiceControllerConfiguration() {
DefaultValuesBehavior = OutSystems.RESTService.Runtime.Abstractions.Behaviors.DefaultValuesBehavior.DontSend,
DateTimeFormat = OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO
};

var holder = inParamRecordList.ToArray<ssConectaProveedores.RestRecords.JSONST_6c0a0d3b1d72414f90bb9301bad200fbStructure>(ssConectaProveedores.RestRecords.JSONST_6c0a0d3b1d72414f90bb9301bad200fbStructure.FromStructureDelegate(config));
outParamJSON = Newtonsoft.Json.JsonConvert.SerializeObject(holder, config.SerializerSettings);

}

/// <summary>
/// JSONSerialize: JsonSerializeJSONSerialize1 (K5p3WcpJE40qMOlqsgCDC1Q)  of Action "GetFolioFiles"
/// </summary>
public static void JsonSerializeJSONSerialize1 (RL_e2f87228588c7237002d108caedf9018 inParamRecordList, out string outParamJSON) {
var config = new OutSystems.RESTService.Runtime.Abstractions.Controllers.BaseRestServiceControllerConfiguration() {
DefaultValuesBehavior = OutSystems.RESTService.Runtime.Abstractions.Behaviors.DefaultValuesBehavior.DontSend,
DateTimeFormat = OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO
};

var holder = inParamRecordList.ToArray<ssConectaProveedores.RestRecords.JSONST_6c0a0d3b1d72414f90bb9301bad200fbStructure>(ssConectaProveedores.RestRecords.JSONST_6c0a0d3b1d72414f90bb9301bad200fbStructure.FromStructureDelegate(config));
outParamJSON = Newtonsoft.Json.JsonConvert.SerializeObject(holder, config.SerializerSettings);

}
}


}
