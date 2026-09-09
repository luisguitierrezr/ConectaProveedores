using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_Wb_FolioFilesPreview_DataActionGetFolioFiles2_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("FolioMainFiles")]
public RestList<ssConectaProveedores.RestRecords.RESTST_a23a10e9592e51ca9ffbbbc42c558496Structure> outParamFolioMainFiles;
[JsonProperty("FolioExtraFiles")]
public RestList<ssConectaProveedores.RestRecords.RESTST_a23a10e9592e51ca9ffbbbc42c558496Structure> outParamFolioExtraFiles;
[JsonProperty("InvoiceMainFiles")]
public RestList<ssConectaProveedores.RestRecords.RESTST_d381fba44897ce4382b17d5149465d51Structure> outParamInvoiceMainFiles;
[JsonProperty("InvoiceExtraFiles")]
public RestList<ssConectaProveedores.RestRecords.RESTST_d381fba44897ce4382b17d5149465d51Structure> outParamInvoiceExtraFiles;
[JsonProperty("IsConstruction")]
public bool? outParamIsConstruction;
[JsonProperty("FolioStatusId")]
public int? outParamFolioStatusId;
[JsonProperty("CanSupplierChange")]
public bool? outParamCanSupplierChange;
[JsonProperty("InvoiceID")]
public long? outParamInvoiceID;
[JsonProperty("Folio")]
public ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord outParamFolio;
[JsonProperty("SupplierNumber")]
public string outParamSupplierNumber;
[JsonProperty("Invoice")]
public ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord outParamInvoice;
[JsonProperty("FilesForDownload")]
public string outParamFilesForDownload;


    public static RESTConectaProveedores_j_FoliosSAE_Wb_FolioFilesPreview_DataActionGetFolioFiles2_Outputs FromOutputs(IBehaviorsConfiguration conf, RL_89dfc296578aaa53d7fbc0b8af34fb54 outParamFolioMainFiles, RL_89dfc296578aaa53d7fbc0b8af34fb54 outParamFolioExtraFiles, RL_cc11123f1ba1bfd417e2f33be28138e9 outParamInvoiceMainFiles, RL_cc11123f1ba1bfd417e2f33be28138e9 outParamInvoiceExtraFiles, bool outParamIsConstruction, int outParamFolioStatusId, bool outParamCanSupplierChange, long outParamInvoiceID, EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord outParamFolio, string outParamSupplierNumber, EN_d1d0320db36efbb094ad0082361435a0EntityRecord outParamInvoice, string outParamFilesForDownload) {RESTConectaProveedores_j_FoliosSAE_Wb_FolioFilesPreview_DataActionGetFolioFiles2_Outputs result = new RESTConectaProveedores_j_FoliosSAE_Wb_FolioFilesPreview_DataActionGetFolioFiles2_Outputs();
// Write the needed fields of the list outParamFolioMainFiles to the result.outParamFolioMainFiles
ssConectaProveedores.RestRecords.RESTST_a23a10e9592e51ca9ffbbbc42c558496Structure tmpoutParamFolioMainFilesElement;
if(outParamFolioMainFiles.Empty) {
// Write the needed fields of the record outParamFolioMainFiles.CurrentRec to the tmpoutParamFolioMainFilesElement
tmpoutParamFolioMainFilesElement = new ssConectaProveedores.RestRecords.RESTST_a23a10e9592e51ca9ffbbbc42c558496Structure();
// Write optimized tmpoutParamFolioMainFilesElement.AttrId
tmpoutParamFolioMainFilesElement.AttrId = (long?) 0L;
tmpoutParamFolioMainFilesElement.AttrFilename = outParamFolioMainFiles.CurrentRec.ssFilename;
// Write optimized tmpoutParamFolioMainFilesElement.AttrFolioId
tmpoutParamFolioMainFilesElement.AttrFolioId = (long?) 0L;
// Write optimized tmpoutParamFolioMainFilesElement.AttrIsExtra
tmpoutParamFolioMainFilesElement.AttrIsExtra = (bool?) false;
tmpoutParamFolioMainFilesElement.AttrStorageId = (long?) outParamFolioMainFiles.CurrentRec.ssStorageId;
// Write optimized tmpoutParamFolioMainFilesElement.AttrCreatedBy
tmpoutParamFolioMainFilesElement.AttrCreatedBy = "";
tmpoutParamFolioMainFilesElement.AttrCreatedByName = outParamFolioMainFiles.CurrentRec.ssCreatedByName;
tmpoutParamFolioMainFilesElement.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(outParamFolioMainFiles.CurrentRec.ssCreatedOn, conf.DateTimeFormat);
tmpoutParamFolioMainFilesElement.AttrSize = (long?) outParamFolioMainFiles.CurrentRec.ssSize;
tmpoutParamFolioMainFilesElement.AttrIsNewFile = (bool?) outParamFolioMainFiles.CurrentRec.ssIsNewFile;
result.outParamFolioMainFiles = new RestList<ssConectaProveedores.RestRecords.RESTST_a23a10e9592e51ca9ffbbbc42c558496Structure>(new ssConectaProveedores.RestRecords.RESTST_a23a10e9592e51ca9ffbbbc42c558496Structure[] {}, tmpoutParamFolioMainFilesElement);
} else {
List<ssConectaProveedores.RestRecords.RESTST_a23a10e9592e51ca9ffbbbc42c558496Structure>
 tmpoutParamFolioMainFiles1List = new List<ssConectaProveedores.RestRecords.RESTST_a23a10e9592e51ca9ffbbbc42c558496Structure>
();
try {outParamFolioMainFiles.StartIteration();
while (!(outParamFolioMainFiles.Eof)) {
// Write the needed fields of the record outParamFolioMainFiles.CurrentRec to the tmpoutParamFolioMainFilesElement
tmpoutParamFolioMainFilesElement = new ssConectaProveedores.RestRecords.RESTST_a23a10e9592e51ca9ffbbbc42c558496Structure();
// Write optimized tmpoutParamFolioMainFilesElement.AttrId
tmpoutParamFolioMainFilesElement.AttrId = (long?) 0L;
tmpoutParamFolioMainFilesElement.AttrFilename = outParamFolioMainFiles.CurrentRec.ssFilename;
// Write optimized tmpoutParamFolioMainFilesElement.AttrFolioId
tmpoutParamFolioMainFilesElement.AttrFolioId = (long?) 0L;
// Write optimized tmpoutParamFolioMainFilesElement.AttrIsExtra
tmpoutParamFolioMainFilesElement.AttrIsExtra = (bool?) false;
tmpoutParamFolioMainFilesElement.AttrStorageId = (long?) outParamFolioMainFiles.CurrentRec.ssStorageId;
// Write optimized tmpoutParamFolioMainFilesElement.AttrCreatedBy
tmpoutParamFolioMainFilesElement.AttrCreatedBy = "";
tmpoutParamFolioMainFilesElement.AttrCreatedByName = outParamFolioMainFiles.CurrentRec.ssCreatedByName;
tmpoutParamFolioMainFilesElement.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(outParamFolioMainFiles.CurrentRec.ssCreatedOn, conf.DateTimeFormat);
tmpoutParamFolioMainFilesElement.AttrSize = (long?) outParamFolioMainFiles.CurrentRec.ssSize;
tmpoutParamFolioMainFilesElement.AttrIsNewFile = (bool?) outParamFolioMainFiles.CurrentRec.ssIsNewFile;
tmpoutParamFolioMainFiles1List.Add(tmpoutParamFolioMainFilesElement);
outParamFolioMainFiles.Advance();
}

} finally {
outParamFolioMainFiles.EndIteration();
}

result.outParamFolioMainFiles = new RestList<ssConectaProveedores.RestRecords.RESTST_a23a10e9592e51ca9ffbbbc42c558496Structure>(tmpoutParamFolioMainFiles1List.ToArray(), default(ssConectaProveedores.RestRecords.RESTST_a23a10e9592e51ca9ffbbbc42c558496Structure));
}

// Write the needed fields of the list outParamFolioExtraFiles to the result.outParamFolioExtraFiles
ssConectaProveedores.RestRecords.RESTST_a23a10e9592e51ca9ffbbbc42c558496Structure tmpoutParamFolioExtraFilesElement;
if(outParamFolioExtraFiles.Empty) {
// Write the needed fields of the record outParamFolioExtraFiles.CurrentRec to the tmpoutParamFolioExtraFilesElement
tmpoutParamFolioExtraFilesElement = new ssConectaProveedores.RestRecords.RESTST_a23a10e9592e51ca9ffbbbc42c558496Structure();
// Write optimized tmpoutParamFolioExtraFilesElement.AttrId
tmpoutParamFolioExtraFilesElement.AttrId = (long?) 0L;
tmpoutParamFolioExtraFilesElement.AttrFilename = outParamFolioExtraFiles.CurrentRec.ssFilename;
// Write optimized tmpoutParamFolioExtraFilesElement.AttrFolioId
tmpoutParamFolioExtraFilesElement.AttrFolioId = (long?) 0L;
// Write optimized tmpoutParamFolioExtraFilesElement.AttrIsExtra
tmpoutParamFolioExtraFilesElement.AttrIsExtra = (bool?) false;
tmpoutParamFolioExtraFilesElement.AttrStorageId = (long?) outParamFolioExtraFiles.CurrentRec.ssStorageId;
// Write optimized tmpoutParamFolioExtraFilesElement.AttrCreatedBy
tmpoutParamFolioExtraFilesElement.AttrCreatedBy = "";
tmpoutParamFolioExtraFilesElement.AttrCreatedByName = outParamFolioExtraFiles.CurrentRec.ssCreatedByName;
tmpoutParamFolioExtraFilesElement.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(outParamFolioExtraFiles.CurrentRec.ssCreatedOn, conf.DateTimeFormat);
tmpoutParamFolioExtraFilesElement.AttrSize = (long?) outParamFolioExtraFiles.CurrentRec.ssSize;
tmpoutParamFolioExtraFilesElement.AttrIsNewFile = (bool?) outParamFolioExtraFiles.CurrentRec.ssIsNewFile;
result.outParamFolioExtraFiles = new RestList<ssConectaProveedores.RestRecords.RESTST_a23a10e9592e51ca9ffbbbc42c558496Structure>(new ssConectaProveedores.RestRecords.RESTST_a23a10e9592e51ca9ffbbbc42c558496Structure[] {}, tmpoutParamFolioExtraFilesElement);
} else {
List<ssConectaProveedores.RestRecords.RESTST_a23a10e9592e51ca9ffbbbc42c558496Structure>
 tmpoutParamFolioExtraFiles1List = new List<ssConectaProveedores.RestRecords.RESTST_a23a10e9592e51ca9ffbbbc42c558496Structure>
();
try {outParamFolioExtraFiles.StartIteration();
while (!(outParamFolioExtraFiles.Eof)) {
// Write the needed fields of the record outParamFolioExtraFiles.CurrentRec to the tmpoutParamFolioExtraFilesElement
tmpoutParamFolioExtraFilesElement = new ssConectaProveedores.RestRecords.RESTST_a23a10e9592e51ca9ffbbbc42c558496Structure();
// Write optimized tmpoutParamFolioExtraFilesElement.AttrId
tmpoutParamFolioExtraFilesElement.AttrId = (long?) 0L;
tmpoutParamFolioExtraFilesElement.AttrFilename = outParamFolioExtraFiles.CurrentRec.ssFilename;
// Write optimized tmpoutParamFolioExtraFilesElement.AttrFolioId
tmpoutParamFolioExtraFilesElement.AttrFolioId = (long?) 0L;
// Write optimized tmpoutParamFolioExtraFilesElement.AttrIsExtra
tmpoutParamFolioExtraFilesElement.AttrIsExtra = (bool?) false;
tmpoutParamFolioExtraFilesElement.AttrStorageId = (long?) outParamFolioExtraFiles.CurrentRec.ssStorageId;
// Write optimized tmpoutParamFolioExtraFilesElement.AttrCreatedBy
tmpoutParamFolioExtraFilesElement.AttrCreatedBy = "";
tmpoutParamFolioExtraFilesElement.AttrCreatedByName = outParamFolioExtraFiles.CurrentRec.ssCreatedByName;
tmpoutParamFolioExtraFilesElement.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(outParamFolioExtraFiles.CurrentRec.ssCreatedOn, conf.DateTimeFormat);
tmpoutParamFolioExtraFilesElement.AttrSize = (long?) outParamFolioExtraFiles.CurrentRec.ssSize;
tmpoutParamFolioExtraFilesElement.AttrIsNewFile = (bool?) outParamFolioExtraFiles.CurrentRec.ssIsNewFile;
tmpoutParamFolioExtraFiles1List.Add(tmpoutParamFolioExtraFilesElement);
outParamFolioExtraFiles.Advance();
}

} finally {
outParamFolioExtraFiles.EndIteration();
}

result.outParamFolioExtraFiles = new RestList<ssConectaProveedores.RestRecords.RESTST_a23a10e9592e51ca9ffbbbc42c558496Structure>(tmpoutParamFolioExtraFiles1List.ToArray(), default(ssConectaProveedores.RestRecords.RESTST_a23a10e9592e51ca9ffbbbc42c558496Structure));
}

// Write the needed fields of the list outParamInvoiceMainFiles to the result.outParamInvoiceMainFiles
ssConectaProveedores.RestRecords.RESTST_d381fba44897ce4382b17d5149465d51Structure tmpoutParamInvoiceMainFilesElement;
if(outParamInvoiceMainFiles.Empty) {
// Write the needed fields of the record outParamInvoiceMainFiles.CurrentRec to the tmpoutParamInvoiceMainFilesElement
tmpoutParamInvoiceMainFilesElement = new ssConectaProveedores.RestRecords.RESTST_d381fba44897ce4382b17d5149465d51Structure();
// Write optimized tmpoutParamInvoiceMainFilesElement.AttrId
tmpoutParamInvoiceMainFilesElement.AttrId = (long?) 0L;
// Write optimized tmpoutParamInvoiceMainFilesElement.AttrInvoiceId
tmpoutParamInvoiceMainFilesElement.AttrInvoiceId = (long?) 0L;
tmpoutParamInvoiceMainFilesElement.AttrFilename = outParamInvoiceMainFiles.CurrentRec.ssFilename;
// Write optimized tmpoutParamInvoiceMainFilesElement.AttrIsExtra
tmpoutParamInvoiceMainFilesElement.AttrIsExtra = (bool?) false;
tmpoutParamInvoiceMainFilesElement.AttrStorageId = (long?) outParamInvoiceMainFiles.CurrentRec.ssStorageId;
tmpoutParamInvoiceMainFilesElement.AttrCreatedByName = outParamInvoiceMainFiles.CurrentRec.ssCreatedByName;
// Write optimized tmpoutParamInvoiceMainFilesElement.AttrCreatedBy
tmpoutParamInvoiceMainFilesElement.AttrCreatedBy = "";
tmpoutParamInvoiceMainFilesElement.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(outParamInvoiceMainFiles.CurrentRec.ssCreatedOn, conf.DateTimeFormat);
// Write optimized tmpoutParamInvoiceMainFilesElement.AttrInvoiceStatusLabel
tmpoutParamInvoiceMainFilesElement.AttrInvoiceStatusLabel = "";
// Write optimized tmpoutParamInvoiceMainFilesElement.AttrInvoiceStatusClass
tmpoutParamInvoiceMainFilesElement.AttrInvoiceStatusClass = "";
tmpoutParamInvoiceMainFilesElement.AttrSize = (long?) outParamInvoiceMainFiles.CurrentRec.ssSize;
result.outParamInvoiceMainFiles = new RestList<ssConectaProveedores.RestRecords.RESTST_d381fba44897ce4382b17d5149465d51Structure>(new ssConectaProveedores.RestRecords.RESTST_d381fba44897ce4382b17d5149465d51Structure[] {}, tmpoutParamInvoiceMainFilesElement);
} else {
List<ssConectaProveedores.RestRecords.RESTST_d381fba44897ce4382b17d5149465d51Structure>
 tmpoutParamInvoiceMainFiles1List = new List<ssConectaProveedores.RestRecords.RESTST_d381fba44897ce4382b17d5149465d51Structure>
();
try {outParamInvoiceMainFiles.StartIteration();
while (!(outParamInvoiceMainFiles.Eof)) {
// Write the needed fields of the record outParamInvoiceMainFiles.CurrentRec to the tmpoutParamInvoiceMainFilesElement
tmpoutParamInvoiceMainFilesElement = new ssConectaProveedores.RestRecords.RESTST_d381fba44897ce4382b17d5149465d51Structure();
// Write optimized tmpoutParamInvoiceMainFilesElement.AttrId
tmpoutParamInvoiceMainFilesElement.AttrId = (long?) 0L;
// Write optimized tmpoutParamInvoiceMainFilesElement.AttrInvoiceId
tmpoutParamInvoiceMainFilesElement.AttrInvoiceId = (long?) 0L;
tmpoutParamInvoiceMainFilesElement.AttrFilename = outParamInvoiceMainFiles.CurrentRec.ssFilename;
// Write optimized tmpoutParamInvoiceMainFilesElement.AttrIsExtra
tmpoutParamInvoiceMainFilesElement.AttrIsExtra = (bool?) false;
tmpoutParamInvoiceMainFilesElement.AttrStorageId = (long?) outParamInvoiceMainFiles.CurrentRec.ssStorageId;
tmpoutParamInvoiceMainFilesElement.AttrCreatedByName = outParamInvoiceMainFiles.CurrentRec.ssCreatedByName;
// Write optimized tmpoutParamInvoiceMainFilesElement.AttrCreatedBy
tmpoutParamInvoiceMainFilesElement.AttrCreatedBy = "";
tmpoutParamInvoiceMainFilesElement.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(outParamInvoiceMainFiles.CurrentRec.ssCreatedOn, conf.DateTimeFormat);
// Write optimized tmpoutParamInvoiceMainFilesElement.AttrInvoiceStatusLabel
tmpoutParamInvoiceMainFilesElement.AttrInvoiceStatusLabel = "";
// Write optimized tmpoutParamInvoiceMainFilesElement.AttrInvoiceStatusClass
tmpoutParamInvoiceMainFilesElement.AttrInvoiceStatusClass = "";
tmpoutParamInvoiceMainFilesElement.AttrSize = (long?) outParamInvoiceMainFiles.CurrentRec.ssSize;
tmpoutParamInvoiceMainFiles1List.Add(tmpoutParamInvoiceMainFilesElement);
outParamInvoiceMainFiles.Advance();
}

} finally {
outParamInvoiceMainFiles.EndIteration();
}

result.outParamInvoiceMainFiles = new RestList<ssConectaProveedores.RestRecords.RESTST_d381fba44897ce4382b17d5149465d51Structure>(tmpoutParamInvoiceMainFiles1List.ToArray(), default(ssConectaProveedores.RestRecords.RESTST_d381fba44897ce4382b17d5149465d51Structure));
}

// Write the needed fields of the list outParamInvoiceExtraFiles to the result.outParamInvoiceExtraFiles
ssConectaProveedores.RestRecords.RESTST_d381fba44897ce4382b17d5149465d51Structure tmpoutParamInvoiceExtraFilesElement;
if(outParamInvoiceExtraFiles.Empty) {
// Write the needed fields of the record outParamInvoiceExtraFiles.CurrentRec to the tmpoutParamInvoiceExtraFilesElement
tmpoutParamInvoiceExtraFilesElement = new ssConectaProveedores.RestRecords.RESTST_d381fba44897ce4382b17d5149465d51Structure();
// Write optimized tmpoutParamInvoiceExtraFilesElement.AttrId
tmpoutParamInvoiceExtraFilesElement.AttrId = (long?) 0L;
// Write optimized tmpoutParamInvoiceExtraFilesElement.AttrInvoiceId
tmpoutParamInvoiceExtraFilesElement.AttrInvoiceId = (long?) 0L;
tmpoutParamInvoiceExtraFilesElement.AttrFilename = outParamInvoiceExtraFiles.CurrentRec.ssFilename;
// Write optimized tmpoutParamInvoiceExtraFilesElement.AttrIsExtra
tmpoutParamInvoiceExtraFilesElement.AttrIsExtra = (bool?) false;
tmpoutParamInvoiceExtraFilesElement.AttrStorageId = (long?) outParamInvoiceExtraFiles.CurrentRec.ssStorageId;
tmpoutParamInvoiceExtraFilesElement.AttrCreatedByName = outParamInvoiceExtraFiles.CurrentRec.ssCreatedByName;
// Write optimized tmpoutParamInvoiceExtraFilesElement.AttrCreatedBy
tmpoutParamInvoiceExtraFilesElement.AttrCreatedBy = "";
tmpoutParamInvoiceExtraFilesElement.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(outParamInvoiceExtraFiles.CurrentRec.ssCreatedOn, conf.DateTimeFormat);
// Write optimized tmpoutParamInvoiceExtraFilesElement.AttrInvoiceStatusLabel
tmpoutParamInvoiceExtraFilesElement.AttrInvoiceStatusLabel = "";
// Write optimized tmpoutParamInvoiceExtraFilesElement.AttrInvoiceStatusClass
tmpoutParamInvoiceExtraFilesElement.AttrInvoiceStatusClass = "";
tmpoutParamInvoiceExtraFilesElement.AttrSize = (long?) outParamInvoiceExtraFiles.CurrentRec.ssSize;
result.outParamInvoiceExtraFiles = new RestList<ssConectaProveedores.RestRecords.RESTST_d381fba44897ce4382b17d5149465d51Structure>(new ssConectaProveedores.RestRecords.RESTST_d381fba44897ce4382b17d5149465d51Structure[] {}, tmpoutParamInvoiceExtraFilesElement);
} else {
List<ssConectaProveedores.RestRecords.RESTST_d381fba44897ce4382b17d5149465d51Structure>
 tmpoutParamInvoiceExtraFiles1List = new List<ssConectaProveedores.RestRecords.RESTST_d381fba44897ce4382b17d5149465d51Structure>
();
try {outParamInvoiceExtraFiles.StartIteration();
while (!(outParamInvoiceExtraFiles.Eof)) {
// Write the needed fields of the record outParamInvoiceExtraFiles.CurrentRec to the tmpoutParamInvoiceExtraFilesElement
tmpoutParamInvoiceExtraFilesElement = new ssConectaProveedores.RestRecords.RESTST_d381fba44897ce4382b17d5149465d51Structure();
// Write optimized tmpoutParamInvoiceExtraFilesElement.AttrId
tmpoutParamInvoiceExtraFilesElement.AttrId = (long?) 0L;
// Write optimized tmpoutParamInvoiceExtraFilesElement.AttrInvoiceId
tmpoutParamInvoiceExtraFilesElement.AttrInvoiceId = (long?) 0L;
tmpoutParamInvoiceExtraFilesElement.AttrFilename = outParamInvoiceExtraFiles.CurrentRec.ssFilename;
// Write optimized tmpoutParamInvoiceExtraFilesElement.AttrIsExtra
tmpoutParamInvoiceExtraFilesElement.AttrIsExtra = (bool?) false;
tmpoutParamInvoiceExtraFilesElement.AttrStorageId = (long?) outParamInvoiceExtraFiles.CurrentRec.ssStorageId;
tmpoutParamInvoiceExtraFilesElement.AttrCreatedByName = outParamInvoiceExtraFiles.CurrentRec.ssCreatedByName;
// Write optimized tmpoutParamInvoiceExtraFilesElement.AttrCreatedBy
tmpoutParamInvoiceExtraFilesElement.AttrCreatedBy = "";
tmpoutParamInvoiceExtraFilesElement.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(outParamInvoiceExtraFiles.CurrentRec.ssCreatedOn, conf.DateTimeFormat);
// Write optimized tmpoutParamInvoiceExtraFilesElement.AttrInvoiceStatusLabel
tmpoutParamInvoiceExtraFilesElement.AttrInvoiceStatusLabel = "";
// Write optimized tmpoutParamInvoiceExtraFilesElement.AttrInvoiceStatusClass
tmpoutParamInvoiceExtraFilesElement.AttrInvoiceStatusClass = "";
tmpoutParamInvoiceExtraFilesElement.AttrSize = (long?) outParamInvoiceExtraFiles.CurrentRec.ssSize;
tmpoutParamInvoiceExtraFiles1List.Add(tmpoutParamInvoiceExtraFilesElement);
outParamInvoiceExtraFiles.Advance();
}

} finally {
outParamInvoiceExtraFiles.EndIteration();
}

result.outParamInvoiceExtraFiles = new RestList<ssConectaProveedores.RestRecords.RESTST_d381fba44897ce4382b17d5149465d51Structure>(tmpoutParamInvoiceExtraFiles1List.ToArray(), default(ssConectaProveedores.RestRecords.RESTST_d381fba44897ce4382b17d5149465d51Structure));
}

result.outParamIsConstruction = (bool?) outParamIsConstruction;
// Write optimized result.outParamFolioStatusId
result.outParamFolioStatusId = (int?) 0;
// Write optimized result.outParamCanSupplierChange
result.outParamCanSupplierChange = (bool?) false;
result.outParamInvoiceID = (long?) outParamInvoiceID;
// Write the needed fields of the record outParamFolio to the result.outParamFolio
result.outParamFolio = new ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord();
result.outParamFolio.AttrId = (long?) outParamFolio.ssId;
result.outParamFolio.AttrIsDraft = (bool?) outParamFolio.ssIsDraft;
result.outParamFolio.AttrFolioNumber = outParamFolio.ssFolioNumber;
result.outParamFolio.AttrCanProveedorCancel = (bool?) outParamFolio.ssCanProveedorCancel;
result.outParamFolio.AttrOrderId = (long?) outParamFolio.ssOrderId;
result.outParamFolio.AttrSupplierId = (long?) outParamFolio.ssSupplierId;
result.outParamFolio.AttrCompanyId = (long?) outParamFolio.ssCompanyId;
result.outParamFolio.AttrFolioStatusId = (int?) outParamFolio.ssFolioStatusId;
result.outParamFolio.AttrTotalAmount = (decimal?) outParamFolio.ssTotalAmount;
result.outParamFolio.AttrTotalIVA_Amount = (decimal?) outParamFolio.ssTotalIVA_Amount;
result.outParamFolio.AttrPartialAmount = (decimal?) outParamFolio.ssPartialAmount;
result.outParamFolio.AttrCurrencyId = outParamFolio.ssCurrencyId;
result.outParamFolio.AttrFirstApproverUserId = outParamFolio.ssFirstApproverUserId;
result.outParamFolio.AttrApprovalProcessTypeId = (int?) outParamFolio.ssApprovalProcessTypeId;
result.outParamFolio.AttrSAPEntryError = outParamFolio.ssSAPEntryError;
result.outParamFolio.AttrCreatedBy = outParamFolio.ssCreatedBy;
result.outParamFolio.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(outParamFolio.ssCreatedOn, conf.DateTimeFormat);
result.outParamFolio.AttrUpdatedBy = outParamFolio.ssUpdatedBy;
result.outParamFolio.AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(outParamFolio.ssUpdatedOn, conf.DateTimeFormat);
result.outParamFolio.AttrMinuteSelected = (int?) outParamFolio.ssMinuteSelected;
result.outParamSupplierNumber = outParamSupplierNumber;
// Write the needed fields of the record outParamInvoice to the result.outParamInvoice
result.outParamInvoice = new ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord();
result.outParamInvoice.AttrId = (long?) outParamInvoice.ssId;
result.outParamInvoice.AttrName = outParamInvoice.ssName;
result.outParamInvoice.AttrRequisitionId = (long?) outParamInvoice.ssRequisitionId;
result.outParamInvoice.AttrFolioId = (long?) outParamInvoice.ssFolioId;
result.outParamInvoice.AttrOrderMainId = (long?) outParamInvoice.ssOrderMainId;
result.outParamInvoice.AttrCFDITypeId = (int?) outParamInvoice.ssCFDITypeId;
result.outParamInvoice.AttrTotalAmount = (decimal?) outParamInvoice.ssTotalAmount;
result.outParamInvoice.AttrCurrency = outParamInvoice.ssCurrency;
result.outParamInvoice.AttrInvoiceStatusId = (int?) outParamInvoice.ssInvoiceStatusId;
result.outParamInvoice.AttrAccountingDateTime = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(outParamInvoice.ssAccountingDateTime, conf.DateTimeFormat);
result.outParamInvoice.AttrPaymentDateTime = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(outParamInvoice.ssPaymentDateTime, conf.DateTimeFormat);
result.outParamInvoice.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(outParamInvoice.ssCreatedOn, conf.DateTimeFormat);
result.outParamInvoice.AttrCreatedBy = outParamInvoice.ssCreatedBy;
result.outParamInvoice.AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(outParamInvoice.ssUpdatedOn, conf.DateTimeFormat);
result.outParamInvoice.AttrUpdatedBy = outParamInvoice.ssUpdatedBy;
result.outParamInvoice.AttrSubmittedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(outParamInvoice.ssSubmittedOn, conf.DateTimeFormat);
result.outParamInvoice.AttrIsNewVersion = (bool?) outParamInvoice.ssIsNewVersion;
result.outParamInvoice.AttrID_POLIZA = outParamInvoice.ssID_POLIZA;
result.outParamInvoice.AttrID_POLIZA_SAP = outParamInvoice.ssID_POLIZA_SAP;
result.outParamInvoice.AttrDoc51 = outParamInvoice.ssDoc51;
result.outParamInvoice.AttrAccountingError = outParamInvoice.ssAccountingError;
result.outParamInvoice.AttrOrderAccConceptsID = (long?) outParamInvoice.ssOrderAccConceptsID;
result.outParamInvoice.AttrAmortization = (decimal?) outParamInvoice.ssAmortization;
result.outParamInvoice.AttrCreditNoteInvoiceId = (long?) outParamInvoice.ssCreditNoteInvoiceId;
result.outParamFilesForDownload = outParamFilesForDownload;
return result;
}


    public static ConectaProveedores_j_FoliosSAE_Wb_FolioFilesPreview_DataActionGetFolioFiles2_Model ToModel(RESTConectaProveedores_j_FoliosSAE_Wb_FolioFilesPreview_DataActionGetFolioFiles2_Outputs variables) {ConectaProveedores_j_FoliosSAE_Wb_FolioFilesPreview_DataActionGetFolioFiles2_Model result = new ConectaProveedores_j_FoliosSAE_Wb_FolioFilesPreview_DataActionGetFolioFiles2_Model();
result.outParamFolioMainFiles = variables == null ? new RL_89dfc296578aaa53d7fbc0b8af34fb54() : RL_89dfc296578aaa53d7fbc0b8af34fb54.FromRestList(variables.outParamFolioMainFiles, ssConectaProveedores.RestRecords.RESTST_a23a10e9592e51ca9ffbbbc42c558496Structure.ToStructure);
result.outParamFolioExtraFiles = variables == null ? new RL_89dfc296578aaa53d7fbc0b8af34fb54() : RL_89dfc296578aaa53d7fbc0b8af34fb54.FromRestList(variables.outParamFolioExtraFiles, ssConectaProveedores.RestRecords.RESTST_a23a10e9592e51ca9ffbbbc42c558496Structure.ToStructure);
result.outParamInvoiceMainFiles = variables == null ? new RL_cc11123f1ba1bfd417e2f33be28138e9() : RL_cc11123f1ba1bfd417e2f33be28138e9.FromRestList(variables.outParamInvoiceMainFiles, ssConectaProveedores.RestRecords.RESTST_d381fba44897ce4382b17d5149465d51Structure.ToStructure);
result.outParamInvoiceExtraFiles = variables == null ? new RL_cc11123f1ba1bfd417e2f33be28138e9() : RL_cc11123f1ba1bfd417e2f33be28138e9.FromRestList(variables.outParamInvoiceExtraFiles, ssConectaProveedores.RestRecords.RESTST_d381fba44897ce4382b17d5149465d51Structure.ToStructure);
result.outParamIsConstruction = variables == null || variables.outParamIsConstruction == null ? false : variables.outParamIsConstruction.Value;
result.outParamFolioStatusId = variables == null || variables.outParamFolioStatusId == null ? 0 : variables.outParamFolioStatusId.Value;
result.outParamCanSupplierChange = variables == null || variables.outParamCanSupplierChange == null ? false : variables.outParamCanSupplierChange.Value;
result.outParamInvoiceID = variables == null || variables.outParamInvoiceID == null ? 0L : variables.outParamInvoiceID.Value;
result.outParamFolio = variables == null ? new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord() : ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.ToStructure(variables.outParamFolio);
result.outParamSupplierNumber = variables == null || variables.outParamSupplierNumber == null ? "" : variables.outParamSupplierNumber;
result.outParamInvoice = variables == null ? new EN_d1d0320db36efbb094ad0082361435a0EntityRecord() : ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(variables.outParamInvoice);
result.outParamFilesForDownload = variables == null || variables.outParamFilesForDownload == null ? "" : variables.outParamFilesForDownload;
return result;
}


    public static RESTConectaProveedores_j_FoliosSAE_Wb_FolioFilesPreview_DataActionGetFolioFiles2_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_j_FoliosSAE_Wb_FolioFilesPreview_DataActionGetFolioFiles2_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_j_FoliosSAE_Wb_FolioFilesPreview_DataActionGetFolioFiles2_Outputs result = new RESTConectaProveedores_j_FoliosSAE_Wb_FolioFilesPreview_DataActionGetFolioFiles2_Outputs();
result.outParamFolioMainFiles = screenModel.outParamFolioMainFiles.ToRestList<ssConectaProveedores.RestRecords.RESTST_a23a10e9592e51ca9ffbbbc42c558496Structure>(ssConectaProveedores.RestRecords.RESTST_a23a10e9592e51ca9ffbbbc42c558496Structure.FromStructureDelegate(conf));
result.outParamFolioExtraFiles = screenModel.outParamFolioExtraFiles.ToRestList<ssConectaProveedores.RestRecords.RESTST_a23a10e9592e51ca9ffbbbc42c558496Structure>(ssConectaProveedores.RestRecords.RESTST_a23a10e9592e51ca9ffbbbc42c558496Structure.FromStructureDelegate(conf));
result.outParamInvoiceMainFiles = screenModel.outParamInvoiceMainFiles.ToRestList<ssConectaProveedores.RestRecords.RESTST_d381fba44897ce4382b17d5149465d51Structure>(ssConectaProveedores.RestRecords.RESTST_d381fba44897ce4382b17d5149465d51Structure.FromStructureDelegate(conf));
result.outParamInvoiceExtraFiles = screenModel.outParamInvoiceExtraFiles.ToRestList<ssConectaProveedores.RestRecords.RESTST_d381fba44897ce4382b17d5149465d51Structure>(ssConectaProveedores.RestRecords.RESTST_d381fba44897ce4382b17d5149465d51Structure.FromStructureDelegate(conf));
result.outParamIsConstruction = (bool?) screenModel.outParamIsConstruction;
result.outParamFolioStatusId = (int?) screenModel.outParamFolioStatusId;
result.outParamCanSupplierChange = (bool?) screenModel.outParamCanSupplierChange;
result.outParamInvoiceID = (long?) screenModel.outParamInvoiceID;
result.outParamFolio = ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure(screenModel.outParamFolio, conf);
result.outParamSupplierNumber = screenModel.outParamSupplierNumber;
result.outParamInvoice = ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure(screenModel.outParamInvoice, conf);
result.outParamFilesForDownload = screenModel.outParamFilesForDownload;
return result;
}

}
