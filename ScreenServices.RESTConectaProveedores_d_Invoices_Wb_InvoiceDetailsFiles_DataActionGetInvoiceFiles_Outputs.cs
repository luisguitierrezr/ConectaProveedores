using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_d_Invoices_Wb_InvoiceDetailsFiles_DataActionGetInvoiceFiles_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("MainFiles")]
public RestList<ssConectaProveedores.RestRecords.RESTRC_7cb091de697d14a1ce465208aa77fcb0> outParamMainFiles;
[JsonProperty("ExtraFiles")]
public RestList<ssConectaProveedores.RestRecords.RESTRC_7cb091de697d14a1ce465208aa77fcb0> outParamExtraFiles;


    public static RESTConectaProveedores_d_Invoices_Wb_InvoiceDetailsFiles_DataActionGetInvoiceFiles_Outputs FromOutputs(IBehaviorsConfiguration conf, RL_e40371698c3bd2f83f525cf47c117634 outParamMainFiles, RL_e40371698c3bd2f83f525cf47c117634 outParamExtraFiles) {RESTConectaProveedores_d_Invoices_Wb_InvoiceDetailsFiles_DataActionGetInvoiceFiles_Outputs result = new RESTConectaProveedores_d_Invoices_Wb_InvoiceDetailsFiles_DataActionGetInvoiceFiles_Outputs();
// Write the needed fields of the list outParamMainFiles to the result.outParamMainFiles
ssConectaProveedores.RestRecords.RESTRC_7cb091de697d14a1ce465208aa77fcb0 tmpoutParamMainFilesElement;
if(outParamMainFiles.Empty) {
// Write the needed fields of the record outParamMainFiles.CurrentRec to the tmpoutParamMainFilesElement
tmpoutParamMainFilesElement = new ssConectaProveedores.RestRecords.RESTRC_7cb091de697d14a1ce465208aa77fcb0();
// Write the needed fields of the record outParamMainFiles.CurrentRec.ssENInvoiceFile to the tmpoutParamMainFilesElement.AttrInvoiceFile
tmpoutParamMainFilesElement.AttrInvoiceFile = new ssConectaProveedores.RestRecords.RESTEN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord();
// Write optimized tmpoutParamMainFilesElement.AttrInvoiceFile.AttrId
tmpoutParamMainFilesElement.AttrInvoiceFile.AttrId = (long?) 0L;
// Write optimized tmpoutParamMainFilesElement.AttrInvoiceFile.AttrInvoiceId
tmpoutParamMainFilesElement.AttrInvoiceFile.AttrInvoiceId = (long?) 0L;
tmpoutParamMainFilesElement.AttrInvoiceFile.AttrFilename = outParamMainFiles.CurrentRec.ssENInvoiceFile.ssFilename;
// Write optimized tmpoutParamMainFilesElement.AttrInvoiceFile.AttrIsExtra
tmpoutParamMainFilesElement.AttrInvoiceFile.AttrIsExtra = (bool?) false;
// Write optimized tmpoutParamMainFilesElement.AttrInvoiceFile.AttrIsReport
tmpoutParamMainFilesElement.AttrInvoiceFile.AttrIsReport = (bool?) false;
tmpoutParamMainFilesElement.AttrInvoiceFile.AttrStorageId = (long?) outParamMainFiles.CurrentRec.ssENInvoiceFile.ssStorageId;
// Write optimized tmpoutParamMainFilesElement.AttrInvoiceFile.AttrCreatedBy
tmpoutParamMainFilesElement.AttrInvoiceFile.AttrCreatedBy = "";
// Write optimized tmpoutParamMainFilesElement.AttrInvoiceFile.AttrCreatedOn
tmpoutParamMainFilesElement.AttrInvoiceFile.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write the needed fields of the record outParamMainFiles.CurrentRec.ssENStorage to the tmpoutParamMainFilesElement.AttrStorage
tmpoutParamMainFilesElement.AttrStorage = new ssConectaProveedores.RestRecords.RESTEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord();
tmpoutParamMainFilesElement.AttrStorage.AttrId = (long?) outParamMainFiles.CurrentRec.ssENStorage.ssId;
// Write optimized tmpoutParamMainFilesElement.AttrStorage.AttrConcept
tmpoutParamMainFilesElement.AttrStorage.AttrConcept = "";
// Write optimized tmpoutParamMainFilesElement.AttrStorage.AttrInternalConceptId
tmpoutParamMainFilesElement.AttrStorage.AttrInternalConceptId = (int?) 0;
// Write optimized tmpoutParamMainFilesElement.AttrStorage.AttrFile
tmpoutParamMainFilesElement.AttrStorage.AttrFile = new byte[] {};
// Write optimized tmpoutParamMainFilesElement.AttrStorage.AttrFilename
tmpoutParamMainFilesElement.AttrStorage.AttrFilename = "";
// Write optimized tmpoutParamMainFilesElement.AttrStorage.AttrVendor
tmpoutParamMainFilesElement.AttrStorage.AttrVendor = "";
// Write optimized tmpoutParamMainFilesElement.AttrStorage.AttrDoc_Type
tmpoutParamMainFilesElement.AttrStorage.AttrDoc_Type = "";
// Write optimized tmpoutParamMainFilesElement.AttrStorage.AttrObject_type
tmpoutParamMainFilesElement.AttrStorage.AttrObject_type = "";
// Write optimized tmpoutParamMainFilesElement.AttrStorage.AttrIstoSendToExternal
tmpoutParamMainFilesElement.AttrStorage.AttrIstoSendToExternal = (bool?) false;
// Write optimized tmpoutParamMainFilesElement.AttrStorage.AttrWithEntegrationError
tmpoutParamMainFilesElement.AttrStorage.AttrWithEntegrationError = (bool?) false;
// Write optimized tmpoutParamMainFilesElement.AttrStorage.AttrIsExternal
tmpoutParamMainFilesElement.AttrStorage.AttrIsExternal = (bool?) false;
// Write optimized tmpoutParamMainFilesElement.AttrStorage.AttrArchive_ID
tmpoutParamMainFilesElement.AttrStorage.AttrArchive_ID = "";
// Write optimized tmpoutParamMainFilesElement.AttrStorage.AttrArc_Doc_ID
tmpoutParamMainFilesElement.AttrStorage.AttrArc_Doc_ID = "";
// Write optimized tmpoutParamMainFilesElement.AttrStorage.AttrError_Message
tmpoutParamMainFilesElement.AttrStorage.AttrError_Message = "";
// Write optimized tmpoutParamMainFilesElement.AttrStorage.AttrSentWhen
tmpoutParamMainFilesElement.AttrStorage.AttrSentWhen = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamMainFilesElement.AttrStorage.AttrIsToDelete
tmpoutParamMainFilesElement.AttrStorage.AttrIsToDelete = (bool?) false;
// Write optimized tmpoutParamMainFilesElement.AttrStorage.AttrIsToBig
tmpoutParamMainFilesElement.AttrStorage.AttrIsToBig = (bool?) false;
// Write optimized tmpoutParamMainFilesElement.AttrStorage.AttrAttempt
tmpoutParamMainFilesElement.AttrStorage.AttrAttempt = (int?) 0;
tmpoutParamMainFilesElement.AttrStorage.AttrSize = (long?) outParamMainFiles.CurrentRec.ssENStorage.ssSize;
// Write optimized tmpoutParamMainFilesElement.AttrStorage.AttrCreateAt
tmpoutParamMainFilesElement.AttrStorage.AttrCreateAt = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
result.outParamMainFiles = new RestList<ssConectaProveedores.RestRecords.RESTRC_7cb091de697d14a1ce465208aa77fcb0>(new ssConectaProveedores.RestRecords.RESTRC_7cb091de697d14a1ce465208aa77fcb0[] {}, tmpoutParamMainFilesElement);
} else {
List<ssConectaProveedores.RestRecords.RESTRC_7cb091de697d14a1ce465208aa77fcb0>
 tmpoutParamMainFiles1List = new List<ssConectaProveedores.RestRecords.RESTRC_7cb091de697d14a1ce465208aa77fcb0>
();
try {outParamMainFiles.StartIteration();
while (!(outParamMainFiles.Eof)) {
// Write the needed fields of the record outParamMainFiles.CurrentRec to the tmpoutParamMainFilesElement
tmpoutParamMainFilesElement = new ssConectaProveedores.RestRecords.RESTRC_7cb091de697d14a1ce465208aa77fcb0();
// Write the needed fields of the record outParamMainFiles.CurrentRec.ssENInvoiceFile to the tmpoutParamMainFilesElement.AttrInvoiceFile
tmpoutParamMainFilesElement.AttrInvoiceFile = new ssConectaProveedores.RestRecords.RESTEN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord();
// Write optimized tmpoutParamMainFilesElement.AttrInvoiceFile.AttrId
tmpoutParamMainFilesElement.AttrInvoiceFile.AttrId = (long?) 0L;
// Write optimized tmpoutParamMainFilesElement.AttrInvoiceFile.AttrInvoiceId
tmpoutParamMainFilesElement.AttrInvoiceFile.AttrInvoiceId = (long?) 0L;
tmpoutParamMainFilesElement.AttrInvoiceFile.AttrFilename = outParamMainFiles.CurrentRec.ssENInvoiceFile.ssFilename;
// Write optimized tmpoutParamMainFilesElement.AttrInvoiceFile.AttrIsExtra
tmpoutParamMainFilesElement.AttrInvoiceFile.AttrIsExtra = (bool?) false;
// Write optimized tmpoutParamMainFilesElement.AttrInvoiceFile.AttrIsReport
tmpoutParamMainFilesElement.AttrInvoiceFile.AttrIsReport = (bool?) false;
tmpoutParamMainFilesElement.AttrInvoiceFile.AttrStorageId = (long?) outParamMainFiles.CurrentRec.ssENInvoiceFile.ssStorageId;
// Write optimized tmpoutParamMainFilesElement.AttrInvoiceFile.AttrCreatedBy
tmpoutParamMainFilesElement.AttrInvoiceFile.AttrCreatedBy = "";
// Write optimized tmpoutParamMainFilesElement.AttrInvoiceFile.AttrCreatedOn
tmpoutParamMainFilesElement.AttrInvoiceFile.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write the needed fields of the record outParamMainFiles.CurrentRec.ssENStorage to the tmpoutParamMainFilesElement.AttrStorage
tmpoutParamMainFilesElement.AttrStorage = new ssConectaProveedores.RestRecords.RESTEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord();
tmpoutParamMainFilesElement.AttrStorage.AttrId = (long?) outParamMainFiles.CurrentRec.ssENStorage.ssId;
// Write optimized tmpoutParamMainFilesElement.AttrStorage.AttrConcept
tmpoutParamMainFilesElement.AttrStorage.AttrConcept = "";
// Write optimized tmpoutParamMainFilesElement.AttrStorage.AttrInternalConceptId
tmpoutParamMainFilesElement.AttrStorage.AttrInternalConceptId = (int?) 0;
// Write optimized tmpoutParamMainFilesElement.AttrStorage.AttrFile
tmpoutParamMainFilesElement.AttrStorage.AttrFile = new byte[] {};
// Write optimized tmpoutParamMainFilesElement.AttrStorage.AttrFilename
tmpoutParamMainFilesElement.AttrStorage.AttrFilename = "";
// Write optimized tmpoutParamMainFilesElement.AttrStorage.AttrVendor
tmpoutParamMainFilesElement.AttrStorage.AttrVendor = "";
// Write optimized tmpoutParamMainFilesElement.AttrStorage.AttrDoc_Type
tmpoutParamMainFilesElement.AttrStorage.AttrDoc_Type = "";
// Write optimized tmpoutParamMainFilesElement.AttrStorage.AttrObject_type
tmpoutParamMainFilesElement.AttrStorage.AttrObject_type = "";
// Write optimized tmpoutParamMainFilesElement.AttrStorage.AttrIstoSendToExternal
tmpoutParamMainFilesElement.AttrStorage.AttrIstoSendToExternal = (bool?) false;
// Write optimized tmpoutParamMainFilesElement.AttrStorage.AttrWithEntegrationError
tmpoutParamMainFilesElement.AttrStorage.AttrWithEntegrationError = (bool?) false;
// Write optimized tmpoutParamMainFilesElement.AttrStorage.AttrIsExternal
tmpoutParamMainFilesElement.AttrStorage.AttrIsExternal = (bool?) false;
// Write optimized tmpoutParamMainFilesElement.AttrStorage.AttrArchive_ID
tmpoutParamMainFilesElement.AttrStorage.AttrArchive_ID = "";
// Write optimized tmpoutParamMainFilesElement.AttrStorage.AttrArc_Doc_ID
tmpoutParamMainFilesElement.AttrStorage.AttrArc_Doc_ID = "";
// Write optimized tmpoutParamMainFilesElement.AttrStorage.AttrError_Message
tmpoutParamMainFilesElement.AttrStorage.AttrError_Message = "";
// Write optimized tmpoutParamMainFilesElement.AttrStorage.AttrSentWhen
tmpoutParamMainFilesElement.AttrStorage.AttrSentWhen = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamMainFilesElement.AttrStorage.AttrIsToDelete
tmpoutParamMainFilesElement.AttrStorage.AttrIsToDelete = (bool?) false;
// Write optimized tmpoutParamMainFilesElement.AttrStorage.AttrIsToBig
tmpoutParamMainFilesElement.AttrStorage.AttrIsToBig = (bool?) false;
// Write optimized tmpoutParamMainFilesElement.AttrStorage.AttrAttempt
tmpoutParamMainFilesElement.AttrStorage.AttrAttempt = (int?) 0;
tmpoutParamMainFilesElement.AttrStorage.AttrSize = (long?) outParamMainFiles.CurrentRec.ssENStorage.ssSize;
// Write optimized tmpoutParamMainFilesElement.AttrStorage.AttrCreateAt
tmpoutParamMainFilesElement.AttrStorage.AttrCreateAt = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
tmpoutParamMainFiles1List.Add(tmpoutParamMainFilesElement);
outParamMainFiles.Advance();
}

} finally {
outParamMainFiles.EndIteration();
}

result.outParamMainFiles = new RestList<ssConectaProveedores.RestRecords.RESTRC_7cb091de697d14a1ce465208aa77fcb0>(tmpoutParamMainFiles1List.ToArray(), default(ssConectaProveedores.RestRecords.RESTRC_7cb091de697d14a1ce465208aa77fcb0));
}

// Write the needed fields of the list outParamExtraFiles to the result.outParamExtraFiles
ssConectaProveedores.RestRecords.RESTRC_7cb091de697d14a1ce465208aa77fcb0 tmpoutParamExtraFilesElement;
if(outParamExtraFiles.Empty) {
// Write the needed fields of the record outParamExtraFiles.CurrentRec to the tmpoutParamExtraFilesElement
tmpoutParamExtraFilesElement = new ssConectaProveedores.RestRecords.RESTRC_7cb091de697d14a1ce465208aa77fcb0();
// Write the needed fields of the record outParamExtraFiles.CurrentRec.ssENInvoiceFile to the tmpoutParamExtraFilesElement.AttrInvoiceFile
tmpoutParamExtraFilesElement.AttrInvoiceFile = new ssConectaProveedores.RestRecords.RESTEN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord();
// Write optimized tmpoutParamExtraFilesElement.AttrInvoiceFile.AttrId
tmpoutParamExtraFilesElement.AttrInvoiceFile.AttrId = (long?) 0L;
// Write optimized tmpoutParamExtraFilesElement.AttrInvoiceFile.AttrInvoiceId
tmpoutParamExtraFilesElement.AttrInvoiceFile.AttrInvoiceId = (long?) 0L;
tmpoutParamExtraFilesElement.AttrInvoiceFile.AttrFilename = outParamExtraFiles.CurrentRec.ssENInvoiceFile.ssFilename;
// Write optimized tmpoutParamExtraFilesElement.AttrInvoiceFile.AttrIsExtra
tmpoutParamExtraFilesElement.AttrInvoiceFile.AttrIsExtra = (bool?) false;
// Write optimized tmpoutParamExtraFilesElement.AttrInvoiceFile.AttrIsReport
tmpoutParamExtraFilesElement.AttrInvoiceFile.AttrIsReport = (bool?) false;
tmpoutParamExtraFilesElement.AttrInvoiceFile.AttrStorageId = (long?) outParamExtraFiles.CurrentRec.ssENInvoiceFile.ssStorageId;
// Write optimized tmpoutParamExtraFilesElement.AttrInvoiceFile.AttrCreatedBy
tmpoutParamExtraFilesElement.AttrInvoiceFile.AttrCreatedBy = "";
// Write optimized tmpoutParamExtraFilesElement.AttrInvoiceFile.AttrCreatedOn
tmpoutParamExtraFilesElement.AttrInvoiceFile.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write the needed fields of the record outParamExtraFiles.CurrentRec.ssENStorage to the tmpoutParamExtraFilesElement.AttrStorage
tmpoutParamExtraFilesElement.AttrStorage = new ssConectaProveedores.RestRecords.RESTEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord();
// Write optimized tmpoutParamExtraFilesElement.AttrStorage.AttrId
tmpoutParamExtraFilesElement.AttrStorage.AttrId = (long?) 0L;
// Write optimized tmpoutParamExtraFilesElement.AttrStorage.AttrConcept
tmpoutParamExtraFilesElement.AttrStorage.AttrConcept = "";
// Write optimized tmpoutParamExtraFilesElement.AttrStorage.AttrInternalConceptId
tmpoutParamExtraFilesElement.AttrStorage.AttrInternalConceptId = (int?) 0;
// Write optimized tmpoutParamExtraFilesElement.AttrStorage.AttrFile
tmpoutParamExtraFilesElement.AttrStorage.AttrFile = new byte[] {};
// Write optimized tmpoutParamExtraFilesElement.AttrStorage.AttrFilename
tmpoutParamExtraFilesElement.AttrStorage.AttrFilename = "";
// Write optimized tmpoutParamExtraFilesElement.AttrStorage.AttrVendor
tmpoutParamExtraFilesElement.AttrStorage.AttrVendor = "";
// Write optimized tmpoutParamExtraFilesElement.AttrStorage.AttrDoc_Type
tmpoutParamExtraFilesElement.AttrStorage.AttrDoc_Type = "";
// Write optimized tmpoutParamExtraFilesElement.AttrStorage.AttrObject_type
tmpoutParamExtraFilesElement.AttrStorage.AttrObject_type = "";
// Write optimized tmpoutParamExtraFilesElement.AttrStorage.AttrIstoSendToExternal
tmpoutParamExtraFilesElement.AttrStorage.AttrIstoSendToExternal = (bool?) false;
// Write optimized tmpoutParamExtraFilesElement.AttrStorage.AttrWithEntegrationError
tmpoutParamExtraFilesElement.AttrStorage.AttrWithEntegrationError = (bool?) false;
// Write optimized tmpoutParamExtraFilesElement.AttrStorage.AttrIsExternal
tmpoutParamExtraFilesElement.AttrStorage.AttrIsExternal = (bool?) false;
// Write optimized tmpoutParamExtraFilesElement.AttrStorage.AttrArchive_ID
tmpoutParamExtraFilesElement.AttrStorage.AttrArchive_ID = "";
// Write optimized tmpoutParamExtraFilesElement.AttrStorage.AttrArc_Doc_ID
tmpoutParamExtraFilesElement.AttrStorage.AttrArc_Doc_ID = "";
// Write optimized tmpoutParamExtraFilesElement.AttrStorage.AttrError_Message
tmpoutParamExtraFilesElement.AttrStorage.AttrError_Message = "";
// Write optimized tmpoutParamExtraFilesElement.AttrStorage.AttrSentWhen
tmpoutParamExtraFilesElement.AttrStorage.AttrSentWhen = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamExtraFilesElement.AttrStorage.AttrIsToDelete
tmpoutParamExtraFilesElement.AttrStorage.AttrIsToDelete = (bool?) false;
// Write optimized tmpoutParamExtraFilesElement.AttrStorage.AttrIsToBig
tmpoutParamExtraFilesElement.AttrStorage.AttrIsToBig = (bool?) false;
// Write optimized tmpoutParamExtraFilesElement.AttrStorage.AttrAttempt
tmpoutParamExtraFilesElement.AttrStorage.AttrAttempt = (int?) 0;
tmpoutParamExtraFilesElement.AttrStorage.AttrSize = (long?) outParamExtraFiles.CurrentRec.ssENStorage.ssSize;
// Write optimized tmpoutParamExtraFilesElement.AttrStorage.AttrCreateAt
tmpoutParamExtraFilesElement.AttrStorage.AttrCreateAt = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
result.outParamExtraFiles = new RestList<ssConectaProveedores.RestRecords.RESTRC_7cb091de697d14a1ce465208aa77fcb0>(new ssConectaProveedores.RestRecords.RESTRC_7cb091de697d14a1ce465208aa77fcb0[] {}, tmpoutParamExtraFilesElement);
} else {
List<ssConectaProveedores.RestRecords.RESTRC_7cb091de697d14a1ce465208aa77fcb0>
 tmpoutParamExtraFiles1List = new List<ssConectaProveedores.RestRecords.RESTRC_7cb091de697d14a1ce465208aa77fcb0>
();
try {outParamExtraFiles.StartIteration();
while (!(outParamExtraFiles.Eof)) {
// Write the needed fields of the record outParamExtraFiles.CurrentRec to the tmpoutParamExtraFilesElement
tmpoutParamExtraFilesElement = new ssConectaProveedores.RestRecords.RESTRC_7cb091de697d14a1ce465208aa77fcb0();
// Write the needed fields of the record outParamExtraFiles.CurrentRec.ssENInvoiceFile to the tmpoutParamExtraFilesElement.AttrInvoiceFile
tmpoutParamExtraFilesElement.AttrInvoiceFile = new ssConectaProveedores.RestRecords.RESTEN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord();
// Write optimized tmpoutParamExtraFilesElement.AttrInvoiceFile.AttrId
tmpoutParamExtraFilesElement.AttrInvoiceFile.AttrId = (long?) 0L;
// Write optimized tmpoutParamExtraFilesElement.AttrInvoiceFile.AttrInvoiceId
tmpoutParamExtraFilesElement.AttrInvoiceFile.AttrInvoiceId = (long?) 0L;
tmpoutParamExtraFilesElement.AttrInvoiceFile.AttrFilename = outParamExtraFiles.CurrentRec.ssENInvoiceFile.ssFilename;
// Write optimized tmpoutParamExtraFilesElement.AttrInvoiceFile.AttrIsExtra
tmpoutParamExtraFilesElement.AttrInvoiceFile.AttrIsExtra = (bool?) false;
// Write optimized tmpoutParamExtraFilesElement.AttrInvoiceFile.AttrIsReport
tmpoutParamExtraFilesElement.AttrInvoiceFile.AttrIsReport = (bool?) false;
tmpoutParamExtraFilesElement.AttrInvoiceFile.AttrStorageId = (long?) outParamExtraFiles.CurrentRec.ssENInvoiceFile.ssStorageId;
// Write optimized tmpoutParamExtraFilesElement.AttrInvoiceFile.AttrCreatedBy
tmpoutParamExtraFilesElement.AttrInvoiceFile.AttrCreatedBy = "";
// Write optimized tmpoutParamExtraFilesElement.AttrInvoiceFile.AttrCreatedOn
tmpoutParamExtraFilesElement.AttrInvoiceFile.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write the needed fields of the record outParamExtraFiles.CurrentRec.ssENStorage to the tmpoutParamExtraFilesElement.AttrStorage
tmpoutParamExtraFilesElement.AttrStorage = new ssConectaProveedores.RestRecords.RESTEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord();
// Write optimized tmpoutParamExtraFilesElement.AttrStorage.AttrId
tmpoutParamExtraFilesElement.AttrStorage.AttrId = (long?) 0L;
// Write optimized tmpoutParamExtraFilesElement.AttrStorage.AttrConcept
tmpoutParamExtraFilesElement.AttrStorage.AttrConcept = "";
// Write optimized tmpoutParamExtraFilesElement.AttrStorage.AttrInternalConceptId
tmpoutParamExtraFilesElement.AttrStorage.AttrInternalConceptId = (int?) 0;
// Write optimized tmpoutParamExtraFilesElement.AttrStorage.AttrFile
tmpoutParamExtraFilesElement.AttrStorage.AttrFile = new byte[] {};
// Write optimized tmpoutParamExtraFilesElement.AttrStorage.AttrFilename
tmpoutParamExtraFilesElement.AttrStorage.AttrFilename = "";
// Write optimized tmpoutParamExtraFilesElement.AttrStorage.AttrVendor
tmpoutParamExtraFilesElement.AttrStorage.AttrVendor = "";
// Write optimized tmpoutParamExtraFilesElement.AttrStorage.AttrDoc_Type
tmpoutParamExtraFilesElement.AttrStorage.AttrDoc_Type = "";
// Write optimized tmpoutParamExtraFilesElement.AttrStorage.AttrObject_type
tmpoutParamExtraFilesElement.AttrStorage.AttrObject_type = "";
// Write optimized tmpoutParamExtraFilesElement.AttrStorage.AttrIstoSendToExternal
tmpoutParamExtraFilesElement.AttrStorage.AttrIstoSendToExternal = (bool?) false;
// Write optimized tmpoutParamExtraFilesElement.AttrStorage.AttrWithEntegrationError
tmpoutParamExtraFilesElement.AttrStorage.AttrWithEntegrationError = (bool?) false;
// Write optimized tmpoutParamExtraFilesElement.AttrStorage.AttrIsExternal
tmpoutParamExtraFilesElement.AttrStorage.AttrIsExternal = (bool?) false;
// Write optimized tmpoutParamExtraFilesElement.AttrStorage.AttrArchive_ID
tmpoutParamExtraFilesElement.AttrStorage.AttrArchive_ID = "";
// Write optimized tmpoutParamExtraFilesElement.AttrStorage.AttrArc_Doc_ID
tmpoutParamExtraFilesElement.AttrStorage.AttrArc_Doc_ID = "";
// Write optimized tmpoutParamExtraFilesElement.AttrStorage.AttrError_Message
tmpoutParamExtraFilesElement.AttrStorage.AttrError_Message = "";
// Write optimized tmpoutParamExtraFilesElement.AttrStorage.AttrSentWhen
tmpoutParamExtraFilesElement.AttrStorage.AttrSentWhen = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamExtraFilesElement.AttrStorage.AttrIsToDelete
tmpoutParamExtraFilesElement.AttrStorage.AttrIsToDelete = (bool?) false;
// Write optimized tmpoutParamExtraFilesElement.AttrStorage.AttrIsToBig
tmpoutParamExtraFilesElement.AttrStorage.AttrIsToBig = (bool?) false;
// Write optimized tmpoutParamExtraFilesElement.AttrStorage.AttrAttempt
tmpoutParamExtraFilesElement.AttrStorage.AttrAttempt = (int?) 0;
tmpoutParamExtraFilesElement.AttrStorage.AttrSize = (long?) outParamExtraFiles.CurrentRec.ssENStorage.ssSize;
// Write optimized tmpoutParamExtraFilesElement.AttrStorage.AttrCreateAt
tmpoutParamExtraFilesElement.AttrStorage.AttrCreateAt = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
tmpoutParamExtraFiles1List.Add(tmpoutParamExtraFilesElement);
outParamExtraFiles.Advance();
}

} finally {
outParamExtraFiles.EndIteration();
}

result.outParamExtraFiles = new RestList<ssConectaProveedores.RestRecords.RESTRC_7cb091de697d14a1ce465208aa77fcb0>(tmpoutParamExtraFiles1List.ToArray(), default(ssConectaProveedores.RestRecords.RESTRC_7cb091de697d14a1ce465208aa77fcb0));
}

return result;
}


    public static ConectaProveedores_d_Invoices_Wb_InvoiceDetailsFiles_DataActionGetInvoiceFiles_Model ToModel(RESTConectaProveedores_d_Invoices_Wb_InvoiceDetailsFiles_DataActionGetInvoiceFiles_Outputs variables) {ConectaProveedores_d_Invoices_Wb_InvoiceDetailsFiles_DataActionGetInvoiceFiles_Model result = new ConectaProveedores_d_Invoices_Wb_InvoiceDetailsFiles_DataActionGetInvoiceFiles_Model();
result.outParamMainFiles = variables == null ? new RL_e40371698c3bd2f83f525cf47c117634() : RL_e40371698c3bd2f83f525cf47c117634.FromRestList(variables.outParamMainFiles, ssConectaProveedores.RestRecords.RESTRC_7cb091de697d14a1ce465208aa77fcb0.ToStructure);
result.outParamExtraFiles = variables == null ? new RL_e40371698c3bd2f83f525cf47c117634() : RL_e40371698c3bd2f83f525cf47c117634.FromRestList(variables.outParamExtraFiles, ssConectaProveedores.RestRecords.RESTRC_7cb091de697d14a1ce465208aa77fcb0.ToStructure);
return result;
}


    public static RESTConectaProveedores_d_Invoices_Wb_InvoiceDetailsFiles_DataActionGetInvoiceFiles_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_d_Invoices_Wb_InvoiceDetailsFiles_DataActionGetInvoiceFiles_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_d_Invoices_Wb_InvoiceDetailsFiles_DataActionGetInvoiceFiles_Outputs result = new RESTConectaProveedores_d_Invoices_Wb_InvoiceDetailsFiles_DataActionGetInvoiceFiles_Outputs();
result.outParamMainFiles = screenModel.outParamMainFiles.ToRestList<ssConectaProveedores.RestRecords.RESTRC_7cb091de697d14a1ce465208aa77fcb0>(ssConectaProveedores.RestRecords.RESTRC_7cb091de697d14a1ce465208aa77fcb0.FromStructureDelegate(conf));
result.outParamExtraFiles = screenModel.outParamExtraFiles.ToRestList<ssConectaProveedores.RestRecords.RESTRC_7cb091de697d14a1ce465208aa77fcb0>(ssConectaProveedores.RestRecords.RESTRC_7cb091de697d14a1ce465208aa77fcb0.FromStructureDelegate(conf));
return result;
}

}
